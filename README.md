[![Build status](https://ci.appveyor.com/api/projects/status/lj6l90oofv42u4se/branch/master?svg=true)](https://ci.appveyor.com/project/McNeight/wpffolderbrowser/branch/master)

## Project Description
Use the Windows Vista / Windows 7 Folder Browser Dialog from your WPF projects, without any additional dependencies.

## Remarks

This project was adapted from the Vista Bridge sample on [MSDN](http://msdn2.microsoft.com/en-us/library/ms756482.aspx). Basically, I did only the following:

    Get the example to run under .Net 4.0 .
    Add the FOS_PICKFOLDER option to the initialization code of the OpenFileDialog.
    Add members to set an initial folder and to set the initial text of the file name TextBox.
    Remove members that did not apply to the FolderBrowser dialog.
    Remove unused code and dependencies.
    Rename public classes and namespaces.


As a result, the WPFFolderBrowserDialog class can now be used out of the box in WPF projects, much like the Microsoft.Win32.OpenFileDialog class, which actually lacks only a way to set the FOS_PICKFOLDER option in order to support this scenario (I still hope that some day some one will add this possibility and make this project obsolete!).

Actually, everybody could do this by themselves, but since it took me roughly a day to figure out how to do it, I thought I'd share the result with the community...

## Installation

    Download the WPFFolderBrowser.dll DLL to your project directory.
    Unblock it for usage in VS (see http://msdn.microsoft.com/en-us/library/ee890038(VS.100).aspx for details).
    Add a reference to it to your project.

## Building from Source

The WPFFolderBrowser library has been built using Microsoft Visual C# 2010 Express. The solution / project files are contained in the source code repository.

## Usage

    Instantiate the class WPFFolderBrowser.WPFFolderBrowserDialog.
    Set the diverse options. The options work as on OpenFileDialog. Options which do not apply to choosing folders have been removed.
    Optionally, set InitialDirectory to a folder that will be opened by default.
    Also optionally, set FileName to the current value of the folder you want to select.
    Call ShowDialog. If the function returns true, the user has selected a folder.
    Retrieve the path of the selected folder through the FileName property.

## Additional License Information

The license for the original sample code from MSDN is included in the source code repository. The original sample code on which this project is based can be obtained here: http://msdn2.microsoft.com/en-us/library/ms756482.aspx .