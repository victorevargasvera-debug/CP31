using System;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;

namespace SpecialFeatures.Ucl.UclWide
{
	// Token: 0x020001B7 RID: 439
	public static class UclWideConstraints
	{
		// Token: 0x0600148C RID: 5260 RVA: 0x001D8510 File Offset: 0x001D6710
		internal static bool ConUclIsEditable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)375055736;
			short num2 = num;
			num = (short)678356344;
			switch (num2 == num)
			{
			}
			num = (short)958726144;
			if (num != 0)
			{
			}
			num = (short)1234108416;
			short num3 = num;
			num = (short)1838350337;
			if (num != 0)
			{
			}
			return (self as global::SpecialFeatures.Ucl.UclWide.UclWideSectionGeneral).UclWideGen_UCLEdit_A00001Value;
		}

		// Token: 0x0600148D RID: 5261 RVA: 0x001D85C4 File Offset: 0x001D67C4
		internal static void conSetValueHotListEditable(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			switch (0)
			{
			case 0:
				goto IL_46;
			}
			short num;
			int num3;
			global::SpecialFeatures.Ucl.UclWide.UclWideSectionGeneral uclWideSectionGeneral;
			for (;;)
			{
				IL_0A:
				num = (short)1123811328;
				short num2 = num;
				switch (num3)
				{
				case 0:
					goto IL_D1;
				case 1:
					if (uclWideSectionGeneral.UclWideGen_UCLEdit_A00001Value)
					{
						num = (short)1458569218;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D1;
				case 2:
					num = (short)1425211393;
					if (num != 0)
					{
					}
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(uclWideSectionGeneral.UclWideGen_HotListEdit_A00002Object, true));
					num = (short)951844864;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_46;
				IL_D1:
				num = (short)1581678325;
				short num4 = num;
				num = (short)1578139381;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_106;
				}
			}
			IL_106:
			num = (short)1701773312;
			if (num != 0)
			{
			}
			return;
			IL_46:
			uclWideSectionGeneral = (self as global::SpecialFeatures.Ucl.UclWide.UclWideSectionGeneral);
			num = (short)1304887297;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600148E RID: 5262 RVA: 0x001D86F0 File Offset: 0x001D68F0
		internal static void conSetValueUclEditable(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			switch (0)
			{
			case 0:
				goto IL_45;
			}
			short num;
			int num3;
			global::SpecialFeatures.Ucl.UclWide.UclWideSectionGeneral uclWideSectionGeneral;
			for (;;)
			{
				IL_0A:
				num = (short)121241600;
				short num2 = num;
				switch (num3)
				{
				case 0:
					num = (short)1503723521;
					if (num != 0)
					{
					}
					goto IL_D2;
				case 1:
					if (!uclWideSectionGeneral.UclWideGen_HotListEdit_A00002Value)
					{
						num = (short)325582850;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D2;
				case 2:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(uclWideSectionGeneral.UclWideGen_UCLEdit_A00001Object, false));
					num = (short)150339584;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_45;
				IL_D2:
				num = (short)1833114036;
				short num4 = num;
				num = (short)96672180;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_108;
				}
			}
			IL_108:
			num = (short)1214316544;
			if (num != 0)
			{
			}
			return;
			IL_45:
			uclWideSectionGeneral = (self as global::SpecialFeatures.Ucl.UclWide.UclWideSectionGeneral);
			num = (short)793051137;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}
	}
}
