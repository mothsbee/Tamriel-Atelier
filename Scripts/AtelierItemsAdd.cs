// Project:         Tamriel Atelier
// License:         MIT

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
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM002.templateIndex, ItemGroups.MensClothing, typeof(AtelierM002));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM003.templateIndex, ItemGroups.MensClothing, typeof(AtelierM003));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM004.templateIndex, ItemGroups.MensClothing, typeof(AtelierM004));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM005.templateIndex, ItemGroups.MensClothing, typeof(AtelierM005));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM006.templateIndex, ItemGroups.MensClothing, typeof(AtelierM006));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM007.templateIndex, ItemGroups.MensClothing, typeof(AtelierM007));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM008.templateIndex, ItemGroups.MensClothing, typeof(AtelierM008));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM009.templateIndex, ItemGroups.MensClothing, typeof(AtelierM009));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM010.templateIndex, ItemGroups.MensClothing, typeof(AtelierM010));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM011.templateIndex, ItemGroups.MensClothing, typeof(AtelierM011));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM012.templateIndex, ItemGroups.MensClothing, typeof(AtelierM012));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM013.templateIndex, ItemGroups.MensClothing, typeof(AtelierM013));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM014.templateIndex, ItemGroups.MensClothing, typeof(AtelierM014));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM015.templateIndex, ItemGroups.MensClothing, typeof(AtelierM015));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM016.templateIndex, ItemGroups.MensClothing, typeof(AtelierM016));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM017.templateIndex, ItemGroups.MensClothing, typeof(AtelierM017));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM018.templateIndex, ItemGroups.MensClothing, typeof(AtelierM018));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM019.templateIndex, ItemGroups.MensClothing, typeof(AtelierM019));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM020.templateIndex, ItemGroups.MensClothing, typeof(AtelierM020));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM021.templateIndex, ItemGroups.MensClothing, typeof(AtelierM021));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM022.templateIndex, ItemGroups.MensClothing, typeof(AtelierM022));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM023.templateIndex, ItemGroups.MensClothing, typeof(AtelierM023));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM024.templateIndex, ItemGroups.MensClothing, typeof(AtelierM024));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM025.templateIndex, ItemGroups.MensClothing, typeof(AtelierM025));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM026.templateIndex, ItemGroups.MensClothing, typeof(AtelierM026));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM027.templateIndex, ItemGroups.MensClothing, typeof(AtelierM027));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM028.templateIndex, ItemGroups.MensClothing, typeof(AtelierM028));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM029.templateIndex, ItemGroups.MensClothing, typeof(AtelierM029));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM030.templateIndex, ItemGroups.MensClothing, typeof(AtelierM030));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM031.templateIndex, ItemGroups.MensClothing, typeof(AtelierM031));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM032.templateIndex, ItemGroups.MensClothing, typeof(AtelierM032));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM033.templateIndex, ItemGroups.MensClothing, typeof(AtelierM033));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM034.templateIndex, ItemGroups.MensClothing, typeof(AtelierM034));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM035.templateIndex, ItemGroups.MensClothing, typeof(AtelierM035));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM036.templateIndex, ItemGroups.MensClothing, typeof(AtelierM036));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM037.templateIndex, ItemGroups.MensClothing, typeof(AtelierM037));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM038.templateIndex, ItemGroups.MensClothing, typeof(AtelierM038));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM039.templateIndex, ItemGroups.MensClothing, typeof(AtelierM039));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM040.templateIndex, ItemGroups.MensClothing, typeof(AtelierM040));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM041.templateIndex, ItemGroups.MensClothing, typeof(AtelierM041));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM042.templateIndex, ItemGroups.MensClothing, typeof(AtelierM042));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM043.templateIndex, ItemGroups.MensClothing, typeof(AtelierM043));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM044.templateIndex, ItemGroups.MensClothing, typeof(AtelierM044));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM045.templateIndex, ItemGroups.MensClothing, typeof(AtelierM045));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM046.templateIndex, ItemGroups.MensClothing, typeof(AtelierM046));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM047.templateIndex, ItemGroups.MensClothing, typeof(AtelierM047));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM048.templateIndex, ItemGroups.MensClothing, typeof(AtelierM048));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM049.templateIndex, ItemGroups.MensClothing, typeof(AtelierM049));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM050.templateIndex, ItemGroups.MensClothing, typeof(AtelierM050));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM051.templateIndex, ItemGroups.MensClothing, typeof(AtelierM051));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM052.templateIndex, ItemGroups.MensClothing, typeof(AtelierM052));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM053.templateIndex, ItemGroups.MensClothing, typeof(AtelierM053));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM054.templateIndex, ItemGroups.MensClothing, typeof(AtelierM054));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM055.templateIndex, ItemGroups.MensClothing, typeof(AtelierM055));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM056.templateIndex, ItemGroups.MensClothing, typeof(AtelierM056));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM057.templateIndex, ItemGroups.MensClothing, typeof(AtelierM057));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM058.templateIndex, ItemGroups.MensClothing, typeof(AtelierM058));
            //add women's clothing
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF001.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF001));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF002.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF002));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF003.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF003));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF004.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF004));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF005.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF005));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF006.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF006));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF007.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF007));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF008.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF008));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF009.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF009));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF010.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF010));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF011.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF011));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF012.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF012));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF013.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF013));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF014.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF014));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF015.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF015));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF016.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF016));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF017.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF017));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF018.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF018));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF019.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF019));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF020.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF020));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF021.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF021));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF022.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF022));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF023.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF023));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF024.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF024));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF025.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF025));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF026.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF026));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF027.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF027));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF028.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF028));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF029.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF029));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF030.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF030));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF031.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF031));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF032.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF032));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF033.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF033));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF034.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF034));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF035.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF035));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF036.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF036));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF037.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF037));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF038.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF038));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF039.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF039));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF040.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF040));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF041.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF041));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF042.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF042));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF043.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF043));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF044.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF044));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF045.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF045));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF046.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF046));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF047.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF047));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF048.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF048));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF049.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF049));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF050.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF050));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF051.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF051));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF052.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF052));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF053.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF053));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF054.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF054));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF055.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF055));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF056.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF056));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF057.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF057));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF058.templateIndex, ItemGroups.WomensClothing, typeof(AtelierF058));

            mod.IsReady = true;

        }

    }



}
