namespace KzA.Blazor.HexDump
{
    internal static class Helper
    {
        internal static char AsciiFromByte(byte b)
        {
            if (b < 0x21 || b > 0x7E)
            {
                return '.';
            }
            return (char)b;
        }
    }
}
