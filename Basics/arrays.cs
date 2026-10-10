// Declartion and Assigmention

// string [] friends = new string[3];
// friends[0] = "Alice";
// friends[1] = "Bob";
// friends[2] = "Charlie";
// Console.WriteLine("My friends are:");
// for (int i = 0; i < friends.Length; i++)
// {
//     Console.WriteLine(friends[i]);
// }






// Initialization 1

// int [] nums = new int[5] {1, 2, 3, 4, 5};

// Initialization 2

// int [] nums = new int[] {1, 2, 3, 4, 5};

// Initialization 3

// var nums = new int[] {1, 2, 3, 4, 5};

// Initialization 4

// int [] nums = {1, 2, 3, 4, 5};

// Initialization 5
// var nums = {1, 2, 3, 4, 5}; // Error: Cannot use 'var' with array initializer without an explicit type " new int[] "

// Console.WriteLine("The numbers are:");
// for (int i = 0; i < nums.Length; i++)
// {
//     Console.WriteLine(nums[i]);
// }

// 1D
// int[] arr;

// 2D Rectangular
// int[,] arr;

// 3D Rectangular
// int[,,] arr;

// Jagged 2D
// int[][] arr;

// Jagged 3D
// int[][][] arr;

// MUlti-Dimensional Array
// int[,] numbers =
// {
//     { 1, 2, 3 },
//     { 4, 5, 6 }
// };

// Console.WriteLine(numbers[0, 0]);
// Console.WriteLine(numbers[1, 2]);

// // Jagged Array
// int[][] numbers2 =
// {
//     new int[] { 1, 2, 3 },
//     new int[] { 4, 5 },
//     new int[] { 6, 7, 8, 9 }
// };

// Console.WriteLine(numbers2[0][0]);
// Console.WriteLine(numbers2[1][1]);
// Console.WriteLine(numbers2[2][3]);



// Indcies & Ranges

// string [] friends = new string[] { "Alice", "Bob", "Charlie", "David", "Eve" };
var friends = new string[] { "Alice", "Bob", "Charlie", "David", "Eve" };
var first = friends[0]; // "Alice"
var last = friends[^1]; // "Eve"
Console.WriteLine($"First friend: {first}");
Console.WriteLine($"Last friend: {last}");
var slice1 = friends[..2]; // "Alice", "Bob" ==> first two elements, element at index 2 is excluded, type of slice1 is string[] array
var slice2 = friends[2..]; // "Charlie", "David", "Eve" ==> from index 2 to the end, element at index 2 is included, type of slice2 is string[] array
var slice3 = friends[1..4]; // "Bob", "Charlie", "David" ==> from index 1 to index 4, element at index 4 is excluded, type of slice3 is string[] array

// slices with "^"  ^ is used to count from the end of the array, the index is exclusive and you start counting from the end of the array, so ^1 is the last element, ^2 is the second to last element, and so on

var slice4 = friends[^3..^1]; // "Charlie", "David" ==> from index ^3 to index ^1, element at index ^1 is excluded, type of slice4 is string[] array
var slice5 = friends[^2..]; // "David", "Eve" ==> from index ^2 to the end, element at index ^2 is included, type of slice5 is string[] array
var slice6 = friends[2..^2]; // "Charlie" ==> from index 2 to index ^2, element at index ^2 is excluded, type of slice6 is string[] array



