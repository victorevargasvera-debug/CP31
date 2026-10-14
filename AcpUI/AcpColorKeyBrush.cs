using System;
using System.Windows;
using System.Windows.Media;

namespace AcpUI
{
	// Token: 0x0200000E RID: 14
	public class AcpColorKeyBrush
	{
		// Token: 0x060000BC RID: 188 RVA: 0x00010E14 File Offset: 0x0000F014
		public static global::System.Windows.Media.Brush GetBrushFromColorKey(global::System.Type type, string colorKey)
		{
			short num = (short)544026207;
			short num2 = num;
			num = (short)697445983;
			switch (num2 == num)
			{
			}
			num = (short)758317056;
			short num3 = num;
			num = (short)170459136;
			if (num != 0)
			{
			}
			num = (short)359727105;
			if (num != 0)
			{
			}
			global::System.Windows.ComponentResourceKey resourceKey = new global::System.Windows.ComponentResourceKey(type, colorKey);
			return (global::System.Windows.Media.Brush)new global::System.Windows.FrameworkElement().TryFindResource(resourceKey);
		}
	}
}
