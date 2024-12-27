namespace repair
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtApplicationNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProblemDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxEquipmentType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContactInfo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.btnAddApplication = new System.Windows.Forms.Button();
            this.btnViewStatus = new System.Windows.Forms.Button();
            this.btnLeaveFeedback = new System.Windows.Forms.Button();
            this.listBoxStatus = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFeedback = new System.Windows.Forms.TextBox();
            this.btnOpenWorkerForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер заявки";
            // 
            // txtApplicationNumber
            // 
            this.txtApplicationNumber.Location = new System.Drawing.Point(27, 38);
            this.txtApplicationNumber.Name = "txtApplicationNumber";
            this.txtApplicationNumber.Size = new System.Drawing.Size(113, 22);
            this.txtApplicationNumber.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата заявки";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(179, 38);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(153, 22);
            this.dateTimePicker.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Описание проблемы";
            // 
            // txtProblemDescription
            // 
            this.txtProblemDescription.Location = new System.Drawing.Point(357, 38);
            this.txtProblemDescription.Name = "txtProblemDescription";
            this.txtProblemDescription.Size = new System.Drawing.Size(153, 22);
            this.txtProblemDescription.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(533, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Устройство";
            // 
            // comboBoxEquipmentType
            // 
            this.comboBoxEquipmentType.FormattingEnabled = true;
            this.comboBoxEquipmentType.Location = new System.Drawing.Point(525, 36);
            this.comboBoxEquipmentType.Name = "comboBoxEquipmentType";
            this.comboBoxEquipmentType.Size = new System.Drawing.Size(121, 24);
            this.comboBoxEquipmentType.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(656, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Контактные данные";
            // 
            // txtContactInfo
            // 
            this.txtContactInfo.Location = new System.Drawing.Point(659, 38);
            this.txtContactInfo.Name = "txtContactInfo";
            this.txtContactInfo.Size = new System.Drawing.Size(121, 22);
            this.txtContactInfo.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(816, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Тип поломки";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(802, 36);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 24);
            this.comboBoxType.TabIndex = 11;
            // 
            // btnAddApplication
            // 
            this.btnAddApplication.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAddApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddApplication.Location = new System.Drawing.Point(179, 85);
            this.btnAddApplication.Name = "btnAddApplication";
            this.btnAddApplication.Size = new System.Drawing.Size(109, 56);
            this.btnAddApplication.TabIndex = 0;
            this.btnAddApplication.Text = "Добавить заявку";
            this.btnAddApplication.UseVisualStyleBackColor = false;
            this.btnAddApplication.Click += new System.EventHandler(this.btnAddApplication_Click);
            // 
            // btnViewStatus
            // 
            this.btnViewStatus.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnViewStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnViewStatus.Location = new System.Drawing.Point(659, 85);
            this.btnViewStatus.Name = "btnViewStatus";
            this.btnViewStatus.Size = new System.Drawing.Size(119, 56);
            this.btnViewStatus.TabIndex = 12;
            this.btnViewStatus.Text = "Посмотреть статус";
            this.btnViewStatus.UseVisualStyleBackColor = false;
            this.btnViewStatus.Click += new System.EventHandler(this.btnViewStatus_Click);
            // 
            // btnLeaveFeedback
            // 
            this.btnLeaveFeedback.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnLeaveFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLeaveFeedback.Location = new System.Drawing.Point(767, 453);
            this.btnLeaveFeedback.Name = "btnLeaveFeedback";
            this.btnLeaveFeedback.Size = new System.Drawing.Size(124, 58);
            this.btnLeaveFeedback.TabIndex = 13;
            this.btnLeaveFeedback.Text = "Добавить отзыв";
            this.btnLeaveFeedback.UseVisualStyleBackColor = false;
            this.btnLeaveFeedback.Click += new System.EventHandler(this.btnLeaveFeedback_Click);
            // 
            // listBoxStatus
            // 
            this.listBoxStatus.FormattingEnabled = true;
            this.listBoxStatus.ItemHeight = 16;
            this.listBoxStatus.Location = new System.Drawing.Point(27, 160);
            this.listBoxStatus.Name = "listBoxStatus";
            this.listBoxStatus.Size = new System.Drawing.Size(896, 164);
            this.listBoxStatus.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(22, 466);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "Добавить отзыв";
            // 
            // txtFeedback
            // 
            this.txtFeedback.Location = new System.Drawing.Point(27, 498);
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.Size = new System.Drawing.Size(236, 22);
            this.txtFeedback.TabIndex = 16;
            // 
            // btnOpenWorkerForm
            // 
            this.btnOpenWorkerForm.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnOpenWorkerForm.Location = new System.Drawing.Point(867, 560);
            this.btnOpenWorkerForm.Name = "btnOpenWorkerForm";
            this.btnOpenWorkerForm.Size = new System.Drawing.Size(75, 23);
            this.btnOpenWorkerForm.TabIndex = 17;
            this.btnOpenWorkerForm.Text = "Работник";
            this.btnOpenWorkerForm.UseVisualStyleBackColor = true;
            this.btnOpenWorkerForm.Click += new System.EventHandler(this.btnOpenWorkerForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(935, 576);
            this.Controls.Add(this.btnOpenWorkerForm);
            this.Controls.Add(this.txtFeedback);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBoxStatus);
            this.Controls.Add(this.btnLeaveFeedback);
            this.Controls.Add(this.btnViewStatus);
            this.Controls.Add(this.btnAddApplication);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtContactInfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxEquipmentType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProblemDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtApplicationNumber);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApplicationNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProblemDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxEquipmentType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtContactInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button btnAddApplication;
        private System.Windows.Forms.Button btnViewStatus;
        private System.Windows.Forms.Button btnLeaveFeedback;
        private System.Windows.Forms.ListBox listBoxStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFeedback;
        private System.Windows.Forms.Button btnOpenWorkerForm;
    }
}