using System;
using System.Diagnostics;
using System.Windows.Media;

namespace Infragistics
{
	// Token: 0x02000007 RID: 7
	internal class TypeResolverUtilities
	{
		// Token: 0x06000018 RID: 24 RVA: 0x0000279C File Offset: 0x0000099C
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

		// Token: 0x06000019 RID: 25 RVA: 0x00002DE9 File Offset: 0x00000FE9
		internal static string GetString(string name)
		{
			return global::Infragistics.TypeResolverUtilities.GetString(name, null);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002DF2 File Offset: 0x00000FF2
		internal static string GetString(string name, params object[] args)
		{
			return global::SR.GetString(name, args);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002DFC File Offset: 0x00000FFC
		internal static global::System.Type ResolveType(object owner, global::System.Type explicitType, string typeName, global::System.Type fallbackType, string unknownTypeResourceId)
		{
			global::Infragistics.CoreUtilities.ValidateNotEmpty(unknownTypeResourceId, "unknownTypeResourceId");
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
					if (type == null && global::System.Diagnostics.Debugger.IsAttached && global::System.Diagnostics.Debugger.IsLogging())
					{
						global::System.Diagnostics.Debugger.Log(40, "Global", global::Infragistics.TypeResolverUtilities.GetString("UnknownTypeName", new object[]
						{
							typeName,
							owner
						}) + global::System.Environment.NewLine);
					}
				}
			}
			return type ?? fallbackType;
		}
	}
}
