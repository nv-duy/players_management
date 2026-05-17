namespace clubsForm
{
    partial class Formteam
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
            this.dgvTeams = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.cbbTactic = new System.Windows.Forms.ComboBox();
            this.lbTactic = new System.Windows.Forms.Label();
            this.cbbCoach = new System.Windows.Forms.ComboBox();
            this.lbCoach = new System.Windows.Forms.Label();
            this.cbbCountry = new System.Windows.Forms.ComboBox();
            this.lbCountry = new System.Windows.Forms.Label();
            this.cbbName = new System.Windows.Forms.ComboBox();
            this.lbName = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tactic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTeams
            // 
            this.dgvTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.country,
            this.coach,
            this.tactic});
            this.dgvTeams.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTeams.Location = new System.Drawing.Point(0, 253);
            this.dgvTeams.Name = "dgvTeams";
            this.dgvTeams.RowHeadersWidth = 51;
            this.dgvTeams.RowTemplate.Height = 24;
            this.dgvTeams.Size = new System.Drawing.Size(1336, 256);
            this.dgvTeams.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.tbSearch);
            this.splitContainer1.Panel1.Controls.Add(this.lbSearch);
            this.splitContainer1.Panel1.Controls.Add(this.lbCount);
            this.splitContainer1.Panel1.Controls.Add(this.cbbTactic);
            this.splitContainer1.Panel1.Controls.Add(this.lbTactic);
            this.splitContainer1.Panel1.Controls.Add(this.cbbCoach);
            this.splitContainer1.Panel1.Controls.Add(this.lbCoach);
            this.splitContainer1.Panel1.Controls.Add(this.cbbCountry);
            this.splitContainer1.Panel1.Controls.Add(this.lbCountry);
            this.splitContainer1.Panel1.Controls.Add(this.cbbName);
            this.splitContainer1.Panel1.Controls.Add(this.lbName);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnDel);
            this.splitContainer1.Panel2.Controls.Add(this.btnEdit);
            this.splitContainer1.Panel2.Controls.Add(this.btnAdd);
            this.splitContainer1.Size = new System.Drawing.Size(1336, 253);
            this.splitContainer1.SplitterDistance = 916;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(767, 162);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 37);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(128, 162);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(596, 37);
            this.tbSearch.TabIndex = 4;
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.Location = new System.Drawing.Point(35, 171);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(69, 18);
            this.lbSearch.TabIndex = 3;
            this.lbSearch.Text = "Tìm kiếm";
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCount.Location = new System.Drawing.Point(743, 217);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(142, 20);
            this.lbCount.TabIndex = 2;
            this.lbCount.Text = "Số lượng đội hình:";
            // 
            // cbbTactic
            // 
            this.cbbTactic.FormattingEnabled = true;
            this.cbbTactic.Location = new System.Drawing.Point(128, 113);
            this.cbbTactic.Name = "cbbTactic";
            this.cbbTactic.Size = new System.Drawing.Size(596, 24);
            this.cbbTactic.TabIndex = 1;
            // 
            // lbTactic
            // 
            this.lbTactic.AutoSize = true;
            this.lbTactic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTactic.Location = new System.Drawing.Point(23, 117);
            this.lbTactic.Name = "lbTactic";
            this.lbTactic.Size = new System.Drawing.Size(99, 20);
            this.lbTactic.TabIndex = 0;
            this.lbTactic.Text = "Chiến thuật:";
            this.lbTactic.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbbCoach
            // 
            this.cbbCoach.FormattingEnabled = true;
            this.cbbCoach.Location = new System.Drawing.Point(128, 83);
            this.cbbCoach.Name = "cbbCoach";
            this.cbbCoach.Size = new System.Drawing.Size(596, 24);
            this.cbbCoach.TabIndex = 1;
            // 
            // lbCoach
            // 
            this.lbCoach.AutoSize = true;
            this.lbCoach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCoach.Location = new System.Drawing.Point(23, 87);
            this.lbCoach.Name = "lbCoach";
            this.lbCoach.Size = new System.Drawing.Size(48, 20);
            this.lbCoach.TabIndex = 0;
            this.lbCoach.Text = "HLV:";
            // 
            // cbbCountry
            // 
            this.cbbCountry.FormattingEnabled = true;
            this.cbbCountry.Location = new System.Drawing.Point(128, 53);
            this.cbbCountry.Name = "cbbCountry";
            this.cbbCountry.Size = new System.Drawing.Size(596, 24);
            this.cbbCountry.TabIndex = 1;
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountry.Location = new System.Drawing.Point(23, 57);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(81, 20);
            this.lbCountry.TabIndex = 0;
            this.lbCountry.Text = "Quốc gia:";
            this.lbCountry.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbbName
            // 
            this.cbbName.FormattingEnabled = true;
            this.cbbName.Location = new System.Drawing.Point(128, 23);
            this.cbbName.Name = "cbbName";
            this.cbbName.Size = new System.Drawing.Size(596, 24);
            this.cbbName.TabIndex = 1;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(23, 27);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(81, 20);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Tên CLB:";
            this.lbName.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(232, 140);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(96, 59);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(130, 140);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(96, 59);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(130, 27);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(198, 107);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Tên CLB";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // country
            // 
            this.country.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.country.HeaderText = "Quốc gia";
            this.country.MinimumWidth = 6;
            this.country.Name = "country";
            this.country.ReadOnly = true;
            // 
            // coach
            // 
            this.coach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coach.HeaderText = "HLV";
            this.coach.MinimumWidth = 6;
            this.coach.Name = "coach";
            this.coach.ReadOnly = true;
            // 
            // tactic
            // 
            this.tactic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tactic.HeaderText = "Chiến thuật";
            this.tactic.MinimumWidth = 6;
            this.tactic.Name = "tactic";
            this.tactic.ReadOnly = true;
            // 
            // Formteam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 509);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.dgvTeams);
            this.Name = "Formteam";
            this.Text = "Quản lý đội hình";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeams)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.DataGridView dgvTeams;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cbbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.ComboBox cbbTactic;
        private System.Windows.Forms.Label lbTactic;
        private System.Windows.Forms.ComboBox cbbCoach;
        private System.Windows.Forms.Label lbCoach;
        private System.Windows.Forms.ComboBox cbbCountry;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn country;
        private System.Windows.Forms.DataGridViewTextBoxColumn coach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tactic;
    }
}

