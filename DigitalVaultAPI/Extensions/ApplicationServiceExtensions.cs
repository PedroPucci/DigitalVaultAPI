using DigitalVaultAPI.Application.UnitOfWork;
using DigitalVaultAPI.Extensions.SwaggerDocumentation;
using DigitalVaultAPI.Infrastracture.Connection;
using DigitalVaultAPI.Infrastracture.Repository.RepositoryUoW;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.Text.Json.Serialization;

namespace DigitalVaultAPI.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(opt =>
            {
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

                opt.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Teste backend: sistema para gerenciar carteiras digitais e transações financeiras",
                    Description = @"
                        Você deve criar uma API para gerenciar carteiras digitais e transações financeiras. Essa API será utilizada por uma aplicação front-end e deve incluir as 
                        seguintes funcionalidades:

                        Autenticação
                        Criar um usuário
                        Consultar saldo da carteira de um usuário
                        Adicionar saldo à carteira
                        Criar uma transferência entre usuários (carteiras)
                        Listar transferências realizadas por um usuário, com filtro opcional por período de data


                        Para mais informações, consulte o repositório oficial:
                        [GitHub - TestWebBackEndDeveloper](https://github.com/PedroPucci/TestWebBackEndDeveloper).
                        ",
                });

                opt.OperationFilter<CustomOperationDescriptions>();
            }
            );

            services.AddDbContext<DataContext>(opt =>
            {
                opt.UseNpgsql(config.GetConnectionString("WebApiDatabase"));
            });
            services.AddCors(opt =>
            {
                opt.AddPolicy("CorsPolicy", policy =>
                {
                    policy.AllowAnyMethod().AllowAnyHeader().WithOrigins("http://localhost:4200");
                });
            });

            services.AddScoped<IUnitOfWorkService, UnitOfWorkService>();
            services.AddScoped<IRepositoryUoW, RepositoryUoW>();

            services.AddMvc().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.DefaultIgnoreCondition
                                   = JsonIgnoreCondition.WhenWritingNull;
            });

            return services;
        }
    }
}