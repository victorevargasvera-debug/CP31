using System;
using DevAge.ComponentModel.Validator;

namespace DevAge.Text.FixedLength
{
	// Token: 0x020002B0 RID: 688
	internal class Field : global::DevAge.Text.FixedLength.IField
	{
		// Token: 0x06002218 RID: 8728 RVA: 0x00078A78 File Offset: 0x00076C78
		public Field(int index, string name, int length, global::System.Type type) : this(index, name, length, new global::DevAge.ComponentModel.Validator.ValidatorTypeConverter(type))
		{
		}

		// Token: 0x06002219 RID: 8729 RVA: 0x00078A8C File Offset: 0x00076C8C
		public Field(int index, string name, int length, global::DevAge.ComponentModel.Validator.IValidator validator)
		{
			this.mIndex = index;
			this.mName = name;
			this.Length = length;
			this.Validator = validator;
		}

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x0600221A RID: 8730 RVA: 0x00078AB8 File Offset: 0x00076CB8
		public int Index
		{
			get
			{
				return this.mIndex;
			}
		}

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x0600221B RID: 8731 RVA: 0x00078AC0 File Offset: 0x00076CC0
		public string Name
		{
			get
			{
				return this.mName;
			}
		}

		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x0600221C RID: 8732 RVA: 0x00078AC8 File Offset: 0x00076CC8
		// (set) Token: 0x0600221D RID: 8733 RVA: 0x00078AD0 File Offset: 0x00076CD0
		public int Length
		{
			get
			{
				return this.mLength;
			}
			set
			{
				if (value <= 0)
				{
					throw new global::DevAge.Text.FixedLength.InvalidFieldLengthException(value);
				}
				this.mLength = value;
			}
		}

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x0600221E RID: 8734 RVA: 0x00078AE8 File Offset: 0x00076CE8
		// (set) Token: 0x0600221F RID: 8735 RVA: 0x00078AF0 File Offset: 0x00076CF0
		public bool TrimBeforeParse
		{
			get
			{
				return this.mTrimBeforeParse;
			}
			set
			{
				this.mTrimBeforeParse = value;
			}
		}

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x06002220 RID: 8736 RVA: 0x00078AFC File Offset: 0x00076CFC
		// (set) Token: 0x06002221 RID: 8737 RVA: 0x00078B04 File Offset: 0x00076D04
		public global::DevAge.ComponentModel.Validator.IValidator Validator
		{
			get
			{
				return this.mValidator;
			}
			set
			{
				if (value == null)
				{
					throw new global::System.ArgumentNullException("Validator");
				}
				this.mValidator = value;
			}
		}

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x06002222 RID: 8738 RVA: 0x00078B20 File Offset: 0x00076D20
		public virtual string RegularExpressionPattern
		{
			get
			{
				string format = "(?<{0}>.{{{1}}})";
				return string.Format(format, this.Name, this.Length.ToString());
			}
		}

		// Token: 0x06002223 RID: 8739 RVA: 0x00078B54 File Offset: 0x00076D54
		public virtual string ValueToString(object val)
		{
			string result;
			try
			{
				string text = this.Validator.ValueToString(val);
				if (text == null)
				{
					text = string.Empty;
				}
				if (text.Length > this.Length)
				{
					throw new global::DevAge.Text.FixedLength.ValueNotValidLengthException(text, this.Length);
				}
				if (text.Length < this.Length)
				{
					if (this.Validator.AllowNull)
					{
						text = text.PadRight(this.Length, ' ');
					}
					else if (this.Validator.ValueType == typeof(string))
					{
						text = text.PadRight(this.Length, ' ');
					}
					else if (this.Validator.ValueType == typeof(int))
					{
						text = text.PadLeft(this.Length, '0');
					}
					else
					{
						if (this.Validator.ValueType == typeof(double))
						{
							throw new global::DevAge.Text.FixedLength.ValueNotValidLengthException(text, this.Length);
						}
						if (this.Validator.ValueType == typeof(decimal))
						{
							throw new global::DevAge.Text.FixedLength.ValueNotValidLengthException(text, this.Length);
						}
						throw new global::DevAge.Text.FixedLength.ValueNotSupportedException(text, this.Validator.ValueType);
					}
				}
				result = text;
			}
			catch (global::System.Exception innerException)
			{
				throw new global::DevAge.Text.FixedLength.FieldStringConvertException(this.Name, val, innerException);
			}
			return result;
		}

		// Token: 0x06002224 RID: 8740 RVA: 0x00078CBC File Offset: 0x00076EBC
		public virtual object StringToValue(string str)
		{
			object result;
			try
			{
				if (this.TrimBeforeParse && str != null)
				{
					str = str.Trim();
				}
				result = this.Validator.StringToValue(str);
			}
			catch (global::System.Exception innerException)
			{
				throw new global::DevAge.Text.FixedLength.FieldParseException(this.Name, str, innerException);
			}
			return result;
		}

		// Token: 0x04000C5C RID: 3164
		private int mIndex;

		// Token: 0x04000C5D RID: 3165
		private string mName;

		// Token: 0x04000C5E RID: 3166
		private int mLength;

		// Token: 0x04000C5F RID: 3167
		private bool mTrimBeforeParse = true;

		// Token: 0x04000C60 RID: 3168
		private global::DevAge.ComponentModel.Validator.IValidator mValidator;
	}
}
