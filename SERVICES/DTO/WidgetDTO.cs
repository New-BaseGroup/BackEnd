using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICES.DTO
{
    public class WidgetDTO
    {
        [Required]
        public string Header { get; set; }

        [Required]
        public string Data { get; set; }

        [Required]
        public int Position { get; set; }
    }
}
