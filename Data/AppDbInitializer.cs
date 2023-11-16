using Microsoft.AspNetCore.Builder;
public class AppDbInitializer
{
    public static void Seed(IApplicationBuilder applicationBuilder)
    {
        using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
        {
            var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
            if (!context.books.Any())
            {
                context.books.AddRange(new Book()
                {
                    Title = "first book",
                    Description = "first book description",
                    IsRead = true,
                    DateRead = DateTime.Now,
                    Rate = 1,
                    Genre = "remance",
                    Author = "first author",
                    CoverUrl = "https.......",
                    DateAdded = DateTime.Now
                },
                new Book()
                {
                    Title = "seconde book",
                    Description = "seconde book description",
                    IsRead = true,
                    DateRead = DateTime.Now,
                    Rate = 1,
                    Genre = "biography",
                    Author = "seconde author",
                    CoverUrl = "https.......",
                    DateAdded = DateTime.Now
                }
                );
            }
        }
    }
}
