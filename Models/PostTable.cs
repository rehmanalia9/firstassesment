using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class PostTable
    {
        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public string Titlle { get; set; }
        public string Descripition { get; set; }
        public string Image { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescripition { get; set; }
        public string Status { get; set; }
        public DateTime? CreatedData { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
