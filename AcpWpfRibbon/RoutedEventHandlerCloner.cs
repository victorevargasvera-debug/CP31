using System;
using System.Reflection;
using System.Windows;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon
{
	// Token: 0x020000A2 RID: 162
	internal static class RoutedEventHandlerCloner
	{
		// Token: 0x06000811 RID: 2065 RVA: 0x000BC400 File Offset: 0x000BA600
		internal static bool CopyHandlers(global::System.Windows.UIElement source, global::System.Windows.UIElement target, global::System.Windows.RoutedEvent eventToCopy)
		{
			int a_ = 19;
			short num = (short)1319632896;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_77;
				}
				object value;
				global::System.Reflection.MethodInfo method2;
				global::System.Type type;
				global::System.Reflection.PropertyInfo property;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
					{
						global::System.Windows.RoutedEventHandlerInfo[] array;
						if (array != null)
						{
							num = (short)1630339078;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 1:
						goto IL_26F;
					case 2:
					{
						global::System.Reflection.MethodInfo method;
						if (method == null)
						{
							num = (short)105381896;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.RoutedEventHandlerInfo[] array = method.Invoke(value, new object[]
						{
							eventToCopy
						}) as global::System.Windows.RoutedEventHandlerInfo[];
						num = (short)1159987200;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						if (value == null)
						{
							num = (short)1042087943;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Reflection.MethodInfo method = value.GetType().GetMethod(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ⱪ࡬᭮⍰ᱲtͶᱸὺ㡼ॾ쾆", a_), global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic);
						num = (short)681771010;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						if (method2 == null)
						{
							num = (short)1217986573;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						method2.Invoke(source, null);
						property = type.GetProperty(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⹪᭬੮ὰݲ㵴ᙶ᝸ὺᅼ᩾횄力", a_), global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.NonPublic);
						num = (short)399310860;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_22E;
					case 6:
						num = (short)93847561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						return false;
					case 8:
						return false;
					case 9:
					{
						global::System.Windows.RoutedEventHandlerInfo[] array;
						if (array.Length == 0)
						{
							num = (short)1713831941;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.RoutedEventHandlerInfo[] array2 = array;
						int num3 = 0;
						num = (short)1094385679;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_233;
					case 11:
						goto IL_1EF;
					case 12:
						if (property == null)
						{
							num = (short)2019557387;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D4;
					case 13:
						return false;
					case 14:
					{
						global::System.Windows.RoutedEventHandlerInfo[] array2;
						int num3;
						if (num3 >= array2.Length)
						{
							num = (short)1757478913;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.RoutedEventHandlerInfo routedEventHandlerInfo = array2[num3];
						target.AddHandler(eventToCopy, routedEventHandlerInfo.Handler, routedEventHandlerInfo.InvokeHandledEventsToo);
						num3++;
						num = (short)713752586;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						goto IL_233;
					}
					goto IL_77;
					IL_233:
					num = (short)2141978638;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_1EF:
				num = (short)2111242241;
				if (num != 0)
				{
				}
				return false;
				IL_22E:
				return false;
				IL_26F:
				num = (short)2067464192;
				short num4 = num;
				return true;
				IL_2D4:
				value = property.GetValue(source, null);
				goto IL_2DD;
				IL_77:
				type = source.GetType();
				method2 = type.GetMethod(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⹪ͬᱮѰŲၴ㉶ླྀṺ፼୾즀ﾌﲎ슐杖ﲘ", a_), global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.NonPublic);
				num = (short)1791740429;
				short num5 = num;
				num = (short)750373389;
				switch ((num5 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_2DD:
					num = (short)20381699;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_30;
				default:
					num = (short)61210624;
					if (num != 0)
					{
					}
					num = (short)439943172;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_30;
				}
				break;
			}
			}
		}
	}
}
