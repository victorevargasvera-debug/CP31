using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000048 RID: 72
	[global::System.ComponentModel.TypeConverter(typeof(global::System.ComponentModel.ExpandableObjectConverter))]
	public class CardViewSettings : global::Infragistics.Windows.Controls.ViewSettingsBase
	{
		// Token: 0x06000322 RID: 802 RVA: 0x0000C86C File Offset: 0x0000AA6C
		static CardViewSettings()
		{
			global::System.Windows.Media.Animation.DoubleAnimation doubleAnimation = new global::System.Windows.Media.Animation.DoubleAnimation(0.0, 1.0, global::System.TimeSpan.FromMilliseconds(750.0), global::System.Windows.Media.Animation.FillBehavior.Stop);
			doubleAnimation.BeginTime = null;
			doubleAnimation.AutoReverse = false;
			doubleAnimation.AccelerationRatio = 0.6;
			doubleAnimation.DecelerationRatio = 0.4;
			doubleAnimation.Freeze();
			global::Infragistics.Windows.DataPresenter.CardViewSettings.s_RepositionAnimation = global::System.Windows.DependencyProperty.Register("RepositionAnimation", typeof(global::System.Windows.Media.Animation.DoubleAnimationBase), typeof(global::Infragistics.Windows.DataPresenter.CardViewSettings), new global::System.Windows.FrameworkPropertyMetadata(doubleAnimation));
		}

		// Token: 0x06000323 RID: 803 RVA: 0x0000CCBD File Offset: 0x0000AEBD
		protected internal override void OnControlInitialized()
		{
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0000CCC0 File Offset: 0x0000AEC0
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override void Reset()
		{
			this.ResetAllowCardWidthResizing();
			this.ResetAllowCardHeightResizing();
			this.ResetAutoFitCards();
			this.ResetCardHeight();
			this.ResetCardWidth();
			this.ResetCollapseCardButtonVisibility();
			this.ResetCollapseEmptyCellsButtonVisibility();
			this.ResetHeaderPath();
			this.ResetHeaderVisibility();
			this.ResetInterCardSpacingX();
			this.ResetInterCardSpacingY();
			this.ResetMaxCardCols();
			this.ResetMaxCardRows();
			this.ResetOrientation();
			this.ResetPadding();
			this.ResetRepositionAnimation();
			this.ResetShouldAnimateCardPositioning();
			this.ResetShouldCollapseCards();
			this.ResetShouldCollapseEmptyCells();
		}

		// Token: 0x06000325 RID: 805 RVA: 0x0000CD40 File Offset: 0x0000AF40
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool ShouldSerialize()
		{
			return this.ShouldSerializeAllowCardWidthResizing() || this.ShouldSerializeAllowCardHeightResizing() || this.ShouldSerializeAutoFitCards() || this.ShouldSerializeCardHeight() || this.ShouldSerializeCardWidth() || this.ShouldSerializeCollapseCardButtonVisibility() || this.ShouldSerializeCollapseEmptyCellsButtonVisibility() || this.ShouldSerializeHeaderPath() || this.ShouldSerializeHeaderVisibility() || this.ShouldSerializeInterCardSpacingX() || this.ShouldSerializeInterCardSpacingY() || this.ShouldSerializeMaxCardCols() || this.ShouldSerializeMaxCardRows() || this.ShouldSerializeOrientation() || this.ShouldSerializePadding() || this.ShouldSerializeRepositionAnimation() || this.ShouldSerializeShouldAnimateCardPositioning() || this.ShouldSerializeShouldCollapseCards() || this.ShouldSerializeShouldCollapseEmptyCells();
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000326 RID: 806 RVA: 0x0000CDEB File Offset: 0x0000AFEB
		// (set) Token: 0x06000327 RID: 807 RVA: 0x0000CDFD File Offset: 0x0000AFFD
		[global::System.ComponentModel.Bindable(true)]
		public bool AllowCardWidthResizing
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.AllowCardWidthResizingProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.AllowCardWidthResizingProperty, value);
			}
		}

		// Token: 0x06000328 RID: 808 RVA: 0x0000CE10 File Offset: 0x0000B010
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeAllowCardWidthResizing()
		{
			return this.AllowCardWidthResizing != (bool)global::Infragistics.Windows.DataPresenter.CardViewSettings.AllowCardWidthResizingProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06000329 RID: 809 RVA: 0x0000CE31 File Offset: 0x0000B031
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetAllowCardWidthResizing()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.AllowCardWidthResizingProperty);
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600032A RID: 810 RVA: 0x0000CE3E File Offset: 0x0000B03E
		// (set) Token: 0x0600032B RID: 811 RVA: 0x0000CE50 File Offset: 0x0000B050
		[global::System.ComponentModel.Bindable(true)]
		public bool AllowCardHeightResizing
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.AllowCardHeightResizingProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.AllowCardHeightResizingProperty, value);
			}
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0000CE63 File Offset: 0x0000B063
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeAllowCardHeightResizing()
		{
			return this.AllowCardHeightResizing != (bool)global::Infragistics.Windows.DataPresenter.CardViewSettings.AllowCardHeightResizingProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0000CE84 File Offset: 0x0000B084
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetAllowCardHeightResizing()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.AllowCardHeightResizingProperty);
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600032E RID: 814 RVA: 0x0000CE91 File Offset: 0x0000B091
		// (set) Token: 0x0600032F RID: 815 RVA: 0x0000CEA3 File Offset: 0x0000B0A3
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.AutoFitCards AutoFitCards
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.AutoFitCards)base.GetValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.AutoFitCardsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.AutoFitCardsProperty, value);
			}
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0000CEB6 File Offset: 0x0000B0B6
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeAutoFitCards()
		{
			return this.AutoFitCards != (global::Infragistics.Windows.DataPresenter.AutoFitCards)global::Infragistics.Windows.DataPresenter.CardViewSettings.AutoFitCardsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0000CED7 File Offset: 0x0000B0D7
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetAutoFitCards()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.AutoFitCardsProperty);
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000332 RID: 818 RVA: 0x0000CEE4 File Offset: 0x0000B0E4
		// (set) Token: 0x06000333 RID: 819 RVA: 0x0000CEF6 File Offset: 0x0000B0F6
		[global::System.ComponentModel.Bindable(true)]
		public double CardHeight
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.CardHeightProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.CardHeightProperty, value);
			}
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0000CF09 File Offset: 0x0000B109
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeCardHeight()
		{
			return this.CardHeight != (double)global::Infragistics.Windows.DataPresenter.CardViewSettings.CardHeightProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0000CF2A File Offset: 0x0000B12A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetCardHeight()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.CardHeightProperty);
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000336 RID: 822 RVA: 0x0000CF37 File Offset: 0x0000B137
		// (set) Token: 0x06000337 RID: 823 RVA: 0x0000CF49 File Offset: 0x0000B149
		[global::System.ComponentModel.Bindable(true)]
		public double CardWidth
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.CardWidthProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.CardWidthProperty, value);
			}
		}

		// Token: 0x06000338 RID: 824 RVA: 0x0000CF5C File Offset: 0x0000B15C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeCardWidth()
		{
			return this.CardWidth != (double)global::Infragistics.Windows.DataPresenter.CardViewSettings.CardWidthProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06000339 RID: 825 RVA: 0x0000CF7D File Offset: 0x0000B17D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetCardWidth()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.CardWidthProperty);
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600033A RID: 826 RVA: 0x0000CF8A File Offset: 0x0000B18A
		// (set) Token: 0x0600033B RID: 827 RVA: 0x0000CF9C File Offset: 0x0000B19C
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Visibility CollapseCardButtonVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.CollapseCardButtonVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.CollapseCardButtonVisibilityProperty, value);
			}
		}

		// Token: 0x0600033C RID: 828 RVA: 0x0000CFAF File Offset: 0x0000B1AF
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeCollapseCardButtonVisibility()
		{
			return this.CollapseCardButtonVisibility != (global::System.Windows.Visibility)global::Infragistics.Windows.DataPresenter.CardViewSettings.CollapseCardButtonVisibilityProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0000CFD0 File Offset: 0x0000B1D0
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetCollapseCardButtonVisibility()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.CollapseCardButtonVisibilityProperty);
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600033E RID: 830 RVA: 0x0000CFDD File Offset: 0x0000B1DD
		// (set) Token: 0x0600033F RID: 831 RVA: 0x0000CFEF File Offset: 0x0000B1EF
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Visibility CollapseEmptyCellsButtonVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.CollapseEmptyCellsButtonVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.CollapseEmptyCellsButtonVisibilityProperty, value);
			}
		}

		// Token: 0x06000340 RID: 832 RVA: 0x0000D002 File Offset: 0x0000B202
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeCollapseEmptyCellsButtonVisibility()
		{
			return this.CollapseEmptyCellsButtonVisibility != (global::System.Windows.Visibility)global::Infragistics.Windows.DataPresenter.CardViewSettings.CollapseEmptyCellsButtonVisibilityProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0000D023 File Offset: 0x0000B223
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetCollapseEmptyCellsButtonVisibility()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.CollapseEmptyCellsButtonVisibilityProperty);
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000342 RID: 834 RVA: 0x0000D030 File Offset: 0x0000B230
		// (set) Token: 0x06000343 RID: 835 RVA: 0x0000D042 File Offset: 0x0000B242
		[global::System.ComponentModel.Bindable(true)]
		public string HeaderPath
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.HeaderPathProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.HeaderPathProperty, value);
			}
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0000D050 File Offset: 0x0000B250
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeHeaderPath()
		{
			return this.HeaderPath != (string)global::Infragistics.Windows.DataPresenter.CardViewSettings.HeaderPathProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0000D071 File Offset: 0x0000B271
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetHeaderPath()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.HeaderPathProperty);
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000346 RID: 838 RVA: 0x0000D07E File Offset: 0x0000B27E
		// (set) Token: 0x06000347 RID: 839 RVA: 0x0000D090 File Offset: 0x0000B290
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Visibility HeaderVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.HeaderVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.HeaderVisibilityProperty, value);
			}
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0000D0A3 File Offset: 0x0000B2A3
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeHeaderVisibility()
		{
			return this.HeaderVisibility != (global::System.Windows.Visibility)global::Infragistics.Windows.DataPresenter.CardViewSettings.HeaderVisibilityProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0000D0C4 File Offset: 0x0000B2C4
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetHeaderVisibility()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.HeaderVisibilityProperty);
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600034A RID: 842 RVA: 0x0000D0D1 File Offset: 0x0000B2D1
		// (set) Token: 0x0600034B RID: 843 RVA: 0x0000D0E3 File Offset: 0x0000B2E3
		[global::System.ComponentModel.Bindable(true)]
		public double InterCardSpacingX
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.InterCardSpacingXProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.InterCardSpacingXProperty, value);
			}
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0000D0F6 File Offset: 0x0000B2F6
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeInterCardSpacingX()
		{
			return this.InterCardSpacingX != (double)global::Infragistics.Windows.DataPresenter.CardViewSettings.InterCardSpacingXProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0000D117 File Offset: 0x0000B317
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetInterCardSpacingX()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.InterCardSpacingXProperty);
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600034E RID: 846 RVA: 0x0000D124 File Offset: 0x0000B324
		// (set) Token: 0x0600034F RID: 847 RVA: 0x0000D136 File Offset: 0x0000B336
		[global::System.ComponentModel.Bindable(true)]
		public double InterCardSpacingY
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.InterCardSpacingYProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.InterCardSpacingYProperty, value);
			}
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0000D149 File Offset: 0x0000B349
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeInterCardSpacingY()
		{
			return this.InterCardSpacingY != (double)global::Infragistics.Windows.DataPresenter.CardViewSettings.InterCardSpacingYProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0000D16A File Offset: 0x0000B36A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetInterCardSpacingY()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.InterCardSpacingYProperty);
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000352 RID: 850 RVA: 0x0000D177 File Offset: 0x0000B377
		// (set) Token: 0x06000353 RID: 851 RVA: 0x0000D189 File Offset: 0x0000B389
		[global::System.ComponentModel.Bindable(true)]
		public int MaxCardCols
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.MaxCardColsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.MaxCardColsProperty, value);
			}
		}

		// Token: 0x06000354 RID: 852 RVA: 0x0000D19C File Offset: 0x0000B39C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeMaxCardCols()
		{
			return this.MaxCardCols != (int)global::Infragistics.Windows.DataPresenter.CardViewSettings.MaxCardColsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06000355 RID: 853 RVA: 0x0000D1BD File Offset: 0x0000B3BD
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetMaxCardCols()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.MaxCardColsProperty);
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000356 RID: 854 RVA: 0x0000D1CA File Offset: 0x0000B3CA
		// (set) Token: 0x06000357 RID: 855 RVA: 0x0000D1DC File Offset: 0x0000B3DC
		[global::System.ComponentModel.Bindable(true)]
		public int MaxCardRows
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.MaxCardRowsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.MaxCardRowsProperty, value);
			}
		}

		// Token: 0x06000358 RID: 856 RVA: 0x0000D1EF File Offset: 0x0000B3EF
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeMaxCardRows()
		{
			return this.MaxCardRows != (int)global::Infragistics.Windows.DataPresenter.CardViewSettings.MaxCardRowsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06000359 RID: 857 RVA: 0x0000D210 File Offset: 0x0000B410
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetMaxCardRows()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.MaxCardRowsProperty);
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600035A RID: 858 RVA: 0x0000D21D File Offset: 0x0000B41D
		// (set) Token: 0x0600035B RID: 859 RVA: 0x0000D22F File Offset: 0x0000B42F
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Controls.Orientation Orientation
		{
			get
			{
				return (global::System.Windows.Controls.Orientation)base.GetValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.OrientationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.OrientationProperty, value);
			}
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0000D242 File Offset: 0x0000B442
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeOrientation()
		{
			return this.Orientation != (global::System.Windows.Controls.Orientation)global::Infragistics.Windows.DataPresenter.CardViewSettings.OrientationProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0000D263 File Offset: 0x0000B463
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetOrientation()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.OrientationProperty);
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600035E RID: 862 RVA: 0x0000D270 File Offset: 0x0000B470
		// (set) Token: 0x0600035F RID: 863 RVA: 0x0000D282 File Offset: 0x0000B482
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Thickness Padding
		{
			get
			{
				return (global::System.Windows.Thickness)base.GetValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.PaddingProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.PaddingProperty, value);
			}
		}

		// Token: 0x06000360 RID: 864 RVA: 0x0000D295 File Offset: 0x0000B495
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializePadding()
		{
			return this.Padding != (global::System.Windows.Thickness)global::Infragistics.Windows.DataPresenter.CardViewSettings.PaddingProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0000D2B6 File Offset: 0x0000B4B6
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetPadding()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.PaddingProperty);
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000362 RID: 866 RVA: 0x0000D2C3 File Offset: 0x0000B4C3
		public static global::System.Windows.DependencyProperty RepositionAnimationProperty
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.CardViewSettings.s_RepositionAnimation;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000363 RID: 867 RVA: 0x0000D2CA File Offset: 0x0000B4CA
		// (set) Token: 0x06000364 RID: 868 RVA: 0x0000D2DC File Offset: 0x0000B4DC
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Media.Animation.DoubleAnimationBase RepositionAnimation
		{
			get
			{
				return (global::System.Windows.Media.Animation.DoubleAnimationBase)base.GetValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.RepositionAnimationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.RepositionAnimationProperty, value);
			}
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0000D2EA File Offset: 0x0000B4EA
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeRepositionAnimation()
		{
			return this.RepositionAnimation != (global::System.Windows.Media.Animation.DoubleAnimationBase)global::Infragistics.Windows.DataPresenter.CardViewSettings.RepositionAnimationProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06000366 RID: 870 RVA: 0x0000D30B File Offset: 0x0000B50B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetRepositionAnimation()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.RepositionAnimationProperty);
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000367 RID: 871 RVA: 0x0000D318 File Offset: 0x0000B518
		// (set) Token: 0x06000368 RID: 872 RVA: 0x0000D32A File Offset: 0x0000B52A
		[global::System.ComponentModel.Bindable(true)]
		public bool ShouldAnimateCardPositioning
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.ShouldAnimateCardPositioningProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.ShouldAnimateCardPositioningProperty, value);
			}
		}

		// Token: 0x06000369 RID: 873 RVA: 0x0000D33D File Offset: 0x0000B53D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeShouldAnimateCardPositioning()
		{
			return this.ShouldAnimateCardPositioning != (bool)global::Infragistics.Windows.DataPresenter.CardViewSettings.ShouldAnimateCardPositioningProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0000D35E File Offset: 0x0000B55E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetShouldAnimateCardPositioning()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.ShouldAnimateCardPositioningProperty);
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600036B RID: 875 RVA: 0x0000D36B File Offset: 0x0000B56B
		// (set) Token: 0x0600036C RID: 876 RVA: 0x0000D37D File Offset: 0x0000B57D
		[global::System.ComponentModel.Bindable(true)]
		public bool ShouldCollapseCards
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.ShouldCollapseCardsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.ShouldCollapseCardsProperty, value);
			}
		}

		// Token: 0x0600036D RID: 877 RVA: 0x0000D390 File Offset: 0x0000B590
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeShouldCollapseCards()
		{
			return this.ShouldCollapseCards != (bool)global::Infragistics.Windows.DataPresenter.CardViewSettings.ShouldCollapseCardsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x0600036E RID: 878 RVA: 0x0000D3B1 File Offset: 0x0000B5B1
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetShouldCollapseCards()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.ShouldCollapseCardsProperty);
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600036F RID: 879 RVA: 0x0000D3BE File Offset: 0x0000B5BE
		// (set) Token: 0x06000370 RID: 880 RVA: 0x0000D3D0 File Offset: 0x0000B5D0
		[global::System.ComponentModel.Bindable(true)]
		public bool ShouldCollapseEmptyCells
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.ShouldCollapseEmptyCellsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.ShouldCollapseEmptyCellsProperty, value);
			}
		}

		// Token: 0x06000371 RID: 881 RVA: 0x0000D3E3 File Offset: 0x0000B5E3
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeShouldCollapseEmptyCells()
		{
			return this.ShouldCollapseEmptyCells != (bool)global::Infragistics.Windows.DataPresenter.CardViewSettings.ShouldCollapseEmptyCellsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06000372 RID: 882 RVA: 0x0000D404 File Offset: 0x0000B604
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetShouldCollapseEmptyCells()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.ShouldCollapseEmptyCellsProperty);
		}

		// Token: 0x06000373 RID: 883 RVA: 0x0000D414 File Offset: 0x0000B614
		internal void EnumeratePropertiesWithNonDefaultValues(global::System.ComponentModel.PropertyChangedEventHandler callback)
		{
			global::System.Windows.LocalValueEnumerator localValueEnumerator = base.GetLocalValueEnumerator();
			while (localValueEnumerator.MoveNext())
			{
				global::System.Windows.LocalValueEntry localValueEntry = localValueEnumerator.Current;
				if (!object.Equals(localValueEntry.Property.DefaultMetadata.DefaultValue, localValueEntry.Value))
				{
					callback(this, new global::System.ComponentModel.PropertyChangedEventArgs(localValueEntry.Property.Name));
				}
			}
		}

		// Token: 0x06000374 RID: 884 RVA: 0x0000D472 File Offset: 0x0000B672
		private static bool ValidatePositiveDouble(object value)
		{
			return value is double && (double.IsNaN((double)value) || (double)value > 0.0);
		}

		// Token: 0x06000375 RID: 885 RVA: 0x0000D49E File Offset: 0x0000B69E
		private static bool ValidateNonNegativeInt(object value)
		{
			return value is int && (double)((int)value) >= 0.0;
		}

		// Token: 0x040000D5 RID: 213
		private const double DEFAULT_ITEM_WIDTH = 200.0;

		// Token: 0x040000D6 RID: 214
		private const double DEFAULT_ITEM_HEIGHT = 200.0;

		// Token: 0x040000D7 RID: 215
		internal const double ITEM_ANIMATION_DAMPENING = 0.6;

		// Token: 0x040000D8 RID: 216
		internal const double ITEM_ANIMATION_ATTRACTION = 2.5;

		// Token: 0x040000D9 RID: 217
		private const double ITEM_ANIMATION_DISTANCE_THRESHOLD = 0.1;

		// Token: 0x040000DA RID: 218
		public static readonly global::System.Windows.DependencyProperty AllowCardWidthResizingProperty = global::System.Windows.DependencyProperty.Register("AllowCardWidthResizing", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CardViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));

		// Token: 0x040000DB RID: 219
		public static readonly global::System.Windows.DependencyProperty AllowCardHeightResizingProperty = global::System.Windows.DependencyProperty.Register("AllowCardHeightResizing", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CardViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));

		// Token: 0x040000DC RID: 220
		public static readonly global::System.Windows.DependencyProperty AutoFitCardsProperty = global::System.Windows.DependencyProperty.Register("AutoFitCards", typeof(global::Infragistics.Windows.DataPresenter.AutoFitCards), typeof(global::Infragistics.Windows.DataPresenter.CardViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.AutoFitCards.None, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));

		// Token: 0x040000DD RID: 221
		public static readonly global::System.Windows.DependencyProperty CardHeightProperty = global::System.Windows.DependencyProperty.Register("CardHeight", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.CardViewSettings), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.CardViewSettings.ValidatePositiveDouble));

		// Token: 0x040000DE RID: 222
		public static readonly global::System.Windows.DependencyProperty CardWidthProperty = global::System.Windows.DependencyProperty.Register("CardWidth", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.CardViewSettings), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.CardViewSettings.ValidatePositiveDouble));

		// Token: 0x040000DF RID: 223
		public static readonly global::System.Windows.DependencyProperty CollapseCardButtonVisibilityProperty = global::System.Windows.DependencyProperty.Register("CollapseCardButtonVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.DataPresenter.CardViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityVisibleBox, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));

		// Token: 0x040000E0 RID: 224
		public static readonly global::System.Windows.DependencyProperty CollapseEmptyCellsButtonVisibilityProperty = global::System.Windows.DependencyProperty.Register("CollapseEmptyCellsButtonVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.DataPresenter.CardViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityCollapsedBox, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));

		// Token: 0x040000E1 RID: 225
		public static readonly global::System.Windows.DependencyProperty HeaderPathProperty = global::System.Windows.DependencyProperty.Register("HeaderPath", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.CardViewSettings), new global::System.Windows.FrameworkPropertyMetadata(string.Empty, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));

		// Token: 0x040000E2 RID: 226
		public static readonly global::System.Windows.DependencyProperty HeaderVisibilityProperty = global::System.Windows.DependencyProperty.Register("HeaderVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.DataPresenter.CardViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityVisibleBox, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));

		// Token: 0x040000E3 RID: 227
		public static readonly global::System.Windows.DependencyProperty InterCardSpacingXProperty = global::System.Windows.DependencyProperty.Register("InterCardSpacingX", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.CardViewSettings), new global::System.Windows.FrameworkPropertyMetadata(4.0, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.CardViewSettings.ValidatePositiveDouble));

		// Token: 0x040000E4 RID: 228
		public static readonly global::System.Windows.DependencyProperty InterCardSpacingYProperty = global::System.Windows.DependencyProperty.Register("InterCardSpacingY", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.CardViewSettings), new global::System.Windows.FrameworkPropertyMetadata(4.0, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.CardViewSettings.ValidatePositiveDouble));

		// Token: 0x040000E5 RID: 229
		public static readonly global::System.Windows.DependencyProperty MaxCardColsProperty = global::System.Windows.DependencyProperty.Register("MaxCardCols", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.CardViewSettings), new global::System.Windows.FrameworkPropertyMetadata(0, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.CardViewSettings.ValidateNonNegativeInt));

		// Token: 0x040000E6 RID: 230
		public static readonly global::System.Windows.DependencyProperty MaxCardRowsProperty = global::System.Windows.DependencyProperty.Register("MaxCardRows", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.CardViewSettings), new global::System.Windows.FrameworkPropertyMetadata(0, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.CardViewSettings.ValidateNonNegativeInt));

		// Token: 0x040000E7 RID: 231
		public static readonly global::System.Windows.DependencyProperty OrientationProperty = global::System.Windows.DependencyProperty.Register("Orientation", typeof(global::System.Windows.Controls.Orientation), typeof(global::Infragistics.Windows.DataPresenter.CardViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Controls.Orientation.Horizontal, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));

		// Token: 0x040000E8 RID: 232
		public static readonly global::System.Windows.DependencyProperty PaddingProperty = global::System.Windows.DependencyProperty.Register("Padding", typeof(global::System.Windows.Thickness), typeof(global::Infragistics.Windows.DataPresenter.CardViewSettings), new global::System.Windows.FrameworkPropertyMetadata(default(global::System.Windows.Thickness), global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));

		// Token: 0x040000E9 RID: 233
		private static global::System.Windows.DependencyProperty s_RepositionAnimation;

		// Token: 0x040000EA RID: 234
		public static readonly global::System.Windows.DependencyProperty ShouldAnimateCardPositioningProperty = global::System.Windows.DependencyProperty.Register("ShouldAnimateCardPositioning", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CardViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox));

		// Token: 0x040000EB RID: 235
		public static readonly global::System.Windows.DependencyProperty ShouldCollapseCardsProperty = global::System.Windows.DependencyProperty.Register("ShouldCollapseCards", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CardViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));

		// Token: 0x040000EC RID: 236
		public static readonly global::System.Windows.DependencyProperty ShouldCollapseEmptyCellsProperty = global::System.Windows.DependencyProperty.Register("ShouldCollapseEmptyCells", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CardViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));
	}
}
