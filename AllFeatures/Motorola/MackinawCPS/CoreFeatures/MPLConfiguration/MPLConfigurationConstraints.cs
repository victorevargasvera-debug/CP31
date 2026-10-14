using System;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;

namespace Motorola.MackinawCPS.CoreFeatures.MPLConfiguration
{
	// Token: 0x02000523 RID: 1315
	public static class MPLConfigurationConstraints
	{
		// Token: 0x0600B1AB RID: 45483 RVA: 0x00A4A7F0 File Offset: 0x00A489F0
		internal static bool ConMplTxSqTypeIsDpl(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1637220353;
			if (num != 0)
			{
			}
			num = (short)571800032;
			short num2 = num;
			num = (short)1019148768;
			switch (num2 == num)
			{
			}
			num = (short)1624768512;
			if (num != 0)
			{
			}
			num = (short)1936130048;
			short num3 = num;
			return (self as global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInnerSection).MplCfgMPLListTxSquelchType_A9567.Value == 3;
		}

		// Token: 0x0600B1AC RID: 45484 RVA: 0x00A4A8AC File Offset: 0x00A48AAC
		internal static bool ConMplRxSqTypeIsDpl(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)510665180;
			short num2 = num;
			num = (short)926172;
			switch (num2 == num)
			{
			}
			num = (short)188219393;
			if (num != 0)
			{
			}
			num = (short)1947467776;
			if (num != 0)
			{
			}
			num = (short)136773632;
			short num3 = num;
			return (self as global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInnerSection).MplCfgMPLListRxSquelchType_A9028.Value == 3;
		}

		// Token: 0x0600B1AD RID: 45485 RVA: 0x00A4A96C File Offset: 0x00A48B6C
		internal static bool ConMplDirectSqTypeIsPl(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num;
			global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInnerSection mpllistInnerSection;
			for (;;)
			{
				num = (short)1305870336;
				short num2 = num;
				mpllistInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInnerSection);
				if (mpllistInnerSection.RefConventionalWide.General.CnvWideGeneralDirectFrequency_A7860.Value)
				{
					break;
				}
				num = (short)1219668175;
				short num3 = num;
				num = (short)1266723023;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_8B;
				}
			}
			return mpllistInnerSection.MplCfgMPLListTASquelchType_A9266.Value == 2;
			IL_8B:
			num = (short)1683881984;
			if (num != 0)
			{
			}
			num = (short)1069809665;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x0600B1AE RID: 45486 RVA: 0x00A4AA44 File Offset: 0x00A48C44
		internal static bool ConMplRxTASqTypeIsPl(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)773371856;
			short num2 = num;
			num = (short)1647884240;
			switch (num2 == num)
			{
			}
			num = (short)531300353;
			if (num != 0)
			{
			}
			num = (short)1856045056;
			if (num != 0)
			{
			}
			num = (short)909049856;
			short num3 = num;
			return (self as global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInnerSection).MplCfgMPLListRxSquelchType_A9028.Value == 2;
		}

		// Token: 0x0600B1AF RID: 45487 RVA: 0x00A4AB00 File Offset: 0x00A48D00
		internal static bool conMPLDirectFreqEnAndDirectSqlchIsDPL(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num;
			global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInnerSection mpllistInnerSection;
			for (;;)
			{
				num = (short)1118830592;
				short num2 = num;
				mpllistInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInnerSection);
				if (mpllistInnerSection.RefConventionalWide.General.CnvWideGeneralDirectFrequency_A7860.Value)
				{
					break;
				}
				num = (short)321801243;
				short num3 = num;
				num = (short)513035291;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_8C;
				}
			}
			return mpllistInnerSection.MplCfgMPLListTASquelchType_A9266.Value == 3;
			IL_8C:
			num = (short)2116878336;
			if (num != 0)
			{
			}
			num = (short)969539585;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x0600B1B0 RID: 45488 RVA: 0x00A4ABD8 File Offset: 0x00A48DD8
		internal static bool ConMPLTxSquelchTypeIsPL(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1919441266;
			short num2 = num;
			num = (short)808606066;
			switch (num2 == num)
			{
			}
			num = (short)2103574528;
			if (num != 0)
			{
			}
			num = (short)973471745;
			if (num != 0)
			{
			}
			num = (short)838795264;
			short num3 = num;
			return (self as global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInnerSection).MplCfgMPLListTxSquelchType_A9567.Value == 2;
		}

		// Token: 0x0600B1B1 RID: 45489 RVA: 0x00A4AC94 File Offset: 0x00A48E94
		internal static void conSetTaPlCodeBasedOnTAPlFreqValue(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)953269882;
			short num2 = num;
			num = (short)1553055354;
			switch (num2 == num)
			{
			}
			num = (short)534183936;
			if (num != 0)
			{
			}
			num = (short)991625217;
			if (num != 0)
			{
			}
			num = (short)2077491200;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInnerSection mpllistInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInnerSection;
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(mpllistInnerSection.MplCfgMPLListTAPLCode_A9262, mpllistInnerSection.MplCfgMPLListTAPLFreq_A9263.Value));
		}

		// Token: 0x0600B1B2 RID: 45490 RVA: 0x00A4AD60 File Offset: 0x00A48F60
		internal static void conSetTaPlFreqBasedOnTAPlCode(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)192020481;
			if (num != 0)
			{
			}
			num = (short)550591372;
			short num2 = num;
			num = (short)1787190156;
			switch (num2 == num)
			{
			}
			num = (short)676003840;
			if (num != 0)
			{
			}
			num = (short)223805440;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInnerSection mpllistInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInnerSection;
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(mpllistInnerSection.MplCfgMPLListTAPLFreq_A9263, mpllistInnerSection.MplCfgMPLListTAPLCode_A9262.Value));
		}

		// Token: 0x0600B1B3 RID: 45491 RVA: 0x00A4AE2C File Offset: 0x00A4902C
		internal static bool conIsDirectFreqEn(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)878307521;
			short num2 = num;
			num = (short)867100865;
			switch (num2 == num)
			{
			}
			num = (short)164757505;
			if (num != 0)
			{
			}
			num = (short)486604800;
			if (num != 0)
			{
			}
			num = (short)1779892224;
			short num3 = num;
			return (self as global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInnerSection).RefConventionalWide.General.CnvWideGeneralDirectFrequency_A7860.Value;
		}

		// Token: 0x0600B1B4 RID: 45492 RVA: 0x00A4AEF0 File Offset: 0x00A490F0
		public static void conSetRxPlCodeBasedOnRxTAPlFreqValue(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)665696279;
			short num2 = num;
			num = (short)136951831;
			switch (num2 == num)
			{
			}
			num = (short)1321664512;
			if (num != 0)
			{
			}
			num = (short)1772355585;
			if (num != 0)
			{
			}
			num = (short)203292672;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInnerSection mpllistInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInnerSection;
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(mpllistInnerSection.MplCfgMPLListRxPLCode_A9026, mpllistInnerSection.MplCfgMPLListRxPLFreq_A9027.Value));
		}

		// Token: 0x0600B1B5 RID: 45493 RVA: 0x00A4AFBC File Offset: 0x00A491BC
		public static void conSetRxPlFreqBasedOnRxTAPlCode(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)343970434;
			short num2 = num;
			num = (short)1172214402;
			switch (num2 == num)
			{
			}
			num = (short)494927873;
			if (num != 0)
			{
			}
			num = (short)1604386816;
			if (num != 0)
			{
			}
			num = (short)355008512;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInnerSection mpllistInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInnerSection;
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(mpllistInnerSection.MplCfgMPLListRxPLFreq_A9027, mpllistInnerSection.MplCfgMPLListRxPLCode_A9026.Value));
		}

		// Token: 0x0600B1B6 RID: 45494 RVA: 0x00A4B088 File Offset: 0x00A49288
		internal static void conSetTxPlFreqBasedOnTxPlCode(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1971023725;
			short num2 = num;
			num = (short)519532397;
			switch (num2 == num)
			{
			}
			num = (short)156172289;
			if (num != 0)
			{
			}
			num = (short)1181810688;
			if (num != 0)
			{
			}
			num = (short)128778240;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInnerSection mpllistInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInnerSection;
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(mpllistInnerSection.MplCfgMPLListTxPLFreq_A9556, mpllistInnerSection.MplCfgMPLListTxPLCode_A9555.Value));
		}

		// Token: 0x0600B1B7 RID: 45495 RVA: 0x00A4B154 File Offset: 0x00A49354
		internal static void conSetTxPlCodeBasedOnTxPlFreqValue(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)186495308;
			short num2 = num;
			num = (short)1594011980;
			switch (num2 == num)
			{
			}
			num = (short)701235201;
			if (num != 0)
			{
			}
			num = (short)477560832;
			if (num != 0)
			{
			}
			num = (short)670826496;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInnerSection mpllistInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInnerSection;
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(mpllistInnerSection.MplCfgMPLListTxPLCode_A9555, mpllistInnerSection.MplCfgMPLListTxPLFreq_A9556.Value));
		}

		// Token: 0x0600B1B8 RID: 45496 RVA: 0x00A4B220 File Offset: 0x00A49420
		internal static bool ConMplRxTASqTypeIsPlEditbl(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)597557249;
			if (num != 0)
			{
			}
			num = (short)958652667;
			short num2 = num;
			num = (short)1977934075;
			switch (num2 == num)
			{
			}
			num = (short)197656576;
			if (num != 0)
			{
			}
			num = (short)1020461056;
			short num3 = num;
			return (self as global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInnerSection).MplCfgMPLListRxSquelchType_A9028.Value == 2;
		}

		// Token: 0x0600B1B9 RID: 45497 RVA: 0x00A4B2E0 File Offset: 0x00A494E0
		internal static bool ConMplDirectSqTypeIsPlEditbl(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num;
			global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInnerSection mpllistInnerSection;
			for (;;)
			{
				num = (short)1192886272;
				short num2 = num;
				mpllistInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInnerSection);
				if (mpllistInnerSection.RefConventionalWide.General.CnvWideGeneralDirectFrequency_A7860.Value)
				{
					break;
				}
				num = (short)1619028595;
				short num3 = num;
				num = (short)1717004915;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_8F;
				}
			}
			return mpllistInnerSection.MplCfgMPLListTASquelchType_A9266.Value == 2;
			IL_8F:
			num = (short)1197539329;
			if (num != 0)
			{
			}
			num = (short)1076494336;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x0600B1BA RID: 45498 RVA: 0x00A4B3BC File Offset: 0x00A495BC
		internal static bool ConMPLTxSquelchTypeIsPLEditbl(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)941100369;
			short num2 = num;
			num = (short)1342639441;
			switch (num2 == num)
			{
			}
			num = (short)2092433409;
			if (num != 0)
			{
			}
			num = (short)644612096;
			if (num != 0)
			{
			}
			num = (short)943325184;
			short num3 = num;
			return (self as global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInnerSection).MplCfgMPLListTxSquelchType_A9567.Value == 2;
		}
	}
}
