using MariaStudyGroup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MariaStudyGroup.Controllers
{
    public class StudyGroupController : Controller
    {
        // GET: StudyGroup
        public ActionResult Index()
        {
            List<StudyGroupMember> members = new List<StudyGroupMember>
            {
                new StudyGroupMember { StudentNumber = "u22749536", Name = "Maria", Surname = "Mbambu", EmailAddress = "maria.mbambu@tuks.co.za" },
                new StudyGroupMember { StudentNumber = "u24595901", Name = "Petrus", Surname = "Chabedi", EmailAddress = "petrus.chabedi@tuks.co.za" },
                new StudyGroupMember { StudentNumber = "u22557173", Name = "Masilo", Surname = "Makola", EmailAddress = "masilo.makola@tuks.co.za" },
                new StudyGroupMember { StudentNumber = "u22761421", Name = "Maria Lynn", Surname = "Vewesse", EmailAddress = "maria.vewesse@tuks.co.za" },
                new StudyGroupMember { StudentNumber = "u23578140", Name = "Kopano", Surname = "Moloi", EmailAddress = "kopano.moloi@tuks.co.za" }
            };

            return View(members);
        }
    }
}