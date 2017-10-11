#if UNITY_IOS
using System.IO;
using UnityEditor;
using UnityEditor.iOS.Xcode;
using UnityEditor.Callbacks;

public class XcodeSettingsPostProcesser
{
    [PostProcessBuild]
    public static void OnPostprocessBuild(BuildTarget buildTarget, string pathToBuiltProject)
    {
        string projPath = PBXProject.GetPBXProjectPath(pathToBuiltProject);
        PBXProject proj = new PBXProject();
        proj.ReadFromString(File.ReadAllText(projPath));
        string target = proj.TargetGuidByName("Unity-iPhone");

        proj.SetBuildProperty(target, "SWIFT_VERSION", "3.2");

        File.WriteAllText(projPath, proj.WriteToString());

        var plistPath = Path.Combine(pathToBuiltProject, "Info.plist");
        var plist = new PlistDocument();
        plist.ReadFromFile(plistPath);

        plist.root.SetString("NSSpeechRecognitionUsageDescription", "This app needs access to Speech Recognition");

        plist.WriteToFile(plistPath);
    }
}
#endif