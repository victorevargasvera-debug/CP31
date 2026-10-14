using System;
using System.Collections;
using System.Text;
using NLog.Config;
using NLog.Internal;

namespace NLog.MessageTemplates
{
	// Token: 0x02000085 RID: 133
	internal class ValueFormatter : global::NLog.IValueFormatter
	{
		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060008D2 RID: 2258 RVA: 0x00017577 File Offset: 0x00015777
		// (set) Token: 0x060008D3 RID: 2259 RVA: 0x0001758D File Offset: 0x0001578D
		public static global::NLog.IValueFormatter Instance
		{
			get
			{
				global::NLog.IValueFormatter result;
				if ((result = global::NLog.MessageTemplates.ValueFormatter._instance) == null)
				{
					result = (global::NLog.MessageTemplates.ValueFormatter._instance = new global::NLog.MessageTemplates.ValueFormatter());
				}
				return result;
			}
			set
			{
				global::NLog.MessageTemplates.ValueFormatter._instance = (value ?? new global::NLog.MessageTemplates.ValueFormatter());
			}
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x0001759E File Offset: 0x0001579E
		private ValueFormatter()
		{
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x000175B8 File Offset: 0x000157B8
		public bool FormatValue(object value, string format, global::NLog.MessageTemplates.CaptureType captureType, global::System.IFormatProvider formatProvider, global::System.Text.StringBuilder builder)
		{
			if (captureType == global::NLog.MessageTemplates.CaptureType.Serialize)
			{
				return global::NLog.Config.ConfigurationItemFactory.Default.JsonConverter.SerializeObject(value, builder);
			}
			if (captureType != global::NLog.MessageTemplates.CaptureType.Stringify)
			{
				return this.FormatObject(value, format, formatProvider, builder);
			}
			builder.Append('"');
			global::NLog.MessageTemplates.ValueFormatter.FormatToString(value, null, formatProvider, builder);
			builder.Append('"');
			return true;
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x00017610 File Offset: 0x00015810
		public bool FormatObject(object value, string format, global::System.IFormatProvider formatProvider, global::System.Text.StringBuilder builder)
		{
			if (this.SerializeSimpleObject(value, format, formatProvider, builder))
			{
				return true;
			}
			global::System.Collections.IEnumerable enumerable = value as global::System.Collections.IEnumerable;
			if (enumerable != null)
			{
				return this.SerializeWithoutCyclicLoop(enumerable, format, formatProvider, builder, default(global::NLog.Internal.SingleItemOptimizedHashSet<object>), 0);
			}
			builder.Append(global::System.Convert.ToString(value, formatProvider));
			return true;
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x0001765C File Offset: 0x0001585C
		private bool SerializeSimpleObject(object value, string format, global::System.IFormatProvider formatProvider, global::System.Text.StringBuilder builder)
		{
			string value2;
			if ((value2 = (value as string)) != null)
			{
				bool flag = format != "l";
				if (flag)
				{
					builder.Append('"');
				}
				builder.Append(value2);
				if (flag)
				{
					builder.Append('"');
				}
				return true;
			}
			if (value == null)
			{
				builder.Append("NULL");
				return true;
			}
			global::System.IFormattable formattable;
			if (!string.IsNullOrEmpty(format) && (formattable = (value as global::System.IFormattable)) != null)
			{
				builder.Append(formattable.ToString(format, formatProvider));
				return true;
			}
			global::System.TypeCode typeCode = global::System.Convert.GetTypeCode(value);
			switch (typeCode)
			{
			case global::System.TypeCode.Boolean:
				builder.Append(((bool)value) ? "true" : "false");
				return true;
			case global::System.TypeCode.Char:
			{
				bool flag2 = format != "l";
				if (flag2)
				{
					builder.Append('"');
				}
				builder.Append((char)value);
				if (flag2)
				{
					builder.Append('"');
				}
				return true;
			}
			case global::System.TypeCode.SByte:
			case global::System.TypeCode.Byte:
			case global::System.TypeCode.Int16:
			case global::System.TypeCode.UInt16:
			case global::System.TypeCode.Int32:
			case global::System.TypeCode.UInt32:
			case global::System.TypeCode.Int64:
			case global::System.TypeCode.UInt64:
			{
				global::System.Enum value3;
				if ((value3 = (value as global::System.Enum)) != null)
				{
					this.AppendEnumAsString(builder, value3);
				}
				else
				{
					builder.AppendIntegerAsString(value, typeCode);
				}
				return true;
			}
			}
			return false;
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x0001778C File Offset: 0x0001598C
		private void AppendEnumAsString(global::System.Text.StringBuilder sb, global::System.Enum value)
		{
			string value2;
			if (!this._enumCache.TryGetValue(value, out value2))
			{
				value2 = value.ToString();
				this._enumCache.TryAddValue(value, value2);
			}
			sb.Append(value2);
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x000177C8 File Offset: 0x000159C8
		private bool SerializeWithoutCyclicLoop(global::System.Collections.IEnumerable collection, string format, global::System.IFormatProvider formatProvider, global::System.Text.StringBuilder builder, global::NLog.Internal.SingleItemOptimizedHashSet<object> objectsInPath, int depth)
		{
			if (objectsInPath.Contains(collection))
			{
				return false;
			}
			if (depth > 10)
			{
				return false;
			}
			global::System.Collections.IDictionary dictionary = collection as global::System.Collections.IDictionary;
			if (dictionary != null)
			{
				using (new global::NLog.Internal.SingleItemOptimizedHashSet<object>.SingleItemScopedInsert(dictionary, ref objectsInPath, true))
				{
					return this.SerializeDictionaryObject(dictionary, format, formatProvider, builder, objectsInPath, depth);
				}
			}
			bool result;
			using (new global::NLog.Internal.SingleItemOptimizedHashSet<object>.SingleItemScopedInsert(collection, ref objectsInPath, true))
			{
				result = this.SerializeCollectionObject(collection, format, formatProvider, builder, objectsInPath, depth);
			}
			return result;
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x00017864 File Offset: 0x00015A64
		private bool SerializeDictionaryObject(global::System.Collections.IDictionary dictionary, string format, global::System.IFormatProvider formatProvider, global::System.Text.StringBuilder builder, global::NLog.Internal.SingleItemOptimizedHashSet<object> objectsInPath, int depth)
		{
			bool flag = false;
			foreach (object obj in dictionary)
			{
				global::System.Collections.DictionaryEntry dictionaryEntry = (global::System.Collections.DictionaryEntry)obj;
				if (builder.Length > 524288)
				{
					return false;
				}
				if (flag)
				{
					builder.Append(", ");
				}
				if (dictionaryEntry.Key is string || !(dictionaryEntry.Key is global::System.Collections.IEnumerable))
				{
					this.FormatObject(dictionaryEntry.Key, format, formatProvider, builder);
				}
				else
				{
					this.SerializeWithoutCyclicLoop((global::System.Collections.IEnumerable)dictionaryEntry.Key, format, formatProvider, builder, objectsInPath, depth + 1);
				}
				builder.Append("=");
				if (dictionaryEntry.Value is string || !(dictionaryEntry.Value is global::System.Collections.IEnumerable))
				{
					this.FormatObject(dictionaryEntry.Value, format, formatProvider, builder);
				}
				else
				{
					this.SerializeWithoutCyclicLoop((global::System.Collections.IEnumerable)dictionaryEntry.Value, format, formatProvider, builder, objectsInPath, depth + 1);
				}
				flag = true;
			}
			return true;
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x00017990 File Offset: 0x00015B90
		private bool SerializeCollectionObject(global::System.Collections.IEnumerable collection, string format, global::System.IFormatProvider formatProvider, global::System.Text.StringBuilder builder, global::NLog.Internal.SingleItemOptimizedHashSet<object> objectsInPath, int depth)
		{
			bool flag = false;
			foreach (object obj in collection)
			{
				if (builder.Length > 524288)
				{
					return false;
				}
				if (flag)
				{
					builder.Append(", ");
				}
				if (obj is string || !(obj is global::System.Collections.IEnumerable))
				{
					this.FormatObject(obj, format, formatProvider, builder);
				}
				else
				{
					this.SerializeWithoutCyclicLoop((global::System.Collections.IEnumerable)obj, format, formatProvider, builder, objectsInPath, depth + 1);
				}
				flag = true;
			}
			return true;
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x00017A3C File Offset: 0x00015C3C
		public static void FormatToString(object value, string format, global::System.IFormatProvider formatProvider, global::System.Text.StringBuilder builder)
		{
			string text = value as string;
			if (text != null)
			{
				builder.Append(text);
				return;
			}
			global::System.IFormattable formattable = value as global::System.IFormattable;
			if (formattable != null)
			{
				builder.Append(formattable.ToString(format, formatProvider));
				return;
			}
			builder.Append(global::System.Convert.ToString(value, formatProvider));
		}

		// Token: 0x04000221 RID: 545
		private static global::NLog.IValueFormatter _instance;

		// Token: 0x04000222 RID: 546
		private const int MaxRecursionDepth = 10;

		// Token: 0x04000223 RID: 547
		private const int MaxValueLength = 524288;

		// Token: 0x04000224 RID: 548
		private const string LiteralFormatSymbol = "l";

		// Token: 0x04000225 RID: 549
		private readonly global::NLog.Internal.MruCache<global::System.Enum, string> _enumCache = new global::NLog.Internal.MruCache<global::System.Enum, string>(1500);
	}
}
