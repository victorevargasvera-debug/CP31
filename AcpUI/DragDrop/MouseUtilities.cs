using System;
using System.Windows;
using System.Windows.Media;
using AcpUI.Common;

namespace AcpUI.DragDrop
{
	// Token: 0x0200006F RID: 111
	public class MouseUtilities
	{
		// Token: 0x060005B6 RID: 1462 RVA: 0x00073014 File Offset: 0x00071214
		public static global::System.Windows.Point GetMousePosition(global::System.Windows.Media.Visual relativeTo)
		{
			short num = (short)1243466968;
			short num2 = num;
			num = (short)1789447384;
			switch (num2 == num)
			{
			}
			num = (short)1293811712;
			short num3 = num;
			num = (short)738328577;
			if (num != 0)
			{
			}
			num = (short)830341120;
			if (num != 0)
			{
			}
			global::AcpUI.Common.NativeMethods.Win32Point win32Point = default(global::AcpUI.Common.NativeMethods.Win32Point);
			global::AcpUI.Common.NativeMethods.GetCursorPos(ref win32Point);
			return relativeTo.PointFromScreen(new global::System.Windows.Point((double)win32Point.a, (double)win32Point.b));
		}
	}
}
