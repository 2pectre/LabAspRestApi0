using System.Data;
using LabAspApi.Services;
using Microsoft.Data.SqlClient;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets; // Ensure Azure SDK packages are up to date

var builder = WebApplication.CreateBuilder(args);

// > Azure Key Vault
//var client = new SecretClient(new Uri($"https://specter.vault.azure.net"), new DefaultAzureCredential());
var client = new SecretClient(new Uri($"https://specter.vault.azure.net"), new ClientSecretCredential(Environment.GetEnvironmentVariable("AZURE_TENANT_ID"), Environment.GetEnvironmentVariable("AZURE_CLIENT_ID"), Environment.GetEnvironmentVariable("AZURE_CLIENT_SECRET")));

var server = client.GetSecret("Server").Value.Value;
var userId = client.GetSecret("User-Id").Value.Value;
var password = client.GetSecret("Password").Value.Value;

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
connectionString = connectionString?.Replace("{server}", server).Replace("{User-Id}", userId).Replace("{Password}", password);
builder.Services.AddScoped<IDbConnection>(sp => new SqlConnection(connectionString));

// > MVC 패턴 Controller 사용 설정
builder.Services.AddControllers();

// > 의존성 주입(DI)
// > AddScoped : 각 요청마다 하나의 인스턴스를 생성하고 요청 내에서는 재사용
// > AddTransient : 요청될 때마다 새로운 인스턴스를 생성하며, 상태 공유 안함
builder.Services.AddScoped<ProductsService>();
builder.Services.AddScoped<TestService>();

var app = builder.Build();

// > 개발 환경 예외 발생 출력 미들웨어 설정
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

// > 라우팅, 인증, 권한 부여 등의 미들웨어 설정
app.UseRouting();
app.UseAuthorization();
app.MapControllers();

// > API 시작
app.Run();