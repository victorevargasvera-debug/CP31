using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	// Token: 0x02000025 RID: 37
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	internal struct JsonPosition
	{
		// Token: 0x060000AC RID: 172 RVA: 0x000030A2 File Offset: 0x000012A2
		public JsonPosition(global::Newtonsoft.Json.JsonContainerType type)
		{
			this.Type = type;
			this.HasIndex = global::Newtonsoft.Json.JsonPosition.TypeHasIndex(type);
			this.Position = -1;
			this.PropertyName = null;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000030C8 File Offset: 0x000012C8
		internal int CalculateLength()
		{
			global::Newtonsoft.Json.JsonContainerType type = this.Type;
			if (type == global::Newtonsoft.Json.JsonContainerType.Object)
			{
				return this.PropertyName.Length + 5;
			}
			if (type - global::Newtonsoft.Json.JsonContainerType.Array > 1)
			{
				throw new global::System.ArgumentOutOfRangeException("Type");
			}
			return global::Newtonsoft.Json.Utilities.MathUtils.IntLength((ulong)((long)this.Position)) + 2;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00003110 File Offset: 0x00001310
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		internal void WriteTo([global::System.Runtime.CompilerServices.Nullable(1)] global::System.Text.StringBuilder sb, ref global::System.IO.StringWriter writer, ref char[] buffer)
		{
			global::Newtonsoft.Json.JsonContainerType type = this.Type;
			if (type != global::Newtonsoft.Json.JsonContainerType.Object)
			{
				if (type - global::Newtonsoft.Json.JsonContainerType.Array > 1)
				{
					return;
				}
				sb.Append('[');
				sb.Append(this.Position);
				sb.Append(']');
				return;
			}
			else
			{
				string propertyName = this.PropertyName;
				if (propertyName.IndexOfAny(global::Newtonsoft.Json.JsonPosition.SpecialCharacters) != -1)
				{
					sb.Append("['");
					if (writer == null)
					{
						writer = new global::System.IO.StringWriter(sb);
					}
					global::Newtonsoft.Json.Utilities.JavaScriptUtils.WriteEscapedJavaScriptString(writer, propertyName, '\'', false, global::Newtonsoft.Json.Utilities.JavaScriptUtils.SingleQuoteCharEscapeFlags, global::Newtonsoft.Json.StringEscapeHandling.Default, null, ref buffer);
					sb.Append("']");
					return;
				}
				if (sb.Length > 0)
				{
					sb.Append('.');
				}
				sb.Append(propertyName);
				return;
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000031B6 File Offset: 0x000013B6
		internal static bool TypeHasIndex(global::Newtonsoft.Json.JsonContainerType type)
		{
			return type == global::Newtonsoft.Json.JsonContainerType.Array || type == global::Newtonsoft.Json.JsonContainerType.Constructor;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x000031C4 File Offset: 0x000013C4
		internal static string BuildPath(global::System.Collections.Generic.List<global::Newtonsoft.Json.JsonPosition> positions, global::Newtonsoft.Json.JsonPosition? currentPosition)
		{
			int num = 0;
			if (positions != null)
			{
				for (int i = 0; i < positions.Count; i++)
				{
					num += positions[i].CalculateLength();
				}
			}
			if (currentPosition != null)
			{
				num += currentPosition.GetValueOrDefault().CalculateLength();
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(num);
			global::System.IO.StringWriter stringWriter = null;
			char[] array = null;
			if (positions != null)
			{
				foreach (global::Newtonsoft.Json.JsonPosition jsonPosition in positions)
				{
					jsonPosition.WriteTo(stringBuilder, ref stringWriter, ref array);
				}
			}
			if (currentPosition != null)
			{
				currentPosition.GetValueOrDefault().WriteTo(stringBuilder, ref stringWriter, ref array);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00003298 File Offset: 0x00001498
		internal static string FormatMessage([global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.IJsonLineInfo lineInfo, string path, string message)
		{
			if (!message.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.Ordinal))
			{
				message = message.Trim();
				if (!message.EndsWith('.'))
				{
					message += ".";
				}
				message += " ";
			}
			message += "Path '{0}'".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, path);
			if (lineInfo != null && lineInfo.HasLineInfo())
			{
				message += ", line {0}, position {1}".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, lineInfo.LineNumber, lineInfo.LinePosition);
			}
			message += ".";
			return message;
		}

		// Token: 0x04000049 RID: 73
		private static readonly char[] SpecialCharacters = new char[]
		{
			'.',
			' ',
			'\'',
			'/',
			'"',
			'[',
			']',
			'(',
			')',
			'\t',
			'\n',
			'\r',
			'\f',
			'\b',
			'\\',
			'\u0085',
			'\u2028',
			'\u2029'
		};

		// Token: 0x0400004A RID: 74
		internal global::Newtonsoft.Json.JsonContainerType Type;

		// Token: 0x0400004B RID: 75
		internal int Position;

		// Token: 0x0400004C RID: 76
		[global::System.Runtime.CompilerServices.Nullable(2)]
		internal string PropertyName;

		// Token: 0x0400004D RID: 77
		internal bool HasIndex;
	}
}
