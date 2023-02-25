// Цикл for - цикл со счетчиком, когда знаем кол-во итераций
string Method4(int count, string text){
  string result = string.Empty;
  for(int i = 0; i < count; i++){ //инициальзация, проверка условия, счетчик
    result = result + text;
  }
return result;
}
string res = Method4(10, "Текст");
Console.WriteLine(res);

//Цикл в цикле на примере таблицы умножения:
for(int i = 2; i <= 10; i++){
  for(int j = 2; j <= 10; j++){ //тело внешнего цикла
    Console.WriteLine($"{i} x {j} = {i * j}"); //тело внешнего цикла
  }
  Console.WriteLine(); // переход на новую строку после одного цикла, чтоб красиво было
}