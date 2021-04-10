using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace OlahDataAirside
{
    public partial class Form5 : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\source\repos\OlahDataAirside\OlahDataAirside\AirsideDatabase.accdb");
        OleDbCommand cmd;
        OleDbCommandBuilder cb;
        OleDbDataAdapter da;
        DataTable dt;
        int id = 0;

        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //tahun akhir
            //int
            //januari
            int A = 0;
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + textBox1.Text + "%'  and bulan like '"+label1.Text+"' and wilayah like '" + comboBox2.Text + "%' and hal like '"+"Internasional"+"'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B = 0, C = 0;
            for (A = 0; A < dataGridView1.Rows.Count; ++A)
            {
                B += Convert.ToInt32(dataGridView1.Rows[A].Cells[6].Value);
                C += Convert.ToInt32(dataGridView1.Rows[A].Cells[7].Value);
            }
            textBox2.Text = (B + C).ToString();

            //februari
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + textBox1.Text + "%'  and bulan like '" + label2.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Internasional" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B1 = 0, C1 = 0;
            for (A = 0; A < dataGridView2.Rows.Count; ++A)
            {
                B1 += Convert.ToInt32(dataGridView2.Rows[A].Cells[6].Value);
                C1 += Convert.ToInt32(dataGridView2.Rows[A].Cells[7].Value);
            }
            textBox3.Text = (B1 + C1).ToString();

            //maret
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + textBox1.Text + "%'  and bulan like '" + label3.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Internasional" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView3.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B2 = 0, C2 = 0;
            for (A = 0; A < dataGridView3.Rows.Count; ++A)
            {
                B2 += Convert.ToInt32(dataGridView3.Rows[A].Cells[6].Value);
                C2 += Convert.ToInt32(dataGridView3.Rows[A].Cells[7].Value);
            }
            textBox4.Text = (B2 + C2).ToString();

            //april
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + textBox1.Text + "%'  and bulan like '" + label4.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Internasional" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView4.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B3 = 0, C3 = 0;
            for (A = 0; A < dataGridView4.Rows.Count; ++A)
            {
                B3 += Convert.ToInt32(dataGridView4.Rows[A].Cells[6].Value);
                C3 += Convert.ToInt32(dataGridView4.Rows[A].Cells[7].Value);
            }
            textBox5.Text = (B3 + C3).ToString();

            //mei
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + textBox1.Text + "%'  and bulan like '" + label5.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Internasional" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView5.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B4 = 0, C4 = 0;
            for (A = 0; A < dataGridView5.Rows.Count; ++A)
            {
                B4 += Convert.ToInt32(dataGridView5.Rows[A].Cells[6].Value);
                C4 += Convert.ToInt32(dataGridView5.Rows[A].Cells[7].Value);
            }
            textBox6.Text = (B4 + C4).ToString();

            //juni
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + textBox1.Text + "%'  and bulan like '" + label6.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Internasional" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView6.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B5 = 0, C5 = 0;
            for (A = 0; A < dataGridView6.Rows.Count; ++A)
            {
                B5 += Convert.ToInt32(dataGridView6.Rows[A].Cells[6].Value);
                C5 += Convert.ToInt32(dataGridView6.Rows[A].Cells[7].Value);
            }
            textBox7.Text = (B5 + C5).ToString();

            //juli
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + textBox1.Text + "%'  and bulan like '" + label7.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Internasional" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView7.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B6 = 0, C6 = 0;
            for (A = 0; A < dataGridView7.Rows.Count; ++A)
            {
                B6 += Convert.ToInt32(dataGridView7.Rows[A].Cells[6].Value);
                C6 += Convert.ToInt32(dataGridView7.Rows[A].Cells[7].Value);
            }
            textBox8.Text = (B6 + C6).ToString();

            //agustus
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + textBox1.Text + "%'  and bulan like '" + label8.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Internasional" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView8.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B7 = 0, C7 = 0;
            for (A = 0; A < dataGridView8.Rows.Count; ++A)
            {
                B7 += Convert.ToInt32(dataGridView8.Rows[A].Cells[6].Value);
                C7 += Convert.ToInt32(dataGridView8.Rows[A].Cells[7].Value);
            }
            textBox9.Text = (B7 + C7).ToString();

            //september
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + textBox1.Text + "%'  and bulan like '" + label9.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Internasional" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView9.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B8 = 0, C8 = 0;
            for (A = 0; A < dataGridView9.Rows.Count; ++A)
            {
                B8 += Convert.ToInt32(dataGridView9.Rows[A].Cells[6].Value);
                C8 += Convert.ToInt32(dataGridView9.Rows[A].Cells[7].Value);
            }
            textBox10.Text = (B8 + C8).ToString();

            //oktober
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + textBox1.Text + "%'  and bulan like '" + label10.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Internasional" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView10.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B9 = 0, C9 = 0;
            for (A = 0; A < dataGridView10.Rows.Count; ++A)
            {
                B9 += Convert.ToInt32(dataGridView10.Rows[A].Cells[6].Value);
                C9 += Convert.ToInt32(dataGridView10.Rows[A].Cells[7].Value);
            }
            textBox11.Text = (B9 + C9).ToString();

            //november
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + textBox1.Text + "%'  and bulan like '" + label11.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Internasional" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView11.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B10 = 0, C10 = 0;
            for (A = 0; A < dataGridView11.Rows.Count; ++A)
            {
                B10 += Convert.ToInt32(dataGridView11.Rows[A].Cells[6].Value);
                C10 += Convert.ToInt32(dataGridView11.Rows[A].Cells[7].Value);
            }
            textBox12.Text = (B10 + C10).ToString();

            //desember
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + textBox1.Text + "%'  and bulan like '" + label12.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Internasional" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView12.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B11 = 0, C11 = 0;
            for (A = 0; A < dataGridView12.Rows.Count; ++A)
            {
                B11 += Convert.ToInt32(dataGridView12.Rows[A].Cells[6].Value);
                C11 += Convert.ToInt32(dataGridView12.Rows[A].Cells[7].Value);
            }
            textBox13.Text = (B11 + C11).ToString();

            //dom
            //januari
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + textBox1.Text + "%'  and bulan like '" + label1.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Domestik" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView13.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B12 = 0, C12 = 0;
            for (A = 0; A < dataGridView13.Rows.Count; ++A)
            {
                B12 += Convert.ToInt32(dataGridView13.Rows[A].Cells[6].Value);
                C12 += Convert.ToInt32(dataGridView13.Rows[A].Cells[7].Value);
            }
            textBox24.Text = (B12 + C12).ToString();

            //februari
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + textBox1.Text + "%'  and bulan like '" + label2.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Domestik" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView14.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B13 = 0, C13 = 0;
            for (A = 0; A < dataGridView14.Rows.Count; ++A)
            {
                B13 += Convert.ToInt32(dataGridView14.Rows[A].Cells[6].Value);
                C13 += Convert.ToInt32(dataGridView14.Rows[A].Cells[7].Value);
            }
            textBox23.Text = (B13 + C13).ToString();

            //maret
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + textBox1.Text + "%'  and bulan like '" + label3.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Domestik" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView15.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B14 = 0, C14 = 0;
            for (A = 0; A < dataGridView15.Rows.Count; ++A)
            {
                B14 += Convert.ToInt32(dataGridView15.Rows[A].Cells[6].Value);
                C14 += Convert.ToInt32(dataGridView15.Rows[A].Cells[7].Value);
            }
            textBox22.Text = (B14 + C14).ToString();

            //april
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + textBox1.Text + "%'  and bulan like '" + label4.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Domestik" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView16.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B15 = 0, C15 = 0;
            for (A = 0; A < dataGridView16.Rows.Count; ++A)
            {
                B15 += Convert.ToInt32(dataGridView16.Rows[A].Cells[6].Value);
                C15 += Convert.ToInt32(dataGridView16.Rows[A].Cells[7].Value);
            }
            textBox21.Text = (B15 + C15).ToString();

            //mei
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + textBox1.Text + "%'  and bulan like '" + label5.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Domestik" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView17.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B16 = 0, C16 = 0;
            for (A = 0; A < dataGridView17.Rows.Count; ++A)
            {
                B16 += Convert.ToInt32(dataGridView17.Rows[A].Cells[6].Value);
                C16 += Convert.ToInt32(dataGridView17.Rows[A].Cells[7].Value);
            }
            textBox20.Text = (B16 + C16).ToString();

            //juni
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + textBox1.Text + "%'  and bulan like '" + label6.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Domestik" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView18.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B17 = 0, C17 = 0;
            for (A = 0; A < dataGridView18.Rows.Count; ++A)
            {
                B17 += Convert.ToInt32(dataGridView18.Rows[A].Cells[6].Value);
                C17 += Convert.ToInt32(dataGridView18.Rows[A].Cells[7].Value);
            }
            textBox19.Text = (B17 + C17).ToString();

            //juli
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + textBox1.Text + "%'  and bulan like '" + label7.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Domestik" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView19.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B18 = 0, C18 = 0;
            for (A = 0; A < dataGridView19.Rows.Count; ++A)
            {
                B18 += Convert.ToInt32(dataGridView19.Rows[A].Cells[6].Value);
                C18 += Convert.ToInt32(dataGridView19.Rows[A].Cells[7].Value);
            }
            textBox18.Text = (B18 + C18).ToString();

            //agustus
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + textBox1.Text + "%'  and bulan like '" + label8.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Domestik" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView20.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B19 = 0, C19 = 0;
            for (A = 0; A < dataGridView20.Rows.Count; ++A)
            {
                B19 += Convert.ToInt32(dataGridView20.Rows[A].Cells[6].Value);
                C19 += Convert.ToInt32(dataGridView20.Rows[A].Cells[7].Value);
            }
            textBox17.Text = (B19 + C19).ToString();

            //september
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + textBox1.Text + "%'  and bulan like '" + label9.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Domestik" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView21.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B20 = 0, C20 = 0;
            for (A = 0; A < dataGridView21.Rows.Count; ++A)
            {
                B20 += Convert.ToInt32(dataGridView21.Rows[A].Cells[6].Value);
                C20 += Convert.ToInt32(dataGridView21.Rows[A].Cells[7].Value);
            }
            textBox16.Text = (B20 + C20).ToString();

            //oktober
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + textBox1.Text + "%'  and bulan like '" + label10.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Domestik" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView22.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B21 = 0, C21 = 0;
            for (A = 0; A < dataGridView22.Rows.Count; ++A)
            {
                B21 += Convert.ToInt32(dataGridView22.Rows[A].Cells[6].Value);
                C21 += Convert.ToInt32(dataGridView22.Rows[A].Cells[7].Value);
            }
            textBox15.Text = (B21 + C21).ToString();

            //november
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + textBox1.Text + "%'  and bulan like '" + label11.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Domestik" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView23.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B22 = 0, C22 = 0;
            for (A = 0; A < dataGridView23.Rows.Count; ++A)
            {
                B22 += Convert.ToInt32(dataGridView23.Rows[A].Cells[6].Value);
                C22 += Convert.ToInt32(dataGridView23.Rows[A].Cells[7].Value);
            }
            textBox25.Text = (B22 + C22).ToString();

            //desember
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + textBox1.Text + "%'  and bulan like '" + label12.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Domestik" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView24.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B23 = 0, C23 = 0;
            for (A = 0; A < dataGridView24.Rows.Count; ++A)
            {
                B23 += Convert.ToInt32(dataGridView24.Rows[A].Cells[6].Value);
                C23 += Convert.ToInt32(dataGridView24.Rows[A].Cells[7].Value);
            }
            textBox14.Text = (B23 + C23).ToString();

            //tahunsebelumnya
            label75.Text = (int.Parse(textBox1.Text) - 1).ToString();
            //int
            //januari
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label75.Text + "%'  and bulan like '" + label1.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Internasional" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView25.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B24 = 0, C24 = 0;
            for (A = 0; A < dataGridView25.Rows.Count; ++A)
            {
                B24 += Convert.ToInt32(dataGridView25.Rows[A].Cells[6].Value);
                C24 += Convert.ToInt32(dataGridView25.Rows[A].Cells[7].Value);
            }
            textBox49.Text = (B24 + C24).ToString();

            //februari
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label75.Text + "%'  and bulan like '" + label2.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Internasional" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView26.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B25 = 0, C25 = 0;
            for (A = 0; A < dataGridView26.Rows.Count; ++A)
            {
                B25 += Convert.ToInt32(dataGridView26.Rows[A].Cells[6].Value);
                C25 += Convert.ToInt32(dataGridView26.Rows[A].Cells[7].Value);
            }
            textBox48.Text = (B25 + C25).ToString();

            //maret
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label75.Text + "%'  and bulan like '" + label3.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Internasional" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView27.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B26 = 0, C26 = 0;
            for (A = 0; A < dataGridView27.Rows.Count; ++A)
            {
                B26 += Convert.ToInt32(dataGridView27.Rows[A].Cells[6].Value);
                C26 += Convert.ToInt32(dataGridView27.Rows[A].Cells[7].Value);
            }
            textBox47.Text = (B26 + C26).ToString();

            //april
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label75.Text + "%'  and bulan like '" + label4.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Internasional" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView28.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B27 = 0, C27 = 0;
            for (A = 0; A < dataGridView28.Rows.Count; ++A)
            {
                B27 += Convert.ToInt32(dataGridView28.Rows[A].Cells[6].Value);
                C27 += Convert.ToInt32(dataGridView28.Rows[A].Cells[7].Value);
            }
            textBox46.Text = (B27 + C27).ToString();

            //mei
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label75.Text + "%'  and bulan like '" + label5.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Internasional" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView29.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B28 = 0, C28 = 0;
            for (A = 0; A < dataGridView29.Rows.Count; ++A)
            {
                B28 += Convert.ToInt32(dataGridView29.Rows[A].Cells[6].Value);
                C28 += Convert.ToInt32(dataGridView29.Rows[A].Cells[7].Value);
            }
            textBox45.Text = (B28 + C28).ToString();

            //juni
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label75.Text + "%'  and bulan like '" + label6.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Internasional" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView30.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B29 = 0, C29 = 0;
            for (A = 0; A < dataGridView30.Rows.Count; ++A)
            {
                B29 += Convert.ToInt32(dataGridView30.Rows[A].Cells[6].Value);
                C29 += Convert.ToInt32(dataGridView30.Rows[A].Cells[7].Value);
            }
            textBox44.Text = (B29 + C29).ToString();

            //juli
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label75.Text + "%'  and bulan like '" + label7.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Internasional" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView31.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B30 = 0, C30 = 0;
            for (A = 0; A < dataGridView31.Rows.Count; ++A)
            {
                B30 += Convert.ToInt32(dataGridView31.Rows[A].Cells[6].Value);
                C30 += Convert.ToInt32(dataGridView31.Rows[A].Cells[7].Value);
            }
            textBox43.Text = (B30 + C30).ToString();

            //agustus
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label75.Text + "%'  and bulan like '" + label8.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Internasional" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView32.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B31 = 0, C31 = 0;
            for (A = 0; A < dataGridView32.Rows.Count; ++A)
            {
                B31 += Convert.ToInt32(dataGridView32.Rows[A].Cells[6].Value);
                C31 += Convert.ToInt32(dataGridView32.Rows[A].Cells[7].Value);
            }
            textBox42.Text = (B31 + C31).ToString();

            //september
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label75.Text + "%'  and bulan like '" + label9.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Internasional" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView33.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B32 = 0, C32 = 0;
            for (A = 0; A < dataGridView33.Rows.Count; ++A)
            {
                B32 += Convert.ToInt32(dataGridView33.Rows[A].Cells[6].Value);
                C32 += Convert.ToInt32(dataGridView33.Rows[A].Cells[7].Value);
            }
            textBox41.Text = (B32 + C32).ToString();

            //oktober
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label75.Text + "%'  and bulan like '" + label10.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Internasional" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView34.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B33 = 0, C33 = 0;
            for (A = 0; A < dataGridView34.Rows.Count; ++A)
            {
                B33 += Convert.ToInt32(dataGridView34.Rows[A].Cells[6].Value);
                C33 += Convert.ToInt32(dataGridView34.Rows[A].Cells[7].Value);
            }
            textBox40.Text = (B33 + C33).ToString();

            //november
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label75.Text + "%'  and bulan like '" + label11.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Internasional" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView35.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B34 = 0, C34 = 0;
            for (A = 0; A < dataGridView35.Rows.Count; ++A)
            {
                B34 += Convert.ToInt32(dataGridView35.Rows[A].Cells[6].Value);
                C34 += Convert.ToInt32(dataGridView35.Rows[A].Cells[7].Value);
            }
            textBox38.Text = (B34 + C34).ToString();

            //desember
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label75.Text + "%'  and bulan like '" + label12.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Internasional" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView36.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B35 = 0, C35 = 0;
            for (A = 0; A < dataGridView36.Rows.Count; ++A)
            {
                B35 += Convert.ToInt32(dataGridView36.Rows[A].Cells[6].Value);
                C35 += Convert.ToInt32(dataGridView36.Rows[A].Cells[7].Value);
            }
            textBox39.Text = (B35 + C35).ToString();

            //dom
            //januari
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label75.Text + "%'  and bulan like '" + label1.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Domestik" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView37.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B36 = 0, C36 = 0;
            for (A = 0; A < dataGridView37.Rows.Count; ++A)
            {
                B36 += Convert.ToInt32(dataGridView37.Rows[A].Cells[6].Value);
                C36 += Convert.ToInt32(dataGridView37.Rows[A].Cells[7].Value);
            }
            textBox61.Text = (B36 + C36).ToString();

            //februari
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label75.Text + "%'  and bulan like '" + label2.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Domestik" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView38.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B37 = 0, C37 = 0;
            for (A = 0; A < dataGridView38.Rows.Count; ++A)
            {
                B37 += Convert.ToInt32(dataGridView38.Rows[A].Cells[6].Value);
                C37 += Convert.ToInt32(dataGridView38.Rows[A].Cells[7].Value);
            }
            textBox60.Text = (B37 + C37).ToString();

            //maret
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label75.Text + "%'  and bulan like '" + label3.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Domestik" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView39.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B38 = 0, C38 = 0;
            for (A = 0; A < dataGridView39.Rows.Count; ++A)
            {
                B38 += Convert.ToInt32(dataGridView39.Rows[A].Cells[6].Value);
                C38 += Convert.ToInt32(dataGridView39.Rows[A].Cells[7].Value);
            }
            textBox59.Text = (B38 + C38).ToString();

            //april
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label75.Text + "%'  and bulan like '" + label4.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Domestik" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView40.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B39 = 0, C39 = 0;
            for (A = 0; A < dataGridView40.Rows.Count; ++A)
            {
                B39 += Convert.ToInt32(dataGridView40.Rows[A].Cells[6].Value);
                C39 += Convert.ToInt32(dataGridView40.Rows[A].Cells[7].Value);
            }
            textBox58.Text = (B39 + C39).ToString();

            //mei
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label75.Text + "%'  and bulan like '" + label5.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Domestik" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView41.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B40 = 0, C40 = 0;
            for (A = 0; A < dataGridView41.Rows.Count; ++A)
            {
                B40 += Convert.ToInt32(dataGridView41.Rows[A].Cells[6].Value);
                C40 += Convert.ToInt32(dataGridView41.Rows[A].Cells[7].Value);
            }
            textBox57.Text = (B40 + C40).ToString();

            //juni
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label75.Text + "%'  and bulan like '" + label6.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Domestik" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView42.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B41 = 0, C41 = 0;
            for (A = 0; A < dataGridView42.Rows.Count; ++A)
            {
                B41 += Convert.ToInt32(dataGridView42.Rows[A].Cells[6].Value);
                C41 += Convert.ToInt32(dataGridView42.Rows[A].Cells[7].Value);
            }
            textBox56.Text = (B41 + C41).ToString();

            //juli
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label75.Text + "%'  and bulan like '" + label7.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Domestik" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView43.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B42 = 0, C42 = 0;
            for (A = 0; A < dataGridView43.Rows.Count; ++A)
            {
                B42 += Convert.ToInt32(dataGridView43.Rows[A].Cells[6].Value);
                C42 += Convert.ToInt32(dataGridView43.Rows[A].Cells[7].Value);
            }
            textBox55.Text = (B42 + C42).ToString();

            //agustus
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label75.Text + "%'  and bulan like '" + label8.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Domestik" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView44.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B43 = 0, C43 = 0;
            for (A = 0; A < dataGridView44.Rows.Count; ++A)
            {
                B43 += Convert.ToInt32(dataGridView44.Rows[A].Cells[6].Value);
                C43 += Convert.ToInt32(dataGridView44.Rows[A].Cells[7].Value);
            }
            textBox54.Text = (B43 + C43).ToString();

            //september
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label75.Text + "%'  and bulan like '" + label9.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Domestik" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView45.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B44 = 0, C44 = 0;
            for (A = 0; A < dataGridView45.Rows.Count; ++A)
            {
                B44 += Convert.ToInt32(dataGridView45.Rows[A].Cells[6].Value);
                C44 += Convert.ToInt32(dataGridView45.Rows[A].Cells[7].Value);
            }
            textBox53.Text = (B44 + C44).ToString();

            //oktober
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label75.Text + "%'  and bulan like '" + label10.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Domestik" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView46.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B45 = 0, C45 = 0;
            for (A = 0; A < dataGridView46.Rows.Count; ++A)
            {
                B45 += Convert.ToInt32(dataGridView46.Rows[A].Cells[6].Value);
                C45 += Convert.ToInt32(dataGridView46.Rows[A].Cells[7].Value);
            }
            textBox52.Text = (B45 + C45).ToString();

            //november
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label75.Text + "%'  and bulan like '" + label11.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Domestik" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView47.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B46 = 0, C46 = 0;
            for (A = 0; A < dataGridView47.Rows.Count; ++A)
            {
                B46 += Convert.ToInt32(dataGridView47.Rows[A].Cells[6].Value);
                C46 += Convert.ToInt32(dataGridView47.Rows[A].Cells[7].Value);
            }
            textBox50.Text = (B46 + C46).ToString();

            //desember
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label75.Text + "%'  and bulan like '" + label12.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Domestik" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView48.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B47 = 0, C47 = 0;
            for (A = 0; A < dataGridView48.Rows.Count; ++A)
            {
                B47 += Convert.ToInt32(dataGridView48.Rows[A].Cells[6].Value);
                C47 += Convert.ToInt32(dataGridView48.Rows[A].Cells[7].Value);
            }
            textBox51.Text = (B47 + C47).ToString();

            //loc 2017

            //januari
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + textBox1.Text + "%'  and bulan like '" + label1.Text + "' and wilayah like '" + comboBox2.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView49.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B48 = 0;
            for (A = 0; A < dataGridView49.Rows.Count; ++A)
            {
                B48 += Convert.ToInt32(dataGridView49.Rows[A].Cells[8].Value);
            }
            textBox37.Text = B48.ToString();

            
            //februari
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + textBox1.Text + "%'  and bulan like '" + label2.Text + "' and wilayah like '" + comboBox2.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView50.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B49 = 0;
            for (A = 0; A < dataGridView50.Rows.Count; ++A)
            {
                B49 += Convert.ToInt32(dataGridView50.Rows[A].Cells[8].Value);
            }
            textBox36.Text = B49.ToString();

            
            //maret
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + textBox1.Text + "%'  and bulan like '" + label3.Text + "' and wilayah like '" + comboBox2.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView51.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B50 = 0;
            for (A = 0; A < dataGridView51.Rows.Count; ++A)
            {
                B50 += Convert.ToInt32(dataGridView51.Rows[A].Cells[8].Value);
            }
            textBox35.Text = B48.ToString();

            //april
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + textBox1.Text + "%'  and bulan like '" + label4.Text + "' and wilayah like '" + comboBox2.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView52.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B51 = 0;
            for (A = 0; A < dataGridView52.Rows.Count; ++A)
            {
                B51 += Convert.ToInt32(dataGridView52.Rows[A].Cells[8].Value);
            }
            textBox34.Text = B51.ToString();

            //mei
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + textBox1.Text + "%'  and bulan like '" + label5.Text + "' and wilayah like '" + comboBox2.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView53.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B52 = 0;
            for (A = 0; A < dataGridView53.Rows.Count; ++A)
            {
                B52 += Convert.ToInt32(dataGridView53.Rows[A].Cells[8].Value);
            }
            textBox33.Text = B52.ToString();

            //juni
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + textBox1.Text + "%'  and bulan like '" + label6.Text + "' and wilayah like '" + comboBox2.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView54.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B53 = 0;
            for (A = 0; A < dataGridView54.Rows.Count; ++A)
            {
                B53 += Convert.ToInt32(dataGridView54.Rows[A].Cells[8].Value);
            }
            textBox32.Text = B53.ToString();

            //juli
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + textBox1.Text + "%'  and bulan like '" + label7.Text + "' and wilayah like '" + comboBox2.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView55.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B54 = 0;
            for (A = 0; A < dataGridView55.Rows.Count; ++A)
            {
                B54 += Convert.ToInt32(dataGridView55.Rows[A].Cells[8].Value);
            }
            textBox31.Text = B54.ToString();

            //agustus
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + textBox1.Text + "%'  and bulan like '" + label8.Text + "' and wilayah like '" + comboBox2.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView56.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B55 = 0;
            for (A = 0; A < dataGridView56.Rows.Count; ++A)
            {
                B55 += Convert.ToInt32(dataGridView56.Rows[A].Cells[8].Value);
            }
            textBox30.Text = B55.ToString();

            //september
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + textBox1.Text + "%'  and bulan like '" + label9.Text + "' and wilayah like '" + comboBox2.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView57.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B56 = 0;
            for (A = 0; A < dataGridView57.Rows.Count; ++A)
            {
                B56 += Convert.ToInt32(dataGridView57.Rows[A].Cells[8].Value);
            }
            textBox29.Text = B56.ToString();

            //oktober
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + textBox1.Text + "%'  and bulan like '" + label10.Text + "' and wilayah like '" + comboBox2.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView58.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B57 = 0;
            for (A = 0; A < dataGridView58.Rows.Count; ++A)
            {
                B57 += Convert.ToInt32(dataGridView58.Rows[A].Cells[8].Value);
            }
            textBox28.Text = B57.ToString();

            //november
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + textBox1.Text + "%'  and bulan like '" + label11.Text + "' and wilayah like '" + comboBox2.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView59.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B58 = 0;
            for (A = 0; A < dataGridView59.Rows.Count; ++A)
            {
                B58 += Convert.ToInt32(dataGridView59.Rows[A].Cells[8].Value);
            }
            textBox26.Text = B58.ToString();

            //desember
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + textBox1.Text + "%'  and bulan like '" + label12.Text + "' and wilayah like '" + comboBox2.Text + "%'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView60.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B59 = 0;
            for (A = 0; A < dataGridView60.Rows.Count; ++A)
            {
                B59 += Convert.ToInt32(dataGridView60.Rows[A].Cells[8].Value);
            }
            textBox27.Text = B59.ToString();

            /*
            //loc 2016

            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label75.Text + "%'  and bulan like '" + label1.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Domestik" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView37.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B36 = 0, C36 = 0;
            for (A = 0; A < dataGridView37.Rows.Count; ++A)
            {
                B36 += Convert.ToInt32(dataGridView37.Rows[A].Cells[6].Value);
                C36 += Convert.ToInt32(dataGridView37.Rows[A].Cells[7].Value);
            }
            textBox61.Text = (B36 + C36).ToString();

            //februari
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label75.Text + "%'  and bulan like '" + label2.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Domestik" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView38.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B37 = 0, C37 = 0;
            for (A = 0; A < dataGridView38.Rows.Count; ++A)
            {
                B37 += Convert.ToInt32(dataGridView38.Rows[A].Cells[6].Value);
                C37 += Convert.ToInt32(dataGridView38.Rows[A].Cells[7].Value);
            }
            textBox60.Text = (B37 + C37).ToString();

            //maret
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label75.Text + "%'  and bulan like '" + label3.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Domestik" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView39.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B38 = 0, C38 = 0;
            for (A = 0; A < dataGridView39.Rows.Count; ++A)
            {
                B38 += Convert.ToInt32(dataGridView39.Rows[A].Cells[6].Value);
                C38 += Convert.ToInt32(dataGridView39.Rows[A].Cells[7].Value);
            }
            textBox59.Text = (B38 + C38).ToString();

            //april
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label75.Text + "%'  and bulan like '" + label4.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Domestik" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView40.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B39 = 0, C39 = 0;
            for (A = 0; A < dataGridView40.Rows.Count; ++A)
            {
                B39 += Convert.ToInt32(dataGridView40.Rows[A].Cells[6].Value);
                C39 += Convert.ToInt32(dataGridView40.Rows[A].Cells[7].Value);
            }
            textBox58.Text = (B39 + C39).ToString();

            //mei
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label75.Text + "%'  and bulan like '" + label5.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Domestik" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView41.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B40 = 0, C40 = 0;
            for (A = 0; A < dataGridView41.Rows.Count; ++A)
            {
                B40 += Convert.ToInt32(dataGridView41.Rows[A].Cells[6].Value);
                C40 += Convert.ToInt32(dataGridView41.Rows[A].Cells[7].Value);
            }
            textBox57.Text = (B40 + C40).ToString();

            //juni
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label75.Text + "%'  and bulan like '" + label6.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Domestik" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView42.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B41 = 0, C41 = 0;
            for (A = 0; A < dataGridView42.Rows.Count; ++A)
            {
                B41 += Convert.ToInt32(dataGridView42.Rows[A].Cells[6].Value);
                C41 += Convert.ToInt32(dataGridView42.Rows[A].Cells[7].Value);
            }
            textBox56.Text = (B41 + C41).ToString();

            //juli
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label75.Text + "%'  and bulan like '" + label7.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Domestik" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView43.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B42 = 0, C42 = 0;
            for (A = 0; A < dataGridView43.Rows.Count; ++A)
            {
                B42 += Convert.ToInt32(dataGridView43.Rows[A].Cells[6].Value);
                C42 += Convert.ToInt32(dataGridView43.Rows[A].Cells[7].Value);
            }
            textBox55.Text = (B42 + C42).ToString();

            //agustus
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label75.Text + "%'  and bulan like '" + label8.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Domestik" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView44.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B43 = 0, C43 = 0;
            for (A = 0; A < dataGridView44.Rows.Count; ++A)
            {
                B43 += Convert.ToInt32(dataGridView44.Rows[A].Cells[6].Value);
                C43 += Convert.ToInt32(dataGridView44.Rows[A].Cells[7].Value);
            }
            textBox54.Text = (B43 + C43).ToString();

            //september
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label75.Text + "%'  and bulan like '" + label9.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Domestik" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView45.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B44 = 0, C44 = 0;
            for (A = 0; A < dataGridView45.Rows.Count; ++A)
            {
                B44 += Convert.ToInt32(dataGridView45.Rows[A].Cells[6].Value);
                C44 += Convert.ToInt32(dataGridView45.Rows[A].Cells[7].Value);
            }
            textBox53.Text = (B44 + C44).ToString();

            //oktober
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label75.Text + "%'  and bulan like '" + label10.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Domestik" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView46.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B45 = 0, C45 = 0;
            for (A = 0; A < dataGridView46.Rows.Count; ++A)
            {
                B45 += Convert.ToInt32(dataGridView46.Rows[A].Cells[6].Value);
                C45 += Convert.ToInt32(dataGridView46.Rows[A].Cells[7].Value);
            }
            textBox52.Text = (B45 + C45).ToString();

            //november
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label75.Text + "%'  and bulan like '" + label11.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Domestik" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView47.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B46 = 0, C46 = 0;
            for (A = 0; A < dataGridView47.Rows.Count; ++A)
            {
                B46 += Convert.ToInt32(dataGridView47.Rows[A].Cells[6].Value);
                C46 += Convert.ToInt32(dataGridView47.Rows[A].Cells[7].Value);
            }
            textBox50.Text = (B46 + C46).ToString();

            //desember
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label75.Text + "%'  and bulan like '" + label12.Text + "' and wilayah like '" + comboBox2.Text + "%' and hal like '" + "Domestik" + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                dataGridView48.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }
            int B47 = 0, C47 = 0;
            for (A = 0; A < dataGridView48.Rows.Count; ++A)
            {
                B47 += Convert.ToInt32(dataGridView48.Rows[A].Cells[6].Value);
                C47 += Convert.ToInt32(dataGridView48.Rows[A].Cells[7].Value);
            }
            textBox51.Text = (B47 + C47).ToString(); */


        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
