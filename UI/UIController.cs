using System;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Serialization;
using UnityEngine.UIElements;
using Cursor = UnityEngine.Cursor;

namespace UI
{
    public class UIController : MonoBehaviour
    {
        GameObject _operationPanel; 
        public OperationButtonManager operationButtonManager;
        public List<Animator> buttonAnimatorList;
        int Selected => Animator.StringToHash("Selected");
        int Normal => Animator.StringToHash("Normal");

        void Awake()
        {
            _operationPanel = GameObject.Find("OperationPanel");
            operationButtonManager = _operationPanel.GetComponent<OperationButtonManager>();
        }

        private void Start()
        {
            Cursor.visible = false;  
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                operationButtonManager.OnPlay();
            }
        }
    }
}