using System;
using System.Collections.Generic;
using System.Text;

namespace CookFLow.Domain.Entities
{
    public class User
    {
        public bool IsActive { get; set; } = true;
        public Guid Id { get; private set; } = Guid.CreateVersion7();
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;


    }
}
