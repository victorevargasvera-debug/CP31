using System;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000333 RID: 819
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class HeaderLabelArea : global::Infragistics.Windows.DataPresenter.RecordCellAreaBase
	{
		// Token: 0x060026F4 RID: 9972 RVA: 0x000ADA60 File Offset: 0x000ABC60
		static HeaderLabelArea()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.HeaderLabelArea), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.HeaderLabelArea)));
		}

		// Token: 0x060026F5 RID: 9973 RVA: 0x000ADB2F File Offset: 0x000ABD2F
		public HeaderLabelArea()
		{
			this._styleSelectorHelper = new global::Infragistics.Windows.DataPresenter.HeaderLabelArea.StyleSelectorHelper(this);
		}

		// Token: 0x060026F6 RID: 9974 RVA: 0x000ADB43 File Offset: 0x000ABD43
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			if (e.Property == global::Infragistics.Windows.DataPresenter.HeaderLabelArea.InternalVersionProperty)
			{
				this.InitializeVersionInfo();
			}
		}

		// Token: 0x060026F7 RID: 9975 RVA: 0x000ADB60 File Offset: 0x000ABD60
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

		// Token: 0x060026F8 RID: 9976 RVA: 0x000ADBA0 File Offset: 0x000ABDA0
		private static void OnFieldLayoutChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.HeaderLabelArea headerLabelArea = target as global::Infragistics.Windows.DataPresenter.HeaderLabelArea;
			if (headerLabelArea != null)
			{
				headerLabelArea._cachedFieldLayout = (e.NewValue as global::Infragistics.Windows.DataPresenter.FieldLayout);
				headerLabelArea.InitializeVersionInfo();
			}
		}

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x060026F9 RID: 9977 RVA: 0x000ADBCF File Offset: 0x000ABDCF
		// (set) Token: 0x060026FA RID: 9978 RVA: 0x000ADBD7 File Offset: 0x000ABDD7
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

		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x060026FB RID: 9979 RVA: 0x000ADBE5 File Offset: 0x000ABDE5
		public global::System.Windows.Controls.Orientation Orientation
		{
			get
			{
				return (global::System.Windows.Controls.Orientation)base.GetValue(global::Infragistics.Windows.DataPresenter.HeaderLabelArea.OrientationProperty);
			}
		}

		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x060026FC RID: 9980 RVA: 0x000ADBF7 File Offset: 0x000ABDF7
		// (set) Token: 0x060026FD RID: 9981 RVA: 0x000ADC09 File Offset: 0x000ABE09
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

		// Token: 0x060026FE RID: 9982 RVA: 0x000ADC1C File Offset: 0x000ABE1C
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

		// Token: 0x04001343 RID: 4931
		private int _cachedVersion;

		// Token: 0x04001344 RID: 4932
		private bool _versionInitialized;

		// Token: 0x04001345 RID: 4933
		private global::Infragistics.Windows.DataPresenter.HeaderLabelArea.StyleSelectorHelper _styleSelectorHelper;

		// Token: 0x04001346 RID: 4934
		public static readonly global::System.Windows.DependencyProperty FieldLayoutProperty = global::System.Windows.DependencyProperty.Register("FieldLayout", typeof(global::Infragistics.Windows.DataPresenter.FieldLayout), typeof(global::Infragistics.Windows.DataPresenter.HeaderLabelArea), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.HeaderLabelArea.OnFieldLayoutChanged)));

		// Token: 0x04001347 RID: 4935
		private global::Infragistics.Windows.DataPresenter.FieldLayout _cachedFieldLayout;

		// Token: 0x04001348 RID: 4936
		private static readonly global::System.Windows.DependencyPropertyKey OrientationPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Orientation", typeof(global::System.Windows.Controls.Orientation), typeof(global::Infragistics.Windows.DataPresenter.HeaderLabelArea), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Controls.Orientation.Vertical));

		// Token: 0x04001349 RID: 4937
		public static readonly global::System.Windows.DependencyProperty OrientationProperty = global::Infragistics.Windows.DataPresenter.HeaderLabelArea.OrientationPropertyKey.DependencyProperty;

		// Token: 0x0400134A RID: 4938
		internal static readonly global::System.Windows.DependencyProperty InternalVersionProperty = global::System.Windows.DependencyProperty.Register("InternalVersion", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.HeaderLabelArea), new global::System.Windows.FrameworkPropertyMetadata(0));

		// Token: 0x02000334 RID: 820
		private class StyleSelectorHelper : global::Infragistics.Windows.Helpers.StyleSelectorHelperBase
		{
			// Token: 0x060026FF RID: 9983 RVA: 0x000ADC9C File Offset: 0x000ABE9C
			internal StyleSelectorHelper(global::Infragistics.Windows.DataPresenter.HeaderLabelArea hla) : base(hla)
			{
				this._hla = hla;
			}

			// Token: 0x17000B84 RID: 2948
			// (get) Token: 0x06002700 RID: 9984 RVA: 0x000ADCAC File Offset: 0x000ABEAC
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

			// Token: 0x0400134B RID: 4939
			private global::Infragistics.Windows.DataPresenter.HeaderLabelArea _hla;
		}
	}
}
