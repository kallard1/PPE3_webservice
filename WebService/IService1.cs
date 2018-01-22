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

        /**
         * Customer Address
         */
        [OperationContract]
        IList<SPS_ADDRESS_CUSTOMERS_Result> GetAddressCustomers();

        [OperationContract]
        int SetAddressCustomer(address_customers a_c);

        /**
         * Customer Contact
         */
        [OperationContract]
        IList<string> GetContactsCustomers();

        [OperationContract]
        int SetContactsCustomer(contacts_customers c_c);

        /**
         * Employees
         */
        [OperationContract]
        IList<SPS_EMPLOYEES_Result> GetEmployees();

        [OperationContract]
        int SetEmployee(employees e);

        /**
         * Devices
         */
        [OperationContract]
        IList<SPS_DEVICES_Result> GetDevices();

        [OperationContract]
        int SetDevice(devices d);

        /**
         * Interventions
         */
        [OperationContract]
        IList<SPS_INTERVENTIONS_Result> GetInterventions();

        [OperationContract]
        int SetIntervention(interventions i);

        /**
         * Localization
         */
        [OperationContract]
        IList<SPS_LOCALIZATION_Result> GetLocalizations();

        [OperationContract]
        int SetLocalization(localizations l);
    }
}
