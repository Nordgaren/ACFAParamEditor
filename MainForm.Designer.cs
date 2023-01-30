﻿namespace ACFAParamEditor
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.RowDGV = new System.Windows.Forms.DataGridView();
            this.rowid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rowname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParamDGV = new System.Windows.Forms.DataGridView();
            this.paramname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paramtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CellDGV = new System.Windows.Forms.DataGridView();
            this.celltype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellvalue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SplitContainerA = new System.Windows.Forms.SplitContainer();
            this.SplitContainerB = new System.Windows.Forms.SplitContainer();
            this.ReaderStatusStrip = new System.Windows.Forms.StatusStrip();
            this.TSSLParamReading = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSLRowReading = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSLCellReading = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSLDefReading = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileMS = new System.Windows.Forms.ToolStripMenuItem();
            this.ConvertMS = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMS = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenParamsFMS = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFMS = new System.Windows.Forms.ToolStripMenuItem();
            this.ConvertDefXmlCMS = new System.Windows.Forms.ToolStripMenuItem();
            this.ConvertParamTSVCMS = new System.Windows.Forms.ToolStripMenuItem();
            this.ConvertTSVParamCMS = new System.Windows.Forms.ToolStripMenuItem();
            this.ConvertParamCSVCMS = new System.Windows.Forms.ToolStripMenuItem();
            this.ConvertCSVParamCMS = new System.Windows.Forms.ToolStripMenuItem();
            this.RowMS = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteRowRMS = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutHMS = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyRowRMS = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.RowDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParamDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CellDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerA)).BeginInit();
            this.SplitContainerA.Panel1.SuspendLayout();
            this.SplitContainerA.Panel2.SuspendLayout();
            this.SplitContainerA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerB)).BeginInit();
            this.SplitContainerB.Panel1.SuspendLayout();
            this.SplitContainerB.Panel2.SuspendLayout();
            this.SplitContainerB.SuspendLayout();
            this.ReaderStatusStrip.SuspendLayout();
            this.MainFormMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // RowDGV
            // 
            this.RowDGV.AllowUserToAddRows = false;
            this.RowDGV.AllowUserToDeleteRows = false;
            this.RowDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RowDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.RowDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.RowDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RowDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.NullValue = "null";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RowDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.RowDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RowDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowid,
            this.rowname});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.NullValue = "null";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RowDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.RowDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RowDGV.Location = new System.Drawing.Point(0, 0);
            this.RowDGV.Name = "RowDGV";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RowDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.RowDGV.Size = new System.Drawing.Size(370, 605);
            this.RowDGV.TabIndex = 1;
            this.RowDGV.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.RowDGV_CellValueChanged);
            this.RowDGV.SelectionChanged += new System.EventHandler(this.RowDGV_SelectionChanged);
            // 
            // rowid
            // 
            this.rowid.FillWeight = 48.63222F;
            this.rowid.HeaderText = "Row ID";
            this.rowid.Name = "rowid";
            // 
            // rowname
            // 
            this.rowname.FillWeight = 151.3678F;
            this.rowname.HeaderText = "Row Name";
            this.rowname.Name = "rowname";
            // 
            // ParamDGV
            // 
            this.ParamDGV.AllowUserToAddRows = false;
            this.ParamDGV.AllowUserToDeleteRows = false;
            this.ParamDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ParamDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.ParamDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.ParamDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ParamDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.NullValue = "null";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ParamDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ParamDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ParamDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paramname,
            this.paramtype});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.NullValue = "null";
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ParamDGV.DefaultCellStyle = dataGridViewCellStyle5;
            this.ParamDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParamDGV.Location = new System.Drawing.Point(0, 0);
            this.ParamDGV.Name = "ParamDGV";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ParamDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.ParamDGV.Size = new System.Drawing.Size(370, 605);
            this.ParamDGV.TabIndex = 0;
            this.ParamDGV.SelectionChanged += new System.EventHandler(this.ParamDGV_SelectionChanged);
            // 
            // paramname
            // 
            this.paramname.HeaderText = "Param Name";
            this.paramname.Name = "paramname";
            this.paramname.ReadOnly = true;
            // 
            // paramtype
            // 
            this.paramtype.HeaderText = "Param Type";
            this.paramtype.Name = "paramtype";
            this.paramtype.ReadOnly = true;
            // 
            // CellDGV
            // 
            this.CellDGV.AllowUserToAddRows = false;
            this.CellDGV.AllowUserToDeleteRows = false;
            this.CellDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CellDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.CellDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.CellDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CellDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.NullValue = "null";
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CellDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.CellDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CellDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.celltype,
            this.cellname,
            this.cellvalue});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.NullValue = "null";
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CellDGV.DefaultCellStyle = dataGridViewCellStyle8;
            this.CellDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CellDGV.Location = new System.Drawing.Point(0, 0);
            this.CellDGV.Name = "CellDGV";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CellDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.CellDGV.Size = new System.Drawing.Size(370, 605);
            this.CellDGV.TabIndex = 2;
            this.CellDGV.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellDGV_CellValueChanged);
            // 
            // celltype
            // 
            this.celltype.HeaderText = "Cell Type";
            this.celltype.Name = "celltype";
            this.celltype.ReadOnly = true;
            // 
            // cellname
            // 
            this.cellname.HeaderText = "Cell Name";
            this.cellname.Name = "cellname";
            this.cellname.ReadOnly = true;
            // 
            // cellvalue
            // 
            this.cellvalue.HeaderText = "Cell Value";
            this.cellvalue.Name = "cellvalue";
            // 
            // SplitContainerA
            // 
            this.SplitContainerA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainerA.ForeColor = System.Drawing.SystemColors.Control;
            this.SplitContainerA.Location = new System.Drawing.Point(0, 24);
            this.SplitContainerA.Name = "SplitContainerA";
            // 
            // SplitContainerA.Panel1
            // 
            this.SplitContainerA.Panel1.Controls.Add(this.ParamDGV);
            this.SplitContainerA.Panel1.ForeColor = System.Drawing.SystemColors.Control;
            // 
            // SplitContainerA.Panel2
            // 
            this.SplitContainerA.Panel2.Controls.Add(this.SplitContainerB);
            this.SplitContainerA.Panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.SplitContainerA.Size = new System.Drawing.Size(1118, 605);
            this.SplitContainerA.SplitterDistance = 370;
            this.SplitContainerA.TabIndex = 4;
            // 
            // SplitContainerB
            // 
            this.SplitContainerB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainerB.Location = new System.Drawing.Point(0, 0);
            this.SplitContainerB.Name = "SplitContainerB";
            // 
            // SplitContainerB.Panel1
            // 
            this.SplitContainerB.Panel1.Controls.Add(this.RowDGV);
            this.SplitContainerB.Panel1.ForeColor = System.Drawing.SystemColors.Control;
            // 
            // SplitContainerB.Panel2
            // 
            this.SplitContainerB.Panel2.Controls.Add(this.CellDGV);
            this.SplitContainerB.Size = new System.Drawing.Size(744, 605);
            this.SplitContainerB.SplitterDistance = 370;
            this.SplitContainerB.TabIndex = 1;
            // 
            // ReaderStatusStrip
            // 
            this.ReaderStatusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ReaderStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSLParamReading,
            this.TSSLRowReading,
            this.TSSLCellReading,
            this.TSSLDefReading});
            this.ReaderStatusStrip.Location = new System.Drawing.Point(0, 629);
            this.ReaderStatusStrip.Name = "ReaderStatusStrip";
            this.ReaderStatusStrip.Size = new System.Drawing.Size(1118, 22);
            this.ReaderStatusStrip.TabIndex = 1;
            // 
            // TSSLParamReading
            // 
            this.TSSLParamReading.ForeColor = System.Drawing.SystemColors.Control;
            this.TSSLParamReading.Name = "TSSLParamReading";
            this.TSSLParamReading.Size = new System.Drawing.Size(0, 17);
            // 
            // TSSLRowReading
            // 
            this.TSSLRowReading.ForeColor = System.Drawing.SystemColors.Control;
            this.TSSLRowReading.Name = "TSSLRowReading";
            this.TSSLRowReading.Size = new System.Drawing.Size(0, 17);
            // 
            // TSSLCellReading
            // 
            this.TSSLCellReading.ForeColor = System.Drawing.SystemColors.Control;
            this.TSSLCellReading.Name = "TSSLCellReading";
            this.TSSLCellReading.Size = new System.Drawing.Size(0, 17);
            // 
            // TSSLDefReading
            // 
            this.TSSLDefReading.ForeColor = System.Drawing.SystemColors.Control;
            this.TSSLDefReading.Name = "TSSLDefReading";
            this.TSSLDefReading.Size = new System.Drawing.Size(0, 17);
            // 
            // MainFormMenuStrip
            // 
            this.MainFormMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.MainFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMS,
            this.ConvertMS,
            this.RowMS,
            this.HelpMS});
            this.MainFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainFormMenuStrip.Name = "MainFormMenuStrip";
            this.MainFormMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MainFormMenuStrip.Size = new System.Drawing.Size(1118, 24);
            this.MainFormMenuStrip.TabIndex = 1;
            this.MainFormMenuStrip.Text = "MainFormMenuStrip";
            // 
            // FileMS
            // 
            this.FileMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.FileMS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenParamsFMS,
            this.SaveFMS});
            this.FileMS.ForeColor = System.Drawing.SystemColors.Control;
            this.FileMS.Name = "FileMS";
            this.FileMS.Size = new System.Drawing.Size(37, 20);
            this.FileMS.Text = "File";
            // 
            // ConvertMS
            // 
            this.ConvertMS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConvertDefXmlCMS,
            this.ConvertParamCSVCMS,
            this.ConvertCSVParamCMS,
            this.ConvertParamTSVCMS,
            this.ConvertTSVParamCMS});
            this.ConvertMS.ForeColor = System.Drawing.SystemColors.Control;
            this.ConvertMS.Name = "ConvertMS";
            this.ConvertMS.Size = new System.Drawing.Size(61, 20);
            this.ConvertMS.Text = "Convert";
            // 
            // HelpMS
            // 
            this.HelpMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.HelpMS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutHMS});
            this.HelpMS.ForeColor = System.Drawing.SystemColors.Control;
            this.HelpMS.Name = "HelpMS";
            this.HelpMS.Size = new System.Drawing.Size(44, 20);
            this.HelpMS.Text = "Help";
            // 
            // OpenParamsFMS
            // 
            this.OpenParamsFMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.OpenParamsFMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OpenParamsFMS.ForeColor = System.Drawing.SystemColors.Control;
            this.OpenParamsFMS.Name = "OpenParamsFMS";
            this.OpenParamsFMS.Size = new System.Drawing.Size(180, 22);
            this.OpenParamsFMS.Text = "Open Params";
            this.OpenParamsFMS.Click += new System.EventHandler(this.OpenParamsFMS_click);
            // 
            // SaveFMS
            // 
            this.SaveFMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.SaveFMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SaveFMS.ForeColor = System.Drawing.SystemColors.Control;
            this.SaveFMS.Name = "SaveFMS";
            this.SaveFMS.Size = new System.Drawing.Size(180, 22);
            this.SaveFMS.Text = "Save";
            this.SaveFMS.Click += new System.EventHandler(this.SaveFMS_Click);
            // 
            // ConvertDefXmlCMS
            // 
            this.ConvertDefXmlCMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ConvertDefXmlCMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ConvertDefXmlCMS.ForeColor = System.Drawing.SystemColors.Control;
            this.ConvertDefXmlCMS.Name = "ConvertDefXmlCMS";
            this.ConvertDefXmlCMS.Size = new System.Drawing.Size(206, 22);
            this.ConvertDefXmlCMS.Text = "Convert Defs to Xml Defs";
            this.ConvertDefXmlCMS.Click += new System.EventHandler(this.ConvertDefXmlCMS_Click);
            // 
            // ConvertParamTSVCMS
            // 
            this.ConvertParamTSVCMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ConvertParamTSVCMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ConvertParamTSVCMS.ForeColor = System.Drawing.SystemColors.Control;
            this.ConvertParamTSVCMS.Name = "ConvertParamTSVCMS";
            this.ConvertParamTSVCMS.Size = new System.Drawing.Size(206, 22);
            this.ConvertParamTSVCMS.Text = "Convert Params to TSV";
            this.ConvertParamTSVCMS.Click += new System.EventHandler(this.ConvertParamTSVCMS_Click);
            // 
            // ConvertTSVParamCMS
            // 
            this.ConvertTSVParamCMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ConvertTSVParamCMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ConvertTSVParamCMS.ForeColor = System.Drawing.SystemColors.Control;
            this.ConvertTSVParamCMS.Name = "ConvertTSVParamCMS";
            this.ConvertTSVParamCMS.Size = new System.Drawing.Size(206, 22);
            this.ConvertTSVParamCMS.Text = "Convert TSV to Params";
            this.ConvertTSVParamCMS.Click += new System.EventHandler(this.ConvertTSVParamCMS_Click);
            // 
            // ConvertParamCSVCMS
            // 
            this.ConvertParamCSVCMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ConvertParamCSVCMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ConvertParamCSVCMS.ForeColor = System.Drawing.SystemColors.Control;
            this.ConvertParamCSVCMS.Name = "ConvertParamCSVCMS";
            this.ConvertParamCSVCMS.Size = new System.Drawing.Size(206, 22);
            this.ConvertParamCSVCMS.Text = "Convert Params to CSV";
            this.ConvertParamCSVCMS.Click += new System.EventHandler(this.ConvertParamCSVCMS_Click);
            // 
            // ConvertCSVParamCMS
            // 
            this.ConvertCSVParamCMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ConvertCSVParamCMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ConvertCSVParamCMS.ForeColor = System.Drawing.SystemColors.Control;
            this.ConvertCSVParamCMS.Name = "ConvertCSVParamCMS";
            this.ConvertCSVParamCMS.Size = new System.Drawing.Size(206, 22);
            this.ConvertCSVParamCMS.Text = "Convert CSV to Params";
            this.ConvertCSVParamCMS.Click += new System.EventHandler(this.ConvertCSVParamCMS_Click);
            // 
            // RowMS
            // 
            this.RowMS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyRowRMS,
            this.DeleteRowRMS});
            this.RowMS.ForeColor = System.Drawing.SystemColors.Control;
            this.RowMS.Name = "RowMS";
            this.RowMS.Size = new System.Drawing.Size(47, 20);
            this.RowMS.Text = "Rows";
            // 
            // DeleteRowRMS
            // 
            this.DeleteRowRMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.DeleteRowRMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DeleteRowRMS.ForeColor = System.Drawing.SystemColors.Control;
            this.DeleteRowRMS.Name = "DeleteRowRMS";
            this.DeleteRowRMS.Size = new System.Drawing.Size(180, 22);
            this.DeleteRowRMS.Text = "Delete Row";
            this.DeleteRowRMS.Click += new System.EventHandler(this.DeleteRowRMS_Click);
            // 
            // AboutHMS
            // 
            this.AboutHMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.AboutHMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AboutHMS.ForeColor = System.Drawing.SystemColors.Control;
            this.AboutHMS.Name = "AboutHMS";
            this.AboutHMS.Size = new System.Drawing.Size(180, 22);
            this.AboutHMS.Text = "About";
            this.AboutHMS.Click += new System.EventHandler(this.AboutHMS_Click);
            // 
            // CopyRowRMS
            // 
            this.CopyRowRMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.CopyRowRMS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CopyRowRMS.ForeColor = System.Drawing.SystemColors.Control;
            this.CopyRowRMS.Name = "CopyRowRMS";
            this.CopyRowRMS.Size = new System.Drawing.Size(180, 22);
            this.CopyRowRMS.Text = "Copy Row";
            this.CopyRowRMS.Click += new System.EventHandler(this.CopyRowRMS_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1118, 651);
            this.Controls.Add(this.SplitContainerA);
            this.Controls.Add(this.ReaderStatusStrip);
            this.Controls.Add(this.MainFormMenuStrip);
            this.MainMenuStrip = this.MainFormMenuStrip;
            this.Name = "MainForm";
            this.Text = "Armored Core For Answer Param Editor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RowDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParamDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CellDGV)).EndInit();
            this.SplitContainerA.Panel1.ResumeLayout(false);
            this.SplitContainerA.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerA)).EndInit();
            this.SplitContainerA.ResumeLayout(false);
            this.SplitContainerB.Panel1.ResumeLayout(false);
            this.SplitContainerB.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerB)).EndInit();
            this.SplitContainerB.ResumeLayout(false);
            this.ReaderStatusStrip.ResumeLayout(false);
            this.ReaderStatusStrip.PerformLayout();
            this.MainFormMenuStrip.ResumeLayout(false);
            this.MainFormMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView CellDGV;
        private System.Windows.Forms.DataGridView RowDGV;
        private System.Windows.Forms.DataGridView ParamDGV;
        private System.Windows.Forms.SplitContainer SplitContainerA;
        private System.Windows.Forms.SplitContainer SplitContainerB;
        private System.Windows.Forms.StatusStrip ReaderStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel TSSLParamReading;
        private System.Windows.Forms.ToolStripStatusLabel TSSLRowReading;
        private System.Windows.Forms.ToolStripStatusLabel TSSLCellReading;
        private System.Windows.Forms.ToolStripStatusLabel TSSLDefReading;
        private System.Windows.Forms.DataGridViewTextBoxColumn paramname;
        private System.Windows.Forms.DataGridViewTextBoxColumn paramtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn celltype;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellname;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellvalue;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowid;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowname;
        private System.Windows.Forms.MenuStrip MainFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileMS;
        private System.Windows.Forms.ToolStripMenuItem OpenParamsFMS;
        private System.Windows.Forms.ToolStripMenuItem SaveFMS;
        private System.Windows.Forms.ToolStripMenuItem ConvertMS;
        private System.Windows.Forms.ToolStripMenuItem ConvertDefXmlCMS;
        private System.Windows.Forms.ToolStripMenuItem ConvertParamCSVCMS;
        private System.Windows.Forms.ToolStripMenuItem ConvertCSVParamCMS;
        private System.Windows.Forms.ToolStripMenuItem ConvertParamTSVCMS;
        private System.Windows.Forms.ToolStripMenuItem ConvertTSVParamCMS;
        private System.Windows.Forms.ToolStripMenuItem RowMS;
        private System.Windows.Forms.ToolStripMenuItem DeleteRowRMS;
        private System.Windows.Forms.ToolStripMenuItem HelpMS;
        private System.Windows.Forms.ToolStripMenuItem AboutHMS;
        private System.Windows.Forms.ToolStripMenuItem CopyRowRMS;
    }
}

