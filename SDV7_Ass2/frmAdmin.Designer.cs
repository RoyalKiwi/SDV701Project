namespace WinFormAdmin
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.cbTypes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstPokemon = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblDateModified = new System.Windows.Forms.Label();
            this.lblDustCost = new System.Windows.Forms.Label();
            this.lblNextEvolutionCost = new System.Windows.Forms.Label();
            this.lblNextEvloutionName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTypeDescription = new System.Windows.Forms.Label();
            this.lblDustCostMove = new System.Windows.Forms.Label();
            this.lblEvolvable = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTypes
            // 
            this.cbTypes.FormattingEnabled = true;
            this.cbTypes.Location = new System.Drawing.Point(167, 30);
            this.cbTypes.Name = "cbTypes";
            this.cbTypes.Size = new System.Drawing.Size(208, 21);
            this.cbTypes.TabIndex = 0;
            this.cbTypes.Text = "FIRE";
            this.cbTypes.SelectedIndexChanged += new System.EventHandler(this.cbTypes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type";
            // 
            // lstPokemon
            // 
            this.lstPokemon.FormattingEnabled = true;
            this.lstPokemon.Location = new System.Drawing.Point(28, 68);
            this.lstPokemon.Name = "lstPokemon";
            this.lstPokemon.Size = new System.Drawing.Size(371, 264);
            this.lstPokemon.TabIndex = 2;
            this.lstPokemon.SelectedIndexChanged += new System.EventHandler(this.lstPokemon_SelectedIndexChanged);
            this.lstPokemon.DoubleClick += new System.EventHandler(this.lstPokemon_DoubleClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(28, 349);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(28, 396);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(237, 23);
            this.btnOrders.TabIndex = 6;
            this.btnOrders.Text = "VIEW ORDERS";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(190, 349);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(109, 349);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(474, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Type:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(474, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Dust Cost of New Move:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(474, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Next Evolution Name:";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(474, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Candy Cost of Evolution:";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(474, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "Evolvable:";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(474, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 21);
            this.label9.TabIndex = 16;
            this.label9.Text = "Gender:";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(474, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 21);
            this.label10.TabIndex = 17;
            this.label10.Text = "Quantity:";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(474, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 21);
            this.label11.TabIndex = 18;
            this.label11.Text = "Date Last Modified:";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(474, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 21);
            this.label12.TabIndex = 19;
            this.label12.Text = "Dust Cost:";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(474, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 21);
            this.label13.TabIndex = 20;
            this.label13.Text = "Description:";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(474, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 21);
            this.label14.TabIndex = 21;
            this.label14.Text = "Name:";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(474, 52);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 21);
            this.label15.TabIndex = 22;
            this.label15.Text = "Type Description:";
            // 
            // lblType
            // 
            this.lblType.Location = new System.Drawing.Point(614, 31);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(35, 21);
            this.lblType.TabIndex = 23;
            this.lblType.Text = "Fire";
            // 
            // lblGender
            // 
            this.lblGender.Location = new System.Drawing.Point(614, 220);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(132, 21);
            this.lblGender.TabIndex = 24;
            this.lblGender.Text = "M";
            // 
            // lblQuantity
            // 
            this.lblQuantity.Location = new System.Drawing.Point(614, 199);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(174, 21);
            this.lblQuantity.TabIndex = 25;
            this.lblQuantity.Text = "6";
            // 
            // lblDateModified
            // 
            this.lblDateModified.Location = new System.Drawing.Point(614, 178);
            this.lblDateModified.Name = "lblDateModified";
            this.lblDateModified.Size = new System.Drawing.Size(174, 21);
            this.lblDateModified.TabIndex = 26;
            this.lblDateModified.Text = "Type:";
            // 
            // lblDustCost
            // 
            this.lblDustCost.Location = new System.Drawing.Point(614, 157);
            this.lblDustCost.Name = "lblDustCost";
            this.lblDustCost.Size = new System.Drawing.Size(44, 21);
            this.lblDustCost.TabIndex = 27;
            this.lblDustCost.Text = "25000";
            // 
            // lblNextEvolutionCost
            // 
            this.lblNextEvolutionCost.Location = new System.Drawing.Point(614, 307);
            this.lblNextEvolutionCost.Name = "lblNextEvolutionCost";
            this.lblNextEvolutionCost.Size = new System.Drawing.Size(35, 21);
            this.lblNextEvolutionCost.TabIndex = 28;
            this.lblNextEvolutionCost.Text = "25";
            // 
            // lblNextEvloutionName
            // 
            this.lblNextEvloutionName.Location = new System.Drawing.Point(614, 286);
            this.lblNextEvloutionName.Name = "lblNextEvloutionName";
            this.lblNextEvloutionName.Size = new System.Drawing.Size(96, 21);
            this.lblNextEvloutionName.TabIndex = 29;
            this.lblNextEvloutionName.Text = "Charmeleon";
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(614, 94);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(132, 63);
            this.lblDescription.TabIndex = 30;
            this.lblDescription.Text = "The flame on its tail shows the strength of its life force. If it is weak, the fl" +
    "ame also burns weakly.";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(614, 73);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(108, 21);
            this.lblName.TabIndex = 31;
            this.lblName.Text = "Charmander";
            // 
            // lblTypeDescription
            // 
            this.lblTypeDescription.Location = new System.Drawing.Point(614, 52);
            this.lblTypeDescription.Name = "lblTypeDescription";
            this.lblTypeDescription.Size = new System.Drawing.Size(124, 21);
            this.lblTypeDescription.TabIndex = 32;
            this.lblTypeDescription.Text = "Uses Fire Attacks";
            // 
            // lblDustCostMove
            // 
            this.lblDustCostMove.Location = new System.Drawing.Point(614, 265);
            this.lblDustCostMove.Name = "lblDustCostMove";
            this.lblDustCostMove.Size = new System.Drawing.Size(187, 21);
            this.lblDustCostMove.TabIndex = 33;
            this.lblDustCostMove.Text = "N/A";
            // 
            // lblEvolvable
            // 
            this.lblEvolvable.Location = new System.Drawing.Point(614, 244);
            this.lblEvolvable.Name = "lblEvolvable";
            this.lblEvolvable.Size = new System.Drawing.Size(124, 21);
            this.lblEvolvable.TabIndex = 34;
            this.lblEvolvable.Text = "Yes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(514, 331);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblEvolvable);
            this.Controls.Add(this.lblDustCostMove);
            this.Controls.Add(this.lblTypeDescription);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblNextEvloutionName);
            this.Controls.Add(this.lblNextEvolutionCost);
            this.Controls.Add(this.lblDustCost);
            this.Controls.Add(this.lblDateModified);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstPokemon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTypes);
            this.Name = "frmAdmin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstPokemon;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblDateModified;
        private System.Windows.Forms.Label lblDustCost;
        private System.Windows.Forms.Label lblNextEvolutionCost;
        private System.Windows.Forms.Label lblNextEvloutionName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTypeDescription;
        private System.Windows.Forms.Label lblDustCostMove;
        private System.Windows.Forms.Label lblEvolvable;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

