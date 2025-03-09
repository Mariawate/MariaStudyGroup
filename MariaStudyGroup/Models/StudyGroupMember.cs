using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MariaStudyGroup.Models
{
    public class StudyGroupMember
    {
        [Key]
        public string StudentNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EmailAddress { get; set; }
        public string MyLink { get; set; }
    }
}