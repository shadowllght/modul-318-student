using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace TransportApp
{
    public partial class app : Form
    {

        private Stations Stations;
        private Connections Connections;
        private Transport Transport;
        Transport helper = new Transport();
        
        public app()
        {
            InitializeComponent();

            Stations = new Stations();
            Connections = new Connections();
            Transport = new Transport();
            
        }
        #region trash
        private void tChanged(object sender, EventArgs e) {
        }
        #endregion
        private void darkButton_Click(object sender, EventArgs e)
        {
            if (this.BackColor != Color.FromArgb(50, 50, 50))
            {
                this.BackColor = Color.FromArgb(50, 50, 50); //dark background colour
                destinationLabel.ForeColor = Color.FromArgb(220, 220, 220);// text colours
                standortLabel.ForeColor = Color.FromArgb(220, 220, 220);
                Titel.ForeColor = Color.FromArgb(220, 220, 220);
                checkBoxAb.ForeColor = Color.FromArgb(220, 220, 220);
                checkBoxAn.ForeColor = Color.FromArgb(220, 220, 220);
                darkButton.Text = "light mode";
            }
            else if (this.BackColor == Color.FromArgb(50, 50, 50))
            {
                this.BackColor = Color.FromArgb(220, 220, 220); //white background colour
                destinationLabel.ForeColor = Color.FromArgb(0, 0, 0);// text colours
                standortLabel.ForeColor = Color.FromArgb(0, 0, 0);
                Titel.ForeColor = Color.FromArgb(0, 0, 0);
                checkBoxAb.ForeColor = Color.FromArgb(0, 0, 0);
                checkBoxAn.ForeColor = Color.FromArgb(0, 0, 0);
                darkButton.Text = "dark mode";
            }
        }
        
        private void ButtonSuche_Click(object sender, EventArgs e)
        {
            if (standortText.Text == "" || destinationText.Text == "")
            {
                MessageBox.Show("Bitte fülle beide Felder aus!");
            }
            string time = timePicker.Value.ToString();
            string date = datePicker.Value.ToString();
            int x = 0;
            if (checkBoxAn.Checked) x = 1;

            var connections = helper.GetConnections(standortText.Text, destinationText.Text, date, time, x) ;
            dataGridView.Rows.Clear();
            foreach (var connection in connections.ConnectionList)
            {
                DateTime abzeit = DateTime.Parse(connection.From.Departure);
                DateTime anzeit = DateTime.Parse(connection.To.Arrival);
                TimeSpan dauer = anzeit - abzeit;
                string abfahrtszeit = abzeit.ToString("HH:mm") + " Uhr";
                string ankuftszeit = anzeit.ToString("HH:mm") + " Uhr";
                string dauerzeit = string.Format("{0:%h} h {0:%m} min", dauer);

                dataGridView.Rows.Add(connection.From.Station.Name, connection.To.Station.Name, abfahrtszeit, ankuftszeit, dauerzeit);
            }
            
        }

        private void ButtonSwitch_Click(object sender, EventArgs e)
        {
            string x;
            x = standortText.Text;
            standortText.Text = destinationText.Text;
            destinationText.Text = x;

        }

        private void StandortText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Stations Vorschlag = Transport.GetStations(standortText.Text);


                listBoxStandort.Items.Clear();
                foreach (Station station in Vorschlag.StationList)
                {
                    listBoxStandort.Items.Add(station.Name);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DestinationText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Stations Vorschlag = Transport.GetStations(destinationText.Text);

                listBoxDestination.Items.Clear();
                foreach (Station station in Vorschlag.StationList)
                {
                    listBoxDestination.Items.Add(station.Name);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListBoxStandort_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            standortText.Text = Convert.ToString(listBoxStandort.SelectedItem);
        }

        private void ListBoxDestination_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            destinationText.Text = Convert.ToString(listBoxDestination.SelectedItem);
        }

        private void CheckBoxAn_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAn.Checked) checkBoxAb.Checked = false;
            if (checkBoxAn.Checked == false) checkBoxAb.Checked = true;
        }

        private void CheckBoxAb_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAb.Checked) checkBoxAn.Checked = false;
            if (checkBoxAb.Checked == false) checkBoxAn.Checked = true;
        }
    }
}


