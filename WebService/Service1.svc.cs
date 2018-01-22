using System;
using System.Collections.Generic;
using System.Linq;

namespace WebService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class Service1 : IService1
    {
        /**
         * Customers
         */
        public List<SPS_CUSTOMERS_Result> GetCustomers()
        {
            List<SPS_CUSTOMERS_Result> items = null;
            using (var database = new mygavoltEntities())
            {
                database.Configuration.ProxyCreationEnabled = false;
                items = database.SPS_CUSTOMERS().ToList();
            }

            return items.ToList();
        }

        public int SetCustomer(customers c)
        {
            using (var db = new mygavoltEntities())
            {
                db.Configuration.ProxyCreationEnabled = false;
                db.SPI_CUSTOMERS(c.business_name, c.lastname, c.firstname, c.email, c.phone, c.mobile);
            }

            return 1;
        }

        /**
         * Customer Address
         */
        public IList<SPS_ADDRESS_CUSTOMERS_Result> GetAddressCustomers()
        {
            throw new NotImplementedException();
        }

        public int SetAddressCustomer(address_customers a_c)
        {
            using (var db = new mygavoltEntities())
            {
                db.Configuration.ProxyCreationEnabled = false;
                db.SPI_ADDRESS_CUSTOMERS(a_c.customer_id, a_c.street_number, a_c.street_name, a_c.zip_code, a_c.city, a_c.country);
            }

            return 1;
        }

        /**
         * Customer Contact
         */
        public IList<string> GetContactsCustomers()
        {
            throw new NotImplementedException();
        }

        public int SetContactsCustomer(contacts_customers c_c)
        {
            using (var db = new mygavoltEntities())
            {
                db.Configuration.ProxyCreationEnabled = false;
                db.SPI_CONTACTS_CUSTOMERS(c_c.customer_id, c_c.lastname, c_c.firstname, c_c.email, c_c.phone, c_c.mobile);
            }
            return 1;
        }

        /**
         * Employees
         */
        public IList<SPS_EMPLOYEES_Result> GetEmployees()
        {
            IList<SPS_EMPLOYEES_Result> items;
            using (var db = new mygavoltEntities())
            {
                db.Configuration.ProxyCreationEnabled = false;
                items = db.SPS_EMPLOYEES().ToList();
            }

            return items.ToList();
        }

        public int SetEmployee(employees e)
        {
            using (var db = new mygavoltEntities())
            {
                db.Configuration.ProxyCreationEnabled = false;
                db.SPI_EMPLOYEES(e.lastname, e.firstname, e.social_security_number, e.email, e.role_id, e.phone, e.mobile, e.marital_status, e.birthdate, e.arrival_date, e.bank_account, e.street_number, e.street_name, e.zip_code, e.city, e.country);
            }

            return 1;
        }

        /**
         * Devices
         */
        public IList<SPS_DEVICES_Result> GetDevices()
        {
            IList<SPS_DEVICES_Result> items;

            using (var db = new mygavoltEntities())
            {
                db.Configuration.ProxyCreationEnabled = false;
                items = db.SPS_DEVICES().ToList();
            }

            return items.ToList();
        }

        public int SetDevice(devices d)
        {
            using (var db = new mygavoltEntities())
            {
                db.Configuration.ProxyCreationEnabled = false;
                db.SPI_DEVICES(d.label, d.IMEI, d.system, d.version, d.mac_address);
            }

            return 1;
        }

        /**
         * Interventions
         */
        public IList<SPS_INTERVENTIONS_Result> GetInterventions()
        {
            IList<SPS_INTERVENTIONS_Result> items;
            using (var db = new mygavoltEntities())
            {
                db.Configuration.ProxyCreationEnabled = false;
                items = db.SPS_INTERVENTIONS().ToList();
            }

            return items.ToList();
        }

        public int SetIntervention(interventions i)
        {
            using (var db = new mygavoltEntities())
            {
                db.Configuration.ProxyCreationEnabled = false;
                db.SPI_INTERVENTIONS(i.employee_id, i.address_customer_id, i.date, i.motive_id, i.report, i.customer_id);
            }

            return 1;
        }
    }
}