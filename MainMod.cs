using VRC.Modding;

[assembly: VRCModInfo("Mod Template", "1.0.0", "YouTubey")]

namespace OSCLoaderModTemplate
{
    // VRCModInfo and VRCMod are required to have your mod be picked up. Only one can exist in an assembly.
    public class MainMod : VRCMod
    {
        // This will run once the mod has loaded. Typing "public override" will allow you to see all OSCLoader callbacks.
        public override void OnModStart()
        {
            Log("Mod has loaded.");
        }
    }
}
