using Dal;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//Context config
builder.Services.AddDbContext<SchoolContext>(
    options => options.UseSqlServer(
        builder.Configuration.GetConnectionString("SchoolDB")
    )
);

// Swagger config
builder.Services.AddSwaggerGen(config =>
{
    config.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "schoolApi",
        Version = "v1",
        Description = "Webservice de l'école"
    });
});


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseSwagger();

app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "schoolApi"); });

app.UseAuthorization();

app.MapControllers();

app.Run();
