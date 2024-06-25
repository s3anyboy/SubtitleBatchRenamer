# Subtitle Batch Renamer (SBR)


## Summary

- This project is written in C# as a Windows Forms App.
- This tool automatically searches for video files and subtitle files within the selected folder (recursively), attempts to match the subtitle files to their corresponding video files, and provides options to append language code and file numbering for multiple subtitle files. When subtitle files are processed, they get renamed accordingly to match their associated video files' names and moved into the same directory as the video files. 


## To-Dos in future updates

- Implement INFO and ERROR logging.
- Implement method to export original file names and file path to a text (.txt) file before file renaming and moving.
- Implement method to help differentiate between same-language subtitle types (filesize compare?)
