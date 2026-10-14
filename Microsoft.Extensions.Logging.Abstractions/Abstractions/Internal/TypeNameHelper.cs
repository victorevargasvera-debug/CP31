using System;
using System.Collections.Generic;
using System.Reflection;

namespace Microsoft.Extensions.Logging.Abstractions.Internal
{
	// Token: 0x02000012 RID: 18
	public class TypeNameHelper
	{
		// Token: 0x06000057 RID: 87 RVA: 0x00002B58 File Offset: 0x00000D58
		public static string GetTypeDisplayName(global::System.Type type)
		{
			if (type.GetTypeInfo().IsGenericType)
			{
				string[] array = type.GetGenericTypeDefinition().FullName.Split(new char[]
				{
					'+'
				});
				for (int i = 0; i < array.Length; i++)
				{
					string text = array[i];
					int num = text.IndexOf('`');
					if (num >= 0)
					{
						text = text.Substring(0, num);
					}
					array[i] = text;
				}
				return string.Join(".", array);
			}
			if (global::Microsoft.Extensions.Logging.Abstractions.Internal.TypeNameHelper._builtInTypeNames.ContainsKey(type))
			{
				return global::Microsoft.Extensions.Logging.Abstractions.Internal.TypeNameHelper._builtInTypeNames[type];
			}
			string text2 = type.FullName;
			if (type.IsNested)
			{
				text2 = text2.Replace('+', '.');
			}
			return text2;
		}

		// Token: 0x0400001B RID: 27
		private static readonly global::System.Collections.Generic.Dictionary<global::System.Type, string> _builtInTypeNames = new global::System.Collections.Generic.Dictionary<global::System.Type, string>
		{
			{
				typeof(bool),
				"bool"
			},
			{
				typeof(byte),
				"byte"
			},
			{
				typeof(char),
				"char"
			},
			{
				typeof(decimal),
				"decimal"
			},
			{
				typeof(double),
				"double"
			},
			{
				typeof(float),
				"float"
			},
			{
				typeof(int),
				"int"
			},
			{
				typeof(long),
				"long"
			},
			{
				typeof(object),
				"object"
			},
			{
				typeof(sbyte),
				"sbyte"
			},
			{
				typeof(short),
				"short"
			},
			{
				typeof(string),
				"string"
			},
			{
				typeof(uint),
				"uint"
			},
			{
				typeof(ulong),
				"ulong"
			},
			{
				typeof(ushort),
				"ushort"
			}
		};
	}
}
