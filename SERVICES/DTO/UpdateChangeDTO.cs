using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICES.DTO
{
    public class UpdateChangeDTO
    {
        public int ID { get; set; }

        public int? Amount { get; set; }

        public DateTime? Date { get; init; }

        public string? Title { get; set; }
        public string? Description { get; init; }
    }
}
