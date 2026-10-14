using System;
using System.Collections;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;

namespace DevAge.ComponentModel.Validator
{
	// Token: 0x02000288 RID: 648
	internal class ValidatorBase : global::DevAge.ComponentModel.ComponentLight, global::DevAge.ComponentModel.Validator.IValidator
	{
		// Token: 0x0600212A RID: 8490 RVA: 0x000760C0 File Offset: 0x000742C0
		public ValidatorBase()
		{
			this.ValueType = null;
		}

		// Token: 0x0600212B RID: 8491 RVA: 0x000760D8 File Offset: 0x000742D8
		public ValidatorBase(global::System.Type type)
		{
			this.ValueType = type;
		}

		// Token: 0x0600212C RID: 8492 RVA: 0x000760F0 File Offset: 0x000742F0
		protected virtual void OnLoadingValueType()
		{
			if (this.ValueType != null)
			{
				if (this.ValueType.IsValueType)
				{
					this.m_bAllowNull = false;
					if (this.ValueType.IsEnum)
					{
						global::System.Reflection.FieldInfo[] fields = this.ValueType.GetFields(global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public);
						this.m_DefaultValue = fields[0].GetValue(null);
					}
					else
					{
						this.m_DefaultValue = global::System.Activator.CreateInstance(this.ValueType);
					}
				}
				else
				{
					this.m_DefaultValue = null;
					this.m_bAllowNull = true;
				}
				this.m_StandardValues = null;
				this.m_bStandardValuesExclusive = false;
				this.m_MaximumValue = null;
				this.m_MinimumValue = null;
				this.m_sNullString = "";
				this.m_sNullDisplayString = "";
				return;
			}
			this.m_bAllowNull = true;
			this.m_DefaultValue = null;
			this.m_StandardValues = null;
			this.m_bStandardValuesExclusive = false;
			this.m_MaximumValue = null;
			this.m_MinimumValue = null;
			this.m_sNullString = "";
			this.m_sNullDisplayString = "";
		}

		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x0600212D RID: 8493 RVA: 0x000761F0 File Offset: 0x000743F0
		// (set) Token: 0x0600212E RID: 8494 RVA: 0x000761F8 File Offset: 0x000743F8
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DefaultValue(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool AllowNull
		{
			get
			{
				return this.m_bAllowNull;
			}
			set
			{
				if (this.m_bAllowNull != value)
				{
					this.m_bAllowNull = value;
					this.OnChanged(global::System.EventArgs.Empty);
				}
			}
		}

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x0600212F RID: 8495 RVA: 0x00076218 File Offset: 0x00074418
		// (set) Token: 0x06002130 RID: 8496 RVA: 0x00076220 File Offset: 0x00074420
		[global::System.ComponentModel.DefaultValue("")]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public string NullString
		{
			get
			{
				return this.m_sNullString;
			}
			set
			{
				if (this.m_sNullString != value)
				{
					this.m_sNullString = value;
					this.OnChanged(global::System.EventArgs.Empty);
				}
			}
		}

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x06002131 RID: 8497 RVA: 0x00076248 File Offset: 0x00074448
		// (set) Token: 0x06002132 RID: 8498 RVA: 0x00076250 File Offset: 0x00074450
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.DefaultValue("")]
		[global::System.ComponentModel.Browsable(false)]
		public string NullDisplayString
		{
			get
			{
				return this.m_sNullDisplayString;
			}
			set
			{
				if (this.m_sNullDisplayString != value)
				{
					this.m_sNullDisplayString = value;
					this.OnChanged(global::System.EventArgs.Empty);
				}
			}
		}

		// Token: 0x06002133 RID: 8499 RVA: 0x00076278 File Offset: 0x00074478
		public virtual bool IsNullString(string p_str)
		{
			return p_str == null || p_str == this.m_sNullString;
		}

		// Token: 0x06002134 RID: 8500 RVA: 0x00076290 File Offset: 0x00074490
		public virtual string ObjectToStringForError(object val)
		{
			string result;
			try
			{
				if (val == null)
				{
					result = "<null>";
				}
				else
				{
					result = val.ToString();
				}
			}
			catch (global::System.Exception)
			{
				result = "<object>";
			}
			return result;
		}

		// Token: 0x06002135 RID: 8501 RVA: 0x000762D8 File Offset: 0x000744D8
		public object ObjectToValue(object p_Object)
		{
			global::System.Type type = this.ValueType;
			if (type == null && p_Object != null)
			{
				type = p_Object.GetType();
			}
			global::DevAge.ComponentModel.ConvertingObjectEventArgs convertingObjectEventArgs = new global::DevAge.ComponentModel.ConvertingObjectEventArgs(p_Object, type);
			this.OnConvertingObjectToValue(convertingObjectEventArgs);
			if (convertingObjectEventArgs.ConvertingStatus == global::DevAge.ComponentModel.ConvertingStatus.Error)
			{
				throw new global::DevAge.ConversionErrorException(this.ValueTypeName, this.ObjectToStringForError(convertingObjectEventArgs.Value));
			}
			if (this.IsValidValue(convertingObjectEventArgs.Value))
			{
				return convertingObjectEventArgs.Value;
			}
			throw new global::DevAge.ConversionErrorException(this.ValueTypeName, this.ObjectToStringForError(convertingObjectEventArgs.Value));
		}

		// Token: 0x06002136 RID: 8502 RVA: 0x00076368 File Offset: 0x00074568
		public object ValueToObject(object p_Value, global::System.Type p_ReturnObjectType)
		{
			if (p_ReturnObjectType == null)
			{
				throw new global::DevAge.DevAgeApplicationException("Invalid parameter returnObjectType cannot be null");
			}
			global::DevAge.ComponentModel.ConvertingObjectEventArgs convertingObjectEventArgs = new global::DevAge.ComponentModel.ConvertingObjectEventArgs(p_Value, p_ReturnObjectType);
			this.OnConvertingValueToObject(convertingObjectEventArgs);
			if (convertingObjectEventArgs.ConvertingStatus == global::DevAge.ComponentModel.ConvertingStatus.Error)
			{
				throw new global::DevAge.ConversionErrorException(p_ReturnObjectType.Name, this.ObjectToStringForError(convertingObjectEventArgs.Value));
			}
			if (convertingObjectEventArgs.Value == null)
			{
				return null;
			}
			if (convertingObjectEventArgs.DestinationType.IsAssignableFrom(convertingObjectEventArgs.Value.GetType()))
			{
				return convertingObjectEventArgs.Value;
			}
			throw new global::DevAge.ConversionErrorException(p_ReturnObjectType.Name, this.ObjectToStringForError(convertingObjectEventArgs.Value));
		}

		// Token: 0x06002137 RID: 8503 RVA: 0x00076404 File Offset: 0x00074604
		public string ValueToString(object p_Value)
		{
			object obj = this.ValueToObject(p_Value, typeof(string));
			if (obj == null)
			{
				return null;
			}
			return (string)obj;
		}

		// Token: 0x06002138 RID: 8504 RVA: 0x00076438 File Offset: 0x00074638
		public object StringToValue(string p_str)
		{
			return this.ObjectToValue(p_str);
		}

		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x06002139 RID: 8505 RVA: 0x00076444 File Offset: 0x00074644
		// (set) Token: 0x0600213A RID: 8506 RVA: 0x0007644C File Offset: 0x0007464C
		[global::System.ComponentModel.DefaultValue(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public bool AllowStringConversion
		{
			get
			{
				return this.m_bAllowStringConversion;
			}
			set
			{
				if (this.m_bAllowStringConversion != value)
				{
					this.m_bAllowStringConversion = value;
					this.OnChanged(global::System.EventArgs.Empty);
				}
			}
		}

		// Token: 0x0600213B RID: 8507 RVA: 0x0007646C File Offset: 0x0007466C
		public virtual bool IsStringConversionSupported()
		{
			return (this.AllowStringConversion && typeof(string) == this.ValueType) || this.ValueType == null;
		}

		// Token: 0x0600213C RID: 8508 RVA: 0x0007649C File Offset: 0x0007469C
		public virtual string ValueToDisplayString(object p_Value)
		{
			global::DevAge.ComponentModel.ConvertingObjectEventArgs convertingObjectEventArgs = new global::DevAge.ComponentModel.ConvertingObjectEventArgs(p_Value, typeof(string));
			this.OnConvertingValueToDisplayString(convertingObjectEventArgs);
			if (convertingObjectEventArgs.ConvertingStatus == global::DevAge.ComponentModel.ConvertingStatus.Error)
			{
				throw new global::DevAge.ConversionErrorException("display String", this.ObjectToStringForError(convertingObjectEventArgs.Value));
			}
			if (convertingObjectEventArgs.Value == null)
			{
				return this.NullDisplayString;
			}
			if (convertingObjectEventArgs.Value is string)
			{
				return (string)convertingObjectEventArgs.Value;
			}
			throw new global::DevAge.ConversionErrorException("display String", this.ObjectToStringForError(convertingObjectEventArgs.Value));
		}

		// Token: 0x14000094 RID: 148
		// (add) Token: 0x0600213D RID: 8509 RVA: 0x0007652C File Offset: 0x0007472C
		// (remove) Token: 0x0600213E RID: 8510 RVA: 0x00076548 File Offset: 0x00074748
		public event global::DevAge.ComponentModel.ConvertingObjectEventHandler ConvertingObjectToValue
		{
			add
			{
				this.m_ConvertingObjectToValue = (global::DevAge.ComponentModel.ConvertingObjectEventHandler)global::System.Delegate.Combine(this.m_ConvertingObjectToValue, value);
			}
			remove
			{
				this.m_ConvertingObjectToValue = (global::DevAge.ComponentModel.ConvertingObjectEventHandler)global::System.Delegate.Remove(this.m_ConvertingObjectToValue, value);
			}
		}

		// Token: 0x14000095 RID: 149
		// (add) Token: 0x0600213F RID: 8511 RVA: 0x00076564 File Offset: 0x00074764
		// (remove) Token: 0x06002140 RID: 8512 RVA: 0x00076580 File Offset: 0x00074780
		public event global::DevAge.ComponentModel.ConvertingObjectEventHandler ConvertingValueToObject
		{
			add
			{
				this.m_ConvertingValueToObject = (global::DevAge.ComponentModel.ConvertingObjectEventHandler)global::System.Delegate.Combine(this.m_ConvertingValueToObject, value);
			}
			remove
			{
				this.m_ConvertingValueToObject = (global::DevAge.ComponentModel.ConvertingObjectEventHandler)global::System.Delegate.Remove(this.m_ConvertingValueToObject, value);
			}
		}

		// Token: 0x14000096 RID: 150
		// (add) Token: 0x06002141 RID: 8513 RVA: 0x0007659C File Offset: 0x0007479C
		// (remove) Token: 0x06002142 RID: 8514 RVA: 0x000765B8 File Offset: 0x000747B8
		public event global::DevAge.ComponentModel.ConvertingObjectEventHandler ConvertingValueToDisplayString
		{
			add
			{
				this.m_ConvertingValueToDisplayString = (global::DevAge.ComponentModel.ConvertingObjectEventHandler)global::System.Delegate.Combine(this.m_ConvertingValueToDisplayString, value);
			}
			remove
			{
				this.m_ConvertingValueToDisplayString = (global::DevAge.ComponentModel.ConvertingObjectEventHandler)global::System.Delegate.Remove(this.m_ConvertingValueToDisplayString, value);
			}
		}

		// Token: 0x06002143 RID: 8515 RVA: 0x000765D4 File Offset: 0x000747D4
		protected virtual void OnConvertingObjectToValue(global::DevAge.ComponentModel.ConvertingObjectEventArgs e)
		{
			if (this.m_ConvertingObjectToValue != null)
			{
				this.m_ConvertingObjectToValue(this, e);
			}
			if (e.ConvertingStatus == global::DevAge.ComponentModel.ConvertingStatus.Error)
			{
				throw new global::DevAge.ConversionErrorException(e.DestinationType.Name, this.ObjectToStringForError(e.Value));
			}
			if (e.ConvertingStatus == global::DevAge.ComponentModel.ConvertingStatus.Completed)
			{
				return;
			}
			if (e.Value is string)
			{
				string p_str = (string)e.Value;
				if (this.IsNullString(p_str))
				{
					e.Value = null;
				}
			}
		}

		// Token: 0x06002144 RID: 8516 RVA: 0x00076664 File Offset: 0x00074864
		protected virtual void OnConvertingValueToObject(global::DevAge.ComponentModel.ConvertingObjectEventArgs e)
		{
			if (this.m_ConvertingValueToObject != null)
			{
				this.m_ConvertingValueToObject(this, e);
			}
			if (e.ConvertingStatus == global::DevAge.ComponentModel.ConvertingStatus.Error)
			{
				throw new global::DevAge.ConversionErrorException(e.DestinationType.Name, this.ObjectToStringForError(e.Value));
			}
			global::DevAge.ComponentModel.ConvertingStatus convertingStatus = e.ConvertingStatus;
		}

		// Token: 0x06002145 RID: 8517 RVA: 0x000766C0 File Offset: 0x000748C0
		protected virtual void OnConvertingValueToDisplayString(global::DevAge.ComponentModel.ConvertingObjectEventArgs e)
		{
			if (this.m_ConvertingValueToDisplayString != null)
			{
				this.m_ConvertingValueToDisplayString(this, e);
			}
			if (e.ConvertingStatus == global::DevAge.ComponentModel.ConvertingStatus.Error)
			{
				throw new global::DevAge.ConversionErrorException("display String", this.ObjectToStringForError(e.Value));
			}
			if (e.ConvertingStatus == global::DevAge.ComponentModel.ConvertingStatus.Completed)
			{
				return;
			}
			if (e.Value == null)
			{
				e.Value = this.NullDisplayString;
				return;
			}
			if (this.IsStringConversionSupported())
			{
				e.Value = this.ValueToString(e.Value);
				return;
			}
			e.Value = e.Value.ToString();
		}

		// Token: 0x06002146 RID: 8518 RVA: 0x00076760 File Offset: 0x00074960
		public bool IsValidValue(object p_Value)
		{
			bool result;
			try
			{
				if (this.IsInStandardValues(p_Value))
				{
					result = true;
				}
				else if (p_Value == null)
				{
					if (this.AllowNull)
					{
						result = true;
					}
					else
					{
						result = false;
					}
				}
				else if (this.m_bStandardValuesExclusive)
				{
					result = false;
				}
				else
				{
					if (this.m_MaximumValue != null)
					{
						global::System.IComparable comparable = (global::System.IComparable)this.m_MaximumValue;
						if (comparable.CompareTo(p_Value) < 0)
						{
							return false;
						}
					}
					if (this.m_MinimumValue != null)
					{
						global::System.IComparable comparable2 = (global::System.IComparable)this.m_MinimumValue;
						if (comparable2.CompareTo(p_Value) > 0)
						{
							return false;
						}
					}
					if (this.ValueType != null)
					{
						result = this.ValueType.IsAssignableFrom(p_Value.GetType());
					}
					else
					{
						result = true;
					}
				}
			}
			catch (global::System.Exception)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06002147 RID: 8519 RVA: 0x0007684C File Offset: 0x00074A4C
		public bool IsValidObject(object p_Object)
		{
			object obj;
			return this.IsValidObject(p_Object, out obj);
		}

		// Token: 0x06002148 RID: 8520 RVA: 0x00076868 File Offset: 0x00074A68
		public bool IsValidObject(object p_Object, out object p_ValueConverted)
		{
			p_ValueConverted = null;
			bool result;
			try
			{
				p_ValueConverted = this.ObjectToValue(p_Object);
				result = this.IsValidValue(p_ValueConverted);
			}
			catch (global::System.Exception)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06002149 RID: 8521 RVA: 0x000768A8 File Offset: 0x00074AA8
		public bool IsValidString(string p_strValue)
		{
			object obj;
			return this.IsValidString(p_strValue, out obj);
		}

		// Token: 0x0600214A RID: 8522 RVA: 0x000768C4 File Offset: 0x00074AC4
		public bool IsValidString(string p_strValue, out object p_ValueConverted)
		{
			return this.IsValidObject(p_strValue, out p_ValueConverted);
		}

		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x0600214B RID: 8523 RVA: 0x000768D0 File Offset: 0x00074AD0
		// (set) Token: 0x0600214C RID: 8524 RVA: 0x000768D8 File Offset: 0x00074AD8
		[global::System.ComponentModel.DefaultValue(null)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public object MinimumValue
		{
			get
			{
				return this.m_MinimumValue;
			}
			set
			{
				if (this.m_MinimumValue != value)
				{
					this.m_MinimumValue = value;
					this.OnChanged(global::System.EventArgs.Empty);
				}
			}
		}

		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x0600214D RID: 8525 RVA: 0x000768F8 File Offset: 0x00074AF8
		// (set) Token: 0x0600214E RID: 8526 RVA: 0x00076900 File Offset: 0x00074B00
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.DefaultValue(null)]
		public object MaximumValue
		{
			get
			{
				return this.m_MaximumValue;
			}
			set
			{
				if (this.m_MaximumValue != value)
				{
					this.m_MaximumValue = value;
					this.OnChanged(global::System.EventArgs.Empty);
				}
			}
		}

		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x0600214F RID: 8527 RVA: 0x00076920 File Offset: 0x00074B20
		// (set) Token: 0x06002150 RID: 8528 RVA: 0x00076928 File Offset: 0x00074B28
		[global::System.ComponentModel.DefaultValue(null)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Type ValueType
		{
			get
			{
				return this.m_ValueType;
			}
			set
			{
				if (this.m_ValueType != value)
				{
					this.m_ValueType = value;
					this.OnLoadingValueType();
					this.OnChanged(global::System.EventArgs.Empty);
				}
			}
		}

		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x06002151 RID: 8529 RVA: 0x00076950 File Offset: 0x00074B50
		// (set) Token: 0x06002152 RID: 8530 RVA: 0x00076970 File Offset: 0x00074B70
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.DefaultValue("")]
		public string ValueTypeName
		{
			get
			{
				if (this.ValueType == null)
				{
					return string.Empty;
				}
				return this.ValueType.AssemblyQualifiedName;
			}
			set
			{
				if (value == null || value.Trim().Length == 0)
				{
					this.ValueType = null;
					return;
				}
				this.ValueType = global::System.Type.GetType(value, true, true);
			}
		}

		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x06002153 RID: 8531 RVA: 0x000769A0 File Offset: 0x00074BA0
		// (set) Token: 0x06002154 RID: 8532 RVA: 0x000769A8 File Offset: 0x00074BA8
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.DefaultValue(null)]
		public object DefaultValue
		{
			get
			{
				return this.m_DefaultValue;
			}
			set
			{
				if (this.m_DefaultValue != value)
				{
					this.m_DefaultValue = value;
					this.OnChanged(global::System.EventArgs.Empty);
				}
			}
		}

		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x06002155 RID: 8533 RVA: 0x000769C8 File Offset: 0x00074BC8
		// (set) Token: 0x06002156 RID: 8534 RVA: 0x000769D0 File Offset: 0x00074BD0
		[global::System.ComponentModel.DefaultValue(null)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::System.Collections.ICollection StandardValues
		{
			get
			{
				return this.m_StandardValues;
			}
			set
			{
				if (this.m_StandardValues != value)
				{
					this.m_StandardValues = value;
					this.OnChanged(global::System.EventArgs.Empty);
				}
			}
		}

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x06002157 RID: 8535 RVA: 0x000769F0 File Offset: 0x00074BF0
		// (set) Token: 0x06002158 RID: 8536 RVA: 0x000769F8 File Offset: 0x00074BF8
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool StandardValuesExclusive
		{
			get
			{
				return this.m_bStandardValuesExclusive;
			}
			set
			{
				if (this.m_bStandardValuesExclusive != value)
				{
					this.m_bStandardValuesExclusive = value;
					this.OnChanged(global::System.EventArgs.Empty);
				}
			}
		}

		// Token: 0x06002159 RID: 8537 RVA: 0x00076A18 File Offset: 0x00074C18
		public virtual bool IsInStandardValues(object p_Value)
		{
			if (this.m_StandardValues == null)
			{
				return false;
			}
			foreach (object obj in this.m_StandardValues)
			{
				if ((obj == null && p_Value == null) || (obj != null && obj.Equals(p_Value)))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600215A RID: 8538 RVA: 0x00076AA4 File Offset: 0x00074CA4
		public virtual object StandardValueAtIndex(int p_Index)
		{
			if (this.m_StandardValues == null)
			{
				throw new global::DevAge.DevAgeApplicationException("StandardValues is null");
			}
			global::System.Collections.IList list = this.m_StandardValues as global::System.Collections.IList;
			if (list != null)
			{
				return list[p_Index];
			}
			int num = 0;
			foreach (object result in this.m_StandardValues)
			{
				if (num == p_Index)
				{
					return result;
				}
				num++;
			}
			throw new global::DevAge.DevAgeApplicationException("Invalid Index");
		}

		// Token: 0x0600215B RID: 8539 RVA: 0x00076B50 File Offset: 0x00074D50
		public virtual int StandardValuesIndexOf(object p_StandardValue)
		{
			if (this.m_StandardValues == null)
			{
				throw new global::DevAge.DevAgeApplicationException("StandardValues is null");
			}
			global::System.Collections.IList list = this.m_StandardValues as global::System.Collections.IList;
			if (list != null)
			{
				return list.IndexOf(p_StandardValue);
			}
			int num = 0;
			foreach (object obj in this.m_StandardValues)
			{
				if (obj == null && p_StandardValue == null)
				{
					return num;
				}
				if (obj != null && obj.Equals(p_StandardValue))
				{
					return num;
				}
				num++;
			}
			return -1;
		}

		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x0600215C RID: 8540 RVA: 0x00076C14 File Offset: 0x00074E14
		// (set) Token: 0x0600215D RID: 8541 RVA: 0x00076C1C File Offset: 0x00074E1C
		[global::System.ComponentModel.DefaultValue(null)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::System.Globalization.CultureInfo CultureInfo
		{
			get
			{
				return this.m_CultureInfo;
			}
			set
			{
				if (this.m_CultureInfo != value)
				{
					this.m_CultureInfo = value;
					this.OnChanged(global::System.EventArgs.Empty);
				}
			}
		}

		// Token: 0x0600215E RID: 8542 RVA: 0x00076C3C File Offset: 0x00074E3C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600215F RID: 8543 RVA: 0x00076C48 File Offset: 0x00074E48
		protected virtual void OnChanged(global::System.EventArgs e)
		{
			if (this.mChanged != null)
			{
				this.mChanged(this, e);
			}
		}

		// Token: 0x14000097 RID: 151
		// (add) Token: 0x06002160 RID: 8544 RVA: 0x00076C64 File Offset: 0x00074E64
		// (remove) Token: 0x06002161 RID: 8545 RVA: 0x00076C80 File Offset: 0x00074E80
		public event global::System.EventHandler Changed
		{
			add
			{
				this.mChanged = (global::System.EventHandler)global::System.Delegate.Combine(this.mChanged, value);
			}
			remove
			{
				this.mChanged = (global::System.EventHandler)global::System.Delegate.Remove(this.mChanged, value);
			}
		}

		// Token: 0x04000C28 RID: 3112
		private bool m_bAllowNull;

		// Token: 0x04000C29 RID: 3113
		private string m_sNullString;

		// Token: 0x04000C2A RID: 3114
		private string m_sNullDisplayString;

		// Token: 0x04000C2B RID: 3115
		private bool m_bAllowStringConversion = true;

		// Token: 0x04000C2C RID: 3116
		private global::DevAge.ComponentModel.ConvertingObjectEventHandler m_ConvertingObjectToValue;

		// Token: 0x04000C2D RID: 3117
		private global::DevAge.ComponentModel.ConvertingObjectEventHandler m_ConvertingValueToObject;

		// Token: 0x04000C2E RID: 3118
		private global::DevAge.ComponentModel.ConvertingObjectEventHandler m_ConvertingValueToDisplayString;

		// Token: 0x04000C2F RID: 3119
		private object m_MinimumValue;

		// Token: 0x04000C30 RID: 3120
		private object m_MaximumValue;

		// Token: 0x04000C31 RID: 3121
		private global::System.Type m_ValueType;

		// Token: 0x04000C32 RID: 3122
		private object m_DefaultValue;

		// Token: 0x04000C33 RID: 3123
		private global::System.Collections.ICollection m_StandardValues;

		// Token: 0x04000C34 RID: 3124
		private bool m_bStandardValuesExclusive;

		// Token: 0x04000C35 RID: 3125
		private global::System.Globalization.CultureInfo m_CultureInfo;

		// Token: 0x04000C36 RID: 3126
		private global::System.EventHandler mChanged;
	}
}
