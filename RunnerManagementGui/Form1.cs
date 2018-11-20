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
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonInputAdd_Click(object sender, EventArgs e)
        {
            if (validFields() && validRegister())
            {
                addRunner();
                reloadRegisterRun();
                cleanRegister();
            }
        }
        private bool validFields()
        {
            int value;
            int.TryParse(textBoxInputNumber.Text, out value);
            if (value == 0)
            {
                sendMessage(Texts.Words["invalidNumberRunner"]);
                return false;
            }
            if (comboBoxInputcategorie.SelectedIndex == 0)
            {
                sendMessage(Texts.Words["invalidCategorieRunner"]);
                return false;
            }
            if (timestamp(dateTimePickerInputEnd.Value) - timestamp(dateTimePickerInputStart.Value) <= 0)
            {
                sendMessage(Texts.Words["invalidTimesRunner"]);
                return false;
            }
            return true;
        }
        private bool validRegister()
        {
            int value;
            int.TryParse(textBoxInputNumber.Text, out value);
            if (value > 0)
            {
                if (this.data.allRunners().Any(x => x["numero"] == value.ToString())){
                    sendMessage(Texts.Words["RepitedNumberRunner"]);
                    return false;
                }
            }
            return true;
        }
        private int timestamp(DateTime time)
        {
            int output;
            int.TryParse(string.Format("{0}{1}{2}", time.Hour, time.Minute, time.Second), out output);
            return output;
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
            int numero, categorie;
            string timeStart = dateTimePickerInputStart.Text;
            string timeEnd = dateTimePickerInputEnd.Text;
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
            if(validateActionRemove())
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
        private bool validateActionRemove()
        {
            if (validFields())
            {
                string[] lines = {
                    Texts.Words["messageRemoveUser"],
                    String.Format("Numero corredor: {0}", textBoxInputNumber.Text),
                    String.Format("Categoria: {0}", comboBoxInputcategorie.GetItemText(comboBoxInputcategorie.SelectedItem)),
                    String.Format("Hora Partida: {0}", dateTimePickerInputStart.Value),
                    String.Format("Hora Llegada: {0}", dateTimePickerInputEnd.Value)};
                DialogResult response = MessageBox.Show(string.Join("\n", lines), 
                    Texts.Words["titleRemoveUser"], 
                    MessageBoxButtons.YesNo);
                return response == DialogResult.Yes;
            }
            return false;
        }

        private bool removeRunner()
        {
            int numero;
            int.TryParse(textBoxInputNumber.Text, out numero);
            return this.data.removeRunner(numero);

        }
    }
}
