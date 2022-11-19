using CaramoissantApi.Commons;
using CaramoissantApi.Handlers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddInfrastructure(builder.Configuration);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.Urls.Add("https://172.105.69.103:5024");
app.Urls.Add("http://localhost:5024");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors(x => x
    .AllowAnyMethod()
    .AllowAnyHeader()
    .SetIsOriginAllowed(origin => true)
    .AllowCredentials());
}
else
{
    app.UseHttpsRedirection();
}
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.UseMiddleware<ErrorHandlerMiddleware>();
app.MapControllers();
app.Run();
