using System;
using UnityEngine;
using UnityEngine.UI;

namespace UniSpeech.Sample
{
    public class UniSpeechSampleUI : MonoBehaviour
    {
        [SerializeField] private Text text;
        [SerializeField] private Button button;
        [SerializeField] private Text buttonText;

        public Action onClick = () => { };

        public void OnClick()
        {
            onClick();
        }

        public void UpdateText(string text)
        {
            this.text.text = text;
        }

        public void UpdateButton(string text, bool interactive)
        {
            buttonText.text = text;
            button.interactable = interactive;
        }
    }
}

