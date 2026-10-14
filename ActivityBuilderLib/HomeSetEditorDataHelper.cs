using System;

namespace Motorola.CommonCPS.RadioManagement.ActivityBuilderLib
{
	// Token: 0x02000006 RID: 6
	public static class HomeSetEditorDataHelper
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00002C00 File Offset: 0x00000E00
		public static global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetBase GenerateWidgetObjectByItemType(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType itemType, int X, int Y, int SpanX, int SpanY, string guidString)
		{
			short num = (short)209911808;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_47;
				}
				global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetBase result;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						goto IL_18C;
					case 1:
						goto IL_1DE;
					case 2:
						return result;
					case 3:
						switch (itemType)
						{
						case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.sShortcut:
							result = new global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.ShortcutWidget
							{
								X = X,
								Y = Y,
								WidgetItemType = itemType,
								SpanX = SpanX,
								SpanY = SpanY,
								GuidId = guidString
							};
							num = (short)384499714;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMyStatus:
						case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wQuery:
						case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMyIncident:
						case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wStatusMonitor:
						case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wRadio:
						case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wSearch:
						case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMappingSimple:
						case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMessagingSimple:
						case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMessagingAdv:
						case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wCalendarSimple:
						case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wCalendarAdv:
						case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMyApps:
						case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wCoreApp:
							goto IL_191;
						case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMappingAdv:
							result = new global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.MapWidget
							{
								WidgetItemType = itemType,
								X = X,
								Y = Y,
								SpanX = SpanX,
								SpanY = SpanY,
								GuidId = guidString,
								MapType = global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.MapItemType.Unconfigured
							};
							num = (short)222691328;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType.wMapNoType:
							return result;
						default:
							num = (short)1011810309;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 4:
						return result;
					case 5:
						num = (short)2088435716;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_47;
				}
				IL_18C:
				return result;
				IL_191:
				result = new global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.AppWidget
				{
					WidgetItemType = itemType,
					X = X,
					Y = Y,
					SpanX = SpanX,
					SpanY = SpanY,
					GuidId = guidString
				};
				goto IL_1C5;
				IL_1DE:
				num = (short)2067464192;
				short num3 = num;
				return result;
				IL_47:
				num = (short)947781633;
				if (num != 0)
				{
				}
				result = null;
				num = (short)208560943;
				short num4 = num;
				num = (short)1377788719;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_1C5:
					num = (short)1891958785;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				default:
					num = (short)590348288;
					if (num != 0)
					{
					}
					num = (short)1343160323;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				break;
			}
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002E88 File Offset: 0x00001088
		public static global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.MapWidget GenerateMapWidgetObject(global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.WidgetItemType itemType, int X, int Y, int SpanX, int SpanY, string guidString, global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.MapItemType mapType)
		{
			short num = (short)854042922;
			short num2 = num;
			num = (short)1278060842;
			switch (num2 == num)
			{
			}
			num = (short)843644928;
			short num3 = num;
			num = (short)630980608;
			if (num != 0)
			{
			}
			num = (short)1986134017;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.MapWidget
			{
				WidgetItemType = itemType,
				X = X,
				Y = Y,
				SpanX = SpanX,
				SpanY = SpanY,
				GuidId = guidString,
				MapType = mapType
			};
		}
	}
}
