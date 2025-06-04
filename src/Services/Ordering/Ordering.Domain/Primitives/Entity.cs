using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Domain.Primitives
{
    public abstract class Entity
    {
        protected Entity()
        {
                
        }
        public Guid Id { get; protected set; }
    }
}
