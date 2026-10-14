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
		// Token: 0x06000305 RID: 773 RVA: 0x0000BE30 File Offset: 0x0000A030
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

		// Token: 0x06000306 RID: 774 RVA: 0x0000C281 File Offset: 0x0000A481
		protected internal override void OnControlInitialized()
		{
		}

		// Token: 0x06000307 RID: 775 RVA: 0x0000C284 File Offset: 0x0000A484
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

		// Token: 0x06000308 RID: 776 RVA: 0x0000C304 File Offset: 0x0000A504
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool ShouldSerialize()
		{
			return this.ShouldSerializeAllowCardWidthResizing() || this.ShouldSerializeAllowCardHeightResizing() || this.ShouldSerializeAutoFitCards() || this.ShouldSerializeCardHeight() || this.ShouldSerializeCardWidth() || this.ShouldSerializeCollapseCardButtonVisibility() || this.ShouldSerializeCollapseEmptyCellsButtonVisibility() || this.ShouldSerializeHeaderPath() || this.ShouldSerializeHeaderVisibility() || this.ShouldSerializeInterCardSpacingX() || this.ShouldSerializeInterCardSpacingY() || this.ShouldSerializeMaxCardCols() || this.ShouldSerializeMaxCardRows() || this.ShouldSerializeOrientation() || this.ShouldSerializePadding() || this.ShouldSerializeRepositionAnimation() || this.ShouldSerializeShouldAnimateCardPositioning() || this.ShouldSerializeShouldCollapseCards() || this.ShouldSerializeShouldCollapseEmptyCells();
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000309 RID: 777 RVA: 0x0000C3AF File Offset: 0x0000A5AF
		// (set) Token: 0x0600030A RID: 778 RVA: 0x0000C3C1 File Offset: 0x0000A5C1
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

		// Token: 0x0600030B RID: 779 RVA: 0x0000C3D4 File Offset: 0x0000A5D4
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeAllowCardWidthResizing()
		{
			return this.AllowCardWidthResizing != (bool)global::Infragistics.Windows.DataPresenter.CardViewSettings.AllowCardWidthResizingProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x0600030C RID: 780 RVA: 0x0000C3F5 File Offset: 0x0000A5F5
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetAllowCardWidthResizing()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.AllowCardWidthResizingProperty);
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600030D RID: 781 RVA: 0x0000C402 File Offset: 0x0000A602
		// (set) Token: 0x0600030E RID: 782 RVA: 0x0000C414 File Offset: 0x0000A614
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

		// Token: 0x0600030F RID: 783 RVA: 0x0000C427 File Offset: 0x0000A627
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeAllowCardHeightResizing()
		{
			return this.AllowCardHeightResizing != (bool)global::Infragistics.Windows.DataPresenter.CardViewSettings.AllowCardHeightResizingProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0000C448 File Offset: 0x0000A648
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetAllowCardHeightResizing()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.AllowCardHeightResizingProperty);
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000311 RID: 785 RVA: 0x0000C455 File Offset: 0x0000A655
		// (set) Token: 0x06000312 RID: 786 RVA: 0x0000C467 File Offset: 0x0000A667
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

		// Token: 0x06000313 RID: 787 RVA: 0x0000C47A File Offset: 0x0000A67A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeAutoFitCards()
		{
			return this.AutoFitCards != (global::Infragistics.Windows.DataPresenter.AutoFitCards)global::Infragistics.Windows.DataPresenter.CardViewSettings.AutoFitCardsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06000314 RID: 788 RVA: 0x0000C49B File Offset: 0x0000A69B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetAutoFitCards()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.AutoFitCardsProperty);
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000315 RID: 789 RVA: 0x0000C4A8 File Offset: 0x0000A6A8
		// (set) Token: 0x06000316 RID: 790 RVA: 0x0000C4BA File Offset: 0x0000A6BA
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

		// Token: 0x06000317 RID: 791 RVA: 0x0000C4CD File Offset: 0x0000A6CD
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeCardHeight()
		{
			return this.CardHeight != (double)global::Infragistics.Windows.DataPresenter.CardViewSettings.CardHeightProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06000318 RID: 792 RVA: 0x0000C4EE File Offset: 0x0000A6EE
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetCardHeight()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.CardHeightProperty);
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000319 RID: 793 RVA: 0x0000C4FB File Offset: 0x0000A6FB
		// (set) Token: 0x0600031A RID: 794 RVA: 0x0000C50D File Offset: 0x0000A70D
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

		// Token: 0x0600031B RID: 795 RVA: 0x0000C520 File Offset: 0x0000A720
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeCardWidth()
		{
			return this.CardWidth != (double)global::Infragistics.Windows.DataPresenter.CardViewSettings.CardWidthProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0000C541 File Offset: 0x0000A741
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetCardWidth()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.CardWidthProperty);
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600031D RID: 797 RVA: 0x0000C54E File Offset: 0x0000A74E
		// (set) Token: 0x0600031E RID: 798 RVA: 0x0000C560 File Offset: 0x0000A760
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

		// Token: 0x0600031F RID: 799 RVA: 0x0000C573 File Offset: 0x0000A773
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeCollapseCardButtonVisibility()
		{
			return this.CollapseCardButtonVisibility != (global::System.Windows.Visibility)global::Infragistics.Windows.DataPresenter.CardViewSettings.CollapseCardButtonVisibilityProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06000320 RID: 800 RVA: 0x0000C594 File Offset: 0x0000A794
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetCollapseCardButtonVisibility()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.CollapseCardButtonVisibilityProperty);
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000321 RID: 801 RVA: 0x0000C5A1 File Offset: 0x0000A7A1
		// (set) Token: 0x06000322 RID: 802 RVA: 0x0000C5B3 File Offset: 0x0000A7B3
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

		// Token: 0x06000323 RID: 803 RVA: 0x0000C5C6 File Offset: 0x0000A7C6
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeCollapseEmptyCellsButtonVisibility()
		{
			return this.CollapseEmptyCellsButtonVisibility != (global::System.Windows.Visibility)global::Infragistics.Windows.DataPresenter.CardViewSettings.CollapseEmptyCellsButtonVisibilityProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0000C5E7 File Offset: 0x0000A7E7
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetCollapseEmptyCellsButtonVisibility()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.CollapseEmptyCellsButtonVisibilityProperty);
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000325 RID: 805 RVA: 0x0000C5F4 File Offset: 0x0000A7F4
		// (set) Token: 0x06000326 RID: 806 RVA: 0x0000C606 File Offset: 0x0000A806
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

		// Token: 0x06000327 RID: 807 RVA: 0x0000C614 File Offset: 0x0000A814
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeHeaderPath()
		{
			return this.HeaderPath != (string)global::Infragistics.Windows.DataPresenter.CardViewSettings.HeaderPathProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06000328 RID: 808 RVA: 0x0000C635 File Offset: 0x0000A835
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetHeaderPath()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.HeaderPathProperty);
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000329 RID: 809 RVA: 0x0000C642 File Offset: 0x0000A842
		// (set) Token: 0x0600032A RID: 810 RVA: 0x0000C654 File Offset: 0x0000A854
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

		// Token: 0x0600032B RID: 811 RVA: 0x0000C667 File Offset: 0x0000A867
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeHeaderVisibility()
		{
			return this.HeaderVisibility != (global::System.Windows.Visibility)global::Infragistics.Windows.DataPresenter.CardViewSettings.HeaderVisibilityProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0000C688 File Offset: 0x0000A888
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetHeaderVisibility()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.HeaderVisibilityProperty);
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600032D RID: 813 RVA: 0x0000C695 File Offset: 0x0000A895
		// (set) Token: 0x0600032E RID: 814 RVA: 0x0000C6A7 File Offset: 0x0000A8A7
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

		// Token: 0x0600032F RID: 815 RVA: 0x0000C6BA File Offset: 0x0000A8BA
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeInterCardSpacingX()
		{
			return this.InterCardSpacingX != (double)global::Infragistics.Windows.DataPresenter.CardViewSettings.InterCardSpacingXProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0000C6DB File Offset: 0x0000A8DB
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetInterCardSpacingX()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.InterCardSpacingXProperty);
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000331 RID: 817 RVA: 0x0000C6E8 File Offset: 0x0000A8E8
		// (set) Token: 0x06000332 RID: 818 RVA: 0x0000C6FA File Offset: 0x0000A8FA
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

		// Token: 0x06000333 RID: 819 RVA: 0x0000C70D File Offset: 0x0000A90D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeInterCardSpacingY()
		{
			return this.InterCardSpacingY != (double)global::Infragistics.Windows.DataPresenter.CardViewSettings.InterCardSpacingYProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0000C72E File Offset: 0x0000A92E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetInterCardSpacingY()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.InterCardSpacingYProperty);
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000335 RID: 821 RVA: 0x0000C73B File Offset: 0x0000A93B
		// (set) Token: 0x06000336 RID: 822 RVA: 0x0000C74D File Offset: 0x0000A94D
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

		// Token: 0x06000337 RID: 823 RVA: 0x0000C760 File Offset: 0x0000A960
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeMaxCardCols()
		{
			return this.MaxCardCols != (int)global::Infragistics.Windows.DataPresenter.CardViewSettings.MaxCardColsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06000338 RID: 824 RVA: 0x0000C781 File Offset: 0x0000A981
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetMaxCardCols()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.MaxCardColsProperty);
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000339 RID: 825 RVA: 0x0000C78E File Offset: 0x0000A98E
		// (set) Token: 0x0600033A RID: 826 RVA: 0x0000C7A0 File Offset: 0x0000A9A0
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

		// Token: 0x0600033B RID: 827 RVA: 0x0000C7B3 File Offset: 0x0000A9B3
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeMaxCardRows()
		{
			return this.MaxCardRows != (int)global::Infragistics.Windows.DataPresenter.CardViewSettings.MaxCardRowsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x0600033C RID: 828 RVA: 0x0000C7D4 File Offset: 0x0000A9D4
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetMaxCardRows()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.MaxCardRowsProperty);
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600033D RID: 829 RVA: 0x0000C7E1 File Offset: 0x0000A9E1
		// (set) Token: 0x0600033E RID: 830 RVA: 0x0000C7F3 File Offset: 0x0000A9F3
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

		// Token: 0x0600033F RID: 831 RVA: 0x0000C806 File Offset: 0x0000AA06
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeOrientation()
		{
			return this.Orientation != (global::System.Windows.Controls.Orientation)global::Infragistics.Windows.DataPresenter.CardViewSettings.OrientationProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06000340 RID: 832 RVA: 0x0000C827 File Offset: 0x0000AA27
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetOrientation()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.OrientationProperty);
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000341 RID: 833 RVA: 0x0000C834 File Offset: 0x0000AA34
		// (set) Token: 0x06000342 RID: 834 RVA: 0x0000C846 File Offset: 0x0000AA46
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

		// Token: 0x06000343 RID: 835 RVA: 0x0000C859 File Offset: 0x0000AA59
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializePadding()
		{
			return this.Padding != (global::System.Windows.Thickness)global::Infragistics.Windows.DataPresenter.CardViewSettings.PaddingProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0000C87A File Offset: 0x0000AA7A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetPadding()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.PaddingProperty);
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000345 RID: 837 RVA: 0x0000C887 File Offset: 0x0000AA87
		public static global::System.Windows.DependencyProperty RepositionAnimationProperty
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.CardViewSettings.s_RepositionAnimation;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000346 RID: 838 RVA: 0x0000C88E File Offset: 0x0000AA8E
		// (set) Token: 0x06000347 RID: 839 RVA: 0x0000C8A0 File Offset: 0x0000AAA0
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

		// Token: 0x06000348 RID: 840 RVA: 0x0000C8AE File Offset: 0x0000AAAE
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeRepositionAnimation()
		{
			return this.RepositionAnimation != (global::System.Windows.Media.Animation.DoubleAnimationBase)global::Infragistics.Windows.DataPresenter.CardViewSettings.RepositionAnimationProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0000C8CF File Offset: 0x0000AACF
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetRepositionAnimation()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.RepositionAnimationProperty);
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600034A RID: 842 RVA: 0x0000C8DC File Offset: 0x0000AADC
		// (set) Token: 0x0600034B RID: 843 RVA: 0x0000C8EE File Offset: 0x0000AAEE
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

		// Token: 0x0600034C RID: 844 RVA: 0x0000C901 File Offset: 0x0000AB01
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeShouldAnimateCardPositioning()
		{
			return this.ShouldAnimateCardPositioning != (bool)global::Infragistics.Windows.DataPresenter.CardViewSettings.ShouldAnimateCardPositioningProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0000C922 File Offset: 0x0000AB22
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetShouldAnimateCardPositioning()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.ShouldAnimateCardPositioningProperty);
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600034E RID: 846 RVA: 0x0000C92F File Offset: 0x0000AB2F
		// (set) Token: 0x0600034F RID: 847 RVA: 0x0000C941 File Offset: 0x0000AB41
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

		// Token: 0x06000350 RID: 848 RVA: 0x0000C954 File Offset: 0x0000AB54
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeShouldCollapseCards()
		{
			return this.ShouldCollapseCards != (bool)global::Infragistics.Windows.DataPresenter.CardViewSettings.ShouldCollapseCardsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0000C975 File Offset: 0x0000AB75
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetShouldCollapseCards()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.ShouldCollapseCardsProperty);
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000352 RID: 850 RVA: 0x0000C982 File Offset: 0x0000AB82
		// (set) Token: 0x06000353 RID: 851 RVA: 0x0000C994 File Offset: 0x0000AB94
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

		// Token: 0x06000354 RID: 852 RVA: 0x0000C9A7 File Offset: 0x0000ABA7
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeShouldCollapseEmptyCells()
		{
			return this.ShouldCollapseEmptyCells != (bool)global::Infragistics.Windows.DataPresenter.CardViewSettings.ShouldCollapseEmptyCellsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06000355 RID: 853 RVA: 0x0000C9C8 File Offset: 0x0000ABC8
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetShouldCollapseEmptyCells()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.CardViewSettings.ShouldCollapseEmptyCellsProperty);
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0000C9D8 File Offset: 0x0000ABD8
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

		// Token: 0x06000357 RID: 855 RVA: 0x0000CA36 File Offset: 0x0000AC36
		private static bool ValidatePositiveDouble(object value)
		{
			return value is double && (double.IsNaN((double)value) || (double)value > 0.0);
		}

		// Token: 0x06000358 RID: 856 RVA: 0x0000CA62 File Offset: 0x0000AC62
		private static bool ValidateNonNegativeInt(object value)
		{
			return value is int && (double)((int)value) >= 0.0;
		}

		// Token: 0x040000C2 RID: 194
		private const double DEFAULT_ITEM_WIDTH = 200.0;

		// Token: 0x040000C3 RID: 195
		private const double DEFAULT_ITEM_HEIGHT = 200.0;

		// Token: 0x040000C4 RID: 196
		internal const double ITEM_ANIMATION_DAMPENING = 0.6;

		// Token: 0x040000C5 RID: 197
		internal const double ITEM_ANIMATION_ATTRACTION = 2.5;

		// Token: 0x040000C6 RID: 198
		private const double ITEM_ANIMATION_DISTANCE_THRESHOLD = 0.1;

		// Token: 0x040000C7 RID: 199
		public static readonly global::System.Windows.DependencyProperty AllowCardWidthResizingProperty = global::System.Windows.DependencyProperty.Register("AllowCardWidthResizing", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CardViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));

		// Token: 0x040000C8 RID: 200
		public static readonly global::System.Windows.DependencyProperty AllowCardHeightResizingProperty = global::System.Windows.DependencyProperty.Register("AllowCardHeightResizing", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CardViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));

		// Token: 0x040000C9 RID: 201
		public static readonly global::System.Windows.DependencyProperty AutoFitCardsProperty = global::System.Windows.DependencyProperty.Register("AutoFitCards", typeof(global::Infragistics.Windows.DataPresenter.AutoFitCards), typeof(global::Infragistics.Windows.DataPresenter.CardViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.AutoFitCards.None, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));

		// Token: 0x040000CA RID: 202
		public static readonly global::System.Windows.DependencyProperty CardHeightProperty = global::System.Windows.DependencyProperty.Register("CardHeight", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.CardViewSettings), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.CardViewSettings.ValidatePositiveDouble));

		// Token: 0x040000CB RID: 203
		public static readonly global::System.Windows.DependencyProperty CardWidthProperty = global::System.Windows.DependencyProperty.Register("CardWidth", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.CardViewSettings), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.CardViewSettings.ValidatePositiveDouble));

		// Token: 0x040000CC RID: 204
		public static readonly global::System.Windows.DependencyProperty CollapseCardButtonVisibilityProperty = global::System.Windows.DependencyProperty.Register("CollapseCardButtonVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.DataPresenter.CardViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityVisibleBox, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));

		// Token: 0x040000CD RID: 205
		public static readonly global::System.Windows.DependencyProperty CollapseEmptyCellsButtonVisibilityProperty = global::System.Windows.DependencyProperty.Register("CollapseEmptyCellsButtonVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.DataPresenter.CardViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityCollapsedBox, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));

		// Token: 0x040000CE RID: 206
		public static readonly global::System.Windows.DependencyProperty HeaderPathProperty = global::System.Windows.DependencyProperty.Register("HeaderPath", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.CardViewSettings), new global::System.Windows.FrameworkPropertyMetadata(string.Empty, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));

		// Token: 0x040000CF RID: 207
		public static readonly global::System.Windows.DependencyProperty HeaderVisibilityProperty = global::System.Windows.DependencyProperty.Register("HeaderVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.DataPresenter.CardViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityVisibleBox, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));

		// Token: 0x040000D0 RID: 208
		public static readonly global::System.Windows.DependencyProperty InterCardSpacingXProperty = global::System.Windows.DependencyProperty.Register("InterCardSpacingX", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.CardViewSettings), new global::System.Windows.FrameworkPropertyMetadata(4.0, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.CardViewSettings.ValidatePositiveDouble));

		// Token: 0x040000D1 RID: 209
		public static readonly global::System.Windows.DependencyProperty InterCardSpacingYProperty = global::System.Windows.DependencyProperty.Register("InterCardSpacingY", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.CardViewSettings), new global::System.Windows.FrameworkPropertyMetadata(4.0, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.CardViewSettings.ValidatePositiveDouble));

		// Token: 0x040000D2 RID: 210
		public static readonly global::System.Windows.DependencyProperty MaxCardColsProperty = global::System.Windows.DependencyProperty.Register("MaxCardCols", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.CardViewSettings), new global::System.Windows.FrameworkPropertyMetadata(0, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.CardViewSettings.ValidateNonNegativeInt));

		// Token: 0x040000D3 RID: 211
		public static readonly global::System.Windows.DependencyProperty MaxCardRowsProperty = global::System.Windows.DependencyProperty.Register("MaxCardRows", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.CardViewSettings), new global::System.Windows.FrameworkPropertyMetadata(0, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.CardViewSettings.ValidateNonNegativeInt));

		// Token: 0x040000D4 RID: 212
		public static readonly global::System.Windows.DependencyProperty OrientationProperty = global::System.Windows.DependencyProperty.Register("Orientation", typeof(global::System.Windows.Controls.Orientation), typeof(global::Infragistics.Windows.DataPresenter.CardViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Controls.Orientation.Horizontal, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));

		// Token: 0x040000D5 RID: 213
		public static readonly global::System.Windows.DependencyProperty PaddingProperty = global::System.Windows.DependencyProperty.Register("Padding", typeof(global::System.Windows.Thickness), typeof(global::Infragistics.Windows.DataPresenter.CardViewSettings), new global::System.Windows.FrameworkPropertyMetadata(default(global::System.Windows.Thickness), global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));

		// Token: 0x040000D6 RID: 214
		private static global::System.Windows.DependencyProperty s_RepositionAnimation;

		// Token: 0x040000D7 RID: 215
		public static readonly global::System.Windows.DependencyProperty ShouldAnimateCardPositioningProperty = global::System.Windows.DependencyProperty.Register("ShouldAnimateCardPositioning", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CardViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox));

		// Token: 0x040000D8 RID: 216
		public static readonly global::System.Windows.DependencyProperty ShouldCollapseCardsProperty = global::System.Windows.DependencyProperty.Register("ShouldCollapseCards", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CardViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));

		// Token: 0x040000D9 RID: 217
		public static readonly global::System.Windows.DependencyProperty ShouldCollapseEmptyCellsProperty = global::System.Windows.DependencyProperty.Register("ShouldCollapseEmptyCells", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CardViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));
	}
}
