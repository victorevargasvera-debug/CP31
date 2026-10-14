using System;
using System.Collections.Generic;
using System.Windows;

namespace Infragistics
{
	// Token: 0x020000B9 RID: 185
	public class SmartPlacer
	{
		// Token: 0x060007F6 RID: 2038 RVA: 0x0002599C File Offset: 0x00023B9C
		public SmartPlacer()
		{
			this.Overlap = 0.3;
			this.Fade = 2.0;
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x060007F7 RID: 2039 RVA: 0x000259CD File Offset: 0x00023BCD
		// (set) Token: 0x060007F8 RID: 2040 RVA: 0x000259D5 File Offset: 0x00023BD5
		public global::System.Windows.Rect? Bounds { get; set; }

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060007F9 RID: 2041 RVA: 0x000259DE File Offset: 0x00023BDE
		// (set) Token: 0x060007FA RID: 2042 RVA: 0x000259E6 File Offset: 0x00023BE6
		public double Overlap { get; set; }

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060007FB RID: 2043 RVA: 0x000259EF File Offset: 0x00023BEF
		// (set) Token: 0x060007FC RID: 2044 RVA: 0x000259F7 File Offset: 0x00023BF7
		public double Fade { get; set; }

		// Token: 0x060007FD RID: 2045 RVA: 0x00025A00 File Offset: 0x00023C00
		public void Place(global::Infragistics.ISmartPlaceable smartPlaceable)
		{
			if (smartPlaceable == null)
			{
				return;
			}
			double num = double.MaxValue;
			global::System.Windows.Rect rect = global::System.Windows.Rect.Empty;
			global::Infragistics.SmartPosition smartPosition = global::Infragistics.SmartPosition.CenterBottom;
			bool flag = false;
			foreach (global::Infragistics.SmartPosition smartPosition2 in smartPlaceable.GetSmartPositions())
			{
				global::System.Windows.Rect smartBounds = smartPlaceable.GetSmartBounds(smartPosition2);
				if (this.Bounds == null || this.Bounds.Value.Contains(smartBounds))
				{
					double num2 = 0.0;
					foreach (global::System.Windows.Rect rc in this.placed)
					{
						num2 += smartBounds.IntersectionArea(rc);
					}
					if (num2 == 0.0)
					{
						num = num2;
						smartPosition = smartPosition2;
						rect = smartBounds;
						flag = true;
						break;
					}
					if (num2 < num)
					{
						num = num2;
						smartPosition = smartPosition2;
						rect = smartBounds;
						flag = true;
					}
				}
			}
			double num3 = 0.0;
			if (flag)
			{
				num3 = num / rect.GetArea();
			}
			if (!flag || num3 > this.Overlap)
			{
				smartPlaceable.Opacity = 0.0;
				return;
			}
			if (num > 0.0)
			{
				smartPlaceable.Opacity = global::System.Math.Pow(1.0 - global::Infragistics.MathUtil.Clamp(0.0, num3, 1.0), this.Fade);
			}
			else
			{
				smartPlaceable.Opacity = 1.0;
			}
			smartPlaceable.SmartPosition = smartPosition;
			this.placed.Add(rect);
		}

		// Token: 0x040002E7 RID: 743
		private global::System.Collections.Generic.List<global::System.Windows.Rect> placed = new global::System.Collections.Generic.List<global::System.Windows.Rect>();
	}
}
