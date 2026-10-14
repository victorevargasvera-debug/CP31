using System;
using System.Reflection;
using System.Text;

namespace DevAge.Text.FixedLength
{
	// Token: 0x02000283 RID: 643
	internal class LineWriter
	{
		// Token: 0x060020D2 RID: 8402 RVA: 0x000758DC File Offset: 0x00073ADC
		public LineWriter(global::DevAge.Text.FixedLength.FieldList fields)
		{
			this.mFields = fields;
		}

		// Token: 0x060020D3 RID: 8403 RVA: 0x000758EC File Offset: 0x00073AEC
		public LineWriter(global::System.Type lineClassType)
		{
			this.mFields = global::DevAge.Text.FixedLength.Utilities.ExtractFieldListFromType(lineClassType);
		}

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x060020D4 RID: 8404 RVA: 0x00075900 File Offset: 0x00073B00
		public global::DevAge.Text.FixedLength.FieldList Fields
		{
			get
			{
				return this.mFields;
			}
		}

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x060020D5 RID: 8405 RVA: 0x00075908 File Offset: 0x00073B08
		// (set) Token: 0x060020D6 RID: 8406 RVA: 0x00075910 File Offset: 0x00073B10
		public char Separator
		{
			get
			{
				return this.mSeparator;
			}
			set
			{
				this.mSeparator = value;
			}
		}

		// Token: 0x060020D7 RID: 8407 RVA: 0x0007591C File Offset: 0x00073B1C
		public void Reset()
		{
			this.mLineValues = null;
		}

		// Token: 0x060020D8 RID: 8408 RVA: 0x00075928 File Offset: 0x00073B28
		public void SetValue(string fieldName, object val)
		{
			if (this.mLineValues == null)
			{
				this.mLineValues = new object[this.mFields.Count];
			}
			if (this.mSortedList == null)
			{
				this.mSortedList = this.mFields.GetSortedList();
			}
			this.mLineValues[this.mFields[fieldName].Index] = val;
		}

		// Token: 0x060020D9 RID: 8409 RVA: 0x00075990 File Offset: 0x00073B90
		public string CreateLine()
		{
			if (this.mLineValues == null)
			{
				throw new global::System.ArgumentNullException("mLineValues", "SetValue not called");
			}
			if (this.mSortedList == null)
			{
				this.mSortedList = this.mFields.GetSortedList();
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			for (int i = 0; i < this.mSortedList.Length; i++)
			{
				stringBuilder.Append(this.mSortedList[i].ValueToString(this.mLineValues[i]));
				if (this.Separator != '\0')
				{
					stringBuilder.Append(this.Separator);
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060020DA RID: 8410 RVA: 0x00075A34 File Offset: 0x00073C34
		public string CreateLineFromClass(object schemaClass)
		{
			global::System.Reflection.PropertyInfo[] properties = schemaClass.GetType().GetProperties(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.GetProperty);
			foreach (global::System.Reflection.PropertyInfo propertyInfo in properties)
			{
				object[] customAttributes = propertyInfo.GetCustomAttributes(typeof(global::DevAge.Text.FixedLength.FieldAttribute), true);
				if (customAttributes.Length > 0)
				{
					this.SetValue(propertyInfo.Name, propertyInfo.GetValue(schemaClass, null));
				}
			}
			return this.CreateLine();
		}

		// Token: 0x04000C13 RID: 3091
		private global::DevAge.Text.FixedLength.FieldList mFields;

		// Token: 0x04000C14 RID: 3092
		private global::DevAge.Text.FixedLength.IField[] mSortedList;

		// Token: 0x04000C15 RID: 3093
		private char mSeparator;

		// Token: 0x04000C16 RID: 3094
		private object[] mLineValues;
	}
}
