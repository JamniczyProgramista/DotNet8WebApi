using DotNet8WebApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace DotNet8WebApi.Data;

public class UserDbContext(DbContextOptions<UserDbContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
    
}