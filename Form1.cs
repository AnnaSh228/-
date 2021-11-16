using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace фрукти
{
    public partial class Form1 : Form
    {
        List<Animals> animalsList = new List<Animals>();
        public Form1()
        {
            InitializeComponent();
            ShowInfo();
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            this.animalsList.Clear();
            var rnd = new Random();
            for (var i = 0; i < 10; ++i)
            {
                switch (rnd.Next() % 3) 
                {
                    case 0: 
                        this.animalsList.Add(Cows.Generate());
                        break;
                    case 1:
                        this.animalsList.Add(Dogs.Generate());
                        break;
                    case 2:
                        this.animalsList.Add(Cats.Generate());
                        
                        break;
                       
                }
            }
            ShowInfo();
        }
        private void ShowInfo()
        {
           
            int cowsCount = 0;
            int dogsCount = 0;
            int catsCount = 0;

           
            foreach (var animal in this.animalsList)
            {
                
                if (animal is Cows) 
                {
                    cowsCount += 1;
                }
                else if (animal is Dogs)
                {
                    dogsCount += 1;
                }
                else if (animal is Cats)
                {
                    catsCount += 1;
                }
            }

           
            txtInfo.Text = "Коровы\tСобаки\tКошки"; 
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}", cowsCount, dogsCount, catsCount);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (this.animalsList.Count == 0)
            {
                txtOut.Text = "Пусто";
                return;
            }
            var animal = this.animalsList[0];
            this.animalsList.RemoveAt(0);
            txtOut.Text = animal.GetInfo();
            ShowInfo();
        }
    }
}
