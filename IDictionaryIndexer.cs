using System.Collections;
using System.Collections.Generic;

namespace NullableTest
{
    class IDictionaryIndexer
    {
        static void Test()
        {
            IDictionary dictionary = new Dictionary<string, string>();

            // works
            dictionary.Add("key", null);

            // warning CS8625: Cannot convert null literal to non-nullable reference type.
            dictionary["test"] = null;
        }
    }
}
