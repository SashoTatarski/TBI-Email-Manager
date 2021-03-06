﻿using EMS.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EMS.WebProject.Models.Users
{
    public class RegisterUserViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = Constants.EmailDisplayName)]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long", MinimumLength = 6)]
        [RegularExpression(Constants.RegexExpression, ErrorMessage = Constants.PassValidStateErrMsg)]
        [CustomPasswordValidator]
        [DataType(DataType.Password)]
        [Display(Name = Constants.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = Constants.ConfurmPassword)]
        [Compare(Constants.Password, ErrorMessage = Constants.PassMatchMsg)]
        public string ConfirmPassword { get; set; }

        public List<SelectListItem> Roles { get; set; }
        public string Role { get; set; }

        public string Error { get; set; }
    }
}
