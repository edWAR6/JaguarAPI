//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EARTH.Jaguar.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class P_Personas
    {
        public P_Personas()
        {
            this.P_Notas = new HashSet<P_Notas>();
            this.R_Estudiantes = new HashSet<R_Estudiantes>();
        }
    
        public int IdPersona { get; set; }
        public string Fallecido { get; set; }
        public string Identificacion { get; set; }
        public string Pasaporte { get; set; }
        public string login_red { get; set; }
        public string Prefix { get; set; }
        public string Nombre { get; set; }
        public string SNombre { get; set; }
        public string Apellidos { get; set; }
        public string Genero { get; set; }
        public string GrupoEtnico { get; set; }
        public Nullable<System.DateTime> Fecha_Nacimiento { get; set; }
        public string Pais_Nacimiento { get; set; }
        public string zona { get; set; }
        public string Direccion_Oficial { get; set; }
        public string EstadoCivil { get; set; }
        public string Sobrenombre { get; set; }
        public string IdiomaProcedencia { get; set; }
        public string LenguaMaterna { get; set; }
        public Nullable<short> NHijos { get; set; }
        public string PEOPLE_CODE_ID { get; set; }
        public string GOVERMENT_ID { get; set; }
        public string PREVIOUS_ID { get; set; }
        public string usuario { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public int Escolaridad { get; set; }
        public string NombreCompleto { get; set; }
        public string ApellidoNombre { get; set; }
        public string Nacionalidad { get; set; }
        public bool Residente { get; set; }
    
        public virtual ICollection<P_Notas> P_Notas { get; set; }
        public virtual ICollection<R_Estudiantes> R_Estudiantes { get; set; }
    }
}
