using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AD.Collections;

namespace DLLAD
{
    
    public partial class FormAD : Form
    {
        AD.Players Player = new AD.Players(0, "name", 0);
        AD.Collections.PlayerList RandList = new AD.Collections.PlayerList();


        public FormAD()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Max_Click(object sender, EventArgs e)
        {

        }

        private void CreateList_Click(object sender, EventArgs e)
        {
            RandList.CreateList();
            List<AD.Players> PlayerBase = PlayerList.GetList();
            ResultBox.Text = PlayerList.GetPlayerStats(PlayerBase);
        }
    }
}
