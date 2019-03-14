using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SahteVeri
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        List<Customer> clist = new List<Customer>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            FakeName o1 = new FakeName();
            FakeNumber o2 = new FakeNumber();

            for (int i = 1; i <= 100; i++)
            {
                Customer o = new Customer();

                o.id = i;
                o.name =o1.Karmaisim();
                o.surname = o1.Karmasoyisim();
                o.subscriptionNumber = o2.Karmanumber();
                o.age = o2.Karmayas();
                o.phoneNumber = o2.TelNoUret();
                clist.Add(o);  
            }
        }

        private void Doldur()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = clist;

            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Doldur();
        }
    }
}
