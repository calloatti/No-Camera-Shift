using HarmonyLib;
using Timberborn.ModManagerScene;
using UnityEngine;

namespace Calloatti.NoCameraShift
{
  public class ModStarter : IModStarter
  {
    private const string HarmonyId = "calloatti.nocamerashift";

    public void StartMod(IModEnvironment modEnvironment)
    {
      // Instantiate Harmony and apply all patches in this assembly
      Harmony harmony = new Harmony(HarmonyId);
      harmony.PatchAll(typeof(ModStarter).Assembly);
      Debug.Log($"[{HarmonyId}] Harmony patches applied successfully!");
    }
  }
}