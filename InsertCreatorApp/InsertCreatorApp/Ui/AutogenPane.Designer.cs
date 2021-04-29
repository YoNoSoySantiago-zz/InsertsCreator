
namespace InsertCreatorApp.Ui
{
    partial class AutogenPane
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
            this.nud_departments = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_generateAction = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_employee = new System.Windows.Forms.NumericUpDown();
            this.nud_project = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nud_works = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_departments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_project)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_works)).BeginInit();
            this.SuspendLayout();
            // 
            // nud_departments
            // 
            this.nud_departments.Location = new System.Drawing.Point(220, 93);
            this.nud_departments.Name = "nud_departments";
            this.nud_departments.Size = new System.Drawing.Size(60, 20);
            this.nud_departments.TabIndex = 0;
            this.nud_departments.ValueChanged += new System.EventHandler(this.nud_departments_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DEPARTMENTS";
            // 
            // bt_generateAction
            // 
            this.bt_generateAction.Enabled = false;
            this.bt_generateAction.Location = new System.Drawing.Point(120, 321);
            this.bt_generateAction.Name = "bt_generateAction";
            this.bt_generateAction.Size = new System.Drawing.Size(75, 23);
            this.bt_generateAction.TabIndex = 2;
            this.bt_generateAction.Text = "GENERATE";
            this.bt_generateAction.UseVisualStyleBackColor = true;
            this.bt_generateAction.Click += new System.EventHandler(this.bt_generateAction_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "EMPLOYEE";
            // 
            // nud_employee
            // 
            this.nud_employee.Location = new System.Drawing.Point(220, 136);
            this.nud_employee.Name = "nud_employee";
            this.nud_employee.Size = new System.Drawing.Size(60, 20);
            this.nud_employee.TabIndex = 5;
            this.nud_employee.ValueChanged += new System.EventHandler(this.nud_employee_ValueChanged);
            // 
            // nud_project
            // 
            this.nud_project.Location = new System.Drawing.Point(220, 180);
            this.nud_project.Name = "nud_project";
            this.nud_project.Size = new System.Drawing.Size(60, 20);
            this.nud_project.TabIndex = 7;
            this.nud_project.ValueChanged += new System.EventHandler(this.nud_project_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "PROJECT";
            // 
            // nud_works
            // 
            this.nud_works.Location = new System.Drawing.Point(220, 225);
            this.nud_works.Name = "nud_works";
            this.nud_works.Size = new System.Drawing.Size(60, 20);
            this.nud_works.TabIndex = 9;
            this.nud_works.ValueChanged += new System.EventHandler(this.nud_works_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "WORKS_ON";
            // 
            // AutogenPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 356);
            this.Controls.Add(this.nud_works);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nud_project);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nud_employee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_generateAction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud_departments);
            this.Name = "AutogenPane";
            this.Load += new System.EventHandler(this.AutogenPane_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_departments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_project)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_works)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nud_departments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_generateAction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_employee;
        private System.Windows.Forms.NumericUpDown nud_project;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nud_works;
        private System.Windows.Forms.Label label5;
    }
}