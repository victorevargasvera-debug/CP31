using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020002B4 RID: 692
	public class UnboundField : global::Infragistics.Windows.DataPresenter.Field
	{
		// Token: 0x06001FBA RID: 8122 RVA: 0x000880F0 File Offset: 0x000862F0
		static UnboundField()
		{
			global::Infragistics.Windows.DataPresenter.Field.DataTypeProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.UnboundField), new global::System.Windows.FrameworkPropertyMetadata(typeof(string)));
			global::Infragistics.Windows.DataPresenter.Field.IsUnboundPropertyKey.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.UnboundField), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox));
		}

		// Token: 0x06001FBC RID: 8124 RVA: 0x000881E4 File Offset: 0x000863E4
		internal override void InitializeFrom(global::Infragistics.Windows.DataPresenter.Field source)
		{
			global::Infragistics.Windows.DataPresenter.UnboundField unboundField = source as global::Infragistics.Windows.DataPresenter.UnboundField;
			base.InitializeFrom(source);
			this.BindingMode = unboundField.BindingMode;
			this.BindingPath = unboundField.BindingPath;
			this.Binding = unboundField.Binding;
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x06001FBD RID: 8125 RVA: 0x00088223 File Offset: 0x00086423
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public override bool IsUnbound
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06001FBE RID: 8126 RVA: 0x00088228 File Offset: 0x00086428
		private static void OnBindingRelatedPropertyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.UnboundField unboundField = target as global::Infragistics.Windows.DataPresenter.UnboundField;
			global::System.Windows.Data.BindingBase binding = unboundField.Binding;
			if (binding != null)
			{
				unboundField.ValidateBindingSetting(binding);
			}
			unboundField.InitializeIsBoundToRootProperty();
		}

		// Token: 0x06001FBF RID: 8127 RVA: 0x00088254 File Offset: 0x00086454
		private void ValidateBindingSetting(global::System.Windows.Data.BindingBase binding)
		{
			if (binding != null)
			{
				string text = null;
				if (this.BindingPath != null)
				{
					text = "BindingPath";
				}
				else if (!object.Equals(this.BindingMode, global::Infragistics.Windows.DataPresenter.UnboundField.BindingModeProperty.DefaultMetadata.DefaultValue))
				{
					text = "BindingMode";
				}
				if (text != null)
				{
					throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidOperationException_26B", new object[]
					{
						text
					}));
				}
			}
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x06001FC0 RID: 8128 RVA: 0x000882BC File Offset: 0x000864BC
		// (set) Token: 0x06001FC1 RID: 8129 RVA: 0x000882C4 File Offset: 0x000864C4
		[global::System.ComponentModel.Bindable(false)]
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Data.BindingBase Binding
		{
			get
			{
				return this._binding;
			}
			set
			{
				if (this._binding != value)
				{
					this.ValidateBindingSetting(value);
					this._binding = value;
					this.InitializeIsBoundToRootProperty();
					base.RaisePropertyChangedEvent("Binding");
				}
			}
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x06001FC2 RID: 8130 RVA: 0x000882EE File Offset: 0x000864EE
		// (set) Token: 0x06001FC3 RID: 8131 RVA: 0x00088300 File Offset: 0x00086500
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

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x06001FC4 RID: 8132 RVA: 0x00088313 File Offset: 0x00086513
		// (set) Token: 0x06001FC5 RID: 8133 RVA: 0x00088325 File Offset: 0x00086525
		[global::System.ComponentModel.DefaultValue(null)]
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

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x06001FC6 RID: 8134 RVA: 0x00088333 File Offset: 0x00086533
		// (set) Token: 0x06001FC7 RID: 8135 RVA: 0x00088345 File Offset: 0x00086545
		[global::System.ComponentModel.Category("Behavior")]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Description("Specifies whether to auto-release binding objects or to retain them after they are created.")]
		[global::System.ComponentModel.Bindable(true)]
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

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x06001FC8 RID: 8136 RVA: 0x00088358 File Offset: 0x00086558
		internal bool IsBoundToRootProperty
		{
			get
			{
				return this._isBoundToRootProperty;
			}
		}

		// Token: 0x06001FC9 RID: 8137 RVA: 0x00088368 File Offset: 0x00086568
		private void InitializeIsBoundToRootProperty()
		{
			this._isBoundToRootProperty = false;
			global::System.Windows.PropertyPath propertyPath = this.BindingPath;
			if (propertyPath == null)
			{
				global::System.Windows.Data.Binding binding = this.Binding as global::System.Windows.Data.Binding;
				if (binding != null)
				{
					propertyPath = binding.Path;
				}
			}
			if (propertyPath != null)
			{
				string path = propertyPath.Path;
				if (path != null && path.Length > 0)
				{
					string[] array = path.Split(new char[]
					{
						'.',
						'[',
						'\0',
						'/'
					});
					this._isBoundToRootProperty = (array.Length == 1);
				}
			}
		}

		// Token: 0x04000F83 RID: 3971
		private global::System.Windows.Data.BindingBase _binding;

		// Token: 0x04000F84 RID: 3972
		private bool _isBoundToRootProperty;

		// Token: 0x04000F85 RID: 3973
		public static readonly global::System.Windows.DependencyProperty BindingModeProperty = global::System.Windows.DependencyProperty.Register("BindingMode", typeof(global::System.Windows.Data.BindingMode), typeof(global::Infragistics.Windows.DataPresenter.UnboundField), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Data.BindingMode.OneWay, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.UnboundField.OnBindingRelatedPropertyChanged)));

		// Token: 0x04000F86 RID: 3974
		public static readonly global::System.Windows.DependencyProperty BindingPathProperty = global::System.Windows.DependencyProperty.Register("BindingPath", typeof(global::System.Windows.PropertyPath), typeof(global::Infragistics.Windows.DataPresenter.UnboundField), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.UnboundField.OnBindingRelatedPropertyChanged)));

		// Token: 0x04000F87 RID: 3975
		public static readonly global::System.Windows.DependencyProperty BindingRetentionModeProperty = global::System.Windows.DependencyProperty.Register("BindingRetentionMode", typeof(global::Infragistics.Windows.DataPresenter.BindingRetentionMode), typeof(global::Infragistics.Windows.DataPresenter.UnboundField), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.BindingRetentionMode.AutoRelease, global::System.Windows.FrameworkPropertyMetadataOptions.None));
	}
}
