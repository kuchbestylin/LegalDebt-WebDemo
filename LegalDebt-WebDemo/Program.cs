using BlazorBootstrap;
using LegalDebt_WebDemo.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Radzen;
using SharedProject.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddBlazorBootstrap();
builder.Services.AddScoped<DialogService>();
builder.Services.AddScoped<NotificationService>();
builder.Services.AddScoped<TooltipService>();
builder.Services.AddScoped<ContextMenuService>();
//builder.Services.AddScoped<TwilioService>(sp =>
//{
//    var twilioSettings = builder.Configuration.GetSection("TwilioSettings").Get<TwilioSettings>();
//    return new TwilioService(twilioSettings.AccountSid,twilioSettings.AuthToken, twilioSettings.SourcePhoneNumber);
//});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
public class TwilioSettings
{
    public required string AccountSid { get; set; }
    public required string AuthToken { get; set; }
    public required string SourcePhoneNumber { get; set; }
}