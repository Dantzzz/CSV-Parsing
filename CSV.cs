using System;
using System.Collections.Generic;
using System.Text;

namespace CSVParsing
{
    class CSV
    {
        public static List<String> getCSV(string input)
        {
            List<string> output = new List<string>();
            string temp = "";

            for (int i = 0; i < input.Length; i++)
            {

                if (input[i] == '\"')
                {
                    i++;
                    while (input[i] != '\"')
                    {
                        temp += input[i];
                        i++;
                    }
                }

                if (input[i] != '\"' && input[i] != ',')
                {
                    temp += input[i];
                }

                if (input[i] == ',' || input[i] == '\n' || i == input.Length - 1)
                {
                    output.Add(temp);
                    temp = "";
                }
            }
            return output;
        }
    }
}
//Reference code respository: https://github.com/Makairo/CSVParsing
