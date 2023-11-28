using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace _01.Entity
{
    public class Services
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }
        public string ImageName { get; set; }
        public string Description { get; set; }
        public DateTime CreateAtDate { get; set; }
        public DateTime UpdateAtDate { get; set; }
        public bool IsActive { get; set; }

        public Services()
        {
            CreateAtDate = DateTime.Now;
            UpdateAtDate = DateTime.Now;
            IsActive = true;
        }
    }
}
