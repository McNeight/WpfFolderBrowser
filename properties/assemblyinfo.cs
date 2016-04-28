using System.Resources;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("WpfFolderBrowser")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyCompany("WpfGlue")]
[assembly: AssemblyProduct("WpfFolderBrowser")]
[assembly: AssemblyCopyright("Copyright © Microsoft 2006 / parts hbarck 2011")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: InternalsVisibleTo("VistaBridgeTests")]
[assembly: InternalsVisibleTo("VistaBridgeControls")]

#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("FE6DFCFC-609F-499C-BBA2-A77BDE13E196")]

// CA1014: Mark 'WPFFolderBrowser.dll' with CLSCompliant(true) because it exposes externally visible types.
[assembly: System.CLSCompliant(true)]

// CA1824: Because assembly 'WPFFolderBrowser.dll' contains a ResX-based resource file, mark it with the NeutralResourcesLanguage attribute, specifying the language of the resources within the assembly. This could improve lookup performance the first time a resource is retrieved.
[assembly: NeutralResourcesLanguage("en-US")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Revision and Build Numbers 
// by using the '*' as shown below:
//
// https://blogs.msdn.microsoft.com/carloc/2008/02/22/version-numbers-in-a-compiled-assembly/
//
// Build: the number of days since 1.1.2000 (you can modify this start date by setting Software\\Microsoft\\ALink\\VersionStartDate).  i.e. 1879 = 02.22.2005
//
// Revision: the number of two second intervals since midnight in local time; i.e. 31308 =  17:23:36 local time.

// Specifies the version of the assembly being attributed.
[assembly: AssemblyVersion("1.1.*")]

// Instructs a compiler to use a specific version number for the Win32 file version resource.
// The Win32 file version is not required to be the same as the assembly's version number.
[assembly: AssemblyFileVersion("1.1")]

// Defines additional version information for an assembly manifest.
[assembly: AssemblyInformationalVersion("1.1")]
