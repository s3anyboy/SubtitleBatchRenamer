


# Subtitle Batch Renamer (SBR)


## Summary

- This project is written in C# as a Windows Forms App.
- This tool automatically searches for video files and subtitle files within the selected folder (recursively), attempts to match the subtitle files to their corresponding video files, and provides options to append language code, labels, and file numbering for multiple subtitle files. When subtitle files are processed, they get renamed accordingly to match their associated video files' names and moved into the same directory as the video files. 

## Options 
- Skip File: The file will not be processed.
- Add Lang: Add a language identifier code to the end of the subtitle name.
- Add Label: Add a label tag to the end of the subtitle name.
- Add Num: Add a number to the end of the subtitle name.

**Language**

The most common and widely support code is the 2-letter ISO 639 so all valid languages are included. Some players support IETF BCP 47 with country subdivision (en-US) so the most common country subdivions are also included. Some 3-letter codes for ConLangs without 2-letter codes are also included. (Klingon and Elvish languages). 
If you need a missing language code, simply add it as a new line in language.txt.

**Labels**

Not all players or applications support all labels. The available labels are:
- CC - Closed Captions
- HI - Hearing Impaired
- SDH - Subtitles for Deaf & Hard of Hearing
- COMMENTARY - Commentary
- SIGNS - Signs (& Songs) 

## Credits
- Created by: jameswsullivan
- Contributions: s3anyboy

## To-Dos in future updates

- Implement INFO and ERROR logging.
- Implement method to export original file names and file path to a text (.txt) file before file renaming and moving.
- Implement method to help differentiate between same-language subtitle types (filesize compare?)
- Implement method to deal with extremely long filepath names for better readability.
