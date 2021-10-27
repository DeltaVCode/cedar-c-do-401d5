static int Count<T>(IEnumerable<T> source)
{
    if (source is ICollection<T> collection)
        return collection.Count;

    int count = 0;
    foreach (T value in source)
        count++;
    return count;
}
