using Personal.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal.EfDal
{
    public class PersonalModel : DbContext
    {

        public virtual DbSet<ilgiAlan> ilgiAlan { get; set; }

    }
}
