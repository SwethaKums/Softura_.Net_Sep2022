using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsole
{
    internal class Task6Collec
    {
        public static void Main()
        {
         Dictionary<int,string> data=new Dictionary<int,string>();
            data.Add(1, "vanila icecream");
            data.Add(2, "chocolate icecream");
            data.Add(3, "Mango icecream");
            data.Add(4, "strawberry cake");
            FileStream fs = new FileStream("C:\\softura\\Konsole\\Konsole.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter bs = new StreamWriter(fs);
            bs.BaseStream.Seek(0, SeekOrigin.End);
            foreach (object i in data)
                bs.WriteLine(i);
            bs.Flush();
            fs.Close();

            FileStream fr = new FileStream("C:\\softura\\Konsole\\Konsole.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader br = new StreamReader(fr);
            br.BaseStream.Seek(0, SeekOrigin.Begin);
            Console.WriteLine(br.ReadToEnd());
            br.Close();
            fr.Close();

            FileInfo fd = new FileInfo("C:\\softura\\Konsole\\Konsole.txt");
            Console.WriteLine("File created Time : " + fd.CreationTime);
            Console.WriteLine("Length of the file: "+ fd.Length);



        }
    }
}
