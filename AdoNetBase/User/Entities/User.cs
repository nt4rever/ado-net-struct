using Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.User.Entities
{
    public class User : EntityBase
    {
        public required string UserName { get; set; }
    }
}
