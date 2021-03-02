using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryApp
{
    class MyDictionary<Key, Value>
    {
        Key[] keys;
        Value[] values;

        public MyDictionary()
        {
            keys = new Key[0];
            values = new Value[0];
        }

        public void Add(Key key, Value value)
        {
            Key[] tempArrayKey = keys;
            Value[] tempArrayValue = values;

            keys = new Key[keys.Length + 1];
            values = new Value[values.Length + 1];

            for (int i = 0; i < tempArrayKey.Length; i++)
            {
                keys[i] = tempArrayKey[i];
                values[i] = tempArrayValue[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }

        public void List()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(keys[i] + " -> " + values[i]);
            }
        }
    }
}
