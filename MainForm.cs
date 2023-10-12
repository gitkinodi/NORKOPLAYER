using System;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace NORKOPLAYER
{
    public partial class MainForm : Form
    {
        private SettingsForm MySettingsForm;
        private AboutForm MyAboutForm;

        private Player MyPlayer;
        private Random MyRandom;

        private SQLiteConnection MySQLiteConnection;
        private SQLiteCommand MySQLiteCommand;
        private SQLiteDataReader MySQLiteDataReader;

        private int CurrentTrackIndex;

        private bool LoopActive;
        private bool ShuffleActive;
        private bool SearchActive;
        private bool SearchLeave;
        private bool ControlsPlayerActive;
        private bool PlayPauseState;

        private string CurrentTheme;
        private bool UseRelativePaths;
        private bool ShowTrackPaths;

        private Color ButtonOFFColor;
        private Color ButtonONColor;
        private Color CustomSelectColor;
        private Color CustomDeselectColor;

        public MainForm()
        {
            InitializeComponent();

            MySettingsForm = new SettingsForm();
            MyAboutForm = new AboutForm();

            MyPlayer = new Player();
            MyRandom = new Random();

            MySQLiteConnection = new SQLiteConnection();
            MySQLiteCommand = new SQLiteCommand();

            CurrentTrackIndex = -1;
            LoopActive = false;
            ShuffleActive = false;
            SearchActive = false;
            SearchLeave = false;
            PlayPauseState = false;

            CurrentTheme = "Khaki";
            UseRelativePaths = true;
            ShowTrackPaths = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ChooseTheme(CurrentTheme);

            StartUpTask();
        }

        private void StartUpTask()
        {
            string[] Args = Environment.GetCommandLineArgs();
            if (Args.Length > 1)
            {
                string Arg = Args[1];
                switch (Path.GetExtension(Arg).ToLower())
                {
                    case ".npl":
                        MySQLiteConnection.ConnectionString = $@"Data Source={Arg}; Version=3;";
                        MySQLiteConnection.Open();

                        MySQLiteCommand.Connection = MySQLiteConnection;
                        MySQLiteCommand.CommandText = "SELECT TrackName, TrackPath FROM tbPlaylist";
                        MySQLiteCommand.ExecuteNonQuery();

                        MySQLiteDataReader = MySQLiteCommand.ExecuteReader();
                        if (MySQLiteDataReader.HasRows)
                        {
                            while (MySQLiteDataReader.Read())
                            {
                                dataGridView_Playlist.Rows.Add(MySQLiteDataReader.GetString(0), MySQLiteDataReader.GetString(1));
                            }
                        }

                        MySQLiteDataReader.Close();
                        MySQLiteConnection.Close();

                        button_SavePlaylist.Enabled = true;
                        label_PlaylistName.Text = Path.GetFileName(Arg);

                        break;

                    case ".mp3":
                    case ".flac":
                    case ".wav":

                        if (UseRelativePaths)
                        {
                            dataGridView_Playlist.Rows.Add(Path.GetFileName(Arg), Arg.Replace(Application.StartupPath + '\\', ""));
                        }
                        else
                        {
                            dataGridView_Playlist.Rows.Add(Path.GetFileName(Arg), Arg);
                        }

                        StartTrackByIndex(0, true);

                        break;
                }
            }
        }

        private void ChooseTheme(string ThemeName)
        {
            CurrentTheme = ThemeName;

            switch (ThemeName)
            {
                case "Default":
                    menuStrip_MainForm.BackColor = SystemColors.Control;
                    toolStripMenuItem_Settings.BackColor = SystemColors.Control;
                    toolStripMenuItem_About.BackColor = SystemColors.Control;
                    toolStripMenuItem_Exit.BackColor = SystemColors.Control;

                    button_OpenPlaylist.BackColor = SystemColors.Control;
                    button_SavePlaylist.BackColor = SystemColors.Control;
                    button_SaveAsNewPlaylist.BackColor = SystemColors.Control;
                    button_ClearPlaylist.BackColor = SystemColors.Control;
                    label_PlaylistName.BackColor = SystemColors.Control;
                    textBox_Search.BackColor = SystemColors.Control;

                    label_Speed.BackColor = SystemColors.Control;
                    label_Volume.BackColor = SystemColors.Control;
                    trackBar_Speed.BackColor = SystemColors.Control;
                    trackBar_Volume.BackColor = SystemColors.Control;

                    button_Play.BackColor = SystemColors.Control;
                    button_Pause.BackColor = SystemColors.Control;
                    button_Previous.BackColor = SystemColors.Control;
                    button_Next.BackColor = SystemColors.Control;

                    ButtonOFFColor = SystemColors.Control;
                    ButtonONColor = SystemColors.ControlDark;
                    button_Loop.BackColor = LoopActive ? ButtonONColor : ButtonOFFColor;
                    button_Shuffle.BackColor = ShuffleActive ? ButtonONColor : ButtonOFFColor;

                    CustomSelectColor = SystemColors.HotTrack;
                    CustomDeselectColor = SystemColors.Window;
                    dataGridView_Playlist.BackgroundColor = SystemColors.AppWorkspace;
                    for (int i = 0; i < dataGridView_Playlist.RowCount; i++)
                    {
                        dataGridView_Playlist[0, i].Style.BackColor = CustomDeselectColor;
                        dataGridView_Playlist[1, i].Style.BackColor = CustomDeselectColor;
                    }
                    if (CurrentTrackIndex != -1)
                    {
                        dataGridView_Playlist[0, CurrentTrackIndex].Style.BackColor = CustomSelectColor;
                        dataGridView_Playlist[1, CurrentTrackIndex].Style.BackColor = CustomSelectColor;
                    }
                    dataGridView_Playlist.DefaultCellStyle.BackColor = CustomDeselectColor;
                    dataGridView_Playlist.DefaultCellStyle.SelectionBackColor = Color.NavajoWhite;


                    label_TrackName.BackColor = SystemColors.Control;
                    label_TrackPosition.BackColor = SystemColors.Control;
                    label_TrackDuration.BackColor = SystemColors.Control;
                    progressBar_TrackPosition.BackColor = SystemColors.Control;

                    break;

                case "Khaki":
                    menuStrip_MainForm.BackColor = Color.Khaki;
                    toolStripMenuItem_Settings.BackColor = Color.Khaki;
                    toolStripMenuItem_About.BackColor = Color.Khaki;
                    toolStripMenuItem_Exit.BackColor = Color.Khaki;

                    button_OpenPlaylist.BackColor = Color.Khaki;
                    button_SavePlaylist.BackColor = Color.Khaki;
                    button_SaveAsNewPlaylist.BackColor = Color.Khaki;
                    button_ClearPlaylist.BackColor = Color.Khaki;
                    label_PlaylistName.BackColor = Color.Khaki;
                    textBox_Search.BackColor = Color.AntiqueWhite;

                    label_Speed.BackColor = Color.Khaki;
                    label_Volume.BackColor = Color.Khaki;
                    trackBar_Speed.BackColor = Color.Khaki;
                    trackBar_Volume.BackColor = Color.Khaki;

                    button_Play.BackColor = Color.Khaki;
                    button_Pause.BackColor = Color.Khaki;
                    button_Previous.BackColor = Color.Khaki;
                    button_Next.BackColor = Color.Khaki;

                    ButtonOFFColor = Color.Khaki;
                    ButtonONColor = Color.Goldenrod;
                    button_Loop.BackColor = LoopActive ? ButtonONColor : ButtonOFFColor;
                    button_Shuffle.BackColor = ShuffleActive ? ButtonONColor : ButtonOFFColor;

                    CustomSelectColor = Color.Gold;
                    CustomDeselectColor = Color.Cornsilk;
                    dataGridView_Playlist.BackgroundColor = Color.Tan;
                    for (int i = 0; i < dataGridView_Playlist.RowCount; i++)
                    {
                        dataGridView_Playlist[0, i].Style.BackColor = CustomDeselectColor;
                        dataGridView_Playlist[1, i].Style.BackColor = CustomDeselectColor;
                    }
                    if (CurrentTrackIndex != -1)
                    {
                        dataGridView_Playlist[0, CurrentTrackIndex].Style.BackColor = CustomSelectColor;
                        dataGridView_Playlist[1, CurrentTrackIndex].Style.BackColor = CustomSelectColor;
                    }
                    dataGridView_Playlist.DefaultCellStyle.BackColor = CustomDeselectColor;
                    dataGridView_Playlist.DefaultCellStyle.SelectionBackColor = Color.LightSalmon;


                    label_TrackName.BackColor = Color.Khaki;
                    label_TrackPosition.BackColor = Color.Khaki;
                    label_TrackDuration.BackColor = Color.Khaki;
                    progressBar_TrackPosition.BackColor = Color.Khaki;

                    break;
            }
        }

        private void ControlsPlayerEnabled(bool EnabledMode)
        {
            ControlsPlayerActive = EnabledMode;

            button_Play.Enabled = EnabledMode;
            button_Pause.Enabled = EnabledMode;
            button_Previous.Enabled = EnabledMode;
            button_Next.Enabled = EnabledMode;
            button_Loop.Enabled = EnabledMode;
            button_Shuffle.Enabled = EnabledMode;

            label_TrackPosition.Enabled = EnabledMode;
            label_TrackDuration.Enabled = EnabledMode;
            progressBar_TrackPosition.Enabled = EnabledMode;
        }

        private void StartTrackByIndex(int TrackIndex, bool ChangeCurrentTrackIndex)
        {
            if (CurrentTrackIndex != -1)
            {
                dataGridView_Playlist[0, CurrentTrackIndex].Style.BackColor = CustomDeselectColor;
                dataGridView_Playlist[1, CurrentTrackIndex].Style.BackColor = CustomDeselectColor;
            }

            if (ChangeCurrentTrackIndex)
            {
                CurrentTrackIndex = TrackIndex;
            }
            dataGridView_Playlist[0, TrackIndex].Style.BackColor = CustomSelectColor;
            dataGridView_Playlist[1, TrackIndex].Style.BackColor = CustomSelectColor;

            if (!SearchActive)
            {
                dataGridView_Playlist.CurrentCell = dataGridView_Playlist[0, TrackIndex];
            }

            dataGridView_Playlist[0, TrackIndex].Selected = false;
            dataGridView_Playlist[1, TrackIndex].Selected = false;

            label_TrackName.Text = dataGridView_Playlist[0, TrackIndex].Value.ToString();

            if (Path.IsPathRooted(dataGridView_Playlist[1, TrackIndex].Value.ToString()))
            {
                MyPlayer.SetTrack(dataGridView_Playlist[1, TrackIndex].Value.ToString());
            }
            else
            {
                MyPlayer.SetTrack(Path.Combine(Application.StartupPath, dataGridView_Playlist[1, TrackIndex].Value.ToString()));
            }
            MyPlayer.SetSpeed(trackBar_Speed.Value / 10.0);
            MyPlayer.Play();

            PlayPauseState = true;

            ControlsPlayerEnabled(true);
        }


        private void label_TrackName_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "MUSIC|*.mp3;*.flac;*.wav|MP3|*.mp3|FLAC|*.flac|WAV|*.wav",
                Multiselect = true
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < ofd.FileNames.Length; i++)
                {
                    if (UseRelativePaths)
                    {
                        dataGridView_Playlist.Rows.Add(ofd.SafeFileNames[i], ofd.FileNames[i].Replace(Application.StartupPath + '\\', ""));
                    }
                    else
                    {
                        dataGridView_Playlist.Rows.Add(ofd.SafeFileNames[i], ofd.FileNames[i]);
                    }
                }
            }
        }

        private void dataGridView_Playlist_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            StartTrackByIndex(e.RowIndex, true);
        }

        private void dataGridView_Playlist_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (e.Row.Index < CurrentTrackIndex)
            {
                CurrentTrackIndex--;
            }
            else if (e.Row.Index == CurrentTrackIndex)
            {
                if (dataGridView_Playlist.Rows.Count > 1)
                {
                    if (CurrentTrackIndex < dataGridView_Playlist.Rows.Count - 1)
                    {
                        StartTrackByIndex(CurrentTrackIndex + 1, false);
                    }
                    else
                    {
                        StartTrackByIndex(CurrentTrackIndex - 1, true);
                    }
                }
                else
                {
                    MyPlayer.Stop();
                    ControlsPlayerEnabled(false);

                    CurrentTrackIndex = -1;

                    label_TrackName.Text = "[ Добавить треки ]";
                }
            }
        }


        private void dataGridView_Playlist_KeyDown(object sender, KeyEventArgs e)
        {
            if (dataGridView_Playlist.SelectedRows.Count > 0)
            {
                int selectedindex = dataGridView_Playlist.SelectedRows[0].Index;

                if (e.KeyCode == Keys.PageUp)
                {
                    e.Handled = true;

                    if (selectedindex > 0)
                    {
                        DataGridViewRow row = dataGridView_Playlist.Rows[selectedindex];
                        dataGridView_Playlist.Rows.Remove(row);
                        dataGridView_Playlist.Rows.Insert(selectedindex - 1, row);

                        dataGridView_Playlist.Rows[selectedindex - 1].Selected = true;
                        dataGridView_Playlist.CurrentCell = dataGridView_Playlist[0, selectedindex - 1];

                        if (selectedindex == CurrentTrackIndex)
                        {
                            CurrentTrackIndex--;
                        }
                        else if (selectedindex == CurrentTrackIndex + 1)
                        {
                            CurrentTrackIndex++;
                        }
                    }
                }
                else if (e.KeyCode == Keys.PageDown)
                {
                    e.Handled = true;

                    if (selectedindex < dataGridView_Playlist.Rows.Count - 1)
                    {
                        DataGridViewRow row = dataGridView_Playlist.Rows[selectedindex];
                        dataGridView_Playlist.Rows.Remove(row);
                        dataGridView_Playlist.Rows.Insert(selectedindex + 1, row);

                        dataGridView_Playlist.Rows[selectedindex + 1].Selected = true;
                        dataGridView_Playlist.CurrentCell = dataGridView_Playlist[0, selectedindex + 1];

                        if (selectedindex == CurrentTrackIndex)
                        {
                            CurrentTrackIndex++;
                        }
                        else if (selectedindex == CurrentTrackIndex - 1)
                        {
                            CurrentTrackIndex--;
                        }
                    }
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    e.Handled = true;

                    StartTrackByIndex(selectedindex, true);
                }
            }
        }


        private void timer_InfoUpdater_Tick(object sender, System.EventArgs e)
        {
            if (MyPlayer.GetCurrentPosition() <= MyPlayer.GetDuration()) // Rammstein Sonne.flac
            {
                label_TrackPosition.Text = MyPlayer.GetCurrentPositionString();
                label_TrackDuration.Text = MyPlayer.GetDurationString();
                progressBar_TrackPosition.Maximum = (int)(MyPlayer.GetDuration());
                progressBar_TrackPosition.Value = (int)(MyPlayer.GetCurrentPosition());
            }

            if (MyPlayer.IsMediaEnded())
            {
                if (LoopActive)
                {
                    StartTrackByIndex(CurrentTrackIndex, false);
                }
                else if (ShuffleActive)
                {
                    StartTrackByIndex(MyRandom.Next(dataGridView_Playlist.RowCount), true);
                }
                else if (CurrentTrackIndex < dataGridView_Playlist.RowCount - 1)
                {
                    StartTrackByIndex(CurrentTrackIndex + 1, true);
                }
            }
        }


        private void button_Play_Click(object sender, System.EventArgs e)
        {
            MyPlayer.Play();

            PlayPauseState = true;
        }

        private void button_Pause_Click(object sender, System.EventArgs e)
        {
            MyPlayer.Pause();

            PlayPauseState = false;
        }

        private void button_Previous_Click(object sender, System.EventArgs e)
        {
            if (0 < CurrentTrackIndex)
            {
                StartTrackByIndex(CurrentTrackIndex - 1, true);
            }
        }

        private void button_Next_Click(object sender, System.EventArgs e)
        {
            if (CurrentTrackIndex < dataGridView_Playlist.RowCount - 1)
            {
                StartTrackByIndex(CurrentTrackIndex + 1, true);
            }
        }

        private void button_Loop_Click(object sender, System.EventArgs e)
        {
            if (!LoopActive)
            {
                button_Loop.BackColor = ButtonONColor;
                LoopActive = true;
            }
            else
            {
                button_Loop.BackColor = ButtonOFFColor;
                LoopActive = false;
            }
        }

        private void button_Shuffle_Click(object sender, System.EventArgs e)
        {
            if (!ShuffleActive)
            {
                button_Shuffle.BackColor = ButtonONColor;
                ShuffleActive = true;
            }
            else
            {
                button_Shuffle.BackColor = ButtonOFFColor;
                ShuffleActive = false;
            }
        }


        private void trackBar_Volume_Scroll(object sender, System.EventArgs e)
        {
            label_Volume.Text = $"{trackBar_Volume.Value}%";
            MyPlayer.SetVolume(trackBar_Volume.Value);
        }

        private void trackBar_Speed_Scroll(object sender, System.EventArgs e)
        {
            label_Speed.Text = $"x{trackBar_Speed.Value / 10.0}";
            MyPlayer.SetSpeed(trackBar_Speed.Value / 10.0);
        }

        private void label_Volume_Click(object sender, System.EventArgs e)
        {
            trackBar_Volume.Value = 50;
            label_Volume.Text = $"{trackBar_Volume.Value}%";
            MyPlayer.SetVolume(trackBar_Volume.Value);
        }

        private void label_Speed_Click(object sender, System.EventArgs e)
        {
            trackBar_Speed.Value = 10;
            label_Speed.Text = $"x{trackBar_Speed.Value / 10.0}";
            MyPlayer.SetSpeed(trackBar_Speed.Value / 10.0);
        }


        private void progressBar_TrackPosition_MouseDown(object sender, MouseEventArgs e)
        {
            MyPlayer.SetPosition(MyPlayer.GetDuration() * e.Location.X / progressBar_TrackPosition.Width);
        }

        private void label_TrackPosition_Click(object sender, System.EventArgs e)
        {
            MyPlayer.SetPosition(0);
            label_TrackPosition.Text = "00:00";
        }

        private void label_TrackDuration_Click(object sender, System.EventArgs e)
        {
            MyPlayer.SetPosition(MyPlayer.GetDuration() - 10);
        }


        private void button_OpenPlaylist_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Playlist File|*.npl",
                Multiselect = false
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                MyPlayer.Stop();
                ControlsPlayerEnabled(false);

                CurrentTrackIndex = -1;

                dataGridView_Playlist.Rows.Clear();
                label_TrackName.Text = "[ Добавить треки ]";


                MySQLiteConnection.ConnectionString = $@"Data Source={ofd.FileName}; Version=3;";
                MySQLiteConnection.Open();

                MySQLiteCommand.Connection = MySQLiteConnection;
                MySQLiteCommand.CommandText = "SELECT TrackName, TrackPath FROM tbPlaylist";
                MySQLiteCommand.ExecuteNonQuery();

                MySQLiteDataReader = MySQLiteCommand.ExecuteReader();
                if (MySQLiteDataReader.HasRows)
                {
                    while (MySQLiteDataReader.Read())
                    {
                        dataGridView_Playlist.Rows.Add(MySQLiteDataReader.GetString(0), MySQLiteDataReader.GetString(1));
                    }
                }

                MySQLiteDataReader.Close();
                MySQLiteConnection.Close();

                button_SavePlaylist.Enabled = true;
                label_PlaylistName.Text = ofd.SafeFileName;
            }
        }

        private void button_SavePlaylist_Click(object sender, System.EventArgs e)
        {
            MySQLiteConnection.Open();

            MySQLiteCommand.CommandText = "DELETE FROM tbPlaylist";
            MySQLiteCommand.ExecuteNonQuery();

            for (int i = 0; i < dataGridView_Playlist.RowCount; i++)
            {
                MySQLiteCommand.CommandText = $@"INSERT INTO tbPlaylist (TrackName, TrackPath) VALUES ('{dataGridView_Playlist[0, i].Value.ToString().Replace("'", "''")}', '{dataGridView_Playlist[1, i].Value.ToString().Replace("'", "''")}')";
                MySQLiteCommand.ExecuteNonQuery();
            }

            MySQLiteConnection.Close();
        }

        private void button_SaveAsNewPlaylist_Click(object sender, System.EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Playlist File|*.npl"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                SQLiteConnection.CreateFile($@"{sfd.FileName}");

                MySQLiteConnection.ConnectionString = $@"Data Source={sfd.FileName}; Version=3;";
                MySQLiteConnection.Open();

                MySQLiteCommand.Connection = MySQLiteConnection;
                MySQLiteCommand.CommandText = "CREATE TABLE tbPlaylist (TrackName VARCHAR(255), TrackPath VARCHAR(260))";
                MySQLiteCommand.ExecuteNonQuery();

                for (int i = 0; i < dataGridView_Playlist.RowCount; i++)
                {
                    MySQLiteCommand.CommandText = $@"INSERT INTO tbPlaylist (TrackName, TrackPath) VALUES ('{dataGridView_Playlist[0, i].Value.ToString().Replace("'", "''")}', '{dataGridView_Playlist[1, i].Value.ToString().Replace("'", "''")}')";
                    MySQLiteCommand.ExecuteNonQuery();
                }

                MySQLiteConnection.Close();

                button_SavePlaylist.Enabled = true;
                label_PlaylistName.Text = Path.GetFileName(sfd.FileName);
            }
        }

        private void button_ClearPlaylist_Click(object sender, EventArgs e)
        {
            MyPlayer.Stop();
            ControlsPlayerEnabled(false);

            CurrentTrackIndex = -1;

            dataGridView_Playlist.Rows.Clear();
            label_TrackName.Text = "[ Выбрать треки ]";
        }


        private void toolStripMenuItem_Settings_Click(object sender, EventArgs e)
        {
            switch (CurrentTheme)
            {
                case "Default":
                    MySettingsForm.radioButton_DefaultTheme.Checked = true;
                    break;

                case "Khaki":
                    MySettingsForm.radioButton_KhakiTheme.Checked = true;
                    break;
            }

            MySettingsForm.checkBox_UseRelativePaths.Checked = UseRelativePaths;
            MySettingsForm.checkBox_ShowTrackPaths.Checked = ShowTrackPaths;

            MySettingsForm.ShowDialog();

            if (MySettingsForm.radioButton_DefaultTheme.Checked)
            {
                ChooseTheme("Default");
            }
            else if (MySettingsForm.radioButton_KhakiTheme.Checked)
            {
                ChooseTheme("Khaki");
            }

            UseRelativePaths = MySettingsForm.checkBox_UseRelativePaths.Checked;

            ShowTrackPaths = dataGridView_Playlist.Columns[1].Visible = MySettingsForm.checkBox_ShowTrackPaths.Checked;
        }

        private void toolStripMenuItem_About_Click(object sender, EventArgs e)
        {
            MyAboutForm.ShowDialog();
        }

        private void toolStripMenuItem_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void textBox_Search_Enter(object sender, EventArgs e)
        {
            SearchLeave = false;
            if (!SearchActive)
            {
                textBox_Search.Text = string.Empty;
            }
            textBox_Search.ForeColor = SystemColors.WindowText;
        }

        private void textBox_Search_Leave(object sender, EventArgs e)
        {
            SearchLeave = true;
            if (textBox_Search.Text == string.Empty)
            {
                textBox_Search.Text = "Поиск";
            }
            textBox_Search.ForeColor = SystemColors.WindowFrame;
        }

        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            if (!SearchLeave)
            {
                if (textBox_Search.Text == string.Empty)
                {
                    SearchActive = false;
                }
                else
                {
                    SearchActive = true;
                }

                for (int i = 0; i < dataGridView_Playlist.Rows.Count; i++)
                {
                    if (!dataGridView_Playlist[0, i].Value.ToString().ToLower().Contains(textBox_Search.Text.ToLower()))
                    {
                        dataGridView_Playlist.Rows[i].Visible = false;
                    }
                    else
                    {
                        dataGridView_Playlist.Rows[i].Visible = true;
                    }
                }
            }
        }


        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (ControlsPlayerActive)
            {
                if (e.KeyCode == Keys.MediaPlayPause || e.KeyCode == Keys.Space)
                {
                    e.Handled = true;

                    if (PlayPauseState)
                    {
                        MyPlayer.Pause();

                        PlayPauseState = false;
                    }
                    else
                    {
                        MyPlayer.Play();

                        PlayPauseState = true;
                    }
                }
                else if (e.KeyCode == Keys.MediaPreviousTrack)
                {
                    e.Handled = true;

                    if (0 < CurrentTrackIndex)
                    {
                        StartTrackByIndex(CurrentTrackIndex - 1, true);
                    }
                }
                else if (e.KeyCode == Keys.MediaNextTrack)
                {
                    e.Handled = true;

                    if (CurrentTrackIndex < dataGridView_Playlist.RowCount - 1)
                    {
                        StartTrackByIndex(CurrentTrackIndex + 1, true);
                    }
                }
                else if (e.KeyCode == Keys.Left)
                {
                    e.Handled = true;
                    if (MyPlayer.GetCurrentPosition() - 5 > 0)
                    {
                        MyPlayer.SetPosition(MyPlayer.GetCurrentPosition() - 5);
                    }
                    else
                    {
                        MyPlayer.SetPosition(0);
                    }
                }
                else if (e.KeyCode == Keys.Right)
                {
                    e.Handled = true;
                    if (MyPlayer.GetCurrentPosition() - 5 < MyPlayer.GetDuration())
                    {
                        MyPlayer.SetPosition(MyPlayer.GetCurrentPosition() + 5);
                    }
                    else
                    {
                        MyPlayer.SetPosition(MyPlayer.GetDuration());
                    }
                }
                else if (e.KeyCode == Keys.NumPad0)
                {
                    e.Handled = true;
                    MyPlayer.SetPosition(0);
                }
                else if (e.KeyCode == Keys.NumPad1)
                {
                    e.Handled = true;
                    MyPlayer.SetPosition(MyPlayer.GetDuration() * 0.1);
                }
                else if (e.KeyCode == Keys.NumPad2)
                {
                    e.Handled = true;
                    MyPlayer.SetPosition(MyPlayer.GetDuration() * 0.2);
                }
                else if (e.KeyCode == Keys.NumPad3)
                {
                    e.Handled = true;
                    MyPlayer.SetPosition(MyPlayer.GetDuration() * 0.3);
                }
                else if (e.KeyCode == Keys.NumPad4)
                {
                    e.Handled = true;
                    MyPlayer.SetPosition(MyPlayer.GetDuration() * 0.4);
                }
                else if (e.KeyCode == Keys.NumPad5)
                {
                    e.Handled = true;
                    MyPlayer.SetPosition(MyPlayer.GetDuration() * 0.5);
                }
                else if (e.KeyCode == Keys.NumPad6)
                {
                    e.Handled = true;
                    MyPlayer.SetPosition(MyPlayer.GetDuration() * 0.6);
                }
                else if (e.KeyCode == Keys.NumPad7)
                {
                    e.Handled = true;
                    MyPlayer.SetPosition(MyPlayer.GetDuration() * 0.7);
                }
                else if (e.KeyCode == Keys.NumPad8)
                {
                    e.Handled = true;
                    MyPlayer.SetPosition(MyPlayer.GetDuration() * 0.8);
                }
                else if (e.KeyCode == Keys.NumPad9)
                {
                    e.Handled = true;
                    MyPlayer.SetPosition(MyPlayer.GetDuration() * 0.9);
                }
            }
        }
    }
}
