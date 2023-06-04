
namespace CatchGraphPlan
{
    partial class FormMunicipalContractUpdate
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
            this.action_date = new System.Windows.Forms.DateTimePicker();
            this.sign_date = new System.Windows.Forms.DateTimePicker();
            this.BTNUpdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.customer = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.contractor_company = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // action_date
            // 
            this.action_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.action_date.Location = new System.Drawing.Point(236, 24);
            this.action_date.Name = "action_date";
            this.action_date.Size = new System.Drawing.Size(200, 22);
            this.action_date.TabIndex = 64;
            // 
            // sign_date
            // 
            this.sign_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sign_date.Location = new System.Drawing.Point(5, 24);
            this.sign_date.Name = "sign_date";
            this.sign_date.Size = new System.Drawing.Size(200, 22);
            this.sign_date.TabIndex = 63;
            // 
            // BTNUpdate
            // 
            this.BTNUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTNUpdate.Location = new System.Drawing.Point(171, 117);
            this.BTNUpdate.Name = "BTNUpdate";
            this.BTNUpdate.Size = new System.Drawing.Size(98, 30);
            this.BTNUpdate.TabIndex = 62;
            this.BTNUpdate.Text = "Обновить";
            this.BTNUpdate.UseVisualStyleBackColor = true;
            this.BTNUpdate.Click += new System.EventHandler(this.BTNAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(233, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 61;
            this.label6.Text = "Заказчик";
            // 
            // customer
            // 
            this.customer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customer.Location = new System.Drawing.Point(234, 75);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(202, 24);
            this.customer.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(4, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 59;
            this.label5.Text = "Исполнитель";
            // 
            // contractor_company
            // 
            this.contractor_company.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.contractor_company.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contractor_company.Location = new System.Drawing.Point(7, 75);
            this.contractor_company.Name = "contractor_company";
            this.contractor_company.Size = new System.Drawing.Size(198, 24);
            this.contractor_company.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(233, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 56;
            this.label2.Text = "Дата действия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(2, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 55;
            this.label1.Text = "Дата Заключения";
            // 
            // BTNBack
            // 
            this.BTNBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTNBack.Location = new System.Drawing.Point(171, 117);
            this.BTNBack.Name = "BTNBack";
            this.BTNBack.Size = new System.Drawing.Size(98, 30);
            this.BTNBack.TabIndex = 65;
            this.BTNBack.Text = "Назад";
            this.BTNBack.UseVisualStyleBackColor = true;
            this.BTNBack.Click += new System.EventHandler(this.BTNBack_Click);
            // 
            // FormMunicipalContractUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 159);
            this.Controls.Add(this.BTNBack);
            this.Controls.Add(this.action_date);
            this.Controls.Add(this.sign_date);
            this.Controls.Add(this.BTNUpdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.contractor_company);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMunicipalContractUpdate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker action_date;
        private System.Windows.Forms.DateTimePicker sign_date;
        private System.Windows.Forms.Button BTNUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox customer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox contractor_company;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNBack;
    }
}