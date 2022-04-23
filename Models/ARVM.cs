using ArEmulator.Models.Handlers;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ArEmulator.Models
{
    public class ARVM
    {
        public Stack vmStack = new Stack();
        private List<ARVMInstruction> instructions { get; set; }

        public int ind = 0;

        List<Handler> handlers = new List<Handler>()
        {
            new Ldc_i4(),
            new Add(),
            new Sub(),
            new Mul(),
            new Div(),
            new Shl(),
            new Shr(),
        };
        public ARVM(List<ARVMInstruction> instructions)
        {
            this.instructions = instructions;
        }

        public void Run()
        {
            foreach (ARVMInstruction instruction in this.instructions)
            {
                // tries to find an handler which is the same type as the current instruction's OpCode
                Handler handler = handlers.Where(x => x.Type == instruction.opCode).FirstOrDefault();
                
                if (handler == null)
                {
                    throw new System.Exception($"Uknown OpCode ({instruction.opCode})");
                }

                handler.Handle(this, instruction);

            }
        }

    }
}
