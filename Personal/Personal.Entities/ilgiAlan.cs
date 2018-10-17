using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personal.Entities.Abstract;

namespace Personal.Entities
{
    public class ilgiAlan : ABaseEntity
    {
        [StringLength(1000)]
        public string  aciklama { get; set; }

        [StringLength(200)]
        public string ikon { get; set; }
    }
}
