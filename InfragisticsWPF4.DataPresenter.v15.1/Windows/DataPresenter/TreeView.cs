using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Windows.DataPresenter.Events;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000211 RID: 529
	public class TreeView : global::Infragistics.Windows.DataPresenter.GridViewBase
	{
		// Token: 0x06001FC6 RID: 8134 RVA: 0x00089ED0 File Offset: 0x000880D0
		public TreeView()
		{
			base.SetValue(global::Infragistics.Windows.DataPresenter.TreeView.ViewSettingsProperty, this.ViewSettings);
		}

		// Token: 0x06001FC7 RID: 8135 RVA: 0x00089EE9 File Offset: 0x000880E9
		private static object OnCoerceViewSettings(global::System.Windows.DependencyObject d, object value)
		{
			if (value == null)
			{
				return new global::Infragistics.Windows.DataPresenter.TreeViewSettings();
			}
			return value;
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x06001FC8 RID: 8136 RVA: 0x00089EF5 File Offset: 0x000880F5
		// (set) Token: 0x06001FC9 RID: 8137 RVA: 0x00089F10 File Offset: 0x00088110
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.TreeViewSettings ViewSettings
		{
			get
			{
				if (this._viewSettings == null)
				{
					this._viewSettings = new global::Infragistics.Windows.DataPresenter.TreeViewSettings();
				}
				return this._viewSettings;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.TreeView.ViewSettingsProperty, value);
			}
		}

		// Token: 0x06001FCA RID: 8138 RVA: 0x00089F1E File Offset: 0x0008811E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeViewSettings()
		{
			return this.ViewSettings != (global::Infragistics.Windows.DataPresenter.TreeViewSettings)global::Infragistics.Windows.DataPresenter.TreeView.ViewSettingsProperty.DefaultMetadata.DefaultValue;
		}

		// Token: 0x06001FCB RID: 8139 RVA: 0x00089F3F File Offset: 0x0008813F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetViewSettings()
		{
			base.ClearValue(global::Infragistics.Windows.DataPresenter.TreeView.ViewSettingsProperty);
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x06001FCC RID: 8140 RVA: 0x00089F4C File Offset: 0x0008814C
		protected internal override bool IsAutoFitHeightSupported
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x06001FCD RID: 8141 RVA: 0x00089F4F File Offset: 0x0008814F
		protected internal override bool IsAutoFitWidthSupported
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x06001FCE RID: 8142 RVA: 0x00089F52 File Offset: 0x00088152
		protected internal override bool IsCrossLevelSelectionSupported
		{
			get
			{
				return this.ViewSettings.SelectionDepthMode != global::Infragistics.Windows.DataPresenter.SelectionDepthMode.Single;
			}
		}

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x06001FCF RID: 8143 RVA: 0x00089F65 File Offset: 0x00088165
		protected internal override bool IsFixingSupportedForNestedRecords
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x06001FD0 RID: 8144 RVA: 0x00089F68 File Offset: 0x00088168
		protected internal override bool IsGroupBySupported
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06001FD1 RID: 8145 RVA: 0x00089F6B File Offset: 0x0008816B
		internal override bool IsTreeView
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x06001FD2 RID: 8146 RVA: 0x00089F6E File Offset: 0x0008816E
		protected internal override global::System.Type ItemsPanelType
		{
			get
			{
				return typeof(global::Infragistics.Windows.DataPresenter.TreeViewPanel);
			}
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x06001FD3 RID: 8147 RVA: 0x00089F7C File Offset: 0x0008817C
		internal override double LevelIndentationResolved
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.TreeViewSettings viewSettings = this.ViewSettings;
				if (viewSettings == null)
				{
					return (double)global::Infragistics.Windows.DataPresenter.TreeViewSettings.IndentPerLevelProperty.DefaultMetadata.DefaultValue;
				}
				return viewSettings.IndentPerLevel;
			}
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x06001FD4 RID: 8148 RVA: 0x00089FAE File Offset: 0x000881AE
		protected internal override global::System.Windows.Controls.Orientation LogicalOrientation
		{
			get
			{
				return global::System.Windows.Controls.Orientation.Vertical;
			}
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06001FD5 RID: 8149 RVA: 0x00089FB1 File Offset: 0x000881B1
		protected internal override global::Infragistics.Windows.DataPresenter.DataDisplayMode SupportedDataDisplayMode
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.DataDisplayMode.FlattenedHierarchical;
			}
		}

		// Token: 0x06001FD6 RID: 8150 RVA: 0x00089FB4 File Offset: 0x000881B4
		protected internal override global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator GetFieldLayoutTemplateGenerator(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			return new global::Infragistics.Windows.DataPresenter.HeaderedGridViewFieldLayoutTemplateGenerator(fieldLayout, global::System.Windows.Controls.Orientation.Vertical);
		}

		// Token: 0x06001FD7 RID: 8151 RVA: 0x00089FC0 File Offset: 0x000881C0
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			if (e.Property == global::Infragistics.Windows.DataPresenter.TreeView.ViewSettingsProperty)
			{
				if (this._viewSettings != null)
				{
					this._viewSettings.PropertyChanged -= this.OnViewSettingsPropertyChanged;
				}
				this._viewSettings = (e.NewValue as global::Infragistics.Windows.DataPresenter.TreeViewSettings);
				if (this._viewSettings != null)
				{
					this._viewSettings.PropertyChanged += this.OnViewSettingsPropertyChanged;
				}
				base.RaiseViewStateChanged(new global::Infragistics.Windows.DataPresenter.Events.ViewStateChangedEventArgs(global::Infragistics.Windows.DataPresenter.ViewStateChangedAction.InvalidateMeasure));
			}
		}

		// Token: 0x06001FD8 RID: 8152 RVA: 0x0008A040 File Offset: 0x00088240
		private void OnViewSettingsPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			string propertyName;
			switch (propertyName = e.PropertyName)
			{
			case "AllowLastRecordScrollToTop":
			case "FilterResultsDisplayMode":
			case "IndentPerLevel":
			case "TreeLinePen":
			case "TreeLineVisibility":
				base.RaiseViewStateChanged(new global::Infragistics.Windows.DataPresenter.Events.ViewStateChangedEventArgs(global::Infragistics.Windows.DataPresenter.ViewStateChangedAction.InvalidateMeasure));
				return;
			case "TreeFieldName":
				base.RaiseViewStateChanged(new global::Infragistics.Windows.DataPresenter.Events.ViewStateChangedEventArgs(global::Infragistics.Windows.DataPresenter.ViewStateChangedAction.InvalidateFieldLayouts));
				break;
			case "SelectionDepthMode":
				break;

				return;
			}
		}

		// Token: 0x04000D5D RID: 3421
		private global::Infragistics.Windows.DataPresenter.TreeViewSettings _viewSettings;

		// Token: 0x04000D5E RID: 3422
		public static readonly global::System.Windows.DependencyProperty ViewSettingsProperty = global::System.Windows.DependencyProperty.Register("ViewSettings", typeof(global::Infragistics.Windows.DataPresenter.TreeViewSettings), typeof(global::Infragistics.Windows.DataPresenter.TreeView), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.TreeView.OnCoerceViewSettings)));
	}
}
