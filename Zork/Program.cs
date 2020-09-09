//=======Hanniee Tran========//
//===DIG4778 Tool + Plugin===//

using System; //use this so u dont have to type system. over n over

namespace Zork
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");

            string inputString = Console.ReadLine(); //ReadLine take no arguements and return player's input as string (literally rewrite the command we input
            inputString = inputString.ToUpper(); // this line make sure the string case-sensitive are the same(so u can use look instead of typing LOOK) 
            //('ToUpper' transformed all case to CAP and 'ToLower' do oppisite)
            if (inputString == "QUIT")
            {
                Console.WriteLine("Thank you for playing.");
            }
            else if (inputString == "LOOK")
            {
                Console.WriteLine("This is an open field west of white house, with a boarded front door.\nA rubber mat saying 'Welcome to Zork!' lies by the door."); // \n is to skip a line
            }
            else
            {
                Console.WriteLine("Unrecognized command.");
            } 
        }
    }
}
