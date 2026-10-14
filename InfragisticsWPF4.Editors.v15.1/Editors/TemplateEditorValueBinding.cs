using System;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000066 RID: 102
	[global::System.Windows.Localizability(global::System.Windows.LocalizationCategory.None, Modifiability = global::System.Windows.Modifiability.Unmodifiable, Readability = global::System.Windows.Readability.Unreadable)]
	[global::System.Windows.Markup.MarkupExtensionReturnType(typeof(object))]
	public class TemplateEditorValueBinding : global::System.Windows.Markup.MarkupExtension
	{
		// Token: 0x060005E4 RID: 1508 RVA: 0x00018588 File Offset: 0x00016788
		public override object ProvideValue(global::System.IServiceProvider serviceProvider)
		{
			if (serviceProvider != null)
			{
				global::System.Windows.Markup.IProvideValueTarget provideValueTarget = serviceProvider.GetService(typeof(global::System.Windows.Markup.IProvideValueTarget)) as global::System.Windows.Markup.IProvideValueTarget;
				if (provideValueTarget != null)
				{
					object targetObject = provideValueTarget.TargetObject;
					object targetProperty = provideValueTarget.TargetProperty;
					global::System.Type type = null;
					object obj = null;
					string text;
					if (targetProperty == null)
					{
						text = null;
					}
					else
					{
						global::System.Windows.DependencyProperty dependencyProperty = targetProperty as global::System.Windows.DependencyProperty;
						if (dependencyProperty != null)
						{
							text = dependencyProperty.Name;
							type = dependencyProperty.PropertyType;
							global::System.Windows.PropertyMetadata propertyMetadata;
							try
							{
								propertyMetadata = ((targetObject != null) ? dependencyProperty.GetMetadata(targetObject.GetType()) : null);
							}
							catch (global::System.Exception)
							{
								propertyMetadata = dependencyProperty.DefaultMetadata;
							}
							obj = ((propertyMetadata != null) ? propertyMetadata.DefaultValue : null);
						}
						else
						{
							global::System.Reflection.PropertyInfo propertyInfo = targetProperty as global::System.Reflection.PropertyInfo;
							if (propertyInfo != null)
							{
								text = propertyInfo.Name;
								type = propertyInfo.PropertyType;
							}
							else
							{
								text = targetProperty.GetType().Name;
							}
						}
					}
					if (type != null && typeof(global::System.Windows.Data.BindingBase).IsAssignableFrom(type))
					{
						throw new global::System.Windows.Markup.XamlParseException(global::Infragistics.Windows.Editors.ValueEditor.GetString("LE_TemplateEditorValueBinding_InvalidUse_ToBinding", new object[]
						{
							text
						}));
					}
					if (this._binding == null)
					{
						this._binding = new global::System.Windows.Data.Binding();
						this._binding.Mode = this._bindingMode;
						if (this._converter != null)
						{
							this._binding.Converter = this._converter;
						}
						else if (type.IsValueType && type.IsPrimitive)
						{
							this._binding.Converter = global::Infragistics.Windows.Editors.TemplateEditorValueBinding.DefaultConverter.Instance;
						}
						this._binding.ConverterCulture = this._converterCulture;
						this._binding.ConverterParameter = this._converterParameter;
						this._binding.NotifyOnSourceUpdated = this._notifyOnSourceUpdated;
						this._binding.NotifyOnTargetUpdated = this._notifyOnTargetUpdated;
						this._binding.NotifyOnValidationError = this._notifyOnValidationError;
						this._binding.Path = new global::System.Windows.PropertyPath("(0).(1)", new object[]
						{
							global::Infragistics.Windows.Editors.TemplateEditor.EditorProperty,
							global::Infragistics.Windows.Editors.ValueEditor.ValueProperty
						});
						this._binding.RelativeSource = global::System.Windows.Data.RelativeSource.Self;
						this._binding.StringFormat = this._stringFormat;
						if (this._targetNullValue != null)
						{
							this._binding.TargetNullValue = this._targetNullValue;
						}
						else if (obj != null)
						{
							this._binding.TargetNullValue = obj;
						}
						this._binding.UpdateSourceTrigger = this._updateSourceTrigger;
						this._isSealed = true;
					}
					return this._binding.ProvideValue(serviceProvider);
				}
			}
			return this;
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060005E5 RID: 1509 RVA: 0x00018804 File Offset: 0x00016A04
		// (set) Token: 0x060005E6 RID: 1510 RVA: 0x0001880C File Offset: 0x00016A0C
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Data.IValueConverter Converter
		{
			get
			{
				return this._converter;
			}
			set
			{
				this.CheckIsSealed();
				this._converter = value;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060005E7 RID: 1511 RVA: 0x0001881B File Offset: 0x00016A1B
		// (set) Token: 0x060005E8 RID: 1512 RVA: 0x00018823 File Offset: 0x00016A23
		[global::System.ComponentModel.TypeConverter(typeof(global::System.Windows.CultureInfoIetfLanguageTagConverter))]
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Globalization.CultureInfo ConverterCulture
		{
			get
			{
				return this._converterCulture;
			}
			set
			{
				this.CheckIsSealed();
				this._converterCulture = value;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060005E9 RID: 1513 RVA: 0x00018832 File Offset: 0x00016A32
		// (set) Token: 0x060005EA RID: 1514 RVA: 0x0001883A File Offset: 0x00016A3A
		[global::System.ComponentModel.DefaultValue(null)]
		public object ConverterParameter
		{
			get
			{
				return this._converterParameter;
			}
			set
			{
				this.CheckIsSealed();
				this._converterParameter = value;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060005EB RID: 1515 RVA: 0x00018849 File Offset: 0x00016A49
		// (set) Token: 0x060005EC RID: 1516 RVA: 0x00018851 File Offset: 0x00016A51
		[global::System.ComponentModel.DefaultValue(global::System.Windows.Data.BindingMode.OneWay)]
		public global::System.Windows.Data.BindingMode Mode
		{
			get
			{
				return this._bindingMode;
			}
			set
			{
				this.CheckIsSealed();
				this._bindingMode = value;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x00018860 File Offset: 0x00016A60
		// (set) Token: 0x060005EE RID: 1518 RVA: 0x00018868 File Offset: 0x00016A68
		[global::System.ComponentModel.DefaultValue(false)]
		public bool NotifyOnSourceUpdated
		{
			get
			{
				return this._notifyOnSourceUpdated;
			}
			set
			{
				this.CheckIsSealed();
				this._notifyOnSourceUpdated = value;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060005EF RID: 1519 RVA: 0x00018877 File Offset: 0x00016A77
		// (set) Token: 0x060005F0 RID: 1520 RVA: 0x0001887F File Offset: 0x00016A7F
		[global::System.ComponentModel.DefaultValue(false)]
		public bool NotifyOnTargetUpdated
		{
			get
			{
				return this._notifyOnTargetUpdated;
			}
			set
			{
				this.CheckIsSealed();
				this._notifyOnTargetUpdated = value;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060005F1 RID: 1521 RVA: 0x0001888E File Offset: 0x00016A8E
		// (set) Token: 0x060005F2 RID: 1522 RVA: 0x00018896 File Offset: 0x00016A96
		[global::System.ComponentModel.DefaultValue(false)]
		public bool NotifyOnValidationError
		{
			get
			{
				return this._notifyOnValidationError;
			}
			set
			{
				this.CheckIsSealed();
				this._notifyOnValidationError = value;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060005F3 RID: 1523 RVA: 0x000188A5 File Offset: 0x00016AA5
		// (set) Token: 0x060005F4 RID: 1524 RVA: 0x000188AD File Offset: 0x00016AAD
		[global::System.ComponentModel.DefaultValue(null)]
		public string StringFormat
		{
			get
			{
				return this._stringFormat;
			}
			set
			{
				this.CheckIsSealed();
				this._stringFormat = value;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060005F5 RID: 1525 RVA: 0x000188BC File Offset: 0x00016ABC
		// (set) Token: 0x060005F6 RID: 1526 RVA: 0x000188C4 File Offset: 0x00016AC4
		public object TargetNullValue
		{
			get
			{
				return this._targetNullValue;
			}
			set
			{
				this.CheckIsSealed();
				this._targetNullValue = value;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060005F7 RID: 1527 RVA: 0x000188D3 File Offset: 0x00016AD3
		// (set) Token: 0x060005F8 RID: 1528 RVA: 0x000188DB File Offset: 0x00016ADB
		[global::System.ComponentModel.DefaultValue(global::System.Windows.Data.UpdateSourceTrigger.Default)]
		public global::System.Windows.Data.UpdateSourceTrigger UpdateSourceTrigger
		{
			get
			{
				return this._updateSourceTrigger;
			}
			set
			{
				this.CheckIsSealed();
				this._updateSourceTrigger = value;
			}
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x000188EA File Offset: 0x00016AEA
		private void CheckIsSealed()
		{
			if (this._isSealed)
			{
				throw new global::System.InvalidOperationException("LE_TemplateEditorValueBinding_IsSealed");
			}
		}

		// Token: 0x04000212 RID: 530
		private global::System.Windows.Data.Binding _binding;

		// Token: 0x04000213 RID: 531
		private global::System.Windows.Data.BindingMode _bindingMode = global::System.Windows.Data.BindingMode.Default;

		// Token: 0x04000214 RID: 532
		private global::System.Windows.Data.IValueConverter _converter;

		// Token: 0x04000215 RID: 533
		private global::System.Globalization.CultureInfo _converterCulture;

		// Token: 0x04000216 RID: 534
		private object _converterParameter;

		// Token: 0x04000217 RID: 535
		private bool _notifyOnSourceUpdated;

		// Token: 0x04000218 RID: 536
		private bool _notifyOnTargetUpdated;

		// Token: 0x04000219 RID: 537
		private bool _notifyOnValidationError;

		// Token: 0x0400021A RID: 538
		private string _stringFormat;

		// Token: 0x0400021B RID: 539
		private object _targetNullValue;

		// Token: 0x0400021C RID: 540
		private global::System.Windows.Data.UpdateSourceTrigger _updateSourceTrigger = global::System.Windows.Data.UpdateSourceTrigger.PropertyChanged;

		// Token: 0x0400021D RID: 541
		private bool _isSealed;

		// Token: 0x02000067 RID: 103
		private class DefaultConverter : global::System.Windows.Data.IValueConverter
		{
			// Token: 0x060005FA RID: 1530 RVA: 0x000188FF File Offset: 0x00016AFF
			private DefaultConverter()
			{
			}

			// Token: 0x060005FB RID: 1531 RVA: 0x00018908 File Offset: 0x00016B08
			public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
			{
				if (value == null || value.GetType() == targetType || targetType == typeof(object))
				{
					return value;
				}
				try
				{
					return global::Infragistics.CoreUtilities.ConvertDataValue(value, targetType, culture, null);
				}
				catch (global::System.Exception)
				{
				}
				return value;
			}

			// Token: 0x060005FC RID: 1532 RVA: 0x00018960 File Offset: 0x00016B60
			public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
			{
				return value;
			}

			// Token: 0x0400021E RID: 542
			public static readonly global::Infragistics.Windows.Editors.TemplateEditorValueBinding.DefaultConverter Instance = new global::Infragistics.Windows.Editors.TemplateEditorValueBinding.DefaultConverter();
		}
	}
}
