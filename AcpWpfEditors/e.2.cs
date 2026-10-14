using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace DevComponents.WpfEditors
{
	// Token: 0x0200003D RID: 61
	internal class e : global::System.Windows.Documents.Adorner
	{
		// Token: 0x06000450 RID: 1104 RVA: 0x00055DA0 File Offset: 0x00053FA0
		public e(global::DevComponents.WpfEditors.SuperTabControl A_0, global::DevComponents.WpfEditors.SuperTabItem A_1) : base(A_0)
		{
			this.a = new global::DevComponents.WpfEditors.TabDragPreview();
			this.a.DragTab = A_1;
			this.b = A_1;
			base.AddVisualChild(this.a);
			base.AddLogicalChild(this.a);
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00055DEC File Offset: 0x00053FEC
		public void b(global::System.Windows.Point A_0)
		{
			short num = (short)1015449535;
			short num2 = num;
			num = (short)661817279;
			switch (num2 == num)
			{
			default:
			{
				num = (short)442826752;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1890451456;
			if (num != 0)
			{
			}
			num = (short)17498113;
			if (num != 0)
			{
			}
			global::System.Windows.Controls.Canvas.SetTop(this.a, A_0.Y);
			global::System.Windows.Controls.Canvas.SetLeft(this.a, A_0.X);
			base.InvalidateArrange();
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00055EBC File Offset: 0x000540BC
		public global::System.Windows.UIElement b()
		{
			short num = (short)1554317313;
			if (num != 0)
			{
			}
			num = (short)683278336;
			short num2 = num;
			num = (short)857094349;
			short num3 = num;
			num = (short)1561737421;
			switch (num3 == num)
			{
			}
			num = (short)476708864;
			if (num != 0)
			{
			}
			return this.b;
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00055F6C File Offset: 0x0005416C
		public void b(global::System.Windows.UIElement A_0)
		{
			short num = (short)935264257;
			if (num != 0)
			{
			}
			num = (short)1406140416;
			short num2 = num;
			num = (short)1840155358;
			short num3 = num;
			num = (short)830835422;
			switch (num3 == num)
			{
			}
			num = (short)1127153664;
			if (num != 0)
			{
			}
			this.b = A_0;
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00056018 File Offset: 0x00054218
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
		{
			short num = (short)702590236;
			short num2 = num;
			num = (short)1644866844;
			switch (num2 == num)
			{
			default:
			{
				num = (short)770113536;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1614020608;
			if (num != 0)
			{
			}
			num = (short)793444353;
			if (num != 0)
			{
			}
			this.a.Measure(constraint);
			return base.MeasureOverride(constraint);
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x000560D4 File Offset: 0x000542D4
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			short num = (short)232900545;
			short num2 = num;
			num = (short)2075838401;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1239351296;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)797245441;
			if (num != 0)
			{
			}
			num = (short)1518927872;
			if (num != 0)
			{
			}
			this.a.Arrange(new global::System.Windows.Rect(global::System.Windows.Controls.Canvas.GetLeft(this.a), global::System.Windows.Controls.Canvas.GetTop(this.a), this.b.RenderSize.Width, this.b.RenderSize.Width));
			return base.ArrangeOverride(finalSize);
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x000561D4 File Offset: 0x000543D4
		protected override global::System.Collections.IEnumerator get_LogicalChildren()
		{
			short num = (short)557387215;
			short num2 = num;
			num = (short)1198394831;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1434189824;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1783365632;
			if (num != 0)
			{
			}
			num = (short)186974209;
			if (num != 0)
			{
			}
			return new global::System.Collections.Generic.List<global::System.Windows.UIElement>
			{
				this.a
			}.GetEnumerator();
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00056298 File Offset: 0x00054498
		protected override int get_VisualChildrenCount()
		{
			short num = (short)1066958084;
			short num2 = num;
			num = (short)1153596676;
			switch (num2 == num)
			{
			default:
			{
				num = (short)780402688;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1351942145;
			if (num != 0)
			{
			}
			num = (short)1096482816;
			if (num != 0)
			{
			}
			return base.VisualChildrenCount + 1;
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00056348 File Offset: 0x00054548
		protected override global::System.Windows.Media.Visual GetVisualChild(int index)
		{
			while (index == 0)
			{
				short num = (short)522038570;
				short num2 = num;
				num = (short)2015538474;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)900661249;
					if (num != 0)
					{
					}
					num = (short)870842368;
					if (num != 0)
					{
					}
					num = (short)435879936;
					short num3 = num;
					return this.a;
				}
				}
			}
			return base.GetVisualChild(index);
		}

		// Token: 0x0400022A RID: 554
		private global::DevComponents.WpfEditors.TabDragPreview a;

		// Token: 0x0400022B RID: 555
		private global::System.Windows.UIElement b;
	}
}
