#import <Foundation/Foundation.h>
#import <Speech/Speech.h>
#import "unityswift-Swift.h"    // Required
// This header file is generated automatically when Xcode build runs.

#pragma mark - C interface

extern "C" {
    void _sr_requestRecognizerAuthorization() {
        [[SpeechRecognizer sharedInstance] requestRecognizerAuthorization];
    }

    BOOL _sr_startRecord() {
        return [[SpeechRecognizer sharedInstance] startRecord];
    }
    
    BOOL _sr_stopRecord() {
        return [[SpeechRecognizer sharedInstance] stopRecord];
    }

    void _sr_setCallbackGameObjectName(const char *callbackGameObjectName) {
        [[SpeechRecognizer sharedInstance] setUnitySendMessageGameObjectName:[NSString stringWithUTF8String:callbackGameObjectName]];
    }
}
