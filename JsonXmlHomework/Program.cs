using System;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;
using System.IO;

namespace JsonXmlHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Qwerty", "1234As!", "developer@gmail.com", "+77021021213");
            User user2 = new User("Maestro", "#Piano55", "musicman80@mail.com", "+77782880808");
            User user3 = new User("mr.Smith", "Coollife88$", "smittytime@gmail.com", "+77071072727");

            User[] users = new User[] { user1, user2, user3 };
            
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(User[]));
            
            using (FileStream fs = new FileStream("people.json", FileMode.OpenOrCreate)) // папка bin -> debug
            {
                jsonFormatter.WriteObject(fs, users);

                Console.WriteLine("JSON Serialization passed successfully");
            }

            XmlSerializer xmlFormatter = new XmlSerializer(typeof(User[]));

            using (FileStream fs = new FileStream("users.xml", FileMode.OpenOrCreate)) // папка bin -> debug
            {
                xmlFormatter.Serialize(fs, users);

                Console.WriteLine("XML Serialization passed successfully");
            }
            
        }
    }
}
