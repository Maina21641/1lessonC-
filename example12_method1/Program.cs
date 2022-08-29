// Вид 1
// void method1()
// {
//     Console.WriteLine("Автор ...");
// }
// method1();

// Вид 2
// void method2(string msg) // какое то количество аргументов
// {
//     Console.WriteLine(msg);
// }
// method2("Текст выводимого сообщения");

// пример с двумя аргументами
// void method21(string msg, int count) 
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i ++;
//     }
// }
// method21("Текст", 4);
// method21(count: 4, msg: "Текст"); // это пример с именнованными аргументами, которые можно использовать не по порядку

// Вид 3 (если метод возвращает, указываем тип данных)

// int method3()
// {
//     return DateTime.Now.Year;
// }
// int year = method3(); // сюда положен результат работы метода
// Console.WriteLine(year); // здесь мы его выводим на экран

// Вид 4 (методы, которые что-то принимают и что-то возвращают)

// string method4(int count, string text)
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
// string res = method4(10, "z");
// Console.WriteLine(res);

// Пример с циклом for
// string method5(int count, string text)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = method5(10, "z");
// Console.WriteLine(res);

// Цикл в цикле на примере таблицы умножения

for (int i = 2; i <= 10; i ++)
{
    for (int j = 2; j <=10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}