using System;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001CE RID: 462
	public abstract class RecordPrefixArea : global::System.Windows.Controls.ContentControl
	{
		// Token: 0x06001B31 RID: 6961 RVA: 0x0007A5BB File Offset: 0x000787BB
		public RecordPrefixArea()
		{
			this._styleSelectorHelper = this.CreateStyleSelectorHelper();
		}

		// Token: 0x06001B32 RID: 6962 RVA: 0x0007A5D0 File Offset: 0x000787D0
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			if (e.Property == global::System.Windows.FrameworkElement.DataContextProperty)
			{
				global::Infragistics.Windows.DataPresenter.Record record = e.NewValue as global::Infragistics.Windows.DataPresenter.Record;
				if (record != this._record)
				{
					if (this._record != null)
					{
						this._record = null;
					}
					else
					{
						this._record = record;
					}
					base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPrefixArea.RecordPropertyKey, this._record);
					return;
				}
			}
			else if (e.Property == global::Infragistics.Windows.DataPresenter.RecordPrefixArea.InternalVersionProperty)
			{
				this.InitializeVersionInfo();
			}
		}

		// Token: 0x06001B33 RID: 6963 RVA: 0x0007A648 File Offset: 0x00078848
		private static void OnFieldLayoutChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.RecordPrefixArea recordPrefixArea = target as global::Infragistics.Windows.DataPresenter.RecordPrefixArea;
			if (recordPrefixArea != null)
			{
				recordPrefixArea._cachedFieldLayout = (e.NewValue as global::Infragistics.Windows.DataPresenter.FieldLayout);
				recordPrefixArea.InitializeVersionInfo();
			}
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x06001B34 RID: 6964 RVA: 0x0007A677 File Offset: 0x00078877
		// (set) Token: 0x06001B35 RID: 6965 RVA: 0x0007A67F File Offset: 0x0007887F
		public global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				return this._cachedFieldLayout;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPrefixArea.FieldLayoutProperty, value);
			}
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x06001B36 RID: 6966 RVA: 0x0007A68D File Offset: 0x0007888D
		public global::System.Windows.Controls.Orientation Orientation
		{
			get
			{
				return (global::System.Windows.Controls.Orientation)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPrefixArea.OrientationProperty);
			}
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x06001B37 RID: 6967 RVA: 0x0007A69F File Offset: 0x0007889F
		public global::Infragistics.Windows.DataPresenter.Record Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x06001B38 RID: 6968 RVA: 0x0007A6A7 File Offset: 0x000788A7
		// (set) Token: 0x06001B39 RID: 6969 RVA: 0x0007A6B9 File Offset: 0x000788B9
		internal int InternalVersion
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordPrefixArea.InternalVersionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPrefixArea.InternalVersionProperty, value);
			}
		}

		// Token: 0x06001B3A RID: 6970
		internal abstract global::Infragistics.Windows.Helpers.StyleSelectorHelperBase CreateStyleSelectorHelper();

		// Token: 0x06001B3B RID: 6971 RVA: 0x0007A6CC File Offset: 0x000788CC
		private void InitializeVersionInfo()
		{
			if (this._cachedFieldLayout != null && this._cachedFieldLayout.DataPresenter != null && this._cachedFieldLayout.StyleGenerator != null)
			{
				int internalVersion = this.InternalVersion;
				if (this._cachedVersion != internalVersion)
				{
					this._cachedVersion = internalVersion;
					if (this._versionInitialized)
					{
						this._styleSelectorHelper.InvalidateStyle();
					}
					base.SetValue(global::Infragistics.Windows.DataPresenter.RecordPrefixArea.OrientationPropertyKey, global::Infragistics.KnownBoxes.FromValue(this.FieldLayout.StyleGenerator.LogicalOrientation));
				}
				this._versionInitialized = true;
			}
		}

		// Token: 0x04000AF1 RID: 2801
		private int _cachedVersion;

		// Token: 0x04000AF2 RID: 2802
		private bool _versionInitialized;

		// Token: 0x04000AF3 RID: 2803
		private global::Infragistics.Windows.DataPresenter.Record _record;

		// Token: 0x04000AF4 RID: 2804
		private global::Infragistics.Windows.Helpers.StyleSelectorHelperBase _styleSelectorHelper;

		// Token: 0x04000AF5 RID: 2805
		public static readonly global::System.Windows.DependencyProperty FieldLayoutProperty = global::System.Windows.DependencyProperty.Register("FieldLayout", typeof(global::Infragistics.Windows.DataPresenter.FieldLayout), typeof(global::Infragistics.Windows.DataPresenter.RecordPrefixArea), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordPrefixArea.OnFieldLayoutChanged)));

		// Token: 0x04000AF6 RID: 2806
		private global::Infragistics.Windows.DataPresenter.FieldLayout _cachedFieldLayout;

		// Token: 0x04000AF7 RID: 2807
		private static readonly global::System.Windows.DependencyPropertyKey OrientationPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Orientation", typeof(global::System.Windows.Controls.Orientation), typeof(global::Infragistics.Windows.DataPresenter.RecordPrefixArea), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Controls.Orientation.Vertical));

		// Token: 0x04000AF8 RID: 2808
		public static readonly global::System.Windows.DependencyProperty OrientationProperty = global::Infragistics.Windows.DataPresenter.RecordPrefixArea.OrientationPropertyKey.DependencyProperty;

		// Token: 0x04000AF9 RID: 2809
		private static readonly global::System.Windows.DependencyPropertyKey RecordPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Record", typeof(global::Infragistics.Windows.DataPresenter.Record), typeof(global::Infragistics.Windows.DataPresenter.RecordPrefixArea), new global::System.Windows.FrameworkPropertyMetadata());

		// Token: 0x04000AFA RID: 2810
		public static readonly global::System.Windows.DependencyProperty RecordProperty = global::Infragistics.Windows.DataPresenter.RecordPrefixArea.RecordPropertyKey.DependencyProperty;

		// Token: 0x04000AFB RID: 2811
		internal static readonly global::System.Windows.DependencyProperty InternalVersionProperty = global::System.Windows.DependencyProperty.Register("InternalVersion", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.RecordPrefixArea), new global::System.Windows.FrameworkPropertyMetadata(0));
	}
}
