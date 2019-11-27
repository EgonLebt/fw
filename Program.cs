using System;
using System.IO;
using System.Diagnostics;

namespace fw
{
    class Program
    {
        static void Main(string[] args)
        {
                       
            if (args.Length > 0) {
                Console.WriteLine("Alarm empfangen");
                string fileName = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss-fff") + "_" + Process.GetCurrentProcess().Id +"_fe2_alarm.txt";             

                Directory.CreateDirectory("logs");

                using (StreamWriter outputFile = new StreamWriter("./logs/" + fileName))
                {
                    int i = 0;
                    foreach (var arg in args) {
                        outputFile.WriteLine("arg" + i++ +": " + arg.ToString());
                    }

                }
            }
            else {
                Console.WriteLine("Alarm nicht verfügbar");
            }
        }
    }
}
