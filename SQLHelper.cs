using System;
using System.Data;
using System.Data.SqlClient;

namespace Apartman_Otamasyon
{
    class SQLHelper
    {
        // Veritabanı bağlantı dizesi (connection string)
        public string ConnectionString { get; set; }
        // SqlConnection nesnesi
        public SqlConnection Connection { get; set; }

        // Yapıcı metot (constructor): Bağlantı dizesi ve SqlConnection'ı başlatır
        public SQLHelper()
        {
            // SqlConnection nesnesini başlatır
            Connection = new SqlConnection(ConnectionString);
            // Veritabanı bağlantı dizesini belirler
            ConnectionString = @"Data Source=elıf;Initial Catalog=Apartman;Integrated Security=True";
            // Connection nesnesinin bağlantı dizesini ayarlar
            Connection.ConnectionString = ConnectionString;
        }

        // Stored Procedure çalıştırmak için kullanılan metot
        public void ExecuteProc(string procName, params SqlParameter[] ps)
        {
            // SqlCommand nesnesi oluşturur
            SqlCommand command = new SqlCommand();
            // Komut türünü "Stored Procedure" olarak belirler
            command.CommandType = CommandType.StoredProcedure;
            // Çalıştırılacak procedure adını belirler
            command.CommandText = procName;
            // Parametreleri komuta ekler
            command.Parameters.AddRange(ps);
            // Bağlantıyı, önceden tanımlanan SqlConnection'a atar
            command.Connection = Connection;
            // Bağlantıyı açar
            Connection.Open();
            // Komutu çalıştırır (veri işlemi yapılmaz, sadece komut çalıştırılır)
            command.ExecuteNonQuery();


        }
        public DataTable GetTable(string query)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, ConnectionString);
            DataTable dt = new DataTable();
            adapter.Fill(dt); // data tavle doldurmak icin 
            return dt;  
        }
    }
}