using HarmonyLib;
using Timberborn.ModManagerScene;
using UnityEngine;

namespace Calloatti.NoCameraShift
{
  public class ModStarter : IModStarter
  {
    private const string HarmonyId = "Calloatti.NoCameraShift";

    public void StartMod(IModEnvironment modEnvironment)
    {
      // Instantiate Harmony and apply all patches in this assembly
new Harmony(HarmonyId).PatchAll();
      Debug.Log($"[{HarmonyId}] Harmony patches applied successfully!");
    }
  }
}