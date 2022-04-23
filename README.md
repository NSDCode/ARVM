# ARVM
ARVM (Arithmetic Virtual Machine) is a basic Emulator designed to solve simple arithmetic problems inside .NET assemblies using dnlib


# Introduction

ARVM has for purpose to be used to solve arithmetics problems inside .NET assemblies, the emulator currently supports few operations.


# Usage
```cs
    internal class MainTests
    {
        static void Main(string[] args)
        {
            List<ARVMInstruction> instructions = new List<ARVMInstruction>()
            {
                 new ARVMInstruction(OpCodes.Ldc_I4, 10),
                 new ARVMInstruction(OpCodes.Ldc_I4, 10),
                 new ARVMInstruction(OpCodes.Add, null),

            };

            ARVM VM = new ARVM(instructions);

            VM.Run();
            Console.WriteLine($"Result: {VM.vmStack.Pop()}");
            Console.ReadLine();
        }
    }
```

## Implementation

A basic implementation could look like this:

```cs
            List<OpCode> arithmetics = new List<OpCode>()
            {
                OpCodes.Add,
                OpCodes.Sub,
                OpCodes.Mul,
                OpCodes.Div,
                OpCodes.Shl,
                OpCodes.Shr,
            };

            List<Instruction> instructions = new List<Instruction>()
            {
                new Instruction(OpCodes.Ldc_I4, 10),
                new Instruction(OpCodes.Ldc_I4, 20),
                new Instruction(OpCodes.Add),
                new Instruction(OpCodes.Ret)
            };

            for (int i = 0; i < instructions.Count; i++)
            {
                var instr = instructions[i];

                if (arithmetics.Contains(instr.OpCode))
                {
                    if (instructions[i - 1].IsLdcI4() && instructions[i - 2].IsLdcI4())
                    {

                        var operand1 = instructions[i - 1].GetLdcI4Value();
                        var operand2 = instructions[i - 2].GetLdcI4Value();

                        List<ARVMInstruction> VMinstructions = new List<ARVMInstruction>()
                        {
                            new ARVMInstruction(OpCodes.Ldc_I4, operand2),
                            new ARVMInstruction(OpCodes.Ldc_I4, operand1),
                            new ARVMInstruction(instr.OpCode , instr.Operand),
                        };

                        ARVM VM = new ARVM(VMinstructions);

                        VM.Run();

                        int result = (int)VM.vmStack.Pop();

                        instructions[i] = new Instruction(OpCodes.Ldc_I4, result);
                        instructions.RemoveAt(i - 1);
                        instructions.RemoveAt(i - 2);

                        foreach (Instruction instruction in instructions)
                        {
                            Console.WriteLine(instruction.ToString());
                        }
                        



                    }
                }
            }

            Console.ReadLine();
```

before:
```
IL_0000: ldc.i4 10
IL_0000: ldc.i4 20
IL_0000: add
IL_0000: ret
```

after:
```
IL_0000: ldc.i4 30
IL_0000: ret
```


## Credits

Yeet-Emulator (i got inspired by his code): https://github.com/GabrieleAsaro/Yeet-Emulator

dnlib: https://github.com/0xd4d/dnlib
