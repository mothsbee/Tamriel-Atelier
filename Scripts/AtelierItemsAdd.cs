 using System;
using System.Collections;
using UnityEngine;
using DaggerfallConnect;
using DaggerfallConnect.Save;
using DaggerfallWorkshop;
using DaggerfallWorkshop.Utility;
using DaggerfallWorkshop.Game;
using DaggerfallWorkshop.Game.Items;
using DaggerfallWorkshop.Game.Utility.ModSupport;
using DaggerfallWorkshop.Game.Utility.ModSupport.ModSettings;
using DaggerfallWorkshop.Game.Entity;
using DaggerfallWorkshop.Game.Formulas;
using DaggerfallWorkshop.Game.Player;
using DaggerfallWorkshop.Game.Utility;
using DaggerfallWorkshop.Game.MagicAndEffects;
using DaggerfallWorkshop.Game.MagicAndEffects.MagicEffects;
using DaggerfallWorkshop.Game.Guilds;
using System.Collections.Generic;
using DaggerfallConnect.FallExe;

using DaggerfallWorkshop.Game.Serialization;



namespace AtelierItems
{
    public class AtelierAddItems : MonoBehaviour
    {
        static Mod mod;

        [Invoke(StateManager.StateTypes.Start, 0)]
        public static void Init(InitParams initParams)
        {
            mod = initParams.Mod;
            var go = new GameObject(mod.Title);
            go.AddComponent<AtelierAddItems>();
        }
 
        void Awake()
        {
            //add men's clothing
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM001.templateIndex, ItemGroups.MensClothing, typeof(AtelierM001));
            mod.IsReady = true;

        }

    }



}
