using System.Runtime.InteropServices;

namespace Cassia.Impl
{
    [StructLayout(LayoutKind.Sequential)]
    public struct WTSINFOEX
    {
        [MarshalAs(UnmanagedType.U4)]
        public uint Level;
        public int Unknown;
        public WTSINFOEX_LEVEL Data;
    }

}