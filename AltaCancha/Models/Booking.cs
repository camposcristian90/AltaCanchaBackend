﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AltaCancha.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public State State { get; set; }
        public Double Payment { get; set; }
        public ApplicationUser User { get; set; }
        public Match Match { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime CreateDate { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime ModDate { get; set; }

    }
}