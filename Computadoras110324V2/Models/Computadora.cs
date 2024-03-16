using System;
using System.Collections.Generic;

namespace Computadoras110324V2.Models
{
    public partial class Computadora
    {
        public Computadora()
        {
            Componentes = new List<Componente>();
        }

        public int Id { get; set; }
        public DateTime FechaLlegada { get; set; }
        public string Marca { get; set; } = null!;
        public string Tipo { get; set; } = null!;

        public virtual IList<Componente> Componentes { get; set; }
    }
}
