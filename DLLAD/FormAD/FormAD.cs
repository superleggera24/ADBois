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

        static List<AD.Players> PlayerBase = PlayerList<AD.Players>.PlayerBase;
        public static AD.Players[] _RandomArray = new AD.Players[300];
        static Random random = new Random();
        static Random rnd = new Random();
        public static int size = 10;
        public void CreateList()
        {
            ResultBox.Text = "";
            int ID = 0;
            string Name = "";
            int HScore = 0;
            

            for (int i = 0; i < size; i++)
            {
                ID = i;
                Name = RandomString();
                HScore = RandomNo(size);

                PlayerBase.Add(new AD.Players(ID, Name, HScore));
                
            }
        }

        public void NewPlayer(int Id, string Name, int Score)
        {
            PlayerBase.Add(new AD.Players(Id, Name, Score));
        }
        public static int RandomNo(int size)
        {
            
            return rnd.Next(size * 2);
        }
        
        public static string RandomString()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            string finalString = new String(stringChars);
            return finalString;
        }

        public FormAD()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResultBox.Text = "";
            string Text = "";
            int count = 0;
            // De foreach zorgt dat de array gevuld wordt en dat de textbox gevuld wordt.
            foreach (AD.Players player in PlayerBase)
            {
                _RandomArray[count] = player;
                string Id = player.GetId().ToString();
                string Name = player.GetName();
                string Score = player.GetScore().ToString();
                Text = string.Format("ID: {0}, Name {1}, Score {2}", Id, Name, Score);
                Text += Environment.NewLine;
                ResultBox.Text += Text;
                count++;
            }
        }

        private void Max_Click(object sender, EventArgs e)
        {

        }

        private void CreateList_Click(object sender, EventArgs e)
        {
            ResultBox.Text = "";
            CreateList();
            
            ResultBox.Text = GetPlayerStats(PlayerBase);
        }

        public static string GetPlayerStats(List<AD.Players> PlayerBase)
        {
            string stats = null;
            foreach (AD.Players player in PlayerBase)
            {
                stats += "ID";
                stats += player.GetId().ToString();
                stats += "Name: ";
                stats += player.GetName();
                stats += ", Highscore: ";
                stats += player.GetScore().ToString();
                stats += Environment.NewLine;

            }
            return stats;
        }

        private void CreateQueue_Click(object sender, EventArgs e)
        {
            Queue.CreateQueue(PlayerBase);



        }

        private void CreateStack_Click(object sender, EventArgs e)
        {
            RandStack.InitiateRandStack(PlayerBase);
            AD.Players player = RandStack.PeekStack();
            ResultBox.Text = player.GetName();
        }
    }
}
