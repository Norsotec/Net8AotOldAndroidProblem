var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseStaticWebAssets();                       // ADD STEP 7


// Add services to the container.
builder.Services.AddControllersWithViews();                 // CHANGE STEP 7
builder.Services.AddRazorPages();                           // ADD STEP 7

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseWebAssemblyDebugging();                          // ADD STEP 7
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();                              // ADD STEP 7
app.UseStaticFiles();                                       // ADD STEP 7

app.UseAuthorization();

app.MapRazorPages();                                        // ADD STEP 7
app.MapControllers();
app.MapFallbackToFile("index.html");                        // ADD STEP 7

app.Run();
