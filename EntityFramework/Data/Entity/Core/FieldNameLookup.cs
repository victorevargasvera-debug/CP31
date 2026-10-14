using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Utilities;
using System.Globalization;

namespace System.Data.Entity.Core
{
	// Token: 0x020002CC RID: 716
	internal sealed class FieldNameLookup
	{
		// Token: 0x060022A8 RID: 8872 RVA: 0x00060ED0 File Offset: 0x0005F0D0
		public FieldNameLookup(global::System.Collections.ObjectModel.ReadOnlyCollection<string> columnNames)
		{
			int count = columnNames.Count;
			this._fieldNames = new string[count];
			for (int i = 0; i < count; i++)
			{
				this._fieldNames[i] = columnNames[i];
			}
			this.GenerateLookup();
		}

		// Token: 0x060022A9 RID: 8873 RVA: 0x00060F24 File Offset: 0x0005F124
		public FieldNameLookup(global::System.Data.IDataRecord reader)
		{
			int fieldCount = reader.FieldCount;
			this._fieldNames = new string[fieldCount];
			for (int i = 0; i < fieldCount; i++)
			{
				this._fieldNames[i] = reader.GetName(i);
			}
			this.GenerateLookup();
		}

		// Token: 0x060022AA RID: 8874 RVA: 0x00060F76 File Offset: 0x0005F176
		public int GetOrdinal(string fieldName)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(fieldName, "fieldName");
			int num = this.IndexOf(fieldName);
			if (num == -1)
			{
				throw new global::System.IndexOutOfRangeException(fieldName);
			}
			return num;
		}

		// Token: 0x060022AB RID: 8875 RVA: 0x00060F98 File Offset: 0x0005F198
		private int IndexOf(string fieldName)
		{
			int num;
			if (!this._fieldNameLookup.TryGetValue(fieldName, out num))
			{
				num = this.LinearIndexOf(fieldName, global::System.Globalization.CompareOptions.IgnoreCase);
				if (num == -1)
				{
					num = this.LinearIndexOf(fieldName, global::System.Globalization.CompareOptions.IgnoreCase | global::System.Globalization.CompareOptions.IgnoreKanaType | global::System.Globalization.CompareOptions.IgnoreWidth);
				}
			}
			return num;
		}

		// Token: 0x060022AC RID: 8876 RVA: 0x00060FD0 File Offset: 0x0005F1D0
		private int LinearIndexOf(string fieldName, global::System.Globalization.CompareOptions compareOptions)
		{
			for (int i = 0; i < this._fieldNames.Length; i++)
			{
				if (global::System.Globalization.CultureInfo.InvariantCulture.CompareInfo.Compare(fieldName, this._fieldNames[i], compareOptions) == 0)
				{
					this._fieldNameLookup[fieldName] = i;
					return i;
				}
			}
			return -1;
		}

		// Token: 0x060022AD RID: 8877 RVA: 0x0006101C File Offset: 0x0005F21C
		private void GenerateLookup()
		{
			int num = this._fieldNames.Length - 1;
			while (0 <= num)
			{
				this._fieldNameLookup[this._fieldNames[num]] = num;
				num--;
			}
		}

		// Token: 0x04000BF3 RID: 3059
		private readonly global::System.Collections.Generic.Dictionary<string, int> _fieldNameLookup = new global::System.Collections.Generic.Dictionary<string, int>();

		// Token: 0x04000BF4 RID: 3060
		private readonly string[] _fieldNames;
	}
}
