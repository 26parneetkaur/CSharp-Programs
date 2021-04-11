using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using X.PagedList.Mvc.Core;
using SqlBusinessLayer.Interface;
using SqlEntities.Entities;
using SqlProject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;
using SqlEntities.CustomEntities;

namespace SqlProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentComponent _studentComponent;

        public HomeController(IStudentComponent studentComponent)
        {
            _studentComponent = studentComponent;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Students()
        {
            ViewBag.College = _studentComponent.GetCollege();
            ViewBag.Teacher = _studentComponent.GetTeacher();
            return View("AddStudents");
        }
        [HttpPost]
        public IActionResult AddStudents(Student model)
        {

            if (ModelState.IsValid)
            {
                Student obj = new Student();
                obj.StudentFirstName = model.StudentFirstName;
                obj.StudentLastName = model.StudentLastName;
                obj.StudentGender = model.StudentGender;
                obj.StudentDob = model.StudentDob;
                obj.StudentAge = model.StudentAge;
                obj.State = model.State;
                obj.TeacherId = model.TeacherId;
                obj.CollegeId = model.CollegeId;

                _studentComponent.InsertUpdateStudent(obj);
                return RedirectToAction("FetchStudents");
            }
            return View();
        }
        public IActionResult UpdateStudents(int id)
        {
            //ViewBag.College = _studentComponent.GetCollege();
            //ViewBag.Teacher = _studentComponent.GetTeacher();
            List<Teacher> teacherList = _studentComponent.GetTeacher();
            List<College> collegeList = _studentComponent.GetCollege();

            List<string> collegeNames = new List<string>();
            List<string> teacherNames = new List<string>();

            foreach (var item in collegeList)
            {
                collegeNames.Add(item.CollegeName);
            }

            foreach (var item in teacherList)
            {
                teacherNames.Add(item.TeacherName);
            }

            ViewBag.CollegeNames = collegeNames;
            ViewBag.TeacherNames = teacherNames;
            var model = new Student();
            if (id > 0)
            {
                model = _studentComponent.GetStudent().FirstOrDefault(x => x.StudentId == id);
            }
            return View("UpdateStudentDetails", model);
        }

        [HttpPost]
        public IActionResult UpdateStudentsList(Student ob)
        {
           
                _studentComponent.InsertUpdateStudent(ob);
            return RedirectToAction("FetchStudents");
        }

        public IActionResult ShowStudentDetails(int id)
        {
            //Student std = _studentComponent.GetStudent().FirstOrDefault(x => x.StudentId == id);
            StudentInsertUpdateModel studentObj = _studentComponent.GetCustomStudentData().FirstOrDefault(x => x.StudentId == id);
            return View(studentObj);
        }
        
        public IActionResult DeleteStudent(long Id)
        {
            var stdId = _studentComponent.GetStudentById(Id);
            var result = _studentComponent.DeleteStudent(Id);
            return RedirectToAction("FetchStudents");
        }
        public IActionResult Candidates(int id)
        {
            if (id == 0)
                id = 1;
            ViewBag.PageNo = id;
            ViewBag.TotalPages = _studentComponent.TotalPages();
            return View(_studentComponent.Pagination(id));
        }
        public IActionResult FetchStudents(string Sorting_Order, string Search_Data, string Filter_Value, int? Page_No)
        {
            ViewBag.CurrentSortOrder = Sorting_Order;
            ViewBag.SortingName = String.IsNullOrEmpty(Sorting_Order) ? "Name_Description" : "";
            ViewBag.SortingAge = String.IsNullOrEmpty(Sorting_Order) ? "Age_Description" : "StudentAge";

            if (Search_Data != null)
            {
                Page_No = 1;
            }
            else
            {
                Search_Data = Filter_Value;
            }

            ViewBag.FilterValue = Search_Data;
            var students = from stu in _studentComponent.GetCustomStudentData() select stu;
            {
                if (!String.IsNullOrEmpty(Search_Data))
                {
                    students = students.Where(x => x.StudentFirstName.ToUpper().Contains(Search_Data.ToUpper())
                    || x.StudentLastName.ToUpper().Contains(Search_Data.ToUpper()));
                }
            }
            switch (Sorting_Order)
            {
                case "Name_Description":
                    students = students.OrderByDescending(stu => stu.StudentFirstName);
                    break;

                case "StudentAge":
                    students = students.OrderBy(stu => stu.StudentAge);
                    break;
                case "Age_Description":
                    students = students.OrderByDescending(stu => stu.StudentAge);
                    break;
                default:
                    students = students.OrderBy(stu => stu.StudentFirstName);
                    break;
            }
            int Size_Of_Page = 4;
            int No_Of_Page = (Page_No ?? 1);
            return View(students.ToPagedList(No_Of_Page, Size_Of_Page));
            
        }

        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
