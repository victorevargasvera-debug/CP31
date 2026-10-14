using System;
using System.Collections;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon.KeyTips
{
	// Token: 0x020000CD RID: 205
	internal class ButtonPopupKeyRenderer : global::DevComponents.WpfRibbon.KeyTips.KeyTipRenderer
	{
		// Token: 0x060008A9 RID: 2217 RVA: 0x000C45A8 File Offset: 0x000C27A8
		public override void Render(global::System.Windows.Media.DrawingContext dc, object elem, global::DevComponents.WpfRibbon.KeyTipRenderInfo info)
		{
			int a_ = 19;
			short num = (short)986578944;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_70;
				}
				global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown;
				for (;;)
				{
					IL_30:
					num = (short)1498939392;
					short num3 = num;
					switch (num2)
					{
					case 0:
						goto IL_C2;
					case 1:
						num = (short)83558400;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						if (buttonDropDown == null)
						{
							num = (short)1201930241;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.Size renderSize = buttonDropDown.Popup.RenderSize;
						global::System.Collections.IEnumerator enumerator = ((global::System.Collections.IEnumerable)buttonDropDown.Items).GetEnumerator();
						num = (short)822018051;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_42B;
					}
					goto IL_70;
				}
				IL_C2:
				string str = global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㥪࡬Ůᕰᙲݴቶ୸孺ṼṾꎂﶎ놐ﲒﮔﮖ뮚ﶞ쮠욢욤펦\udaa8讪슬즮醰잲체잶\udcb8鮺ﾼ쪾뗀럂꫄꧆跈맊ꋌ뿎闐볒ꋔ맖律곚뗜뛞跠蛢엤苦藨軪胬쿮藰諲藴鋶\ud9f8鋺軼\udffe", a_);
				global::System.Type type = elem.GetType();
				string str2 = (type != null) ? type.ToString() : null;
				IL_3F0:
				throw new global::System.InvalidOperationException(str + str2);
				IL_42B:
				try
				{
					num = (short)1237188618;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							global::System.Windows.UIElement uielement;
							if (uielement.Visibility == global::System.Windows.Visibility.Visible)
							{
								num = (short)1858994188;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
						{
							global::System.Windows.UIElement uielement;
							if (uielement is global::System.Windows.Controls.Panel)
							{
								num = (short)1195048968;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1972795032;
							short num4 = num;
							num = (short)1069250200;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
							{
								num = (short)736690176;
								if (num != 0)
								{
								}
								global::System.Windows.Size renderSize;
								this.ProcessUIElement(uielement, dc, info, buttonDropDown.Popup, renderSize);
								break;
							}
							}
							num = (short)950468619;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							num = (short)111345665;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							num = (short)1116012544;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							num = (short)117440525;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
						{
							global::System.Windows.UIElement uielement;
							if (uielement != null)
							{
								num = (short)873463811;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 7:
						{
							global::System.Windows.UIElement uielement;
							if (uielement.IsVisible)
							{
								num = (short)369426434;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 8:
						{
							global::System.Windows.Size renderSize;
							global::System.Windows.UIElement uielement;
							this.ProcessPanel(uielement as global::System.Windows.Controls.Panel, dc, info, buttonDropDown.Popup, renderSize);
							num = (short)1048313862;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
						{
							global::System.Collections.IEnumerator enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)240451588;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Windows.UIElement uielement = enumerator.Current as global::System.Windows.UIElement;
							num = (short)1488191493;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
							switch (0)
							{
							case 0:
								goto IL_14A;
							}
							continue;
						case 12:
							num = (short)2104557569;
							if (num != 0)
							{
							}
							num = (short)2142306311;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							goto IL_376;
						}
						IL_1B7:
						num = (short)1531838473;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_14A:
						goto IL_1B7;
					}
					IL_376:
					return;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_398;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_385:
						switch (num2)
						{
						case 0:
							disposable.Dispose();
							num = (short)1858535426;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (disposable != null)
							{
								num = (short)1339752448;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3EF;
						case 2:
							goto IL_3ED;
						}
						goto IL_398;
					}
					IL_3ED:
					IL_3EF:
					goto EndFinally_11;
					IL_398:
					global::System.Collections.IEnumerator enumerator;
					disposable = (enumerator as global::System.IDisposable);
					num = (short)313458689;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_385;
					EndFinally_11:;
				}
				goto IL_3F0;
				IL_70:
				buttonDropDown = (elem as global::DevComponents.WpfRibbon.ButtonDropDown);
				num = (short)967966722;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x000C4A04 File Offset: 0x000C2C04
		protected virtual void ProcessPanel(global::System.Windows.Controls.Panel panel, global::System.Windows.Media.DrawingContext dc, global::DevComponents.WpfRibbon.KeyTipRenderInfo info, global::System.Windows.UIElement container, global::System.Windows.Size popupSize)
		{
			short num = (short)330301441;
			if (num != 0)
			{
			}
			num = (short)590020608;
			short num2 = num;
			global::System.Collections.IEnumerator enumerator = panel.Children.GetEnumerator();
			try
			{
				num = (short)485097480;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 1:
						num = (short)1833959435;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						global::System.Windows.UIElement uielement;
						if (uielement.Visibility == global::System.Windows.Visibility.Visible)
						{
							num = (short)1230700550;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
					{
						global::System.Windows.UIElement uielement;
						this.ProcessPanel(uielement as global::System.Windows.Controls.Panel, dc, info, container, popupSize);
						num = (short)343670784;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						num = (short)653536595;
						short num4 = num;
						num = (short)85732691;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_220;
						default:
						{
							num = (short)571932672;
							if (num != 0)
							{
							}
							global::System.Windows.UIElement uielement;
							if (uielement.IsVisible)
							{
								num = (short)1004994570;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						break;
					}
					case 5:
					{
						global::System.Windows.UIElement uielement;
						if (uielement is global::System.Windows.Controls.Panel)
						{
							num = (short)1809055747;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.ProcessUIElement(uielement, dc, info, container, popupSize);
						num = (short)1358430217;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						num = (short)2010054660;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)201326593;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)enumerator.Current;
						num = (short)1510866946;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						switch (0)
						{
						case 0:
							goto IL_B4;
						}
						continue;
					case 10:
						goto IL_220;
					case 11:
						goto IL_271;
					}
					IL_13E:
					num = (short)109838343;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_B4:
					goto IL_13E;
					IL_220:
					num = (short)1809645573;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_271:;
			}
			finally
			{
				switch (0)
				{
				case 0:
					goto IL_28F;
				}
				int num3;
				global::System.IDisposable disposable;
				for (;;)
				{
					IL_27D:
					switch (num3)
					{
					case 0:
						disposable.Dispose();
						num = (short)1917190146;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (disposable != null)
						{
							num = (short)1055457280;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2DF;
					case 2:
						goto IL_2DD;
					}
					goto IL_28F;
				}
				IL_2DD:
				IL_2DF:
				goto EndFinally_8;
				IL_28F:
				disposable = (enumerator as global::System.IDisposable);
				num = (short)2089287681;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_27D;
				EndFinally_8:;
			}
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x000C4D10 File Offset: 0x000C2F10
		protected virtual void ProcessUIElement(global::System.Windows.UIElement e, global::System.Windows.Media.DrawingContext dc, global::DevComponents.WpfRibbon.KeyTipRenderInfo info, global::System.Windows.UIElement container, global::System.Windows.Size popupSize)
		{
			short num = (short)1361249284;
			short num2 = num;
			num = (short)523043844;
			switch (num2 == num)
			{
			}
			num = (short)904462337;
			if (num != 0)
			{
			}
			num = (short)1444413440;
			if (num != 0)
			{
			}
			num = (short)1767702528;
			short num3 = num;
			global::System.Windows.Point point = e.PointToScreen(default(global::System.Windows.Point));
			point = container.PointFromScreen(point);
			global::System.Windows.Rect rect = new global::System.Windows.Rect(point, e.RenderSize);
			point = new global::System.Windows.Point(rect.X + 16.0, rect.Bottom - global::DevComponents.WpfRibbon.KeyTips.KeyTipRenderer.DefaultKeyTipSize.Height * 0.92);
			point = container.PointToScreen(point);
			point = info.Adorner.PointFromScreen(point);
			point.X = global::System.Math.Round(point.X) + 0.5;
			point.Y = global::System.Math.Round(point.Y) + 0.5;
			this.RenderKeyTip(dc, info, e, point);
			this.RecordActiveKeyTip(e, info);
		}
	}
}
