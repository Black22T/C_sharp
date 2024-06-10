using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simon_dice
{
    public partial class Form1 : Form
    {
        Random randomBoton = new Random();
        List<int> simondice = new List<int>();
        List<int> jugador = new List<int>();
        int indice, contador = 0, puntajemaximo=0;
        float tiempoDeJuego = 5;
        private DateTime tiempoInicio;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (contador < simondice.Count)
            {
                iluminarboton(simondice[contador]);
                contador++;
                timer2.Start();
            }
            else
            {
                jugador.Clear();
                contador = 0;
                timer1.Stop();
                tiempoInicio = DateTime.Now;
                timer3.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            resetearColores();
            timer2.Stop();
        }

        public void perdiste()
        {
            resetearColores();
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            
            label1.Text = "Perdiste";
            
            jugador.Clear();
            simondice.Clear();
        }

        public void ronda()
        {
            simondice.Add(randomBoton.Next(0, 4));
            contador = 0;
            indice = 0;
            if (puntajemaximo < simondice.Count && jugador.Count > 0)
            {
                puntajemaximo = jugador.Count;
                label2.Text = "Puntaje maximo: " + puntajemaximo;
            }
            jugador.Clear(); 
            timer3.Stop();
            label1.Text = "";
            timer1.Start();
            resetearColores();
        }


        public void iluminarboton(int botonIluminar)
        {
            switch (botonIluminar)
            {
                case 0:
                    verdeBoton.BackColor = Color.Green;
                    break;
                case 1:
                    rojoBoton.BackColor = Color.Red;
                    break;
                case 2:
                    amarilloBoton.BackColor = Color.Yellow;
                    break;
                case 3:
                    azulBoton.BackColor = Color.Blue;
                    break;
            }
        }

        /*public void compara()
        {
            if (simondice[indice] == jugador[indice])
            {

                indice++;
                tiempoInicio = DateTime.Now;
                timer3.Start();
                if (indice == simondice.Count)
                {
                    ronda();
                }
            }
            else
            {
                perdiste();
            }
        }*/

        public void compara()
        {
            if (indice < simondice.Count && indice < jugador.Count)
            {
                if (simondice[indice] == jugador[indice])
                {
                    indice++;
                    if (indice == simondice.Count)
                    {
                        ronda();
                    }
                    else
                    {
                        tiempoInicio = DateTime.Now;
                        timer3.Start();
                    }
                }
                else
                {
                    perdiste();
                }
            }
            else
            {
                perdiste();
            }
        }

        public void timerRun(int boton)
        {
            if (timer3.Enabled)
            {
                jugador.Add(boton);
                compara();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            jugador.Clear();
            simondice.Clear();
            indice = 0;
            ronda();
        }

        private void verdeBoton_Click(object sender, EventArgs e)
        {
            resetearColores();
            iluminarboton(0);
            timerRun(0);
        }

        private void rojoBoton_Click(object sender, EventArgs e)
        {
            resetearColores();
            iluminarboton(1);
            timerRun(1);
        }

        private void amarilloBoton_Click(object sender, EventArgs e)
        {
            resetearColores();
            iluminarboton(2);
            timerRun(2);
        }

        private void azulBoton_Click(object sender, EventArgs e)
        {
            resetearColores();
            iluminarboton(3);
            timerRun(3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            TimeSpan tiempoTranscurrido = DateTime.Now - tiempoInicio;
            float tiempoRestante = tiempoDeJuego - (float)tiempoTranscurrido.TotalSeconds;

            if (tiempoRestante <= 0)
            {
                timer3.Stop();
                perdiste();
            }
            else
            {
                string tiempoRestanteCortado = tiempoRestante.ToString("F3");
                label1.Text = tiempoRestanteCortado;
            }
        }

        public void resetearColores()
        {
            verdeBoton.BackColor = Color.PaleGreen;
            rojoBoton.BackColor = Color.LightCoral;
            amarilloBoton.BackColor = Color.Khaki;
            azulBoton.BackColor = Color.LightSteelBlue;
        }
    }
}