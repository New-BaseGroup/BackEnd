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
        public int? WidgetID { get; set; }
        [Required]
        public string Header { get; set; }

        [Required]
        public string Data { get; set; }

        [Required]
        public int Position { get; set; }
    }
}
