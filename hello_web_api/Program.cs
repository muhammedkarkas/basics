var builder = WebApplication.CreateBuilder(args);

//Services(container)
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build(); //WebApplication Create

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();
