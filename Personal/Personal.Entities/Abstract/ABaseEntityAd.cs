using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal.Entities.Abstract
{
    public abstract class ABaseEntityAd : ABaseEntity
    {
        [StringLength(1000)]
        public string aciklama { get; set; }
    }
}
