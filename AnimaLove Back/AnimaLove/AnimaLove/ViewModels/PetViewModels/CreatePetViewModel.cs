using AnimaLove.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AnimaLove.ViewModels.PetViewModels
{
    public class CreatePetViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        [NotMapped, Required]
        public IFormFile Photo { get; set; }
        public Category category { get; set; }
    }
}
