// Project:         Tamriel Atelier
// License:         MIT

using DaggerfallWorkshop;
using DaggerfallWorkshop.Game;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;
using UnityEngine;

namespace AtelierItems
{
    //womens clothing
    public class AtelierF001 : DaggerfallUnityItem
    {
        public new const int TemplateIndex = 20000;
        //20200;
        public const int TextureRecord = 0;

        public AtelierF001() : base(ItemGroups.WomensClothing, TemplateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return TemplateIndex; }
        }
        public override int InventoryTextureRecord
        {
            get
            {
                if (dyeColor == DyeColors.SilverOrElven)
                {
                    dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                    CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                }

                return 0 + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
            }
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

            CurrentVariant = variant >= ItemTemplate.variants ? 0 : variant;

            //update the paperdoll after changing the variant
            DaggerfallUI.Instance.InventoryWindow.Refresh();

            return true;
        }
        public override ItemData_v1 GetSaveData()
        {
            ItemData_v1 data = base.GetSaveData();
            data.className = typeof(AtelierF001).ToString();
            return data;
        }

    }
    public class AtelierF002 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20001;
             //20200;
             public const int TextureRecord = 2;

             public AtelierF002() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF002).ToString();
                 return data;
             }

         }
    public class AtelierF003 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20002;
             //20200;
             public const int TextureRecord = 4;

             public AtelierF003() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF003).ToString();
                 return data;
             }

         }
    public class AtelierF004 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20003;
             //20200;
             public const int TextureRecord = 8;

             public AtelierF004() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF004).ToString();
                 return data;
             }

         }
    public class AtelierF005 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20004;
             //20200;
             public const int TextureRecord = 10;

             public AtelierF005() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF005).ToString();
                 return data;
             }

         }
    public class AtelierF006 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20005;
             //20200;
             public const int TextureRecord = 12;

             public AtelierF006() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF006).ToString();
                 return data;
             }

         }
    public class AtelierF007 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20006;
             //20200;
             public const int TextureRecord = 13;

             public AtelierF007() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF007).ToString();
                 return data;
             }

         }
    public class AtelierF008 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20007;
             //20200;
             public const int TextureRecord = 14;

             public AtelierF008() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF008).ToString();
                 return data;
             }

         }
    public class AtelierF009 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20008;
             //20200;
             public const int TextureRecord = 15;

             public AtelierF009() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF009).ToString();
                 return data;
             }

         }
    public class AtelierF010 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20009;
             //20200;
             public const int TextureRecord = 16;

             public AtelierF010() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF010).ToString();
                 return data;
             }

         }
    public class AtelierF011 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20010;
             //20200;
             public const int TextureRecord = 17;

             public AtelierF011() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF011).ToString();
                 return data;
             }

         }
         public class AtelierF012 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20011;
             //20200;
             public const int TextureRecord = 18;

             public AtelierF012() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF012).ToString();
                 return data;
             }

         }
         public class AtelierF013 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20012;
             //20200;
             public const int TextureRecord = 21;

             public AtelierF013() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF013).ToString();
                 return data;
             }

         }
         public class AtelierF014 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20013;
             //20200;
             public const int TextureRecord = 24;

             public AtelierF014() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF014).ToString();
                 return data;
             }

         }
         public class AtelierF015 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20014;
             //20200;
             public const int TextureRecord = 27;

             public AtelierF015() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF015).ToString();
                 return data;
             }

         }
         public class AtelierF016 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20015;
             //20200;
             public const int TextureRecord = 30;

             public AtelierF016() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF016).ToString();
                 return data;
             }

         }
         public class AtelierF017 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20016;
             //20200;
             public const int TextureRecord = 33;

             public AtelierF017() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF017).ToString();
                 return data;
             }

         }
         public class AtelierF018 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20017;
             //20200;
             public const int TextureRecord = 36;

             public AtelierF018() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF018).ToString();
                 return data;
             }

         }
         public class AtelierF019 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20018;
             //20200;
             public const int TextureRecord = 39;

             public AtelierF019() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF019).ToString();
                 return data;
             }

         }
         public class AtelierF020 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20019;
             //20200;
             public const int TextureRecord = 42;

             public AtelierF020() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF020).ToString();
                 return data;
             }

         }
         public class AtelierF021 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20020;
             //20200;
             public const int TextureRecord = 45;

             public AtelierF021() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF021).ToString();
                 return data;
             }

         }
         public class AtelierF022 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20021;
             //20200;
             public const int TextureRecord = 49;

             public AtelierF022() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF022).ToString();
                 return data;
             }

         }
         public class AtelierF023 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20022;
             //20200;
             public const int TextureRecord = 51;

             public AtelierF023() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF023).ToString();
                 return data;
             }

         }
         public class AtelierF024 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20023;
             //20200;
             public const int TextureRecord = 53;

             public AtelierF024() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF024).ToString();
                 return data;
             }

         }
         public class AtelierF025 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20024;
             //20200;
             public const int TextureRecord = 54;

             public AtelierF025() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF025).ToString();
                 return data;
             }

         }
         public class AtelierF026 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20025;
             //20200;
             public const int TextureRecord = 55;

             public AtelierF026() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF026).ToString();
                 return data;
             }

         }
         public class AtelierF027 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20026;
             //20200;
             public const int TextureRecord = 59;

             public AtelierF027() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF027).ToString();
                 return data;
             }

         }
         public class AtelierF028 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20027;
             //20200;
             public const int TextureRecord = 61;

             public AtelierF028() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF028).ToString();
                 return data;
             }

         }
         public class AtelierF029 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20028;
             //20200;
             public const int TextureRecord = 62;

             public AtelierF029() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF029).ToString();
                 return data;
             }

         }
         public class AtelierF030 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20029;
             //20200;
             public const int TextureRecord = 63;

             public AtelierF030() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF030).ToString();
                 return data;
             }

         }
         public class AtelierF031 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20030;
             //20200;
             public const int TextureRecord = 66;

             public AtelierF031() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF031).ToString();
                 return data;
             }

         }
         public class AtelierF032 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20031;
             //20200;
             public const int TextureRecord = 70;

             public AtelierF032() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF032).ToString();
                 return data;
             }

         }
         public class AtelierF033 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20032;
             //20200;
             public const int TextureRecord = 73;

             public AtelierF033() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF033).ToString();
                 return data;
             }

         }
         public class AtelierF034 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20033;
             //20200;
             public const int TextureRecord = 76;

             public AtelierF034() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF034).ToString();
                 return data;
             }

         }
         public class AtelierF035 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20034;
             //20200;
             public const int TextureRecord = 80;

             public AtelierF035() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF035).ToString();
                 return data;
             }

         }
         public class AtelierF036 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20035;
             //20200;
             public const int TextureRecord = 83;

             public AtelierF036() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF036).ToString();
                 return data;
             }

         }
         public class AtelierF037 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20036;
             //20200;
             public const int TextureRecord = 86;

             public AtelierF037() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF037).ToString();
                 return data;
             }

         }
         public class AtelierF038 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20037;
             //20200;
             public const int TextureRecord = 88;

             public AtelierF038() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF038).ToString();
                 return data;
             }

         }
         public class AtelierF039 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20038;
             //20200;
             public const int TextureRecord = 89;

             public AtelierF039() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF039).ToString();
                 return data;
             }

         }
         public class AtelierF040 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20039;
             //20201;
             public const int TextureRecord = 0;

             public AtelierF040() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
                 }
             }
             public override EquipSlots GetEquipSlot()
             {
                 return EquipSlots.LegsClothes; // notates clothes type
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF040).ToString();
                 return data;
             }

         }
         public class AtelierF041 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20040;
             //20201;
             public const int TextureRecord = 20;

             public AtelierF041() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
                 }
             }
             public override EquipSlots GetEquipSlot()
             {
                 return EquipSlots.LegsClothes; // notates clothes type
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF041).ToString();
                 return data;
             }

         }
         public class AtelierF042 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20041;
             //20201;
             public const int TextureRecord = 24;

             public AtelierF042() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
                 }
             }
             public override EquipSlots GetEquipSlot()
             {
                 return EquipSlots.LegsClothes; // notates clothes type
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF042).ToString();
                 return data;
             }

         }
         public class AtelierF043 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20042;
             //20201;
             public const int TextureRecord = 40;

             public AtelierF043() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
                 }
             }
             public override EquipSlots GetEquipSlot()
             {
                 return EquipSlots.LegsClothes; // notates clothes type
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF043).ToString();
                 return data;
             }

         }
         public class AtelierF044 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20043;
             //20201;
             public const int TextureRecord = 56;

             public AtelierF044() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
                 }
             }
             public override EquipSlots GetEquipSlot()
             {
                 return EquipSlots.LegsClothes; // notates clothes type
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF044).ToString();
                 return data;
             }

         }
         public class AtelierF045 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20044;
             //20202;
             public const int TextureRecord = 0;

             public AtelierF045() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
                 }
             }
             public override EquipSlots GetEquipSlot()
             {
                 return EquipSlots.Feet; // notates clothes type
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF045).ToString();
                 return data;
             }

         }
         public class AtelierF046 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20045;
             //20202;
             public const int TextureRecord = 1;

             public AtelierF046() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
                 }
             }
             public override EquipSlots GetEquipSlot()
             {
                 return EquipSlots.Feet; // notates clothes type
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF046).ToString();
                 return data;
             }

         }
         public class AtelierF047 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20046;
             //20202;
             public const int TextureRecord = 2;

             public AtelierF047() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
                 }
             }
             public override EquipSlots GetEquipSlot()
             {
                 return EquipSlots.Feet; // notates clothes type
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF047).ToString();
                 return data;
             }

         }
         public class AtelierF048 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20047;
             //20202;
             public const int TextureRecord = 3;

             public AtelierF048() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
                 }
             }
             public override EquipSlots GetEquipSlot()
             {
                 return EquipSlots.Feet; // notates clothes type
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF048).ToString();
                 return data;
             }

         }
         public class AtelierF049 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20048;
             //20204;
             public const int TextureRecord = 0;

             public AtelierF049() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
             }
             public override EquipSlots GetEquipSlot()
             {
                 return EquipSlots.Unknown1; // notates clothes type
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF049).ToString();
                 return data;
             }
         }
         public class AtelierF050 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20049;
             //20204;
             public const int TextureRecord = 8;

             public AtelierF050() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
             }
             public override EquipSlots GetEquipSlot()
             {
                 return EquipSlots.Unknown1; // notates clothes type
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF050).ToString();
                 return data;
             }
         }
         public class AtelierF051 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20050;
             //20204;
             public const int TextureRecord = 9;

             public AtelierF051() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
             }
             public override EquipSlots GetEquipSlot()
             {
                 return EquipSlots.Unknown1; // notates clothes type
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF051).ToString();
                 return data;
             }
         }
         public class AtelierF052 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20051;
             //20204;
             public const int TextureRecord = 10;

             public AtelierF052() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
             }
             public override EquipSlots GetEquipSlot()
             {
                 return EquipSlots.Unknown1; // notates clothes type
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF052).ToString();
                 return data;
             }
         }
         public class AtelierF053 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20052;
             //20204;
             public const int TextureRecord = 11;

             public AtelierF053() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
             }
             public override EquipSlots GetEquipSlot()
             {
                 return EquipSlots.Unknown1; // notates clothes type
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF053).ToString();
                 return data;
             }
         }
         public class AtelierF054 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20053;
             //20204;
             public const int TextureRecord = 12;

             public AtelierF054() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
             }
             public override EquipSlots GetEquipSlot()
             {
                 return EquipSlots.Unknown1; // notates clothes type
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF054).ToString();
                 return data;
             }
         }
         public class AtelierF055 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20054;
             //20204;
             public const int TextureRecord = 3;

             public AtelierF055() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
             }
             public override EquipSlots GetEquipSlot()
             {
                 return EquipSlots.Unknown1; // notates clothes type
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF055).ToString();
                 return data;
             }
         }
         public class AtelierF056 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20055;
             //20204;
             public const int TextureRecord = 6;

             public AtelierF056() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
             }
             public override EquipSlots GetEquipSlot()
             {
                 return EquipSlots.Unknown1; // notates clothes type
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF056).ToString();
                 return data;
             }
         }
         public class AtelierF057 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20056;
             //20203;
             public const int TextureRecord = 3;

             public AtelierF057() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
             }
             public override EquipSlots GetEquipSlot()
             {
                 return EquipSlots.Unknown1; // notates clothes type
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF057).ToString();
                 return data;
             }
         }
         public class AtelierF058 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20057;
             //20203;
             public const int TextureRecord = 4;

             public AtelierF058() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
             }
             public override EquipSlots GetEquipSlot()
             {
                 return EquipSlots.Unknown2; // notates clothes type
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF058).ToString();
                 return data;
             }
         }
         public class AtelierF059 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20058;
             //20200;
             public const int TextureRecord = 90;

             public AtelierF059() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF059).ToString();
                 return data;
             }
         }
         public class AtelierF060 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20059;
             //20200;
             public const int TextureRecord = 91;

             public AtelierF060() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF060).ToString();
                 return data;
             }
         }
         public class AtelierF061 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20060;
             //20200;
             public const int TextureRecord = 94;

             public AtelierF061() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF061).ToString();
                 return data;
             }
         }
         public class AtelierF062 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20061;
             //20200;
             public const int TextureRecord = 101;

             public AtelierF062() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF062).ToString();
                 return data;
             }
         }
         public class AtelierF063 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20062;
             //20200;
             public const int TextureRecord = 106;

             public AtelierF063() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF063).ToString();
                 return data;
             }
         }
         public class AtelierF064 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20063;
             //20200;
             public const int TextureRecord = 111;

             public AtelierF064() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF064).ToString();
                 return data;
             }
         }
         public class AtelierF065 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20064;
             //20200;
             public const int TextureRecord = 116;

             public AtelierF065() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF065).ToString();
                 return data;
             }
         }
         public class AtelierF066 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20065;
             //20200;
             public const int TextureRecord = 118;

             public AtelierF066() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF066).ToString();
                 return data;
             }
         }
         public class AtelierF067 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20066;
             //20200;
             public const int TextureRecord = 120;

             public AtelierF067() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF067).ToString();
                 return data;
             }
         }
         public class AtelierF068 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20067;
             //20200;
             public const int TextureRecord = 122;

             public AtelierF068() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF068).ToString();
                 return data;
             }
         }
         public class AtelierF069 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20068;
             //20200;
             public const int TextureRecord = 123;

             public AtelierF069() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF069).ToString();
                 return data;
             }
         }
         public class AtelierF070 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20069;
             //20200;
             public const int TextureRecord = 124;

             public AtelierF070() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF070).ToString();
                 return data;
             }
         }
         public class AtelierF071 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20070;
             //20200;
             public const int TextureRecord = 125;

             public AtelierF071() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF071).ToString();
                 return data;
             }
         }
         public class AtelierF072 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20071;
             //20200;
             public const int TextureRecord = 127;

             public AtelierF072() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF072).ToString();
                 return data;
             }
         }

         public class AtelierF073 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20072;
             //20200;
             public const int TextureRecord = 127;

             public AtelierF073() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF073).ToString();
                 return data;
             }
         }
         public class AtelierF074 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20073;
             //20201;
             public const int TextureRecord = 5;

             public AtelierF074() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF074).ToString();
                 return data;
             }
         }
public class AtelierF075 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20074;
             //20201;
             public const int TextureRecord = 5;

             public AtelierF075() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
             }
             public override EquipSlots GetEquipSlot()
             {
                 return EquipSlots.LegsClothes; // notates clothes type
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF075).ToString();
                 return data;
             }
         }
         public class AtelierF076 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20075;
             //20201;
             public const int TextureRecord = 5;

             public AtelierF076() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
             }
             public override EquipSlots GetEquipSlot()
             {
                 return EquipSlots.LegsClothes; // notates clothes type
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF076).ToString();
                 return data;
             }
         }
         public class AtelierF077 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20076;
             //20201;
             public const int TextureRecord = 8;

             public AtelierF077() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
             }
             public override EquipSlots GetEquipSlot()
             {
                 return EquipSlots.LegsClothes; // notates clothes type
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF077).ToString();
                 return data;
             }
         }
         public class AtelierF078 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20077;
             //20201;
             public const int TextureRecord = 11;

             public AtelierF078() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
             }
             public override EquipSlots GetEquipSlot()
             {
                 return EquipSlots.LegsClothes; // notates clothes type
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF078).ToString();
                 return data;
             }
         }
         public class AtelierF079 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20078;
             //20201;
             public const int TextureRecord = 14;

             public AtelierF079() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
             }
             public override EquipSlots GetEquipSlot()
             {
                 return EquipSlots.LegsClothes; // notates clothes type
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF079).ToString();
                 return data;
             }
         }
         public class AtelierF080 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20079;
             //20202;
             public const int TextureRecord = 4;

             public AtelierF080() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
             }
             public override EquipSlots GetEquipSlot()
             {
                 return EquipSlots.Feet; // notates clothes type
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF080).ToString();
                 return data;
             }
         }
         public class AtelierF081 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20080;
             //20202;
             public const int TextureRecord = 5;

             public AtelierF081() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
             }
             public override EquipSlots GetEquipSlot()
             {
                 return EquipSlots.Feet; // notates clothes type
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF081).ToString();
                 return data;
             }
         }
         public class AtelierF082 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20081;
             //20202;
             public const int TextureRecord = 6;

             public AtelierF082() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
             }
             public override EquipSlots GetEquipSlot()
             {
                 return EquipSlots.Feet; // notates clothes type
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF082).ToString();
                 return data;
             }
         }
         public class AtelierF083 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20082;
             //20202;
             public const int TextureRecord = 7;

             public AtelierF083() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
             }
             public override EquipSlots GetEquipSlot()
             {
                 return EquipSlots.Feet; // notates clothes type
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF083).ToString();
                 return data;
             }
         }
         public class AtelierF084 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20083;
             //20202;
             public const int TextureRecord = 8;

             public AtelierF084() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
             }
             public override EquipSlots GetEquipSlot()
             {
                 return EquipSlots.Feet; // notates clothes type
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF084).ToString();
                 return data;
             }
         }
         public class AtelierF085 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20084;
             //20203;
             public const int TextureRecord = 0;

             public AtelierF085() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
             }
             public override EquipSlots GetEquipSlot()
             {
                 return EquipSlots.Unknown2; // notates clothes type
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF085).ToString();
                 return data;
             }
         }
         public class AtelierF086 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20085;
             //20203;
             public const int TextureRecord = 1;

             public AtelierF086() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
             }
             public override EquipSlots GetEquipSlot()
             {
                 return EquipSlots.Unknown2; // notates clothes type
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF086).ToString();
                 return data;
             }
         }
         public class AtelierF087 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20086;
             //20203;
             public const int TextureRecord = 2;

             public AtelierF087() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
             }
             public override EquipSlots GetEquipSlot()
             {
                 return EquipSlots.Unknown2; // notates clothes type
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF087).ToString();
                 return data;
             }
         }
         public class AtelierF088 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20087;
             //20203;
             public const int TextureRecord = 5;

             public AtelierF088() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
             }
             public override EquipSlots GetEquipSlot()
             {
                 return EquipSlots.Unknown2; // notates clothes type
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF088).ToString();
                 return data;
             }
         }
         public class AtelierF089 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20088;
             //20204;
             public const int TextureRecord = 15;

             public AtelierF089() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
             }
             public override EquipSlots GetEquipSlot()
             {
                 return EquipSlots.Unknown1; // notates clothes type
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF089).ToString();
                 return data;
             }
         }
         public class AtelierF090 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20089;
             //20204;
             public const int TextureRecord = 16;

             public AtelierF090() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
             }
             public override EquipSlots GetEquipSlot()
             {
                 return EquipSlots.Unknown1; // notates clothes type
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF090).ToString();
                 return data;
             }
         }
         public class AtelierF091 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20090;
             //20204;
             public const int TextureRecord = 17;

             public AtelierF091() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
             }
             public override EquipSlots GetEquipSlot()
             {
                 return EquipSlots.Unknown1; // notates clothes type
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF091).ToString();
                 return data;
             }
         }
         public class AtelierF092 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20091;
             //20204;
             public const int TextureRecord = 20;

             public AtelierF092() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
             }
             public override EquipSlots GetEquipSlot()
             {
                 return EquipSlots.Unknown1; // notates clothes type
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF092).ToString();
                 return data;
             }
         }
         public class AtelierF093 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20092;
             //20204;
             public const int TextureRecord = 25;

             public AtelierF093() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
             }
             public override EquipSlots GetEquipSlot()
             {
                 return EquipSlots.Unknown1; // notates clothes type
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF093).ToString();
                 return data;
             }
         }
         public class AtelierF094 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20093;
             //20204;
             public const int TextureRecord = 26;

             public AtelierF094() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
             }
             public override EquipSlots GetEquipSlot()
             {
                 return EquipSlots.Unknown1; // notates clothes type
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF094).ToString();
                 return data;
             }
         }
         public class AtelierF095 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20094;
             //20205;
             public const int TextureRecord = 0;

             public AtelierF095() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
             }
             public override EquipSlots GetEquipSlot()
             {
                 return EquipSlots.Gloves; // notates clothes type
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF095).ToString();
                 return data;
             }
         }
         public class AtelierF096 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20095;
             //20205;
             public const int TextureRecord = 1;

             public AtelierF096() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
             }
             public override EquipSlots GetEquipSlot()
             {
                 return EquipSlots.Gloves; // notates clothes type
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF096).ToString();
                 return data;
             }
         }
         public class AtelierF097 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20096;
             //20205;
             public const int TextureRecord = 3;

             public AtelierF097() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
             }
             public override EquipSlots GetEquipSlot()
             {
                 return EquipSlots.Gloves; // notates clothes type
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF097).ToString();
                 return data;
             }
         }
         public class AtelierF098 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20097;
             //20205;
             public const int TextureRecord = 4;

             public AtelierF098() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
             }
             public override EquipSlots GetEquipSlot()
             {
                 return EquipSlots.Gloves; // notates clothes type
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF098).ToString();
                 return data;
             }
         }
         public class AtelierF099 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20098;
             //20205;
             public const int TextureRecord = 5;

             public AtelierF099() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
             }
             public override EquipSlots GetEquipSlot()
             {
                 return EquipSlots.Gloves; // notates clothes type
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF099).ToString();
                 return data;
             }
         }
         public class AtelierF100 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20099;
             //20205;
             public const int TextureRecord = 6;

             public AtelierF100() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
             }
             public override EquipSlots GetEquipSlot()
             {
                 return EquipSlots.Gloves; // notates clothes type
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF100).ToString();
                 return data;
             }
         }
         public class AtelierF101 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20100;
             //20205;
             public const int TextureRecord = 7;

             public AtelierF101() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
             }
             public override EquipSlots GetEquipSlot()
             {
                 return EquipSlots.Gloves; // notates clothes type
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF101).ToString();
                 return data;
             }
         }
         public class AtelierF102 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 20101;
             public const int TextureRecord = 8;

             public AtelierF102() : base(ItemGroups.WomensClothing, TemplateIndex)
             {
             }
             public override int InventoryTextureArchive
             {
                 get { return TemplateIndex; }
             }
             public override int InventoryTextureRecord
             {
                 get
                 {
                     if (dyeColor == DyeColors.SilverOrElven)
                     {
                         dyeColor = ItemBuilder.RandomClothingDye(); // randomizes dye upon initialization
                         CurrentVariant = Random.Range(0, ItemTemplate.variants); // randomizes variants, if applicable
                     }

                     return 0 + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
                 }
             }
             public override EquipSlots GetEquipSlot()
             {
                 return EquipSlots.Gloves; // notates clothes type
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
                 DaggerfallUI.Instance.InventoryWindow.Refresh();

                 return true;
             }
             public override ItemData_v1 GetSaveData()
             {
                 ItemData_v1 data = base.GetSaveData();
                 data.className = typeof(AtelierF102).ToString();
                 return data;
             }
         }

}