using System;
using System.Windows.Media;

namespace Infragistics
{
	// Token: 0x0200009D RID: 157
	internal class TypeResolverUtilities
	{
		// Token: 0x060005FD RID: 1533 RVA: 0x00016BC4 File Offset: 0x00014DC4
		internal static global::System.Type GetKnownType(string value)
		{
			value.ToLowerInvariant();
			string key;
			switch (key = value.ToLowerInvariant())
			{
			case "string":
				return typeof(string);
			case "bool":
			case "boolean":
				return typeof(bool);
			case "color":
				return typeof(global::System.Windows.Media.Color);
			case "datetime":
				return typeof(global::System.DateTime);
			case "decimal":
				return typeof(decimal);
			case "double":
				return typeof(double);
			case "float":
			case "single":
				return typeof(float);
			case "int16":
			case "short":
				return typeof(short);
			case "int":
			case "int32":
				return typeof(int);
			case "int64":
			case "long":
				return typeof(long);
			case "uint16":
			case "ushort":
				return typeof(ushort);
			case "uint":
			case "uint32":
				return typeof(uint);
			case "uint64":
			case "ulong":
				return typeof(ulong);
			case "byte":
				return typeof(byte);
			case "sbyte":
				return typeof(sbyte);
			case "char":
				return typeof(char);
			case "bool?":
			case "boolean?":
			case "nullable<bool>":
			case "nullable<boolean>":
				return typeof(bool?);
			case "color?":
			case "nullable<color>":
				return typeof(global::System.Windows.Media.Color?);
			case "datetime?":
			case "nullable<datetime>":
				return typeof(global::System.DateTime?);
			case "decimal?":
			case "nullable<decimal>":
				return typeof(decimal?);
			case "double?":
			case "nullable<double>":
				return typeof(double?);
			case "float?":
			case "single?":
			case "nullable<float>":
			case "nullable<single>":
				return typeof(float?);
			case "int16?":
			case "nullable<int16>":
			case "short?":
			case "nullable<short>":
				return typeof(short?);
			case "int?":
			case "int32?":
			case "nullable<int>":
			case "nullable<int32>":
				return typeof(int?);
			case "int64?":
			case "nullable<int64>":
			case "long?":
			case "nullable<long>":
				return typeof(long?);
			case "uint16?":
			case "nullable<uint16>":
			case "ushort?":
			case "nullable<ushort>":
				return typeof(ushort?);
			case "uint?":
			case "uint32?":
			case "nullable<uint>":
			case "nullable<uint32>":
				return typeof(uint?);
			case "uint64?":
			case "nullable<uint64>":
			case "ulong?":
			case "nullable<ulong>":
				return typeof(ulong?);
			case "byte?":
			case "nullable<byte>":
				return typeof(byte?);
			case "sbyte?":
			case "nullable<sbyte>":
				return typeof(sbyte?);
			case "char?":
			case "nullable<char>":
				return typeof(char?);
			}
			return null;
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00017211 File Offset: 0x00015411
		internal static string GetString(string name)
		{
			return global::Infragistics.TypeResolverUtilities.GetString(name, null);
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x0001721A File Offset: 0x0001541A
		internal static string GetString(string name, params object[] args)
		{
			return global::SR.GetString(name, args);
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x00017224 File Offset: 0x00015424
		internal static global::System.Type ResolveType(object owner, global::System.Type explicitType, string typeName, global::System.Type fallbackType, string stringTypePropertyName)
		{
			global::Infragistics.CoreUtilities.ValidateNotEmpty(stringTypePropertyName, "stringTypePropertyName");
			if (explicitType != null)
			{
				return explicitType;
			}
			global::System.Type type = null;
			if (!string.IsNullOrWhiteSpace(typeName))
			{
				type = global::Infragistics.TypeResolverUtilities.GetKnownType(typeName);
				if (type == null)
				{
					type = global::System.Type.GetType(typeName);
					if (type == null && global::Infragistics.CoreUtilities.IsDebuggerLogging())
					{
						global::Infragistics.CoreUtilities.DebuggerLog(40, "Global", global::Infragistics.TypeResolverUtilities.GetString("UnknownTypeName", new object[]
						{
							typeName,
							owner,
							stringTypePropertyName
						}) + global::System.Environment.NewLine);
					}
				}
			}
			return type ?? fallbackType;
		}
	}
}
