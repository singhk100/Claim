using Claim;
using Claim.ClaimDBContext;
using Claim.Interfaces;
using Claim.Repository;
using Claim.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ClaimsDBContext>
    (options => options.UseSqlServer(builder.Configuration.GetConnectionString("ClaimConnectionString")));
builder.Services.AddScoped<IClaimServices, ClaimService>();
builder.Services.AddScoped<IClaimsRepository, ClaimsRepository>();
builder.Services.TryAddScoped<ClaimsRepository>();
builder.Services.TryAddScoped<Query>();
builder.Services.TryAddScoped<PolicyRepository>();
builder.Services.TryAddScoped<CustomerRepository>();
builder.Services.TryAddScoped<ClaimantRepository>();




//builder.Services.AddTransient<IQuery, Query>();




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

app.Run();
