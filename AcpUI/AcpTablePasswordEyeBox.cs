using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace AcpUI
{
	// Token: 0x0200002A RID: 42
	public class AcpTablePasswordEyeBox : global::AcpUI.AcpPasswordEyeBox
	{
		// Token: 0x0600025C RID: 604 RVA: 0x0002C7F4 File Offset: 0x0002A9F4
		public AcpTablePasswordEyeBox()
		{
			this.b.BorderThickness = new global::System.Windows.Thickness(0.0, 0.0, 0.0, 0.0);
			this.c.BorderThickness = new global::System.Windows.Thickness(0.0, 0.0, 0.0, 0.0);
			this.d.BorderThickness = new global::System.Windows.Thickness(0.0, 0.0, 0.0, 0.0);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0002C8A4 File Offset: 0x0002AAA4
		protected override void OnPreviewKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			short num = (short)1239652880;
			short num2 = num;
			num = (short)1149278736;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1238958080;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)695533569;
			if (num != 0)
			{
			}
			num = (short)163774464;
			if (num != 0)
			{
			}
			this.AcpTablePasswordEyeBox_PreviewKeyDown(null, e);
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0002C958 File Offset: 0x0002AB58
		protected override void OnPreviewMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)518586369;
			if (num != 0)
			{
			}
			num = (short)1303445504;
			short num2 = num;
			num = (short)503345334;
			short num3 = num;
			num = (short)1803186358;
			switch (num3 == num)
			{
			}
			num = (short)1492516864;
			if (num != 0)
			{
			}
			this.AcpTablePasswordEyeBox_PreviewMouseLeftButtonDown(null, e);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0002CA08 File Offset: 0x0002AC08
		public void AcpTablePasswordEyeBox_PreviewKeyDown(object sender, global::System.Windows.Input.KeyEventArgs e)
		{
			short num;
			if (e.Key == global::System.Windows.Input.Key.Tab)
			{
				num = (short)1680945916;
				short num2 = num;
				num = (short)1405760252;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2015297536;
					short num3 = num;
					num = (short)982581248;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
			num = (short)1952841729;
			if (num != 0)
			{
			}
			this.b.CaretBrush = global::System.Windows.Media.Brushes.Black;
			this.b.Focus();
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0002CAD8 File Offset: 0x0002ACD8
		public void AcpTablePasswordEyeBox_PreviewMouseLeftButtonDown(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)1688272897;
			if (num != 0)
			{
			}
			if (!base.IsFocused)
			{
				num = (short)833817603;
				short num2 = num;
				num = (short)1422330883;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_BB;
				case 1:
					break;
				default:
				{
					num = (short)845152256;
					short num3 = num;
					break;
				}
				}
				num = (short)2014052352;
				if (num != 0)
				{
				}
				this.b.CaretBrush = global::System.Windows.Media.Brushes.Transparent;
				return;
			}
			IL_BB:
			this.b.CaretBrush = global::System.Windows.Media.Brushes.Black;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0002CBB0 File Offset: 0x0002ADB0
		protected override void OnGotFocus(global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1108934657;
			if (num != 0)
			{
			}
			num = (short)1433337856;
			short num2 = num;
			num = (short)748120471;
			short num3 = num;
			num = (short)1190357399;
			switch (num3 == num)
			{
			}
			num = (short)1987706880;
			if (num != 0)
			{
			}
			this.b.CaretBrush = global::System.Windows.Media.Brushes.Transparent;
			base.OnGotFocus(e);
		}
	}
}
