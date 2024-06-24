using System.Windows.Forms;

namespace SubtitleBatchRenamer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CustomInitialization();
            this.Icon = Properties.Resources.SBR;
        }

        private void videoFolderPickerButton_Click(object sender, EventArgs e)
        {
            DialogResult videoFolderPickerDialogResult = videoFolderPicker.ShowDialog();
            if (videoFolderPickerDialogResult == DialogResult.OK)
            {
                videoFolderPathTextbox.Text = videoFolderPicker.SelectedPath;
                searchVideoFilesButton.Enabled = true;
                searchSubtitleFilesButton.Enabled = false;
                processFileRenamingButton.Enabled = false;
                subtitleDataGridView.Rows.Clear();
                videoFilesFoundComboBox.Items.Clear();
            }
            else if (videoFolderPickerDialogResult == DialogResult.Cancel)
            {
                videoFolderPathTextbox.Text = null;
                subtitleDataGridView.Rows.Clear();
                videoFilesFoundComboBox.Items.Clear();
                searchVideoFilesButton.Enabled = false;
                searchSubtitleFilesButton.Enabled = false;
                processFileRenamingButton.Enabled = false;
            }
        }

        private void searchVideoFilesButton_Click(object sender, EventArgs e)
        {
            if (videoFolderPicker.SelectedPath != null)
            {
                string fileFormat = System.String.Empty;
                List<string> videoFiles = new List<string>();

                videoFilesFoundComboBox.Items.Clear();

                if (fileFormatComboBox.SelectedItem.ToString() == "All Files" || fileFormatComboBox.SelectedItem.ToString() == null)
                {
                    foreach (object item in fileFormatComboBox.Items)
                    {
                        if (item.ToString() == null || item.ToString() == "All Files")
                        {
                            continue;
                        }
                        else
                        {
                            fileFormat = "*." + item.ToString().ToLower();
                            videoFiles.AddRange(Directory.GetFiles(videoFolderPicker.SelectedPath, fileFormat, SearchOption.AllDirectories));
                        }
                    }
                }
                else
                {
                    fileFormat = "*." + fileFormatComboBox.SelectedItem.ToString().ToLower();
                    videoFiles.AddRange(Directory.GetFiles(videoFolderPicker.SelectedPath, fileFormat, SearchOption.AllDirectories));
                }

                if (videoFiles.Count > 0)
                {
                    foreach (String videoFile in videoFiles)
                    {
                        videoFilesFoundComboBox.Items.Add(videoFile);
                    }

                    videoFilesFoundComboBox.SelectedIndex = 0;

                    subtitleDataGridVideoFileCol.DataSource = videoFilesFoundComboBox.Items;

                    searchSubtitleFilesButton.Enabled = true;
                    processFileRenamingButton.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No video files found in directory!", "No Videos Found!");
                }
            }
            else
            {
                MessageBox.Show("No folder selected!", "No Folder Selected!");
            }
        }

        private void searchSubtitleFilesButton_Click(object sender, EventArgs e)
        {
            List<string> subtitleFiles = new List<string>();

            subtitleDataGridView.Rows.Clear();

            foreach (string subtitleFileFormat in subtitleFileFormats)
            {
                subtitleFiles.AddRange(Directory.GetFiles(videoFolderPicker.SelectedPath, subtitleFileFormat, SearchOption.AllDirectories));
            }

            if (subtitleFiles.Count > 0)
            {
                int rowIndex = 1;
                foreach (string subtitleFile in subtitleFiles)
                {
                    int numColDefaultValue = 0;
                    int rowId = subtitleDataGridView.Rows.Add();
                    subtitleDataGridView.Rows[rowId].Cells[subtitleDataGridIndexCol.Index].Value = (rowIndex).ToString();
                    subtitleDataGridView.Rows[rowId].Cells[subtitleDataGridSubtitleFileNameCol.Index].Value = subtitleFile;

                    if (videoFilesFoundComboBox.Items.Count > 0)
                    {
                        foreach (object videoFile in videoFilesFoundComboBox.Items)
                        {
                            if (subtitleFile.Contains(Path.GetFileNameWithoutExtension(videoFile.ToString())))
                            {
                                subtitleDataGridView.Rows[rowId].Cells[subtitleDataGridVideoFileCol.Index].Value = videoFile.ToString();
                                break;
                            }
                        }

                        subtitleDataGridView.Rows[rowId].Cells[subtitleDataGridLangSelectionCol.Index].Value = subtitleDataGridLangSelectionCol.Items[0];

                        if (subtitleDataGridView.Rows.Count == 1)
                        {
                            subtitleDataGridView.Rows[rowId].Cells[subtitleDataGridNumSelectionCol.Index].Value = subtitleDataGridNumSelectionCol.Items[0];
                        }
                        else if (subtitleDataGridView.Rows.Count > 1)
                        {
                            foreach (DataGridViewRow row in subtitleDataGridView.Rows)
                            {
                                if (row.Index != rowId && row.Cells[subtitleDataGridVideoFileCol.Index].Value == subtitleDataGridView.Rows[rowId].Cells[subtitleDataGridVideoFileCol.Index].Value)
                                {
                                    numColDefaultValue++;
                                }
                            }

                            if (numColDefaultValue <= numComboBoxHidden.Items.Count - 1)
                            {
                                subtitleDataGridView.Rows[rowId].Cells[subtitleDataGridNumSelectionCol.Index].Value = subtitleDataGridNumSelectionCol.Items[numColDefaultValue];
                            }
                            else
                            {
                                subtitleDataGridView.Rows[rowId].Cells[subtitleDataGridNumSelectionCol.Index].Value = subtitleDataGridNumSelectionCol.Items[0];
                            }
                        }
                    }
                    rowIndex++;
                }

                processFileRenamingButton.Enabled = true;
                selectAllSkipFileCheckBox.Enabled = true;
                selectAllAppendLangCheckBox.Enabled = true;
                selectAllAppendNumCheckBox.Enabled = true;
            }
            else
            {
                MessageBox.Show("No subtitles found!", "No Subtitles Found!");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void processFileRenamingButton_Click(object sender, EventArgs e)
        {
            if (subtitleDataGridView.Rows.Count > 0)
            {
                string currentSubtitleFileName = "";
                string newSubtitleFileName = "";
                string newSubtitleFileFullPath = "";
                string subtitleFileExtension = "";
                string videoFileName = "";
                string subtitleFileDirectory = "";
                string subtitleFileFullPath = "";
                string videoFileDirectory = "";

                foreach (DataGridViewRow row in subtitleDataGridView.Rows)
                {
                    if (row.Cells[subtitleDataGridSkipCol.Index].Value != null)
                    {
                        if ((bool)row.Cells[subtitleDataGridSkipCol.Index].Value == true)
                        {
                            continue;
                        }
                    }

                    if (row.Cells[subtitleDataGridSubtitleFileNameCol.Index].Value != null && row.Cells[subtitleDataGridVideoFileCol.Index].Value != null)
                    {
                        currentSubtitleFileName = Path.GetFileNameWithoutExtension(row.Cells[subtitleDataGridSubtitleFileNameCol.Index].Value.ToString());
                        subtitleFileExtension = Path.GetExtension(row.Cells[subtitleDataGridSubtitleFileNameCol.Index].Value.ToString());
                        subtitleFileDirectory = Path.GetDirectoryName(row.Cells[subtitleDataGridSubtitleFileNameCol.Index].Value.ToString());
                        subtitleFileFullPath = row.Cells[subtitleDataGridSubtitleFileNameCol.Index].Value.ToString();
                        videoFileName = Path.GetFileNameWithoutExtension(row.Cells[subtitleDataGridVideoFileCol.Index].Value.ToString());
                        videoFileDirectory = Path.GetDirectoryName(row.Cells[subtitleDataGridVideoFileCol.Index].Value.ToString());

                        newSubtitleFileName = videoFileName;

                        DataGridViewCheckBoxCell appendLangCheckboxCell = row.Cells[subtitleDataGridAppendLangCheckboxCol.Index] as DataGridViewCheckBoxCell;
                        DataGridViewCheckBoxCell appendNumCheckboxCell = row.Cells[subtitleDataGridAppendNumCheckboxCol.Index] as DataGridViewCheckBoxCell;

                        if (row.Cells[subtitleDataGridAppendLangCheckboxCol.Index].Value != null && (bool)row.Cells[subtitleDataGridAppendLangCheckboxCol.Index].Value == true)
                        {
                            if (row.Cells[subtitleDataGridLangSelectionCol.Index].Value != null && row.Cells[subtitleDataGridLangSelectionCol.Index].Value.ToString() != "")
                            {
                                newSubtitleFileName += "." + row.Cells[subtitleDataGridLangSelectionCol.Index].Value.ToString();
                            }
                            else
                            {
                                MessageBox.Show("No language selected! Please select a subtitle language.", "No language selected!");
                                return;
                            }
                        }

                        if (row.Cells[subtitleDataGridAppendNumCheckboxCol.Index].Value != null && (bool)row.Cells[subtitleDataGridAppendNumCheckboxCol.Index].Value == true)
                        {
                            if (row.Cells[subtitleDataGridNumSelectionCol.Index].Value != null && row.Cells[subtitleDataGridNumSelectionCol.Index].Value.ToString() != "")
                            {
                                newSubtitleFileName += "." + row.Cells[subtitleDataGridNumSelectionCol.Index].Value.ToString();
                            }
                            else
                            {
                                MessageBox.Show("No numbering selected! Please select a number to append to the subtitle file.", "No subtitle number selected!");
                                return;
                            }
                        }

                        newSubtitleFileName += subtitleFileExtension;
                        newSubtitleFileFullPath = Path.Combine(videoFileDirectory, newSubtitleFileName);
                        if (!File.Exists(newSubtitleFileFullPath))
                        {
                            File.Move(subtitleFileFullPath, newSubtitleFileFullPath);
                        }
                    }

                    currentSubtitleFileName = "";
                    newSubtitleFileName = "";
                    subtitleFileExtension = "";
                    videoFileName = "";
                    subtitleFileDirectory = "";
                    videoFileDirectory = "";
                    newSubtitleFileFullPath = "";
                    subtitleFileFullPath = "";
                }

                MessageBox.Show("All files have been processed successfully! File list will be emptied.", "Operation Successful!");

                videoFolderPathTextbox.Text = null;
                subtitleDataGridView.Rows.Clear();
                videoFilesFoundComboBox.Items.Clear();
                searchVideoFilesButton.Enabled = false;
                searchSubtitleFilesButton.Enabled = false;
                processFileRenamingButton.Enabled = false;
                selectAllSkipFileCheckBox.Checked = false;
                selectAllAppendLangCheckBox.Checked = false;
                selectAllAppendNumCheckBox.Checked = false;
                selectAllSkipFileCheckBox.Enabled = false;
                selectAllAppendLangCheckBox.Enabled = false;
                selectAllAppendNumCheckBox.Enabled = false;
            }
        }

        private void startOverButton_Click(object sender, EventArgs e)
        {
            videoFolderPathTextbox.Text = null;
            subtitleDataGridView.Rows.Clear();
            videoFilesFoundComboBox.Items.Clear();
            searchVideoFilesButton.Enabled = false;
            searchSubtitleFilesButton.Enabled = false;
            processFileRenamingButton.Enabled = false;
            selectAllSkipFileCheckBox.Checked = false;
            selectAllAppendLangCheckBox.Checked = false;
            selectAllAppendNumCheckBox.Checked = false;
            selectAllSkipFileCheckBox.Enabled = false;
            selectAllAppendLangCheckBox.Enabled = false;
            selectAllAppendNumCheckBox.Enabled = false;
        }

        private void selectAllAppendLangCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (subtitleDataGridView.Rows.Count > 0)
            {
                if (selectAllAppendLangCheckBox.Checked)
                {
                    foreach (DataGridViewRow row in subtitleDataGridView.Rows)
                    {
                        row.Cells[subtitleDataGridAppendLangCheckboxCol.Index].Value = true;
                    }
                }
                else
                {
                    foreach (DataGridViewRow row in subtitleDataGridView.Rows)
                    {
                        row.Cells[subtitleDataGridAppendLangCheckboxCol.Index].Value = false;
                    }
                }
            }
        }

        private void selectAllAppendNumCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (subtitleDataGridView.Rows.Count > 0)
            {
                if (selectAllAppendNumCheckBox.Checked)
                {
                    foreach (DataGridViewRow row in subtitleDataGridView.Rows)
                    {
                        row.Cells[subtitleDataGridAppendNumCheckboxCol.Index].Value = true;
                    }
                }
                else
                {
                    foreach (DataGridViewRow row in subtitleDataGridView.Rows)
                    {
                        row.Cells[subtitleDataGridAppendNumCheckboxCol.Index].Value = false;
                    }
                }
            }
        }

        private void selectAllSkipFileCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (subtitleDataGridView.Rows.Count > 0)
            {
                if (selectAllSkipFileCheckBox.Checked)
                {
                    foreach (DataGridViewRow row in subtitleDataGridView.Rows)
                    {
                        row.Cells[subtitleDataGridSkipCol.Index].Value = true;
                    }
                }
                else
                {
                    foreach (DataGridViewRow row in subtitleDataGridView.Rows)
                    {
                        row.Cells[subtitleDataGridSkipCol.Index].Value = false;
                    }
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
