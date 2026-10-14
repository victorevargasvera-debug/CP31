using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon
{
	// Token: 0x0200006D RID: 109
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class QatBorder : global::System.Windows.Controls.Decorator
	{
		// Token: 0x0600053A RID: 1338 RVA: 0x00071E80 File Offset: 0x00070080
		static QatBorder()
		{
			int a_ = 8;
			short num = (short)1904682389;
			short num2 = num;
			num = (short)1395991957;
			switch (num2 == num)
			{
			default:
			{
				num = (short)224722944;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1451556865;
			if (num != 0)
			{
			}
			num = (short)1077805056;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.QatBorder.BorderThicknessProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("≟ൡᙣɥ൧ᡩ㡫٭᥯ᅱέᡵᵷॹཻ", a_), typeof(global::System.Windows.Thickness), typeof(global::DevComponents.WpfRibbon.QatBorder), new global::System.Windows.FrameworkPropertyMetadata(default(global::System.Windows.Thickness), global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender), new global::System.Windows.ValidateValueCallback(global::DevComponents.WpfRibbon.QatBorder.IsThicknessValid));
			global::DevComponents.WpfRibbon.QatBorder.PaddingProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("た͡cɥŧѩ୫", a_), typeof(global::System.Windows.Thickness), typeof(global::DevComponents.WpfRibbon.QatBorder), new global::System.Windows.FrameworkPropertyMetadata(default(global::System.Windows.Thickness), global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender), new global::System.Windows.ValidateValueCallback(global::DevComponents.WpfRibbon.QatBorder.IsThicknessValid));
			global::DevComponents.WpfRibbon.QatBorder.BorderBrushProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("≟ൡᙣɥ൧ᡩ⹫ᱭկűᱳ", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfRibbon.QatBorder), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.SubPropertiesDoNotAffectRender));
			global::DevComponents.WpfRibbon.QatBorder.BackgroundProperty = global::System.Windows.Controls.Panel.BackgroundProperty.AddOwner(typeof(global::DevComponents.WpfRibbon.QatBorder), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.SubPropertiesDoNotAffectRender));
			global::DevComponents.WpfRibbon.QatBorder.LightBorderBrushProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ⱟୡͣ๥ᱧ⡩ͫᱭᑯ᝱ٳ㑵੷ཹཻᙽ", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfRibbon.QatBorder), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.SubPropertiesDoNotAffectRender));
			global::DevComponents.WpfRibbon.QatBorder.IsBorderVisibleProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⥟ᅡ♣॥ᩧ๩५ᱭ♯᭱ݳή᩷ᙹ᥻", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.QatBorder), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsParentMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsParentArrange | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::DevComponents.WpfRibbon.QatBorder.IsBackgroundVisibleProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⥟ᅡ♣ݥ୧ũ୫ᱭὯݱᩳት⹷፹ཻ᝽", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.QatBorder), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x0600053B RID: 1339 RVA: 0x000720D0 File Offset: 0x000702D0
		// (set) Token: 0x0600053C RID: 1340 RVA: 0x0007218C File Offset: 0x0007038C
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Media.Brush Background
		{
			get
			{
				short num = (short)703290964;
				short num2 = num;
				num = (short)264396372;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1359282176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1184432129;
				if (num != 0)
				{
				}
				num = (short)36700160;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfRibbon.QatBorder.BackgroundProperty);
			}
			set
			{
				short num = (short)1619290354;
				short num2 = num;
				num = (short)1324509426;
				switch (num2 == num)
				{
				default:
				{
					num = (short)80281600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1333133313;
				if (num != 0)
				{
				}
				num = (short)90243072;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.QatBorder.BackgroundProperty, value);
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x0600053D RID: 1341 RVA: 0x00072244 File Offset: 0x00070444
		// (set) Token: 0x0600053E RID: 1342 RVA: 0x00072300 File Offset: 0x00070500
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Media.Brush BorderBrush
		{
			get
			{
				short num = (short)622099593;
				short num2 = num;
				num = (short)28802185;
				switch (num2 == num)
				{
				}
				num = (short)2025783297;
				if (num != 0)
				{
				}
				num = (short)1546518528;
				if (num != 0)
				{
				}
				num = (short)1212809216;
				short num3 = num;
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfRibbon.QatBorder.BorderBrushProperty);
			}
			set
			{
				short num = (short)431378342;
				short num2 = num;
				num = (short)847990694;
				switch (num2 == num)
				{
				}
				num = (short)1403387905;
				if (num != 0)
				{
				}
				num = (short)1000865792;
				if (num != 0)
				{
				}
				num = (short)1360986112;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfRibbon.QatBorder.BorderBrushProperty, value);
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x000723B8 File Offset: 0x000705B8
		// (set) Token: 0x06000540 RID: 1344 RVA: 0x00072470 File Offset: 0x00070670
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Media.Brush LightBorderBrush
		{
			get
			{
				short num = (short)1295297081;
				short num2 = num;
				num = (short)379169337;
				switch (num2 == num)
				{
				}
				num = (short)104267777;
				if (num != 0)
				{
				}
				num = (short)1758593024;
				if (num != 0)
				{
				}
				num = (short)967180288;
				short num3 = num;
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfRibbon.QatBorder.LightBorderBrushProperty);
			}
			set
			{
				short num = (short)719268818;
				short num2 = num;
				num = (short)2037197778;
				switch (num2 == num)
				{
				}
				num = (short)1078788097;
				if (num != 0)
				{
				}
				num = (short)1444282368;
				if (num != 0)
				{
				}
				num = (short)1294991360;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfRibbon.QatBorder.LightBorderBrushProperty, value);
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x00072524 File Offset: 0x00070724
		// (set) Token: 0x06000542 RID: 1346 RVA: 0x000725E0 File Offset: 0x000707E0
		public global::System.Windows.Thickness BorderThickness
		{
			get
			{
				short num = (short)591996381;
				short num2 = num;
				num = (short)1647257053;
				switch (num2 == num)
				{
				}
				num = (short)611123201;
				if (num != 0)
				{
				}
				num = (short)1771241472;
				if (num != 0)
				{
				}
				num = (short)104464384;
				short num3 = num;
				return (global::System.Windows.Thickness)base.GetValue(global::DevComponents.WpfRibbon.QatBorder.BorderThicknessProperty);
			}
			set
			{
				short num = (short)83230721;
				if (num != 0)
				{
				}
				num = (short)281942421;
				short num2 = num;
				num = (short)2122586517;
				switch (num2 == num)
				{
				}
				num = (short)1245052928;
				if (num != 0)
				{
				}
				num = (short)319094784;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfRibbon.QatBorder.BorderThicknessProperty, value);
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x0007269C File Offset: 0x0007089C
		// (set) Token: 0x06000544 RID: 1348 RVA: 0x00072758 File Offset: 0x00070958
		public global::System.Windows.Thickness Padding
		{
			get
			{
				short num = (short)1566182112;
				short num2 = num;
				num = (short)1460800224;
				switch (num2 == num)
				{
				}
				num = (short)688455681;
				if (num != 0)
				{
				}
				num = (short)1126432768;
				if (num != 0)
				{
				}
				num = (short)1062338560;
				short num3 = num;
				return (global::System.Windows.Thickness)base.GetValue(global::DevComponents.WpfRibbon.QatBorder.PaddingProperty);
			}
			set
			{
				short num = (short)1205517141;
				short num2 = num;
				num = (short)974830421;
				switch (num2 == num)
				{
				}
				num = (short)1528561665;
				if (num != 0)
				{
				}
				num = (short)2068447232;
				if (num != 0)
				{
				}
				num = (short)646840320;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfRibbon.QatBorder.PaddingProperty, value);
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x00072810 File Offset: 0x00070A10
		// (set) Token: 0x06000546 RID: 1350 RVA: 0x000728CC File Offset: 0x00070ACC
		[global::System.ComponentModel.DefaultValue(true)]
		public bool IsBorderVisible
		{
			get
			{
				short num = (short)953736659;
				short num2 = num;
				num = (short)141549011;
				switch (num2 == num)
				{
				}
				num = (short)1481113601;
				if (num != 0)
				{
				}
				num = (short)2025783296;
				if (num != 0)
				{
				}
				num = (short)1504772096;
				short num3 = num;
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.QatBorder.IsBorderVisibleProperty);
			}
			set
			{
				short num = (short)76971763;
				short num2 = num;
				num = (short)1477345011;
				switch (num2 == num)
				{
				}
				num = (short)622723072;
				if (num != 0)
				{
				}
				num = (short)1371668481;
				if (num != 0)
				{
				}
				num = (short)1305608192;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfRibbon.QatBorder.IsBorderVisibleProperty, value);
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x00072988 File Offset: 0x00070B88
		// (set) Token: 0x06000548 RID: 1352 RVA: 0x00072A44 File Offset: 0x00070C44
		[global::System.ComponentModel.DefaultValue(true)]
		public bool IsBackgroundVisible
		{
			get
			{
				short num = (short)1108122958;
				short num2 = num;
				num = (short)1353424206;
				switch (num2 == num)
				{
				}
				num = (short)1414004736;
				if (num != 0)
				{
				}
				num = (short)645726209;
				if (num != 0)
				{
				}
				num = (short)577175552;
				short num3 = num;
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.QatBorder.IsBackgroundVisibleProperty);
			}
			set
			{
				short num = (short)1489043457;
				if (num != 0)
				{
				}
				num = (short)2006877792;
				short num2 = num;
				num = (short)453543520;
				switch (num2 == num)
				{
				}
				num = (short)1851457536;
				if (num != 0)
				{
				}
				num = (short)1487929344;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfRibbon.QatBorder.IsBackgroundVisibleProperty, value);
			}
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00072B04 File Offset: 0x00070D04
		private static bool IsThicknessValid(object value)
		{
			switch (0)
			{
			case 0:
				goto IL_90;
			}
			int num;
			short num2;
			global::System.Windows.Thickness thickness;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)676921371;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (double.IsNaN(thickness.Bottom))
					{
						goto IL_3A7;
					}
					num2 = (short)1753153555;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)2030632981;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (!double.IsNegativeInfinity(thickness.Top))
					{
						num2 = (short)975699993;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 4:
					num2 = (short)528220163;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (thickness.Top >= 0.0)
					{
						num2 = (short)33161247;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 6:
					return false;
				case 7:
					num2 = (short)678232080;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (!double.IsNegativeInfinity(thickness.Left))
					{
						num2 = (short)1337458697;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 9:
				{
					num2 = (short)90958859;
					short num3 = num2;
					num2 = (short)1501162507;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3A7;
					default:
						num2 = (short)780861440;
						if (num2 != 0)
						{
						}
						num2 = (short)1722089495;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 10:
					if (!double.IsNaN(thickness.Left))
					{
						num2 = (short)764870682;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 11:
					if (!double.IsNaN(thickness.Top))
					{
						num2 = (short)1385758749;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 12:
					goto IL_263;
				case 13:
					if (thickness.Left >= 0.0)
					{
						num2 = (short)2089156610;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 14:
					if (!double.IsNaN(thickness.Right))
					{
						num2 = (short)1998389265;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 15:
				{
					num2 = (short)486866944;
					short num4 = num2;
					if (!double.IsPositiveInfinity(thickness.Right))
					{
						num2 = (short)734920704;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 16:
					if (double.IsPositiveInfinity(thickness.Bottom))
					{
						num2 = (short)1398407180;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1101201416;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
					num2 = (short)1830223883;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
					if (thickness.Bottom >= 0.0)
					{
						num2 = (short)1082064920;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 19:
					if (!double.IsPositiveInfinity(thickness.Left))
					{
						num2 = (short)599261206;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 20:
					return true;
				case 21:
					if (thickness.Right >= 0.0)
					{
						num2 = (short)836763678;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 22:
					num2 = (short)401080335;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 23:
					if (!double.IsNegativeInfinity(thickness.Right))
					{
						num2 = (short)1668481028;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 24:
					num2 = (short)1193607178;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 25:
					num2 = (short)1039597596;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 26:
					num2 = (short)342622222;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 27:
					if (!double.IsPositiveInfinity(thickness.Top))
					{
						num2 = (short)1457061895;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 28:
					if (!double.IsNegativeInfinity(thickness.Bottom))
					{
						num2 = (short)1592459284;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 29:
					num2 = (short)29753345;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 30:
					num2 = (short)1286733825;
					if (num2 != 0)
					{
					}
					num2 = (short)41353221;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 31:
					num2 = (short)748158994;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_90;
				IL_3A7:
				num2 = (short)979173382;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_263:
			return false;
			IL_90:
			thickness = (global::System.Windows.Thickness)value;
			num2 = (short)255852557;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x0600054A RID: 1354 RVA: 0x000730AC File Offset: 0x000712AC
		private bool RendersBorder
		{
			get
			{
				short num = (short)72810500;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::DevComponents.WpfRibbon.QatPanel qatPanel;
					switch (num2)
					{
					case 0:
					{
						num = (short)225580505;
						short num3 = num;
						num = (short)520820185;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_74;
						default:
							num = (short)1116078080;
							if (num != 0)
							{
							}
							qatPanel = (this.Child as global::DevComponents.WpfRibbon.QatPanel);
							num = (short)695926789;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						num = (short)1649606658;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_74;
					case 3:
						return false;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_3C;
						}
						continue;
					case 5:
						if (qatPanel != null)
						{
							num = (short)1391394817;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_14E;
					}
					IL_3C:
					if (this.IsBorderVisible)
					{
						num = (short)1618739200;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_14E;
					IL_74:
					num = (short)1595277312;
					short num4 = num;
					if (!qatPanel.HasOnlyCustomizeItem)
					{
						goto IL_14E;
					}
					num = (short)434176003;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_14E:
				num = (short)431751169;
				if (num != 0)
				{
				}
				return this.IsBorderVisible;
			}
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00073234 File Offset: 0x00071434
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
		{
			short num = (short)1536098305;
			if (num != 0)
			{
			}
			num = (short)592838656;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_68;
				}
				global::System.Windows.Size thicknessSize;
				global::System.Windows.Size thicknessSize2;
				global::System.Windows.UIElement child;
				for (;;)
				{
					IL_51:
					switch (num2)
					{
					case 0:
						goto IL_218;
					case 1:
						goto IL_11B;
					case 2:
						while (!this.RendersBorder)
						{
							num = (short)196673536;
							short num3 = num;
							num = (short)1469359218;
							short num4 = num;
							num = (short)348234866;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)1114898432;
								if (num != 0)
								{
								}
								num = (short)1440677889;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_51;
							}
						}
						thicknessSize = global::DevComponents.WpfRibbon.QatBorder.GetThicknessSize(this.BorderThickness);
						thicknessSize2 = global::DevComponents.WpfRibbon.QatBorder.GetThicknessSize(this.Padding);
						num = (short)1255079939;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (child != null)
						{
							num = (short)1227685888;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22B;
					}
					goto IL_68;
				}
				IL_11B:
				child.Measure(constraint);
				return child.DesiredSize;
				IL_218:
				global::System.Windows.Size result = new global::System.Windows.Size(thicknessSize2.Width + 12.0 + 2.0, thicknessSize2.Height);
				global::System.Windows.Size availableSize = new global::System.Windows.Size(global::System.Math.Max(0.0, constraint.Width - result.Width), global::System.Math.Max(0.0, constraint.Height - result.Height));
				child.Measure(availableSize);
				global::System.Windows.Size desiredSize = child.DesiredSize;
				result.Width = desiredSize.Width + result.Width;
				result.Height = desiredSize.Height + result.Height;
				return result;
				IL_22B:
				return new global::System.Windows.Size(thicknessSize.Width + thicknessSize2.Width, thicknessSize.Height + thicknessSize2.Height);
				IL_68:
				child = this.Child;
				num = (short)426639362;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_51;
			}
			}
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00073490 File Offset: 0x00071690
		private global::DevComponents.WpfRibbon.QatCustomizeButton GetQatCustomizeButton()
		{
			short num = (short)154206212;
			int num2 = (int)((global::System.IntPtr)num);
			int num3;
			global::DevComponents.WpfRibbon.QatPanel qatPanel;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1294991361;
					if (num != 0)
					{
					}
					goto IL_FD;
				case 1:
					if (num3 < 0)
					{
						num = (short)211877888;
						short num4 = num;
						num = (short)1079377923;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1058865158;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_FD;
				case 3:
					goto IL_1A4;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_4E;
					}
					continue;
				case 5:
					if (qatPanel.Children[num3].Visibility != global::System.Windows.Visibility.Visible)
					{
						num = (short)1064697863;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_239;
				case 6:
					if (qatPanel.Children[num3] is global::DevComponents.WpfRibbon.QatCustomizeButton)
					{
						num = (short)1856897033;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1948778501;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					num3--;
					num = (short)1108475906;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					qatPanel = (this.Child as global::DevComponents.WpfRibbon.QatPanel);
					num3 = qatPanel.Children.Count - 1;
					num = (short)721682432;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_1ED;
				}
				IL_4E:
				if (this.Child is global::DevComponents.WpfRibbon.QatPanel)
				{
					num = (short)1178927112;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_239;
				IL_FD:
				num = (short)1352859991;
				short num5 = num;
				num = (short)606470487;
				switch ((num5 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_8F;
				default:
					num = (short)407961600;
					if (num != 0)
					{
					}
					num = (short)775553025;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_8F:
			return qatPanel.Children[num3] as global::DevComponents.WpfRibbon.QatCustomizeButton;
			IL_1A4:
			goto IL_239;
			IL_1ED:
			goto IL_8F;
			IL_239:
			return null;
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x000736D8 File Offset: 0x000718D8
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			short num = (short)1863778304;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_A7;
				}
				global::System.Windows.UIElement child;
				for (;;)
				{
					IL_28:
					global::DevComponents.WpfRibbon.QatCustomizeButton qatCustomizeButton;
					switch (num2)
					{
					case 0:
					{
						this.m_BackgroundGeometry = new global::System.Windows.Media.StreamGeometry();
						global::System.Windows.Media.StreamGeometryContext streamGeometryContext = this.m_BackgroundGeometry.Open();
						num = (short)2053046289;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						global::System.Windows.Rect rect;
						if (!global::DevComponents.WpfRibbon.QatBorder.IsZero(rect.Width))
						{
							num = (short)1160118275;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_88B;
					}
					case 2:
						goto IL_633;
					case 3:
						num = (short)1835073555;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_3CC;
					case 5:
						if (this.LightBorderBrush != null)
						{
							num = (short)906428432;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.m_LightBorderGeometry = null;
						num = (short)1279655949;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						global::System.Windows.Rect rect2;
						if (!global::DevComponents.WpfRibbon.QatBorder.IsZero(rect2.Width))
						{
							num = (short)553648137;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_45F;
					}
					case 7:
					{
						global::System.Windows.Rect rect2;
						if (!global::DevComponents.WpfRibbon.QatBorder.IsZero(rect2.Height))
						{
							num = (short)189923328;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_45F;
					}
					case 8:
						if (child != null)
						{
							num = (short)255262731;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return finalSize;
					case 9:
						num = (short)440467463;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						if (!this.RendersBorder)
						{
							num = (short)1769013262;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.Thickness borderThickness = this.BorderThickness;
						global::System.Windows.Rect rect = new global::System.Windows.Rect(finalSize);
						global::System.Windows.Rect rect2 = global::DevComponents.WpfRibbon.QatBorder.DeflateRect(rect, borderThickness);
						rect2.Inflate(0.0, -1.0);
						rect2.X += 0.5;
						rect2.Width -= 0.5;
						num = (short)1306787865;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						child.Arrange(new global::System.Windows.Rect(finalSize));
						num = (short)1035927579;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_4DC;
					case 13:
						goto IL_4DC;
					case 14:
						goto IL_599;
					case 15:
						goto IL_169;
					case 16:
					{
						this.m_LightBorderGeometry = new global::System.Windows.Media.StreamGeometry();
						global::System.Windows.Media.StreamGeometryContext streamGeometryContext2 = this.m_LightBorderGeometry.Open();
						num = (short)1268187160;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						try
						{
							global::System.Windows.Media.StreamGeometryContext streamGeometryContext;
							global::System.Windows.Rect rect2;
							global::DevComponents.WpfRibbon.QatBorder.CreateGeometry(streamGeometryContext, rect2);
							goto IL_70F;
						}
						finally
						{
							num = (short)1424621570;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Windows.Media.StreamGeometryContext streamGeometryContext;
								switch (num2)
								{
								case 0:
									goto IL_596;
								case 1:
									((global::System.IDisposable)streamGeometryContext).Dispose();
									num = (short)1137967104;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_55F;
									}
									continue;
								}
								IL_55F:
								if (streamGeometryContext == null)
								{
									break;
								}
								num = (short)1797980161;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_596:;
						}
						goto IL_599;
						IL_70F:
						this.m_BackgroundGeometry.Freeze();
						num = (short)1235419165;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
					{
						global::System.Windows.Rect rect2;
						rect2.Width -= qatCustomizeButton.DesiredSize.Width;
						global::System.Windows.Rect rect;
						rect.Width -= qatCustomizeButton.DesiredSize.Width;
						num = (short)1728708610;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
					{
						global::System.Windows.Rect rect;
						if (!global::DevComponents.WpfRibbon.QatBorder.IsZero(rect.Height))
						{
							num = (short)1340866583;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_88B;
					}
					case 20:
					{
						int num3 = 7;
						global::System.Windows.Rect rect;
						global::System.Windows.Rect r = new global::System.Windows.Rect(rect.X + (double)num3, rect.Y, rect.Width - (double)num3, rect.Height);
						child.Arrange(global::DevComponents.WpfRibbon.QatBorder.DeflateRect(r, this.Padding));
						num = (short)799277071;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						goto IL_123;
					case 22:
					{
						global::System.Windows.Rect rect;
						if (!rect.IsEmpty)
						{
							num = (short)513998874;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_88B;
					}
					case 23:
						num = (short)753467414;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
					{
						global::System.Windows.Rect rect;
						try
						{
							num = (short)661061633;
							if (num != 0)
							{
							}
							global::System.Windows.Rect rect3 = rect;
							double num4 = rect3.Y;
							rect3.Y = num4 + 1.0;
							num4 = rect3.Height;
							rect3.Height = num4 - 1.0;
							num4 = rect3.X;
							rect3.X = num4 - 1.0;
							rect3.Width += 1.5;
							global::System.Windows.Media.StreamGeometryContext streamGeometryContext2;
							global::DevComponents.WpfRibbon.QatBorder.CreateGeometry(streamGeometryContext2, rect3);
							goto IL_6CD;
						}
						finally
						{
							num = (short)583729154;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Windows.Media.StreamGeometryContext streamGeometryContext2;
								switch (num2)
								{
								case 0:
									goto IL_3C9;
								case 1:
									for (;;)
									{
										num = (short)724319596;
										short num5 = num;
										num = (short)735722860;
										switch ((num5 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											goto IL_395;
										}
									}
									IL_395:
									num = (short)1182793728;
									if (num != 0)
									{
									}
									((global::System.IDisposable)streamGeometryContext2).Dispose();
									num = (short)1578631168;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_342;
									}
									continue;
								}
								IL_342:
								if (streamGeometryContext2 == null)
								{
									break;
								}
								num = (short)2061238273;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3C9:;
						}
						goto Block_6;
						IL_6CD:
						this.m_LightBorderGeometry.Freeze();
						rect.Inflate(0.0, -1.0);
						num = (short)752484364;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
						if (child != null)
						{
							num = (short)806813716;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_169;
					case 26:
						num = (short)73007109;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						goto IL_800;
					case 28:
						if (qatCustomizeButton != null)
						{
							num = (short)707067922;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_633;
					case 29:
					{
						num = (short)159121408;
						short num6 = num;
						goto IL_123;
					}
					}
					goto IL_A7;
					IL_123:
					num = (short)1860435969;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_169:
					qatCustomizeButton = this.GetQatCustomizeButton();
					num = (short)1492779036;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_45F:
					this.m_BackgroundGeometry = null;
					num = (short)1941110805;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_6:
					global::System.Windows.Media.StreamGeometryContext streamGeometryContext3;
					try
					{
						IL_3CC:
						global::System.Windows.Rect rect;
						rect.Inflate(-0.5, -0.5);
						global::DevComponents.WpfRibbon.QatBorder.CreateGeometry(streamGeometryContext3, rect);
						break;
					}
					finally
					{
						num = (short)792199170;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_45C;
							case 1:
								((global::System.IDisposable)streamGeometryContext3).Dispose();
								num = (short)1753546752;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_425;
								}
								continue;
							}
							IL_425:
							if (streamGeometryContext3 == null)
							{
								break;
							}
							num = (short)1393491969;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_45C:;
					}
					goto IL_45F;
					IL_4DC:
					this.m_BorderGeometry = new global::System.Windows.Media.StreamGeometry();
					streamGeometryContext3 = this.m_BorderGeometry.Open();
					num = (short)559153156;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_599:
					num = (short)415629320;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_633:
					global::System.Windows.Media.Brush borderBrush = this.BorderBrush;
					global::System.Windows.Media.Brush lightBorderBrush = this.LightBorderBrush;
					num = (short)829161478;
					num2 = (int)((global::System.IntPtr)num);
				}
				this.m_BorderGeometry.Freeze();
				return finalSize;
				IL_800:
				return finalSize;
				IL_88B:
				this.m_BackgroundGeometry = null;
				this.m_BorderGeometry = null;
				return finalSize;
				IL_A7:
				child = this.Child;
				num = (short)1758199818;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00073FA8 File Offset: 0x000721A8
		protected override void OnRender(global::System.Windows.Media.DrawingContext dc)
		{
			short num = (short)52232207;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)150929410;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)974385409;
					short num3 = num;
					num = (short)579596545;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_30E;
					default:
						num = (short)771031040;
						if (num != 0)
						{
						}
						if (this.IsBackgroundVisible)
						{
							num = (short)565903360;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F7;
					}
					break;
				}
				case 2:
					if (this.m_LightBorderGeometry != null)
					{
						num = (short)549126156;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_337;
				case 3:
					if (((global::DevComponents.WpfRibbon.QatPanel)this.Child).IsCompleteOverflow)
					{
						num = (short)427884558;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_270;
				case 4:
					dc.DrawGeometry(this.LightBorderBrush, null, this.m_LightBorderGeometry);
					num = (short)713228293;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_337;
				case 6:
					if (this.Background != null)
					{
						num = (short)1796931600;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2F7;
				case 7:
					goto IL_30E;
				case 8:
					num = (short)1296236550;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (this.LightBorderBrush != null)
					{
						num = (short)979304452;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_337;
				case 10:
					if (this.m_BackgroundGeometry != null)
					{
						num = (short)199884808;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2F7;
				case 11:
					num = (short)103219213;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					num = (short)1308033025;
					if (num != 0)
					{
					}
					num = (short)1607270409;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					if (this.BorderBrush != null)
					{
						num = (short)101056531;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 14:
					goto IL_187;
				case 15:
					switch (0)
					{
					case 0:
						goto IL_82;
					}
					continue;
				case 16:
					dc.DrawGeometry(this.Background, null, this.m_BackgroundGeometry);
					num = (short)1831206934;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					num = (short)227409923;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					return;
				case 19:
					dc.DrawGeometry(null, new global::System.Windows.Media.Pen(this.BorderBrush, 1.0), this.m_BorderGeometry);
					num = (short)442499090;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					num = (short)1656946709;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					if (this.Child is global::DevComponents.WpfRibbon.QatPanel)
					{
						num = (short)1106771968;
						short num4 = num;
						num = (short)577830929;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_270;
				case 22:
					goto IL_2F7;
				}
				IL_82:
				if (this.RendersBorder)
				{
					num = (short)1945829396;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_270:
				num = (short)696188929;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2F7:
				num = (short)172621831;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_30E:
				if (this.m_BorderGeometry != null)
				{
					num = (short)496697355;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_337:
				num = (short)514195466;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_187:;
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x000743D8 File Offset: 0x000725D8
		private static void CreateGeometry(global::System.Windows.Media.StreamGeometryContext ctx, global::System.Windows.Rect rect)
		{
			short num = (short)1607139329;
			if (num != 0)
			{
			}
			num = (short)1427767296;
			short num2 = num;
			num = (short)1650770132;
			short num3 = num;
			num = (short)2050408660;
			switch (num3 == num)
			{
			}
			num = (short)1442643968;
			if (num != 0)
			{
			}
			ctx.BeginFigure(rect.Location, true, true);
			ctx.BezierTo(rect.Location, new global::System.Windows.Point(rect.X + 10.0, rect.Y + 2.0), new global::System.Windows.Point(rect.X + 12.0, rect.Bottom - 5.0), true, true);
			ctx.LineTo(new global::System.Windows.Point(rect.X + 12.0, rect.Bottom), true, true);
			ctx.LineTo(new global::System.Windows.Point(rect.Right - 9.0, rect.Bottom), true, true);
			ctx.ArcTo(new global::System.Windows.Point(rect.Right - 9.0, rect.Y), new global::System.Windows.Size(52.0, rect.Height), 0.0, false, global::System.Windows.Media.SweepDirection.Counterclockwise, true, true);
			ctx.LineTo(rect.Location, true, true);
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x0007458C File Offset: 0x0007278C
		private static global::System.Windows.Rect DeflateRect(global::System.Windows.Rect r, global::System.Windows.Thickness thick)
		{
			short num = (short)2114858430;
			short num2 = num;
			num = (short)1162161598;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1110441984;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1613824001;
			if (num != 0)
			{
			}
			num = (short)1953300480;
			if (num != 0)
			{
			}
			return new global::System.Windows.Rect(r.Left + thick.Left, r.Top + thick.Top, global::System.Math.Max(0.0, r.Width - thick.Left - thick.Right), global::System.Math.Max(0.0, r.Height - thick.Top - thick.Bottom));
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x000746A4 File Offset: 0x000728A4
		private static global::System.Windows.Size GetThicknessSize(global::System.Windows.Thickness t)
		{
			short num = (short)1294917965;
			short num2 = num;
			num = (short)1417208141;
			switch (num2 == num)
			{
			default:
			{
				num = (short)888471552;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)927793153;
			if (num != 0)
			{
			}
			num = (short)1032192000;
			if (num != 0)
			{
			}
			return new global::System.Windows.Size(t.Left + t.Right, t.Top + t.Bottom);
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00074770 File Offset: 0x00072970
		private static bool IsZero(double value)
		{
			short num = (short)176257032;
			short num2 = num;
			num = (short)1845852168;
			switch (num2 == num)
			{
			default:
			{
				num = (short)71106560;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)672727041;
			if (num != 0)
			{
			}
			num = (short)2023358464;
			if (num != 0)
			{
			}
			return global::System.Math.Abs(value) < 2.220446049250313E-15;
		}

		// Token: 0x0400029E RID: 670
		public static readonly global::System.Windows.DependencyProperty BackgroundProperty;

		// Token: 0x0400029F RID: 671
		public static readonly global::System.Windows.DependencyProperty BorderBrushProperty;

		// Token: 0x040002A0 RID: 672
		public static readonly global::System.Windows.DependencyProperty BorderThicknessProperty;

		// Token: 0x040002A1 RID: 673
		public static readonly global::System.Windows.DependencyProperty LightBorderBrushProperty;

		// Token: 0x040002A2 RID: 674
		public static readonly global::System.Windows.DependencyProperty PaddingProperty;

		// Token: 0x040002A3 RID: 675
		public static readonly global::System.Windows.DependencyProperty IsBorderVisibleProperty;

		// Token: 0x040002A4 RID: 676
		public static readonly global::System.Windows.DependencyProperty IsBackgroundVisibleProperty;

		// Token: 0x040002A5 RID: 677
		private global::System.Windows.Media.StreamGeometry m_BackgroundGeometry;

		// Token: 0x040002A6 RID: 678
		private global::System.Windows.Media.StreamGeometry m_BorderGeometry;

		// Token: 0x040002A7 RID: 679
		private global::System.Windows.Media.StreamGeometry m_LightBorderGeometry;

		// Token: 0x040002A8 RID: 680
		private const int ArcWidth = 12;
	}
}
