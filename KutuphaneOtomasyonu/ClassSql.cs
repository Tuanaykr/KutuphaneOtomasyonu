using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    internal class ClassSql
    {
        private string _connectionString;
        private static ClassSql _instance;

        public ClassSql(string connectionString)
        {
            _connectionString = connectionString;
        }

        public static ClassSql GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ClassSql("Data Source=LAPTOP-0MDR6GEA\\SQLEXPRESS;Initial Catalog=KutuphaneOtomasyonu;Integrated Security=True;");
            }
            return _instance;
        }


        public bool TelefonVarMi(string telefon)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM uye WHERE telefon = @Telefon";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Telefon", telefon);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public bool EmailVarMi(string email)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM uye WHERE eMail = @Email";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public bool KayitOl(string tableName, string ad, string soyad, string email, string sifre, string telefon, string adres)
        {
            if (TelefonVarMi(telefon))
            {
                MessageBox.Show("Bu telefon numarası zaten kayıtlı.");
                return false;
            }

            if (EmailVarMi(email))
            {
                MessageBox.Show("Bu e-posta adresi zaten kayıtlı.");
                return false;
            }

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = $"INSERT INTO {tableName} (ad, soyad, eMail, sifre, telefon, adres) VALUES (@Ad, @Soyad, @Email, @Sifre, @Telefon, @Adres)";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Ad", ad);
                    command.Parameters.AddWithValue("@Soyad", soyad);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Sifre", sifre);
                    command.Parameters.AddWithValue("@Telefon", telefon);
                    command.Parameters.AddWithValue("@Adres", adres);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        
        public string GirisKontrol(string email, string sifre)
        {
            string rol = string.Empty;
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("sp_GirisKontrol", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Sifre", sifre);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            rol = reader["Rol"].ToString();
                        }
                        else
                        {
                            throw new Exception("Kullanıcı veya şifre hatalı.");
                        }
                    }
                }
            }
            return rol;
        }




        public DataTable TumAdminleriGetir()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM admin";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        public DataTable FiltreleAdmin(string anahtarKelime)
        {
            DataTable dataTable = new DataTable();

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM admin WHERE Ad LIKE @AnahtarKelime OR Soyad LIKE @AnahtarKelime";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AnahtarKelime", "%" + anahtarKelime + "%");

                    try
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataTable);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Filtreleme sırasında bir hata oluştu: {ex.Message}");
                    }
                }
            }
            return dataTable;
        }


        public DataTable TumUyeleriGetir()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM uye";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        public DataTable FiltreleUye(string anahtarKelime)
        {
            DataTable dataTable = new DataTable(); // Filtrelenmiş verileri saklamak için bir DataTable oluştur

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM uye WHERE Ad LIKE @AnahtarKelime OR Soyad LIKE @AnahtarKelime";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    
                    command.Parameters.AddWithValue("@AnahtarKelime", "%" + anahtarKelime + "%");

                    try
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataTable);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Filtreleme sırasında bir hata oluştu: {ex.Message}");
                    }
                }
            }

            return dataTable;
        }


        public DataTable TumKitaplariGetir()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = @"
            SELECT k.kitapID, k.ISBN, k.ad, k.yazar, k.baskiYili, k.yayinEvi, k.sayfaSayisi, k.aciklama, kk.kategoriID 
            FROM kitap k
            LEFT JOIN kitap_kategori kk ON k.kitapID = kk.kitapID";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        public DataTable TumRaftakiKitaplariGetir()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM kitap WHERE kitapDurumu = 1"; // kitapDurumu 1 olan kitaplar rafta demek
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }

            return dataTable;
        }


        public DataTable FiltreleKitap(string anahtarKelime)
        {
            DataTable dataTable = new DataTable(); 

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM kitap WHERE ISBN LIKE @AnahtarKelime OR Ad LIKE @AnahtarKelime OR yazar LIKE @AnahtarKelime ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AnahtarKelime", "%" + anahtarKelime + "%");

                    try
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataTable);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Filtreleme sırasında bir hata oluştu: {ex.Message}");
                    }
                }
            }

            return dataTable;
        }


        public DataTable TumIslemleriGetir()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM islem";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }

            return dataTable;
        }


        public DataTable FiltreleIslem(string anahtarKelime)
        {
            DataTable dataTable = new DataTable();

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM islem WHERE emanetDurumu LIKE @AnahtarKelime OR islemID LIKE @AnahtarKelime";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AnahtarKelime", "%" + anahtarKelime + "%");

                    try
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataTable);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Filtreleme sırasında bir hata oluştu: {ex.Message}");
                    }
                }
            }

            return dataTable;
        }



        public bool KitapEkle(string isbn, string kitapAdi, string yazar, string baskiYili, string yayinEvi, string sayfaSayisi, string aciklama, int kategoriID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // ISBN kontrolü
                    string isbnCheckQuery = "SELECT COUNT(*) FROM kitap WHERE ISBN = @ISBN";
                    using (SqlCommand isbnCheckCommand = new SqlCommand(isbnCheckQuery, connection, transaction))
                    {
                        isbnCheckCommand.Parameters.AddWithValue("@ISBN", isbn);
                        int count = (int)isbnCheckCommand.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Aynı ISBN numarası ile kayıt yapılamaz.");
                            return false;
                        }
                    }

                    string kitapQuery = "INSERT INTO kitap (ISBN, ad, yazar, baskiYili, yayinEvi, sayfaSayisi, aciklama, kitapDurumu, adminID) " +
                                        "OUTPUT INSERTED.kitapID " +
                                        "VALUES (@ISBN, @Ad, @Yazar, @BaskiYili, @YayinEvi, @SayfaSayisi, @Aciklama, 1, 1)";

                    int kitapID;
                    using (SqlCommand kitapCommand = new SqlCommand(kitapQuery, connection, transaction))
                    {
                        kitapCommand.Parameters.AddWithValue("@ISBN", isbn);
                        kitapCommand.Parameters.AddWithValue("@Ad", kitapAdi);
                        kitapCommand.Parameters.AddWithValue("@Yazar", yazar);
                        kitapCommand.Parameters.AddWithValue("@BaskiYili", baskiYili);
                        kitapCommand.Parameters.AddWithValue("@YayinEvi", yayinEvi);
                        kitapCommand.Parameters.AddWithValue("@SayfaSayisi", sayfaSayisi);
                        kitapCommand.Parameters.AddWithValue("@Aciklama", aciklama);

                        kitapID = (int)kitapCommand.ExecuteScalar();
                    }

                    string kitapKategoriQuery = "INSERT INTO kitap_kategori (kitapID, kategoriID) VALUES (@KitapID, @KategoriID)";

                    using (SqlCommand kitapKategoriCommand = new SqlCommand(kitapKategoriQuery, connection, transaction))
                    {
                        kitapKategoriCommand.Parameters.AddWithValue("@KitapID", kitapID);
                        kitapKategoriCommand.Parameters.AddWithValue("@KategoriID", kategoriID);
                        kitapKategoriCommand.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Kitap eklenirken bir hata oluştu: {ex.Message}");
                    return false;
                }
            }
        }
        
        public DataTable TumKategorileriGetir()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM kategori";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            }

            return dataTable;
        }

        public bool KitapGuncelle(int kitapID, string isbn, string kitapAdi, string yazar, string baskiYili, string yayinEvi, string sayfaSayisi, string aciklama, int kategoriID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string kitapQuery = "UPDATE kitap SET ISBN = @ISBN, ad = @Ad, yazar = @Yazar, baskiYili = @BaskiYili, yayinEvi = @YayinEvi, sayfaSayisi = @SayfaSayisi, aciklama = @Aciklama WHERE kitapID = @KitapID";

                    using (SqlCommand kitapCommand = new SqlCommand(kitapQuery, connection, transaction))
                    {
                        kitapCommand.Parameters.AddWithValue("@KitapID", kitapID);
                        kitapCommand.Parameters.AddWithValue("@ISBN", isbn);
                        kitapCommand.Parameters.AddWithValue("@Ad", kitapAdi);
                        kitapCommand.Parameters.AddWithValue("@Yazar", yazar);
                        kitapCommand.Parameters.AddWithValue("@BaskiYili", baskiYili);
                        kitapCommand.Parameters.AddWithValue("@YayinEvi", yayinEvi);
                        kitapCommand.Parameters.AddWithValue("@SayfaSayisi", sayfaSayisi);
                        kitapCommand.Parameters.AddWithValue("@Aciklama", aciklama);

                        kitapCommand.ExecuteNonQuery();
                    }

                    string kitapKategoriQuery = "UPDATE kitap_kategori SET kategoriID = @KategoriID WHERE kitapID = @KitapID";

                    using (SqlCommand kitapKategoriCommand = new SqlCommand(kitapKategoriQuery, connection, transaction))
                    {
                        kitapKategoriCommand.Parameters.AddWithValue("@KitapID", kitapID);
                        kitapKategoriCommand.Parameters.AddWithValue("@KategoriID", kategoriID);
                        kitapKategoriCommand.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Kitap güncellenirken bir hata oluştu: {ex.Message}");
                    return false;
                }
            }
        }

        public bool IslemEkle(int uyeID, int kitapID, DateTime islemTarihi, DateTime iadeTarihi, int adminID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "INSERT INTO islem (uyeID, kitapID, islemTarihi, iadeTarihi, adminID) VALUES (@UyeID, @KitapID, @IslemTarihi, @IadeTarihi, @AdminID)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UyeID", uyeID);
                    command.Parameters.AddWithValue("@KitapID", kitapID);
                    command.Parameters.AddWithValue("@IslemTarihi", islemTarihi);
                    command.Parameters.AddWithValue("@IadeTarihi", iadeTarihi);
                    command.Parameters.AddWithValue("@AdminID", adminID);

                    try
                    {
                        command.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"İşlem eklenirken bir hata oluştu: {ex.Message}");
                        return false;
                    }
                }
            }
        }


        public bool IslemSil(int islemID)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "DELETE FROM islem WHERE islemID = @IslemID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IslemID", islemID);

                    try
                    {
                        command.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"İşlem silinirken bir hata oluştu: {ex.Message}");
                        return false;
                    }
                }
            }
        }


        public int GetAdminIDByEmail(string email)
        {
            int adminID = 0;
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT adminID FROM admin WHERE Email = @Email";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            adminID = reader.GetInt32(0);
                        }
                    }
                }
            }
            return adminID;
        }


        public DataTable GetUyeDataByID(int uyeID)
        {
            DataTable dataTable = new DataTable();
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM uye WHERE uyeID = @UyeID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UyeID", uyeID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
            }
            return dataTable;
        }

        
        public int GetUyeIDByEmail(string email)
        {
            int uyeID = 0;
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT uyeID FROM uye WHERE Email = @Email";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            uyeID = reader.GetInt32(0);
                        }
                    }
                }
            }
            return uyeID;
        }


        public string GetKitapEmanetDurumu(int kitapID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT emanetDurumu FROM kitap WHERE kitapID = @KitapID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@KitapID", kitapID);

                    try
                    {
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            return result.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Belirtilen kitap bulunamadı.");
                            return null;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Kitap emanet durumu alınırken bir hata oluştu: {ex.Message}");
                        return null;
                    }
                }
            }
        }


        public bool AdminEkle(string ad, string soyad, string email, string telefon, string adres)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string checkQuery = "SELECT COUNT(*) FROM admin WHERE email = @Email";

                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@Email", email);
                    int count = (int)checkCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        return false;
                    }
                }

                string query = "INSERT INTO admin (ad, soyad, email, telefon, adres) VALUES (@Ad, @Soyad, @Email, @Telefon, @Adres)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Ad", ad);
                    command.Parameters.AddWithValue("@Soyad", soyad);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Telefon", telefon);
                    command.Parameters.AddWithValue("@Adres", adres);

                    try
                    {
                        command.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Admin eklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }


        public bool AdminGuncelle(int adminID, string ad, string soyad, string email, string telefon, string adres)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "UPDATE admin SET ad = @Ad, soyad = @Soyad, email = @Email, telefon = @Telefon, adres = @Adres WHERE adminID = @AdminID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AdminID", adminID);
                    command.Parameters.AddWithValue("@Ad", ad);
                    command.Parameters.AddWithValue("@Soyad", soyad);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Telefon", telefon);
                    command.Parameters.AddWithValue("@Adres", adres);

                    try
                    {
                        command.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Admin güncellenirken bir hata oluştu: {ex.Message}");
                        return false;
                    }
                }
            }
        }


        public bool AdminSil(int adminID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "DELETE FROM admin WHERE adminID = @AdminID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AdminID", adminID);

                    try
                    {
                        command.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Admin silinirken bir hata oluştu: {ex.Message}");
                        return false;
                    }
                }
            }
        }


        public bool UyeEkle(string ad, string soyad, string email, string telefon, string adres)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string checkQuery = "SELECT COUNT(*) FROM uye WHERE email = @Email";

                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@Email", email);
                    int count = (int)checkCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        return false;
                    }
                }

                string query = "INSERT INTO uye (ad, soyad, email, telefon, adres) VALUES (@Ad, @Soyad, @Email, @Telefon, @Adres)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Ad", ad);
                    command.Parameters.AddWithValue("@Soyad", soyad);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Telefon", telefon);
                    command.Parameters.AddWithValue("@Adres", adres);

                    try
                    {
                        command.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Üye eklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }

       
        public bool UyeGuncelle(int uyeID, string ad, string soyad, string email, string telefon, string adres)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "UPDATE uye SET ad = @Ad, soyad = @Soyad, email = @Email, telefon = @Telefon, adres = @Adres WHERE uyeID = @UyeID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UyeID", uyeID);
                    command.Parameters.AddWithValue("@Ad", ad);
                    command.Parameters.AddWithValue("@Soyad", soyad);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Telefon", telefon);
                    command.Parameters.AddWithValue("@Adres", adres);

                    try
                    {
                        command.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Üye güncellenirken bir hata oluştu: {ex.Message}");
                        return false;
                    }
                }
            }
        }


        public bool UyeSil(int uyeID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "DELETE FROM uye WHERE uyeID = @UyeID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UyeID", uyeID);

                    try
                    {
                        command.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Üye silinirken bir hata oluştu: {ex.Message}");
                        return false;
                    }
                }
            }
        }


        public DataTable UyeBilgileriniGetir(int uyeID)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT ad, soyad, eMail, sifre, telefon, adres FROM uye WHERE uyeID = @UyeID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UyeID", uyeID);
                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }


        public DataTable UzerimdekiKitaplariGetir(int uyeID)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = @"
            SELECT k.kitapID, k.ad AS KitapAdi, k.yazar AS Yazar, i.islemTarihi AS EmanetTarihi, i.iadeTarihi AS IadeTarihi
            FROM islem i
            JOIN kitap k ON i.kitapID = k.kitapID
            WHERE i.uyeID = @uyeID AND i.emanetDurumu = 'EMANETTE'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@uyeID", uyeID);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }


        public bool TeslimVer(int uyeID, int kitapID, DateTime islemTarihi, DateTime iadeTarihi, int adminID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("TeslimVer", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@uyeID", uyeID);
                    command.Parameters.AddWithValue("@kitapID", kitapID);
                    command.Parameters.AddWithValue("@islemTarihi", islemTarihi);
                    command.Parameters.AddWithValue("@iadeTarihi", iadeTarihi);
                    command.Parameters.AddWithValue("@adminID", adminID);

                    try
                    {
                        command.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Teslim verilirken bir hata oluştu: {ex.Message}");
                        return false;
                    }
                }
            }
        }


        public bool TeslimAl(int islemID, int kitapID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("TeslimAl", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@islemID", islemID);
                    command.Parameters.AddWithValue("@kitapID", kitapID);

                    try
                    {
                        command.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Teslim alınırken bir hata oluştu: {ex.Message}");
                        return false;
                    }
                }
            }
        }


        public bool KitapIadeTarihiniGuncelle(int kitapID, DateTime yeniIadeTarihi)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "UPDATE islem SET iadeTarihi = @YeniIadeTarihi WHERE kitapID = @KitapID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@YeniIadeTarihi", yeniIadeTarihi);
                    command.Parameters.AddWithValue("@KitapID", kitapID);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Kitap iade tarihi güncellenirken bir hata oluştu: {ex.Message}");
                        return false;
                    }
                }
            }
        }


        public DataTable GetirGecmisKitaplar(int uyeID)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT kitap.ad AS 'Kitap Adı', kitap.yazar AS 'Yazar', islem.islemTarihi AS 'Alış Tarihi', islem.iadeTarihi AS 'İade Tarihi' " +
                               "FROM islem " +
                               "INNER JOIN kitap ON islem.kitapID = kitap.kitapID " +
                               "WHERE islem.uyeID = @UyeID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UyeID", uyeID);

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }


        public bool UyeBilgileriGuncelle(int uyeID, string ad, string soyad, string email, string sifre, string telefon, string adres)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = "UPDATE uye SET ad = @Ad, soyad = @Soyad, eMail = @Email, sifre = @Sifre, telefon = @Telefon, adres = @Adres WHERE uyeID = @UyeID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Ad", ad);
                        command.Parameters.AddWithValue("@Soyad", soyad);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Sifre", sifre);
                        command.Parameters.AddWithValue("@Telefon", telefon);
                        command.Parameters.AddWithValue("@Adres", adres);
                        command.Parameters.AddWithValue("@UyeID", uyeID);

                        int affectedRows = command.ExecuteNonQuery();
                        return affectedRows > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Üye bilgileri güncellenirken bir hata oluştu: " + ex.Message);
                return false;
            }
        }


        public bool UyeIadeEdilmemisKitabiVarMi(int uyeID)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM islem WHERE uyeID = @uyeID AND emanetDurumu = 'EMANETTE' AND iadeTarihi < GETDATE()";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@uyeID", uyeID);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}
