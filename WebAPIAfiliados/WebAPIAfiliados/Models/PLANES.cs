//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAPIAfiliados.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PLANES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PLANES()
        {
            this.AFILIADOS = new HashSet<AFILIADOS>();
        }
    
        public int id { get; set; }
        public string Plann { get; set; }
        public int Monto_Consumido { get; set; }
        public System.DateTime Fecha_Registro { get; set; }
        public string Estatus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AFILIADOS> AFILIADOS { get; set; }
    }
}
