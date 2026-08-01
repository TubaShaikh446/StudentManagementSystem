using Microsoft.AspNetCore.Mvc;
using StudentManagement.Data;
using StudentManagement.Models;

namespace StudentManagement.Controllers
{
    public class StudentController : Controller

    {
        private readonly ApplicationDbContext _context;

        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var students = _context.Students.ToList();

            // Dashboard Cards Data
            ViewBag.TotalStudents = _context.Students.Count();

            ViewBag.TotalCourses = _context.Courses.Count();

            ViewBag.ActiveStudents = _context.Students.Count();

            ViewBag.AverageAge = Math.Round(
                _context.Students.Average(x => x.Age), 0
            );


            return View(students);
        }
        // GET: Student/Create
        public IActionResult Create()
        {
            ViewBag.Courses = _context.Courses.ToList();

            return View();
        }
        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Students.Add(student);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(student);
        }
        public IActionResult Details(int id)
        {
            var student = _context.Students.FirstOrDefault(x => x.Id == id);

            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }
        // GET: Student/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            var student = _context.Students.Find(id);


            if (student == null)
            {
                return NotFound();
            }


            ViewBag.Courses = _context.Courses.ToList();


            return View(student);
        }

        // POST: Student/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Student student)
        {
            if (id != student.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(student);
                _context.SaveChanges();

                TempData["Success"] = "Student updated successfully.";

                return RedirectToAction(nameof(Index));
            }

            return View(student);
        }
        public IActionResult Delete(int id)
        {
            var student = _context.Students.Find(id);

            if (student == null)
                return NotFound();

            return View(student);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var student = _context.Students.Find(id);

            _context.Students.Remove(student);

            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        public IActionResult Dashboard()
        {
            var totalStudents = _context.Students.Count();

            var maleStudents = _context.Students
                .Count(x => x.Gender == "Male");

            var femaleStudents = _context.Students
                .Count(x => x.Gender == "Female");

            // Real course count from database
            var totalCourses = _context.Courses.Count();


            ViewBag.TotalStudents = totalStudents;
            ViewBag.MaleStudents = maleStudents;
            ViewBag.FemaleStudents = femaleStudents;
            ViewBag.TotalCourses = totalCourses;


            return View();
        }
    }
}
