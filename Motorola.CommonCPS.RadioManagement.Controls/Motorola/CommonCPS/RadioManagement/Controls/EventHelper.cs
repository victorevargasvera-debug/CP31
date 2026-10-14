using System;
using System.Windows;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000071 RID: 113
	public static class EventHelper
	{
		// Token: 0x06000261 RID: 609 RVA: 0x00028340 File Offset: 0x00026540
		public static void SubscribeOneShot(global::System.Action<global::System.Windows.RoutedEventHandler> subscribe, global::System.Action<global::System.Windows.RoutedEventHandler> unsubscribe, global::System.Windows.RoutedEventHandler handler)
		{
			short num = (short)1548671601;
			short num2 = num;
			num = (short)1763629681;
			switch (num2 == num)
			{
			}
			num = (short)1486946304;
			short num3 = num;
			num = (short)1859321857;
			if (num != 0)
			{
			}
			num = (short)1772158976;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.EventHelper.<>c__DisplayClass0_0 CS$<>8__locals1 = new global::Motorola.CommonCPS.RadioManagement.Controls.EventHelper.<>c__DisplayClass0_0();
			CS$<>8__locals1.a = unsubscribe;
			CS$<>8__locals1.c = handler;
			CS$<>8__locals1.b = null;
			CS$<>8__locals1.b = new global::System.Windows.RoutedEventHandler(CS$<>8__locals1.d);
			subscribe(CS$<>8__locals1.b);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00028424 File Offset: 0x00026624
		public static void SubscribeOneShot(global::System.Action<global::System.Windows.DependencyPropertyChangedEventHandler> subscribe, global::System.Action<global::System.Windows.DependencyPropertyChangedEventHandler> unsubscribe, global::System.Windows.DependencyPropertyChangedEventHandler handler)
		{
			short num = (short)2146518677;
			short num2 = num;
			num = (short)606422677;
			switch (num2 == num)
			{
			}
			num = (short)110821376;
			short num3 = num;
			num = (short)2145583105;
			if (num != 0)
			{
			}
			num = (short)245432320;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.EventHelper.<>c__DisplayClass1_0 CS$<>8__locals1 = new global::Motorola.CommonCPS.RadioManagement.Controls.EventHelper.<>c__DisplayClass1_0();
			CS$<>8__locals1.a = unsubscribe;
			CS$<>8__locals1.c = handler;
			CS$<>8__locals1.b = null;
			CS$<>8__locals1.b = new global::System.Windows.DependencyPropertyChangedEventHandler(CS$<>8__locals1.d);
			subscribe(CS$<>8__locals1.b);
		}
	}
}
