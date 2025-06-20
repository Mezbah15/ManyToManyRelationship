namespace ManyToMany
{
    public class Courses
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Students>? Students { get; set; }
    }
}
