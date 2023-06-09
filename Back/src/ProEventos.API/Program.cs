using Microsoft.EntityFrameworkCore;
using ProEventos.Persistence;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddDbContext<ProEventosContext>(options => 
                options.UseSqlite(builder.Configuration.
                GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.UseCors(x => x.AllowAnyHeader().
                    AllowAnyMethod().
                    AllowAnyOrigin());

app.UseAuthorization();

app.MapControllers();

app.Run();
