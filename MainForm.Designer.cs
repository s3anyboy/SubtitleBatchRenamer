﻿using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

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

        ////load list of languages from language.txt
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Define path of text file named "language.txt" located in the application directory
                string lang_filePath = Path.Combine(Application.StartupPath, "language.txt");

                // Read all lines from the file
                string[] lines = File.ReadAllLines(lang_filePath);

                // Add the lines to the numComboBoxHidden
                numComboBoxHidden.Items.AddRange(lines);

            }
            catch (Exception ex)
            {
                // Handle any errors that might occur
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ComboBox langComboBoxHidden;
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            videoFolderPicker = new FolderBrowserDialog();
            searchVideoFilesButton = new Button();
            subtitleDataGridView = new DataGridView();
            subtitleDataGridIndexCol = new DataGridViewTextBoxColumn();
            subtitleDataGridSubtitleFileNameCol = new DataGridViewTextBoxColumn();
            subtitleDataGridVideoFileCol = new DataGridViewComboBoxColumn();
            subtitleDataGridSkipCol = new DataGridViewCheckBoxColumn();
            subtitleDataGridAppendLangCheckboxCol = new DataGridViewCheckBoxColumn();
            subtitleDataGridLangSelectionCol = new DataGridViewComboBoxColumn();
            subtitleDataGridAppendLabelCheckboxCol = new DataGridViewCheckBoxColumn();
            subtitleDataGridLabelSelectionCol = new DataGridViewComboBoxColumn();
            subtitleDataGridAppendNumCheckboxCol = new DataGridViewCheckBoxColumn();
            subtitleDataGridNumSelectionCol = new DataGridViewComboBoxColumn();
            videoFilesFoundComboBox = new ComboBox();
            videoFilesComboBoxLabel = new Label();
            searchSubtitleFilesButton = new Button();
            processFileRenamingButton = new Button();
            exitButton = new Button();
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
            selectAllAppendLabelCheckBox = new CheckBox();
            labelComboBoxHidden = new ComboBox();
            aboutButton = new Button();
            langComboBoxHidden = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)subtitleDataGridView).BeginInit();
            topControlPanel1.SuspendLayout();
            topControlPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // langComboBoxHidden
            // 
            langComboBoxHidden.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            langComboBoxHidden.FormattingEnabled = true;
            langComboBoxHidden.Items.AddRange(new object[] { "en-US", "zh-CN", "fr", "ja", "es", "pt" });
            langComboBoxHidden.Location = new Point(10, 500);
            langComboBoxHidden.Margin = new Padding(3, 2, 3, 2);
            langComboBoxHidden.Name = "langComboBoxHidden";
            langComboBoxHidden.Size = new Size(133, 23);
            langComboBoxHidden.TabIndex = 13;
            langComboBoxHidden.Visible = false;
            // 
            // videoFolderPicker
            // 
            videoFolderPicker.ShowHiddenFiles = true;
            // 
            // searchVideoFilesButton
            // 
            searchVideoFilesButton.Dock = DockStyle.Right;
            searchVideoFilesButton.Location = new Point(860, 0);
            searchVideoFilesButton.Margin = new Padding(0);
            searchVideoFilesButton.Name = "searchVideoFilesButton";
            searchVideoFilesButton.Size = new Size(149, 22);
            searchVideoFilesButton.TabIndex = 6;
            searchVideoFilesButton.Text = "Search for Video Files";
            searchVideoFilesButton.UseVisualStyleBackColor = true;
            searchVideoFilesButton.Click += searchVideoFilesButton_Click;
            // 
            // subtitleDataGridView
            // 
            subtitleDataGridView.AllowUserToAddRows = false;
            subtitleDataGridView.AllowUserToDeleteRows = false;
            subtitleDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.ScrollBar;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            subtitleDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            subtitleDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            subtitleDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            subtitleDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            subtitleDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            subtitleDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            subtitleDataGridView.Columns.AddRange(new DataGridViewColumn[] { subtitleDataGridIndexCol, subtitleDataGridSubtitleFileNameCol, subtitleDataGridVideoFileCol, subtitleDataGridSkipCol, subtitleDataGridAppendLangCheckboxCol, subtitleDataGridLangSelectionCol, subtitleDataGridAppendLabelCheckboxCol, subtitleDataGridLabelSelectionCol, subtitleDataGridAppendNumCheckboxCol, subtitleDataGridNumSelectionCol });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            subtitleDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            subtitleDataGridView.EditMode = DataGridViewEditMode.EditOnEnter;
            subtitleDataGridView.Location = new Point(10, 63);
            subtitleDataGridView.Margin = new Padding(3, 2, 3, 2);
            subtitleDataGridView.Name = "subtitleDataGridView";
            subtitleDataGridView.RowHeadersVisible = false;
            subtitleDataGridView.RowHeadersWidth = 51;
            subtitleDataGridView.RowTemplate.Height = 29;
            subtitleDataGridView.RowTemplate.Resizable = DataGridViewTriState.True;
            subtitleDataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            subtitleDataGridView.Size = new Size(1158, 401);
            subtitleDataGridView.StandardTab = true;
            subtitleDataGridView.TabIndex = 7;
            subtitleDataGridView.CellContentClick += subtitleDataGridView_CellContentClick;
            // 
            // subtitleDataGridIndexCol
            // 
            subtitleDataGridIndexCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            subtitleDataGridIndexCol.HeaderText = "No.";
            subtitleDataGridIndexCol.MinimumWidth = 50;
            subtitleDataGridIndexCol.Name = "subtitleDataGridIndexCol";
            subtitleDataGridIndexCol.Width = 50;
            // 
            // subtitleDataGridSubtitleFileNameCol
            // 
            subtitleDataGridSubtitleFileNameCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            subtitleDataGridSubtitleFileNameCol.HeaderText = "Subtitles";
            subtitleDataGridSubtitleFileNameCol.MinimumWidth = 50;
            subtitleDataGridSubtitleFileNameCol.Name = "subtitleDataGridSubtitleFileNameCol";
            // 
            // subtitleDataGridVideoFileCol
            // 
            subtitleDataGridVideoFileCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            subtitleDataGridVideoFileCol.HeaderText = "Video Files";
            subtitleDataGridVideoFileCol.MinimumWidth = 50;
            subtitleDataGridVideoFileCol.Name = "subtitleDataGridVideoFileCol";
            // 
            // subtitleDataGridSkipCol
            // 
            subtitleDataGridSkipCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            subtitleDataGridSkipCol.HeaderText = "Skip File";
            subtitleDataGridSkipCol.MinimumWidth = 6;
            subtitleDataGridSkipCol.Name = "subtitleDataGridSkipCol";
            subtitleDataGridSkipCol.Resizable = DataGridViewTriState.False;
            subtitleDataGridSkipCol.Width = 50;
            // 
            // subtitleDataGridAppendLangCheckboxCol
            // 
            subtitleDataGridAppendLangCheckboxCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            subtitleDataGridAppendLangCheckboxCol.HeaderText = "Add Lang";
            subtitleDataGridAppendLangCheckboxCol.MinimumWidth = 6;
            subtitleDataGridAppendLangCheckboxCol.Name = "subtitleDataGridAppendLangCheckboxCol";
            subtitleDataGridAppendLangCheckboxCol.Width = 50;
            // 
            // subtitleDataGridLangSelectionCol
            // 
            subtitleDataGridLangSelectionCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            subtitleDataGridLangSelectionCol.HeaderText = "Lang";
            subtitleDataGridLangSelectionCol.Items.AddRange(new object[] { "" });
            subtitleDataGridLangSelectionCol.MinimumWidth = 35;
            subtitleDataGridLangSelectionCol.Name = "subtitleDataGridLangSelectionCol";
            subtitleDataGridLangSelectionCol.Width = 39;
            // 
            // subtitleDataGridAppendLabelCheckboxCol
            // 
            subtitleDataGridAppendLabelCheckboxCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            subtitleDataGridAppendLabelCheckboxCol.HeaderText = "Add Label";
            subtitleDataGridAppendLabelCheckboxCol.Name = "subtitleDataGridAppendLabelCheckboxCol";
            subtitleDataGridAppendLabelCheckboxCol.Width = 50;
            // 
            // subtitleDataGridLabelSelectionCol
            // 
            subtitleDataGridLabelSelectionCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            subtitleDataGridLabelSelectionCol.HeaderText = "Label";
            subtitleDataGridLabelSelectionCol.MinimumWidth = 50;
            subtitleDataGridLabelSelectionCol.Name = "subtitleDataGridLabelSelectionCol";
            subtitleDataGridLabelSelectionCol.Width = 50;
            // 
            // subtitleDataGridAppendNumCheckboxCol
            // 
            subtitleDataGridAppendNumCheckboxCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            subtitleDataGridAppendNumCheckboxCol.HeaderText = "Add Num";
            subtitleDataGridAppendNumCheckboxCol.MinimumWidth = 6;
            subtitleDataGridAppendNumCheckboxCol.Name = "subtitleDataGridAppendNumCheckboxCol";
            subtitleDataGridAppendNumCheckboxCol.Width = 50;
            // 
            // subtitleDataGridNumSelectionCol
            // 
            subtitleDataGridNumSelectionCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            subtitleDataGridNumSelectionCol.HeaderText = "Num";
            subtitleDataGridNumSelectionCol.MinimumWidth = 6;
            subtitleDataGridNumSelectionCol.Name = "subtitleDataGridNumSelectionCol";
            subtitleDataGridNumSelectionCol.Width = 50;
            // 
            // videoFilesFoundComboBox
            // 
            videoFilesFoundComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            videoFilesFoundComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            videoFilesFoundComboBox.FormattingEnabled = true;
            videoFilesFoundComboBox.Location = new Point(119, 1);
            videoFilesFoundComboBox.Margin = new Padding(3, 2, 3, 2);
            videoFilesFoundComboBox.Name = "videoFilesFoundComboBox";
            videoFilesFoundComboBox.Size = new Size(1040, 23);
            videoFilesFoundComboBox.TabIndex = 8;
            // 
            // videoFilesComboBoxLabel
            // 
            videoFilesComboBoxLabel.AutoSize = true;
            videoFilesComboBoxLabel.Location = new Point(3, 4);
            videoFilesComboBoxLabel.Name = "videoFilesComboBoxLabel";
            videoFilesComboBoxLabel.Size = new Size(103, 15);
            videoFilesComboBoxLabel.TabIndex = 9;
            videoFilesComboBoxLabel.Text = "Video Files Found:";
            // 
            // searchSubtitleFilesButton
            // 
            searchSubtitleFilesButton.Dock = DockStyle.Right;
            searchSubtitleFilesButton.Location = new Point(1009, 0);
            searchSubtitleFilesButton.Margin = new Padding(0);
            searchSubtitleFilesButton.Name = "searchSubtitleFilesButton";
            searchSubtitleFilesButton.Size = new Size(149, 22);
            searchSubtitleFilesButton.TabIndex = 10;
            searchSubtitleFilesButton.Text = "Search for Subtitles";
            searchSubtitleFilesButton.UseVisualStyleBackColor = true;
            searchSubtitleFilesButton.Click += searchSubtitleFilesButton_Click;
            // 
            // processFileRenamingButton
            // 
            processFileRenamingButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            processFileRenamingButton.Location = new Point(884, 492);
            processFileRenamingButton.Margin = new Padding(3, 2, 3, 2);
            processFileRenamingButton.Name = "processFileRenamingButton";
            processFileRenamingButton.Size = new Size(140, 22);
            processFileRenamingButton.TabIndex = 11;
            processFileRenamingButton.Text = "Process Files";
            processFileRenamingButton.UseVisualStyleBackColor = true;
            processFileRenamingButton.Click += processFileRenamingButton_Click;
            // 
            // exitButton
            // 
            exitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            exitButton.Location = new Point(1029, 492);
            exitButton.Margin = new Padding(3, 2, 3, 2);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(140, 22);
            exitButton.TabIndex = 12;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // numComboBoxHidden
            // 
            numComboBoxHidden.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            numComboBoxHidden.FormattingEnabled = true;
            numComboBoxHidden.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            numComboBoxHidden.Location = new Point(276, 500);
            numComboBoxHidden.Margin = new Padding(3, 2, 3, 2);
            numComboBoxHidden.Name = "numComboBoxHidden";
            numComboBoxHidden.Size = new Size(133, 23);
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
            topControlPanel1.Location = new Point(10, 9);
            topControlPanel1.Margin = new Padding(3, 2, 3, 2);
            topControlPanel1.Name = "topControlPanel1";
            topControlPanel1.Size = new Size(1158, 22);
            topControlPanel1.TabIndex = 15;
            // 
            // videoFolderPathTextbox
            // 
            videoFolderPathTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            videoFolderPathTextbox.BackColor = Color.White;
            videoFolderPathTextbox.Enabled = false;
            videoFolderPathTextbox.ForeColor = Color.White;
            videoFolderPathTextbox.Location = new Point(98, 1);
            videoFolderPathTextbox.Margin = new Padding(3, 2, 3, 2);
            videoFolderPathTextbox.Name = "videoFolderPathTextbox";
            videoFolderPathTextbox.Size = new Size(610, 23);
            videoFolderPathTextbox.TabIndex = 1;
            // 
            // videoFileFormatDropdownLabel
            // 
            videoFileFormatDropdownLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            videoFileFormatDropdownLabel.AutoSize = true;
            videoFileFormatDropdownLabel.Location = new Point(714, 4);
            videoFileFormatDropdownLabel.Name = "videoFileFormatDropdownLabel";
            videoFileFormatDropdownLabel.Size = new Size(48, 15);
            videoFileFormatDropdownLabel.TabIndex = 4;
            videoFileFormatDropdownLabel.Text = "Format:";
            // 
            // videoFolderPickerButton
            // 
            videoFolderPickerButton.Dock = DockStyle.Left;
            videoFolderPickerButton.Location = new Point(0, 0);
            videoFolderPickerButton.Margin = new Padding(3, 2, 3, 2);
            videoFolderPickerButton.Name = "videoFolderPickerButton";
            videoFolderPickerButton.Size = new Size(92, 22);
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
            fileFormatComboBox.Items.AddRange(new object[] { "All Files", "AVI", "FLV", "MKV", "MOV", "MPEG", "MPG", "MP4", "M4V", "RM", "WEBM", "WMV" });
            fileFormatComboBox.Location = new Point(765, -1);
            fileFormatComboBox.Margin = new Padding(3, 2, 3, 2);
            fileFormatComboBox.Name = "fileFormatComboBox";
            fileFormatComboBox.Size = new Size(92, 23);
            fileFormatComboBox.TabIndex = 5;
            // 
            // topControlPanel2
            // 
            topControlPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            topControlPanel2.Controls.Add(videoFilesComboBoxLabel);
            topControlPanel2.Controls.Add(videoFilesFoundComboBox);
            topControlPanel2.Location = new Point(10, 36);
            topControlPanel2.Margin = new Padding(3, 2, 3, 2);
            topControlPanel2.Name = "topControlPanel2";
            topControlPanel2.Size = new Size(1158, 22);
            topControlPanel2.TabIndex = 16;
            // 
            // startOverButton
            // 
            startOverButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            startOverButton.Location = new Point(738, 492);
            startOverButton.Margin = new Padding(3, 2, 3, 2);
            startOverButton.Name = "startOverButton";
            startOverButton.Size = new Size(140, 22);
            startOverButton.TabIndex = 17;
            startOverButton.Text = "Start Over";
            startOverButton.UseVisualStyleBackColor = true;
            startOverButton.Click += startOverButton_Click;
            // 
            // selectAllAppendNumCheckBox
            // 
            selectAllAppendNumCheckBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            selectAllAppendNumCheckBox.AutoSize = true;
            selectAllAppendNumCheckBox.Location = new Point(1099, 470);
            selectAllAppendNumCheckBox.Margin = new Padding(3, 2, 3, 2);
            selectAllAppendNumCheckBox.Name = "selectAllAppendNumCheckBox";
            selectAllAppendNumCheckBox.Size = new Size(78, 19);
            selectAllAppendNumCheckBox.TabIndex = 18;
            selectAllAppendNumCheckBox.Text = "Add Num";
            selectAllAppendNumCheckBox.UseVisualStyleBackColor = true;
            selectAllAppendNumCheckBox.CheckedChanged += selectAllAppendNumCheckBox_CheckedChanged;
            // 
            // selectAllLabel
            // 
            selectAllLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            selectAllLabel.AutoSize = true;
            selectAllLabel.Location = new Point(732, 471);
            selectAllLabel.Name = "selectAllLabel";
            selectAllLabel.Size = new Size(118, 15);
            selectAllLabel.TabIndex = 19;
            selectAllLabel.Text = "Select / De-select All:";
            selectAllLabel.Click += selectAllLabel_Click;
            // 
            // selectAllAppendLangCheckBox
            // 
            selectAllAppendLangCheckBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            selectAllAppendLangCheckBox.AutoSize = true;
            selectAllAppendLangCheckBox.Location = new Point(931, 470);
            selectAllAppendLangCheckBox.Margin = new Padding(3, 2, 3, 2);
            selectAllAppendLangCheckBox.Name = "selectAllAppendLangCheckBox";
            selectAllAppendLangCheckBox.Size = new Size(77, 19);
            selectAllAppendLangCheckBox.TabIndex = 20;
            selectAllAppendLangCheckBox.Text = "Add Lang";
            selectAllAppendLangCheckBox.UseVisualStyleBackColor = true;
            selectAllAppendLangCheckBox.CheckedChanged += selectAllAppendLangCheckBox_CheckedChanged;
            // 
            // selectAllSkipFileCheckBox
            // 
            selectAllSkipFileCheckBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            selectAllSkipFileCheckBox.AutoSize = true;
            selectAllSkipFileCheckBox.Location = new Point(856, 470);
            selectAllSkipFileCheckBox.Margin = new Padding(3, 2, 3, 2);
            selectAllSkipFileCheckBox.Name = "selectAllSkipFileCheckBox";
            selectAllSkipFileCheckBox.Size = new Size(69, 19);
            selectAllSkipFileCheckBox.TabIndex = 21;
            selectAllSkipFileCheckBox.Text = "Skip File";
            selectAllSkipFileCheckBox.UseVisualStyleBackColor = true;
            selectAllSkipFileCheckBox.CheckedChanged += selectAllSkipFileCheckBox_CheckedChanged;
            // 
            // selectAllAppendLabelCheckBox
            // 
            selectAllAppendLabelCheckBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            selectAllAppendLabelCheckBox.AutoSize = true;
            selectAllAppendLabelCheckBox.Location = new Point(1014, 470);
            selectAllAppendLabelCheckBox.Margin = new Padding(3, 2, 3, 2);
            selectAllAppendLabelCheckBox.Name = "selectAllAppendLabelCheckBox";
            selectAllAppendLabelCheckBox.Size = new Size(79, 19);
            selectAllAppendLabelCheckBox.TabIndex = 22;
            selectAllAppendLabelCheckBox.Text = "Add Label";
            selectAllAppendLabelCheckBox.UseVisualStyleBackColor = true;
            selectAllAppendLabelCheckBox.CheckedChanged += selectallAppendLabelCheckBox_CheckedChanged;
            // 
            // labelComboBoxHidden
            // 
            labelComboBoxHidden.FormattingEnabled = true;
            labelComboBoxHidden.Items.AddRange(new object[] { "CC", "HI", "SDH", "FORCED", "COMMENTARY", "SIGNS" });
            labelComboBoxHidden.Location = new Point(149, 500);
            labelComboBoxHidden.Name = "labelComboBoxHidden";
            labelComboBoxHidden.Size = new Size(121, 23);
            labelComboBoxHidden.TabIndex = 23;
            labelComboBoxHidden.Visible = false;
            labelComboBoxHidden.SelectedIndexChanged += labelComboBoxHidden_SelectedIndexChanged;
            // 
            // aboutButton
            // 
            aboutButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            aboutButton.Location = new Point(13, 489);
            aboutButton.Name = "aboutButton";
            aboutButton.Size = new Size(50, 25);
            aboutButton.TabIndex = 24;
            aboutButton.Text = "About";
            aboutButton.UseVisualStyleBackColor = true;
            aboutButton.Click += aboutButton_Click_1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1181, 533);
            Controls.Add(aboutButton);
            Controls.Add(labelComboBoxHidden);
            Controls.Add(selectAllAppendLabelCheckBox);
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
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(1197, 572);
            Name = "MainForm";
            Text = "SBR";
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
            selectAllAppendLabelCheckBox.Enabled = false;
            selectAllAppendNumCheckBox.Enabled = false;

            {
                try
                {
                    // Read all lines from the text file
                    List<string> lines = new List<string>(File.ReadAllLines(@"language.txt"));

                    // Find the ComboBoxColumn
                    DataGridViewComboBoxColumn comboBoxColumn = subtitleDataGridView.Columns["subtitleDataGridLangSelectionCol"] as DataGridViewComboBoxColumn;

                    if (comboBoxColumn != null)
                    {
                        // Set the DataSource property of the ComboBoxColumn
                        comboBoxColumn.DataSource = lines;
                    }
                    else
                    {
                        MessageBox.Show("ComboBoxColumn 'subtitleDataGridLangSelectionCol' not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Handle any errors that might occur
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            subtitleDataGridLabelSelectionCol.DataSource = labelComboBoxHidden.Items;
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
        private CheckBox selectAllAppendNumCheckBox;
        private Label selectAllLabel;
        private CheckBox selectAllAppendLangCheckBox;
        private CheckBox selectAllSkipFileCheckBox;
        private CheckBox selectAllAppendLabelCheckBox;
        private ComboBox labelComboBoxHidden;
        private Button aboutButton;
        private DataGridViewTextBoxColumn subtitleDataGridIndexCol;
        private DataGridViewTextBoxColumn subtitleDataGridSubtitleFileNameCol;
        private DataGridViewComboBoxColumn subtitleDataGridVideoFileCol;
        private DataGridViewCheckBoxColumn subtitleDataGridSkipCol;
        private DataGridViewCheckBoxColumn subtitleDataGridAppendLangCheckboxCol;
        private DataGridViewComboBoxColumn subtitleDataGridLangSelectionCol;
        private DataGridViewCheckBoxColumn subtitleDataGridAppendLabelCheckboxCol;
        private DataGridViewComboBoxColumn subtitleDataGridLabelSelectionCol;
        private DataGridViewCheckBoxColumn subtitleDataGridAppendNumCheckboxCol;
        private DataGridViewComboBoxColumn subtitleDataGridNumSelectionCol;
    }
}