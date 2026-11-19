// Project:         Tamriel Atelier
// License:         MIT

using DaggerfallWorkshop;
using DaggerfallWorkshop.Game;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Serialization;
using UnityEngine;

namespace AtelierItems
{
    //Mens clothing
    public class AtelierM001 : DaggerfallUnityItem
    {
        public new const int TemplateIndex = 21000;
        //20200;
        public const int TextureRecord = 0;

        public AtelierM001() : base(ItemGroups.MensClothing, TemplateIndex)
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
            data.className = typeof(AtelierM001).ToString();
            return data;
        }

    }
    public class AtelierM002 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21001;
             //20200;
             public const int TextureRecord = 2;

             public AtelierM002() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM002).ToString();
                 return data;
             }

         }
    public class AtelierM003 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21002;
             //20200;
             public const int TextureRecord = 4;

             public AtelierM003() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM003).ToString();
                 return data;
             }

         }
    public class AtelierM004 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21003;
             //20200;
             public const int TextureRecord = 8;

             public AtelierM004() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM004).ToString();
                 return data;
             }

         }
    public class AtelierM005 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21004;
             //20200;
             public const int TextureRecord = 10;

             public AtelierM005() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM005).ToString();
                 return data;
             }

         }
    public class AtelierM006 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21005;
             //20200;
             public const int TextureRecord = 12;

             public AtelierM006() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM006).ToString();
                 return data;
             }

         }
    public class AtelierM007 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21006;
             //20200;
             public const int TextureRecord = 13;

             public AtelierM007() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM007).ToString();
                 return data;
             }

         }
    public class AtelierM008 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21007;
             //20200;
             public const int TextureRecord = 14;

             public AtelierM008() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM008).ToString();
                 return data;
             }

         }
    public class AtelierM009 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21008;
             //20200;
             public const int TextureRecord = 15;

             public AtelierM009() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM009).ToString();
                 return data;
             }

         }
    public class AtelierM010 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21009;
             //20200;
             public const int TextureRecord = 16;

             public AtelierM010() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM010).ToString();
                 return data;
             }

         }
    public class AtelierM011 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21010;
             //20200;
             public const int TextureRecord = 17;

             public AtelierM011() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM011).ToString();
                 return data;
             }

         }
         public class AtelierM012 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21011;
             //20200;
             public const int TextureRecord = 18;

             public AtelierM012() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM012).ToString();
                 return data;
             }

         }
         public class AtelierM013 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21012;
             //20200;
             public const int TextureRecord = 21;

             public AtelierM013() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM013).ToString();
                 return data;
             }

         }
         public class AtelierM014 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21013;
             //20200;
             public const int TextureRecord = 24;

             public AtelierM014() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM014).ToString();
                 return data;
             }

         }
         public class AtelierM015 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21014;
             //20200;
             public const int TextureRecord = 27;

             public AtelierM015() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM015).ToString();
                 return data;
             }

         }
         public class AtelierM016 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21015;
             //20200;
             public const int TextureRecord = 30;

             public AtelierM016() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM016).ToString();
                 return data;
             }

         }
         public class AtelierM017 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21016;
             //20200;
             public const int TextureRecord = 33;

             public AtelierM017() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM017).ToString();
                 return data;
             }

         }
         public class AtelierM018 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21017;
             //20200;
             public const int TextureRecord = 36;

             public AtelierM018() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM018).ToString();
                 return data;
             }

         }
         public class AtelierM019 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21018;
             //20200;
             public const int TextureRecord = 39;

             public AtelierM019() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM019).ToString();
                 return data;
             }

         }
         public class AtelierM020 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21019;
             //20200;
             public const int TextureRecord = 42;

             public AtelierM020() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM020).ToString();
                 return data;
             }

         }
         public class AtelierM021 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21020;
             //20200;
             public const int TextureRecord = 45;

             public AtelierM021() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM021).ToString();
                 return data;
             }

         }
         public class AtelierM022 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21021;
             //20200;
             public const int TextureRecord = 49;

             public AtelierM022() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM022).ToString();
                 return data;
             }

         }
         public class AtelierM023 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21022;
             //20200;
             public const int TextureRecord = 51;

             public AtelierM023() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM023).ToString();
                 return data;
             }

         }
         public class AtelierM024 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21023;
             //20200;
             public const int TextureRecord = 53;

             public AtelierM024() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM024).ToString();
                 return data;
             }

         }
         public class AtelierM025 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21024;
             //20200;
             public const int TextureRecord = 54;

             public AtelierM025() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM025).ToString();
                 return data;
             }

         }
         public class AtelierM026 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21025;
             //20200;
             public const int TextureRecord = 55;

             public AtelierM026() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM026).ToString();
                 return data;
             }

         }
         public class AtelierM027 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21026;
             //20200;
             public const int TextureRecord = 59;

             public AtelierM027() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM027).ToString();
                 return data;
             }

         }
         public class AtelierM028 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21027;
             //20200;
             public const int TextureRecord = 61;

             public AtelierM028() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM028).ToString();
                 return data;
             }

         }
         public class AtelierM029 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21028;
             //20200;
             public const int TextureRecord = 62;

             public AtelierM029() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM029).ToString();
                 return data;
             }

         }
         public class AtelierM030 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21029;
             //20200;
             public const int TextureRecord = 63;

             public AtelierM030() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM030).ToString();
                 return data;
             }

         }
         public class AtelierM031 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21030;
             //20200;
             public const int TextureRecord = 66;

             public AtelierM031() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM031).ToString();
                 return data;
             }

         }
         public class AtelierM032 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21031;
             //20200;
             public const int TextureRecord = 70;

             public AtelierM032() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM032).ToString();
                 return data;
             }

         }
         public class AtelierM033 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21032;
             //20200;
             public const int TextureRecord = 73;

             public AtelierM033() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM033).ToString();
                 return data;
             }

         }
         public class AtelierM034 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21033;
             //20200;
             public const int TextureRecord = 76;

             public AtelierM034() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM034).ToString();
                 return data;
             }

         }
         public class AtelierM035 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21034;
             //20200;
             public const int TextureRecord = 80;

             public AtelierM035() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM035).ToString();
                 return data;
             }

         }
         public class AtelierM036 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21035;
             //20200;
             public const int TextureRecord = 83;

             public AtelierM036() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM036).ToString();
                 return data;
             }

         }
         public class AtelierM037 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21036;
             //20200;
             public const int TextureRecord = 86;

             public AtelierM037() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM037).ToString();
                 return data;
             }

         }
         public class AtelierM038 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21037;
             //20200;
             public const int TextureRecord = 88;

             public AtelierM038() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM038).ToString();
                 return data;
             }

         }
         public class AtelierM039 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21038;
             //20200;
             public const int TextureRecord = 89;

             public AtelierM039() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM039).ToString();
                 return data;
             }

         }
         public class AtelierM040 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21039;
             //20201;
             public const int TextureRecord = 0;

             public AtelierM040() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM040).ToString();
                 return data;
             }

         }
         public class AtelierM041 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21040;
             //20201;
             public const int TextureRecord = 20;

             public AtelierM041() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM041).ToString();
                 return data;
             }

         }
         public class AtelierM042 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21041;
             //20201;
             public const int TextureRecord = 24;

             public AtelierM042() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM042).ToString();
                 return data;
             }

         }
         public class AtelierM043 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21042;
             //20201;
             public const int TextureRecord = 40;

             public AtelierM043() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM043).ToString();
                 return data;
             }

         }
         public class AtelierM044 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21043;
             //20201;
             public const int TextureRecord = 56;

             public AtelierM044() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM044).ToString();
                 return data;
             }

         }
         public class AtelierM045 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21044;
             //20202;
             public const int TextureRecord = 0;

             public AtelierM045() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM045).ToString();
                 return data;
             }

         }
         public class AtelierM046 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21045;
             //20202;
             public const int TextureRecord = 1;

             public AtelierM046() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM046).ToString();
                 return data;
             }

         }
         public class AtelierM047 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21046;
             //20202;
             public const int TextureRecord = 2;

             public AtelierM047() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM047).ToString();
                 return data;
             }

         }
         public class AtelierM048 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21047;
             //20202;
             public const int TextureRecord = 3;

             public AtelierM048() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM048).ToString();
                 return data;
             }

         }
         public class AtelierM049 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21048;
             //20204;
             public const int TextureRecord = 0;

             public AtelierM049() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM049).ToString();
                 return data;
             }
         }
         public class AtelierM050 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21049;
             //20204;
             public const int TextureRecord = 8;

             public AtelierM050() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM050).ToString();
                 return data;
             }
         }
         public class AtelierM051 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21050;
             //20204;
             public const int TextureRecord = 9;

             public AtelierM051() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM051).ToString();
                 return data;
             }
         }
         public class AtelierM052 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21051;
             //20204;
             public const int TextureRecord = 10;

             public AtelierM052() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM052).ToString();
                 return data;
             }
         }
         public class AtelierM053 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21052;
             //20204;
             public const int TextureRecord = 11;

             public AtelierM053() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM053).ToString();
                 return data;
             }
         }
         public class AtelierM054 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21053;
             //20204;
             public const int TextureRecord = 12;

             public AtelierM054() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM054).ToString();
                 return data;
             }
         }
         public class AtelierM055 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21054;
             //20204;
             public const int TextureRecord = 3;

             public AtelierM055() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM055).ToString();
                 return data;
             }
         }
         public class AtelierM056 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21055;
             //20204;
             public const int TextureRecord = 6;

             public AtelierM056() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM056).ToString();
                 return data;
             }
         }
         public class AtelierM057 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21056;
             //20203;
             public const int TextureRecord = 3;

             public AtelierM057() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM057).ToString();
                 return data;
             }
         }
         public class AtelierM058 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21057;
             //20203;
             public const int TextureRecord = 4;

             public AtelierM058() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM058).ToString();
                 return data;
             }
         }
         public class AtelierM059 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21058;
             //20200;
             public const int TextureRecord = 90;

             public AtelierM059() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM059).ToString();
                 return data;
             }
         }
         public class AtelierM060 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21059;
             //20200;
             public const int TextureRecord = 91;

             public AtelierM060() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM060).ToString();
                 return data;
             }
         }
         public class AtelierM061 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21060;
             //20200;
             public const int TextureRecord = 94;

             public AtelierM061() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM061).ToString();
                 return data;
             }
         }
         public class AtelierM062 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21061;
             //20200;
             public const int TextureRecord = 101;

             public AtelierM062() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM062).ToString();
                 return data;
             }
         }
         public class AtelierM063 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21062;
             //20200;
             public const int TextureRecord = 106;

             public AtelierM063() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM063).ToString();
                 return data;
             }
         }
         public class AtelierM064 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21063;
             //20200;
             public const int TextureRecord = 111;

             public AtelierM064() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM064).ToString();
                 return data;
             }
         }
         public class AtelierM065 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21064;
             //20200;
             public const int TextureRecord = 116;

             public AtelierM065() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM065).ToString();
                 return data;
             }
         }
         public class AtelierM066 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21065;
             //20200;
             public const int TextureRecord = 118;

             public AtelierM066() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM066).ToString();
                 return data;
             }
         }
         public class AtelierM067 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21066;
             //20200;
             public const int TextureRecord = 120;

             public AtelierM067() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM067).ToString();
                 return data;
             }
         }
         public class AtelierM068 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21067;
             //20200;
             public const int TextureRecord = 122;

             public AtelierM068() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM068).ToString();
                 return data;
             }
         }
         public class AtelierM069 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21068;
             //20200;
             public const int TextureRecord = 123;

             public AtelierM069() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM069).ToString();
                 return data;
             }
         }
         public class AtelierM070 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21069;
             //20200;
             public const int TextureRecord = 124;

             public AtelierM070() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM070).ToString();
                 return data;
             }
         }
         public class AtelierM071 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21070;
             //20200;
             public const int TextureRecord = 125;

             public AtelierM071() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM071).ToString();
                 return data;
             }
         }
         public class AtelierM072 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21071;
             //20200;
             public const int TextureRecord = 127;

             public AtelierM072() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM072).ToString();
                 return data;
             }
         }

         public class AtelierM073 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21072;
             //20200;
             public const int TextureRecord = 127;

             public AtelierM073() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM073).ToString();
                 return data;
             }
         }
         public class AtelierM074 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21073;
             //20201;
             public const int TextureRecord = 5;

             public AtelierM074() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM074).ToString();
                 return data;
             }
         }
public class AtelierM075 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21074;
             //20201;
             public const int TextureRecord = 5;

             public AtelierM075() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM075).ToString();
                 return data;
             }
         }
         public class AtelierM076 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21075;
             //20201;
             public const int TextureRecord = 5;

             public AtelierM076() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM076).ToString();
                 return data;
             }
         }
         public class AtelierM077 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21076;
             //20201;
             public const int TextureRecord = 8;

             public AtelierM077() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM077).ToString();
                 return data;
             }
         }
         public class AtelierM078 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21077;
             //20201;
             public const int TextureRecord = 11;

             public AtelierM078() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM078).ToString();
                 return data;
             }
         }
         public class AtelierM079 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21078;
             //20201;
             public const int TextureRecord = 14;

             public AtelierM079() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM079).ToString();
                 return data;
             }
         }
         public class AtelierM080 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21079;
             //20202;
             public const int TextureRecord = 4;

             public AtelierM080() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM080).ToString();
                 return data;
             }
         }
         public class AtelierM081 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21080;
             //20202;
             public const int TextureRecord = 5;

             public AtelierM081() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM081).ToString();
                 return data;
             }
         }
         public class AtelierM082 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21081;
             //20202;
             public const int TextureRecord = 6;

             public AtelierM082() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM082).ToString();
                 return data;
             }
         }
         public class AtelierM083 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21082;
             //20202;
             public const int TextureRecord = 7;

             public AtelierM083() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM083).ToString();
                 return data;
             }
         }
         public class AtelierM084 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21083;
             //20202;
             public const int TextureRecord = 8;

             public AtelierM084() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM084).ToString();
                 return data;
             }
         }
         public class AtelierM085 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21084;
             //20203;
             public const int TextureRecord = 0;

             public AtelierM085() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM085).ToString();
                 return data;
             }
         }
         public class AtelierM086 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21085;
             //20203;
             public const int TextureRecord = 1;

             public AtelierM086() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM086).ToString();
                 return data;
             }
         }
         public class AtelierM087 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21086;
             //20203;
             public const int TextureRecord = 2;

             public AtelierM087() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM087).ToString();
                 return data;
             }
         }
         public class AtelierM088 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21087;
             //20203;
             public const int TextureRecord = 5;

             public AtelierM088() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM088).ToString();
                 return data;
             }
         }
         public class AtelierM089 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21088;
             //20204;
             public const int TextureRecord = 15;

             public AtelierM089() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM089).ToString();
                 return data;
             }
         }
         public class AtelierM090 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21089;
             //20204;
             public const int TextureRecord = 16;

             public AtelierM090() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM090).ToString();
                 return data;
             }
         }
         public class AtelierM091 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21090;
             //20204;
             public const int TextureRecord = 17;

             public AtelierM091() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM091).ToString();
                 return data;
             }
         }
         public class AtelierM092 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21091;
             //20204;
             public const int TextureRecord = 20;

             public AtelierM092() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM092).ToString();
                 return data;
             }
         }
         public class AtelierM093 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21092;
             //20204;
             public const int TextureRecord = 25;

             public AtelierM093() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM093).ToString();
                 return data;
             }
         }
         public class AtelierM094 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21093;
             //20204;
             public const int TextureRecord = 26;

             public AtelierM094() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM094).ToString();
                 return data;
             }
         }
         public class AtelierM095 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21094;
             //20205;
             public const int TextureRecord = 0;

             public AtelierM095() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM095).ToString();
                 return data;
             }
         }
         public class AtelierM096 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21095;
             //20205;
             public const int TextureRecord = 1;

             public AtelierM096() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM096).ToString();
                 return data;
             }
         }
         public class AtelierM097 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21096;
             //20205;
             public const int TextureRecord = 3;

             public AtelierM097() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM097).ToString();
                 return data;
             }
         }
         public class AtelierM098 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21097;
             //20205;
             public const int TextureRecord = 4;

             public AtelierM098() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM098).ToString();
                 return data;
             }
         }
         public class AtelierM099 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21098;
             //20205;
             public const int TextureRecord = 5;

             public AtelierM099() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM099).ToString();
                 return data;
             }
         }
         public class AtelierM100 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21099;
             //20205;
             public const int TextureRecord = 6;

             public AtelierM100() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM100).ToString();
                 return data;
             }
         }
         public class AtelierM101 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21100;
             //20205;
             public const int TextureRecord = 7;

             public AtelierM101() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM101).ToString();
                 return data;
             }
         }
         public class AtelierM102 : DaggerfallUnityItem
         {
             public new const int TemplateIndex = 21101;
             public const int TextureRecord = 8;

             public AtelierM102() : base(ItemGroups.MensClothing, TemplateIndex)
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
                 data.className = typeof(AtelierM102).ToString();
                 return data;
             }
         }

}