using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using DevComponents.WpfRibbon.Converters;

namespace DevComponents.WpfRibbon
{
	// Token: 0x02000051 RID: 81
	[global::System.Windows.TemplatePart(Name = "PART_GalleryBorder", Type = typeof(global::System.Windows.Controls.Decorator))]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class Gallery : global::DevComponents.WpfRibbon.ButtonDropDown
	{
		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x0004E25C File Offset: 0x0004C45C
		// (set) Token: 0x060003A5 RID: 933 RVA: 0x0004E314 File Offset: 0x0004C514
		public double MaxPopupHeight
		{
			get
			{
				short num = (short)1677852672;
				short num2 = num;
				num = (short)1539440641;
				if (num != 0)
				{
				}
				num = (short)968369152;
				short num3 = num;
				num = (short)348070912;
				switch (num3 == num)
				{
				}
				num = (short)1910636544;
				if (num != 0)
				{
				}
				return (double)base.GetValue(global::DevComponents.WpfRibbon.Gallery.MaxPopupHeightProperty);
			}
			set
			{
				short num = (short)1751580672;
				short num2 = num;
				num = (short)1918648032;
				short num3 = num;
				num = (short)165363424;
				switch (num3 == num)
				{
				}
				num = (short)1291321345;
				if (num != 0)
				{
				}
				num = (short)338690048;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.Gallery.MaxPopupHeightProperty, value);
			}
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0004E3CC File Offset: 0x0004C5CC
		static Gallery()
		{
			int a_ = 0;
			short num = (short)138280960;
			short num2 = num;
			num = (short)742654965;
			short num3 = num;
			num = (short)942343157;
			switch (num3 == num)
			{
			}
			num = (short)1673265152;
			if (num != 0)
			{
			}
			num = (short)1753874433;
			if (num != 0)
			{
			}
			global::DevComponents.WpfRibbon.Gallery.MaxPopupHeightProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᕗ㭙⑛๝ཟቡᅣᙥ⁧ཀྵի७ᡯٱ", a_), typeof(double), typeof(global::DevComponents.WpfRibbon.Gallery), new global::System.Windows.UIPropertyMetadata(400.0));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfRibbon.Gallery), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfRibbon.Gallery)));
			global::System.Windows.FrameworkElement.FocusVisualStyleProperty.OverrideMetadata(typeof(global::DevComponents.WpfRibbon.Gallery), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::DevComponents.WpfRibbon.Gallery.DropDownGalleryCommand = new global::System.Windows.Input.RoutedCommand(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("᱗⡙㍛⹝⑟ൡ፣ࡥ⽧୩kɭᕯq൳", a_), typeof(global::DevComponents.WpfRibbon.GalleryScrollViewer));
			global::System.Windows.Input.CommandManager.RegisterClassCommandBinding(typeof(global::DevComponents.WpfRibbon.Gallery), new global::System.Windows.Input.CommandBinding(global::DevComponents.WpfRibbon.Gallery.DropDownGalleryCommand, new global::System.Windows.Input.ExecutedRoutedEventHandler(global::DevComponents.WpfRibbon.Gallery.OnDropDownGalleryCommand), new global::System.Windows.Input.CanExecuteRoutedEventHandler(global::DevComponents.WpfRibbon.Gallery.OnQueryDropDownGalleryCommand)));
			global::DevComponents.WpfRibbon.Gallery.IsCollapsibleProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᅗ⥙Ὓㅝ౟๡գᙥ᭧ͩ๫ɭᕯ", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.Gallery), new global::System.Windows.FrameworkPropertyMetadata(true));
			global::DevComponents.WpfRibbon.Gallery.SuggestedContainerWidthProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ୗ⽙㭛㥝՟ᅡၣͥ౧⥩ͫmѯ፱ᵳᡵᵷࡹ⭻᝽", a_), typeof(double), typeof(global::DevComponents.WpfRibbon.Gallery), new global::System.Windows.FrameworkPropertyMetadata(200.0, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsParentMeasure));
			global::DevComponents.WpfRibbon.Gallery.IsCollapsedProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᅗ⥙Ὓㅝ౟๡գᙥ᭧ཀྵ࡫", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.Gallery), new global::System.Windows.FrameworkPropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.Gallery.OnIsCollapsedChanged)));
			global::DevComponents.WpfRibbon.Gallery.MenuItemsPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᕗ㽙㉛⭝⥟ᙡţ୥᭧", a_), typeof(global::System.Collections.ObjectModel.ObservableCollection<global::System.Windows.UIElement>), typeof(global::DevComponents.WpfRibbon.Gallery), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::DevComponents.WpfRibbon.Gallery.MenuItemsProperty = global::DevComponents.WpfRibbon.Gallery.MenuItemsPropertyKey.DependencyProperty;
			global::DevComponents.WpfRibbon.Gallery.MenuItemsVisibilityPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᕗ㽙㉛⭝⥟ᙡţ୥᭧㱩իᵭ᥯ၱᵳ᩵ᅷ๹ջ", a_), typeof(global::System.Windows.Visibility), typeof(global::DevComponents.WpfRibbon.Gallery), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Visibility.Collapsed));
			global::DevComponents.WpfRibbon.Gallery.MenuItemsVisibilityProperty = global::DevComponents.WpfRibbon.Gallery.MenuItemsVisibilityPropertyKey.DependencyProperty;
			global::DevComponents.WpfRibbon.Gallery.CategoryProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("᭗㭙⡛㭝ݟൡᙣὥ", a_), typeof(string), typeof(global::DevComponents.WpfRibbon.Gallery), new global::System.Windows.PropertyMetadata("", new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfRibbon.Gallery.OnCategoryChanged)));
			global::DevComponents.WpfRibbon.Gallery.IsResizeEnabledProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᅗ⥙๛㭝፟ୡṣͥⵧѩ൫౭ᱯ᝱ၳ", a_), typeof(bool), typeof(global::DevComponents.WpfRibbon.Gallery), new global::System.Windows.FrameworkPropertyMetadata(true));
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0004E70C File Offset: 0x0004C90C
		public Gallery()
		{
			base.SetValue(global::DevComponents.WpfRibbon.Gallery.MenuItemsPropertyKey, new global::System.Collections.ObjectModel.ObservableCollection<global::System.Windows.UIElement>());
			this.MenuItems.CollectionChanged += this.MenuItemsCollectionChanged;
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0004E758 File Offset: 0x0004C958
		public override void OnApplyTemplate()
		{
			int a_ = 12;
			short num = (short)438632449;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.m_ResizeThumb != null)
					{
						num = (short)1967521793;
						if (num != 0)
						{
						}
						num = (short)136970250;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A5;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_5F;
					}
					continue;
				case 2:
					goto IL_36E;
				case 3:
					if (this.m_ItemsPanel != null)
					{
						num = (short)2026307595;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_230;
				case 4:
				{
					num = (short)194730527;
					short num3 = num;
					num = (short)769808927;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_36E;
					default:
					{
						num = (short)1205665792;
						if (num != 0)
						{
						}
						this.m_MenuItemsPanel.Children.Clear();
						num = (short)415105024;
						short num4 = num;
						num = (short)1022165001;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 5:
					goto IL_230;
				case 6:
					if (this.m_ResizeThumb != null)
					{
						num = (short)488570888;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_373;
				case 7:
					goto IL_18D;
				case 8:
					this.m_ResizeThumb.DragDelta += this.ResizeThumbDragDelta;
					this.m_ResizeThumb.DragStarted += this.ResizeThumbDragStarted;
					num = (short)1459355655;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_E2;
				case 10:
					this.m_ResizeThumb.DragDelta -= this.ResizeThumbDragDelta;
					this.m_ResizeThumb.DragStarted -= this.ResizeThumbDragStarted;
					num = (short)770637826;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					this.m_ItemsPanel.IsItemsHost = false;
					num = (short)73924613;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_5F:
				if (this.m_MenuItemsPanel != null)
				{
					num = (short)414056452;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_E2;
				IL_A5:
				num = (short)491257859;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_36E:
				goto IL_A5;
				IL_E2:
				num = (short)913768448;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_230:
				this.m_Panel = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⍣ݥѧ٩५ᱭ९⑱ᵳ፵ཷ", a_)) as global::DevComponents.WpfRibbon.GalleryScrollViewer);
				this.m_ItemsPanel = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㑣❥㩧㹩㍫❭ѯ᝱ᥳյ⡷᭹ቻ᭽", a_)) as global::System.Windows.Controls.Panel);
				this.m_MenuItemsPanel = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㑣❥㩧㹩㍫⍭ᕯᱱų㽵౷όᅻൽ큿", a_)) as global::System.Windows.Controls.Panel);
				this.m_PopupGalleryPanel = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㑣॥ᡧὩᱫ⵭Ὧᱱs᝵ᅷᑹ᥻౽큿", a_)) as global::System.Windows.Controls.Panel);
				this.m_ResizeThumb = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⍣ݥѧ٩५ᱭ९≱᭳ٵ൷੹⹻᭽ﺃ\udc87曆", a_)) as global::System.Windows.Controls.Primitives.Thumb);
				this.m_PopupScrollViewer = (base.GetTemplateChild(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("㑣॥ᡧὩᱫ㵭፯q᭳᩵ᑷⱹᕻ᭽", a_)) as global::System.Windows.Controls.ScrollViewer);
				num = (short)1556480006;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_18D:
			IL_373:
			this.UpdateMenuItems();
			base.OnApplyTemplate();
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0004EAE4 File Offset: 0x0004CCE4
		protected override void OnGotKeyboardFocus(global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			short num = (short)885456896;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)424968091;
					short num3 = num;
					num = (short)799309723;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14E;
					case 1:
						break;
					default:
					{
						num = (short)1019936768;
						short num4 = num;
						break;
					}
					}
					num = (short)150077440;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_AF;
					}
					continue;
				}
				case 1:
					global::DevComponents.WpfRibbon.FocusHelpers.FocusFirstChild(this);
					num = (short)280821763;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (!this.IsCollapsed)
					{
						num = (short)275251201;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_14E;
				case 3:
					goto IL_ED;
				case 4:
					num = (short)1835532289;
					if (num != 0)
					{
					}
					num = (short)748224514;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_AF:
				if (e.NewFocus != this)
				{
					break;
				}
				num = (short)1100480516;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_ED:
			IL_14E:
			base.OnGotKeyboardFocus(e);
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0004EC48 File Offset: 0x0004CE48
		private void ResizeThumbDragStarted(object sender, global::System.Windows.Controls.Primitives.DragStartedEventArgs e)
		{
			short num = (short)176471130;
			short num2 = num;
			num = (short)1865268314;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			case 1:
				break;
			default:
			{
				num = (short)1991442432;
				short num3 = num;
				break;
			}
			}
			num = (short)1395982336;
			if (num != 0)
			{
			}
			num = (short)2030305281;
			if (num != 0)
			{
			}
			if (this.m_PopupGalleryPanel != null)
			{
				this.m_StartingPopupPanelSize = new global::System.Windows.Size(global::System.Math.Ceiling(this.m_PopupScrollViewer.RenderSize.Width), global::System.Math.Ceiling(this.m_PopupScrollViewer.RenderSize.Height));
				return;
			}
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0004ED38 File Offset: 0x0004CF38
		private void ResizeThumbDragDelta(object sender, global::System.Windows.Controls.Primitives.DragDeltaEventArgs e)
		{
			short num = (short)343080960;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)1050673153;
				if (num != 0)
				{
				}
				num = (short)631111681;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					double num3;
					double num4;
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						goto IL_2D4;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_95;
						}
						continue;
					case 2:
						if (this.m_PopupScrollViewer.Height != num3)
						{
							num = (short)381353984;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						goto IL_47E;
					case 4:
						return;
					case 5:
						if (this.m_PopupScrollViewer.Width == num4)
						{
							num = (short)997457927;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D4;
					case 6:
					{
						try
						{
							num = (short)1773600768;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_FE;
									}
									continue;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1680998406;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::DevComponents.WpfRibbon.GalleryWrapPanel galleryWrapPanel = ((global::System.Windows.UIElement)enumerator.Current) as global::DevComponents.WpfRibbon.GalleryWrapPanel;
									num = (short)1467023364;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::DevComponents.WpfRibbon.GalleryWrapPanel galleryWrapPanel;
									galleryWrapPanel.Width = double.NaN;
									num = (short)37879813;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_1BF;
								case 4:
								{
									global::DevComponents.WpfRibbon.GalleryWrapPanel galleryWrapPanel;
									if (galleryWrapPanel != null)
									{
										num = (short)1483603970;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									num = (short)338755587;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_100:
								num = (short)1578106881;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_FE:
								goto IL_100;
							}
							IL_1BF:
							goto IL_302;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_1E1;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_1CE:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)969998338;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_238;
								case 1:
									goto IL_236;
								case 2:
									disposable.Dispose();
									num = (short)156827649;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1E1;
							}
							IL_236:
							IL_238:
							goto EndFinally_10;
							IL_1E1:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)319029248;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_1CE;
							EndFinally_10:;
						}
						goto IL_239;
						IL_302:
						num = (short)814547265;
						short num5 = num;
						num = (short)118227265;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_47E;
						default:
						{
							num = (short)673841152;
							if (num != 0)
							{
							}
							this.m_PopupScrollViewer.Width = num4;
							this.m_PopupScrollViewer.Height = num3;
							base.Popup.UpdateLayout();
							num = (short)1775828992;
							short num6 = num;
							num = (short)1812660232;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 7:
						goto IL_239;
					case 8:
						return;
					case 9:
						this.m_MinPopupPanelSize.Width = this.m_PopupScrollViewer.ActualWidth;
						num = (short)1013448707;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (this.m_MinPopupPanelSize.Width == 0.0)
						{
							num = (short)1358626825;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3B7;
					}
					IL_95:
					if (this.m_PopupGalleryPanel == null)
					{
						num = (short)1491468292;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Windows.Controls.Panel popupGalleryPanel = this.m_PopupGalleryPanel;
					num = (short)1258487818;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_239:
					num = (short)666107906;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2D4:
					enumerator = this.m_PopupGalleryPanel.Children.GetEnumerator();
					num = (short)723517446;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3B7:
					num4 = global::System.Math.Ceiling(global::System.Math.Max(this.m_MinPopupPanelSize.Width, this.m_StartingPopupPanelSize.Width + e.HorizontalChange));
					num3 = global::System.Math.Ceiling(global::System.Math.Max(this.m_MinPopupPanelSize.Height, this.m_PopupScrollViewer.ActualHeight + e.VerticalChange));
					num = (short)221511685;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_47E:
					goto IL_3B7;
				}
				return;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060003AC RID: 940 RVA: 0x0004F1E4 File Offset: 0x0004D3E4
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
		public global::System.Collections.ObjectModel.ObservableCollection<global::System.Windows.UIElement> MenuItems
		{
			get
			{
				short num = (short)1045889024;
				short num2 = num;
				num = (short)1248930740;
				short num3 = num;
				num = (short)687745972;
				switch (num3 == num)
				{
				}
				num = (short)407502848;
				if (num != 0)
				{
				}
				num = (short)1819148289;
				if (num != 0)
				{
				}
				return (global::System.Collections.ObjectModel.ObservableCollection<global::System.Windows.UIElement>)base.GetValue(global::DevComponents.WpfRibbon.Gallery.MenuItemsProperty);
			}
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0004F29C File Offset: 0x0004D49C
		private void MenuItemsCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			short num = (short)341180416;
			short num2 = num;
			num = (short)1929248769;
			if (num != 0)
			{
			}
			num = (short)1155054734;
			short num3 = num;
			num = (short)824622222;
			switch (num3 == num)
			{
			}
			num = (short)1573191680;
			if (num != 0)
			{
			}
			this.UpdateMenuItems();
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0004F350 File Offset: 0x0004D550
		private void UpdateMenuItems()
		{
			short num = (short)2125922304;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_42;
					}
					continue;
				case 1:
					num = (short)1150353409;
					if (num != 0)
					{
					}
					this.MenuItemsVisibility = global::System.Windows.Visibility.Collapsed;
					num = (short)259457028;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					if (this.m_MenuItemsPanel == null)
					{
						num = (short)528547840;
						short num3 = num;
						num = (short)196476931;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.m_MenuItemsPanel.Children.Clear();
					global::System.Collections.Generic.IEnumerator<global::System.Windows.UIElement> enumerator = this.MenuItems.GetEnumerator();
					num = (short)249364486;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					return;
				case 4:
					goto IL_27C;
				case 5:
					goto IL_27C;
				case 6:
					try
					{
						num = (short)1545601024;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_145;
								}
								continue;
							case 1:
								goto IL_1C2;
							case 3:
								num = (short)1464467457;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
							{
								global::System.Collections.Generic.IEnumerator<global::System.Windows.UIElement> enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)1127284739;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Windows.UIElement element = enumerator.Current;
								this.m_MenuItemsPanel.Children.Add(element);
								num = (short)1807482882;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_147:
							num = (short)1394540548;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_145:
							goto IL_147;
						}
						IL_1C2:
						goto IL_2E3;
					}
					finally
					{
						num = (short)409796608;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Collections.Generic.IEnumerator<global::System.Windows.UIElement> enumerator;
							switch (num2)
							{
							case 0:
								goto IL_1DC;
							case 1:
								goto IL_279;
							case 2:
								enumerator.Dispose();
								num = (short)1942487041;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1F8;
							IL_1DC:
							switch (0)
							{
							case 0:
							{
								IL_1F8:
								num = (short)1153996811;
								short num4 = num;
								num = (short)650156043;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_1DC;
								default:
									num = (short)1336737792;
									if (num != 0)
									{
									}
									if (enumerator == null)
									{
										goto IL_27B;
									}
									num = (short)1354825730;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
								break;
							}
							}
						}
						IL_279:
						IL_27B:;
					}
					goto IL_27C;
				}
				IL_42:
				if (this.MenuItems.Count == 0)
				{
					num = (short)300351489;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				this.MenuItemsVisibility = global::System.Windows.Visibility.Visible;
				num = (short)782434309;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_27C:
				num = (short)671154178;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_2E3:
			this.m_MenuItemsPanel.InvalidateMeasure();
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060003AF RID: 943 RVA: 0x0004F65C File Offset: 0x0004D85C
		// (set) Token: 0x060003B0 RID: 944 RVA: 0x0004F714 File Offset: 0x0004D914
		[global::System.ComponentModel.DefaultValue(true)]
		[global::System.ComponentModel.Browsable(true)]
		public bool IsCollapsible
		{
			get
			{
				short num = (short)2113601536;
				short num2 = num;
				num = (short)1714933387;
				short num3 = num;
				num = (short)1997000331;
				switch (num3 == num)
				{
				}
				num = (short)1160249345;
				if (num != 0)
				{
				}
				num = (short)1194196992;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.Gallery.IsCollapsibleProperty);
			}
			set
			{
				short num = (short)753664000;
				short num2 = num;
				num = (short)601811779;
				short num3 = num;
				num = (short)1123609411;
				switch (num3 == num)
				{
				}
				num = (short)1926234112;
				if (num != 0)
				{
				}
				num = (short)2114191361;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.Gallery.IsCollapsibleProperty, value);
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x0004F7D0 File Offset: 0x0004D9D0
		// (set) Token: 0x060003B2 RID: 946 RVA: 0x0004F888 File Offset: 0x0004DA88
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool IsResizeEnabled
		{
			get
			{
				short num = (short)546111488;
				short num2 = num;
				num = (short)1982144301;
				short num3 = num;
				num = (short)1585717037;
				switch (num3 == num)
				{
				}
				num = (short)2127364097;
				if (num != 0)
				{
				}
				num = (short)701562880;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.Gallery.IsResizeEnabledProperty);
			}
			set
			{
				short num = (short)423690240;
				short num2 = num;
				num = (short)652421288;
				short num3 = num;
				num = (short)2097555624;
				switch (num3 == num)
				{
				}
				num = (short)850067457;
				if (num != 0)
				{
				}
				num = (short)1742340096;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.Gallery.IsResizeEnabledProperty, value);
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x0004F944 File Offset: 0x0004DB44
		// (set) Token: 0x060003B4 RID: 948 RVA: 0x0004F9FC File Offset: 0x0004DBFC
		public bool IsCollapsed
		{
			get
			{
				short num = (short)1121124352;
				short num2 = num;
				num = (short)127607501;
				short num3 = num;
				num = (short)1736450765;
				switch (num3 == num)
				{
				}
				num = (short)993263616;
				if (num != 0)
				{
				}
				num = (short)1854210049;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfRibbon.Gallery.IsCollapsedProperty);
			}
			set
			{
				short num = (short)919863296;
				short num2 = num;
				num = (short)1230116768;
				short num3 = num;
				num = (short)803280800;
				switch (num3 == num)
				{
				}
				num = (short)1782513665;
				if (num != 0)
				{
				}
				num = (short)792920064;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.Gallery.IsCollapsedProperty, value);
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x0004FAB8 File Offset: 0x0004DCB8
		// (set) Token: 0x060003B6 RID: 950 RVA: 0x0004FB70 File Offset: 0x0004DD70
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Windows.Visibility MenuItemsVisibility
		{
			get
			{
				short num = (short)2097152000;
				short num2 = num;
				num = (short)953571194;
				short num3 = num;
				num = (short)820533114;
				switch (num3 == num)
				{
				}
				num = (short)311230465;
				if (num != 0)
				{
				}
				num = (short)2075262976;
				if (num != 0)
				{
				}
				return (global::System.Windows.Visibility)base.GetValue(global::DevComponents.WpfRibbon.Gallery.MenuItemsVisibilityProperty);
			}
			internal set
			{
				short num = (short)190119936;
				short num2 = num;
				num = (short)528725260;
				short num3 = num;
				num = (short)1870574860;
				switch (num3 == num)
				{
				}
				num = (short)412745729;
				if (num != 0)
				{
				}
				num = (short)1364393984;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.Gallery.MenuItemsVisibilityPropertyKey, value);
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x0004FC2C File Offset: 0x0004DE2C
		// (set) Token: 0x060003B8 RID: 952 RVA: 0x0004FCE4 File Offset: 0x0004DEE4
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.DefaultValue(200.0)]
		public double SuggestedContainerWidth
		{
			get
			{
				short num = (short)1632305152;
				short num2 = num;
				num = (short)795342833;
				short num3 = num;
				num = (short)1947203569;
				switch (num3 == num)
				{
				}
				num = (short)1135214593;
				if (num != 0)
				{
				}
				num = (short)201850880;
				if (num != 0)
				{
				}
				return (double)base.GetValue(global::DevComponents.WpfRibbon.Gallery.SuggestedContainerWidthProperty);
			}
			set
			{
				short num = (short)428605440;
				short num2 = num;
				num = (short)1451622401;
				if (num != 0)
				{
				}
				num = (short)881323316;
				short num3 = num;
				num = (short)2133716276;
				switch (num3 == num)
				{
				}
				num = (short)1803288576;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfRibbon.Gallery.SuggestedContainerWidthProperty, value);
			}
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0004FD9C File Offset: 0x0004DF9C
		private static void OnQueryDropDownGalleryCommand(object target, global::System.Windows.Input.CanExecuteRoutedEventArgs args)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			bool canExecute;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)348848129;
					if (num2 != 0)
					{
					}
					canExecute = false;
					num2 = (short)521142272;
					short num3 = num2;
					num2 = (short)287627207;
					short num4 = num2;
					num2 = (short)689625031;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_130;
					default:
						num2 = (short)311230464;
						if (num2 != 0)
						{
						}
						num2 = (short)917307393;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					goto IL_D9;
				case 2:
				{
					global::DevComponents.WpfRibbon.Gallery gallery = (global::DevComponents.WpfRibbon.Gallery)target;
					if (gallery.Popup != null)
					{
						canExecute = true;
					}
					if (gallery.Items.Count == 0)
					{
						num2 = (short)1533476864;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_130;
				}
				}
				goto IL_1C;
			}
			IL_D9:
			IL_130:
			args.CanExecute = canExecute;
			return;
			IL_1C:
			canExecute = false;
			num2 = (short)1806565378;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0004FEE0 File Offset: 0x0004E0E0
		protected override void HandleMouseDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)1997537282;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					base.HandleMouseDown(e);
					num = (short)523894784;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_14;
				}
				goto IL_5B;
				IL_14:
				num = (short)515178496;
				short num3 = num;
				switch (0)
				{
				case 0:
				{
					IL_5B:
					num = (short)1226971833;
					short num4 = num;
					num = (short)48110265;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					default:
						num = (short)1258618881;
						if (num != 0)
						{
						}
						num = (short)1499725824;
						if (num != 0)
						{
						}
						if (!this.IsCollapsed)
						{
							return;
						}
						num = (short)959119361;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					break;
				}
				}
			}
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00050000 File Offset: 0x0004E200
		private static void OnDropDownGalleryCommand(object target, global::System.Windows.Input.ExecutedRoutedEventArgs args)
		{
			short num = (short)179437570;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					((global::DevComponents.WpfRibbon.Gallery)target).IsPopupOpen = true;
					args.Handled = true;
					num = (short)2036269056;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_15;
				}
				goto IL_5B;
				IL_15:
				num = (short)741605376;
				short num3 = num;
				switch (0)
				{
				case 0:
				{
					IL_5B:
					num = (short)2145875439;
					short num4 = num;
					num = (short)873559535;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15;
					default:
						num = (short)1063124992;
						if (num != 0)
						{
						}
						if (args.Command != global::DevComponents.WpfRibbon.Gallery.DropDownGalleryCommand)
						{
							return;
						}
						num = (short)893321217;
						if (num != 0)
						{
						}
						num = (short)1622278145;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					break;
				}
				}
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060003BC RID: 956 RVA: 0x0005012C File Offset: 0x0004E32C
		internal global::System.Windows.Controls.Panel InternalItemsPanel
		{
			get
			{
				short num = (short)896532480;
				short num2 = num;
				num = (short)1368301905;
				short num3 = num;
				num = (short)2002559313;
				switch (num3 == num)
				{
				}
				num = (short)1424162816;
				if (num != 0)
				{
				}
				num = (short)2075525121;
				if (num != 0)
				{
				}
				return this.m_ItemsPanel;
			}
		}

		// Token: 0x060003BD RID: 957 RVA: 0x000501DC File Offset: 0x0004E3DC
		protected override void OnPopupOpened(global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_60;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_1E4;
				case 1:
					goto IL_1E4;
				case 2:
				{
					num2 = (short)214750192;
					short num3 = num2;
					num2 = (short)217568240;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_363;
					default:
						num2 = (short)1733820416;
						if (num2 != 0)
						{
						}
						num2 = (short)2146041864;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					this.GeneratePopupGalleryItems(this.m_PopupGalleryPanel);
					num2 = (short)610598931;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (this.m_PopupScrollViewer != null)
					{
						num2 = (short)1452933130;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_341;
				case 5:
					goto IL_1A5;
				case 6:
					if (!this.IsCollapsed)
					{
						num2 = (short)833749009;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3EB;
				case 7:
					goto IL_341;
				case 8:
					if (base.FlowDirection == global::System.Windows.FlowDirection.LeftToRight)
					{
						num2 = (short)814022665;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					this.m_ResizeThumb.Cursor = global::System.Windows.Input.Cursors.SizeNESW;
					num2 = (short)93847553;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					this.m_ResizeThumb.Cursor = global::System.Windows.Input.Cursors.SizeNWSE;
					num2 = (short)528154624;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					this.m_PopupScrollViewer.SizeChanged += this.PopupScrollViewerSizeChanged;
					num2 = (short)1160773639;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					if (this.m_PopupGalleryPanel != null)
					{
						num2 = (short)1374289923;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3AC;
				case 12:
					num2 = (short)1467613190;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					if (this.m_ItemsPanel != null)
					{
						num2 = (short)329252878;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1A5;
				case 14:
					this.m_ItemsPanel.Width = this.m_ItemsPanel.ActualWidth;
					this.m_ItemsPanel.IsItemsHost = false;
					num2 = (short)2124349445;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					goto IL_276;
				case 16:
					if (base.Popup != null)
					{
						goto IL_363;
					}
					goto IL_3EB;
				case 17:
				{
					num2 = (short)207159296;
					short num4 = num2;
					base.Popup.VerticalOffset = -base.ActualHeight;
					num2 = (short)984416271;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 18:
					if (this.m_ResizeThumb != null)
					{
						num2 = (short)1861484546;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1E4;
				case 19:
					num2 = (short)1006370817;
					if (num2 != 0)
					{
					}
					goto IL_3AC;
				}
				goto IL_60;
				IL_1A5:
				num2 = (short)1142882315;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1E4:
				num2 = (short)1834352644;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_341:
				num2 = (short)1462829072;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_363:
				num2 = (short)721747980;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_3AC:
				num2 = (short)185335826;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_276:
			IL_3EB:
			base.OnPopupOpened(e);
			return;
			IL_60:
			this.m_MinPopupPanelSize = default(global::System.Windows.Size);
			this.m_StartingPopupPanelSize = default(global::System.Windows.Size);
			num2 = (short)208273421;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060003BE RID: 958 RVA: 0x000505DC File Offset: 0x0004E7DC
		private void PopupScrollViewerSizeChanged(object sender, global::System.Windows.SizeChangedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
				{
					num2 = (short)121765888;
					short num3 = num2;
					num2 = (short)917821486;
					short num4 = num2;
					num2 = (short)2113984558;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num2 = (short)1461059585;
						if (num2 != 0)
						{
						}
						num2 = (short)1610940416;
						if (num2 != 0)
						{
						}
						this.m_PopupScrollViewer.Height = this.MaxPopupHeight;
						num2 = (short)2134179840;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					if (this.m_PopupScrollViewer.ActualHeight > this.MaxPopupHeight)
					{
						num2 = (short)2135359489;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			this.m_PopupScrollViewer.SizeChanged -= this.PopupScrollViewerSizeChanged;
			num2 = (short)1947271170;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00050724 File Offset: 0x0004E924
		private void GeneratePopupGalleryItems(global::System.Windows.Controls.Panel p)
		{
			short num = (short)1597767680;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6B;
				}
				bool flag;
				global::DevComponents.WpfRibbon.GalleryWrapPanel galleryWrapPanel;
				global::System.Collections.IEnumerable enumerable;
				string b;
				for (;;)
				{
					IL_28:
					global::System.Windows.Controls.Primitives.IItemContainerGenerator itemContainerGenerator;
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						if (!flag)
						{
							num = (short)2092171274;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						if (galleryWrapPanel.Parent == null)
						{
							num = (short)846331918;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_192;
					case 2:
						goto IL_946;
					case 3:
						goto IL_1CB;
					case 4:
					{
						num = (short)1093140480;
						short num3 = num;
						if (itemContainerGenerator != null)
						{
							num = (short)179765256;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_126;
					}
					case 5:
					{
						global::System.Collections.ArrayList arrayList;
						try
						{
							num = (short)1649803264;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_2CF;
									}
									continue;
								case 1:
								{
									global::System.Windows.UIElement uielement;
									if ((uielement = (itemContainerGenerator.GenerateNext() as global::System.Windows.UIElement)) == null)
									{
										num = (short)1429405699;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									arrayList.Add(uielement);
									itemContainerGenerator.PrepareItemContainer(uielement);
									num = (short)1027473412;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_356;
								case 3:
									num = (short)477757442;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_2FB:
								num = (short)1286340609;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2CF:
								goto IL_2FB;
							}
							IL_356:
							goto IL_275;
						}
						finally
						{
							num = (short)1840513026;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.IDisposable disposable;
								switch (num2)
								{
								case 0:
									goto IL_3C6;
								case 1:
									disposable.Dispose();
									num = (short)1790902272;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_38D;
									}
									continue;
								}
								IL_38D:
								if (disposable == null)
								{
									break;
								}
								num = (short)1659109377;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3C6:;
						}
						goto IL_3C9;
						IL_275:
						enumerable = arrayList;
						num = (short)1566834695;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_192;
					case 7:
						goto IL_126;
					case 8:
					{
						global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList(base.Items.Count);
						itemContainerGenerator.RemoveAll();
						global::System.IDisposable disposable = itemContainerGenerator.StartAt(new global::System.Windows.Controls.Primitives.GeneratorPosition(-1, 0), global::System.Windows.Controls.Primitives.GeneratorDirection.Forward);
						num = (short)773980165;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						if (base.ItemsSource == null)
						{
							num = (short)1763311618;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1CB;
					case 10:
					{
						global::System.Windows.Controls.Separator separator = new global::System.Windows.Controls.Separator();
						separator.Visibility = global::System.Windows.Visibility.Collapsed;
						p.Children.Add(separator);
						num = (short)232456203;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						return;
					case 12:
						try
						{
							num = (short)1768292363;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Windows.UIElement uielement2;
								string category;
								global::System.Windows.UIElement uielement3;
								global::System.Windows.UIElement uielement4;
								switch (num2)
								{
								case 0:
									flag = true;
									num = (short)379715591;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									num = (short)2125880358;
									short num4 = num;
									num = (short)382229542;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_6F3;
									default:
										num = (short)390463488;
										if (num != 0)
										{
										}
										num = (short)304152579;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									uielement2 = null;
									goto IL_6F1;
								case 3:
									if (category != b)
									{
										num = (short)1519124480;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4D7;
								case 4:
									goto IL_664;
								case 5:
									if (!enumerator.MoveNext())
									{
										num = (short)1732050969;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									uielement3 = (enumerator.Current as global::System.Windows.UIElement);
									num = (short)1659633680;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									if (uielement4 is global::DevComponents.WpfRibbon.ButtonDropDown)
									{
										num = (short)857866262;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_7ED;
								case 7:
									if (galleryWrapPanel.Children.Count > 0)
									{
										num = (short)128122888;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_664;
								case 8:
									p.Children.Add(galleryWrapPanel);
									galleryWrapPanel = new global::DevComponents.WpfRibbon.GalleryWrapPanel();
									num = (short)1981218820;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									global::System.Windows.Size renderSize = uielement3.RenderSize;
									this.m_MinPopupPanelSize.Height = renderSize.Height + 12.0;
									num = (short)645595146;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
									goto IL_48C;
								case 11:
									switch (0)
									{
									case 0:
										goto IL_487;
									}
									continue;
								case 13:
									num = (short)703660034;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									goto IL_8CA;
								case 15:
									goto IL_4D7;
								case 16:
									if (uielement3 != null)
									{
										num = (short)2949143;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 17:
									if (category != null)
									{
										num = (short)1665007617;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4D7;
								case 18:
								{
									global::System.Windows.Size renderSize;
									if (renderSize.Height > this.m_MinPopupPanelSize.Height)
									{
										num = (short)641925129;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_48C;
								}
								case 19:
									goto IL_7ED;
								case 20:
									if (uielement3 is global::System.Windows.Controls.ContentPresenter)
									{
										num = (short)1358430229;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_7ED;
								case 21:
									((global::System.Windows.Controls.ContentPresenter)uielement3).ApplyTemplate();
									num = (short)210239512;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 22:
									category = global::DevComponents.WpfRibbon.Gallery.GetCategory(uielement4);
									num = (short)224526355;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 23:
								{
									global::System.Windows.Size renderSize = uielement3.RenderSize;
									num = (short)1820917778;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 24:
									if (global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(uielement3) <= 0)
									{
										num = (short)1549402125;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1924333594;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 25:
									num = (short)1535180814;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 26:
									uielement2 = (global::System.Windows.Media.VisualTreeHelper.GetChild(uielement3, 0) as global::System.Windows.UIElement);
									goto IL_6F1;
								}
								goto IL_487;
								IL_48C:
								category = global::DevComponents.WpfRibbon.Gallery.GetCategory(uielement3);
								num = (short)420544532;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4D7:
								galleryWrapPanel.Children.Add(uielement3);
								num = (short)1424556044;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_664:
								global::System.Windows.Controls.Label element = this.CreateCategoryLabel(category);
								p.Children.Add(element);
								p.Children.Add(this.CreateSeparator());
								b = category;
								num = (short)1330708495;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_6F3:
								num = (short)526778374;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_6F1:
								uielement4 = uielement2;
								goto IL_6F3;
								IL_7ED:
								num = (short)239534097;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_874:
								num = (short)604372997;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_487:
								goto IL_874;
							}
							IL_8CA:
							goto IL_BF;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_8EC;
							}
							global::System.IDisposable disposable2;
							for (;;)
							{
								IL_8D9:
								switch (num2)
								{
								case 0:
									if (disposable2 != null)
									{
										num = (short)192937986;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_945;
								case 1:
									goto IL_943;
								case 2:
									disposable2.Dispose();
									num = (short)67895297;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_8EC;
							}
							IL_943:
							IL_945:
							goto EndFinally_22;
							IL_8EC:
							disposable2 = (enumerator as global::System.IDisposable);
							num = (short)377815040;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_8D9;
							EndFinally_22:;
						}
						goto IL_946;
						IL_BF:
						num = (short)1780678657;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (base.ItemTemplate != null)
						{
							num = (short)1976762371;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_126;
					case 14:
						num = (short)529006593;
						if (num != 0)
						{
						}
						goto IL_3C9;
					}
					goto IL_6B;
					IL_126:
					enumerator = enumerable.GetEnumerator();
					num = (short)1259470860;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_192:
					num = (short)1342439424;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1CB:
					itemContainerGenerator = base.ItemContainerGenerator;
					num = (short)1591214084;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3C9:
					p.Children.Add(galleryWrapPanel);
					num = (short)314966022;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_946:
					num = (short)1566441485;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_6B:
				galleryWrapPanel = new global::DevComponents.WpfRibbon.GalleryWrapPanel();
				b = "";
				flag = false;
				enumerable = base.Items;
				num = (short)26279945;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x000510EC File Offset: 0x0004F2EC
		protected virtual global::System.Windows.Controls.Label CreateCategoryLabel(string cat)
		{
			int a_ = 3;
			short num = (short)1944256513;
			if (num != 0)
			{
			}
			num = (short)383276122;
			short num2 = num;
			num = (short)1461605466;
			switch (num2 == num)
			{
			}
			num = (short)857014272;
			short num3 = num;
			num = (short)323485696;
			if (num != 0)
			{
			}
			global::System.Windows.Controls.Label label = new global::System.Windows.Controls.Label();
			if (!(cat == ""))
			{
				if (cat != null)
				{
					goto IL_D1;
				}
			}
			cat = global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ᕚ㉜罞≠ɢᅤɦ๨ѪὬ᙮", a_);
			IL_D1:
			label.Content = cat;
			label.SetResourceReference(global::System.Windows.Controls.Control.BackgroundProperty, new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.Ribbon), global::DevComponents.WpfRibbon.RibbonColors.GalleryCategoryBackground));
			label.SetResourceReference(global::System.Windows.Controls.Control.ForegroundProperty, new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfRibbon.Ribbon), global::DevComponents.WpfRibbon.RibbonColors.GalleryCategoryForeground));
			label.FontWeight = global::System.Windows.FontWeights.Bold;
			label.Margin = default(global::System.Windows.Thickness);
			label.Padding = new global::System.Windows.Thickness(6.0, 1.0, 1.0, 1.0);
			return label;
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00051258 File Offset: 0x0004F458
		protected virtual global::System.Windows.Controls.Separator CreateSeparator()
		{
			short num = (short)1661131401;
			short num2 = num;
			num = (short)1520032393;
			switch (num2 == num)
			{
			}
			num = (short)517406720;
			if (num != 0)
			{
			}
			num = (short)817823744;
			short num3 = num;
			num = (short)451870721;
			if (num != 0)
			{
			}
			return new global::System.Windows.Controls.Separator
			{
				Padding = default(global::System.Windows.Thickness),
				Margin = default(global::System.Windows.Thickness)
			};
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00051324 File Offset: 0x0004F524
		protected override void OnPopupClosed(global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1733558273;
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
						goto IL_42;
					}
					continue;
				case 2:
					num = (short)1694629889;
					if (num != 0)
					{
					}
					goto IL_66;
				case 3:
				{
					global::System.Collections.IEnumerator enumerator = this.m_PopupGalleryPanel.Children.GetEnumerator();
					num = (short)550633478;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
				{
					num = (short)32039966;
					short num3 = num;
					num = (short)979559454;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_66;
					case 1:
						break;
					default:
					{
						num = (short)173473792;
						short num4 = num;
						break;
					}
					}
					num = (short)403505152;
					if (num != 0)
					{
					}
					if (this.m_ItemsPanel != null)
					{
						num = (short)208732165;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 5:
				{
					this.m_ItemsPanel.Width = double.NaN;
					this.m_ItemsPanel.IsItemsHost = true;
					int count = this.m_ItemsPanel.Children.Count;
					num = (short)1546190848;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					try
					{
						num = (short)1679163393;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::System.Windows.UIElement uielement;
								global::System.Windows.Controls.WrapPanel wrapPanel = uielement as global::System.Windows.Controls.WrapPanel;
								global::System.Windows.UIElement uielement2 = wrapPanel.Children[0];
								wrapPanel.Children.Clear();
								num = (short)1954611205;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								switch (0)
								{
								case 0:
									goto IL_1D2;
								}
								continue;
							case 2:
								goto IL_2A2;
							case 3:
							{
								global::System.Collections.IEnumerator enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)1463877636;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)enumerator.Current;
								num = (short)799080454;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								num = (short)1376976898;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
							{
								global::System.Windows.UIElement uielement;
								if (uielement is global::System.Windows.Controls.WrapPanel)
								{
									num = (short)436731904;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							}
							IL_1D4:
							num = (short)231604227;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_1D2:
							goto IL_1D4;
						}
						IL_2A2:;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_2C0;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_2AE:
							switch (num2)
							{
							case 0:
								if (disposable != null)
								{
									num = (short)1127219202;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_311;
							case 1:
								goto IL_30F;
							case 2:
								disposable.Dispose();
								num = (short)676986881;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2C0;
						}
						IL_30F:
						IL_311:
						goto EndFinally_9;
						IL_2C0:
						global::System.Collections.IEnumerator enumerator;
						disposable = (enumerator as global::System.IDisposable);
						num = (short)1749024768;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_2AE;
						EndFinally_9:;
					}
					this.m_PopupGalleryPanel.Children.Clear();
					this.m_PopupScrollViewer.Width = double.NaN;
					this.m_PopupScrollViewer.Height = double.NaN;
					num = (short)617414658;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_42:
				if (this.m_PopupGalleryPanel != null)
				{
					num = (short)29032451;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_66:
				base.OnPopupClosed(e);
				num = (short)2048000004;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x000516DC File Offset: 0x0004F8DC
		internal double GetMinContainerWidth()
		{
			short num = (short)1095499776;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1911685120;
				num2 = (int)((global::System.IntPtr)num);
				double result;
				for (;;)
				{
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_4F;
						}
						continue;
					case 1:
						for (;;)
						{
							try
							{
								num = (short)1886191619;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										num = (short)818872322;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
									{
										global::System.Windows.UIElement uielement;
										result = uielement.DesiredSize.Width * 2.0;
										num = (short)1631191048;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
									{
										global::System.Windows.UIElement uielement;
										if (uielement.Visibility == global::System.Windows.Visibility.Visible)
										{
											num = (short)1859059713;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 3:
										switch (0)
										{
										case 0:
											goto IL_EF;
										}
										continue;
									case 4:
										num = (short)1530200071;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 5:
									{
										global::System.Windows.UIElement uielement;
										if (uielement != null)
										{
											num = (short)2068840448;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 6:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)1340342276;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Windows.UIElement uielement = enumerator.Current as global::System.Windows.UIElement;
										num = (short)1034813445;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 7:
										goto IL_1F2;
									case 8:
										goto IL_197;
									}
									IL_12E:
									num = (short)263454726;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_EF:
									goto IL_12E;
								}
								IL_197:
								goto IL_2A0;
								IL_1F2:
								goto IL_296;
							}
							finally
							{
								switch (0)
								{
								case 0:
									goto IL_214;
								}
								global::System.IDisposable disposable;
								for (;;)
								{
									IL_201:
									switch (num2)
									{
									case 0:
										if (disposable != null)
										{
											num = (short)828899330;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_26A;
									case 1:
										goto IL_268;
									case 2:
										disposable.Dispose();
										num = (short)1249640449;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_214;
								}
								IL_268:
								IL_26A:
								goto EndFinally_8;
								IL_214:
								disposable = (enumerator as global::System.IDisposable);
								num = (short)837419008;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_201;
								EndFinally_8:;
							}
							goto IL_26B;
							IL_2A0:
							num = (short)1286842704;
							short num3 = num;
							num = (short)787392848;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_2D4;
							}
						}
						break;
					case 2:
						goto IL_26B;
					}
					IL_4F:
					if (base.Items.Count > 0)
					{
						num = (short)201064449;
						if (num != 0)
						{
						}
						num = (short)1500774402;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_26B:
					enumerator = ((global::System.Collections.IEnumerable)base.Items).GetEnumerator();
					num = (short)961347585;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_296:
				return 36.0;
				IL_2D4:
				num = (short)676790272;
				short num4 = num;
				num = (short)1649803264;
				if (num != 0)
				{
				}
				return result;
			}
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x00051A18 File Offset: 0x0004FC18
		internal double PanelWidth
		{
			get
			{
				short num = (short)122138015;
				short num2 = num;
				num = (short)1216589215;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1510670337;
					if (num != 0)
					{
					}
					num = (short)1863647232;
					if (num != 0)
					{
					}
					if (this.m_Panel != null)
					{
						num = (short)1995046912;
						short num3 = num;
						return this.m_Panel.DesiredSize.Width;
					}
					break;
				}
				return 0.0;
			}
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00051AE8 File Offset: 0x0004FCE8
		[global::System.Windows.AttachedPropertyBrowsableForChildren]
		public static string GetCategory(global::System.Windows.UIElement element)
		{
			int a_ = 14;
			short num = (short)1999049154;
			short num2 = num;
			num = (short)1507070402;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)539099137;
				if (num != 0)
				{
				}
				num = (short)508035072;
				if (num != 0)
				{
				}
				if (element == null)
				{
					num = (short)52756480;
					short num3 = num;
					throw new global::System.ArgumentNullException(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ͥѧཀྵū", a_));
				}
				break;
			}
			return (string)element.GetValue(global::DevComponents.WpfRibbon.Gallery.CategoryProperty);
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00051BC4 File Offset: 0x0004FDC4
		public static void SetCategory(global::System.Windows.UIElement element, string category)
		{
			int a_ = 19;
			short num = (short)1493019220;
			short num2 = num;
			num = (short)1298573908;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)380764160;
				if (num != 0)
				{
				}
				if (element == null)
				{
					num = (short)888406017;
					if (num != 0)
					{
					}
					num = (short)1498415104;
					short num3 = num;
					throw new global::System.ArgumentNullException(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("๪Ŭ੮ᱰ", a_));
				}
				break;
			}
			element.SetValue(global::DevComponents.WpfRibbon.Gallery.CategoryProperty, category);
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00051C9C File Offset: 0x0004FE9C
		private static void OnIsCollapsedChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::DevComponents.WpfRibbon.Gallery gallery;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (gallery != null)
					{
						num2 = (short)2003697666;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					return;
				case 2:
				{
					for (;;)
					{
						gallery.OnIsCollapsedChanged();
						num2 = (short)1645704475;
						short num3 = num2;
						num2 = (short)1015051547;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_90;
						}
					}
					IL_90:
					num2 = (short)196214784;
					if (num2 != 0)
					{
					}
					num2 = (short)1982201856;
					short num4 = num2;
					num2 = (short)1173880833;
					if (num2 != 0)
					{
					}
					num2 = (short)1365639169;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			gallery = (d as global::DevComponents.WpfRibbon.Gallery);
			num2 = (short)968491008;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00051DB8 File Offset: 0x0004FFB8
		private void OnIsCollapsedChanged()
		{
			short num = (short)1490092033;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					if (this.m_OldHeight == base.Height)
					{
						return;
					}
					num = (short)1319478277;
					short num3 = num;
					num = (short)1733272581;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num = (short)2038628352;
						if (num != 0)
						{
						}
						num = (short)515178496;
						short num4 = num;
						num = (short)738983939;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 2:
					goto IL_54;
				case 3:
					base.Height = this.m_OldHeight;
					num = (short)684916740;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					return;
				}
				IL_38:
				if (this.IsCollapsed)
				{
					num = (short)217120770;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1721696256;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_54:
			num = (short)99090433;
			if (num != 0)
			{
			}
			this.m_OldHeight = base.Height;
			base.Height = double.NaN;
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00051F3C File Offset: 0x0005013C
		private static void OnCategoryChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)2108819439;
			short num2 = num;
			num = (short)912525295;
			switch (num2 == num)
			{
			}
			num = (short)614596609;
			if (num != 0)
			{
			}
			num = (short)110428160;
			short num3 = num;
			num = (short)1625096192;
			if (num != 0)
			{
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060003CA RID: 970 RVA: 0x00051FE8 File Offset: 0x000501E8
		// (set) Token: 0x060003CB RID: 971 RVA: 0x00052098 File Offset: 0x00050298
		internal bool ImmediateLivePreview
		{
			get
			{
				short num = (short)25773915;
				short num2 = num;
				num = (short)2038318939;
				switch (num2 == num)
				{
				}
				num = (short)931201024;
				if (num != 0)
				{
				}
				num = (short)497745920;
				short num3 = num;
				num = (short)393347073;
				if (num != 0)
				{
				}
				return this._ImmediateLivePreview;
			}
			set
			{
				short num = (short)198294808;
				short num2 = num;
				num = (short)1191230744;
				switch (num2 == num)
				{
				}
				num = (short)1810694145;
				if (num != 0)
				{
				}
				num = (short)1665794048;
				short num3 = num;
				num = (short)1362296832;
				if (num != 0)
				{
				}
				this._ImmediateLivePreview = value;
			}
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00052148 File Offset: 0x00050348
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			short num = (short)1165363027;
			short num2 = num;
			num = (short)991233875;
			switch (num2 == num)
			{
			}
			num = (short)934477825;
			if (num != 0)
			{
			}
			num = (short)2104492032;
			short num3 = num;
			num = (short)1794834432;
			if (num != 0)
			{
			}
			this._ImmediateLivePreview = false;
			base.OnMouseLeave(e);
		}

		// Token: 0x040001AD RID: 429
		public static readonly global::System.Windows.Input.RoutedCommand DropDownGalleryCommand;

		// Token: 0x040001AE RID: 430
		public static readonly global::System.Windows.DependencyProperty IsCollapsibleProperty;

		// Token: 0x040001AF RID: 431
		public static readonly global::System.Windows.DependencyProperty IsResizeEnabledProperty;

		// Token: 0x040001B0 RID: 432
		public static readonly global::System.Windows.DependencyProperty SuggestedContainerWidthProperty;

		// Token: 0x040001B1 RID: 433
		public static readonly global::System.Windows.DependencyProperty IsCollapsedProperty;

		// Token: 0x040001B2 RID: 434
		public static readonly global::System.Windows.DependencyProperty MenuItemsProperty;

		// Token: 0x040001B3 RID: 435
		private static readonly global::System.Windows.DependencyPropertyKey MenuItemsPropertyKey;

		// Token: 0x040001B4 RID: 436
		public static readonly global::System.Windows.DependencyProperty MenuItemsVisibilityProperty;

		// Token: 0x040001B5 RID: 437
		private static readonly global::System.Windows.DependencyPropertyKey MenuItemsVisibilityPropertyKey;

		// Token: 0x040001B6 RID: 438
		public static readonly global::System.Windows.DependencyProperty CategoryProperty;

		// Token: 0x040001B7 RID: 439
		public static readonly global::System.Windows.DependencyProperty MaxPopupHeightProperty;

		// Token: 0x040001B8 RID: 440
		private const string PartGalleryViewPanelName = "GalleryView";

		// Token: 0x040001B9 RID: 441
		private const string PartItemsPanelName = "PART_ItemsPanel";

		// Token: 0x040001BA RID: 442
		private const string PartMenuItemsPanelName = "PART_MenuItemsPanel";

		// Token: 0x040001BB RID: 443
		private const string PartPopupContainerPanel = "PopupContainerPanel";

		// Token: 0x040001BC RID: 444
		private const string PartResizeThumbName = "GalleryPopupResizeThumb";

		// Token: 0x040001BD RID: 445
		private const string PartPopupScrollViewer = "PopupScrollViewer";

		// Token: 0x040001BE RID: 446
		private global::DevComponents.WpfRibbon.GalleryScrollViewer m_Panel;

		// Token: 0x040001BF RID: 447
		private global::System.Windows.Controls.Panel m_ItemsPanel;

		// Token: 0x040001C0 RID: 448
		private global::System.Windows.Controls.Panel m_MenuItemsPanel;

		// Token: 0x040001C1 RID: 449
		private global::System.Windows.Controls.Panel m_PopupGalleryPanel;

		// Token: 0x040001C2 RID: 450
		private global::System.Windows.Controls.Primitives.Thumb m_ResizeThumb;

		// Token: 0x040001C3 RID: 451
		private global::System.Windows.Size m_MinPopupPanelSize;

		// Token: 0x040001C4 RID: 452
		private global::System.Windows.Size m_StartingPopupPanelSize;

		// Token: 0x040001C5 RID: 453
		private global::System.Windows.Controls.ScrollViewer m_PopupScrollViewer;

		// Token: 0x040001C6 RID: 454
		private double m_OldHeight = double.NaN;

		// Token: 0x040001C7 RID: 455
		private bool _ImmediateLivePreview;
	}
}
