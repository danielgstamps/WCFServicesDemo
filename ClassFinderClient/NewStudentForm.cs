using System;
using System.Drawing;
using System.Windows.Forms;
using ClassFinderClient.ClassFinderServiceReference;

// Author: Daniel Stamps
// Version: 4/16/2015
namespace ClassFinderClient
{
    public partial class NewStudentForm : Form
    {
        private readonly ClassFinderServiceClient _client;

        public NewStudentForm()
        {
            this.InitializeComponent();
            this._client = new ClassFinderServiceClient("NetNamedPipeBinding_IClassFinderService");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtId.Text) ||
                string.IsNullOrEmpty(this.txtName.Text) ||
                string.IsNullOrEmpty(this.txtGpa.Text))
            {
                this.lblMessage.Text = "Error: Missing data.";
                this.lblMessage.ForeColor = Color.Red;
                return;
            }

            try
            {
                var id = Math.Abs(Int32.Parse(this.txtId.Text));
                var name = this.txtName.Text;
                var gpa = Double.Parse(this.txtGpa.Text);
                var success = this._client.CreateNewStudent(id, name, gpa);
                if (success)
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    DialogResult = DialogResult.No;
                }
                Close();
            }
            catch (Exception)
            {
                this.lblMessage.Text = "Error: Invalid data.";
                this.lblMessage.ForeColor = Color.Red;
            }
        }
    }
}