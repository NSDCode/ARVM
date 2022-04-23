using dnlib.DotNet.Emit;

namespace ArEmulator.Models
{
    public class ARVMInstruction
    {
        public OpCode opCode { get; set; }
        public object operand { get; set; }

        public ARVMInstruction(OpCode opCode, object operand)
        {
            this.opCode = opCode;
            this.operand = operand; 
        }


    }
}
