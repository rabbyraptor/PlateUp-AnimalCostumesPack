using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace KitchenAnimalPack.Outfits
{
    public class CockatielOutfit : CustomPlayerCosmetic
    {
        public override string UniqueNameID => "cockatieloutfit";
        public override CosmeticType CosmeticType => CosmeticType.Outfit;
        public override GameObject Visual => Mod.Bundle.LoadAsset<GameObject>("Cockatiel");

        public override void OnRegister(GameDataObject gameDataObject)
        {
            GameObject Prefab = ((PlayerCosmetic)gameDataObject).Visual;

            PlayerOutfitComponent playerOutfitComponent = Prefab.AddComponent<PlayerOutfitComponent>();
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(Prefab, "Cockatiel Costume").GetComponent<SkinnedMeshRenderer>());

            MaterialUtils.ApplyMaterial<SkinnedMeshRenderer>(Prefab, "Cockatiel Costume", new Material[] {
                MaterialUtils.GetExistingMaterial("Plastic - Grey"),
                MaterialUtils.GetExistingMaterial("Clothing Red"),
                MaterialUtils.GetExistingMaterial("Clothing - Yellow"),
                MaterialUtils.GetExistingMaterial("Plastic - Dark Grey")
            });
        }
    }
}