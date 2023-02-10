using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HearthstoneSpaceGame_CompApp
{
    public partial class HearthstoneCompanionApp : Form
    {
        public int medicHP = 25;
        public int mercHP = 25;
        public Card[] medicDeck = new Card[11];
        public Card[] mercDeck = new Card[11];
        public string imgPath = AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\";
        public int randomIndex = 0;
        public int totalCost = 0;
        public int totalCostMerc = 0;
        public HearthstoneCompanionApp()
        {
            for (int i = 0; i < medicDeck.Length; i++)
            {
                medicDeck[i] = new Card();
            }
            for (int i = 0; i < mercDeck.Length; i++)
            {
                mercDeck[i] = new Card();
            }

            //Initialize medic deck
            medicDeck[0].name = "Cryo-Expert Klaus";
            medicDeck[0].image = Image.FromFile(imgPath + "cryoKlaus.png");
            medicDeck[0].attack = 5;
            medicDeck[0].health = 7;
            medicDeck[0].cost = 5;
            medicDeck[1].name = "Cunning Defender";
            medicDeck[1].image = Image.FromFile(imgPath + "cunningDefender.png");
            medicDeck[1].attack = 1;
            medicDeck[1].health = 4;
            medicDeck[1].cost = 1;
            medicDeck[2].name = "Exotic Beast Handler";
            medicDeck[2].image = Image.FromFile(imgPath + "ExoticBeastHandler.png");
            medicDeck[2].attack = 4;
            medicDeck[2].health = 4;
            medicDeck[2].cost = 3;
            medicDeck[3].name = "Experimented Crew";
            medicDeck[3].image = Image.FromFile(imgPath + "experimentedCrew.png");
            medicDeck[3].attack = 3;
            medicDeck[3].health = 6;
            medicDeck[3].cost = 4;
            medicDeck[4].name = "Threatening Decoy";
            medicDeck[4].image = Image.FromFile(imgPath + "threateningDecoy.png");
            medicDeck[4].attack = 0;
            medicDeck[4].health = 2;
            medicDeck[4].cost = 1;
            medicDeck[5].name = "Precise Extraction";
            medicDeck[5].image = Image.FromFile(imgPath + "preciseExtraction.png");
            medicDeck[5].attack = 0;
            medicDeck[5].health = 0;
            medicDeck[5].cost = 4;
            medicDeck[6].name = "Accidental Sabotage";
            medicDeck[6].image = Image.FromFile(imgPath + "accidentalSabotage.png");
            medicDeck[6].attack = 0;
            medicDeck[6].health = 0;
            medicDeck[6].cost = 3;
            medicDeck[7].name = "Medical Degree";
            medicDeck[7].image = Image.FromFile(imgPath + "medicalDegree.png");
            medicDeck[7].attack = 0;
            medicDeck[7].health = 0;
            medicDeck[7].cost = 2;
            medicDeck[8].name = "Glowing Rock";
            medicDeck[8].image = Image.FromFile(imgPath + "glowingRock.png");
            medicDeck[8].attack = 0;
            medicDeck[8].health = 0;
            medicDeck[8].cost = 3;
            medicDeck[9].name = "Extra Medbay";
            medicDeck[9].image = Image.FromFile(imgPath + "extraMedbay.png");
            medicDeck[9].attack = 0;
            medicDeck[9].health = 0;
            medicDeck[9].cost = 3;
            medicDeck[10].name = "Minion";
            medicDeck[10].image = Image.FromFile(imgPath + "medicMinion.png");
            medicDeck[10].attack = 2;
            medicDeck[10].health = 2;
            medicDeck[10].cost = 0;
            //Initialize merc deck
            mercDeck[0].name = "Jarcelle, Pirate Magus";
            mercDeck[0].image = Image.FromFile(imgPath + "jarcellePirateMagus.png");
            mercDeck[0].attack = 3;
            mercDeck[0].health = 4;
            mercDeck[0].cost = 3;
            mercDeck[1].name = "Net Thrower";
            mercDeck[1].image = Image.FromFile(imgPath + "netThrower.png");
            mercDeck[1].attack = 2;
            mercDeck[1].health = 3;
            mercDeck[1].cost = 2;
            mercDeck[2].name = "Cunning Dasher";
            mercDeck[2].image = Image.FromFile(imgPath + "cunningDasher.png");
            mercDeck[2].attack = 3;
            mercDeck[2].health = 4;
            mercDeck[2].cost = 3;
            mercDeck[3].name = "Quickshot Gunling";
            mercDeck[3].image = Image.FromFile(imgPath + "quickshotGunling.png");
            mercDeck[3].attack = 2;
            mercDeck[3].health = 1;
            mercDeck[3].cost = 2;
            mercDeck[4].name = "Ship Spotter";
            mercDeck[4].image = Image.FromFile(imgPath + "shipSpotter.png");
            mercDeck[4].attack = 2;
            mercDeck[4].health = 2;
            mercDeck[4].cost = 1;
            mercDeck[5].name = "Quickshot";
            mercDeck[5].image = Image.FromFile(imgPath + "quickshot.png");
            mercDeck[5].attack = 0;
            mercDeck[5].health = 0;
            mercDeck[5].cost = 1;
            mercDeck[6].name = "Hired Hands";
            mercDeck[6].image = Image.FromFile(imgPath + "hiredHands.png");
            mercDeck[6].attack = 0;
            mercDeck[6].health = 0;
            mercDeck[6].cost = 3;
            mercDeck[7].name = "Well-Placed Bribe";
            mercDeck[7].image = Image.FromFile(imgPath + "wellPlacedBribe.png");
            mercDeck[7].attack = 0;
            mercDeck[7].health = 0;
            mercDeck[7].cost = 7;
            mercDeck[8].name = "Sniper Cannon";
            mercDeck[8].image = Image.FromFile(imgPath + "sniperCannon.png");
            mercDeck[8].attack = 3;
            mercDeck[8].health = 3;
            mercDeck[8].cost = 5;
            mercDeck[9].name = "Broadside Attachment";
            mercDeck[9].image = Image.FromFile(imgPath + "broadsideAttachment.png");
            mercDeck[9].attack = 0;
            mercDeck[9].health = 0;
            mercDeck[9].cost = 5;
            mercDeck[10].name = "Minion";
            mercDeck[10].image = Image.FromFile(imgPath + "mercenaryMinion.png");
            mercDeck[10].attack = 2;
            mercDeck[10].health = 2;
            mercDeck[10].cost = 0;

            InitializeComponent();
            medicClass.Image = Image.FromFile(imgPath + "medicClass.png");
            mercPic.Image = Image.FromFile(imgPath + "mercenaryClass.png");
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView2.View = View.Details;
            listView2.FullRowSelect = true;
            listViewHandMerc.View = View.Details;
            listViewHandMerc.FullRowSelect = true;
            listViewFieldMerc.View = View.Details;
            listViewFieldMerc.FullRowSelect = true;
        }   

        private void Button4_Click(object sender, EventArgs e)
        {
            
            Random random = new Random();
            randomIndex = random.Next(0, 10);
            medLabel.Text = medicDeck[randomIndex].name;
            pictureBox2.Image = medicDeck[randomIndex].image;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            randomIndex = random.Next(0, 10);
            mercLabel2.Text = mercDeck[randomIndex].name;
            pictureBox1.Image = mercDeck[randomIndex].image;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (medicHP > 0)
            {
                medicHP--;
            }
            label5.Text = medicHP.ToString();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (medicHP < 25)
            {
                medicHP++;
            }
            label5.Text = medicHP.ToString();
        }
        private void MercStatsMin_Click(object sender, EventArgs e)
        {
            if (mercHP > 0)
            {
                mercHP--;
            }
            mercStatsLabel.Text = mercHP.ToString();
        }

        private void MercStatsPlus_Click(object sender, EventArgs e)
        {
            if (mercHP < 25)
            {
                mercHP++;
            }
            mercStatsLabel.Text = mercHP.ToString();
        }

        private void AddHandButton_Click(object sender, EventArgs e)
        {
            ListViewItem item = listView1.Items.Add(medicDeck[randomIndex].name);
            item.SubItems.Add(medicDeck[randomIndex].health.ToString());
            item.SubItems.Add(medicDeck[randomIndex].attack.ToString());
            item.SubItems.Add(medicDeck[randomIndex].cost.ToString());
        }

        private void Clear1Button_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void Removebutton1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem i in listView1.SelectedItems)
            {
                i.Remove();
            }
        }

        private void AddToField_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem i in listView1.SelectedItems)
            {
                string cost = i.SubItems[3].Text;
                int costInt = Int32.Parse(cost);
                if (storageBar.Value - costInt >= 0)
                {
                    i.Remove();
                    listView2.Items.Add(i);
                    storageBar.Value -= costInt;
                    storageText.Text = "Storage: " + (storageBar.Value) + "/" + storageBar.Maximum;
                    errorLabel.Visible = false;
                    totalCost += costInt;
                }
                else
                {
                    errorLabel.Visible = true;
                }
            }
        }

        private void removebutton2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem i in listView2.SelectedItems)
            {
                string costString = i.SubItems[3].Text;
                int costInt = Int32.Parse(costString);
                i.Remove();
                totalCost -= costInt;
                storageBar.Value += costInt;
                storageText.Text = "Storage: " + storageBar.Value + "/" + storageBar.Maximum;
            }
        }

        private void ListAttack1Sub_Click(object sender, EventArgs e)
        {
            string attack = "";
            string health = "";
            string cost = "";
            foreach (ListViewItem i in listView2.SelectedItems)
            {
                attack = i.SubItems[2].Text;
                int attackInt = Int32.Parse(attack);
                if (attackInt > 0)
                {
                    attackInt--;
                }
                health = i.SubItems[1].Text;
                cost = i.SubItems[3].Text;
                i.SubItems.RemoveAt(1);
                i.SubItems.RemoveAt(1);
                i.SubItems.RemoveAt(1);
                i.SubItems.Add(health);
                i.SubItems.Add(attackInt.ToString());
                i.SubItems.Add(cost);
            }
        }

        private void ListAttack1Plus_Click(object sender, EventArgs e)
        {
            string attack = "";
            string health = "";
            string cost = "";
            foreach (ListViewItem i in listView2.SelectedItems)
            {
                attack = i.SubItems[2].Text;
                int attackInt = Int32.Parse(attack);
                if (attackInt < 15)
                {
                    attackInt++;
                }
                health = i.SubItems[1].Text;
                cost = i.SubItems[3].Text;
                i.SubItems.RemoveAt(1);
                i.SubItems.RemoveAt(1);
                i.SubItems.RemoveAt(1);
                i.SubItems.Add(health);
                i.SubItems.Add(attackInt.ToString());
                i.SubItems.Add(cost);
            }
        }

        private void ListHealth1Sub_Click(object sender, EventArgs e)
        {
            string attack = "";
            string health = "";
            string cost = "";
            foreach (ListViewItem i in listView2.SelectedItems)
            {
                health = i.SubItems[1].Text;
                int healthInt = Int32.Parse(health);
                if (healthInt > 0)
                {
                    healthInt--;
                }
                attack = i.SubItems[2].Text;
                cost = i.SubItems[3].Text;
                i.SubItems.RemoveAt(1);
                i.SubItems.RemoveAt(1);
                i.SubItems.RemoveAt(1);
                i.SubItems.Add(healthInt.ToString());
                i.SubItems.Add(attack);
                i.SubItems.Add(cost);
            }
        }

        private void ListHealth1Plus_Click(object sender, EventArgs e)
        {
            string attack = "";
            string health = "";
            string cost = "";
            foreach (ListViewItem i in listView2.SelectedItems)
            {
                health = i.SubItems[1].Text;
                int healthInt = Int32.Parse(health);
                if (healthInt < 100)
                {
                    healthInt++;
                }
                attack = i.SubItems[2].Text;
                cost = i.SubItems[3].Text;
                i.SubItems.RemoveAt(1);
                i.SubItems.RemoveAt(1);
                i.SubItems.RemoveAt(1);
                i.SubItems.Add(healthInt.ToString());
                i.SubItems.Add(attack);
                i.SubItems.Add(cost);
            }
        }

        private void Clear2Button_Click_1(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            totalCost = 0;
            storageBar.Value = storageBar.Maximum;
            storageText.Text = "Storage: " + storageBar.Value + "/" + storageBar.Maximum;
        }

        private void NextTurnButton_Click(object sender, EventArgs e)
        {
            //Medic Bar
            errorLabel.Visible = false;
            if (storageBar.Maximum < 8)
            {
                storageBar.Maximum++;
            }
            if (listView2.Items.Count == 0)
            {
                storageBar.Value = storageBar.Maximum;
            }
            else
            {
                storageBar.Value = storageBar.Maximum - totalCost;
            }
            storageText.Text = "Storage: " + storageBar.Value + "/" + storageBar.Maximum;
        }

        private void ListView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Card c in medicDeck)
            {
                foreach (ListViewItem i in listView2.SelectedItems)
                {
                    if (i.Text == c.name)
                    {
                        imagePreview.Image = c.image;
                    }
                }
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView2.Items.Clear();
            imagePreview.Image = null;
            pictureBox2.Image = null;
            storageBar.Maximum = 1;
            storageBar.Value = storageBar.Maximum;
            storageText.Text = "Storage: " + storageBar.Value + "/" + storageBar.Maximum;
            medLabel.Text = null;
            errorLabel.Text = null;
            listViewHandMerc.Items.Clear();
            listViewFieldMerc.Items.Clear();
            imagePreviewMerc.Image = null;
            pictureBox1.Image = null;
            storageBarMerc.Maximum = 1;
            storageBarMerc.Value = storageBarMerc.Maximum;
            storageTextMerc.Text = "Storage: " + storageBarMerc.Value + "/" + storageBarMerc.Maximum;
            mercLabel2.Text = null;
            errorMerc.Text = null;

        }

        //Merc functions
        private void AddToHandMerc_Click(object sender, EventArgs e)
        {
            ListViewItem item = listViewHandMerc.Items.Add(mercDeck[randomIndex].name);
            item.SubItems.Add(mercDeck[randomIndex].health.ToString());
            item.SubItems.Add(mercDeck[randomIndex].attack.ToString());
            item.SubItems.Add(mercDeck[randomIndex].cost.ToString());
        }

        private void Clear1Merc_Click(object sender, EventArgs e)
        {
            listViewHandMerc.Items.Clear();
        }

        private void Remove1Merc_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem i in listViewHandMerc.SelectedItems)
            {
                i.Remove();
            }
        }

        private void AddToFieldMerc_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem i in listViewHandMerc.SelectedItems)
            {
                string cost = i.SubItems[3].Text;
                int costInt = Int32.Parse(cost);
                if (storageBarMerc.Value - costInt >= 0)
                {
                    i.Remove();
                    listViewFieldMerc.Items.Add(i);
                    storageBarMerc.Value -= costInt;
                    storageTextMerc.Text = "Storage: " + (storageBarMerc.Value) + "/" + storageBarMerc.Maximum;
                    errorMerc.Visible = false;
                    totalCostMerc += costInt;
                }
                else
                {
                    errorMerc.Visible = true;
                }
            }
        }

        private void Clear2Merc_Click(object sender, EventArgs e)
        {
            listViewFieldMerc.Items.Clear();
            totalCostMerc = 0;
            storageBarMerc.Value = storageBarMerc.Maximum;
            storageTextMerc.Text = "Storage: " + storageBarMerc.Value + "/" + storageBarMerc.Maximum;
        }

        private void Remove2Merc_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem i in listViewFieldMerc.SelectedItems)
            {
                string costString = i.SubItems[3].Text;
                int costInt = Int32.Parse(costString);
                i.Remove();
                totalCostMerc -= costInt;
                storageBarMerc.Value += costInt;
                storageTextMerc.Text = "Storage: " + storageBarMerc.Value + "/" + storageBarMerc.Maximum;
            }
        }

        private void Minus1merc_Click(object sender, EventArgs e)
        {
            string attack = "";
            string health = "";
            string cost = "";
            foreach (ListViewItem i in listViewFieldMerc.SelectedItems)
            {
                attack = i.SubItems[2].Text;
                int attackInt = Int32.Parse(attack);
                if (attackInt > 0)
                {
                    attackInt--;
                }
                health = i.SubItems[1].Text;
                cost = i.SubItems[3].Text;
                i.SubItems.RemoveAt(1);
                i.SubItems.RemoveAt(1);
                i.SubItems.RemoveAt(1);
                i.SubItems.Add(health);
                i.SubItems.Add(attackInt.ToString());
                i.SubItems.Add(cost);
            }
        }

        private void Plus1merc_Click(object sender, EventArgs e)
        {
            string attack = "";
            string health = "";
            string cost = "";
            foreach (ListViewItem i in listViewFieldMerc.SelectedItems)
            {
                attack = i.SubItems[2].Text;
                int attackInt = Int32.Parse(attack);
                if (attackInt < 15)
                {
                    attackInt++;
                }
                health = i.SubItems[1].Text;
                cost = i.SubItems[3].Text;
                i.SubItems.RemoveAt(1);
                i.SubItems.RemoveAt(1);
                i.SubItems.RemoveAt(1);
                i.SubItems.Add(health);
                i.SubItems.Add(attackInt.ToString());
                i.SubItems.Add(cost);
            }
        }

        private void Minus2merc_Click(object sender, EventArgs e)
        {
            string attack = "";
            string health = "";
            string cost = "";
            foreach (ListViewItem i in listViewFieldMerc.SelectedItems)
            {
                health = i.SubItems[1].Text;
                int healthInt = Int32.Parse(health);
                if (healthInt > 0)
                {
                    healthInt--;
                }
                attack = i.SubItems[2].Text;
                cost = i.SubItems[3].Text;
                i.SubItems.RemoveAt(1);
                i.SubItems.RemoveAt(1);
                i.SubItems.RemoveAt(1);
                i.SubItems.Add(healthInt.ToString());
                i.SubItems.Add(attack);
                i.SubItems.Add(cost);
            }
        }

        private void Plus2merc_Click(object sender, EventArgs e)
        {
            string attack = "";
            string health = "";
            string cost = "";
            foreach (ListViewItem i in listViewFieldMerc.SelectedItems)
            {
                health = i.SubItems[1].Text;
                int healthInt = Int32.Parse(health);
                if (healthInt < 100)
                {
                    healthInt++;
                }
                attack = i.SubItems[2].Text;
                cost = i.SubItems[3].Text;
                i.SubItems.RemoveAt(1);
                i.SubItems.RemoveAt(1);
                i.SubItems.RemoveAt(1);
                i.SubItems.Add(healthInt.ToString());
                i.SubItems.Add(attack);
                i.SubItems.Add(cost);
            }
        }

        private void ListViewFieldMerc_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Card c in mercDeck)
            {
                foreach (ListViewItem i in listViewFieldMerc.SelectedItems)
                {
                    if (i.Text == c.name)
                    {
                        imagePreviewMerc.Image = c.image;
                    }
                }
            }
            foreach (Card d in medicDeck)
            {
                foreach (ListViewItem i in listViewFieldMerc.SelectedItems)
                {
                    if (i.Text == d.name)
                    {
                        imagePreviewMerc.Image = d.image;
                    }
                }
            }
        }

        private void NextTurnMercButton_Click(object sender, EventArgs e)
        {
            //Merc Bar
            errorMerc.Visible = false;
            if (storageBarMerc.Maximum < 8)
            {
                storageBarMerc.Maximum++;
            }
            if (listViewFieldMerc.Items.Count == 0)
            {
                storageBarMerc.Value = storageBarMerc.Maximum;
            }
            else
            {
                storageBarMerc.Value = storageBarMerc.Maximum - totalCostMerc;
            }
            storageTextMerc.Text = "Storage: " + storageBarMerc.Value + "/" + storageBarMerc.Maximum;
        }

        private void AddminionMedic_Click(object sender, EventArgs e)
        {
            foreach (Card c in medicDeck)
            {
                if (c.name == "Minion")
                {
                    ListViewItem item = listView2.Items.Add(c.name);
                    item.SubItems.Add(c.attack.ToString());
                    item.SubItems.Add(c.health.ToString());
                    item.SubItems.Add(c.cost.ToString());
                }
            }
        }

        private void AddminionMerc_Click(object sender, EventArgs e)
        {
            foreach (Card c in mercDeck)
            {
                if (c.name == "Minion")
                {
                    ListViewItem item = listViewFieldMerc.Items.Add(c.name);
                    item.SubItems.Add(c.attack.ToString());
                    item.SubItems.Add(c.health.ToString());
                    item.SubItems.Add(c.cost.ToString());
                }
            }
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Card c in medicDeck)
            {
                foreach (ListViewItem i in listView1.SelectedItems)
                {
                    if (i.Text == c.name)
                    {
                        pictureBox2.Image = c.image;
                    }
                }
            }
        }

        private void ListViewHandMerc_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Card c in mercDeck)
            {
                foreach (ListViewItem i in listViewHandMerc.SelectedItems)
                {
                    if (i.Text == c.name)
                    {
                        pictureBox1.Image = c.image;
                    }
                }
            }
        }

        private void TakeButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem i in listView2.SelectedItems)
            {
                string cost = i.SubItems[3].Text;
                int costInt = Int32.Parse(cost);
                storageBar.Value += costInt;
                storageText.Text = "Storage: " + (storageBar.Value) + "/" + storageBar.Maximum;
                totalCost -= costInt;
                i.Remove();
                i.SubItems[3].Text = "0";
                listViewFieldMerc.Items.Add(i);
            }
        }
    }
}
