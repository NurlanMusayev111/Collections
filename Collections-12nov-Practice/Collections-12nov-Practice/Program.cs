

using Collections_12nov_Practice.Controllers;
using System.Collections;

//AuthorControlles authorControlles = new AuthorControlles();
//EmployeeControllers employeeControllers = new EmployeeControllers();

//authorControlles.GetAuthorByAge();

//employeeControllers.GetFilter();


//AccountController accountController = new AccountController();
//ProductController productController = new ProductController();

//var res = accountController.Login();

//if (res)
//{
//    while (true)
//    {
//        Console.WriteLine("Select option : 1 - GetAll products , 2 - Search product by name");
//    Option: string option = Console.ReadLine();

//        int resOption;

//        bool isCorrectFormatOption = int.TryParse(option, out resOption);

//        if (isCorrectFormatOption)
//        {
//            switch (resOption)
//            {
//                case 1:
//                    productController.GetAll();
//                    break;
//                case 2:
//                    productController.Search();
//                    break;
//                default:
//                    Console.WriteLine("Cannot find this option...");
//                    goto Option;

//            }
//        }
//        else
//        {
//            Console.WriteLine("Option format is wrong");
//            goto Option;
//        }
//    }

//}



//ArrayList arrayList = new ArrayList();

//arrayList.Add("Nurlan");
//arrayList.Add(922);
//arrayList.Add(true);

//foreach (var item in arrayList)
//{
//    Console.WriteLine(item);
//}



//Hashtable hashtable = new Hashtable();

//hashtable.Add(1, "Salam");
//hashtable.Add(2, "Sagol");

//foreach (DictionaryEntry hash in hashtable)
//{
//    Console.WriteLine(hash.Key + " " + hash.Value);
//}


//SortedList<int, string> datas = new();

//datas.Add(1, "Salam");
//datas.Add(2, "Sagol");

//foreach (KeyValuePair<int,string> data in datas)
//{
//    Console.WriteLine(data);
//}


Dictionary<int, string> datas = new();

datas.Add(1, "Admin");
datas.Add(2, "Member");

foreach(KeyValuePair<int,string>)