using dnlib.DotNet.Emit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArEmulator.Models.Handlers
{
    public class Ldc_i4 : Handler
    {
        public override OpCode Type => OpCodes.Ldc_I4;

        public override void Handle(ARVM VM, ARVMInstruction instruction)
        {
            object a = instruction.operand;

            VM.vmStack.Push((int)a);
        }
    }
}
