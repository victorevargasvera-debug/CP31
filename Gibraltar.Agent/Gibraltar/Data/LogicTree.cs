using System;

namespace Gibraltar.Data
{
	// Token: 0x020000ED RID: 237
	internal abstract class LogicTree
	{
		// Token: 0x060009CF RID: 2511 RVA: 0x000179B8 File Offset: 0x00015BB8
		public static int CompareReference<T>(T data, T fieldValue) where T : class, global::System.IComparable<T>
		{
			if (fieldValue == null)
			{
				if (data != null)
				{
					return 1;
				}
				return 0;
			}
			else
			{
				if (data == null)
				{
					return -1;
				}
				return -fieldValue.CompareTo(data);
			}
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x000179F0 File Offset: 0x00015BF0
		public static int CompareValue<T>(T data, T fieldValue) where T : struct, global::System.IComparable<T>
		{
			return -fieldValue.CompareTo(data);
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x00017A04 File Offset: 0x00015C04
		public static int CompareVersion(global::System.Version data, global::System.Version fieldValue)
		{
			if (fieldValue == null)
			{
				if (!(data == null))
				{
					return int.MaxValue;
				}
				return 0;
			}
			else
			{
				if (data == null)
				{
					return int.MinValue;
				}
				int num = -fieldValue.Major.CompareTo(data.Major);
				if (num == 0)
				{
					num = -fieldValue.Minor.CompareTo(data.Minor);
					if (num == 0 && fieldValue.Build >= 0)
					{
						num = -fieldValue.Build.CompareTo(data.Build);
						if (num == 0 && fieldValue.Revision >= 0)
						{
							num = -fieldValue.Revision.CompareTo(data.Revision);
						}
					}
				}
				return num;
			}
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x00017ACC File Offset: 0x00015CCC
		public static int CompareVersionBuildOnly(global::System.Version data, global::System.Version fieldValue)
		{
			if (fieldValue == null)
			{
				if (!(data == null))
				{
					return int.MaxValue;
				}
				return 0;
			}
			else
			{
				if (data == null)
				{
					return int.MinValue;
				}
				return -fieldValue.Build.CompareTo(data.Build);
			}
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x00017B24 File Offset: 0x00015D24
		public static int ComparePrefix(string data, string fieldValue)
		{
			if (fieldValue == null)
			{
				if (data != null)
				{
					return 1;
				}
				return 0;
			}
			else
			{
				if (data == null)
				{
					return int.MinValue;
				}
				int length = fieldValue.Length;
				int length2 = data.Length;
				if (length == 0)
				{
					return 0;
				}
				if (length > length2)
				{
					return int.MinValue;
				}
				string strB = data.Substring(0, length);
				return -fieldValue.CompareTo(strB);
			}
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x00017B88 File Offset: 0x00015D88
		public static int CompareSuffix(string data, string fieldValue)
		{
			if (fieldValue == null)
			{
				if (data != null)
				{
					return int.MaxValue;
				}
				return 0;
			}
			else
			{
				if (data == null)
				{
					return int.MinValue;
				}
				int length = fieldValue.Length;
				int num = data.Length - length;
				if (length == 0)
				{
					return 0;
				}
				if (num < 0)
				{
					return int.MinValue;
				}
				string strB = (num == 0) ? data : data.Substring(num);
				return -fieldValue.CompareTo(strB);
			}
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x00017BFC File Offset: 0x00015DFC
		public static int CompareContains(string data, string fieldValue)
		{
			if (fieldValue == null)
			{
				if (data != null)
				{
					return int.MaxValue;
				}
				return 0;
			}
			else
			{
				if (data == null)
				{
					return int.MinValue;
				}
				int length = fieldValue.Length;
				int length2 = data.Length;
				if (length == 0)
				{
					return 0;
				}
				if (length2 < length)
				{
					return int.MinValue;
				}
				if (!data.Contains(fieldValue))
				{
					return int.MinValue;
				}
				return 0;
			}
		}

		// Token: 0x04000261 RID: 609
		public static readonly global::Gibraltar.Data.MatchOperationType[] AllOperations = new global::Gibraltar.Data.MatchOperationType[]
		{
			global::Gibraltar.Data.MatchOperationType.Equals,
			global::Gibraltar.Data.MatchOperationType.NotEquals,
			global::Gibraltar.Data.MatchOperationType.LessThan,
			global::Gibraltar.Data.MatchOperationType.GreaterThan,
			global::Gibraltar.Data.MatchOperationType.LessOrEquals,
			global::Gibraltar.Data.MatchOperationType.GreaterOrEquals,
			global::Gibraltar.Data.MatchOperationType.InRange,
			global::Gibraltar.Data.MatchOperationType.NotInRange,
			global::Gibraltar.Data.MatchOperationType.Between,
			global::Gibraltar.Data.MatchOperationType.NotBetween,
			global::Gibraltar.Data.MatchOperationType.StartsWith,
			global::Gibraltar.Data.MatchOperationType.NotStartsWith,
			global::Gibraltar.Data.MatchOperationType.EndsWith,
			global::Gibraltar.Data.MatchOperationType.NotEndsWith,
			global::Gibraltar.Data.MatchOperationType.Contains,
			global::Gibraltar.Data.MatchOperationType.NotContains,
			global::Gibraltar.Data.MatchOperationType.IncludeList,
			global::Gibraltar.Data.MatchOperationType.ExcludeList
		};
	}
}
