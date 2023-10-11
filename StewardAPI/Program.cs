using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
//using Serilog;

using System.Text;
using System;
using StewardAPI.Data;
using Model;
using StewardAPI.Repository.User;
using StewardAPI.Configuration;
using StewardAPI.ServiceExtension;
using StewardAPI.Repository.DepartmentRepo;
using StewardAPI.Models;
using StewardAPI.Repository.IDoctorRepository;
using StewardAPI.Repository.PatientRepository;
using StewardAPI.Repository.Global;
using StewardAPI.Repository.prescription;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddIdentityCore<ApplicationUser>()
               .AddRoles<IdentityRole>()
               .AddEntityFrameworkStores<AppDbContext>();

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
builder.Services.AddScoped<IDoctorRepository, DoctorRepo>();
builder.Services.AddScoped<IPatientRepository, PatientRepository>();
builder.Services.AddScoped<IGlobalComplaint, GlobalComplaint>();
builder.Services.AddScoped<IGlobalAdvice, GlobalAdviceRepo>();
builder.Services.AddScoped<IGlobalDignosis, GlobalDignosisRepo>();
builder.Services.AddScoped<IGlobalInvestigation, GlobalInvestigationRepo>();
builder.Services.AddScoped<IGlobalMedicine, GlobalMedicine>();

builder.Services.AddScoped<IComplaintRepo, ComplaintRepo>();
builder.Services.AddAutoMapper(typeof(MapperConfig));


builder.Services.ConfigureSqlContext(builder.Configuration);
builder.Services.AddHttpContextAccessor();
builder.Services.ConfigureSwagger();
builder.Services.AddCors();
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme =
    JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

}).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ClockSkew = TimeSpan.Zero,
        ValidIssuer = builder.Configuration["JwtSettings:Issuer"],
        ValidAudience = builder.Configuration["JwtSettings:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JwtSettings:Key"]))
    };
});
var app = builder.Build();

app.UseCors(builder => builder
     .AllowAnyOrigin()
     .AllowAnyMethod()
     .AllowAnyHeader());

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseStaticFiles();
app.UseHttpsRedirection();


app.MapControllers();

app.UseAuthentication();
app.UseAuthorization();


app.Run();
