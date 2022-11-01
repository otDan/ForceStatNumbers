using BepInEx;
using HarmonyLib;

namespace ForceStatNumbers
{
    [BepInDependency("com.willis.rounds.unbound")]
    [BepInPlugin(ModId, ModName, Version)]
    [BepInProcess("Rounds.exe")]
    public class ForceStatNumbers : BaseUnityPlugin
    {
        private const string ModId = "ot.dan.rounds.forcestatnumbers";
        private const string ModName = "Force Stat Numbers";
        public const string Version = "1.0.0";
        public const string ModInitials = "FSN";
        private const string CompatibilityModName = "ForceStatNumbers";
        public static ForceStatNumbers Instance { get; private set; }
        private const bool DEBUG = false;

        private void Awake()
        {
            Instance = this;
            
            var harmony = new Harmony(ModId);
            harmony.PatchAll();
        }

        private void Start()
        {
            Optionshandler.showCardStatNumbers = true;
        }

        public void Log(string debug)
        {
            if (DEBUG) UnityEngine.Debug.Log(debug);
        }
    }
}