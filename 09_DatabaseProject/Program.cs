using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ado.net
            // C# programlama dilinde SQL yapılarını kullanmamıza olanak sağlayan bir çerçevedir.

            Console.WriteLine("***** C# Veri Tabanlı Ürün Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();


            string tableNumber;

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("1- Kategoriler");
            Console.WriteLine("2- Ürünler");
            Console.WriteLine("3- Siparişler");
            Console.WriteLine("4- Çıkış Yap");
            Console.WriteLine();
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("------------------------------------------");

            // Data Source = SQL Veri tabanı server adı / initial Catalog = Veri tabanı ismi / integrated security = bağlantının güvenilir olup olmadığı
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GI3R06F\\SQLEXPRESS; initial Catalog=EgitimKampiDb; integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From Tbl_Category", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            //Sql Data Adapter = C# tarafında oluşturulan sorguyu SQL veri tabanı arasında bir köprü görecek olan sınıftır.
            DataTable dataTable = new DataTable(); // Data Table verileri belleğe almamızı sağlayacak
            adapter.Fill(dataTable);

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();

                connection.Close();





            }
        }
    }
}