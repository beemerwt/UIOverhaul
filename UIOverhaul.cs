using BepInEx;
using BepInEx.Logging;
using Jotunn.Managers;

namespace UIOverhaul
{
    [BepInDependency(Jotunn.Main.ModGuid)]
    [BepInPlugin(UIOverhaulGuid, UIOverhaulName, UIOverhaulVersion)]
    public class UIOverhaul : BaseUnityPlugin
    {

        public const string UIOverhaulGuid = "com.github.beemerwt.uioverhaul";
        public const string UIOverhaulName = "UIOverhaul";
        public const string UIOverhaulDesc = "Much needed QOL changes for the default Valheim UI";
        public const string UIOverhaulVersion = "1.0.0";

        public static new ManualLogSource Logger;

        private void Awake()
        {
            // Plugin startup logic
            Logger = base.Logger;
            Logger.LogInfo($"Plugin {UIOverhaulGuid} is loaded!");

            PrefabManager.OnVanillaPrefabsAvailable += EquipmentGui.Load;
        }
    }
}
