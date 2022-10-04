using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        DataTable table1 = new DataTable();
        List<Stuff> list = new List<Stuff>();
        public List<Stuff> Stuffs { get; set; }
        public Form1()
        {
            Stuffs = GetStuffs();
            InitializeComponent();
        }

        private List<Stuff> GetStuffs()
        {
            
            
            return list;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
            table1.Columns.Add("Name", typeof(string));
            table1.Columns.Add("Price", typeof(int));
            table1.Columns.Add("Country", typeof(string));
            table1.Columns.Add("Packing date", typeof(string));
            table1.Columns.Add("Description", typeof(string));

            Goods tang = new Goods(105, "Spain", "Tangarines", "25.09.2022", "Fruit", "25.10.2022", 200, "kg");
            list.Add(tang);
            Book book = new Book(155, "Great Britain", "1984", "23.05.2021", "Book", 215, "Bloomberg", "George Orwell");
            list.Add(book);

            dataGridView1.DataSource = table1;


            for (int i = 0; i < Stuffs.Count; i++)
            {
                table1.Rows.Add(Stuffs[i].Name, Stuffs[i].Price, Stuffs[i].Country, Stuffs[i].ProductionDate, Stuffs[i].Description);
            }



        }

      

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 2);

        }
    }
}
