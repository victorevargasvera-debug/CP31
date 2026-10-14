using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020002F1 RID: 753
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	[global::System.Obsolete("Use Field (or one of its editor specific derived classes) with the new BindingType property set to 'Unbound' or 'UseAlternateBinding' instead. The new 'AlternateBinding' and 'AlternateBindingRetentionMode' properties replace all the UnboundFields 'Binding...' properties", false)]
	public class UnboundField : global::Infragistics.Windows.DataPresenter.Field
	{
		// Token: 0x060022F2 RID: 8946 RVA: 0x000982B4 File Offset: 0x000964B4
		static UnboundField()
		{
			global::Infragistics.Windows.DataPresenter.Field.DataTypeProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.UnboundField), new global::System.Windows.FrameworkPropertyMetadata(typeof(string)));
			global::Infragistics.Windows.DataPresenter.Field.IsUnboundPropertyKey.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.UnboundField), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox));
			global::Infragistics.Windows.DataPresenter.Field.BindingTypeProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.UnboundField), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.BindingType.Unbound));
		}

		// Token: 0x060022F4 RID: 8948 RVA: 0x000983D4 File Offset: 0x000965D4
		protected internal override void InitializeFrom(global::Infragistics.Windows.DataPresenter.Field source)
		{
			global::Infragistics.Windows.DataPresenter.UnboundField unboundField = source as global::Infragistics.Windows.DataPresenter.UnboundField;
			base.InitializeFrom(source);
			this.BindingMode = unboundField.BindingMode;
			this.BindingPath = unboundField.BindingPath;
		}

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x060022F5 RID: 8949 RVA: 0x00098407 File Offset: 0x00096607
		[global::System.Obsolete("Use BindingType instead", false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public override bool IsUnbound
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060022F6 RID: 8950 RVA: 0x0009840C File Offset: 0x0009660C
		private static void OnBindingRelatedPropertyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.UnboundField unboundField = target as global::Infragistics.Windows.DataPresenter.UnboundField;
			global::System.Windows.Data.BindingBase binding = unboundField.Binding;
			if (binding != null)
			{
				unboundField.ValidateBindingSetting(binding);
			}
			unboundField.InitializeIsBoundToRootProperty();
			if (unboundField.Owner != null)
			{
				unboundField.Owner._hasUnboundFieldsWithoutBindings = null;
			}
		}

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x060022F7 RID: 8951 RVA: 0x00098450 File Offset: 0x00096650
		// (set) Token: 0x060022F8 RID: 8952 RVA: 0x00098458 File Offset: 0x00096658
		[global::System.ComponentModel.Bindable(false)]
		[global::System.Obsolete("Use Field (or one of its editor specific derived classes) with the new BindingType property set to 'Unbound' or 'UseAlternateBinding' instead. The new 'AlternateBinding' and 'AlternateBindingRetentionMode' properties replace all the UnboundFields 'Binding...' properties", false)]
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Data.BindingBase Binding
		{
			get
			{
				return base.AlternateBinding;
			}
			set
			{
				base.AlternateBinding = value;
			}
		}

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x060022F9 RID: 8953 RVA: 0x00098461 File Offset: 0x00096661
		// (set) Token: 0x060022FA RID: 8954 RVA: 0x00098473 File Offset: 0x00096673
		[global::System.Obsolete("Use Field (or one of its editor specific derived classes) with the new BindingType property set to 'Unbound' or 'UseAlternateBinding' instead. The new 'AlternateBinding' and 'AlternateBindingRetentionMode' properties replace all the UnboundFields 'Binding...' properties", false)]
		[global::System.ComponentModel.DefaultValue(global::System.Windows.Data.BindingMode.OneWay)]
		public global::System.Windows.Data.BindingMode BindingMode
		{
			get
			{
				return (global::System.Windows.Data.BindingMode)base.GetValue(global::Infragistics.Windows.DataPresenter.UnboundField.BindingModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.UnboundField.BindingModeProperty, value);
			}
		}

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x060022FB RID: 8955 RVA: 0x00098486 File Offset: 0x00096686
		// (set) Token: 0x060022FC RID: 8956 RVA: 0x00098498 File Offset: 0x00096698
		[global::System.ComponentModel.DefaultValue(null)]
		[global::System.Obsolete("Use Field (or one of its editor specific derived classes) with the new BindingType property set to 'Unbound' or 'UseAlternateBinding' instead. The new 'AlternateBinding' and 'AlternateBindingRetentionMode' properties replace all the UnboundFields 'Binding...' properties", false)]
		public global::System.Windows.PropertyPath BindingPath
		{
			get
			{
				return (global::System.Windows.PropertyPath)base.GetValue(global::Infragistics.Windows.DataPresenter.UnboundField.BindingPathProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.UnboundField.BindingPathProperty, value);
			}
		}

		// Token: 0x060022FD RID: 8957 RVA: 0x000984A8 File Offset: 0x000966A8
		private static void OnBindingRetentionModeChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.UnboundField unboundField = target as global::Infragistics.Windows.DataPresenter.UnboundField;
			if (unboundField != null)
			{
				unboundField.SetCurrentValue(global::Infragistics.Windows.DataPresenter.Field.AlternateBindingRetentionModeProperty, e.NewValue);
			}
		}

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x060022FE RID: 8958 RVA: 0x000984D1 File Offset: 0x000966D1
		// (set) Token: 0x060022FF RID: 8959 RVA: 0x000984E3 File Offset: 0x000966E3
		[global::System.ComponentModel.Category("Behavior")]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Description("Specifies whether to auto-release binding objects or to retain them after they are created.")]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.Obsolete("Use Field (or one of its editor specific derived classes) with the new BindingType property set to 'Unbound' or 'UseAlternateBinding' instead. The new 'AlternateBinding' and 'AlternateBindingRetentionMode' properties replace all the UnboundFields 'Binding...' properties", false)]
		public global::Infragistics.Windows.DataPresenter.BindingRetentionMode BindingRetentionMode
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.BindingRetentionMode)base.GetValue(global::Infragistics.Windows.DataPresenter.UnboundField.BindingRetentionModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.UnboundField.BindingRetentionModeProperty, value);
			}
		}

		// Token: 0x04001168 RID: 4456
		public static readonly global::System.Windows.DependencyProperty BindingModeProperty = global::System.Windows.DependencyProperty.Register("BindingMode", typeof(global::System.Windows.Data.BindingMode), typeof(global::Infragistics.Windows.DataPresenter.UnboundField), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Data.BindingMode.OneWay, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.UnboundField.OnBindingRelatedPropertyChanged)));

		// Token: 0x04001169 RID: 4457
		public static readonly global::System.Windows.DependencyProperty BindingPathProperty = global::System.Windows.DependencyProperty.Register("BindingPath", typeof(global::System.Windows.PropertyPath), typeof(global::Infragistics.Windows.DataPresenter.UnboundField), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.UnboundField.OnBindingRelatedPropertyChanged)));

		// Token: 0x0400116A RID: 4458
		public static readonly global::System.Windows.DependencyProperty BindingRetentionModeProperty = global::System.Windows.DependencyProperty.Register("BindingRetentionMode", typeof(global::Infragistics.Windows.DataPresenter.BindingRetentionMode), typeof(global::Infragistics.Windows.DataPresenter.UnboundField), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.BindingRetentionMode.AutoRelease, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.UnboundField.OnBindingRetentionModeChanged)));
	}
}
