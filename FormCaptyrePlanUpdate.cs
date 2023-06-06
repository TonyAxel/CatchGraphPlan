using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CatchGraphPlan.Capture;
using CatchGraphPlan.Controllers;
using CatchGraphPlan.DataBase;
using CatchGraphPlan.PM;
using CatchGraphPlan.Role;


namespace CatchGraphPlan
{
    public partial class FormCaptyrePlanUpdate : Form
    {
        PermissionsManager pm = PermManFactory.getInstance();
        int id;
        CapturePlanController capturePlanController = new CapturePlanController();
        public FormCaptyrePlanUpdate()
        {
            InitializeComponent();

        }
        public FormCaptyrePlanUpdate(int id)
        {
            InitializeComponent();
            this.id = id;
            CapturePlan capturePlan = DB.query().getCapturePlanId(id);

            if (pm.canEditRegister(new CapturePlan()))
            {
                mynicipality.DisplayMember = "Text";
                mynicipality.ValueMember = "Value";

                var itemsType = new[] {
                    new {Text = "", Value = 0},
                };
                foreach (var item in capturePlanController.getMunicipality())
                {
                    var val = new[] { new { Text = item.name.ToString(), Value = Convert.ToInt32(item.id) } };

                    itemsType = itemsType.Concat(val).ToArray();
                }
                mynicipality.DataSource = itemsType;
                BTNBack.Hide();

                if (capturePlan.file == "None")
                {
                    label1.Text = "Нет файла";
                    BTNDeleteFile.Hide();
                }
                else
                {
                    label1.Text = "Файл: " + capturePlan.file;
                    BTNAddFile.Hide();
                }
            }
            else
            {
                mynicipality.DisplayMember = "Text";
                mynicipality.ValueMember = "Value";
                var itemsType = new[] {
                    new {Text = capturePlan.municipality.name, Value = Convert.ToInt32(capturePlan.municipality.id)},
                };
                date.Enabled = false;
                mynicipality.Enabled = false;
                mynicipality.DataSource = itemsType;
                label1.Hide();
                BTNAddFile.Hide();
                BTNDeleteFile.Hide();
            }

            date.Value = capturePlan.date;
            mynicipality.SelectedValue = capturePlan.municipality.id;
        }
        private void BTNUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                CapturePlan capturePlan = new CapturePlan(this.id, date.Value,new  Municipality(Convert.ToInt32(mynicipality.SelectedValue), mynicipality.Text));
                capturePlanController.updateCapturePlan(capturePlan);

                var form = new FormCapturePlan();

                this.Hide();

                form.Show();
            }
            catch
            {
                MessageBox.Show("Не удалось обновить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void BTNBack_Click(object sender, EventArgs e)
        {
            var form = new FormCapturePlan();

            this.Hide();

            form.Show();
        }

        private void BTNAddFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files | *.pdf"; // file types, that will be allowed to upload
            dialog.Multiselect = false; // allow/deny user to upload more than one file at a time
            if (dialog.ShowDialog() == DialogResult.OK) // if user clicked OK
            {
                String path = dialog.FileName; // get name of file

                string pathName = path.Split('\\').Last();

                try
                {
                    capturePlanController.setFile(new CapturePlan(id, pathName));

                    label1.Text = pathName;
                    BTNDeleteFile.Show();
                    BTNAddFile.Hide();

                }
                catch
                {
                    MessageBox.Show("Не удалось добавить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BTNDeleteFile_Click(object sender, EventArgs e)
        {
            try
            {
                capturePlanController.deleteFile(new CapturePlan(id));

                label1.Text = "Нет файла";
                BTNDeleteFile.Hide();
                BTNAddFile.Show();
            }
            catch
            {
                MessageBox.Show("Не удалось удалить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
