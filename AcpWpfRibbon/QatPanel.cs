using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon
{
	// Token: 0x02000070 RID: 112
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class QatPanel : global::System.Windows.Controls.Panel
	{
		// Token: 0x0600055E RID: 1374 RVA: 0x00075BA8 File Offset: 0x00073DA8
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			short num = (short)312147968;
			switch (num)
			{
			default:
			{
				num = (short)411893775;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.Windows.Size result;
				for (;;)
				{
					int num4;
					int num3;
					bool flag;
					int num5;
					global::System.Windows.UIElement uielement;
					global::System.Windows.Size availableSize2;
					global::System.Windows.Size desiredSize;
					global::DevComponents.WpfRibbon.Qat qat;
					global::System.Collections.Generic.List<global::System.Windows.UIElement>.Enumerator enumerator;
					switch (num2)
					{
					case 0:
						num3 = num4;
						num = (short)1356398597;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_643;
					case 2:
					{
						if (num3 < 0)
						{
							num = (short)1147535388;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.UIElement element = this.m_GeneratedChildren[num3];
						num = (short)962199581;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						if (flag)
						{
							num = (short)1721499648;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_289;
					case 4:
						if (!flag)
						{
							num = (short)881852423;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_664;
					case 5:
						goto IL_604;
					case 6:
						goto IL_3A1;
					case 7:
						num = (short)825819170;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_142;
					case 9:
						num = (short)1527513091;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num = (short)1047134225;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (num5 > num4)
						{
							num = (short)83296265;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						uielement = this.m_GeneratedChildren[num5];
						uielement.Measure(availableSize2);
						desiredSize = uielement.DesiredSize;
						desiredSize.Width = global::System.Math.Round(desiredSize.Width);
						desiredSize.Height = global::System.Math.Round(desiredSize.Height);
						num = (short)1414725636;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (qat != null)
						{
							num = (short)1490550816;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7A2;
					case 13:
						goto IL_142;
					case 14:
						goto IL_604;
					case 15:
						switch (0)
						{
						case 0:
							goto IL_DC;
						}
						continue;
					case 16:
					{
						bool isItemsHost = base.IsItemsHost;
						global::DevComponents.WpfRibbon.QatOverflowPanel overflowPanel = this.OverflowPanel;
						if (isItemsHost)
						{
							num = (short)1743192085;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_707;
					}
					case 17:
					{
						global::DevComponents.WpfRibbon.QatOverflowPanel overflowPanel;
						if (overflowPanel != null)
						{
							num = (short)984219668;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7E5;
					}
					case 18:
						base.Margin = this.m_OldMargin;
						this.m_OldMargin = default(global::System.Windows.Thickness);
						num = (short)1117192211;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						goto IL_741;
					case 20:
						goto IL_664;
					case 21:
						num = (short)504299547;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						IL_82C:
						goto IL_3A1;
					case 23:
						return result;
					case 24:
						try
						{
							num = (short)239665153;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2123038722;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Windows.UIElement element2 = enumerator.Current;
									this.m_Children.Add(element2);
									global::DevComponents.WpfRibbon.Qat.SetIsOverflowItem(element2, false);
									num = (short)369557507;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1E4;
									}
									continue;
								case 2:
									num = (short)1207435268;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_276;
								}
								IL_223:
								num = (short)1489895424;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1E4:
								goto IL_223;
							}
							IL_276:
							goto IL_707;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_289;
					case 25:
						this.m_OldMargin = base.Margin;
						base.Margin = default(global::System.Windows.Thickness);
						num = (short)1625817111;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
					{
						num = (short)445251584;
						short num6 = num;
						goto IL_7A2;
					}
					case 27:
					{
						global::DevComponents.WpfRibbon.QatOverflowPanel overflowPanel;
						if (overflowPanel != null)
						{
							num = (short)1650262047;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4D7;
					}
					case 28:
						goto IL_289;
					case 29:
					{
						global::System.Windows.UIElement element;
						if (global::DevComponents.WpfRibbon.Qat.GetIsOverflowItem(element))
						{
							num = (short)978649124;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_643;
					}
					case 30:
						if (this.IsCompleteOverflow)
						{
							num = (short)1258291237;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 31:
					{
						global::DevComponents.WpfRibbon.QatOverflowPanel overflowPanel;
						overflowPanel.Children.Clear();
						num = (short)1622212643;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 32:
						qat.HasOverflowItems = flag;
						num = (short)664993818;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsEmpty(base.Margin))
						{
							num = (short)1088880665;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 34:
						if (global::DevComponents.WpfRibbon.LayoutHelpers.GreaterThan(desiredSize.Width + result.Width, availableSize.Width))
						{
							num = (short)572719114;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7E5;
					case 35:
						goto IL_4D7;
					case 36:
					{
						global::System.Windows.UIElement element;
						this.m_Children.Remove(element);
						global::DevComponents.WpfRibbon.QatOverflowPanel overflowPanel;
						overflowPanel.Children.Insert(0, element);
						num = (short)2117468161;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 37:
						num = (short)1691090977;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_DC:
					if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsEmpty(this.m_OldMargin))
					{
						num = (short)1169752082;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_741;
					IL_142:
					num = (short)1726545921;
					if (num != 0)
					{
					}
					num = (short)1164967947;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_289:
					qat = this.Qat;
					num = (short)644481036;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3A1:
					num5++;
					num = (short)1190068237;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4D7:
					this.m_Children.Clear();
					enumerator = this.m_GeneratedChildren.GetEnumerator();
					num = (short)819260209;
					short num7 = num;
					num = (short)880732977;
					switch ((num7 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_82C;
					default:
						num = (short)1826226176;
						if (num != 0)
						{
						}
						num = (short)702414872;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_604:
					num = (short)699596802;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_643:
					num3--;
					num = (short)1354301454;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_664:
					global::DevComponents.WpfRibbon.Qat.SetIsOverflowItem(uielement, true);
					flag = true;
					num = (short)1462501382;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_707:
					num4 = this.m_GeneratedChildren.Count - 1;
					flag = false;
					result = default(global::System.Windows.Size);
					num5 = 0;
					num = (short)1251409928;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_741:
					this.GenerateChildren();
					availableSize2 = new global::System.Windows.Size(double.PositiveInfinity, availableSize.Height);
					num = (short)2112028688;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7A2:
					num = (short)1367932958;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7E5:
					result.Width += desiredSize.Width;
					result.Height = global::System.Math.Max(desiredSize.Height, result.Height);
					num = (short)1033306134;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
			}
			}
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x0007641C File Offset: 0x0007461C
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			short num = (short)636747776;
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
				int num3;
				int num4;
				double num7;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						goto IL_70;
					case 1:
						goto IL_70;
					case 2:
						return finalSize;
					case 3:
					{
						num = (short)532283393;
						if (num != 0)
						{
						}
						if (num3 > num4)
						{
							num = (short)1713700866;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)983367680;
						short num5 = num;
						num = (short)1921248258;
						short num6 = num;
						num = (short)641723394;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
						{
							num = (short)1725825024;
							if (num != 0)
							{
							}
							global::System.Windows.UIElement uielement = this.m_Children[num3];
							uielement.Arrange(new global::System.Windows.Rect(num7, 0.0, uielement.DesiredSize.Width, global::System.Math.Max(uielement.DesiredSize.Height, finalSize.Height)));
							num7 += global::System.Math.Round(uielement.DesiredSize.Width);
							num3++;
							num = (short)533856257;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					}
					goto IL_3E;
					IL_70:
					num = (short)2116222979;
					num2 = (int)((global::System.IntPtr)num);
				}
				return finalSize;
				IL_3E:
				num4 = this.m_Children.Count - 1;
				num7 = 0.0;
				num3 = 0;
				num = (short)1780678656;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x000765F4 File Offset: 0x000747F4
		private void GenerateChildren()
		{
			short num = (short)1076166656;
			switch (num)
			{
			default:
			{
				num = (short)477560838;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Windows.Controls.Primitives.IItemContainerGenerator itemGenerator;
					global::System.IDisposable disposable;
					global::DevComponents.WpfRibbon.QatOverflowPanel overflowPanel;
					global::DevComponents.WpfRibbon.Qat qat;
					switch (num2)
					{
					case 0:
						return;
					case 1:
						goto IL_3B7;
					case 2:
						if (this.m_ItemGenerator == null)
						{
							num = (short)549650446;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_49D;
					case 3:
						goto IL_3B7;
					case 4:
						try
						{
							num = (short)1981808640;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_174;
									}
									continue;
								case 1:
									goto IL_216;
								case 2:
								{
									global::System.Windows.UIElement uielement;
									if ((uielement = (itemGenerator.GenerateNext() as global::System.Windows.UIElement)) == null)
									{
										num = (short)236126211;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									this.m_GeneratedChildren.Add(uielement);
									this.m_Children.Add(uielement);
									global::DevComponents.WpfRibbon.Qat.SetIsOverflowItem(uielement, false);
									itemGenerator.PrepareItemContainer(uielement);
									num = (short)2103967748;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)1308819457;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1BD:
								num = (short)1010761730;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_174:
								goto IL_1BD;
							}
							IL_216:
							goto IL_346;
						}
						finally
						{
							num = (short)358547458;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_285;
								case 1:
									disposable.Dispose();
									num = (short)2124611584;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_24D;
									}
									continue;
								}
								goto IL_24D;
								IL_250:
								num = (short)290390017;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_285:
								num = (short)50971252;
								short num3 = num;
								num = (short)1451606644;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_250;
								default:
									goto IL_2BC;
								}
								IL_24D:
								if (disposable != null)
								{
									goto IL_250;
								}
								goto IL_285;
							}
							IL_2BC:
							num = (short)1457520640;
							if (num != 0)
							{
							}
						}
						goto IL_2D3;
					case 5:
						overflowPanel.Children.Clear();
						num = (short)760086539;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_89;
						}
						continue;
					case 7:
						if (base.IsItemsHost)
						{
							num = (short)960167948;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4ED;
					case 8:
						goto IL_49D;
					case 9:
						num = (short)407502850;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						this.m_Children = this.CreateUIElementCollection(null);
						num = (short)1634205699;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_31A;
					case 12:
						num = (short)539557904;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (overflowPanel != null)
						{
							num = (short)110624773;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_31A;
					case 14:
						this.m_ItemGenerator = ((global::System.Windows.Controls.Primitives.IItemContainerGenerator)qat.ItemContainerGenerator).GetItemContainerGeneratorForPanel(this);
						this.m_ItemGenerator.ItemsChanged += this.OnItemsChanged;
						num = (short)744751112;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (this.m_Children == null)
						{
							num = (short)1886781450;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.m_Children.Clear();
						num = (short)1873084417;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (qat != null)
						{
							num = (short)1210974217;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4ED;
					}
					IL_89:
					if (this.m_ChildrenGenerated)
					{
						num = (short)1924399104;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_2D3:
					qat = this.Qat;
					num = (short)1704787975;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_31A:
					disposable = itemGenerator.StartAt(new global::System.Windows.Controls.Primitives.GeneratorPosition(-1, 0), global::System.Windows.Controls.Primitives.GeneratorDirection.Forward);
					num = (short)1832517636;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3B7:
					num = (short)209911809;
					if (num != 0)
					{
					}
					num = (short)1702559744;
					short num4 = num;
					this.GeneratedChildren.Clear();
					overflowPanel = this.OverflowPanel;
					num = (short)1697775629;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_49D:
					itemGenerator = this.m_ItemGenerator;
					itemGenerator.RemoveAll();
					num = (short)1048641551;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_346:
				this.m_ChildrenGenerated = true;
				return;
				IL_4ED:
				this.m_Children = base.InternalChildren;
				return;
			}
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000561 RID: 1377 RVA: 0x00076B0C File Offset: 0x00074D0C
		internal bool IsCompleteOverflow
		{
			get
			{
				short num = (short)1418067970;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1475674118;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return true;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_45;
						}
						continue;
					case 3:
					{
						num = (short)1618673664;
						short num3 = num;
						num = (short)424083461;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_69;
					case 5:
					{
						if (this.OverflowPanel == null)
						{
							goto IL_1A8;
						}
						num = (short)138015826;
						short num4 = num;
						num = (short)2090005586;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_69;
						default:
							num = (short)294715392;
							if (num != 0)
							{
							}
							num = (short)816119812;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
						if (this.m_Children.Count == 0)
						{
							num = (short)1177747459;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A8;
					case 7:
						if (this.OverflowPanel.Children.Count > 0)
						{
							num = (short)1692467201;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A8;
					}
					IL_45:
					if (this.m_Children != null)
					{
						num = (short)2146238464;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1A8;
					IL_69:
					num = (short)808452103;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_1A8:
				num = (short)718733313;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000562 RID: 1378 RVA: 0x00076CEC File Offset: 0x00074EEC
		private global::DevComponents.WpfRibbon.Qat Qat
		{
			get
			{
				short num = (short)1438908416;
				short num2 = num;
				num = (short)127098109;
				short num3 = num;
				num = (short)501767421;
				switch (num3 == num)
				{
				}
				num = (short)2035548161;
				if (num != 0)
				{
				}
				num = (short)1132593152;
				if (num != 0)
				{
				}
				return base.TemplatedParent as global::DevComponents.WpfRibbon.Qat;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000563 RID: 1379 RVA: 0x00076DA0 File Offset: 0x00074FA0
		internal global::System.Collections.Generic.List<global::System.Windows.UIElement> GeneratedChildren
		{
			get
			{
				short num = (short)1907884034;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_9A;
					case 1:
						this.m_GeneratedChildren = new global::System.Collections.Generic.List<global::System.Windows.UIElement>(10);
						num = (short)920387584;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					}
					goto IL_31;
					IL_39:
					num = (short)453509121;
					if (num != 0)
					{
					}
					num = (short)1755119617;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9A:
					num = (short)1126760448;
					short num3 = num;
					num = (short)1642627641;
					short num4 = num;
					num = (short)1627292217;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_39;
					default:
						goto IL_F7;
					}
					IL_31:
					if (this.m_GeneratedChildren == null)
					{
						goto IL_39;
					}
					goto IL_9A;
				}
				IL_F7:
				num = (short)1362231296;
				if (num != 0)
				{
				}
				return this.m_GeneratedChildren;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000564 RID: 1380 RVA: 0x00076EC4 File Offset: 0x000750C4
		private global::DevComponents.WpfRibbon.QatOverflowPanel OverflowPanel
		{
			get
			{
				short num = (short)1076917559;
				short num2 = num;
				num = (short)1505195319;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_AF;
				case 1:
					break;
				default:
				{
					num = (short)1223557120;
					short num3 = num;
					break;
				}
				}
				num = (short)181338112;
				if (num != 0)
				{
				}
				num = (short)1560870913;
				if (num != 0)
				{
				}
				global::DevComponents.WpfRibbon.Qat qat = this.Qat;
				if (qat != null)
				{
					return qat.OverflowPanel;
				}
				IL_AF:
				return null;
			}
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00076F84 File Offset: 0x00075184
		private void OnItemsChanged(object sender, global::System.Windows.Controls.Primitives.ItemsChangedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::System.Collections.Specialized.NotifyCollectionChangedAction action;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (action > global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
					{
						num2 = (short)34537476;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_5B;
				case 1:
					num2 = (short)1955135489;
					if (num2 != 0)
					{
					}
					goto IL_5B;
				case 2:
					goto IL_7C;
				case 3:
				{
					num2 = (short)1854841689;
					short num3 = num2;
					num2 = (short)708289369;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_68;
					default:
					{
						num2 = (short)1786052608;
						short num4 = num2;
						num2 = (short)634978304;
						if (num2 != 0)
						{
						}
						if (action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset)
						{
							num2 = (short)78774273;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_153;
					}
					}
					break;
				}
				case 4:
					num2 = (short)1775566851;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
				IL_68:
				num2 = (short)174194690;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_5B:
				this.m_ChildrenGenerated = false;
				this.GenerateChildren();
				goto IL_68;
			}
			IL_7C:
			IL_153:
			base.InvalidateMeasure();
			return;
			IL_24:
			action = e.Action;
			num2 = (short)834928640;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000566 RID: 1382 RVA: 0x000770EC File Offset: 0x000752EC
		protected override int VisualChildrenCount
		{
			get
			{
				short num = (short)1079117502;
				short num2 = num;
				num = (short)865535678;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_AE;
				case 1:
					break;
				default:
				{
					num = (short)507052032;
					short num3 = num;
					break;
				}
				}
				num = (short)476315648;
				if (num != 0)
				{
				}
				num = (short)1981153281;
				if (num != 0)
				{
				}
				if (this.m_Children == null)
				{
					return base.VisualChildrenCount;
				}
				IL_AE:
				return this.m_Children.Count;
			}
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x000771B4 File Offset: 0x000753B4
		protected override global::System.Windows.Media.Visual GetVisualChild(int index)
		{
			int a_ = 3;
			short num = (short)231407616;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)2073753622;
					short num3 = num;
					num = (short)938932246;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)823263232;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_92;
						}
						continue;
					}
					break;
				}
				case 1:
					goto IL_173;
				case 2:
					if (this.m_Children == null)
					{
						num = (short)1547173891;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1A9;
				case 3:
					goto IL_E4;
				case 4:
					if (index >= this.VisualChildrenCount)
					{
						num = (short)2146369537;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1971453954;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					num = (short)1704460292;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_92:
				if (index < 0)
				{
					goto IL_10F;
				}
				num = (short)13762565;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_E4:
			num = (short)879493121;
			if (num != 0)
			{
			}
			return base.GetVisualChild(index);
			IL_10F:
			throw new global::System.ArgumentOutOfRangeException(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㉚㍜㭞Ѡ᭢", a_), index, global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᩚ⽜㡞ᑠ๢d०ᵨ䭪୬nͰ卲⍴Ṷ੸๺ᱼ፾ꆀ권뎒杖뮚咽膠톢쒤즦캨캪", a_));
			IL_173:
			num = (short)1172897792;
			short num4 = num;
			goto IL_10F;
			IL_1A9:
			return this.m_Children[index];
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000568 RID: 1384 RVA: 0x00077378 File Offset: 0x00075578
		internal bool HasOnlyCustomizeItem
		{
			get
			{
				short num = (short)328269824;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1984424315;
						short num3 = num;
						num = (short)187099515;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)57933825;
							if (num != 0)
							{
							}
							num = (short)175308800;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_B5;
							}
							continue;
						}
						break;
					}
					case 1:
						num = (short)1792933890;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (this.Children[0] is global::DevComponents.WpfRibbon.QatCustomizeButton)
						{
							num = (short)358350851;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 3:
						return true;
					case 4:
						if (this.Children.Count == 1)
						{
							num = (short)722665473;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 5:
						goto IL_D2;
					}
					IL_B5:
					if (!this.m_ChildrenGenerated)
					{
						num = (short)1493565445;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1491795972;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_D2:
				num = (short)1274609664;
				short num4 = num;
				return false;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000569 RID: 1385 RVA: 0x00077510 File Offset: 0x00075710
		[global::System.ComponentModel.Browsable(false)]
		public new global::System.Windows.Controls.UIElementCollection Children
		{
			get
			{
				short num = (short)1192335564;
				short num2 = num;
				num = (short)1672845516;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_B0;
				case 1:
					break;
				default:
				{
					num = (short)67829760;
					short num3 = num;
					break;
				}
				}
				num = (short)777191425;
				if (num != 0)
				{
				}
				num = (short)1832648704;
				if (num != 0)
				{
				}
				if (this.m_ChildrenGenerated)
				{
					return this.m_Children;
				}
				IL_B0:
				return base.Children;
			}
		}

		// Token: 0x040002A9 RID: 681
		private global::System.Windows.Controls.UIElementCollection m_Children;

		// Token: 0x040002AA RID: 682
		private global::System.Windows.Controls.ItemContainerGenerator m_ItemGenerator;

		// Token: 0x040002AB RID: 683
		private global::System.Collections.Generic.List<global::System.Windows.UIElement> m_GeneratedChildren;

		// Token: 0x040002AC RID: 684
		private bool m_ChildrenGenerated;

		// Token: 0x040002AD RID: 685
		private global::System.Windows.Thickness m_OldMargin;
	}
}
