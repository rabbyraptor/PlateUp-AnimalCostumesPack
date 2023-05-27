using Kitchen;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace KitchenAnimalPack.Outfits
{
    public class SharkOutfit : CustomPlayerCosmetic
    {
        public override string UniqueNameID => "sharkoutfit";
        public override CosmeticType CosmeticType => CosmeticType.Outfit;
        public override GameObject Visual => Mod.Bundle.LoadAsset<GameObject>("Shark");

        public override void OnRegister(GameDataObject gameDataObject)
        {
            GameObject Prefab = ((PlayerCosmetic)gameDataObject).Visual;

            PlayerOutfitComponent playerOutfitComponent = Prefab.AddComponent<PlayerOutfitComponent>();
            playerOutfitComponent.Renderers.Add(GameObjectUtils.GetChildObject(Prefab, "Shark Costume").GetComponent<SkinnedMeshRenderer>());

            MaterialUtils.ApplyMaterial<SkinnedMeshRenderer>(Prefab, "Shark Costume", new Material[] {
                MaterialUtils.GetExistingMaterial("Clothing White"),
                MaterialUtils.GetExistingMaterial("Raw Fish Blue Fin")
            });
        }
    }
}