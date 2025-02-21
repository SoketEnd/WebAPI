using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLogic
{
    public static class Exptions
    {
        public static IServiceCollection AddBiusnessLogic(this IServiceCollection services)
        {
            services.AddScoped<INoteSrvice, NoteSevice>();
            return services;
        }
    }
}
