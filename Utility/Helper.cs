using System.Collections.Generic;
using UnityEngine;

namespace Utility
{
    public class Helper : MonoBehaviour
    {
        public static void Print<T>(IEnumerable<T> list, string title = "")
        {
            print($"{title} [{string.Join(", ", list)}]");
        }
    }
}