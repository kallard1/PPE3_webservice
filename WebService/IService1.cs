using System.Collections.Generic;
using System.ServiceModel;

namespace WebService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IService1
    {
        // Getters 
        [OperationContract]
        IList<string> GetAddressCustomers();

        [OperationContract]
        IList<string> GetContactsCustomers();

        [OperationContract]
        IList<customers> GetCustomers();

        [OperationContract]
        IList<devices> GetDevices();

        [OperationContract]
        IList<employees> GetEmployees();

        [OperationContract]
        IList<interventions> GetInterventions();

        [OperationContract]
        IList<localizations> GetLocalizations();

        [OperationContract]
        IList<motives> GetMotives();

        [OperationContract]
        IList<roles> GetRoles();

        [OperationContract]
        IList<string> GetNomEmployees();


        // Setters

        [OperationContract]
        int SetAddressCustomer(address_customers a_c);
        /*
        [OperationContract]
        int SetContactsCustomer(contacts_customers c_c);
        */
        [OperationContract]
        int SetCustomer(customers c);

        [OperationContract]
        int SetDevice(devices d);

        [OperationContract]
        int SetEmployee(employees e);

        [OperationContract]
        int SetIntervention(interventions i);

        [OperationContract]
        int SetLocalization(localizations l);

        [OperationContract]
        int SetMotive(motives m);

        [OperationContract]
        int SetRole(roles r);
    }
}
