using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace DevComponents.WpfRibbon
{
	// Token: 0x020000A4 RID: 164
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class TitlePanel : global::System.Windows.Controls.Panel
	{
		// Token: 0x06000828 RID: 2088 RVA: 0x000BDAB8 File Offset: 0x000BBCB8
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			short num = (short)503906304;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3E;
				}
				global::System.Windows.Size result;
				global::System.Collections.IEnumerator enumerator2;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						if (availableSize.Width < double.PositiveInfinity)
						{
							num = (short)1751646209;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 1:
						goto IL_66B;
					case 2:
						return result;
					case 3:
						try
						{
							num = (short)507183110;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::DevComponents.WpfRibbon.ContextGroup contextGroup;
								global::System.Collections.Generic.IEnumerator<global::DevComponents.WpfRibbon.RibbonTab> enumerator;
								global::System.Windows.Size availableSize2;
								switch (num2)
								{
								case 0:
									goto IL_276;
								case 1:
								{
									if (contextGroup != null)
									{
										num = (short)2069626892;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Windows.UIElement uielement;
									uielement.Measure(new global::System.Windows.Size(double.PositiveInfinity, availableSize.Height));
									result.Width += uielement.DesiredSize.Width;
									result.Height = global::System.Math.Max(uielement.DesiredSize.Height, result.Height);
									num = (short)1377894405;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									contextGroup.Visibility = global::System.Windows.Visibility.Visible;
									num = (short)1135280128;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									try
									{
										num = (short)1081344004;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_4B6;
											case 1:
											{
												if (!enumerator.MoveNext())
												{
													num = (short)1022820352;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::DevComponents.WpfRibbon.RibbonTab ribbonTab = enumerator.Current;
												availableSize2.Width += ribbonTab.DesiredSize.Width;
												num = (short)401473538;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 2:
											{
												num = (short)1852585698;
												short num3 = num;
												num = (short)1600337634;
												switch ((num3 == num) ? 1 : 0)
												{
												case 0:
												case 2:
													goto IL_4B6;
												default:
													num = (short)2042232832;
													if (num != 0)
													{
													}
													break;
												}
												break;
											}
											case 3:
												goto IL_563;
											case 4:
												switch (0)
												{
												case 0:
													goto IL_480;
												}
												continue;
											}
											IL_482:
											num = (short)97648641;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_480:
											goto IL_482;
											IL_4B6:
											num = (short)214630403;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_563:
										goto IL_190;
									}
									finally
									{
										num = (short)1546780674;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												enumerator.Dispose();
												num = (short)781451265;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												goto IL_5D5;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_59B;
												}
												continue;
											}
											IL_59B:
											if (enumerator == null)
											{
												break;
											}
											num = (short)1082785792;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_5D5:;
									}
									goto IL_5D8;
									IL_190:
									contextGroup.Measure(availableSize2);
									global::System.Windows.Size desiredSize = contextGroup.DesiredSize;
									result.Width += desiredSize.Width;
									num = (short)1893203986;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									switch (0)
									{
									case 0:
										goto IL_14C;
									}
									continue;
								case 7:
									goto IL_5D8;
								case 9:
									if (!contextGroup.IsOneTabVisible)
									{
										num = (short)2079784973;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1315110927;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									if (contextGroup.Visibility != global::System.Windows.Visibility.Collapsed)
									{
										num = (short)1040842763;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 11:
									contextGroup.Visibility = global::System.Windows.Visibility.Collapsed;
									num = (short)1846411267;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									num = (short)1503920137;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									num = (short)1137639434;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)1350434823;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)enumerator2.Current;
									contextGroup = (uielement as global::DevComponents.WpfRibbon.ContextGroup);
									num = (short)1975386113;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 15:
									if (contextGroup.Visibility != global::System.Windows.Visibility.Visible)
									{
										num = (short)921763842;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_276;
								case 16:
								{
									global::System.Windows.Size desiredSize;
									result.Height = desiredSize.Height;
									num = (short)1817444360;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 17:
									goto IL_5F0;
								case 18:
								{
									global::System.Windows.Size desiredSize;
									if (desiredSize.Height > result.Height)
									{
										num = (short)56098832;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								goto IL_14C;
								IL_276:
								availableSize2 = new global::System.Windows.Size(0.0, global::System.Math.Min(this.GetContextGroupHeight(), availableSize.Height));
								enumerator = contextGroup.LinkedTabs.GetEnumerator();
								num = (short)21757956;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_311:
								num = (short)858521614;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_14C:
								goto IL_311;
								IL_5D8:
								num = (short)1793064977;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_5F0:
							goto IL_6A;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_612;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_5FF:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)986251265;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_668;
								case 2:
									if (disposable != null)
									{
										num = (short)2072576000;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_66A;
								}
								goto IL_612;
							}
							IL_668:
							IL_66A:
							goto EndFinally_16;
							IL_612:
							disposable = (enumerator2 as global::System.IDisposable);
							num = (short)1535639554;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_5FF;
							EndFinally_16:;
						}
						goto IL_66B;
						IL_6A:
						num = (short)2114715649;
						if (num != 0)
						{
						}
						num = (short)985858048;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3E;
					IL_66B:
					result.Width = availableSize.Width;
					num = (short)903217152;
					short num4 = num;
					num = (short)854130690;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_3E:
				global::System.Windows.Controls.UIElementCollection internalChildren = base.InternalChildren;
				result = default(global::System.Windows.Size);
				enumerator2 = internalChildren.GetEnumerator();
				num = (short)300744707;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x000BE1B8 File Offset: 0x000BC3B8
		private double GetContextGroupHeight()
		{
			short num = (short)786177976;
			short num2 = num;
			num = (short)956768184;
			switch (num2 == num)
			{
			}
			num = (short)1043922944;
			short num3 = num;
			num = (short)1582825472;
			if (num != 0)
			{
			}
			num = (short)1826160641;
			if (num != 0)
			{
			}
			return this.m_TitleChromeHeight + 20.0;
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x000BE274 File Offset: 0x000BC474
		private bool IsTabVisible(global::DevComponents.WpfRibbon.RibbonTab tab)
		{
			short num = (short)317915140;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1400111104;
				short num3 = num;
				global::System.Windows.UIElement uielement;
				switch (num2)
				{
				case 0:
				{
					num = (short)308984320;
					short num4 = num;
					num = (short)1127987712;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D1;
					default:
						num = (short)607387648;
						if (num != 0)
						{
						}
						if (uielement != null)
						{
							num = (short)987365379;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					break;
				}
				case 1:
					return false;
				case 2:
					if (uielement.Visibility != global::System.Windows.Visibility.Visible)
					{
						num = (short)1552613377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 3:
					num = (short)1534787586;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_67;
					}
					continue;
				case 5:
					return false;
				}
				IL_67:
				if (tab.Visibility != global::System.Windows.Visibility.Visible)
				{
					num = (short)1274150917;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				uielement = (global::System.Windows.Media.VisualTreeHelper.GetParent(tab) as global::System.Windows.UIElement);
				IL_D1:
				num = (short)878968833;
				if (num != 0)
				{
				}
				num = (short)1511587840;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x000BE400 File Offset: 0x000BC600
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			short num = (short)911998976;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::System.Windows.Controls.UIElementCollection internalChildren = base.InternalChildren;
				global::System.Windows.Rect item = new global::System.Windows.Rect(finalSize);
				global::System.Collections.Generic.List<global::System.Windows.Rect> list = new global::System.Collections.Generic.List<global::System.Windows.Rect>(internalChildren.Count * 2);
				list.Add(item);
				global::System.Collections.Generic.List<global::System.Windows.UIElement> list2 = new global::System.Collections.Generic.List<global::System.Windows.UIElement>(internalChildren.Count);
				global::System.Collections.IEnumerator enumerator = internalChildren.GetEnumerator();
				try
				{
					num = (short)70057987;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::DevComponents.WpfRibbon.ContextGroup contextGroup;
						global::System.Windows.UIElement uielement;
						switch (num2)
						{
						case 0:
							try
							{
								num = (short)1086128132;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										global::DevComponents.WpfRibbon.RibbonTab ribbonTab;
										global::System.Windows.Rect layoutSlot = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(ribbonTab);
										layoutSlot.X -= this.m_QatRightPosition - this.m_TabXPosition;
										num = (short)1357840395;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
										num = (short)213319688;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
									{
										global::System.Windows.Rect rect2;
										global::System.Windows.Rect rect = rect2;
										num = (short)1424818179;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										switch (0)
										{
										case 0:
											goto IL_35E;
										}
										continue;
									case 5:
									{
										global::DevComponents.WpfRibbon.RibbonTab ribbonTab;
										if (this.IsTabVisible(ribbonTab))
										{
											num = (short)1674706944;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 7:
									{
										global::System.Collections.Generic.IEnumerator<global::DevComponents.WpfRibbon.RibbonTab> enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)804454409;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::DevComponents.WpfRibbon.RibbonTab ribbonTab = enumerator2.Current;
										num = (short)1055457285;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 8:
									{
										global::System.Windows.Rect layoutSlot;
										if (layoutSlot.Right <= item.Right)
										{
											num = (short)973275149;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 9:
										num = (short)1049100300;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 10:
									{
										global::System.Windows.Rect rect;
										if (rect.Width == 0.0)
										{
											num = (short)1203830786;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Windows.Rect rect2;
										rect.Union(rect2);
										num = (short)1728774150;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 11:
									{
										global::System.Windows.Rect layoutSlot;
										if (layoutSlot.X >= 0.0)
										{
											num = (short)170852353;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 12:
										goto IL_571;
									case 13:
									{
										global::System.Windows.Rect layoutSlot;
										global::System.Windows.Rect rect2 = new global::System.Windows.Rect(layoutSlot.X, 0.0, layoutSlot.Width, this.GetContextGroupHeight());
										num = (short)617611274;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_415:
									num = (short)389873671;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_35E:
									goto IL_415;
								}
								IL_571:
								goto IL_6F6;
							}
							finally
							{
								num = (short)1432420354;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::DevComponents.WpfRibbon.RibbonTab> enumerator2;
									switch (num2)
									{
									case 0:
										enumerator2.Dispose();
										num = (short)52887553;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_5DF;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_5A8;
										}
										continue;
									}
									IL_5A8:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)1843462144;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_5DF:;
							}
							goto IL_5E2;
							IL_6F6:
							num = (short)866385924;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							contextGroup.Visibility = global::System.Windows.Visibility.Hidden;
							num = (short)1791623179;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							list2.Add(uielement);
							num = (short)1743257605;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_2BB;
							}
							continue;
						case 4:
						{
							global::System.Windows.Rect rect;
							if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsEmpty(rect))
							{
								num = (short)1666056201;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)278396940;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							if (!enumerator.MoveNext())
							{
								num = (short)1387331599;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_5E2;
						case 7:
						{
							if (contextGroup == null)
							{
								num = (short)1907621890;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Windows.Rect rect = default(global::System.Windows.Rect);
							global::System.Collections.Generic.IEnumerator<global::DevComponents.WpfRibbon.RibbonTab> enumerator2 = contextGroup.LinkedTabs.GetEnumerator();
							num = (short)623771648;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
							if (uielement.Visibility == global::System.Windows.Visibility.Visible)
							{
								num = (short)656867341;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 9:
						{
							global::System.Windows.Rect rect;
							contextGroup.Arrange(rect);
							this.ExcludeArea(list, rect);
							num = (short)749207562;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 12:
							if (contextGroup.Visibility != global::System.Windows.Visibility.Hidden)
							{
								num = (short)640614401;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 13:
							num = (short)1558708231;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
							goto IL_7B9;
						case 15:
							num = (short)141033486;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_2C0:
						num = (short)1242955782;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2BB:
						goto IL_2C0;
						IL_5E2:
						uielement = (global::System.Windows.UIElement)enumerator.Current;
						contextGroup = (uielement as global::DevComponents.WpfRibbon.ContextGroup);
						num = (short)1471348744;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_7B9:
					goto IL_23B;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_7DB;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_7C8:
						switch (num2)
						{
						case 0:
							disposable.Dispose();
							num = (short)420741121;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_830;
						case 2:
							if (disposable != null)
							{
								num = (short)1350959104;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_832;
						}
						goto IL_7DB;
					}
					IL_830:
					IL_832:
					goto EndFinally_24;
					IL_7DB:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)618266626;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_7C8;
					EndFinally_24:;
				}
				goto IL_833;
				for (;;)
				{
					IL_23B:
					list.Sort(new global::DevComponents.WpfRibbon.TitlePanel.RectWidthComparer());
					using (global::System.Collections.Generic.List<global::System.Windows.UIElement>.Enumerator enumerator3 = list2.GetEnumerator())
					{
						num = (short)1618608129;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Windows.UIElement uielement2;
							switch (num2)
							{
							case 0:
							{
								num = (short)813931648;
								short num3 = num;
								num = (short)365141120;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_20A;
								default:
									num = (short)414580736;
									if (num != 0)
									{
									}
									if (list.Count == 0)
									{
										num = (short)179437570;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1691222019;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
								switch (0)
								{
								case 0:
									goto IL_A6;
								}
								continue;
							case 2:
								num = (short)124583942;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								if (uielement2.Visibility == global::System.Windows.Visibility.Visible)
								{
									num = (short)1495072772;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 4:
								goto IL_20A;
							case 5:
								num = (short)207945736;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								goto IL_135;
							case 7:
								if (!enumerator3.MoveNext())
								{
									num = (short)1538916357;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								uielement2 = enumerator3.Current;
								num = (short)1409810432;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
								goto IL_228;
							}
							IL_E2:
							num = (short)1559560199;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_A6:
							goto IL_E2;
							IL_20A:
							uielement2.Arrange(list[list.Count - 1]);
							list.RemoveAt(list.Count - 1);
							num = (short)1607729161;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_135:
						IL_228:
						break;
					}
				}
				IL_833:
				num = (short)973340673;
				if (num != 0)
				{
				}
				num = (short)912523264;
				short num4 = num;
				return finalSize;
			}
			}
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x000BECE0 File Offset: 0x000BCEE0
		private void ExcludeArea(global::System.Collections.Generic.List<global::System.Windows.Rect> availableArea, global::System.Windows.Rect tabsArea)
		{
			short num = (short)2088370176;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_7B;
				}
				int num3;
				int num5;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
					{
						global::System.Windows.Rect rect;
						global::System.Windows.Rect value = new global::System.Windows.Rect(rect.X, rect.Y, global::System.Math.Max(0.0, tabsArea.X - rect.X), rect.Height);
						global::System.Windows.Rect rect2 = new global::System.Windows.Rect(tabsArea.Right, rect.Y, global::System.Math.Max(0.0, rect.Right - tabsArea.Right), rect.Height);
						bool flag = false;
						num = (short)1389953037;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						num = (short)345112581;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						global::System.Windows.Rect value;
						availableArea[num3] = value;
						bool flag = true;
						num = (short)1335558152;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						global::System.Windows.Rect rect;
						if (rect.IntersectsWith(tabsArea))
						{
							num = (short)1775894528;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D4;
					}
					case 4:
						goto IL_1D4;
					case 5:
					{
						bool flag;
						if (flag)
						{
							num = (short)1041629195;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.Rect rect2;
						availableArea[num3] = rect2;
						num = (short)542244868;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						return;
					case 7:
						goto IL_1D4;
					case 8:
						goto IL_313;
					case 9:
					{
						global::System.Windows.Rect rect2;
						if (global::DevComponents.WpfRibbon.LayoutHelpers.GreaterThan(rect2.Width, 0.0))
						{
							num = (short)2097283088;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D4;
					}
					case 10:
					{
						global::System.Windows.Rect rect2;
						if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(rect2.Width))
						{
							num = (short)1494220801;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D4;
					}
					case 11:
					{
						global::System.Windows.Rect rect2;
						availableArea.Add(rect2);
						num = (short)1688141831;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						goto IL_263;
					case 13:
					{
						global::System.Windows.Rect value;
						if (global::DevComponents.WpfRibbon.LayoutHelpers.GreaterThan(value.Width, 0.0))
						{
							num = (short)2110783502;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_313;
					}
					case 14:
						num = (short)295043087;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						global::System.Windows.Rect value;
						if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(value.Width))
						{
							num = (short)786890752;
							short num4 = num;
							num = (short)289734658;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_313;
					}
					case 16:
						num = (short)1628962826;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
					{
						if (num3 <= num5)
						{
							global::System.Windows.Rect rect = availableArea[num3];
							num = (short)337772547;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)596483234;
						short num6 = num;
						num = (short)35036322;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)117571584;
							if (num != 0)
							{
							}
							num = (short)572063745;
							if (num != 0)
							{
							}
							num = (short)2001797126;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 18:
						goto IL_263;
					}
					goto IL_7B;
					IL_1D4:
					num3++;
					num = (short)1838546956;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_263:
					num = (short)219021329;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_313:
					num = (short)2071068681;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_7B:
				num3 = 0;
				num5 = availableArea.Count - 1;
				num = (short)1027604498;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x0600082D RID: 2093 RVA: 0x000BF124 File Offset: 0x000BD324
		// (set) Token: 0x0600082E RID: 2094 RVA: 0x000BF1D4 File Offset: 0x000BD3D4
		internal double TabXPosition
		{
			get
			{
				short num = (short)1645595705;
				short num2 = num;
				num = (short)388222009;
				switch (num2 == num)
				{
				}
				num = (short)1210318848;
				if (num != 0)
				{
				}
				num = (short)1770651649;
				if (num != 0)
				{
				}
				num = (short)1704263680;
				short num3 = num;
				return this.m_TabXPosition;
			}
			set
			{
				short num = (short)1908801225;
				short num2 = num;
				num = (short)1418854089;
				switch (num2 == num)
				{
				}
				num = (short)1938030593;
				if (num != 0)
				{
				}
				num = (short)1882587136;
				if (num != 0)
				{
				}
				num = (short)93847552;
				short num3 = num;
				this.m_TabXPosition = value;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x0600082F RID: 2095 RVA: 0x000BF288 File Offset: 0x000BD488
		// (set) Token: 0x06000830 RID: 2096 RVA: 0x000BF334 File Offset: 0x000BD534
		internal double QatRightPosition
		{
			get
			{
				short num = (short)982109221;
				short num2 = num;
				num = (short)1469238309;
				switch (num2 == num)
				{
				}
				num = (short)1965752321;
				if (num != 0)
				{
				}
				num = (short)624689152;
				if (num != 0)
				{
				}
				num = (short)1044250624;
				short num3 = num;
				return this.m_QatRightPosition;
			}
			set
			{
				short num = (short)215505460;
				short num2 = num;
				num = (short)1106074164;
				switch (num2 == num)
				{
				}
				num = (short)1244332033;
				if (num != 0)
				{
				}
				num = (short)1872297984;
				if (num != 0)
				{
				}
				num = (short)81592320;
				short num3 = num;
				this.m_QatRightPosition = value;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000831 RID: 2097 RVA: 0x000BF3E4 File Offset: 0x000BD5E4
		// (set) Token: 0x06000832 RID: 2098 RVA: 0x000BF494 File Offset: 0x000BD694
		internal double TitleChromeHeight
		{
			get
			{
				short num = (short)1430546608;
				short num2 = num;
				num = (short)313682096;
				switch (num2 == num)
				{
				}
				num = (short)1801715713;
				if (num != 0)
				{
				}
				num = (short)1912274944;
				if (num != 0)
				{
				}
				num = (short)2095841280;
				short num3 = num;
				return this.m_TitleChromeHeight;
			}
			set
			{
				short num = (short)1221841303;
				short num2 = num;
				num = (short)90689943;
				switch (num2 == num)
				{
				}
				num = (short)835846144;
				if (num != 0)
				{
				}
				num = (short)1375141889;
				if (num != 0)
				{
				}
				num = (short)1662451712;
				short num3 = num;
				this.m_TitleChromeHeight = value;
			}
		}

		// Token: 0x040006C3 RID: 1731
		private double m_TabXPosition;

		// Token: 0x040006C4 RID: 1732
		private double m_QatRightPosition;

		// Token: 0x040006C5 RID: 1733
		private double m_TitleChromeHeight;

		// Token: 0x020000A5 RID: 165
		private class RectWidthComparer : global::System.Collections.Generic.IComparer<global::System.Windows.Rect>
		{
			// Token: 0x06000834 RID: 2100 RVA: 0x000BF558 File Offset: 0x000BD758
			public int Compare(global::System.Windows.Rect x, global::System.Windows.Rect y)
			{
				short num = (short)622563492;
				short num2 = num;
				num = (short)613388452;
				switch (num2 == num)
				{
				}
				num = (short)1089142784;
				if (num != 0)
				{
				}
				num = (short)117571585;
				if (num != 0)
				{
				}
				num = (short)571473920;
				short num3 = num;
				return (int)(x.Width - y.Width);
			}
		}
	}
}
