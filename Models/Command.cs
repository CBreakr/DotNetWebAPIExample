namespace Commander.Models
{
    public class Command
    {
        public int Id { get; set; }
        public string HowTo { get; set; }
        public string Line { get; set; }
        public string Platform { get; set; }

        public Command(int id, string howto, string line, string platform){
            Id = id;
            HowTo = howto;
            Line = line;
            Platform = platform;
        }
    }
}