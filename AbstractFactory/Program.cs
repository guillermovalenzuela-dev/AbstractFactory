using AbstractFactory.Models.Client;
using AbstractFactory.Models.PrepaidPlan;
using Asp.Versioning;
using Asp.Versioning.Conventions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddApiVersioning(options =>
{
    options.DefaultApiVersion = new ApiVersion(1);
    options.ReportApiVersions = true;
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.ApiVersionReader = ApiVersionReader.Combine(
        new UrlSegmentApiVersionReader(),
        new HeaderApiVersionReader("X-Api-Version"));
}).AddApiExplorer(options =>
{
    options.GroupNameFormat = "'v'V";
    options.SubstituteApiVersionInUrl = true;
});

var app = builder.Build();

var versionSet = app.NewApiVersionSet()
                    .HasApiVersion(1.0)
                    .HasApiVersion(2.0)
                    .ReportApiVersions()
                    .Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/packages", (PrepaidPlanPackage plan) =>
{
    PrepaidPlanClient client = new PrepaidPlanClient(plan);
    return client.Resume();
}).WithApiVersionSet(versionSet)
   .MapToApiVersion(1.0);

app.MapGet("/packages", (string plan) =>
{
    PrepaidPlanClient client = new PrepaidPlanClient(plan);
    return client.Resume();
}).WithApiVersionSet(versionSet)
   .MapToApiVersion(2.0);

app.Run();
