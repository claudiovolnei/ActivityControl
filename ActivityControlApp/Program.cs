using ActivityControlApp.Data;
using ActivityControlApp.Handlers;
using ActivityControlApp.Services;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

var appSettingSection = builder.Configuration.GetSection("AppSettings");
builder.Services.Configure<AppSettings>(appSettingSection);
builder.Services.AddTransient<ValidateHeaderHandler>();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddHttpClient<IUserService, UserService>();
builder.Services.AddHttpClient<IBookStoresService<Author>, BookStoresService<Author>>()
     .AddHttpMessageHandler<ValidateHeaderHandler>();
builder.Services.AddHttpClient<IBookStoresService<Publisher>, BookStoresService<Publisher>>()
      .AddHttpMessageHandler<ValidateHeaderHandler>();

builder.Services.AddSingleton<HttpClient>();

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("SeniorEmployee", policy =>
        policy.RequireClaim("IsUserEmployedBefore1990", "true"));
});

var app = builder.Build();

if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapBlazorHub();
    endpoints.MapFallbackToPage("/_Host");
});

app.Run();