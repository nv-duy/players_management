namespace player
{
    partial class Formsub
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnUnsub = new System.Windows.Forms.Button();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.dgvAll = new System.Windows.Forms.DataGridView();
            this.lbteamname = new System.Windows.Forms.Label();
            this.mainName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainOvr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainClb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbcoachname = new System.Windows.Forms.Label();
            this.subName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subOvr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subClb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAll)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvMain);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvAll);
            this.splitContainer1.Size = new System.Drawing.Size(1345, 378);
            this.splitContainer1.SplitterDistance = 704;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnSub
            // 
            this.btnSub.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(1218, 378);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(127, 57);
            this.btnSub.TabIndex = 1;
            this.btnSub.Text = "Thêm";
            this.btnSub.UseVisualStyleBackColor = true;
            // 
            // btnUnsub
            // 
            this.btnUnsub.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUnsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnsub.Location = new System.Drawing.Point(0, 378);
            this.btnUnsub.Name = "btnUnsub";
            this.btnUnsub.Size = new System.Drawing.Size(127, 57);
            this.btnUnsub.TabIndex = 1;
            this.btnUnsub.Text = "Loại";
            this.btnUnsub.UseVisualStyleBackColor = true;
            // 
            // dgvMain
            // 
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mainName,
            this.mainCountry,
            this.mainOvr,
            this.mainClb,
            this.mainPosition});
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(0, 0);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersWidth = 51;
            this.dgvMain.RowTemplate.Height = 24;
            this.dgvMain.Size = new System.Drawing.Size(704, 378);
            this.dgvMain.TabIndex = 0;
            // 
            // dgvAll
            // 
            this.dgvAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subName,
            this.subCountry,
            this.subOvr,
            this.subClb,
            this.subPosition});
            this.dgvAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAll.Location = new System.Drawing.Point(0, 0);
            this.dgvAll.Name = "dgvAll";
            this.dgvAll.RowHeadersWidth = 51;
            this.dgvAll.RowTemplate.Height = 24;
            this.dgvAll.Size = new System.Drawing.Size(637, 378);
            this.dgvAll.TabIndex = 0;
            // 
            // lbteamname
            // 
            this.lbteamname.AutoSize = true;
            this.lbteamname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbteamname.Location = new System.Drawing.Point(284, 381);
            this.lbteamname.Name = "lbteamname";
            this.lbteamname.Size = new System.Drawing.Size(48, 20);
            this.lbteamname.TabIndex = 2;
            this.lbteamname.Text = "CLB:";
            // 
            // mainName
            // 
            this.mainName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mainName.HeaderText = "Tên cầu thủ";
            this.mainName.MinimumWidth = 6;
            this.mainName.Name = "mainName";
            this.mainName.ReadOnly = true;
            // 
            // mainCountry
            // 
            this.mainCountry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mainCountry.HeaderText = "Quốc tịch";
            this.mainCountry.MinimumWidth = 6;
            this.mainCountry.Name = "mainCountry";
            this.mainCountry.ReadOnly = true;
            // 
            // mainOvr
            // 
            this.mainOvr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mainOvr.HeaderText = "Chỉ số";
            this.mainOvr.MinimumWidth = 6;
            this.mainOvr.Name = "mainOvr";
            this.mainOvr.ReadOnly = true;
            // 
            // mainClb
            // 
            this.mainClb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mainClb.HeaderText = "CLB";
            this.mainClb.MinimumWidth = 6;
            this.mainClb.Name = "mainClb";
            this.mainClb.ReadOnly = true;
            // 
            // mainPosition
            // 
            this.mainPosition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mainPosition.HeaderText = "Vị trí";
            this.mainPosition.MinimumWidth = 6;
            this.mainPosition.Name = "mainPosition";
            this.mainPosition.ReadOnly = true;
            // 
            // lbcoachname
            // 
            this.lbcoachname.AutoSize = true;
            this.lbcoachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcoachname.Location = new System.Drawing.Point(284, 415);
            this.lbcoachname.Name = "lbcoachname";
            this.lbcoachname.Size = new System.Drawing.Size(48, 20);
            this.lbcoachname.TabIndex = 2;
            this.lbcoachname.Text = "HLV:";
            // 
            // subName
            // 
            this.subName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subName.HeaderText = "Tên cầu thủ";
            this.subName.MinimumWidth = 6;
            this.subName.Name = "subName";
            this.subName.ReadOnly = true;
            // 
            // subCountry
            // 
            this.subCountry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subCountry.HeaderText = "Quốc tịch";
            this.subCountry.MinimumWidth = 6;
            this.subCountry.Name = "subCountry";
            this.subCountry.ReadOnly = true;
            // 
            // subOvr
            // 
            this.subOvr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subOvr.HeaderText = "Chỉ số";
            this.subOvr.MinimumWidth = 6;
            this.subOvr.Name = "subOvr";
            this.subOvr.ReadOnly = true;
            // 
            // subClb
            // 
            this.subClb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subClb.HeaderText = "CLB";
            this.subClb.MinimumWidth = 6;
            this.subClb.Name = "subClb";
            this.subClb.ReadOnly = true;
            // 
            // subPosition
            // 
            this.subPosition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subPosition.HeaderText = "Vị trí";
            this.subPosition.MinimumWidth = 6;
            this.subPosition.Name = "subPosition";
            this.subPosition.ReadOnly = true;
            // 
            // Formsub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 435);
            this.Controls.Add(this.lbcoachname);
            this.Controls.Add(this.lbteamname);
            this.Controls.Add(this.btnUnsub);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Formsub";
            this.Text = "Quản lý đội hình";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnUnsub;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.DataGridView dgvAll;
        private System.Windows.Forms.Label lbteamname;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainName;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainOvr;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainClb;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainPosition;
        private System.Windows.Forms.Label lbcoachname;
        private System.Windows.Forms.DataGridViewTextBoxColumn subName;
        private System.Windows.Forms.DataGridViewTextBoxColumn subCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn subOvr;
        private System.Windows.Forms.DataGridViewTextBoxColumn subClb;
        private System.Windows.Forms.DataGridViewTextBoxColumn subPosition;
    }
}

