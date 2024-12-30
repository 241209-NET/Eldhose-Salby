using ExpenseTracker.API.Model;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.API.Data;

public partial class ExpenseTrackerContext:DbContext
{
    public ExpenseTrackerContext(){}
    public ExpenseTrackerContext(DbContextOptions<ExpenseTrackerContext> options) : base(options){}
    public virtual DbSet<User>Users{get; set;}
    public virtual DbSet<Expense>Expenses{get; set;}
    public virtual DbSet<Category>Category{ get; set;}
}