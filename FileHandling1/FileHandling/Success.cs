using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandling2
{
    internal class Success
    {
        public void ReadFile()
        {

            FileStream fileStream = new FileStream("E:\\Capgemini\\FileHandling\\networklog.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fileStream);
            Console.WriteLine("Success Records:");
            Console.WriteLine("Id\tSource\t\tDestination\tDate\t\tTime\t\tStatus\t\tNetwork");
            while (reader.Peek() > 0)
            {
                var networkId = reader.ReadLine();
                string[] strId = networkId.Split(':');
                string id = strId[1];

                var networkSource = reader.ReadLine();
                string[] strSource = networkSource.Split(':');
                string Source = strSource[1];

                var networkDestination = reader.ReadLine();
                string[] strDestination = networkDestination.Split(':');
                string Destination = strDestination[1];

                var networkDate = reader.ReadLine();
                string[] strTime = networkDate.Split(' ');
                string Time = strTime[1];
                string a = strTime[2];
                string[] strDate = strTime[0].Split(':');
                string Date = strDate[1];

                var networkStatus = reader.ReadLine();
                string[] strStatus = networkStatus.Split(':');
                string Status = strStatus[1];

                var networkNetwork = reader.ReadLine();
                string[] strNetwork = networkNetwork.Split(':');
                string Network = strNetwork[1];

                reader.ReadLine();
                if (Status.Contains("Success"))
                    Console.WriteLine(id + "\t" + Source + "\t" + Destination + "\t" + Date + "\t" + Time + "\t" + a + "\t" + Status + "\t\t" + Network);
            }
            reader.Close();
            fileStream.Close();

        }
    }
}
