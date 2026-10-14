using System;
using System.Reflection;
using System.Text.RegularExpressions;

namespace DevAge.Text.FixedLength
{
	// Token: 0x020002C6 RID: 710
	internal class LineParser
	{
		// Token: 0x060022C3 RID: 8899 RVA: 0x0007A384 File Offset: 0x00078584
		public LineParser()
		{
			this.mFields = new global::DevAge.Text.FixedLength.FieldList();
		}

		// Token: 0x060022C4 RID: 8900 RVA: 0x0007A398 File Offset: 0x00078598
		public LineParser(global::System.Type lineClassType)
		{
			this.mFields = global::DevAge.Text.FixedLength.Utilities.ExtractFieldListFromType(lineClassType);
		}

		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x060022C5 RID: 8901 RVA: 0x0007A3AC File Offset: 0x000785AC
		public global::DevAge.Text.FixedLength.FieldList Fields
		{
			get
			{
				return this.mFields;
			}
		}

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x060022C6 RID: 8902 RVA: 0x0007A3B4 File Offset: 0x000785B4
		// (set) Token: 0x060022C7 RID: 8903 RVA: 0x0007A3BC File Offset: 0x000785BC
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

		// Token: 0x060022C8 RID: 8904 RVA: 0x0007A3C8 File Offset: 0x000785C8
		public void Reset()
		{
			this.mRegEx = null;
			this.mRegExMatch = null;
		}

		// Token: 0x060022C9 RID: 8905 RVA: 0x0007A3D8 File Offset: 0x000785D8
		public void LoadLine(string line)
		{
			if (this.mRegEx == null)
			{
				this.mRegEx = this.CreateLineRegExp();
			}
			this.mRegExMatch = this.mRegEx.Match(line);
		}

		// Token: 0x060022CA RID: 8906 RVA: 0x0007A404 File Offset: 0x00078604
		public object GetValue(string fieldName)
		{
			if (this.mRegExMatch == null)
			{
				throw new global::System.ArgumentNullException("mRegExMatch");
			}
			global::System.Text.RegularExpressions.Group group = this.mRegExMatch.Groups[fieldName];
			if (!group.Success)
			{
				throw new global::DevAge.Text.FixedLength.RegExException(fieldName);
			}
			return this.mFields[fieldName].StringToValue(group.Value);
		}

		// Token: 0x060022CB RID: 8907 RVA: 0x0007A468 File Offset: 0x00078668
		private global::System.Text.RegularExpressions.Regex CreateLineRegExp()
		{
			global::DevAge.Text.FixedLength.IField[] sortedList = this.mFields.GetSortedList();
			string text = "^";
			for (int i = 0; i < sortedList.Length; i++)
			{
				text += sortedList[i].RegularExpressionPattern;
				text += global::DevAge.Text.FixedLength.Utilities.ValidateRegExpSeparator(this.Separator);
			}
			return new global::System.Text.RegularExpressions.Regex(text, global::System.Text.RegularExpressions.RegexOptions.Compiled | global::System.Text.RegularExpressions.RegexOptions.Singleline);
		}

		// Token: 0x060022CC RID: 8908 RVA: 0x0007A4CC File Offset: 0x000786CC
		public object FillLineClass(object schemaClass)
		{
			if (this.mRegExMatch == null)
			{
				throw new global::System.ArgumentNullException("mRegExMatch", "LoadLine not called");
			}
			global::System.Reflection.PropertyInfo[] properties = schemaClass.GetType().GetProperties(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.GetProperty);
			foreach (global::System.Reflection.PropertyInfo propertyInfo in properties)
			{
				object[] customAttributes = propertyInfo.GetCustomAttributes(typeof(global::DevAge.Text.FixedLength.FieldAttribute), true);
				if (customAttributes.Length > 0)
				{
					propertyInfo.SetValue(schemaClass, this.GetValue(propertyInfo.Name), null);
				}
			}
			return schemaClass;
		}

		// Token: 0x04000C76 RID: 3190
		private global::DevAge.Text.FixedLength.FieldList mFields;

		// Token: 0x04000C77 RID: 3191
		private global::System.Text.RegularExpressions.Regex mRegEx;

		// Token: 0x04000C78 RID: 3192
		private char mSeparator;

		// Token: 0x04000C79 RID: 3193
		private global::System.Text.RegularExpressions.Match mRegExMatch;
	}
}
