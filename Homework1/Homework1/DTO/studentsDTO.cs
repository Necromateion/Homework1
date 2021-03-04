using Homework1.Models;
using Microsoft.EntityFrameworkCore;
using Homework1.Models;

namespace Homework1.DTO
{
    public class studentsDTO
    {
        public int Students_id { get; set; }

        public int Age { get; set; }

        public string Firstname { get; set; }
        
        public string Lastname { get; set; }
        
        public string Adress { get; set; }
        
        public string Country { get; set; }
    }
}