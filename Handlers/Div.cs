using dnlib.DotNet.Emit;
using System;

namespace ArEmulator.Models.Handlers
{
    public class Div : Handler
    {
        public override OpCode Type => OpCodes.Div;

        public override void Handle(ARVM VM, ARVMInstruction instruction)
        {
            object a = VM.vmStack.Pop();
            object b = VM.vmStack.Pop();

            try
            {
                VM.vmStack.Push((int)b / (int)a);
            }
            catch (DivideByZeroException)
            {
                // will ignore division by 0
                VM.vmStack.Push(b);
                VM.vmStack.Push(a);
            }

            VM.ind++;
        }
    }
}
