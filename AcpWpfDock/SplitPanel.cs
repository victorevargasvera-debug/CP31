using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using System.Windows.Media;
using DevComponents.WpfDock.Converters;
using DevComponents.WpfDock.Primitives;

namespace DevComponents.WpfDock
{
	// Token: 0x0200003C RID: 60
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.Markup.ContentProperty("Children")]
	[global::System.Windows.Localizability(global::System.Windows.LocalizationCategory.Ignore)]
	public class SplitPanel : global::System.Windows.FrameworkElement
	{
		// Token: 0x060002A2 RID: 674 RVA: 0x000449D4 File Offset: 0x00042BD4
		static SplitPanel()
		{
			int a_ = 10;
			short num = (short)642646017;
			if (num != 0)
			{
			}
			num = (short)1824088192;
			short num2 = num;
			num = (short)1814847616;
			switch (num2 == num)
			{
			}
			num = (short)1968373760;
			if (num != 0)
			{
			}
			num = (short)408289280;
			short num3 = num;
			global::DevComponents.WpfDock.SplitPanel.RelativeSizeProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("鯈껊ꇌ껎ꗐ뫒ꏔ닖諘닚Ƛ뫞", a_), typeof(global::System.Windows.Size), typeof(global::DevComponents.WpfDock.SplitPanel), new global::System.Windows.PropertyMetadata(new global::System.Windows.Size(100.0, 100.0), new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfDock.SplitPanel.a)));
			global::DevComponents.WpfDock.SplitPanel.OrientationProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("蛈맊꓌꫎뿐꟒듔ꏖ냘듚돜", a_), typeof(global::System.Windows.Controls.Orientation), typeof(global::DevComponents.WpfDock.SplitPanel), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Controls.Orientation.Vertical, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::DevComponents.WpfDock.SplitPanel.BackgroundProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("诈꫊껌꓎뛐ꇒ뫔ꋖ럘뿚", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfDock.SplitPanel), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.SubPropertiesDoNotAffectRender));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::DevComponents.WpfDock.SplitPanel), global::DevComponents.WpfDock.DockSite.DockChangedEvent, new global::System.Windows.RoutedEventHandler(global::DevComponents.WpfDock.SplitPanel.a));
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00044B74 File Offset: 0x00042D74
		public SplitPanel()
		{
			this.e = global::System.Guid.NewGuid().ToString();
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00044BC4 File Offset: 0x00042DC4
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			short num = (short)1673466981;
			short num2 = num;
			num = (short)1128404069;
			switch (num2 == num)
			{
			}
			num = (short)1292763137;
			if (num != 0)
			{
			}
			num = (short)651821056;
			if (num != 0)
			{
			}
			num = (short)604897280;
			short num3 = num;
			return this.a(availableSize, false);
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x00044C74 File Offset: 0x00042E74
		protected virtual bool IsDocument
		{
			get
			{
				short num = (short)178694607;
				short num2 = num;
				num = (short)463579599;
				switch (num2 == num)
				{
				}
				num = (short)499187713;
				if (num != 0)
				{
				}
				num = (short)973864960;
				if (num != 0)
				{
				}
				num = (short)1952907264;
				short num3 = num;
				return global::DevComponents.WpfDock.DockSite.GetIsDocument(this);
			}
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00044D24 File Offset: 0x00042F24
		private double f()
		{
			short num = (short)1658650624;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::System.Windows.Size size;
				global::System.Collections.Generic.IEnumerator<global::System.Windows.UIElement> enumerator;
				switch (0)
				{
				case 0:
					break;
				default:
				{
					for (;;)
					{
						IL_28:
						switch (num2)
						{
						case 0:
							try
							{
								num = (short)1922367490;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_1F5;
									case 1:
									{
										global::System.Windows.UIElement uielement;
										global::System.Windows.Size relativeSize = global::DevComponents.WpfDock.SplitPanel.GetRelativeSize(uielement);
										size.Width += relativeSize.Width;
										size.Height += relativeSize.Height;
										num = (short)552992773;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
										switch (0)
										{
										case 0:
											goto IL_113;
										}
										continue;
									case 3:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)1969618950;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Windows.UIElement uielement = enumerator.Current;
										num = (short)849936388;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
									{
										global::System.Windows.UIElement uielement;
										if (uielement.Visibility == global::System.Windows.Visibility.Visible)
										{
											num = (short)2132344833;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 6:
										num = (short)1330839552;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_152:
									num = (short)38338563;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_113:
									goto IL_152;
								}
								IL_1F5:
								goto IL_66;
							}
							finally
							{
								num = (short)317587456;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_22D;
										}
										continue;
									case 1:
										enumerator.Dispose();
										num = (short)1590493186;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_265;
									}
									IL_22D:
									if (enumerator == null)
									{
										break;
									}
									num = (short)1029373953;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_265:;
							}
							goto IL_268;
							IL_66:
							num = (short)980746241;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (this.Orientation == global::System.Windows.Controls.Orientation.Horizontal)
							{
								num = (short)1952972800;
								short num3 = num;
								num = (short)1377697794;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2E4;
						case 2:
							goto IL_CA;
						}
						goto IL_3B;
					}
					IL_CA:
					IL_268:
					num = (short)1133618138;
					short num4 = num;
					num = (short)1029022682;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_4F;
					default:
						num = (short)1281425409;
						if (num != 0)
						{
						}
						num = (short)6881280;
						if (num != 0)
						{
						}
						return size.Width;
					}
					IL_2E4:
					return size.Height;
				}
				}
				IL_3B:
				global::System.Collections.ObjectModel.Collection<global::System.Windows.UIElement> internalChildren = this.InternalChildren;
				size = default(global::System.Windows.Size);
				enumerator = internalChildren.GetEnumerator();
				IL_4F:
				num = (short)1552023552;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00045038 File Offset: 0x00043238
		private int e()
		{
			short num = (short)1645019136;
			short num2 = num;
			num = (short)1519583233;
			if (num != 0)
			{
			}
			num = (short)1265412072;
			short num3 = num;
			num = (short)1809688552;
			switch (num3 == num)
			{
			}
			num = (short)1691942912;
			if (num != 0)
			{
			}
			return 4;
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x000450E4 File Offset: 0x000432E4
		private double d()
		{
			short num = (short)1159725056;
			short num2 = num;
			num = (short)1386277036;
			short num3 = num;
			num = (short)1456269484;
			switch (num3 == num)
			{
			}
			num = (short)287965185;
			if (num != 0)
			{
			}
			num = (short)662634496;
			if (num != 0)
			{
			}
			return 4.0;
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00045198 File Offset: 0x00043398
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			short num = (short)468058112;
			short num2 = num;
			num = (short)2093613057;
			if (num != 0)
			{
			}
			num = (short)706989436;
			short num3 = num;
			num = (short)2009714044;
			switch (num3 == num)
			{
			}
			num = (short)1442119680;
			if (num != 0)
			{
			}
			return this.a(finalSize, true);
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0004524C File Offset: 0x0004344C
		private global::System.Windows.Size a(global::System.Windows.Size A_0, bool A_1)
		{
			short num = (short)159514624;
			switch (num)
			{
			default:
			{
				num = (short)2103574541;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.Windows.Size result;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_C67;
					case 1:
						result.Height = A_0.Height;
						num = (short)1021181969;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_DB;
					case 3:
					{
						global::System.Windows.Controls.Orientation orientation;
						if (orientation == global::System.Windows.Controls.Orientation.Horizontal)
						{
							num = (short)1848573958;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result.Height = A_0.Height;
						num = (short)2098003984;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						if (base.Parent is global::DevComponents.WpfDock.Primitives.b)
						{
							num = (short)1257635841;
							if (num != 0)
							{
							}
							num = (short)1720516609;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result.Height = global::DevComponents.WpfDock.DockSite.GetDockSize(this);
						num = (short)980090894;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						global::System.Collections.ObjectModel.Collection<global::System.Windows.UIElement> internalChildren = this.InternalChildren;
						global::System.Windows.Controls.Orientation orientation = this.Orientation;
						global::System.Windows.Size size = new global::System.Windows.Size(this.d(), (double)this.e());
						double num3 = 0.0;
						global::System.Windows.Controls.Dock dock = global::DevComponents.WpfDock.DockSite.GetDock(this);
						global::DevComponents.WpfDock.DockSplitter dockSplitter = null;
						bool isDocument = this.IsDocument;
						double num4 = this.f();
						global::System.Windows.Size size2 = A_0;
						if (!isDocument && this.CanResizeSplitPanel && this.b.Count > 0)
						{
							if (orientation == global::System.Windows.Controls.Orientation.Horizontal)
							{
								size2.Height -= (double)this.e();
							}
							else
							{
								size2.Width -= this.d();
							}
							dockSplitter = this.c[0];
							global::System.Windows.Rect finalRect = new global::System.Windows.Rect(A_0.Width - size.Width, 0.0, size.Width, A_0.Height);
							if (dock == global::System.Windows.Controls.Dock.Right)
							{
								finalRect = new global::System.Windows.Rect(0.0, 0.0, size.Width, A_0.Height);
							}
							else if (dock == global::System.Windows.Controls.Dock.Top)
							{
								finalRect = new global::System.Windows.Rect(0.0, A_0.Height - size.Height, A_0.Width, size.Height);
							}
							else if (dock == global::System.Windows.Controls.Dock.Bottom)
							{
								finalRect = new global::System.Windows.Rect(0.0, 0.0, A_0.Width, size.Height);
							}
							if (A_1)
							{
								dockSplitter.Arrange(finalRect);
							}
							else
							{
								dockSplitter.Measure(finalRect.Size);
							}
						}
						if (orientation == global::System.Windows.Controls.Orientation.Horizontal)
						{
							size2.Width = global::System.Math.Max(20.0, size2.Width - global::System.Math.Ceiling((double)global::System.Math.Max(0, this.b.Count - (isDocument ? 0 : 1)) * size.Width));
						}
						else
						{
							size2.Height = global::System.Math.Max(20.0, size2.Height - global::System.Math.Ceiling((double)global::System.Math.Max(0, this.b.Count - (isDocument ? 0 : 1)) * size.Height));
						}
						double num5 = (orientation == global::System.Windows.Controls.Orientation.Horizontal) ? size.Width : size.Height;
						double num6 = (orientation == global::System.Windows.Controls.Orientation.Horizontal) ? size2.Width : size2.Height;
						global::System.Collections.Generic.IEnumerator<global::System.Windows.UIElement> enumerator = internalChildren.GetEnumerator();
						num = (short)104529935;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						result.Width = A_0.Width;
						num = (short)630784004;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_AB5;
					case 8:
						goto IL_C8F;
					case 9:
					{
						if (A_1)
						{
							num = (short)631046151;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = default(global::System.Windows.Size);
						global::System.Windows.Controls.Orientation orientation = this.Orientation;
						num = (short)2012741635;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						return A_0;
					case 11:
						result.Width = A_0.Width;
						num = (short)51445760;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)2053111810;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						switch (0)
						{
						case 0:
							goto IL_8B;
						}
						continue;
					case 14:
						goto IL_BEE;
					case 15:
					{
						num = (short)1544122782;
						short num7 = num;
						num = (short)210071966;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_DB;
						default:
							num = (short)966656000;
							if (num != 0)
							{
							}
							try
							{
								num = (short)1093664774;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::DevComponents.WpfDock.DockSplitter dockSplitter;
									global::System.Windows.UIElement uielement;
									switch (num2)
									{
									case 0:
									{
										global::System.Windows.Size relativeSize = global::DevComponents.WpfDock.SplitPanel.GetRelativeSize(uielement);
										global::System.Windows.Size size2;
										global::System.Windows.Size size3 = size2;
										num = (short)2054356999;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
									{
										if (A_1)
										{
											num = (short)1766588435;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Windows.Rect finalRect2;
										dockSplitter.Measure(finalRect2.Size);
										num = (short)875233305;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
										goto IL_758;
									case 3:
										goto IL_758;
									case 4:
									{
										global::System.Windows.Size size;
										double num3;
										global::System.Windows.Controls.Dock dock;
										global::System.Windows.Size size3;
										global::System.Windows.Rect finalRect3 = new global::System.Windows.Rect(num3, (dock == global::System.Windows.Controls.Dock.Bottom) ? size.Height : 0.0, size3.Width, size3.Height);
										num = (short)49086469;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 5:
										goto IL_6D6;
									case 6:
										switch (0)
										{
										case 0:
											goto IL_4B1;
										}
										continue;
									case 7:
									{
										global::System.Windows.Controls.Orientation orientation;
										if (orientation == global::System.Windows.Controls.Orientation.Horizontal)
										{
											num = (short)1461190686;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										double num4;
										global::System.Windows.Size size2;
										double num6;
										global::System.Windows.Size relativeSize;
										global::System.Windows.Size size3;
										size3.Height = global::System.Math.Min(num6, global::System.Math.Max(20.0, global::System.Math.Ceiling(size2.Height * (relativeSize.Height / num4))));
										num = (short)1996292117;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 8:
										goto IL_6D6;
									case 9:
									{
										double num5;
										global::System.Windows.Rect finalRect3;
										global::System.Windows.Rect finalRect2 = new global::System.Windows.Rect(finalRect3.Right, finalRect3.Y, num5, finalRect3.Height);
										num = (short)1665531917;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 11:
									{
										if (A_1)
										{
											num = (short)1331298333;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Windows.Rect finalRect3;
										uielement.Measure(finalRect3.Size);
										num = (short)1349844994;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 12:
									{
										global::System.Windows.Controls.Orientation orientation;
										if (orientation == global::System.Windows.Controls.Orientation.Horizontal)
										{
											num = (short)1497432078;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										double num3;
										double num5;
										global::System.Windows.Size size3;
										num3 += size3.Height + num5;
										double num6;
										num6 -= size3.Height;
										num = (short)376242210;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 13:
										goto IL_82F;
									case 14:
									{
										double num3;
										double num5;
										global::System.Windows.Size size3;
										num3 += size3.Width + num5;
										double num6;
										num6 -= size3.Width;
										num = (short)512032800;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 15:
									{
										double num6 = 20.0;
										num = (short)409468938;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 16:
									{
										global::System.Windows.Controls.Orientation orientation;
										if (orientation == global::System.Windows.Controls.Orientation.Horizontal)
										{
											num = (short)1103757340;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)276168737;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 17:
									{
										global::System.Collections.Generic.IEnumerator<global::System.Windows.UIElement> enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)1666056214;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										uielement = enumerator.Current;
										num = (short)780533791;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 18:
										goto IL_5DC;
									case 19:
									{
										global::System.Windows.Rect finalRect2;
										dockSplitter.Arrange(finalRect2);
										num = (short)1873805347;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 20:
									{
										global::System.Windows.Controls.Orientation orientation;
										if (orientation == global::System.Windows.Controls.Orientation.Horizontal)
										{
											num = (short)1748172809;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_82F;
									}
									case 21:
										goto IL_5DC;
									case 22:
										num = (short)914948120;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 23:
									{
										double num5;
										global::System.Windows.Rect finalRect3;
										global::System.Windows.Rect finalRect2 = new global::System.Windows.Rect(finalRect3.X, finalRect3.Bottom, finalRect3.Width, num5);
										num = (short)1075642388;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 24:
										goto IL_A0F;
									case 25:
										goto IL_8B1;
									case 26:
									{
										double num6;
										if (num6 < 20.0)
										{
											num = (short)1470496783;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 27:
										if (dockSplitter != null)
										{
											num = (short)1147338775;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_8B1;
									case 28:
										num = (short)954269700;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 29:
									{
										global::System.Windows.Rect finalRect3;
										uielement.Arrange(finalRect3);
										num = (short)220397571;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 30:
									{
										double num4;
										global::System.Windows.Size size2;
										double num6;
										global::System.Windows.Size relativeSize;
										global::System.Windows.Size size3;
										size3.Width = global::System.Math.Min(num6, global::System.Math.Max(20.0, global::System.Math.Ceiling(size2.Width * (relativeSize.Width / num4))));
										num = (short)1618804754;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 31:
										if (uielement.Visibility != global::System.Windows.Visibility.Collapsed)
										{
											num = (short)1434386432;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									case 32:
										goto IL_950;
									case 33:
									{
										global::System.Windows.Size size;
										double num3;
										global::System.Windows.Controls.Dock dock;
										global::System.Windows.Size size3;
										global::System.Windows.Rect finalRect3 = new global::System.Windows.Rect((dock == global::System.Windows.Controls.Dock.Right) ? size.Width : 0.0, num3, size3.Width, size3.Height);
										num = (short)1152516104;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 34:
										goto IL_950;
									case 35:
										goto IL_8B1;
									}
									goto IL_4B1;
									IL_5DC:
									num = (short)884670480;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_6D6:
									num = (short)829751307;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_758:
									this.b.TryGetValue(uielement, out dockSplitter);
									num = (short)1299316763;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_82F:
									num = (short)1092943873;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_8B1:
									dockSplitter = null;
									num = (short)1798242316;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_950:
									num = (short)1466302490;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_9B8:
									num = (short)1085603857;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_4B1:
									goto IL_9B8;
								}
								IL_A0F:;
							}
							finally
							{
								num = (short)1208614912;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::System.Windows.UIElement> enumerator;
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_A45;
										}
										continue;
									case 1:
										enumerator.Dispose();
										num = (short)1506738178;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_A7E;
									}
									IL_A45:
									if (enumerator == null)
									{
										break;
									}
									num = (short)1905197057;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_A7E:;
							}
							num = (short)1715666953;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 16:
						if (base.Parent is global::DevComponents.WpfDock.Primitives.b)
						{
							num = (short)1940848651;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result.Width = global::DevComponents.WpfDock.DockSite.GetDockSize(this);
						num = (short)1550581768;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_BC4;
					}
					IL_8B:
					if (A_0.Width >= this.d() * (double)(this.b.Count + 1))
					{
						num = (short)399179788;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_DB:
					if (A_0.Height < (double)(this.e() * (this.b.Count + 1)))
					{
						num = (short)410451978;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)448790533;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				return A_0;
				IL_AB5:
				num = (short)942080000;
				short num8 = num;
				return A_0;
				IL_BC4:
				IL_BEE:
				IL_C67:
				IL_C8F:
				global::DevComponents.WpfDock.i.a(ref result);
				return result;
			}
			}
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00045F10 File Offset: 0x00044110
		[global::System.Windows.AttachedPropertyBrowsableForChildren]
		public static global::System.Windows.Size GetRelativeSize(global::System.Windows.UIElement element)
		{
			int a_ = 10;
			if (element != null)
			{
				short num = (short)495552506;
				short num2 = num;
				num = (short)1253672954;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)76218369;
					if (num != 0)
					{
					}
					num = (short)553648128;
					short num3 = num;
					num = (short)1880096768;
					if (num != 0)
					{
					}
					return (global::System.Windows.Size)element.GetValue(global::DevComponents.WpfDock.SplitPanel.RelativeSizeProperty);
				}
				}
			}
			throw new global::System.ArgumentNullException(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("곈ꟊ꣌ꋎ듐뷒ꇔ", a_));
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00045FEC File Offset: 0x000441EC
		public static void SetRelativeSize(global::System.Windows.UIElement element, global::System.Windows.Size d)
		{
			int a_ = 12;
			if (element != null)
			{
				short num = (short)1575452061;
				short num2 = num;
				num = (short)1827437981;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1885601792;
					if (num != 0)
					{
					}
					num = (short)1732902912;
					short num3 = num;
					num = (short)1747714049;
					if (num != 0)
					{
					}
					element.SetValue(global::DevComponents.WpfDock.SplitPanel.RelativeSizeProperty, d);
					return;
				}
				}
			}
			throw new global::System.ArgumentNullException(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("껊ꇌ꫎볐뛒믔ꏖ", a_));
		}

		// Token: 0x060002AD RID: 685 RVA: 0x000460C8 File Offset: 0x000442C8
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::System.Windows.UIElement uielement;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					uielement.InvalidateMeasure();
					global::System.Windows.FrameworkElement frameworkElement = global::System.Windows.Media.VisualTreeHelper.GetParent(uielement) as global::System.Windows.FrameworkElement;
					num2 = (short)1988362241;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
				{
					global::System.Windows.FrameworkElement frameworkElement;
					if (frameworkElement != null)
					{
						goto IL_146;
					}
					return;
				}
				case 2:
				{
					global::System.Windows.FrameworkElement frameworkElement;
					frameworkElement.InvalidateMeasure();
					num2 = (short)1105920004;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
				{
					num2 = (short)380577484;
					short num3 = num2;
					num2 = (short)699737804;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_146;
					default:
						num2 = (short)1655701504;
						if (num2 != 0)
						{
						}
						if (uielement != null)
						{
							num2 = (short)546635776;
							short num4 = num2;
							num2 = (short)1303052288;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				case 4:
					goto IL_F1;
				}
				goto IL_24;
				IL_146:
				num2 = (short)802816002;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_F1:
			num2 = (short)202899457;
			if (num2 != 0)
			{
			}
			return;
			IL_24:
			uielement = (A_0 as global::System.Windows.UIElement);
			num2 = (short)1157824515;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00046238 File Offset: 0x00044438
		private static void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1777991681;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			int num2;
			global::DevComponents.WpfDock.SplitPanel splitPanel;
			for (;;)
			{
				IL_32:
				switch (num2)
				{
				case 0:
					return;
				case 1:
					if (splitPanel != null)
					{
						num = (short)1381695490;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
				{
					num = (short)636616704;
					short num3 = num;
					splitPanel.c();
					num = (short)436144927;
					short num4 = num;
					num = (short)886704927;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)1676673024;
						if (num != 0)
						{
						}
						num = (short)1904476160;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				goto IL_44;
			}
			return;
			IL_44:
			splitPanel = (A_1.Source as global::DevComponents.WpfDock.SplitPanel);
			num = (short)1985675265;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_32;
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060002AF RID: 687 RVA: 0x0004635C File Offset: 0x0004455C
		// (set) Token: 0x060002B0 RID: 688 RVA: 0x00046418 File Offset: 0x00044618
		public global::System.Windows.Controls.Orientation Orientation
		{
			get
			{
				short num = (short)149770249;
				short num2 = num;
				num = (short)1934381065;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1722220544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)339607552;
				if (num != 0)
				{
				}
				num = (short)39518209;
				if (num != 0)
				{
				}
				return (global::System.Windows.Controls.Orientation)base.GetValue(global::DevComponents.WpfDock.SplitPanel.OrientationProperty);
			}
			set
			{
				short num = (short)1790273554;
				short num2 = num;
				num = (short)417425426;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1288044544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1917386752;
				if (num != 0)
				{
				}
				num = (short)112656385;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfDock.SplitPanel.OrientationProperty, value);
			}
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x000464D4 File Offset: 0x000446D4
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)1170276353;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)478281729;
					if (num != 0)
					{
					}
					goto IL_9A;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 2:
					this.c();
					num = (short)1612120064;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_31:
				if (e.Property == global::DevComponents.WpfDock.DockSite.IsDocumentProperty)
				{
					num = (short)1608056834;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_9A:
				num = (short)1960245294;
				short num3 = num;
				num = (short)1834612782;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_31;
				default:
					goto IL_CF;
				}
			}
			IL_CF:
			num = (short)144048128;
			if (num != 0)
			{
			}
			num = (short)353959936;
			short num4 = num;
			base.OnPropertyChanged(e);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x000465F4 File Offset: 0x000447F4
		private void c()
		{
			short num = (short)1550450688;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_86;
				}
				global::System.Collections.Generic.List<global::DevComponents.WpfDock.DockSplitter>.Enumerator enumerator2;
				for (;;)
				{
					IL_27:
					global::System.Windows.Controls.Dock dock;
					global::System.Windows.Controls.Orientation orientation;
					global::DevComponents.WpfDock.DockSplitter dockSplitter;
					global::System.Collections.Generic.IEnumerator<global::System.Windows.UIElement> enumerator;
					global::System.Windows.UIElement uielement2;
					global::System.Windows.Controls.Orientation orientation2;
					switch (num2)
					{
					case 0:
						if (this.Orientation != global::System.Windows.Controls.Orientation.Horizontal)
						{
							num = (short)1298464777;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2022047762;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_7EF;
					case 2:
						goto IL_D0;
					case 3:
						goto IL_7CB;
					case 4:
						goto IL_D0;
					case 5:
						if (dock != global::System.Windows.Controls.Dock.Left)
						{
							num = (short)327090197;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7CB;
					case 6:
						orientation = global::System.Windows.Controls.Orientation.Horizontal;
						goto IL_1CC;
					case 7:
						num = (short)113704975;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						dockSplitter = new global::DevComponents.WpfDock.DockSplitter();
						dockSplitter.Focusable = false;
						dockSplitter.LeftControl = this;
						num = (short)362741765;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_7AB;
					case 10:
						try
						{
							num = (short)1925644294;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_738;
								case 1:
								{
									global::System.Windows.UIElement uielement;
									if (uielement.Visibility == global::System.Windows.Visibility.Visible)
									{
										num = (short)2144403461;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									num = (short)645464064;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)301203458;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Windows.UIElement uielement = enumerator.Current;
									num = (short)1051721729;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									if (uielement2 == null)
									{
										num = (short)1270022152;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									dockSplitter = new global::DevComponents.WpfDock.DockSplitter();
									dockSplitter.Focusable = false;
									dockSplitter.LeftControl = uielement2;
									global::System.Windows.UIElement uielement;
									dockSplitter.RightControl = uielement;
									dockSplitter.Orientation = orientation2;
									this.b.Add(uielement2, dockSplitter);
									this.c.Add(dockSplitter);
									uielement2 = uielement;
									num = (short)1868627977;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									num = (short)1499791364;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_5E7;
									}
									continue;
								case 8:
								{
									global::System.Windows.UIElement uielement;
									uielement2 = uielement;
									num = (short)2075328519;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_6DE:
								num = (short)269221891;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5E7:
								goto IL_6DE;
							}
							IL_738:
							goto IL_348;
						}
						finally
						{
							num = (short)1797259265;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_7A8;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_770;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)971374592;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_770:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2075459586;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_7A8:;
						}
						goto IL_7AB;
						IL_348:
						enumerator2 = this.c.GetEnumerator();
						num = (short)507183116;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						try
						{
							num = (short)717225987;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)1879179268;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::DevComponents.WpfDock.DockSplitter dockSplitter2 = enumerator2.Current;
									base.RemoveVisualChild(dockSplitter2);
									base.RemoveLogicalChild(dockSplitter2);
									dockSplitter2.LeftControl = null;
									dockSplitter2.RightControl = null;
									num = (short)414318593;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_491;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_3FC;
									}
									continue;
								case 4:
									num = (short)1835991042;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_3FE:
								num = (short)622788608;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3FC:
								goto IL_3FE;
							}
							IL_491:
							goto IL_149;
						}
						finally
						{
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto IL_4A4;
						IL_149:
						this.b.Clear();
						this.c.Clear();
						num = (short)1143734292;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						try
						{
							num = (short)937558019;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_2B9;
								case 1:
									num = (short)1740242946;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_30F;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_237;
									}
									continue;
								case 4:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)2037383169;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::DevComponents.WpfDock.DockSplitter child = enumerator2.Current;
									base.AddVisualChild(child);
									base.AddLogicalChild(child);
									num = (short)1242365952;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								goto IL_237;
								IL_2B9:
								num = (short)511836164;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_237:
								num = (short)1951984770;
								short num3 = num;
								num = (short)202435714;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_30F;
								default:
									num = (short)1393426432;
									if (num != 0)
									{
									}
									goto IL_2B9;
								}
							}
							IL_30F:
							goto IL_830;
						}
						finally
						{
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto IL_322;
					case 13:
						goto IL_4A4;
					case 14:
						if (this.Children.Count == 1)
						{
							num = (short)273350663;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4E7;
					case 15:
						if (this.IsDocument)
						{
							num = (short)1885667344;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4E7;
					case 16:
						return;
					case 17:
						if (this.CanResizeSplitPanel)
						{
							num = (short)1039269896;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7EF;
					case 18:
						orientation = global::System.Windows.Controls.Orientation.Vertical;
						goto IL_1CC;
					case 19:
						if (dock == global::System.Windows.Controls.Dock.Right)
						{
							num = (short)101318657;
							if (num != 0)
							{
							}
							num = (short)115998723;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_322;
					case 20:
						if (this.Children.Count != 0)
						{
							num = (short)1850277888;
							short num4 = num;
							num = (short)727646221;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 21:
						num = (short)1999175699;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_86;
					IL_D0:
					this.b.Add(this, dockSplitter);
					this.c.Add(dockSplitter);
					dockSplitter = null;
					num = (short)1510998017;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1CC:
					orientation2 = orientation;
					uielement2 = null;
					enumerator = this.Children.GetEnumerator();
					num = (short)595722250;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_322:
					dockSplitter.Orientation = global::System.Windows.Controls.Orientation.Horizontal;
					num = (short)1991835652;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4A4:
					num = (short)148897806;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4E7:
					dock = global::DevComponents.WpfDock.DockSite.GetDock(this);
					dockSplitter = null;
					num = (short)589299729;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7AB:
					num = (short)1049493510;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7CB:
					dockSplitter.Orientation = global::System.Windows.Controls.Orientation.Vertical;
					num = (short)705429506;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7EF:
					num = (short)356843520;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_830:
				this.OnSplittersRecreated(new global::System.EventArgs());
				return;
				IL_86:
				enumerator2 = this.c.GetEnumerator();
				num = (short)2138636299;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x060002B3 RID: 691 RVA: 0x00046E88 File Offset: 0x00045088
		// (remove) Token: 0x060002B4 RID: 692 RVA: 0x00046FB8 File Offset: 0x000451B8
		public event global::System.EventHandler SplittersUpdating
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::System.EventHandler eventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::System.EventHandler eventHandler2;
					switch (num)
					{
					case 0:
						return;
					case 1:
						goto IL_39;
					case 2:
					{
						if (eventHandler != eventHandler2)
						{
							goto IL_39;
						}
						num2 = (short)912457728;
						short num3 = num2;
						num2 = (short)1991707748;
						short num4 = num2;
						num2 = (short)2047085668;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num2 = (short)1289551873;
							if (num2 != 0)
							{
							}
							num2 = (short)1438318592;
							if (num2 != 0)
							{
							}
							num2 = (short)393543680;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_1C;
					IL_39:
					eventHandler2 = eventHandler;
					global::System.EventHandler value2 = (global::System.EventHandler)global::System.Delegate.Combine(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler>(ref this.f, value2, eventHandler2);
					num2 = (short)179044354;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_1C:
				eventHandler = this.f;
				num2 = (short)1853030401;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::System.EventHandler eventHandler;
				for (;;)
				{
					IL_0A:
					global::System.EventHandler eventHandler2;
					switch (num)
					{
					case 0:
						return;
					case 1:
						goto IL_39;
					case 2:
					{
						num2 = (short)1520762881;
						if (num2 != 0)
						{
						}
						num2 = (short)1612185600;
						short num3 = num2;
						if (eventHandler != eventHandler2)
						{
							goto IL_39;
						}
						num2 = (short)974140492;
						short num4 = num2;
						num2 = (short)60634188;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num2 = (short)64552960;
							if (num2 != 0)
							{
							}
							num2 = (short)615972864;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_1C;
					IL_39:
					eventHandler2 = eventHandler;
					global::System.EventHandler value2 = (global::System.EventHandler)global::System.Delegate.Remove(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler>(ref this.f, value2, eventHandler2);
					num2 = (short)601489410;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_1C:
				eventHandler = this.f;
				num2 = (short)1476198401;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x000470EC File Offset: 0x000452EC
		protected virtual void OnSplittersUpdating(global::System.EventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::System.EventHandler eventHandler;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
					if (eventHandler != null)
					{
						num2 = (short)292552706;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
				{
					eventHandler(this, e);
					num2 = (short)1149347232;
					short num3 = num2;
					num2 = (short)2118690208;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					case 1:
						break;
					default:
					{
						num2 = (short)1214054400;
						short num4 = num2;
						break;
					}
					}
					num2 = (short)1267859457;
					if (num2 != 0)
					{
					}
					num2 = (short)2026176512;
					if (num2 != 0)
					{
					}
					num2 = (short)1794703360;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			eventHandler = this.f;
			num2 = (short)1415446529;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x0004720C File Offset: 0x0004540C
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public global::System.Collections.Generic.List<global::DevComponents.WpfDock.DockSplitter> Splitters
		{
			get
			{
				short num = (short)1451270473;
				short num2 = num;
				num = (short)912105801;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1772093440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1858207745;
				if (num != 0)
				{
				}
				num = (short)404684800;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x060002B7 RID: 695 RVA: 0x000472BC File Offset: 0x000454BC
		// (remove) Token: 0x060002B8 RID: 696 RVA: 0x000473F4 File Offset: 0x000455F4
		public event global::System.EventHandler SplittersRecreated
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::System.EventHandler eventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::System.EventHandler eventHandler2;
					switch (num)
					{
					case 0:
						goto IL_39;
					case 1:
						if (eventHandler == eventHandler2)
						{
							num2 = (short)1913913346;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_39;
					case 2:
						goto IL_102;
					}
					goto IL_1C;
					IL_39:
					eventHandler2 = eventHandler;
					global::System.EventHandler value2 = (global::System.EventHandler)global::System.Delegate.Combine(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler>(ref this.g, value2, eventHandler2);
					num2 = (short)1188633678;
					short num3 = num2;
					num2 = (short)1927617614;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1C;
					default:
					{
						num2 = (short)1483997184;
						if (num2 != 0)
						{
						}
						num2 = (short)1438121984;
						short num4 = num2;
						num2 = (short)1567227905;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
					}
				}
				IL_102:
				num2 = (short)374734849;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				eventHandler = this.g;
				num2 = (short)897056768;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::System.EventHandler eventHandler;
				for (;;)
				{
					IL_0A:
					global::System.EventHandler eventHandler2;
					switch (num)
					{
					case 0:
						goto IL_3B;
					case 1:
						num2 = (short)594018305;
						if (num2 != 0)
						{
						}
						if (eventHandler == eventHandler2)
						{
							num2 = (short)1345388546;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_3B;
					case 2:
						return;
					}
					goto IL_1C;
					IL_3B:
					eventHandler2 = eventHandler;
					global::System.EventHandler value2 = (global::System.EventHandler)global::System.Delegate.Remove(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler>(ref this.g, value2, eventHandler2);
					num2 = (short)1198958283;
					short num3 = num2;
					num2 = (short)1086170827;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1C;
					default:
					{
						num2 = (short)1568014336;
						if (num2 != 0)
						{
						}
						num2 = (short)356843520;
						short num4 = num2;
						num2 = (short)1309409281;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
					}
				}
				return;
				IL_1C:
				eventHandler = this.g;
				num2 = (short)1869021184;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x0004752C File Offset: 0x0004572C
		protected virtual void OnSplittersRecreated(global::System.EventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::System.EventHandler eventHandler;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (eventHandler != null)
					{
						num2 = (short)468975617;
						if (num2 != 0)
						{
						}
						num2 = (short)410517505;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
				{
					num2 = (short)1034657046;
					short num3 = num2;
					num2 = (short)1675795734;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)104333312;
						short num4 = num2;
						num2 = (short)1703542784;
						if (num2 != 0)
						{
						}
						eventHandler(this, e);
						num2 = (short)538705922;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
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
			eventHandler = this.g;
			num2 = (short)39845888;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060002BA RID: 698 RVA: 0x0004764C File Offset: 0x0004584C
		protected override int VisualChildrenCount
		{
			get
			{
				short num = (short)1787465496;
				short num2 = num;
				num = (short)734367512;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1876492288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1373241344;
				if (num != 0)
				{
				}
				num = (short)601554945;
				if (num != 0)
				{
				}
				return this.Children.Count + this.b.Count;
			}
		}

		// Token: 0x060002BB RID: 699 RVA: 0x0004770C File Offset: 0x0004590C
		protected override global::System.Windows.Media.Visual GetVisualChild(int index)
		{
			while (index >= this.Children.Count)
			{
				short num = (short)713097216;
				short num2 = num;
				num = (short)718864385;
				if (num != 0)
				{
				}
				num = (short)676592392;
				short num3 = num;
				num = (short)1621949192;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)549191680;
					if (num != 0)
					{
					}
					return this.c[index - this.Children.Count];
				}
			}
			return this.Children[index];
		}

		// Token: 0x060002BC RID: 700 RVA: 0x000477EC File Offset: 0x000459EC
		protected virtual global::DevComponents.WpfDock.SplitPanelChildrenCollection CreateUIElementCollection()
		{
			short num = (short)1733570249;
			short num2 = num;
			num = (short)1260334793;
			switch (num2 == num)
			{
			default:
			{
				num = (short)963641344;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1331429376;
			if (num != 0)
			{
			}
			num = (short)499646465;
			if (num != 0)
			{
			}
			return new global::DevComponents.WpfDock.SplitPanelChildrenCollection(this);
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060002BD RID: 701 RVA: 0x0004789C File Offset: 0x00045A9C
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
		public global::DevComponents.WpfDock.SplitPanelChildrenCollection Children
		{
			get
			{
				short num = (short)1635858523;
				short num2 = num;
				num = (short)995571803;
				switch (num2 == num)
				{
				default:
				{
					num = (short)674824192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)395575296;
				if (num != 0)
				{
				}
				num = (short)1103626241;
				if (num != 0)
				{
				}
				return this.InternalChildren;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060002BE RID: 702 RVA: 0x00047948 File Offset: 0x00045B48
		protected internal global::DevComponents.WpfDock.SplitPanelChildrenCollection InternalChildren
		{
			get
			{
				short num = (short)47251457;
				if (num != 0)
				{
				}
				num = (short)1880883200;
				short num2 = num;
				num = (short)523567104;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_81;
						}
						continue;
					case 1:
						for (;;)
						{
							num = (short)1394359782;
							short num4 = num;
							num = (short)1233927654;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_D9;
							}
						}
						IL_D9:
						num = (short)79233024;
						if (num != 0)
						{
						}
						this.d = this.CreateUIElementCollection();
						this.d.CollectionChanged += this.a;
						num = (short)32571394;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_128;
					}
					IL_81:
					if (this.d != null)
					{
						break;
					}
					num = (short)1083441153;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_128:
				return this.d;
			}
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00047A88 File Offset: 0x00045C88
		internal void g()
		{
			short num = (short)1497558547;
			short num2 = num;
			num = (short)1502739;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)425590784;
				short num3 = num;
				num = (short)30998529;
				if (num != 0)
				{
				}
				num = (short)683147264;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.IEnumerator<global::System.Windows.UIElement> enumerator = this.Children.GetEnumerator();
				try
				{
					num = (short)1498349570;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1345716227;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Windows.UIElement child = enumerator.Current;
							base.RemoveLogicalChild(child);
							base.RemoveVisualChild(child);
							num = (short)1915813888;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_E0;
							}
							continue;
						case 3:
							num = (short)730726404;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_156;
						}
						IL_10D:
						num = (short)476315649;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_E0:
						goto IL_10D;
					}
					IL_156:;
				}
				finally
				{
					num = (short)637337600;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_188;
							}
							continue;
						case 1:
							enumerator.Dispose();
							num = (short)528416770;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_1BC;
						}
						IL_188:
						if (enumerator == null)
						{
							break;
						}
						num = (short)942014465;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_1BC:;
				}
				break;
			}
			}
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00047C64 File Offset: 0x00045E64
		private void a(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
		{
			short num = (short)1886846976;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4E;
				}
				bool isDocument;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						num = (short)1080229894;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						global::System.Collections.IEnumerator enumerator = A_1.NewItems.GetEnumerator();
						num = (short)1725759492;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (A_1.NewItems != null)
						{
							num = (short)2061107201;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C9;
					case 3:
					{
						num = (short)926154752;
						short num3 = num;
						goto IL_347;
					}
					case 4:
						try
						{
							num = (short)834207746;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
								{
									IL_291:
									global::System.Collections.IEnumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)572719107;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)enumerator.Current;
									base.AddLogicalChild(uielement);
									base.AddVisualChild(uielement);
									global::DevComponents.WpfDock.DockSite.SetIsDocument(uielement, isDocument);
									num = (short)316407808;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1ED;
									}
									continue;
								case 3:
									num = (short)651821060;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_2CF;
								}
								IL_22C:
								num = (short)852965006;
								short num4 = num;
								num = (short)997340814;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_291;
								default:
									num = (short)1747320832;
									if (num != 0)
									{
									}
									num = (short)1930559489;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1ED:
								goto IL_22C;
							}
							IL_2CF:
							goto IL_4C9;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_2F1;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_2DE:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)1214513153;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_346;
								case 1:
									disposable.Dispose();
									num = (short)807010306;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_344;
								}
								goto IL_2F1;
							}
							IL_344:
							IL_346:
							goto EndFinally_14;
							IL_2F1:
							global::System.Collections.IEnumerator enumerator;
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1354301440;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_2DE;
							EndFinally_14:;
						}
						goto Block_5;
					case 5:
						if (A_1.Action != global::System.Collections.Specialized.NotifyCollectionChangedAction.Move)
						{
							num = (short)840499200;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C9;
					case 6:
						num = (short)1047658497;
						if (num != 0)
						{
						}
						if (A_1.OldItems != null)
						{
							num = (short)1529806855;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BB;
					case 7:
					{
						global::System.Collections.IEnumerator enumerator = A_1.OldItems.GetEnumerator();
						num = (short)1131610115;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_4E;
					IL_BB:
					num = (short)1920008194;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_5:
					try
					{
						IL_347:
						num = (short)1452802052;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								if (isDocument)
								{
									num = (short)1168769026;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 1:
								num = (short)569114630;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
							{
								global::System.Windows.UIElement uielement2;
								global::DevComponents.WpfDock.DockSite.SetIsDocument(uielement2, false);
								num = (short)174129157;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
							{
								global::System.Collections.IEnumerator enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)344850433;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Windows.UIElement uielement2 = (global::System.Windows.UIElement)enumerator.Current;
								base.RemoveLogicalChild(uielement2);
								base.RemoveVisualChild(uielement2);
								num = (short)56033280;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								switch (0)
								{
								case 0:
									goto IL_38A;
								}
								continue;
							case 6:
								goto IL_451;
							}
							IL_38C:
							num = (short)1383792643;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_38A:
							goto IL_38C;
						}
						IL_451:
						goto IL_BB;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_473;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_460:
							switch (num2)
							{
							case 0:
								if (disposable != null)
								{
									num = (short)182190081;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_4C8;
							case 1:
								disposable.Dispose();
								num = (short)1458110466;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_4C6;
							}
							goto IL_473;
						}
						IL_4C6:
						IL_4C8:
						break;
						IL_473:
						global::System.Collections.IEnumerator enumerator;
						disposable = (enumerator as global::System.IDisposable);
						num = (short)1366884352;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_460;
					}
					break;
				}
				IL_4C9:
				this.c();
				this.b();
				base.InvalidateMeasure();
				return;
				IL_4E:
				isDocument = global::DevComponents.WpfDock.DockSite.GetIsDocument(this);
				num = (short)354615301;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00048180 File Offset: 0x00046380
		private void b()
		{
			short num = (short)1125842944;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3A;
				}
				global::DevComponents.WpfDock.DockSite dockSite;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerator<global::System.Windows.UIElement> enumerator;
					bool isDocument;
					switch (num2)
					{
					case 0:
						goto IL_57;
					case 1:
					{
						num = (short)1305483594;
						short num3 = num;
						num = (short)334567754;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_57;
						case 1:
							break;
						default:
						{
							num = (short)811401216;
							short num4 = num;
							break;
						}
						}
						num = (short)1915944960;
						if (num != 0)
						{
						}
						goto IL_25D;
					}
					case 2:
						try
						{
							num = (short)39714820;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup;
									if (dockWindowGroup != null)
									{
										num = (short)285343746;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									num = (short)1364459526;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup;
									dockSite.UpdateIsDocument(dockWindowGroup);
									num = (short)1924464645;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1939537921;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Windows.UIElement uielement = enumerator.Current;
									global::DevComponents.WpfDock.DockSite.SetIsDocument(uielement, isDocument);
									global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup = uielement as global::DevComponents.WpfDock.DockWindowGroup;
									num = (short)35717120;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_130;
									}
									continue;
								case 6:
									goto IL_1EE;
								}
								IL_132:
								num = (short)961150979;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_130:
								goto IL_132;
							}
							IL_1EE:
							goto IL_28D;
						}
						finally
						{
							num = (short)336789504;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_225;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)447938562;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_25A;
								}
								IL_225:
								if (enumerator == null)
								{
									break;
								}
								num = (short)779288577;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_25A:;
						}
						goto IL_25D;
					}
					goto IL_3A;
					IL_57:
					if (dockSite != null)
					{
						num = (short)800522241;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_25D:
					isDocument = global::DevComponents.WpfDock.DockSite.GetIsDocument(this);
					enumerator = this.Children.GetEnumerator();
					num = (short)1827602434;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_28D:
				num = (short)1937440769;
				if (num != 0)
				{
				}
				return;
				IL_3A:
				dockSite = this.GetDockSite();
				num = (short)1665990656;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00048460 File Offset: 0x00046660
		public global::DevComponents.WpfDock.DockSite GetDockSite()
		{
			short num = (short)1157413891;
			short num2 = num;
			num = (short)546225155;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1510473728;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)899678209;
			if (num != 0)
			{
			}
			num = (short)1778712576;
			if (num != 0)
			{
			}
			return global::DevComponents.WpfDock.DockSite.a(this);
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x0004850C File Offset: 0x0004670C
		// (set) Token: 0x060002C4 RID: 708 RVA: 0x000485C4 File Offset: 0x000467C4
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Media.Brush Background
		{
			get
			{
				short num = (short)985819447;
				short num2 = num;
				num = (short)347826487;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1185218560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)9371649;
				if (num != 0)
				{
				}
				num = (short)1292566528;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfDock.SplitPanel.BackgroundProperty);
			}
			set
			{
				short num = (short)1497509813;
				short num2 = num;
				num = (short)1323708341;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2071068672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1999306753;
				if (num != 0)
				{
				}
				num = (short)588447744;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfDock.SplitPanel.BackgroundProperty, value);
			}
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0004867C File Offset: 0x0004687C
		protected override void OnRender(global::System.Windows.Media.DrawingContext dc)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::System.Windows.Media.Brush background;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (background != null)
					{
						num2 = (short)2128805889;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
				{
					num2 = (short)211508683;
					short num3 = num2;
					num2 = (short)358702539;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)2069299201;
						if (num2 != 0)
						{
						}
						num2 = (short)142344192;
						short num4 = num2;
						num2 = (short)228851712;
						if (num2 != 0)
						{
						}
						dc.DrawRectangle(background, null, new global::System.Windows.Rect(0.0, 0.0, base.RenderSize.Width, base.RenderSize.Height));
						num2 = (short)647823362;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
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
			background = this.Background;
			num2 = (short)292421632;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x000487D0 File Offset: 0x000469D0
		public global::System.Windows.UIElement GetDockedElementAt(global::System.Windows.Point p)
		{
			short num = (short)1973682176;
			switch (num)
			{
			default:
			{
				global::System.Collections.Generic.IEnumerator<global::System.Windows.UIElement> enumerator = this.InternalChildren.GetEnumerator();
				global::System.Windows.UIElement result;
				try
				{
					num = (short)1188036609;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_2A1;
						case 1:
							num = (short)1704001537;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_DA;
							}
							continue;
						case 2:
						{
							global::System.Windows.UIElement dockedElementAt;
							result = dockedElementAt;
							num = (short)1055260679;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							global::System.Windows.UIElement uielement;
							if (uielement is global::DevComponents.WpfDock.SplitPanel)
							{
								num = (short)881262604;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							result = uielement;
							num = (short)476250120;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1093009414;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Windows.UIElement uielement = enumerator.Current;
							num = (short)546963467;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							num = (short)1522139139;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							num = (short)120651776;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							goto IL_159;
						case 8:
							goto IL_F7;
						case 9:
						{
							global::System.Windows.UIElement dockedElementAt;
							if (dockedElementAt != null)
							{
								num = (short)304939010;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 10:
						{
							global::System.Windows.Rect layoutSlot;
							if (layoutSlot.Contains(p))
							{
								num = (short)747503621;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 11:
						{
							global::System.Windows.UIElement uielement;
							if (uielement.Visibility == global::System.Windows.Visibility.Visible)
							{
								num = (short)927203341;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 12:
						{
							global::System.Windows.UIElement uielement;
							global::System.Windows.Point p2 = uielement.PointFromScreen(base.PointToScreen(p));
							global::System.Windows.UIElement dockedElementAt = ((global::DevComponents.WpfDock.SplitPanel)uielement).GetDockedElementAt(p2);
							num = (short)1855913993;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 13:
						{
							global::System.Windows.UIElement uielement;
							global::System.Windows.Rect layoutSlot = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(uielement as global::System.Windows.FrameworkElement);
							num = (short)1900150794;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_15E:
						num = (short)674693124;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_DA:
						goto IL_15E;
					}
					IL_F7:
					IL_159:
					return result;
					IL_2A1:
					goto IL_2B;
				}
				finally
				{
					for (;;)
					{
						IL_2A6:
						num = (short)1514012674;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_361;
							case 1:
								enumerator.Dispose();
								num = (short)382402560;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_2D8;
								}
								continue;
							}
							IL_2D8:
							if (enumerator == null)
							{
								goto IL_363;
							}
							num = (short)940838698;
							short num3 = num;
							num = (short)242028330;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_2A6;
							default:
								num = (short)1982332928;
								if (num != 0)
								{
								}
								num = (short)2143944705;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
						}
					}
					IL_361:
					IL_363:;
				}
				return result;
				IL_2B:
				num = (short)908066816;
				short num4 = num;
				return null;
			}
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060002C7 RID: 711 RVA: 0x00048B60 File Offset: 0x00046D60
		private bool CanResizeSplitPanel
		{
			get
			{
				short num = (short)1155564300;
				short num2 = num;
				num = (short)2008056588;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_106:
					num = (short)1822687232;
					num3 = (int)((global::System.IntPtr)num);
					break;
				case 1:
					goto IL_5D;
				default:
				{
					num = (short)1412628480;
					short num4 = num;
					goto IL_5D;
				}
				}
				for (;;)
				{
					IL_91:
					switch (num3)
					{
					case 0:
						if (!this.IsDocument)
						{
							num = (short)1525415937;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 1:
						goto IL_13C;
					case 2:
						goto IL_CB;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_A7;
						}
						continue;
					}
					IL_A7:
					if (base.Parent is global::DevComponents.WpfDock.SplitPanel)
					{
						return false;
					}
					num = (short)267911170;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_CB:
				goto IL_106;
				IL_13C:
				num = (short)563740673;
				if (num != 0)
				{
				}
				return !(base.Parent is global::DevComponents.WpfDock.FloatingWindow);
				IL_5D:
				num = (short)2098987008;
				if (num != 0)
				{
				}
				num = (short)1087438851;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_91;
			}
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00048CAC File Offset: 0x00046EAC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void UpdateAutoVisibility()
		{
			short num = (short)289079296;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_58;
					}
					continue;
				case 1:
					goto IL_19B;
				case 2:
					if (base.Parent is global::DevComponents.WpfDock.SplitPanel)
					{
						num = (short)630063110;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_291;
				case 3:
					goto IL_14C;
				case 4:
					base.Visibility = global::System.Windows.Visibility.Collapsed;
					num = (short)1917583365;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_227;
				case 6:
				{
					num = (short)1323106304;
					short num3 = num;
					goto IL_124;
				}
				case 7:
					num = (short)1548877835;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					((global::DevComponents.WpfDock.SplitPanel)base.Parent).UpdateAutoVisibility();
					num = (short)1022885889;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (base.Parent is global::DevComponents.WpfDock.SplitPanel)
					{
						num = (short)949026824;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_291;
				case 10:
					num = (short)1006436353;
					if (num != 0)
					{
					}
					if (base.Visibility == global::System.Windows.Visibility.Collapsed)
					{
						num = (short)501809164;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_291;
				case 11:
					if (base.Visibility == global::System.Windows.Visibility.Visible)
					{
						num = (short)1163722756;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_227;
				case 12:
				{
					num = (short)2075661824;
					short num4 = num;
					num = (short)621090304;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_124;
					default:
						num = (short)624164864;
						if (num != 0)
						{
						}
						base.Visibility = global::System.Windows.Visibility.Visible;
						num = (short)938868745;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_58:
				if (this.VisibleItemsCount == 0)
				{
					num = (short)1785397255;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)252968970;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_124:
				((global::DevComponents.WpfDock.SplitPanel)base.Parent).UpdateAutoVisibility();
				num = (short)194707459;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_227:
				num = (short)863567874;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_14C:
			IL_19B:
			IL_291:
			this.c();
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x00048F50 File Offset: 0x00047150
		[global::System.ComponentModel.Bindable(false)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public int VisibleItemsCount
		{
			get
			{
				int num = 0;
				global::System.Collections.Generic.IEnumerator<global::System.Windows.UIElement> enumerator = this.Children.GetEnumerator();
				short num2;
				try
				{
					num2 = (short)2114715651;
					int num3 = (int)((global::System.IntPtr)num2);
					for (;;)
					{
						switch (num3)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num2 = (short)1624637442;
								num3 = (int)((global::System.IntPtr)num2);
								continue;
							}
							global::System.Windows.UIElement uielement = enumerator.Current;
							num2 = (short)38600710;
							num3 = (int)((global::System.IntPtr)num2);
							continue;
						}
						case 1:
							goto IL_169;
						case 2:
							num2 = (short)75038721;
							num3 = (int)((global::System.IntPtr)num2);
							continue;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_58;
							}
							continue;
						case 4:
							num++;
							num2 = (short)1874722821;
							num3 = (int)((global::System.IntPtr)num2);
							continue;
						case 6:
						{
							global::System.Windows.UIElement uielement;
							if (uielement.Visibility == global::System.Windows.Visibility.Visible)
							{
								num2 = (short)743178248;
								num3 = (int)((global::System.IntPtr)num2);
								continue;
							}
							break;
						}
						case 7:
						{
							num2 = (short)609681409;
							if (num2 != 0)
							{
							}
							global::System.Windows.UIElement uielement;
							if (!(uielement is global::DevComponents.WpfDock.DockSplitter))
							{
								num2 = (short)1307901956;
								num3 = (int)((global::System.IntPtr)num2);
								continue;
							}
							break;
						}
						case 8:
							num2 = (short)902299655;
							num3 = (int)((global::System.IntPtr)num2);
							continue;
						}
						IL_95:
						num2 = (short)457768960;
						num3 = (int)((global::System.IntPtr)num2);
						continue;
						IL_58:
						goto IL_95;
					}
					IL_169:;
				}
				finally
				{
					for (;;)
					{
						IL_16E:
						num2 = (short)1672871938;
						int num3 = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								goto IL_224;
							case 1:
								enumerator.Dispose();
								num2 = (short)477036544;
								num3 = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_19F;
								}
								continue;
							}
							IL_19F:
							if (enumerator == null)
							{
								goto IL_226;
							}
							num2 = (short)736661941;
							short num4 = num2;
							num2 = (short)552702389;
							switch ((num4 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_16E;
							default:
								num2 = (short)918487040;
								if (num2 != 0)
								{
								}
								num2 = (short)396951553;
								num3 = (int)((global::System.IntPtr)num2);
								break;
							}
						}
					}
					IL_224:
					IL_226:;
				}
				num2 = (short)68747264;
				short num5 = num2;
				return num;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060002CA RID: 714 RVA: 0x000491CC File Offset: 0x000473CC
		protected override global::System.Collections.IEnumerator LogicalChildren
		{
			get
			{
				short num = (short)726859776;
				short num2 = num;
				num = (short)1382088706;
				int num3 = (int)((global::System.IntPtr)num);
				global::System.Collections.Generic.List<global::System.Windows.UIElement> list;
				for (;;)
				{
					global::System.Collections.Generic.List<global::DevComponents.WpfDock.DockSplitter>.Enumerator enumerator;
					switch (num3)
					{
					case 0:
						try
						{
							num = (short)52137063;
							short num4 = num;
							num = (short)1872923751;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_155;
							default:
								num = (short)996737024;
								if (num != 0)
								{
								}
								num = (short)1725300738;
								num3 = (int)((global::System.IntPtr)num);
								break;
							}
							for (;;)
							{
								IL_113:
								switch (num3)
								{
								case 0:
									num = (short)1494286337;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_1A3;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_12D;
									}
									continue;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)316407808;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Windows.UIElement item = enumerator.Current;
									list.Add(item);
									num = (short)1855651844;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								break;
							}
							IL_12D:
							goto IL_155;
							IL_1A3:
							goto IL_1E8;
							IL_155:
							num = (short)2002059267;
							num3 = (int)((global::System.IntPtr)num);
							goto IL_113;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_1B3;
					case 1:
						num = (short)1861025793;
						if (num != 0)
						{
						}
						goto IL_1B3;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_58;
						}
						continue;
					}
					IL_58:
					if (this.c.Count > 0)
					{
						num = (short)648216577;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F4;
					IL_1B3:
					list = new global::System.Collections.Generic.List<global::System.Windows.UIElement>(this.d);
					enumerator = this.c.GetEnumerator();
					num = (short)387842048;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_1E8:
				return list.GetEnumerator();
				IL_1F4:
				return this.d.GetEnumerator();
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060002CB RID: 715 RVA: 0x000493E8 File Offset: 0x000475E8
		[global::System.ComponentModel.Browsable(false)]
		public string Id
		{
			get
			{
				short num = (short)1892417537;
				if (num != 0)
				{
				}
				num = (short)1736038924;
				short num2 = num;
				num = (short)1501354508;
				switch (num2 == num)
				{
				}
				num = (short)1783234560;
				short num3 = num;
				num = (short)490078208;
				if (num != 0)
				{
				}
				return this.e;
			}
		}

		// Token: 0x0400019E RID: 414
		public static readonly global::System.Windows.DependencyProperty RelativeSizeProperty;

		// Token: 0x0400019F RID: 415
		public static readonly global::System.Windows.DependencyProperty OrientationProperty;

		// Token: 0x040001A0 RID: 416
		public static readonly global::System.Windows.DependencyProperty BackgroundProperty;

		// Token: 0x040001A1 RID: 417
		internal const double a = 20.0;

		// Token: 0x040001A2 RID: 418
		private global::System.Collections.Generic.Dictionary<global::System.Windows.UIElement, global::DevComponents.WpfDock.DockSplitter> b = new global::System.Collections.Generic.Dictionary<global::System.Windows.UIElement, global::DevComponents.WpfDock.DockSplitter>();

		// Token: 0x040001A3 RID: 419
		private global::System.Collections.Generic.List<global::DevComponents.WpfDock.DockSplitter> c = new global::System.Collections.Generic.List<global::DevComponents.WpfDock.DockSplitter>();

		// Token: 0x040001A4 RID: 420
		private global::DevComponents.WpfDock.SplitPanelChildrenCollection d;

		// Token: 0x040001A5 RID: 421
		private string e = "";

		// Token: 0x040001A6 RID: 422
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler f;

		// Token: 0x040001A7 RID: 423
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler g;
	}
}
