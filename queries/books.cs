using hot_defer.entities;

namespace hot_defer.queries;

public class Query
{
    private readonly Book book = new()
    {
        Title = "C# in depth.",

        Comments = new[]
        {
            new()
            {
                Body = "This is a comment 1"
            },
            new Comment
            {
                Body = "This is a comment 2"
            }
        }
    };

    private readonly IEnumerable<Book> books = new[]
    {
        new Book
        {
            Id = 1,
            Title = "C# in depth.",
            Comments = new[]
            {
                new()
                {
                    Id = 1,
                    Body = "This is a comment 1"
                },
                new Comment
                {
                    Id = 3,
                    Body = "This is a comment 2"
                },
                new Comment
                {
                    Id = 4,
                    Body = "This is a comment 3"
                },
                new Comment
                {
                    Id = 5,
                    Body = "This is a comment 4"
                },
                new Comment
                {
                    Id = 6,
                    Body = "This is a comment 5"
                },
                new Comment
                {
                    Id = 7,
                    Body = "This is a comment 6"
                },
                new Comment
                {
                    Id = 8,
                    Body = "This is a comment 7"
                },
                new Comment
                {
                    Id = 9,
                    Body = "This is a comment 8"
                }
            }
        },
        new Book
        {
            Id = 2,
            Title = "C# in depth.",
            Comments = new[]
            {
                new Comment
                {
                    Id = 10,
                    Body = "This is a comment 1"
                },
                new Comment
                {
                    Id = 11,
                    Body = "This is a comment 2"
                }
            }
        },
        new Book
        {
            Id = 3,
            Title = "F# in depth.",
            Comments = new[]
            {
                new Comment
                {
                    Id = 12,

                    Body = "This is a comment 1"
                },
                new Comment
                {
                    Id = 13,
                    Body = "This is a comment 2"
                }
            }
        },
        new Book
        {
            Id = 4,
            Title = "G# in depth.",
            Comments = new[]
            {
                new Comment
                {
                    Id = 14,

                    Body = "This is a comment 1"
                },
                new Comment
                {
                    Id = 15,

                    Body = "This is a comment 2"
                }
            }
        }
    };

    public Book GetBook()
    {
        return book;
    }

    public IEnumerable<Book> GetBooks()
    {
        return books;
    }
}

public class BookType : ObjectType<Book>
{
    protected override void Configure(IObjectTypeDescriptor<Book> descriptor)
    {
        descriptor.Field(f => f.Title).Type<StringType>();
        descriptor.Field(f => f.Comments).Resolve(async () =>
        {
            await Task.Delay(3000);
            return new []
            {
                new Comment {Id = 11, Body = "Great book about C#!"},
                new Comment {Id = 12, Body = "Haven't read it..."}
            };
        });
    }
}

public class QueryType : ObjectType<Query>
{
    protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
    {
        descriptor.Field(f => f.GetBook()).Type<BookType>();
    }
}
