using System;
using System.Collections.Generic;

namespace Address
{

    class AddressBook
    {
        public Dictionary<string, Contact> addressbook { get; set; }

        public AddressBook()
        {
            addressbook = new Dictionary<string, Contact>();
        }

        public void AddContact(Contact contact)
        {
            try
            {
                addressbook.Add(contact.Email, contact);
            }
            catch
            {
                Console.WriteLine($"{contact.FullName()} is already a contact.");
            }
        }
        public Contact GetByEmail(string email)
        {
            addressbook.TryGetValue(email, out Contact contact);
            return contact;
        }
    }
}