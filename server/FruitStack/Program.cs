using FruitStack.Extensions;
using Microsoft.AspNetCore.Hosting;

var builder = WebApplication.CreateBuilder(args);

//Configure services
builder.Services
    .AddControllers()
    .Services
    .AddServices()
    .AddSwaggerGenerator()
    .AddHttpFruityviceClient(builder.Configuration)
    .AddHttpUnsplashClient(builder.Configuration)
    .AddAutoMapper(typeof(Program))
    .AddMemoryCache();

var app = builder.Build();

//Configure middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(x => x
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

app.MapControllers();
app.Run();
