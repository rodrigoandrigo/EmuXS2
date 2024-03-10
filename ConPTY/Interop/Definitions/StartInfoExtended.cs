using System;
using System.Runtime.InteropServices;

namespace EmuXS2.ConPTY.Interop.Definitions
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    internal struct StartInfoExtended
    {
        public StartInfo StartupInfo;
        public IntPtr lpAttributeList;
    }
}
