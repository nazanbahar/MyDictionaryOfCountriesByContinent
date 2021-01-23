using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDictionary
{
    class MyDictionary<K, V>
    {
        K [] keys;
        V[] values;

        //constructor
        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];
        }

        //add metot
        public void Add(K key, V value) {

            K[] tempArrayK = keys;
            keys = new K[keys.Length + 1];

            V[] tempArrayV = values;
            values = new V[values.Length + 1];

            for (int i = 0; i < tempArrayK.Length ; i++)
            {
                keys[i] = tempArrayK[i]; 
            }
            keys[keys.Length - 1] = key;


            for (int i = 0; i < tempArrayV.Length; i++)
            {
                values[i] = tempArrayV[i];
            }
            values[values.Length - 1] = value;

        }

        //Sonucu Listelemek: eleman sayisini verir.
        public int Lengh
        {

            get { return values.Length; }

        }

        //eleman isimlerini görmek istersek...
        public K[] Keys
        {
            get { return keys; }   // return items; dersek elemanları okuruz..
        }

        public V[] Values
        {
            get { return values; }   // return items; dersek elemanları okuruz..
        }
 
    }
}
