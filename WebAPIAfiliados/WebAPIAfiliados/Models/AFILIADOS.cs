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
    
    public partial class AFILIADOS
    {
        public int id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public System.DateTime Fecha_nacimineto { get; set; }
        public string Sexo { get; set; }
        public string Cedula { get; set; }
        public string Numero_Seguridaad_Social { get; set; }
        public System.DateTime Fecha_Resgistro { get; set; }
        public int Monto_Consumido { get; set; }
        public int idEstatus { get; set; }
        public int idPlan { get; set; }
    
        public virtual ESTATUS ESTATUS { get; set; }
        public virtual PLANES PLANES { get; set; }
    }
}
