using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using Infragistics.Windows.Editors.Events;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000020 RID: 32
	public abstract class TextEditorBase : global::Infragistics.Windows.Editors.ValueEditor
	{
		// Token: 0x060001BF RID: 447 RVA: 0x00007B4C File Offset: 0x00005D4C
		static TextEditorBase()
		{
			global::System.Windows.Controls.ToolTipService.IsEnabledProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.TextEditorBase), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Editors.TextEditorBase.CoerceToolTipIsEnabled)));
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00007C19 File Offset: 0x00005E19
		protected override void DoInitialization()
		{
			base.DoInitialization();
			this.SyncDisplayText();
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00007C28 File Offset: 0x00005E28
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			global::System.Windows.DependencyProperty property = e.Property;
			if (global::System.Windows.FrameworkElement.LanguageProperty == property || global::Infragistics.Windows.Editors.ValueEditor.FormatProperty == property || global::Infragistics.Windows.Editors.ValueEditor.FormatProviderProperty == property)
			{
				this.SyncDisplayText();
				return;
			}
			if (global::Infragistics.Windows.Editors.TextEditorBase.NullTextProperty == property)
			{
				this.SyncDisplayText();
			}
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00007C74 File Offset: 0x00005E74
		internal override bool SyncValuePropertiesOverride(global::System.Windows.DependencyProperty prop, object newValue, out global::System.Exception error)
		{
			bool result = base.SyncValuePropertiesOverride(prop, newValue, out error);
			this.SyncDisplayText();
			return result;
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x00007C92 File Offset: 0x00005E92
		protected virtual global::System.Windows.Data.IValueConverter DefaultValueToDisplayTextConverter
		{
			get
			{
				return global::Infragistics.Windows.Editors.ValueEditorDefaultConverter.ValueToDisplayTextConverter;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x00007C99 File Offset: 0x00005E99
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public string DisplayText
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.Editors.TextEditorBase.DisplayTextProperty);
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x00007CAB File Offset: 0x00005EAB
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x00007CBD File Offset: 0x00005EBD
		[global::System.ComponentModel.Bindable(true)]
		public string NullText
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.Editors.TextEditorBase.NullTextProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.TextEditorBase.NullTextProperty, value);
			}
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00007CCB File Offset: 0x00005ECB
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeNullText()
		{
			return global::Infragistics.Windows.Utilities.ShouldSerialize(global::Infragistics.Windows.Editors.TextEditorBase.NullTextProperty, this);
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00007CD8 File Offset: 0x00005ED8
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetNullText()
		{
			base.ClearValue(global::Infragistics.Windows.Editors.TextEditorBase.NullTextProperty);
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060001CA RID: 458 RVA: 0x00007CE5 File Offset: 0x00005EE5
		// (set) Token: 0x060001CB RID: 459 RVA: 0x00007CF7 File Offset: 0x00005EF7
		public global::System.Windows.Data.IValueConverter ValueToDisplayTextConverter
		{
			get
			{
				return (global::System.Windows.Data.IValueConverter)base.GetValue(global::Infragistics.Windows.Editors.TextEditorBase.ValueToDisplayTextConverterProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.TextEditorBase.ValueToDisplayTextConverterProperty, value);
			}
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00007D08 File Offset: 0x00005F08
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ConvertDisplayTextToValue(string displayText, out object value, out global::System.Exception error)
		{
			error = null;
			value = null;
			try
			{
				value = this.ValueToDisplayTextConverterResolved.ConvertBack(displayText, base.ValueType, this, base.FormatProviderResolved as global::System.Globalization.CultureInfo);
				if (value == null)
				{
					if (displayText != null && displayText.Length != 0 && !(displayText == this.NullText))
					{
						error = global::Infragistics.Windows.Editors.Utils.GetTextToValueConversionError(base.ValueType, displayText);
						return false;
					}
					value = null;
				}
			}
			catch (global::System.Exception ex)
			{
				error = ex;
				return false;
			}
			return true;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00007D8C File Offset: 0x00005F8C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public bool ConvertValueToDisplayText(object value, out string text, out global::System.Exception error)
		{
			error = null;
			text = null;
			try
			{
				text = (string)this.ValueToDisplayTextConverterResolved.Convert(value, typeof(string), this, base.FormatProviderResolved as global::System.Globalization.CultureInfo);
			}
			catch (global::System.Exception ex)
			{
				error = ex;
				return false;
			}
			return true;
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060001CE RID: 462 RVA: 0x00007DE8 File Offset: 0x00005FE8
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public global::System.Windows.Data.IValueConverter ValueToDisplayTextConverterResolved
		{
			get
			{
				global::System.Windows.Data.IValueConverter valueConverter = this.ValueToDisplayTextConverter;
				if (valueConverter == null)
				{
					valueConverter = this.DefaultValueToDisplayTextConverter;
				}
				return valueConverter;
			}
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00007E08 File Offset: 0x00006008
		private static object CoerceToolTipIsEnabled(global::System.Windows.DependencyObject d, object value)
		{
			global::Infragistics.Windows.Editors.TextEditorBase textEditorBase = (global::Infragistics.Windows.Editors.TextEditorBase)d;
			if (textEditorBase.HasOpenDropDown)
			{
				return global::Infragistics.KnownBoxes.FalseBox;
			}
			return value;
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00007E2C File Offset: 0x0000602C
		internal void MouseLeftButtonDown_ToggleDropDownHelper(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			bool flag = this.HasDropDown && this.ShouldToggleDropDown(e);
			if (flag && !base.IsInEditMode && !base.IsFocusWithin)
			{
				base.Focus();
				if (!base.IsFocusWithin)
				{
					flag = false;
				}
			}
			if (flag)
			{
				this.ToggleDropDown();
				e.Handled = true;
			}
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00007E80 File Offset: 0x00006080
		internal virtual void RaiseDropDownClosedIfPending()
		{
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00007E84 File Offset: 0x00006084
		internal void SyncDisplayText()
		{
			string value;
			global::System.Exception ex;
			this.ConvertValueToDisplayText(base.Value, out value, out ex);
			base.SetValue(global::Infragistics.Windows.Editors.TextEditorBase.DisplayTextPropertyKey, value);
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00007EB0 File Offset: 0x000060B0
		internal virtual bool ShouldToggleDropDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			global::System.Windows.FrameworkElement frameworkElement = (base.GetTemplateChild("PART_DropDownButton") ?? base.GetTemplateChild("DropDownButton")) as global::System.Windows.FrameworkElement;
			if (frameworkElement == null && base.IsInEditMode)
			{
				frameworkElement = (global::Infragistics.Windows.Utilities.GetDescendantFromName(this, "PART_DropDownButton") ?? global::Infragistics.Windows.Utilities.GetDescendantFromName(this, "DropDownButton"));
				if (frameworkElement == null || frameworkElement.ActualHeight <= 0.0 || frameworkElement.ActualWidth <= 0.0)
				{
					base.UpdateLayout();
				}
			}
			return frameworkElement != null && global::Infragistics.Windows.Editors.Utils.IsMouseOverElement(frameworkElement, e);
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00007F3D File Offset: 0x0000613D
		internal virtual void ToggleDropDown()
		{
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00007F3F File Offset: 0x0000613F
		internal void UpdateDropDownButtonVisibility()
		{
			this.UpdateDropDownButtonVisibility(base.IsEditingAllowed);
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00007F50 File Offset: 0x00006150
		internal void UpdateDropDownButtonVisibility(bool allowButton)
		{
			bool flag = false;
			if (allowButton)
			{
				switch ((global::Infragistics.Windows.Editors.DropDownButtonDisplayMode)base.GetValue(global::Infragistics.Windows.Editors.XamComboEditor.DropDownButtonDisplayModeProperty))
				{
				case global::Infragistics.Windows.Editors.DropDownButtonDisplayMode.Always:
					flag = true;
					goto IL_63;
				case global::Infragistics.Windows.Editors.DropDownButtonDisplayMode.Focused:
					flag = (base.IsInEditMode || base.IsFocusWithin);
					goto IL_63;
				case global::Infragistics.Windows.Editors.DropDownButtonDisplayMode.OnlyInEditMode:
					flag = base.IsInEditMode;
					goto IL_63;
				}
				flag = (base.IsInEditMode || base.IsMouseOver);
			}
			IL_63:
			base.SetValue(global::Infragistics.Windows.Editors.XamComboEditor.DropDownButtonVisibilityPropertyKey, flag ? global::Infragistics.KnownBoxes.VisibilityVisibleBox : global::Infragistics.KnownBoxes.VisibilityCollapsedBox);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00007FDA File Offset: 0x000061DA
		protected override void OnEditModeEnding(global::Infragistics.Windows.Editors.Events.EditModeEndingEventArgs args)
		{
			if (this.HasOpenDropDown)
			{
				this.ToggleDropDown();
			}
			this.RaiseDropDownClosedIfPending();
			base.RaiseEventHelper(args);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00007FF8 File Offset: 0x000061F8
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (base.Host == null && base.Focusable && base.IsEnabled && !base.IsInEditMode)
			{
				this.MouseLeftButtonDown_ToggleDropDownHelper(e);
			}
			base.OnMouseLeftButtonDown(e);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00008028 File Offset: 0x00006228
		protected override void OnPreviewMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (base.Host != null && base.Focusable && base.IsEnabled && base.Host._previewMouseLeftButtonDown_EnterEditMode_TimeStamp == e.Timestamp)
			{
				this.MouseLeftButtonDown_ToggleDropDownHelper(e);
			}
			base.OnPreviewMouseLeftButtonDown(e);
		}

		// Token: 0x04000082 RID: 130
		protected static readonly global::System.Windows.DependencyPropertyKey DisplayTextPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("DisplayText", typeof(string), typeof(global::Infragistics.Windows.Editors.TextEditorBase), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None, null));

		// Token: 0x04000083 RID: 131
		public static readonly global::System.Windows.DependencyProperty DisplayTextProperty = global::Infragistics.Windows.Editors.TextEditorBase.DisplayTextPropertyKey.DependencyProperty;

		// Token: 0x04000084 RID: 132
		public static readonly global::System.Windows.DependencyProperty NullTextProperty = global::System.Windows.DependencyProperty.Register("NullText", typeof(string), typeof(global::Infragistics.Windows.Editors.TextEditorBase), new global::System.Windows.FrameworkPropertyMetadata(string.Empty, global::System.Windows.FrameworkPropertyMetadataOptions.None));

		// Token: 0x04000085 RID: 133
		public static readonly global::System.Windows.DependencyProperty ValueToDisplayTextConverterProperty = global::System.Windows.DependencyProperty.Register("ValueToDisplayTextConverter", typeof(global::System.Windows.Data.IValueConverter), typeof(global::Infragistics.Windows.Editors.TextEditorBase), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.None));
	}
}
