using System;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020002F8 RID: 760
	[global::System.Windows.Localizability(global::System.Windows.LocalizationCategory.None, Modifiability = global::System.Windows.Modifiability.Unmodifiable, Readability = global::System.Windows.Readability.Unreadable)]
	[global::System.Windows.Markup.MarkupExtensionReturnType(typeof(object))]
	public class FieldBinding : global::System.Windows.Markup.MarkupExtension
	{
		// Token: 0x06002324 RID: 8996 RVA: 0x00098DBD File Offset: 0x00096FBD
		public FieldBinding()
		{
		}

		// Token: 0x06002325 RID: 8997 RVA: 0x00098DCC File Offset: 0x00096FCC
		public FieldBinding(string path)
		{
			this._path = path;
		}

		// Token: 0x06002326 RID: 8998 RVA: 0x00098DE4 File Offset: 0x00096FE4
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
					bool flag = false;
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
							global::System.Windows.PropertyMetadata propertyMetadata = (targetObject != null) ? dependencyProperty.GetMetadata(targetObject.GetType()) : null;
							obj = ((propertyMetadata != null) ? propertyMetadata.DefaultValue : null);
							if (obj == global::Infragistics.Windows.DataPresenter.Field.DefaultValueMarker.Instance)
							{
								obj = null;
							}
							flag = (dependencyProperty == global::Infragistics.Windows.DataPresenter.Field.DataContextProperty);
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
						throw new global::System.Windows.Markup.XamlParseException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_FieldBinding_InvalidUse_ToBinding", new object[]
						{
							text
						}));
					}
					if (targetObject is global::Infragistics.Windows.DataPresenter.Field || targetObject is global::Infragistics.Windows.DataPresenter.FieldLayout || targetObject is global::Infragistics.Windows.DataPresenter.FieldLayoutSettings || targetObject is global::Infragistics.Windows.DataPresenter.FieldSettings)
					{
						global::Infragistics.Windows.DataPresenter.FieldSettings fieldSettings = targetObject as global::Infragistics.Windows.DataPresenter.FieldSettings;
						if (fieldSettings != null)
						{
							fieldSettings.HasFieldBinding = true;
						}
						else
						{
							global::Infragistics.Windows.DataPresenter.FieldLayoutSettings fieldLayoutSettings = targetObject as global::Infragistics.Windows.DataPresenter.FieldLayoutSettings;
							if (fieldLayoutSettings != null)
							{
								fieldLayoutSettings.HasFieldBinding = true;
							}
						}
						if (this._binding == null)
						{
							this._binding = new global::System.Windows.Data.Binding();
							this._binding.RelativeSource = global::System.Windows.Data.RelativeSource.Self;
							global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
							if (flag)
							{
								if (targetObject is global::Infragistics.Windows.DataPresenter.Field)
								{
									stringBuilder.Append("Owner.DataPresenter.(0)");
								}
								else
								{
									if (!(targetObject is global::Infragistics.Windows.DataPresenter.FieldLayout))
									{
										throw new global::System.Windows.Markup.XamlParseException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_FieldBinding_InvalidUse_ToBinding", new object[]
										{
											text
										}));
									}
									stringBuilder.Append("DataPresenter.(0)");
								}
							}
							else
							{
								stringBuilder.Append("(0)");
							}
							if (!string.IsNullOrEmpty(this._path))
							{
								stringBuilder.Append(".");
								stringBuilder.Append(this._path);
							}
							this._binding.Path = new global::System.Windows.PropertyPath(stringBuilder.ToString(), new object[]
							{
								global::System.Windows.FrameworkElement.DataContextProperty
							});
							this._binding.Mode = this._bindingMode;
							this._binding.Converter = this._converter;
							this._binding.ConverterCulture = this._converterCulture;
							this._binding.ConverterParameter = this._converterParameter;
							this._binding.NotifyOnSourceUpdated = this._notifyOnSourceUpdated;
							this._binding.NotifyOnTargetUpdated = this._notifyOnTargetUpdated;
							this._binding.NotifyOnValidationError = this._notifyOnValidationError;
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
					throw new global::System.Windows.Markup.XamlParseException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_FieldBinding_InvalidUse", new object[]
					{
						text
					}));
				}
			}
			return this;
		}

		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x06002327 RID: 8999 RVA: 0x0009911F File Offset: 0x0009731F
		// (set) Token: 0x06002328 RID: 9000 RVA: 0x00099127 File Offset: 0x00097327
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

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x06002329 RID: 9001 RVA: 0x00099136 File Offset: 0x00097336
		// (set) Token: 0x0600232A RID: 9002 RVA: 0x0009913E File Offset: 0x0009733E
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

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x0600232B RID: 9003 RVA: 0x0009914D File Offset: 0x0009734D
		// (set) Token: 0x0600232C RID: 9004 RVA: 0x00099155 File Offset: 0x00097355
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

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x0600232D RID: 9005 RVA: 0x00099164 File Offset: 0x00097364
		// (set) Token: 0x0600232E RID: 9006 RVA: 0x0009916C File Offset: 0x0009736C
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

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x0600232F RID: 9007 RVA: 0x0009917B File Offset: 0x0009737B
		// (set) Token: 0x06002330 RID: 9008 RVA: 0x00099183 File Offset: 0x00097383
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

		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x06002331 RID: 9009 RVA: 0x00099192 File Offset: 0x00097392
		// (set) Token: 0x06002332 RID: 9010 RVA: 0x0009919A File Offset: 0x0009739A
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

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x06002333 RID: 9011 RVA: 0x000991A9 File Offset: 0x000973A9
		// (set) Token: 0x06002334 RID: 9012 RVA: 0x000991B1 File Offset: 0x000973B1
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

		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x06002335 RID: 9013 RVA: 0x000991C0 File Offset: 0x000973C0
		// (set) Token: 0x06002336 RID: 9014 RVA: 0x000991C8 File Offset: 0x000973C8
		public string Path
		{
			get
			{
				return this._path;
			}
			set
			{
				this.CheckIsSealed();
				this._path = value;
			}
		}

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x06002337 RID: 9015 RVA: 0x000991D7 File Offset: 0x000973D7
		// (set) Token: 0x06002338 RID: 9016 RVA: 0x000991DF File Offset: 0x000973DF
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

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x06002339 RID: 9017 RVA: 0x000991EE File Offset: 0x000973EE
		// (set) Token: 0x0600233A RID: 9018 RVA: 0x000991F6 File Offset: 0x000973F6
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

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x0600233B RID: 9019 RVA: 0x00099205 File Offset: 0x00097405
		// (set) Token: 0x0600233C RID: 9020 RVA: 0x0009920D File Offset: 0x0009740D
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

		// Token: 0x0600233D RID: 9021 RVA: 0x0009921C File Offset: 0x0009741C
		private void CheckIsSealed()
		{
			if (this._isSealed)
			{
				throw new global::System.InvalidOperationException("LE_FieldBinding_IsSealed");
			}
		}

		// Token: 0x04001194 RID: 4500
		private global::System.Windows.Data.Binding _binding;

		// Token: 0x04001195 RID: 4501
		private global::System.Windows.Data.BindingMode _bindingMode = global::System.Windows.Data.BindingMode.Default;

		// Token: 0x04001196 RID: 4502
		private global::System.Windows.Data.IValueConverter _converter;

		// Token: 0x04001197 RID: 4503
		private global::System.Globalization.CultureInfo _converterCulture;

		// Token: 0x04001198 RID: 4504
		private object _converterParameter;

		// Token: 0x04001199 RID: 4505
		private bool _notifyOnSourceUpdated;

		// Token: 0x0400119A RID: 4506
		private bool _notifyOnTargetUpdated;

		// Token: 0x0400119B RID: 4507
		private bool _notifyOnValidationError;

		// Token: 0x0400119C RID: 4508
		private string _path;

		// Token: 0x0400119D RID: 4509
		private string _stringFormat;

		// Token: 0x0400119E RID: 4510
		private object _targetNullValue;

		// Token: 0x0400119F RID: 4511
		private global::System.Windows.Data.UpdateSourceTrigger _updateSourceTrigger;

		// Token: 0x040011A0 RID: 4512
		private bool _isSealed;
	}
}
