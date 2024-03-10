using System;
using Iced.Intel;

namespace EmuXS2.VCPU
{
    internal class CPU
    {

        public void x32()
        {
            byte[] bytes = new byte[] { 0x48, 0x8B, 0xC8 }; // mov rcx, rax
            var codeReader = new ByteArrayCodeReader(bytes);
            var decoder = Iced.Intel.Decoder.Create(32, codeReader);
            var instruction = decoder.Decode();

            Console.WriteLine(instruction.Mnemonic); // Outputs: Mov
            Console.WriteLine(instruction.Op0Kind);  // Outputs: Register
            Console.WriteLine(instruction.Op1Kind);  // Outputs: Register
            Console.WriteLine(instruction.Op0Register); // Outputs: RCX
            Console.WriteLine(instruction.Op1Register); // Outputs: RAX
        }
        public class Disassembly
        {
            private readonly byte[] _moduleData;
            private readonly Decoder _decoder;
            private readonly ByteArrayCodeReader _codeReader;
            public readonly InstructionList Instructions;


            public Disassembly(byte[] moduleData)
            {
                _moduleData = moduleData;
                _codeReader = new ByteArrayCodeReader(_moduleData);
                _decoder = Decoder.Create(16, _codeReader);
                _decoder.IP = 0x0;

                Instructions = new InstructionList();

            }

            public void Disassemble()
            {
                while (_decoder.IP < (ulong)_moduleData.Length)
                {
                    _decoder.Decode(out Instructions.AllocUninitializedElement());
                }
            }
        }


        public static void Main(string[] args)
        {


            
        }
    }    
}
