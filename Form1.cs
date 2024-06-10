using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<String[]> ls = new List<String[]>();
            StreamReader sr = new StreamReader("inf.txt");
            string[] h = (sr.ReadLine()).Split(' ');
            ls.Add(h);
            sr.Close();
            IEnumerable<string[]> un = from t in ls
                                where Convert.ToInt32(t[3]) < 40
                                orderby t[3]
                                select t;
           
            
            foreach (string[] l in un)
            {
                dataGridView1.Rows.Add(l[0], l[1], l[2], l[3], l[4]);

            }
            

        }
    }
}
