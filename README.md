# ARVM
Basic Emulator to solve simple arithmetic problems inside .NET assemblies using dnlib


# Introduction

ARVM has for purpose to be used to solve arithmetics problems inside .NET assemblies, the emulator currently supports few operations.


# Usage
![image](https://user-images.githubusercontent.com/47573987/164846051-6209dea6-c296-4e15-8fa8-611a85e5425a.png)


Create a list of ARVMInstructions, which will be basically your program, then create an instance of ARVM.
Once you did this, you can simply run your program using the 'Run' method

You can access the stack with the property 'vmStack'





## Credits

Yeet-Emulator (i got inspired by his code): https://github.com/GabrieleAsaro/Yeet-Emulator
dnlib: https://github.com/0xd4d/dnlib
