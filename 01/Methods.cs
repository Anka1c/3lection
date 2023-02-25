// Вид 1: Не принимает аргументы, ничего не возвращает
void Method1(){    //ключевое слово VIOD, в скобках нет никаких аргументов
  Console.WriteLine("Автор Анечка");   //В теле метода что-то показывать на экран. Хотим указывать атвороство в конце кода
}
Method1(); // Вызов метода, обязательно со скобками

// Вид 2: Принимает аргумент, ничего не возвращает
void Method2 (string msg){ //VOID, идентификатор Method2, в скобках аргумент
  Console.WriteLine(msg);
}
Method2("Текст сообщения"); // вызов метода и текст выводимый в консоли

// Вид 2.1:именованные аргументы. Если больше одного аргумента
void Method21(string msg, int count){
  int i = 0;
  while (i < count){
    Console.WriteLine(msg);
    i++;
  }
}
Method21("Текст", 4) //вызов. Слово "Текст" будет написано 4 раза
Method21(count: 4, msg: "Текст") //2 способ вызоваю Можно в разном порядке,но именовано

// Вид 3: Ничего не принимают, что-то возвращают
int Method3();{   // без аргументов
  return DateTime.Now.Year; //обязательно return
} 
int Year = Method3; //вызов метода
Console.WriteLine(Year);


// Вид 4: что-что принимает, что-то возвращает
string Method4(int count, string text){ //передаем int count & string text, возвращаем строку
  int i = 0;
  string result = string.Empty; //изначально пусть будет пустая строка
    while(i < count){
      result = result + text;
      i++;
    }
    return result; //обязательно return
}
string res = Method4(10, "Текст"); //вызов. Слово Текст друг за другом 10 раз
Console.WriteLine(res);