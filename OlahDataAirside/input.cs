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
    public partial class input : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = D:\source\repos\OlahDataAirside\OlahDataAirside\AirsideDatabase.accdb");
        public input()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            if (radioButton1.Checked == true)
            {
                if(textBox2.Text.Length > 0)
                {
                    cmd.CommandText = "insert into pesawatAdom(bln_pwtAD,dtg_pwtAD,brk_pwtAD,lok_pwtAD,thn_pwtAD,jml_pwtAD,total_dtgpwtAD,total_brkpwtAD,total_lokpwtAD,total_pwtAD) values('" + label3.Text + "','" + textBox2.Text + "','" + textBox26.Text + "','" + textBox38.Text + "','" + textBox1.Text + "','" + textBox50.Text + "','" + textBox14.Text + "','" + textBox15.Text + "','" + textBox16.Text + "','" + textBox17.Text + "')";
                    cmd.ExecuteNonQuery();
                }

                if (textBox3.Text.Length > 0)
                {
                    cmd.CommandText = "insert into pesawatAdom(bln_pwtAD,dtg_pwtAD,brk_pwtAD,lok_pwtAD,thn_pwtAD,jml_pwtAD,total_dtgpwtAD,total_brkpwtAD,total_lokpwtAD,total_pwtAD) values('" + label4.Text + "','" + textBox3.Text + "','" + textBox27.Text + "','" + textBox39.Text + "','" + textBox1.Text + "','" + textBox51.Text + "','" + textBox14.Text + "','" + textBox15.Text + "','" + textBox16.Text + "','" + textBox17.Text + "')";
                    cmd.ExecuteNonQuery();
                }

                if (textBox4.Text.Length > 0)
                {
                    cmd.CommandText = "insert into pesawatAdom(bln_pwtAD,dtg_pwtAD,brk_pwtAD,lok_pwtAD,thn_pwtAD,jml_pwtAD,total_dtgpwtAD,total_brkpwtAD,total_lokpwtAD,total_pwtAD) values('" + label5.Text + "','" + textBox4.Text + "','" + textBox29.Text + "','" + textBox41.Text + "','" + textBox1.Text + "','" + textBox53.Text + "','" + textBox14.Text + "','" + textBox15.Text + "','" + textBox16.Text + "','" + textBox17.Text + "')";
                    cmd.ExecuteNonQuery();
                }

                if (textBox5.Text.Length > 0)
                {
                    cmd.CommandText = "insert into pesawatAdom(bln_pwtAD,dtg_pwtAD,brk_pwtAD,lok_pwtAD,thn_pwtAD,jml_pwtAD,total_dtgpwtAD,total_brkpwtAD,total_lokpwtAD,total_pwtAD) values('" + label6.Text + "','" + textBox5.Text + "','" + textBox30.Text + "','" + textBox42.Text + "','" + textBox1.Text + "','" + textBox54.Text + "','" + textBox14.Text + "','" + textBox15.Text + "','" + textBox16.Text + "','" + textBox17.Text + "')";
                    cmd.ExecuteNonQuery();
                }

                if (textBox6.Text.Length > 0)
                {
                    cmd.CommandText = "insert into pesawatAdom(bln_pwtAD,dtg_pwtAD,brk_pwtAD,lok_pwtAD,thn_pwtAD,jml_pwtAD,total_dtgpwtAD,total_brkpwtAD,total_lokpwtAD,total_pwtAD) values('" + label7.Text + "','" + textBox6.Text + "','" + textBox31.Text + "','" + textBox43.Text + "','" + textBox1.Text + "','" + textBox55.Text + "','" + textBox14.Text + "','" + textBox15.Text + "','" + textBox16.Text + "','" + textBox17.Text + "')";
                    cmd.ExecuteNonQuery();
                }

                if (textBox7.Text.Length > 0)
                {
                    cmd.CommandText = "insert into pesawatAdom(bln_pwtAD,dtg_pwtAD,brk_pwtAD,lok_pwtAD,thn_pwtAD,jml_pwtAD,total_dtgpwtAD,total_brkpwtAD,total_lokpwtAD,total_pwtAD) values('" + label8.Text + "','" + textBox7.Text + "','" + textBox28.Text + "','" + textBox40.Text + "','" + textBox1.Text + "','" + textBox52.Text + "','" + textBox14.Text + "','" + textBox15.Text + "','" + textBox16.Text + "','" + textBox17.Text + "')";
                    cmd.ExecuteNonQuery();
                }

                if (textBox8.Text.Length > 0)
                {
                    cmd.CommandText = "insert into pesawatAdom(bln_pwtAD,dtg_pwtAD,brk_pwtAD,lok_pwtAD,thn_pwtAD,jml_pwtAD,total_dtgpwtAD,total_brkpwtAD,total_lokpwtAD,total_pwtAD) values('" + label9.Text + "','" + textBox8.Text + "','" + textBox25.Text + "','" + textBox37.Text + "','" + textBox1.Text + "','" + textBox49.Text + "','" + textBox14.Text + "','" + textBox15.Text + "','" + textBox16.Text + "','" + textBox17.Text + "')";
                    cmd.ExecuteNonQuery();
                }

                if (textBox9.Text.Length > 0)
                {
                    cmd.CommandText = "insert into pesawatAdom(bln_pwtAD,dtg_pwtAD,brk_pwtAD,lok_pwtAD,thn_pwtAD,jml_pwtAD,total_dtgpwtAD,total_brkpwtAD,total_lokpwtAD,total_pwtAD) values('" + label10.Text + "','" + textBox9.Text + "','" + textBox24.Text + "','" + textBox36.Text + "','" + textBox1.Text + "','" + textBox48.Text + "','" + textBox14.Text + "','" + textBox15.Text + "','" + textBox16.Text + "','" + textBox17.Text + "')";
                    cmd.ExecuteNonQuery();
                }

                if (textBox10.Text.Length > 0)
                {
                    cmd.CommandText = "insert into pesawatAdom(bln_pwtAD,dtg_pwtAD,brk_pwtAD,lok_pwtAD,thn_pwtAD,jml_pwtAD,total_dtgpwtAD,total_brkpwtAD,total_lokpwtAD,total_pwtAD) values('" + label11.Text + "','" + textBox10.Text + "','" + textBox23.Text + "','" + textBox35.Text + "','" + textBox1.Text + "','" + textBox47.Text + "','" + textBox14.Text + "','" + textBox15.Text + "','" + textBox16.Text + "','" + textBox17.Text + "')";
                    cmd.ExecuteNonQuery();
                }

                if (textBox11.Text.Length > 0)
                {
                    cmd.CommandText = "insert into pesawatAdom(bln_pwtAD,dtg_pwtAD,brk_pwtAD,lok_pwtAD,thn_pwtAD,jml_pwtAD,total_dtgpwtAD,total_brkpwtAD,total_lokpwtAD,total_pwtAD) values('" + label12.Text + "','" + textBox11.Text + "','" + textBox22.Text + "','" + textBox34.Text + "','" + textBox1.Text + "','" + textBox46.Text + "','" + textBox14.Text + "','" + textBox15.Text + "','" + textBox16.Text + "','" + textBox17.Text + "')";
                    cmd.ExecuteNonQuery();
                }

                if (textBox12.Text.Length > 0)
                {
                    cmd.CommandText = "insert into pesawatAdom(bln_pwtAD,dtg_pwtAD,brk_pwtAD,lok_pwtAD,thn_pwtAD,jml_pwtAD,total_dtgpwtAD,total_brkpwtAD,total_lokpwtAD,total_pwtAD) values('" + label13.Text + "','" + textBox12.Text + "','" + textBox21.Text + "','" + textBox33.Text + "','" + textBox1.Text + "','" + textBox45.Text + "','" + textBox14.Text + "','" + textBox15.Text + "','" + textBox16.Text + "','" + textBox17.Text + "')";
                    cmd.ExecuteNonQuery();
                }

                if (textBox13.Text.Length > 0)
                {
                    cmd.CommandText = "insert into pesawatAdom(bln_pwtAD,dtg_pwtAD,brk_pwtAD,lok_pwtAD,thn_pwtAD,jml_pwtAD,total_dtgpwtAD,total_brkpwtAD,total_lokpwtAD,total_pwtAD) values('" + label14.Text + "','" + textBox13.Text + "','" + textBox20.Text + "','" + textBox32.Text + "','" + textBox1.Text + "','" + textBox44.Text + "','" + textBox14.Text + "','" + textBox15.Text + "','" + textBox16.Text + "','" + textBox17.Text + "')";
                    cmd.ExecuteNonQuery();
                }

            }
            else if (radioButton2.Checked == true)
            {
                if (textBox2.Text.Length > 0)
                {
                    cmd.CommandText = "insert into ((bln_pwtAD,dtg_pwtAD,thn_pwtAD) values('" + label4.Text + "','" + textBox3.Text + "','" + textBox1.Text + "')";
                    cmd.ExecuteNonQuery();
                }

                if (textBox3.Text.Length > 0)
                {
                    cmd.CommandText = "insert into pesawatAdom(bln_pwtAD,dtg_pwtAD,thn_pwtAD) values('" + label4.Text + "','" + textBox3.Text + "','" + textBox1.Text + "')";
                    cmd.ExecuteNonQuery();
                }

                if (textBox4.Text.Length > 0)
                {
                    cmd.CommandText = "insert into pesawatAdom(bln_pwtAD,dtg_pwtAD,thn_pwtAD) values('" + label5.Text + "','" + textBox4.Text + "','" + textBox1.Text + "')";
                    cmd.ExecuteNonQuery();
                }

                if (textBox5.Text.Length > 0)
                {
                    cmd.CommandText = "insert into pesawatAdom(bln_pwtAD,dtg_pwtAD,thn_pwtAD) values('" + label6.Text + "','" + textBox5.Text + "','" + textBox1.Text + "')";
                    cmd.ExecuteNonQuery();
                }

                if (textBox6.Text.Length > 0)
                {
                    cmd.CommandText = "insert into pesawatAdom(bln_pwtAD,dtg_pwtAD,thn_pwtAD) values('" + label7.Text + "','" + textBox6.Text + "','" + textBox1.Text + "')";
                    cmd.ExecuteNonQuery();
                }

                if (textBox7.Text.Length > 0)
                {
                    cmd.CommandText = "insert into pesawatAdom(bln_pwtAD,dtg_pwtAD,thn_pwtAD) values('" + label8.Text + "','" + textBox7.Text + "','" + textBox1.Text + "')";
                    cmd.ExecuteNonQuery();
                }

                if (textBox8.Text.Length > 0)
                {
                    cmd.CommandText = "insert into pesawatAdom(bln_pwtAD,dtg_pwtAD,thn_pwtAD) values('" + label9.Text + "','" + textBox8.Text + "','" + textBox1.Text + "')";
                    cmd.ExecuteNonQuery();
                }

                if (textBox9.Text.Length > 0)
                {
                    cmd.CommandText = "insert into pesawatAdom(bln_pwtAD,dtg_pwtAD,thn_pwtAD) values('" + label10.Text + "','" + textBox9.Text + "','" + textBox1.Text + "')";
                    cmd.ExecuteNonQuery();
                }

                if (textBox10.Text.Length > 0)
                {
                    cmd.CommandText = "insert into pesawatAdom(bln_pwtAD,dtg_pwtAD,thn_pwtAD) values('" + label11.Text + "','" + textBox10.Text + "','" + textBox1.Text + "')";
                    cmd.ExecuteNonQuery();
                }

                if (textBox11.Text.Length > 0)
                {
                    cmd.CommandText = "insert into pesawatAdom(bln_pwtAD,dtg_pwtAD,thn_pwtAD) values('" + label12.Text + "','" + textBox11.Text + "','" + textBox1.Text + "')";
                    cmd.ExecuteNonQuery();
                }

                if (textBox12.Text.Length > 0)
                {
                    cmd.CommandText = "insert into pesawatAdom(bln_pwtAD,dtg_pwtAD,thn_pwtAD) values('" + label13.Text + "','" + textBox12.Text + "','" + textBox1.Text + "')";
                    cmd.ExecuteNonQuery();
                }

                if (textBox13.Text.Length > 0)
                {
                    cmd.CommandText = "insert into pesawatAdom(bln_pwtAD,dtg_pwtAD,thn_pwtAD) values('" + label14.Text + "','" + textBox13.Text + "','" + textBox1.Text + "')";
                    cmd.ExecuteNonQuery();
                }

            }
            else
            {
                MessageBox.Show("Pilih Salah Satu");
            }
            
            con.Close();

            MessageBox.Show("record inserted succesfully");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form2 data = new Form2();
            data.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double dtg1, dtg2, dtg3, dtg4, dtg5, dtg6, dtg7, dtg8, dtg9, dtg10, dtg11, dtg12, brk1, brk2, brk3, brk4, brk5, brk6, brk7, brk8, brk9, brk10, brk11, brk12, lok1, lok2, lok3, lok4, lok5, lok6, lok7, lok8, lok9, lok10, lok11, lok12;
            dtg1 = double.Parse(textBox2.Text);
            dtg2 = double.Parse(textBox3.Text);
            dtg3 = double.Parse(textBox4.Text);
            dtg4 = double.Parse(textBox5.Text);
            dtg5 = double.Parse(textBox6.Text);
            dtg6 = double.Parse(textBox7.Text);
            dtg7 = double.Parse(textBox8.Text);
            dtg8 = double.Parse(textBox9.Text);
            dtg9 = double.Parse(textBox10.Text);
            dtg10 = double.Parse(textBox11.Text);
            dtg11 = double.Parse(textBox12.Text);
            dtg12 = double.Parse(textBox13.Text);

            brk1 = double.Parse(textBox26.Text);
            brk2 = double.Parse(textBox27.Text);
            brk3 = double.Parse(textBox29.Text);
            brk4 = double.Parse(textBox30.Text);
            brk5 = double.Parse(textBox31.Text);
            brk6 = double.Parse(textBox28.Text);
            brk7 = double.Parse(textBox25.Text);
            brk8 = double.Parse(textBox24.Text);
            brk9 = double.Parse(textBox23.Text);
            brk10 = double.Parse(textBox22.Text);
            brk11 = double.Parse(textBox21.Text);
            brk12 = double.Parse(textBox20.Text);

            lok1 = double.Parse(textBox38.Text);
            lok2 = double.Parse(textBox39.Text);
            lok3 = double.Parse(textBox41.Text);
            lok4 = double.Parse(textBox42.Text);
            lok5 = double.Parse(textBox43.Text);
            lok6 = double.Parse(textBox40.Text);
            lok7 = double.Parse(textBox37.Text);
            lok8 = double.Parse(textBox36.Text);
            lok9 = double.Parse(textBox35.Text);
            lok10 = double.Parse(textBox34.Text);
            lok11 = double.Parse(textBox33.Text);
            lok12 = double.Parse(textBox32.Text);


            
            textBox48.Text = textBox9.Text + textBox24.Text + textBox36.Text;
            textBox47.Text = textBox10.Text + textBox23.Text + textBox35.Text;
            textBox46.Text = textBox11.Text + textBox22.Text + textBox34.Text;
            textBox45.Text = textBox12.Text + textBox21.Text + textBox33.Text;
            textBox44.Text = textBox13.Text + textBox20.Text + textBox32.Text;
            textBox14.Text = textBox2.Text + textBox3.Text + textBox4.Text + textBox5.Text + textBox6.Text + textBox7.Text + textBox8.Text + textBox9.Text + textBox10.Text + textBox11.Text + textBox12.Text + textBox13.Text;
            textBox15.Text = textBox26.Text + textBox27.Text + textBox29.Text + textBox30.Text + textBox31.Text + textBox28.Text + textBox25.Text + textBox24.Text + textBox23.Text + textBox22.Text + textBox21.Text + textBox20.Text;
            textBox16.Text = textBox38.Text + textBox39.Text + textBox41.Text + textBox42.Text + textBox43.Text + textBox40.Text + textBox37.Text + textBox36.Text + textBox35.Text + textBox34.Text + textBox33.Text + textBox32.Text;
            textBox17.Text = textBox14.Text + textBox15.Text + textBox16.Text;
            textBox18.Text = textBox2.Text + textBox3.Text + textBox4.Text + textBox5.Text + textBox6.Text + textBox7.Text;
            textBox19.Text = textBox8.Text + textBox9.Text + textBox10.Text + textBox11.Text + textBox12.Text + textBox13.Text;
            textBox57.Text = textBox26.Text + textBox27.Text + textBox29.Text + textBox30.Text + textBox31.Text + textBox28.Text;
            textBox56.Text = textBox25.Text + textBox24.Text + textBox23.Text + textBox22.Text + textBox21.Text + textBox20.Text;
            textBox59.Text = textBox38.Text + textBox39.Text + textBox41.Text + textBox42.Text + textBox43.Text + textBox40.Text;
            textBox58.Text = textBox37.Text + textBox36.Text + textBox35.Text + textBox34.Text + textBox33.Text + textBox32.Text;

        }

        private void input_Load(object sender, EventArgs e)
        {

        }
    }
}