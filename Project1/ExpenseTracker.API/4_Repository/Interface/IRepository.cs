using ExpenseTracker.API.Model;

namespace ExpenseTracker.API.Repository;

public interface IUserRepository
{
    User CreateUser(User newUser);
    void DeleteUserById(int id);
    IEnumerable<User> GetAllUsers();
    User? GetUserById(int id);
}

public interface IExpenseRepository
{
    IEnumerable<Expense>GetAllExpenses();
    IEnumerable<Expense> GetExpenseByUserId(int userId);
    Expense CreateExpense(Expense newExpense);
}

public interface ICategoryRepository
{
    IEnumerable<Category>GetAllCategory();
    Category CreateCategory(Category newCategory);
    Category? DeleteCategoryById(int id);
}