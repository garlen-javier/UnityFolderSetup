

using UnityEditor;
using UnityEditor.Build;

namespace GJSetup.Editor.Utils
{
    public static class DefineSymbolUtil
    {
        public static void Add(string symbol)
        {
            BuildTargetGroup currentGroup = GetCurrentBuildTargetGroup();
            NamedBuildTarget nt = NamedBuildTarget.FromBuildTargetGroup(currentGroup);
            Add(symbol, nt);
        }
        
        public static void Add(string symbol, NamedBuildTarget buildTarget)
        {
            // Get current defines
            string defines = PlayerSettings.GetScriptingDefineSymbols(buildTarget);

            // Prevent duplicates
            if (!defines.Contains(symbol))
            {
                if (!string.IsNullOrEmpty(defines))
                    defines += ";" + symbol;
                else
                    defines = symbol;

                PlayerSettings.SetScriptingDefineSymbols(buildTarget, defines);
                UnityEngine.Debug.Log($"Added scripting symbol: {symbol} for {buildTarget.TargetName}");
            }
        }
        
        public static void Remove(string symbol)
        {
            BuildTargetGroup currentGroup = GetCurrentBuildTargetGroup();
            NamedBuildTarget nt = NamedBuildTarget.FromBuildTargetGroup(currentGroup);
            Remove(symbol, nt);
        }

        public static void Remove(string symbol, NamedBuildTarget buildTarget)
        {
            string defines = PlayerSettings.GetScriptingDefineSymbols(buildTarget);

            if (defines.Contains(symbol))
            {
                var defineList = new System.Collections.Generic.List<string>(defines.Split(';'));
                defineList.Remove(symbol);

                string newDefines = string.Join(";", defineList);
                PlayerSettings.SetScriptingDefineSymbols(buildTarget, newDefines);
                UnityEngine.Debug.Log($"Removed scripting symbol: {symbol} for {buildTarget.TargetName}");
            }
        }
        
        private static BuildTargetGroup GetCurrentBuildTargetGroup()
        {
            BuildTarget activeTarget = EditorUserBuildSettings.activeBuildTarget;
            return BuildPipeline.GetBuildTargetGroup(activeTarget);
        }
    
    }
}