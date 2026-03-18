using System.IO;
using UnityEditor;
using UnityEngine;
using static System.Environment;

namespace GJSetup.Editor
{
    /// <summary>
    /// Import Assets from Unity Asset Store
    /// </summary>
    public static class AssetSetup
    {
        private const string AssetStoreFolderPath = "Unity/Asset Store-5.x";
        private const string DefaultMenuItem = "Tools/Setup/Free && Paid Assets/";
        
        [MenuItem(DefaultMenuItem + "Import Essentials",priority = 2)]
        public static void ImportEssentials()
        {
            //Note: Check names here: //C:/Users/<username>/AppData/Roaming/Unity/Asset Store-5.x
            ImportAsset("RiderFlow.unitypackage", "Jetbrains/Editor ExtensionsDesign");
            ImportAsset("FolderColor.unitypackage", "Nyukiland/Editor ExtensionsUtilities");
            ImportAsset("Editor Console Pro.unitypackage", "FlyingWorm/Editor ExtensionsSystem");
            ImportAsset("Wingman - Your Inspectors Best Friend.unitypackage", "Kyle Rhoads/Editor ExtensionsUtilities");
            ImportAsset("Build Report Tool.unitypackage", "Anomalous Underdog/Editor ExtensionsUtilities");
            ImportAsset("Odin Inspector and Serializer.unitypackage", "Sirenix/Editor ExtensionsSystem");
        }

        #region Tween Packages
        
        [MenuItem(DefaultMenuItem + "Tween/Import DoTween",priority = 3)]
        public static void ImportDoTween()
        {
            ImportAsset("DOTween HOTween v2.unitypackage", "Demigiant/Editor ExtensionsAnimation");
        }

        [MenuItem(DefaultMenuItem + "Tween/Import PrimeTween")]
        public static void ImportPrimeTween()
        {
            ImportAsset("PrimeTween High-Performance Animations and Sequences.unitypackage", "Kyrylo Kuzyk/Editor ExtensionsAnimation");
        }
        
        #endregion

        #region Prototype Packages
        
        [MenuItem(DefaultMenuItem + "Prototype/Import Prototype Materials",priority = 4)]
        public static void ImportPrototypeMaterials()
        {
            ImportAsset("Gridbox Prototype Materials.unitypackage", "Ciathyza/Textures Materials");
        }
        
        [MenuItem(DefaultMenuItem + "Prototype/Import Prototype Map")]
        public static void ImportPrototypeMap()
        {
            ImportAsset("Prototype Map.unitypackage", "AngeloMaN87/3D ModelsEnvironments");
        }
        
        [MenuItem(DefaultMenuItem + "Prototype/Import BrawlBattle Arena Freebie")]
        public static void ImportBrawlBattleArenaFreebie()
        {
            ImportAsset("BrawlBattle Arena Freebie.unitypackage", "Solo Player/3D ModelsEnvironments");
        }
        
        [MenuItem(DefaultMenuItem + "Prototype/AllSky Free - 10 Skybox Set")]
        public static void ImportAllSkyFree()
        {
            ImportAsset("AllSky Free - 10 Sky Skybox Set.unitypackage", "rpgwhitelock/Textures MaterialsSkies");
        }
        
        #endregion

        #region UI
        
        [MenuItem(DefaultMenuItem + "UI/Flat pack - GUI",priority = 5)]
        public static void ImportFlatPackGUI()
        {
            ImportAsset("Flat pack - GUI.unitypackage", "CorePro/Textures MaterialsGUI Skins");
        }
 
        [MenuItem(DefaultMenuItem + "UI/Hyper casual mobile GUI")]
        public static void ImportHyperCasualMobileGUI()
        {
            ImportAsset("Hyper casual mobile GUI.unitypackage", "MaryaBelevich/Textures MaterialsGUI Skins");
        }
        
        [MenuItem(DefaultMenuItem + "UI/Free Casual Buttons Pack")]
        public static void ImportFreeCasualButtonsPack()
        {
            ImportAsset("Free Casual Buttons Pack.unitypackage", "traint/Textures MaterialsGUI Skins");
        }
        
        [MenuItem(DefaultMenuItem + "UI/Farm Game UI - Starter 2D")]
        public static void ImportFarmGameUIStarter2D()
        {
            ImportAsset("Farm Game UI - Starter 2D.unitypackage", "maanetorn/Textures MaterialsGUI Skins");
        }
        
        #endregion
        
        #region VFX
        
        [MenuItem(DefaultMenuItem + "VFX/Import Unity Particle Pack",priority = 6)]
        public static void ImportUnityParticlePack()
        {
            ImportAsset("Particle Pack.unitypackage", "Unity Technologies/Particle Systems");
        }
        
        [MenuItem(DefaultMenuItem + "VFX/Cartoon FX Remaster Free")]
        public static void ImportCartoonFXRemasterFree()
        {
            ImportAsset("Cartoon FX Remaster Free.unitypackage", "Jean Moreno/Particle Systems");
        }
        
        [MenuItem(DefaultMenuItem + "VFX/War FX")]
        public static void ImportWarFX()
        {
            ImportAsset("War FX.unitypackage", "Jean Moreno/Particle Systems");
        }

        #endregion
        
        #region Paid Packages

        [MenuItem(DefaultMenuItem + "Paid/Juice/Feel",priority = 7)]
        public static void ImportFeel()
        {
            ImportAsset("Feel.unitypackage", "More Mountains/ScriptingEffects");
        }
        
        [MenuItem(DefaultMenuItem + "Paid/Helper/Animancer Pro v8",priority = 8)]
        public static void ImportAnimancerProV8()
        {
            ImportAsset("Animancer Pro v8.unitypackage", "Kybernetik/ScriptingAnimation");
        }

        #region UI

        [MenuItem(DefaultMenuItem + "Paid/UI/Text Animator",priority = 9)]
        public static void ImportTextAnimator()
        {
            ImportAsset("Text Animator for Unity.unitypackage", "Febucci Tools/ScriptingGUI");
        }
        
        [MenuItem(DefaultMenuItem + "Paid/UI/Dialogue System")]
        public static void ImportDialogueSystem()
        {
            ImportAsset("Dialogue System for Unity.unitypackage", "Pixel Crushers/ScriptingAI");
        }

        #endregion

        #region Shaders
        
        [MenuItem(DefaultMenuItem + "Paid/Shader/2D/Sprite Shaders Ultimate",priority = 10)]
        public static void ImportSpriteShadersUltimate()
        {
            ImportAsset("Sprite Shaders Ultimate.unitypackage", "Ekincan Tas/Shaders");
        }
        
        [MenuItem(DefaultMenuItem + "Paid/Shader/Amplify/Amplify Shader Editor",priority = 11)]
        public static void ImportAmplifyShaderEditor()
        {
            ImportAsset("Amplify Shader Editor.unitypackage", "Amplify Creations/Editor ExtensionsVisual Scripting");
        }
        
        [MenuItem(DefaultMenuItem + "Paid/Shader/Amplify/Amplify Impostors")]
        public static void ImportAmplifyImpostors()
        {
            ImportAsset("Amplify Impostors.unitypackage", "Amplify Creations/Editor ExtensionsUtilities");
        }
        
        [MenuItem(DefaultMenuItem + "Paid/Shader/Amplify/Amplify LUT Pack")]
        public static void ImportAmplifyLUTPack()
        {
            ImportAsset("Amplify LUT Pack.unitypackage", "Amplify Creations/ShadersFullscreen Camera Effects");
        }
        
        [MenuItem(DefaultMenuItem + "Paid/Shader/Amazing/Curved World",priority = 12)]
        public static void ImportCurvedWorld()
        {
            ImportAsset("Curved World.unitypackage", "Amazing ssets/Shaders");
        }
        
        [MenuItem(DefaultMenuItem + "Paid/Shader/Amazing/Advanced Dissolve")]
        public static void ImportAdvancedDissolve()
        {
            ImportAsset("Advanced Dissolve.unitypackage", "Amazing ssets/Shaders");
        }
        
        [MenuItem(DefaultMenuItem + "Paid/Shader/Amazing/Wireframe Shader")]
        public static void ImportWireframeShader()
        {
            ImportAsset("Wireframe Shader.unitypackage", "Amazing ssets/Shaders");
        }
        
        [MenuItem(DefaultMenuItem + "Paid/Shader/Amazing/Dynamic Radial Masks")]
        public static void ImportDynamicRadialMasks()
        {
            ImportAsset("Dynamic Radial Masks.unitypackage", "Amazing ssets/Shaders");
        }
        
        [MenuItem(DefaultMenuItem + "Paid/Shader/Amazing/Subsurface Scattering Shader")]
        public static void ImportSubsurfaceScatteringShader()
        {
            ImportAsset("Subsurface Scattering Shader.unitypackage", "Amazing ssets/Shaders");
        }
        
        [MenuItem(DefaultMenuItem + "Paid/Shader/Amazing/Beast - Advanced Tessellation")]
        public static void ImportBeastAdvancedTessellation()
        {
            ImportAsset("Beast - Advanced Tessellation Shader.unitypackage", "Amazing ssets/Shaders");
        }
        
        [MenuItem(DefaultMenuItem + "Paid/Shader/Amazing/Lowpoly Shader")]
        public static void ImportLowpolyShader()
        {
            ImportAsset("Lowpoly Shader.unitypackage", "Amazing ssets/Shaders");
        }
        
        [MenuItem(DefaultMenuItem + "Paid/Shader/Mystify FX")]
        public static void ImportMystifyFX()
        {
            ImportAsset("Mystify FX.unitypackage", "Kronnect/Shaders");
        }
        
        #endregion

        #region VFX
        
        [MenuItem(DefaultMenuItem + "Paid/VFX/Cartoon FX4 Remaster",priority = 13)]
        public static void ImportCartoonFX4Remaster()
        {
            ImportAsset("Cartoon FX 4 Remaster.unitypackage", "Jean Moreno/Particle Systems");
        }
        
        [MenuItem(DefaultMenuItem + "Paid/VFX/Sci-Fi Arsenal")]
        public static void ImportSciFiArsenal()
        {
            ImportAsset("Sci-Fi Arsenal.unitypackage", "Archanor VFX/Particle Systems");
        }
        
        [MenuItem(DefaultMenuItem + "Paid/VFX/VolFx - VFX Toolkit Post Processing Timeline Tracks Shaders Tools")]
        public static void ImportVolFxPPTimelineShadersTools()
        {
            ImportAsset("VolFx - VFX Toolkit Post Processing Timeline Tracks Shaders Tools.unitypackage", "NullTale/ShadersFullscreen Camera Effects");
        }
        
        #endregion

        #region Physics

        [MenuItem(DefaultMenuItem + "Paid/Physics/Final IK",priority = 14)]
        public static void ImportFinalIK()
        {
            ImportAsset("Final IK.unitypackage", "RootMotion/Editor ExtensionsAnimation");
        }
        
        [MenuItem(DefaultMenuItem + "Paid/Physics/PuppetMaster")]
        public static void ImportPuppetMaster()
        {
            ImportAsset("PuppetMaster.unitypackage", "RootMotion/ScriptingPhysics");
        }
        
        [MenuItem(DefaultMenuItem + "Paid/Physics/Ragdoll Animator 2")]
        public static void ImportRagdollAnimator2()
        {
            ImportAsset("Ragdoll Animator 2.unitypackage", "FImpossible Creations/ScriptingPhysics");
        }

        #endregion
        
        #region Engines and Tools
        
        [MenuItem(DefaultMenuItem + "Paid/Engines/TopDown Engine",priority = 15)]
        public static void ImportTopDownEngine()
        {
            ImportAsset("TopDown Engine.unitypackage", "More Mountains/Complete ProjectsSystems");
        }
        
        [MenuItem(DefaultMenuItem + "Paid/Engines/Corgi Engine - 2D + 2.5D Platformer")]
        public static void ImportCorgiEngine()
        {
            ImportAsset("Corgi Engine - 2D 25D Platformer.unitypackage", "More Mountains/Complete ProjectsSystems");
        }
        
        [MenuItem(DefaultMenuItem + "Paid/Engines/Easy Grid Builder Pro 2")]
        public static void ImportEasyGridBuilderPro2()
        {
            ImportAsset("Easy Grid Builder Pro 2 Modular Building System.unitypackage", "SoulGames/Editor ExtensionsGame Toolkits");
        }
        
        #endregion

        #region Networking

        [MenuItem(DefaultMenuItem + "Paid/Networking/FishNet Pro",priority = 16)]
        public static void ImportFishNetProNetworking()
        {
            ImportAsset("FishNet Pro Networking Evolved.unitypackage", "FirstGearGames/ScriptingNetwork");
        }
        
        [MenuItem(DefaultMenuItem + "Paid/Networking/Smooth Sync")]
        public static void ImportSmoothSync()
        {
            ImportAsset("Smooth Sync.unitypackage", "Noble Whale Studios/ScriptingNetwork");
        }

        #endregion

        #region Debugging

        [MenuItem(DefaultMenuItem + "Paid/Networking/Draw XXL",priority = 17)]
        public static void ImportDrawXXL()
        {
            ImportAsset("Draw XXL.unitypackage", "Symphony Games/Editor ExtensionsUtilities");
        }

        #endregion
        
        #endregion

        private static void ImportAsset(string asset, string folder)
        {
            string basePath = GetFolderPath(SpecialFolder.ApplicationData);
            string assetPath = Path.Combine(basePath, AssetStoreFolderPath); //C:/Users/<username>/AppData/Roaming/Unity/Asset Store-5.x
            AssetDatabase.ImportPackage(Path.Combine(assetPath, folder, asset), false);
            Debug.Log($"Import Asset: {asset}");
        }
        
    }
}