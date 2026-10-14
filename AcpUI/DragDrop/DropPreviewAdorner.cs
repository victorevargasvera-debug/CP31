using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace AcpUI.DragDrop
{
	// Token: 0x0200006A RID: 106
	public class DropPreviewAdorner : global::System.Windows.Documents.Adorner
	{
		// Token: 0x17000187 RID: 391
		// (get) Token: 0x0600056E RID: 1390 RVA: 0x0006E1CC File Offset: 0x0006C3CC
		// (set) Token: 0x0600056F RID: 1391 RVA: 0x0006E27C File Offset: 0x0006C47C
		internal double Left
		{
			get
			{
				short num = (short)2042691584;
				short num2 = num;
				num = (short)1967981244;
				short num3 = num;
				num = (short)1996554940;
				switch (num3 == num)
				{
				}
				num = (short)1457586176;
				if (num != 0)
				{
				}
				num = (short)630128641;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)1727987712;
				short num2 = num;
				num = (short)1662957023;
				short num3 = num;
				num = (short)495629791;
				switch (num3 == num)
				{
				}
				num = (short)1627717633;
				if (num != 0)
				{
				}
				num = (short)471728128;
				if (num != 0)
				{
				}
				this.b = value;
				this.a();
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000570 RID: 1392 RVA: 0x0006E334 File Offset: 0x0006C534
		// (set) Token: 0x06000571 RID: 1393 RVA: 0x0006E3E4 File Offset: 0x0006C5E4
		internal double Top
		{
			get
			{
				short num = (short)1975517184;
				short num2 = num;
				num = (short)1066598401;
				if (num != 0)
				{
				}
				num = (short)394289601;
				short num3 = num;
				num = (short)2092130753;
				switch (num3 == num)
				{
				}
				num = (short)76349440;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)1549729792;
				short num2 = num;
				num = (short)995949476;
				short num3 = num;
				num = (short)1536687012;
				switch (num3 == num)
				{
				}
				num = (short)1838874625;
				if (num != 0)
				{
				}
				num = (short)1313144832;
				if (num != 0)
				{
				}
				this.c = value;
				this.a();
			}
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x0006E49C File Offset: 0x0006C69C
		internal DropPreviewAdorner(global::System.Windows.UIElement A_0, global::System.Windows.UIElement A_1) : base(A_1)
		{
			this.a = new global::System.Windows.Controls.ContentPresenter();
			this.a.Content = A_0;
			this.a.IsHitTestVisible = false;
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x0006E4D4 File Offset: 0x0006C6D4
		private void a()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::System.Windows.Documents.AdornerLayer adornerLayer;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (adornerLayer != null)
					{
						num2 = (short)1144651777;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
				{
					num2 = (short)1056977978;
					short num3 = num2;
					num2 = (short)1189557306;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)1693843456;
						if (num2 != 0)
						{
						}
						num2 = (short)1804337153;
						if (num2 != 0)
						{
						}
						adornerLayer.Update(base.AdornedElement);
						num2 = (short)1487601666;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			adornerLayer = (base.Parent as global::System.Windows.Documents.AdornerLayer);
			num2 = (short)1361510400;
			short num4 = num2;
			num2 = (short)1366949888;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x0006E5FC File Offset: 0x0006C7FC
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
		{
			short num = (short)208470016;
			short num2 = num;
			num = (short)462277589;
			short num3 = num;
			num = (short)719702997;
			switch (num3 == num)
			{
			}
			num = (short)1226571776;
			if (num != 0)
			{
			}
			num = (short)899153921;
			if (num != 0)
			{
			}
			this.a.Measure(constraint);
			return this.a.DesiredSize;
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x0006E6B8 File Offset: 0x0006C8B8
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			short num = (short)431850570;
			short num2 = num;
			num = (short)487162954;
			switch (num2 == num)
			{
			}
			num = (short)1655373825;
			if (num != 0)
			{
			}
			num = (short)1958281216;
			short num3 = num;
			num = (short)1585971200;
			if (num != 0)
			{
			}
			this.a.Arrange(new global::System.Windows.Rect(finalSize));
			return finalSize;
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x0006E778 File Offset: 0x0006C978
		protected override global::System.Windows.Media.Visual GetVisualChild(int index)
		{
			short num = (short)1851310935;
			short num2 = num;
			num = (short)938787671;
			switch (num2 == num)
			{
			}
			num = (short)1112276993;
			if (num != 0)
			{
			}
			num = (short)884867072;
			short num3 = num;
			num = (short)440532992;
			if (num != 0)
			{
			}
			return this.a;
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x0006E82C File Offset: 0x0006CA2C
		protected override int VisualChildrenCount
		{
			get
			{
				short num = (short)2003173377;
				if (num != 0)
				{
				}
				num = (short)348363904;
				short num2 = num;
				num = (short)114596992;
				switch (num2 == num)
				{
				}
				num = (short)1450246144;
				short num3 = num;
				num = (short)146931712;
				if (num != 0)
				{
				}
				return 1;
			}
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x0006E8D4 File Offset: 0x0006CAD4
		public override global::System.Windows.Media.GeneralTransform GetDesiredTransform(global::System.Windows.Media.GeneralTransform transform)
		{
			short num = (short)254008337;
			short num2 = num;
			num = (short)2008144913;
			switch (num2 == num)
			{
			}
			num = (short)1229258752;
			if (num != 0)
			{
			}
			num = (short)1321926656;
			short num3 = num;
			num = (short)164429825;
			if (num != 0)
			{
			}
			return new global::System.Windows.Media.GeneralTransformGroup
			{
				Children = 
				{
					new global::System.Windows.Media.TranslateTransform(this.Left, this.Top),
					base.GetDesiredTransform(transform)
				}
			};
		}

		// Token: 0x040002EE RID: 750
		private global::System.Windows.Controls.ContentPresenter a;

		// Token: 0x040002EF RID: 751
		private double b;

		// Token: 0x040002F0 RID: 752
		private double c;
	}
}
