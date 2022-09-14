using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Runtime.Serialization.Json;

namespace Login
{
    public class inputClient
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
    class Client
    {
        static void Main()
        {
           inputClient client = new inputClient();
            Console.WriteLine("Your Username : ");
            client.Username = Console.ReadLine();
 
            Console.WriteLine("Your Password : ");
            client.Password = Console.ReadLine();
            
            Console.Clear();
           
            Console.WriteLine(client.Username.Length + "_" + client.Username + " " + client.Password.Length + "_" + client.Password );
            string jsonString = JsonSerializer.Serialize(client);

            Console.WriteLine(jsonString);
            Console.ReadLine();
            StreamWriter sw = new StreamWriter("E:\\Semester 5\\Jarkom\\Data Login.json");
            sw.WriteLine(jsonString);
            sw.Close();

            string fileName = "E:\\Semester 5\\Jarkom\\Data Login.json";
            string json = File.ReadAllText(fileName);
            inputClient client2 = JsonSerializer.Deserialize<inputClient>(json);
            Console.WriteLine($"username: {client2.Username}");
            Console.WriteLine($"Password: {client2.Password}");
        }
    }
    
}