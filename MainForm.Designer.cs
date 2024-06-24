namespace SubtitleBatchRenamer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            videoFolderPicker = new FolderBrowserDialog();
            searchVideoFilesButton = new Button();
            subtitleDataGridView = new DataGridView();
            subtitleDataGridIndexCol = new DataGridViewTextBoxColumn();
            subtitleDataGridSubtitleFileNameCol = new DataGridViewTextBoxColumn();
            subtitleDataGridVideoFileCol = new DataGridViewComboBoxColumn();
            subtitleDataGridSkipCol = new DataGridViewCheckBoxColumn();
            subtitleDataGridAppendLangCheckboxCol = new DataGridViewCheckBoxColumn();
            subtitleDataGridLangSelectionCol = new DataGridViewComboBoxColumn();
            subtitleDataGridAppendNumCheckboxCol = new DataGridViewCheckBoxColumn();
            subtitleDataGridNumSelectionCol = new DataGridViewComboBoxColumn();
            videoFilesFoundComboBox = new ComboBox();
            videoFilesComboBoxLabel = new Label();
            searchSubtitleFilesButton = new Button();
            processFileRenamingButton = new Button();
            exitButton = new Button();
            langComboBoxHidden = new ComboBox();
            numComboBoxHidden = new ComboBox();
            topControlPanel1 = new Panel();
            videoFolderPathTextbox = new TextBox();
            videoFileFormatDropdownLabel = new Label();
            videoFolderPickerButton = new Button();
            fileFormatComboBox = new ComboBox();
            topControlPanel2 = new Panel();
            startOverButton = new Button();
            selectAllAppendNumCheckBox = new CheckBox();
            selectAllLabel = new Label();
            selectAllAppendLangCheckBox = new CheckBox();
            selectAllSkipFileCheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)subtitleDataGridView).BeginInit();
            topControlPanel1.SuspendLayout();
            topControlPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // videoFolderPicker
            // 
            videoFolderPicker.ShowHiddenFiles = true;
            // 
            // searchVideoFilesButton
            // 
            searchVideoFilesButton.Dock = DockStyle.Right;
            searchVideoFilesButton.Location = new Point(984, 0);
            searchVideoFilesButton.Margin = new Padding(0);
            searchVideoFilesButton.Name = "searchVideoFilesButton";
            searchVideoFilesButton.Size = new Size(170, 30);
            searchVideoFilesButton.TabIndex = 6;
            searchVideoFilesButton.Text = "Search for Video Files";
            searchVideoFilesButton.UseVisualStyleBackColor = true;
            searchVideoFilesButton.Click += searchVideoFilesButton_Click;
            // 
            // subtitleDataGridView
            // 
            subtitleDataGridView.AllowUserToAddRows = false;
            subtitleDataGridView.AllowUserToDeleteRows = false;
            subtitleDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            subtitleDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            subtitleDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            subtitleDataGridView.ColumnHeadersHeight = 29;
            subtitleDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            subtitleDataGridView.Columns.AddRange(new DataGridViewColumn[] { subtitleDataGridIndexCol, subtitleDataGridSubtitleFileNameCol, subtitleDataGridVideoFileCol, subtitleDataGridSkipCol, subtitleDataGridAppendLangCheckboxCol, subtitleDataGridLangSelectionCol, subtitleDataGridAppendNumCheckboxCol, subtitleDataGridNumSelectionCol });
            subtitleDataGridView.EditMode = DataGridViewEditMode.EditOnEnter;
            subtitleDataGridView.Location = new Point(12, 84);
            subtitleDataGridView.Name = "subtitleDataGridView";
            subtitleDataGridView.RowHeadersVisible = false;
            subtitleDataGridView.RowHeadersWidth = 51;
            subtitleDataGridView.RowTemplate.Height = 29;
            subtitleDataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            subtitleDataGridView.Size = new Size(1324, 535);
            subtitleDataGridView.StandardTab = true;
            subtitleDataGridView.TabIndex = 7;
            // 
            // subtitleDataGridIndexCol
            // 
            subtitleDataGridIndexCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            subtitleDataGridIndexCol.HeaderText = "No.";
            subtitleDataGridIndexCol.MinimumWidth = 6;
            subtitleDataGridIndexCol.Name = "subtitleDataGridIndexCol";
            subtitleDataGridIndexCol.Width = 61;
            // 
            // subtitleDataGridSubtitleFileNameCol
            // 
            subtitleDataGridSubtitleFileNameCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            subtitleDataGridSubtitleFileNameCol.HeaderText = "Subtitles";
            subtitleDataGridSubtitleFileNameCol.MinimumWidth = 6;
            subtitleDataGridSubtitleFileNameCol.Name = "subtitleDataGridSubtitleFileNameCol";
            // 
            // subtitleDataGridVideoFileCol
            // 
            subtitleDataGridVideoFileCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            subtitleDataGridVideoFileCol.HeaderText = "Video Files";
            subtitleDataGridVideoFileCol.MinimumWidth = 6;
            subtitleDataGridVideoFileCol.Name = "subtitleDataGridVideoFileCol";
            // 
            // subtitleDataGridSkipCol
            // 
            subtitleDataGridSkipCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            subtitleDataGridSkipCol.HeaderText = "Skip File";
            subtitleDataGridSkipCol.MinimumWidth = 6;
            subtitleDataGridSkipCol.Name = "subtitleDataGridSkipCol";
            subtitleDataGridSkipCol.Resizable = DataGridViewTriState.False;
            subtitleDataGridSkipCol.Width = 70;
            // 
            // subtitleDataGridAppendLangCheckboxCol
            // 
            subtitleDataGridAppendLangCheckboxCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            subtitleDataGridAppendLangCheckboxCol.HeaderText = "Append Lang";
            subtitleDataGridAppendLangCheckboxCol.MinimumWidth = 6;
            subtitleDataGridAppendLangCheckboxCol.Name = "subtitleDataGridAppendLangCheckboxCol";
            subtitleDataGridAppendLangCheckboxCol.Width = 104;
            // 
            // subtitleDataGridLangSelectionCol
            // 
            subtitleDataGridLangSelectionCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            subtitleDataGridLangSelectionCol.HeaderText = "Lang";
            subtitleDataGridLangSelectionCol.MinimumWidth = 6;
            subtitleDataGridLangSelectionCol.Name = "subtitleDataGridLangSelectionCol";
            subtitleDataGridLangSelectionCol.Width = 47;
            // 
            // subtitleDataGridAppendNumCheckboxCol
            // 
            subtitleDataGridAppendNumCheckboxCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            subtitleDataGridAppendNumCheckboxCol.HeaderText = "Append Num";
            subtitleDataGridAppendNumCheckboxCol.MinimumWidth = 6;
            subtitleDataGridAppendNumCheckboxCol.Name = "subtitleDataGridAppendNumCheckboxCol";
            subtitleDataGridAppendNumCheckboxCol.Width = 104;
            // 
            // subtitleDataGridNumSelectionCol
            // 
            subtitleDataGridNumSelectionCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            subtitleDataGridNumSelectionCol.HeaderText = "Num";
            subtitleDataGridNumSelectionCol.MinimumWidth = 6;
            subtitleDataGridNumSelectionCol.Name = "subtitleDataGridNumSelectionCol";
            subtitleDataGridNumSelectionCol.Width = 47;
            // 
            // videoFilesFoundComboBox
            // 
            videoFilesFoundComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            videoFilesFoundComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            videoFilesFoundComboBox.FormattingEnabled = true;
            videoFilesFoundComboBox.Location = new Point(136, 1);
            videoFilesFoundComboBox.Name = "videoFilesFoundComboBox";
            videoFilesFoundComboBox.Size = new Size(1188, 28);
            videoFilesFoundComboBox.TabIndex = 8;
            // 
            // videoFilesComboBoxLabel
            // 
            videoFilesComboBoxLabel.AutoSize = true;
            videoFilesComboBoxLabel.Location = new Point(3, 5);
            videoFilesComboBoxLabel.Name = "videoFilesComboBoxLabel";
            videoFilesComboBoxLabel.Size = new Size(129, 20);
            videoFilesComboBoxLabel.TabIndex = 9;
            videoFilesComboBoxLabel.Text = "Video Files Found:";
            // 
            // searchSubtitleFilesButton
            // 
            searchSubtitleFilesButton.Dock = DockStyle.Right;
            searchSubtitleFilesButton.Location = new Point(1154, 0);
            searchSubtitleFilesButton.Margin = new Padding(0);
            searchSubtitleFilesButton.Name = "searchSubtitleFilesButton";
            searchSubtitleFilesButton.Size = new Size(170, 30);
            searchSubtitleFilesButton.TabIndex = 10;
            searchSubtitleFilesButton.Text = "Search for Subtitles";
            searchSubtitleFilesButton.UseVisualStyleBackColor = true;
            searchSubtitleFilesButton.Click += searchSubtitleFilesButton_Click;
            // 
            // processFileRenamingButton
            // 
            processFileRenamingButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            processFileRenamingButton.Location = new Point(1010, 656);
            processFileRenamingButton.Name = "processFileRenamingButton";
            processFileRenamingButton.Size = new Size(160, 29);
            processFileRenamingButton.TabIndex = 11;
            processFileRenamingButton.Text = "Process Files";
            processFileRenamingButton.UseVisualStyleBackColor = true;
            processFileRenamingButton.Click += processFileRenamingButton_Click;
            // 
            // exitButton
            // 
            exitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            exitButton.Location = new Point(1176, 656);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(160, 29);
            exitButton.TabIndex = 12;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // langComboBoxHidden
            // 
            langComboBoxHidden.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            langComboBoxHidden.FormattingEnabled = true;
            langComboBoxHidden.Items.AddRange(new object[] { "en", "en.SDH", "es", "fr", "aa", "ab", "ae", "af", "ak", "am", "an", "ar", "as", "av", "ay", "az", "ba", "be", "bg", "bh", "bi", "bm", "bn", "bo", "br", "bs", "ca", "ce", "ch", "co", "cr", "cs", "cu", "cv", "cy", "da", "de", "dv", "dz", "ee", "el", "eo", "et", "eu", "fa", "ff", "fi", "fj", "fo", "fy", "ga", "gd", "gl", "gn", "gu", "gv", "ha", "he", "hi", "ho", "hr", "ht", "hu", "hy", "hz", "ia", "id", "ie", "ig", "ii", "ik", "io", "is", "it", "iu", "ja", "jv", "ka", "kg", "ki", "kj", "kk", "kl", "km", "kn", "ko", "kr", "ks", "ku", "kv", "kw", "ky", "la", "lb", "lg", "li", "ln", "lo", "lt", "lu", "lv", "mg", "mh", "mi", "mk", "ml", "mn", "mr", "ms", "mt", "my", "na", "nb", "nd", "ne", "ng", "nl", "nn", "no", "nr", "nv", "ny", "oc", "oj", "om", "or", "os", "pa", "pi", "pl", "ps", "pt", "qu", "rm", "rn", "ro", "ru", "rw", "sa", "sc", "sd", "se", "sg", "si", "sk", "sl", "sm", "sn", "so", "sq", "sr", "ss", "st", "su", "sv", "sw", "ta", "te", "tg", "th", "ti", "tk", "tl", "tn", "to", "tr", "ts", "tt", "tw", "ty", "ug", "uk", "ur", "uz", "ve", "vi", "vo", "wa", "wo", "wx", "io", "za", "zh", "zu" });
            langComboBoxHidden.Location = new Point(12, 657);
            langComboBoxHidden.Name = "langComboBoxHidden";
            langComboBoxHidden.Size = new Size(151, 28);
            langComboBoxHidden.TabIndex = 13;
            langComboBoxHidden.Visible = false;
            // 
            // numComboBoxHidden
            // 
            numComboBoxHidden.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            numComboBoxHidden.FormattingEnabled = true;
            numComboBoxHidden.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            numComboBoxHidden.Location = new Point(169, 657);
            numComboBoxHidden.Name = "numComboBoxHidden";
            numComboBoxHidden.Size = new Size(151, 28);
            numComboBoxHidden.TabIndex = 14;
            numComboBoxHidden.Visible = false;
            // 
            // topControlPanel1
            // 
            topControlPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            topControlPanel1.Controls.Add(videoFolderPathTextbox);
            topControlPanel1.Controls.Add(videoFileFormatDropdownLabel);
            topControlPanel1.Controls.Add(videoFolderPickerButton);
            topControlPanel1.Controls.Add(fileFormatComboBox);
            topControlPanel1.Controls.Add(searchVideoFilesButton);
            topControlPanel1.Controls.Add(searchSubtitleFilesButton);
            topControlPanel1.Location = new Point(12, 12);
            topControlPanel1.Name = "topControlPanel1";
            topControlPanel1.Size = new Size(1324, 30);
            topControlPanel1.TabIndex = 15;
            // 
            // videoFolderPathTextbox
            // 
            videoFolderPathTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            videoFolderPathTextbox.BackColor = Color.White;
            videoFolderPathTextbox.Enabled = false;
            videoFolderPathTextbox.ForeColor = Color.White;
            videoFolderPathTextbox.Location = new Point(111, 2);
            videoFolderPathTextbox.Name = "videoFolderPathTextbox";
            videoFolderPathTextbox.Size = new Size(696, 27);
            videoFolderPathTextbox.TabIndex = 1;
            // 
            // videoFileFormatDropdownLabel
            // 
            videoFileFormatDropdownLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            videoFileFormatDropdownLabel.AutoSize = true;
            videoFileFormatDropdownLabel.Location = new Point(819, 5);
            videoFileFormatDropdownLabel.Name = "videoFileFormatDropdownLabel";
            videoFileFormatDropdownLabel.Size = new Size(59, 20);
            videoFileFormatDropdownLabel.TabIndex = 4;
            videoFileFormatDropdownLabel.Text = "Format:";
            // 
            // videoFolderPickerButton
            // 
            videoFolderPickerButton.Dock = DockStyle.Left;
            videoFolderPickerButton.Location = new Point(0, 0);
            videoFolderPickerButton.Name = "videoFolderPickerButton";
            videoFolderPickerButton.Size = new Size(105, 30);
            videoFolderPickerButton.TabIndex = 2;
            videoFolderPickerButton.Text = "Browse ...";
            videoFolderPickerButton.UseVisualStyleBackColor = true;
            videoFolderPickerButton.Click += videoFolderPickerButton_Click;
            // 
            // fileFormatComboBox
            // 
            fileFormatComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            fileFormatComboBox.BackColor = Color.White;
            fileFormatComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            fileFormatComboBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            fileFormatComboBox.ForeColor = SystemColors.WindowText;
            fileFormatComboBox.FormattingEnabled = true;
            fileFormatComboBox.Items.AddRange(new object[] { "All Files", "AVI", "MKV", "MP4", "RM", "WMV" });
            fileFormatComboBox.Location = new Point(878, 1);
            fileFormatComboBox.Name = "fileFormatComboBox";
            fileFormatComboBox.Size = new Size(105, 28);
            fileFormatComboBox.TabIndex = 5;
            // 
            // topControlPanel2
            // 
            topControlPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            topControlPanel2.Controls.Add(videoFilesComboBoxLabel);
            topControlPanel2.Controls.Add(videoFilesFoundComboBox);
            topControlPanel2.Location = new Point(12, 48);
            topControlPanel2.Name = "topControlPanel2";
            topControlPanel2.Size = new Size(1324, 30);
            topControlPanel2.TabIndex = 16;
            // 
            // startOverButton
            // 
            startOverButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            startOverButton.Location = new Point(844, 656);
            startOverButton.Name = "startOverButton";
            startOverButton.Size = new Size(160, 29);
            startOverButton.TabIndex = 17;
            startOverButton.Text = "Start Over";
            startOverButton.UseVisualStyleBackColor = true;
            startOverButton.Click += startOverButton_Click;
            // 
            // selectAllAppendNumCheckBox
            // 
            selectAllAppendNumCheckBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            selectAllAppendNumCheckBox.AutoSize = true;
            selectAllAppendNumCheckBox.Location = new Point(1216, 626);
            selectAllAppendNumCheckBox.Name = "selectAllAppendNumCheckBox";
            selectAllAppendNumCheckBox.Size = new Size(120, 24);
            selectAllAppendNumCheckBox.TabIndex = 18;
            selectAllAppendNumCheckBox.Text = "Append Num";
            selectAllAppendNumCheckBox.UseVisualStyleBackColor = true;
            selectAllAppendNumCheckBox.CheckedChanged += selectAllAppendNumCheckBox_CheckedChanged;
            // 
            // selectAllLabel
            // 
            selectAllLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            selectAllLabel.AutoSize = true;
            selectAllLabel.Location = new Point(839, 627);
            selectAllLabel.Name = "selectAllLabel";
            selectAllLabel.Size = new Size(151, 20);
            selectAllLabel.TabIndex = 19;
            selectAllLabel.Text = "Select / De-select All:";
            // 
            // selectAllAppendLangCheckBox
            // 
            selectAllAppendLangCheckBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            selectAllAppendLangCheckBox.AutoSize = true;
            selectAllAppendLangCheckBox.Location = new Point(1090, 626);
            selectAllAppendLangCheckBox.Name = "selectAllAppendLangCheckBox";
            selectAllAppendLangCheckBox.Size = new Size(120, 24);
            selectAllAppendLangCheckBox.TabIndex = 20;
            selectAllAppendLangCheckBox.Text = "Append Lang";
            selectAllAppendLangCheckBox.UseVisualStyleBackColor = true;
            selectAllAppendLangCheckBox.CheckedChanged += selectAllAppendLangCheckBox_CheckedChanged;
            // 
            // selectAllSkipFileCheckBox
            // 
            selectAllSkipFileCheckBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            selectAllSkipFileCheckBox.AutoSize = true;
            selectAllSkipFileCheckBox.Location = new Point(996, 626);
            selectAllSkipFileCheckBox.Name = "selectAllSkipFileCheckBox";
            selectAllSkipFileCheckBox.Size = new Size(86, 24);
            selectAllSkipFileCheckBox.TabIndex = 21;
            selectAllSkipFileCheckBox.Text = "Skip File";
            selectAllSkipFileCheckBox.UseVisualStyleBackColor = true;
            selectAllSkipFileCheckBox.CheckedChanged += selectAllSkipFileCheckBox_CheckedChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 703);
            Controls.Add(selectAllSkipFileCheckBox);
            Controls.Add(selectAllAppendLangCheckBox);
            Controls.Add(selectAllLabel);
            Controls.Add(selectAllAppendNumCheckBox);
            Controls.Add(startOverButton);
            Controls.Add(topControlPanel2);
            Controls.Add(topControlPanel1);
            Controls.Add(numComboBoxHidden);
            Controls.Add(langComboBoxHidden);
            Controls.Add(exitButton);
            Controls.Add(processFileRenamingButton);
            Controls.Add(subtitleDataGridView);
            MinimumSize = new Size(1366, 750);
            Name = "MainForm";
            Text = "Subtitle Renamer";
            ((System.ComponentModel.ISupportInitialize)subtitleDataGridView).EndInit();
            topControlPanel1.ResumeLayout(false);
            topControlPanel1.PerformLayout();
            topControlPanel2.ResumeLayout(false);
            topControlPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        #region My Custom Declarations and Initializations.

        HashSet<string> subtitleFileFormats = new HashSet<string>() { "*.srt", "*.ssa", "*.vtt" };
        private void CustomInitialization()
        {
            fileFormatComboBox.SelectedIndex = 0;
            videoFilesFoundComboBox.DropDownWidth = videoFilesFoundComboBox.Width;
            subtitleDataGridVideoFileCol.DropDownWidth = subtitleDataGridVideoFileCol.Width;
            searchVideoFilesButton.Enabled = false;
            searchSubtitleFilesButton.Enabled = false;
            processFileRenamingButton.Enabled = false;
            subtitleDataGridView.ShowCellToolTips = false;
            selectAllSkipFileCheckBox.Enabled = false;
            selectAllAppendLangCheckBox.Enabled = false;
            selectAllAppendNumCheckBox.Enabled = false;

            subtitleDataGridLangSelectionCol.DataSource = langComboBoxHidden.Items;
            subtitleDataGridNumSelectionCol.DataSource = numComboBoxHidden.Items;
        }

        #endregion

        private FolderBrowserDialog videoFolderPicker;
        private Button searchVideoFilesButton;
        private DataGridView subtitleDataGridView;
        private ComboBox videoFilesFoundComboBox;
        private Label videoFilesComboBoxLabel;
        private Button searchSubtitleFilesButton;
        private Button processFileRenamingButton;
        private Button exitButton;
        private ComboBox langComboBoxHidden;
        private ComboBox numComboBoxHidden;
        private Panel topControlPanel1;
        private Label videoFileFormatDropdownLabel;
        private Button videoFolderPickerButton;
        private ComboBox fileFormatComboBox;
        protected TextBox videoFolderPathTextbox;
        private Panel topControlPanel2;
        private Button startOverButton;
        private DataGridViewTextBoxColumn subtitleDataGridIndexCol;
        private DataGridViewTextBoxColumn subtitleDataGridSubtitleFileNameCol;
        private DataGridViewComboBoxColumn subtitleDataGridVideoFileCol;
        private DataGridViewCheckBoxColumn subtitleDataGridSkipCol;
        private DataGridViewCheckBoxColumn subtitleDataGridAppendLangCheckboxCol;
        private DataGridViewComboBoxColumn subtitleDataGridLangSelectionCol;
        private DataGridViewCheckBoxColumn subtitleDataGridAppendNumCheckboxCol;
        private DataGridViewComboBoxColumn subtitleDataGridNumSelectionCol;
        private CheckBox selectAllAppendNumCheckBox;
        private Label selectAllLabel;
        private CheckBox selectAllAppendLangCheckBox;
        private CheckBox selectAllSkipFileCheckBox;
    }
}
