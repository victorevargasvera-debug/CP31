using System;
using System.Collections;

namespace DevAge.ComponentModel.Validator
{
	// Token: 0x020002C8 RID: 712
	internal class ValueMapping
	{
		// Token: 0x060022D3 RID: 8915 RVA: 0x0007A6C4 File Offset: 0x000788C4
		public ValueMapping()
		{
		}

		// Token: 0x060022D4 RID: 8916 RVA: 0x0007A6E4 File Offset: 0x000788E4
		public ValueMapping(global::DevAge.ComponentModel.Validator.IValidator validator, global::System.Collections.IList valueList, global::System.Collections.IList displayStringList, global::System.Collections.IList specialList, global::System.Type specialType)
		{
			this.ValueList = valueList;
			this.DisplayStringList = displayStringList;
			this.SpecialList = specialList;
			if (validator != null)
			{
				this.BindValidator(validator);
			}
		}

		// Token: 0x060022D5 RID: 8917 RVA: 0x0007A738 File Offset: 0x00078938
		public void BindValidator(global::DevAge.ComponentModel.Validator.IValidator p_Validator)
		{
			p_Validator.ConvertingValueToDisplayString += this.p_Validator_ConvertingValueToDisplayString;
			p_Validator.ConvertingObjectToValue += this.p_Validator_ConvertingObjectToValue;
			p_Validator.ConvertingValueToObject += this.p_Validator_ConvertingValueToObject;
		}

		// Token: 0x060022D6 RID: 8918 RVA: 0x0007A770 File Offset: 0x00078970
		public void UnBindValidator(global::DevAge.ComponentModel.Validator.IValidator p_Validator)
		{
			p_Validator.ConvertingValueToDisplayString -= this.p_Validator_ConvertingValueToDisplayString;
			p_Validator.ConvertingObjectToValue -= this.p_Validator_ConvertingObjectToValue;
			p_Validator.ConvertingValueToObject -= this.p_Validator_ConvertingValueToObject;
		}

		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x060022D7 RID: 8919 RVA: 0x0007A7A8 File Offset: 0x000789A8
		// (set) Token: 0x060022D8 RID: 8920 RVA: 0x0007A7B0 File Offset: 0x000789B0
		public global::System.Collections.IList ValueList
		{
			get
			{
				return this.m_ValueList;
			}
			set
			{
				this.m_ValueList = value;
			}
		}

		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x060022D9 RID: 8921 RVA: 0x0007A7BC File Offset: 0x000789BC
		// (set) Token: 0x060022DA RID: 8922 RVA: 0x0007A7C4 File Offset: 0x000789C4
		public global::System.Collections.IList SpecialList
		{
			get
			{
				return this.mSpecialList;
			}
			set
			{
				this.mSpecialList = value;
			}
		}

		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x060022DB RID: 8923 RVA: 0x0007A7D0 File Offset: 0x000789D0
		// (set) Token: 0x060022DC RID: 8924 RVA: 0x0007A7D8 File Offset: 0x000789D8
		public global::System.Type SpecialType
		{
			get
			{
				return this.mSpecialType;
			}
			set
			{
				this.mSpecialType = value;
			}
		}

		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x060022DD RID: 8925 RVA: 0x0007A7E4 File Offset: 0x000789E4
		// (set) Token: 0x060022DE RID: 8926 RVA: 0x0007A7EC File Offset: 0x000789EC
		public global::System.Collections.IList DisplayStringList
		{
			get
			{
				return this.m_DisplayStringList;
			}
			set
			{
				this.m_DisplayStringList = value;
			}
		}

		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x060022DF RID: 8927 RVA: 0x0007A7F8 File Offset: 0x000789F8
		// (set) Token: 0x060022E0 RID: 8928 RVA: 0x0007A800 File Offset: 0x00078A00
		public bool ThrowErrorIfNotFound
		{
			get
			{
				return this.m_bThrowErrorIfNotFound;
			}
			set
			{
				this.m_bThrowErrorIfNotFound = value;
			}
		}

		// Token: 0x060022E1 RID: 8929 RVA: 0x0007A80C File Offset: 0x00078A0C
		private void p_Validator_ConvertingValueToDisplayString(object sender, global::DevAge.ComponentModel.ConvertingObjectEventArgs e)
		{
			if (this.m_DisplayStringList != null)
			{
				if (this.m_ValueList == null)
				{
					throw new global::System.ApplicationException("ValueList cannot be null");
				}
				int num = this.m_ValueList.IndexOf(e.Value);
				if (num >= 0)
				{
					e.Value = this.m_DisplayStringList[num];
					e.ConvertingStatus = global::DevAge.ComponentModel.ConvertingStatus.Completed;
					return;
				}
				if (this.m_bThrowErrorIfNotFound)
				{
					e.ConvertingStatus = global::DevAge.ComponentModel.ConvertingStatus.Error;
				}
			}
		}

		// Token: 0x060022E2 RID: 8930 RVA: 0x0007A884 File Offset: 0x00078A84
		private void p_Validator_ConvertingObjectToValue(object sender, global::DevAge.ComponentModel.ConvertingObjectEventArgs e)
		{
			if (this.mSpecialList != null && e.Value != null && e.Value.GetType() == this.SpecialType)
			{
				if (this.m_ValueList == null)
				{
					throw new global::System.ApplicationException("ValueList cannot be null");
				}
				int num = this.m_ValueList.IndexOf(e.Value);
				if (num >= 0)
				{
					e.Value = this.m_ValueList[num];
					e.ConvertingStatus = global::DevAge.ComponentModel.ConvertingStatus.Completed;
					return;
				}
				num = this.mSpecialList.IndexOf(e.Value);
				if (num >= 0)
				{
					e.Value = this.m_ValueList[num];
					e.ConvertingStatus = global::DevAge.ComponentModel.ConvertingStatus.Completed;
					return;
				}
				if (this.m_bThrowErrorIfNotFound)
				{
					e.ConvertingStatus = global::DevAge.ComponentModel.ConvertingStatus.Error;
				}
			}
		}

		// Token: 0x060022E3 RID: 8931 RVA: 0x0007A950 File Offset: 0x00078B50
		private void p_Validator_ConvertingValueToObject(object sender, global::DevAge.ComponentModel.ConvertingObjectEventArgs e)
		{
			if (this.mSpecialList != null && e.DestinationType == this.SpecialType)
			{
				if (this.m_ValueList == null)
				{
					throw new global::System.ApplicationException("ValueList cannot be null");
				}
				int num = this.m_ValueList.IndexOf(e.Value);
				if (num >= 0)
				{
					e.Value = this.mSpecialList[num];
					e.ConvertingStatus = global::DevAge.ComponentModel.ConvertingStatus.Completed;
					return;
				}
				if (this.m_bThrowErrorIfNotFound)
				{
					e.ConvertingStatus = global::DevAge.ComponentModel.ConvertingStatus.Error;
				}
			}
		}

		// Token: 0x04000C7A RID: 3194
		private global::System.Collections.IList m_ValueList;

		// Token: 0x04000C7B RID: 3195
		private global::System.Type mSpecialType = typeof(string);

		// Token: 0x04000C7C RID: 3196
		private global::System.Collections.IList mSpecialList;

		// Token: 0x04000C7D RID: 3197
		private global::System.Collections.IList m_DisplayStringList;

		// Token: 0x04000C7E RID: 3198
		private bool m_bThrowErrorIfNotFound = true;
	}
}
