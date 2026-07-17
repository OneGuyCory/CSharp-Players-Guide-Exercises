/* Combined all parts of Enclave to one project
 Objectives
    * Read Line of text from user
    * create bool variable
    * display contents
    * create int variable to hold secret number
    * use if statement to check if first char is '#'
    * display secret number at end
    * create str variable to hold passphrase
    * add 'dah' to passphrase if user text starts with '#'
    * display passphrase and secret number
 * */

Console.Write("Input a 3 character string: ");
string userText = Console.ReadLine();
bool isThree = userText.Length == 3;
int secretNumber = 0;
string input1 = "";
string input2 = "";
string input3 = "";
string passphrase = input1 + input2 + input3;

if      (userText[0] == '#') { secretNumber += 4; input1 = "dah"; } 
else if (userText[0] == 'o') { secretNumber -= 3; input1 = "fus"; } 
else if (userText[0] == '^') { secretNumber -= 2; input1 = "ro";  } 
else                         { secretNumber += 1; input1 = "bex"; }

if      (userText[1] == '#') { secretNumber += 4; input2 = "dah"; }
else if (userText[1] == 'o') { secretNumber -= 3; input2 = "fus"; }
else if (userText[1] == '^') { secretNumber -= 2; input2 = "ro";  }
else                         { secretNumber += 1; input2 = "bex"; }

if      (userText[2] == '#') { secretNumber += 4; input3 = "dah"; }
else if (userText[2] == 'o') { secretNumber -= 3; input3 = "fus"; }
else if (userText[2] == '^') { secretNumber -= 2; input3 = "ro";  }
else                         { secretNumber += 1; input3 = "bex"; }

Console.WriteLine(secretNumber + " " + input1 + input2 + input3);