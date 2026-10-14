using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using Infragistics.Controls.Editors.Primitives;

namespace Infragistics.Controls.Editors
{
	// Token: 0x02000046 RID: 70
	public abstract class TextInputBase : global::Infragistics.Controls.Editors.ValueInput
	{
		// Token: 0x0600032F RID: 815 RVA: 0x000116C9 File Offset: 0x0000F8C9
		protected override void DoInitialization()
		{
			base.DoInitialization();
			this.SyncDisplayText();
		}

		// Token: 0x06000330 RID: 816 RVA: 0x000116D8 File Offset: 0x0000F8D8
		internal override void ProcessPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.ProcessPropertyChanged(e);
			global::System.Windows.DependencyProperty property = e.Property;
			if (global::System.Windows.FrameworkElement.LanguageProperty == property || global::Infragistics.Controls.Editors.ValueInput.FormatProperty == property || global::Infragistics.Controls.Editors.ValueInput.FormatProviderProperty == property)
			{
				this.SyncDisplayText();
				return;
			}
			if (global::Infragistics.Controls.Editors.TextInputBase.NullTextProperty == property)
			{
				this.SyncDisplayText();
			}
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00011724 File Offset: 0x0000F924
		internal override bool SyncValuePropertiesOverride(global::System.Windows.DependencyProperty prop, object newValue, out global::System.Exception error)
		{
			bool result = base.SyncValuePropertiesOverride(prop, newValue, out error);
			this.SyncDisplayText();
			return result;
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000332 RID: 818 RVA: 0x00011742 File Offset: 0x0000F942
		protected virtual global::System.Windows.Data.IValueConverter DefaultValueToDisplayTextConverter
		{
			get
			{
				return global::Infragistics.Controls.Editors.ValueInputDefaultConverter.ValueToDisplayTextConverter;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000333 RID: 819 RVA: 0x00011749 File Offset: 0x0000F949
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public string DisplayText
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Editors.TextInputBase.DisplayTextProperty);
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000334 RID: 820 RVA: 0x0001175B File Offset: 0x0000F95B
		// (set) Token: 0x06000335 RID: 821 RVA: 0x0001176D File Offset: 0x0000F96D
		[global::System.ComponentModel.Bindable(true)]
		public string NullText
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Editors.TextInputBase.NullTextProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.TextInputBase.NullTextProperty, value);
			}
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0001177B File Offset: 0x0000F97B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeNullText()
		{
			return global::Infragistics.DependencyPropertyUtilities.ShouldSerialize(this, global::Infragistics.Controls.Editors.TextInputBase.NullTextProperty);
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00011788 File Offset: 0x0000F988
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetNullText()
		{
			base.ClearValue(global::Infragistics.Controls.Editors.TextInputBase.NullTextProperty);
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000338 RID: 824 RVA: 0x00011795 File Offset: 0x0000F995
		// (set) Token: 0x06000339 RID: 825 RVA: 0x000117A7 File Offset: 0x0000F9A7
		public global::System.Windows.Data.IValueConverter ValueToDisplayTextConverter
		{
			get
			{
				return (global::System.Windows.Data.IValueConverter)base.GetValue(global::Infragistics.Controls.Editors.TextInputBase.ValueToDisplayTextConverterProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.TextInputBase.ValueToDisplayTextConverterProperty, value);
			}
		}

		// Token: 0x0600033A RID: 826 RVA: 0x000117B8 File Offset: 0x0000F9B8
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ConvertDisplayTextToValue(string displayText, out object value, out global::System.Exception error)
		{
			error = null;
			value = null;
			try
			{
				value = this.ValueToDisplayTextConverterResolved.ConvertBack(displayText, base.ValueTypeResolved, this, base.FormatProviderResolved as global::System.Globalization.CultureInfo);
				if (value == null)
				{
					if (displayText != null && displayText.Length != 0 && !(displayText == this.NullText))
					{
						error = global::Infragistics.Controls.Editors.Primitives.Utils.GetTextToValueConversionError(base.ValueTypeResolved, displayText);
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

		// Token: 0x0600033B RID: 827 RVA: 0x0001183C File Offset: 0x0000FA3C
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

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600033C RID: 828 RVA: 0x00011898 File Offset: 0x0000FA98
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		[global::System.ComponentModel.Browsable(false)]
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

		// Token: 0x0600033D RID: 829 RVA: 0x000118B8 File Offset: 0x0000FAB8
		internal void MouseLeftButtonDown_ToggleDropDownHelper(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			bool flag = this.HasDropDown && this.ShouldToggleDropDown(e);
			if (flag && !base.IsKeyboardFocusWithin)
			{
				base.Focus();
				if (!base.IsKeyboardFocusWithin)
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

		// Token: 0x0600033E RID: 830 RVA: 0x00011904 File Offset: 0x0000FB04
		internal virtual void RaiseDropDownClosedIfPending()
		{
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00011908 File Offset: 0x0000FB08
		internal void SyncDisplayText()
		{
			string value;
			global::System.Exception ex;
			this.ConvertValueToDisplayText(base.Value, out value, out ex);
			base.SetValue(global::Infragistics.Controls.Editors.TextInputBase.DisplayTextPropertyKey, value);
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00011934 File Offset: 0x0000FB34
		internal virtual bool ShouldToggleDropDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			global::System.Windows.FrameworkElement frameworkElement = (base.GetTemplateChild("PART_DropDownButton") ?? base.GetTemplateChild("DropDownButton")) as global::System.Windows.FrameworkElement;
			return frameworkElement != null && global::Infragistics.Controls.Editors.Primitives.Utils.IsMouseOverElement(frameworkElement, e);
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00011970 File Offset: 0x0000FB70
		internal virtual void ToggleDropDown()
		{
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00011972 File Offset: 0x0000FB72
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (global::Infragistics.Controls.Editors.Primitives.Utils.IsFocusable(this) && base.IsEnabled && !base.IsInEditMode)
			{
				this.MouseLeftButtonDown_ToggleDropDownHelper(e);
			}
			base.OnMouseLeftButtonDown(e);
		}

		// Token: 0x04000124 RID: 292
		internal static readonly global::System.Windows.DependencyPropertyKey DisplayTextPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("DisplayText", typeof(string), typeof(global::Infragistics.Controls.Editors.TextInputBase), null, null);

		// Token: 0x04000125 RID: 293
		public static readonly global::System.Windows.DependencyProperty DisplayTextProperty = global::Infragistics.Controls.Editors.TextInputBase.DisplayTextPropertyKey.DependencyProperty;

		// Token: 0x04000126 RID: 294
		public static readonly global::System.Windows.DependencyProperty NullTextProperty = global::Infragistics.DependencyPropertyUtilities.Register("NullText", typeof(string), typeof(global::Infragistics.Controls.Editors.TextInputBase), string.Empty, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.ValueInput.OnProcessPropertyChangedCallback));

		// Token: 0x04000127 RID: 295
		public static readonly global::System.Windows.DependencyProperty ValueToDisplayTextConverterProperty = global::Infragistics.DependencyPropertyUtilities.Register("ValueToDisplayTextConverter", typeof(global::System.Windows.Data.IValueConverter), typeof(global::Infragistics.Controls.Editors.TextInputBase), null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.ValueInput.OnProcessPropertyChangedCallback));
	}
}
