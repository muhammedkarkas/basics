var builder = WebApplication.CreateBuilder(args);

//Services(container)
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build(); //WebApplication Create

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();
app.Run();

//ISS development deðilde production modda old için sistem ISS üzerinden ayaða kaldýrýldýðýnda swagger kullanýlamayacak. Eðer development modda ise uygulama swagger kullanabilecektir. Bu mod ayarlamalarý launcsetting dosyasý içerisinde yapýlmaktadýr.