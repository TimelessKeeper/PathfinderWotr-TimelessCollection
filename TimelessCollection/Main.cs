using TimelessCollection.Feats;
using TimelessCollection.Utilities;
using HarmonyLib;
using JetBrains.Annotations;
using Kingmaker;
using Kingmaker.Blueprints.JsonSystem;
using System;
using UnityModManagerNet;

namespace TimelessCollection
{
    static class Main
    {
        [HarmonyPatch(typeof(BlueprintsCache), "Init")]
        public class BloodriderCachePatch
        {
            private static bool Initialized;

            public static void Postfix()
            {
                if (Initialized) return;
                Initialized = true;

                BloodriderMount.AddBloodriderMount();
            }
        }

        public static bool Enabled = true;
        public static UnityModManager.ModEntry ModEntry;
        static bool Load(UnityModManager.ModEntry modEntry)
        {
            var harmony = new Harmony(modEntry.Info.Id);
            ModEntry = modEntry;
            harmony.PatchAll();
            PostPatchInitializer.Initialize();
            return true;
        }

        internal static void LogPatch(string v, object coupDeGraceAbility)
        {
            throw new NotImplementedException();
        }

        public static void Log(string msg)
        {
            ModEntry.Logger.Log(msg);
        }
        [System.Diagnostics.Conditional("DEBUG")]
        public static void LogDebug(string msg)
        {
            ModEntry.Logger.Log(msg);
        }
        public static void LogPatch(string action, [NotNull] IScriptableObjectWithAssetId bp)
        {
            Log($"{action}: {bp.AssetGuid} - {bp.name}");
        }
        public static void LogHeader(string msg)
        {
            Log($"--{msg.ToUpper()}--");
        }
        public static void Error(Exception e, string message)
        {
            Log(message);
            Log(e.ToString());
            PFLog.Mods.Error(message);
        }
        public static void Error(string message)
        {
            Log(message);
            PFLog.Mods.Error(message);
        }
    }
}