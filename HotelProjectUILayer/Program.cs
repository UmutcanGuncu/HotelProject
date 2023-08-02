using DataAccessLayer.Context;
using FluentValidation;
using FluentValidation.AspNetCore;
using HotelProjectUILayer.Dtos.GuestDto;
using HotelProjectUILayer.ValidationRules.Guest;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<IValidator<CreateGuestDto>, CreateGuestValidator>();
builder.Services.AddTransient<IValidator<UpdateGuestDto>, UpdateGuestValidation>();
builder.Services.AddControllersWithViews().AddFluentValidation();
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddHttpClient();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Default}/{action=Index}/{id?}");
app.MapControllerRoute(
    name: "MyArea",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.Run();

