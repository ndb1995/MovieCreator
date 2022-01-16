namespace MovieCreator.Data
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Rating { get; set; }
        public string Description { get; set; }
        public bool? isFinished { get; set; }
    }
}
