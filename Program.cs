// Console.Write("Сколько студентов в группе? ");
// int studentsCount = int.Parse(Console.ReadLine());
// int[] grades = new int[studentsCount];
// int sum = 0;

// for (int i = 0; i < grades.Length; i++) {
//     Console.Write($"Оценка студента {i + 1}: ");
//     grades[i] = int.Parse(Console.ReadLine());
//     sum += grades[i];
// }

// foreach (int grade in grades) {
//     Console.WriteLine(grade);
// }

// Console.WriteLine($"Средний балл: {(double)sum / studentsCount}");

// int[] points = { 8, 7, 2, 10, 5 };
// for (int i = 0; i < points.Length; i++)
// {
//     if (points[i] < 10)
//     {
//         points[i] = points[i] + 1;
//     }
// }
// foreach (int point in points)
// {
//     Console.WriteLine(point);
// }

// int[] grades = { 4, 5, 3, 5, 4, 2 };
// for (int i = 0; i < grades.Length - 1; i++)
// {
//     for (int j = 0; j < grades.Length - 1 - i; j++)
//     {
//         if (grades[j] < grades[j + 1])
//         {
//             int temp = grades[j];
//             grades[j] = grades[j + 1];
//             grades[j + 1] = temp;
//         }
//     }
// }
// foreach (int grade in grades)
// {
//     Console.WriteLine(grade);
// }

// int[] GenerateEvenSlots(int lessonsCount) {
//     int[] slots = new int[lessonsCount];
//     for (int i = 0; i < lessonsCount; i++) {
//         slots[i] = (i + 1) * 2;
//     }
//     return slots;
// }

// int[] slots = GenerateEvenSlots(6);
// foreach (int slot in slots) {
//     Console.WriteLine(slot);
// }

// int[] grades = { 4, 5, 3, 5, 4, 2 };
// Array.Sort(grades);
// foreach (int grade in grades) {
//     Console.WriteLine(grade);
// }

// Console.Write("Введите N: ");
// int n = int.Parse(Console.ReadLine());
// int[] squares = new int[n];

// for (int i = 0; i < n; i++) {
//     squares[i] = (i + 1) * (i + 1);
// }

// foreach (int num in squares) {
//     Console.WriteLine(num);
// }

// int[] GenerateEvenNumbers(int n) {
//     int count = n / 2;
//     int[] even = new int[count];
//     for (int i = 0; i < count; i++) {
//         even[i] = (i + 1) * 2;
//     }

//     return even;
// }
// int[] result = GenerateEvenNumbers(10);
// foreach (int num in result) {
//     Console.WriteLine(num);
// }

// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
// Console.WriteLine("Фамилия не введена. Завершение работы.");
// return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

// Console.Write("Введите размер массива: ");
// int size = int.Parse(Console.ReadLine());
// int[] numbers = new int[size];
// Console.WriteLine("Введите элементы массива:");
// for (int i = 0; i < size; i++)
// {
//     numbers[i] = int.Parse(Console.ReadLine());
// }
// for (int i = 0; i < size / 2; i++)
// {
//     int temp = numbers[i];
//     numbers[i] = numbers[size - 1 - i];
//     numbers[size - 1 - i] = temp;
// }

// Console.WriteLine("Развёрнутый массив:");
// foreach (int num in numbers)
// {
//     Console.Write(num + " ");
// }

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] numbers = new int[size];
Console.WriteLine("Введите элементы массива:");
for (int i = 0; i < size; i++)
{
    numbers[i] = int.Parse(Console.ReadLine());
}
Array.Sort(numbers);
int max = numbers[size - 1];
int secondMax = max;
for (int i = size - 2; i >= 0; i--)
{
    if (numbers[i] != max)
    {
        secondMax = numbers[i];
        break;
    }
}

Console.WriteLine($"Второе по величине число: {secondMax}");