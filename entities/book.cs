namespace hot_defer.entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public Comment[] Comments { get; set; }
    }


    public class Comment
    {
        public int Id { get; set; }
        public string Body { get; set; }
    }

}