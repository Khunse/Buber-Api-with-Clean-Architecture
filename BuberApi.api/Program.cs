using BuberApi.api.Filters;
using BuberApi.api.Middlewares;
using BuberApi.Application;
using BuberApi.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplicationDependencies()
                            .AddInfrastructureDependency(builder.Configuration);

builder.Services.AddControllers();
// builder.Services.AddControllers( options => options.Filters.Add<ErrorHandlingFilter>());

var app = builder.Build();

// app.UseMiddleware<GlobalExceptionMiddleware>();
app.UseExceptionHandler("/error");
app.UseHttpsRedirection();

app.MapControllers();

app.Run();

