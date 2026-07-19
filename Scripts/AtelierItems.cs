// Project:         Tamriel Atelier
// License:         MIT

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

        public AtelierM001() : base(ItemGroups.MensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
    public class AtelierM002 : DaggerfallUnityItem
    {
        public const int templateIndex = 11001;
        public const int textureArchive = 20210;
        public const int textureRecord = 2;

        public AtelierM002() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11002;
        public const int textureArchive = 20210;
        public const int textureRecord = 4;

        public AtelierM003() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11003;
        public const int textureArchive = 20210;
        public const int textureRecord = 8;

        public AtelierM004() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11004;
        public const int textureArchive = 20210;
        public const int textureRecord = 10;

        public AtelierM005() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11005;
        public const int textureArchive = 20210;
        public const int textureRecord = 12;

        public AtelierM006() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

            return true;
        }
        public override ItemData_v1 GetSaveData()
        {
            ItemData_v1 data = base.GetSaveData();
            data.className = typeof(AtelierM005).ToString();
            return data;
        }

    }
    public class AtelierM007 : DaggerfallUnityItem
    {
        public const int templateIndex = 11006;
        public const int textureArchive = 20210;
        public const int textureRecord = 13;

        public AtelierM007() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11007;
        public const int textureArchive = 20210;
        public const int textureRecord = 14;

        public AtelierM008() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11008;
        public const int textureArchive = 20210;
        public const int textureRecord = 15;

        public AtelierM009() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11009;
        public const int textureArchive = 20210;
        public const int textureRecord = 16;

        public AtelierM010() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11010;
        public const int textureArchive = 20210;
        public const int textureRecord = 16;

        public AtelierM011() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11011;
        public const int textureArchive = 20210;
        public const int textureRecord = 18;

        public AtelierM012() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11012;
        public const int textureArchive = 20210;
        public const int textureRecord = 21;

        public AtelierM013() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11013;
        public const int textureArchive = 20210;
        public const int textureRecord = 24;

        public AtelierM014() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11014;
        public const int textureArchive = 20210;
        public const int textureRecord = 27;

        public AtelierM015() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11015;
        public const int textureArchive = 20210;
        public const int textureRecord = 30;

        public AtelierM016() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11016;
        public const int textureArchive = 20210;
        public const int textureRecord = 33;

        public AtelierM017() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11017;
        public const int textureArchive = 20210;
        public const int textureRecord = 36;

        public AtelierM018() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11018;
        public const int textureArchive = 20210;
        public const int textureRecord = 39;

        public AtelierM019() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11019;
        public const int textureArchive = 20210;
        public const int textureRecord = 42;

        public AtelierM020() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11020;
        public const int textureArchive = 20210;
        public const int textureRecord = 45;

        public AtelierM021() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11021;
        public const int textureArchive = 20210;
        public const int textureRecord = 49;

        public AtelierM022() : base(ItemGroups.MensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11022;
        public const int textureArchive = 20210;
        public const int textureRecord = 51;

        public AtelierM023() : base(ItemGroups.MensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11023;
        public const int textureArchive = 20210;
        public const int textureRecord = 53;

        public AtelierM024() : base(ItemGroups.MensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11024;
        public const int textureArchive = 20210;
        public const int textureRecord = 54;

        public AtelierM025() : base(ItemGroups.MensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11025;
        public const int textureArchive = 20210;
        public const int textureRecord = 55;

        public AtelierM026() : base(ItemGroups.MensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11026;
        public const int textureArchive = 20210;
        public const int textureRecord = 59;

        public AtelierM027() : base(ItemGroups.MensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11027;
        public const int textureArchive = 20210;
        public const int textureRecord = 61;

        public AtelierM028() : base(ItemGroups.MensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11028;
        public const int textureArchive = 20210;
        public const int textureRecord = 62;

        public AtelierM029() : base(ItemGroups.MensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11029;
        public const int textureArchive = 20210;
        public const int textureRecord = 63;

        public AtelierM030() : base(ItemGroups.MensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11030;
        public const int textureArchive = 20210;
        public const int textureRecord = 66;

        public AtelierM031() : base(ItemGroups.MensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11031;
        public const int textureArchive = 20210;
        public const int textureRecord = 70;

        public AtelierM032() : base(ItemGroups.MensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11032;
        public const int textureArchive = 20210;
        public const int textureRecord = 73;

        public AtelierM033() : base(ItemGroups.MensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11033;
        public const int textureArchive = 20210;
        public const int textureRecord = 76;

        public AtelierM034() : base(ItemGroups.MensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11034;
        public const int textureArchive = 20210;
        public const int textureRecord = 80;

        public AtelierM035() : base(ItemGroups.MensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11035;
        public const int textureArchive = 20210;
        public const int textureRecord = 83;

        public AtelierM036() : base(ItemGroups.MensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11036;
        public const int textureArchive = 20210;
        public const int textureRecord = 86;

        public AtelierM037() : base(ItemGroups.MensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11037;
        public const int textureArchive = 20210;
        public const int textureRecord = 88;

        public AtelierM038() : base(ItemGroups.MensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11038;
        public const int textureArchive = 20210;
        public const int textureRecord = 89;

        public AtelierM039() : base(ItemGroups.MensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11039;
        public const int textureArchive = 20211;
        public const int textureRecord = 0;

        public AtelierM040() : base(ItemGroups.MensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11040;
        public const int textureArchive = 20211;
        public const int textureRecord = 20;

        public AtelierM041() : base(ItemGroups.MensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11041;
        public const int textureArchive = 20211;
        public const int textureRecord = 24;

        public AtelierM042() : base(ItemGroups.MensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11042;
        public const int textureArchive = 20211;
        public const int textureRecord = 40;

        public AtelierM043() : base(ItemGroups.MensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11043;
        public const int textureArchive = 20211;
        public const int textureRecord = 56;

        public AtelierM044() : base(ItemGroups.MensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11044;
        public const int textureArchive = 20212;
        public const int textureRecord = 0;

        public AtelierM045() : base(ItemGroups.MensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11045;
        public const int textureArchive = 20212;
        public const int textureRecord = 1;

        public AtelierM046() : base(ItemGroups.MensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11046;
        public const int textureArchive = 20212;
        public const int textureRecord = 2;

        public AtelierM047() : base(ItemGroups.MensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11047;
        public const int textureArchive = 20212;
        public const int textureRecord = 3;

        public AtelierM048() : base(ItemGroups.MensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11048;
        public const int textureArchive = 20214;
        public const int textureRecord = 0;

        public AtelierM049() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11049;
        public const int textureArchive = 20214;
        public const int textureRecord = 8;

        public AtelierM050() : base(ItemGroups.MensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11050;
        public const int textureArchive = 20214;
        public const int textureRecord = 9;

        public AtelierM051() : base(ItemGroups.MensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11051;
        public const int textureArchive = 20214;
        public const int textureRecord = 10;

        public AtelierM052() : base(ItemGroups.MensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11052;
        public const int textureArchive = 20214;
        public const int textureRecord = 11;

        public AtelierM053() : base(ItemGroups.MensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11053;
        public const int textureArchive = 20214;
        public const int textureRecord = 12;

        public AtelierM054() : base(ItemGroups.MensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11054;
        public const int textureArchive = 20214;
        public const int textureRecord = 3;

        public AtelierM055() : base(ItemGroups.MensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11055;
        public const int textureArchive = 20214;
        public const int textureRecord = 6;

        public AtelierM056() : base(ItemGroups.MensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11056;
        public const int textureArchive = 20213;
        public const int textureRecord = 3;

        public AtelierM057() : base(ItemGroups.MensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 11057;
        public const int textureArchive = 20213;
        public const int textureRecord = 4;

        public AtelierM058() : base(ItemGroups.MensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

            return true;
        }
        public override ItemData_v1 GetSaveData()
        {
            ItemData_v1 data = base.GetSaveData();
            data.className = typeof(AtelierM058).ToString();
            return data;
        }
    }



    //womens clothing
    public class AtelierF001 : DaggerfallUnityItem
    {
        public const int templateIndex = 10000;
        public const int textureArchive = 20200;
        public const int textureRecord = 0;

        public AtelierF001() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10001;
        public const int textureArchive = 20200;
        public const int textureRecord = 2;

        public AtelierF002() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10002;
        public const int textureArchive = 20200;
        public const int textureRecord = 4;

        public AtelierF003() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10003;
        public const int textureArchive = 20200;
        public const int textureRecord = 8;

        public AtelierF004() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10004;
        public const int textureArchive = 20200;
        public const int textureRecord = 10;

        public AtelierF005() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10005;
        public const int textureArchive = 20200;
        public const int textureRecord = 12;

        public AtelierF006() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

            return true;
        }
        public override ItemData_v1 GetSaveData()
        {
            ItemData_v1 data = base.GetSaveData();
            data.className = typeof(AtelierF005).ToString();
            return data;
        }

    }
    public class AtelierF007 : DaggerfallUnityItem
    {
        public const int templateIndex = 10006;
        public const int textureArchive = 20200;
        public const int textureRecord = 13;

        public AtelierF007() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10007;
        public const int textureArchive = 20200;
        public const int textureRecord = 14;

        public AtelierF008() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10008;
        public const int textureArchive = 20200;
        public const int textureRecord = 15;

        public AtelierF009() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10009;
        public const int textureArchive = 20200;
        public const int textureRecord = 16;

        public AtelierF010() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10010;
        public const int textureArchive = 20200;
        public const int textureRecord = 16;

        public AtelierF011() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10011;
        public const int textureArchive = 20200;
        public const int textureRecord = 18;

        public AtelierF012() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10012;
        public const int textureArchive = 20200;
        public const int textureRecord = 21;

        public AtelierF013() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10013;
        public const int textureArchive = 20200;
        public const int textureRecord = 24;

        public AtelierF014() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10014;
        public const int textureArchive = 20200;
        public const int textureRecord = 27;

        public AtelierF015() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10015;
        public const int textureArchive = 20200;
        public const int textureRecord = 30;

        public AtelierF016() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10016;
        public const int textureArchive = 20200;
        public const int textureRecord = 33;

        public AtelierF017() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10017;
        public const int textureArchive = 20200;
        public const int textureRecord = 36;

        public AtelierF018() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10018;
        public const int textureArchive = 20200;
        public const int textureRecord = 39;

        public AtelierF019() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10019;
        public const int textureArchive = 20200;
        public const int textureRecord = 42;

        public AtelierF020() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10020;
        public const int textureArchive = 20200;
        public const int textureRecord = 45;

        public AtelierF021() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10021;
        public const int textureArchive = 20200;
        public const int textureRecord = 49;

        public AtelierF022() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10022;
        public const int textureArchive = 20200;
        public const int textureRecord = 51;

        public AtelierF023() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10023;
        public const int textureArchive = 20200;
        public const int textureRecord = 53;

        public AtelierF024() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10024;
        public const int textureArchive = 20200;
        public const int textureRecord = 54;

        public AtelierF025() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10025;
        public const int textureArchive = 20200;
        public const int textureRecord = 55;

        public AtelierF026() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10026;
        public const int textureArchive = 20200;
        public const int textureRecord = 59;

        public AtelierF027() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10027;
        public const int textureArchive = 20200;
        public const int textureRecord = 61;

        public AtelierF028() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10028;
        public const int textureArchive = 20200;
        public const int textureRecord = 62;

        public AtelierF029() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10029;
        public const int textureArchive = 20200;
        public const int textureRecord = 63;

        public AtelierF030() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10030;
        public const int textureArchive = 20200;
        public const int textureRecord = 66;

        public AtelierF031() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10031;
        public const int textureArchive = 20200;
        public const int textureRecord = 70;

        public AtelierF032() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10032;
        public const int textureArchive = 20200;
        public const int textureRecord = 73;

        public AtelierF033() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10033;
        public const int textureArchive = 20200;
        public const int textureRecord = 76;

        public AtelierF034() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10034;
        public const int textureArchive = 20200;
        public const int textureRecord = 80;

        public AtelierF035() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10035;
        public const int textureArchive = 20200;
        public const int textureRecord = 83;

        public AtelierF036() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10036;
        public const int textureArchive = 20200;
        public const int textureRecord = 86;

        public AtelierF037() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10037;
        public const int textureArchive = 20200;
        public const int textureRecord = 88;

        public AtelierF038() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10038;
        public const int textureArchive = 20200;
        public const int textureRecord = 89;

        public AtelierF039() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20210_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10039;
        public const int textureArchive = 20201;
        public const int textureRecord = 0;

        public AtelierF040() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10040;
        public const int textureArchive = 20201;
        public const int textureRecord = 20;

        public AtelierF041() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10041;
        public const int textureArchive = 20201;
        public const int textureRecord = 24;

        public AtelierF042() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10042;
        public const int textureArchive = 20201;
        public const int textureRecord = 40;

        public AtelierF043() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10043;
        public const int textureArchive = 20201;
        public const int textureRecord = 56;

        public AtelierF044() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10044;
        public const int textureArchive = 20202;
        public const int textureRecord = 0;

        public AtelierF045() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10045;
        public const int textureArchive = 20202;
        public const int textureRecord = 1;

        public AtelierF046() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10046;
        public const int textureArchive = 20202;
        public const int textureRecord = 2;

        public AtelierF047() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10047;
        public const int textureArchive = 20202;
        public const int textureRecord = 3;

        public AtelierF048() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10048;
        public const int textureArchive = 20204;
        public const int textureRecord = 0;

        public AtelierF049() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10049;
        public const int textureArchive = 20204;
        public const int textureRecord = 8;

        public AtelierF050() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10050;
        public const int textureArchive = 20204;
        public const int textureRecord = 9;

        public AtelierF051() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10051;
        public const int textureArchive = 20204;
        public const int textureRecord = 10;

        public AtelierF052() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10052;
        public const int textureArchive = 20204;
        public const int textureRecord = 11;

        public AtelierF053() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10053;
        public const int textureArchive = 20204;
        public const int textureRecord = 12;

        public AtelierF054() : base(ItemGroups.WomensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10054;
        public const int textureArchive = 20204;
        public const int textureRecord = 3;

        public AtelierF055() : base(ItemGroups.MensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10055;
        public const int textureArchive = 20204;
        public const int textureRecord = 6;

        public AtelierF056() : base(ItemGroups.MensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10056;
        public const int textureArchive = 20203;
        public const int textureRecord = 3;

        public AtelierF057() : base(ItemGroups.MensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

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
        public const int templateIndex = 10057;
        public const int textureArchive = 20203;
        public const int textureRecord = 4;

        public AtelierF058() : base(ItemGroups.MensClothing, templateIndex)
        {
        }
        public override int InventoryTextureArchive
        {
            get { return textureArchive; }
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

                return textureRecord + CurrentVariant; // returns record + variant (so 20200_0-0_Blue for example)
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
            DaggerfallUI.Instance.InventoryWindow.Refresh(true);

            return true;
        }
        public override ItemData_v1 GetSaveData()
        {
            ItemData_v1 data = base.GetSaveData();
            data.className = typeof(AtelierF058).ToString();
            return data;
        }
    }
}