namespace Module15;

class Program
{
    static void Main(string[] args)
    {
        //Exercise 1
        //Concat two lists of numbers [1, 2, 3] and [4, 5, 6]. Then do the same with Union and compare results.
        // var list1 = new List<int>{1,2,3};
        // var list2 = new List<int>{4,5,6};
        
        // var newList = list1.Concat(list2).ToList();
        // var newList = list1.Union(list2).ToList();
        // Console.WriteLine(String.Join(",", newList));
        
        //Exercise 2
        //Given a list ["B", "C", "D"], prepend "A" and append "E" to get ["A", "B", "C", "D", "E"].
        // var strings = new List<string> {"B", "C", "D" };
        // var updatedString = strings.Append("E").Prepend("A");
        //
        // Console.WriteLine(String.Join(", ", updatedString));
        
        //Exercise 3
        //Zip a list of student names with their grades. Create objects with Name and Grade properties.

        // var studentNames = new List<string> { "Hamza", "Yalina", "Ziyan", "Sherani", "Aalam" };
        // var grades = new List<string> { "A+", "O", "A", "A++", "B" };
        // var zippedList = studentNames.Zip(grades);
        // foreach (var item in zippedList)
        // {
        //     Console.WriteLine(item);
        // }
        
        // Exercise 4:
        //Zip two lists of numbers (same length) and calculate the difference between each pair.
        // var list1 = new List<int> { 10, 20, 30 };
        // var list2 = new List<int> { 5, 4, 3 };
        // var newList = list1.Zip(list2, (x, y) => x - y);
        // foreach (var item in newList)
        // {
        //     Console.WriteLine(item);
        // }
        
        //Exercise 5:
        //You have headers ["Product", "Price", "Qty"] and values ["Laptop", "999", "5"]. Zip them into a dictionary.
        // var headers = new[] { "Product", "Price", "Qty" };
        // var values = new[] { "Laptop", "999", "5" };
        //
        // var newRecord = headers.Zip(values).ToDictionary(pair => pair.First, pair => pair.Second);
        // foreach (var item in newRecord)
        // {
        //     Console.WriteLine(item);
        // }

    }
}