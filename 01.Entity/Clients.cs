using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Entity
{
    public class Clients
    {
        public int Id { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }
        public string FileName { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }
        public string LastName { get; set; }
        public string Location { get; set; }

        public DateTime CreateAtDate { get; set; }
        public DateTime UpdateAtDate { get; set; }
        public bool IsActive { get; set; }
        public string GetFullName() => string.Concat(Name," ",LastName);

        public Clients()
        {
            CreateAtDate = DateTime.Now;
            UpdateAtDate = DateTime.Now;
            IsActive = true;


        }
    }
}
