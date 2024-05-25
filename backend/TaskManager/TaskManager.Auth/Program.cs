using Microsoft.AspNetCore.CookiePolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using TaskManager.Application.Utils;
using TaskManager.Auth.Extensions;
using TaskManager.Core.Utils.Abstractions;
using TaskManager.DataAccess.Auth.DBContext;
using TaskManager.DataAccess.Mapping;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var configuration = builder.Configuration;

services.Configure<JwtOptions>(configuration.GetSection(nameof(JwtOptions)));
var jwtOptions = configuration.GetSection(nameof(JwtOptions)).Get<JwtOptions>();
services.AddApiAuthentication(Options.Create(jwtOptions));

services.AddAutoMapper(typeof(AuthMapping));

services.AddDbContext<AuthDBContext>(options =>
{
    options.UseSqlite(configuration.GetConnectionString(nameof(AuthDBContext)));
});

services.AddControllers();
services.AddSwaggerGen();

services.AddScoped<IJwtProvider, JwtProvider>();
services.AddScoped<IPasswordHasher, PasswordHasher>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseCookiePolicy(new CookiePolicyOptions
{
    MinimumSameSitePolicy = SameSiteMode.Strict,
    HttpOnly = HttpOnlyPolicy.Always,
    Secure = CookieSecurePolicy.Always
});

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();