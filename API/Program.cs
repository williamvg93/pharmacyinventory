using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<PharmaInvenContext>(options =>
{
    string connectionString = builder.Configuration.GetConnectionString("MysqlConnection");
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});


var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();



/* 
    Solucionar Error AddDbContext = Instalar el package EntityFrameworkCore en API
dotnet add package Microsoft.EntityFrameworkCore

 
    Crear la Migracion
dotnet ef migrations add nombreMigracion --project ./Infrastructure/ --startup-project ./API/ --output-dir ./Data/Migrations


    Actualizar la DB
dotnet ef database update --project ./Infrastructure/ --startup-project ./API/ 
*/


/* Host 'DESKTOP-GQJ7FIE' is not allowed to connect to this MySQL server */