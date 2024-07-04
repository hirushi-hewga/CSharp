using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_06_21___HW__Exceptions__Namespaces_
{
    struct Fullname
    {
        public string name;
        public string surname;
        public string lastname;
        public Fullname(string name, string surname, string lastname)
        {
            this.name = name;
            this.surname = surname;
            this.lastname = lastname;
        }
    }
    partial class CreditCard
    {
        private string card_number;
        private Fullname owner_full_name;
        private string cvc;
        private DateTime card_expiration_date;
        public CreditCard(string card_number, Fullname owner_full_name, string cvc, DateTime card_expiration_date)
        {
            Card_number = card_number;
            Owner_full_name = owner_full_name;
            Cvc = cvc;
            Card_expiration_date = card_expiration_date;
        }
    }
    partial class CreditCard
    {
        public string Card_number
        {
            get { return card_number; }
            set
            {
                if (value.Length != 16)
                    throw new LengthException("Length exception. Length should be 16");
                else if (!value.All(s => char.IsDigit(s)))
                    throw new FormatException("Data type exception. Number must consist of numbers");
                else card_number = value;
            }
        }
        public Fullname Owner_full_name
        {
            get { return owner_full_name; }
            set {
                if (string.IsNullOrEmpty(value.name) || string.IsNullOrEmpty(value.surname) || string.IsNullOrEmpty(value.lastname))
                    throw new ArgumentNullException("Argument null exception. Name, surname or lastname is empty");
                else owner_full_name = value;
            }
        }
        public string Cvc
        {
            get { return cvc; }
            set
            {
                if (value.Length != 3)
                    throw new LengthException("Length exception. Length should be 3");
                else if (!value.All(s => char.IsDigit(s)))
                    throw new FormatException("Data type exception. CVC must consist of numbers");
                else cvc = value;
            }
        }
        public DateTime Card_expiration_date
        {
            get { return card_expiration_date; }
            set {
                if (value <= DateTime.Now)
                    throw new InvalidValueException("Invalid value exception. Date must be greater than now");
                else card_expiration_date = value;
            }
        }
    }
}
