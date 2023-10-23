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

//ISS development de�ilde production modda old i�in sistem ISS �zerinden aya�a kald�r�ld���nda swagger kullan�lamayacak. E�er development modda ise uygulama swagger kullanabilecektir. Bu mod ayarlamalar� launcsetting dosyas� i�erisinde yap�lmaktad�r.