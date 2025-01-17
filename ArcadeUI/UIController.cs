using System.Collections.Generic;
using UnityEngine;
using Cursor = UnityEngine.Cursor;

namespace ArcadeUI
{
    public class UIController : MonoBehaviour
    {
        GameObject _operationPanel; 
        OperationButtonManager _operationButtonManager;

        public List<Animator> buttonAnimatorList;
        
        int _selectedHash;
        int _normalHash;

        void Awake()
        {
            _operationPanel = GameObject.Find("OperationPanel");
            _operationButtonManager = _operationPanel.GetComponent<OperationButtonManager>();
            _selectedHash = Animator.StringToHash("Selected");
            _normalHash = Animator.StringToHash("Normal");
        }

        void Start()
        {
            Cursor.visible = false;  
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape)) _operationButtonManager.OnPlay();
        }
    }
}
