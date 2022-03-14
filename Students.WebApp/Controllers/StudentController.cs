using Microsoft.AspNetCore.Mvc;
using Students.WebApp.Models;

namespace Students.WebApp.Controllers;

public class StudentController : Controller
{
    private Models.Students _students;


    public StudentController()
    {
        _students = Models.Students.ImportFromJson("./wwwroot/students.json").Result;
    }

    public IActionResult Index()
    {
        return View("Index", _students);
    }

    public IActionResult Student(string id)
    {
        var student = int.TryParse(id, out var Id) ? _students.GetStudentById(Id) : new Student();
        
        return View("Student", student);
    }
}