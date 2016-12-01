using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Library;

namespace Server
{
    public class MyObject : IMyObject
    {
        public string GetCommandString(int i)
        {
            switch (i)
            {
                case 1:// TODO: Реализация старта выполнения ваших команд
                    return "Начало обработки";

                case 0:// TODO: Реализация остановки выполнения ваших команд
                    return "Конец обработки";

                default:// TODO: Выполнение какой-либо вашей команды
                    return "Получил " + i.ToString();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(MyObject), new Uri("http://localhost/SampleService""));
            host.AddServiceEndpoint(typeof(IMyObject), new BasicHttpBinding(), "");
            host.Open();
            Console.WriteLine("Сервер запущен");
            Console.ReadLine();

           // host.Close();
        }
    }
}