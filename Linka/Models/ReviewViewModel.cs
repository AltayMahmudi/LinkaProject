using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Linka.Models
{
	public class ReviewViewModel
	{

        public byte Star { get; set; }


        public string Title { get; set; }

  
        public string Review { get; set; }

        public DateTime AddedDate { get; set; }
    }
}
