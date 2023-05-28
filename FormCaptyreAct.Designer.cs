
namespace CatchGraphPlan
{
    partial class FormCaptyreAct
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
            this.карточкиОтловленныхЖивотныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.реестрОрганизацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.реестрМуниципальныхКонтрактовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.number_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogs_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cats_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animals_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.captyre_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.captyre_goal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mynicipality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mynicipal_contract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(154, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Сортировка";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Фильтры";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(158, 89);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 30;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 29;
            // 
            // BTNExportExcel
            // 
            this.BTNExportExcel.Location = new System.Drawing.Point(353, 27);
            this.BTNExportExcel.Name = "BTNExportExcel";
            this.BTNExportExcel.Size = new System.Drawing.Size(102, 28);
            this.BTNExportExcel.TabIndex = 28;
            this.BTNExportExcel.Text = "Экспорт Excel";
            this.BTNExportExcel.UseVisualStyleBackColor = true;
            // 
            // BTNUpdate
            // 
            this.BTNUpdate.Location = new System.Drawing.Point(194, 27);
            this.BTNUpdate.Name = "BTNUpdate";
            this.BTNUpdate.Size = new System.Drawing.Size(85, 28);
            this.BTNUpdate.TabIndex = 27;
            this.BTNUpdate.Text = "Изменить";
            this.BTNUpdate.UseVisualStyleBackColor = true;
            this.BTNUpdate.Click += new System.EventHandler(this.BTNUpdate_Click);
            // 
            // BTNDelete
            // 
            this.BTNDelete.Location = new System.Drawing.Point(103, 27);
            this.BTNDelete.Name = "BTNDelete";
            this.BTNDelete.Size = new System.Drawing.Size(85, 28);
            this.BTNDelete.TabIndex = 26;
            this.BTNDelete.Text = "Удалить";
            this.BTNDelete.UseVisualStyleBackColor = true;
            // 
            // BTNAdd
            // 
            this.BTNAdd.Location = new System.Drawing.Point(12, 27);
            this.BTNAdd.Name = "BTNAdd";
            this.BTNAdd.Size = new System.Drawing.Size(85, 28);
            this.BTNAdd.TabIndex = 25;
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
            this.menuStrip1.Size = new System.Drawing.Size(1020, 24);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // реестрыToolStripMenuItem
            // 
            this.реестрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.реестрПлановГрафиковToolStripMenuItem,
            this.реестрАктовОтловаToolStripMenuItem,
            this.карточкиОтловленныхЖивотныхToolStripMenuItem,
            this.реестрОрганизацияToolStripMenuItem,
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
            // 
            // карточкиОтловленныхЖивотныхToolStripMenuItem
            // 
            this.карточкиОтловленныхЖивотныхToolStripMenuItem.Name = "карточкиОтловленныхЖивотныхToolStripMenuItem";
            this.карточкиОтловленныхЖивотныхToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.карточкиОтловленныхЖивотныхToolStripMenuItem.Text = "карточка отловленного животного";
            this.карточкиОтловленныхЖивотныхToolStripMenuItem.Click += new System.EventHandler(this.карточкиОтловленныхЖивотныхToolStripMenuItem_Click);
            // 
            // реестрОрганизацияToolStripMenuItem
            // 
            this.реестрОрганизацияToolStripMenuItem.Name = "реестрОрганизацияToolStripMenuItem";
            this.реестрОрганизацияToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.реестрОрганизацияToolStripMenuItem.Text = "Реестр организация";
            this.реестрОрганизацияToolStripMenuItem.Click += new System.EventHandler(this.реестрОрганизацияToolStripMenuItem_Click);
            // 
            // реестрМуниципальныхКонтрактовToolStripMenuItem
            // 
            this.реестрМуниципальныхКонтрактовToolStripMenuItem.Name = "реестрМуниципальныхКонтрактовToolStripMenuItem";
            this.реестрМуниципальныхКонтрактовToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.реестрМуниципальныхКонтрактовToolStripMenuItem.Text = "Реестр муниципальных контрактов";
            this.реестрМуниципальныхКонтрактовToolStripMenuItem.Click += new System.EventHandler(this.реестрМуниципальныхКонтрактовToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number_id,
            this.dogs_count,
            this.cats_count,
            this.animals_count,
            this.company,
            this.captyre_date,
            this.captyre_goal,
            this.mynicipality,
            this.mynicipal_contract});
            this.dataGridView1.Location = new System.Drawing.Point(0, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1020, 311);
            this.dataGridView1.TabIndex = 34;
            // 
            // number_id
            // 
            this.number_id.Frozen = true;
            this.number_id.HeaderText = "Номер акта отлова";
            this.number_id.Name = "number_id";
            this.number_id.ReadOnly = true;
            // 
            // dogs_count
            // 
            this.dogs_count.Frozen = true;
            this.dogs_count.HeaderText = "Колличество собак";
            this.dogs_count.Name = "dogs_count";
            this.dogs_count.ReadOnly = true;
            // 
            // cats_count
            // 
            this.cats_count.Frozen = true;
            this.cats_count.HeaderText = "Колличество кошек";
            this.cats_count.Name = "cats_count";
            this.cats_count.ReadOnly = true;
            // 
            // animals_count
            // 
            this.animals_count.Frozen = true;
            this.animals_count.HeaderText = "Колличество животных";
            this.animals_count.Name = "animals_count";
            this.animals_count.ReadOnly = true;
            // 
            // company
            // 
            this.company.Frozen = true;
            this.company.HeaderText = "Организация";
            this.company.Name = "company";
            this.company.ReadOnly = true;
            // 
            // captyre_date
            // 
            this.captyre_date.Frozen = true;
            this.captyre_date.HeaderText = "Дата отлова";
            this.captyre_date.Name = "captyre_date";
            this.captyre_date.ReadOnly = true;
            // 
            // captyre_goal
            // 
            this.captyre_goal.Frozen = true;
            this.captyre_goal.HeaderText = "Цель отлова";
            this.captyre_goal.Name = "captyre_goal";
            this.captyre_goal.ReadOnly = true;
            // 
            // mynicipality
            // 
            this.mynicipality.Frozen = true;
            this.mynicipality.HeaderText = "Заявка на отлов";
            this.mynicipality.Name = "mynicipality";
            this.mynicipality.ReadOnly = true;
            // 
            // mynicipal_contract
            // 
            this.mynicipal_contract.Frozen = true;
            this.mynicipal_contract.HeaderText = "Муниципиальный контракт";
            this.mynicipal_contract.Name = "mynicipal_contract";
            this.mynicipal_contract.ReadOnly = true;
            this.mynicipal_contract.Width = 180;
            // 
            // FormCaptyreAct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BTNExportExcel);
            this.Controls.Add(this.BTNUpdate);
            this.Controls.Add(this.BTNDelete);
            this.Controls.Add(this.BTNAdd);
            this.Name = "FormCaptyreAct";
            this.Text = "Реестр актов - отлова";
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn number_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogs_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn cats_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn animals_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn company;
        private System.Windows.Forms.DataGridViewTextBoxColumn captyre_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn captyre_goal;
        private System.Windows.Forms.DataGridViewTextBoxColumn mynicipality;
        private System.Windows.Forms.DataGridViewTextBoxColumn mynicipal_contract;
        private System.Windows.Forms.ToolStripMenuItem карточкиОтловленныхЖивотныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem реестрОрганизацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem реестрМуниципальныхКонтрактовToolStripMenuItem;
    }
}