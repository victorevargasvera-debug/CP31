using System;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using Infragistics.Windows.Automation.Peers.Editors;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Licensing;

namespace Infragistics.Windows.Editors
{
	// Token: 0x0200006F RID: 111
	[global::System.Windows.TemplateVisualState(Name = "Unchecked", GroupName = "CheckStates")]
	[global::System.Windows.TemplateVisualState(Name = "Indeterminate", GroupName = "CheckStates")]
	[global::Infragistics.Windows.Licensing.UltraLicense("XamCheckEditor")]
	[global::System.Windows.TemplateVisualState(Name = "Checked", GroupName = "CheckStates")]
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	public class XamCheckEditor : global::Infragistics.Windows.Editors.ValueEditor
	{
		// Token: 0x060005E8 RID: 1512 RVA: 0x0001849C File Offset: 0x0001669C
		static XamCheckEditor()
		{
			global::Infragistics.Windows.Editors.ValueEditor.ValueTypeProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamCheckEditor), new global::System.Windows.FrameworkPropertyMetadata(typeof(bool)));
			global::System.Windows.Controls.Control.HorizontalContentAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamCheckEditor), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.HorizontalAlignment.Center));
			global::System.Windows.Controls.Control.VerticalContentAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamCheckEditor), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.VerticalAlignment.Center));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamCheckEditor), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Editors.XamCheckEditor)));
			global::System.Windows.Input.KeyboardNavigation.TabNavigationProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamCheckEditor), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.Local));
			global::System.Windows.Input.KeyboardNavigation.ControlTabNavigationProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamCheckEditor), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.Local));
			global::System.Windows.Input.KeyboardNavigation.DirectionalNavigationProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamCheckEditor), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.Local));
			global::System.Windows.Input.KeyboardNavigation.IsTabStopProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamCheckEditor), new global::System.Windows.FrameworkPropertyMetadata(false));
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x00018610 File Offset: 0x00016810
		public XamCheckEditor()
		{
			try
			{
				this._license = (global::System.ComponentModel.LicenseManager.Validate(typeof(global::Infragistics.Windows.Editors.XamCheckEditor), this) as global::Infragistics.Windows.Licensing.UltraLicense);
			}
			catch (global::System.IO.FileNotFoundException)
			{
			}
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x00018654 File Offset: 0x00016854
		internal override void InitializeValueProperties()
		{
			if (global::Infragistics.Windows.Editors.Utils.IsValuePropertySet(global::Infragistics.Windows.Editors.XamCheckEditor.IsCheckedProperty, this))
			{
				base.Value = this.IsChecked;
			}
			base.InitializeValueProperties();
			this.SetIsCheckedHelper(base.Value);
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00018686 File Offset: 0x00016886
		public override bool CanEditType(global::System.Type type)
		{
			return typeof(bool) == type || typeof(bool?) == type;
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x000186AC File Offset: 0x000168AC
		public override bool CanRenderType(global::System.Type type)
		{
			return this.CanEditType(type);
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x000186B5 File Offset: 0x000168B5
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool IsExtentBasedOnValue(global::System.Windows.Controls.Orientation orientation)
		{
			return false;
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x000186B8 File Offset: 0x000168B8
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.Editors.XamCheckEditorAutomationPeer(this);
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x000186C0 File Offset: 0x000168C0
		protected override void OnPreviewMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnPreviewMouseLeftButtonDown(e);
			if (!e.Handled)
			{
				base.StartEditModeOnMouseDownHelper();
			}
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x000186D8 File Offset: 0x000168D8
		protected override void SetVisualState(bool useTransitions)
		{
			base.SetVisualState(useTransitions);
			bool? isChecked = this.IsChecked;
			if (isChecked == null)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Indeterminate", useTransitions);
				return;
			}
			if (isChecked.Value)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Checked", useTransitions);
				return;
			}
			global::System.Windows.VisualStateManager.GoToState(this, "Unchecked", useTransitions);
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x00018730 File Offset: 0x00016930
		internal override bool SyncValuePropertiesOverride(global::System.Windows.DependencyProperty prop, object newValue, out global::System.Exception error)
		{
			bool result = base.SyncValuePropertiesOverride(prop, newValue, out error);
			this.SetIsCheckedHelper(base.Value);
			return result;
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060005F2 RID: 1522 RVA: 0x00018754 File Offset: 0x00016954
		// (set) Token: 0x060005F3 RID: 1523 RVA: 0x00018766 File Offset: 0x00016966
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<bool>))]
		public bool? IsChecked
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Windows.Editors.XamCheckEditor.IsCheckedProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamCheckEditor.IsCheckedProperty, global::Infragistics.KnownBoxes.FromValue(value));
			}
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x0001877C File Offset: 0x0001697C
		private static void OnIsCheckedChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamCheckEditor xamCheckEditor = (global::Infragistics.Windows.Editors.XamCheckEditor)dependencyObject;
			if (!xamCheckEditor.SyncingValueProperties)
			{
				xamCheckEditor.Value = e.NewValue;
			}
			xamCheckEditor.UpdateVisualStates();
			global::Infragistics.Windows.Automation.Peers.Editors.XamCheckEditorAutomationPeer xamCheckEditorAutomationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(xamCheckEditor) as global::Infragistics.Windows.Automation.Peers.Editors.XamCheckEditorAutomationPeer;
			if (xamCheckEditorAutomationPeer != null)
			{
				xamCheckEditorAutomationPeer.RaiseToggleStatePropertyChangedEvent((bool?)e.OldValue, (bool?)e.NewValue);
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060005F5 RID: 1525 RVA: 0x000187D8 File Offset: 0x000169D8
		// (set) Token: 0x060005F6 RID: 1526 RVA: 0x000187EA File Offset: 0x000169EA
		[global::System.ComponentModel.Bindable(true)]
		public bool IsThreeState
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.XamCheckEditor.IsThreeStateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamCheckEditor.IsThreeStateProperty, value);
			}
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x000187FD File Offset: 0x000169FD
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeIsThreeState()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.XamCheckEditor.IsThreeStateProperty, this);
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x0001880A File Offset: 0x00016A0A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetIsThreeState()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.XamCheckEditor.IsThreeStateProperty);
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00018818 File Offset: 0x00016A18
		internal void ToggleIsChecked()
		{
			bool? isChecked = this.IsChecked;
			bool isThreeState = this.IsThreeState;
			if (isChecked == null)
			{
				isChecked = new bool?(true);
			}
			else if (isChecked.Value)
			{
				isChecked = new bool?(false);
			}
			else if (isThreeState)
			{
				isChecked = null;
			}
			else
			{
				isChecked = new bool?(true);
			}
			this.IsChecked = isChecked;
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00018878 File Offset: 0x00016A78
		private void SetIsCheckedHelper(object value)
		{
			value = global::Infragistics.CoreUtilities.ConvertDataValue(value, typeof(bool), base.FormatProviderResolved, base.Format);
			if (!(value is bool))
			{
				this.IsChecked = null;
				return;
			}
			this.IsChecked = new bool?((bool)value);
		}

		// Token: 0x04000233 RID: 563
		private global::Infragistics.Windows.Licensing.UltraLicense _license;

		// Token: 0x04000234 RID: 564
		public static readonly global::System.Windows.DependencyProperty IsCheckedProperty = global::System.Windows.DependencyProperty.Register("IsChecked", typeof(bool?), typeof(global::Infragistics.Windows.Editors.XamCheckEditor), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamCheckEditor.OnIsCheckedChanged)));

		// Token: 0x04000235 RID: 565
		public static readonly global::System.Windows.DependencyProperty IsThreeStateProperty = global::System.Windows.DependencyProperty.Register("IsThreeState", typeof(bool), typeof(global::Infragistics.Windows.Editors.XamCheckEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.None, null));
	}
}
