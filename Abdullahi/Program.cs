using System.ComponentModel.Design;

namespace Abdullahi
{

    class Program
    {
        //Main - metoden här börjar mitt program
        static void Main()
        {
            // Initierar en lista för att hålla Person-objekt

            List<Person> peopleList = new List<Person>();
            bool continueProgram = true;

            // loop som visar meny och hanterar användarens input
            while (continueProgram)
            {
                Console.WriteLine("\nVälj ett alternativ:");
                Console.WriteLine("1. Lägga till person");
                Console.WriteLine("2. Skriva ut lista med alla tillagda personer");
                Console.WriteLine("3. Avsluta programmet");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Felaktig inmatning. Vänligen ange en siffra för ditt val.");
                    continue;
                }

                switch (choice)
                {
                    // Switch-case för att utföra åtgärder baserat på användarens val
                    case 1:
                        AddPerson(peopleList);
                        break;
                    case 2:
                        ListPersons(peopleList);
                        break;
                    case 3:
                        continueProgram = false;
                        break;
                    default:
                        Console.WriteLine("Ogiltigt val. Vänligen välj ett giltigt alternativ.");
                        break;
                }
            }
        }
        // Metod för att lägga till en ny person i listan
        static void AddPerson(List<Person> list)
        {
            Console.WriteLine("Lägg till en ny person:");
            string name;
            Gender gender;
            DateTime birthday;
            int hairLength;
            string hairColor, eyeColor;

            Console.Write("Vad är namnet på person: ");
            name = Console.ReadLine();

            // Loop för att säkerställa korrekt inmatning för kön
            do
            {
                Console.Write("Ange personens kön ( Man, Kvinna, Annat): ");
                string personGender = Console.ReadLine();

                if (personGender == "Man" || personGender.ToLower() == "Man")
                {
                    gender = Gender.Man;
                    break;

                }

                else if (personGender == "Kvinna" || personGender.ToLower() == "Kvinna")
                {
                    gender = Gender.Kvinna;
                    break;

                }

                else if (personGender == "Annat" || personGender.ToLower() == "Annat")
                {
                    gender = Gender.Annat;
                    break;

                }

                else 
                { 
                    Console.WriteLine("Felaktig inmatning av kön ange enligt formatet");
                
                }

            } while (true);

            // Loop för att säkerställa korrekt inmatning för födelsedatum
            while (true)
            {
                Console.Write("Ange personens födelsedatum ÅÅÅÅ-MM-DD: ");
                if (DateTime.TryParse(Console.ReadLine(), out birthday))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ogiltigt datumformat. Ange datum i ÅÅÅÅ-MM-DD format.");
                }
            }

            // Loop för att säkerställa korrekt inmatning för hårlängd
            while (true)
            {
                Console.Write("Ange personens hårlängd (i cm): ");
                if (int.TryParse(Console.ReadLine(), out hairLength))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ogiltig hårlängd. Ange ett numeriskt värde.");
                }
            }



            Console.Write("Ange personens hårfärg: ");
            hairColor = Console.ReadLine();


            Console.Write("Ange personens ögonfärg: ");
            eyeColor = Console.ReadLine();

            Hair hairInfo = new Hair { Length = hairLength, Color = hairColor, EyeColor = eyeColor };
            Person newPerson = new Person(name, gender, birthday, hairInfo, eyeColor);

            list.Add(newPerson);
            Console.WriteLine("Person tillagd!");
        }

        // Metod för att lista alla personer i den angivna listan
        static void ListPersons(List<Person> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("Det finns inga personer i listan.");
            }
            else
            {
                Console.WriteLine("Listan med tillagda personer:");
                foreach (var person in list)
                {
                    Console.WriteLine(person.ToString());
                }
            }
        }
    }
}