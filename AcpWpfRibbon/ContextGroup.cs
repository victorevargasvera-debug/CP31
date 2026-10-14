using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Effects;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon
{
	// Token: 0x02000026 RID: 38
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class ContextGroup : global::System.Windows.Controls.ContentControl
	{
		// Token: 0x060002BD RID: 701 RVA: 0x0003E390 File Offset: 0x0003C590
		static ContextGroup()
		{
			int a_ = 4;
			short num = (short)1322871435;
			short num2 = num;
			num = (short)1245670027;
			switch (num2 == num)
			{
			}
			num = (short)928579585;
			if (num != 0)
			{
			}
			num = (short)866385920;
			short num3 = num;
			num = (short)1927348224;
			if (num != 0)
			{
			}
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfRibbon.ContextGroup), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfRibbon.ContextGroup)));
			global::DevComponents.WpfRibbon.ContextGroup.StockColorProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ཛ⩝ཟšལ╥ݧ٩ͫᱭ", a_), typeof(global::DevComponents.WpfRibbon.eContextGroupColor), typeof(global::DevComponents.WpfRibbon.ContextGroup), new global::System.Windows.FrameworkPropertyMetadata(global::DevComponents.WpfRibbon.eContextGroupColor.Orange, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.ContextGroup.OnStockColorChanged)));
			global::DevComponents.WpfRibbon.ContextGroup.IsSimpleContentPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᕛⵝ㍟ୡॣᙥѧཀྵ⽫ŭṯٱᅳᡵ౷", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.ContextGroup), new global::System.Windows.FrameworkPropertyMetadata(false));
			global::DevComponents.WpfRibbon.ContextGroup.IsSimpleContentProperty = global::DevComponents.WpfRibbon.ContextGroup.IsSimpleContentPropertyKey.DependencyProperty;
		}

		// Token: 0x060002BE RID: 702 RVA: 0x0003E4F0 File Offset: 0x0003C6F0
		public ContextGroup()
		{
			this.m_LinkedTabs = new global::System.Collections.ObjectModel.ObservableCollection<global::DevComponents.WpfRibbon.RibbonTab>();
		}

		// Token: 0x060002BF RID: 703 RVA: 0x0003E510 File Offset: 0x0003C710
		public override void OnApplyTemplate()
		{
			int a_ = 15;
			short num = (short)1428141864;
			short num2 = num;
			num = (short)1301526312;
			switch (num2 == num)
			{
			}
			num = (short)1254162433;
			if (num != 0)
			{
			}
			num = (short)1992425472;
			short num3 = num;
			num = (short)1723596800;
			if (num != 0)
			{
			}
			this.m_ContentLabel = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㝦⡨㥪㥬の㵰ቲ᝴ቶᕸ㡺ቼᅾ", a_)) as global::System.Windows.Controls.Label);
			this.UpdateLabelGlassEffect();
			base.OnApplyTemplate();
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x0003E5F0 File Offset: 0x0003C7F0
		// (set) Token: 0x060002C1 RID: 705 RVA: 0x0003E824 File Offset: 0x0003CA24
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Windows.Visibility TabsVisibility
		{
			get
			{
				short num = (short)148373505;
				if (num != 0)
				{
				}
				num = (short)1911881728;
				short num2 = num;
				global::System.Collections.Generic.IEnumerator<global::DevComponents.WpfRibbon.RibbonTab> enumerator = this.m_LinkedTabs.GetEnumerator();
				global::System.Windows.Visibility result;
				try
				{
					num = (short)164560898;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_17C;
						case 1:
							result = global::System.Windows.Visibility.Visible;
							num = (short)1845624832;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_A1;
							}
							continue;
						case 3:
							if (enumerator.Current.Visibility == global::System.Windows.Visibility.Visible)
							{
								num = (short)811780060;
								short num4 = num;
								num = (short)1262208988;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_181;
								default:
									num = (short)383123456;
									if (num != 0)
									{
									}
									num = (short)149487617;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
							}
							break;
						case 4:
							goto IL_181;
						case 5:
							goto IL_199;
						case 6:
							if (!enumerator.MoveNext())
							{
								num = (short)931594244;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)704446467;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_A3:
						num = (short)340328454;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_A1:
						goto IL_A3;
						IL_181:
						num = (short)491323397;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_17C:
					return result;
					IL_199:
					return global::System.Windows.Visibility.Collapsed;
				}
				finally
				{
					num = (short)715653122;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1509228545;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_204;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_1CF;
							}
							continue;
						}
						IL_1CF:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1208025088;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_204:;
				}
				return result;
			}
			set
			{
				global::System.Collections.Generic.IEnumerator<global::DevComponents.WpfRibbon.RibbonTab> enumerator = this.m_LinkedTabs.GetEnumerator();
				short num;
				try
				{
					num = (short)1829502979;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							num = (short)1722286082;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)2047737856;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							enumerator.Current.Visibility = value;
							num = (short)1589492668;
							short num3 = num;
							num = (short)504085436;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)292814848;
								if (num != 0)
								{
								}
								num = (short)102760452;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							goto IL_10C;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_47;
							}
							continue;
						}
						IL_BA:
						num = (short)1985150977;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_47:
						goto IL_BA;
					}
					IL_10C:;
				}
				finally
				{
					num = (short)344522754;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							enumerator.Dispose();
							num = (short)707592193;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_19D;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_142;
							}
							continue;
						}
						IL_142:
						if (enumerator == null)
						{
							break;
						}
						num = (short)2061828097;
						if (num != 0)
						{
						}
						num = (short)1791229952;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_19D:;
				}
				num = (short)417595392;
				short num4 = num;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x0003EA18 File Offset: 0x0003CC18
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Collections.ObjectModel.ObservableCollection<global::DevComponents.WpfRibbon.RibbonTab> LinkedTabs
		{
			get
			{
				short num = (short)714030790;
				short num2 = num;
				num = (short)1563573958;
				switch (num2 == num)
				{
				}
				num = (short)1068302337;
				if (num != 0)
				{
				}
				num = (short)881131520;
				short num3 = num;
				num = (short)667811840;
				if (num != 0)
				{
				}
				return this.m_LinkedTabs;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x0003EAC8 File Offset: 0x0003CCC8
		internal bool IsOneTabVisible
		{
			get
			{
				short num = (short)1630273537;
				if (num != 0)
				{
				}
				num = (short)910753792;
				short num2 = num;
				global::System.Collections.Generic.IEnumerator<global::DevComponents.WpfRibbon.RibbonTab> enumerator = this.m_LinkedTabs.GetEnumerator();
				bool result;
				try
				{
					num = (short)986054658;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_17A;
						case 1:
							result = true;
							num = (short)146800640;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_A1;
							}
							continue;
						case 3:
							if (enumerator.Current.Visibility == global::System.Windows.Visibility.Visible)
							{
								num = (short)346790581;
								short num4 = num;
								num = (short)1861786293;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_17F;
								default:
									num = (short)1975189504;
									if (num != 0)
									{
									}
									num = (short)684457985;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
							}
							break;
						case 4:
							goto IL_17F;
						case 5:
							goto IL_196;
						case 6:
							if (!enumerator.MoveNext())
							{
								num = (short)1682636804;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1554055171;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_A3:
						num = (short)1351680006;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_A1:
						goto IL_A3;
						IL_17F:
						num = (short)1107689477;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_17A:
					return result;
					IL_196:
					return false;
				}
				finally
				{
					num = (short)998309890;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)141033473;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_1FF;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_1CB;
							}
							continue;
						}
						IL_1CB:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1549729792;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_1FF:;
				}
				return result;
			}
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0003ECF4 File Offset: 0x0003CEF4
		private static void OnStockColorChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)2070809716;
			short num2 = num;
			num = (short)414780532;
			switch (num2 == num)
			{
			}
			num = (short)1767309313;
			if (num != 0)
			{
			}
			num = (short)1980497920;
			short num3 = num;
			num = (short)1609105408;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfRibbon.ContextGroup)d).OnStockColorChanged((global::DevComponents.WpfRibbon.eContextGroupColor)e.NewValue);
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0003EDB4 File Offset: 0x0003CFB4
		private void OnStockColorChanged(global::DevComponents.WpfRibbon.eContextGroupColor c)
		{
			short num = (short)1363071112;
			short num2 = num;
			num = (short)1251397768;
			switch (num2 == num)
			{
			}
			num = (short)536281088;
			if (num != 0)
			{
			}
			num = (short)2112552960;
			short num3 = num;
			num = (short)887226369;
			if (num != 0)
			{
			}
			this.ApplyNewStockColor(c);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0003EE64 File Offset: 0x0003D064
		private void ApplyNewStockColor(global::DevComponents.WpfRibbon.eContextGroupColor c)
		{
			short num = (short)1084948481;
			if (num != 0)
			{
			}
			num = (short)2080773462;
			short num2 = num;
			num = (short)1859851606;
			switch (num2 == num)
			{
			}
			num = (short)1492844544;
			short num3 = num;
			num = (short)1516961792;
			if (num != 0)
			{
			}
			string str = global::DevComponents.WpfRibbon.RibbonColors.ContextGroupClass + c.ToString();
			base.SetResourceReference(global::System.Windows.Controls.Control.BackgroundProperty, new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.Ribbon), str + global::DevComponents.WpfRibbon.ContextGroupPartColorKeys.Background));
			base.SetResourceReference(global::System.Windows.Controls.Control.BorderBrushProperty, new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.Ribbon), str + global::DevComponents.WpfRibbon.ContextGroupPartColorKeys.Border));
			this.UpdateStockForegroundColor();
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0003EF78 File Offset: 0x0003D178
		private void UpdateStockForegroundColor()
		{
			short num = (short)112790047;
			short num2 = num;
			num = (short)224791071;
			switch (num2 == num)
			{
			}
			num = (short)482607105;
			if (num != 0)
			{
			}
			num = (short)777715712;
			short num3 = num;
			num = (short)518127616;
			if (num != 0)
			{
			}
			string str = global::DevComponents.WpfRibbon.RibbonColors.ContextGroupClass + this.StockColor.ToString();
			base.SetResourceReference(global::System.Windows.Controls.Control.ForegroundProperty, new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.Ribbon), str + global::DevComponents.WpfRibbon.ContextGroupPartColorKeys.Foreground));
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x0003F064 File Offset: 0x0003D264
		// (set) Token: 0x060002C9 RID: 713 RVA: 0x0003F120 File Offset: 0x0003D320
		[global::System.ComponentModel.DefaultValue(global::DevComponents.WpfRibbon.eContextGroupColor.Orange)]
		public global::DevComponents.WpfRibbon.eContextGroupColor StockColor
		{
			get
			{
				short num = (short)112039232;
				short num2 = num;
				num = (short)23106880;
				switch (num2 == num)
				{
				}
				num = (short)677904385;
				if (num != 0)
				{
				}
				num = (short)1014628352;
				short num3 = num;
				num = (short)2007236608;
				if (num != 0)
				{
				}
				return (global::DevComponents.WpfRibbon.eContextGroupColor)base.GetValue(global::DevComponents.WpfRibbon.ContextGroup.StockColorProperty);
			}
			set
			{
				short num = (short)1585387165;
				short num2 = num;
				num = (short)1501173405;
				switch (num2 == num)
				{
				}
				num = (short)440270848;
				if (num != 0)
				{
				}
				num = (short)357957632;
				short num3 = num;
				num = (short)551223297;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ContextGroup.StockColorProperty, value);
			}
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0003F1D8 File Offset: 0x0003D3D8
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			short num2;
			int num3;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_185;
				case 1:
				{
					global::DevComponents.WpfRibbon.RibbonTab ribbonTab;
					ribbonTab.IsSelected = true;
					num2 = (short)1573060616;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
				{
					if (num3 < 0)
					{
						num2 = (short)311427072;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::DevComponents.WpfRibbon.RibbonTab ribbonTab = this.LinkedTabs[num3];
					num2 = (short)1617362950;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
				{
					global::DevComponents.WpfRibbon.RibbonTab ribbonTab;
					if (!ribbonTab.IsSelected)
					{
						num2 = (short)634519553;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_CD;
				}
				case 4:
				{
					num2 = (short)1577410576;
					short num4 = num2;
					num2 = (short)1498963984;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1C6;
					default:
						num2 = (short)484638721;
						if (num2 != 0)
						{
						}
						num2 = (short)594739200;
						if (num2 != 0)
						{
						}
						goto IL_153;
					}
					break;
				}
				case 5:
					num2 = (short)903151619;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
				{
					global::DevComponents.WpfRibbon.RibbonTab ribbonTab;
					if (ribbonTab.Visibility == global::System.Windows.Visibility.Visible)
					{
						num2 = (short)1556414469;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_CD;
				}
				case 7:
					goto IL_153;
				case 8:
					goto IL_CD;
				}
				goto IL_34;
				IL_CD:
				num3--;
				num2 = (short)1883897863;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_153:
				num2 = (short)1308884994;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_185:
			IL_1C6:
			num2 = (short)2109014016;
			short num5 = num2;
			base.OnMouseLeftButtonDown(e);
			return;
			IL_34:
			num3 = this.LinkedTabs.Count - 1;
			num2 = (short)358350852;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060002CB RID: 715 RVA: 0x0003F3DC File Offset: 0x0003D5DC
		// (set) Token: 0x060002CC RID: 716 RVA: 0x0003F494 File Offset: 0x0003D694
		public bool IsSimpleContent
		{
			get
			{
				short num = (short)1101529856;
				short num2 = num;
				num = (short)918094592;
				switch (num2 == num)
				{
				}
				num = (short)1100087297;
				if (num != 0)
				{
				}
				num = (short)1193672704;
				short num3 = num;
				num = (short)1075118080;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.ContextGroup.IsSimpleContentProperty);
			}
			internal set
			{
				short num = (short)1203872143;
				short num2 = num;
				num = (short)1108713871;
				switch (num2 == num)
				{
				}
				num = (short)767688705;
				if (num != 0)
				{
				}
				num = (short)2146566144;
				short num3 = num;
				num = (short)585105408;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.ContextGroup.IsSimpleContentPropertyKey, value);
			}
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0003F554 File Offset: 0x0003D754
		protected override void OnContentChanged(object oldContent, object newContent)
		{
			short num = (short)2108030979;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (!this.IsSimpleContent)
					{
						num = (short)458031106;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C0;
				case 1:
					this.IsSimpleContent = false;
					num = (short)163577862;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					this.IsSimpleContent = true;
					num = (short)846462980;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				case 4:
				{
					num = (short)270027553;
					short num3 = num;
					num = (short)2123451169;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_149;
					}
					break;
				}
				case 5:
					if (this.IsSimpleContent)
					{
						num = (short)662044673;
						if (num != 0)
						{
						}
						num = (short)973012993;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C0;
				case 6:
					goto IL_1BE;
				case 7:
					num = (short)771162112;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_45:
				if (newContent is string)
				{
					num = (short)774242304;
					short num4 = num;
					num = (short)419823623;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)308346885;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_149:
			num = (short)134545408;
			if (num != 0)
			{
			}
			IL_1BE:
			IL_1C0:
			base.OnContentChanged(oldContent, newContent);
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060002CE RID: 718 RVA: 0x0003F72C File Offset: 0x0003D92C
		internal global::System.Windows.Controls.Label ContentLabel
		{
			get
			{
				short num = (short)756830777;
				short num2 = num;
				num = (short)384258617;
				switch (num2 == num)
				{
				}
				num = (short)277938176;
				if (num != 0)
				{
				}
				num = (short)1479737344;
				short num3 = num;
				num = (short)317063169;
				if (num != 0)
				{
				}
				return this.m_ContentLabel;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060002CF RID: 719 RVA: 0x0003F7DC File Offset: 0x0003D9DC
		// (set) Token: 0x060002D0 RID: 720 RVA: 0x0003F88C File Offset: 0x0003DA8C
		internal bool IsGlassEnabled
		{
			get
			{
				short num = (short)1885063022;
				short num2 = num;
				num = (short)583976814;
				switch (num2 == num)
				{
				}
				num = (short)1911685121;
				if (num != 0)
				{
				}
				num = (short)638713856;
				short num3 = num;
				num = (short)576323584;
				if (num != 0)
				{
				}
				return this.m_IsGlassEnabled;
			}
			set
			{
				short num = (short)1176240130;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						this.m_IsGlassEnabled = value;
						this.UpdateLabelGlassEffect();
						num = (short)180617216;
						short num3 = num;
						num = (short)244711425;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						num = (short)689505547;
						short num4 = num;
						num = (short)1598817547;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3C;
						default:
							goto IL_D3;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					}
					goto IL_30;
					IL_3C:
					num = (short)586022912;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_30:
					if (this.m_IsGlassEnabled != value)
					{
						goto IL_3C;
					}
					return;
				}
				IL_D3:
				num = (short)1163198465;
				if (num != 0)
				{
				}
				num = (short)666501120;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0003F9AC File Offset: 0x0003DBAC
		private void UpdateLabelGlassEffect()
		{
			short num = (short)1669726211;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_7B;
				case 1:
					if (this.IsGlassEnabled)
					{
						num = (short)600834050;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_19E;
				case 2:
					goto IL_198;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_36;
					}
					continue;
				}
				IL_36:
				num = (short)2022178817;
				if (num != 0)
				{
				}
				if (this.m_ContentLabel == null)
				{
					num = (short)600113152;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1874788353;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_7B:
			num = (short)1870313636;
			short num3 = num;
			num = (short)1371584676;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_CA:
				num = (short)390987776;
				short num4 = num;
				global::System.Windows.Media.Effects.DropShadowEffect dropShadowEffect = new global::System.Windows.Media.Effects.DropShadowEffect();
				dropShadowEffect.ShadowDepth = 0.0;
				dropShadowEffect.Color = global::System.Windows.Media.Colors.White;
				dropShadowEffect.BlurRadius = 9.0;
				dropShadowEffect.Opacity = 1.0;
				this.m_ContentLabel.Effect = dropShadowEffect;
				this.m_ContentLabel.SetResourceReference(global::System.Windows.Controls.Control.ForegroundProperty, new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.Ribbon), global::System.Windows.SystemColors.ActiveCaptionBrushKey));
				return;
			}
			default:
				num = (short)1326841856;
				if (num != 0)
				{
				}
				return;
			}
			IL_198:
			goto IL_CA;
			IL_19E:
			this.m_ContentLabel.Effect = null;
			this.UpdateStockForegroundColor();
		}

		// Token: 0x040000EC RID: 236
		private global::System.Collections.ObjectModel.ObservableCollection<global::DevComponents.WpfRibbon.RibbonTab> m_LinkedTabs;

		// Token: 0x040000ED RID: 237
		public static readonly global::System.Windows.DependencyProperty StockColorProperty;

		// Token: 0x040000EE RID: 238
		public static readonly global::System.Windows.DependencyProperty IsSimpleContentProperty;

		// Token: 0x040000EF RID: 239
		private static readonly global::System.Windows.DependencyPropertyKey IsSimpleContentPropertyKey;

		// Token: 0x040000F0 RID: 240
		private const string LabelContentName = "PART_LabelContent";

		// Token: 0x040000F1 RID: 241
		private global::System.Windows.Controls.Label m_ContentLabel;

		// Token: 0x040000F2 RID: 242
		private bool m_IsGlassEnabled;
	}
}
