namespace LittlePermanence.Models {
    public class Lesson {
        public int Id { get; set; }
        public DateOnly Date {  get; set; }
        public int HourAmount { get; set; }
        public required Teacher Teacher { get; set; }
        public required Student Student { get; set; }
        public required Subject Subject { get; set; }
    }
}
