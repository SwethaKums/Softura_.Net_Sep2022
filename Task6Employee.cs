using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Konsole
{
    [Serializable()]
    internal class Task6Employee
    {

        public int id { get; set; }
        public string name { get; set; }

        public int age { get; set; }
        public string Gender { get; set; }

    }
    internal class Serial
    {
        
        public static void Main()
        {

            Task6Employee Employee =  new Task6Employee()
            {
                id = 001,
                name = "swetha",
                age = 22,
                Gender = "Female"
            };

            BinaryFormatter fs = new BinaryFormatter();
            Stream ss = new FileStream("Task6Employee.txt", FileMode.Create, FileAccess.Write, FileShare.None);
            fs.Serialize(ss, Employee);
            ss.Close();

            FileStream fs1 = new FileStream("Task6Employee.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter ss1 = new BinaryFormatter();


            Task6Employee Employe = (Task6Employee)ss1.Deserialize(fs1);

            Console.WriteLine("Employee Details");
            Console.WriteLine(Employe.id);
            Console.WriteLine(Employe.name);
            Console.WriteLine(Employe.age);
            Console.WriteLine(Employe.Gender);
            fs1.Close();


        }
    }

}
 