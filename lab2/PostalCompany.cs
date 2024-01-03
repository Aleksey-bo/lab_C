using Lb2;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab2
{
    internal class PostalCompany
    {
        private static PostalCompany _instance;
        private string Name { get; set; }
        private Dictionary<string, UserCard> СlientCards { get; set; }
        private double TotalMoney { get; set; }

        private List<string> Storage;
        private string Address { get; set; }
        private string EDRPOU { get; set; }
        private decimal[] MonthlyIncome { get; set; }
        private Dictionary<string, ClientCompany> RegisteredClients { get; set; }

        public delegate void MethodMessage(object sender, HandlerMessage e);
        public event MethodMessage onMessage;

        public PostalCompany()
        {
            Name = "FastPost";
            Address = "Street 45, b. 109";
            EDRPOU = "345563456";
            Storage = new List<string>();
            СlientCards = LoadClientCardsFromFile("client_cards.txt") ?? new Dictionary<string, UserCard>();
            RegisteredClients = LoadClientsFromFile("company_clients.txt") ?? new Dictionary<string, ClientCompany>();
            MonthlyIncome = UpdateTaxArray();
        }

        public static PostalCompany Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PostalCompany();
                }
                return _instance;
            }
        }

        public void AddClientCard(UserCard clientCard)
        {
            if (!СlientCards.ContainsKey(clientCard.Id))
            {
                СlientCards.Add(clientCard.Id, clientCard);

                WriteClientCardsToFile("client_cards.txt");

                Console.WriteLine($"Нова картка зареєстрована: {clientCard.Id}");
            }
            else
            {
                Console.WriteLine($"Карта з ідентифікатором {clientCard.Id} вже існує.");
            }
        }
        private void WriteClientCardsToFile(string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var kvp in СlientCards)
                    {
                        writer.WriteLine($"{kvp.Key},{kvp.Value.Name},{kvp.Value.Email},{kvp.Value.PhoneNumber}");
                    }
                }

                Console.WriteLine("Картки збережено у файлі.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка при збереженні карток у файл: {ex.Message}");
            }
        }
        private Dictionary<string, UserCard> LoadClientCardsFromFile(string filePath)
        {
            var dictionary = new Dictionary<string, UserCard>();

            if (File.Exists(filePath))
            {
                using (var reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var parts = line.Split(',');

                        var id = parts[0];
                        var name = parts[1];
                        var email = parts[2];
                        var phoneNumber = parts[3];

                        var clientCard = new UserCard(id, name, email, phoneNumber);
                        dictionary.Add(id, clientCard);
                    }
                }
            }

            return dictionary;
        }
        public void AddCompanyClient(ClientCompany clientCompany)
        {
            if (!RegisteredClients.Values.Any(client => client.Email == clientCompany.Email))
            {
                RegisteredClients.Add(clientCompany.Id, clientCompany);

                WriteCompanyClientsToFile("company_clients.txt");

                Console.WriteLine($"Новий клієнт компанії зареєстрований: {clientCompany.Name}");
            }
            else
            {
                Console.WriteLine($"Клієнт компанії з email: {clientCompany.Email} вже існує.");

                onMessage?.Invoke(this, new HandlerMessage($"This email is already registered"));
            }
        }
        private void WriteCompanyClientsToFile(string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var kvp in RegisteredClients)
                    {
                        writer.WriteLine($"{kvp.Key},{kvp.Value.Name},{kvp.Value.Email}");
                    }
                }

                Console.WriteLine("Клієнти компанії збережено у файлі.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка при збереженні клієнтів компанії у файл: {ex.Message}");
            }
        }
        private Dictionary<string, ClientCompany> LoadClientsFromFile(string filePath)
        {
            var dictionary = new Dictionary<string, ClientCompany>();

            if (File.Exists(filePath))
            {
                using (var reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var parts = line.Split(',');

                        var id = parts[0];
                        var name = parts[1];
                        var email = parts[2];

                        var client = new ClientCompany(id, name, email);
                        dictionary.Add(id, client);
                    }
                }
            }

            return dictionary;
        }
        public bool RemoveClientCard(string id)
        {

            if (СlientCards.ContainsKey(id))
            {
                СlientCards.Remove(id);
                WriteClientCardsToFile("client_cards.txt");

                return true;
            }
            else
            {
                return false;
            }
        }
        public void WriteLogToFile(get_set_delivery delivery)
        {
            var log = delivery.ToString();
            File.AppendAllText("logs.txt", log + Environment.NewLine);
        }
        public decimal[] UpdateTaxArray()
        {
            decimal[] taxArray = new decimal[12];
            string filePath = "logs.txt";
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Файл не найден.");
                return taxArray;
            }

            string[] lines = File.ReadAllLines(filePath);

            Regex priceRegex = new Regex(@"PriceToPay: (\d+)", RegexOptions.Compiled);
            Regex dateRegex = new Regex(@"OperationDate: (\d{2}/\d{2}/\d{4})", RegexOptions.Compiled);

            foreach (string line in lines)
            {
                Match priceMatch = priceRegex.Match(line);
                Match dateMatch = dateRegex.Match(line);
                if (priceMatch.Success && dateMatch.Success)
                {
                    decimal priceToPay = decimal.Parse(priceMatch.Groups[1].Value) * 18;

                    DateTime operationDate = DateTime.ParseExact(dateMatch.Groups[1].Value, "MM/dd/yyyy", CultureInfo.InvariantCulture);

                    int month = operationDate.Month;

                    taxArray[month - 1] += priceToPay;
                }
            }

            return taxArray;
        }

        public void EventHandlerExistsClient(object sender, HandlerMessage e)
        {
            e.MessageView();
        }

        private void ClientCard_onMessage(object sender, HandlerMessage e, get_set_delivery package)
        {
            WriteLogToFile(package);
        }
    }
}
