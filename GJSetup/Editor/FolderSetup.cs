using System.IO;
using UnityEditor;
using UnityEngine;
using static System.IO.Directory;
using static UnityEditor.AssetDatabase;

namespace GJSetup.Editor
{
    // Common
    // ↑
    // Data
    // ↑
    // Core
    // ↑
    // Gameplay
    // ↑
    // View
    
    // Common → depends on almost nothing.
    // Data → may use Common.
    // Core → may use Common and Data. Engine-level systems/managers.
    // Gameplay → may use Core, Data, and Common.
    // View → may use everything to display information, but the other layers shouldn't depend on View.
    
    public static class FolderSetup
    {
        [MenuItem("Tools/Setup/Create Default Folders",priority = 1)]
        public static void CreateDefaultFolders()
        {
            CreateFolders("_Project", 
                "Resources/Scenes",
                "Resources/Scenes/Game",
                "Resources/Scenes/Screens",
                "Resources/Prefabs",
                "Resources/Textures",
                "Resources/Materials",
                "Resources/Scriptables",
                "Resources/Audio",
                "Resources/Audio/Sfx",
                "Resources/Audio/Bgm",
                "Scripts/Game",
                "Scripts/Game/Common",
                "Scripts/Game/Common/Enums",
                "Scripts/Game/Common/Structs",
                "Scripts/Game/Common/Interface",
                "Scripts/Game/Core",
                "Scripts/Game/Core/PersistentManagers",
                "Scripts/Game/Data",
                "Scripts/Game/View",
                "Scripts/Game/Gameplay",
                "Scripts/Game/Gameplay/Events",
                "Scripts/Game/Gameplay/Events/Structs",
                "Scripts/Game/Gameplay/Events/Scriptables",
                "Scripts/Game/Gameplay/Controllers",
                "Scripts/Game/Gameplay/Factory",
                "Scripts/Game/Gameplay/Systems",
                "Scripts/Game/Gameplay/Managers",
                "Scripts/Tests"
                // "Scripts/Main",
                // "Scripts/Main/Entities",
                // "Scripts/Main/Events",
                // "Scripts/Main/Events/Structs",
                // "Scripts/Main/Events/Scriptables"
                );
            //MoveFolder("_Project/Resources", "Settings");
            Refresh();
            
            //MoveAsset("Assets/InputSystem_Actions.inputactions", "Assets/_Project/Resources/Input/InputSystem_Actions.inputactions");
            //DeleteAsset("Assets/Readme.asset");
            //Refresh();
        }
        
        private static void CreateFolders(string root,params string[] folders)
        {
            string fullPath = Path.Combine(Application.dataPath, root);
            foreach (var newDir in folders)
            {
                CreateDirectory(Path.Combine(fullPath, newDir));
            }
        }
        
        private static void MoveFolder(string newParent, string folderName)
        {
            string sourcePath = $"Assets/{folderName}";
            if (IsValidFolder(sourcePath))
            {
                string destinationPath = $"Assets/{newParent}/{folderName}";
                string error = MoveAsset(sourcePath, destinationPath);
                if(!string.IsNullOrEmpty(error))
                    Debug.LogError($"Failed to move {folderName}: {error}");
            }
        }

        private static void DeleteFolder(string folderName)
        {
            string pathToDelete = $"Assets/{folderName}";
            if (IsValidFolder(pathToDelete))
                DeleteAsset(pathToDelete);
        }
        
    
    }
}
