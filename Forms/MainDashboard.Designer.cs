﻿namespace SoftwareTwoProject.Forms
{
    partial class MainDashboard
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
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.client_scheduleDataSet = new SoftwareTwoProject.client_scheduleDataSet();
            this.AddCustomerBut = new System.Windows.Forms.Button();
            this.EditCustomerBut = new System.Windows.Forms.Button();
            this.DeleteCustomerBut = new System.Windows.Forms.Button();
            this.AppointmentsListGrid = new System.Windows.Forms.DataGridView();
            this.appointmentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdByDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdateByDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.client_scheduleDataSet1 = new SoftwareTwoProject.client_scheduleDataSet1();
            this.AppointmentsAddBut = new System.Windows.Forms.Button();
            this.EditAppointmentsBut = new System.Windows.Forms.Button();
            this.DeleteAppointmentsBut = new System.Windows.Forms.Button();
            this.ExitBut = new System.Windows.Forms.Button();
            this.WeeklyViewBut = new System.Windows.Forms.Button();
            this.MonthlyViewBut = new System.Windows.Forms.Button();
            this.ReportsMenuBut = new System.Windows.Forms.Button();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.AppointementsLabel = new System.Windows.Forms.Label();
            this.customerTableAdapter = new SoftwareTwoProject.client_scheduleDataSetTableAdapters.customerTableAdapter();
            this.appointmentTableAdapter = new SoftwareTwoProject.client_scheduleDataSet1TableAdapters.appointmentTableAdapter();
            this.CustomerInfoGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_scheduleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsListGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_scheduleDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerInfoGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.client_scheduleDataSet;
            // 
            // client_scheduleDataSet
            // 
            this.client_scheduleDataSet.DataSetName = "client_scheduleDataSet";
            this.client_scheduleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddCustomerBut
            // 
            this.AddCustomerBut.Location = new System.Drawing.Point(47, 261);
            this.AddCustomerBut.Name = "AddCustomerBut";
            this.AddCustomerBut.Size = new System.Drawing.Size(75, 23);
            this.AddCustomerBut.TabIndex = 1;
            this.AddCustomerBut.Text = "Add";
            this.AddCustomerBut.UseVisualStyleBackColor = true;
            this.AddCustomerBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddCustomerBut_MouseClick);
            // 
            // EditCustomerBut
            // 
            this.EditCustomerBut.Location = new System.Drawing.Point(47, 302);
            this.EditCustomerBut.Name = "EditCustomerBut";
            this.EditCustomerBut.Size = new System.Drawing.Size(75, 23);
            this.EditCustomerBut.TabIndex = 2;
            this.EditCustomerBut.Text = "Edit";
            this.EditCustomerBut.UseVisualStyleBackColor = true;
            this.EditCustomerBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EditCustomerBut_MouseClick);
            // 
            // DeleteCustomerBut
            // 
            this.DeleteCustomerBut.Location = new System.Drawing.Point(47, 343);
            this.DeleteCustomerBut.Name = "DeleteCustomerBut";
            this.DeleteCustomerBut.Size = new System.Drawing.Size(75, 23);
            this.DeleteCustomerBut.TabIndex = 3;
            this.DeleteCustomerBut.Text = "Delete";
            this.DeleteCustomerBut.UseVisualStyleBackColor = true;
            this.DeleteCustomerBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DeleteCustomerBut_MouseClick);
            // 
            // AppointmentsListGrid
            // 
            this.AppointmentsListGrid.AllowUserToAddRows = false;
            this.AppointmentsListGrid.AutoGenerateColumns = false;
            this.AppointmentsListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentsListGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appointmentIdDataGridViewTextBoxColumn,
            this.customerIdDataGridViewTextBoxColumn1,
            this.userIdDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.urlDataGridViewTextBoxColumn,
            this.startDataGridViewTextBoxColumn,
            this.endDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn1,
            this.createdByDataGridViewTextBoxColumn1,
            this.lastUpdateDataGridViewTextBoxColumn1,
            this.lastUpdateByDataGridViewTextBoxColumn1});
            this.AppointmentsListGrid.DataSource = this.appointmentBindingSource;
            this.AppointmentsListGrid.Location = new System.Drawing.Point(477, 81);
            this.AppointmentsListGrid.Name = "AppointmentsListGrid";
            this.AppointmentsListGrid.Size = new System.Drawing.Size(330, 150);
            this.AppointmentsListGrid.TabIndex = 4;
            // 
            // appointmentIdDataGridViewTextBoxColumn
            // 
            this.appointmentIdDataGridViewTextBoxColumn.DataPropertyName = "appointmentId";
            this.appointmentIdDataGridViewTextBoxColumn.HeaderText = "appointmentId";
            this.appointmentIdDataGridViewTextBoxColumn.Name = "appointmentIdDataGridViewTextBoxColumn";
            // 
            // customerIdDataGridViewTextBoxColumn1
            // 
            this.customerIdDataGridViewTextBoxColumn1.DataPropertyName = "customerId";
            this.customerIdDataGridViewTextBoxColumn1.HeaderText = "customerId";
            this.customerIdDataGridViewTextBoxColumn1.Name = "customerIdDataGridViewTextBoxColumn1";
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "userId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "userId";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "contact";
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // urlDataGridViewTextBoxColumn
            // 
            this.urlDataGridViewTextBoxColumn.DataPropertyName = "url";
            this.urlDataGridViewTextBoxColumn.HeaderText = "url";
            this.urlDataGridViewTextBoxColumn.Name = "urlDataGridViewTextBoxColumn";
            // 
            // startDataGridViewTextBoxColumn
            // 
            this.startDataGridViewTextBoxColumn.DataPropertyName = "start";
            this.startDataGridViewTextBoxColumn.HeaderText = "start";
            this.startDataGridViewTextBoxColumn.Name = "startDataGridViewTextBoxColumn";
            // 
            // endDataGridViewTextBoxColumn
            // 
            this.endDataGridViewTextBoxColumn.DataPropertyName = "end";
            this.endDataGridViewTextBoxColumn.HeaderText = "end";
            this.endDataGridViewTextBoxColumn.Name = "endDataGridViewTextBoxColumn";
            // 
            // createDateDataGridViewTextBoxColumn1
            // 
            this.createDateDataGridViewTextBoxColumn1.DataPropertyName = "createDate";
            this.createDateDataGridViewTextBoxColumn1.HeaderText = "createDate";
            this.createDateDataGridViewTextBoxColumn1.Name = "createDateDataGridViewTextBoxColumn1";
            // 
            // createdByDataGridViewTextBoxColumn1
            // 
            this.createdByDataGridViewTextBoxColumn1.DataPropertyName = "createdBy";
            this.createdByDataGridViewTextBoxColumn1.HeaderText = "createdBy";
            this.createdByDataGridViewTextBoxColumn1.Name = "createdByDataGridViewTextBoxColumn1";
            // 
            // lastUpdateDataGridViewTextBoxColumn1
            // 
            this.lastUpdateDataGridViewTextBoxColumn1.DataPropertyName = "lastUpdate";
            this.lastUpdateDataGridViewTextBoxColumn1.HeaderText = "lastUpdate";
            this.lastUpdateDataGridViewTextBoxColumn1.Name = "lastUpdateDataGridViewTextBoxColumn1";
            // 
            // lastUpdateByDataGridViewTextBoxColumn1
            // 
            this.lastUpdateByDataGridViewTextBoxColumn1.DataPropertyName = "lastUpdateBy";
            this.lastUpdateByDataGridViewTextBoxColumn1.HeaderText = "lastUpdateBy";
            this.lastUpdateByDataGridViewTextBoxColumn1.Name = "lastUpdateByDataGridViewTextBoxColumn1";
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataMember = "appointment";
            this.appointmentBindingSource.DataSource = this.client_scheduleDataSet1;
            // 
            // client_scheduleDataSet1
            // 
            this.client_scheduleDataSet1.DataSetName = "client_scheduleDataSet1";
            this.client_scheduleDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AppointmentsAddBut
            // 
            this.AppointmentsAddBut.Location = new System.Drawing.Point(477, 261);
            this.AppointmentsAddBut.Name = "AppointmentsAddBut";
            this.AppointmentsAddBut.Size = new System.Drawing.Size(75, 23);
            this.AppointmentsAddBut.TabIndex = 5;
            this.AppointmentsAddBut.Text = "Add";
            this.AppointmentsAddBut.UseVisualStyleBackColor = true;
            this.AppointmentsAddBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AppointmentsAddBut_MouseClick);
            // 
            // EditAppointmentsBut
            // 
            this.EditAppointmentsBut.Location = new System.Drawing.Point(477, 302);
            this.EditAppointmentsBut.Name = "EditAppointmentsBut";
            this.EditAppointmentsBut.Size = new System.Drawing.Size(75, 23);
            this.EditAppointmentsBut.TabIndex = 6;
            this.EditAppointmentsBut.Text = "Edit";
            this.EditAppointmentsBut.UseVisualStyleBackColor = true;
            this.EditAppointmentsBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EditAppointmentsBut_MouseClick);
            // 
            // DeleteAppointmentsBut
            // 
            this.DeleteAppointmentsBut.Location = new System.Drawing.Point(477, 343);
            this.DeleteAppointmentsBut.Name = "DeleteAppointmentsBut";
            this.DeleteAppointmentsBut.Size = new System.Drawing.Size(75, 23);
            this.DeleteAppointmentsBut.TabIndex = 7;
            this.DeleteAppointmentsBut.Text = "Delete";
            this.DeleteAppointmentsBut.UseVisualStyleBackColor = true;
            // 
            // ExitBut
            // 
            this.ExitBut.Location = new System.Drawing.Point(788, 444);
            this.ExitBut.Name = "ExitBut";
            this.ExitBut.Size = new System.Drawing.Size(75, 23);
            this.ExitBut.TabIndex = 8;
            this.ExitBut.Text = "Exit";
            this.ExitBut.UseVisualStyleBackColor = true;
            this.ExitBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ExitBut_MouseClick);
            // 
            // WeeklyViewBut
            // 
            this.WeeklyViewBut.Location = new System.Drawing.Point(211, 444);
            this.WeeklyViewBut.Name = "WeeklyViewBut";
            this.WeeklyViewBut.Size = new System.Drawing.Size(75, 23);
            this.WeeklyViewBut.TabIndex = 9;
            this.WeeklyViewBut.Text = "Weeklyt";
            this.WeeklyViewBut.UseVisualStyleBackColor = true;
            // 
            // MonthlyViewBut
            // 
            this.MonthlyViewBut.Location = new System.Drawing.Point(307, 444);
            this.MonthlyViewBut.Name = "MonthlyViewBut";
            this.MonthlyViewBut.Size = new System.Drawing.Size(75, 23);
            this.MonthlyViewBut.TabIndex = 10;
            this.MonthlyViewBut.Text = "Monthly";
            this.MonthlyViewBut.UseVisualStyleBackColor = true;
            // 
            // ReportsMenuBut
            // 
            this.ReportsMenuBut.Location = new System.Drawing.Point(477, 444);
            this.ReportsMenuBut.Name = "ReportsMenuBut";
            this.ReportsMenuBut.Size = new System.Drawing.Size(75, 23);
            this.ReportsMenuBut.TabIndex = 11;
            this.ReportsMenuBut.Text = "Reports";
            this.ReportsMenuBut.UseVisualStyleBackColor = true;
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Location = new System.Drawing.Point(110, 51);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(94, 13);
            this.CustomerLabel.TabIndex = 12;
            this.CustomerLabel.Text = "Customer Records";
            // 
            // AppointementsLabel
            // 
            this.AppointementsLabel.AutoSize = true;
            this.AppointementsLabel.Location = new System.Drawing.Point(607, 51);
            this.AppointementsLabel.Name = "AppointementsLabel";
            this.AppointementsLabel.Size = new System.Drawing.Size(71, 13);
            this.AppointementsLabel.TabIndex = 13;
            this.AppointementsLabel.Text = "Appointments";
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // appointmentTableAdapter
            // 
            this.appointmentTableAdapter.ClearBeforeFill = true;
            // 
            // CustomerInfoGrid
            // 
            this.CustomerInfoGrid.AllowUserToAddRows = false;
            this.CustomerInfoGrid.AllowUserToDeleteRows = false;
            this.CustomerInfoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerInfoGrid.Location = new System.Drawing.Point(70, 81);
            this.CustomerInfoGrid.Name = "CustomerInfoGrid";
            this.CustomerInfoGrid.Size = new System.Drawing.Size(274, 150);
            this.CustomerInfoGrid.TabIndex = 14;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 479);
            this.Controls.Add(this.CustomerInfoGrid);
            this.Controls.Add(this.AppointementsLabel);
            this.Controls.Add(this.CustomerLabel);
            this.Controls.Add(this.ReportsMenuBut);
            this.Controls.Add(this.MonthlyViewBut);
            this.Controls.Add(this.WeeklyViewBut);
            this.Controls.Add(this.ExitBut);
            this.Controls.Add(this.DeleteAppointmentsBut);
            this.Controls.Add(this.EditAppointmentsBut);
            this.Controls.Add(this.AppointmentsAddBut);
            this.Controls.Add(this.AppointmentsListGrid);
            this.Controls.Add(this.DeleteCustomerBut);
            this.Controls.Add(this.EditCustomerBut);
            this.Controls.Add(this.AddCustomerBut);
            this.Name = "MainDashboard";
            this.Text = "MainDashboard";
            this.Load += new System.EventHandler(this.MainDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_scheduleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsListGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_scheduleDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerInfoGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddCustomerBut;
        private System.Windows.Forms.Button EditCustomerBut;
        private System.Windows.Forms.Button DeleteCustomerBut;
        private System.Windows.Forms.DataGridView AppointmentsListGrid;
        private System.Windows.Forms.Button AppointmentsAddBut;
        private System.Windows.Forms.Button EditAppointmentsBut;
        private System.Windows.Forms.Button DeleteAppointmentsBut;
        private System.Windows.Forms.Button ExitBut;
        private System.Windows.Forms.Button WeeklyViewBut;
        private System.Windows.Forms.Button MonthlyViewBut;
        private System.Windows.Forms.Button ReportsMenuBut;
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.Label AppointementsLabel;
        private client_scheduleDataSet client_scheduleDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private client_scheduleDataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private client_scheduleDataSet1 client_scheduleDataSet1;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private client_scheduleDataSet1TableAdapters.appointmentTableAdapter appointmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdByDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdateByDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView CustomerInfoGrid;
    }
}