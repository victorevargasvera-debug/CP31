using System;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using Infragistics.Themes;
using Infragistics.Windows.Automation.Peers.Editors;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Licensing;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000075 RID: 117
	[global::Infragistics.Windows.Licensing.UltraLicense("XamCheckEditor")]
	[global::System.Windows.TemplateVisualState(Name = "Unchecked", GroupName = "CheckStates")]
	[global::System.Windows.TemplateVisualState(Name = "Checked", GroupName = "CheckStates")]
	[global::System.Windows.TemplateVisualState(Name = "Indeterminate", GroupName = "CheckStates")]
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	public class XamCheckEditor : global::Infragistics.Windows.Editors.ValueEditor
	{
		// Token: 0x06000640 RID: 1600 RVA: 0x00019B64 File Offset: 0x00017D64
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
			global::Infragistics.Themes.ThemeManager.RegisterControl(typeof(global::Infragistics.Windows.Editors.XamCheckEditor));
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00019CE8 File Offset: 0x00017EE8
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

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000642 RID: 1602 RVA: 0x00019D2C File Offset: 0x00017F2C
		protected override bool AcceptsArrowKeysInEditModeDefault
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x00019D2F File Offset: 0x00017F2F
		internal override void InitializeValueProperties()
		{
			if (global::Infragistics.Windows.Editors.Utils.IsValuePropertySet(global::Infragistics.Windows.Editors.XamCheckEditor.IsCheckedProperty, this))
			{
				global::Infragistics.DependencyPropertyUtilities.SetCurrentValue(this, global::Infragistics.Windows.Editors.ValueEditor.ValueProperty, this.IsChecked);
			}
			base.InitializeValueProperties();
			this.SetIsCheckedHelper(base.Value);
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x00019D66 File Offset: 0x00017F66
		public override bool CanEditType(global::System.Type type)
		{
			return typeof(bool) == type || typeof(bool?) == type;
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x00019D8C File Offset: 0x00017F8C
		public override bool CanRenderType(global::System.Type type)
		{
			return this.CanEditType(type);
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x00019D95 File Offset: 0x00017F95
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool IsExtentBasedOnValue(global::System.Windows.Controls.Orientation orientation)
		{
			return false;
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x00019D98 File Offset: 0x00017F98
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.Editors.XamCheckEditorAutomationPeer(this);
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x00019DA0 File Offset: 0x00017FA0
		protected override void OnPreviewMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnPreviewMouseLeftButtonDown(e);
			if (!e.Handled)
			{
				base.StartEditModeOnMouseDownHelper();
			}
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x00019DB8 File Offset: 0x00017FB8
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

		// Token: 0x0600064A RID: 1610 RVA: 0x00019E10 File Offset: 0x00018010
		internal override bool SyncValuePropertiesOverride(global::System.Windows.DependencyProperty prop, object newValue, out global::System.Exception error)
		{
			bool result = base.SyncValuePropertiesOverride(prop, newValue, out error);
			this.SetIsCheckedHelper(base.Value);
			return result;
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x0600064B RID: 1611 RVA: 0x00019E34 File Offset: 0x00018034
		// (set) Token: 0x0600064C RID: 1612 RVA: 0x00019E46 File Offset: 0x00018046
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
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

		// Token: 0x0600064D RID: 1613 RVA: 0x00019E5C File Offset: 0x0001805C
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

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x0600064E RID: 1614 RVA: 0x00019EB8 File Offset: 0x000180B8
		// (set) Token: 0x0600064F RID: 1615 RVA: 0x00019ECA File Offset: 0x000180CA
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

		// Token: 0x06000650 RID: 1616 RVA: 0x00019EDD File Offset: 0x000180DD
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeIsThreeState()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.XamCheckEditor.IsThreeStateProperty, this);
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x00019EEA File Offset: 0x000180EA
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetIsThreeState()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.XamCheckEditor.IsThreeStateProperty);
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x00019EF8 File Offset: 0x000180F8
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

		// Token: 0x06000653 RID: 1619 RVA: 0x00019F58 File Offset: 0x00018158
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

		// Token: 0x04000266 RID: 614
		private global::Infragistics.Windows.Licensing.UltraLicense _license;

		// Token: 0x04000267 RID: 615
		public static readonly global::System.Windows.DependencyProperty IsCheckedProperty = global::System.Windows.DependencyProperty.Register("IsChecked", typeof(bool?), typeof(global::Infragistics.Windows.Editors.XamCheckEditor), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamCheckEditor.OnIsCheckedChanged)));

		// Token: 0x04000268 RID: 616
		public static readonly global::System.Windows.DependencyProperty IsThreeStateProperty = global::System.Windows.DependencyProperty.Register("IsThreeState", typeof(bool), typeof(global::Infragistics.Windows.Editors.XamCheckEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.None, null));
	}
}
