using ArEmulator.Models;
using dnlib.DotNet.Emit;
using System;
using System.Collections.Generic;

namespace ArEmulator
{
    internal class MainTests
    {
        static void Main(string[] args)
        {
            List<ARVMInstruction> instructions = new List<ARVMInstruction>()
            {
                 new ARVMInstruction(OpCodes.Ldc_I4, 10),
                 new ARVMInstruction(OpCodes.Ldc_I4, 10),
                 new ARVMInstruction(OpCodes.Add, null),
                 new ARVMInstruction(OpCodes.Ldc_I4, 5),
                 new ARVMInstruction(OpCodes.Div, null),
                 new ARVMInstruction(OpCodes.Ldc_I4, 3),
                 new ARVMInstruction(OpCodes.Mul, null)

            };

            ARVM VM = new ARVM(instructions);

            VM.Run();
            Console.WriteLine($"Result: {VM.vmStack.Pop()}");
            Console.ReadLine();
        }
    }
}
