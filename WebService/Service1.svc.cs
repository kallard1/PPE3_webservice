using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebService
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////// REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class Service1 : IService1
    {
        // ****************************************************************************************************************************//
        // **   Les SETers (attention à ce qu'il soient aussi défini dans IService1.cs)    ** //
        // ********************************************************************************** //

        // Pour info : 
        // - on passe l'objet entier en paramètre pour pouvoir utiliser ses attributs
        // - on ne revoie pas de liste (d'où le int)


        public int SetAddressCustomer(address_customers a_c)
        {
            // ca on y touche pas
            using (var database = new mygavoltEntities())
            {
                // connexion a la base
                database.Configuration.ProxyCreationEnabled = false;
                // appel de la procédure stockée avec les champs necessaire dans le bon ordre
                database.SPI_ADDRESS_CUSTOMERS(a_c.customer_id, a_c.street_number, a_c.street_name, a_c.zip_code, a_c.city, a_c.country);
            }
            return 1;
        }

        /*
        public int SetContactsCustomer(contacts_customers c_c)
        {
             using (mygavoltEntities1 database = new mygavoltEntities1())
            {
                database.Configuration.ProxyCreationEnabled = false;
                database.SPI_CONTACTS_CUSTOMERS(c_c.customer_id, c_c.lastname, c_c.firstname, c_c.email, c_c.phone, c_c.mobile);
            }
             return 1;
        }
        */

        public int SetCustomer(customers c)
        {
            using (var database = new mygavoltEntities())
            {
                database.Configuration.ProxyCreationEnabled = false;
                database.SPI_CUSTOMERS(c.business_name, c.lastname, c.firstname, c.email, c.phone, c.mobile);
            }
            return 1;
        }

        public int SetDevice(devices d)
        {
            //device d = new device();
            using (var database = new mygavoltEntities())
            {
                database.Configuration.ProxyCreationEnabled = false;
                database.SPI_DEVICES(d.label, d.IMEI, d.system, d.version, d.mac_address);
            }
            return 1;
        }

        public int SetEmployee(employees e)
        {
            using (var database = new mygavoltEntities())
            {
                database.Configuration.ProxyCreationEnabled = false;
                database.SPI_EMPLOYEES(e.lastname, e.firstname, e.social_security_number, e.email, e.role_id, e.phone, e.mobile, e.marital_status, e.birthdate, e.arrival_date, e.bank_account, e.street_number, e.street_name, e.zip_code, e.city, e.country);
            }
            return 1;
        }

        public int SetIntervention(interventions i)
        {
            using (var database = new mygavoltEntities())
            {
                database.Configuration.ProxyCreationEnabled = false;
                database.SPI_INTERVENTIONS(i.employee_id, i.address_customer_id, i.date, i.motive_id, i.report, i.customer_id);
            }
            return 1;
        }

        public int SetLocalization(localizations l)
        {
            using (var database = new mygavoltEntities())
            {
                database.Configuration.ProxyCreationEnabled = false;
                database.SPI_LOCALIZATION(l.device_id, l.employee_id, l.position);
            }
            return 1;
        }

        public int SetMotive(motives m)
        {
            using (var database = new mygavoltEntities())
            {
                database.Configuration.ProxyCreationEnabled = false;
                database.SPI_MOTIVES(m.label);
            }
            return 1;
        }

        public int SetRole(roles r)
        {
            using (var database = new mygavoltEntities())
            {
                database.Configuration.ProxyCreationEnabled = false;
                database.SPI_ROLES(r.label);
            }
            return 1;
        }

        // ****************************************************************************************************************************//

        public IList<devices> GetDevices()
        {
            IList<devices> items;
            using (var database = new mygavoltEntities())
            {
                database.Configuration.ProxyCreationEnabled = false;
                items = database.devices.ToList();
            }
            return items.ToList();
        }

        public IList<string> GetNomEmployees()
        {
            IList<employees> items;
            IList<string> empls = new List<string>();
            using (var database = new mygavoltEntities())
            {
                database.Configuration.ProxyCreationEnabled = false;
                //items = database.employees.ToList();
                //items = database.SPS_EMPLOYEES().ToList().Select(c=>c.lastname);
                items = database.employees.ToList();
            }

            foreach (employees t in items)
            {
                string toto = t.lastname;
                empls.Add(toto);
            }
            return empls;
        }

        public IList<employees> GetEmployees()
        {
            IList<employees> items;
            using (var database = new mygavoltEntities())
            {
                database.Configuration.ProxyCreationEnabled = false;
                //items = database.employees.ToList();
                items = database.employees.ToList();
            }

            return items.ToList();
        }

        public IList<customers> GetCustomers()
        {
            IList<customers> items = null;
            using (var database = new mygavoltEntities())
            {
                database.Configuration.ProxyCreationEnabled = false;
                items = database.customers.ToList();
                //items = database.customers.ToList();
                /*IList<SPS_CUSTOMERS_Result> customer = database.SPS_CUSTOMERS().ToList();

                foreach(SPS_CUSTOMERS_Result sp in customer)
                {
                    IList<intervention> interventuins = new List<intervention>();
                    customer cus = new mygavolt_webservice.customer();
                    cus.business_name = sp.business_name;
                    cus.lastname = sp.lastname;
                    cus.interventions = interventuins;
                    items.Add(cus);
                }*/
            }

            return items.ToList();
        }

        public IList<motives> GetMotives()
        {
            IList<motives> items;
            using (var database = new mygavoltEntities())
            {
                database.Configuration.ProxyCreationEnabled = false;
                items = database.motives.ToList();
            }

            return items.ToList();
        }

        public IList<string> GetAddressCustomers()
        {
            throw new NotImplementedException();
        }

        public IList<string> GetContactsCustomers()
        {
            throw new NotImplementedException();
        }

        public IList<interventions> GetInterventions()
        {
            IList<interventions> items;
            using (var database = new mygavoltEntities())
            {
                database.Configuration.ProxyCreationEnabled = false;
                items = database.interventions.ToList();
            }

            return items.ToList();
        }

        public IList<localizations> GetLocalizations()
        {
            IList<localizations> items;
            using (var database = new mygavoltEntities())
            {
                database.Configuration.ProxyCreationEnabled = false;
                items = database.localizations.ToList();
            }

            return items.ToList();
        }

        public IList<roles> GetRoles()
        {
            IList<roles> items;
            using (var database = new mygavoltEntities())
            {
                database.Configuration.ProxyCreationEnabled = false;
                items = database.roles.ToList();
            }

            return items.ToList();
        }

        // ****************************************************************************************************************************//
        // *   Les MODers (attention à ce qu'il soient aussi défini dans IService1.cs)    * //
        // ******************************************************************************** //
        public int ModifyEmployee(employees e)
        {
            using (var database = new mygavoltEntities())
            {
                database.Configuration.ProxyCreationEnabled = false;
                database.SPM_EMPLOYEES(e.id, e.lastname, e.firstname, e.social_security_number, e.email, e.role_id, e.phone, e.mobile, e.marital_status, e.birthdate, e.arrival_date, e.bank_account, e.street_number, e.street_name, e.zip_code, e.city, e.country);
            }
            return 1;
        }

        public int ModifyDevice(devices d)
        {
            using (var database = new mygavoltEntities())
            {
                database.Configuration.ProxyCreationEnabled = false;
                database.SPM_DEVICES(d.id, d.label, d.IMEI, d.system, d.version, d.mac_address);
            }
            return 1;
        }

        public int ModifyCustomer(customers c)
        {
            using (var database = new mygavoltEntities())
            {
                database.Configuration.ProxyCreationEnabled = false;
                database.SPM_CUSTOMERS(c.id, c.business_name, c.lastname, c.firstname, c.email, c.phone, c.mobile);
            }
            return 1;
        }

        public int ModifyAddressCustomer(address_customers a_c)
        {
            using (var database = new mygavoltEntities())
            {
                database.Configuration.ProxyCreationEnabled = false;
                database.SPM_ADDRESS_CUSTOMERS(a_c.id, a_c.street_number, a_c.street_name, a_c.zip_code, a_c.city, a_c.country);
            }
            return 1;
        }

        public int ModifyContactCustomer(contacts_customers c_c)
        {
            using (var database = new mygavoltEntities())
            {
                database.Configuration.ProxyCreationEnabled = false;
                database.SPM_CONTACTS_CUSTOMERS(c_c.id, c_c.lastname, c_c.firstname, c_c.email, c_c.phone, c_c.mobile);
            }
            return 1;
        }

        public int ModifyIntervention(interventions i)
        {
            using (var database = new mygavoltEntities())
            {
                database.Configuration.ProxyCreationEnabled = false;
                database.SPM_INTERVENTIONS(i.id, i.employee_id, i.address_customer_id, i.date, i.motive_id, i.report, i.customer_id);
            }
            return 1;
        }

        public int ModifyLocalization(localizations l)
        {
            using (var database = new mygavoltEntities())
            {
                database.Configuration.ProxyCreationEnabled = false;
                database.SPM_LOCALIZATIONS(l.id, l.device_id, l.employee_id, l.position);
            }
            return 1;
        }

        public int ModifyMotive(motives m)
        {
            using (var database = new mygavoltEntities())
            {
                database.Configuration.ProxyCreationEnabled = false;
                database.SPM_MOTIVES(m.id, m.label);
            }
            return 1;
        }

        public int ModifyRole(roles r)
        {
            using (var database = new mygavoltEntities())
            {
                database.Configuration.ProxyCreationEnabled = false;
                database.SPM_ROLES(r.id, r.label);
            }
            return 1;
        }

        // ****************************************************************************************************************************//
        // *   Les Delete (attention à ce qu'il soient aussi défini dans IService1.cs)    * //
        // ******************************************************************************** //

        public int DeleteEmploye(employees e)
        {
            using (var database = new mygavoltEntities())
            {
                database.Configuration.ProxyCreationEnabled = false;
                database.SPD_EMPLOYEES(e.id);
            }
            return 1;
        }

        public int DeleteDevice(devices d)
        {
            using (var database = new mygavoltEntities())
            {
                database.Configuration.ProxyCreationEnabled = false;
                database.SPD_DEVICES(d.id);
            }
            return 1;
        }

        public int DeleteCustomer(customers c)
        {
            using (var database = new mygavoltEntities())
            {
                database.Configuration.ProxyCreationEnabled = false;
                database.SPD_CUSTOMERS();
            }
            return 1;
        }

        public int DeleteAddressCustomer(address_customers a_c)
        {
            using (var database = new mygavoltEntities())
            {
                database.Configuration.ProxyCreationEnabled = false;
                database.SPD_ADDRESS_CUSTOMERS(a_c.id);
            }
            return 1;
        }

        public int DeleteContactCustomer(contacts_customers c_c)
        {
            using (var database = new mygavoltEntities())
            {
                database.Configuration.ProxyCreationEnabled = false;
                database.SPD_CONTACTS_CUSTOMERS(c_c.id);
            }
            return 1;
        }

        public int DeleteMotive(motives m)
        {
            using (var database = new mygavoltEntities())
            {
                database.Configuration.ProxyCreationEnabled = false;
                database.SPD_MOTIVES(m.id);
            }
            return 1;
        }

        public int DeleteRole(roles r)
        {
            using (var database = new mygavoltEntities())
            {
                database.Configuration.ProxyCreationEnabled = false;
                database.SPD_ROLES(r.id);
            }
            return 1;
        }
    }
}
