using EmuXS2.ConPTY.Interop.Definitions;

namespace EmuXS2.ConPTY
{

    public class TermConPTY : WindowsPseudoConsole
    {

        public new ProcessInfo Start(short width = 80, short height = 30)
        {
            FileName = "cmd.exe";

            return base.Start(width, height);
        }
    }
}
