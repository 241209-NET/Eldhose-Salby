using ExpenseTracker.API.Model;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.API.Data;

public class ExpenseTrackerContext:DbContext
{
    public ExpenseTrackerContext(){}
    public ExpenseTrackerContext(DbContextOptions<ExpenseTrackerContext> options) : base(options){}
    public DbSet<User>Users{get; set;}
}