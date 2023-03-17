using DemoProject;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//Lifetimes: 
//Scoped - Creates a new instance for each HTTP Request(Recommendet for Asp.Net Core mos t of the time)
//Transient - Creates a new instance everytime the service is requested
//Singleton - Creates only one instance for as long as the application is running

builder.Services.AddScoped<NameService>();
builder.Services.AddScoped<SomeOtherService>();

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
app.UseMiddleware<ExceptionMiddleware>();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
