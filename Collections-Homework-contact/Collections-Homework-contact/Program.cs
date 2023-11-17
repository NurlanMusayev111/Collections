
using Collections_Homework_contact;

List<Person> persons = new();


string option;


do
{
    Console.WriteLine("1 - Kontakda nomre elave et:");
    Console.WriteLine("2- kontaktdaki nomreleri goster :");
    Console.WriteLine("3 - Kontaktdaki nomreni sil:");
    Console.WriteLine("4 - Kontakda axtaris etmek:");
    Console.WriteLine("5 - Kontakti elifba sirasi ile sirala:");
    Console.WriteLine("6 - telefon nomresini guncelle :");

    Option: option = Console.ReadLine();

    int oneOption;

    bool isTrueOption = int.TryParse(option, out oneOption);

    if (!isTrueOption)
    {
        Console.WriteLine("Cannot search this option...");
        goto Option;
    }
 

    switch (option)
    {
        case "1":
            Console.WriteLine("Please add name");
            string name = Console.ReadLine().Trim().ToLower();

            Console.WriteLine("Please add surname");
            string surname = Console.ReadLine().Trim().ToLower();

            Console.WriteLine("Add phone number :");
            Number: string number = Console.ReadLine();

            int num;

            bool isTrueNumber = int.TryParse(number, out num);

            if (!isTrueNumber)
            {
                Console.WriteLine("Please enter correct format...");
                goto Number;
            }
          

            Person person = new()
            {
                Name = name,
                Surname = surname,
                Phone = num,
            };

            persons.Add(person);
            break;



        case "2":
            foreach (var item in persons)
            {
                Console.WriteLine($"{item.Name} - {item.Surname} - {item.Phone}");
            }
            break;
        default:
            Console.WriteLine("Secim dugun deyil");
            break;


        case "3":
            Console.WriteLine("Please select delete number name:");
            string delName = Console.ReadLine().Trim().ToLower();

            Console.WriteLine("Please select delete number surname:");
            string delSurname = Console.ReadLine().Trim().ToLower();


            foreach (var item in persons)
            {
                if(delName == item.Name && delSurname == item.Surname)
                {
                    persons.Remove(item);
                    break;
                }
                else
                {
                    Console.WriteLine("1:Attemp again");
                    Console.WriteLine("2:End deleting process");

                    string select = Console.ReadLine();

                    switch (select)
                    {
                        case "1":
                            break;

                        case "2":

                            break;
                            


                    }
                }
            }

            break;


        case "4":

            Console.WriteLine("1 - Ada gore axtarmaq");
            Console.WriteLine("2 - Nomreye gore axtarmaq");
            string optionSearch = Console.ReadLine(); 
            switch (optionSearch)
            {

                case "1":
                    Console.WriteLine("Daxil edin :");
                    string searchText = Console.ReadLine().ToLower().Trim();
                    foreach (var item in persons)
                    {
                        if(item.Name.Contains(searchText) || item.Surname.Contains(searchText))
                        {
                            Console.WriteLine($"{item.Name} - {item.Surname}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Netice tapilmadi...");
                            
                        }
                        
                    }
                    break;
                case "2":
                    Console.WriteLine("Nomreni daxil edin");
                    string searchNum = Console.ReadLine();

                    foreach (var item in persons)
                    {
                        if (item.Phone.ToString().Contains(searchNum))
                        {
                            Console.WriteLine($"{item.Name} - {item.Surname} - {item.Phone}");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Netice tapilmadi...");
                            
                        }
                    }


                    break;

               
            }
            break;


        case "5":
            Console.WriteLine("1 - A-Z siralamaq :");
            Console.WriteLine("2 - Z-A siralamaq :");
            SortElem: string sort = Console.ReadLine();

            int intSort;

            bool isTrueSort = int.TryParse(sort, out intSort);

            if (!isTrueSort)
            {
                Console.WriteLine("No sorting...");
                goto SortElem;
            }
            else
            {
                switch (sort)
                {
                    case "1":

                        var orderElem = persons.OrderBy(x => x.Name);
                        foreach (var elem in orderElem)
                        {
                            Console.WriteLine($"{elem.Name} - {elem.Surname}");

                        }
                        break;

                    case "2":
                        var orderByElem = persons.OrderByDescending(x => x.Name);
                        foreach (var elem in orderByElem)
                        {
                            Console.WriteLine($"{elem.Name} - {elem.Surname}");
                        }
                        break;

                    
                }
            }

            break;



    }

} while (option != null);


