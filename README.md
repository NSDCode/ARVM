# ARVM
Basic Emulator to solve simple arithmetic problems inside .NET assemblies using dnlib


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




Create a list of ARVMInstructions, which will be basically your program, then create an instance of ARVM.
Once you did this, you can simply run your program using the 'Run' method

You can access the stack with the property 'vmStack'





## Credits

Yeet-Emulator (i got inspired by his code): https://github.com/GabrieleAsaro/Yeet-Emulator
dnlib: https://github.com/0xd4d/dnlib
