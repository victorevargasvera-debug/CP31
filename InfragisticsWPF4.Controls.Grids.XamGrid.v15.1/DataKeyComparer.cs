using System;
using System.Collections.Generic;

namespace Infragistics
{
	// Token: 0x0200015A RID: 346
	internal class DataKeyComparer : global::System.Collections.Generic.IEqualityComparer<object>
	{
		// Token: 0x06000B27 RID: 2855 RVA: 0x00029F10 File Offset: 0x00028110
		bool global::System.Collections.Generic.IEqualityComparer<object>.Equals(object x, object y)
		{
			if (x == null && y == null)
			{
				return true;
			}
			if (x == null || y == null)
			{
				return false;
			}
			global::Infragistics.ISupportDataKeys supportDataKeys = x as global::Infragistics.ISupportDataKeys;
			global::Infragistics.ISupportDataKeys supportDataKeys2 = y as global::Infragistics.ISupportDataKeys;
			if (supportDataKeys == null || supportDataKeys2 == null)
			{
				return x.Equals(y);
			}
			object[] dataKeys = supportDataKeys.GetDataKeys();
			object[] dataKeys2 = supportDataKeys2.GetDataKeys();
			if (dataKeys == null && dataKeys2 == null)
			{
				return true;
			}
			if (dataKeys == null || dataKeys2 == null)
			{
				return false;
			}
			if (dataKeys.Length != dataKeys2.Length)
			{
				return false;
			}
			for (int i = 0; i < dataKeys.Length; i++)
			{
				if (dataKeys[i] != dataKeys2[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x00029F90 File Offset: 0x00028190
		int global::System.Collections.Generic.IEqualityComparer<object>.GetHashCode(object obj)
		{
			global::Infragistics.ISupportDataKeys supportDataKeys = obj as global::Infragistics.ISupportDataKeys;
			if (supportDataKeys != null)
			{
				object[] dataKeys = supportDataKeys.GetDataKeys();
				if (dataKeys != null && dataKeys.Length > 0)
				{
					return global::Infragistics.DataKeyComparer.GenerateHashCodeFromDataKey(dataKeys, dataKeys.Length);
				}
			}
			return obj.GetHashCode();
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x00029FC8 File Offset: 0x000281C8
		private static int GenerateHashCodeFromDataKey(object[] keys, int length)
		{
			if (length == 0)
			{
				return 0;
			}
			int num = length - 1;
			return ((keys[num] == null) ? 0 : keys[num].GetHashCode()) ^ global::Infragistics.DataKeyComparer.GenerateHashCodeFromDataKey(keys, num);
		}
	}
}
