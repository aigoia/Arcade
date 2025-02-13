using UnityEngine;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;

namespace UI
{
    public class OperationButtonManager : MonoBehaviour
    {
        GameObject _buttonPanel;
        Animator _buttonAnimator;
        GameObject _darker;
        public Image darkerImage; 
        Animator _leftTopAnimator;
        Animator _rightTopAnimator;
        Animator _leftBottomAnimator;
        Animator _rightBottomAnimator;
        Animator _middlePanelAnimator;
        Button _continueButton;
        Button _thisButton;
        
        void Awake()
        {
            _darker = GameObject.Find("Darker");
            darkerImage ??= _darker.GetComponent<Image>();
            darkerImage.enabled = true;
            _darker.SetActive(false);
            
            _buttonPanel = GameObject.Find("ButtonPanel");
            _buttonAnimator = _buttonPanel.GetComponent<Animator>();
            
            _leftTopAnimator = GameObject.Find("LeftTopPanel").GetComponent<Animator>();
            _rightTopAnimator = GameObject.Find("RightTopPanel").GetComponent<Animator>();
            _leftBottomAnimator = GameObject.Find("LeftBottomPanel").GetComponent<Animator>();
            _rightBottomAnimator = GameObject.Find("RightBottomPanel").GetComponent<Animator>();
            _middlePanelAnimator = GameObject.Find("MiddlePanel").GetComponent<Animator>();

            _continueButton = GameObject.Find("Continue").GetComponent<Button>();
            _thisButton = GetComponent<Button>();
        }

        void Start()
        {
            _continueButton.onClick.AddListener(OnPlayContinue);
        }

        void OnPlayContinue()
        {
            if (!_darker.activeSelf) return;

            _thisButton.onClick.Invoke();
            
            _buttonAnimator.Play("Hide");
            
            _leftTopAnimator.Play("Show");
            _rightTopAnimator.Play("Show");
            _leftBottomAnimator.Play("Show");
            _rightBottomAnimator.Play("Show");
            _middlePanelAnimator.Play("Show");
            
            _darker.SetActive(!_darker.activeSelf);
            Cursor.visible = false;
        }
        
        public void OnPlay()
        {
            _thisButton.onClick.Invoke();
            
            _buttonAnimator.Play(_darker.activeSelf ? "Hide" : "Show");
            
            _leftTopAnimator.Play(_darker.activeSelf ? "Show" : "Hide");
            _rightTopAnimator.Play(_darker.activeSelf ? "Show" : "Hide");
            _leftBottomAnimator.Play(_darker.activeSelf ? "Show" : "Hide");
            _rightBottomAnimator.Play(_darker.activeSelf ? "Show" : "Hide");
            _middlePanelAnimator.Play(_darker.activeSelf ? "Show" : "Hide");
            
            _darker.SetActive(!_darker.activeSelf);
            Cursor.visible = _darker.activeSelf;
        }
    }
}
