using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CatchGraphPlan.Role;
using CatchGraphPlan.PM;
using CatchGraphPlan.Controllers;
using CatchGraphPlan.Capture;
using Excel = Microsoft.Office.Interop.Excel;

namespace CatchGraphPlan
{
    public partial class FormCapturePlan : Form
    {
        PermissionsManager pm = PermManFactory.getInstance();

        CapturePlanController capturePlanController = new CapturePlanController();
        string role;
        public FormCapturePlan()
        {
            InitializeComponent();
            Filter.DisplayMember = "Text";
            Filter.ValueMember = "Value";

            Sort.DisplayMember = "Text";
            Sort.ValueMember = "Value";

            var itemsFilter = new[] {
                    new {Text = "Нет", Value = ""},
                    new {Text = "Дата", Value = "company_sign = 1"},
                    new {Text = "Юр. лица", Value = "company_sign = 2"},
                };

            var itemsSort = new[] {
                    new {Text = "Нет", Value = ""},
                    new {Text = "По названию", Value = "name ASC"},
                };

            Filter.DataSource = itemsFilter;
            Sort.DataSource = itemsSort;

            if (!pm.canEditRegister(new CapturePlan()))
            {
                this.role = "Просмотр";
                BTNAdd.Enabled = false;
                BTNDelete.Enabled = false;
                string filter = Filter.SelectedValue.ToString() == "" ? null : Filter.SelectedValue.ToString();
                string sort = Sort.SelectedValue.ToString() == "" ? null : Sort.SelectedValue.ToString();
                List<CapturePlan> listCapturePlan = capturePlanController.getCapturePlan(filter: filter, sort: sort);
                foreach (CapturePlan capturePlan in listCapturePlan)
                {
                    dataGridView1.Rows.Add(capturePlan.id, capturePlan.date.Year, capturePlan.date.Month, capturePlan.municipality.name, capturePlan.date);
                }

            }
            if (pm.canEditRegister(new CapturePlan()))
            {
                this.role = "Оператор ОМСУ";

                BTNAdd.Enabled = false;
                BTNDelete.Enabled = false;
                string filter = Filter.SelectedValue.ToString() == "" ? null : Filter.SelectedValue.ToString();
                string sort = Sort.SelectedValue.ToString() == "" ? null : Sort.SelectedValue.ToString();
                List<CapturePlan> listCapturePlan = capturePlanController.getCapturePlan(filter, sort);
                foreach (CapturePlan capturePlan in listCapturePlan)
                {
                    dataGridView1.Rows.Add(capturePlan.id, capturePlan.date.Year,capturePlan.date.Month, capturePlan.municipality.name, capturePlan.date);
                }
            }
            if (pm.canEditRegister(new CapturePlan()))
            {
                this.role = "Оператор по отлову";
                string filter = Filter.SelectedValue.ToString() == "" ? null : Filter.SelectedValue.ToString();
                string sort = Sort.SelectedValue.ToString() == "" ? null : Sort.SelectedValue.ToString();
                List<CapturePlan> listCapturePlan = capturePlanController.getCapturePlan(filter: filter, sort: sort);
                foreach (CapturePlan capturePlan in listCapturePlan)
                {
                    dataGridView1.Rows.Add(capturePlan.id, capturePlan.date.Year, capturePlan.date.Month, capturePlan.municipality.name, capturePlan.date);
                }
            }
        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            var form = new FormCaptyrePlanAdd();

            this.Hide();

            form.Show();
        }

        private void BTNUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);

            var form = new FormCaptyrePlanUpdate();

            this.Hide();

            form.Show();
        }

        private void реестрАктовОтловаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormCaptyreAct();

            this.Hide();

            form.Show();
        }

        private void карточкаОтловленногоЖивотногоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormCaptyreAnimal();

            this.Hide();

            form.Show();
        }

        private void реестрОрганизацийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormCompany();

            this.Hide();

            form.Show();
        }

        private void реестрМуниципальныхКонтрактовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormMunicipalContract();
            this.Hide();

            form.Show();
        }

        private void BTNDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
            DateTime date = Convert.ToDateTime(dataGridView1.CurrentRow.Cells["date"].Value);
            Municipality mynicipality = new Municipality(0, dataGridView1.CurrentRow.Cells["mynicipality"].Value.ToString());
            

            try
            {
                CapturePlan capturePlan = new CapturePlan(id, date, mynicipality);
                capturePlanController.deleteCapturePlan(capturePlan);
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
            catch
            {
                MessageBox.Show("Не удалось удалить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BTNExportExcel_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();

            exApp.Workbooks.Add();

            Excel.Worksheet worksheet = (Excel.Worksheet)exApp.ActiveSheet;

            int i, j;

            for (i = 2; i <= dataGridView1.RowCount + 1; i++)
            {
                for (j = 0; j <= dataGridView1.ColumnCount - 1; j++)
                {
                    worksheet.Cells[1, j + 1] = dataGridView1.Columns[j].HeaderText.ToString();
                    worksheet.Cells[i, j + 1] = dataGridView1[j, i - 2].Value.ToString();
                }
            }

            exApp.Visible = true;
        }

        private void BTNAccept_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (role == "Просмотр")
            {
                string filter = Filter.SelectedValue.ToString() == "" ? null : Filter.SelectedValue.ToString();
                string sort = Sort.SelectedValue.ToString() == "" ? null : Sort.SelectedValue.ToString();
                List<CapturePlan> listCapturePlan = capturePlanController.getCapturePlan(filter: filter, sort: sort);
                foreach (CapturePlan capturePlan in listCapturePlan)
                {
                    dataGridView1.Rows.Add(capturePlan.id, capturePlan.date.Year, capturePlan.date.Month, capturePlan.municipality.name, capturePlan.date);

                }

            }
            if (role == "Оператор ОМСУ")
            {

                string filter = Filter.SelectedValue.ToString() == "" ? null : Filter.SelectedValue.ToString();
                string sort = Sort.SelectedValue.ToString() == "" ? null : Sort.SelectedValue.ToString();
                List<CapturePlan> listCapturePlan = capturePlanController.getCapturePlan(filter, sort);
                foreach (CapturePlan capturePlan in listCapturePlan)
                {
                    dataGridView1.Rows.Add(capturePlan.id, capturePlan.date.Year, capturePlan.date.Month, capturePlan.municipality.name, capturePlan.date);
                }
            }
            if (role == "Оператор по отлову")
            {
                string filter = Filter.SelectedValue.ToString() == "" ? null : Filter.SelectedValue.ToString();
                string sort = Sort.SelectedValue.ToString() == "" ? null : Sort.SelectedValue.ToString();
                List<CapturePlan> listCapturePlan = capturePlanController.getCapturePlan(filter: filter, sort: sort);
                foreach (CapturePlan capturePlan in listCapturePlan)
                {
                    dataGridView1.Rows.Add(capturePlan.id, capturePlan.date.Year, capturePlan.date.Month, capturePlan.municipality.name, capturePlan.date);
                }
            }
        }
    }
}
