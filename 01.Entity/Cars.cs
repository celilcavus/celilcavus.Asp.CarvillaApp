using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Entity
{
    public class Cars
    {
        public int Id { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }

        public string ImageName { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public string PriceIcon { get; set; }
        public string Description { get; set; }

        public bool IsActive { get; set; }
        public DateTime CreateAtDate { get; set; }
        public DateTime UpdateAtDate { get; set; }

        public Cars()
        {
            IsActive = true;
            CreateAtDate = DateTime.Now;
            UpdateAtDate = DateTime.Now;
        }
    }
}
