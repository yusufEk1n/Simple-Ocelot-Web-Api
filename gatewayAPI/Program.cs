using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Ocelot'u programımıza servis olarak tanıtırken, 'ocelot.json' konfigürasyonunu
// parametre olarak verdik. Bu sayede ocelot servisi konfigürasyon dosyamıza göre
// addres dönüşümlerini yapabilecek. 
builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);
builder.Services.AddOcelot(builder.Configuration);

// Add services to the container.

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

app.UseAuthorization();

app.MapControllers();

// programımızın ocelot servisini sürekli kullanmasını istiyoruz.
await app.UseOcelot();

app.Run();
