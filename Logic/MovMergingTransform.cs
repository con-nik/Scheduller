using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Scheduller.Logic
{
    internal class MovMergingTransform : ITransform
    {
        public string[] Transform(string[] inputCode)
        {
            for (int i = 0; i < inputCode.Length; i++)
            {
                CheckAddInstruction(inputCode, i);
                CheckStoreInstruction(inputCode, i);
                CheckRelationalInstruction(inputCode, i);
                CheckGardInstruction(inputCode, i);
            }

            return inputCode;
        }

        private void CheckGardInstruction(string[] inputCode, int i)
        {
            return;
        }

        private void CheckRelationalInstruction(string[] inputCode, int i)
        {
            return;
        }

        private void CheckStoreInstruction(string[] inputCode, int i)
        {
            return;
        }

        private void CheckAddInstruction(string[] inputCode, int index)
        {
            if (IsCertainInstruction(inputCode[index], "ADD"))
            {
                if (index >= 1 && IsCertainInstruction(inputCode[index - 1], "MOV"))
                {
                    List<string> movOperands = ExtractOperands(inputCode[index - 1]);
                    List<string> addOperands = ExtractOperands(inputCode[index]);

                    if (movOperands[0] == addOperands[1] || movOperands[0] == addOperands[2])
                    {
                        string newInstruction = GetNewInstruction(movOperands, addOperands);
                        inputCode[index] = newInstruction;
                    }
                }
            }
        }

        private string GetNewInstruction(List<string> movOperands, List<string> addOperands)
        {
            string hashtagNumberPattern = @"#(\d+)";
            Regex hashtagRegex = new Regex(hashtagNumberPattern);

            string returnInstruction;
            returnInstruction = $"ADD {addOperands[0]}, {movOperands[1]}, {addOperands[2]}";

            Match match1 = hashtagRegex.Match(movOperands[1]);
            Match match2 = hashtagRegex.Match(addOperands[2]);

            if (match1.Success && match2.Success &&
                int.TryParse(match1.Groups[1].Value, out int number1) &&
                int.TryParse(match2.Groups[1].Value, out int number2))
            {
                returnInstruction = $"MOV {addOperands[0]}, #{number1 + number2}";
            }

            return returnInstruction;
        }

        private bool IsCertainInstruction(string instruction, string instructionName)
        {
            return instruction.Trim().StartsWith(instructionName, StringComparison.OrdinalIgnoreCase);
        }

        static List<string> ExtractOperands(string instruction)
        {
            string[] parts = instruction.Split();
            List<string> operands = parts.Skip(1).Select(operand => operand.TrimEnd(',')).ToList();
            return operands;
        }
    }
}
