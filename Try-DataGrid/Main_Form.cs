using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Try_DataGrid
{
    public partial class mainForm : Form
    {

        public List<Person> people = new List<Person>();
        public mainForm()
        {
            Add();
            InitializeComponent();
        }

        public void Add()
        {
            people.Add(new Person("Marios", "Kosta", 1926, 22, 1.83));
            people.Add(new Person("Andreas", "Perdikou", 3695, 23, 1.90));
            people.Add(new Person("Giorgos", "Michael", 1924, 25, 1.85));
        }
        private void mainForm_Load(object sender, EventArgs e)
        {
            var people = this.people;

            dataGridView1.DataSource = people;
        }
    }
}
