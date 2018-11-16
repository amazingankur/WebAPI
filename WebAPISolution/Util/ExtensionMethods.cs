using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPISolution.Util
{
    public static class ExtensionMethods
    {
        public static T[] RemoveAtIndex<T>(this T[] source, int index)
        {
            T[] destination = new T[source.Length - 1];
            if (index > 0)
                Array.Copy(source, 0, destination, 0, index);

            if (index < source.Length - 1)
                Array.Copy(source, index + 1, destination, index, source.Length - index - 1);

            return destination;
        }
    }
}