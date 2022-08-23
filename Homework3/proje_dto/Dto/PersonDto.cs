﻿using DataAnnotationsExtensions;
using proje_base.Attribute;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_dto.Dto
{
    public class PersonDto
    {
        [Required]
        [MaxLength(25)]
        [Display(Name = "AccountId")]
        public int AccountId { get; set; }

        [Required]
        [MaxLength(500)]
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(500)]
        [Display(Name = "LastName")]
        public string LastName { get; set; }

        [EmailAddress]
        [MaxLength(500)]
        public string Email { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [Phone]
        [MaxLength(25)]
        public string Phone { get; set; }

        [Required]
        [DateOfBirth]
        [DataType(DataType.Date)]
        [Display(Name = "DateOfBirth")]
        public DateTime DateOfBitrh { get; set; }
    }
}
