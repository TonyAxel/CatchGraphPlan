
namespace CatchGraphPlan
{
    partial class FormCapturePlan
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mynicipality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(157, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Сортировка";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Фильтры";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(161, 89);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 22;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 21;
            // 
            // BTNExportExcel
            // 
            this.BTNExportExcel.Location = new System.Drawing.Point(356, 27);
            this.BTNExportExcel.Name = "BTNExportExcel";
            this.BTNExportExcel.Size = new System.Drawing.Size(102, 28);
            this.BTNExportExcel.TabIndex = 20;
            this.BTNExportExcel.Text = "Экспорт Excel";
            this.BTNExportExcel.UseVisualStyleBackColor = true;
            // 
            // BTNUpdate
            // 
            this.BTNUpdate.Location = new System.Drawing.Point(197, 27);
            this.BTNUpdate.Name = "BTNUpdate";
            this.BTNUpdate.Size = new System.Drawing.Size(85, 28);
            this.BTNUpdate.TabIndex = 19;
            this.BTNUpdate.Text = "Изменить";
            this.BTNUpdate.UseVisualStyleBackColor = true;
            this.BTNUpdate.Click += new System.EventHandler(this.BTNUpdate_Click);
            // 
            // BTNDelete
            // 
            this.BTNDelete.Location = new System.Drawing.Point(106, 27);
            this.BTNDelete.Name = "BTNDelete";
            this.BTNDelete.Size = new System.Drawing.Size(85, 28);
            this.BTNDelete.TabIndex = 18;
            this.BTNDelete.Text = "Удалить";
            this.BTNDelete.UseVisualStyleBackColor = true;
            // 
            // BTNAdd
            // 
            this.BTNAdd.Location = new System.Drawing.Point(15, 27);
            this.BTNAdd.Name = "BTNAdd";
            this.BTNAdd.Size = new System.Drawing.Size(85, 28);
            this.BTNAdd.TabIndex = 17;
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
            this.menuStrip1.Size = new System.Drawing.Size(598, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // реестрыToolStripMenuItem
            // 
            this.реестрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.реестрПлановГрафиковToolStripMenuItem,
            this.реестрАктовОтловаToolStripMenuItem});
            this.реестрыToolStripMenuItem.Name = "реестрыToolStripMenuItem";
            this.реестрыToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.реестрыToolStripMenuItem.Text = "Реестры";
            // 
            // реестрПлановГрафиковToolStripMenuItem
            // 
            this.реестрПлановГрафиковToolStripMenuItem.Name = "реестрПлановГрафиковToolStripMenuItem";
            this.реестрПлановГрафиковToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.реестрПлановГрафиковToolStripMenuItem.Text = "Реестр планов - графиков";
            // 
            // реестрАктовОтловаToolStripMenuItem
            // 
            this.реестрАктовОтловаToolStripMenuItem.Name = "реестрАктовОтловаToolStripMenuItem";
            this.реестрАктовОтловаToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.реестрАктовОтловаToolStripMenuItem.Text = "Реестр актов - отлова";
            this.реестрАктовОтловаToolStripMenuItem.Click += new System.EventHandler(this.реестрАктовОтловаToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.year,
            this.month,
            this.mynicipality});
            this.dataGridView1.Location = new System.Drawing.Point(81, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(423, 150);
            this.dataGridView1.TabIndex = 26;
            // 
            // year
            // 
            this.year.Frozen = true;
            this.year.HeaderText = "Год";
            this.year.Name = "year";
            this.year.ReadOnly = true;
            // 
            // month
            // 
            this.month.Frozen = true;
            this.month.HeaderText = "Месяц";
            this.month.Name = "month";
            this.month.ReadOnly = true;
            // 
            // mynicipality
            // 
            this.mynicipality.Frozen = true;
            this.mynicipality.HeaderText = "Муниципальное образование";
            this.mynicipality.Name = "mynicipality";
            this.mynicipality.ReadOnly = true;
            this.mynicipality.Width = 180;
            // 
            // FormCaptyrePlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 301);
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
            this.Name = "FormCaptyrePlan";
            this.Text = "Реестр планов-графиков";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn month;
        private System.Windows.Forms.DataGridViewTextBoxColumn mynicipality;
    }
}