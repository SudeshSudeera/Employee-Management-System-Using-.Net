﻿namespace PersonalTracking
{
    partial class FrmMain
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
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnTask = new System.Windows.Forms.Button();
            this.btnSalary = new System.Windows.Forms.Button();
            this.btnPermission = new System.Windows.Forms.Button();
            this.btnDepartment = new System.Windows.Forms.Button();
            this.btnPosition = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.SkyBlue;
            this.btnEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.Image = global::PersonalTracking.Properties.Resources.management;
            this.btnEmployee.Location = new System.Drawing.Point(23, 12);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(154, 131);
            this.btnEmployee.TabIndex = 0;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnTask
            // 
            this.btnTask.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTask.Image = global::PersonalTracking.Properties.Resources.workspace;
            this.btnTask.Location = new System.Drawing.Point(224, 12);
            this.btnTask.Name = "btnTask";
            this.btnTask.Size = new System.Drawing.Size(154, 131);
            this.btnTask.TabIndex = 1;
            this.btnTask.Text = "Tasks";
            this.btnTask.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTask.UseVisualStyleBackColor = false;
            this.btnTask.Click += new System.EventHandler(this.btnTask_Click);
            // 
            // btnSalary
            // 
            this.btnSalary.BackColor = System.Drawing.Color.LightGreen;
            this.btnSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalary.Image = global::PersonalTracking.Properties.Resources.give_money;
            this.btnSalary.Location = new System.Drawing.Point(423, 12);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(154, 131);
            this.btnSalary.TabIndex = 2;
            this.btnSalary.Text = "Salary";
            this.btnSalary.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalary.UseVisualStyleBackColor = false;
            this.btnSalary.Click += new System.EventHandler(this.btnSalary_Click);
            // 
            // btnPermission
            // 
            this.btnPermission.BackColor = System.Drawing.Color.Gold;
            this.btnPermission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPermission.Image = global::PersonalTracking.Properties.Resources.traveler2;
            this.btnPermission.Location = new System.Drawing.Point(23, 163);
            this.btnPermission.Name = "btnPermission";
            this.btnPermission.Size = new System.Drawing.Size(154, 131);
            this.btnPermission.TabIndex = 3;
            this.btnPermission.Text = "Permission";
            this.btnPermission.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPermission.UseVisualStyleBackColor = false;
            this.btnPermission.Click += new System.EventHandler(this.btnPermission_Click);
            // 
            // btnDepartment
            // 
            this.btnDepartment.BackColor = System.Drawing.Color.HotPink;
            this.btnDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartment.Image = global::PersonalTracking.Properties.Resources.organization;
            this.btnDepartment.Location = new System.Drawing.Point(224, 163);
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Size = new System.Drawing.Size(154, 131);
            this.btnDepartment.TabIndex = 4;
            this.btnDepartment.Text = "Department";
            this.btnDepartment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDepartment.UseVisualStyleBackColor = false;
            this.btnDepartment.Click += new System.EventHandler(this.btnDepartment_Click);
            // 
            // btnPosition
            // 
            this.btnPosition.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosition.Image = global::PersonalTracking.Properties.Resources.medal;
            this.btnPosition.Location = new System.Drawing.Point(423, 163);
            this.btnPosition.Name = "btnPosition";
            this.btnPosition.Size = new System.Drawing.Size(154, 131);
            this.btnPosition.TabIndex = 5;
            this.btnPosition.Text = "Position";
            this.btnPosition.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPosition.UseVisualStyleBackColor = false;
            this.btnPosition.Click += new System.EventHandler(this.btnPosition_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.OrangeRed;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Image = global::PersonalTracking.Properties.Resources.logout;
            this.btnLogOut.Location = new System.Drawing.Point(128, 322);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(154, 131);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Crimson;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = global::PersonalTracking.Properties.Resources.exit;
            this.btnExit.Location = new System.Drawing.Point(334, 322);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(154, 131);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 465);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnPosition);
            this.Controls.Add(this.btnDepartment);
            this.Controls.Add(this.btnPermission);
            this.Controls.Add(this.btnSalary);
            this.Controls.Add(this.btnTask);
            this.Controls.Add(this.btnEmployee);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Tracking";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnTask;
        private System.Windows.Forms.Button btnSalary;
        private System.Windows.Forms.Button btnPermission;
        private System.Windows.Forms.Button btnDepartment;
        private System.Windows.Forms.Button btnPosition;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnExit;
    }
}