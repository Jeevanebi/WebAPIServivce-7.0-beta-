﻿using System.ComponentModel.DataAnnotations;

namespace WebService.API.Models
{
    public class AuthUser
    {
        [Required]
        public string? UserName { get; set; }
        [Required]
        public string? Email { get; set; }  
        [Required]
        public string? Password { get; set; }

    }
}
