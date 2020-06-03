using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace karambol
{
    class Golyo
    {
        public Golyo(int x, int y, string kep) 
        {
            //this.NEV = nev;
            this.X = x+20;
            this.Y = y+20;
            this.KEP = kep;
                      

        }

        private int _x, _y, _irx, _iry;
        private string _nev, _kep;

        
        public string KEP
        {
            get { return _kep; }
            set { _kep = value; }

        }
        //public string NEV
        //{
        //    get { return _nev; }
        //    set { _nev = value; }

        //}
        public int X
        {
            get { return _x; }
            set { _x = value; }

        }
        public int Y
        {
            get { return _y; }
            set { _y = value; }

        }
        public int IRX
        {
            get { return _irx; }
            set { _irx = value; }

        }
        public int IRY
        {
            get { return _iry; }
            set { _iry = value; }

        }
        
        public void rajzol(PictureBox NEV)
        {
            //PictureBox NEV = new PictureBox();
            NEV.Image = Image.FromFile(this.KEP);
            NEV.BackColor = Color.Transparent;
            NEV.Left = this.X;
            NEV.Top = this.Y;
            NEV.Width = 40;
            NEV.Height = 40;
            NEV.SizeMode = PictureBoxSizeMode.Zoom;
        }




    }
}
