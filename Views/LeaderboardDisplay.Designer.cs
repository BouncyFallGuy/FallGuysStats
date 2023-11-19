﻿namespace FallGuysStats {
    partial class LeaderboardDisplay {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaderboardDisplay));
            this.mpsSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.lblSearchDescription = new MetroFramework.Controls.MetroLabel();
            this.mlMyRank = new MetroFramework.Controls.MetroLink();
            // this.lblPagingInfo = new MetroFramework.Controls.MetroLabel();
            // this.mlFirstPagingButton = new MetroFramework.Controls.MetroLink();
            // this.mlLastPagingButton = new MetroFramework.Controls.MetroLink();
            // this.mlLeftPagingButton = new MetroFramework.Controls.MetroLink();
            // this.mlRightPagingButton = new MetroFramework.Controls.MetroLink();
            this.mlVisitFallalytics = new MetroFramework.Controls.MetroLink();
            this.mlRefreshList = new MetroFramework.Controls.MetroLink();
            this.cboRoundList = new FallGuysStats.ImageComboBox();
            this.gridDetails = new FallGuysStats.Grid();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // mpsSpinner
            // 
            this.mpsSpinner.BackColor = System.Drawing.Color.White;
            this.mpsSpinner.Location = new System.Drawing.Point(423, 60);
            this.mpsSpinner.Margin = new System.Windows.Forms.Padding(0);
            this.mpsSpinner.Maximum = 100;
            this.mpsSpinner.MaximumSize = new System.Drawing.Size(28, 28);
            this.mpsSpinner.MinimumSize = new System.Drawing.Size(28, 28);
            this.mpsSpinner.Name = "mpsSpinner";
            this.mpsSpinner.Size = new System.Drawing.Size(28, 28);
            this.mpsSpinner.Speed = 1.5F;
            this.mpsSpinner.Style = MetroFramework.MetroColorStyle.Teal;
            this.mpsSpinner.TabIndex = 4;
            this.mpsSpinner.UseCustomBackColor = true;
            this.mpsSpinner.UseSelectable = true;
            this.mpsSpinner.Value = 80;
            this.mpsSpinner.Visible = false;
            // 
            // lblSearchDescription
            // 
            this.lblSearchDescription.AutoSize = true;
            this.lblSearchDescription.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSearchDescription.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblSearchDescription.ForeColor = System.Drawing.Color.FromArgb(0, 174, 219);
            this.lblSearchDescription.Location = new System.Drawing.Point(423, 60);
            this.lblSearchDescription.Name = "lblSearchDescription";
            this.lblSearchDescription.Size = new System.Drawing.Size(139, 25);
            this.lblSearchDescription.TabIndex = 3;
            this.lblSearchDescription.Text = "Choose a round";
            this.lblSearchDescription.UseCustomForeColor = true;
            this.lblSearchDescription.Visible = false;
            // 
            // mlMyRank
            // 
            this.mlMyRank.AutoSize = true;
            this.mlMyRank.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mlMyRank.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.mlMyRank.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.mlMyRank.Image = global::FallGuysStats.Properties.Resources.medal_gold_grid_icon;
            this.mlMyRank.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mlMyRank.ImageSize = 30;
            this.mlMyRank.Location = new System.Drawing.Point(635, 58);
            this.mlMyRank.Name = "mlMyRank";
            this.mlMyRank.Size = new System.Drawing.Size(50, 30);
            this.mlMyRank.TabIndex = 7;
            this.mlMyRank.Text = "";
            this.mlMyRank.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mlMyRank.UseCustomBackColor = true;
            this.mlMyRank.UseCustomForeColor = true;
            this.mlMyRank.UseSelectable = true;
            this.mlMyRank.UseStyleColors = true;
            this.mlMyRank.Visible = false;
            this.mlMyRank.Click += new System.EventHandler(this.link_Click);
            this.mlMyRank.MouseEnter += new System.EventHandler(this.mlMyRank_MouseEnter);
            this.mlMyRank.MouseLeave += new System.EventHandler(this.mlMyRank_MouseLeave);
            // 
            // lblPagingInfo
            // 
            // this.lblPagingInfo.AutoSize = true;
            // this.lblPagingInfo.FontSize = MetroFramework.MetroLabelSize.Tall;
            // this.lblPagingInfo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            // this.lblPagingInfo.Location = new System.Drawing.Point(635, 61);
            // this.lblPagingInfo.Name = "lblPagingInfo";
            // this.lblPagingInfo.Size = new System.Drawing.Size(139, 25);
            // this.lblPagingInfo.TabIndex = 3;
            // this.lblPagingInfo.Text = "1 - 50";
            // this.lblPagingInfo.Visible = false;
            // 
            // mlFirstPagingButton
            // 
            // this.mlFirstPagingButton.AutoSize = true;
            // this.mlFirstPagingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            // this.mlFirstPagingButton.FontSize = MetroFramework.MetroLinkSize.Medium;
            // this.mlFirstPagingButton.Image = global::FallGuysStats.Properties.Resources.first_button_icon;
            // this.mlFirstPagingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // this.mlFirstPagingButton.ImageSize = 27;
            // this.mlFirstPagingButton.Location = new System.Drawing.Point(579, 60);
            // this.mlFirstPagingButton.Name = "mlFirstPagingButton";
            // this.mlFirstPagingButton.Size = new System.Drawing.Size(27, 28);
            // this.mlFirstPagingButton.TabIndex = 7;
            // this.mlFirstPagingButton.Text = "";
            // this.mlFirstPagingButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // this.mlFirstPagingButton.UseSelectable = true;
            // this.mlFirstPagingButton.UseStyleColors = true;
            // this.mlFirstPagingButton.Visible = false;
            // this.mlFirstPagingButton.Click += new System.EventHandler(this.link_Click);
            // 
            // mlLastPagingButton
            // 
            // this.mlLastPagingButton.AutoSize = true;
            // this.mlLastPagingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            // this.mlLastPagingButton.FontSize = MetroFramework.MetroLinkSize.Medium;
            // this.mlLastPagingButton.Image = global::FallGuysStats.Properties.Resources.last_button_icon;
            // this.mlLastPagingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // this.mlLastPagingButton.ImageSize = 27;
            // this.mlLastPagingButton.Location = new System.Drawing.Point(721, 60);
            // this.mlLastPagingButton.Name = "mlLastPagingButton";
            // this.mlLastPagingButton.Size = new System.Drawing.Size(27, 28);
            // this.mlLastPagingButton.TabIndex = 7;
            // this.mlLastPagingButton.Text = "";
            // this.mlLastPagingButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // this.mlLastPagingButton.UseSelectable = true;
            // this.mlLastPagingButton.UseStyleColors = true;
            // this.mlLastPagingButton.Visible = false;
            // this.mlLastPagingButton.Click += new System.EventHandler(this.link_Click);
            // 
            // mlLeftPagingButton
            // 
            // this.mlLeftPagingButton.AutoSize = true;
            // this.mlLeftPagingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            // this.mlLeftPagingButton.FontSize = MetroFramework.MetroLinkSize.Medium;
            // this.mlLeftPagingButton.Image = global::FallGuysStats.Properties.Resources.left_button_icon;
            // this.mlLeftPagingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // this.mlLeftPagingButton.ImageSize = 27;
            // this.mlLeftPagingButton.Location = new System.Drawing.Point(600, 60);
            // this.mlLeftPagingButton.Name = "mlLeftPagingButton";
            // this.mlLeftPagingButton.Size = new System.Drawing.Size(27, 28);
            // this.mlLeftPagingButton.TabIndex = 7;
            // this.mlLeftPagingButton.Text = "";
            // this.mlLeftPagingButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // this.mlLeftPagingButton.UseSelectable = true;
            // this.mlLeftPagingButton.UseStyleColors = true;
            // this.mlLeftPagingButton.Visible = false;
            // this.mlLeftPagingButton.Click += new System.EventHandler(this.link_Click);
            // 
            // mlRightPagingButton
            // 
            // this.mlRightPagingButton.AutoSize = true;
            // this.mlRightPagingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            // this.mlRightPagingButton.FontSize = MetroFramework.MetroLinkSize.Medium;
            // this.mlRightPagingButton.Image = global::FallGuysStats.Properties.Resources.right_button_icon;
            // this.mlRightPagingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // this.mlRightPagingButton.ImageSize = 27;
            // this.mlRightPagingButton.Location = new System.Drawing.Point(700, 60);
            // this.mlRightPagingButton.Name = "mlRightPagingButton";
            // this.mlRightPagingButton.Size = new System.Drawing.Size(27, 28);
            // this.mlRightPagingButton.TabIndex = 7;
            // this.mlRightPagingButton.Text = "";
            // this.mlRightPagingButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // this.mlRightPagingButton.UseSelectable = true;
            // this.mlRightPagingButton.UseStyleColors = true;
            // this.mlRightPagingButton.Visible = false;
            // this.mlRightPagingButton.Click += new System.EventHandler(this.link_Click);
            // 
            // mlVisitFallalytics
            // 
            this.mlVisitFallalytics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mlVisitFallalytics.AutoSize = true;
            this.mlVisitFallalytics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mlVisitFallalytics.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.mlVisitFallalytics.ForeColor = System.Drawing.Color.FromArgb(0, 174, 219);
            this.mlVisitFallalytics.Image = global::FallGuysStats.Properties.Resources.fallalytics_icon;
            this.mlVisitFallalytics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mlVisitFallalytics.ImageSize = 20;
            this.mlVisitFallalytics.Location = new System.Drawing.Point(836, 60);
            this.mlVisitFallalytics.Name = "mlVisitFallalytics";
            this.mlVisitFallalytics.Size = new System.Drawing.Size(310, 29);
            this.mlVisitFallalytics.TabIndex = 7;
            this.mlVisitFallalytics.Text = "See full rankings in FALLALYTICS";
            this.mlVisitFallalytics.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mlVisitFallalytics.UseCustomBackColor = true;
            this.mlVisitFallalytics.UseCustomForeColor = true;
            this.mlVisitFallalytics.UseSelectable = true;
            this.mlVisitFallalytics.UseStyleColors = true;
            this.mlVisitFallalytics.Visible = false;
            this.mlVisitFallalytics.Click += new System.EventHandler(this.link_Click);
            // 
            // mlRefreshList
            // 
            this.mlRefreshList.AutoSize = true;
            this.mlRefreshList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mlRefreshList.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.mlRefreshList.Image = global::FallGuysStats.Properties.Resources.refresh_icon;
            this.mlRefreshList.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mlRefreshList.ImageSize = 26;
            this.mlRefreshList.Location = new System.Drawing.Point(145, 61);
            this.mlRefreshList.Name = "mlRefreshList";
            this.mlRefreshList.Size = new System.Drawing.Size(26, 27);
            this.mlRefreshList.TabIndex = 7;
            this.mlRefreshList.Text = "";
            this.mlRefreshList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mlRefreshList.UseSelectable = true;
            this.mlRefreshList.UseStyleColors = true;
            this.mlRefreshList.Visible = false;
            this.mlRefreshList.Click += new System.EventHandler(this.link_Click);
            // 
            // cboRoundList
            // 
            this.cboRoundList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboRoundList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboRoundList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoundList.FormattingEnabled = true;
            this.cboRoundList.ItemHeight = 23;
            this.cboRoundList.Location = new System.Drawing.Point(11, 61);
            this.cboRoundList.MaxDropDownItems = 20;
            this.cboRoundList.Name = "cboRoundList";
            this.cboRoundList.Size = new System.Drawing.Size(370, 20);
            this.cboRoundList.TabIndex = 1;
            this.cboRoundList.SelectedIndexChanged += new System.EventHandler(this.cboRoundList_SelectedIndexChanged);
            // 
            // gridDetails
            // 
            this.gridDetails.AllowUserToDeleteRows = false;
            this.gridDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDetails.ColumnHeadersHeight = 24;
            this.gridDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridDetails.EnableHeadersVisualStyles = false;
            this.gridDetails.Location = new System.Drawing.Point(11, 98);
            this.gridDetails.Name = "gridDetails";
            this.gridDetails.ReadOnly = true;
            this.gridDetails.RowHeadersVisible = false;
            this.gridDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDetails.Size = new System.Drawing.Size(1189, 824);
            this.gridDetails.TabIndex = 2;
            this.gridDetails.DataSourceChanged += new System.EventHandler(this.gridDetails_DataSourceChanged);
            this.gridDetails.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridDetails_CellFormatting);
            // this.gridDetails.Scroll += new System.Windows.Forms.ScrollEventHandler(this.gridDetails_Scroll);
            this.gridDetails.SelectionChanged += new System.EventHandler(this.gridDetails_SelectionChanged);
            // 
            // LeaderboardDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1210, 937);
            this.Controls.Add(this.mpsSpinner);
            this.Controls.Add(this.lblSearchDescription);
            this.Controls.Add(this.mlMyRank);
            // this.Controls.Add(this.lblPagingInfo);
            // this.Controls.Add(this.mlFirstPagingButton);
            // this.Controls.Add(this.mlLastPagingButton);
            // this.Controls.Add(this.mlLeftPagingButton);
            // this.Controls.Add(this.mlRightPagingButton);
            this.Controls.Add(this.mlVisitFallalytics);
            this.Controls.Add(this.mlRefreshList);
            this.Controls.Add(this.cboRoundList);
            this.Controls.Add(this.gridDetails);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1210, 1289);
            this.MinimumSize = new System.Drawing.Size(1210, 425);
            this.Name = "LeaderboardDisplay";
            this.Padding = new System.Windows.Forms.Padding(23, 60, 23, 18);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Level Stats";
            this.Load += new System.EventHandler(this.LeaderboardDisplay_Load);
            this.Shown += new System.EventHandler(this.LeaderboardDisplay_Shown);
            this.Resize += new System.EventHandler(this.LeaderboardDisplay_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.gridDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private MetroFramework.Controls.MetroProgressSpinner mpsSpinner;
        private MetroFramework.Controls.MetroLabel lblSearchDescription;
        private MetroFramework.Controls.MetroLink mlMyRank;
        // private MetroFramework.Controls.MetroLabel lblPagingInfo;
        // private MetroFramework.Controls.MetroLink mlFirstPagingButton;
        // private MetroFramework.Controls.MetroLink mlLastPagingButton;
        // private MetroFramework.Controls.MetroLink mlLeftPagingButton;
        // private MetroFramework.Controls.MetroLink mlRightPagingButton;
        private MetroFramework.Controls.MetroLink mlVisitFallalytics;
        private MetroFramework.Controls.MetroLink mlRefreshList;
        private FallGuysStats.ImageComboBox cboRoundList;
        private FallGuysStats.Grid gridDetails;
    }
}