using HarmonyLib;
using Timberborn.CameraSystem;

namespace Calloatti.NoCameraShift
{
  // Intercept the method that shifts the camera and immediately abort it
  [HarmonyPatch(typeof(CameraHorizontalShifter), nameof(CameraHorizontalShifter.EnableHorizontalCameraShift))]
  public static class Patch_CameraHorizontalShifter_Enable
  {
    public static bool Prefix()
    {
      return false; // Skip the original method
    }
  }

  // Intercept the method that resets the camera and immediately abort it
  [HarmonyPatch(typeof(CameraHorizontalShifter), nameof(CameraHorizontalShifter.DisableCameraShift))]
  public static class Patch_CameraHorizontalShifter_Disable
  {
    public static bool Prefix()
    {
      return false; // Skip the original method
    }
  }
}