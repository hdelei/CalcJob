﻿
namespace CalcJob
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timeBox = new System.Windows.Forms.MaskedTextBox();
            this.reloadGrid = new MetroFramework.Controls.MetroLabel();
            this.closeForm = new MetroFramework.Controls.MetroLabel();
            this.DecimalCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalTimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridMetro = new MetroFramework.Controls.MetroGrid();
            this.mAddTimeButton = new MetroFramework.Controls.MetroButton();
            this.labelTimeTip1 = new MetroFramework.Controls.MetroLabel();
            this.alwaysCheckBox = new MetroFramework.Controls.MetroCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridMetro)).BeginInit();
            this.SuspendLayout();
            // 
            // timeBox
            // 
            this.timeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.timeBox.BeepOnError = true;
            this.timeBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeBox.ForeColor = System.Drawing.Color.Red;
            this.timeBox.Location = new System.Drawing.Point(19, 41);
            this.timeBox.Mask = "00:00";
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(96, 39);
            this.timeBox.TabIndex = 0;
            this.timeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timeBox.ValidatingType = typeof(System.DateTime);
            this.timeBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TimeBox_KeyUp);
            // 
            // reloadGrid
            // 
            this.reloadGrid.AutoSize = true;
            this.reloadGrid.BackColor = System.Drawing.Color.Black;
            this.reloadGrid.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.reloadGrid.ForeColor = System.Drawing.Color.DodgerBlue;
            this.reloadGrid.Location = new System.Drawing.Point(20, 5);
            this.reloadGrid.Name = "reloadGrid";
            this.reloadGrid.Size = new System.Drawing.Size(47, 19);
            this.reloadGrid.TabIndex = 2;
            this.reloadGrid.Text = "reload";
            this.reloadGrid.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.reloadGrid.UseCustomBackColor = true;
            this.reloadGrid.UseCustomForeColor = true;
            this.reloadGrid.Click += new System.EventHandler(this.reloadGrid_Click);
            this.reloadGrid.MouseEnter += new System.EventHandler(this.reloadGrid_MouseEnter);
            this.reloadGrid.MouseLeave += new System.EventHandler(this.reloadGrid_MouseLeave);
            // 
            // closeForm
            // 
            this.closeForm.AutoSize = true;
            this.closeForm.BackColor = System.Drawing.Color.Black;
            this.closeForm.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.closeForm.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.closeForm.ForeColor = System.Drawing.Color.DodgerBlue;
            this.closeForm.Location = new System.Drawing.Point(317, -1);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(25, 25);
            this.closeForm.TabIndex = 3;
            this.closeForm.Text = " x";
            this.closeForm.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.closeForm.UseCustomBackColor = true;
            this.closeForm.UseCustomForeColor = true;
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            this.closeForm.MouseEnter += new System.EventHandler(this.closeForm_MouseEnter);
            this.closeForm.MouseLeave += new System.EventHandler(this.closeForm_MouseLeave);
            // 
            // DecimalCol
            // 
            this.DecimalCol.HeaderText = "Decimal";
            this.DecimalCol.Name = "DecimalCol";
            this.DecimalCol.ReadOnly = true;
            this.DecimalCol.Width = 80;
            // 
            // TotalTimeCol
            // 
            this.TotalTimeCol.HeaderText = "Total Time";
            this.TotalTimeCol.Name = "TotalTimeCol";
            this.TotalTimeCol.ReadOnly = true;
            this.TotalTimeCol.Width = 80;
            // 
            // EndTimeColumn
            // 
            this.EndTimeColumn.HeaderText = "End Time";
            this.EndTimeColumn.MaxInputLength = 5;
            this.EndTimeColumn.Name = "EndTimeColumn";
            this.EndTimeColumn.ReadOnly = true;
            this.EndTimeColumn.Width = 80;
            // 
            // StartTimeColumn
            // 
            this.StartTimeColumn.HeaderText = "Start Time";
            this.StartTimeColumn.MaxInputLength = 5;
            this.StartTimeColumn.Name = "StartTimeColumn";
            this.StartTimeColumn.ReadOnly = true;
            this.StartTimeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StartTimeColumn.Width = 80;
            // 
            // gridMetro
            // 
            this.gridMetro.AllowUserToDeleteRows = false;
            this.gridMetro.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gridMetro.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gridMetro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gridMetro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridMetro.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridMetro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMetro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridMetro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMetro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StartTimeColumn,
            this.EndTimeColumn,
            this.TotalTimeCol,
            this.DecimalCol});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridMetro.DefaultCellStyle = dataGridViewCellStyle8;
            this.gridMetro.EnableHeadersVisualStyles = false;
            this.gridMetro.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridMetro.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gridMetro.Location = new System.Drawing.Point(19, 103);
            this.gridMetro.MultiSelect = false;
            this.gridMetro.Name = "gridMetro";
            this.gridMetro.ReadOnly = true;
            this.gridMetro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMetro.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gridMetro.RowHeadersVisible = false;
            this.gridMetro.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.gridMetro.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.gridMetro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMetro.Size = new System.Drawing.Size(323, 167);
            this.gridMetro.TabIndex = 4;
            this.gridMetro.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.gridMetro.UseCustomBackColor = true;
            this.gridMetro.UseStyleColors = true;
            this.gridMetro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMetro_CellClick);
            this.gridMetro.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridMetro_CellFormatting);
            // 
            // mAddTimeButton
            // 
            this.mAddTimeButton.Enabled = false;
            this.mAddTimeButton.Location = new System.Drawing.Point(143, 41);
            this.mAddTimeButton.Name = "mAddTimeButton";
            this.mAddTimeButton.Size = new System.Drawing.Size(194, 39);
            this.mAddTimeButton.TabIndex = 1;
            this.mAddTimeButton.Text = "Add Time";
            this.mAddTimeButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mAddTimeButton.UseSelectable = true;
            this.mAddTimeButton.Click += new System.EventHandler(this.mAddTimeButton_Click);
            // 
            // labelTimeTip1
            // 
            this.labelTimeTip1.AutoSize = true;
            this.labelTimeTip1.Location = new System.Drawing.Point(17, 277);
            this.labelTimeTip1.Name = "labelTimeTip1";
            this.labelTimeTip1.Size = new System.Drawing.Size(72, 19);
            this.labelTimeTip1.TabIndex = 10;
            this.labelTimeTip1.Text = "Reload Tip";
            this.labelTimeTip1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // alwaysCheckBox
            // 
            this.alwaysCheckBox.AutoSize = true;
            this.alwaysCheckBox.Location = new System.Drawing.Point(19, 305);
            this.alwaysCheckBox.Name = "alwaysCheckBox";
            this.alwaysCheckBox.Size = new System.Drawing.Size(96, 15);
            this.alwaysCheckBox.TabIndex = 5;
            this.alwaysCheckBox.Text = "always on top";
            this.alwaysCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.alwaysCheckBox.UseSelectable = true;
            this.alwaysCheckBox.CheckedChanged += new System.EventHandler(this.alwaysCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(354, 334);
            this.Controls.Add(this.alwaysCheckBox);
            this.Controls.Add(this.labelTimeTip1);
            this.Controls.Add(this.mAddTimeButton);
            this.Controls.Add(this.closeForm);
            this.Controls.Add(this.reloadGrid);
            this.Controls.Add(this.gridMetro);
            this.Controls.Add(this.timeBox);
            this.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Calc Job Time";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridMetro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox timeBox;
        private MetroFramework.Controls.MetroLabel reloadGrid;
        private MetroFramework.Controls.MetroLabel closeForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn DecimalCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalTimeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTimeColumn;
        private MetroFramework.Controls.MetroGrid gridMetro;
        private MetroFramework.Controls.MetroButton mAddTimeButton;
        private MetroFramework.Controls.MetroLabel labelTimeTip1;
        private MetroFramework.Controls.MetroCheckBox alwaysCheckBox;
    }
}
