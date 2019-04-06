using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AndresMoronFriend.Models
{
    public class ListaM
    {
        public enum UniType
        {
            Conocido,
            CompañeroDeEstudio,
            ColegaDeTrabajo,
            Amigo,
            AmigOdeInfancia,
            Pariente,

        }
        [key]
        public char Name { get; set; }
        [Required]
        public String NombreCompleto { get; set; }

        public char Type { get; set; }
        [Required]
        public char TipoAmigo { get; set; }

        public char NicKName {get;set;}
        public char Apodo { get; set; }
         
        public char DateTime { get; set; }
        public char Cumpleaños { get; set; }



    }
}