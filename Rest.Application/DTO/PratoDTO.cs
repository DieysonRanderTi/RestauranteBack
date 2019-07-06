using Rest.Domain.Ententies;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Rest.Application.DTO
{
    public class PratoDTO
    {
        public int IdPrato { get; set; }
        public string NomePrato { get; set; }
        public double PrecoPrato { get; set; }

        public int IdRestaurante { get; set; }
        [ForeignKey("IdRestaurante")]

        public virtual Restaurante Restaurante { get; set; }
    }
}
