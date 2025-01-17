using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Utility;

namespace Arcade
{
    public class GameManager : MonoBehaviour
    {
        void Start()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            
            Helper.Print(numbers, "Numbers");
        }

        public void Exit()
        {
#if UNITY_EDITOR
            EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
            Debug.Log("Game is exiting");
        }
    }
}
