using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduller.Logic
{
    internal class MovMergingTransform : ITransform
    {
        public string[] Transform(string[] inputCode)
        {
            bool movFound = false;
            List<string> movOperands = new List<string>();
            List<string> addOperands = new List<string>();

            for (int i = 0; i < inputCode.Length; i++)
            {
                if (inputCode[i].Trim().StartsWith("ADD", StringComparison.OrdinalIgnoreCase))
                {
                    if(movFound == true)
                    {
                        addOperands = ExtractOperands(inputCode[i]);
                        if (movOperands[0] == addOperands[1] || movOperands[0] == addOperands[2])
                        {
                            Console.WriteLine("true" + " line " + i);
                        }     
                        else
                        {
                            Console.WriteLine("false");
                        }
                    }
                }

                if (inputCode[i].Trim().StartsWith("MOV", StringComparison.OrdinalIgnoreCase))
                {
                    movFound = true;
                    movOperands = ExtractOperands(inputCode[i]);
                }
                else
                {
                    movFound = false;
                }
            }

            return inputCode;
        }

        static List<string> ExtractOperands(string instruction)
        {
            string[] parts = instruction.Split();
            List<string> operands = parts.Skip(2).Select(operand => operand.TrimEnd(',')).ToList();
            return operands;
        }
    }
}
