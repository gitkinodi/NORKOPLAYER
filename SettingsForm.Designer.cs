namespace NORKOPLAYER
{
    partial class SettingsForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_KhakiTheme = new System.Windows.Forms.RadioButton();
            this.radioButton_DefaultTheme = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox_ShowTrackPaths = new System.Windows.Forms.CheckBox();
            this.checkBox_UseRelativePaths = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button_OK = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(382, 242);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.radioButton_KhakiTheme);
            this.groupBox1.Controls.Add(this.radioButton_DefaultTheme);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(0, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(382, 118);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тема оформления";
            // 
            // radioButton_KhakiTheme
            // 
            this.radioButton_KhakiTheme.AutoSize = true;
            this.radioButton_KhakiTheme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_KhakiTheme.Location = new System.Drawing.Point(13, 62);
            this.radioButton_KhakiTheme.Name = "radioButton_KhakiTheme";
            this.radioButton_KhakiTheme.Size = new System.Drawing.Size(75, 26);
            this.radioButton_KhakiTheme.TabIndex = 1;
            this.radioButton_KhakiTheme.TabStop = true;
            this.radioButton_KhakiTheme.Text = "Хаки";
            this.radioButton_KhakiTheme.UseVisualStyleBackColor = true;
            // 
            // radioButton_DefaultTheme
            // 
            this.radioButton_DefaultTheme.AutoSize = true;
            this.radioButton_DefaultTheme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_DefaultTheme.Location = new System.Drawing.Point(13, 30);
            this.radioButton_DefaultTheme.Name = "radioButton_DefaultTheme";
            this.radioButton_DefaultTheme.Size = new System.Drawing.Size(140, 26);
            this.radioButton_DefaultTheme.TabIndex = 0;
            this.radioButton_DefaultTheme.TabStop = true;
            this.radioButton_DefaultTheme.Text = "Стандартная";
            this.radioButton_DefaultTheme.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.checkBox_ShowTrackPaths);
            this.groupBox2.Controls.Add(this.checkBox_UseRelativePaths);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 126);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(382, 116);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Общие";
            // 
            // checkBox_ShowTrackPaths
            // 
            this.checkBox_ShowTrackPaths.AutoSize = true;
            this.checkBox_ShowTrackPaths.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_ShowTrackPaths.Location = new System.Drawing.Point(7, 63);
            this.checkBox_ShowTrackPaths.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox_ShowTrackPaths.Name = "checkBox_ShowTrackPaths";
            this.checkBox_ShowTrackPaths.Size = new System.Drawing.Size(256, 26);
            this.checkBox_ShowTrackPaths.TabIndex = 5;
            this.checkBox_ShowTrackPaths.Text = "Показывать пути к трекам";
            this.checkBox_ShowTrackPaths.UseVisualStyleBackColor = true;
            // 
            // checkBox_UseRelativePaths
            // 
            this.checkBox_UseRelativePaths.AutoSize = true;
            this.checkBox_UseRelativePaths.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_UseRelativePaths.Location = new System.Drawing.Point(7, 27);
            this.checkBox_UseRelativePaths.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox_UseRelativePaths.Name = "checkBox_UseRelativePaths";
            this.checkBox_UseRelativePaths.Size = new System.Drawing.Size(328, 26);
            this.checkBox_UseRelativePaths.TabIndex = 4;
            this.checkBox_UseRelativePaths.Text = "Использовать относительные пути";
            this.checkBox_UseRelativePaths.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(382, 287);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.Controls.Add(this.button_OK, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 245);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(376, 39);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // button_OK
            // 
            this.button_OK.AutoSize = true;
            this.button_OK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_OK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_OK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_OK.Location = new System.Drawing.Point(229, 3);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(144, 33);
            this.button_OK.TabIndex = 0;
            this.button_OK.Text = "ОК";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(382, 287);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки";
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.RadioButton radioButton_KhakiTheme;
        internal System.Windows.Forms.RadioButton radioButton_DefaultTheme;
        internal System.Windows.Forms.CheckBox checkBox_UseRelativePaths;
        internal System.Windows.Forms.CheckBox checkBox_ShowTrackPaths;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button_OK;
    }
}