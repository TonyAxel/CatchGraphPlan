using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CatchGraphPlan.Role;
using CatchGraphPlan.Controllers;
using CatchGraphPlan.Capture;
using Excel = Microsoft.Office.Interop.Excel;

namespace CatchGraphPlan
{
    public partial class FormCaptyreAct : Form
    {
        PermissionsManager pm = PermManFactory.getInstance();
        CaptyreActController controller = new CaptyreActController();


        public FormCaptyreAct()
        {
            InitializeComponent();
            Filter.DisplayMember = "Text";
            Filter.ValueMember = "Value";

            Sort.DisplayMember = "Text";
            Sort.ValueMember = "Value";

            var itemsFilter = new[] {
                    new {Text = "Нет", Value = ""},
                };
            foreach (var item in controller.getCompany())
            {
                var val = new[] { new { Text = item.name.ToString(), Value = $"company = {item.id}" } };

                itemsFilter = itemsFilter.Concat(val).ToArray();
            }
            var itemsSort = new[] {
                    new {Text = "Нет", Value = ""},
                    new {Text = "Дата", Value = "capture_date ASC"},
                    new {Text = "Собаки", Value = "dogs_count ASC"},
                    new {Text = "Кошки", Value = "cats_count ASC"},
                    new {Text = "Животные", Value = "animals_count ASC"},
                };

            Filter.DataSource = itemsFilter;
            Sort.DataSource = itemsSort;
            List<CaptureAct> listCapturePlan = new List<CaptureAct>();
            if (pm.canEditRegister(new CaptureAct()))
            {
                string filter = Filter.SelectedValue.ToString() == "" ? null : Filter.SelectedValue.ToString();
                string sort = Sort.SelectedValue.ToString() == "" ? null : Sort.SelectedValue.ToString();
                listCapturePlan = controller.getCaptureAct(filter: filter, sort: sort);
                
            }
            else
            {
                BTNAdd.Enabled = false;
                BTNDelete.Enabled = false;
                string filter = Filter.SelectedValue.ToString() == "" ? null : Filter.SelectedValue.ToString();
                string sort = Sort.SelectedValue.ToString() == "" ? null : Sort.SelectedValue.ToString();
                listCapturePlan = controller.getCaptureAct(filter: filter, sort: sort);
            }
            foreach (CaptureAct captureAct in listCapturePlan)
            {
                dataGridView1.Rows.Add(captureAct.number_id, captureAct.dogs_count, captureAct.cats_count, captureAct.animals_count, captureAct.company.name, captureAct.capture_Date.ToUniversalTime().AddDays(1).ToString("dd.MM.yyyy"), captureAct.capture_goal, captureAct.captureMunicipalContract.id);
            }
        }

        private void реестрПлановГрафиковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormCapturePlan();

            this.Hide();

            form.Show();
        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            var form = new FormCaptyreActAdd();

            this.Hide();

            form.Show();
        }

        private void BTNUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["number_id"].Value);
            var form = new FormCaptyreActUpdate(id);

            this.Hide();

            form.Show();
        }


        private void реестрОрганизацияToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void BTNAccept_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            List<CaptureAct> listCaptureAct = new List<CaptureAct>();
            if (pm.canEditRegister(new CaptureAct()))
            {
                string filter = Filter.SelectedValue.ToString() == "" ? null : Filter.SelectedValue.ToString();
                string sort = Sort.SelectedValue.ToString() == "" ? null : Sort.SelectedValue.ToString();
                listCaptureAct = controller.getCaptureAct(filter: filter, sort: sort);
            }
            else
            {
                string filter = Filter.SelectedValue.ToString() == "" ? null : Filter.SelectedValue.ToString();
                string sort = Sort.SelectedValue.ToString() == "" ? null : Sort.SelectedValue.ToString();
                listCaptureAct = controller.getCaptureAct(filter, sort);
            }
            foreach (CaptureAct captureAct in listCaptureAct)
            {
                dataGridView1.Rows.Add(captureAct.number_id, captureAct.dogs_count, captureAct.cats_count, captureAct.animals_count, captureAct.company.name, captureAct.capture_Date.ToUniversalTime().AddDays(1).ToString("dd.MM.yyyy"), captureAct.capture_goal, captureAct.captureMunicipalContract.id);
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

        private void BTNDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["number_id"].Value);

            try
            {
                CaptureAct captureAct = new CaptureAct(id);
                controller.deleteCaptureAct(captureAct);
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
            catch
            {
                MessageBox.Show("Не удалось удалить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
