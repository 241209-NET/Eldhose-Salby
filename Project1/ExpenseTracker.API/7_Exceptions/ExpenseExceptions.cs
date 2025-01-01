namespace ExpenseTracker.API.ExpenseException;

public class NoExpenseException : Exception
{
    public NoExpenseException(){}
    public NoExpenseException(string  message) :base(message){}
    public NoExpenseException(string message, Exception inner) : base(message, inner){}
}