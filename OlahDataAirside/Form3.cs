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

    public partial class Form3 : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\source\repos\OlahDataAirside\OlahDataAirside\AirsideDatabase.accdb");
        OleDbCommand cmd;
        OleDbCommandBuilder cb;
        OleDbDataAdapter da;
        DataTable dt;
        int id = 0;

        public Form3()
        {
            InitializeComponent();
        }

        void fillcombo()
        {
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database]";
                cmd.ExecuteNonQuery();
                dt = new DataTable();
                da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    comboBox1.Items.Add(dr["tahun"].ToString());
                }/*
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                     int stahun = dr.GetInt32("tahun");
                   // string stahun = Convert.ToString(itahun);
                    comboBox1.Items.Add(stahun);
                }*/
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("error " + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //data hitung A
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText =   "select * from [database] where tahun like '" + textBox1.Text + "%'  and terminal like '" + "A" + "%' and  hal like '" + "Domestik" + "%' and wilayah like '" + comboBox2.Text + "%'";
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

            int A = 0, B = 0, C = 0, D = 0;
            for (A = 0; A < dataGridView5.Rows.Count; ++A)
            {
                B += Convert.ToInt32(dataGridView5.Rows[A].Cells[6].Value);
                C += Convert.ToInt32(dataGridView5.Rows[A].Cells[7].Value);
                D += Convert.ToInt32(dataGridView5.Rows[A].Cells[8].Value);
            }
            textBox14.Text = B.ToString();
            textBox15.Text = C.ToString();
            textBox16.Text = D.ToString();
            textBox17.Text = (B + C).ToString();

            //data hitung B
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + textBox1.Text + "%'  and terminal like '" + "B" + "%' and  hal like '" + "Domestik" + "%' and wilayah like '" + comboBox2.Text + "%'";
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

            int E = 0, F = 0, G = 0, H = 0;
            for (E = 0; E < dataGridView6.Rows.Count; ++E)
            {
                F += Convert.ToInt32(dataGridView6.Rows[E].Cells[6].Value);
                G += Convert.ToInt32(dataGridView6.Rows[E].Cells[7].Value);
                H += Convert.ToInt32(dataGridView6.Rows[E].Cells[8].Value);
            }
            textBox11.Text = F.ToString();
            textBox10.Text = G.ToString();
            textBox9.Text = H.ToString();
            textBox8.Text = (F + G).ToString();

            //data hitung all
            int tadtg, tabrk, taloc, tbdtg, tbbrk, tbloc, tatotal, tbtotal;

            tadtg = int.Parse(textBox14.Text);
            tabrk = int.Parse(textBox15.Text);
            taloc = int.Parse(textBox16.Text);
            tatotal = int.Parse(textBox17.Text);
            tbdtg = int.Parse(textBox11.Text);
            tbbrk = int.Parse(textBox10.Text);
            tbloc = int.Parse(textBox9.Text);
            tbtotal = int.Parse(textBox8.Text);

            textBox27.Text = (tadtg + tbdtg).ToString();
            textBox26.Text = (tabrk + tbbrk).ToString();
            textBox25.Text = (taloc + tbloc).ToString();
            textBox24.Text = (tadtg + tabrk  + tbdtg + tbbrk ).ToString();

            //internasional
            //data hitung A
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + textBox1.Text + "%'  and terminal like '" + "A" + "%' and  hal like '" + "Internasional" + "%' and wilayah like '" + comboBox2.Text + "%'";
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

            int Aa = 0, Bb = 0, Cc = 0, Dd = 0;
            for (Aa = 0; Aa < dataGridView2.Rows.Count; ++Aa)
            {
                Bb += Convert.ToInt32(dataGridView2.Rows[Aa].Cells[6].Value);
                Cc += Convert.ToInt32(dataGridView2.Rows[Aa].Cells[7].Value);
                Dd += Convert.ToInt32(dataGridView2.Rows[Aa].Cells[8].Value);
            }
            textBox28.Text = Bb.ToString();
            textBox23.Text = Cc.ToString();
            textBox22.Text = Dd.ToString();
            textBox21.Text = (Bb + Cc).ToString();

            //data hitung B
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + textBox1.Text + "%'  and terminal like '" + "B" + "%' and  hal like '" + "Internasional" + "%' and wilayah like '" + comboBox2.Text + "%'";
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

            int Ee = 0, Ff = 0, Gg = 0, Hh = 0;
            for (Ee = 0; Ee < dataGridView1.Rows.Count; ++Ee)
            {
                Ff += Convert.ToInt32(dataGridView1.Rows[Ee].Cells[6].Value);
                Gg += Convert.ToInt32(dataGridView1.Rows[Ee].Cells[7].Value);
                Hh += Convert.ToInt32(dataGridView1.Rows[Ee].Cells[8].Value);
            }
            textBox20.Text = Ff.ToString();
            textBox19.Text = Gg.ToString();
            textBox18.Text = Hh.ToString();
            textBox13.Text = (Ff + Gg).ToString();

            //data hitung all
            int taidtg, taibrk, tailoc, tbidtg, tbibrk, tbiloc, taitotal, tbitotal;

            taidtg = int.Parse(textBox28.Text);
            taibrk = int.Parse(textBox23.Text);
            tailoc = int.Parse(textBox22.Text);
            taitotal = int.Parse(textBox21.Text);
            tbidtg = int.Parse(textBox20.Text);
            tbibrk = int.Parse(textBox19.Text);
            tbiloc = int.Parse(textBox18.Text);
            tbitotal = int.Parse(textBox13.Text);

            textBox12.Text = (taidtg + tbidtg).ToString();
            textBox7.Text = (taibrk + tbibrk).ToString();
            textBox6.Text = (tailoc + tbiloc).ToString();
            textBox5.Text = (taidtg + taibrk + tbidtg + tbibrk ).ToString();

            int tdom, tin, tloc1,tloc2;
            tdom = int.Parse(textBox24.Text);
            tin = int.Parse(textBox5.Text);
            tloc1 = int.Parse(textBox25.Text);
            tloc2 = int.Parse(textBox6.Text);

            textBox32.Text = tdom.ToString();
            textBox31.Text = tin.ToString();
            textBox30.Text = (tloc1 + tloc2).ToString();
            textBox29.Text = (tdom + tin + tloc1 + tloc2).ToString();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airsideDatabaseDataSet2.database' table. You can move, or remove it, as needed.
            this.databaseTableAdapter.Fill(this.airsideDatabaseDataSet2.database);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.chart1.Series["jumlah"].Points.AddXY("Datang", int.Parse(textBox27.Text));
            this.chart1.Series["jumlah"].Points.AddXY("Berangkat", int.Parse(textBox26.Text));
            this.chart1.Series["jumlah"].Points.AddXY("Local", int.Parse(textBox25.Text));
            this.chart1.Series["jumlah"].Points.AddXY("Total", int.Parse(textBox24.Text));

            //internasional
            this.chart2.Series["jumlah"].Points.AddXY("Datang", int.Parse(textBox12.Text));
            this.chart2.Series["jumlah"].Points.AddXY("Berangkat", int.Parse(textBox7.Text));
            this.chart2.Series["jumlah"].Points.AddXY("Local", int.Parse(textBox6.Text));
            this.chart2.Series["jumlah"].Points.AddXY("Total", int.Parse(textBox5.Text));

            //ALL
            this.chart3.Series["jumlah"].Points.AddXY("Datang", int.Parse(textBox32.Text));
            this.chart3.Series["jumlah"].Points.AddXY("Berangkat", int.Parse(textBox31.Text));
            this.chart3.Series["jumlah"].Points.AddXY("Local", int.Parse(textBox30.Text));
            this.chart3.Series["jumlah"].Points.AddXY("Total", int.Parse(textBox29.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 fk = new Form4();
            fk.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
    
}