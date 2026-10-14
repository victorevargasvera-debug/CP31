using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000216 RID: 534
	public class TreeViewSettings : global::Infragistics.Windows.DataPresenter.GridViewSettingsBase
	{
		// Token: 0x06001FF8 RID: 8184 RVA: 0x0008B68D File Offset: 0x0008988D
		protected internal override void OnControlInitialized()
		{
		}

		// Token: 0x06001FF9 RID: 8185 RVA: 0x0008B690 File Offset: 0x00089890
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override void Reset()
		{
			base.Reset();
			base.ClearValue(global::Infragistics.Windows.DataPresenter.TreeViewSettings.FilterResultsDisplayModeProperty);
			base.ClearValue(global::Infragistics.Windows.DataPresenter.TreeViewSettings.IndentPerLevelProperty);
			base.ClearValue(global::Infragistics.Windows.DataPresenter.TreeViewSettings.SelectionDepthModeProperty);
			base.ClearValue(global::Infragistics.Windows.DataPresenter.TreeViewSettings.TreeFieldNameProperty);
			base.ClearValue(global::Infragistics.Windows.DataPresenter.TreeViewSettings.TreeLinePenProperty);
			base.ClearValue(global::Infragistics.Windows.DataPresenter.TreeViewSettings.TreeLineVisibilityProperty);
		}

		// Token: 0x06001FFA RID: 8186 RVA: 0x0008B6E8 File Offset: 0x000898E8
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool ShouldSerialize()
		{
			return base.ShouldSerialize() || this.FilterResultsDisplayMode != (global::Infragistics.Windows.DataPresenter.TreeViewFilterResultsDisplayMode)global::Infragistics.Windows.DataPresenter.TreeViewSettings.FilterResultsDisplayModeProperty.DefaultMetadata.DefaultValue || this.IndentPerLevel != (double)global::Infragistics.Windows.DataPresenter.TreeViewSettings.IndentPerLevelProperty.DefaultMetadata.DefaultValue || this.SelectionDepthMode != (global::Infragistics.Windows.DataPresenter.SelectionDepthMode)global::Infragistics.Windows.DataPresenter.TreeViewSettings.SelectionDepthModeProperty.GetMetadata(this).DefaultValue || !string.IsNullOrWhiteSpace(this.TreeFieldName) || this.TreeLinePen != null || this.TreeLineVisibility != (global::System.Windows.Visibility)global::Infragistics.Windows.DataPresenter.TreeViewSettings.TreeLineVisibilityProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x06001FFB RID: 8187 RVA: 0x0008B78B File Offset: 0x0008998B
		// (set) Token: 0x06001FFC RID: 8188 RVA: 0x0008B79D File Offset: 0x0008999D
		public global::Infragistics.Windows.DataPresenter.TreeViewFilterResultsDisplayMode FilterResultsDisplayMode
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.TreeViewFilterResultsDisplayMode)base.GetValue(global::Infragistics.Windows.DataPresenter.TreeViewSettings.FilterResultsDisplayModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.TreeViewSettings.FilterResultsDisplayModeProperty, value);
			}
		}

		// Token: 0x06001FFD RID: 8189 RVA: 0x0008B7B0 File Offset: 0x000899B0
		private static bool ValidateIndentPerLevel(object value)
		{
			return value is double && !double.IsNaN((double)value) && !double.IsInfinity((double)value) && (double)value >= 0.0;
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06001FFE RID: 8190 RVA: 0x0008B7EC File Offset: 0x000899EC
		// (set) Token: 0x06001FFF RID: 8191 RVA: 0x0008B7FE File Offset: 0x000899FE
		public double IndentPerLevel
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.DataPresenter.TreeViewSettings.IndentPerLevelProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.TreeViewSettings.IndentPerLevelProperty, value);
			}
		}

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x06002000 RID: 8192 RVA: 0x0008B811 File Offset: 0x00089A11
		// (set) Token: 0x06002001 RID: 8193 RVA: 0x0008B823 File Offset: 0x00089A23
		[global::System.ComponentModel.Description("Determines which records are included when doing a Record or Cell Range selection")]
		[global::System.ComponentModel.Category("Behavior")]
		public global::Infragistics.Windows.DataPresenter.SelectionDepthMode SelectionDepthMode
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.SelectionDepthMode)base.GetValue(global::Infragistics.Windows.DataPresenter.TreeViewSettings.SelectionDepthModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.TreeViewSettings.SelectionDepthModeProperty, value);
			}
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06002002 RID: 8194 RVA: 0x0008B836 File Offset: 0x00089A36
		// (set) Token: 0x06002003 RID: 8195 RVA: 0x0008B848 File Offset: 0x00089A48
		[global::System.ComponentModel.DefaultValue(null)]
		public string TreeFieldName
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.DataPresenter.TreeViewSettings.TreeFieldNameProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.TreeViewSettings.TreeFieldNameProperty, value);
			}
		}

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x06002004 RID: 8196 RVA: 0x0008B856 File Offset: 0x00089A56
		// (set) Token: 0x06002005 RID: 8197 RVA: 0x0008B868 File Offset: 0x00089A68
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Media.Pen TreeLinePen
		{
			get
			{
				return (global::System.Windows.Media.Pen)base.GetValue(global::Infragistics.Windows.DataPresenter.TreeViewSettings.TreeLinePenProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.TreeViewSettings.TreeLinePenProperty, value);
			}
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06002006 RID: 8198 RVA: 0x0008B876 File Offset: 0x00089A76
		// (set) Token: 0x06002007 RID: 8199 RVA: 0x0008B888 File Offset: 0x00089A88
		public global::System.Windows.Visibility TreeLineVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.DataPresenter.TreeViewSettings.TreeLineVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.TreeViewSettings.TreeLineVisibilityProperty, value);
			}
		}

		// Token: 0x04000D74 RID: 3444
		public static readonly global::System.Windows.DependencyProperty FilterResultsDisplayModeProperty = global::System.Windows.DependencyProperty.Register("FilterResultsDisplayMode", typeof(global::Infragistics.Windows.DataPresenter.TreeViewFilterResultsDisplayMode), typeof(global::Infragistics.Windows.DataPresenter.TreeViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.TreeViewFilterResultsDisplayMode.ShowWithAncestors));

		// Token: 0x04000D75 RID: 3445
		public static readonly global::System.Windows.DependencyProperty IndentPerLevelProperty = global::System.Windows.DependencyProperty.Register("IndentPerLevel", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.TreeViewSettings), new global::System.Windows.FrameworkPropertyMetadata(15.0), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DataPresenter.TreeViewSettings.ValidateIndentPerLevel));

		// Token: 0x04000D76 RID: 3446
		public static readonly global::System.Windows.DependencyProperty SelectionDepthModeProperty = global::System.Windows.DependencyProperty.Register("SelectionDepthMode", typeof(global::Infragistics.Windows.DataPresenter.SelectionDepthMode), typeof(global::Infragistics.Windows.DataPresenter.TreeViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.SelectionDepthMode.VisibleOnly));

		// Token: 0x04000D77 RID: 3447
		public static readonly global::System.Windows.DependencyProperty TreeFieldNameProperty = global::System.Windows.DependencyProperty.Register("TreeFieldName", typeof(string), typeof(global::Infragistics.Windows.DataPresenter.TreeViewSettings), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000D78 RID: 3448
		public static readonly global::System.Windows.DependencyProperty TreeLinePenProperty = global::System.Windows.DependencyProperty.Register("TreeLinePen", typeof(global::System.Windows.Media.Pen), typeof(global::Infragistics.Windows.DataPresenter.TreeViewSettings), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000D79 RID: 3449
		public static readonly global::System.Windows.DependencyProperty TreeLineVisibilityProperty = global::System.Windows.DependencyProperty.Register("TreeLineVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.DataPresenter.TreeViewSettings), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityVisibleBox));
	}
}
