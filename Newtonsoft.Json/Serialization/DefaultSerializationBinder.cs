using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000077 RID: 119
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public class DefaultSerializationBinder : global::System.Runtime.Serialization.SerializationBinder, global::Newtonsoft.Json.Serialization.ISerializationBinder
	{
		// Token: 0x0600065A RID: 1626 RVA: 0x0001B694 File Offset: 0x00019894
		public DefaultSerializationBinder()
		{
			this._typeCache = new global::Newtonsoft.Json.Utilities.ThreadSafeStore<global::Newtonsoft.Json.Utilities.StructMultiKey<string, string>, global::System.Type>(new global::System.Func<global::Newtonsoft.Json.Utilities.StructMultiKey<string, string>, global::System.Type>(this.GetTypeFromTypeNameKey));
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x0001B6B4 File Offset: 0x000198B4
		private global::System.Type GetTypeFromTypeNameKey([global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			0,
			2,
			1
		})] global::Newtonsoft.Json.Utilities.StructMultiKey<string, string> typeNameKey)
		{
			string value = typeNameKey.Value1;
			string value2 = typeNameKey.Value2;
			if (value == null)
			{
				return global::System.Type.GetType(value2);
			}
			global::System.Reflection.Assembly assembly = global::System.Reflection.Assembly.LoadWithPartialName(value);
			if (assembly == null)
			{
				foreach (global::System.Reflection.Assembly assembly2 in global::System.AppDomain.CurrentDomain.GetAssemblies())
				{
					if (assembly2.FullName == value || assembly2.GetName().Name == value)
					{
						assembly = assembly2;
						break;
					}
				}
			}
			if (assembly == null)
			{
				throw new global::Newtonsoft.Json.JsonSerializationException("Could not load assembly '{0}'.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, value));
			}
			global::System.Type type = assembly.GetType(value2);
			if (type == null)
			{
				if (value2.IndexOf('`') >= 0)
				{
					try
					{
						type = this.GetGenericTypeFromTypeName(value2, assembly);
					}
					catch (global::System.Exception innerException)
					{
						throw new global::Newtonsoft.Json.JsonSerializationException("Could not find type '{0}' in assembly '{1}'.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, value2, assembly.FullName), innerException);
					}
				}
				if (type == null)
				{
					throw new global::Newtonsoft.Json.JsonSerializationException("Could not find type '{0}' in assembly '{1}'.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, value2, assembly.FullName));
				}
			}
			return type;
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x0001B7D8 File Offset: 0x000199D8
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		private global::System.Type GetGenericTypeFromTypeName(string typeName, global::System.Reflection.Assembly assembly)
		{
			global::System.Type result = null;
			int num = typeName.IndexOf('[');
			if (num >= 0)
			{
				string name = typeName.Substring(0, num);
				global::System.Type type = assembly.GetType(name);
				if (type != null)
				{
					global::System.Collections.Generic.List<global::System.Type> list = new global::System.Collections.Generic.List<global::System.Type>();
					int num2 = 0;
					int num3 = 0;
					int num4 = typeName.Length - 1;
					for (int i = num + 1; i < num4; i++)
					{
						char c = typeName[i];
						if (c != '[')
						{
							if (c == ']')
							{
								num2--;
								if (num2 == 0)
								{
									global::Newtonsoft.Json.Utilities.StructMultiKey<string, string> typeNameKey = global::Newtonsoft.Json.Utilities.ReflectionUtils.SplitFullyQualifiedTypeName(typeName.Substring(num3, i - num3));
									list.Add(this.GetTypeByName(typeNameKey));
								}
							}
						}
						else
						{
							if (num2 == 0)
							{
								num3 = i + 1;
							}
							num2++;
						}
					}
					result = type.MakeGenericType(list.ToArray());
				}
			}
			return result;
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x0001B8A4 File Offset: 0x00019AA4
		private global::System.Type GetTypeByName([global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			0,
			2,
			1
		})] global::Newtonsoft.Json.Utilities.StructMultiKey<string, string> typeNameKey)
		{
			return this._typeCache.Get(typeNameKey);
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x0001B8B2 File Offset: 0x00019AB2
		public override global::System.Type BindToType([global::System.Runtime.CompilerServices.Nullable(2)] string assemblyName, string typeName)
		{
			return this.GetTypeByName(new global::Newtonsoft.Json.Utilities.StructMultiKey<string, string>(assemblyName, typeName));
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x0001B8C1 File Offset: 0x00019AC1
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public override void BindToName([global::System.Runtime.CompilerServices.Nullable(1)] global::System.Type serializedType, out string assemblyName, out string typeName)
		{
			assemblyName = serializedType.Assembly.FullName;
			typeName = serializedType.FullName;
		}

		// Token: 0x04000220 RID: 544
		internal static readonly global::Newtonsoft.Json.Serialization.DefaultSerializationBinder Instance = new global::Newtonsoft.Json.Serialization.DefaultSerializationBinder();

		// Token: 0x04000221 RID: 545
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			0,
			2,
			1,
			1
		})]
		private readonly global::Newtonsoft.Json.Utilities.ThreadSafeStore<global::Newtonsoft.Json.Utilities.StructMultiKey<string, string>, global::System.Type> _typeCache;
	}
}
