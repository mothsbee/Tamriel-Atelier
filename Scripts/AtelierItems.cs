using UnityEngine;
using DaggerfallWorkshop.Game.Formulas;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Game.Entity;
using DaggerfallWorkshop.Game;

namespace AtelierItems
{
    //mens clothing
    public class AtelierM001 : DaggerfallUnityItem
    {
        public const int templateIndex = 11000;
        public const int textureArchive = 20210;
        public const int textureRecord = 0;

        public class ItemGroup : AtelierItemGroups
        {
            atelierItemGroup = 2;
            atelierIsMerch = true;
            atelierIsLoot = true;
        }

        public AtelierM001() : base(ItemGroups.MensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
        }
        public override int InventoryTextureRecord
        {
            get { return textureRecord + CurrentVariant;} // returns record + variant (so 20210_0-0_Blue for example) 
        }
        public override EquipSlots GetEquipSlot()
        {
            return EquipSlots.ChestClothes; // notates clothes type
        }
        public override bool UseItem(ItemCollection collection)
        {
            //When used, the item will turn to the next variant if available

            if (ItemTemplate.variants <= 1)
                return false;

            int variant = CurrentVariant + 1;

            if (variant >= ItemTemplate.variants)
                CurrentVariant = 0;
            else
                CurrentVariant = variant;

            //update the paperdoll after changing the variant
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

            return true;
        }
        public override ItemData_v1 GetSaveData()
        {
            ItemData_v1 data = base.GetSaveData();
            data.className = typeof(AtelierM001).ToString();
            return data;
        }

    }
    
}