﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.Models
{
    public class Change
    {
        
        public int ChangeID { get; set; }
        public string Title { get; set; }

        
        public int Amount { get; set; }
        public DateTime Date { get; set; }
        public string? Description { get; set; }
    }
}
