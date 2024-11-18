//Inloggningssystem inlämningsuppgift 1 c#
// Av Linnéa Schilström

        //skapa array för lagring av användare. int count beräknar hur många användare som skapats
        String[] userName = new string[10];
        String[] password = new string[10];
        int userCount = 0;

        while (true) { 
        Console.WriteLine("Välkommen till inloggningsystemet!");
        //Meny
        Console.WriteLine("\t1 Sign in:");
        Console.WriteLine("\t2 Log in:");
        Console.WriteLine("\t3 Exit:");
        Console.Write("Ange ditt val: ");
        string choice = Console.ReadLine(); 
        //Vänta på respons från användare
        //om användaren väljer 1 -> skapa ny användare
        if (choice == "1")
            {
                Console.WriteLine("--Skapa ny användare--");
                Console.Write("Ange användarnamn: ");
                String newUsername = Console.ReadLine();
                Console.Write("Ange lösenord: ");
                String newPassword = Console.ReadLine();

                //Lagra användarnamn/lösenord i array
                userName[userCount] = newUsername;
                password[userCount] = newPassword;
                userCount++;
                Console.WriteLine("Du har nu skapat en ny användare. Klicka på valfri knapp för att återgå till startsidan.");
                Console.ReadKey();
            }
        // val 2 -> logga in
        else if (choice == "2")
            {
                Console.WriteLine("--Logga in--");
                Console.Write("Ange användarnamn: ");
                String loginUsername = Console.ReadLine();
                Console.Write("Ange lösenord: ");
                String loginPassword = Console.ReadLine();

                //Kontroll av inloggning. matchar användarnamn/lösernord -> inloggning lyckas
                // matchar inte "inloggning misslyckades", skickas tillbaka till start
                bool loginSuccsess = false;
                for (int i = 0; i < userCount; i++)
                {
                    if (userName[i] == loginUsername && password[i] == loginPassword)
                    {
                        loginSuccsess = true;
                        break;
                    }
                }
                if (loginSuccsess)
                {
                    Console.WriteLine("Inloggning lyckades!");
                    Console.WriteLine("Programmet avlutas..");
                    Console.ReadKey();
                    break;
                }
                else 
                { Console.WriteLine("Inloggning misslyckades, testa igen.");
                  Console.ReadKey();
                }
            }
        //Om val = 3 skiver ut meddelande och programmet avslutas
        else if (choice == "3")
            {
                Console.WriteLine("Avslutar programmet..");
                break;
            }
        }