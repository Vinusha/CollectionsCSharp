namespace Generics;

public class Group<T> where T : struct
{
    private List<T> _items = new List<T>();

    public void AddAnItem(T item)
    {
        _items.Add(item); 
    }

    public T GetAnItem(int index) 
    {
        if (index >= 0 && index < _items.Count)
        {
            return _items[index];
        }
        else
        {
            throw new IndexOutOfRangeException();
        }
    }

    public List<T> GetSortedListDesc()
    {
        return _items.OrderByDescending(item => item).ToList();
    }
}
