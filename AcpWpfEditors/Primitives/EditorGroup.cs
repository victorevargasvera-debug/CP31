using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;

namespace DevComponents.WpfEditors.Primitives
{
	// Token: 0x02000063 RID: 99
	[global::System.Windows.Markup.ContentProperty("Items")]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class EditorGroup : global::DevComponents.WpfEditors.Primitives.EditorElement
	{
		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000664 RID: 1636 RVA: 0x00085D70 File Offset: 0x00083F70
		// (set) Token: 0x06000665 RID: 1637 RVA: 0x00085E28 File Offset: 0x00084028
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DefaultValue(1)]
		public double HorizontalItemSpacing
		{
			get
			{
				short num = (short)1899444774;
				short num2 = num;
				num = (short)2105489958;
				switch (num2 == num)
				{
				default:
				{
					num = (short)452657152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)584515584;
				if (num != 0)
				{
				}
				num = (short)920322049;
				if (num != 0)
				{
				}
				return (double)base.GetValue(global::DevComponents.WpfEditors.Primitives.EditorGroup.HorizontalItemSpacingProperty);
			}
			set
			{
				short num = (short)1067646977;
				if (num != 0)
				{
				}
				num = (short)1567031296;
				short num2 = num;
				num = (short)1677321801;
				short num3 = num;
				num = (short)2068309577;
				switch (num3 == num)
				{
				}
				num = (short)888209408;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.Primitives.EditorGroup.HorizontalItemSpacingProperty, value);
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x00085EE4 File Offset: 0x000840E4
		// (set) Token: 0x06000667 RID: 1639 RVA: 0x00085F9C File Offset: 0x0008419C
		[global::System.ComponentModel.Category("Layout")]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.VerticalAlignment VerticalContentAlignment
		{
			get
			{
				short num = (short)1130928650;
				short num2 = num;
				num = (short)1853266442;
				switch (num2 == num)
				{
				default:
				{
					num = (short)255328256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)777781249;
				if (num != 0)
				{
				}
				num = (short)1565392896;
				if (num != 0)
				{
				}
				return (global::System.Windows.VerticalAlignment)base.GetValue(global::DevComponents.WpfEditors.Primitives.EditorGroup.VerticalContentAlignmentProperty);
			}
			set
			{
				short num = (short)1428677092;
				short num2 = num;
				num = (short)529261028;
				switch (num2 == num)
				{
				default:
				{
					num = (short)446169088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1556283393;
				if (num != 0)
				{
				}
				num = (short)653656064;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.Primitives.EditorGroup.VerticalContentAlignmentProperty, value);
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000668 RID: 1640 RVA: 0x00086058 File Offset: 0x00084258
		// (set) Token: 0x06000669 RID: 1641 RVA: 0x00086114 File Offset: 0x00084314
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Category("Layout")]
		public global::System.Windows.HorizontalAlignment HorizonalContentAlignment
		{
			get
			{
				short num = (short)210709814;
				short num2 = num;
				num = (short)880487734;
				switch (num2 == num)
				{
				default:
				{
					num = (short)983891968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)975372288;
				if (num != 0)
				{
				}
				num = (short)513212417;
				if (num != 0)
				{
				}
				return (global::System.Windows.HorizontalAlignment)base.GetValue(global::DevComponents.WpfEditors.Primitives.EditorGroup.HorizonalContentAlignmentProperty);
			}
			set
			{
				short num = (short)1263760719;
				short num2 = num;
				num = (short)64648527;
				switch (num2 == num)
				{
				default:
				{
					num = (short)460652544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1273233409;
				if (num != 0)
				{
				}
				num = (short)357040128;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.Primitives.EditorGroup.HorizonalContentAlignmentProperty, value);
			}
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x000861CC File Offset: 0x000843CC
		static EditorGroup()
		{
			int a_ = 18;
			short num = (short)44660439;
			short num2 = num;
			num = (short)2022667991;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1323499520;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1579679744;
			if (num != 0)
			{
			}
			num = (short)1211105281;
			if (num != 0)
			{
			}
			global::DevComponents.WpfEditors.Primitives.EditorGroup.HorizontalItemSpacingProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("韞軠釢賤鷦蛨藪駬軮鷰뫲致鋶铸꣺跼黾戀樂欄怆", a_), typeof(double), typeof(global::DevComponents.WpfEditors.Primitives.EditorGroup), new global::System.Windows.FrameworkPropertyMetadata(1.0, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));
			global::DevComponents.WpfEditors.Primitives.EditorGroup.VerticalContentAlignmentProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("觞蓠釢釤軦諨諪臬곮黰鷲致鋶韸迺볼鏾栀搂欄樆氈攊礌", a_), typeof(global::System.Windows.VerticalAlignment), typeof(global::DevComponents.WpfEditors.Primitives.EditorGroup), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.VerticalAlignment.Center, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange));
			global::DevComponents.WpfEditors.Primitives.EditorGroup.HorizonalContentAlignmentProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("韞軠釢賤鷦蛨藪賬菮닰鳲鯴菶鳸闺觼뻾洀樂戄椆搈渊挌笎", a_), typeof(global::System.Windows.HorizontalAlignment), typeof(global::DevComponents.WpfEditors.Primitives.EditorGroup), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.HorizontalAlignment.Left, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange));
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x0600066B RID: 1643 RVA: 0x00086330 File Offset: 0x00084530
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
		public global::System.Windows.Controls.UIElementCollection Items
		{
			get
			{
				short num = (short)1539673994;
				short num2 = num;
				num = (short)1862045578;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1295253504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)606797825;
				if (num != 0)
				{
				}
				num = (short)37027840;
				if (num != 0)
				{
				}
				return this.InternalItems;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x0600066C RID: 1644 RVA: 0x000863E4 File Offset: 0x000845E4
		protected internal global::System.Windows.Controls.UIElementCollection InternalItems
		{
			get
			{
				short num = (short)315621378;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)107282433;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_112;
					case 1:
					{
						num = (short)1826750464;
						short num3 = num;
						num = (short)958099;
						short num4 = num;
						num = (short)471309971;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_64;
						default:
							num = (short)1826095104;
							if (num != 0)
							{
							}
							this.a = this.CreateUIElementCollection(this);
							num = (short)1395851264;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_59;
						}
						continue;
					}
					goto IL_59;
					IL_64:
					num = (short)271450113;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_59:
					if (this.a == null)
					{
						goto IL_64;
					}
					break;
				}
				IL_112:
				return this.a;
			}
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x0008650C File Offset: 0x0008470C
		protected virtual global::System.Windows.Controls.UIElementCollection CreateUIElementCollection(global::System.Windows.FrameworkElement logicalParent)
		{
			short num = (short)1564508347;
			short num2 = num;
			num = (short)374243515;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1836515328;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)880017408;
			if (num != 0)
			{
			}
			num = (short)191627265;
			if (num != 0)
			{
			}
			return new global::System.Windows.Controls.UIElementCollection(this, logicalParent);
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x000865C0 File Offset: 0x000847C0
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			short num = (short)2082996224;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::System.Windows.Size result = default(global::System.Windows.Size);
				global::System.Windows.Controls.UIElementCollection items = this.Items;
				double horizontalItemSpacing = this.HorizontalItemSpacing;
				global::System.Collections.IEnumerator enumerator = items.GetEnumerator();
				try
				{
					num = (short)1901527044;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 1:
							goto IL_147;
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)12255235;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)enumerator.Current;
							uielement.Measure(availableSize);
							result.Width += global::System.Math.Ceiling(uielement.DesiredSize.Width) + horizontalItemSpacing;
							result.Height = global::System.Math.Max(result.Height, global::System.Math.Ceiling(uielement.DesiredSize.Height));
							num = (short)78708736;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							num = (short)1979187201;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_75;
							}
							continue;
						}
						IL_EF:
						num = (short)890961922;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_75:
						goto IL_EF;
					}
					IL_147:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_169;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_156:
						switch (num2)
						{
						case 0:
						{
							num = (short)1259245343;
							short num3 = num;
							num = (short)648908575;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_186;
							default:
								goto IL_1F7;
							}
							break;
						}
						case 1:
							disposable.Dispose();
							num = (short)400228352;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_186;
						}
						goto IL_169;
						IL_186:
						if (disposable == null)
						{
							goto IL_20E;
						}
						num = (short)1058930689;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1F7:
					num = (short)915144704;
					if (num != 0)
					{
					}
					IL_20E:
					goto EndFinally_5;
					IL_169:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)1475936258;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_156;
					EndFinally_5:;
				}
				num = (short)834404353;
				if (num != 0)
				{
				}
				num = (short)1106640896;
				short num4 = num;
				return result;
			}
			}
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x00086850 File Offset: 0x00084A50
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			short num = (short)600375296;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_8A;
				}
				double num5;
				global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> list;
				double horizontalItemSpacing;
				global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> list2;
				global::System.Windows.VerticalAlignment verticalContentAlignment;
				global::System.Collections.IEnumerator enumerator2;
				for (;;)
				{
					IL_27:
					double num4;
					int num6;
					global::System.Windows.FrameworkElement frameworkElement;
					global::System.Windows.Size desiredSize;
					double y;
					switch (num2)
					{
					case 0:
					{
						num = (short)379650049;
						if (num != 0)
						{
						}
						global::System.Windows.VerticalAlignment verticalAlignment;
						if (verticalAlignment == global::System.Windows.VerticalAlignment.Bottom)
						{
							num = (short)1507393548;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2099773460;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_BE3;
					case 2:
						goto IL_BBB;
					case 3:
						goto IL_1B6;
					case 4:
						goto IL_BE3;
					case 5:
					{
						double num3 = global::System.Math.Max(4.0, (num4 - num5 - (double)list.Count * horizontalItemSpacing) / (double)list.Count);
						global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>.Enumerator enumerator = list.GetEnumerator();
						num = (short)382009359;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						num6 = list2.Count - 1;
						num = (short)855244819;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						if (frameworkElement.VerticalAlignment == global::System.Windows.VerticalAlignment.Stretch)
						{
							num = (short)717750274;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.VerticalAlignment verticalAlignment = frameworkElement.VerticalAlignment;
						num = (short)210960388;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						if (list.Count > 0)
						{
							num = (short)1415839749;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return finalSize;
					case 9:
						goto IL_DA;
					case 10:
					{
						global::System.Windows.VerticalAlignment verticalAlignment;
						if (verticalAlignment == global::System.Windows.VerticalAlignment.Top)
						{
							num = (short)230359061;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_518;
					}
					case 11:
						if (list2.Count > 0)
						{
							num = (short)1998127110;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B6;
					case 12:
						y = finalSize.Height - desiredSize.Height;
						num = (short)909508630;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						y = 0.0;
						desiredSize.Height = finalSize.Height;
						num = (short)1651900434;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_C37;
					case 15:
						try
						{
							num = (short)1728512008;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Windows.Size desiredSize2;
								double y2;
								global::System.Windows.FrameworkElement frameworkElement2;
								switch (num2)
								{
								case 0:
									num = (short)869335042;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_505;
								case 3:
									goto IL_4A3;
								case 4:
									y2 = finalSize.Height - desiredSize2.Height;
									num = (short)1080426509;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									if (frameworkElement2.VerticalAlignment == global::System.Windows.VerticalAlignment.Top)
									{
										num = (short)883621895;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1948844041;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1670905856;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									frameworkElement2 = enumerator.Current;
									desiredSize2 = frameworkElement2.DesiredSize;
									y2 = (finalSize.Height - desiredSize2.Height) / 2.0;
									num = (short)146866181;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									y2 = 0.0;
									num = (short)2085355523;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									switch (0)
									{
									case 0:
										goto IL_2DB;
									}
									continue;
								case 9:
									if (frameworkElement2.VerticalAlignment == global::System.Windows.VerticalAlignment.Bottom)
									{
										num = (short)61472772;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1547960332;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									goto IL_4A3;
								case 11:
									y2 = 0.0;
									desiredSize2.Height = finalSize.Height;
									num = (short)1054998538;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									if (frameworkElement2.VerticalAlignment == global::System.Windows.VerticalAlignment.Stretch)
									{
										num = (short)1959657483;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4A3;
								case 13:
									goto IL_4A3;
								}
								IL_3B1:
								num = (short)445054982;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2DB:
								goto IL_3B1;
								IL_4A3:
								double num3;
								global::System.Windows.Rect finalRect = new global::System.Windows.Rect(num5, y2, global::System.Math.Ceiling(num3), desiredSize2.Height);
								frameworkElement2.Arrange(finalRect);
								num5 += finalRect.Width + horizontalItemSpacing;
								num = (short)1411645441;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_505:
							return finalSize;
						}
						finally
						{
							global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_518;
					case 16:
					{
						if (num6 < 0)
						{
							num = (short)534577155;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						frameworkElement = list2[num6];
						desiredSize = frameworkElement.DesiredSize;
						global::System.Windows.VerticalAlignment verticalAlignment = verticalContentAlignment;
						num = (short)585695239;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						try
						{
							num = (short)1814102034;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Windows.Size desiredSize3;
								global::System.Windows.UIElement uielement;
								double y3;
								switch (num2)
								{
								case 0:
									desiredSize3.Height = finalSize.Height;
									num = (short)1448935429;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::System.Windows.VerticalAlignment verticalAlignment2;
									if (verticalAlignment2 == global::System.Windows.VerticalAlignment.Stretch)
									{
										num = (short)1487732752;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_83E;
								}
								case 2:
								{
									global::System.Windows.FrameworkElement frameworkElement3 = uielement as global::System.Windows.FrameworkElement;
									num = (short)736493583;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_83E;
								case 4:
									goto IL_83E;
								case 5:
									goto IL_79F;
								case 6:
								{
									num = (short)349017090;
									short num7 = num;
									num = (short)880514050;
									switch ((num7 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_9BD;
									default:
										num = (short)293797888;
										if (num != 0)
										{
										}
										y3 = 0.0;
										num = (short)1151926293;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
								{
									global::System.Windows.FrameworkElement frameworkElement3;
									list.Add(frameworkElement3);
									num = (short)1997930518;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									global::System.Windows.FrameworkElement frameworkElement3;
									list2.Add(frameworkElement3);
									num = (short)1269891084;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									num = (short)789577742;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									if (!enumerator2.MoveNext())
									{
										num = (short)798752777;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									uielement = (global::System.Windows.UIElement)enumerator2.Current;
									num = (short)2078539795;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									goto IL_9BD;
								case 13:
								{
									global::System.Windows.FrameworkElement frameworkElement3;
									if (frameworkElement3.HorizontalAlignment == global::System.Windows.HorizontalAlignment.Right)
									{
										num = (short)303366152;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1947336728;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 14:
									goto IL_B41;
								case 15:
								{
									global::System.Windows.FrameworkElement frameworkElement3;
									if (frameworkElement3.VerticalAlignment == global::System.Windows.VerticalAlignment.Stretch)
									{
										num = (short)1324482560;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Windows.VerticalAlignment verticalAlignment2 = frameworkElement3.VerticalAlignment;
									num = (short)935985172;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 16:
									y3 = 0.0;
									desiredSize3.Height = finalSize.Height;
									num = (short)331612163;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 17:
									if (uielement is global::System.Windows.FrameworkElement)
									{
										num = (short)491061250;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_9EB;
								case 18:
									switch (0)
									{
									case 0:
										goto IL_6DF;
									}
									continue;
								case 19:
									if (uielement.Visibility != global::System.Windows.Visibility.Collapsed)
									{
										num = (short)1656225819;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 20:
									goto IL_79F;
								case 21:
									goto IL_83E;
								case 24:
								{
									global::System.Windows.FrameworkElement frameworkElement3;
									if (frameworkElement3.HorizontalAlignment == global::System.Windows.HorizontalAlignment.Stretch)
									{
										num = (short)1743978503;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_9EB;
								}
								case 25:
								{
									global::System.Windows.VerticalAlignment verticalAlignment2;
									if (verticalAlignment2 == global::System.Windows.VerticalAlignment.Bottom)
									{
										num = (short)484638731;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1362690049;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 26:
								{
									global::System.Windows.VerticalAlignment verticalAlignment2;
									if (verticalAlignment2 == global::System.Windows.VerticalAlignment.Top)
									{
										num = (short)1910177798;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1293680665;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 27:
								{
									global::System.Windows.VerticalAlignment verticalAlignment2 = verticalContentAlignment;
									desiredSize3 = uielement.DesiredSize;
									num = (short)1490419729;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								goto IL_6DF;
								IL_79F:
								num = (short)1093074957;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_83E:
								global::System.Windows.Rect finalRect2 = new global::System.Windows.Rect(num5, y3, global::System.Math.Ceiling(desiredSize3.Width), desiredSize3.Height);
								uielement.Arrange(finalRect2);
								num5 += finalRect2.Width + horizontalItemSpacing;
								num = (short)1799028759;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_928:
								num = (short)654245898;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_6DF:
								goto IL_928;
								IL_9BD:
								y3 = finalSize.Height - desiredSize3.Height;
								num = (short)1759903748;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_9EB:
								y3 = (finalSize.Height - desiredSize3.Height) / 2.0;
								num = (short)1805320218;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_B41:
							goto IL_1FA;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_B63;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_B50:
								switch (num2)
								{
								case 0:
									goto IL_BB8;
								case 1:
									if (disposable != null)
									{
										num = (short)19202050;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_BBA;
								case 2:
									disposable.Dispose();
									num = (short)1233387520;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_B63;
							}
							IL_BB8:
							IL_BBA:
							goto EndFinally_26;
							IL_B63:
							disposable = (enumerator2 as global::System.IDisposable);
							num = (short)1566638081;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_B50;
							EndFinally_26:;
						}
						goto IL_BBB;
						IL_1FA:
						num4 = finalSize.Width;
						num = (short)215416843;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						goto IL_DA;
					case 19:
					{
						num = (short)679477248;
						short num8 = num;
						goto IL_C37;
					}
					case 20:
					{
						global::System.Windows.VerticalAlignment verticalAlignment;
						if (verticalAlignment == global::System.Windows.VerticalAlignment.Stretch)
						{
							num = (short)186843149;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DA;
					}
					case 21:
						y = 0.0;
						num = (short)1819017225;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						goto IL_DA;
					}
					goto IL_8A;
					IL_DA:
					num4 -= desiredSize.Width;
					global::System.Windows.Rect finalRect3 = new global::System.Windows.Rect(num4, y, global::System.Math.Ceiling(desiredSize.Width), desiredSize.Height);
					frameworkElement.Arrange(finalRect3);
					num4 -= horizontalItemSpacing;
					num6--;
					num = (short)349372430;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B6:
					num = (short)898957320;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_518:
					num = (short)592707584;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BBB:
					desiredSize.Height = finalSize.Height;
					num = (short)1815543809;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BE3:
					y = (finalSize.Height - desiredSize.Height) / 2.0;
					num = (short)1625489418;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C37:
					num = (short)534642704;
					num2 = (int)((global::System.IntPtr)num);
				}
				return finalSize;
				IL_8A:
				global::System.Windows.Controls.UIElementCollection items = this.Items;
				horizontalItemSpacing = this.HorizontalItemSpacing;
				num5 = 0.0;
				verticalContentAlignment = this.VerticalContentAlignment;
				list2 = new global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>();
				list = new global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>();
				enumerator2 = items.GetEnumerator();
				num = (short)288686097;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000670 RID: 1648 RVA: 0x0008756C File Offset: 0x0008576C
		// (set) Token: 0x06000671 RID: 1649 RVA: 0x000876B8 File Offset: 0x000858B8
		public global::DevComponents.WpfEditors.Primitives.EditorElement FocusedItem
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_20;
				}
				short num2;
				global::DevComponents.WpfEditors.Primitives.EditorElement editorElement;
				for (;;)
				{
					IL_0A:
					int num;
					switch (num)
					{
					case 0:
						num2 = (short)1540751361;
						if (num2 != 0)
						{
						}
						if (this.Items.Contains(editorElement))
						{
							num2 = (short)173211650;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_13E;
					case 1:
						if (editorElement == null)
						{
							num2 = (short)349634563;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1450704896;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						return editorElement;
					case 3:
						goto IL_D1;
					}
					goto IL_20;
				}
				IL_D1:
				return null;
				IL_13E:
				return null;
				IL_20:
				editorElement = (global::System.Windows.Input.Keyboard.FocusedElement as global::DevComponents.WpfEditors.Primitives.EditorElement);
				num2 = (short)999949696;
				short num3 = num2;
				num2 = (short)1382679936;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_0A;
				default:
				{
					num2 = (short)995950592;
					if (num2 != 0)
					{
					}
					num2 = (short)1612644352;
					short num4 = num2;
					num2 = (short)1999831041;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				}
			}
			set
			{
				short num = (short)1500971009;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_32;
						}
						continue;
					case 2:
						for (;;)
						{
							value.Focus();
							num = (short)669515777;
							if (num != 0)
							{
							}
							num = (short)2137103844;
							short num3 = num;
							num = (short)1809358308;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_DC;
							}
						}
						IL_DC:
						num = (short)1807089664;
						if (num != 0)
						{
						}
						num = (short)1211301888;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_32:
					num = (short)411566080;
					short num4 = num;
					if (value == null)
					{
						break;
					}
					num = (short)1396113410;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x000877D4 File Offset: 0x000859D4
		protected override void OnLostKeyboardFocus(global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			short num = (short)1486553092;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1038942208;
				short num3 = num;
				switch (num2)
				{
				case 0:
					num = (short)1635516419;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)410481842;
					short num4 = num;
					num = (short)257389746;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_120;
					default:
						num = (short)1827209216;
						if (num != 0)
						{
						}
						this.OnFocusedItemChanged((global::DevComponents.WpfEditors.Primitives.EditorElement)e.Source);
						num = (short)1249116165;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					num = (short)1136459782;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (e.Source is global::DevComponents.WpfEditors.Primitives.EditorElement)
					{
						num = (short)1668022273;
						if (num != 0)
						{
						}
						num = (short)1723203586;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C1;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_6A;
					}
					continue;
				case 5:
					goto IL_102;
				case 6:
					goto IL_120;
				}
				IL_6A:
				if (e.Source != this)
				{
					num = (short)296353792;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_120:
				if (!this.Items.Contains((global::DevComponents.WpfEditors.Primitives.EditorElement)e.Source))
				{
					break;
				}
				num = (short)2139226113;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_102:
			IL_1C1:
			base.OnLostKeyboardFocus(e);
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x000879AC File Offset: 0x00085BAC
		protected virtual void OnFocusedItemChanged(global::DevComponents.WpfEditors.Primitives.EditorElement previousFocus)
		{
			short num = (short)897646593;
			if (num != 0)
			{
			}
			num = (short)2117872115;
			short num2 = num;
			num = (short)59189747;
			switch (num2 == num)
			{
			}
			num = (short)68288512;
			if (num != 0)
			{
			}
			num = (short)1788084224;
			short num3 = num;
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x00087A54 File Offset: 0x00085C54
		protected virtual bool CanFocus(global::DevComponents.WpfEditors.Primitives.EditorElement v)
		{
			short num = (short)1349189634;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (!v.Focusable)
					{
						goto IL_134;
					}
					goto IL_1B6;
				case 1:
					num = (short)1283981315;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					continue;
				case 3:
				{
					if (!(v is global::DevComponents.WpfEditors.Primitives.EditorInputGroup))
					{
						return false;
					}
					num = (short)1498677249;
					if (num != 0)
					{
					}
					num = (short)776468135;
					short num3 = num;
					num = (short)992736935;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_134;
					default:
						num = (short)1090846720;
						if (num != 0)
						{
						}
						num = (short)330432519;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					if (v.Visibility == global::System.Windows.Visibility.Visible)
					{
						num = (short)1986265094;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 5:
					num = (short)1171914756;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					num = (short)1195442176;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_10B;
				}
				IL_44:
				if (v != null)
				{
					num = (short)160694277;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return false;
				IL_134:
				num = (short)511574016;
				short num4 = num;
				num = (short)1776287745;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10B:
			IL_1B6:
			return v.IsEnabled;
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000675 RID: 1653 RVA: 0x00087C20 File Offset: 0x00085E20
		protected override int VisualChildrenCount
		{
			get
			{
				short num = (short)1438777345;
				if (num != 0)
				{
				}
				num = (short)207594910;
				short num2 = num;
				num = (short)175547806;
				switch (num2 == num)
				{
				}
				num = (short)1453588480;
				if (num != 0)
				{
				}
				num = (short)1434583040;
				short num3 = num;
				return this.Items.Count;
			}
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x00087CD4 File Offset: 0x00085ED4
		protected override global::System.Windows.Media.Visual GetVisualChild(int index)
		{
			short num = (short)625999873;
			if (num != 0)
			{
			}
			num = (short)1657011169;
			short num2 = num;
			num = (short)740228065;
			switch (num2 == num)
			{
			}
			num = (short)804651008;
			if (num != 0)
			{
			}
			num = (short)591659008;
			short num3 = num;
			return this.Items[index];
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000677 RID: 1655 RVA: 0x00087D8C File Offset: 0x00085F8C
		protected override global::System.Collections.IEnumerator LogicalChildren
		{
			get
			{
				short num = (short)815708887;
				short num2 = num;
				num = (short)68598487;
				switch (num2 == num)
				{
				}
				num = (short)1979842560;
				if (num != 0)
				{
				}
				num = (short)50003969;
				if (num != 0)
				{
				}
				num = (short)382926848;
				short num3 = num;
				return this.Items.GetEnumerator();
			}
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x00087E44 File Offset: 0x00086044
		public virtual bool FocusFirstInput()
		{
			short num = (short)1788411904;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::System.Collections.IEnumerator enumerator = this.Items.GetEnumerator();
				bool result;
				try
				{
					num = (short)1205731340;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1046478853;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)enumerator.Current;
							num = (short)1637482510;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							num = (short)1594032143;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							num = (short)237764612;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							num = (short)1468530696;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							global::System.Windows.UIElement uielement;
							if (uielement.Focus())
							{
								num = (short)283115531;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
							num = (short)1920729104;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							result = true;
							num = (short)209190921;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
						{
							global::System.Windows.UIElement uielement;
							if (uielement.Visibility == global::System.Windows.Visibility.Visible)
							{
								num = (short)1413677059;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 8:
						{
							global::System.Windows.UIElement uielement;
							if (uielement.Focus())
							{
								num = (short)1377239046;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 9:
							goto IL_E3;
						case 10:
						{
							global::System.Windows.UIElement uielement;
							if (uielement is global::DevComponents.WpfEditors.FreeTextEntryBox)
							{
								num = (short)1031536653;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 11:
							result = true;
							num = (short)1371537425;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							switch (0)
							{
							case 0:
								goto IL_C7;
							}
							continue;
						case 13:
							num = (short)444334087;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
						{
							global::System.Windows.UIElement uielement;
							if (uielement.Visibility == global::System.Windows.Visibility.Visible)
							{
								num = (short)1387003905;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_278;
						}
						case 15:
						{
							global::System.Windows.UIElement uielement;
							if (uielement is global::DevComponents.WpfEditors.Primitives.EditorInputBase)
							{
								num = (short)420741121;
								if (num != 0)
								{
								}
								num = (short)2081685506;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_278;
						}
						case 16:
							goto IL_312;
						case 17:
							goto IL_1E7;
						}
						IL_190:
						num = (short)1699807232;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_C7:
						goto IL_190;
						IL_278:
						num = (short)2133917706;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_E3:
					IL_1E7:
					return result;
					IL_312:
					goto IL_2C;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_334;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_321:
						switch (num2)
						{
						case 0:
							goto IL_3D9;
						case 1:
							if (disposable != null)
							{
								num = (short)1697185794;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3DB;
						case 2:
							goto IL_3B9;
						}
						goto IL_334;
					}
					IL_3B9:
					disposable.Dispose();
					goto IL_3C1;
					IL_3D9:
					IL_3DB:
					goto EndFinally_11;
					IL_334:
					num = (short)239099382;
					short num3 = num;
					num = (short)339369462;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_3C1:
						num = (short)105054208;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_321;
					default:
						num = (short)585957376;
						if (num != 0)
						{
						}
						disposable = (enumerator as global::System.IDisposable);
						num = (short)298582017;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_321;
					}
					EndFinally_11:;
				}
				return result;
				IL_2C:
				num = (short)1271136256;
				short num4 = num;
				return false;
			}
			}
		}

		// Token: 0x040002C3 RID: 707
		public static readonly global::System.Windows.DependencyProperty HorizontalItemSpacingProperty;

		// Token: 0x040002C4 RID: 708
		public static readonly global::System.Windows.DependencyProperty VerticalContentAlignmentProperty;

		// Token: 0x040002C5 RID: 709
		public static readonly global::System.Windows.DependencyProperty HorizonalContentAlignmentProperty;

		// Token: 0x040002C6 RID: 710
		private global::System.Windows.Controls.UIElementCollection a;
	}
}
