using System.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging.Console;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var people = "Hi there";
app.MapGet("login", () => people);

app.Run();