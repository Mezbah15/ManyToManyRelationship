namespace ManyToMany
{
    public class Students
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Cgpa { get; set; }
        public List<Courses>? Courses { get; set; }
    }
}
