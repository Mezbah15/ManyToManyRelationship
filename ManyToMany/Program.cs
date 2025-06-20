
using ManyToMany;

var context = new StudentDbContext();

//var course = new Courses();

//course.Name = "Python";
//context.Courses.Add(course);
//context.SaveChanges();

//Console.WriteLine($"{course.Name} Course Added");

var student = new Students();
var choosenCourse = new List<int> { 1, 2 };

student.Name = "Jarif";
student.Cgpa = 5.5;
student.Courses = context.Courses.Where(course => choosenCourse.Contains(course.Id)).ToList();
context.Students.Add(student);
context.SaveChanges();

Console.WriteLine($"{student.Name} Added");