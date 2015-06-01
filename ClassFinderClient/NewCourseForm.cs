using System;
using System.Drawing;
using System.Windows.Forms;
using ClassFinderClient.ClassFinderServiceReference;

// Author: Daniel Stamps
// Version: 4/16/2015
namespace ClassFinderClient
{
    public partial class NewCourseForm : Form
    {
        private readonly ClassFinderServiceClient _client;

        public NewCourseForm()
        {
            this.InitializeComponent();
            this._client = new ClassFinderServiceClient("NetTcpBinding_IClassFinderService");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtCrn.Text) ||
                string.IsNullOrEmpty(this.txtTitle.Text) ||
                string.IsNullOrEmpty(this.txtInstructor.Text))
            {
                this.lblMessage.Text = "Error: Missing data.";
                this.lblMessage.ForeColor = Color.Red;
                return;
            }

            try
            {
                var crn = Math.Abs(Int32.Parse(this.txtCrn.Text));
                var title = this.txtTitle.Text;
                var instructor = this.txtInstructor.Text;
                var success = this._client.CreateNewCourse(crn, title, instructor);
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