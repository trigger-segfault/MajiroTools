﻿using System.Collections.Generic;

namespace Majiro.Script {
	public class MjoScript {
		public uint EntryPointIndex;
		public readonly List<FunctionEntry> Functions;
		public readonly List<Instruction> Instructions;

		public MjoScript(uint entryPointIndex, List<FunctionEntry> functions, List<Instruction> instructions) {
			EntryPointIndex = entryPointIndex;
			Functions = functions;
			Instructions = instructions;
		}

		public int InstructionIndexFromOffset(uint offset) {
			return Instructions.FindIndex(instruction => instruction.Offset == offset);
		}
	}

	public struct FunctionEntry {
		public uint NameHash;
		public uint Offset;
	}
}