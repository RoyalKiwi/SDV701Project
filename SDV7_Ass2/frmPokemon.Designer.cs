namespace WinFormAdmin
{
    partial class frmPokemon
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDexNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtDustCost = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.cbEvolvable = new System.Windows.Forms.ComboBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDustCostNewMove = new System.Windows.Forms.TextBox();
            this.txtCandyCostEvolution = new System.Windows.Forms.TextBox();
            this.txtNextEvolution = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(33, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Evolveable";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(33, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(33, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(33, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dust Cost:";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(33, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Description:";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(33, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Name:";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(33, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 8;
            this.label9.Text = "Dex No:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(33, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Type:";
            // 
            // txtDexNo
            // 
            this.txtDexNo.Location = new System.Drawing.Point(115, 48);
            this.txtDexNo.Name = "txtDexNo";
            this.txtDexNo.Size = new System.Drawing.Size(100, 20);
            this.txtDexNo.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(115, 71);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 11;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(115, 94);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 20);
            this.txtDescription.TabIndex = 12;
            // 
            // txtDustCost
            // 
            this.txtDustCost.Location = new System.Drawing.Point(115, 117);
            this.txtDustCost.Name = "txtDustCost";
            this.txtDustCost.Size = new System.Drawing.Size(100, 20);
            this.txtDustCost.TabIndex = 13;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(115, 140);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 14;
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(115, 163);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(100, 21);
            this.cbGender.TabIndex = 15;
            // 
            // cbEvolvable
            // 
            this.cbEvolvable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEvolvable.FormattingEnabled = true;
            this.cbEvolvable.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbEvolvable.Location = new System.Drawing.Point(115, 186);
            this.cbEvolvable.Name = "cbEvolvable";
            this.cbEvolvable.Size = new System.Drawing.Size(100, 21);
            this.cbEvolvable.TabIndex = 16;
            this.cbEvolvable.SelectedIndexChanged += new System.EventHandler(this.cbEvolvable_SelectedIndexChanged);
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Fire",
            "Water",
            "Earth"});
            this.cbType.Location = new System.Drawing.Point(115, 25);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(100, 21);
            this.cbType.TabIndex = 17;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(176, 247);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "OK";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(176, 287);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(33, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "DustCostofNewMove";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(33, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 23);
            this.label10.TabIndex = 21;
            this.label10.Text = "NextEvolutionName";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(36, 292);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 23);
            this.label11.TabIndex = 22;
            this.label11.Text = "CandyCostOfNextEvolution";
            // 
            // txtDustCostNewMove
            // 
            this.txtDustCostNewMove.Enabled = false;
            this.txtDustCostNewMove.Location = new System.Drawing.Point(36, 229);
            this.txtDustCostNewMove.Name = "txtDustCostNewMove";
            this.txtDustCostNewMove.Size = new System.Drawing.Size(100, 20);
            this.txtDustCostNewMove.TabIndex = 23;
            // 
            // txtCandyCostEvolution
            // 
            this.txtCandyCostEvolution.Enabled = false;
            this.txtCandyCostEvolution.Location = new System.Drawing.Point(36, 307);
            this.txtCandyCostEvolution.Name = "txtCandyCostEvolution";
            this.txtCandyCostEvolution.Size = new System.Drawing.Size(100, 20);
            this.txtCandyCostEvolution.TabIndex = 24;
            // 
            // txtNextEvolution
            // 
            this.txtNextEvolution.Enabled = false;
            this.txtNextEvolution.Location = new System.Drawing.Point(36, 269);
            this.txtNextEvolution.Name = "txtNextEvolution";
            this.txtNextEvolution.Size = new System.Drawing.Size(100, 20);
            this.txtNextEvolution.TabIndex = 25;
            // 
            // frmPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 353);
            this.Controls.Add(this.txtNextEvolution);
            this.Controls.Add(this.txtCandyCostEvolution);
            this.Controls.Add(this.txtDustCostNewMove);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.cbEvolvable);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtDustCost);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDexNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmPokemon";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDexNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtDustCost;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.ComboBox cbEvolvable;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDustCostNewMove;
        private System.Windows.Forms.TextBox txtCandyCostEvolution;
        private System.Windows.Forms.TextBox txtNextEvolution;
    }
}