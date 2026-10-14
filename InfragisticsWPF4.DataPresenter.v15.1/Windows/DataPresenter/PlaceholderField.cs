using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020002F0 RID: 752
	internal class PlaceholderField : global::Infragistics.Windows.DataPresenter.Field
	{
		// Token: 0x060022E9 RID: 8937 RVA: 0x000981CB File Offset: 0x000963CB
		static PlaceholderField()
		{
			global::Infragistics.Windows.DataPresenter.Field.BindingTypeProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.PlaceholderField), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.BindingType.Unbound, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.PlaceholderField.OnBindingTypeChanged)));
		}

		// Token: 0x060022EA RID: 8938 RVA: 0x000981F8 File Offset: 0x000963F8
		internal PlaceholderField(global::Infragistics.Windows.DataPresenter.FieldLayout owner, global::Infragistics.Windows.DataPresenter.Field mappedField)
		{
			base.MappedTreeField = mappedField;
			base.Initialize(owner);
		}

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x060022EB RID: 8939 RVA: 0x00098210 File Offset: 0x00096410
		// (set) Token: 0x060022EC RID: 8940 RVA: 0x0009823D File Offset: 0x0009643D
		internal override bool IsInLayout
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.Field mappedTreeField = base.MappedTreeField;
				return mappedTreeField != null && mappedTreeField.IsInLayout && mappedTreeField.VisibilityResolved != global::System.Windows.Visibility.Collapsed;
			}
			set
			{
				base.IsInLayout = value;
			}
		}

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x060022ED RID: 8941 RVA: 0x00098246 File Offset: 0x00096446
		public override bool IsPlaceholderForTreeView
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x060022EE RID: 8942 RVA: 0x0009824C File Offset: 0x0009644C
		internal override bool IsValid
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout owner = base.Owner;
				return owner != null && owner.IsTreeView && base.MappedTreeField != null && base.MappedTreeField.IsValid;
			}
		}

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x060022EF RID: 8943 RVA: 0x00098280 File Offset: 0x00096480
		internal int PlaceholderIndex
		{
			get
			{
				return this._placeholderIndex;
			}
		}

		// Token: 0x060022F0 RID: 8944 RVA: 0x00098288 File Offset: 0x00096488
		internal void SetPlaceholderIndex(int index)
		{
			this._placeholderIndex = index;
		}

		// Token: 0x060022F1 RID: 8945 RVA: 0x00098291 File Offset: 0x00096491
		private static void OnBindingTypeChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if ((global::Infragistics.Windows.DataPresenter.BindingType)e.NewValue != global::Infragistics.Windows.DataPresenter.BindingType.Unbound)
			{
				throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_40"));
			}
		}

		// Token: 0x04001167 RID: 4455
		private int _placeholderIndex;
	}
}
