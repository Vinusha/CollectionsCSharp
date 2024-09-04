namespace Generics;

public class Program
{
    static void Main(string[] args)
    {
        Group<int> group = new Group<int>();

        group.AddAnItem(1);
        group.AddAnItem(2);
        group.AddAnItem(3);

        var anItem = group.GetAnItem(1);

        Console.WriteLine(anItem);

        var sortedDesc = group.GetSortedListDesc();

        foreach (var item in sortedDesc) 
        {
            Console.WriteLine(item);
        }
    }
}
