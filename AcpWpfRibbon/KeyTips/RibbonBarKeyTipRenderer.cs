using System;
using System.Collections;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon.KeyTips
{
	// Token: 0x020000D0 RID: 208
	internal class RibbonBarKeyTipRenderer : global::DevComponents.WpfRibbon.KeyTips.KeyTipRenderer
	{
		// Token: 0x060008B9 RID: 2233 RVA: 0x000C5E58 File Offset: 0x000C4058
		public override void Render(global::System.Windows.Media.DrawingContext dc, object elem, global::DevComponents.WpfRibbon.KeyTipRenderInfo info)
		{
			int a_ = 1;
			short num = (short)1811480576;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_74;
				}
				global::DevComponents.WpfRibbon.RibbonBar ribbonBar;
				for (;;)
				{
					IL_31:
					global::System.Windows.Point point;
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						point = new global::System.Windows.Point(ribbonBar.RenderSize.Width - global::DevComponents.WpfRibbon.KeyTips.KeyTipRenderer.DefaultKeyTipSize.Width, ribbonBar.RenderSize.Height - 2.0);
						num = (short)1582891013;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						if (ribbonBar == null)
						{
							num = (short)253034498;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.Size renderSize = ribbonBar.RenderSize;
						num = (short)1680736270;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						num = (short)1715404800;
						short num3 = num;
						num = (short)1084227591;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						num = (short)1647837185;
						if (num != 0)
						{
						}
						goto IL_29D;
					case 4:
						try
						{
							num = (short)467206144;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_37F;
									}
									continue;
								case 1:
									num = (short)896991242;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::System.Windows.UIElement uielement;
									if (uielement != null)
									{
										num = (short)445186060;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									num = (short)105316359;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::System.Windows.UIElement uielement;
									if (uielement.Visibility == global::System.Windows.Visibility.Visible)
									{
										num = (short)222625797;
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
										num = (short)1796341771;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
								{
									global::System.Windows.Size renderSize;
									global::System.Windows.UIElement uielement;
									this.ProcessPanel(uielement as global::System.Windows.Controls.Panel, dc, info, ribbonBar, renderSize);
									num = (short)600834050;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
								{
									global::System.Windows.UIElement uielement;
									if (uielement is global::System.Windows.Controls.Panel)
									{
										num = (short)693895176;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Windows.Size renderSize;
									this.ProcessUIElement(uielement, dc, info, ribbonBar, renderSize);
									num = (short)636616707;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
									goto IL_531;
								case 11:
									num = (short)693043209;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									num = (short)18481158;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)621608961;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Windows.UIElement uielement = enumerator.Current as global::System.Windows.UIElement;
									num = (short)2071396356;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_3E5:
								num = (short)834338829;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_37F:
								goto IL_3E5;
							}
							IL_531:
							goto IL_649;
						}
						finally
						{
							num = (short)1760237053;
							short num4 = num;
							num = (short)1771378173;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_59F;
							default:
								num = (short)725155840;
								if (num != 0)
								{
								}
								switch (0)
								{
								case 0:
									goto IL_59F;
								}
								break;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_58C:
								switch (num2)
								{
								case 0:
									goto IL_5F6;
								case 1:
									disposable.Dispose();
									num = (short)1408499712;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									if (disposable != null)
									{
										num = (short)1036386305;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_5F8;
								}
								goto IL_59F;
							}
							IL_5F6:
							IL_5F8:
							goto EndFinally_15;
							IL_59F:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)43909122;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_58C;
							EndFinally_15:;
						}
						goto IL_5F9;
						IL_649:
						num = (short)2067202061;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (info.RibbonMenuMode)
						{
							num = (short)418578442;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_29D;
					case 6:
						num = (short)2050686988;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_ED;
					case 8:
						goto IL_31C;
					case 9:
						goto IL_10C;
					case 10:
						point.Y = ribbonBar.RenderSize.Height - global::DevComponents.WpfRibbon.KeyTips.KeyTipRenderer.DefaultKeyTipSize.Height + 5.0;
						num = (short)2000879619;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						global::System.Windows.Size renderSize = ribbonBar.ButtonPanel.RenderSize;
						num = (short)1170538505;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						if (this.HasKeyTip(ribbonBar))
						{
							num = (short)1717501952;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 13:
						if (ribbonBar.DialogLauncherVisible == global::System.Windows.Visibility.Visible)
						{
							num = (short)1862402054;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 14:
						if (ribbonBar.ButtonPanel != null)
						{
							num = (short)1395982347;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10C;
					}
					goto IL_74;
					IL_10C:
					enumerator = ((global::System.Collections.IEnumerable)ribbonBar.Items).GetEnumerator();
					num = (short)964493316;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_29D:
					point = ribbonBar.PointToScreen(point);
					point = info.Adorner.PointFromScreen(point);
					point.X = global::System.Math.Round(point.X) + 0.5;
					point.Y = global::System.Math.Round(point.Y) + 0.5;
					this.RenderKeyTip(dc, info, ribbonBar, point);
					this.RecordActiveKeyTip(ribbonBar, info);
					num = (short)602472456;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_ED:
				string str = global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("୘㹚㍜㭞Ѡᅢdᕦ䥨ࡪ౬Ů兰Ųၴ᥶ᵸṺོ彾ﺆꦈ릘ﮜ뾞햠\udaa2햤슦覨寧쒬춮펰\udcb2\udbb4\ud8b8즺鶼좾꧀ꫂ꧄ꋆ껊ꇌ꫎볐ꇔ껖꧘뻚﷜뛞鋠쏢", a_);
				global::System.Type type = elem.GetType();
				string str2 = (type != null) ? type.ToString() : null;
				goto IL_5F9;
				IL_31C:
				return;
				IL_5F9:
				throw new global::System.InvalidOperationException(str + str2);
				IL_74:
				ribbonBar = (elem as global::DevComponents.WpfRibbon.RibbonBar);
				num = (short)1362165761;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x000C650C File Offset: 0x000C470C
		private void ProcessPanel(global::System.Windows.Controls.Panel panel, global::System.Windows.Media.DrawingContext dc, global::DevComponents.WpfRibbon.KeyTipRenderInfo info, global::DevComponents.WpfRibbon.RibbonBar rb, global::System.Windows.Size rbSize)
		{
			global::System.Collections.IEnumerator enumerator = panel.Children.GetEnumerator();
			short num;
			try
			{
				num = (short)1630535680;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)897781982;
					short num3 = num;
					num = (short)1649676510;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)598802432;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_AF;
							}
							continue;
						case 2:
							goto IL_219;
						case 3:
							num = (short)1579417609;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							global::System.Windows.UIElement uielement;
							if (uielement.IsVisible)
							{
								num = (short)336134147;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
							num = (short)599785476;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
						{
							global::System.Windows.UIElement uielement;
							if (uielement.Visibility == global::System.Windows.Visibility.Visible)
							{
								num = (short)585695238;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 8:
							num = (short)103350274;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
						{
							global::System.Windows.UIElement uielement;
							if (uielement is global::System.Windows.Controls.Panel)
							{
								num = (short)1806499850;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.ProcessUIElement(uielement, dc, info, rb, rbSize);
							num = (short)1899102209;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
						{
							global::System.Windows.UIElement uielement;
							this.ProcessPanel(uielement as global::System.Windows.Controls.Panel, dc, info, rb, rbSize);
							num = (short)1290076165;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 11:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1035468808;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)enumerator.Current;
							num = (short)571408391;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_AF:
						break;
					}
					IL_ED:
					num = (short)1455685643;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					goto IL_ED;
				}
				IL_219:;
			}
			finally
			{
				switch (0)
				{
				case 0:
					goto IL_237;
				}
				int num2;
				global::System.IDisposable disposable;
				for (;;)
				{
					IL_225:
					switch (num2)
					{
					case 0:
						disposable.Dispose();
						num = (short)1346895873;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_287;
					case 2:
						if (disposable != null)
						{
							num = (short)2124939264;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_289;
					}
					goto IL_237;
				}
				IL_287:
				IL_289:
				goto EndFinally_8;
				IL_237:
				disposable = (enumerator as global::System.IDisposable);
				num = (short)1808138242;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_225;
				EndFinally_8:;
			}
			num = (short)1176043520;
			short num4 = num;
			num = (short)389873665;
			if (num != 0)
			{
			}
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x000C6810 File Offset: 0x000C4A10
		private void ProcessUIElement(global::System.Windows.UIElement e, global::System.Windows.Media.DrawingContext dc, global::DevComponents.WpfRibbon.KeyTipRenderInfo info, global::DevComponents.WpfRibbon.RibbonBar rb, global::System.Windows.Size rbSize)
		{
			short num = (short)731906049;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Windows.Point point;
				switch (num2)
				{
				case 0:
					point.Y = 0.0;
					num = (short)745078788;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_50;
					}
					continue;
				case 2:
					num = (short)480444425;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					point = e.PointToScreen(default(global::System.Windows.Point));
					point = rb.PointFromScreen(point);
					global::System.Windows.Rect elemRect = new global::System.Windows.Rect(point, e.RenderSize);
					point = this.GetSpecKeyTipPosition(rbSize, elemRect);
					point = rb.PointToScreen(point);
					point = info.Adorner.PointFromScreen(point);
					num = (short)869728264;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					goto IL_170;
				case 5:
					goto IL_256;
				case 6:
					goto IL_256;
				case 7:
					if (info.UseSpecKeyTipPositioning)
					{
						num = (short)1274150913;
						if (num != 0)
						{
						}
						num = (short)1106444291;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.RenderKeyTip(dc, info, e);
					goto IL_152;
				case 8:
					if (info.RibbonMenuMode)
					{
						num = (short)86835202;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_170;
				case 9:
					if (point.Y < 0.0)
					{
						num = (short)2086928384;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_170;
				case 10:
					return;
				}
				IL_50:
				if (!this.HasKeyTip(e))
				{
					num = (short)1726021642;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)311689223;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_152:
				num = (short)1580466181;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_256:
				num = (short)940465734;
				short num3 = num;
				num = (short)1701469766;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_152;
				default:
					goto IL_28C;
				}
				IL_170:
				point.X = global::System.Math.Round(point.X) + 0.5;
				point.Y = global::System.Math.Round(point.Y) + 0.5;
				this.RenderKeyTip(dc, info, e, point);
				num = (short)255852550;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_28C:
			num = (short)831258624;
			if (num != 0)
			{
			}
			num = (short)84738048;
			short num4 = num;
			this.RecordActiveKeyTip(e, info);
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x000C6AF4 File Offset: 0x000C4CF4
		private global::System.Windows.Point GetSpecKeyTipPosition(global::System.Windows.Size ribbonBarSize, global::System.Windows.Rect elemRect)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			short num2;
			global::System.Windows.Point result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (elemRect.Y < ribbonBarSize.Height * 0.699999988079071)
					{
						num2 = (short)1973026817;
						if (num2 != 0)
						{
						}
						num2 = (short)1002897416;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_261;
				case 1:
				{
					num2 = (short)1085507399;
					short num3 = num2;
					num2 = (short)165775175;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)860815360;
						if (num2 != 0)
						{
						}
						result.Y = -global::DevComponents.WpfRibbon.KeyTips.KeyTipRenderer.DefaultKeyTipSize.Height * 0.3;
						num2 = (short)676134919;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					return result;
				case 3:
					if (elemRect.Bottom >= ribbonBarSize.Height * 0.800000011920929)
					{
						num2 = (short)768212996;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)216858629;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_261;
				case 5:
					if (elemRect.Y <= ribbonBarSize.Height * 0.2)
					{
						num2 = (short)532938753;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result.Y = (ribbonBarSize.Height - global::DevComponents.WpfRibbon.KeyTips.KeyTipRenderer.DefaultKeyTipSize.Height) / 2.0;
					num2 = (short)2053242886;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					return result;
				case 7:
					return result;
				case 8:
					num2 = (short)606797827;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_34;
				IL_261:
				result.Y = ribbonBarSize.Height - global::DevComponents.WpfRibbon.KeyTips.KeyTipRenderer.DefaultKeyTipSize.Height / 2.0;
				num2 = (short)1427177474;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_34:
			num2 = (short)1642201088;
			short num4 = num2;
			result = new global::System.Windows.Point(elemRect.X + (elemRect.Width - global::DevComponents.WpfRibbon.KeyTips.KeyTipRenderer.DefaultKeyTipSize.Width) / 2.0, 0.0);
			num2 = (short)1523253248;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
