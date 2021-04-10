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
    public partial class Form2 : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\source\repos\OlahDataAirside\OlahDataAirside\AirsideDatabase.accdb");
        OleDbCommand cmd;
        OleDbCommandBuilder cb;
        OleDbDataAdapter da;
        DataTable dt;
        int id = 0;

        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'airsideDatabaseDataSet1.database' table. You can move, or remove it, as needed.
            this.databaseTableAdapter.Fill(this.airsideDatabaseDataSet1.database);
            disp_data();
        }

        private void disp_data()
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [database]";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void clear_data()
        {

        }
        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
 
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
            {
                label8.Text = radioButton8.Text;
            }
            else if (radioButton9.Checked)
            {
                label8.Text = radioButton9.Text;
            }
            else
            {
                label8.Text = "pilih terminal";
            }

            if (radioButton6.Checked)
            {
                label9.Text = radioButton6.Text;
            }
            else if (radioButton7.Checked)
            {
                label9.Text = radioButton6.Text;
            }
            else
            {
                label9.Text = "pilih wilayah";
            }

            if (radioButton1.Checked)
            {
                label10.Text = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                label10.Text = radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                label10.Text = radioButton3.Text;
            }
            else if (radioButton4.Checked)
            {
                label10.Text = radioButton4.Text;
            }
            else if (radioButton5.Checked)
            {
                label10.Text = radioButton5.Text;
            }
            else
            {
                label10.Text = "pilih terminal";
            }

            if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text) && !String.IsNullOrEmpty(textBox5.Text) && !String.IsNullOrEmpty(textBox6.Text))
            {
                if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false && radioButton5.Checked == false)
                { 
                    MessageBox.Show("Pilih Option1");
                }
                else if (radioButton6.Checked == false && radioButton7.Checked == false)
                {
                    MessageBox.Show("Pilih Option2");
                }
                else if(radioButton8.Checked == false && radioButton9.Checked == false)
                {
                    MessageBox.Show("Pilih Option3");
                }
                else
                {

                    try
                    {
                        con.Open();
                        OleDbCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "INSERT INTO [database] (bulan, tahun, terminal, hal, wilayah, datang, berangkat, lokal) values('" + comboBox1.Text + "','" + textBox1.Text + "', '" + label8.Text + "', '" + label9.Text + "', '" + label10.Text + "', '" + textBox2.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "')";
                        cmd.ExecuteNonQuery();
                        con.Close();
                        disp_data();

                        MessageBox.Show("record inserted succesfully");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(" Error   " + ex);
                    }
                }
            }
            else
            {
                MessageBox.Show("Data masih kosong");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(label20.Text) != 0)
                {
                    con.Open();
                    cmd = new OleDbCommand("delete from [database] where id=@id", con);
                    cmd.Parameters.AddWithValue("@id", label20.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Deleted succesfully");
                    disp_data();
                }
                else
                {
                    MessageBox.Show("please selected record to delete");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("error " + ex);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 fl = new Form2();
            fl.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new OleDbCommand("update [database] set tahun=@tahun where id=@id", con);
                cmd.Parameters.Add("@id", OleDbType.Integer).Value = int.Parse(label20.Text);
                cmd.Parameters.Add("@tahun", OleDbType.Numeric).Value = int.Parse(label14.Text);
                cmd.ExecuteNonQuery();

                con.Close();


                MessageBox.Show("Update Berhasil");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [database] where tahun like '" + textBox7.Text + "%'";
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

            int A = 0, B = 0, C = 0, D = 0;
            for (A = 0; A < dataGridView2.Rows.Count; ++A)
            {
                B += Convert.ToInt32(dataGridView2.Rows[A].Cells[6].Value);
                C += Convert.ToInt32(dataGridView2.Rows[A].Cells[7].Value);
                D += Convert.ToInt32(dataGridView2.Rows[A].Cells[8].Value);
            } 
            textBox14.Text = B.ToString();
            textBox15.Text = C.ToString();
            textBox16.Text = D.ToString();
            textBox17.Text = (B + C + D).ToString();

            int E = 0, F = 0, G = 0, H = 0, n=6;
            for (E = 0; E < n; ++E)
            {
                F += Convert.ToInt32(dataGridView2.Rows[E].Cells[6].Value);
                G += Convert.ToInt32(dataGridView2.Rows[E].Cells[7].Value);
                H += Convert.ToInt32(dataGridView2.Rows[E].Cells[8].Value);
            }
            textBox18.Text = F.ToString();
            textBox57.Text = G.ToString();
            textBox59.Text = H.ToString();

            int I = 6, J = 0, K = 0, L = 0, m = 12;
            for (I = 6; I < m; ++I)
            {
                J += Convert.ToInt32(dataGridView2.Rows[I].Cells[6].Value);
                K += Convert.ToInt32(dataGridView2.Rows[I].Cells[7].Value);
                L += Convert.ToInt32(dataGridView2.Rows[I].Cells[8].Value);
            }
            textBox19.Text = J.ToString();
            textBox56.Text = K.ToString();
            textBox58.Text = L.ToString();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                label14.Text = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                label20.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            cmd = new OleDbCommand("update [database] set tahun=@tahun where id=@id", con);
            cmd.Parameters.Add("@id", OleDbType.Integer).Value = int.Parse(label20.Text);
            cmd.Parameters.Add("@tahun", OleDbType.Numeric).Value = int.Parse(label14.Text);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("update succes");
            }
            catch(Exception ex)
            {
                MessageBox.Show("error " + ex);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 fn = new Form3();
            fn.Show();
            this.Hide();
        }
    }
}
