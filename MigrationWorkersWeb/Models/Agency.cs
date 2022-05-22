﻿using System.ComponentModel.DataAnnotations;

namespace MigrationWorkersWeb.Models
{
    public class Agency
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Reg_No { get; set; }
        [Required]
        public string License_No { get; set; }
        [Required]
        public string License_Exp_Date  { get; set; }
        [Required]
        public string Website { get; set; }
    }
}
