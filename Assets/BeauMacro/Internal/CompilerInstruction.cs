/*
 * Copyright (C) 2017 - 2019. Filament Games, LLC. All rights reserved.
 * Author:  Alex Beauchesne
 * Date:    23 July 2019
 * 
 * File:    CompilerInstruction.cs
 * Purpose: Instruction, with operation and optional argument.
 */

namespace BeauMacro
{
    /// <summary>
    /// String macro instruction.
    /// </summary>
    internal struct CompilerInstruction
    {
        public OpCode Operation;
        public int? IntArg;

        public CompilerInstruction(OpCode inOperation, int? inArg = null)
        {
            Operation = inOperation;
            IntArg = inArg;
        }
    }
}
