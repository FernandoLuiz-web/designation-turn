using Designator.Infraestructure.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMongoDbConfiguration(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
        
app.Map("/", ()=> $"Bem vindo: {Environment.GetEnvironmentVariable("USER_AUTH", EnvironmentVariableTarget.User)}");

app.UseHttpsRedirection();

app.Run();