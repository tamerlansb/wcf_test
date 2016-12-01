using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Library;
 
namespace Client
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
           /* ServiceHost host = new ServiceHost(typeof(MyObject), new Uri("http://localhost/SampleService"));
            host.AddServiceEndpoint(typeof(IMyObject), new BasicHttpBinding(), "");
            host.Open();
            Console.WriteLine("Сервер запущен");*/

            Uri tcpUri = new Uri("http://localhost/Service1.svc");
            EndpointAddress address = new EndpointAddress(tcpUri);
            BasicHttpBinding binding = new BasicHttpBinding();
            ChannelFactory<IMyObject> factory = new ChannelFactory<IMyObject>("*");
            IMyObject service = factory.CreateChannel();

            Console.WriteLine("Вызываю метод сервиса...?");
            Console.WriteLine(service.GetCommandString(1));
            Console.WriteLine(service.GetCommandString(2));
            Console.WriteLine(service.GetCommandString(20));
            Console.WriteLine(service.GetCommandString(1562492));
            Console.WriteLine(service.GetCommandString(0));
            Console.ReadLine();

           // host.Close();
        }
    }
}
