using AddressBook.Data;
using Microsoft.EntityFrameworkCore;

namespace AddressBook.Helpers
{
    public static class DataHelper
    {
        public static async Task ManageDataAsync(IServiceProvider serviceProvider)
        {
            var dbContextService = serviceProvider.GetRequiredService<ApplicationDbContext>();
            await dbContextService.Database.MigrateAsync();
        }
    }
}
