using System;
using System.Collections;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon.KeyTips
{
	// Token: 0x020000D1 RID: 209
	internal class RibbonKeyTipRenderer : global::DevComponents.WpfRibbon.KeyTips.KeyTipRenderer
	{
		// Token: 0x060008BE RID: 2238 RVA: 0x000C6DB4 File Offset: 0x000C4FB4
		public override void Render(global::System.Windows.Media.DrawingContext dc, object elem, global::DevComponents.WpfRibbon.KeyTipRenderInfo info)
		{
			int a_ = 17;
			short num = (short)495779840;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_AB;
				}
				global::DevComponents.WpfRibbon.Ribbon ribbon;
				for (;;)
				{
					IL_30:
					global::System.Windows.Point point;
					double num3;
					global::System.Collections.IEnumerator enumerator;
					global::System.Windows.Point point2;
					string keyTipString;
					switch (num2)
					{
					case 0:
						goto IL_430;
					case 1:
						num = (short)2024210449;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (ribbon.ApplicationMenu != null)
						{
							num = (short)1085734932;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_227;
					case 3:
						point.Y = num3;
						goto IL_6C3;
					case 4:
						num = (short)2076049427;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (ribbon.ApplicationMenu != null)
						{
							num = (short)1765081116;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_227;
					case 6:
						point = new global::System.Windows.Point((ribbon.ApplicationMenu.RenderSize.Width - global::DevComponents.WpfRibbon.KeyTips.KeyTipRenderer.DefaultKeyTipSize.Width) / 2.0, ribbon.ApplicationMenu.RenderSize.Height - global::DevComponents.WpfRibbon.KeyTips.KeyTipRenderer.DefaultKeyTipSize.Height / 2.0);
						num = (short)1278345241;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						global::System.Windows.Controls.ItemsControl itemsControl = ribbon.QuickAccessToolbar as global::System.Windows.Controls.ItemsControl;
						enumerator = ((global::System.Collections.IEnumerable)itemsControl.Items).GetEnumerator();
						num = (short)646053888;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						if (ribbon.QuickAccessToolbar is global::System.Windows.Controls.ItemsControl)
						{
							num = (short)655884295;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2084962313;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (ribbon.QuickAccessToolbar is global::System.Windows.Controls.Panel)
						{
							num = (short)1898774555;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_125;
					case 10:
						num = (short)1741684747;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_17F;
					case 12:
						if (ribbon.EffectiveStyle == global::DevComponents.WpfRibbon.eEffectiveStyle.Office2010)
						{
							num = (short)2063794182;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9C3;
					case 13:
						if (num3 > 0.0)
						{
							num = (short)2008350721;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8D4;
					case 14:
						if (ribbon == null)
						{
							num = (short)569180170;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 = 0.0;
						num = (short)1586757656;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						try
						{
							num = (short)756678660;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_859;
								case 1:
									num = (short)218365952;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1503920129;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Windows.UIElement e = (global::System.Windows.UIElement)enumerator.Current;
									this.RenderKeyTip(dc, info, e, point2);
									this.RecordActiveKeyTip(e, info);
									num = (short)1368326146;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_7CD;
									}
									continue;
								}
								IL_7CF:
								num = (short)70713347;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_7CD:
								goto IL_7CF;
							}
							IL_859:
							goto IL_125;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_87B;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_868:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)847446017;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_8D1;
								case 2:
									if (disposable != null)
									{
										num = (short)480444416;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_8D3;
								}
								goto IL_87B;
							}
							IL_8D1:
							IL_8D3:
							goto EndFinally_28;
							IL_87B:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)923533314;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_868;
							EndFinally_28:;
						}
						goto IL_8D4;
					case 16:
						goto IL_8D4;
					case 17:
						if (!ribbon.IsQuickAccessToolbarBelow)
						{
							num = (short)1411252228;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8D4;
					case 18:
						goto IL_5F4;
					case 19:
						if (ribbon.EffectiveStyle == global::DevComponents.WpfRibbon.eEffectiveStyle.Office2007)
						{
							num = (short)1567490051;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8D4;
					case 20:
						keyTipString = this.GetKeyTipString(ribbon.ApplicationMenu, info);
						num = (short)1570242583;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
					{
						num = (short)1554776065;
						if (num != 0)
						{
						}
						num = (short)188940288;
						short num4 = num;
						goto IL_227;
					}
					case 22:
						point = new global::System.Windows.Point((ribbon.ApplicationMenu.RenderSize.Width - global::DevComponents.WpfRibbon.KeyTips.KeyTipRenderer.DefaultKeyTipSize.Width) / 2.0, (ribbon.ApplicationMenu.RenderSize.Height - global::DevComponents.WpfRibbon.KeyTips.KeyTipRenderer.DefaultKeyTipSize.Height) / 2.0);
						num = (short)905183244;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						if (keyTipString != "")
						{
							num = (short)1518665750;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_227;
					case 24:
					{
						num = (short)411598872;
						short num5 = num;
						num = (short)656965656;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_6C3;
						default:
							num = (short)918093824;
							if (num != 0)
							{
							}
							if (ribbon.QuickAccessToolbar != null)
							{
								num = (short)449970194;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_125;
						}
						break;
					}
					case 25:
						goto IL_9C3;
					case 26:
						try
						{
							num = (short)190382084;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_3B3;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2035154946;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Windows.UIElement e2 = enumerator.Current as global::System.Windows.UIElement;
									this.RenderKeyTip(dc, info, e2);
									this.RecordActiveKeyTip(e2, info);
									num = (short)973209603;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									num = (short)1771765760;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_328;
									}
									continue;
								}
								IL_363:
								num = (short)166199297;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_328:
								goto IL_363;
							}
							IL_3B3:
							return;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_3D5;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_3C2:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)38928385;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_42D;
								case 2:
									if (disposable != null)
									{
										num = (short)1652162560;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_42F;
								}
								goto IL_3D5;
							}
							IL_42D:
							IL_42F:
							goto EndFinally_27;
							IL_3D5:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)440729602;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_3C2;
							EndFinally_27:;
						}
						goto Block_8;
					case 27:
						enumerator = (ribbon.QuickAccessToolbar as global::System.Windows.Controls.Panel).Children.GetEnumerator();
						num = (short)258736143;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						num = (short)1557069826;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AB;
					IL_125:
					num = (short)410714117;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_8:
					try
					{
						IL_430:
						num = (short)1045495808;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Windows.UIElement uielement;
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_477;
								}
								continue;
							case 1:
							{
								global::System.Windows.Controls.ItemsControl itemsControl;
								object obj;
								uielement = (itemsControl.ItemContainerGenerator.ContainerFromItem(obj) as global::System.Windows.UIElement);
								num = (short)2012741638;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)311951365;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								object obj = enumerator.Current;
								uielement = (obj as global::System.Windows.UIElement);
								num = (short)154402820;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								goto IL_578;
							case 4:
								if (uielement == null)
								{
									num = (short)1081475073;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_47C;
							case 5:
								num = (short)259194883;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								goto IL_47C;
							}
							goto IL_477;
							IL_47C:
							this.RenderKeyTip(dc, info, uielement, point2);
							this.RecordActiveKeyTip(uielement, info);
							num = (short)1438449671;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_523:
							num = (short)27131906;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_477:
							goto IL_523;
						}
						IL_578:
						goto IL_125;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_59A;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_587:
							switch (num2)
							{
							case 0:
								disposable.Dispose();
								num = (short)1037631489;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_5F1;
							case 2:
								if (disposable != null)
								{
									num = (short)1944190976;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_5F3;
							}
							goto IL_59A;
						}
						IL_5F1:
						IL_5F3:
						goto EndFinally_26;
						IL_59A:
						disposable = (enumerator as global::System.IDisposable);
						num = (short)1796931586;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_587;
						EndFinally_26:;
					}
					goto IL_5F4;
					IL_227:
					enumerator = ((global::System.Collections.IEnumerable)ribbon.Items).GetEnumerator();
					num = (short)829095962;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5F4:
					point2 = new global::System.Windows.Point(0.0, ribbon.QuickAccessToolbar.RenderSize.Height - global::DevComponents.WpfRibbon.KeyTips.KeyTipRenderer.DefaultKeyTipSize.Height * 0.7);
					point2 = ribbon.QuickAccessToolbar.PointToScreen(point2);
					point2 = info.Adorner.PointFromScreen(point2);
					num3 = global::System.Math.Round(point2.Y) + 0.5;
					point2.Y = num3;
					point2.X = 0.0;
					num = (short)1038549000;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6C3:
					num = (short)1048576016;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8D4:
					global::DevComponents.WpfRibbon.KeyTipColors colors = this.GetColors(ribbon.ApplicationMenu, info);
					this.RenderKeyTip(dc, new global::System.Windows.Rect(point, global::DevComponents.WpfRibbon.KeyTips.KeyTipRenderer.DefaultKeyTipSize), colors, info.Typeface, info.FontSize, keyTipString);
					this.RecordActiveKeyTip(ribbon.ApplicationMenu, info);
					num = (short)23396373;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9C3:
					point = ribbon.ApplicationMenu.PointToScreen(point);
					point = info.Adorner.PointFromScreen(point);
					point.X = global::System.Math.Round(point.X) + 0.5;
					point.Y = global::System.Math.Round(point.Y) + 0.5;
					num = (short)1161101325;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_17F:
				string str = global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㭨๪ͬ୮ᑰŲၴն奸᡺ᱼᅾꆀﾌ꾎ﺐﶒ璉릘ﾜ쒠삢톤풦覨쒪쮬辮얰쪲어튶馸풼\uddbeꏀ곂ꯄ뻈ꏊ꓌ꏎ듐냔믖볘뛚﷜ꯞ飠鏢胤쟦胨飪췬", a_);
				global::System.Type type = elem.GetType();
				throw new global::System.InvalidOperationException(str + ((type != null) ? type.ToString() : null));
				IL_AB:
				ribbon = (elem as global::DevComponents.WpfRibbon.Ribbon);
				num = (short)1316683790;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}
	}
}
