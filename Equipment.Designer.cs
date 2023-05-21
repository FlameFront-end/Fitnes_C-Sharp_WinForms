namespace Fitnes
{
    partial class Equipment
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
            this.txtEquipName = new System.Windows.Forms.Label();
            this.sdf = new System.Windows.Forms.Label();
            this.fsdf = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEqName = new System.Windows.Forms.TextBox();
            this.txtMusclesUsed = new System.Windows.Forms.TextBox();
            this.txtDescr = new System.Windows.Forms.RichTextBox();
            this.dateTimeDate = new System.Windows.Forms.DateTimePicker();
            this.txtGost = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.txtQquipName_label = new System.Windows.Forms.Label();
            this.txtGost_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEquipName
            // 
            this.txtEquipName.Location = new System.Drawing.Point(0, 0);
            this.txtEquipName.Name = "txtEquipName";
            this.txtEquipName.Size = new System.Drawing.Size(100, 23);
            this.txtEquipName.TabIndex = 14;
            // 
            // sdf
            // 
            this.sdf.AutoSize = true;
            this.sdf.Location = new System.Drawing.Point(164, 127);
            this.sdf.Name = "sdf";
            this.sdf.Size = new System.Drawing.Size(72, 16);
            this.sdf.TabIndex = 1;
            this.sdf.Text = "Описание";
            // 
            // fsdf
            // 
            this.fsdf.AutoSize = true;
            this.fsdf.Location = new System.Drawing.Point(84, 272);
            this.fsdf.Name = "fsdf";
            this.fsdf.Size = new System.Drawing.Size(152, 16);
            this.fsdf.TabIndex = 2;
            this.fsdf.Text = "Используемые мышцы";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(129, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Дата доставки";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 13;
            // 
            // txtEqName
            // 
            this.txtEqName.Location = new System.Drawing.Point(253, 70);
            this.txtEqName.Name = "txtEqName";
            this.txtEqName.Size = new System.Drawing.Size(234, 22);
            this.txtEqName.TabIndex = 5;
            // 
            // txtMusclesUsed
            // 
            this.txtMusclesUsed.Location = new System.Drawing.Point(253, 272);
            this.txtMusclesUsed.Name = "txtMusclesUsed";
            this.txtMusclesUsed.Size = new System.Drawing.Size(200, 22);
            this.txtMusclesUsed.TabIndex = 6;
            // 
            // txtDescr
            // 
            this.txtDescr.Location = new System.Drawing.Point(253, 124);
            this.txtDescr.Name = "txtDescr";
            this.txtDescr.Size = new System.Drawing.Size(234, 109);
            this.txtDescr.TabIndex = 7;
            this.txtDescr.Text = "";
            // 
            // dateTimeDate
            // 
            this.dateTimeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDate.Location = new System.Drawing.Point(253, 319);
            this.dateTimeDate.Name = "dateTimeDate";
            this.dateTimeDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimeDate.TabIndex = 8;
            // 
            // txtGost
            // 
            this.txtGost.Location = new System.Drawing.Point(253, 358);
            this.txtGost.Name = "txtGost";
            this.txtGost.Size = new System.Drawing.Size(200, 22);
            this.txtGost.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(118, 405);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(136, 43);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(260, 405);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(136, 43);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Сбросить";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(402, 405);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(151, 43);
            this.btnView.TabIndex = 12;
            this.btnView.Text = "Посмотреть оборудование";
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // txtQquipName_label
            // 
            this.txtQquipName_label.AutoSize = true;
            this.txtQquipName_label.Location = new System.Drawing.Point(65, 70);
            this.txtQquipName_label.Name = "txtQquipName_label";
            this.txtQquipName_label.Size = new System.Drawing.Size(171, 16);
            this.txtQquipName_label.TabIndex = 16;
            this.txtQquipName_label.Text = "Название оборудования";
            // 
            // txtGost_label
            // 
            this.txtGost_label.Location = new System.Drawing.Point(189, 361);
            this.txtGost_label.Name = "txtGost_label";
            this.txtGost_label.Size = new System.Drawing.Size(47, 19);
            this.txtGost_label.TabIndex = 17;
            this.txtGost_label.Text = "Цена";
            // 
            // Equipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 503);
            this.Controls.Add(this.txtGost_label);
            this.Controls.Add(this.txtQquipName_label);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtGost);
            this.Controls.Add(this.dateTimeDate);
            this.Controls.Add(this.txtDescr);
            this.Controls.Add(this.txtMusclesUsed);
            this.Controls.Add(this.txtEqName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fsdf);
            this.Controls.Add(this.sdf);
            this.Controls.Add(this.txtEquipName);
            this.Name = "Equipment";
            this.Text = "Equipment";
            this.Load += new System.EventHandler(this.Equipment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtEquipName;
        private System.Windows.Forms.Label sdf;
        private System.Windows.Forms.Label fsdf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEqName;
        private System.Windows.Forms.TextBox txtMusclesUsed;
        private System.Windows.Forms.RichTextBox txtDescr;
        private System.Windows.Forms.DateTimePicker dateTimeDate;
        private System.Windows.Forms.TextBox txtGost;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label txtQquipName_label;
        private System.Windows.Forms.Label txtGost_label;
    }
}