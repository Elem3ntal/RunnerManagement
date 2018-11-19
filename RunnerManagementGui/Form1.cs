using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RunnersLibrary;

namespace RunnerManagementGui
{
    public partial class Form1 : Form
    {
        CollectionsRegister data;
        public Form1()
        {
            InitializeComponent();
            data = new CollectionsRegister();
            bool loadProcess = true;
            loadProcess &= loadLabelsText();
            loadProcess &= loadDefaultChoices();
            loadProcess &= loadRegisterColumns();
            loadProcess &= loadResultColumns();
            sendMessage(loadProcess ? "Carga Correcta" : "Error al iniciar");
            test();
        }
        public bool loadRegisterColumns()
        {
            try
            {
                List<string> columnsStructure = GridsStructure.ColumnsRegister;
                dataGridViewRegisterRun.ColumnCount = columnsStructure.Count;
                dataGridViewRegisterRun.ColumnHeadersVisible = true;
                for (int i = 0; i < columnsStructure.Count; i++)
                    dataGridViewRegisterRun.Columns[i].Name = columnsStructure[i];
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool loadResultColumns()
        {
            try
            {
                List<string> columnsStructure = GridsStructure.ColumnsResult;
                dataGridViewResultsRun.ColumnCount = columnsStructure.Count;
                dataGridViewResultsRun.ColumnHeadersVisible = true;
                for (int i = 0; i < columnsStructure.Count; i++)
                    dataGridViewResultsRun.Columns[i].Name = columnsStructure[i];
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool loadDefaultChoices()
        {
            try
            {
                comboBoxInputcategorie.DisplayMember = "Text";
                comboBoxInputcategorie.SelectedValue = "Text";
                comboBoxInputcategorie.ValueMember = "Value";
                comboBoxInputcategorie.DataSource = (from i in Categories.Options.Keys.ToList()
                                                     where i.StartsWith("OptionCategorie", StringComparison.InvariantCultureIgnoreCase)
                                                     select Categories.Options[i]).ToList();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool loadLabelsText()
        {
            try
            {
                this.Text = Texts.Words["titleForm"];
                labelInputNumber.Text = Texts.Words["textLabelInputNumber"];
                labelInputCategorie.Text = Texts.Words["textLabelInputCategorie"];
                labelTitleInputRegister.Text = Texts.Words["textLabelInputHeader"];
                labelInputTimeStart.Text = Texts.Words["textLabelInputTimeStart"];
                labelInputTimeEnd.Text = Texts.Words["textLabelInputTimeEnd"];
                buttonInputAdd.Text = Texts.Words["textButtonInputAdd"];
                buttonInputUpdate.Text = Texts.Words["textButtonInputUpdate"];
                buttonInputRemove.Text = Texts.Words["textButtonInputDelete"];
                labelTitleRegisterRun.Text = Texts.Words["labelTitleRegisterRun"];
                labelTitleResultsRun.Text = Texts.Words["labelTitleResultsRun"];
                labelTitleMessages.Text = Texts.Words["labelTitleMessages"];
                buttonResultConsult.Text = Texts.Words["textButtonResultDelete"];
                buttonResultReset.Text = Texts.Words["textButtonResultReset"];
                buttonClose.Text = Texts.Words["textButtonClose"];
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
            RegistroCorrida dude = new RegistroCorrida();
            dude.horaPartida = "19:15:30";
            dude.horaLlegada = "20:30:25";
            Console.WriteLine("se partio: {0}", dude.horaPartida);
            Console.WriteLine("se llego: {0}", dude.horaLlegada);
            Console.WriteLine("se demoro: {0}", dude.obtenerTiempo());
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonInputAdd_Click(object sender, EventArgs e)
        {
            //TODO: validar que se puede llamar a addRunner, 
            //      es decir, los campos son validos
            /* validar:
             *      que los campos sean validos.
             *      que el numero del corredor, no este en Collections.
             */
            if (validFields())
            {
                addRunner();
                reloadRegisterRun();
                cleanRegister();
            }
        }
        private bool validFields()
        {
            bool isValid = true;
            int value;
            int.TryParse(textBoxInputNumber.Text, out value);
            if (value == 0)
            {
                sendMessage(Texts.Words["invalidNumberRunner"]);
                return false;
            }
            return true;
        }

        private void cleanRegister()
        {
            dateTimePickerInputStart.Text = "";
            dateTimePickerInputEnd.Text = "";
            textBoxInputNumber.Text = "";
            comboBoxInputcategorie.SelectedIndex = 0;
            textBoxInputNumber.ReadOnly = false;
        }
        private bool addRunner()
        {
            //numero, corrida, hora start, hora end
            int numero, categorie;
            string timeStart = dateTimePickerInputStart.Text;
            string timeEnd = dateTimePickerInputEnd.Text;
            Console.WriteLine("time end{0}", timeEnd);
            int.TryParse(textBoxInputNumber.Text, out numero);
            int.TryParse(comboBoxInputcategorie.SelectedValue.ToString(), out categorie);
            this.data.addRunner(new RegistroCorrida(numero, categorie, timeStart, timeEnd));
            return true;
        }
        private bool reloadRegisterRun()
        {
            dataGridViewRegisterRun.Rows.Clear();
            foreach (Dictionary<string, string> runner in this.data.allRunners())
            {
                List<string> register = new List<string>();
                foreach (string data in GridsStructure.ColumnsRegister)
                    register.Add(runner[data]);
                dataGridViewRegisterRun.Rows.Add(register.ToArray());

            }
            return true;
        }

        private void dataGridViewRegisterRun_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridViewRegisterRun_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectRunner(e.RowIndex);
                unselectCells(dataGridViewRegisterRun);
            }
        }
        private void selectRunner(int index)
        {
            DataGridViewRow row = dataGridViewRegisterRun.Rows[index];
            textBoxInputNumber.ReadOnly = true;
            textBoxInputNumber.Text = (string)row.Cells[0].Value;
            comboBoxInputcategorie.SelectedIndex = comboBoxInputcategorie.FindString((string)row.Cells[1].Value);
            dateTimePickerInputStart.Value = DateTime.ParseExact((string)row.Cells[2].Value, "HH:mm:ss", CultureInfo.InvariantCulture);
            dateTimePickerInputEnd.Value = DateTime.ParseExact((string)row.Cells[3].Value, "HH:mm:ss", CultureInfo.InvariantCulture);
        }
        private void unselectCells(DataGridView table)
        {
            foreach (DataGridViewCell cell in table.SelectedCells)
                cell.Selected = false;
        }

        private void buttonInputUpdate_Click(object sender, EventArgs e)
        {
            if (updateRunner())
                reloadRegisterRun();
            cleanRegister();
        }

        private void buttonInputRemove_Click(object sender, EventArgs e)
        {
            if (removeRunner())
                reloadRegisterRun();
            cleanRegister();
        }
        private bool updateRunner()
        {
            //numero, corrida, hora start, hora end
            int numero, categorie;
            string timeStart = dateTimePickerInputStart.Text;
            string timeEnd = dateTimePickerInputEnd.Text;
            int.TryParse(textBoxInputNumber.Text, out numero);
            int.TryParse(comboBoxInputcategorie.SelectedValue.ToString(), out categorie);
            return this.data.updateRunner(new RegistroCorrida(numero, categorie, timeStart, timeEnd));
        }
        private bool removeRunner()
        {
            int numero;
            int.TryParse(textBoxInputNumber.Text, out numero);
            return this.data.removeRunner(numero);

        }
    }
}
