using System;
using System.Collections.Generic;

namespace Polyjuice
{
    public class Ergo<T>
    {
        private static Ergo<T> _ergo;
        private static Dictionary<string, Func<T>> Data { get; } = new Dictionary<string, Func<T>>();
        public static Ergo<T> Current => _ergo = _ergo ?? new Ergo<T>();

        public T this[string when]
        {
            set => Add(when, value);
            get => Get(when);
        }

        public void SetDefault(T value) => Add("pj-default", value);
        public T GetDefault() => Get("pj-default");

        public void Clear() => Data.Clear();

        private static void Add(string key, T value)
        {
            T Func() => value;
            Data[key] = Func;
        }

        private static T Get(string key) =>
            Data.ContainsKey(key) ? Data[key].Invoke() : default(T);
    }
}