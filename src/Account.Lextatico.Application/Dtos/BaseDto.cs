using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Account.Lextatico.Application.Dtos
{
    public abstract class BaseDto
    {
        public Guid Id { get; set; }
        private DateTime CreatedAt { get; set; }
        private DateTime? UpdatedAt { get; set; }
    }
}
