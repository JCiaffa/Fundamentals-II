//1Print All
// static void PrintNumbers(int count)
// {
//     for (int i = 1; i < count; i++){
//         Console.WriteLine(i);
//     }
// }
// PrintNumbers(256);

//2 Print odds
// static void PrintOdds(int count)
// {
//     for (int i = 1; i < count; i++){
//         if(i%2 != 0){
//             Console.WriteLine(i);
//         }
//     }
// }
// PrintOdds(256);

//3 Print Sum
// static int PrintSum(int count)
// {   int sum = 0;
//     for (int i = 1; i <= count; i++){
//         sum += i;
//         Console.WriteLine("Count is:" + i + " Sum is: " + sum);
//     }
//     return sum;
// }
// PrintSum(255);

//4 Iterate Array
// int[] array = {1,2,3,4,6};

// static void LoopArray(int[] numbers)
// {
//     foreach(var num in numbers){
//         Console.WriteLine(num);
//     }
// }
// LoopArray(array);

//5 Find Max
// static int FindMax(int[] numbers)
// {   int max = numbers[0];
//     for (int i = 1; i < numbers.Length; i++){
//         if(max < numbers[i]){
//             max = numbers[i];
//         }
//     }
//     Console.WriteLine(max);
//     return max;
// }

// Console.WriteLine(FindMax(array));
// FindMax(array);

//6 Get Average
// static int FindAve(int[] numbers)
// {   int count = 0;
//     for (int i = 1; i < numbers.Length; i++)
//     {
//         count += numbers[i];
//     }
//         count = count / numbers.Length;
//         Console.WriteLine(count);
//         return count;
//     }

// FindAve(array);

//7 List of Odds 1-255
// static List<int> ListOdds(int count)
// {   List<int> odds = new List<int>();
//     for (int i = 1; i < count; i++){
//         if(i%2 != 0){
//             odds.Add(i);
//         }
//     }
//     return odds;
// }
// ListOdds(256);

//8 Greater Than Y
// List<int> numbersList= new List<int>{1,2,3,4,5,6,7,8,9,10};

// static int GreaterThanY(List<int> numbers, int y)
// {   int count = 0;
//     foreach(var i in numbers)
//     {
//         if(i > y){
//             count += 1;
//         }
//     }
//     Console.WriteLine(count);
//     return count;
// }
// GreaterThanY(numbersList, 6);

//9 Square the Values
// static void SquareArrayValues(List<int> numbers)
// {   
//     foreach(var i in numbers){
//         Console.WriteLine(i*i);
//     }
// }
// SquareArrayValues(numbersList);

//10 Remove Negatives

// List<int> negativeList= new List<int>{-1,2,-3,4,-5,6,-7,8,-9,10};

// static void EliminateNegatives(List<int> numbers)
// {
//     for(int i = 0; i < numbers.Count; i++){
//         if(numbers[i] < 0){
//             numbers[i] = 0;
//         }
//         Console.WriteLine(numbers[i]);
//     }
// }
// EliminateNegatives(negativeList);