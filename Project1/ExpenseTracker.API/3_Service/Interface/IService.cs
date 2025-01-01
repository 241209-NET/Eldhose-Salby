using ExpenseTracker.API.DTO;
using ExpenseTracker.API.Model;

namespace ExpenseTracker.API.Service;

public interface IUserService
{
    User CreateUser(User newUser);
    IEnumerable<User> GetAllUsers();
    User? GetUserById(int id);
    User? DeleteUserById(int id);
}

public interface IExpenseService
{
    IEnumerable<Expense>GetAllExpenses();
    Expense? GetExpenseById(int id);
    Expense CreateExpense(ExpenseInDTO newExpense);
}


public interface ICategoryService
{
    IEnumerable<Category>GetAllCategory();
    Category CreateCategory(Category newCategory);

}