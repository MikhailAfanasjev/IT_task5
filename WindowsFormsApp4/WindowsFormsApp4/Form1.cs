using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        List<ClassLibrary1.Truck> list = new List<ClassLibrary1.Truck>();
        private void button1_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Clear();
             var obj = (new ClassLibrary1.Truck() { 
                 Mark = textBox13.Text,
                 CarryingCapasity = Convert.ToDouble(textBox1.Text),
                 Fuel100 = Convert.ToDouble(textBox3.Text),

                 Height = Convert.ToDouble(textBox6.Text),
                 HP = Convert.ToInt32(textBox5.Text),
                 Length = Convert.ToDouble(textBox7.Text),
                 VT = Convert.ToDouble(textBox4.Text),
                 Weight = Convert.ToDouble(textBox2.Text),
                 Width = Convert.ToDouble(textBox8.Text)
             });
            textBox9.Text = obj.FullMass().ToString();
            textBox10.Text = obj.Distanse().ToString();
            textBox11.Text = obj.GetWatts().ToString();
            textBox12.Text = obj.GetSquare().ToString();
            textBox14.Text = obj.TransportTax().ToString();
            list.Add(obj);         
            var res = from n in list select n.Mark;
            listBox1.DataSource = res.ToList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = list[listBox1.SelectedIndex].CarryingCapasity.ToString();
            textBox2.Text = list[listBox1.SelectedIndex].Weight.ToString();
            textBox3.Text = list[listBox1.SelectedIndex].Fuel100.ToString();
            textBox4.Text = list[listBox1.SelectedIndex].VT.ToString();
            textBox5.Text = list[listBox1.SelectedIndex].HP.ToString();
            textBox6.Text = list[listBox1.SelectedIndex].Height.ToString();
            textBox7.Text = list[listBox1.SelectedIndex].Length.ToString();
            textBox8.Text = list[listBox1.SelectedIndex].Width.ToString();
            textBox9.Text = list[listBox1.SelectedIndex].FullMass().ToString();
            textBox10.Text = list[listBox1.SelectedIndex].Distanse().ToString();
            textBox11.Text = list[listBox1.SelectedIndex].GetWatts().ToString();
            textBox12.Text = list[listBox1.SelectedIndex].GetSquare().ToString();
            textBox13.Text = list[listBox1.SelectedIndex].Mark.ToString();
            textBox14.Text = list[listBox1.SelectedIndex].TransportTax().ToString();


        }
    }
}
