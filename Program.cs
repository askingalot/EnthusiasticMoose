using System;

namespace EnthusiasticMoose
{
    class Program
    {
        static void Main(string[] args)
        {
            MooseSays("H I, I'M  E N T H U S I A S T I C !");

            EnthusiasticQuestion();
            LoveCSharpQuestion();
            SecretQuestion();

        }

        static void Question(string question, string yesAnsser, string noAnswer)
        {
            bool isYes = AskYesOrNo(question);
            if (isYes)
            {
                MooseSays(yesAnsser);
            }
            else
            {
                MooseSays(noAnswer);
            }
        }

        static void EnthusiasticQuestion()
        {
            bool isEnthusiastic = AskYesOrNo("Are you enthusiastic?");
            if (isEnthusiastic)
            {
                MooseSays("Yay!");
            }
            else
            {
                MooseSays("You should try it!");
            }
        }

        static void LoveCSharpQuestion()
        {
            bool doesLoveCSharp = AskYesOrNo("Do you love C# yet?");
            if (doesLoveCSharp)
            {
                MooseSays("Good job sucking up to your instructor!");
            }
            else
            {
                MooseSays("You will...oh, yes, you will...");
            }
        }

        static void SecretQuestion()
        {
            bool isEverythingFine = AskYesOrNo("Do you want to know a secret?");
            if (isEverythingFine)
            {
                MooseSays("ME TOO!!!! I love secrets...tell me one!");
            }
            else
            {
                MooseSays("Oh, no...secrets are the best, I lvoe to share them!");
            }
        }

        static bool AskYesOrNo(string question)
        {
            Console.Write($"{question} (Y/N): ");
            string answer = Console.ReadLine().ToLower();

            while (answer != "y" && answer != "n")
            {
                Console.Write($"{question} (Y/N): ");
                answer = Console.ReadLine().ToLower();
            }

            if (answer == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void MooseSays(string message)
        {
            Console.WriteLine($@"
                                      _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \  
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |  
                      |  .-. .-.  |   
                      \ / o| |o \ /   
                       |   / \   |    {message} 
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
            ");
        }
    }
}