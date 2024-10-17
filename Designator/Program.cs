using Designator.Infraestructure.Configuration;
using Designator.Infraestructure.Interface;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IMongoDbSettings>(serviceProvider =>
        serviceProvider.GetRequiredService<IOptions<MongoDbSettings>>().Value);

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.Map("/", ()=> $"Bem vindo: {Environment.GetEnvironmentVariable("USER_AUTH", EnvironmentVariableTarget.User)}");

app.UseHttpsRedirection();

app.Run();