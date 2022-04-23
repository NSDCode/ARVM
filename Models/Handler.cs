using dnlib.DotNet.Emit;

namespace ArEmulator.Models.Handlers
{
    public abstract class Handler
    {
        public abstract OpCode Type { get; }
        public abstract void Handle(ARVM VM, ARVMInstruction instruction);
    }
}
