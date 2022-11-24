using System.Data.SqlClient;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

SqlConnection con = new SqlConnection("Server=tcp:disasternpodbserver.database.windows.net,1433;Initial Catalog=DisasterNPO_db;Persist Security Info=False;User ID=JasonN42;Password=Khanajj1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

// tables have already been created, that is why ive commented the connection
con.Open();
//SqlCommand cmdCreateMoneyDonations = new SqlCommand("CREATE TABLE MoneyDonations(Money int,Date Date,Name varchar(255));", con);
//SqlCommand cmdCreateDisaster = new SqlCommand("CREATE TABLE Disaster(Aidtypes varchar(225),StartDate Date,EndDate Date,Location varchar(255),Description varchar(255),MoneyAccocated int);", con);
//SqlCommand cmdCreateDonations = new SqlCommand("CREATE TABLE Donations(DonationID int,Name varchar(255),Category varchar(255),Quantity int);", con);
//SqlCommand cmdUsers = new SqlCommand("CREATE TABLE Users(UserName varchar(255),Password varchar(255));", con);
//cmdCreateDisaster.ExecuteNonQuery();
//cmdCreateMoneyDonations.ExecuteNonQuery();
//cmdCreateDonations.ExecuteNonQuery();
//cmdUsers.ExecuteNonQuery();
//The tables
con.Close();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Login}/{id?}");

app.Run();
