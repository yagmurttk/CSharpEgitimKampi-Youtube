using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Crud-->Create - Read - Update - Delete

            Console.WriteLine("***** Menü Sipariş İşlem Paneli ***** ");
            Console.WriteLine();

            Console.WriteLine("-----------------------------------------");

            #region Kategori Ekleme İşlemi (Insert)
            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GI3R06F\\SQLEXPRESS; initial catalog=EgitimKampiDb; integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into Tbl_Category (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Kategori başarıyla eklenmiştir.");


            #endregion

            #region Ürün Ekleme İşlemi 

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Ürün Adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GI3R06F\\SQLEXPRESS;initial catalog=EgitimKampiDb; integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into Tbl_Product (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Ürün başarıyla eklenmiştir.");

            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GI3R06F\\SQLEXPRESS;initial catalog=EgitimKampiDb; integrated security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From Tbl_Product", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();

            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GI3R06F\\SQLEXPRESS;initial catalog=EgitimKampiDb; integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From Tbl_Product Where ProductID=@productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Silme işlemi başarıyla gerçekleşmiştir.");

            #endregion

            #region Ürün Güncelleme İşlemi

            //Console.Write("Güncellenecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek Ürün Adı: ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellenecek Ürün Fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GI3R06F\\SQLEXPRESS;initial catalog=EgitimKampiDb; integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Update Tbl_Product Set ProductName=@productName,ProductPrice=@productPrice where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Güncelleme işlemi başarıyla gerçekleşmiştir.");

            #endregion
        }
    }
}
