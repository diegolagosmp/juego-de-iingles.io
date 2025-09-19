using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace JuegoIngles
{
    public partial class Form1 : Form
    {
        // Estructura para ejercicios
        class Ejercicio
        {
            public string Pregunta { get; set; }
            public List<string> Opciones { get; set; }
            public string RespuestaCorrecta { get; set; }
        }

        List<Ejercicio> ejercicios;
        int indice = 0;

        public Form1()
        {
            InitializeComponent();
            CargarEjercicios();
            MostrarEjercicio();
        }

        void CargarEjercicios()
        {
            ejercicios = new List<Ejercicio>()
            {
                new Ejercicio {
                    Pregunta = "The book is ___ the table.",
                    Opciones = new List<string>(){ "under", "on", "next to" },
                    RespuestaCorrecta = "under"
                },
                new Ejercicio {
                    Pregunta = "The cat is ___ the chair.",
                    Opciones = new List<string>(){ "in", "behind", "between" },
                    RespuestaCorrecta = "behind"
                },
                new Ejercicio {
                    Pregunta = "The ball is ___ the box.",
                    Opciones = new List<string>(){ "in", "on", "under" },
                    RespuestaCorrecta = "in"
                },
                new Ejercicio {
                    Pregunta = "The dog is ___ the sofa.",
                    Opciones = new List<string>(){ "between", "on", "under" },
                    RespuestaCorrecta = "on"
                },
                new Ejercicio {
                    Pregunta = "The picture is ___ the wall.",
                    Opciones = new List<string>(){ "on", "under", "in" },
                    RespuestaCorrecta = "on"
                }
            };
        }

        void MostrarEjercicio()
        {
            if (indice >= ejercicios.Count)
            {
                MessageBox.Show("¡Juego terminado!");
                return;
            }

            var ej = ejercicios[indice];
            lblPregunta.Text = ej.Pregunta;

            btn1.Text = ej.Opciones[0];
            btn2.Text = ej.Opciones[1];
            btn3.Text = ej.Opciones[2];
        }

        void VerificarRespuesta(string seleccion)
        {
            var ej = ejercicios[indice];
            if (seleccion == ej.RespuestaCorrecta)
                MessageBox.Show("✅ Correct!");
            else
                MessageBox.Show("❌ Wrong! The correct answer is: " + ej.RespuestaCorrecta);

            indice++;
            MostrarEjercicio();
        }

        private void btn1_Click(object sender, EventArgs e) => VerificarRespuesta(btn1.Text);
        private void btn2_Click(object sender, EventArgs e) => VerificarRespuesta(btn2.Text);
        private void btn3_Click(object sender, EventArgs e) => VerificarRespuesta(btn3.Text);
    }
}
