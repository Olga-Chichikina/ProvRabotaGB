
// Написать программу, которая из имеющегося массива строк , формирует массив из строк , длина которых меньше или равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо  задать на старте выполнения алгоритма . 

string[] array= { "hello" , "12365" , "cat" , "dog" , " 5689" , "56"}; 
Console.WriteLine("Исходный массив :hello , 12365 , cat , dog ,  5689 , 56");
Console.WriteLine("Новый массив строк , длина которых меньше или равна 3 символа :");
string[] arrayNew = new string[array.Length]; // новый иассив строк 
int i ;
int n=3;
int j=0;
for( i=0 ; i<array.Length ; i++)
  {
    if ( array[i].Length<= n )
      {
        arrayNew[j]= array[i];
        Console.WriteLine(arrayNew[j]);
      }
       else
        {
          j++;
        }
}



    
