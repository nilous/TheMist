using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace TheMist
{
    public class ConnectionHelper
    {
        public static ConnectionHelper Instance = new ConnectionHelper();

        public string Host { get; set; }
        public string Database { get; set; }
        public string User { get; set; }
        public string Password { get; set; }

        public NpgsqlConnection Connect()
        {
            var connStr = $"Host={Host};Username={User};Password={Password};Database={Database}";
            return new NpgsqlConnection(connStr);
        }

        public void LoadSettings()
        {
            try
            {
                using (var reader = File.OpenText("./db.dat"))
                {
                    var json = reader.ReadToEnd();
                    var obj = JsonConvert.DeserializeObject<ConnectionHelper>(json);
                    Host = obj.Host;
                    Database = obj.Database;
                    User = obj.User;
                    Password = obj.Password;
                }
            }
            catch (Exception)
            {
                Host = Database = User = Password = "";
                //MessageBox.Show(ex.Message);
            }
        }

        public void SaveSettings()
        {
            var s = JsonConvert.SerializeObject(this);
            try
            {
                using (var fs = new FileStream("./db.dat", FileMode.Create))
                {
                    using (var w = new BinaryWriter(fs))
                    {
                        fs.Write(Encoding.ASCII.GetBytes(s), 0, s.Length);
                    }
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
