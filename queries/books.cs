using hot_defer.entities;

namespace hot_defer.queries
{
    public class Query
    {

        Book book = new Book
        {
            Title = "C# in depth.",

            Comments = new Comment[]
                    {
                        new Comment
                        {

                            Body = "This is a comment 1"
                        },
                         new Comment
                        {

                            Body = "This is a comment 2"
                        }
                    }
        };

        IEnumerable<Book> books = new Book[]{
            new Book {
                Id=1,
            Title = "C# in depth.",
            Comments = new Comment[]
                    {
                        new Comment
                        {
                            Id=1,
                            Body = "This is a comment 1"
                        },
                         new Comment
                        {
                            Id=3,
                            Body = "This is a comment 2"
                        },
                         new Comment
                        {
                            Id=4,
                            Body = "This is a comment 3"
                        },
                         new Comment
                        {
                            Id=5,
                            Body = "This is a comment 4"
                        },
                         new Comment
                        {
                            Id=6,
                            Body = "This is a comment 5"
                        },
                         new Comment
                        {
                            Id=7,
                            Body = "This is a comment 6"
                        },
                         new Comment
                        {
                            Id=8,
                            Body = "This is a comment 7"
                        },
                         new Comment
                        {
                            Id=9,
                            Body = "This is a comment 8"
                        }
                    }
            },
            new Book {
                Id=2,
            Title = "C# in depth.",
            Comments = new Comment[]
                    {
                        new Comment
                        {
                            Id=10,
                            Body = "This is a comment 1"
                        },
                         new Comment
                        {
                            Id=11,
                            Body = "This is a comment 2"
                        }
                    }
            },
            new Book {
                Id=3,
            Title = "F# in depth.",
            Comments = new Comment[]
                    {
                        new Comment
                        {
                            Id=12,

                            Body = "This is a comment 1"
                        },
                         new Comment
                        {
                            Id=13,
                            Body = "This is a comment 2"
                        }
                    }
            },
            new Book {
                Id=4,
            Title = "G# in depth.",
            Comments = new Comment[]
                    {
                        new Comment
                        {
                            Id=14,

                            Body = "This is a comment 1"
                        },
                         new Comment
                        {
                            Id=15,

                            Body = "This is a comment 2"
                        }
                    }
            }
        };

        public Book GetBook() =>
           book;

        public IEnumerable<Book> GetBooks() =>
            books;
    }

}