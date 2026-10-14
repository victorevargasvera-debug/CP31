using System;
using System.Collections.Generic;

namespace Gibraltar.Data
{
	// Token: 0x020000E5 RID: 229
	internal static class Field<T>
	{
		// Token: 0x06000975 RID: 2421 RVA: 0x00016B60 File Offset: 0x00014D60
		public static bool SetValue(ref T originalValue, T newValue, global::System.Collections.Generic.IEqualityComparer<T> equalityComparer = null)
		{
			bool flag = false;
			return global::Gibraltar.Data.Field<T>.SetValue(ref originalValue, newValue, ref flag, equalityComparer);
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x00016B80 File Offset: 0x00014D80
		public static bool SetValue(object syncObject, ref T originalValue, T newValue, global::System.Collections.Generic.IEqualityComparer<T> equalityComparer = null)
		{
			bool result;
			lock (syncObject)
			{
				result = global::Gibraltar.Data.Field<T>.SetValue(ref originalValue, newValue, equalityComparer);
			}
			return result;
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x00016BBC File Offset: 0x00014DBC
		public static bool SetValue(object syncObject, ref T originalValue, T newValue, ref bool modificationTracking, global::System.Collections.Generic.IEqualityComparer<T> equalityComparer = null)
		{
			bool result;
			lock (syncObject)
			{
				result = global::Gibraltar.Data.Field<T>.SetValue(ref originalValue, newValue, ref modificationTracking, equalityComparer);
			}
			return result;
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x00016BFC File Offset: 0x00014DFC
		public static bool SetValue(ref T originalValue, T newValue, ref bool modificationTracking, global::System.Collections.Generic.IEqualityComparer<T> equalityComparer = null)
		{
			if (originalValue == newValue)
			{
				return false;
			}
			bool result = false;
			if (originalValue == null)
			{
				originalValue = newValue;
				modificationTracking = true;
				result = true;
			}
			else
			{
				bool flag;
				if (equalityComparer == null)
				{
					flag = originalValue.Equals(newValue);
				}
				else
				{
					flag = equalityComparer.Equals(originalValue, newValue);
				}
				if (!flag)
				{
					originalValue = newValue;
					modificationTracking = true;
					result = true;
				}
			}
			return result;
		}
	}
}
