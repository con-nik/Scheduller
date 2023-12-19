using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Scheduller.Logic
{
    internal class MovReabsorptionTransform : ITransform
    {
        public string[] Transform(string[] inputCode)
        {
            for (int i = 0; i < inputCode.Length; i++)
            {
                if (i >= 1 && Utils.IsCertainInstruction(inputCode[i], "MOV"))
                {
                    List<string> movParts = Utils.ExtractInstructionWithOperands(inputCode[i]);
                    List<string> beforeInstrParts = Utils.ExtractInstructionWithOperands(inputCode[i-1]);

                    if (beforeInstrParts.Count > 1 && movParts[2] == beforeInstrParts[1])
                    {
                        inputCode[i] = "~~~" + inputCode[i - 1];
                    }
                }
            }

            return inputCode;
        }
    }
}
