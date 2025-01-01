using ExpenseTracker.API.Model;
using ExpenseTracker.API.Repository;
using ExpenseTracker.API.Service;
using Moq;

namespace ExpenseTracker.TEST;

public class UnitTest1
{
    //Test cases for User service
    [Fact]
        public void TestCreateNewUser()
        {
            //Arrange
            Mock<IUserRepository> mockRepo = new();
            UserService userService = new(mockRepo.Object);

            List<User>userList=[
                new User{UserId=1, Name="amal"},
                new User{UserId=2, Name="aleyamma"},
                new User{UserId=3, Name="antony"}
            ];

            User newUser = new User{UserId=4,Name="alan"};
            mockRepo.Setup(repo => repo.CreateUser(It.IsAny<User>()))
                .Callback((User p) => userList.Add(p))
                .Returns(newUser);
            
            //Act
            var myPet = userService.CreateUser(newUser);

            //Assert
            Assert.Contains(newUser, userList);
            mockRepo.Verify(x => x.CreateUser(It.IsAny<User>()), Times.Once());
        }

        [Fact]
        public void GetAllUsersTest()
        {
            //Arrange
            Mock<IUserRepository> mockRepo = new();
            UserService userService = new(mockRepo.Object);

            List<User>userList=[
                new User{UserId=1, Name="amal"},
                new User{UserId=2, Name="aleyamma"},
                new User{UserId=3, Name="antony"}
            ];

            mockRepo.Setup(repo => repo.GetAllUsers()).Returns(userList);

            //Act
            var result  = userService.GetAllUsers().ToList();

            //Assert
            Assert.Equal(userList,result);
        }

    //Test cases for Category service
        [Fact]
        public void TestCreateNewCategory()
        {
            // Arrange
            Mock<ICategoryRepository> mockRepo = new();
            CategoryService categoryService = new(mockRepo.Object);

            List<Category> categoryList = new()
            {
                new Category { Id = 1, Name = "Food" },
                new Category { Id = 2, Name = "Transport" },
                new Category { Id = 3, Name = "Utilities" }
            };

            Category newCategory = new() { Id = 4, Name = "Entertainment" };
            mockRepo.Setup(repo => repo.CreateCategory(It.IsAny<Category>()))
                .Callback((Category c) => categoryList.Add(c))
                .Returns(newCategory);

            // Act
            var result = categoryService.CreateCategory(newCategory);

            // Assert
            Assert.Contains(newCategory, categoryList);
            mockRepo.Verify(x => x.CreateCategory(It.IsAny<Category>()), Times.Once());
        }

        [Fact]
        public void GetAllCategoriesTest()
        {
            // Arrange
            Mock<ICategoryRepository> mockRepo = new();
            CategoryService categoryService = new(mockRepo.Object);

            List<Category> categoryList = new()
            {
                new Category { Id = 1, Name = "Food" },
                new Category { Id = 2, Name = "Transport" },
                new Category { Id = 3, Name = "Utilities" }
            };

            mockRepo.Setup(repo => repo.GetAllCategory()).Returns(categoryList);

            // Act
            var result = categoryService.GetAllCategory().ToList();

            // Assert
            Assert.Equal(categoryList, result);
            mockRepo.Verify(x => x.GetAllCategory(), Times.Once());
        }

    //Test cases for Expense service
        [Fact]
        public void DeleteExpense_ShouldReturnNull_WhenNotFound()
        {
            // Arrange
            var mockExpenseRepository = new Mock<IExpenseRepository>();
            mockExpenseRepository.Setup(repo => repo.DeleteExpenseById(900)).Returns((Expense)null); // No expense with ID 900
            var expenseService = new ExpenseService(mockExpenseRepository.Object);

            // Act
            var result = expenseService.DeleteExpenseById(900);

            // Assert
            Assert.Null(result);
        }

}