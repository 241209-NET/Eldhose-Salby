using ExpenseTracker.API.Model;
using ExpenseTracker.API.Repository;
using ExpenseTracker.API.Service;
using Moq;

namespace ExpenseTracker.TEST;

public class UnitTest1
{
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
}