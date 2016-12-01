using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Library
{

    [ServiceContract] // Говорим WCF что это интерфейс для запросов сервису
    public interface IMyObject
    {
        [OperationContract] // Делегируемый метод.
        string GetCommandString(int i);
    }
 
}
