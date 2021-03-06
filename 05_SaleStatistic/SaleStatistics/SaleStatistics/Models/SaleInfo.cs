﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SaleStatistics.Models
{
    public class SaleInfo
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Manager name can not be empty!")]
        [StringLength(30, ErrorMessage = "Too many chars")]
        public string Manager { get; set; }

        [Required(ErrorMessage = "Client name can not be empty!")]
        [StringLength(30, ErrorMessage = "Too many chars")]
        public string Client { get; set; }

        [Required(ErrorMessage = "Product name can not be empty!")]
        [StringLength(50, ErrorMessage = "Too many chars")]
        public string Product { get; set; }

        [Required(ErrorMessage = "Amount name can not be empty!")]
        [RegularExpression("^[0-9.]+$", ErrorMessage = "Must be a number!")]
        public double PriceSum { get; set; }

        //validation attributs!!
        // https://metanit.com/sharp/mvc/7.3.php
    }
}