using EShop.Data;
using EShop.Models;
using Microsoft.EntityFrameworkCore;
using Xunit;

public class UserRepositoryTests
{
    private DbContextOptions<ApplicationDbContext> _options;

    public UserRepositoryTests()
    {
        _options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;
    }

    [Fact]
    public void AddUser_Should_Add_User_To_Database()
    {
        using (var context = new ApplicationDbContext(_options))
        {
            // Arrange
            var user = new User { FirstName = "John", LastName = "Doe" };

            // Act
            context.Users.Add(user);
            context.SaveChanges();

             // Assert
            var result = context.Users.FirstOrDefault(u => u.FirstName == "John");
            Assert.Equal("John", result.FirstName);
            Assert.Equal("Doe", result.LastName);
        }
    }

    [Fact]
    public void GetAllUsers_Should_Retrieve_All_Users_From_Database()
    {
        // Arrange
        using (var context = new ApplicationDbContext(_options))
        {
            var users = new[]
            {
                new User { FirstName = "Alice", LastName = "Johnson" },
                new User { FirstName = "Bob", LastName = "Williams" },
                new User { FirstName = "Charlie", LastName = "Brown" }
            };
            context.Users.AddRange(users);
            context.SaveChanges();

            // Act
            List<User> retrievedUsers;
            retrievedUsers = context.Users.ToList();


            // Assert
            Assert.Equal(3, retrievedUsers.Count);
            Assert.Equal("Alice", retrievedUsers[0].FirstName);
            Assert.Equal("Bob", retrievedUsers[1].FirstName);
            Assert.Equal("Charlie", retrievedUsers[2].FirstName);
        }
    }

    [Fact]
    public void UpdateUser_Should_Update_User_In_Database()
    {
        // Arrange
        using (var context = new ApplicationDbContext(_options))
        {
            var user = new User { FirstName = "Mark", LastName = "Anderson" };
            context.Users.Add(user);
            context.SaveChanges();
   

            // Act
            var updatedUser = context.Users.FirstOrDefault();
            updatedUser.LastName = "Smith";
            context.SaveChanges();

            // Assert
            updatedUser = context.Users.FirstOrDefault();
            Assert.NotNull(updatedUser);
            Assert.Equal("Smith", updatedUser.LastName);
        }
    }
}
