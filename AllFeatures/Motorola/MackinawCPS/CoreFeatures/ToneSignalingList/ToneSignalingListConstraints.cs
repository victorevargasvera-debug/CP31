using System;
using System.Globalization;
using System.Threading;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ToneSignalingList
{
	// Token: 0x020001BF RID: 447
	public static class ToneSignalingListConstraints
	{
		// Token: 0x060052DF RID: 21215 RVA: 0x004B322C File Offset: 0x004B142C
		internal static void ConRemoveInvalidZeroAfterDecimalPoint(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)651100161;
			if (num != 0)
			{
			}
			num = (short)823197696;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_72;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.AstroAlertingToneTableInnerSection astroAlertingToneTableInnerSection;
				for (;;)
				{
					IL_4F:
					double num3;
					switch (num2)
					{
					case 0:
						if (astroAlertingToneTableInnerSection != null)
						{
							num = (short)1647837188;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B8;
					case 1:
						goto IL_1B8;
					case 2:
					{
						global::System.Globalization.NumberStyles style;
						global::System.Globalization.CultureInfo currentUICulture;
						if (double.TryParse(astroAlertingToneTableInnerSection.RadErgoAstroAlertingToneTableTone2Freq.UIValue, style, currentUICulture, out num3))
						{
							num = (short)2106785795;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B8;
					}
					case 3:
						goto IL_D8;
					case 4:
					{
						num = (short)528220160;
						short num4 = num;
						num = (short)1404370950;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						global::System.Globalization.NumberStyles style = global::System.Globalization.NumberStyles.Number;
						global::System.Globalization.CultureInfo currentUICulture = global::System.Threading.Thread.CurrentThread.CurrentUICulture;
						num = (short)1161756674;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						if (astroAlertingToneTableInnerSection.RadErgoAstroAlertingToneTableTone2Freq.UIValue.ToUpper() != global::CommonResources.AcgResources.ID_DISABLED.ToUpper())
						{
							num = (short)192151557;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B8;
					}
					goto IL_72;
					IL_D8:
					astroAlertingToneTableInnerSection.RadErgoAstroAlertingToneTableTone2Freq.UIValue = num3.ToString();
					num = (short)1325662209;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B8:
					num = (short)1432050608;
					short num5 = num;
					num = (short)1890802608;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D8;
					default:
						goto IL_1ED;
					}
				}
				IL_1ED:
				num = (short)2077032448;
				if (num != 0)
				{
				}
				return;
				IL_72:
				astroAlertingToneTableInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.AstroAlertingToneTableInnerSection);
				num = (short)1801519104;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_4F;
			}
			}
		}

		// Token: 0x060052E0 RID: 21216 RVA: 0x004B343C File Offset: 0x004B163C
		internal static bool ConAstroAlertToneDecode(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.AstroAlertingToneTableInner astroAlertingToneTableInner;
			short num;
			for (;;)
			{
				astroAlertingToneTableInner = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.AstroAlertingToneTableInner);
				if (astroAlertingToneTableInner == null)
				{
					goto IL_94;
				}
				num = (short)858184884;
				short num2 = num;
				num = (short)221633716;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_46;
				}
			}
			IL_46:
			num = (short)1425473536;
			short num3 = num;
			num = (short)1975779328;
			if (num != 0)
			{
			}
			return astroAlertingToneTableInner.Position <= 10;
			IL_94:
			num = (short)206372865;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x060052E1 RID: 21217 RVA: 0x004B3508 File Offset: 0x004B1708
		public static bool conVisRefToneSignalingTypeIsQCII(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)797919215;
			short num2 = num;
			num = (short)1430013935;
			switch (num2 == num)
			{
			default:
			{
				num = (short)638386176;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1787559937;
			if (num != 0)
			{
			}
			num = (short)1302986752;
			if (num != 0)
			{
			}
			return (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingList).AstroAlertingToneListExpander.RadErgoAstroAlertingToneListType_A43068.Value == 1;
		}

		// Token: 0x060052E2 RID: 21218 RVA: 0x004B35D8 File Offset: 0x004B17D8
		public static bool conVisRefToneSignalingTypeIsNOTQCII(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)201261057;
			if (num != 0)
			{
			}
			num = (short)1632829440;
			short num2 = num;
			num = (short)2112150403;
			short num3 = num;
			num = (short)2075712387;
			switch (num3 == num)
			{
			}
			num = (short)14876672;
			if (num != 0)
			{
			}
			return (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.ToneSignalingList).AstroAlertingToneListExpander.RadErgoAstroAlertingToneListType_A43068.Value != 1;
		}
	}
}
