
namespace CatchGraphPlan
{
    partial class FormCompany
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.реестрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.реестрПлановГрафиковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.реестрАктовОтловаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.карточкаОтловленногоЖивотногоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.реестрОрганизацийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.реестрМуниципальныхКонтрактовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kpp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registration_adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Sort = new System.Windows.Forms.ComboBox();
            this.Filter = new System.Windows.Forms.ComboBox();
            this.BTNExportExcel = new System.Windows.Forms.Button();
            this.BTNUpdate = new System.Windows.Forms.Button();
            this.BTNDelete = new System.Windows.Forms.Button();
            this.BTNAdd = new System.Windows.Forms.Button();
            this.BTNAccept = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.реестрыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(643, 24);
            this.menuStrip1.TabIndex = 27;
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
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.inn,
            this.kpp,
            this.registration_adress,
            this.type,
            this.sign});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(643, 150);
            this.dataGridView1.TabIndex = 28;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.HeaderText = "Наименование организации";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // inn
            // 
            this.inn.HeaderText = "ИНН";
            this.inn.Name = "inn";
            this.inn.ReadOnly = true;
            this.inn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // kpp
            // 
            this.kpp.HeaderText = "КПП";
            this.kpp.Name = "kpp";
            this.kpp.ReadOnly = true;
            this.kpp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // registration_adress
            // 
            this.registration_adress.HeaderText = "Адрес регистрации";
            this.registration_adress.Name = "registration_adress";
            this.registration_adress.ReadOnly = true;
            this.registration_adress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // type
            // 
            this.type.HeaderText = "Тип организации";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // sign
            // 
            this.sign.HeaderText = "ИП/Юридическое лицо";
            this.sign.Name = "sign";
            this.sign.ReadOnly = true;
            this.sign.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(153, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Сортировка";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Фильтры";
            // 
            // Sort
            // 
            this.Sort.FormattingEnabled = true;
            this.Sort.Location = new System.Drawing.Point(157, 89);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(121, 21);
            this.Sort.TabIndex = 34;
            // 
            // Filter
            // 
            this.Filter.FormattingEnabled = true;
            this.Filter.Location = new System.Drawing.Point(11, 89);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(121, 21);
            this.Filter.TabIndex = 33;
            // 
            // BTNExportExcel
            // 
            this.BTNExportExcel.Location = new System.Drawing.Point(352, 27);
            this.BTNExportExcel.Name = "BTNExportExcel";
            this.BTNExportExcel.Size = new System.Drawing.Size(102, 28);
            this.BTNExportExcel.TabIndex = 32;
            this.BTNExportExcel.Text = "Экспорт Excel";
            this.BTNExportExcel.UseVisualStyleBackColor = true;
            this.BTNExportExcel.Click += new System.EventHandler(this.BTNExportExcel_Click);
            // 
            // BTNUpdate
            // 
            this.BTNUpdate.Location = new System.Drawing.Point(193, 27);
            this.BTNUpdate.Name = "BTNUpdate";
            this.BTNUpdate.Size = new System.Drawing.Size(85, 28);
            this.BTNUpdate.TabIndex = 31;
            this.BTNUpdate.Text = "Открыть";
            this.BTNUpdate.UseVisualStyleBackColor = true;
            this.BTNUpdate.Click += new System.EventHandler(this.BTNUpdate_Click);
            // 
            // BTNDelete
            // 
            this.BTNDelete.Location = new System.Drawing.Point(102, 27);
            this.BTNDelete.Name = "BTNDelete";
            this.BTNDelete.Size = new System.Drawing.Size(85, 28);
            this.BTNDelete.TabIndex = 30;
            this.BTNDelete.Text = "Удалить";
            this.BTNDelete.UseVisualStyleBackColor = true;
            this.BTNDelete.Click += new System.EventHandler(this.BTNDelete_Click);
            // 
            // BTNAdd
            // 
            this.BTNAdd.Location = new System.Drawing.Point(11, 27);
            this.BTNAdd.Name = "BTNAdd";
            this.BTNAdd.Size = new System.Drawing.Size(85, 28);
            this.BTNAdd.TabIndex = 29;
            this.BTNAdd.Text = "Добавить";
            this.BTNAdd.UseVisualStyleBackColor = true;
            this.BTNAdd.Click += new System.EventHandler(this.BTNAdd_Click);
            // 
            // BTNAccept
            // 
            this.BTNAccept.Location = new System.Drawing.Point(352, 82);
            this.BTNAccept.Name = "BTNAccept";
            this.BTNAccept.Size = new System.Drawing.Size(102, 28);
            this.BTNAccept.TabIndex = 37;
            this.BTNAccept.Text = "Применить";
            this.BTNAccept.UseVisualStyleBackColor = true;
            this.BTNAccept.Click += new System.EventHandler(this.BTNAccept_Click);
            // 
            // FormCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 267);
            this.Controls.Add(this.BTNAccept);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.BTNExportExcel);
            this.Controls.Add(this.BTNUpdate);
            this.Controls.Add(this.BTNDelete);
            this.Controls.Add(this.BTNAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormCompany";
            this.Text = "Реестр организаций";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem реестрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem реестрПлановГрафиковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem реестрАктовОтловаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem карточкаОтловленногоЖивотногоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem реестрОрганизацийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem реестрМуниципальныхКонтрактовToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Sort;
        private System.Windows.Forms.ComboBox Filter;
        private System.Windows.Forms.Button BTNExportExcel;
        private System.Windows.Forms.Button BTNUpdate;
        private System.Windows.Forms.Button BTNDelete;
        private System.Windows.Forms.Button BTNAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn inn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kpp;
        private System.Windows.Forms.DataGridViewTextBoxColumn registration_adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn sign;
        private System.Windows.Forms.Button BTNAccept;
    }
}