//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebService
{
    using System;
    using System.Collections.Generic;
    
    public partial class interventions
    {
        public int id { get; set; }
        public int employee_id { get; set; }
        public int address_customer_id { get; set; }
        public System.DateTime date { get; set; }
        public int motive_id { get; set; }
        public string report { get; set; }
        public System.DateTime created_at { get; set; }
        public System.DateTime updated_at { get; set; }
        public int customer_id { get; set; }
    
        public virtual address_customers address_customers { get; set; }
        public virtual customers customers { get; set; }
        public virtual employees employees { get; set; }
        public virtual motives motives { get; set; }
    }
}
