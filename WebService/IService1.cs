using System.Collections.Generic;
using System.ServiceModel;

namespace WebService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IService1
    {
        /**
         * Customer
         */
        [OperationContract]
        List<SPS_CUSTOMERS_Result> GetCustomers();

        [OperationContract]
        int SetCustomer(customers c);
    }
}
