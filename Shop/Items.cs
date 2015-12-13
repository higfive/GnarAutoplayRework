using Autoplay;
using EloBuddy;
using EloBuddy.SDK;
using System.Collections.Generic;
using System;

namespace Shop
{
    class Items : Helper
    {
        public static List<CItem> GnarItems = new List<CItem>()
        {
            new CItem(0, 0),
            new CItem(350, (int)ItemId.Sapphire_Crystal),         //1
            new CItem(400, (int)ItemId.Tear_of_the_Goddess),      //2
            new CItem(1100, (int)ItemId.Sorcerers_Shoes),         //3
            new CItem(1250, (int)ItemId.Needlessly_Large_Rod),    //4
            new CItem(1100, (int)ItemId.Archangels_Staff),        //5
            new CItem(2800, (int)ItemId.Frozen_Heart),            //6
            new CItem(1200, (int)ItemId.Catalyst_the_Protector),  //7
            new CItem(1800, (int)ItemId.Rod_of_Ages),             //8
            new CItem(2650, (int)ItemId.Void_Staff),              //9
            new CItem(850, (int)ItemId.Blasting_Wand),            //10
            new CItem(2150, (int)ItemId.Rabadons_Deathcap)        //11
        };
        public static void BuyGnarsItems()
        {
            #region SapphireCrystal
            if (!HasItem(GnarItems[1]) && !HasItem(GnarItems[2]) && !HasItem(GnarItems[5]) && !HasItem(3040) && !HasItem(3048))
            {
                if (myHero.Gold >= GnarItems[1].Gold)
                    Buy(GnarItems[1]);
            }
            #endregion
            #region Tear
            if (!HasItem(GnarItems[2]) && !HasItem(GnarItems[5]) && HasItem(GnarItems[1]) && !HasItem(3040) && !HasItem(3048))
            {
                if (myHero.Gold >= GnarItems[2].Gold)
                    Buy(GnarItems[2]);
            }
            #endregion
            #region Catalyst
            if(!HasItem(GnarItems[7]) && !HasItem(GnarItems[8]))
            {
                if (myHero.Gold >= GnarItems[7].Gold)
                    Buy(GnarItems[7]);
            }
            #endregion
            #region ROA
            if (!HasItem(GnarItems[8]) && HasItem(GnarItems[7]))
            {
                if (myHero.Gold >= GnarItems[8].Gold)
                    Buy(GnarItems[8]);
            }
            #endregion
            #region Boots
            if (!HasItem(GnarItems[3]))
            {
                if (myHero.Gold >= GnarItems[3].Gold)
                    Buy(GnarItems[3]);
            }
            #endregion
            #region LargeRod
            if (!HasItem(GnarItems[4]) && !HasItem(GnarItems[5]) && !HasItem(3040) && !HasItem(3048))
            {
                if (myHero.Gold >= GnarItems[4].Gold)
                    Buy(GnarItems[4]);
            }
            #endregion
            #region ArchStaff
            if (!HasItem(GnarItems[5]) && HasItem(GnarItems[4]) && HasItem(GnarItems[2]) && !HasItem(3040) && !HasItem(3048))
            {
                if (myHero.Gold >= GnarItems[5].Gold)
                    Buy(GnarItems[5]);
            }
            #endregion
            #region FrozenHearth
            if (!HasItem(GnarItems[6]))
            {
                if (myHero.Gold >= GnarItems[6].Gold)
                    Buy(GnarItems[6]);
            }
            #endregion
            #region VoidStaff
            if (!HasItem(GnarItems[9]))
            {
                if (myHero.Gold >= GnarItems[9].Gold)
                    Buy(GnarItems[9]);
            }
            #endregion
            #region BlastWand
            if (!HasItem(GnarItems[10]) && !HasItem(GnarItems[11]))
            {
                if (myHero.Gold >= GnarItems[10].Gold)
                    Buy(GnarItems[10]);
            }
            #endregion
            #region Rabadon
            if (!HasItem(GnarItems[11]) && HasItem(GnarItems[10]))
            {
                if (myHero.Gold >= GnarItems[11].Gold)
                    Buy(GnarItems[11]);
            }
            #endregion
        }

        private static void Buy(CItem item)
        {
            Item itm = new Item(item.ID);
            itm.Buy();
        }

        private static bool HasItem(CItem item)
        {
            return Item.HasItem(item.ID, myHero);
        }
        private static bool HasItem(int id)
        {
            return Item.HasItem(id, myHero);
        }

        public class CItem
        {
            public float Gold;
            public int ID;
            public CItem(float g, int id)
            {
                Gold = g;
                ID = id;
            }
        }//CItem
    }
}