using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Scheduller.Logic
{
    internal class ImmediateMergingTransform : ITransform
    {
        public string[] Transform(string[] inputCode)
        {
            string hashtagNumberPattern = @"#(\d+)";
            Regex hashtagRegex = new Regex(hashtagNumberPattern);

            for (int i = 0; i < inputCode.Length; i++)
            {
                if (i + 1 < inputCode.Length)
                {
                    List<string> instrParts = Utils.ExtractInstructionWithOperands(inputCode[i]);
                    List<string> nextInstrParts = Utils.ExtractInstructionWithOperands(inputCode[i + 1]);

                    Match match1 = null;
                    Match match2 = null;

                    if (instrParts.Count > 3 && nextInstrParts.Count > 3)
                    {
                        match1 = hashtagRegex.Match(instrParts[3]);
                        match2 = hashtagRegex.Match(nextInstrParts[3]);
                    }

                    if (match1 != null && match2 != null &&
                        match1.Success && match2.Success &&
                        int.TryParse(match1.Groups[1].Value, out int number1) &&
                        int.TryParse(match2.Groups[1].Value, out int number2))
                    {
                        
                        int result = 0;
                        bool inList = false;

                        if (instrParts[0] == "SUB" && nextInstrParts[0] == "ADD")
                        {
                            result = number2 - number1;
                            inList = true;
                        }

                        if (instrParts[0] == "ADD" && nextInstrParts[0] == "SUB")
                        { 
                            result = number1 - number2;
                            inList = true;
                        }

                        if (inList)
                        {
                            inputCode[i + 1] = $"~~\t{nextInstrParts[0]} {nextInstrParts[1]}, {instrParts[2]}, #{result}";
                        }
                    }
                }
            }

            return inputCode;
        }
    }

}
