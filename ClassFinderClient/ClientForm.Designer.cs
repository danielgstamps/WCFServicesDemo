namespace ClassFinderClient
{
    partial class ClientForm
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
            this.components = new System.ComponentModel.Container();
            this.dgvAllCourses = new System.Windows.Forms.DataGridView();
            this.lblStudents = new System.Windows.Forms.Label();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.lblAllCourses = new System.Windows.Forms.Label();
            this.btnShowAllStudents = new System.Windows.Forms.Button();
            this.btnAddStudentToClass = new System.Windows.Forms.Button();
            this.lblCourseDetails = new System.Windows.Forms.Label();
            this.lblHighestGpa = new System.Windows.Forms.Label();
            this.lblHighestGpaValue = new System.Windows.Forms.Label();
            this.lblAverageGpa = new System.Windows.Forms.Label();
            this.lblAverageGpaValue = new System.Windows.Forms.Label();
            this.lblParticipants = new System.Windows.Forms.Label();
            this.lblParticipantsValue = new System.Windows.Forms.Label();
            this.lblLowestGpa = new System.Windows.Forms.Label();
            this.lblLowestGpaValue = new System.Windows.Forms.Label();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.btnRemoveFromCourse = new System.Windows.Forms.Button();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnCreateNewCourse = new System.Windows.Forms.Button();
            this.btnCreateNewStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllCourses
            // 
            this.dgvAllCourses.AllowUserToAddRows = false;
            this.dgvAllCourses.AllowUserToDeleteRows = false;
            this.dgvAllCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllCourses.Location = new System.Drawing.Point(15, 32);
            this.dgvAllCourses.Name = "dgvAllCourses";
            this.dgvAllCourses.ReadOnly = true;
            this.dgvAllCourses.RowTemplate.Height = 24;
            this.dgvAllCourses.Size = new System.Drawing.Size(517, 144);
            this.dgvAllCourses.TabIndex = 2;
            this.dgvAllCourses.SelectionChanged += new System.EventHandler(this.dgvAllCourses_SelectionChanged);
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudents.Location = new System.Drawing.Point(12, 226);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(332, 20);
            this.lblStudents.TabIndex = 3;
            this.lblStudents.Text = "Currently Displaying: All Students";
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(15, 252);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.RowTemplate.Height = 24;
            this.dgvStudents.Size = new System.Drawing.Size(514, 205);
            this.dgvStudents.TabIndex = 4;
            // 
            // lblAllCourses
            // 
            this.lblAllCourses.AutoSize = true;
            this.lblAllCourses.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.lblAllCourses.Location = new System.Drawing.Point(12, 9);
            this.lblAllCourses.Name = "lblAllCourses";
            this.lblAllCourses.Size = new System.Drawing.Size(115, 20);
            this.lblAllCourses.TabIndex = 5;
            this.lblAllCourses.Text = "Course List";
            // 
            // btnShowAllStudents
            // 
            this.btnShowAllStudents.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAllStudents.Location = new System.Drawing.Point(542, 252);
            this.btnShowAllStudents.Name = "btnShowAllStudents";
            this.btnShowAllStudents.Size = new System.Drawing.Size(202, 33);
            this.btnShowAllStudents.TabIndex = 6;
            this.btnShowAllStudents.Text = "Show All Students";
            this.btnShowAllStudents.UseVisualStyleBackColor = true;
            this.btnShowAllStudents.Click += new System.EventHandler(this.btnShowAllStudents_Click);
            // 
            // btnAddStudentToClass
            // 
            this.btnAddStudentToClass.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudentToClass.Location = new System.Drawing.Point(542, 291);
            this.btnAddStudentToClass.Name = "btnAddStudentToClass";
            this.btnAddStudentToClass.Size = new System.Drawing.Size(202, 33);
            this.btnAddStudentToClass.TabIndex = 8;
            this.btnAddStudentToClass.Text = "Add to Selected Course";
            this.btnAddStudentToClass.UseVisualStyleBackColor = true;
            this.btnAddStudentToClass.Click += new System.EventHandler(this.btnAddStudentToClass_Click);
            // 
            // lblCourseDetails
            // 
            this.lblCourseDetails.AutoSize = true;
            this.lblCourseDetails.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseDetails.Location = new System.Drawing.Point(563, 32);
            this.lblCourseDetails.Name = "lblCourseDetails";
            this.lblCourseDetails.Size = new System.Drawing.Size(153, 20);
            this.lblCourseDetails.TabIndex = 9;
            this.lblCourseDetails.Text = "Course Details:";
            // 
            // lblHighestGpa
            // 
            this.lblHighestGpa.AutoSize = true;
            this.lblHighestGpa.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighestGpa.Location = new System.Drawing.Point(563, 92);
            this.lblHighestGpa.Name = "lblHighestGpa";
            this.lblHighestGpa.Size = new System.Drawing.Size(124, 20);
            this.lblHighestGpa.TabIndex = 10;
            this.lblHighestGpa.Text = "Highest GPA:";
            // 
            // lblHighestGpaValue
            // 
            this.lblHighestGpaValue.AutoSize = true;
            this.lblHighestGpaValue.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighestGpaValue.Location = new System.Drawing.Point(702, 92);
            this.lblHighestGpaValue.Name = "lblHighestGpaValue";
            this.lblHighestGpaValue.Size = new System.Drawing.Size(42, 20);
            this.lblHighestGpaValue.TabIndex = 11;
            this.lblHighestGpaValue.Text = "N/A";
            // 
            // lblAverageGpa
            // 
            this.lblAverageGpa.AutoSize = true;
            this.lblAverageGpa.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageGpa.Location = new System.Drawing.Point(563, 123);
            this.lblAverageGpa.Name = "lblAverageGpa";
            this.lblAverageGpa.Size = new System.Drawing.Size(128, 20);
            this.lblAverageGpa.TabIndex = 12;
            this.lblAverageGpa.Text = "Average GPA:";
            // 
            // lblAverageGpaValue
            // 
            this.lblAverageGpaValue.AutoSize = true;
            this.lblAverageGpaValue.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageGpaValue.Location = new System.Drawing.Point(702, 123);
            this.lblAverageGpaValue.Name = "lblAverageGpaValue";
            this.lblAverageGpaValue.Size = new System.Drawing.Size(42, 20);
            this.lblAverageGpaValue.TabIndex = 13;
            this.lblAverageGpaValue.Text = "N/A";
            // 
            // lblParticipants
            // 
            this.lblParticipants.AutoSize = true;
            this.lblParticipants.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParticipants.Location = new System.Drawing.Point(563, 61);
            this.lblParticipants.Name = "lblParticipants";
            this.lblParticipants.Size = new System.Drawing.Size(118, 20);
            this.lblParticipants.TabIndex = 14;
            this.lblParticipants.Text = "Participants:";
            // 
            // lblParticipantsValue
            // 
            this.lblParticipantsValue.AutoSize = true;
            this.lblParticipantsValue.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParticipantsValue.Location = new System.Drawing.Point(702, 61);
            this.lblParticipantsValue.Name = "lblParticipantsValue";
            this.lblParticipantsValue.Size = new System.Drawing.Size(42, 20);
            this.lblParticipantsValue.TabIndex = 15;
            this.lblParticipantsValue.Text = "N/A";
            // 
            // lblLowestGpa
            // 
            this.lblLowestGpa.AutoSize = true;
            this.lblLowestGpa.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowestGpa.Location = new System.Drawing.Point(563, 156);
            this.lblLowestGpa.Name = "lblLowestGpa";
            this.lblLowestGpa.Size = new System.Drawing.Size(117, 20);
            this.lblLowestGpa.TabIndex = 16;
            this.lblLowestGpa.Text = "Lowest GPA:";
            // 
            // lblLowestGpaValue
            // 
            this.lblLowestGpaValue.AutoSize = true;
            this.lblLowestGpaValue.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowestGpaValue.Location = new System.Drawing.Point(702, 156);
            this.lblLowestGpaValue.Name = "lblLowestGpaValue";
            this.lblLowestGpaValue.Size = new System.Drawing.Size(42, 20);
            this.lblLowestGpaValue.TabIndex = 17;
            this.lblLowestGpaValue.Text = "N/A";
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedback.Location = new System.Drawing.Point(12, 179);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(0, 20);
            this.lblFeedback.TabIndex = 18;
            // 
            // btnRemoveFromCourse
            // 
            this.btnRemoveFromCourse.Enabled = false;
            this.btnRemoveFromCourse.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFromCourse.Location = new System.Drawing.Point(542, 330);
            this.btnRemoveFromCourse.Name = "btnRemoveFromCourse";
            this.btnRemoveFromCourse.Size = new System.Drawing.Size(202, 33);
            this.btnRemoveFromCourse.TabIndex = 19;
            this.btnRemoveFromCourse.Text = "Remove From Course";
            this.btnRemoveFromCourse.UseVisualStyleBackColor = true;
            this.btnRemoveFromCourse.Click += new System.EventHandler(this.btnRemoveFromCourse_Click);
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(ClassFinderClient.ClassFinderServiceReference.Course);
            // 
            // courseBindingSource1
            // 
            this.courseBindingSource1.DataSource = typeof(ClassFinderClient.ClassFinderServiceReference.Course);
            // 
            // btnCreateNewCourse
            // 
            this.btnCreateNewCourse.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNewCourse.Location = new System.Drawing.Point(542, 424);
            this.btnCreateNewCourse.Name = "btnCreateNewCourse";
            this.btnCreateNewCourse.Size = new System.Drawing.Size(202, 33);
            this.btnCreateNewCourse.TabIndex = 20;
            this.btnCreateNewCourse.Text = "Create New Course";
            this.btnCreateNewCourse.UseVisualStyleBackColor = true;
            this.btnCreateNewCourse.Click += new System.EventHandler(this.btnCreateNewCourse_Click);
            // 
            // btnCreateNewStudent
            // 
            this.btnCreateNewStudent.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNewStudent.Location = new System.Drawing.Point(542, 385);
            this.btnCreateNewStudent.Name = "btnCreateNewStudent";
            this.btnCreateNewStudent.Size = new System.Drawing.Size(202, 33);
            this.btnCreateNewStudent.TabIndex = 21;
            this.btnCreateNewStudent.Text = "Register New Student";
            this.btnCreateNewStudent.UseVisualStyleBackColor = true;
            this.btnCreateNewStudent.Click += new System.EventHandler(this.btnRegisterNewStudent_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 475);
            this.Controls.Add(this.btnCreateNewStudent);
            this.Controls.Add(this.btnCreateNewCourse);
            this.Controls.Add(this.btnRemoveFromCourse);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.lblLowestGpaValue);
            this.Controls.Add(this.lblLowestGpa);
            this.Controls.Add(this.lblParticipantsValue);
            this.Controls.Add(this.lblParticipants);
            this.Controls.Add(this.lblAverageGpaValue);
            this.Controls.Add(this.lblAverageGpa);
            this.Controls.Add(this.lblHighestGpaValue);
            this.Controls.Add(this.lblHighestGpa);
            this.Controls.Add(this.lblCourseDetails);
            this.Controls.Add(this.btnAddStudentToClass);
            this.Controls.Add(this.btnShowAllStudents);
            this.Controls.Add(this.lblAllCourses);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.lblStudents);
            this.Controls.Add(this.dgvAllCourses);
            this.Name = "ClientForm";
            this.Text = "Course Finder - Daniel Stamps";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.DataGridView dgvAllCourses;
        private System.Windows.Forms.BindingSource courseBindingSource1;
        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Label lblAllCourses;
        private System.Windows.Forms.Button btnShowAllStudents;
        private System.Windows.Forms.Button btnAddStudentToClass;
        private System.Windows.Forms.Label lblCourseDetails;
        private System.Windows.Forms.Label lblHighestGpa;
        private System.Windows.Forms.Label lblHighestGpaValue;
        private System.Windows.Forms.Label lblAverageGpa;
        private System.Windows.Forms.Label lblAverageGpaValue;
        private System.Windows.Forms.Label lblParticipants;
        private System.Windows.Forms.Label lblParticipantsValue;
        private System.Windows.Forms.Label lblLowestGpa;
        private System.Windows.Forms.Label lblLowestGpaValue;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Button btnRemoveFromCourse;
        private System.Windows.Forms.Button btnCreateNewCourse;
        private System.Windows.Forms.Button btnCreateNewStudent;
    }
}

