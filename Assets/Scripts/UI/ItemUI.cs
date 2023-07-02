using TMPro;
using UnityEngine;
using UnityEngine.UI; 

namespace GameTest.UI
{
    public class ItemUI : MonoBehaviour
    { 
        [SerializeField] private TMP_Text _text;
        [SerializeField] private Button _button;

        public Button ButtonItem => _button; 
        public TMP_Text TextItem => _text;

        public void SetInteractable(bool available)
        {
            _button.interactable = available;
        }
    }
}