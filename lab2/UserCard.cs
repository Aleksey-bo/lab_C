using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class UserCard
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Id { get; set; }
        public string PhoneNumber { get; set; }
        private BindingList<get_set_delivery> OperationHistory { get; set; }
        private BindingList<get_set_delivery> UnfinishedOperations { get; set; }

        public UserCard(string id, string name, string email, string phoneNumber)
        {
            Id = id;
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
        }
        public BindingList<get_set_delivery> GetOperationHistory()
        {
            if (OperationHistory == null)
            {
                OperationHistory = new BindingList<get_set_delivery>();
            }

            return OperationHistory;
        }

        public BindingList<get_set_delivery> GetUnfinishedOperations()
        {
            if (UnfinishedOperations == null)
            {
                UnfinishedOperations = new BindingList<get_set_delivery>();
            }

            return UnfinishedOperations;
        }

        public decimal SendPackage(get_set_delivery package)
        {
            if (OperationHistory == null)
            {
                OperationHistory = new BindingList<get_set_delivery>();
            }
            if (UnfinishedOperations == null)
            {
                UnfinishedOperations = new BindingList<get_set_delivery>();
            }

            OperationHistory.Add(package);

            if (package.IsCompleted == false)
            {
                UnfinishedOperations.Add(package);
            }

            if (package.IsPaidBySender)
            {
                return (decimal)package.PackageWeight * 0.05M + package.PriceToPay;
            }
            else
            {
                return (decimal)package.PackageWeight * 0.05M;
            }
        }

        public decimal ReceivePackage(get_set_delivery package)
        {
            decimal price = 20;

            if (OperationHistory == null)
            {
                OperationHistory = new BindingList<get_set_delivery>();
            }

            if (UnfinishedOperations == null)
            {
                UnfinishedOperations = new BindingList<get_set_delivery>();
            }

            package.IsCompleted = true;

            OperationHistory.Add(package);
            UnfinishedOperations.Remove(package);

            if (!package.IsPaidBySender)
            {
                return price += package.PriceToPay;
            }
            else
            {
                return price * 0.05M;
            }
        }
    }
}
