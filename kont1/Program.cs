
// Написать программу, которая из имеющегося массива строк , формирует массив из строк , длина которых меньше или равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо  задать на старте выполнения алгоритма . 

string[] array= { "hello" , "12365" , "cat" , "dog" , " 5689" , "56"}; 
string[] arrayNew = new string[array.Length]; // новый иассив строк 
int i ;
int n=3;
int j=0;
for( i=0 ; i<array.Length ; i++)
  {
    if ( array[i].Length<= n )
      {
        arrayNew[j]= array[i];
      }
      else
        {
          j++;
        }
}

Console.WriteLine("array[{0}] = {1}", i, array[i]);

    
