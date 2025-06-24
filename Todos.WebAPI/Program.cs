var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSwaggerGen();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.MapGet("/", () => "Hello World!");
app.MapGet("/getall", () =>Results.Ok( new List<string>() 
{
    "Todo 1",
    "Todo 2", 
    "Todo 3" 
}));
    
app.Run();
