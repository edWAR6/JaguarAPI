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
    
    public partial class R_RegistroNotas
    {
        public int A_Adem { get; set; }
        public string Trimestre { get; set; }
        public string id_curso { get; set; }
        public string Subtipo { get; set; }
        public string seccion { get; set; }
        public int Estudiante { get; set; }
        public string Carrera { get; set; }
        public Nullable<int> A_Carrera { get; set; }
        public decimal Creditos { get; set; }
        public string NotaFinal { get; set; }
        public decimal Nota_Num { get; set; }
        public Nullable<System.DateTime> F_Lim_Icomp { get; set; }
        public decimal PP { get; set; }
        public string NotaMedioP { get; set; }
        public string Estado { get; set; }
        public string CalculoPP { get; set; }
        public Nullable<System.DateTime> FechaEstado { get; set; }
        public string Observaciones { get; set; }
        public string Estado_Recuperacion { get; set; }
        public Nullable<decimal> Calif_Examen_Recup { get; set; }
        public string usuario_i { get; set; }
        public Nullable<System.DateTime> Fecha_i { get; set; }
        public string usuario_act { get; set; }
        public Nullable<System.DateTime> Fecha_act { get; set; }
        public Nullable<System.DateTime> Fecha_CreaEv { get; set; }
        public Nullable<System.DateTime> Fecha_HabilitEv { get; set; }
        public Nullable<System.DateTime> Fecha_FinEv { get; set; }
        public string EstadoEv { get; set; }
        public Nullable<long> IdControl { get; set; }
        public decimal CreditosGanados { get; set; }
        public int Perdio { get; set; }
        public int Recuperado { get; set; }
        public int PosibleRecuperacion { get; set; }
        public int ParaRecuperacion { get; set; }
        public int PerdidaDefinitiva { get; set; }
        public int RetiroOficial { get; set; }
        public Nullable<decimal> PuntosPP { get; set; }
        public decimal CreditosPP { get; set; }
        public int Incompleto { get; set; }
        public int Matriculado { get; set; }
        public int MedioPeriodo { get; set; }
        public int NoRecuperado { get; set; }
        public int NoRecuperacion { get; set; }
        public int Aprobado { get; set; }
        public int Gano { get; set; }
        public Nullable<int> TrackingId { get; set; }
    }
}
