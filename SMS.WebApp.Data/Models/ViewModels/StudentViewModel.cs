using SMS.WebApp.Data.Models.Emums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.WebApp.Data.Models.ViewModels
{
    public class StudentViewModel
    {
        public Guid  StudentId { get; set; }
        public string ? UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime DOB { get; set; }
        public GenderEnums Gender { get; set; }
        public string GradeLevel { get; set; }
        public string PhoneNumber{ get; set; }
    }
}
