using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
// using Microsoft.SDK.Samples.VistaBridge.Library;
// using Microsoft.SDK.Samples.VistaBridge.Interop;
using WPFFolderBrowser;
using WPFFolderBrowser.Interop;

namespace WPFFolderBrowser
{
    /// <summary>
    /// Provides access to a Vista Common File Dialog in Pick Folder mode, which allows the user
    /// to select a folder.
    /// </summary>
    public sealed class WPFFolderBrowserDialog : CommonFileDialog
    {
        private NativeFileOpenDialog openDialogCoClass;

        public WPFFolderBrowserDialog() : base() { }
        public WPFFolderBrowserDialog(string name) : base(name) { }

        internal override IFileDialog GetNativeFileDialog()
        {
            Debug.Assert(openDialogCoClass != null,
                "Must call Initialize() before fetching dialog interface");
            return (IFileDialog)openDialogCoClass;
        }

        internal override void InitializeNativeFileDialog()
        {
            openDialogCoClass = new NativeFileOpenDialog();
        }

        internal override void CleanUpNativeFileDialog()
        {
            if (openDialogCoClass != null)
                Marshal.ReleaseComObject(openDialogCoClass);
        }

        internal override void PopulateWithFileNames(Collection<string> names)
        {
            IShellItemArray resultsArray;
            uint count;
            
            openDialogCoClass.GetResults(out resultsArray);
            resultsArray.GetCount(out count);
            for (int i = 0; i < count; i++)
                names.Add(GetFileNameFromShellItem(GetShellItemAt(resultsArray, i)));
        }

        internal override NativeMethods.FOS GetDerivedOptionFlags(NativeMethods.FOS flags)
        {
            
                flags |= NativeMethods.FOS.FOS_PICKFOLDERS;
            // TODO: other flags

            return flags;
        }
    }
}
