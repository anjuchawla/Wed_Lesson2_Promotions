namespace Wed_Lesson2_Promotions
{
    partial class frmPromotions
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.grpDepartment = new System.Windows.Forms.GroupBox();
            this.rdoClothing = new System.Windows.Forms.RadioButton();
            this.rdoEquipment = new System.Windows.Forms.RadioButton();
            this.rdoJuiceBar = new System.Windows.Forms.RadioButton();
            this.rdoMembership = new System.Windows.Forms.RadioButton();
            this.rdoTraining = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.mtbMemberId = new System.Windows.Forms.MaskedTextBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.chbImageVisible = new System.Windows.Forms.CheckBox();
            this.pcbDepartment = new System.Windows.Forms.PictureBox();
            this.grpDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Look Sharp Fitness Center";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(556, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Anju Chawla";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(655, 499);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -3;
            this.lineShape1.X2 = 660;
            this.lineShape1.Y1 = 58;
            this.lineShape1.Y2 = 62;
            // 
            // grpDepartment
            // 
            this.grpDepartment.Controls.Add(this.rdoTraining);
            this.grpDepartment.Controls.Add(this.rdoMembership);
            this.grpDepartment.Controls.Add(this.rdoJuiceBar);
            this.grpDepartment.Controls.Add(this.rdoEquipment);
            this.grpDepartment.Controls.Add(this.rdoClothing);
            this.grpDepartment.Location = new System.Drawing.Point(26, 99);
            this.grpDepartment.Name = "grpDepartment";
            this.grpDepartment.Size = new System.Drawing.Size(233, 186);
            this.grpDepartment.TabIndex = 3;
            this.grpDepartment.TabStop = false;
            this.grpDepartment.Text = "Department";
            // 
            // rdoClothing
            // 
            this.rdoClothing.AutoSize = true;
            this.rdoClothing.Location = new System.Drawing.Point(19, 35);
            this.rdoClothing.Name = "rdoClothing";
            this.rdoClothing.Size = new System.Drawing.Size(80, 21);
            this.rdoClothing.TabIndex = 0;
            this.rdoClothing.TabStop = true;
            this.rdoClothing.Text = "&Clothing";
            this.rdoClothing.UseVisualStyleBackColor = true;
            // 
            // rdoEquipment
            // 
            this.rdoEquipment.AutoSize = true;
            this.rdoEquipment.Location = new System.Drawing.Point(19, 62);
            this.rdoEquipment.Name = "rdoEquipment";
            this.rdoEquipment.Size = new System.Drawing.Size(176, 21);
            this.rdoEquipment.TabIndex = 1;
            this.rdoEquipment.TabStop = true;
            this.rdoEquipment.Text = "E&quipment/Accessories";
            this.rdoEquipment.UseVisualStyleBackColor = true;
            // 
            // rdoJuiceBar
            // 
            this.rdoJuiceBar.AutoSize = true;
            this.rdoJuiceBar.Location = new System.Drawing.Point(19, 89);
            this.rdoJuiceBar.Name = "rdoJuiceBar";
            this.rdoJuiceBar.Size = new System.Drawing.Size(88, 21);
            this.rdoJuiceBar.TabIndex = 2;
            this.rdoJuiceBar.TabStop = true;
            this.rdoJuiceBar.Text = "&Juice Bar";
            this.rdoJuiceBar.UseVisualStyleBackColor = true;
            // 
            // rdoMembership
            // 
            this.rdoMembership.AutoSize = true;
            this.rdoMembership.Location = new System.Drawing.Point(19, 116);
            this.rdoMembership.Name = "rdoMembership";
            this.rdoMembership.Size = new System.Drawing.Size(106, 21);
            this.rdoMembership.TabIndex = 3;
            this.rdoMembership.TabStop = true;
            this.rdoMembership.Text = "&Membership";
            this.rdoMembership.UseVisualStyleBackColor = true;
            // 
            // rdoTraining
            // 
            this.rdoTraining.AutoSize = true;
            this.rdoTraining.Location = new System.Drawing.Point(19, 143);
            this.rdoTraining.Name = "rdoTraining";
            this.rdoTraining.Size = new System.Drawing.Size(141, 21);
            this.rdoTraining.TabIndex = 4;
            this.rdoTraining.TabStop = true;
            this.rdoTraining.Text = "Personal &Training";
            this.rdoTraining.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "&Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Member &ID";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(398, 121);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(245, 22);
            this.txtName.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtName, "Enter your name");
            // 
            // mtbMemberId
            // 
            this.mtbMemberId.Location = new System.Drawing.Point(398, 160);
            this.mtbMemberId.Mask = "00000";
            this.mtbMemberId.Name = "mtbMemberId";
            this.mtbMemberId.Size = new System.Drawing.Size(45, 22);
            this.mtbMemberId.TabIndex = 7;
            this.mtbMemberId.ValidatingType = typeof(int);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(538, 312);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(96, 30);
            this.btnSignIn.TabIndex = 8;
            this.btnSignIn.Text = "&Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(538, 350);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(96, 30);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "&Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(538, 388);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 30);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(538, 426);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 30);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // chbImageVisible
            // 
            this.chbImageVisible.AutoSize = true;
            this.chbImageVisible.Location = new System.Drawing.Point(26, 473);
            this.chbImageVisible.Name = "chbImageVisible";
            this.chbImageVisible.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chbImageVisible.Size = new System.Drawing.Size(113, 21);
            this.chbImageVisible.TabIndex = 12;
            this.chbImageVisible.Text = "Image &Visible";
            this.chbImageVisible.UseVisualStyleBackColor = true;
            // 
            // pcbDepartment
            // 
            this.pcbDepartment.Location = new System.Drawing.Point(26, 330);
            this.pcbDepartment.Name = "pcbDepartment";
            this.pcbDepartment.Size = new System.Drawing.Size(233, 126);
            this.pcbDepartment.TabIndex = 13;
            this.pcbDepartment.TabStop = false;
            // 
            // frmPromotions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 499);
            this.Controls.Add(this.pcbDepartment);
            this.Controls.Add(this.chbImageVisible);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.mtbMemberId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grpDepartment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPromotions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promotions";
            this.grpDepartment.ResumeLayout(false);
            this.grpDepartment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDepartment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.GroupBox grpDepartment;
        private System.Windows.Forms.RadioButton rdoTraining;
        private System.Windows.Forms.RadioButton rdoMembership;
        private System.Windows.Forms.RadioButton rdoJuiceBar;
        private System.Windows.Forms.RadioButton rdoEquipment;
        private System.Windows.Forms.RadioButton rdoClothing;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MaskedTextBox mtbMemberId;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox chbImageVisible;
        private System.Windows.Forms.PictureBox pcbDepartment;
    }
}

