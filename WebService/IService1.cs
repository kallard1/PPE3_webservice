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

        [OperationContract]
        IList<SPS_DEVICESNOAFFILIATION_Result> GetDevicesNoAffiliation();

        [OperationContract]
        IList<SPS_EMPLOYEESACTIVE_Result> GetEmployeesActive();

        [OperationContract]
        IList<SPS_EMPLOYEESINACTIVE_Result> GetEmployeesInactives();


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

        //Modify

        [OperationContract]
        int ModifyEmployee(employees e);

        [OperationContract]
        int ModifyDevice(devices d);

        [OperationContract]
        int ModifyCustomer(customers c);

        [OperationContract]
        int ModifyAddressCustomer(address_customers a_c);

        [OperationContract]
        int ModifyContactCustomer(contacts_customers c_c);

        [OperationContract]
        int ModifyIntervention(interventions i);

        [OperationContract]
        int ModifyLocalization(localizations l);

        [OperationContract]
        int ModifyMotive(motives m);

        [OperationContract]
        int ModifyRole(roles r);

        //Delete

        [OperationContract]
        int DeleteEmploye(employees e);

        [OperationContract]
        int DeleteDevice(devices d);

        [OperationContract]
        int DeleteCustomer(customers c);

        [OperationContract]
        int DeleteAddressCustomer(address_customers a_c);

        [OperationContract]
        int DeleteContactCustomer(contacts_customers c_c);

        [OperationContract]
        int DeleteMotive(motives m);

        [OperationContract]
        int DeleteRole(roles r);
    }
}
