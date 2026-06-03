using AppLoginAspCore.Repositories.Contract;
<<<<<<< HEAD
using WebApplication1.Libraries.Login;
=======
>>>>>>> 64309fa5bb016cb7f8069abf670c5af2ec60790a
using WebApplication1.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

<<<<<<< HEAD
// Adicionado para manipular as sessões
builder.Services.AddHttpContextAccessor();

//Adicionar a Interface como um servico
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<IColaboradorRepository, ColaboradorRepository>();

//Corrigir problema com TEMPDATA
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    // Define o tempo de expiração da sessão
    options.IdleTimeout = TimeSpan.FromSeconds(60);
    options.Cookie.HttpOnly = true;
    // Mostrar para o navegador que o cookie e essencial
    options.Cookie.IsEssential = true;
});

builder.Services.AddMvc().AddSessionStateTempDataProvider();

builder.Services.AddScoped<WebApplication1.Libraries.Sessao.Sessao>();
builder.Services.AddScoped<LoginCliente>();

var app = builder.Build();

=======
// Add alguma coisa
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<IColaboradorRepository, ColaboradorRepository>();
builder.Services.AddScoped<WebApplication1.Libraries.Sessao.Sessao>();

var app = builder.Build();

builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(60);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

>>>>>>> 64309fa5bb016cb7f8069abf670c5af2ec60790a
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
<<<<<<< HEAD
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseHttpsRedirection();
app.UseDefaultFiles();
app.UseCookiePolicy();
app.UseSession();

=======
>>>>>>> 64309fa5bb016cb7f8069abf670c5af2ec60790a
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

<<<<<<< HEAD
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
=======
app .UseCookiePolicy();

app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();
>>>>>>> 64309fa5bb016cb7f8069abf670c5af2ec60790a


app.Run();
