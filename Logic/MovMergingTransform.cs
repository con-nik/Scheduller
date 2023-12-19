using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Scheduller.Logic
{
    internal class MovMergingTransform : ITransform
    {
        private readonly Dictionary<string, string> relationalValues;
        public MovMergingTransform()
        {
            relationalValues = new Dictionary<string, string>
            {
                { "GT", "LTE" },
                { "LTE", "GT" },
                { "LT", "GTE"},
                { "GTE", "LT"},
            };
        }

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

        private void CheckRelationalInstruction(string[] inputCode, int index)
        {
            if (Utils.IsCertainInstruction(inputCode[index], "MOV"))
            {
                if (index + 1 < inputCode.Length && IsRelationalInstruction(inputCode[index + 1]))
                {
                    List<string> movParts = Utils.ExtractInstructionWithOperands(inputCode[index]);
                    List<string> relationalParts = Utils.ExtractInstructionWithOperands(inputCode[index + 1]);

                    if (movParts[1] == relationalParts[2] || movParts[1] == relationalParts[3])
                    {
                        string newInstruction = GetNewInstructionRelational(movParts, relationalParts);
                        inputCode[index + 1] = newInstruction;
                    }
                }
            }
        }

        private string GetNewInstructionRelational(List<string> movParts, List<string> relationalParts)
        {
            return $"~\t{relationalValues[relationalParts[0]]} {relationalParts[1]}, {relationalParts[3]}, {movParts[2]}";
        }

        private void CheckStoreInstruction(string[] inputCode, int index)
        {
            if (Utils.IsCertainInstruction(inputCode[index], "ST"))
            {
                if (index >= 1 && Utils.IsCertainInstruction(inputCode[index - 1], "MOV"))
                {
                    List<string> movParts = Utils.ExtractInstructionWithOperands(inputCode[index - 1]);
                    List<string> storeParts = Utils.ExtractInstructionWithOperands(inputCode[index]);

                    if ((storeParts.Count == 5 && movParts[1] == storeParts[3]) || 
                        (storeParts.Count == 4 && movParts[1] == storeParts[2]))
                    {
                        string newInstruction = GetNewInstructionStore(movParts, storeParts);
                        inputCode[index] = newInstruction;
                    }
                }
            }
        }

        private string GetNewInstructionStore(List<string> movParts, List<string> storeParts)
        {
            string hashtagNumberPattern = @"#(\d+)";
            Regex hashtagRegex = new Regex(hashtagNumberPattern);

            Match match1 = hashtagRegex.Match(movParts[2]);

            string returnInstruction = storeParts.Count == 5 ? 
                $"ST {storeParts[1]} {storeParts[2]} {storeParts[3]}" :
                $"ST {storeParts[1]} {storeParts[2]}";

            if (match1.Success &&
                int.TryParse(match1.Groups[1].Value, out int number1))
            {
                if (number1 == 0)
                {
                    returnInstruction = storeParts.Count == 5 ?
                        $"~\tST {storeParts[1]}, {storeParts[2]}, R0" :
                        $"~\tST {storeParts[1]}, R0";
                }
            }

            return returnInstruction;
        }

        private void CheckAddInstruction(string[] inputCode, int index)
        {
            if (Utils.IsCertainInstruction(inputCode[index], "ADD"))
            {
                if (index >= 1 && Utils.IsCertainInstruction(inputCode[index - 1], "MOV"))
                {
                    List<string> movParts = Utils.ExtractInstructionWithOperands(inputCode[index - 1]);
                    List<string> addParts = Utils.ExtractInstructionWithOperands(inputCode[index]);

                    if (movParts[1] == addParts[2] || movParts[1] == addParts[3])
                    {
                        string newInstruction = GetNewInstructionAdd(movParts, addParts);
                        inputCode[index] = newInstruction;
                    }
                }
            }
        }

        private string GetNewInstructionAdd(List<string> movParts, List<string> addParts)
        {
            string hashtagNumberPattern = @"#(\d+)";
            Regex hashtagRegex = new Regex(hashtagNumberPattern);

            string returnInstruction;
            returnInstruction = $"~\tADD {addParts[1]}, {movParts[2]}, {addParts[3]}";

            Match match1 = hashtagRegex.Match(movParts[2]);
            Match match2 = hashtagRegex.Match(addParts[3]);

            if (match1.Success && match2.Success &&
                int.TryParse(match1.Groups[1].Value, out int number1) &&
                int.TryParse(match2.Groups[1].Value, out int number2))
            {
                returnInstruction = $"~\tMOV {addParts[1]}, #{number1 + number2}";
            }

            return returnInstruction;
        }

        private bool IsRelationalInstruction(string instruction)
        {
            string[] relationalInstructionsName = new string[] { "GT", "LTE", "LT", "GTE" };
            foreach (var relationalInstruction in relationalInstructionsName)
            {
                if(instruction.Trim().StartsWith(relationalInstruction, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            
            return false;
        }
    }
}
