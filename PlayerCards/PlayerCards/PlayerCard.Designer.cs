namespace PlayerCards
{
    partial class playerCard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(playerCard));
            this.playerSelection = new System.Windows.Forms.ComboBox();
            this.team = new System.Windows.Forms.Label();
            this.playerData = new System.Windows.Forms.TableLayoutPanel();
            this.matches = new System.Windows.Forms.TextBox();
            this.nation = new System.Windows.Forms.TextBox();
            this.games = new System.Windows.Forms.TextBox();
            this.weight = new System.Windows.Forms.TextBox();
            this.height = new System.Windows.Forms.TextBox();
            this.birth = new System.Windows.Forms.TextBox();
            this.accession = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.TextBox();
            this.position = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.matchesLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.positionLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.accessionLabel = new System.Windows.Forms.Label();
            this.birthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.gamesLabel = new System.Windows.Forms.Label();
            this.nationLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.TextBox();
            this.last = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.previous = new System.Windows.Forms.Button();
            this.first = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.playerData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // playerSelection
            // 
            this.playerSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.playerSelection.FormattingEnabled = true;
            this.playerSelection.Location = new System.Drawing.Point(21, 33);
            this.playerSelection.Name = "playerSelection";
            this.playerSelection.Size = new System.Drawing.Size(273, 21);
            this.playerSelection.TabIndex = 1;
            // 
            // team
            // 
            this.team.AutoSize = true;
            this.team.Location = new System.Drawing.Point(652, 33);
            this.team.Name = "team";
            this.team.Size = new System.Drawing.Size(67, 13);
            this.team.TabIndex = 2;
            this.team.Text = "VfB Stuttgart";
            // 
            // playerData
            // 
            this.playerData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.playerData.ColumnCount = 2;
            this.playerData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.37374F));
            this.playerData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.62626F));
            this.playerData.Controls.Add(this.matches, 1, 10);
            this.playerData.Controls.Add(this.nation, 1, 9);
            this.playerData.Controls.Add(this.games, 1, 8);
            this.playerData.Controls.Add(this.weight, 1, 7);
            this.playerData.Controls.Add(this.height, 1, 6);
            this.playerData.Controls.Add(this.birth, 1, 5);
            this.playerData.Controls.Add(this.accession, 1, 4);
            this.playerData.Controls.Add(this.number, 1, 3);
            this.playerData.Controls.Add(this.position, 1, 2);
            this.playerData.Controls.Add(this.name, 1, 1);
            this.playerData.Controls.Add(this.matchesLabel, 0, 10);
            this.playerData.Controls.Add(this.surnameLabel, 0, 0);
            this.playerData.Controls.Add(this.positionLabel, 0, 2);
            this.playerData.Controls.Add(this.numberLabel, 0, 3);
            this.playerData.Controls.Add(this.accessionLabel, 0, 4);
            this.playerData.Controls.Add(this.birthLabel, 0, 5);
            this.playerData.Controls.Add(this.heightLabel, 0, 6);
            this.playerData.Controls.Add(this.weightLabel, 0, 7);
            this.playerData.Controls.Add(this.gamesLabel, 0, 8);
            this.playerData.Controls.Add(this.nationLabel, 0, 9);
            this.playerData.Controls.Add(this.nameLabel, 0, 1);
            this.playerData.Controls.Add(this.surname, 1, 0);
            this.playerData.Location = new System.Drawing.Point(323, 80);
            this.playerData.Name = "playerData";
            this.playerData.RowCount = 11;
            this.playerData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.playerData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.playerData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.playerData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.playerData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.playerData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.playerData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.playerData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.playerData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.playerData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.playerData.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.playerData.Size = new System.Drawing.Size(396, 397);
            this.playerData.TabIndex = 17;
            // 
            // matches
            // 
            this.matches.Location = new System.Drawing.Point(151, 263);
            this.matches.Name = "matches";
            this.matches.ReadOnly = true;
            this.matches.Size = new System.Drawing.Size(231, 20);
            this.matches.TabIndex = 16;
            // 
            // nation
            // 
            this.nation.Location = new System.Drawing.Point(151, 237);
            this.nation.Name = "nation";
            this.nation.ReadOnly = true;
            this.nation.Size = new System.Drawing.Size(231, 20);
            this.nation.TabIndex = 15;
            // 
            // games
            // 
            this.games.Location = new System.Drawing.Point(151, 211);
            this.games.Name = "games";
            this.games.ReadOnly = true;
            this.games.Size = new System.Drawing.Size(231, 20);
            this.games.TabIndex = 14;
            // 
            // weight
            // 
            this.weight.Location = new System.Drawing.Point(151, 185);
            this.weight.Name = "weight";
            this.weight.ReadOnly = true;
            this.weight.Size = new System.Drawing.Size(231, 20);
            this.weight.TabIndex = 13;
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(151, 159);
            this.height.Name = "height";
            this.height.ReadOnly = true;
            this.height.Size = new System.Drawing.Size(231, 20);
            this.height.TabIndex = 12;
            // 
            // birth
            // 
            this.birth.Location = new System.Drawing.Point(151, 133);
            this.birth.Name = "birth";
            this.birth.ReadOnly = true;
            this.birth.Size = new System.Drawing.Size(231, 20);
            this.birth.TabIndex = 11;
            // 
            // accession
            // 
            this.accession.Location = new System.Drawing.Point(151, 107);
            this.accession.Name = "accession";
            this.accession.ReadOnly = true;
            this.accession.Size = new System.Drawing.Size(231, 20);
            this.accession.TabIndex = 10;
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(151, 81);
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Size = new System.Drawing.Size(231, 20);
            this.number.TabIndex = 9;
            // 
            // position
            // 
            this.position.Location = new System.Drawing.Point(151, 55);
            this.position.Name = "position";
            this.position.ReadOnly = true;
            this.position.Size = new System.Drawing.Size(231, 20);
            this.position.TabIndex = 8;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(151, 29);
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Size = new System.Drawing.Size(231, 20);
            this.name.TabIndex = 7;
            // 
            // matchesLabel
            // 
            this.matchesLabel.AutoSize = true;
            this.matchesLabel.Location = new System.Drawing.Point(3, 260);
            this.matchesLabel.Name = "matchesLabel";
            this.matchesLabel.Size = new System.Drawing.Size(70, 13);
            this.matchesLabel.TabIndex = 13;
            this.matchesLabel.Text = "Länderspiele:";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(3, 0);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(38, 13);
            this.surnameLabel.TabIndex = 3;
            this.surnameLabel.Text = "Name:";
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Location = new System.Drawing.Point(3, 52);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(47, 13);
            this.positionLabel.TabIndex = 4;
            this.positionLabel.Text = "Position:";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(3, 78);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(85, 13);
            this.numberLabel.TabIndex = 6;
            this.numberLabel.Text = "Rückennummer:";
            // 
            // accessionLabel
            // 
            this.accessionLabel.AutoSize = true;
            this.accessionLabel.Location = new System.Drawing.Point(3, 104);
            this.accessionLabel.Name = "accessionLabel";
            this.accessionLabel.Size = new System.Drawing.Size(73, 13);
            this.accessionLabel.TabIndex = 7;
            this.accessionLabel.Text = "Im Verein seit:";
            // 
            // birthLabel
            // 
            this.birthLabel.AutoSize = true;
            this.birthLabel.Location = new System.Drawing.Point(3, 130);
            this.birthLabel.Name = "birthLabel";
            this.birthLabel.Size = new System.Drawing.Size(68, 13);
            this.birthLabel.TabIndex = 8;
            this.birthLabel.Text = "Geboren am:";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(3, 156);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(62, 13);
            this.heightLabel.TabIndex = 9;
            this.heightLabel.Text = "Größe (cm):";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(3, 182);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(70, 13);
            this.weightLabel.TabIndex = 10;
            this.weightLabel.Text = "Gewicht (kg):";
            // 
            // gamesLabel
            // 
            this.gamesLabel.AutoSize = true;
            this.gamesLabel.Location = new System.Drawing.Point(3, 208);
            this.gamesLabel.Name = "gamesLabel";
            this.gamesLabel.Size = new System.Drawing.Size(121, 13);
            this.gamesLabel.TabIndex = 11;
            this.gamesLabel.Text = "Spiele/Tore Bundesliga:";
            // 
            // nationLabel
            // 
            this.nationLabel.AutoSize = true;
            this.nationLabel.Location = new System.Drawing.Point(3, 234);
            this.nationLabel.Name = "nationLabel";
            this.nationLabel.Size = new System.Drawing.Size(41, 13);
            this.nationLabel.TabIndex = 12;
            this.nationLabel.Text = "Nation:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(3, 26);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(52, 13);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Vorname:";
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(151, 3);
            this.surname.Name = "surname";
            this.surname.ReadOnly = true;
            this.surname.Size = new System.Drawing.Size(231, 20);
            this.surname.TabIndex = 6;
            // 
            // last
            // 
            this.last.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("last.BackgroundImage")));
            this.last.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.last.Location = new System.Drawing.Point(219, 421);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(60, 56);
            this.last.TabIndex = 5;
            this.last.UseVisualStyleBackColor = true;
            // 
            // next
            // 
            this.next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("next.BackgroundImage")));
            this.next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.next.Location = new System.Drawing.Point(153, 421);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(60, 56);
            this.next.TabIndex = 4;
            this.next.UseVisualStyleBackColor = true;
            // 
            // previous
            // 
            this.previous.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("previous.BackgroundImage")));
            this.previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.previous.Location = new System.Drawing.Point(87, 421);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(60, 56);
            this.previous.TabIndex = 3;
            this.previous.UseVisualStyleBackColor = true;
            // 
            // first
            // 
            this.first.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("first.BackgroundImage")));
            this.first.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.first.Location = new System.Drawing.Point(21, 421);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(60, 56);
            this.first.TabIndex = 2;
            this.first.UseVisualStyleBackColor = true;
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(21, 80);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(258, 319);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // playerCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(735, 486);
            this.Controls.Add(this.last);
            this.Controls.Add(this.next);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.first);
            this.Controls.Add(this.playerData);
            this.Controls.Add(this.team);
            this.Controls.Add(this.playerSelection);
            this.Controls.Add(this.picture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "playerCard";
            this.Text = "Meine Fußball-Mannschaft";
            this.playerData.ResumeLayout(false);
            this.playerData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.ComboBox playerSelection;
        private System.Windows.Forms.Label team;
        private System.Windows.Forms.TableLayoutPanel playerData;
        private System.Windows.Forms.TextBox matches;
        private System.Windows.Forms.TextBox nation;
        private System.Windows.Forms.TextBox games;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.TextBox birth;
        private System.Windows.Forms.TextBox accession;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.TextBox position;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label matchesLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label accessionLabel;
        private System.Windows.Forms.Label birthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label gamesLabel;
        private System.Windows.Forms.Label nationLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.Button first;
        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button last;
    }
}

