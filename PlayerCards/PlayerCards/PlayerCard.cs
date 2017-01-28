using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Reflection;

// author: Maximilian Roeck - Matrikelnummer: 185594

namespace PlayerCards
{
    public partial class playerCard : Form
    {
        private string relativeDataPath = "Resources\\VfB Stuttgart";
        private string dataFileName = "SpielerData.xml";
        private string imageExtension = ".jpg";

        private Dictionary<Spieler, Image> players = new Dictionary<Spieler, Image>();


        public playerCard()
        {
            InitializeComponent();

            // desirializing player data from XML file
            players = PlayerData().ToDictionary(x => x, FetchImage);
            playerSelection.Items.AddRange(players.Keys.ToArray());

            // update text fields
            playerSelection.SelectedIndexChanged += (s, a) =>
            {
                var player = (Spieler)playerSelection.SelectedItem;
                name.Text = player.Vorname;
                surname.Text = player.Name;
                birth.Text = player.GeburtsDatum;
                position.Text = player.Position;
                games.Text = player.SpieleInBundesliga + " / " + player.ToreInBundesliga;
                matches.Text = player.Laenderspiele;
                accession.Text = player.Seit;
                number.Text = player.Rueckennummer;
                nation.Text = player.Nation;
                height.Text = player.GroesseInCm;
                weight.Text = player.GewichtInKg;
                picture.Image = players[player];
            };

            // handle button clicks
            first.Click += (s, a) => playerSelection.SelectedIndex = 0;
            last.Click += (s, a) => playerSelection.SelectedIndex = playerSelection.Items.Count - 1;
            previous.Click += (s, a) => playerSelection.SelectedIndex -= (playerSelection.SelectedIndex <= 0 ? 0 : 1);
            next.Click += (s, a) => playerSelection.SelectedIndex += (playerSelection.SelectedIndex >= playerSelection.Items.Count - 1 ? 0 : 1);

            // control button state
            playerSelection.SelectedIndexChanged += (s, a) =>
            {
                if (playerSelection.SelectedIndex > 0)
                {
                    EnableButtons(true, first, previous);
                }
                if (playerSelection.SelectedIndex < playerSelection.Items.Count - 1)
                {
                    EnableButtons(true, last, next);
                }

                if (playerSelection.SelectedIndex <= 0)
                {
                    EnableButtons(false, first, previous);
                }
                else if (playerSelection.SelectedIndex >= playerSelection.Items.Count - 1)
                {
                    EnableButtons(false, last, next);
                } 
            };

            // layout and additional setup stuff
            playerSelection.SelectedIndex = 0;
        }


        // helper function for simple enabling/disabling of multiple buttons
        private void EnableButtons(bool enable, params Button[] buttons)
        {
           foreach (var button in buttons) {
                button.Enabled = enable;
            }
        }


        // retrieves the path of the currently executing assembly
        private string DataPath(string append = "")
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativeDataPath, append);
        }


        // fetches images for players
        private Image FetchImage(Spieler player)
        {
            try
            {
                return Image.FromFile(DataPath(player.VollerName + imageExtension));
            }
                catch
            {
                return null;
            }
        }
        

        // desirializes player data
        private List<Spieler> PlayerData()
        {
            try
            {
                using (FileStream fileStream = new FileStream(DataPath(dataFileName), FileMode.Open))
                {
                    return ((Kader)new XmlSerializer(typeof(Kader)).Deserialize(fileStream)).SpielerListe;
                }
            }
            catch { }
            return new List<Spieler>();
        }
    }
}
