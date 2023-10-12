namespace NORKOPLAYER
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label_TrackDuration = new System.Windows.Forms.Label();
            this.label_TrackPosition = new System.Windows.Forms.Label();
            this.progressBar_TrackPosition = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label_PlaylistName = new System.Windows.Forms.Label();
            this.label_TrackName = new System.Windows.Forms.Label();
            this.dataGridView_Playlist = new System.Windows.Forms.DataGridView();
            this.TrackNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrackPaths = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.button_SaveAsNewPlaylist = new System.Windows.Forms.Button();
            this.button_SavePlaylist = new System.Windows.Forms.Button();
            this.button_OpenPlaylist = new System.Windows.Forms.Button();
            this.button_ClearPlaylist = new System.Windows.Forms.Button();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label_Volume = new System.Windows.Forms.Label();
            this.button_Pause = new System.Windows.Forms.Button();
            this.button_Play = new System.Windows.Forms.Button();
            this.button_Previous = new System.Windows.Forms.Button();
            this.button_Next = new System.Windows.Forms.Button();
            this.button_Loop = new System.Windows.Forms.Button();
            this.button_Shuffle = new System.Windows.Forms.Button();
            this.label_Speed = new System.Windows.Forms.Label();
            this.trackBar_Volume = new System.Windows.Forms.TrackBar();
            this.trackBar_Speed = new System.Windows.Forms.TrackBar();
            this.timer_InfoUpdater = new System.Windows.Forms.Timer(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip_MainForm = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_About = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Playlist)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Speed)).BeginInit();
            this.tableLayoutPanel7.SuspendLayout();
            this.menuStrip_MainForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(582, 523);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel2.Controls.Add(this.label_TrackDuration, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label_TrackPosition, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.progressBar_TrackPosition, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 498);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(582, 25);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label_TrackDuration
            // 
            this.label_TrackDuration.AutoSize = true;
            this.label_TrackDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_TrackDuration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_TrackDuration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_TrackDuration.Enabled = false;
            this.label_TrackDuration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_TrackDuration.Location = new System.Drawing.Point(492, 0);
            this.label_TrackDuration.Margin = new System.Windows.Forms.Padding(0);
            this.label_TrackDuration.Name = "label_TrackDuration";
            this.label_TrackDuration.Size = new System.Drawing.Size(90, 25);
            this.label_TrackDuration.TabIndex = 3;
            this.label_TrackDuration.Text = "00:00";
            this.label_TrackDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.label_TrackDuration, "В конец трека");
            this.label_TrackDuration.Click += new System.EventHandler(this.label_TrackDuration_Click);
            // 
            // label_TrackPosition
            // 
            this.label_TrackPosition.AutoSize = true;
            this.label_TrackPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_TrackPosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_TrackPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_TrackPosition.Enabled = false;
            this.label_TrackPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_TrackPosition.Location = new System.Drawing.Point(0, 0);
            this.label_TrackPosition.Margin = new System.Windows.Forms.Padding(0);
            this.label_TrackPosition.Name = "label_TrackPosition";
            this.label_TrackPosition.Size = new System.Drawing.Size(90, 25);
            this.label_TrackPosition.TabIndex = 0;
            this.label_TrackPosition.Text = "00:00";
            this.label_TrackPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.label_TrackPosition, "В начало трека");
            this.label_TrackPosition.Click += new System.EventHandler(this.label_TrackPosition_Click);
            // 
            // progressBar_TrackPosition
            // 
            this.progressBar_TrackPosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.progressBar_TrackPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar_TrackPosition.Enabled = false;
            this.progressBar_TrackPosition.Location = new System.Drawing.Point(90, 0);
            this.progressBar_TrackPosition.Margin = new System.Windows.Forms.Padding(0);
            this.progressBar_TrackPosition.Name = "progressBar_TrackPosition";
            this.progressBar_TrackPosition.Size = new System.Drawing.Size(402, 25);
            this.progressBar_TrackPosition.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar_TrackPosition.TabIndex = 2;
            this.progressBar_TrackPosition.MouseDown += new System.Windows.Forms.MouseEventHandler(this.progressBar_TrackPosition_MouseDown);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(582, 498);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.label_PlaylistName, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label_TrackName, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.dataGridView_Playlist, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.textBox_Search, 0, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(90, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 5;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(492, 498);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // label_PlaylistName
            // 
            this.label_PlaylistName.AutoEllipsis = true;
            this.label_PlaylistName.AutoSize = true;
            this.label_PlaylistName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_PlaylistName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_PlaylistName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_PlaylistName.Location = new System.Drawing.Point(0, 35);
            this.label_PlaylistName.Margin = new System.Windows.Forms.Padding(0);
            this.label_PlaylistName.Name = "label_PlaylistName";
            this.label_PlaylistName.Size = new System.Drawing.Size(492, 25);
            this.label_PlaylistName.TabIndex = 4;
            this.label_PlaylistName.Text = "< Новый плейлист >";
            this.label_PlaylistName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_TrackName
            // 
            this.label_TrackName.AutoEllipsis = true;
            this.label_TrackName.AutoSize = true;
            this.label_TrackName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_TrackName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_TrackName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_TrackName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_TrackName.Location = new System.Drawing.Point(0, 473);
            this.label_TrackName.Margin = new System.Windows.Forms.Padding(0);
            this.label_TrackName.Name = "label_TrackName";
            this.label_TrackName.Size = new System.Drawing.Size(492, 25);
            this.label_TrackName.TabIndex = 0;
            this.label_TrackName.Text = "[ Добавить треки ]";
            this.label_TrackName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.label_TrackName, "Добавить треки");
            this.label_TrackName.Click += new System.EventHandler(this.label_TrackName_Click);
            // 
            // dataGridView_Playlist
            // 
            this.dataGridView_Playlist.AllowUserToAddRows = false;
            this.dataGridView_Playlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView_Playlist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView_Playlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Playlist.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView_Playlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Playlist.ColumnHeadersVisible = false;
            this.dataGridView_Playlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TrackNames,
            this.TrackPaths});
            this.dataGridView_Playlist.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Playlist.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Playlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Playlist.Location = new System.Drawing.Point(0, 83);
            this.dataGridView_Playlist.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView_Playlist.MultiSelect = false;
            this.dataGridView_Playlist.Name = "dataGridView_Playlist";
            this.dataGridView_Playlist.ReadOnly = true;
            this.dataGridView_Playlist.RowHeadersVisible = false;
            this.dataGridView_Playlist.RowHeadersWidth = 30;
            this.dataGridView_Playlist.RowTemplate.Height = 24;
            this.dataGridView_Playlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Playlist.Size = new System.Drawing.Size(492, 390);
            this.dataGridView_Playlist.TabIndex = 2;
            this.dataGridView_Playlist.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Playlist_CellContentDoubleClick);
            this.dataGridView_Playlist.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView_Playlist_UserDeletingRow);
            this.dataGridView_Playlist.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_Playlist_KeyDown);
            // 
            // TrackNames
            // 
            this.TrackNames.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.TrackNames.DefaultCellStyle = dataGridViewCellStyle1;
            this.TrackNames.HeaderText = "Названия треков";
            this.TrackNames.MinimumWidth = 6;
            this.TrackNames.Name = "TrackNames";
            this.TrackNames.ReadOnly = true;
            this.TrackNames.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TrackPaths
            // 
            this.TrackPaths.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TrackPaths.HeaderText = "Пути треков";
            this.TrackPaths.MinimumWidth = 6;
            this.TrackPaths.Name = "TrackPaths";
            this.TrackPaths.ReadOnly = true;
            this.TrackPaths.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TrackPaths.Visible = false;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.AutoSize = true;
            this.tableLayoutPanel6.ColumnCount = 4;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.Controls.Add(this.button_SaveAsNewPlaylist, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.button_SavePlaylist, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.button_OpenPlaylist, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.button_ClearPlaylist, 3, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(492, 35);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // button_SaveAsNewPlaylist
            // 
            this.button_SaveAsNewPlaylist.AutoSize = true;
            this.button_SaveAsNewPlaylist.BackgroundImage = global::NORKOPLAYER.Properties.Resources.new_document;
            this.button_SaveAsNewPlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_SaveAsNewPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_SaveAsNewPlaylist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_SaveAsNewPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SaveAsNewPlaylist.Location = new System.Drawing.Point(246, 0);
            this.button_SaveAsNewPlaylist.Margin = new System.Windows.Forms.Padding(0);
            this.button_SaveAsNewPlaylist.Name = "button_SaveAsNewPlaylist";
            this.button_SaveAsNewPlaylist.Size = new System.Drawing.Size(123, 35);
            this.button_SaveAsNewPlaylist.TabIndex = 2;
            this.toolTip.SetToolTip(this.button_SaveAsNewPlaylist, "Сохранить плейлист как");
            this.button_SaveAsNewPlaylist.UseVisualStyleBackColor = false;
            this.button_SaveAsNewPlaylist.Click += new System.EventHandler(this.button_SaveAsNewPlaylist_Click);
            // 
            // button_SavePlaylist
            // 
            this.button_SavePlaylist.AutoSize = true;
            this.button_SavePlaylist.BackgroundImage = global::NORKOPLAYER.Properties.Resources.diskette;
            this.button_SavePlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_SavePlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_SavePlaylist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_SavePlaylist.Enabled = false;
            this.button_SavePlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SavePlaylist.Location = new System.Drawing.Point(123, 0);
            this.button_SavePlaylist.Margin = new System.Windows.Forms.Padding(0);
            this.button_SavePlaylist.Name = "button_SavePlaylist";
            this.button_SavePlaylist.Size = new System.Drawing.Size(123, 35);
            this.button_SavePlaylist.TabIndex = 1;
            this.toolTip.SetToolTip(this.button_SavePlaylist, "Сохранить плейлист");
            this.button_SavePlaylist.UseVisualStyleBackColor = false;
            this.button_SavePlaylist.Click += new System.EventHandler(this.button_SavePlaylist_Click);
            // 
            // button_OpenPlaylist
            // 
            this.button_OpenPlaylist.AutoSize = true;
            this.button_OpenPlaylist.BackgroundImage = global::NORKOPLAYER.Properties.Resources.folder;
            this.button_OpenPlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_OpenPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_OpenPlaylist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_OpenPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_OpenPlaylist.Location = new System.Drawing.Point(0, 0);
            this.button_OpenPlaylist.Margin = new System.Windows.Forms.Padding(0);
            this.button_OpenPlaylist.Name = "button_OpenPlaylist";
            this.button_OpenPlaylist.Size = new System.Drawing.Size(123, 35);
            this.button_OpenPlaylist.TabIndex = 0;
            this.toolTip.SetToolTip(this.button_OpenPlaylist, "Открыть плейлист");
            this.button_OpenPlaylist.UseVisualStyleBackColor = false;
            this.button_OpenPlaylist.Click += new System.EventHandler(this.button_OpenPlaylist_Click);
            // 
            // button_ClearPlaylist
            // 
            this.button_ClearPlaylist.AutoSize = true;
            this.button_ClearPlaylist.BackgroundImage = global::NORKOPLAYER.Properties.Resources.clean;
            this.button_ClearPlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_ClearPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ClearPlaylist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ClearPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ClearPlaylist.Location = new System.Drawing.Point(369, 0);
            this.button_ClearPlaylist.Margin = new System.Windows.Forms.Padding(0);
            this.button_ClearPlaylist.Name = "button_ClearPlaylist";
            this.button_ClearPlaylist.Size = new System.Drawing.Size(123, 35);
            this.button_ClearPlaylist.TabIndex = 3;
            this.toolTip.SetToolTip(this.button_ClearPlaylist, "Очистить плейлист");
            this.button_ClearPlaylist.UseVisualStyleBackColor = false;
            this.button_ClearPlaylist.Click += new System.EventHandler(this.button_ClearPlaylist_Click);
            // 
            // textBox_Search
            // 
            this.textBox_Search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Search.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_Search.Location = new System.Drawing.Point(0, 60);
            this.textBox_Search.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(492, 23);
            this.textBox_Search.TabIndex = 5;
            this.textBox_Search.Text = "Поиск";
            this.toolTip.SetToolTip(this.textBox_Search, "Поиск");
            this.textBox_Search.TextChanged += new System.EventHandler(this.textBox_Search_TextChanged);
            this.textBox_Search.Enter += new System.EventHandler(this.textBox_Search_Enter);
            this.textBox_Search.Leave += new System.EventHandler(this.textBox_Search_Leave);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label_Volume, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.button_Pause, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.button_Play, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.button_Previous, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.button_Next, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.button_Loop, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.button_Shuffle, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.label_Speed, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.trackBar_Volume, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.trackBar_Speed, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(90, 498);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label_Volume
            // 
            this.label_Volume.AutoSize = true;
            this.label_Volume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Volume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Volume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Volume.Location = new System.Drawing.Point(45, 0);
            this.label_Volume.Margin = new System.Windows.Forms.Padding(0);
            this.label_Volume.Name = "label_Volume";
            this.label_Volume.Size = new System.Drawing.Size(45, 25);
            this.label_Volume.TabIndex = 9;
            this.label_Volume.Text = "50%";
            this.label_Volume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.label_Volume, "Сбросить громкость");
            this.label_Volume.Click += new System.EventHandler(this.label_Volume_Click);
            // 
            // button_Pause
            // 
            this.button_Pause.AutoSize = true;
            this.button_Pause.BackgroundImage = global::NORKOPLAYER.Properties.Resources.pause;
            this.button_Pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Pause.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Pause.Enabled = false;
            this.button_Pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Pause.Location = new System.Drawing.Point(45, 408);
            this.button_Pause.Margin = new System.Windows.Forms.Padding(0);
            this.button_Pause.Name = "button_Pause";
            this.button_Pause.Size = new System.Drawing.Size(45, 30);
            this.button_Pause.TabIndex = 1;
            this.toolTip.SetToolTip(this.button_Pause, "Пауза");
            this.button_Pause.UseVisualStyleBackColor = false;
            this.button_Pause.Click += new System.EventHandler(this.button_Pause_Click);
            // 
            // button_Play
            // 
            this.button_Play.AutoSize = true;
            this.button_Play.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_Play.BackgroundImage = global::NORKOPLAYER.Properties.Resources.play;
            this.button_Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Play.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Play.Enabled = false;
            this.button_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Play.Location = new System.Drawing.Point(0, 408);
            this.button_Play.Margin = new System.Windows.Forms.Padding(0);
            this.button_Play.Name = "button_Play";
            this.button_Play.Size = new System.Drawing.Size(45, 30);
            this.button_Play.TabIndex = 0;
            this.toolTip.SetToolTip(this.button_Play, "Играть");
            this.button_Play.UseVisualStyleBackColor = false;
            this.button_Play.Click += new System.EventHandler(this.button_Play_Click);
            // 
            // button_Previous
            // 
            this.button_Previous.AutoSize = true;
            this.button_Previous.BackgroundImage = global::NORKOPLAYER.Properties.Resources.back;
            this.button_Previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Previous.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Previous.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Previous.Enabled = false;
            this.button_Previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Previous.Location = new System.Drawing.Point(0, 438);
            this.button_Previous.Margin = new System.Windows.Forms.Padding(0);
            this.button_Previous.Name = "button_Previous";
            this.button_Previous.Size = new System.Drawing.Size(45, 30);
            this.button_Previous.TabIndex = 3;
            this.toolTip.SetToolTip(this.button_Previous, "Предыдущий трек");
            this.button_Previous.UseVisualStyleBackColor = false;
            this.button_Previous.Click += new System.EventHandler(this.button_Previous_Click);
            // 
            // button_Next
            // 
            this.button_Next.AutoSize = true;
            this.button_Next.BackgroundImage = global::NORKOPLAYER.Properties.Resources.next;
            this.button_Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Next.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Next.Enabled = false;
            this.button_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Next.Location = new System.Drawing.Point(45, 438);
            this.button_Next.Margin = new System.Windows.Forms.Padding(0);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(45, 30);
            this.button_Next.TabIndex = 2;
            this.toolTip.SetToolTip(this.button_Next, "Следующий трек");
            this.button_Next.UseVisualStyleBackColor = false;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // button_Loop
            // 
            this.button_Loop.AutoSize = true;
            this.button_Loop.BackgroundImage = global::NORKOPLAYER.Properties.Resources.repeat;
            this.button_Loop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Loop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Loop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Loop.Enabled = false;
            this.button_Loop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Loop.Location = new System.Drawing.Point(0, 468);
            this.button_Loop.Margin = new System.Windows.Forms.Padding(0);
            this.button_Loop.Name = "button_Loop";
            this.button_Loop.Size = new System.Drawing.Size(45, 30);
            this.button_Loop.TabIndex = 4;
            this.toolTip.SetToolTip(this.button_Loop, "Повтор");
            this.button_Loop.UseVisualStyleBackColor = false;
            this.button_Loop.Click += new System.EventHandler(this.button_Loop_Click);
            // 
            // button_Shuffle
            // 
            this.button_Shuffle.AutoSize = true;
            this.button_Shuffle.BackgroundImage = global::NORKOPLAYER.Properties.Resources.shuffle;
            this.button_Shuffle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Shuffle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Shuffle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Shuffle.Enabled = false;
            this.button_Shuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Shuffle.Location = new System.Drawing.Point(45, 468);
            this.button_Shuffle.Margin = new System.Windows.Forms.Padding(0);
            this.button_Shuffle.Name = "button_Shuffle";
            this.button_Shuffle.Size = new System.Drawing.Size(45, 30);
            this.button_Shuffle.TabIndex = 5;
            this.toolTip.SetToolTip(this.button_Shuffle, "Случайное воспроизведение");
            this.button_Shuffle.UseVisualStyleBackColor = false;
            this.button_Shuffle.Click += new System.EventHandler(this.button_Shuffle_Click);
            // 
            // label_Speed
            // 
            this.label_Speed.AutoSize = true;
            this.label_Speed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Speed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Speed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Speed.Location = new System.Drawing.Point(0, 0);
            this.label_Speed.Margin = new System.Windows.Forms.Padding(0);
            this.label_Speed.Name = "label_Speed";
            this.label_Speed.Size = new System.Drawing.Size(45, 25);
            this.label_Speed.TabIndex = 6;
            this.label_Speed.Text = "x1";
            this.label_Speed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.label_Speed, "Сбросить скорость");
            this.label_Speed.Click += new System.EventHandler(this.label_Speed_Click);
            // 
            // trackBar_Volume
            // 
            this.trackBar_Volume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar_Volume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar_Volume.Location = new System.Drawing.Point(45, 25);
            this.trackBar_Volume.Margin = new System.Windows.Forms.Padding(0);
            this.trackBar_Volume.Maximum = 100;
            this.trackBar_Volume.Name = "trackBar_Volume";
            this.trackBar_Volume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_Volume.Size = new System.Drawing.Size(45, 383);
            this.trackBar_Volume.TabIndex = 8;
            this.trackBar_Volume.TickFrequency = 5;
            this.trackBar_Volume.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar_Volume.Value = 50;
            this.trackBar_Volume.Scroll += new System.EventHandler(this.trackBar_Volume_Scroll);
            // 
            // trackBar_Speed
            // 
            this.trackBar_Speed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar_Speed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar_Speed.LargeChange = 1;
            this.trackBar_Speed.Location = new System.Drawing.Point(0, 25);
            this.trackBar_Speed.Margin = new System.Windows.Forms.Padding(0);
            this.trackBar_Speed.Maximum = 20;
            this.trackBar_Speed.Minimum = 5;
            this.trackBar_Speed.Name = "trackBar_Speed";
            this.trackBar_Speed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_Speed.Size = new System.Drawing.Size(45, 383);
            this.trackBar_Speed.TabIndex = 7;
            this.trackBar_Speed.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar_Speed.Value = 10;
            this.trackBar_Speed.Scroll += new System.EventHandler(this.trackBar_Speed_Scroll);
            // 
            // timer_InfoUpdater
            // 
            this.timer_InfoUpdater.Enabled = true;
            this.timer_InfoUpdater.Tick += new System.EventHandler(this.timer_InfoUpdater_Tick);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.AutoSize = true;
            this.tableLayoutPanel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.menuStrip_MainForm, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(582, 553);
            this.tableLayoutPanel7.TabIndex = 2;
            // 
            // menuStrip_MainForm
            // 
            this.menuStrip_MainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip_MainForm.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.menuStrip_MainForm.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip_MainForm.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_MainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Settings,
            this.toolStripMenuItem_Exit,
            this.toolStripMenuItem_About});
            this.menuStrip_MainForm.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip_MainForm.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_MainForm.Name = "menuStrip_MainForm";
            this.menuStrip_MainForm.Padding = new System.Windows.Forms.Padding(1);
            this.menuStrip_MainForm.Size = new System.Drawing.Size(582, 30);
            this.menuStrip_MainForm.TabIndex = 0;
            // 
            // toolStripMenuItem_Settings
            // 
            this.toolStripMenuItem_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripMenuItem_Settings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem_Settings.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.toolStripMenuItem_Settings.Name = "toolStripMenuItem_Settings";
            this.toolStripMenuItem_Settings.Padding = new System.Windows.Forms.Padding(1);
            this.toolStripMenuItem_Settings.Size = new System.Drawing.Size(109, 28);
            this.toolStripMenuItem_Settings.Text = "Настройки";
            this.toolStripMenuItem_Settings.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolStripMenuItem_Settings.Click += new System.EventHandler(this.toolStripMenuItem_Settings_Click);
            // 
            // toolStripMenuItem_Exit
            // 
            this.toolStripMenuItem_Exit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripMenuItem_Exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem_Exit.Name = "toolStripMenuItem_Exit";
            this.toolStripMenuItem_Exit.Padding = new System.Windows.Forms.Padding(1);
            this.toolStripMenuItem_Exit.Size = new System.Drawing.Size(69, 28);
            this.toolStripMenuItem_Exit.Text = "Выход";
            this.toolStripMenuItem_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolStripMenuItem_Exit.Click += new System.EventHandler(this.toolStripMenuItem_Exit_Click);
            // 
            // toolStripMenuItem_About
            // 
            this.toolStripMenuItem_About.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem_About.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripMenuItem_About.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem_About.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.toolStripMenuItem_About.Name = "toolStripMenuItem_About";
            this.toolStripMenuItem_About.Padding = new System.Windows.Forms.Padding(1);
            this.toolStripMenuItem_About.Size = new System.Drawing.Size(128, 28);
            this.toolStripMenuItem_About.Text = "О программе";
            this.toolStripMenuItem_About.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolStripMenuItem_About.Click += new System.EventHandler(this.toolStripMenuItem_About_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.tableLayoutPanel7);
            this.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip_MainForm;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NORKOPLAYER";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Playlist)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Speed)).EndInit();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.menuStrip_MainForm.ResumeLayout(false);
            this.menuStrip_MainForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label_TrackDuration;
        private System.Windows.Forms.Label label_TrackPosition;
        private System.Windows.Forms.ProgressBar progressBar_TrackPosition;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label_Volume;
        private System.Windows.Forms.Button button_Pause;
        private System.Windows.Forms.Button button_Play;
        private System.Windows.Forms.Button button_Previous;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Button button_Loop;
        private System.Windows.Forms.Button button_Shuffle;
        private System.Windows.Forms.Label label_Speed;
        private System.Windows.Forms.TrackBar trackBar_Speed;
        private System.Windows.Forms.TrackBar trackBar_Volume;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label_TrackName;
        private System.Windows.Forms.DataGridView dataGridView_Playlist;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button button_OpenPlaylist;
        private System.Windows.Forms.Button button_SaveAsNewPlaylist;
        private System.Windows.Forms.Button button_SavePlaylist;
        private System.Windows.Forms.Timer timer_InfoUpdater;
        private System.Windows.Forms.Label label_PlaylistName;
        private System.Windows.Forms.Button button_ClearPlaylist;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.MenuStrip menuStrip_MainForm;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Settings;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_About;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrackNames;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrackPaths;
        private System.Windows.Forms.TextBox textBox_Search;
    }
}