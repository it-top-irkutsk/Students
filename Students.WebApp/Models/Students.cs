using System.Text.Json;

namespace Students.WebApp.Models;

public class Students
{
    private readonly List<Student> _students;

    public Students()
    {
        _students = new List<Student>();
    }
    public Students(List<Student> students)
    {
        _students = students;
    }

    public IEnumerable<Student> GetAllStudents() => _students;

    public Student GetStudentById(int id) => _students.Find(s => s.Id == id) ?? throw new InvalidOperationException();

    public static async Task<Students> ImportFromJson(string path)
    {
        await using var file = new FileStream(path, FileMode.Open);
        var students = await JsonSerializer.DeserializeAsync<List<Student>>(file);
        return students is not null ? new Students(students) : new Students();
    }
}