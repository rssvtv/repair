namespace repair
{
    partial class WorkerForm
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
            this.listBoxApplications = new System.Windows.Forms.ListBox();
            this.txtApplicationNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSpecialistName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerAssignmentDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAssignSpecialist = new System.Windows.Forms.Button();
            this.btnUpdateData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxApplications
            // 
            this.listBoxApplications.FormattingEnabled = true;
            this.listBoxApplications.ItemHeight = 16;
            this.listBoxApplications.Location = new System.Drawing.Point(50, 51);
            this.listBoxApplications.Name = "listBoxApplications";
            this.listBoxApplications.Size = new System.Drawing.Size(783, 180);
            this.listBoxApplications.TabIndex = 0;
            // 
            // txtApplicationNumber
            // 
            this.txtApplicationNumber.Location = new System.Drawing.Point(63, 269);
            this.txtApplicationNumber.Name = "txtApplicationNumber";
            this.txtApplicationNumber.Size = new System.Drawing.Size(100, 22);
            this.txtApplicationNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Номер заявки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(43, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Заявки";
            // 
            // txtSpecialistName
            // 
            this.txtSpecialistName.Location = new System.Drawing.Point(219, 269);
            this.txtSpecialistName.Name = "txtSpecialistName";
            this.txtSpecialistName.Size = new System.Drawing.Size(129, 22);
            this.txtSpecialistName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Специалист";
            // 
            // dateTimePickerAssignmentDate
            // 
            this.dateTimePickerAssignmentDate.Location = new System.Drawing.Point(405, 269);
            this.dateTimePickerAssignmentDate.Name = "dateTimePickerAssignmentDate";
            this.dateTimePickerAssignmentDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerAssignmentDate.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(460, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Дата";
            // 
            // btnAssignSpecialist
            // 
            this.btnAssignSpecialist.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAssignSpecialist.Location = new System.Drawing.Point(223, 307);
            this.btnAssignSpecialist.Name = "btnAssignSpecialist";
            this.btnAssignSpecialist.Size = new System.Drawing.Size(104, 31);
            this.btnAssignSpecialist.TabIndex = 8;
            this.btnAssignSpecialist.Text = "Назначить";
            this.btnAssignSpecialist.UseVisualStyleBackColor = false;
            this.btnAssignSpecialist.Click += new System.EventHandler(this.btnAssignSpecialist_Click);
            // 
            // btnUpdateData
            // 
            this.btnUpdateData.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnUpdateData.Location = new System.Drawing.Point(740, 269);
            this.btnUpdateData.Name = "btnUpdateData";
            this.btnUpdateData.Size = new System.Drawing.Size(93, 35);
            this.btnUpdateData.TabIndex = 9;
            this.btnUpdateData.Text = "Обновить ";
            this.btnUpdateData.UseVisualStyleBackColor = false;
            this.btnUpdateData.Click += new System.EventHandler(this.btnUpdateData_Click);
            // 
            // WorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(892, 533);
            this.Controls.Add(this.btnUpdateData);
            this.Controls.Add(this.btnAssignSpecialist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerAssignmentDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSpecialistName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApplicationNumber);
            this.Controls.Add(this.listBoxApplications);
            this.Name = "WorkerForm";
            this.Text = "WorkerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxApplications;
        private System.Windows.Forms.TextBox txtApplicationNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSpecialistName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerAssignmentDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAssignSpecialist;
        private System.Windows.Forms.Button btnUpdateData;
    }
}