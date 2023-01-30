using MelonLoader;
using AlwaysVTSG;
using HarmonyLib;
using Il2CppAssets.Scripts.Simulation.Towers.Behaviors;

[assembly: MelonInfo(typeof(AlwaysVTSG.Main), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace AlwaysVTSG;

[HarmonyPatch]
public class Main : MelonMod
{
    [HarmonyPatch(typeof(MonkeyTemple), nameof(MonkeyTemple.StartSacrifice))]
    [HarmonyPostfix]
    static void MonkeyTemple_StartSacrifice(MonkeyTemple __instance)
    {
        __instance.ApplyTCBOO();
    }
}
