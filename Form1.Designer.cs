namespace Asg4_xxy180008
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
            this.panel = new System.Windows.Forms.Panel();
            this.lb_warning = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.column_lineNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_text = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bt_search = new System.Windows.Forms.Button();
            this.bt_browse = new System.Windows.Forms.Button();
            this.tb_fileName = new System.Windows.Forms.TextBox();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.lb_search = new System.Windows.Forms.Label();
            this.lb_fileName = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.Controls.Add(this.progressBar);
            this.panel.Controls.Add(this.lb_warning);
            this.panel.Controls.Add(this.listView);
            this.panel.Controls.Add(this.bt_search);
            this.panel.Controls.Add(this.bt_browse);
            this.panel.Controls.Add(this.tb_fileName);
            this.panel.Controls.Add(this.tb_search);
            this.panel.Controls.Add(this.lb_search);
            this.panel.Controls.Add(this.lb_fileName);
            this.panel.Location = new System.Drawing.Point(16, 15);
            this.panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(927, 639);
            this.panel.TabIndex = 0;
            // 
            // lb_warning
            // 
            this.lb_warning.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_warning.AutoSize = true;
            this.lb_warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_warning.ForeColor = System.Drawing.Color.Red;
            this.lb_warning.Location = new System.Drawing.Point(105, 104);
            this.lb_warning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_warning.Name = "lb_warning";
            this.lb_warning.Size = new System.Drawing.Size(51, 20);
            this.lb_warning.TabIndex = 7;
            this.lb_warning.Text = "label1";
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_lineNum,
            this.column_text});
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(32, 157);
            this.listView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(867, 466);
            this.listView.TabIndex = 6;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // column_lineNum
            // 
            this.column_lineNum.Text = "Line No.";
            // 
            // column_text
            // 
            this.column_text.Text = "Text";
            this.column_text.Width = 600;
            // 
            // bt_search
            // 
            this.bt_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_search.Location = new System.Drawing.Point(799, 65);
            this.bt_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(100, 28);
            this.bt_search.TabIndex = 5;
            this.bt_search.Text = "Search";
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // bt_browse
            // 
            this.bt_browse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_browse.Location = new System.Drawing.Point(799, 15);
            this.bt_browse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_browse.Name = "bt_browse";
            this.bt_browse.Size = new System.Drawing.Size(100, 28);
            this.bt_browse.TabIndex = 4;
            this.bt_browse.Text = "Browse";
            this.bt_browse.UseVisualStyleBackColor = true;
            this.bt_browse.Click += new System.EventHandler(this.bt_browse_Click);
            // 
            // tb_fileName
            // 
            this.tb_fileName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_fileName.Location = new System.Drawing.Point(109, 18);
            this.tb_fileName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_fileName.Name = "tb_fileName";
            this.tb_fileName.Size = new System.Drawing.Size(661, 22);
            this.tb_fileName.TabIndex = 3;
            // 
            // tb_search
            // 
            this.tb_search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_search.Location = new System.Drawing.Point(109, 69);
            this.tb_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(661, 22);
            this.tb_search.TabIndex = 2;
            // 
            // lb_search
            // 
            this.lb_search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_search.AutoSize = true;
            this.lb_search.Location = new System.Drawing.Point(27, 71);
            this.lb_search.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_search.Name = "lb_search";
            this.lb_search.Size = new System.Drawing.Size(69, 16);
            this.lb_search.TabIndex = 1;
            this.lb_search.Text = "Search for";
            // 
            // lb_fileName
            // 
            this.lb_fileName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_fileName.AutoSize = true;
            this.lb_fileName.Location = new System.Drawing.Point(29, 22);
            this.lb_fileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_fileName.Name = "lb_fileName";
            this.lb_fileName.Size = new System.Drawing.Size(70, 16);
            this.lb_fileName.TabIndex = 0;
            this.lb_fileName.Text = "File Name";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(109, 127);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(550, 23);
            this.progressBar.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 668);
            this.Controls.Add(this.panel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lb_search;
        private System.Windows.Forms.Label lb_fileName;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox tb_fileName;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.Button bt_browse;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader column_lineNum;
        private System.Windows.Forms.ColumnHeader column_text;
        private System.Windows.Forms.Label lb_warning;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

