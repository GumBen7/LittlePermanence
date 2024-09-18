namespace LittlePermanence.Models {
    public class Teacher {
        public int Id { get; set; }
        public required string FullNameName { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public ICollection<Subject> Subjects { get; set; } = [];
        
    }
}
