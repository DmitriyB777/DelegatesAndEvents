using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents.Library.Extensions
{
    public static class EnumerableExtension
    {
        public static T GetMax<T>(this IEnumerable<T> collection, Func<T, float> convertToNumber) where T : class
        {
            if (collection == null) throw new ArgumentNullException(nameof(collection));

            if (convertToNumber == null) throw new ArgumentNullException(nameof(convertToNumber));

            T maxT = collection.FirstOrDefault();
            float max = convertToNumber(maxT);

            foreach (T item in collection)
            {
                if (convertToNumber(item) > max)
                {
                    maxT = item;
                    max = convertToNumber(maxT);
                }
            }

            return maxT;
        }
    }
}
