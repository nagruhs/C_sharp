// //метод 1 - ничего не принимает и не возвращает
// void Method1()
// {
//     Console.WriteLine("Автор");
// }

// Method1();

// //***************************************

// // метод 2 - принимает и не возвращает
// void Method2(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }

// Method2(msg:"автор",count: 4);// - можно указывать явно какому аргументу даем значение 

// // ***************************************

// // метод 3 - возвращает но не принимает
// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year);

// //***************************************

// //метод 4 - возвращает и принимает
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "йцукен");
// Console.WriteLine(res);