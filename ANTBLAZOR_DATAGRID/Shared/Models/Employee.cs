using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ANTBLAZOR_DATAGRID.Shared.Models
{
    public class Employee
    {
        [DisplayName("Nombre")]
        public string Name { get; set; } = null!;

        [DisplayName("Género")]
        public string Gender { get; set; } = null!;

        [DisplayName("Correo")]
        public string Email { get; set; } = null!;
    }
}
