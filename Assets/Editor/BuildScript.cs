using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class BuildScript {

    public static void BuildSSX () {
        
        EditorApplication.Exit(1);
        System.Console.WriteLine("Setting SDK and JDK paths");
        EditorPrefs.SetString("AndroidSdkRoot", "/opt/Android/android-sdk");
        EditorPrefs.SetString("JdkPath", "/usr/lib/jvm/java-8-openjdk-amd64");

        System.Console.WriteLine("Beginning SSX Build");
        BuildPipeline.BuildPlayer(EditorBuildSettings.scenes, "/app/UnityBuilds/ssx/ssx.apk", BuildTarget.Android, BuildOptions.None);
        EditorApplication.Exit(0);

    }

}