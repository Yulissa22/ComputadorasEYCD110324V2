using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Computadoras110324V2.Models
{
    public partial class Computadora
    {
        public Computadora()
        {
            Componente = new List<Componente>();
        }

        public int Id { get; set; }
        [Required]
        [DisplayName("Fecha de llegada")]
        public DateTime FechaLlegada { get; set; }
        public string Marca { get; set; } = null!;
        public string Tipo { get; set; } = null!;

        public virtual IList<Componente> Componente { get; set; }
    }
}
