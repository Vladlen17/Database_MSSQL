using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Database;

namespace ConsoleApp.Models
{
    public class UserModel : DatabaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
