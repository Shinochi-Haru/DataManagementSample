using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
namespace MD
{
    public class MasterDataPretty<K, D>
    {
        Dictionary<K, D> Data = new Dictionary<K, D>();

        static public PrettyData<K, D> Create(T[] data, Func<T, K> mapper)
        {
            PrettyData<K, D> ret = new PrettyData<K, D>();
            foreach (var d in data)
            {
                K key = mapper.Invoke(d);
                if (key == null) continue;

                if (ret.Data.ContainsKey(key))
                {
                    Debug.Log($"duplicate key:{key}");
                    continue;
                }

                ret.Data.Add(key, d);
            }
            return ret;
        }

        public D GetData(K key)
        {
            if (Data.ContainsKey(key)) return Data[key];
            else return default(D);
        }

#if UNITY_EDITOR
        public K[] GetKeys()
        {
            return Data.Keys.ToArray();
        }
#endif
    }
}
*/