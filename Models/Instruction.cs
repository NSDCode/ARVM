using dnlib.DotNet.Emit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
