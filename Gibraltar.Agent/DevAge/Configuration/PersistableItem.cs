using System;
using System.Globalization;
using DevAge.ComponentModel.Validator;

namespace DevAge.Configuration
{
	// Token: 0x02000285 RID: 645
	internal class PersistableItem
	{
		// Token: 0x060020E7 RID: 8423 RVA: 0x00075E44 File Offset: 0x00074044
		public PersistableItem(global::System.Type pType, string pName, object pDefaultValue)
		{
			this.m_Validator = new global::DevAge.ComponentModel.Validator.ValidatorTypeConverter(pType);
			this.m_Validator.CultureInfo = global::System.Globalization.CultureInfo.InvariantCulture;
			this.m_Type = pType;
			this.m_Name = pName;
			this.m_Value = pDefaultValue;
			this.m_DefaultValue = pDefaultValue;
		}

		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x060020E8 RID: 8424 RVA: 0x00075E84 File Offset: 0x00074084
		public global::DevAge.ComponentModel.Validator.IValidator Validator
		{
			get
			{
				return this.m_Validator;
			}
		}

		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x060020E9 RID: 8425 RVA: 0x00075E8C File Offset: 0x0007408C
		public global::System.Type Type
		{
			get
			{
				return this.m_Type;
			}
		}

		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x060020EA RID: 8426 RVA: 0x00075E94 File Offset: 0x00074094
		public string Name
		{
			get
			{
				return this.m_Name;
			}
		}

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x060020EB RID: 8427 RVA: 0x00075E9C File Offset: 0x0007409C
		// (set) Token: 0x060020EC RID: 8428 RVA: 0x00075EA4 File Offset: 0x000740A4
		public object Value
		{
			get
			{
				return this.m_Value;
			}
			set
			{
				this.m_Value = value;
			}
		}

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x060020ED RID: 8429 RVA: 0x00075EB0 File Offset: 0x000740B0
		// (set) Token: 0x060020EE RID: 8430 RVA: 0x00075EB8 File Offset: 0x000740B8
		public object DefaultValue
		{
			get
			{
				return this.m_DefaultValue;
			}
			set
			{
				this.m_DefaultValue = value;
			}
		}

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x060020EF RID: 8431 RVA: 0x00075EC4 File Offset: 0x000740C4
		public bool IsChanged
		{
			get
			{
				return (this.m_Value != null || this.m_DefaultValue != null) && (this.m_Value == null || !this.m_Value.Equals(this.m_DefaultValue));
			}
		}

		// Token: 0x060020F0 RID: 8432 RVA: 0x00075F00 File Offset: 0x00074100
		public void AcceptAsDefault()
		{
			this.m_DefaultValue = this.m_Value;
		}

		// Token: 0x060020F1 RID: 8433 RVA: 0x00075F10 File Offset: 0x00074110
		public void Reset()
		{
			this.m_Value = this.m_DefaultValue;
		}

		// Token: 0x060020F2 RID: 8434 RVA: 0x00075F20 File Offset: 0x00074120
		public override string ToString()
		{
			return "PersistableItem: " + this.Name + "=" + this.Validator.ValueToDisplayString(this.Value);
		}

		// Token: 0x04000C20 RID: 3104
		private global::DevAge.ComponentModel.Validator.IValidator m_Validator;

		// Token: 0x04000C21 RID: 3105
		private global::System.Type m_Type;

		// Token: 0x04000C22 RID: 3106
		private string m_Name;

		// Token: 0x04000C23 RID: 3107
		private object m_Value;

		// Token: 0x04000C24 RID: 3108
		private object m_DefaultValue;
	}
}
