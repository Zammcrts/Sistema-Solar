using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solar
{
    public partial class Form1 : Form
    {
        // sol 
        Graphics dibujo;
        Brush sol = Brushes.Yellow;
        int solx, soly;
        //mercurio
        Brush mercurio = Brushes.PeachPuff;
        int merx, mery;
        int mert;

        // venus
        Brush venus = Brushes.Tomato;
        int venx, veny;
        int vent;

        // tierra 
        Brush tierra = Brushes.ForestGreen;
        int tiex, tiey;
        int tiet;

        // marte
        Brush marte = Brushes.DarkRed;
        int marx, mary;
        int mart;

        // jupiter
        Brush jupiter = Brushes.IndianRed;
        int jupx, jupy;
        int jupt;

        // saturno
        Brush saturno = Brushes.SandyBrown;
        int satx, saty;
        int satt;

        // urano
        Brush urano = Brushes.SteelBlue;
        int urax, uray;
        int urat;
        // neptono
        Brush nep = Brushes.RoyalBlue;
        int nepx, nepy;
        int nept;
        //luna
        Brush luna = Brushes.LightGray;
        int lunax, lunay;
        int lunat;
        //anillos
        Brush ani = Brushes.SandyBrown;
        int anix, aniy;
        int anit;

        //cosa rara de los anitos
        Pen anillo = new Pen(Color.SandyBrown, 10);
        int anitox, anitoy;
        int anitot;

        double vel;

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.Khaki;
            button6.BackColor = Color.WhiteSmoke;
            vel = vel -0.5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.Khaki;
            button5.BackColor = Color.WhiteSmoke;
            vel = vel + 0.5;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            tiempo = tiempo + 0.01*vel;
            //mercurion
            merx = solx + (int)(200 * Math.Cos(tiempo * 15));
            mery = soly + (int)(90 * Math.Sin(tiempo * 15));
            mert = mery / 16;
            Refresh();

            //venus
            venx = solx + (int)(300 * Math.Cos(tiempo * 13));
            veny = soly + (int)(120 * Math.Sin(tiempo * 13));
            vent = veny /14;

            //tierra
            tiex = solx + (int)(400 * Math.Cos(tiempo * 11));
            tiey = soly + (int)(150 * Math.Sin(tiempo * 11));
            tiet = tiey / 11;

            //marte
            marx = solx + (int)(500 * Math.Cos(tiempo * 8));
            mary = soly + (int)(200 * Math.Sin(tiempo * 8));
            mart = mary / 8;

            //jupiron
            jupx = solx + (int)(600 * Math.Cos(tiempo * 6));
            jupy = soly + (int)(220 * Math.Sin(tiempo * 6));
            jupt = jupy / 7;

            //luna
            lunax = tiex + (int)(50 * Math.Cos(tiempo * 30));
            lunay = tiey + (int)(30 * Math.Sin(tiempo * 30));
            lunat = lunay / 20;

            //saturon
            satx = solx + (int)(700 * Math.Cos(tiempo * 4));
            saty =soly + (int)(230 * Math.Sin(tiempo * 4));
            satt = saty / 6;

            //anillos saturnro
            satx = solx + (int)(700 * Math.Cos(tiempo * 4));
            saty = soly + (int)(230 * Math.Sin(tiempo * 4));
            satt = saty / 6;

            //urano
            urax = solx + (int)(760 * Math.Cos(tiempo * 3));
            uray = soly + (int)(240 * Math.Sin(tiempo * 3));
            urat = uray / 12;

            // neptuno
            nepx = solx + (int)(800 * Math.Cos(tiempo * 2));
            nepy = soly + (int)(250 * Math.Sin(tiempo * 2));
            nept = nepy / 10;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            solx = 650;
            soly = 340;
            merx = 10;
            mery = 10;
            venx = 25;
            veny = 25;
            tiex = 40;
            tiey = 40;
            marx = 35;
            mary = 35;
            jupx = 75;
            jupy = 75;
            lunax = 5;
            lunay= 5;
            satx = 60;
            saty = 60;
            nepx = 45;
            nepx = 45;
            urax = 50;
            uray = 50;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor=Color.LightGreen;
            button2.BackColor = Color.WhiteSmoke;
            anit = 1;
            vel = 1;
            timer1.Start();
        }

        

        double tiempo;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            dibujo = e.Graphics;
            dibujo.FillEllipse(sol, solx, soly,150 , 150);
            //meru
            dibujo.FillEllipse(mercurio, merx, mery, mert, mert);
            //venus
            dibujo.FillEllipse(venus, venx, veny, vent, vent);
            //tierra
            dibujo.FillEllipse(tierra, tiex, tiey, tiet, tiet);
            //marte
            dibujo.FillEllipse(marte, marx, mary, mart, mart);
            //jupirt
            dibujo.FillEllipse(jupiter, jupx, jupy, jupt, jupt);
            //luna
            dibujo.FillEllipse(luna, lunax, lunay, lunat, lunat);
            //saturon
            dibujo.FillEllipse(saturno, satx, saty, satt, satt);
            //anillo
            if (anit == 1)
            {
                dibujo.DrawEllipse(anillo, satx - 20, saty + 30, satt + 50, satt - 50);
            }
            // urano
            dibujo.FillEllipse(urano, urax, uray, urat, urat);

            //neptuno
            dibujo.FillEllipse(nep, nepx, nepy, nept, nept);
        }

      
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button1.BackColor = Color.WhiteSmoke;
            button2.BackColor = Color.Tomato;
            button6.BackColor = Color.WhiteSmoke;
            button5.BackColor = Color.WhiteSmoke;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
       
            MessageBox.Show("PROYECTO FINAL: Sistema Solar\n\n" + "AUTOR:Edna Samantha Cortés Carisoza\n\n" + "5 de Diciembre de 2023");
        }
    }
}
