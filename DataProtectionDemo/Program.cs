using Microsoft.AspNetCore.DataProtection;

// Create a Data Protection provider  
var provider = DataProtectionProvider.Create("MyApp");
var protector = provider.CreateProtector("SensitiveDataProtector");

// Encrypt data  
string originalData = "MySecretPassword123";
string encryptedData = protector.Protect(originalData);
Console.WriteLine($"Encrypted: {encryptedData}");

// Decrypt data  
string decryptedData = protector.Unprotect(encryptedData);
Console.WriteLine($"Decrypted: {decryptedData}");

//var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddDataProtection();

/******************** Key Storage ********************/
//builder.Services.AddDataProtection()
//    .PersistKeysToFileSystem(new DirectoryInfo(@"C:\Keys"));

/******************** Avoid Hardcoding Protectors ********************/
//var protector = provider.CreateProtector("App.Purpose.FileEncryption");

/******************** Key Lifetime ********************/
//builder.Services.AddDataProtection()  
//    .SetDefaultKeyLifetime(TimeSpan.FromDays(90));

/******************** Secure Cross-App Sharing ********************/
//builder.Services.AddDataProtection()
//    .SetApplicationName("SharedApp")
//    .PersistKeysToFileSystem(new DirectoryInfo(@"C:\SharedKeys"));

//var app = builder.Build();
//app.Run();