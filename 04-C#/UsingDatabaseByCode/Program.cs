using System.Data.SqlClient;


var connection = new SqlConnection(@"Data Source=.; Initial Catalog=lindaa; Integrated Security=true");


Console.WriteLine("Input one");
var inp1 = Console.ReadLine();
Console.WriteLine("Input Two");
var inp2 = Console.ReadLine();


connection.Open();
var insert = new SqlCommand(String.Format("Insert into Batch(batch,year) values('{0}','{1}')", inp1, inp2),connection);
var insert1 = insert.ExecuteReader();

insert1.Close();
var result = new SqlCommand("select * from batch", connection); 



var reader = result.ExecuteReader();
while (reader.Read())
{
    Console.WriteLine(reader.GetInt32(0));
    Console.WriteLine(reader.GetString(1));
    Console.WriteLine(reader.GetString(2));

}

