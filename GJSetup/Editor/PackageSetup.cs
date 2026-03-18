using System.Collections.Generic;
using System.Threading.Tasks;
using GJSetup.Editor.Utils;
using UnityEditor;
using UnityEditor.PackageManager;
using UnityEditor.PackageManager.Requests;
using UnityEngine;

namespace GJSetup.Editor
{
    /// <summary>
    /// Packages from github repo and unity
    /// </summary>
    public static class PackageSetup
    {
        private static AddRequest _request;
        private static Queue<string> _packagesToInstall = new Queue<string>();

        private const string _defaultMenuItem = "Tools/Setup/Unity && Github Packages/";
        
        [MenuItem(_defaultMenuItem + "Install Essentials",priority = 3)]
        public static void InstallEssentials()
        {
            InstallPackages(new[]
            {
                "com.unity.cinemachine",
                "com.unity.nuget.newtonsoft-json",
                "com.unity.project-auditor", //Note: Make sure roselyn analyzer is checked at Edit>Preferences>Analysis
                // "https://github.com/hadashiA/VContainer.git?path=VContainer/Assets/VContainer#1.16.8",
                "https://github.com/Cysharp/UniTask.git?path=src/UniTask/Assets/Plugins/UniTask",
                "https://github.com/GlitchEnzo/NuGetForUnity.git?path=/src/NuGetForUnity",
                "https://github.com/adammyhre/Unity-Improved-Timers.git",
               // "com.unity.inputsystem", //Note: should be last as it will require to restart the editor
            });
            
            Debug.LogWarning("After installing Zlinq using NuGetForUnity, manually install ZLinq & ZString from github repo");
            Debug.LogWarning("After installing R3 using NuGetForUnity, manually install R3 from github repo");
            Debug.LogWarning("NuGetForUnity installed, you can install ObservableCollections by Cysharp");
        }
        
        [MenuItem(_defaultMenuItem + "DI/Install VContainer",priority = 4)]
        private static void InstallVContainer()
        {
            InstallPackages(new[]
            {
                "https://github.com/hadashiA/VContainer.git?path=VContainer/Assets/VContainer#1.17.0",
            });
        }
        
        [MenuItem(_defaultMenuItem + "DI/Install Reflex")]
        private static void InstallReflexDI()
        {
            InstallPackages(new[]
            {
                "https://github.com/gustavopsantos/reflex.git?path=/Assets/Reflex/#13.0.3",
            });
        }
        
        // [MenuItem(_defaultMenuItem + "DI/Install Manual")]
        // private static void InstallManualDI()
        // {
        //     InstallPackages(new[]
        //     {
        //         "",
        //     });
        // }
        
        [MenuItem(_defaultMenuItem + "Cysharp/Install ZString",priority = 5)]
        private static void InstallZString()
        {
            InstallPackages(new[]
            {
                "https://github.com/Cysharp/ZString.git?path=src/ZString.Unity/Assets/Scripts/ZString",
            });
            
            DefineSymbolUtil.Add("ZSTRING_TEXTMESHPRO_SUPPORT");
            // Debug.LogWarning("Define the scripting define symbol ZSTRING_TEXTMESHPRO_SUPPORT to enable ZString");
        }
        
        [MenuItem(_defaultMenuItem + "Cysharp/Install ZLinq")]
        private static void InstallZLinq()
        {
            InstallPackages(new[]
            {
                "https://github.com/Cysharp/ZLinq.git?path=src/ZLinq.Unity/Assets/ZLinq.Unity",
            });
        }
        
        [MenuItem(_defaultMenuItem + "Cysharp/Install R3")]
        private static void InstallR3()
        {
            InstallPackages(new[]
            {
                "https://github.com/Cysharp/R3.git?path=src/R3.Unity/Assets/R3.Unity",
            });
        }

        [MenuItem(_defaultMenuItem + "Input/Install Unity Input System",priority = 6)]
        private static void InstallUnityInputSystem()
        {
            InstallPackages(new[]
            {
                "com.unity.inputsystem", 
            });
        }
        
        [MenuItem(_defaultMenuItem + "Prototype/Install Unity Character Controller",priority = 7)]
        private static void InstallUnityCharacterController()
        {
            InstallPackages(new[]
            {
                "com.unity.charactercontroller", 
            });
        }
        
        [MenuItem(_defaultMenuItem + "Utils/Install Unity Recorder",priority = 8)]
        private static void InstallUnityRecorder()
        {
            InstallPackages(new[]
            {
                "com.unity.recorder", 
            });
        }
        
        private static void InstallPackages(string[] packages)
        {
            foreach (var package in packages)
            {
                _packagesToInstall.Enqueue(package);
            }
            
            if(_packagesToInstall.Count > 0)
                StartNextPackageInstall(); 
            
        }

        private static async void StartNextPackageInstall()
        {
            _request = Client.Add(_packagesToInstall.Dequeue());
            while (!_request.IsCompleted) await Task.Delay(10);
            
            if(_request.Status == StatusCode.Success)
                Debug.Log("Installed : " + _request.Result.packageId);
            else if(_request.Status == StatusCode.Failure)
                Debug.LogError(_request.Error.message);

            if (_packagesToInstall.Count > 0)
            {
                await Task.Delay(1000);
                StartNextPackageInstall();
            }
        }

    }
}