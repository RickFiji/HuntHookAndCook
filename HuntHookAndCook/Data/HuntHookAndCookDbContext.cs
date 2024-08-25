using HuntHookAndCook.Models;
using Microsoft.EntityFrameworkCore;

namespace HuntHookAndCook.Data
{
    public class HuntHookAndCookDbContext : DbContext
    {
        public HuntHookAndCookDbContext(DbContextOptions<HuntHookAndCookDbContext> options) : base(options) { }

    }
}
