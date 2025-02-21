using DataAccess.Repisitory;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace DataAccess;

public static class Extensions
{
    public static IServiceCollection AddDataAccess(this IServiceCollection servicesCollection)
    {

        servicesCollection.AddScoped<INoteRepository, NoteRepository>();
        servicesCollection.AddDbContext<AppContext>(x =>
        {
            x.UseSqlServer("Server=DESKTOP-UFDBB12;Database=CRUDdb;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;",
                b => b.MigrationsAssembly("DataAccess"));
        });

        return servicesCollection;
    }
}
