using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApplicationCore.Entities
{
   public abstract class Base
    {
        [Key]
        public int id { get; set; }
    }
}
