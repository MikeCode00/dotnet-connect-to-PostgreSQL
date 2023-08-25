
using System.Data;
using Npgsql;

IDbConnection ConnectDB() {
  return new NpgsqlConnection("Host=localhost;Username=mike;Password=password;Port=5432;Database=test");
}

void OpenDb() {
  var conn = ConnectDB();
  try
  {
    conn.Open();
    Console.WriteLine("Database connection is on");
    conn.Close();
  }
  catch (System.Exception e)
  {
    Console.WriteLine(e.Message);
    throw;
  }
}

OpenDb();