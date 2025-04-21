namespace GuardianPRO
{
    partial class AdminDashboardForm
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
            this.Greetings = new System.Windows.Forms.Label();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnViewApps = new System.Windows.Forms.Button();
            this.btnViewLogs = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.guardianPRODataSet = new GuardianPRO.GuardianPRODataSet();
            this.guardianPRODataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new GuardianPRO.GuardianPRODataSetTableAdapters.UsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.guardianPRODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guardianPRODataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Greetings
            // 
            this.Greetings.AutoSize = true;
            this.Greetings.Location = new System.Drawing.Point(12, 17);
            this.Greetings.Name = "Greetings";
            this.Greetings.Size = new System.Drawing.Size(154, 20);
            this.Greetings.TabIndex = 0;
            this.Greetings.Text = "Добро пожаловать";
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.Location = new System.Drawing.Point(229, 98);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(210, 50);
            this.btnManageUsers.TabIndex = 1;
            this.btnManageUsers.Text = "Управление пользователями";
            this.btnManageUsers.UseVisualStyleBackColor = true;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // btnViewApps
            // 
            this.btnViewApps.Location = new System.Drawing.Point(229, 154);
            this.btnViewApps.Name = "btnViewApps";
            this.btnViewApps.Size = new System.Drawing.Size(210, 50);
            this.btnViewApps.TabIndex = 2;
            this.btnViewApps.Text = "Просмотр всех заявок";
            this.btnViewApps.UseVisualStyleBackColor = true;
            this.btnViewApps.Click += new System.EventHandler(this.btnViewApps_Click);
            // 
            // btnViewLogs
            // 
            this.btnViewLogs.Location = new System.Drawing.Point(229, 210);
            this.btnViewLogs.Name = "btnViewLogs";
            this.btnViewLogs.Size = new System.Drawing.Size(210, 50);
            this.btnViewLogs.TabIndex = 3;
            this.btnViewLogs.Text = "Просмотр логов";
            this.btnViewLogs.UseVisualStyleBackColor = true;
            this.btnViewLogs.Click += new System.EventHandler(this.btnViewLogs_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(491, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(164, 31);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Выйти из системы";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // guardianPRODataSet
            // 
            this.guardianPRODataSet.DataSetName = "GuardianPRODataSet";
            this.guardianPRODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guardianPRODataSetBindingSource
            // 
            this.guardianPRODataSetBindingSource.DataSource = this.guardianPRODataSet;
            this.guardianPRODataSetBindingSource.Position = 0;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.guardianPRODataSetBindingSource;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 319);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnViewLogs);
            this.Controls.Add(this.btnViewApps);
            this.Controls.Add(this.btnManageUsers);
            this.Controls.Add(this.Greetings);
            this.Name = "AdminDashboardForm";
            this.Text = "AdminDashboardForm";
            ((System.ComponentModel.ISupportInitialize)(this.guardianPRODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guardianPRODataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Greetings;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnViewApps;
        private System.Windows.Forms.Button btnViewLogs;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.BindingSource guardianPRODataSetBindingSource;
        private GuardianPRODataSet guardianPRODataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private GuardianPRODataSetTableAdapters.UsersTableAdapter usersTableAdapter;
    }
}