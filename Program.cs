using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_3_and_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int initial_input = int.Parse(input);

            string final_output = "";

            for (int i = 1; i < initial_input + 1; i++) //Lil' counter  for the intial input
            {
                string variable_string = Console.ReadLine();
                int variable_number = int.Parse(variable_string);

                List<int> residues = new List<int>(); //List for the residues
                List<int> residues_Inverted = new List<int>(); //List to invert the residues

                if (variable_number != 0) //Validation to continue
                {
                    while (variable_number != 0)
                    {
                        int r = variable_number % (-2); //This line is to save the residues
                        if (r < 0)
                        {
                            r = r * -1;
                            if (variable_number < 0)
                            {
                                variable_number -= 1; //This is equivalent to (variable_number = variable_number - 1)
                            }
                            if (variable_number > 0)
                            {
                                variable_number += 1; //This is equivalent to (variable_number = variable_number + 1)
                            }
                        }

                        residues.Add(r);
                        variable_number = variable_number / (-2); //This is the operation needed to convert the number to base -2

                    }

                    for (int g = residues.Count - 1; g >= 0; g--) //This weird looking method here inverts the list of residues to get the desired number 
                    {
                        residues_Inverted.Add(residues[g]);
                    }

                    string final_number = string.Join("", residues_Inverted.ToArray()); //The Join command combines many strings into one

                    final_output += "Case #" + i + ": " + final_number + "\n";

                }
                else
                {
                    final_output += "Case #" + i + ": 0" + "\n"; //Validation if the number is impossible to reach
                }
            }
            Console.WriteLine(final_output); //Final print
        }
    }
}
