using System.Runtime.InteropServices;

namespace EmuXS2.ConPTY.Interop.Definitions
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct Coordinates
    {
        public short X;
        public short Y;
    }
}
