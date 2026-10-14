using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace DevComponents.WpfRibbon
{
	// Token: 0x0200000B RID: 11
	internal class BackstageContentAdorner : global::System.Windows.Documents.Adorner
	{
		// Token: 0x0600018A RID: 394 RVA: 0x000284A4 File Offset: 0x000266A4
		public BackstageContentAdorner(global::DevComponents.WpfRibbon.ApplicationMenu adornedElement) : base(adornedElement)
		{
			this._BackstageContentActive = true;
			base.AddLogicalChild(adornedElement.BackstageTab);
			base.AddVisualChild(adornedElement.BackstageTab);
			base.Focusable = true;
			base.FocusVisualStyle = null;
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600018B RID: 395 RVA: 0x000284E8 File Offset: 0x000266E8
		protected override global::System.Collections.IEnumerator LogicalChildren
		{
			get
			{
				short num = (short)980549632;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1419575296;
					short num3 = num;
					switch (num2)
					{
					case 0:
						goto IL_16;
					case 1:
						goto IL_155;
					case 2:
						num = (short)348585985;
						if (num != 0)
						{
						}
						num = (short)1639645187;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (this.ApplicationMenu.BackstageTab != null)
						{
							num = (short)500629505;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_157;
					}
					goto IL_5E;
					IL_16:
					switch (0)
					{
					case 0:
					{
						IL_5E:
						if (!this._BackstageContentActive)
						{
							goto IL_157;
						}
						num = (short)2055860419;
						short num4 = num;
						num = (short)1589506243;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_16;
						default:
							num = (short)578551808;
							if (num != 0)
							{
							}
							num = (short)1532428290;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						break;
					}
					}
				}
				IL_155:
				return new global::System.Collections.Generic.List<global::System.Windows.UIElement>(new global::System.Windows.UIElement[]
				{
					this.ApplicationMenu.BackstageTab
				}).GetEnumerator();
				IL_157:
				return new global::System.Collections.Generic.List<global::System.Windows.UIElement>().GetEnumerator();
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600018C RID: 396 RVA: 0x0002865C File Offset: 0x0002685C
		protected override int VisualChildrenCount
		{
			get
			{
				short num = (short)1746534400;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)815857664;
					short num3 = num;
					switch (num2)
					{
					case 0:
						goto IL_14;
					case 1:
						return 1;
					case 2:
						num = (short)722927619;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (this.ApplicationMenu.BackstageTab != null)
						{
							num = (short)1239941121;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return 0;
					}
					goto IL_5E;
					IL_14:
					switch (0)
					{
					case 0:
					{
						IL_5E:
						num = (short)981532673;
						if (num != 0)
						{
						}
						if (!this._BackstageContentActive)
						{
							return 0;
						}
						num = (short)131904975;
						short num4 = num;
						num = (short)1875359183;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_14;
						default:
							num = (short)1011941376;
							if (num != 0)
							{
							}
							num = (short)2119958530;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						break;
					}
					}
				}
				return 1;
			}
		}

		// Token: 0x0600018D RID: 397 RVA: 0x000287A0 File Offset: 0x000269A0
		protected override global::System.Windows.Media.Visual GetVisualChild(int index)
		{
			short num = (short)926285824;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)2052587520;
				short num3 = num;
				switch (num2)
				{
				case 0:
					goto IL_14;
				case 1:
					goto IL_133;
				case 2:
					num = (short)2013528067;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (index == 0)
					{
						num = (short)1900412929;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_135;
				}
				goto IL_5D;
				IL_14:
				switch (0)
				{
				case 0:
				{
					IL_5D:
					if (!this._BackstageContentActive)
					{
						goto IL_135;
					}
					num = (short)1551036832;
					short num4 = num;
					num = (short)11465120;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					default:
						num = (short)359858177;
						if (num != 0)
						{
						}
						num = (short)961806336;
						if (num != 0)
						{
						}
						num = (short)1896939522;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					break;
				}
				}
			}
			IL_133:
			return this.ApplicationMenu.BackstageTab;
			IL_135:
			return base.GetVisualChild(index);
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600018E RID: 398 RVA: 0x000288EC File Offset: 0x00026AEC
		private global::DevComponents.WpfRibbon.ApplicationMenu ApplicationMenu
		{
			get
			{
				short num = (short)1651776577;
				short num2 = num;
				num = (short)845028417;
				switch (num2 == num)
				{
				}
				num = (short)1218445313;
				if (num != 0)
				{
				}
				num = (short)1460535296;
				if (num != 0)
				{
				}
				num = (short)1298333696;
				short num3 = num;
				return (global::DevComponents.WpfRibbon.ApplicationMenu)base.AdornedElement;
			}
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000289A0 File Offset: 0x00026BA0
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
		{
			short num = (short)101253121;
			int num2 = (int)((global::System.IntPtr)num);
			global::DevComponents.WpfRibbon.ApplicationMenu applicationMenu;
			for (;;)
			{
				num = (short)764590236;
				short num3 = num;
				num = (short)1790228636;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_E5;
				default:
					num = (short)138084352;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						num = (short)911278081;
						if (num != 0)
						{
						}
						applicationMenu = this.ApplicationMenu;
						num = (short)1632305154;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_7C;
						}
						continue;
					case 2:
						goto IL_E5;
					}
					IL_7C:
					if (!this._BackstageContentActive)
					{
						goto IL_17E;
					}
					num = (short)1738276864;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_E5:
			num = (short)1430126592;
			short num4 = num;
			global::System.Windows.UIElement backstageTab = applicationMenu.BackstageTab;
			constraint.Height -= applicationMenu.RenderSize.Height;
			global::DevComponents.WpfRibbon.Ribbon ribbon = applicationMenu.GetRibbon();
			if (ribbon != null && !ribbon.IsUsingGlass)
			{
				constraint.Width -= 1.0;
				constraint.Height -= 8.0;
			}
			backstageTab.Measure(constraint);
			return constraint;
			IL_17E:
			return base.MeasureOverride(constraint);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00028B34 File Offset: 0x00026D34
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			short num = (short)717431022;
			short num2 = num;
			num = (short)94052590;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1414070273;
				if (num != 0)
				{
				}
				num = (short)973799424;
				if (num != 0)
				{
				}
				if (this._BackstageContentActive)
				{
					global::System.Windows.UIElement backstageTab = this.ApplicationMenu.BackstageTab;
					global::System.Windows.Rect finalRect = new global::System.Windows.Rect(finalSize);
					finalRect.Y += this.ApplicationMenu.RenderSize.Height;
					finalRect.Height -= this.ApplicationMenu.RenderSize.Height;
					backstageTab.Arrange(finalRect);
					return base.ArrangeOverride(finalSize);
				}
				break;
			}
			num = (short)898695168;
			short num3 = num;
			return base.ArrangeOverride(finalSize);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00028C50 File Offset: 0x00026E50
		protected override void OnRender(global::System.Windows.Media.DrawingContext drawingContext)
		{
			short num = (short)422117379;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1472724993;
					if (num != 0)
					{
					}
					global::System.Windows.Rect rectangle;
					if (rectangle.Height > 0.0)
					{
						num = (short)388038660;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E2;
				}
				case 1:
					goto IL_1DD;
				case 2:
				{
					global::System.Windows.Rect rectangle = new global::System.Windows.Rect(base.RenderSize);
					num = (short)1866530822;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					switch (0)
					{
					case 0:
						goto IL_40;
					}
					continue;
				case 4:
				{
					global::System.Windows.Rect rectangle;
					rectangle.Y += this.ApplicationMenu.RenderSize.Height;
					rectangle.Height -= this.ApplicationMenu.RenderSize.Height;
					drawingContext.DrawRectangle(global::System.Windows.Media.Brushes.Transparent, null, rectangle);
					num = (short)2048393221;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					goto IL_CD;
				case 6:
				{
					global::System.Windows.Rect rectangle;
					if (rectangle.Width <= 0.0)
					{
						goto IL_1E2;
					}
					num = (short)1216722733;
					short num3 = num;
					num = (short)104118061;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1DD;
					default:
						num = (short)294256640;
						if (num != 0)
						{
						}
						num = (short)534773761;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_40:
				if (this._BackstageContentActive)
				{
					num = (short)65538;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1DD:
				num = (short)1992359936;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_CD:
			IL_1E2:
			num = (short)508821504;
			short num4 = num;
			base.OnRender(drawingContext);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00028E74 File Offset: 0x00027074
		public void RemoveBackstageContent()
		{
			short num = (short)1773848568;
			short num2 = num;
			num = (short)161073144;
			switch (num2 == num)
			{
			}
			num = (short)1410400257;
			if (num != 0)
			{
			}
			num = (short)1638203392;
			if (num != 0)
			{
			}
			num = (short)600768512;
			short num3 = num;
			base.RemoveLogicalChild(this.ApplicationMenu.BackstageTab);
			base.RemoveVisualChild(this.ApplicationMenu.BackstageTab);
			this._BackstageContentActive = false;
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00028F48 File Offset: 0x00027148
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			short num = (short)649592833;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)2109803326;
				short num3 = num;
				num = (short)595200830;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_C7;
				default:
					num = (short)1273757696;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						this.ApplicationMenu.IsPopupOpen = false;
						e.Handled = true;
						num = (short)1969094658;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_7D;
						}
						continue;
					case 2:
						goto IL_C7;
					}
					IL_7D:
					if (e.Key != global::System.Windows.Input.Key.Escape)
					{
						goto IL_C9;
					}
					num = (short)799080448;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_C7:
			IL_C9:
			num = (short)1279787008;
			short num4 = num;
			num = (short)1490944001;
			if (num != 0)
			{
			}
			base.OnKeyDown(e);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00029078 File Offset: 0x00027278
		protected override void OnTextInput(global::System.Windows.Input.TextCompositionEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			global::DevComponents.WpfRibbon.KeyTipsAdorner keyTipsAdorner;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (keyTipsAdorner.ProcessTextInput(e))
					{
						num2 = (short)1438121988;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_187;
				case 1:
					goto IL_15C;
				case 2:
					num2 = (short)2086076422;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (!e.Handled)
					{
						num2 = (short)2098724866;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_187;
				case 4:
					this.ApplicationMenu.ShowKeyTips = false;
					num2 = (short)1104609285;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_9A;
				case 6:
				{
					if (keyTipsAdorner == null)
					{
						goto IL_187;
					}
					num2 = (short)800727588;
					short num3 = num2;
					num2 = (short)1958289956;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15C;
					default:
						num2 = (short)4325376;
						if (num2 != 0)
						{
						}
						num2 = (short)1593114625;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_2C;
				IL_15C:
				num2 = (short)2016083969;
				if (num2 != 0)
				{
				}
				num2 = (short)332595200;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_9A:
			IL_187:
			num2 = (short)2003763200;
			short num4 = num2;
			return;
			IL_2C:
			base.OnTextInput(e);
			keyTipsAdorner = this.ApplicationMenu.m_KeyTipsAdorner;
			num2 = (short)606797827;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0400008E RID: 142
		private bool _BackstageContentActive;
	}
}
