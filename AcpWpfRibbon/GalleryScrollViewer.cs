using System;
using System.Collections;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon
{
	// Token: 0x02000052 RID: 82
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class GalleryScrollViewer : global::System.Windows.Controls.Canvas
	{
		// Token: 0x060003CD RID: 973 RVA: 0x00052200 File Offset: 0x00050400
		static GalleryScrollViewer()
		{
			int a_ = 16;
			short num = (short)1774259949;
			short num2 = num;
			num = (short)1371606765;
			switch (num2 == num)
			{
			}
			num = (short)601686016;
			if (num != 0)
			{
			}
			num = (short)37421056;
			short num3 = num;
			num = (short)1779433473;
			if (num != 0)
			{
			}
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::DevComponents.WpfRibbon.GalleryScrollViewer), new global::System.Windows.FrameworkPropertyMetadata(false));
			global::DevComponents.WpfRibbon.GalleryScrollViewer.VerticalOffsetProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㹧ཀྵṫᩭ᥯ᅱᕳ᩵㝷ᱹ᩻ൽ", a_), typeof(double), typeof(global::DevComponents.WpfRibbon.GalleryScrollViewer), new global::System.Windows.FrameworkPropertyMetadata(0.0, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.GalleryScrollViewer.OnVerticalOffsetChanged)));
			global::DevComponents.WpfRibbon.GalleryScrollViewer.LineDownCommand = new global::System.Windows.Input.RoutedCommand(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⑧ͩɫ୭㑯ᵱͳᡵ", a_), typeof(global::DevComponents.WpfRibbon.GalleryScrollViewer));
			global::DevComponents.WpfRibbon.GalleryScrollViewer.LineUpCommand = new global::System.Windows.Input.RoutedCommand(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⑧ͩɫ୭╯ɱ", a_), typeof(global::DevComponents.WpfRibbon.GalleryScrollViewer));
			global::System.Windows.Input.CommandManager.RegisterClassCommandBinding(typeof(global::DevComponents.WpfRibbon.GalleryScrollViewer), new global::System.Windows.Input.CommandBinding(global::DevComponents.WpfRibbon.GalleryScrollViewer.LineUpCommand, new global::System.Windows.Input.ExecutedRoutedEventHandler(global::DevComponents.WpfRibbon.GalleryScrollViewer.OnScrollCommand), new global::System.Windows.Input.CanExecuteRoutedEventHandler(global::DevComponents.WpfRibbon.GalleryScrollViewer.OnQueryScrollCommand)));
			global::System.Windows.Input.CommandManager.RegisterClassInputBinding(typeof(global::DevComponents.WpfRibbon.GalleryScrollViewer), new global::System.Windows.Input.InputBinding(global::DevComponents.WpfRibbon.GalleryScrollViewer.LineUpCommand, new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Up)));
			global::System.Windows.Input.CommandManager.RegisterClassCommandBinding(typeof(global::DevComponents.WpfRibbon.GalleryScrollViewer), new global::System.Windows.Input.CommandBinding(global::DevComponents.WpfRibbon.GalleryScrollViewer.LineDownCommand, new global::System.Windows.Input.ExecutedRoutedEventHandler(global::DevComponents.WpfRibbon.GalleryScrollViewer.OnScrollCommand), new global::System.Windows.Input.CanExecuteRoutedEventHandler(global::DevComponents.WpfRibbon.GalleryScrollViewer.OnQueryScrollCommand)));
			global::System.Windows.Input.CommandManager.RegisterClassInputBinding(typeof(global::DevComponents.WpfRibbon.GalleryScrollViewer), new global::System.Windows.Input.InputBinding(global::DevComponents.WpfRibbon.GalleryScrollViewer.LineDownCommand, new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Down)));
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00052404 File Offset: 0x00050604
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
		{
			short num = (short)100139008;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1447362569;
				num2 = (int)((global::System.IntPtr)num);
				global::System.Windows.Size size;
				for (;;)
				{
					global::System.Windows.Size availableSize;
					global::DevComponents.WpfRibbon.Gallery gallery;
					double width;
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						availableSize.Width = constraint.Width;
						num = (short)2145255425;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_3CC;
					case 2:
						base.BeginAnimation(global::DevComponents.WpfRibbon.GalleryScrollViewer.VerticalOffsetProperty, null);
						num = (short)1964965901;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)804257799;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (!double.IsInfinity(constraint.Width))
						{
							num = (short)394461196;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3CC;
					case 5:
						goto IL_1A3;
					case 6:
						num = (short)463536129;
						if (num != 0)
						{
						}
						if (!double.IsNaN(base.Width))
						{
							num = (short)1762000901;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4F0;
					case 7:
						if (base.HasAnimatedProperties)
						{
							num = (short)81854466;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AB;
					case 8:
						goto IL_101;
					case 9:
						switch (0)
						{
						case 0:
							goto IL_80;
						}
						continue;
					case 10:
						if (!double.IsNaN(constraint.Width))
						{
							num = (short)497287168;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3CC;
					case 11:
						if (gallery == null)
						{
							width = 200.0;
							goto IL_37C;
						}
						goto IL_374;
					case 12:
						num = (short)328663050;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_AB;
					case 14:
						try
						{
							num = (short)40239105;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1213005826;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1EB;
									}
									continue;
								case 2:
									goto IL_2FA;
								case 3:
								{
									global::System.Windows.UIElement uielement;
									if (uielement != null)
									{
										num = (short)374013956;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
								{
									IL_229:
									global::System.Windows.UIElement uielement;
									uielement.Measure(availableSize);
									size = uielement.DesiredSize;
									num = (short)415367173;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)125698048;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)enumerator.Current;
									num = (short)1604255747;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_256:
								num = (short)443883785;
								short num3 = num;
								num = (short)290857225;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_229;
								default:
									num = (short)1150812160;
									if (num != 0)
									{
									}
									num = (short)537526278;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1EB:
								goto IL_256;
							}
							IL_2FA:
							goto IL_138;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_31C;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_309:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)982515714;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_373;
								case 1:
									goto IL_371;
								case 2:
									disposable.Dispose();
									num = (short)655556609;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_31C;
							}
							IL_371:
							IL_373:
							goto EndFinally_12;
							IL_31C:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)840040448;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_309;
							EndFinally_12:;
						}
						goto IL_374;
						IL_138:
						num = (short)1396441094;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_80:
					if (this.VerticalOffset != 0.0)
					{
						num = (short)632750083;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_101;
					IL_AB:
					this.VerticalOffset = 0.0;
					num = (short)133103616;
					short num4 = num;
					num = (short)2143617032;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_101:
					global::System.Windows.Input.CommandManager.InvalidateRequerySuggested();
					gallery = (base.TemplatedParent as global::DevComponents.WpfRibbon.Gallery);
					num = (short)156303371;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_37C:
					availableSize = new global::System.Windows.Size(width, double.PositiveInfinity);
					num = (short)1492254724;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_374:
					width = gallery.SuggestedContainerWidth;
					goto IL_37C;
					IL_3CC:
					size = default(global::System.Windows.Size);
					enumerator = base.InternalChildren.GetEnumerator();
					num = (short)878379022;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1A3:
				return default(global::System.Windows.Size);
				IL_4F0:
				return new global::System.Windows.Size(size.Width, 0.0);
			}
			}
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00052934 File Offset: 0x00050B34
		private static void OnQueryScrollCommand(object target, global::System.Windows.Input.CanExecuteRoutedEventArgs args)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			global::DevComponents.WpfRibbon.GalleryScrollViewer galleryScrollViewer;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (args.Command == global::DevComponents.WpfRibbon.GalleryScrollViewer.LineUpCommand)
					{
						num2 = (short)39190531;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1641414657;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (args.Command == global::DevComponents.WpfRibbon.GalleryScrollViewer.LineDownCommand)
					{
						num2 = (short)2017263620;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					goto IL_8A;
				case 3:
					goto IL_63;
				case 4:
				{
					num2 = (short)1720188929;
					if (num2 != 0)
					{
					}
					num2 = (short)2136193987;
					short num3 = num2;
					num2 = (short)519617475;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)2053505024;
						if (num2 != 0)
						{
						}
						args.CanExecute = galleryScrollViewer.CanScrollDown;
						num2 = (short)2104885250;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_24;
			}
			IL_63:
			args.CanExecute = galleryScrollViewer.CanScrollUp;
			return;
			IL_8A:
			num2 = (short)1202651136;
			short num4 = num2;
			return;
			IL_24:
			galleryScrollViewer = (global::DevComponents.WpfRibbon.GalleryScrollViewer)target;
			num2 = (short)180748288;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x00052AC0 File Offset: 0x00050CC0
		private bool CanScrollUp
		{
			get
			{
				short num = (short)1556742145;
				if (num != 0)
				{
				}
				num = (short)1198981120;
				short num2 = num;
				num = (short)227944176;
				short num3 = num;
				num = (short)1019815664;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)71303168;
					if (num != 0)
					{
					}
					if (this.VerticalOffset == 0.0)
					{
						return false;
					}
					break;
				}
				return true;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x00052B80 File Offset: 0x00050D80
		private bool CanScrollDown
		{
			get
			{
				short num = (short)386990080;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_34;
						}
						continue;
					case 1:
					{
						num = (short)682862222;
						short num3 = num;
						num = (short)1383114382;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)1877803008;
							if (num != 0)
							{
							}
							global::System.Windows.Size renderSize;
							double num4 = renderSize.Height + this.VerticalOffset;
							renderSize = base.RenderSize;
							if (num4 > renderSize.Height)
							{
								return true;
							}
							break;
						}
						}
						num = (short)481165312;
						short num5 = num;
						num = (short)588644355;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						global::System.Windows.Size renderSize = base.InternalChildren[0].RenderSize;
						num = (short)342163457;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_157;
					}
					IL_34:
					if (base.InternalChildren.Count <= 0)
					{
						return true;
					}
					num = (short)1534328834;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_157:
				num = (short)725417985;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00052CEC File Offset: 0x00050EEC
		private static void OnScrollCommand(object target, global::System.Windows.Input.ExecutedRoutedEventArgs args)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			global::DevComponents.WpfRibbon.GalleryScrollViewer galleryScrollViewer;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (args.Command == global::DevComponents.WpfRibbon.GalleryScrollViewer.LineUpCommand)
					{
						num2 = (short)1245642755;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2076573697;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (args.Command == global::DevComponents.WpfRibbon.GalleryScrollViewer.LineDownCommand)
					{
						num2 = (short)1291517956;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					goto IL_80;
				case 3:
					goto IL_61;
				case 4:
				{
					num2 = (short)41620675;
					short num3 = num2;
					num2 = (short)971773123;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)647364608;
						if (num2 != 0)
						{
						}
						galleryScrollViewer.LineDown();
						num2 = (short)468385794;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_24;
			}
			IL_61:
			num2 = (short)1261764609;
			if (num2 != 0)
			{
			}
			galleryScrollViewer.LineUp();
			return;
			IL_80:
			num2 = (short)1131610112;
			short num4 = num2;
			return;
			IL_24:
			galleryScrollViewer = (global::DevComponents.WpfRibbon.GalleryScrollViewer)target;
			num2 = (short)408682496;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00052E6C File Offset: 0x0005106C
		private void LineDown()
		{
			short num = (short)1466564608;
			short num2 = num;
			num = (short)372112635;
			short num3 = num;
			num = (short)312343803;
			switch (num3 == num)
			{
			}
			num = (short)1762197505;
			if (num != 0)
			{
			}
			num = (short)2116222976;
			if (num != 0)
			{
			}
			this.Animate(this.VerticalOffset - this.GetSingleLineOffset());
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00052F28 File Offset: 0x00051128
		private void LineUp()
		{
			short num = (short)1769275392;
			short num2 = num;
			num = (short)2033766855;
			short num3 = num;
			num = (short)1114821063;
			switch (num3 == num)
			{
			}
			num = (short)1557463040;
			if (num != 0)
			{
			}
			num = (short)2005598209;
			if (num != 0)
			{
			}
			this.Animate(global::System.Math.Min(0.0, this.VerticalOffset + this.GetSingleLineOffset()));
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00052FF4 File Offset: 0x000511F4
		private double GetSingleLineOffset()
		{
			short num = (short)1495138304;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5A;
				}
				double result;
				for (;;)
				{
					IL_27:
					int num4;
					global::System.Windows.Controls.Panel panel;
					double verticalOffset;
					switch (num2)
					{
					case 0:
						if (!(base.InternalChildren[0] is global::System.Windows.Controls.Panel))
						{
							num = (short)711917570;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_282;
					case 1:
					{
						num = (short)1263796224;
						short num3 = num;
						global::System.Windows.Rect layoutSlot;
						result = layoutSlot.Height;
						num = (short)797638660;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_25C;
					case 3:
						goto IL_186;
					case 4:
						goto IL_F2;
					case 5:
						if (base.InternalChildren.Count != 0)
						{
							num = (short)1713373190;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 6:
						num = (short)2025979904;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						if (num4 < panel.Children.Count)
						{
							num = (short)449380353;
							if (num != 0)
							{
							}
							global::System.Windows.Rect layoutSlot = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(panel.Children[num4] as global::System.Windows.FrameworkElement);
							num = (short)1244725257;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)969662573;
						short num5 = num;
						num = (short)1205723245;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_282;
						default:
							num = (short)21692416;
							if (num != 0)
							{
							}
							num = (short)849346568;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 8:
						goto IL_213;
					case 9:
					{
						global::System.Windows.Rect layoutSlot;
						if (layoutSlot.Y + verticalOffset >= 0.0)
						{
							num = (short)1226309633;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4++;
						num = (short)299499523;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_186;
					}
					goto IL_5A;
					IL_186:
					num = (short)1735589895;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_282:
					panel = (base.InternalChildren[0] as global::System.Windows.Controls.Panel);
					verticalOffset = this.VerticalOffset;
					num4 = 0;
					num = (short)1019674634;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_F2:
				return result;
				IL_213:
				return result;
				IL_25C:
				return result;
				IL_5A:
				result = 38.0;
				num = (short)1669267461;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x000532BC File Offset: 0x000514BC
		protected override void OnGotKeyboardFocus(global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			short num = (short)123928581;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1240989697;
					if (num != 0)
					{
					}
					num = (short)416612355;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (base.InternalChildren[0] is global::System.Windows.Controls.Panel)
					{
						num = (short)964296711;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_261;
				case 2:
					goto IL_21B;
				case 3:
					if (base.InternalChildren.Count > 0)
					{
						num = (short)1244987402;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_261;
				case 4:
				{
					global::System.Windows.UIElement uielement;
					if ((base.InternalChildren[0] as global::System.Windows.Controls.Panel).Children.Contains(uielement))
					{
						num = (short)785055753;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_261;
				}
				case 5:
					switch (0)
					{
					case 0:
						goto IL_52;
					}
					continue;
				case 6:
					goto IL_196;
				case 7:
				{
					num = (short)170299185;
					short num3 = num;
					num = (short)569937713;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_196;
					default:
					{
						num = (short)2127233024;
						if (num != 0)
						{
						}
						global::System.Windows.UIElement uielement = e.NewFocus as global::System.Windows.UIElement;
						num = (short)1798242308;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 8:
					if (e.NewFocus is global::System.Windows.UIElement)
					{
						num = (short)245170176;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_261;
				case 9:
				{
					global::System.Windows.UIElement uielement;
					this.BringIntoView(uielement);
					num = (short)1640038402;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 10:
					num = (short)614662145;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_52:
				if (e.NewFocus != null)
				{
					num = (short)911605760;
					short num4 = num;
					num = (short)288227334;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_196:
				num = (short)1294204936;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_21B:
			IL_261:
			base.OnGotKeyboardFocus(e);
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00053534 File Offset: 0x00051734
		private void BringIntoView(global::System.Windows.UIElement elem)
		{
			short num = (short)1581252608;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)2080768001;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_5C;
					}
					continue;
				case 1:
				{
					num = (short)796892886;
					short num3 = num;
					num = (short)1775410902;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)152502272;
						if (num != 0)
						{
						}
						if (elem is global::System.Windows.FrameworkElement)
						{
							goto IL_126;
						}
						break;
					}
					num = (short)1063124992;
					short num4 = num;
					num = (short)1971388419;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					num = (short)1879441409;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_121;
				}
				IL_5C:
				if (elem == null)
				{
					break;
				}
				num = (short)936771586;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_121:
			return;
			IL_126:
			this.Animate(-global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(elem as global::System.Windows.FrameworkElement).Top);
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00053684 File Offset: 0x00051884
		private void Animate(double newVerticalOffset)
		{
			short num = (short)1162018817;
			if (num != 0)
			{
			}
			num = (short)1016528896;
			switch (num)
			{
			default:
			{
				num = (short)1711603714;
				int num2 = (int)((global::System.IntPtr)num);
				double num5;
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)132317184;
						short num3 = num;
						num = (short)224426713;
						short num4 = num;
						num = (short)590838489;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1F8;
						default:
						{
							num = (short)102891520;
							if (num != 0)
							{
							}
							num5 = 190.0;
							double num6 = global::System.Math.Abs(this.VerticalOffset - newVerticalOffset);
							num = (short)96993281;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 1:
					{
						double num6;
						if (num6 < 60.0)
						{
							num = (short)1403584515;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D4;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_89;
						}
						continue;
					case 3:
					{
						double num6;
						num5 *= num6 / 60.0;
						num = (short)1409155078;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_125;
					case 5:
						if (num5 >= 50.0)
						{
							num = (short)1791885316;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F8;
					case 6:
						goto IL_D4;
					}
					IL_89:
					if (this.AnimationEnabled)
					{
						num = (short)1420623872;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_22B;
					IL_D4:
					num5 = global::System.Math.Max(num5, 100.0);
					num = (short)495583237;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_125:
				global::System.TimeSpan timeSpan = global::System.TimeSpan.FromMilliseconds(global::System.Math.Round(num5));
				global::System.Windows.Media.Animation.DoubleAnimation animation = new global::System.Windows.Media.Animation.DoubleAnimation(newVerticalOffset, new global::System.Windows.Duration(timeSpan));
				base.BeginAnimation(global::DevComponents.WpfRibbon.GalleryScrollViewer.VerticalOffsetProperty, animation, global::System.Windows.Media.Animation.HandoffBehavior.Compose);
				return;
				IL_1F8:
				this.VerticalOffset = newVerticalOffset;
				return;
				IL_22B:
				this.VerticalOffset = newVerticalOffset;
				return;
			}
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060003D9 RID: 985 RVA: 0x000538C4 File Offset: 0x00051AC4
		private bool AnimationEnabled
		{
			get
			{
				short num = (short)1027866627;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1139933189;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (global::System.Windows.Media.RenderCapability.Tier > 0)
						{
							num = (short)1598881799;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 2:
						num = (short)60227585;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						num = (short)527302657;
						if (num != 0)
						{
						}
						num = (short)1219807703;
						short num3 = num;
						num = (short)1218628055;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_13B;
						default:
							num = (short)892993536;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_B7;
							}
							continue;
						}
						break;
					}
					case 4:
						goto IL_13B;
					case 5:
						if (global::System.Windows.SystemParameters.ClientAreaAnimation)
						{
							num = (short)458293250;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 6:
						if (base.IsEnabled)
						{
							num = (short)252182528;
							short num4 = num;
							num = (short)871956484;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 7:
						num = (short)1297940486;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_B7:
					if (global::System.Windows.SystemParameters.PowerLineStatus != global::System.Windows.PowerLineStatus.Online)
					{
						return false;
					}
					num = (short)958332928;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_13B:
				return this.m_Animation;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060003DA RID: 986 RVA: 0x00053A84 File Offset: 0x00051C84
		// (set) Token: 0x060003DB RID: 987 RVA: 0x00053B34 File Offset: 0x00051D34
		internal bool Animation
		{
			get
			{
				short num = (short)2036989952;
				short num2 = num;
				num = (short)385482753;
				if (num != 0)
				{
				}
				num = (short)1618607623;
				short num3 = num;
				num = (short)1479998983;
				switch (num3 == num)
				{
				}
				num = (short)1353318400;
				if (num != 0)
				{
				}
				return this.m_Animation;
			}
			set
			{
				short num = (short)1603993600;
				short num2 = num;
				num = (short)1546190849;
				if (num != 0)
				{
				}
				num = (short)658522881;
				short num3 = num;
				num = (short)969818881;
				switch (num3 == num)
				{
				}
				num = (short)1362296832;
				if (num != 0)
				{
				}
				this.m_Animation = value;
			}
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00053BE4 File Offset: 0x00051DE4
		private static void OnVerticalOffsetChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)333905920;
			short num2 = num;
			num = (short)1723074887;
			short num3 = num;
			num = (short)1992100167;
			switch (num3 == num)
			{
			}
			num = (short)515112960;
			if (num != 0)
			{
			}
			num = (short)1427505153;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfRibbon.GalleryScrollViewer)d).SetVerticalOffset((double)e.NewValue);
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060003DD RID: 989 RVA: 0x00053CA8 File Offset: 0x00051EA8
		// (set) Token: 0x060003DE RID: 990 RVA: 0x00053D64 File Offset: 0x00051F64
		public double VerticalOffset
		{
			get
			{
				short num = (short)539688960;
				short num2 = num;
				num = (short)1162004720;
				short num3 = num;
				num = (short)454412528;
				switch (num3 == num)
				{
				}
				num = (short)339345408;
				if (num != 0)
				{
				}
				num = (short)1423376385;
				if (num != 0)
				{
				}
				return (double)base.GetValue(global::DevComponents.WpfRibbon.GalleryScrollViewer.VerticalOffsetProperty);
			}
			set
			{
				short num = (short)993198080;
				short num2 = num;
				num = (short)711917569;
				if (num != 0)
				{
				}
				num = (short)720986787;
				short num3 = num;
				num = (short)1883202211;
				switch (num3 == num)
				{
				}
				num = (short)448856064;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.GalleryScrollViewer.VerticalOffsetProperty, value);
			}
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00053E20 File Offset: 0x00052020
		private void SetVerticalOffset(double value)
		{
			short num = (short)1316159489;
			if (num != 0)
			{
			}
			num = (short)1397817344;
			short num2 = num;
			global::System.Collections.IEnumerator enumerator = base.InternalChildren.GetEnumerator();
			try
			{
				num = (short)749666304;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_98;
						}
						continue;
					case 1:
						goto IL_142;
					case 2:
					{
						if (enumerator.MoveNext())
						{
							global::System.Windows.Controls.Canvas.SetTop((global::System.Windows.UIElement)enumerator.Current, value);
							num = (short)1872887811;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1094092335;
						short num4 = num;
						num = (short)820676143;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_142;
						default:
							num = (short)1182662656;
							if (num != 0)
							{
							}
							num = (short)875823105;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						goto IL_15B;
					}
					IL_C1:
					num = (short)1318584322;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_98:
					goto IL_C1;
					IL_142:
					num = (short)1007812612;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_15B:;
			}
			finally
			{
				switch (0)
				{
				case 0:
					goto IL_179;
				}
				int num3;
				global::System.IDisposable disposable;
				for (;;)
				{
					IL_167:
					switch (num3)
					{
					case 0:
						disposable.Dispose();
						num = (short)1373634562;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (disposable != null)
						{
							num = (short)1443561472;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1CC;
					case 2:
						goto IL_1CA;
					}
					goto IL_179;
				}
				IL_1CA:
				IL_1CC:
				goto EndFinally_5;
				IL_179:
				disposable = (enumerator as global::System.IDisposable);
				num = (short)1840971777;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_167;
				EndFinally_5:;
			}
			global::System.Windows.Input.CommandManager.InvalidateRequerySuggested();
		}

		// Token: 0x040001C8 RID: 456
		public static readonly global::System.Windows.DependencyProperty VerticalOffsetProperty;

		// Token: 0x040001C9 RID: 457
		public static readonly global::System.Windows.Input.RoutedCommand LineDownCommand;

		// Token: 0x040001CA RID: 458
		public static readonly global::System.Windows.Input.RoutedCommand LineUpCommand;

		// Token: 0x040001CB RID: 459
		private bool m_Animation = true;

		// Token: 0x040001CC RID: 460
		private const double DefaultAnimationDuration = 190.0;
	}
}
