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
    
    public partial class R_Cursos
    {
        public R_Cursos()
        {
            this.R_RegistroNotas = new HashSet<R_RegistroNotas>();
        }
    
        public string id_curso { get; set; }
        public string Curso { get; set; }
        public string Curso_l { get; set; }
        public string TipoCurso { get; set; }
        public Nullable<int> Escala { get; set; }
        public string Estado { get; set; }
        public Nullable<bool> Electivo { get; set; }
        public Nullable<decimal> Creditos { get; set; }
        public string Descripcion { get; set; }
        public string Nombre_publicacion { get; set; }
        public string CourseName { get; set; }
        public Nullable<int> Id_FormEv { get; set; }
        public string usuario { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
    
        public virtual ICollection<R_RegistroNotas> R_RegistroNotas { get; set; }
    }
}
