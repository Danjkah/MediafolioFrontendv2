using MediafolioFrontend.Components;
using MediafolioFrontend.Components.Pages;
using MediafolioFrontend.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddScoped(sp => new HttpClient());
builder.Services.AddScoped<IVideoService,VideoService>();
builder.Services.AddScoped<IReviewService,ReviewService>();
builder.Services.AddScoped<ILogService,LogService>();
builder.Services.AddScoped<IVideoGameService,VideoGameService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
