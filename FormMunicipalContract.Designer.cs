
namespace CatchGraphPlan
{
    partial class FormMunicipalContract
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BTNExportExcel = new System.Windows.Forms.Button();
            this.BTNUpdate = new System.Windows.Forms.Button();
            this.BTNDelete = new System.Windows.Forms.Button();
            this.BTNAdd = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.реестрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.реестрПлановГрафиковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.реестрАктовОтловаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.карточкаОтловленногоЖивотногоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.реестрОрганизацийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.реестрМуниципальныхКонтрактовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sign_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractor_company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(152, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Сортировка";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Фильтры";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(156, 89);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 43;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(10, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 42;
            // 
            // BTNExportExcel
            // 
            this.BTNExportExcel.Location = new System.Drawing.Point(351, 27);
            this.BTNExportExcel.Name = "BTNExportExcel";
            this.BTNExportExcel.Size = new System.Drawing.Size(102, 28);
            this.BTNExportExcel.TabIndex = 41;
            this.BTNExportExcel.Text = "Экспорт Excel";
            this.BTNExportExcel.UseVisualStyleBackColor = true;
            // 
            // BTNUpdate
            // 
            this.BTNUpdate.Location = new System.Drawing.Point(192, 27);
            this.BTNUpdate.Name = "BTNUpdate";
            this.BTNUpdate.Size = new System.Drawing.Size(85, 28);
            this.BTNUpdate.TabIndex = 40;
            this.BTNUpdate.Text = "Изменить";
            this.BTNUpdate.UseVisualStyleBackColor = true;
            this.BTNUpdate.Click += new System.EventHandler(this.BTNUpdate_Click);
            // 
            // BTNDelete
            // 
            this.BTNDelete.Location = new System.Drawing.Point(101, 27);
            this.BTNDelete.Name = "BTNDelete";
            this.BTNDelete.Size = new System.Drawing.Size(85, 28);
            this.BTNDelete.TabIndex = 39;
            this.BTNDelete.Text = "Удалить";
            this.BTNDelete.UseVisualStyleBackColor = true;
            // 
            // BTNAdd
            // 
            this.BTNAdd.Location = new System.Drawing.Point(10, 27);
            this.BTNAdd.Name = "BTNAdd";
            this.BTNAdd.Size = new System.Drawing.Size(85, 28);
            this.BTNAdd.TabIndex = 38;
            this.BTNAdd.Text = "Добавить";
            this.BTNAdd.UseVisualStyleBackColor = true;
            this.BTNAdd.Click += new System.EventHandler(this.BTNAdd_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.реестрыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(543, 24);
            this.menuStrip1.TabIndex = 37;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // реестрыToolStripMenuItem
            // 
            this.реестрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.реестрПлановГрафиковToolStripMenuItem,
            this.реестрАктовОтловаToolStripMenuItem,
            this.карточкаОтловленногоЖивотногоToolStripMenuItem,
            this.реестрОрганизацийToolStripMenuItem,
            this.реестрМуниципальныхКонтрактовToolStripMenuItem});
            this.реестрыToolStripMenuItem.Name = "реестрыToolStripMenuItem";
            this.реестрыToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.реестрыToolStripMenuItem.Text = "Реестры";
            // 
            // реестрПлановГрафиковToolStripMenuItem
            // 
            this.реестрПлановГрафиковToolStripMenuItem.Name = "реестрПлановГрафиковToolStripMenuItem";
            this.реестрПлановГрафиковToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.реестрПлановГрафиковToolStripMenuItem.Text = "Реестр планов - графиков";
            this.реестрПлановГрафиковToolStripMenuItem.Click += new System.EventHandler(this.реестрПлановГрафиковToolStripMenuItem_Click);
            // 
            // реестрАктовОтловаToolStripMenuItem
            // 
            this.реестрАктовОтловаToolStripMenuItem.Name = "реестрАктовОтловаToolStripMenuItem";
            this.реестрАктовОтловаToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.реестрАктовОтловаToolStripMenuItem.Text = "Реестр актов - отлова";
            this.реестрАктовОтловаToolStripMenuItem.Click += new System.EventHandler(this.реестрАктовОтловаToolStripMenuItem_Click);
            // 
            // карточкаОтловленногоЖивотногоToolStripMenuItem
            // 
            this.карточкаОтловленногоЖивотногоToolStripMenuItem.Name = "карточкаОтловленногоЖивотногоToolStripMenuItem";
            this.карточкаОтловленногоЖивотногоToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.карточкаОтловленногоЖивотногоToolStripMenuItem.Text = "Карточка отловленного животного";
            this.карточкаОтловленногоЖивотногоToolStripMenuItem.Click += new System.EventHandler(this.карточкаОтловленногоЖивотногоToolStripMenuItem_Click);
            // 
            // реестрОрганизацийToolStripMenuItem
            // 
            this.реестрОрганизацийToolStripMenuItem.Name = "реестрОрганизацийToolStripMenuItem";
            this.реестрОрганизацийToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.реестрОрганизацийToolStripMenuItem.Text = "Реестр организаций";
            this.реестрОрганизацийToolStripMenuItem.Click += new System.EventHandler(this.реестрОрганизацийToolStripMenuItem_Click);
            // 
            // реестрМуниципальныхКонтрактовToolStripMenuItem
            // 
            this.реестрМуниципальныхКонтрактовToolStripMenuItem.Name = "реестрМуниципальныхКонтрактовToolStripMenuItem";
            this.реестрМуниципальныхКонтрактовToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.реестрМуниципальныхКонтрактовToolStripMenuItem.Text = "Реестр муниципальных контрактов";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.sign_date,
            this.action_date,
            this.contractor_company,
            this.customer});
            this.dataGridView1.Location = new System.Drawing.Point(0, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 215);
            this.dataGridView1.TabIndex = 46;
            // 
            // Number
            // 
            this.Number.HeaderText = "Номер";
            this.Number.Name = "Number";
            // 
            // sign_date
            // 
            this.sign_date.HeaderText = "Дата заключения";
            this.sign_date.Name = "sign_date";
            this.sign_date.ReadOnly = true;
            // 
            // action_date
            // 
            this.action_date.HeaderText = "Дата действия";
            this.action_date.Name = "action_date";
            this.action_date.ReadOnly = true;
            // 
            // contractor_company
            // 
            this.contractor_company.HeaderText = "Исполнитель";
            this.contractor_company.Name = "contractor_company";
            this.contractor_company.ReadOnly = true;
            // 
            // customer
            // 
            this.customer.HeaderText = "Заказчик";
            this.customer.Name = "customer";
            this.customer.ReadOnly = true;
            // 
            // FormMunicipalContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 331);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BTNExportExcel);
            this.Controls.Add(this.BTNUpdate);
            this.Controls.Add(this.BTNDelete);
            this.Controls.Add(this.BTNAdd);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormMunicipalContract";
            this.Text = "Реестр муниципальных контрактов";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button BTNExportExcel;
        private System.Windows.Forms.Button BTNUpdate;
        private System.Windows.Forms.Button BTNDelete;
        private System.Windows.Forms.Button BTNAdd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem реестрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem реестрПлановГрафиковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem реестрАктовОтловаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem карточкаОтловленногоЖивотногоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem реестрОрганизацийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem реестрМуниципальныхКонтрактовToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn sign_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn action_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractor_company;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer;
    }
}