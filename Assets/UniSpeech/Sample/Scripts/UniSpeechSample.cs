using UnityEngine;

namespace UniSpeech.Sample
{
    public class UniSpeechSample : MonoBehaviour, ISpeechRecognizer
    {
        [SerializeField] private UniSpeechSampleUI ui;

        void Start()
        {
            SpeechRecognizer.CallbackGameObjectName = gameObject.name;
            SpeechRecognizer.RequestRecognizerAuthorization();
            ui.UpdateButton("Requesting authorization", false);
        }

        public void OnRecognized(string transcription)
        {
            Debug.Log("OnRecognized: " + transcription);
            ui.UpdateText(transcription);
        }

        public void OnError(string description)
        {
            Debug.Log("OnError: " + description);
            ui.UpdateText("Error: " + description);
            ui.onClick = StartRecord;
            ui.UpdateButton("Start", true);
        }

        public void OnAuthorized()
        {
            Debug.Log("OnAuthorized");
            ui.onClick = StartRecord;
            ui.UpdateButton("Start", true);
        }

        public void OnUnauthorized()
        {
            Debug.Log("OnUnauthorized");
            ui.UpdateButton("Unauthorized", false);
        }

        public void OnAvailable()
        {
            Debug.Log("OnAvailable");
            ui.onClick = StartRecord;
            ui.UpdateButton("Start", true);
        }

        public void OnUnavailable()
        {
            Debug.Log("OnUnavailable");
            ui.UpdateButton("Not Available", false);
        }

        private void StartRecord()
        {
            if (SpeechRecognizer.StartRecord())
            {
                ui.UpdateButton("Stop", true);
                ui.onClick = StopRecord;
            }
        }

        private void StopRecord()
        {
            if (SpeechRecognizer.StopRecord())
                ui.UpdateButton("Stopping", false);
        }
    }
}

