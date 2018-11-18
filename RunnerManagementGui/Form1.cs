using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RunnersLibrary;

namespace RunnerManagementGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bool loadProcess = true;
            loadProcess &= loadLabelsText();
            sendMessage(loadProcess ? "Carga Correcta" : "Error al iniciar");
            test();
        }
        public bool loadLabelsText()
        {
            try
            {
                this.Text = (string)Texts.Words["titleForm"];
                labelInputNumber.Text = (string)Texts.Words["textLabelInputNumber"];
                labelInputCategorie.Text = (string)Texts.Words["textLabelInputCategorie"];
                labelTitleInputRegister.Text = (string)Texts.Words["textLabelInputHeader"];
                labelInputTimeStart.Text = (string)Texts.Words["textLabelInputTimeStart"];
                labelInputTimeEnd.Text = (string)Texts.Words["textLabelInputTimeEnd"];
                buttonInputAdd.Text = (string)Texts.Words["textButtonInputAdd"];
                buttonInputUpdate.Text = (string)Texts.Words["textButtonInputUpdate"];
                buttonInputRemove.Text = (string)Texts.Words["textButtonInputDelete"];
                labelTitleRegisterRun.Text = (string)Texts.Words["labelTitleRegisterRun"];
                labelTitleResultsRun.Text = (string)Texts.Words["labelTitleResultsRun"];
                labelTitleMessages.Text = (string)Texts.Words["labelTitleMessages"];
                buttonResultConsult.Text = (string)Texts.Words["textButtonResultDelete"];
                buttonResultReset.Text = (string)Texts.Words["textButtonResultReset"];
                buttonClose.Text = (string)Texts.Words["textButtonClose"];
            }
            catch (Exception e)
            {
                return false;
            };
            return true;
        }
        public void sendMessage(string message)
        {
            labelMessagesText.Text = message;
        }
        public void test()
        {
            RegistroCorrida weon = new RegistroCorrida();
            weon.horaPartida = "19:15:30";
            weon.horaLlegada = "20:30:25";
            Console.WriteLine("se partio: {0}", weon.horaPartida);
            Console.WriteLine("se llego: {0}", weon.horaLlegada);
            Console.WriteLine("se demoro: {0}", weon.obtenerTiempo());
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
