﻿/* 
Дан текст. В тексте нужно все пробелы заменить черточками,
маленькие буквы “к” заменить большими “К”, а большие “С” заменить
маленькими “с”.
*/

string text = " — Я думаю, — сказал князь, улыбаясь, — что,"
+ " ежели бы вас послали вместо нашего милого "
+ "Винценгероде, вы бы взяли приступом согласие "
+ "прусского короля. Вы так красноречивы. Вы дадите мне чаю? ";

string Replace(string text, char oldV, char newV) // oldV- тот символ, который меняем, newV- символ нак который меняем
{
    string result = String.Empty; // заводим новую строку и делаем ёё пустой (инициализация пустой строки)

    int length = text.Length; // для того что бы получить длинну нашей строки. сделать это можно обращением к свойству показывающем количество символов в строке 
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldV) result = result + $"{newV}"; // если наш текущий символ текст итое совпал с тем символом , который мы хотим заменить то в результат мы деолжны будем положить новое значение этой строки 
        else result = result + $"{text[i]}";// если совпадений не обнаружено тот в наш резали надо добавить текущий символ , который и был
    }
    return result;
}
string newText = Replace(text, ' ', '*');// запускаем стринг ньютекст присвоить реплейс текс и указываем, что на что меняем пробелы замеяем на * 
Console.WriteLine(newText);
// текст, который мы получили можем теперь обрабатывать
Console.WriteLine();
newText = Replace(newText, 'к', 'К');// теперь мы в качестве аргументов мы передаём наш обработанный текст, то что надо заменить, те символы, которые заменяем. 
Console.WriteLine(newText);
newText = Replace(newText, 'с', 'S');
Console.WriteLine(newText);