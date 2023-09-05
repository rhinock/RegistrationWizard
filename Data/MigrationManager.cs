using Microsoft.EntityFrameworkCore;

namespace RegistrationWizard.Data
{
    public static class MigrationManager
    {
        public static WebApplication MigrateDatabase(this WebApplication application)
        {
            using (var scope = application.Services.CreateScope())
            {
                using var appContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

                try
                {
                    appContext.Database.Migrate();
                }
                catch (Exception)
                {
                    throw;
                }
            }

            return application;
        }
    }
}
