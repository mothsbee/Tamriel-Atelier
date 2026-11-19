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
using DaggerfallWorkshop.Game.Questing;
using Wenzil.Console;
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
            AtelierConsoleCommands();
            mod.IsReady = true;
        }

        void Awake()
        {
            //mens clothing
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM001.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM001));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM002.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM002));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM003.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM003));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM004.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM004));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM005.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM005));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM006.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM006));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM007.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM007));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM008.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM008));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM009.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM009));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM010.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM010));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM011.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM011));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM012.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM012));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM013.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM013));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM014.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM014));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM015.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM015));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM016.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM016));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM017.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM017));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM018.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM018));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM019.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM019));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM020.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM020));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM021.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM021));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM022.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM022));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM023.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM023));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM024.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM024));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM025.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM025));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM026.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM026));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM027.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM027));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM028.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM028));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM029.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM029));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM030.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM030));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM031.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM031));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM032.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM032));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM033.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM033));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM034.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM034));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM035.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM035));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM036.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM036));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM037.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM037));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM038.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM038));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM039.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM039));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM040.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM040));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM041.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM041));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM042.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM042));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM043.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM043));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM044.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM044));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM045.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM045));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM046.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM046));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM047.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM047));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM048.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM048));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM049.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM049));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM050.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM050));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM051.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM051));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM052.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM052));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM053.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM053));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM054.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM054));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM055.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM055));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM056.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM056));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM057.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM057));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM058.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM058));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM059.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM059));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM060.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM060));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM061.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM061));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM062.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM062));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM063.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM063));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM064.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM064));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM065.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM065));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM066.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM066));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM067.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM067));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM068.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM068));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM069.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM069));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM070.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM070));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM071.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM071));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM072.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM072));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM073.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM073));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM074.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM074));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM075.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM075));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM076.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM076));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM077.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM077));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM078.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM078));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM079.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM079));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM080.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM080));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM081.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM081));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM082.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM082));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM083.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM083));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM084.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM084));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM085.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM085));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM086.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM086));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM087.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM087));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM088.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM088));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM089.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM089));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM090.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM090));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM091.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM091));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM092.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM092));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM093.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM093));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM094.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM094));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM095.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM095));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM096.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM096));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM097.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM097));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM098.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM098));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM099.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM099));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM100.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM100));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM101.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM101));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierM102.TemplateIndex, ItemGroups.MensClothing, typeof(AtelierM102));
            //add women's clothing
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF001.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF001));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF002.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF002));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF003.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF003));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF004.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF004));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF005.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF005));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF006.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF006));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF007.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF007));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF008.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF008));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF009.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF009));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF010.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF010));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF011.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF011));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF012.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF012));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF013.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF013));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF014.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF014));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF015.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF015));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF016.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF016));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF017.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF017));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF018.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF018));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF019.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF019));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF020.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF020));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF021.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF021));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF022.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF022));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF023.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF023));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF024.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF024));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF025.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF025));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF026.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF026));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF027.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF027));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF028.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF028));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF029.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF029));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF030.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF030));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF031.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF031));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF032.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF032));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF033.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF033));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF034.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF034));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF035.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF035));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF036.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF036));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF037.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF037));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF038.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF038));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF039.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF039));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF040.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF040));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF041.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF041));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF042.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF042));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF043.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF043));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF044.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF044));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF045.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF045));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF046.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF046));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF047.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF047));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF048.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF048));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF049.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF049));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF050.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF050));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF051.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF051));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF052.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF052));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF053.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF053));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF054.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF054));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF055.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF055));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF056.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF056));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF057.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF057));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF058.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF058));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF059.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF059));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF060.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF060));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF061.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF061));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF062.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF062));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF063.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF063));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF064.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF064));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF065.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF065));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF066.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF066));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF067.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF067));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF068.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF068));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF069.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF069));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF070.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF070));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF071.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF071));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF072.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF072));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF073.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF073));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF074.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF074));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF075.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF075));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF076.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF076));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF077.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF077));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF078.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF078));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF079.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF079));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF080.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF080));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF081.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF081));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF082.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF082));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF083.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF083));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF084.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF084));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF085.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF085));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF086.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF086));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF087.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF087));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF088.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF088));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF089.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF089));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF090.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF090));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF091.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF091));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF092.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF092));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF093.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF093));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF094.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF094));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF095.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF095));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF096.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF096));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF097.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF097));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF098.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF098));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF099.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF099));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF100.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF100));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF101.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF101));
            DaggerfallUnity.Instance.ItemHelper.RegisterCustomItem(AtelierF102.TemplateIndex, ItemGroups.WomensClothing, typeof(AtelierF102));

        }

        public static void AtelierConsoleCommands()
        {
            try
            {
                ConsoleCommandsDatabase.RegisterCommand(AtelierAddAllItems.Command, AtelierAddAllItems.Description,
                    AtelierAddAllItems.Usage, args => AtelierAddAllItems.Execute());
            }
            catch (Exception e)
            {
                Debug.LogError($"Error Registering Tamriel Atelier Console commands: {e.Message}");
            }
        }
        static class AtelierAddAllItems
        {
            static AtelierAddAllItems()
            {
                Command = "ta_allitems";
                Description = "Adds one of each item added by Tamriel Atelier.";
                Usage = "ta_allitems";
                Player = GameObject.FindGameObjectWithTag("Player");
                PlayerEntity = Player.GetComponent<DaggerfallEntityBehaviour>().Entity as PlayerEntity;
                Items = PlayerEntity.Items;
                ItemHelper = DaggerfallUnity.Instance.ItemHelper;
                mensItems = new[]
                { 21000, 21001, 21002, 21003, 21004, 21005, 21006, 21007, 21008, 21009, 21020, 21011, 21012, 21013,
                    21014, 21015, 21016, 21017, 21018, 21019, 21020, 21021, 21022, 21023, 21024, 21025, 21026, 21027,
                    21028, 21029, 21030, 21031, 21032, 21033, 21034, 21035, 21036, 21037, 21038, 21039, 21040, 21041,
                    21042, 21043, 21044, 21045, 21046, 21047, 21048, 21049, 21050, 21051, 21052, 21053, 21054, 21055,
                    21056, 21057, 21058, 21059, 21060, 21061, 21062, 21063, 21064, 21065, 21066, 21067, 21068, 21069,
                    21070, 21071, 21072, 21073, 21074, 21075, 21076, 21077, 21078, 21079, 21080, 21081, 21082, 21083,
                    21084, 21085, 21086, 21087, 21088, 21089, 21090, 21091, 21092, 21093, 21094, 21095, 21096, 21097,
                    21098, 21099, 21100, 21101 };
                womensItems = new[]
                {
                    20000, 20001, 20002, 20003, 20004, 20005, 20006, 20007, 20008, 20009, 20020, 20011, 20012, 20013,
                    20014, 20015, 20016, 20017, 20018, 20019, 20020, 20021, 20022, 20023, 20024, 20025, 20026, 20027,
                    20028, 20029, 20030, 20031, 20032, 20033, 20034, 20035, 20036, 20037, 20038, 20039, 20040, 20041,
                    20042, 20043, 20044, 20045, 20046, 20047, 20048, 20049, 20050, 20051, 20052, 20053, 20054, 20055,
                    20056, 20057, 20058, 20059, 20060, 20061, 20062, 20063, 20064, 20065, 20066, 20067, 20068, 20069,
                    20070, 20071, 20072, 20073, 20074, 20075, 20076, 20077, 20078, 20079, 20080, 20081, 20082, 20083,
                    20084, 20085, 20086, 20087, 20088, 20089, 20090, 20091, 20092, 20093, 20094, 20095, 20096, 20097,
                    20098, 20099, 20100, 20101
                };
            }

            public static readonly string Command;
            public static readonly string Description;
            public static readonly string Usage;
            private static GameObject Player;
            private static PlayerEntity PlayerEntity;
            public static ItemCollection Items;
            public static ItemHelper ItemHelper { get; set; }
            private static DaggerfallUnityItem newItem;
            private static ItemGroups ClothingType;
            private static readonly int[] mensItems;
            private static readonly int[] womensItems;

            public static string Execute(params string[] args)
            {
                DyeColors[] clothingDyes = ItemBuilder.clothingDyes;
                if ((PlayerEntity.Gender == Genders.Male))
                {
                    ClothingType = ItemGroups.MensClothing;
                    foreach (DyeColors dye in clothingDyes)
                    {
                        for (var index = 0; index < mensItems.Length; index++)
                        {
                            var t = mensItems[index];
                            newItem = ItemBuilder.CreateItem(ClothingType, t);
                            ItemBuilder.SetRace(newItem, PlayerEntity.Race);
                            newItem.dyeColor = dye;
                            ItemBuilder.SetVariant(newItem, UnityEngine.Random.Range(0, 0));
                            PlayerEntity.Items.AddItem(newItem);
                        }
                    }
                }
                else
                {
                    ClothingType = ItemGroups.WomensClothing;
                    foreach (DyeColors dye in clothingDyes)
                    {
                        for (var index = 0; index < womensItems.Length; index++)
                        {
                            var t = womensItems[index];
                            newItem = ItemBuilder.CreateItem(ClothingType, t);
                            ItemBuilder.SetRace(newItem, PlayerEntity.Race);
                            newItem.dyeColor = dye;
                            ItemBuilder.SetVariant(newItem, UnityEngine.Random.Range(0, 0));
                            PlayerEntity.Items.AddItem(newItem);
                        }
                    }
                }

                return $"Tamriel Atelier items added for {PlayerEntity.Gender} player character.";
            }
        }

        }
}