using System.Linq;
namespace Module19;

public static class EnumerableExtensions
{

    extension<T>(IEnumerable<T> source)
    {
        public IEnumerable<T> WhereNot(Func<T, bool> predicate)
        {
            return source.Where(x => !predicate(x));
        }

        public bool IsEmpty()
        {
            return !source.Any();
        }

        public IEnumerable<T> TakeEveryNthElement(int n)
        {
            if (n <= 0)
                throw new ArgumentException("n must be greater than 0");

            int index = 0;
            foreach (var item in source)
            {
                index++;
                if(index % n == 0)
                    yield return item;
            }
        }
        
        public static IEnumerable<T> Shuffle<T1>( IEnumerable<T> source1)
        {
            var random = new Random();
            var list = source1.ToList();

            for (int i = list.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);

                (list[i], list[j]) = (list[j], list[i]);
            }

            return list;
        }
        
        public static Dictionary<TKey, TValue> ToDictionarySafe<T1, TKey, TValue>(
             IEnumerable<T1> source2,
            Func<T1, TKey> keySelector,
            Func<T1, TValue> valueSelector)
        {
            var dictionary = new Dictionary<TKey, TValue>();

            foreach (T1 item in source2)
            {
                var key = keySelector(item);

                if (!dictionary.ContainsKey(key))
                {
                    dictionary[key] = valueSelector(item);
                }
            }

            return dictionary;
        }
    }
}