﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AnimaLove.ViewModels.UserViewModels
{
    public class CreateUserViewModel
    {
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required, DataType(DataType.EmailAddress)]

        public string Email { get; set; }
       
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords does not matching.")]
        public string ConfirmPassword { get; set; }

        public string ProfileImage { get; set; }
        //public Post Posts { get; set; }
        
        //[NotMapped, Required]
        //public IFormFile ProfilePhoto { get; set; }
    }
}
