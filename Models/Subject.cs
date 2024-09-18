namespace LittlePermanence.Models {
    public class Subject {
        public int Id { get; set; }
        public required string Name { get; set; }
        public ICollection<Teacher> Teachers { get; set; } = [];
        public ICollection<Student> Students { get; set; } = [];
    }
}
