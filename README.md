# UniSpeech

iOS Speech framework plugin for Unity

## Installation

1. From Source
    - Clone this repo and copy the `Assets/UniSpeech/Pluigins/iOS/` and `Assets/UnitySwift/` directory to your own project.
    
## Usage

```
using UniSpeech;
using UnityEngine;

public class SpeechRecognizer : MonoBehaviour, ISpeechRecognizer
{
    void Start()
    {
        UniSpeech.SpeechRecognizer.CallbackGameObjectName = gameObject.name;
        UniSpeech.SpeechRecognizer.RequestRecognizerAuthorization();
    }

    public void OnAuthorized()
    {
        UniSpeech.SpeechRecognizer.StartRecord();
    }

    public void OnRecognized(string transcription)
    {
        Debug.Log("OnRecognized: " + transcription);
    }

    public void OnError(string description) { }
    public void OnUnauthorized() { }
    public void OnAvailable() { }
    public void OnUnavailable() { }
}
```

You need to configure `Edit > Project Settings > Player > iOS > Other Settings > Microphone Usage Description`
![image](https://user-images.githubusercontent.com/3272594/31448986-b5259b02-aee0-11e7-8403-7d5451e341b4.png)


## Sample

See [UniSpeech/Sample](https://github.com/noir-neo/UniSpeech/tree/master/Assets/UniSpeech/Sample)


## Requirements

- iOS 10+

## License

the MIT License.

Dependent on [miyabi/unity-swift](https://github.com/miyabi/unity-swift)

