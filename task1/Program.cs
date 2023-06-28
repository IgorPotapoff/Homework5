/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
Console.Clear();

int [] CreateArray (int size,int min,int max){

int [] array = new int [size];
Random rand = new Random();

for (int i = 0;i<size;i++){

array[i] = rand.Next(100,999);


}

return array;
}


int AmountOfPositive(int [] array){

int count = 0;

for (int i=0;i<array.Length;i++){

if (array[i]%2 == 0){

    count+=1;
}

}

return count;

}

int [] arr = CreateArray(10,100,999);

int count = AmountOfPositive(arr);
Console.WriteLine($"[{string.Join(",", arr)}]");

Console.WriteLine(count);