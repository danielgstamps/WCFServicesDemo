using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ClassFinderClient.ClassFinderServiceReference;

// Author: Daniel Stamps
// Version: 4/16/2015
namespace ClassFinderClient
{
    public partial class ClientForm : Form
    {
        private readonly ClassFinderServiceClient _client;

        public ClientForm()
        {
            this.InitializeComponent();
            this._client = new ClassFinderServiceClient("BasicHttpBinding_IClassFinderService");
            this.InitializeDataGridViews();  
        }

        private void InitializeDataGridViews()
        {
            this.dgvAllCourses.DataSource = this._client.GetAllCourses();
            this.dgvStudents.DataSource = this._client.GetAllStudents();

            this.dgvAllCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.dgvAllCourses.Columns[1].DisplayIndex = 2;
            this.dgvAllCourses.Columns[2].DisplayIndex = 1;
            this.dgvAllCourses.Columns[0].HeaderText = "CRN";

            this.dgvStudents.Columns[0].DisplayIndex = 2;
            this.dgvStudents.Columns[1].DisplayIndex = 0;
            this.dgvStudents.Columns[2].DisplayIndex = 1;
            this.dgvStudents.Columns[1].HeaderText = "UWG ID";
            this.dgvStudents.Columns[0].HeaderText = "GPA";
            this.dgvStudents.Columns[3].HeaderText = "Courses";
        }

        private void dgvAllCourses_SelectionChanged(object sender, EventArgs e)
        {
            this.RefreshDataGridViews();
        }

        private void btnShowAllStudents_Click(object sender, EventArgs e)
        {
            this.dgvStudents.DataSource = this._client.GetAllStudents();
            this.btnAddStudentToClass.Enabled = true;
            this.btnRemoveFromCourse.Enabled = false;
            this.lblStudents.Text = "Currently Displaying: All Students";
            this.lblFeedback.Text = "";
        }

        private void btnAddStudentToClass_Click(object sender, EventArgs e)
        {
            var selectedId = Convert.ToInt32(this.dgvStudents.SelectedRows[0].Cells[1].Value);
            var selectedCrn = Convert.ToInt32(this.dgvAllCourses.SelectedRows[0].Cells[0].Value);
            var success = this._client.AddStudentToCourse(selectedId, selectedCrn);
            this.RefreshDataGridViews();
            if (success)
            {
                this.lblFeedback.Text = "Added student to course.";
                this.lblFeedback.ForeColor = Color.Green;
            }
            else
            {
                this.lblFeedback.Text = "That student is already in this course.";
                this.lblFeedback.ForeColor = Color.Red;
            }
        }

        private void btnRemoveFromCourse_Click(object sender, EventArgs e)
        {
            var selectedId = Convert.ToInt32(this.dgvStudents.SelectedRows[0].Cells[1].Value);
            var selectedCrn = Convert.ToInt32(this.dgvAllCourses.SelectedRows[0].Cells[0].Value);
            this._client.RemoveStudentFromCourse(selectedId, selectedCrn);
            this.RefreshDataGridViews();
            this.lblFeedback.Text = "Removed student from course.";
            this.lblFeedback.ForeColor = Color.Green;
        }

        private void btnRegisterNewStudent_Click(object sender, EventArgs e)
        {
            var newStudentForm = new NewStudentForm();
            newStudentForm.ShowDialog();
            if (newStudentForm.DialogResult == DialogResult.OK)
            {
                this.RefreshDataGridViews();
                this.lblFeedback.Text = "New Student successfully registered.";
                this.lblFeedback.ForeColor = Color.Green;
            }
            else if (newStudentForm.DialogResult == DialogResult.No)
            {
                this.lblFeedback.Text = "Could not add new Student: Duplicate IDs.";
                this.lblFeedback.ForeColor = Color.Red;
            }
        }

        private void btnCreateNewCourse_Click(object sender, EventArgs e)
        {
            var newCourseForm = new NewCourseForm();
            newCourseForm.ShowDialog();

            if (newCourseForm.DialogResult == DialogResult.OK)
            {
                this.dgvAllCourses.DataSource = this._client.GetAllCourses();
                this.lblFeedback.Text = "New Course successfully created.";
                this.lblFeedback.ForeColor = Color.Green;
            }
            else if (newCourseForm.DialogResult == DialogResult.No)
            {
                this.lblFeedback.Text = "Could not add new Course: Duplicate CRNs.";
                this.lblFeedback.ForeColor = Color.Red;
            }
        }

        private void RefreshDataGridViews()
        {
            if (this.dgvAllCourses.SelectedRows.Count == 0)
            {
                return;
            }

            var selectedCrn = Convert.ToInt32(this.dgvAllCourses.SelectedRows[0].Cells[0].Value);
            this.dgvStudents.DataSource = this._client.GetStudentsInCourse(selectedCrn);

            this.lblParticipantsValue.Text = this._client.GetStudentsInCourse(selectedCrn).Count().ToString();
            this.lblHighestGpaValue.Text = this._client.GetMaxGpaForCourse(selectedCrn).ToString();
            this.lblAverageGpaValue.Text = this._client.GetAverageGpaForCourse(selectedCrn).ToString();
            this.lblLowestGpaValue.Text = this._client.GetMinGpaForCourse(selectedCrn).ToString();
            this.lblStudents.Text = "Currently Displaying: Students in CS" + selectedCrn;

            this.btnAddStudentToClass.Enabled = false;
            if (this._client.GetStudentsInCourse(selectedCrn).Any())
            {
                this.btnRemoveFromCourse.Enabled = true;
            }
            else
            {
                this.btnRemoveFromCourse.Enabled = false;
            }
        }
    }
}