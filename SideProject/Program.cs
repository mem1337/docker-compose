using Microsoft.EntityFrameworkCore;
using SideProject.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<UserContext>(opt =>
    opt.UseInMemoryDatabase("User"));
builder.Services.AddDbContext<MovieContext>(opt =>
    opt.UseInMemoryDatabase("Movie"));
builder.Services.AddDbContext<FavoriteContext>(opt =>
    opt.UseInMemoryDatabase("Favorite"));
builder.Services.AddDbContext<RatingContext>(opt =>
    opt.UseInMemoryDatabase("Rating"));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();