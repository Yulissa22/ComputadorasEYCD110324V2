using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Computadoras110324V2.Models
{
    public partial class Componente
    {
        public int Id { get; set; }
        public int IdComputadoras { get; set; }
        public string Procesador { get; set; } = null!;
        [DisplayName("Memoria ram")]
        public int MemoriaRamgb { get; set; }
        [DisplayName("Almacenamiento")]
        public int AlmacenamientoGb { get; set; }

        public virtual Computadora IdComputadorasNavigation { get; set; } = null!;
    }
}
