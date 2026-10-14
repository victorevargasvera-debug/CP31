using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using DevComponents.WpfEditors.Primitives;

namespace DevComponents.WpfEditors
{
	// Token: 0x0200002E RID: 46
	public class StateAnimationControl : global::System.Windows.Controls.Panel
	{
		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000365 RID: 869 RVA: 0x0004232C File Offset: 0x0004052C
		// (set) Token: 0x06000366 RID: 870 RVA: 0x000423E8 File Offset: 0x000405E8
		public global::System.Windows.HorizontalAlignment HorizontalContentAlignment
		{
			get
			{
				short num = (short)1939668992;
				short num2 = num;
				num = (short)1326593810;
				short num3 = num;
				num = (short)1849106;
				switch (num3 == num)
				{
				}
				num = (short)1538785280;
				if (num != 0)
				{
				}
				num = (short)1788215297;
				if (num != 0)
				{
				}
				return (global::System.Windows.HorizontalAlignment)base.GetValue(global::DevComponents.WpfEditors.StateAnimationControl.HorizontalContentAlignmentProperty);
			}
			set
			{
				short num = (short)1294073856;
				short num2 = num;
				num = (short)647999180;
				short num3 = num;
				num = (short)388148940;
				switch (num3 == num)
				{
				}
				num = (short)1416691712;
				if (num != 0)
				{
				}
				num = (short)1563951105;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.StateAnimationControl.HorizontalContentAlignmentProperty, value);
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000367 RID: 871 RVA: 0x000424A4 File Offset: 0x000406A4
		// (set) Token: 0x06000368 RID: 872 RVA: 0x0004255C File Offset: 0x0004075C
		public global::System.Windows.VerticalAlignment VerticalContentAlignment
		{
			get
			{
				short num = (short)891486208;
				short num2 = num;
				num = (short)1367214471;
				short num3 = num;
				num = (short)89196935;
				switch (num3 == num)
				{
				}
				num = (short)1401946112;
				if (num != 0)
				{
				}
				num = (short)246022145;
				if (num != 0)
				{
				}
				return (global::System.Windows.VerticalAlignment)base.GetValue(global::DevComponents.WpfEditors.StateAnimationControl.VerticalContentAlignmentProperty);
			}
			set
			{
				short num = (short)1948450816;
				short num2 = num;
				num = (short)1377597857;
				short num3 = num;
				num = (short)803109281;
				switch (num3 == num)
				{
				}
				num = (short)609550337;
				if (num != 0)
				{
				}
				num = (short)634650624;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.StateAnimationControl.VerticalContentAlignmentProperty, value);
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000369 RID: 873 RVA: 0x00042618 File Offset: 0x00040818
		// (set) Token: 0x0600036A RID: 874 RVA: 0x000426D4 File Offset: 0x000408D4
		public global::DevComponents.WpfEditors.eStateAnimationType AnimationType
		{
			get
			{
				short num = (short)2137849856;
				short num2 = num;
				num = (short)367200731;
				short num3 = num;
				num = (short)2080180699;
				switch (num3 == num)
				{
				}
				num = (short)1619722240;
				if (num != 0)
				{
				}
				num = (short)319553537;
				if (num != 0)
				{
				}
				return (global::DevComponents.WpfEditors.eStateAnimationType)base.GetValue(global::DevComponents.WpfEditors.StateAnimationControl.AnimationTypeProperty);
			}
			set
			{
				short num = (short)1237712896;
				short num2 = num;
				num = (short)1879796979;
				short num3 = num;
				num = (short)388132083;
				switch (num3 == num)
				{
				}
				num = (short)735903745;
				if (num != 0)
				{
				}
				num = (short)99483648;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.StateAnimationControl.AnimationTypeProperty, value);
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600036B RID: 875 RVA: 0x00042790 File Offset: 0x00040990
		// (set) Token: 0x0600036C RID: 876 RVA: 0x0004284C File Offset: 0x00040A4C
		public double AnimationDuration
		{
			get
			{
				short num = (short)1590654057;
				short num2 = num;
				num = (short)2046784617;
				switch (num2 == num)
				{
				}
				num = (short)1627914240;
				if (num != 0)
				{
				}
				num = (short)631046145;
				if (num != 0)
				{
				}
				num = (short)1844838400;
				short num3 = num;
				return (double)base.GetValue(global::DevComponents.WpfEditors.StateAnimationControl.AnimationDurationProperty);
			}
			set
			{
				short num = (short)1159564878;
				short num2 = num;
				num = (short)1682083406;
				switch (num2 == num)
				{
				}
				num = (short)170917888;
				if (num != 0)
				{
				}
				num = (short)76611585;
				if (num != 0)
				{
				}
				num = (short)1444020224;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.StateAnimationControl.AnimationDurationProperty, value);
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600036D RID: 877 RVA: 0x00042908 File Offset: 0x00040B08
		// (set) Token: 0x0600036E RID: 878 RVA: 0x000429C0 File Offset: 0x00040BC0
		public bool AnimationEnabled
		{
			get
			{
				short num = (short)1662980640;
				short num2 = num;
				num = (short)365695520;
				switch (num2 == num)
				{
				}
				num = (short)1663696897;
				if (num != 0)
				{
				}
				num = (short)441581568;
				if (num != 0)
				{
				}
				num = (short)1515651072;
				short num3 = num;
				return (bool)base.GetValue(global::DevComponents.WpfEditors.StateAnimationControl.AnimationEnabledProperty);
			}
			set
			{
				short num = (short)39530033;
				short num2 = num;
				num = (short)1911959089;
				switch (num2 == num)
				{
				}
				num = (short)744751105;
				if (num != 0)
				{
				}
				num = (short)908132352;
				if (num != 0)
				{
				}
				num = (short)1660944384;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.StateAnimationControl.AnimationEnabledProperty, value);
			}
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00042A7C File Offset: 0x00040C7C
		static StateAnimationControl()
		{
			int a_ = 0;
			short num = (short)1841013312;
			short num2 = num;
			num = (short)1802150464;
			switch (num2 == num)
			{
			}
			num = (short)845611008;
			if (num != 0)
			{
			}
			num = (short)1206714369;
			if (num != 0)
			{
			}
			num = (short)1760296960;
			short num3 = num;
			global::DevComponents.WpfEditors.StateAnimationControl.HorizontalContentAlignmentProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("藌ꃎꏐ뫒꿔룖럘꿚볜돞ꋠ賢诤鏦賨藪駬껮鷰髲鋴駶铸黺鏼课", a_), typeof(global::System.Windows.HorizontalAlignment), typeof(global::DevComponents.WpfEditors.StateAnimationControl), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.HorizontalAlignment.Stretch, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::DevComponents.WpfEditors.StateAnimationControl.VerticalContentAlignmentProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鯌꫎ꏐ꟒볔듖룘럚黜냞迠韢胤触鷨ꫪ臬蛮雰鷲飴鋶韸迺", a_), typeof(global::System.Windows.VerticalAlignment), typeof(global::DevComponents.WpfEditors.StateAnimationControl), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.VerticalAlignment.Stretch, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::DevComponents.WpfEditors.StateAnimationControl.AnimationTypeProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("賌ꇎ룐뻒듔ꏖ냘듚돜诞飠鏢胤", a_), typeof(global::DevComponents.WpfEditors.eStateAnimationType), typeof(global::DevComponents.WpfEditors.StateAnimationControl), new global::System.Windows.UIPropertyMetadata(global::DevComponents.WpfEditors.eStateAnimationType.ScrollFromRightToLeft));
			global::DevComponents.WpfEditors.StateAnimationControl.AnimationDurationProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("賌ꇎ룐뻒듔ꏖ냘듚돜鯞铠釢蓤鏦胨蓪菬", a_), typeof(double), typeof(global::DevComponents.WpfEditors.StateAnimationControl), new global::System.Windows.UIPropertyMetadata(300.0));
			global::DevComponents.WpfEditors.StateAnimationControl.AnimationEnabledProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("賌ꇎ룐뻒듔ꏖ냘듚돜髞迠苢蟤详賨迪", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.StateAnimationControl), new global::System.Windows.UIPropertyMetadata(true));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::DevComponents.WpfEditors.StateAnimationControl), new global::System.Windows.FrameworkPropertyMetadata(false));
			global::System.Windows.UIElement.ClipToBoundsProperty.OverrideMetadata(typeof(global::DevComponents.WpfEditors.StateAnimationControl), new global::System.Windows.FrameworkPropertyMetadata(true));
			global::System.Windows.FrameworkElement.FocusVisualStyleProperty.OverrideMetadata(typeof(global::DevComponents.WpfEditors.StateAnimationControl), new global::System.Windows.FrameworkPropertyMetadata(null));
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00042CA8 File Offset: 0x00040EA8
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			short num = (short)1755709440;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::System.Windows.Controls.UIElementCollection children = base.Children;
				global::System.Windows.Size result = default(global::System.Windows.Size);
				global::System.Collections.IEnumerator enumerator = children.GetEnumerator();
				try
				{
					num = (short)2064777219;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_181;
						case 1:
							num = (short)1359609856;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							if (enumerator.MoveNext())
							{
								global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)enumerator.Current;
								uielement.Measure(availableSize);
								result.Width = global::System.Math.Max(result.Width, uielement.DesiredSize.Width);
								result.Height = global::System.Math.Max(result.Height, uielement.DesiredSize.Height);
								num = (short)51118084;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1131187888;
							short num3 = num;
							num = (short)1472106160;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_181;
							default:
								num = (short)393871360;
								if (num != 0)
								{
								}
								num = (short)426573825;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
							switch (0)
							{
							case 0:
								goto IL_6F;
							}
							continue;
						}
						IL_E0:
						num = (short)1265041410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_6F:
						goto IL_E0;
					}
					IL_181:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_1A0;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_18D:
						switch (num2)
						{
						case 0:
							disposable.Dispose();
							num = (short)2118909953;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_1F6;
						case 2:
							if (disposable != null)
							{
								num = (short)48168960;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1F8;
						}
						goto IL_1A0;
					}
					IL_1F6:
					IL_1F8:
					goto EndFinally_5;
					IL_1A0:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)780337154;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_18D;
					EndFinally_5:;
				}
				num = (short)22085632;
				short num4 = num;
				num = (short)328925185;
				if (num != 0)
				{
				}
				return result;
			}
			}
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00042F1C File Offset: 0x0004111C
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			short num = (short)980942848;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)585891840;
				short num3 = num;
				global::System.Windows.Controls.UIElementCollection children = base.Children;
				global::System.Windows.HorizontalAlignment horizontalContentAlignment = this.HorizontalContentAlignment;
				global::System.Windows.VerticalAlignment verticalContentAlignment = this.VerticalContentAlignment;
				global::System.Collections.IEnumerator enumerator = children.GetEnumerator();
				try
				{
					num = (short)236781588;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Windows.UIElement uielement;
						global::System.Windows.Rect finalRect;
						switch (num2)
						{
						case 0:
							goto IL_276;
						case 1:
							if (horizontalContentAlignment == global::System.Windows.HorizontalAlignment.Stretch)
							{
								num = (short)1998848009;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_22E;
						case 2:
							if (verticalContentAlignment == global::System.Windows.VerticalAlignment.Stretch)
							{
								num = (short)961478667;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_22E;
						case 3:
							if (verticalContentAlignment == global::System.Windows.VerticalAlignment.Center)
							{
								num = (short)2031026184;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1087045648;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							if (horizontalContentAlignment == global::System.Windows.HorizontalAlignment.Right)
							{
								num = (short)2105475091;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3E5;
						case 6:
							if (!enumerator.MoveNext())
							{
								num = (short)465895436;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							uielement = (global::System.Windows.UIElement)enumerator.Current;
							num = (short)190840833;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							goto IL_439;
						case 8:
							finalRect.Y = (finalSize.Height - finalRect.Height) / 2.0;
							num = (short)1745682453;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							goto IL_3A6;
						case 10:
							finalRect.Y = finalSize.Height - finalRect.Height;
							num = (short)1129840640;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							finalRect = new global::System.Windows.Rect(finalSize);
							num = (short)1684406290;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							num = (short)771162119;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							goto IL_3E5;
						case 14:
							goto IL_3E5;
						case 15:
							if (horizontalContentAlignment == global::System.Windows.HorizontalAlignment.Center)
							{
								num = (short)1432354833;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)616628229;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 16:
							if (verticalContentAlignment == global::System.Windows.VerticalAlignment.Bottom)
							{
								num = (short)1954545674;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_276;
						case 17:
						{
							num = (short)2120473930;
							short num4 = num;
							num = (short)564452682;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_3A6;
							default:
								num = (short)614924288;
								if (num != 0)
								{
								}
								finalRect.X = (finalSize.Width - finalRect.Width) / 2.0;
								num = (short)1352204302;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 18:
							goto IL_276;
						case 19:
							finalRect.X = finalSize.Width - finalRect.Width;
							num = (short)1208614925;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 20:
							switch (0)
							{
							case 0:
								goto IL_E2;
							}
							continue;
						case 21:
							goto IL_276;
						}
						IL_1BA:
						num = (short)657981446;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_E2:
						goto IL_1BA;
						IL_22E:
						finalRect = new global::System.Windows.Rect(uielement.DesiredSize);
						num = (short)1039269903;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_276:
						uielement.Arrange(finalRect);
						num = (short)852819972;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3A6:
						num = (short)1382612994;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3E5:
						num = (short)28180483;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_439:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_45B;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_448:
						switch (num2)
						{
						case 0:
							num = (short)2041380865;
							if (num != 0)
							{
							}
							disposable.Dispose();
							num = (short)1194590209;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_4DB;
						case 2:
							if (disposable != null)
							{
								num = (short)2046492672;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4DD;
						}
						goto IL_45B;
					}
					IL_4DB:
					IL_4DD:
					goto EndFinally_11;
					IL_45B:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)734461954;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_448;
					EndFinally_11:;
				}
				return base.ArrangeOverride(finalSize);
			}
			}
		}

		// Token: 0x06000372 RID: 882 RVA: 0x0004342C File Offset: 0x0004162C
		private global::System.Windows.UIElement a()
		{
			short num = (short)1751229018;
			short num2 = num;
			num = (short)951493210;
			switch (num2 == num)
			{
			}
			num = (short)47185921;
			if (num != 0)
			{
			}
			num = (short)1441792;
			if (num != 0)
			{
			}
			num = (short)428146688;
			short num3 = num;
			return base.Children[0];
		}

		// Token: 0x06000373 RID: 883 RVA: 0x000434E0 File Offset: 0x000416E0
		public void StartStateTransition()
		{
			short num = (short)417464320;
			switch (num)
			{
			default:
			{
				num = (short)836894738;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.Windows.Controls.Image image;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (base.ActualHeight != 0.0)
						{
							num = (short)1435369489;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						goto IL_433;
					case 2:
						goto IL_FC;
					case 3:
						num = (short)873791494;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (base.Children.Count != 0)
						{
							num = (short)1695154186;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 5:
						goto IL_4BF;
					case 6:
					{
						if (!this.AnimationEnabled)
						{
							num = (short)833945605;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.UIElement uielement = this.a();
						global::System.Windows.Media.Imaging.RenderTargetBitmap renderTargetBitmap = new global::System.Windows.Media.Imaging.RenderTargetBitmap((int)base.ActualWidth, (int)base.ActualHeight, 96.0, 96.0, global::System.Windows.Media.PixelFormats.Default);
						renderTargetBitmap.Render(uielement);
						renderTargetBitmap.Freeze();
						image = new global::System.Windows.Controls.Image();
						image.SnapsToDevicePixels = true;
						image.Source = renderTargetBitmap;
						image.Stretch = global::System.Windows.Media.Stretch.None;
						base.Children.Add(image);
						global::DevComponents.WpfEditors.eStateAnimationType animationType = this.AnimationType;
						num = (short)1064960009;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_416;
					case 8:
						goto IL_346;
					case 9:
					{
						global::DevComponents.WpfEditors.eStateAnimationType animationType;
						switch (animationType)
						{
						case global::DevComponents.WpfEditors.eStateAnimationType.ScrollFromRightToLeft:
						case global::DevComponents.WpfEditors.eStateAnimationType.SlideFromRightToLeft:
						{
							global::System.Windows.UIElement uielement;
							uielement.RenderTransform = new global::System.Windows.Media.TranslateTransform(uielement.RenderSize.Width, 0.0);
							num = (short)1511063554;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case global::DevComponents.WpfEditors.eStateAnimationType.ScrollFromLeftToRight:
						case global::DevComponents.WpfEditors.eStateAnimationType.SlideFromLeftToRight:
						{
							global::System.Windows.UIElement uielement;
							uielement.RenderTransform = new global::System.Windows.Media.TranslateTransform(-uielement.RenderSize.Width, 0.0);
							num = (short)1575157774;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case global::DevComponents.WpfEditors.eStateAnimationType.ScrollUpwards:
						{
							num = (short)1987886061;
							short num3 = num;
							num = (short)1931852781;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_319;
							default:
							{
								num = (short)1626800128;
								if (num != 0)
								{
								}
								global::System.Windows.UIElement uielement;
								uielement.RenderTransform = new global::System.Windows.Media.TranslateTransform(0.0, uielement.RenderSize.Height);
								num = (short)487981063;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case global::DevComponents.WpfEditors.eStateAnimationType.ScrollDownards:
						{
							global::System.Windows.UIElement uielement;
							uielement.RenderTransform = new global::System.Windows.Media.TranslateTransform(0.0, -uielement.RenderSize.Height);
							num = (short)937426955;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case global::DevComponents.WpfEditors.eStateAnimationType.FadeIn:
						{
							global::System.Windows.UIElement uielement;
							uielement.Opacity = 0.0;
							num = (short)246218760;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						default:
							num = (short)262930451;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 10:
						num = (short)768999425;
						if (num != 0)
						{
						}
						num = (short)2036858892;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_26F;
					case 12:
						if (this.AnimationDuration > 0.0)
						{
							num = (short)1355874307;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 13:
						if (base.IsInitialized)
						{
							num = (short)1582825487;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 14:
						goto IL_319;
					case 15:
					{
						num = (short)1737818112;
						short num4 = num;
						num = (short)1835401220;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						num = (short)893845504;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						num = (short)719454221;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						switch (0)
						{
						case 0:
							goto IL_93;
						}
						continue;
					case 19:
						num = (short)1643446273;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_93:
					if (base.ActualWidth == 0.0)
					{
						return;
					}
					num = (short)200867856;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_FC:
				IL_26F:
				IL_319:
				IL_346:
				IL_416:
				IL_433:
				goto IL_4C4;
				IL_4BF:
				return;
				IL_4C4:
				this.b.Push(image);
				return;
			}
			}
		}

		// Token: 0x06000374 RID: 884 RVA: 0x000439C0 File Offset: 0x00041BC0
		public void CancelStateTransition()
		{
			if (this.b.Count == 0)
			{
				short num;
				for (;;)
				{
					num = (short)1935832617;
					short num2 = num;
					num = (short)566851113;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_46;
					}
				}
				IL_46:
				num = (short)20054016;
				short num3 = num;
				num = (short)772079616;
				if (num != 0)
				{
				}
				num = (short)1041301505;
				if (num != 0)
				{
				}
				return;
			}
			this.a().RenderTransform = null;
			global::System.Windows.Controls.Image element = this.b.Pop();
			base.Children.Remove(element);
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00043AA0 File Offset: 0x00041CA0
		public void AnimateStateTransition()
		{
			short num = (short)1358888975;
			int num2 = (int)((global::System.IntPtr)num);
			global::DevComponents.WpfEditors.eStateAnimationType animationType;
			global::System.Windows.UIElement uielement;
			global::System.Windows.Controls.Image image;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1118044160;
					short num3 = num;
					num = (short)805600298;
					short num4 = num;
					num = (short)117931050;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2E0;
					default:
						num = (short)1598095360;
						if (num != 0)
						{
						}
						num = (short)1981939718;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					if (animationType != global::DevComponents.WpfEditors.eStateAnimationType.ScrollUpwards)
					{
						num = (short)1025179649;
						if (num != 0)
						{
						}
						num = (short)1130496014;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_115;
				case 2:
					if (animationType != global::DevComponents.WpfEditors.eStateAnimationType.SlideFromRightToLeft)
					{
						num = (short)701693952;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2D6;
				case 3:
					if (animationType == global::DevComponents.WpfEditors.eStateAnimationType.ScrollDownards)
					{
						num = (short)234225671;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1393819650;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_110;
				case 5:
					goto IL_272;
				case 6:
					if (animationType == global::DevComponents.WpfEditors.eStateAnimationType.SlideFromLeftToRight)
					{
						num = (short)488046596;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)567738378;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_315;
				case 8:
					goto IL_157;
				case 9:
					num = (short)910098448;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (animationType == global::DevComponents.WpfEditors.eStateAnimationType.FadeIn)
					{
						num = (short)1955594252;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 11:
					if (animationType != global::DevComponents.WpfEditors.eStateAnimationType.ScrollFromLeftToRight)
					{
						num = (short)689307657;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_31A;
				case 12:
					this.a(uielement, image);
					num = (short)313851909;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					return;
				case 14:
					goto IL_2E0;
				case 15:
					switch (0)
					{
					case 0:
						goto IL_68;
					}
					continue;
				case 16:
					if (animationType == global::DevComponents.WpfEditors.eStateAnimationType.ScrollFromRightToLeft)
					{
						num = (short)345309192;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1479671809;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_68:
				if (this.b.Count == 0)
				{
					num = (short)553320461;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				animationType = this.AnimationType;
				uielement = this.a();
				image = this.b.Pop();
				num = (short)2071134219;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2E0:
				num = (short)1585446915;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_110:
			goto IL_2D6;
			IL_115:
			this.c(animationType, uielement, image);
			return;
			IL_157:
			goto IL_31A;
			IL_272:
			return;
			IL_2D6:
			this.a(animationType, uielement, image);
			return;
			IL_315:
			goto IL_115;
			IL_31A:
			this.b(animationType, uielement, image);
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00043DD4 File Offset: 0x00041FD4
		private void a(global::System.Windows.UIElement A_0, global::System.Windows.Controls.Image A_1)
		{
			short num = (short)533208738;
			short num2 = num;
			num = (short)1369579170;
			switch (num2 == num)
			{
			}
			num = (short)634912769;
			if (num != 0)
			{
			}
			num = (short)134086656;
			if (num != 0)
			{
			}
			num = (short)1640497152;
			short num3 = num;
			global::System.Windows.Media.Animation.DoubleAnimation doubleAnimation = new global::System.Windows.Media.Animation.DoubleAnimation();
			global::DevComponents.WpfEditors.StateAnimationControl.a(doubleAnimation);
			double animationDuration = this.AnimationDuration;
			doubleAnimation.From = new double?(0.0);
			doubleAnimation.To = new double?((double)1);
			doubleAnimation.Completed += this.b;
			doubleAnimation.Duration = new global::System.Windows.Duration(global::System.TimeSpan.FromMilliseconds(animationDuration));
			A_0.BeginAnimation(global::System.Windows.UIElement.OpacityProperty, doubleAnimation);
			doubleAnimation = new global::System.Windows.Media.Animation.DoubleAnimation();
			global::DevComponents.WpfEditors.StateAnimationControl.a(doubleAnimation);
			doubleAnimation.From = new double?((double)1);
			doubleAnimation.To = new double?(0.0);
			doubleAnimation.Duration = new global::System.Windows.Duration(global::System.TimeSpan.FromMilliseconds(animationDuration));
			doubleAnimation.Completed += this.a;
			this.a[doubleAnimation.CreateClock()] = A_1;
			A_1.BeginAnimation(global::System.Windows.UIElement.OpacityProperty, doubleAnimation);
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00043F4C File Offset: 0x0004214C
		private void c(global::DevComponents.WpfEditors.eStateAnimationType A_0, global::System.Windows.UIElement A_1, global::System.Windows.Controls.Image A_2)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			global::System.Windows.Media.Animation.DoubleAnimation doubleAnimation;
			short num2;
			double animationDuration;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					doubleAnimation.From = new double?(0.0);
					doubleAnimation.To = new double?(-(A_1.RenderSize.Height + 1.0));
					num2 = (short)1798438915;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_11D;
				case 2:
				{
					if (A_0 == global::DevComponents.WpfEditors.eStateAnimationType.ScrollUpwards)
					{
						num2 = (short)1011089408;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					doubleAnimation.From = new double?(0.0);
					doubleAnimation.To = new double?(A_1.RenderSize.Height + 1.0);
					num2 = (short)202086145;
					short num3 = num2;
					num2 = (short)866686721;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_27F;
					default:
						num2 = (short)1564409856;
						if (num2 != 0)
						{
						}
						num2 = (short)258736132;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					goto IL_118;
				case 4:
					goto IL_27F;
				case 5:
					goto IL_11D;
				case 6:
					if (A_0 == global::DevComponents.WpfEditors.eStateAnimationType.ScrollUpwards)
					{
						num2 = (short)1398603783;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					doubleAnimation.From = new double?(-A_1.RenderSize.Height);
					doubleAnimation.To = new double?(0.0);
					num2 = (short)954728449;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					doubleAnimation.From = new double?(A_1.RenderSize.Height);
					doubleAnimation.To = new double?(0.0);
					num2 = (short)1343684613;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_30;
				IL_11D:
				global::DevComponents.WpfEditors.StateAnimationControl.a(doubleAnimation);
				doubleAnimation.Completed += this.b;
				doubleAnimation.Duration = new global::System.Windows.Duration(global::System.TimeSpan.FromMilliseconds(animationDuration));
				A_1.RenderTransform.BeginAnimation(global::System.Windows.Media.TranslateTransform.YProperty, doubleAnimation);
				doubleAnimation = new global::System.Windows.Media.Animation.DoubleAnimation();
				global::DevComponents.WpfEditors.StateAnimationControl.a(doubleAnimation);
				num2 = (short)1829830658;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_118:
			IL_27F:
			doubleAnimation.Duration = new global::System.Windows.Duration(global::System.TimeSpan.FromMilliseconds(animationDuration));
			doubleAnimation.Completed += this.a;
			this.a[doubleAnimation.CreateClock()] = A_2;
			A_2.RenderTransform = new global::System.Windows.Media.TranslateTransform(0.0, 0.0);
			A_2.RenderTransform.BeginAnimation(global::System.Windows.Media.TranslateTransform.YProperty, doubleAnimation);
			return;
			IL_30:
			doubleAnimation = new global::System.Windows.Media.Animation.DoubleAnimation();
			animationDuration = this.AnimationDuration;
			num2 = (short)1355153408;
			short num4 = num2;
			num2 = (short)692649985;
			if (num2 != 0)
			{
			}
			num2 = (short)276430854;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00044288 File Offset: 0x00042488
		private void b(global::DevComponents.WpfEditors.eStateAnimationType A_0, global::System.Windows.UIElement A_1, global::System.Windows.Controls.Image A_2)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			global::System.Windows.Media.Animation.DoubleAnimation doubleAnimation;
			short num2;
			double animationDuration;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					doubleAnimation.From = new double?(0.0);
					doubleAnimation.To = new double?(-(A_1.RenderSize.Width + 1.0));
					num2 = (short)1051394051;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_F6;
				case 2:
				{
					if (A_0 == global::DevComponents.WpfEditors.eStateAnimationType.ScrollFromRightToLeft)
					{
						num2 = (short)805961728;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					doubleAnimation.From = new double?(0.0);
					doubleAnimation.To = new double?(A_1.RenderSize.Width + 1.0);
					num2 = (short)1223415452;
					short num3 = num2;
					num2 = (short)236050076;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_27A;
					default:
						num2 = (short)927793152;
						if (num2 != 0)
						{
						}
						num2 = (short)1147142148;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					goto IL_F1;
				case 4:
					goto IL_27A;
				case 5:
					num2 = (short)1643249665;
					if (num2 != 0)
					{
					}
					goto IL_F6;
				case 6:
					if (A_0 == global::DevComponents.WpfEditors.eStateAnimationType.ScrollFromRightToLeft)
					{
						num2 = (short)1796276231;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					doubleAnimation.From = new double?(-A_1.RenderSize.Width);
					doubleAnimation.To = new double?(0.0);
					num2 = (short)475660289;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					doubleAnimation.From = new double?(A_1.RenderSize.Width);
					doubleAnimation.To = new double?(0.0);
					num2 = (short)544210949;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_30;
				IL_F6:
				doubleAnimation.Completed += this.b;
				doubleAnimation.Duration = new global::System.Windows.Duration(global::System.TimeSpan.FromMilliseconds(animationDuration));
				A_1.RenderTransform.BeginAnimation(global::System.Windows.Media.TranslateTransform.XProperty, doubleAnimation);
				doubleAnimation = new global::System.Windows.Media.Animation.DoubleAnimation();
				global::DevComponents.WpfEditors.StateAnimationControl.a(doubleAnimation);
				num2 = (short)1447231490;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_F1:
			IL_27A:
			doubleAnimation.Duration = new global::System.Windows.Duration(global::System.TimeSpan.FromMilliseconds(animationDuration));
			doubleAnimation.Completed += this.a;
			this.a[doubleAnimation.CreateClock()] = A_2;
			A_2.RenderTransform = new global::System.Windows.Media.TranslateTransform(0.0, 0.0);
			A_2.RenderTransform.BeginAnimation(global::System.Windows.Media.TranslateTransform.XProperty, doubleAnimation);
			return;
			IL_30:
			doubleAnimation = new global::System.Windows.Media.Animation.DoubleAnimation();
			global::DevComponents.WpfEditors.StateAnimationControl.a(doubleAnimation);
			animationDuration = this.AnimationDuration;
			num2 = (short)731643904;
			short num4 = num2;
			num2 = (short)152633350;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000379 RID: 889 RVA: 0x000445C0 File Offset: 0x000427C0
		private static void a(global::System.Windows.Media.Animation.AnimationTimeline A_0)
		{
			short num = (short)342757077;
			short num2 = num;
			num = (short)1242828501;
			switch (num2 == num)
			{
			}
			num = (short)1781334017;
			if (num != 0)
			{
			}
			num = (short)809369600;
			if (num != 0)
			{
			}
			num = (short)522846208;
			short num3 = num;
			A_0.AccelerationRatio = 0.4;
			A_0.DecelerationRatio = 0.2;
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00044684 File Offset: 0x00042884
		private void a(global::DevComponents.WpfEditors.eStateAnimationType A_0, global::System.Windows.UIElement A_1, global::System.Windows.Controls.Image A_2)
		{
			short num = (short)1952907264;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_C2;
				}
				global::System.Windows.Media.Animation.RectAnimation rectAnimation;
				global::System.Windows.Media.Animation.DoubleAnimation doubleAnimation;
				double animationDuration;
				for (;;)
				{
					IL_29:
					num = (short)381938723;
					short num3 = num;
					num = (short)1090776099;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2A9;
					default:
					{
						num = (short)589103104;
						if (num != 0)
						{
						}
						num = (short)115146752;
						short num4 = num;
						switch (num2)
						{
						case 0:
							rectAnimation.From = new global::System.Windows.Rect?(new global::System.Windows.Rect(A_1.RenderSize));
							rectAnimation.To = new global::System.Windows.Rect?(new global::System.Windows.Rect(new global::System.Windows.Size(0.0, A_1.RenderSize.Height)));
							num = (short)2045444099;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_16B;
						case 2:
							if (A_0 == global::DevComponents.WpfEditors.eStateAnimationType.SlideFromRightToLeft)
							{
								num = (short)319094784;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							rectAnimation.From = new global::System.Windows.Rect?(new global::System.Windows.Rect(A_1.RenderSize));
							rectAnimation.To = new global::System.Windows.Rect?(new global::System.Windows.Rect(A_1.RenderSize.Width, 0.0, 0.0, A_1.RenderSize.Height));
							num = (short)946470916;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_166;
						case 4:
							goto IL_2A9;
						case 5:
							goto IL_16B;
						case 6:
							if (A_0 == global::DevComponents.WpfEditors.eStateAnimationType.SlideFromRightToLeft)
							{
								num = (short)2108620807;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1823604737;
							if (num != 0)
							{
							}
							doubleAnimation.From = new double?(-A_1.RenderSize.Width);
							doubleAnimation.To = new double?(0.0);
							num = (short)299761665;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							doubleAnimation.From = new double?(A_1.RenderSize.Width);
							doubleAnimation.To = new double?(0.0);
							num = (short)665714693;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C2;
						IL_16B:
						global::DevComponents.WpfEditors.StateAnimationControl.a(doubleAnimation);
						doubleAnimation.Completed += this.b;
						doubleAnimation.Duration = new global::System.Windows.Duration(global::System.TimeSpan.FromMilliseconds(animationDuration));
						A_1.RenderTransform.BeginAnimation(global::System.Windows.Media.TranslateTransform.XProperty, doubleAnimation);
						doubleAnimation = null;
						rectAnimation = new global::System.Windows.Media.Animation.RectAnimation();
						global::DevComponents.WpfEditors.StateAnimationControl.a(rectAnimation);
						num = (short)708837378;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				IL_166:
				IL_2A9:
				rectAnimation.Duration = new global::System.Windows.Duration(global::System.TimeSpan.FromMilliseconds(animationDuration));
				rectAnimation.Completed += this.a;
				this.a[rectAnimation.CreateClock()] = A_2;
				global::System.Windows.Media.RectangleGeometry rectangleGeometry = new global::System.Windows.Media.RectangleGeometry(new global::System.Windows.Rect(A_1.RenderSize));
				A_2.Clip = rectangleGeometry;
				A_2.RenderTransform = new global::System.Windows.Media.TranslateTransform(0.0, 0.0);
				rectangleGeometry.BeginAnimation(global::System.Windows.Media.RectangleGeometry.RectProperty, rectAnimation);
				return;
				IL_C2:
				doubleAnimation = new global::System.Windows.Media.Animation.DoubleAnimation();
				animationDuration = this.AnimationDuration;
				num = (short)570753030;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00044A28 File Offset: 0x00042C28
		private void b(object A_0, global::System.EventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			global::System.Windows.UIElement uielement;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_13D;
				case 1:
					goto IL_114;
				case 2:
					if (this.AnimationType == global::DevComponents.WpfEditors.eStateAnimationType.FadeIn)
					{
						num2 = (short)1823670273;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_9B;
				case 3:
					num2 = (short)1164247042;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (uielement.HasAnimatedProperties)
					{
						num2 = (short)546504707;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13D;
				}
				goto IL_24;
				IL_9B:
				uielement.BeginAnimation(global::System.Windows.UIElement.RenderTransformProperty, null);
				num2 = (short)1307508736;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_13D:
				num2 = (short)564862577;
				short num3 = num2;
				num2 = (short)63381105;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_9B;
				default:
					goto IL_171;
				}
			}
			IL_114:
			num2 = (short)1201537025;
			if (num2 != 0)
			{
			}
			uielement.BeginAnimation(global::System.Windows.UIElement.OpacityProperty, null);
			uielement.Opacity = 1.0;
			return;
			IL_171:
			num2 = (short)2045050880;
			if (num2 != 0)
			{
			}
			return;
			IL_24:
			num2 = (short)1400373248;
			short num4 = num2;
			uielement = base.Children[0];
			uielement.RenderTransform = null;
			num2 = (short)1939275780;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00044BBC File Offset: 0x00042DBC
		private void a(object A_0, global::System.EventArgs A_1)
		{
			short num = (short)720387887;
			short num2 = num;
			num = (short)11878191;
			switch (num2 == num)
			{
			}
			num = (short)2143158272;
			short num3 = num;
			num = (short)2001076224;
			if (num != 0)
			{
			}
			num = (short)2095710209;
			if (num != 0)
			{
			}
			global::System.Windows.Controls.Image element = this.a[A_0] as global::System.Windows.Controls.Image;
			this.a.Remove(A_0);
			base.Children.Remove(element);
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600037D RID: 893 RVA: 0x00044C90 File Offset: 0x00042E90
		public bool IsAnimating
		{
			get
			{
				short num = (short)1384393674;
				short num2 = num;
				num = (short)159067082;
				switch (num2 == num)
				{
				}
				num = (short)1002307584;
				short num3 = num;
				num = (short)1781268480;
				if (num != 0)
				{
				}
				num = (short)39518209;
				if (num != 0)
				{
				}
				return this.a.Count > 0;
			}
		}

		// Token: 0x0400019C RID: 412
		private global::System.Collections.Hashtable a = new global::System.Collections.Hashtable();

		// Token: 0x0400019D RID: 413
		private global::System.Collections.Generic.Stack<global::System.Windows.Controls.Image> b = new global::System.Collections.Generic.Stack<global::System.Windows.Controls.Image>();

		// Token: 0x0400019E RID: 414
		public static readonly global::System.Windows.DependencyProperty HorizontalContentAlignmentProperty;

		// Token: 0x0400019F RID: 415
		public static readonly global::System.Windows.DependencyProperty VerticalContentAlignmentProperty;

		// Token: 0x040001A0 RID: 416
		public static readonly global::System.Windows.DependencyProperty AnimationTypeProperty;

		// Token: 0x040001A1 RID: 417
		public static readonly global::System.Windows.DependencyProperty AnimationDurationProperty;

		// Token: 0x040001A2 RID: 418
		public static readonly global::System.Windows.DependencyProperty AnimationEnabledProperty;
	}
}
