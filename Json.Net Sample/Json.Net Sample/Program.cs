using Json.Net_Sample.models;
using Newtonsoft.Json;
using System;
using System.IO;

namespace Json.Net_Sample
{
    class Program
    {
        private static string path = @"C:\Json Sample\Contacts.json";
        static void Main(string[] args)
        {
            //var contacts = GetContacts();
            //serializeJsonFile(contacts);
            var contacts = GetContactsJsonFromFile();
            DeserializeJsonFile(contacts);
        }

        #region "Writing Json"
        public static void serializeJsonFile(List<Contact> contacts)
        {
            string contactsJson = JsonConvert.SerializeObject(contacts.ToArray(), Formatting.Indented);

            File.WriteAllText(path, contactsJson);
        }
        public static List<Contact> GetContacts()
        {
            List<Contact> contacts = new List<Contact>
            {
                new Contact
                {
                    Name = "Pedro",
                    DateOfBirth = new DateTime(2005, 11, 02),
                    Address = new Address
                    {
                        Street = "Centennial Dr",
                        Number = 1,
                         City = new City
                         {
                             Name = "Capital",
                             Country = new Country { Code = "SD", Name = "Santo Domingo"}

                         }
                    },
                    Phones = new List<Phone>
                    {
                        new Phone {Name = "Personal", Number = "02978641" },
                        new Phone {Name = "Work", Number = "908762398"},
                    }
                },
                new Contact
                {
                    Name = "Marco",
                    DateOfBirth = new DateTime(2006, 10, 07),
                    Address = new Address
                    {
                        Street = "Av. Mariscal la Mar",
                        Number = 1342,
                         City = new City
                         {
                             Name = "Capital",
                             Country = new Country { Code = "PER", Name = "Peru"}

                         }
                    },
                    Phones = new List<Phone>
                    {
                        new Phone {Name = "Personal", Number = "22322978" },
                        new Phone {Name = "Work", Number = "658762"},
                    }
                },
                new Contact
                {
                    Name = "Carlo",
                    DateOfBirth = new DateTime(2000, 04, 19),
                    Address = new Address
                    {
                        Street = "Calle Dr",
                        Number = 11,
                         City = new City
                         {
                             Name = "Capital",
                             Country = new Country { Code = "SD", Name = "Santo Domingo"}

                         }
                    },
                    Phones = new List<Phone>
                    {
                        new Phone {Name = "Personal", Number = "123378641" },
                        new Phone {Name = "Work", Number = "908762398"},
                    }
                },
            };

            return contacts;
        }
        #endregion

        public static string GetContactsJsonFromFile()
        {
            string contactsJsonFromFile;
            using (var reader = new StreamReader(_path))
            {
                contactsJsonFromFile = reader.ReadToEnd();
            }
            return contactsJsonFromFile;
        }

        public static void DeserializeJsonFile(string contactsJsonFromFile)
        {
            Console.WriteLine(contactsJsonFromFile);

            var contacts = JsonConvert.DeserializeObject<List<Contact>>(contactsJsonFromFile);

            Console.WriteLine(string.Format("carlos Address is: {0} {1}", contacts[2].Address.Street, contacts[2].Address.Number));

            Console.WriteLine(string.Format("Pedro date of birth is on: {0}", contacts[0].DateOfBirth.ToShortDateString()));
        }
    }
}