using System;
using System.ComponentModel.DataAnnotations;

namespace TorneoFutbol.App.Dominio
{
    public class Partido
    {
        // Identificador único de cada persona
        public int Id { get; set; }
        [Required(ErrorMessage = "Los Datos Son Obligatorios")]
        [StringLength(10, ErrorMessage = "Maximo 10 Caracteres")]
        public String FechaHora { get; set; }
        [Required(ErrorMessage = "El Nombre Del Equipo Es Obligatorio")]
        [StringLength(30, ErrorMessage = "Maximo 30 Caracteres")]
        public string EquipoLocal { get; set; }
        public String MarcadorInicial { get; set; }
        [Required(ErrorMessage = "El Nombre Del Equipo Es Obligatorio")]
        [StringLength(30, ErrorMessage = "Maximo 30 Caracteres")]
        public String EquipoVisitante { get; set; }
        [Required(ErrorMessage = "El Marcador Es Obligatorio")]
        [StringLength(10, ErrorMessage = "Maximo 10Caracteres")]
        public string MarcadorFinal { get; set; }
        [Required(ErrorMessage = "El Nombre del Colegio Es Obligatorio")]
        [StringLength(30, ErrorMessage = "Maximo 30 Caracteres")]
        public string Colegio { get; set; }
        //Relacion Partido y Equipos
        public System.Collections.Generic.List<Equipo> Equipos { get; set; }
        //Relacion partido y arbitro
        public Arbitro Arbitros { get; set; }



    }
}