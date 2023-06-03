
namespace CatchGraphPlan
{
    partial class FormCaptyrePlanUpdate
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
            this.BTNUpdate = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.mynicipality = new System.Windows.Forms.ComboBox();
            this.BTNBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNUpdate
            // 
            this.BTNUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTNUpdate.Location = new System.Drawing.Point(109, 161);
            this.BTNUpdate.Name = "BTNUpdate";
            this.BTNUpdate.Size = new System.Drawing.Size(123, 30);
            this.BTNUpdate.TabIndex = 5;
            this.BTNUpdate.Text = "Обновить";
            this.BTNUpdate.UseVisualStyleBackColor = true;
            this.BTNUpdate.Click += new System.EventHandler(this.BTNUpdate_Click);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(75, 41);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 20);
            this.date.TabIndex = 4;
            // 
            // mynicipality
            // 
            this.mynicipality.FormattingEnabled = true;
            this.mynicipality.Location = new System.Drawing.Point(75, 96);
            this.mynicipality.Name = "mynicipality";
            this.mynicipality.Size = new System.Drawing.Size(200, 21);
            this.mynicipality.TabIndex = 3;
            // 
            // BTNBack
            // 
            this.BTNBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTNBack.Location = new System.Drawing.Point(109, 161);
            this.BTNBack.Name = "BTNBack";
            this.BTNBack.Size = new System.Drawing.Size(123, 30);
            this.BTNBack.TabIndex = 6;
            this.BTNBack.Text = "Вернуться";
            this.BTNBack.UseVisualStyleBackColor = true;
            this.BTNBack.Click += new System.EventHandler(this.BTNBack_Click);
            // 
            // FormCaptyrePlanUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 241);
            this.Controls.Add(this.BTNBack);
            this.Controls.Add(this.BTNUpdate);
            this.Controls.Add(this.date);
            this.Controls.Add(this.mynicipality);
            this.Name = "FormCaptyrePlanUpdate";
            this.Text = "Изменить план-график";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNUpdate;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.ComboBox mynicipality;
        private System.Windows.Forms.Button BTNBack;
    }
}