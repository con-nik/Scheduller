using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduller.Logic
{
    public static class Utils
    {
        public static bool IsCertainInstruction(string instruction, string instructionName)
        {
            return instruction.Trim().StartsWith(instructionName, StringComparison.OrdinalIgnoreCase);
        }

        public static List<string> ExtractInstructionWithOperands(string instruction)
        {
            string[] parts = instruction.Split();
            List<string> operands = parts.Skip(1).Select(operand => operand.TrimEnd(',')).ToList();
            return operands;
        }
    }
}
