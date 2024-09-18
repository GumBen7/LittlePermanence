namespace LittlePermanence.Models {
    public class Student {
        public int Id { get; set; }
        public required string FullName { get; set; }
        public ICollection<Subject> Subjects { get; set; } = [];
    }
}
