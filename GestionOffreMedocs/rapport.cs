//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionOffreMedocs
{
    using System;
    using System.Collections.Generic;
    
    public partial class rapport
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public rapport()
        {
            this.offrir = new HashSet<offrir>();
        }
    
        public int id { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string motif { get; set; }
        public string bilan { get; set; }
        public string idVisiteur { get; set; }
        public int idMedecin { get; set; }
    
        public virtual medecin medecin { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<offrir> offrir { get; set; }
        public virtual visiteur visiteur { get; set; }
    }
}
