using System;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020002F3 RID: 755
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class HeaderLabelArea : global::Infragistics.Windows.DataPresenter.RecordCellAreaBase
	{
		// Token: 0x06002353 RID: 9043 RVA: 0x0009A1A0 File Offset: 0x000983A0
		static HeaderLabelArea()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.HeaderLabelArea), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.HeaderLabelArea)));
		}

		// Token: 0x06002354 RID: 9044 RVA: 0x0009A26F File Offset: 0x0009846F
		public HeaderLabelArea()
		{
			this._styleSelectorHelper = new global::Infragistics.Windows.DataPresenter.HeaderLabelArea.StyleSelectorHelper(this);
		}

		// Token: 0x06002355 RID: 9045 RVA: 0x0009A283 File Offset: 0x00098483
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			if (e.Property == global::Infragistics.Windows.DataPresenter.HeaderLabelArea.InternalVersionProperty)
			{
				this.InitializeVersionInfo();
			}
		}

		// Token: 0x06002356 RID: 9046 RVA: 0x0009A2A0 File Offset: 0x000984A0
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("HeaderLabelArea: ");
			if (this.FieldLayout != null)
			{
				stringBuilder.Append(this.FieldLayout.ToString());
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06002357 RID: 9047 RVA: 0x0009A2E0 File Offset: 0x000984E0
		private static void OnFieldLayoutChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.HeaderLabelArea headerLabelArea = target as global::Infragistics.Windows.DataPresenter.HeaderLabelArea;
			if (headerLabelArea != null)
			{
				headerLabelArea._cachedFieldLayout = (e.NewValue as global::Infragistics.Windows.DataPresenter.FieldLayout);
				headerLabelArea.InitializeVersionInfo();
			}
		}

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x06002358 RID: 9048 RVA: 0x0009A30F File Offset: 0x0009850F
		// (set) Token: 0x06002359 RID: 9049 RVA: 0x0009A317 File Offset: 0x00098517
		public global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				return this._cachedFieldLayout;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.HeaderLabelArea.FieldLayoutProperty, value);
			}
		}

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x0600235A RID: 9050 RVA: 0x0009A325 File Offset: 0x00098525
		public global::System.Windows.Controls.Orientation Orientation
		{
			get
			{
				return (global::System.Windows.Controls.Orientation)base.GetValue(global::Infragistics.Windows.DataPresenter.HeaderLabelArea.OrientationProperty);
			}
		}

		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x0600235B RID: 9051 RVA: 0x0009A337 File Offset: 0x00098537
		// (set) Token: 0x0600235C RID: 9052 RVA: 0x0009A349 File Offset: 0x00098549
		internal int InternalVersion
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.DataPresenter.HeaderLabelArea.InternalVersionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.HeaderLabelArea.InternalVersionProperty, value);
			}
		}

		// Token: 0x0600235D RID: 9053 RVA: 0x0009A35C File Offset: 0x0009855C
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
					base.SetValue(global::Infragistics.Windows.DataPresenter.HeaderLabelArea.OrientationPropertyKey, global::Infragistics.KnownBoxes.FromValue(this.FieldLayout.StyleGenerator.LogicalOrientation));
				}
				this._versionInitialized = true;
			}
		}

		// Token: 0x04001129 RID: 4393
		private int _cachedVersion;

		// Token: 0x0400112A RID: 4394
		private bool _versionInitialized;

		// Token: 0x0400112B RID: 4395
		private global::Infragistics.Windows.DataPresenter.HeaderLabelArea.StyleSelectorHelper _styleSelectorHelper;

		// Token: 0x0400112C RID: 4396
		public static readonly global::System.Windows.DependencyProperty FieldLayoutProperty = global::System.Windows.DependencyProperty.Register("FieldLayout", typeof(global::Infragistics.Windows.DataPresenter.FieldLayout), typeof(global::Infragistics.Windows.DataPresenter.HeaderLabelArea), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.HeaderLabelArea.OnFieldLayoutChanged)));

		// Token: 0x0400112D RID: 4397
		private global::Infragistics.Windows.DataPresenter.FieldLayout _cachedFieldLayout;

		// Token: 0x0400112E RID: 4398
		private static readonly global::System.Windows.DependencyPropertyKey OrientationPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Orientation", typeof(global::System.Windows.Controls.Orientation), typeof(global::Infragistics.Windows.DataPresenter.HeaderLabelArea), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Controls.Orientation.Vertical));

		// Token: 0x0400112F RID: 4399
		public static readonly global::System.Windows.DependencyProperty OrientationProperty = global::Infragistics.Windows.DataPresenter.HeaderLabelArea.OrientationPropertyKey.DependencyProperty;

		// Token: 0x04001130 RID: 4400
		internal static readonly global::System.Windows.DependencyProperty InternalVersionProperty = global::System.Windows.DependencyProperty.Register("InternalVersion", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.HeaderLabelArea), new global::System.Windows.FrameworkPropertyMetadata(0));

		// Token: 0x020002F4 RID: 756
		private class StyleSelectorHelper : global::Infragistics.Windows.Helpers.StyleSelectorHelperBase
		{
			// Token: 0x0600235E RID: 9054 RVA: 0x0009A3DC File Offset: 0x000985DC
			internal StyleSelectorHelper(global::Infragistics.Windows.DataPresenter.HeaderLabelArea hla) : base(hla)
			{
				this._hla = hla;
			}

			// Token: 0x17000A57 RID: 2647
			// (get) Token: 0x0600235F RID: 9055 RVA: 0x0009A3EC File Offset: 0x000985EC
			public override global::System.Windows.Style Style
			{
				get
				{
					if (this._hla == null)
					{
						return null;
					}
					global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this._hla.FieldLayout;
					if (fieldLayout != null)
					{
						global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = fieldLayout.DataPresenter;
						if (dataPresenter != null)
						{
							return dataPresenter.InternalHeaderLabelAreaStyleSelector.SelectStyle(this._hla.FieldLayout, this._hla);
						}
					}
					return null;
				}
			}

			// Token: 0x04001131 RID: 4401
			private global::Infragistics.Windows.DataPresenter.HeaderLabelArea _hla;
		}
	}
}
