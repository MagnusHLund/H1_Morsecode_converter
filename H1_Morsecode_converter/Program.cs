namespace H1_Morsecode_converter
{
    internal class Program
    {
        // A better solution than the one i made, would be to use a dictionary, however the assignment said use a switch.

        static void Main()
        {
            // infinite loop
            while (true)
            {
                // Outputs "Write a sentence" in the console
                Console.WriteLine("Write a sentence");

                // Creates a char array which becomes user input. A list is also created, which will hold the morse code 
                char[] chars = Console.ReadLine().ToCharArray();
                List<string> list = new List<string>();

                // Runs a foreach, which takes in the char array, as its collection
                foreach (char c in chars)
                {
                    // Converts the char to lowercase and puts it in the "value" char
                    char value = char.ToLower(c);

                    // Runs a switch, which takes in the expression of the "value" variable
                    switch (value)
                    {
                        // Adds the appropriate morse code to the list
                        case 'a':
                            list.Add(".-");
                            break;
                        case 'b':
                            list.Add("-...");
                            break;
                        case 'c':
                            list.Add("-.-.");
                            break;
                        case 'd':
                            list.Add("-..");
                            break;
                        case 'e':
                            list.Add(".");
                            break;
                        case 'f':
                            list.Add("..-.");
                            break;
                        case 'g': 
                            list.Add("--.");
                            break;
                        case 'h':
                            list.Add("....");
                            break;
                        case 'i':
                            list.Add("..");
                            break;
                        case 'j':
                            list.Add(".---");
                            break;
                        case 'k':
                            list.Add("-.-");
                            break;
                        case 'l':
                            list.Add(".-..");
                            break;
                        case 'n':
                            list.Add("-.");
                            break;
                        case 'm':
                            list.Add("--");
                            break;
                        case 'o':
                            list.Add("---");
                            break;
                        case 'p':
                            list.Add(".--.");
                            break;
                        case 'q':
                            list.Add("--.-");
                            break;
                        case 'r':
                            list.Add(".-.");
                            break;
                        case 's':
                            list.Add("...");
                            break;
                        case 't':
                            list.Add("-");
                            break;
                        case 'u':
                            list.Add("..-");
                            break;
                        case 'v':
                            list.Add("...-");
                            break;
                        case 'w':
                            list.Add(".--");
                            break;
                        case 'x':
                            list.Add("-..-");
                            break;
                        case 'y':
                            list.Add("-.--");
                            break;
                        case 'z':
                            list.Add("--..");
                            break;
                        case '1':
                            list.Add(".----");
                            break;
                        case '2':
                            list.Add("..---");
                            break;
                        case '3':
                            list.Add("...--");
                            break;
                        case '4':
                            list.Add("....-");
                            break;
                        case '5':
                            list.Add(".....");
                            break;
                        case '6':
                            list.Add("-....");
                            break;
                        case '7':
                            list.Add("--...");
                            break;
                        case '8':
                            list.Add("---..");
                            break;
                        case '9':
                            list.Add("----.");
                            break;
                        case '0':
                            list.Add("-----");
                            break;
                        default:
                            list.Add(" ");
                            break;
                    }
                }

                // Takes the content of the list and puts it into a new string called "output" and outputs it in the console
                string output = string.Join(" ", list);
                Console.WriteLine(output);
            }
        }
    }
}