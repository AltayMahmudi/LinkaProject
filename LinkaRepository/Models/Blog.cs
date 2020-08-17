using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Repository.Models;

namespace LinkaRepository.Models
{
	public class Blog:BaseEntity
	{
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string Body { get; set; } = "";

        public bool IsFeatured { get; set; } 
        public string BlogCategory { get; set; } 
        public bool IsInspiration { get; set; } 
        public bool IsBanner { get; set; } 

        public bool IsLatest { get; set; } 

        public bool IsEditorsChoice { get; set; } 
        public ICollection<BlogPhoto> Photos { get; set; }

        public User user { get; set; }



    }
}
