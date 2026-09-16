using Tyuiu.KaraschukNE.Sprint0.Task6.Lib;
// See https://aka.ms/new-console-template for more information
int[] numArrey = new int[] { 1, 2, 3, 4, 5 };
Console.WriteLine("Сумма элементов массива = " + DataService.AdditionArray(numArrey));
Console.WriteLine("Разность элемента массива = " + DataService.SubtractionArray(numArrey));
Console.WriteLine("Произведение элементов массива = " + DataService.MultiplicationArray(numArrey));

Console.ReadKey();
