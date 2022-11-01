using HarmonyLib;
using System;
using UnboundLib;

namespace ForceStatNumbers.Patch
{
    [Serializable]
    [HarmonyPatch(typeof(Optionshandler), "SetShowCardStatNumbers")]
    internal class CardStatNumbersButtonPatch
    {
        [HarmonyPriority(int.MinValue)]
        private static bool Prefix(Optionshandler __instance)
        {
            Optionshandler.showCardStatNumbers = true;
            __instance.InvokeMethod("SaveOptions");
            return false;
        }
    }
}
