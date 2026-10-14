using System;
using System.ComponentModel;

namespace DevAge.ComponentModel.Validator
{
	// Token: 0x020002C4 RID: 708
	internal class ValidatorTypeConverter : global::DevAge.ComponentModel.Validator.ValidatorBase
	{
		// Token: 0x06002299 RID: 8857 RVA: 0x00079A80 File Offset: 0x00077C80
		public ValidatorTypeConverter()
		{
			this.m_TypeConverter = null;
		}

		// Token: 0x0600229A RID: 8858 RVA: 0x00079A90 File Offset: 0x00077C90
		public ValidatorTypeConverter(global::System.Type p_Type) : base(p_Type)
		{
		}

		// Token: 0x0600229B RID: 8859 RVA: 0x00079A9C File Offset: 0x00077C9C
		public ValidatorTypeConverter(global::System.Type p_Type, global::System.ComponentModel.TypeConverter p_TypeConverter) : base(p_Type)
		{
			this.TypeConverter = p_TypeConverter;
		}

		// Token: 0x0600229C RID: 8860 RVA: 0x00079AAC File Offset: 0x00077CAC
		public override bool IsStringConversionSupported()
		{
			if (typeof(string).IsAssignableFrom(base.ValueType))
			{
				return base.AllowStringConversion;
			}
			if (this.m_TypeConverter != null)
			{
				return base.AllowStringConversion && this.m_TypeConverter.CanConvertFrom(typeof(string)) && this.m_TypeConverter.CanConvertTo(typeof(string));
			}
			return base.AllowStringConversion;
		}

		// Token: 0x0600229D RID: 8861 RVA: 0x00079B2C File Offset: 0x00077D2C
		protected override void OnConvertingObjectToValue(global::DevAge.ComponentModel.ConvertingObjectEventArgs e)
		{
			base.OnConvertingObjectToValue(e);
			if (e.ConvertingStatus == global::DevAge.ComponentModel.ConvertingStatus.Error)
			{
				throw new global::System.ApplicationException("Invalid conversion");
			}
			if (e.ConvertingStatus == global::DevAge.ComponentModel.ConvertingStatus.Completed)
			{
				return;
			}
			if (e.Value == null)
			{
				return;
			}
			if (e.Value is string)
			{
				string text = (string)e.Value;
				if (this.IsNullString(text))
				{
					e.Value = null;
					return;
				}
				if (e.DestinationType.IsAssignableFrom(e.Value.GetType()))
				{
					return;
				}
				if (this.IsStringConversionSupported())
				{
					e.Value = this.m_TypeConverter.ConvertFromString(global::DevAge.ComponentModel.EmptyTypeDescriptorContext.Empty, base.CultureInfo, text);
					return;
				}
				throw new global::System.ApplicationException("String conversion not supported for this type of Validator.");
			}
			else
			{
				if (e.DestinationType.IsAssignableFrom(e.Value.GetType()))
				{
					return;
				}
				if (this.m_TypeConverter != null)
				{
					e.Value = this.m_TypeConverter.ConvertFrom(global::DevAge.ComponentModel.EmptyTypeDescriptorContext.Empty, base.CultureInfo, e.Value);
				}
				return;
			}
		}

		// Token: 0x0600229E RID: 8862 RVA: 0x00079C40 File Offset: 0x00077E40
		protected override void OnConvertingValueToObject(global::DevAge.ComponentModel.ConvertingObjectEventArgs e)
		{
			base.OnConvertingValueToObject(e);
			if (e.ConvertingStatus == global::DevAge.ComponentModel.ConvertingStatus.Error)
			{
				throw new global::System.ApplicationException("Invalid conversion");
			}
			if (e.ConvertingStatus == global::DevAge.ComponentModel.ConvertingStatus.Completed)
			{
				return;
			}
			if (e.Value == null)
			{
				return;
			}
			if (e.DestinationType.IsAssignableFrom(e.Value.GetType()))
			{
				return;
			}
			if (e.DestinationType == typeof(string) && !this.IsStringConversionSupported())
			{
				throw new global::System.ApplicationException("String conversion not supported for this type of Validator.");
			}
			if (this.m_TypeConverter != null)
			{
				e.Value = this.m_TypeConverter.ConvertTo(global::DevAge.ComponentModel.EmptyTypeDescriptorContext.Empty, base.CultureInfo, e.Value, e.DestinationType);
			}
		}

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x0600229F RID: 8863 RVA: 0x00079D04 File Offset: 0x00077F04
		// (set) Token: 0x060022A0 RID: 8864 RVA: 0x00079D0C File Offset: 0x00077F0C
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.ComponentModel.TypeConverter TypeConverter
		{
			get
			{
				return this.m_TypeConverter;
			}
			set
			{
				if (this.m_TypeConverter != value)
				{
					this.m_TypeConverter = value;
					this.OnLoadingTypeConverter();
					this.OnChanged(global::System.EventArgs.Empty);
				}
			}
		}

		// Token: 0x060022A1 RID: 8865 RVA: 0x00079D34 File Offset: 0x00077F34
		private void OnLoadingTypeConverter()
		{
			base.StandardValues = null;
			base.StandardValuesExclusive = false;
			if (this.m_TypeConverter != null)
			{
				base.StandardValues = this.m_TypeConverter.GetStandardValues();
				if (base.StandardValues != null && base.StandardValues.Count > 0)
				{
					base.StandardValuesExclusive = this.m_TypeConverter.GetStandardValuesExclusive();
					return;
				}
				base.StandardValuesExclusive = false;
			}
		}

		// Token: 0x060022A2 RID: 8866 RVA: 0x00079DA4 File Offset: 0x00077FA4
		protected override void OnLoadingValueType()
		{
			base.OnLoadingValueType();
			if (base.ValueType != null)
			{
				this.TypeConverter = global::System.ComponentModel.TypeDescriptor.GetConverter(base.ValueType);
				return;
			}
			this.TypeConverter = null;
		}

		// Token: 0x04000C70 RID: 3184
		private global::System.ComponentModel.TypeConverter m_TypeConverter;
	}
}
