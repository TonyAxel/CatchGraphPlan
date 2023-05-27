
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
            this.BTNAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.customer = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.contractor_company = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // action_date
            // 
            this.action_date.Location = new System.Drawing.Point(236, 24);
            this.action_date.Name = "action_date";
            this.action_date.Size = new System.Drawing.Size(200, 20);
            this.action_date.TabIndex = 64;
            // 
            // sign_date
            // 
            this.sign_date.Location = new System.Drawing.Point(5, 24);
            this.sign_date.Name = "sign_date";
            this.sign_date.Size = new System.Drawing.Size(200, 20);
            this.sign_date.TabIndex = 63;
            // 
            // BTNAdd
            // 
            this.BTNAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTNAdd.Location = new System.Drawing.Point(159, 118);
            this.BTNAdd.Name = "BTNAdd";
            this.BTNAdd.Size = new System.Drawing.Size(98, 30);
            this.BTNAdd.TabIndex = 62;
            this.BTNAdd.Text = "Обновить";
            this.BTNAdd.UseVisualStyleBackColor = true;
            this.BTNAdd.Click += new System.EventHandler(this.BTNAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(233, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 61;
            this.label6.Text = "Заказчик";
            // 
            // customer
            // 
            this.customer.FormattingEnabled = true;
            this.customer.Location = new System.Drawing.Point(234, 75);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(122, 21);
            this.customer.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(4, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 59;
            this.label5.Text = "Исполнитель";
            // 
            // contractor_company
            // 
            this.contractor_company.FormattingEnabled = true;
            this.contractor_company.Location = new System.Drawing.Point(7, 75);
            this.contractor_company.Name = "contractor_company";
            this.contractor_company.Size = new System.Drawing.Size(122, 21);
            this.contractor_company.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(233, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 56;
            this.label2.Text = "Дата действия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(2, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 55;
            this.label1.Text = "Дата Заключения";
            // 
            // FormMunicipalContractUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 159);
            this.Controls.Add(this.action_date);
            this.Controls.Add(this.sign_date);
            this.Controls.Add(this.BTNAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.contractor_company);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMunicipalContractUpdate";
            this.Text = "Изменить муниципальный контракт";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker action_date;
        private System.Windows.Forms.DateTimePicker sign_date;
        private System.Windows.Forms.Button BTNAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox customer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox contractor_company;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}