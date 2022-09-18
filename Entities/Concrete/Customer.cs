using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Customer : IEntity
    {
        public short Id { get; set; }
        public short UserId { get; set; }
        public string CompanyName { get; set; }
    }
}
