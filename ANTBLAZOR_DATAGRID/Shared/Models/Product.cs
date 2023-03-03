using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANTBLAZOR_DATAGRID.Shared.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        [Display(Name = "Nombre")]
        public string Name { get; set; } = null!;
        [Display(Name = "Proveedor")]
        public string Supplier { get; set; } = null!;
        [Display(Name = "Precio")]
        public double Price { get; set; }
        public string ImageUrl { get; set; } = null!;
        [Display(Name = "Fecha de Manufactura")]
        public DateTime ManufactureDate { get; set; }
    }
}
