using System;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Shapes;

namespace AcpUI.DragDrop
{
	// Token: 0x0200006B RID: 107
	public class ListBoxDragAdorner : global::System.Windows.Documents.Adorner
	{
		// Token: 0x06000579 RID: 1401 RVA: 0x0006E9B4 File Offset: 0x0006CBB4
		internal ListBoxDragAdorner(global::System.Windows.UIElement A_0, global::System.Windows.Size A_1, global::System.Windows.Media.Brush A_2) : base(A_0)
		{
			this.a = new global::System.Windows.Shapes.Rectangle
			{
				Fill = A_2,
				Width = A_1.Width,
				Height = A_1.Height,
				IsHitTestVisible = false
			};
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x0006EA00 File Offset: 0x0006CC00
		public override global::System.Windows.Media.GeneralTransform GetDesiredTransform(global::System.Windows.Media.GeneralTransform transform)
		{
			short num = (short)577503233;
			if (num != 0)
			{
			}
			num = (short)1289402225;
			short num2 = num;
			num = (short)252950385;
			switch (num2 == num)
			{
			}
			num = (short)1122172928;
			short num3 = num;
			num = (short)2114650112;
			if (num != 0)
			{
			}
			return new global::System.Windows.Media.GeneralTransformGroup
			{
				Children = 
				{
					base.GetDesiredTransform(transform),
					new global::System.Windows.Media.TranslateTransform(this.b, this.c)
				}
			};
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x0006EADC File Offset: 0x0006CCDC
		// (set) Token: 0x0600057C RID: 1404 RVA: 0x0006EB8C File Offset: 0x0006CD8C
		internal double OffsetLeft
		{
			get
			{
				short num = (short)1080335612;
				short num2 = num;
				num = (short)589077756;
				switch (num2 == num)
				{
				}
				num = (short)367460353;
				if (num != 0)
				{
				}
				num = (short)371458048;
				short num3 = num;
				num = (short)846004224;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)200732419;
				short num2 = num;
				num = (short)751824643;
				switch (num2 == num)
				{
				}
				num = (short)1728118784;
				if (num != 0)
				{
				}
				num = (short)371851264;
				short num3 = num;
				num = (short)1829306369;
				if (num != 0)
				{
				}
				this.b = value;
				this.a();
			}
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x0006EC44 File Offset: 0x0006CE44
		internal void a(double A_0, double A_1)
		{
			short num = (short)921955138;
			short num2 = num;
			num = (short)600173378;
			switch (num2 == num)
			{
			}
			num = (short)681902080;
			if (num != 0)
			{
			}
			num = (short)1275068416;
			short num3 = num;
			num = (short)1508048897;
			if (num != 0)
			{
			}
			this.b = A_0;
			this.c = A_1;
			this.a();
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x0600057E RID: 1406 RVA: 0x0006ED04 File Offset: 0x0006CF04
		// (set) Token: 0x0600057F RID: 1407 RVA: 0x0006EDB0 File Offset: 0x0006CFB0
		internal double OffsetTop
		{
			get
			{
				short num = (short)1986222056;
				short num2 = num;
				num = (short)1206802408;
				switch (num2 == num)
				{
				}
				num = (short)714670081;
				if (num != 0)
				{
				}
				num = (short)1149632512;
				short num3 = num;
				num = (short)643432448;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)1775032383;
				short num2 = num;
				num = (short)1212799039;
				switch (num2 == num)
				{
				}
				num = (short)266469376;
				if (num != 0)
				{
				}
				num = (short)455344128;
				short num3 = num;
				num = (short)1559756801;
				if (num != 0)
				{
				}
				this.c = value;
				this.a();
			}
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x0006EE68 File Offset: 0x0006D068
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
		{
			short num = (short)1947353660;
			short num2 = num;
			num = (short)2068464188;
			switch (num2 == num)
			{
			}
			num = (short)1871380481;
			if (num != 0)
			{
			}
			num = (short)2044985344;
			short num3 = num;
			num = (short)1829240832;
			if (num != 0)
			{
			}
			this.a.Measure(constraint);
			return this.a.DesiredSize;
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x0006EF28 File Offset: 0x0006D128
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			short num = (short)1655644125;
			short num2 = num;
			num = (short)1519525853;
			switch (num2 == num)
			{
			}
			num = (short)1635385345;
			if (num != 0)
			{
			}
			num = (short)281739264;
			short num3 = num;
			num = (short)1921777664;
			if (num != 0)
			{
			}
			this.a.Arrange(new global::System.Windows.Rect(finalSize));
			return finalSize;
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x0006EFE4 File Offset: 0x0006D1E4
		protected override global::System.Windows.Media.Visual GetVisualChild(int index)
		{
			short num = (short)848500434;
			short num2 = num;
			num = (short)1751324370;
			switch (num2 == num)
			{
			}
			num = (short)1787297793;
			if (num != 0)
			{
			}
			num = (short)1543176192;
			short num3 = num;
			num = (short)1874001920;
			if (num != 0)
			{
			}
			return this.a;
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x0006F098 File Offset: 0x0006D298
		protected override int VisualChildrenCount
		{
			get
			{
				short num = (short)564074305;
				short num2 = num;
				num = (short)556996417;
				switch (num2 == num)
				{
				}
				num = (short)154140673;
				if (num != 0)
				{
				}
				num = (short)348258304;
				short num3 = num;
				num = (short)1062928384;
				if (num != 0)
				{
				}
				return 1;
			}
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x0006F140 File Offset: 0x0006D340
		private void a()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
				{
					num2 = (short)978452481;
					if (num2 != 0)
					{
					}
					global::System.Windows.Documents.AdornerLayer adornerLayer;
					adornerLayer.Update(base.AdornedElement);
					num2 = (short)1883308033;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					goto IL_11A;
				case 2:
				{
					global::System.Windows.Documents.AdornerLayer adornerLayer;
					if (adornerLayer != null)
					{
						num2 = (short)1195376640;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				}
				break;
			}
			IL_1C:
			num2 = (short)330361209;
			short num3 = num2;
			num2 = (short)356575609;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_11A:
				break;
			default:
			{
				num2 = (short)445186048;
				if (num2 != 0)
				{
				}
				global::System.Windows.Documents.AdornerLayer adornerLayer = base.Parent as global::System.Windows.Documents.AdornerLayer;
				num2 = (short)891420672;
				short num4 = num2;
				num2 = (short)276627458;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x040002F1 RID: 753
		private global::System.Windows.Shapes.Rectangle a;

		// Token: 0x040002F2 RID: 754
		private double b;

		// Token: 0x040002F3 RID: 755
		private double c;
	}
}
