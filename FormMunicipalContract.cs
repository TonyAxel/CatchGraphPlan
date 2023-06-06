using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CatchGraphPlan.Capture;
using CatchGraphPlan.Controllers;
using CatchGraphPlan.PM;
using CatchGraphPlan.Role;
using Excel = Microsoft.Office.Interop.Excel;
namespace CatchGraphPlan
{
    public partial class FormMunicipalContract : Form
    {
        PermissionsManager pm = PermManFactory.getInstance();
        CaptureMunicipalContractController controller = new CaptureMunicipalContractController();

        public FormMunicipalContract()
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
                var val = new[] { new { Text = item.name.ToString(), Value = $"contractor_company = {item.id}" } };

                itemsFilter = itemsFilter.Concat(val).ToArray();
            }

            var itemsSort = new[] {
                    new {Text = "Нет", Value = ""},
                    new {Text = "Дата заключения", Value = "sign_date ASC"},
                    new {Text = "Дата действия", Value = "action_date ASC"},
                };

            Filter.DataSource = itemsFilter;
            Sort.DataSource = itemsSort;
            if (pm.canEditRegister(new CaptureMunicipalContract()))
            {
                List<CaptureMunicipalContract> mynicipalities = controller.getMunicipalContract();
                
                foreach(CaptureMunicipalContract value in mynicipalities)
                {
                    dataGridView1.Rows.Add(value.id, value.id, value.sign_date.ToUniversalTime().AddDays(1).ToString("dd.MM.yyyy"), value.action_date.ToUniversalTime().AddDays(1).ToString("dd.MM.yyyy"), value.contractor_company.name, value.customer.name);
                }
            }
            else
            {
                BTNAdd.Enabled = false;
                BTNDelete.Enabled = false;
                List<CaptureMunicipalContract> mynicipalities = controller.getMunicipalContract();

                foreach (CaptureMunicipalContract value in mynicipalities)
                {
                    dataGridView1.Rows.Add(value.id, value.id, value.sign_date.ToUniversalTime().AddDays(1).ToString("dd.MM.yyyy"), value.action_date.ToUniversalTime().AddDays(1).ToString("dd.MM.yyyy"), value.contractor_company.name, value.customer.name);
                }
            }

        }

        private void реестрПлановГрафиковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormCapturePlan();

            this.Hide();

            form.Show();
        }

        private void реестрАктовОтловаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormCaptyreAct();

            this.Hide();

            form.Show();
        }


        private void реестрОрганизацийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormCompany();

            this.Hide();

            form.Show();
        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            var form = new FormMunicipalContractAdd();

            this.Hide();

            form.Show();
        }

        private void BTNUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
            var form = new FormMunicipalContractUpdate(id);

            this.Hide();

            form.Show();
        }

        private void BTNDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["number"].Value);
            try
            {
                CaptureMunicipalContract captureMunicipalContract = new CaptureMunicipalContract(id);
                controller.deleteMunicipalContract(captureMunicipalContract);
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
            catch
            {
                MessageBox.Show("Не удалось удалить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNAccept_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            List<CapturePlan> listCapturePlan = new List<CapturePlan>();

            if (pm.canEditRegister(new CaptureMunicipalContract()))
            {
                string filter = Filter.SelectedValue.ToString() == "" ? null : Filter.SelectedValue.ToString();
                string sort = Sort.SelectedValue.ToString() == "" ? null : Sort.SelectedValue.ToString();
                List<CaptureMunicipalContract> mynicipalities = controller.getMunicipalContract(filter: filter, sort: sort);
                foreach (CaptureMunicipalContract value in mynicipalities)
                {
                    dataGridView1.Rows.Add(value.id, value.id, value.sign_date.ToUniversalTime().AddDays(1).ToString("dd.MM.yyyy"), value.action_date.ToUniversalTime().AddDays(1).ToString("dd.MM.yyyy"), value.contractor_company.name, value.customer.name);
                }
            }
            else
            {
                string filter = Filter.SelectedValue.ToString() == "" ? null : Filter.SelectedValue.ToString();
                string sort = Sort.SelectedValue.ToString() == "" ? null : Sort.SelectedValue.ToString();
                List<CaptureMunicipalContract> mynicipalities = controller.getMunicipalContract(filter: filter, sort: sort);
                foreach (CaptureMunicipalContract value in mynicipalities)
                {
                    dataGridView1.Rows.Add(value.id, value.id, value.sign_date.ToUniversalTime().AddDays(1).ToString("dd.MM.yyyy"), value.action_date.ToUniversalTime().AddDays(1).ToString("dd.MM.yyyy"), value.contractor_company.name, value.customer.name);
                }
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
    }
}
