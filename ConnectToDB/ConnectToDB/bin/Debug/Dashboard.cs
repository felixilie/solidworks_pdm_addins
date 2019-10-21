using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectToDB
{
    public partial class Dashboard : Form
    {
        List<Part> parts = new List<Part>();

        public Dashboard()
        {
            InitializeComponent();

            M1ListBox.DataSource = parts;
            M1ListBox.DisplayMember = "fullInfo";
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            parts = db.GetPart(PartNumberText.Text);

            M1ListBox.DataSource = parts;
            M1ListBox.DisplayMember = "fullInfo";

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
