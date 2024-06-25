using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubtitleBatchRenamer
{
    partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            this.Text = "SBR About";
            this.labelProductName.Text = "Subtitle Batch Renamer (SBR)";
            this.labelVersion.Text = "Version: 1.1.2";
            this.textBoxDescription.Text = "This tool automatically searches for video files and subtitle files within the selected folder (recursively), attempts to match the subtitle files to their corresponding video files, and provides options to append language code, labels, and file numbering for multiple subtitle files. When subtitle files are processed, they get renamed accordingly to match their associated video files' names and moved into the same directory as the video files.\r\n\r\nOptions: \r\nSkip File: The file will not be processed.\r\nAdd Lang: Add a language identifier code to the end of the subtitle name.[1]\r\nAdd Label: Add a label tag to the end of the subtitle name.[2]\r\nAdd Num: Add a number to the end of the subtitle name.\r\n\r\n[1] The most common and widely support code is the 2-letter ISO 639 so all valid languages are included. Some players support IETF BCP 47 with country subdivision (en-US) so the most common country subdivions are also included. Some 3-letter codes for ConLangs without 2-letter codes are also included. (Klingon and Elvish languages). \r\nIf you need a missing code, simply add it as a new line in language.txt.\r\n\r\n[2] Not all players or applications support all labels. Labels available:\r\nCC - Closed Captions\r\nHI - Hearing Impaired\r\nSDH - Subtitles for Deaf & Hard of Hearing\r\nCOMMENTARY - Commentary\r\nSIGNS - Signs (& Songs) \r\n\r\nCreated by: jameswsullivan\r\nContributions: s3anyboy";
        }
    }

}
