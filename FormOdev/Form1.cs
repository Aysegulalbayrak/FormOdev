using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        UrunDal _UrunDal = new UrunDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            
            kategoriAdiload();
            UrunAdiload();
            load1();
        }

        private void kategoriAdiload()
        {
            //Urün ekle bölümündeki kategori adını combox içinde getirmesi için
            var kategoriler = _UrunDal.KategoriGetAll();
            comboBox_kategori.DataSource = kategoriler;
            comboBox_kategori.DisplayMember = "KatagoriAdi";
            comboBox_kategori.ValueMember = "Id";
        }
        private void UrunAdiload()
        {
            //Satış ekle bölümündeki urun adını combox içinde getirmesi için
            var urunler = _UrunDal.GetAll();
            comboBox_urun.DataSource = urunler;
            comboBox_urun.DisplayMember = "UrunAdi";
            comboBox_urun.ValueMember = "Id";
        }

        private void load1()
        {
            dataGridView1.DataSource = _UrunDal.GetAll();
        }

        private void load2()
        {
            dataGridView1.DataSource = _UrunDal.KategoriGetAll();
        }
       
        private void load3()
        {
            dataGridView1.DataSource = _UrunDal.SatisGetAll();
        }
        private void btn_listele_Click(object sender, EventArgs e)
        {
            AA_OdevEntities db = new AA_OdevEntities();
            dataGridView1.DataSource = db.tblUruns.ToList();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_urunekle_Click(object sender, EventArgs e)
        {


            string kategoriAdi = comboBox_kategori.Text;
            int kategoriId = _UrunDal.GetKategoriIdByAd(kategoriAdi);

            try
            {
                if (kategoriId != -1)
                {
                    _UrunDal.UrunAdd(new tblUrun
                    {
                        UrunAdi = textBox_urunad.Text,
                        Fiyat = Convert.ToDecimal(textBox_urunfiyat.Text),
                        Stok = Convert.ToInt32(textBox_urunstok.Text),
                        KategoriId = kategoriId
                    });


                    MessageBox.Show("Ürün Başarlı Bir Şekilde Eklendi..");
                    load1();
                }
                else
                {
                    MessageBox.Show("Geçersiz kategori adı seçildi.");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Fiyat ve stoğa geçersiz veri tipi girildi. Lütfen sadece sayı giriniz");
            }


        }



        private void btn_satisekle_Click(object sender, EventArgs e)
        {
            string UrunAdi = comboBox_urun.Text;
            int urunId = _UrunDal.GetUrunIdByAd(UrunAdi);

            try
            {
                if (urunId != -1)
                {
                    _UrunDal.SatisAdd(new tblSati
                    {
                        Detay = textBox_satisdetay.Text,
                        StisTarihi = Convert.ToDateTime(dateTimePicker1.Value),
                        Discount = Convert.ToInt32(textBox_discount.Text),
                        UrunId = urunId,

                    });
                    
                    MessageBox.Show("Satış Başarlı Bir Şekilde Alındı..");
                    load1();
                }
                else
                {
                    MessageBox.Show("Geçersiz ürün adı seçildi.");
                }
            }
            catch (Exception )
            {

                MessageBox.Show("İndirime geçersiz veri tipi girildi. Lütfen sadece sayı giriniz");
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_tamamınılistele_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = _UrunDal.GetAll();

        }

        private void btn_urunGuncelle_Click(object sender, EventArgs e)
        {
            string kategoriAdi = comboBox_kategori.Text;
            int kategoriId = _UrunDal.GetKategoriIdByAd(kategoriAdi);
            _UrunDal.UrunUpdate(new tblUrun
            {
                Id= Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                UrunAdi = textBox_urunad.Text,
                Fiyat = Convert.ToDecimal(textBox_urunfiyat.Text),
                Stok = Convert.ToInt32(textBox_urunstok.Text),
                KategoriId = kategoriId
            });
            MessageBox.Show("Ürün başarılı bir şekilde güncellendi.");
            load1();
        }

        
        

        private void btn_satisListele_Click(object sender, EventArgs e)
        {
            load3();
        }

        private void btn_urunListele_Click(object sender, EventArgs e)
        {
            load1();
        }

        private void btn_satisGuncelle_Click(object sender, EventArgs e)
        {
            string UrunAdi = comboBox_urun.Text;
            int urunId = _UrunDal.GetUrunIdByAd(UrunAdi);

            
                _UrunDal.SatisUpdate(new tblSati
                {
                    Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                    Detay = textBox_satisdetay.Text,
                    StisTarihi = Convert.ToDateTime(dateTimePicker1.Value),
                    Discount = Convert.ToInt32(textBox_discount.Text),
                    UrunId = urunId



                });
                MessageBox.Show("Satış Başarlı Bir Şekilde Güncellendi..");
                load3();
            
        }

        private void btn_urunSil_Click(object sender, EventArgs e)
        {
            
            _UrunDal.UrunDelete(new tblUrun
            {
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
            });
            MessageBox.Show("Ürün başarılı bir şekilde silindi..");
            load1();
        }

        private void btn_satisSil_Click(object sender, EventArgs e)
        {
            _UrunDal.SatisDelete(new tblSati
            {
                Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
            });
            MessageBox.Show("Satış başarılı bir şekilde silindi..");
            load3();
        }

     
    }
}
