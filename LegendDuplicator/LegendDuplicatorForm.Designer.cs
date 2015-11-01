namespace LegendDuplicator
{
    partial class LegendDuplicatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LegendDuplicatorForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvSheets = new System.Windows.Forms.DataGridView();
            this.SheetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddRevision = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.labelTechnology = new System.Windows.Forms.Label();
            this.designLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSheets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.groupBox1.Location = new System.Drawing.Point(12, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 385);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sheets:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvSheets);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.panel1.Location = new System.Drawing.Point(6, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 350);
            this.panel1.TabIndex = 0;
            // 
            // dgvSheets
            // 
            this.dgvSheets.AllowUserToAddRows = false;
            this.dgvSheets.AllowUserToDeleteRows = false;
            this.dgvSheets.AllowUserToResizeRows = false;
            this.dgvSheets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSheets.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSheets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSheets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSheets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SheetName,
            this.Number,
            this.AddRevision});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSheets.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSheets.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvSheets.Location = new System.Drawing.Point(4, 5);
            this.dgvSheets.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvSheets.Name = "dgvSheets";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSheets.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSheets.RowHeadersVisible = false;
            this.dgvSheets.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvSheets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSheets.ShowEditingIcon = false;
            this.dgvSheets.Size = new System.Drawing.Size(706, 340);
            this.dgvSheets.TabIndex = 1;
            this.dgvSheets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSheets_CellContentClick);
            this.dgvSheets.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSheets_CellMouseDown);
            this.dgvSheets.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvSheets_CurrentCellDirtyStateChanged);
            // 
            // SheetName
            // 
            this.SheetName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SheetName.DataPropertyName = "Name";
            this.SheetName.HeaderText = "Sheet Name";
            this.SheetName.Name = "SheetName";
            this.SheetName.ReadOnly = true;
            // 
            // Number
            // 
            this.Number.DataPropertyName = "Number";
            this.Number.HeaderText = "Sheet Number";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 150;
            // 
            // AddRevision
            // 
            this.AddRevision.DataPropertyName = "SelectSheet";
            this.AddRevision.HeaderText = "Select";
            this.AddRevision.Name = "AddRevision";
            this.AddRevision.Width = 70;
            // 
            // labelTechnology
            // 
            this.labelTechnology.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTechnology.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(210)))));
            this.labelTechnology.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTechnology.Location = new System.Drawing.Point(414, 42);
            this.labelTechnology.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTechnology.Name = "labelTechnology";
            this.labelTechnology.Size = new System.Drawing.Size(202, 31);
            this.labelTechnology.TabIndex = 13;
            this.labelTechnology.Text = "TECHNOLOGY";
            this.labelTechnology.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // designLabel
            // 
            this.designLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(210)))));
            this.designLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.designLabel.Location = new System.Drawing.Point(414, 12);
            this.designLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.designLabel.Name = "designLabel";
            this.designLabel.Size = new System.Drawing.Size(180, 31);
            this.designLabel.TabIndex = 12;
            this.designLabel.Text = "DESIGN";
            this.designLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(388, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(626, 547);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(112, 35);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // LegendDuplicatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 594);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.labelTechnology);
            this.Controls.Add(this.designLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(772, 650);
            this.Name = "LegendDuplicatorForm";
            this.ShowIcon = false;
            this.Text = "Grimshaw DT - Legend Duplicator";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSheets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvSheets;
        private System.Windows.Forms.DataGridViewTextBoxColumn SheetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AddRevision;
        private System.Windows.Forms.Label labelTechnology;
        private System.Windows.Forms.Label designLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOK;
    }
}