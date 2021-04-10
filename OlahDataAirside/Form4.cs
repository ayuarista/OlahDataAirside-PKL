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
    public partial class Form4 : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\source\repos\OlahDataAirside\OlahDataAirside\AirsideDatabase.accdb");
        OleDbCommand cmd;
        OleDbCommandBuilder cb;
        OleDbDataAdapter da;
        DataTable dt;
        int id = 0;

        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //tahun awal
            label30.Text = (int.Parse(textBox1.Text) - 1).ToString();
            label31.Text = (int.Parse(textBox1.Text) - 2).ToString();
            label33.Text = (int.Parse(textBox1.Text) - 3).ToString();
            label34.Text = (int.Parse(textBox1.Text) - 4).ToString();
            label35.Text = (int.Parse(textBox1.Text) - 5).ToString();
            //data hitung A dom
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + textBox1.Text + "%'  and terminal like '" + "A" + "%' and  hal like '" + "Domestik" + "%' and wilayah like '" + comboBox2.Text + "%'";
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

            int A = 0, B = 0, C = 0, D = 0;
            for (A = 0; A < dataGridView1.Rows.Count; ++A)
            {
                B += Convert.ToInt32(dataGridView1.Rows[A].Cells[6].Value);
                C += Convert.ToInt32(dataGridView1.Rows[A].Cells[7].Value);
                D += Convert.ToInt32(dataGridView1.Rows[A].Cells[8].Value);
            }
            int Adtgdom = B;
            int Abrkdom = C;
            int Alocdom = D;
            int Atotdom = (B + C);

            //data hitung B dom
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
                dataGridView2.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);

            }

            int E = 0, F = 0, G = 0, H = 0;
            for (E = 0; E < dataGridView2.Rows.Count; ++E)
            {
                F += Convert.ToInt32(dataGridView2.Rows[E].Cells[6].Value);
                G += Convert.ToInt32(dataGridView2.Rows[E].Cells[7].Value);
                H += Convert.ToInt32(dataGridView2.Rows[E].Cells[8].Value);
            }
            int Bdtgdom = F;
            int Bbrkdom = G;
            int Blocdom = H;
            int Btotdom = (F + G);

            //data hitung all dom
            int tadtg, tabrk, taloc, tbdtg, tbbrk, tbloc, tatotal, tbtotal;

            tadtg = Adtgdom;
            tabrk = Abrkdom;
            taloc = Alocdom;
            tatotal = Atotdom;
            tbdtg = Bdtgdom;
            tbbrk = Bbrkdom;
            tbloc = Blocdom;
            tbtotal = Btotdom;
            //
            int Alldtgdom = (tadtg + tbdtg);
            int Allbrkdom = (tabrk + tbbrk);
            int Alllocdom = (taloc + tbloc);
            int Alltotdom = (tadtg + tabrk + tbdtg + tbbrk);

            //internasional
            //data hitung A int
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
                dataGridView3.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }

            int Aaa = 0, Bbb = 0, Ccc = 0, Ddd = 0;
            for (Aaa = 0; Aaa < dataGridView3.Rows.Count; ++Aaa)
            {
                Bbb += Convert.ToInt32(dataGridView3.Rows[Aaa].Cells[6].Value);
                Ccc += Convert.ToInt32(dataGridView3.Rows[Aaa].Cells[7].Value);
                Ddd += Convert.ToInt32(dataGridView3.Rows[Aaa].Cells[8].Value);
            }
            int Adtgint = Bbb;
            int Abrkint = Ccc;
            int Alocint = Ddd;
            int Atotint = (Bbb + Ccc);

            //data hitung B int
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
                dataGridView4.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);

            }

            int Eee = 0, Fff = 0, Ggg = 0, Hhh = 0;
            for (Eee = 0; Eee < dataGridView4.Rows.Count; ++Eee)
            {
                Fff += Convert.ToInt32(dataGridView4.Rows[Eee].Cells[6].Value);
                Ggg += Convert.ToInt32(dataGridView4.Rows[Eee].Cells[7].Value);
                Hhh += Convert.ToInt32(dataGridView4.Rows[Eee].Cells[8].Value);
            }
            int Bdtgint = Fff;
            int Bbrkint = Ggg;
            int Blocint = Hhh;
            int Btotint = (Fff + Ggg);

            //data hitung all int
            int taidtg, taibrk, tailoc, tbidtg, tbibrk, tbiloc, taitotal, tbitotal;

            taidtg = Adtgint;
            taibrk = Abrkint;
            tailoc = Alocint;
            taitotal = Atotint;
            tbidtg = Bdtgint;
            tbibrk = Bbrkint;
            tbiloc = Blocint;
            tbitotal = Btotint;

            int Alldtgint = (taidtg + tbidtg);
            int Allbrkint = (taibrk + tbibrk);
            int Alllocint = (tailoc + tbiloc);
            int Alltotint = (taidtg + taibrk + tbidtg + tbibrk);

            int tdom, tint, tloc1, tloc2;
            tdom = Alltotdom;
            tint = Alltotint;
            tloc1 = Alllocdom;
            tloc2 = Alllocint;

            textBox32.Text = tdom.ToString();
            textBox31.Text = tint.ToString();
            textBox30.Text = (tloc1 + tloc2).ToString();
            textBox29.Text = (tdom + tint + tloc1 + tloc2).ToString();

            //-1 hari
            //data hitung A dom
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label30.Text + "%'  and terminal like '" + "A" + "%' and  hal like '" + "Domestik" + "%' and wilayah like '" + comboBox2.Text + "%'";
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

            int A1 = 0, B1 = 0, C1 = 0, D1 = 0;
            for (A1 = 0; A1 < dataGridView5.Rows.Count; ++A1)
            {
                B1 += Convert.ToInt32(dataGridView5.Rows[A1].Cells[6].Value);
                C1 += Convert.ToInt32(dataGridView5.Rows[A1].Cells[7].Value);
                D1 += Convert.ToInt32(dataGridView5.Rows[A1].Cells[8].Value);
            }
            int Adtgdom1 = B1;
            int Abrkdom1 = C1;
            int Alocdom1 = D1;
            int Atotdom1 = (B1 + C1);

            //data hitung B dom
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label30.Text + "%'  and terminal like '" + "B" + "%' and  hal like '" + "Domestik" + "%' and wilayah like '" + comboBox2.Text + "%'";
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

            int E1 = 0, F1 = 0, G1 = 0, H1 = 0;
            for (E1 = 0; E1 < dataGridView6.Rows.Count; ++E1)
            {
                F1 += Convert.ToInt32(dataGridView6.Rows[E1].Cells[6].Value);
                G1 += Convert.ToInt32(dataGridView6.Rows[E1].Cells[7].Value);
                H1 += Convert.ToInt32(dataGridView6.Rows[E1].Cells[8].Value);
            }
            int Bdtgdom1 = F1;
            int Bbrkdom1 = G1;
            int Blocdom1 = H1;
            int Btotdom1 = (F1 + G1);

            //data hitung all dom
            int tadtg1, tabrk1, taloc1, tbdtg1, tbbrk1, tbloc1, tatotal1, tbtotal1;

            tadtg1 = Adtgdom1;
            tabrk1 = Abrkdom1;
            taloc1 = Alocdom1;
            tatotal1 = Atotdom1;
            tbdtg1 = Bdtgdom1;
            tbbrk1 = Bbrkdom1;
            tbloc1 = Blocdom1;
            tbtotal1 = Btotdom1;
            //
            int Alldtgdom1 = (tadtg1 + tbdtg1);
            int Allbrkdom1 = (tabrk1 + tbbrk1);
            int Alllocdom1 = (taloc1 + tbloc1);
            int Alltotdom1 = (tadtg1 + tabrk1 + tbdtg1 + tbbrk1);

            //internasional
            //data hitung A int
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label30.Text + "%'  and terminal like '" + "A" + "%' and  hal like '" + "Internasional" + "%' and wilayah like '" + comboBox2.Text + "%'";
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

            int Aaa1 = 0, Bbb1 = 0, Ccc1 = 0, Ddd1 = 0;
            for (Aaa1 = 0; Aaa1 < dataGridView7.Rows.Count; ++Aaa1)
            {
                Bbb1 += Convert.ToInt32(dataGridView7.Rows[Aaa1].Cells[6].Value);
                Ccc1 += Convert.ToInt32(dataGridView7.Rows[Aaa1].Cells[7].Value);
                Ddd1 += Convert.ToInt32(dataGridView7.Rows[Aaa1].Cells[8].Value);
            }
            int Adtgint1 = Bbb1;
            int Abrkint1 = Ccc1;
            int Alocint1 = Ddd1;
            int Atotint1 = (Bbb1 + Ccc1);

            //data hitung B int
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label30.Text + "%'  and terminal like '" + "B" + "%' and  hal like '" + "Internasional" + "%' and wilayah like '" + comboBox2.Text + "%'";
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

            int Eee1 = 0, Fff1 = 0, Ggg1 = 0, Hhh1 = 0;
            for (Eee1 = 0; Eee1 < dataGridView8.Rows.Count; ++Eee1)
            {
                Fff1 += Convert.ToInt32(dataGridView8.Rows[Eee1].Cells[6].Value);
                Ggg1 += Convert.ToInt32(dataGridView8.Rows[Eee1].Cells[7].Value);
                Hhh1 += Convert.ToInt32(dataGridView8.Rows[Eee1].Cells[8].Value);
            }
            int Bdtgint1 = Fff1;
            int Bbrkint1 = Ggg1;
            int Blocint1 = Hhh1;
            int Btotint1 = (Fff1 + Ggg1);

            //data hitung all int
            int taidtg1, taibrk1, tailoc1, tbidtg1, tbibrk1, tbiloc1, taitotal1, tbitotal1;

            taidtg1 = Adtgint1;
            taibrk1 = Abrkint1;
            tailoc1 = Alocint1;
            taitotal1 = Atotint1;
            tbidtg1 = Bdtgint1;
            tbibrk1 = Bbrkint1;
            tbiloc1 = Blocint1;
            tbitotal1 = Btotint1;

            int Alldtgint1 = (taidtg1 + tbidtg1);
            int Allbrkint1 = (taibrk1 + tbibrk1);
            int Alllocint1 = (tailoc1 + tbiloc1);
            int Alltotint1 = (taidtg1 + taibrk1 + tbidtg1 + tbibrk1);

            int tdom1, tint1, tloc11, tloc21;
            tdom1 = Alltotdom1;
            tint1 = Alltotint1;
            tloc11 = Alllocdom1;
            tloc21 = Alllocint1;

            textBox6.Text = tdom1.ToString();
            textBox5.Text = tint1.ToString();
            textBox4.Text = (tloc11 + tloc21).ToString();
            textBox3.Text = (tdom1 + tint1 + tloc11 + tloc21).ToString();

            //-2hari
            //data hitung A dom
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label31.Text + "%'  and terminal like '" + "A" + "%' and  hal like '" + "Domestik" + "%' and wilayah like '" + comboBox2.Text + "%'";
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

            int A2 = 0, B2 = 0, C2 = 0, D2 = 0;
            for (A2 = 0; A2 < dataGridView9.Rows.Count; ++A2)
            {
                B2 += Convert.ToInt32(dataGridView9.Rows[A2].Cells[6].Value);
                C2 += Convert.ToInt32(dataGridView9.Rows[A2].Cells[7].Value);
                D2 += Convert.ToInt32(dataGridView9.Rows[A2].Cells[8].Value);
            }
            int Adtgdom2 = B2;
            int Abrkdom2 = C2;
            int Alocdom2 = D2;
            int Atotdom2 = (B2 + C2);

            //data hitung B dom
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label31.Text + "%'  and terminal like '" + "B" + "%' and  hal like '" + "Domestik" + "%' and wilayah like '" + comboBox2.Text + "%'";
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

            int E2 = 0, F2 = 0, G2 = 0, H2 = 0;
            for (E2 = 0; E2 < dataGridView10.Rows.Count; ++E2)
            {
                F2 += Convert.ToInt32(dataGridView10.Rows[E2].Cells[6].Value);
                G2 += Convert.ToInt32(dataGridView10.Rows[E2].Cells[7].Value);
                H2 += Convert.ToInt32(dataGridView10.Rows[E2].Cells[8].Value);
            }
            int Bdtgdom2 = F2;
            int Bbrkdom2 = G2;
            int Blocdom2 = H2;
            int Btotdom2 = (F2 + G2);

            //data hitung all dom
            int tadtg2, tabrk2, taloc2, tbdtg2, tbbrk2, tbloc2, tatotal2, tbtotal2;

            tadtg2 = Adtgdom2;
            tabrk2 = Abrkdom2;
            taloc2 = Alocdom2;
            tatotal2 = Atotdom2;
            tbdtg2 = Bdtgdom2;
            tbbrk2 = Bbrkdom2;
            tbloc2 = Blocdom2;
            tbtotal2 = Btotdom2;
            //
            int Alldtgdom2 = (tadtg2 + tbdtg2);
            int Allbrkdom2 = (tabrk2 + tbbrk2);
            int Alllocdom2 = (taloc2 + tbloc2);
            int Alltotdom2 = (tadtg2 + tabrk2 + tbdtg2 + tbbrk2);

            //internasional
            //data hitung A int
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label31.Text + "%'  and terminal like '" + "A" + "%' and  hal like '" + "Internasional" + "%' and wilayah like '" + comboBox2.Text + "%'";
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

            int Aaa2 = 0, Bbb2 = 0, Ccc2 = 0, Ddd2 = 0;
            for (Aaa2 = 0; Aaa2 < dataGridView11.Rows.Count; ++Aaa2)
            {
                Bbb2 += Convert.ToInt32(dataGridView11.Rows[Aaa2].Cells[6].Value);
                Ccc2 += Convert.ToInt32(dataGridView11.Rows[Aaa2].Cells[7].Value);
                Ddd2 += Convert.ToInt32(dataGridView11.Rows[Aaa2].Cells[8].Value);
            }
            int Adtgint2 = Bbb2;
            int Abrkint2 = Ccc2;
            int Alocint2 = Ddd2;
            int Atotint2 = (Bbb2 + Ccc2);

            //data hitung B int
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label31.Text + "%'  and terminal like '" + "B" + "%' and  hal like '" + "Internasional" + "%' and wilayah like '" + comboBox2.Text + "%'";
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

            int Eee2 = 0, Fff2 = 0, Ggg2 = 0, Hhh2 = 0;
            for (Eee2 = 0; Eee2 < dataGridView12.Rows.Count; ++Eee2)
            {
                Fff2 += Convert.ToInt32(dataGridView12.Rows[Eee2].Cells[6].Value);
                Ggg2 += Convert.ToInt32(dataGridView12.Rows[Eee2].Cells[7].Value);
                Hhh2 += Convert.ToInt32(dataGridView12.Rows[Eee2].Cells[8].Value);
            }
            int Bdtgint2 = Fff2;
            int Bbrkint2 = Ggg2;
            int Blocint2 = Hhh2;
            int Btotint2 = (Fff2 + Ggg2);

            //data hitung all int
            int taidtg2, taibrk2, tailoc2, tbidtg2, tbibrk2, tbiloc2, taitotal2, tbitotal2;

            taidtg2 = Adtgint2;
            taibrk2 = Abrkint2;
            tailoc2 = Alocint2;
            taitotal2 = Atotint2;
            tbidtg2 = Bdtgint2;
            tbibrk2 = Bbrkint2;
            tbiloc2 = Blocint2;
            tbitotal2 = Btotint2;

            int Alldtgint2 = (taidtg2 + tbidtg2);
            int Allbrkint2 = (taibrk2 + tbibrk2);
            int Alllocint2 = (tailoc2 + tbiloc2);
            int Alltotint2 = (taidtg2 + taibrk2 + tbidtg2 + tbibrk2);

            int tdom2, tint2, tloc12, tloc22;
            tdom2 = Alltotdom2;
            tint2 = Alltotint2;
            tloc12 = Alllocdom2;
            tloc22 = Alllocint2;

            textBox11.Text = tdom2.ToString();
            textBox10.Text = tint2.ToString();
            textBox9.Text = (tloc12 + tloc22).ToString();
            textBox8.Text = (tdom2 + tint2 + tloc12 + tloc22).ToString();

            //-3hari
            //data hitung A dom
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label33.Text + "%'  and terminal like '" + "A" + "%' and  hal like '" + "Domestik" + "%' and wilayah like '" + comboBox2.Text + "%'";
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

            int A3 = 0, B3 = 0, C3 = 0, D3 = 0;
            for (A3 = 0; A3 < dataGridView13.Rows.Count; ++A3)
            {
                B3 += Convert.ToInt32(dataGridView13.Rows[A3].Cells[6].Value);
                C3 += Convert.ToInt32(dataGridView13.Rows[A3].Cells[7].Value);
                D3 += Convert.ToInt32(dataGridView13.Rows[A3].Cells[8].Value);
            }
            int Adtgdom3 = B3;
            int Abrkdom3 = C3;
            int Alocdom3 = D3;
            int Atotdom3 = (B3 + C3);

            //data hitung B dom
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label33.Text + "%'  and terminal like '" + "B" + "%' and  hal like '" + "Domestik" + "%' and wilayah like '" + comboBox2.Text + "%'";
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

            int E3 = 0, F3 = 0, G3 = 0, H3 = 0;
            for (E3 = 0; E3 < dataGridView14.Rows.Count; ++E3)
            {
                F3 += Convert.ToInt32(dataGridView14.Rows[E3].Cells[6].Value);
                G3 += Convert.ToInt32(dataGridView14.Rows[E3].Cells[7].Value);
                H3 += Convert.ToInt32(dataGridView14.Rows[E3].Cells[8].Value);
            }
            int Bdtgdom3 = F3;
            int Bbrkdom3 = G3;
            int Blocdom3 = H3;
            int Btotdom3 = (F3 + G3);

            //data hitung all dom
            int tadtg3, tabrk3, taloc3, tbdtg3, tbbrk3, tbloc3, tatotal3, tbtotal3;

            tadtg3 = Adtgdom3;
            tabrk3 = Abrkdom3;
            taloc3 = Alocdom3;
            tatotal3 = Atotdom3;
            tbdtg3 = Bdtgdom3;
            tbbrk3 = Bbrkdom3;
            tbloc3 = Blocdom3;
            tbtotal3 = Btotdom3;
            //
            int Alldtgdom3 = (tadtg3 + tbdtg3);
            int Allbrkdom3 = (tabrk3 + tbbrk3);
            int Alllocdom3 = (taloc3 + tbloc3);
            int Alltotdom3 = (tadtg3 + tabrk3 + tbdtg3 + tbbrk3);

            //internasional
            //data hitung A int
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label33.Text + "%'  and terminal like '" + "A" + "%' and  hal like '" + "Internasional" + "%' and wilayah like '" + comboBox2.Text + "%'";
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

            int Aaa3 = 0, Bbb3 = 0, Ccc3 = 0, Ddd3 = 0;
            for (Aaa3 = 0; Aaa3 < dataGridView15.Rows.Count; ++Aaa3)
            {
                Bbb3 += Convert.ToInt32(dataGridView15.Rows[Aaa3].Cells[6].Value);
                Ccc3 += Convert.ToInt32(dataGridView15.Rows[Aaa3].Cells[7].Value);
                Ddd3 += Convert.ToInt32(dataGridView15.Rows[Aaa3].Cells[8].Value);
            }
            int Adtgint3 = Bbb3;
            int Abrkint3 = Ccc3;
            int Alocint3 = Ddd3;
            int Atotint3 = (Bbb3 + Ccc3);

            //data hitung B int
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label33.Text + "%'  and terminal like '" + "B" + "%' and  hal like '" + "Internasional" + "%' and wilayah like '" + comboBox2.Text + "%'";
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

            int Eee3 = 0, Fff3 = 0, Ggg3 = 0, Hhh3 = 0;
            for (Eee3 = 0; Eee3 < dataGridView16.Rows.Count; ++Eee3)
            {
                Fff3 += Convert.ToInt32(dataGridView16.Rows[Eee3].Cells[6].Value);
                Ggg3 += Convert.ToInt32(dataGridView16.Rows[Eee3].Cells[7].Value);
                Hhh3 += Convert.ToInt32(dataGridView16.Rows[Eee3].Cells[8].Value);
            }
            int Bdtgint3 = Fff3;
            int Bbrkint3 = Ggg3;
            int Blocint3 = Hhh3;
            int Btotint3 = (Fff3 + Ggg3);

            //data hitung all int
            int taidtg3, taibrk3, tailoc3, tbidtg3, tbibrk3, tbiloc3, taitotal3, tbitotal3;

            taidtg3 = Adtgint3;
            taibrk3 = Abrkint3;
            tailoc3 = Alocint3;
            taitotal3 = Atotint3;
            tbidtg3 = Bdtgint3;
            tbibrk3 = Bbrkint3;
            tbiloc3 = Blocint3;
            tbitotal3 = Btotint3;

            int Alldtgint3 = (taidtg3 + tbidtg3);
            int Allbrkint3 = (taibrk3 + tbibrk3);
            int Alllocint3 = (tailoc3 + tbiloc3);
            int Alltotint3 = (taidtg3 + taibrk3 + tbidtg3 + tbibrk3);

            int tdom3, tint3, tloc13, tloc23;
            tdom3 = Alltotdom3;
            tint3 = Alltotint3;
            tloc13 = Alllocdom3;
            tloc23 = Alllocint3;

            textBox16.Text = tdom3.ToString();
            textBox15.Text = tint3.ToString();
            textBox14.Text = (tloc13 + tloc23).ToString();
            textBox13.Text = (tdom3 + tint3 + tloc13 + tloc23).ToString();

            //-4hari
            //data hitung A dom
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label34.Text + "%'  and terminal like '" + "A" + "%' and  hal like '" + "Domestik" + "%' and wilayah like '" + comboBox2.Text + "%'";
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

            int A4 = 0, B4 = 0, C4 = 0, D4 = 0;
            for (A4 = 0; A4 < dataGridView17.Rows.Count; ++A4)
            {
                B4 += Convert.ToInt32(dataGridView17.Rows[A4].Cells[6].Value);
                C4 += Convert.ToInt32(dataGridView17.Rows[A4].Cells[7].Value);
                D4 += Convert.ToInt32(dataGridView17.Rows[A4].Cells[8].Value);
            }
            int Adtgdom4 = B4;
            int Abrkdom4 = C4;
            int Alocdom4 = D4;
            int Atotdom4 = (B4 + C4);

            //data hitung B dom
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label34.Text + "%'  and terminal like '" + "B" + "%' and  hal like '" + "Domestik" + "%' and wilayah like '" + comboBox2.Text + "%'";
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

            int E4 = 0, F4 = 0, G4 = 0, H4 = 0;
            for (E4 = 0; E4 < dataGridView18.Rows.Count; ++E4)
            {
                F4 += Convert.ToInt32(dataGridView18.Rows[E4].Cells[6].Value);
                G4 += Convert.ToInt32(dataGridView18.Rows[E4].Cells[7].Value);
                H4 += Convert.ToInt32(dataGridView18.Rows[E4].Cells[8].Value);
            }
            int Bdtgdom4 = F4;
            int Bbrkdom4 = G4;
            int Blocdom4 = H4;
            int Btotdom4 = (F4 + G4);

            //data hitung all dom
            int tadtg4, tabrk4, taloc4, tbdtg4, tbbrk4, tbloc4, tatotal4, tbtotal4;

            tadtg4 = Adtgdom4;
            tabrk4 = Abrkdom4;
            taloc4 = Alocdom4;
            tatotal4 = Atotdom4;
            tbdtg4 = Bdtgdom4;
            tbbrk4 = Bbrkdom4;
            tbloc4 = Blocdom4;
            tbtotal4 = Btotdom4;
            //
            int Alldtgdom4 = (tadtg4 + tbdtg4);
            int Allbrkdom4 = (tabrk4 + tbbrk4);
            int Alllocdom4 = (taloc4 + tbloc4);
            int Alltotdom4 = (tadtg4 + tabrk4 + tbdtg4 + tbbrk4);

            //internasional
            //data hitung A int
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label34.Text + "%'  and terminal like '" + "A" + "%' and  hal like '" + "Internasional" + "%' and wilayah like '" + comboBox2.Text + "%'";
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

            int Aaa4 = 0, Bbb4 = 0, Ccc4 = 0, Ddd4 = 0;
            for (Aaa4 = 0; Aaa4 < dataGridView19.Rows.Count; ++Aaa4)
            {
                Bbb4 += Convert.ToInt32(dataGridView19.Rows[Aaa4].Cells[6].Value);
                Ccc4 += Convert.ToInt32(dataGridView19.Rows[Aaa4].Cells[7].Value);
                Ddd4 += Convert.ToInt32(dataGridView19.Rows[Aaa4].Cells[8].Value);
            }
            int Adtgint4 = Bbb4;
            int Abrkint4 = Ccc4;
            int Alocint4 = Ddd4;
            int Atotint4 = (Bbb4 + Ccc4);

            //data hitung B int
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label34.Text + "%'  and terminal like '" + "B" + "%' and  hal like '" + "Internasional" + "%' and wilayah like '" + comboBox2.Text + "%'";
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

            int Eee4 = 0, Fff4 = 0, Ggg4 = 0, Hhh4 = 0;
            for (Eee4 = 0; Eee4 < dataGridView20.Rows.Count; ++Eee4)
            {
                Fff4 += Convert.ToInt32(dataGridView20.Rows[Eee4].Cells[6].Value);
                Ggg4 += Convert.ToInt32(dataGridView20.Rows[Eee4].Cells[7].Value);
                Hhh4 += Convert.ToInt32(dataGridView20.Rows[Eee4].Cells[8].Value);
            }
            int Bdtgint4 = Fff4;
            int Bbrkint4 = Ggg4;
            int Blocint4 = Hhh4;
            int Btotint4 = (Fff4 + Ggg4);

            //data hitung all int
            int taidtg4, taibrk4, tailoc4, tbidtg4, tbibrk4, tbiloc4, taitotal4, tbitotal4;

            taidtg4 = Adtgint4;
            taibrk4 = Abrkint4;
            tailoc4 = Alocint4;
            taitotal4 = Atotint4;
            tbidtg4 = Bdtgint4;
            tbibrk4 = Bbrkint4;
            tbiloc4 = Blocint4;
            tbitotal4 = Btotint4;

            int Alldtgint4 = (taidtg4 + tbidtg4);
            int Allbrkint4 = (taibrk4 + tbibrk4);
            int Alllocint4 = (tailoc4 + tbiloc4);
            int Alltotint4 = (taidtg4 + taibrk4 + tbidtg4 + tbibrk4);

            int tdom4, tint4, tloc14, tloc24;
            tdom4 = Alltotdom4;
            tint4 = Alltotint4;
            tloc14 = Alllocdom4;
            tloc24 = Alllocint4;

            textBox21.Text = tdom4.ToString();
            textBox20.Text = tint4.ToString();
            textBox19.Text = (tloc14 + tloc24).ToString();
            textBox18.Text = (tdom4 + tint4 + tloc14 + tloc24).ToString();

            //-5hari
            //data hitung A dom
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label35.Text + "%'  and terminal like '" + "A" + "%' and  hal like '" + "Domestik" + "%' and wilayah like '" + comboBox2.Text + "%'";
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

            int A5 = 0, B5 = 0, C5 = 0, D5 = 0;
            for (A5 = 0; A5 < dataGridView21.Rows.Count; ++A5)
            {
                B5 += Convert.ToInt32(dataGridView21.Rows[A5].Cells[6].Value);
                C5 += Convert.ToInt32(dataGridView21.Rows[A5].Cells[7].Value);
                D5 += Convert.ToInt32(dataGridView21.Rows[A5].Cells[8].Value);
            }
            int Adtgdom5 = B5;
            int Abrkdom5 = C5;
            int Alocdom5 = D5;
            int Atotdom5 = (B5 + C5);

            //data hitung B dom
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label35.Text + "%'  and terminal like '" + "B" + "%' and  hal like '" + "Domestik" + "%' and wilayah like '" + comboBox2.Text + "%'";
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

            int E5 = 0, F5 = 0, G5 = 0, H5 = 0;
            for (E5 = 0; E5 < dataGridView22.Rows.Count; ++E5)
            {
                F5 += Convert.ToInt32(dataGridView22.Rows[E5].Cells[6].Value);
                G5 += Convert.ToInt32(dataGridView22.Rows[E5].Cells[7].Value);
                H5 += Convert.ToInt32(dataGridView22.Rows[E5].Cells[8].Value);
            }
            int Bdtgdom5 = F5;
            int Bbrkdom5 = G5;
            int Blocdom5 = H5;
            int Btotdom5 = (F5 + G5);

            //data hitung all dom
            int tadtg5, tabrk5, taloc5, tbdtg5, tbbrk5, tbloc5, tatotal5, tbtotal5;

            tadtg5 = Adtgdom5;
            tabrk5 = Abrkdom5;
            taloc5 = Alocdom5;
            tatotal5 = Atotdom5;
            tbdtg5 = Bdtgdom5;
            tbbrk5 = Bbrkdom5;
            tbloc5 = Blocdom5;
            tbtotal5 = Btotdom5;
            //
            int Alldtgdom5 = (tadtg5 + tbdtg5);
            int Allbrkdom5 = (tabrk5 + tbbrk5);
            int Alllocdom5 = (taloc5 + tbloc5);
            int Alltotdom5 = (tadtg5 + tabrk5 + tbdtg5 + tbbrk5);

            //internasional
            //data hitung A int
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label35.Text + "%'  and terminal like '" + "A" + "%' and  hal like '" + "Internasional" + "%' and wilayah like '" + comboBox2.Text + "%'";
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

            int Aaa5 = 0, Bbb5 = 0, Ccc5 = 0, Ddd5 = 0;
            for (Aaa5 = 0; Aaa5 < dataGridView23.Rows.Count; ++Aaa5)
            {
                Bbb5 += Convert.ToInt32(dataGridView23.Rows[Aaa5].Cells[6].Value);
                Ccc5 += Convert.ToInt32(dataGridView23.Rows[Aaa5].Cells[7].Value);
                Ddd5 += Convert.ToInt32(dataGridView23.Rows[Aaa5].Cells[8].Value);
            }
            int Adtgint5 = Bbb5;
            int Abrkint5 = Ccc5;
            int Alocint5 = Ddd5;
            int Atotint5 = (Bbb5 + Ccc5);

            //data hitung B int
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + label35.Text + "%'  and terminal like '" + "B" + "%' and  hal like '" + "Internasional" + "%' and wilayah like '" + comboBox2.Text + "%'";
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

            int Eee5 = 0, Fff5 = 0, Ggg5 = 0, Hhh5 = 0;
            for (Eee5 = 0; Eee5 < dataGridView24.Rows.Count; ++Eee5)
            {
                Fff5 += Convert.ToInt32(dataGridView24.Rows[Eee5].Cells[6].Value);
                Ggg5 += Convert.ToInt32(dataGridView24.Rows[Eee5].Cells[7].Value);
                Hhh5 += Convert.ToInt32(dataGridView24.Rows[Eee5].Cells[8].Value);
            }
            int Bdtgint5 = Fff5;
            int Bbrkint5 = Ggg5;
            int Blocint5 = Hhh5;
            int Btotint5 = (Fff5 + Ggg5);

            //data hitung all int
            int taidtg5, taibrk5, tailoc5, tbidtg5, tbibrk5, tbiloc5, taitotal5, tbitotal5;

            taidtg5 = Adtgint5;
            taibrk5 = Abrkint5;
            tailoc5 = Alocint5;
            taitotal5 = Atotint5;
            tbidtg5 = Bdtgint5;
            tbibrk5 = Bbrkint5;
            tbiloc5 = Blocint5;
            tbitotal5 = Btotint5;

            int Alldtgint5 = (taidtg5 + tbidtg5);
            int Allbrkint5 = (taibrk5 + tbibrk5);
            int Alllocint5 = (tailoc5 + tbiloc5);
            int Alltotint5 = (taidtg5 + taibrk5 + tbidtg5 + tbibrk5);

            int tdom5, tint5, tloc15, tloc25;
            tdom5 = Alltotdom5;
            tint5 = Alltotint5;
            tloc15 = Alllocdom5;
            tloc25 = Alllocint5;

            textBox26.Text = tdom5.ToString();
            textBox25.Text = tint5.ToString();
            textBox24.Text = (tloc15 + tloc25).ToString();
            textBox23.Text = (tdom5 + tint5 + tloc15 + tloc25).ToString();

            //chart
            this.chart1.Series["DOM"].Points.AddXY(textBox1.Text, int.Parse(textBox32.Text));
            this.chart1.Series["INT"].Points.AddXY(textBox1.Text, int.Parse(textBox31.Text));
            this.chart1.Series["LOC"].Points.AddXY(textBox1.Text, int.Parse(textBox30.Text));

            this.chart1.Series["DOM"].Points.AddXY(label30.Text, int.Parse(textBox6.Text));
            this.chart1.Series["INT"].Points.AddXY(label30.Text, int.Parse(textBox5.Text));
            this.chart1.Series["LOC"].Points.AddXY(label30.Text, int.Parse(textBox4.Text));

            this.chart1.Series["DOM"].Points.AddXY(label31.Text, int.Parse(textBox11.Text));
            this.chart1.Series["INT"].Points.AddXY(label31.Text, int.Parse(textBox10.Text));
            this.chart1.Series["LOC"].Points.AddXY(label31.Text, int.Parse(textBox9.Text));

            this.chart1.Series["DOM"].Points.AddXY(label33.Text, int.Parse(textBox16.Text));
            this.chart1.Series["INT"].Points.AddXY(label33.Text, int.Parse(textBox15.Text));
            this.chart1.Series["LOC"].Points.AddXY(label33.Text, int.Parse(textBox14.Text));

            this.chart1.Series["DOM"].Points.AddXY(label34.Text, int.Parse(textBox21.Text));
            this.chart1.Series["INT"].Points.AddXY(label34.Text, int.Parse(textBox20.Text));
            this.chart1.Series["LOC"].Points.AddXY(label34.Text, int.Parse(textBox19.Text));

            this.chart1.Series["DOM"].Points.AddXY(label35.Text, int.Parse(textBox26.Text));
            this.chart1.Series["INT"].Points.AddXY(label35.Text, int.Parse(textBox25.Text));
            this.chart1.Series["LOC"].Points.AddXY(label35.Text, int.Parse(textBox24.Text));

            //persentase

            label37.Text = textBox1.Text;
            label38.Text = label30.Text;
            label39.Text = label31.Text;
            label40.Text = label33.Text;
            label41.Text = label34.Text;
            label42.Text = label35.Text;

            double p1 = double.Parse(textBox29.Text);
            double p2 = double.Parse(textBox3.Text);
            double p3 = double.Parse(textBox8.Text);
            double p4 = double.Parse(textBox13.Text);
            double p5 = double.Parse(textBox18.Text);
            double p6 = double.Parse(textBox23.Text);

            textBox17.Text = "-";
            textBox12.Text = Math.Round((((p2 - p1) / p1) * 100), 2).ToString() + "%";
            textBox7.Text = Math.Round((((p3 - p2) / p2) * 100), 2).ToString() + "%";
            textBox2.Text = Math.Round((((p4 - p3) / p3) * 100), 2).ToString() + "%";
            textBox27.Text = Math.Round((((p5 - p4) / p4) * 100), 2).ToString() + "%";
            textBox22.Text =Math.Round((((p6 - p5) / p5) * 100), 2).ToString() + "%";

            //2017
            double t4 = double.Parse(textBox32.Text);
            double t5 = double.Parse(textBox31.Text);
            double t6 = double.Parse(textBox30.Text);
            //2016
            double t1 = double.Parse(textBox6.Text);
            double t2 = double.Parse(textBox5.Text);
            double t3 = double.Parse(textBox4.Text);

            textBox37.Text = Math.Round((((t4 - t1) / t1) * 100), 2).ToString() + "%";
            textBox36.Text = Math.Round((((t5 - t2) / t2) * 100), 2).ToString() + "%";
            textBox35.Text = Math.Round((((t6 - t3) / t3) * 100), 2).ToString() + "%";

            this.chart2.Series["Series1"].Points.AddXY("DOM", int.Parse(textBox32.Text));
            this.chart2.Series["Series2"].Points.AddXY("DOM", int.Parse(textBox6.Text));
            this.chart2.Series["Series1"].Points.AddXY("INT", int.Parse(textBox31.Text));
            this.chart2.Series["Series2"].Points.AddXY("INT", int.Parse(textBox5.Text));
            this.chart2.Series["Series1"].Points.AddXY("LOC", int.Parse(textBox30.Text));
            this.chart2.Series["Series2"].Points.AddXY("LOC", int.Parse(textBox4.Text));




        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
