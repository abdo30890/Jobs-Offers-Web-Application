using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JobOffers.Web.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("نوع الوظيفة")]
        public string CategoryName { get; set; }
        [Required]
        [DisplayName("وصف النوع")]
        public string CategoryDescription { get; set; }

        public virtual ICollection<Job> Jobs { get; set; }
        
    }
}