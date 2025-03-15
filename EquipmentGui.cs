using Jotunn.Managers;
using Jotunn.Utils;
using UnityEngine;

namespace UIOverhaul
{
    public class EquipmentGui : MonoBehaviour
    {
        private Inventory inventory;

        private static EquipmentGui instance;

        public static EquipmentGui Instance
        {
            get => instance;
            private set => instance = value;
        }

        public void Awake()
        {
            Instance = this;
            inventory = new Inventory("equipment", null, 0, 0);
        }

        public static void Load()
        {
            // Load the AssetBundle
            var embeddedResourceBundle = AssetUtils.LoadAssetBundleFromResources("equipmentgui");
            var equipmentGuiPrefab = embeddedResourceBundle.LoadAsset<GameObject>("equipmentgui");
            PrefabManager.Instance.AddPrefab(equipmentGuiPrefab);
        }

        public Inventory GetInventory()
        {
            return inventory;
        }
    }
}
