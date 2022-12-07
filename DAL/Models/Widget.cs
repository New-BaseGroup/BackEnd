using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Widget
    {
        [Key]
        public int WidgetID { get; set; }
        public string Header { get; set; }

        public string Data { get; set; }
        public int Position { get; set; }

    }
}
