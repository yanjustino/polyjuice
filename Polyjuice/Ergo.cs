using System;
using System.Collections.Generic;
using System.Linq;
using Polyjuice.Potions;

namespace Polyjuice
{
    public class Ergo<T>
    {
        private static Ergo<T> _ergo;
        private static Dictionary<string, Func<T>> Data { get; } = new Dictionary<string, Func<T>>();
        private static Dictionary<string, Func<T>> DataType { get; } = new Dictionary<string, Func<T>>();
        public static Ergo<T> Current => _ergo = _ergo ?? new Ergo<T>();

        public T this[string when]
        {
            set => Add(when, value);
            get => Get(when);
        }

        public T this[Type key, string when]
        {
            set => Add($"{nameof(key)}::{when}", value);
            get => Get($"{nameof(key)}::{when}");
        }        

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