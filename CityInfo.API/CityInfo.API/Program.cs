using Microsoft.AspNetCore.StaticFiles;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(options =>
{
    //this allows us to forbid the program to print the wrong format (header application/json cannot print an xml format and vice versa)
    options.ReturnHttpNotAcceptable = true;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//With this, we will be able to allow any file to be downloaded from our API
builder.Services.AddSingleton<FileExtensionContentTypeProvider>();

var app = builder.Build();

// Configure the HTTP request pipeline.
//how to check which environment we are in? right click on projectName.API in the solution explorer --> properties --> debug --> open debug UI blabla and here is the environment (in dev by default)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints => 
{ 
    endpoints.MapControllers();
});

// no need to use endpoint separatly because it already included
app.MapControllers();

app.Run();

// the main method is added behind the scenes