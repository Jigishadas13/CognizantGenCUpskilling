using System;
using System.Data.SqlClient;

class Program
{
    static void Main(string[] args)
    {
        // Connection String
        string conString =
        "Data Source=localhost;Initial Catalog=JigishaDB;Integrated Security=True";

        SqlConnection con = new SqlConnection(conString);

        con.Open();

        Console.WriteLine("Database Connected");

        // INSERT
        string insertQuery =
        "INSERT INTO Employees(Name, Salary) VALUES('Jigisha',50000)";

        SqlCommand insertCmd = new SqlCommand(insertQuery, con);

        insertCmd.ExecuteNonQuery();

        Console.WriteLine("Data Inserted");

        // READ
        string readQuery = "SELECT * FROM Employees";

        SqlCommand readCmd = new SqlCommand(readQuery, con);

        SqlDataReader reader = readCmd.ExecuteReader();

        Console.WriteLine();

        Console.WriteLine("Employee Records");

        while (reader.Read())
        {
            Console.WriteLine(
                reader["Id"] + " " +
                reader["Name"] + " " +
                reader["Salary"]);
        }

        reader.Close();

        // UPDATE
        string updateQuery =
        "UPDATE Employees SET Salary=60000 WHERE Name='Jigisha'";

        SqlCommand updateCmd = new SqlCommand(updateQuery, con);

        updateCmd.ExecuteNonQuery();

        Console.WriteLine();

        Console.WriteLine("Data Updated");

        // DELETE
        string deleteQuery =
        "DELETE FROM Employees WHERE Name='Jigisha'";

        SqlCommand deleteCmd = new SqlCommand(deleteQuery, con);

        deleteCmd.ExecuteNonQuery();

        Console.WriteLine("Data Deleted");

        con.Close();
    }
}