using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizMahasiswa
{
    public partial class Masterbarang018 : Form
    {
        SqlConnection con = new SqlConnection("Integrated Security= true; Initial Catalog=QuizMahasiswa; server=DESKTOP-4OL84HG\\SQLEXPRESS");
        public Masterbarang018()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void btnSave_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtID.Text);
            string nama = txtNamaBarang.Text;
            int harga = int.Parse(txtHarga.Text);
            int stock = int.Parse(txtStock.Text);
            int namasupplier = int.Parse(cbSupplier.Text);
            var data = new tbl_barang

            {
                id_barang = ID,
                nama_barang = nama,
                harga = harga,
                stok = stock,
                nama_supplier = namasupplier
            };

            db.tbl_barangs.InsertOnSubmit(data);
            db.SubmitChanges();
            MessageBox.Show("Save Successfully");
            txtID.Clear();
            txtHarga.Clear();
            txtNamaBarang.Clear();
            txtStock.Clear();
            cbSupplier.SelectedIndex = -1;
            ll();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ll();

        }

        private void ll()
        {
            // TODO: This line of code loads data into the 'quizMahasiswaDataSet.tbl_barang' table. You can move, or remove it, as needed.
            this.tbl_barangTableAdapter.Fill(this.quizMahasiswaDataSet.tbl_barang);

            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select isnull(max (cast (id_barang as int)),0) +1 from tbl_barang", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            txtID.Text = dt.Rows[0][0].ToString();
            con.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtHarga.Clear();
            txtNamaBarang.Clear();
            txtStock.Clear();
            cbSupplier.SelectedIndex = -1;
            ll();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
