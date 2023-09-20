//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

int N = 0;
Console.WriteLine("Введите числа через пробел");
string[] num = Console.ReadLine().Split(' ');
int M = num.Length;
int[] A = new int[M];
              
for (int i = 0; i < M; i++) 
{
    A[i] = int.Parse(num[i]);
    if (A[i] > 0) {
        N++;
        }
}            
        
Console.WriteLine("Количество чисел больше 0: " + N);
              
              

           