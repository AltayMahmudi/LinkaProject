﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace LinkaRepository.Models
{
	public abstract class BaseEntity
	{
        public int Id { get; set; }
        public bool Status { get; set; }
        public DateTime AddedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;

        [MaxLength(50)]
        public string AddedBy { get; set; }

        [MaxLength(50)]
        public string ModifiedBy { get; set; }
    }
}
