using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppBasica.Models
{
    public class Product : Entity
    {
        public Guid SupplierId { get; set; }

        [Required(ErrorMessage = "O Campo {0} é Obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} Precisa ter entre {2} e {1} Caracteres", MinimumLength = 2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "O Campo {0} é Obrigatório")]
        [StringLength(1000, ErrorMessage = "O campo {0} Precisa ter entre {2} e {1} Caracteres", MinimumLength = 2)]
        public string Description { get; set; }

        [Required(ErrorMessage = "O Campo {0} é Obrigatório")]
        public string Image { get; set; }

        [Required(ErrorMessage = "O Campo {0} é Obrigatório")]
        [Column(TypeName = "decimal(10,4)")]
        public decimal Value { get; set; }

        public DateTime RegistrationDate { get; set; }
        public bool Active { get; set; }

        /* EF Relations */
        public Supplier Supplier { get; set; }
    }
}
