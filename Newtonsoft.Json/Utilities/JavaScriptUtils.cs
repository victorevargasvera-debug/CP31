using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200005E RID: 94
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	internal static class JavaScriptUtils
	{
		// Token: 0x0600054C RID: 1356 RVA: 0x00016954 File Offset: 0x00014B54
		static JavaScriptUtils()
		{
			global::System.Collections.Generic.IList<char> list = new global::System.Collections.Generic.List<char>
			{
				'\n',
				'\r',
				'\t',
				'\\',
				'\f',
				'\b'
			};
			for (int i = 0; i < 32; i++)
			{
				list.Add((char)i);
			}
			foreach (char c in list.Union(new char[]
			{
				'\''
			}))
			{
				global::Newtonsoft.Json.Utilities.JavaScriptUtils.SingleQuoteCharEscapeFlags[(int)c] = true;
			}
			foreach (char c2 in list.Union(new char[]
			{
				'"'
			}))
			{
				global::Newtonsoft.Json.Utilities.JavaScriptUtils.DoubleQuoteCharEscapeFlags[(int)c2] = true;
			}
			foreach (char c3 in list.Union(new char[]
			{
				'"',
				'\'',
				'<',
				'>',
				'&'
			}))
			{
				global::Newtonsoft.Json.Utilities.JavaScriptUtils.HtmlCharEscapeFlags[(int)c3] = true;
			}
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00016AC0 File Offset: 0x00014CC0
		public static bool[] GetCharEscapeFlags(global::Newtonsoft.Json.StringEscapeHandling stringEscapeHandling, char quoteChar)
		{
			if (stringEscapeHandling == global::Newtonsoft.Json.StringEscapeHandling.EscapeHtml)
			{
				return global::Newtonsoft.Json.Utilities.JavaScriptUtils.HtmlCharEscapeFlags;
			}
			if (quoteChar == '"')
			{
				return global::Newtonsoft.Json.Utilities.JavaScriptUtils.DoubleQuoteCharEscapeFlags;
			}
			return global::Newtonsoft.Json.Utilities.JavaScriptUtils.SingleQuoteCharEscapeFlags;
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00016ADC File Offset: 0x00014CDC
		public static bool ShouldEscapeJavaScriptString([global::System.Runtime.CompilerServices.Nullable(2)] string s, bool[] charEscapeFlags)
		{
			if (s == null)
			{
				return false;
			}
			foreach (char c in s)
			{
				if ((int)c >= charEscapeFlags.Length || charEscapeFlags[(int)c])
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x00016B18 File Offset: 0x00014D18
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public static void WriteEscapedJavaScriptString([global::System.Runtime.CompilerServices.Nullable(1)] global::System.IO.TextWriter writer, string s, char delimiter, bool appendDelimiters, [global::System.Runtime.CompilerServices.Nullable(1)] bool[] charEscapeFlags, global::Newtonsoft.Json.StringEscapeHandling stringEscapeHandling, global::Newtonsoft.Json.IArrayPool<char> bufferPool, ref char[] writeBuffer)
		{
			if (appendDelimiters)
			{
				writer.Write(delimiter);
			}
			if (!global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty(s))
			{
				int num = global::Newtonsoft.Json.Utilities.JavaScriptUtils.FirstCharToEscape(s, charEscapeFlags, stringEscapeHandling);
				if (num == -1)
				{
					writer.Write(s);
				}
				else
				{
					if (num != 0)
					{
						if (writeBuffer == null || writeBuffer.Length < num)
						{
							writeBuffer = global::Newtonsoft.Json.Utilities.BufferUtils.EnsureBufferSize(bufferPool, num, writeBuffer);
						}
						s.CopyTo(0, writeBuffer, 0, num);
						writer.Write(writeBuffer, 0, num);
					}
					int num2;
					for (int i = num; i < s.Length; i++)
					{
						char c = s[i];
						if ((int)c >= charEscapeFlags.Length || charEscapeFlags[(int)c])
						{
							string text;
							if (c <= '\\')
							{
								switch (c)
								{
								case '\b':
									text = "\\b";
									break;
								case '\t':
									text = "\\t";
									break;
								case '\n':
									text = "\\n";
									break;
								case '\v':
									goto IL_12A;
								case '\f':
									text = "\\f";
									break;
								case '\r':
									text = "\\r";
									break;
								default:
									if (c != '\\')
									{
										goto IL_12A;
									}
									text = "\\\\";
									break;
								}
							}
							else if (c != '\u0085')
							{
								if (c != '\u2028')
								{
									if (c != '\u2029')
									{
										goto IL_12A;
									}
									text = "\\u2029";
								}
								else
								{
									text = "\\u2028";
								}
							}
							else
							{
								text = "\\u0085";
							}
							IL_18C:
							if (text == null)
							{
								goto IL_22E;
							}
							bool flag = string.Equals(text, "!", global::System.StringComparison.Ordinal);
							if (i > num)
							{
								num2 = i - num + (flag ? 6 : 0);
								int num3 = flag ? 6 : 0;
								if (writeBuffer == null || writeBuffer.Length < num2)
								{
									char[] array = global::Newtonsoft.Json.Utilities.BufferUtils.RentBuffer(bufferPool, num2);
									if (flag)
									{
										global::System.Array.Copy(writeBuffer, array, 6);
									}
									global::Newtonsoft.Json.Utilities.BufferUtils.ReturnBuffer(bufferPool, writeBuffer);
									writeBuffer = array;
								}
								s.CopyTo(num, writeBuffer, num3, num2 - num3);
								writer.Write(writeBuffer, num3, num2 - num3);
							}
							num = i + 1;
							if (!flag)
							{
								writer.Write(text);
								goto IL_22E;
							}
							writer.Write(writeBuffer, 0, 6);
							goto IL_22E;
							IL_12A:
							if ((int)c >= charEscapeFlags.Length && stringEscapeHandling != global::Newtonsoft.Json.StringEscapeHandling.EscapeNonAscii)
							{
								text = null;
								goto IL_18C;
							}
							if (c == '\'' && stringEscapeHandling != global::Newtonsoft.Json.StringEscapeHandling.EscapeHtml)
							{
								text = "\\'";
								goto IL_18C;
							}
							if (c == '"' && stringEscapeHandling != global::Newtonsoft.Json.StringEscapeHandling.EscapeHtml)
							{
								text = "\\\"";
								goto IL_18C;
							}
							if (writeBuffer == null || writeBuffer.Length < 6)
							{
								writeBuffer = global::Newtonsoft.Json.Utilities.BufferUtils.EnsureBufferSize(bufferPool, 6, writeBuffer);
							}
							global::Newtonsoft.Json.Utilities.StringUtils.ToCharAsUnicode(c, writeBuffer);
							text = "!";
							goto IL_18C;
						}
						IL_22E:;
					}
					num2 = s.Length - num;
					if (num2 > 0)
					{
						if (writeBuffer == null || writeBuffer.Length < num2)
						{
							writeBuffer = global::Newtonsoft.Json.Utilities.BufferUtils.EnsureBufferSize(bufferPool, num2, writeBuffer);
						}
						s.CopyTo(num, writeBuffer, 0, num2);
						writer.Write(writeBuffer, 0, num2);
					}
				}
			}
			if (appendDelimiters)
			{
				writer.Write(delimiter);
			}
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00016DAC File Offset: 0x00014FAC
		public static string ToEscapedJavaScriptString([global::System.Runtime.CompilerServices.Nullable(2)] string value, char delimiter, bool appendDelimiters, global::Newtonsoft.Json.StringEscapeHandling stringEscapeHandling)
		{
			bool[] charEscapeFlags = global::Newtonsoft.Json.Utilities.JavaScriptUtils.GetCharEscapeFlags(stringEscapeHandling, delimiter);
			string result;
			using (global::System.IO.StringWriter stringWriter = global::Newtonsoft.Json.Utilities.StringUtils.CreateStringWriter((value != null) ? value.Length : 16))
			{
				char[] array = null;
				global::Newtonsoft.Json.Utilities.JavaScriptUtils.WriteEscapedJavaScriptString(stringWriter, value, delimiter, appendDelimiters, charEscapeFlags, stringEscapeHandling, null, ref array);
				result = stringWriter.ToString();
			}
			return result;
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x00016E08 File Offset: 0x00015008
		private static int FirstCharToEscape(string s, bool[] charEscapeFlags, global::Newtonsoft.Json.StringEscapeHandling stringEscapeHandling)
		{
			for (int num = 0; num != s.Length; num++)
			{
				char c = s[num];
				if ((int)c < charEscapeFlags.Length)
				{
					if (charEscapeFlags[(int)c])
					{
						return num;
					}
				}
				else
				{
					if (stringEscapeHandling == global::Newtonsoft.Json.StringEscapeHandling.EscapeNonAscii)
					{
						return num;
					}
					if (c == '\u0085' || c == '\u2028' || c == '\u2029')
					{
						return num;
					}
				}
			}
			return -1;
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00016E5C File Offset: 0x0001505C
		public static global::System.Threading.Tasks.Task WriteEscapedJavaScriptStringAsync(global::System.IO.TextWriter writer, string s, char delimiter, bool appendDelimiters, bool[] charEscapeFlags, global::Newtonsoft.Json.StringEscapeHandling stringEscapeHandling, global::Newtonsoft.Json.JsonTextWriter client, char[] writeBuffer, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			if (appendDelimiters)
			{
				return global::Newtonsoft.Json.Utilities.JavaScriptUtils.WriteEscapedJavaScriptStringWithDelimitersAsync(writer, s, delimiter, charEscapeFlags, stringEscapeHandling, client, writeBuffer, cancellationToken);
			}
			if (global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty(s))
			{
				return cancellationToken.CancelIfRequestedAsync() ?? global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
			}
			return global::Newtonsoft.Json.Utilities.JavaScriptUtils.WriteEscapedJavaScriptStringWithoutDelimitersAsync(writer, s, charEscapeFlags, stringEscapeHandling, client, writeBuffer, cancellationToken);
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00016EBC File Offset: 0x000150BC
		private static global::System.Threading.Tasks.Task WriteEscapedJavaScriptStringWithDelimitersAsync(global::System.IO.TextWriter writer, string s, char delimiter, bool[] charEscapeFlags, global::Newtonsoft.Json.StringEscapeHandling stringEscapeHandling, global::Newtonsoft.Json.JsonTextWriter client, char[] writeBuffer, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Threading.Tasks.Task task = writer.WriteAsync(delimiter, cancellationToken);
			if (!task.IsCompletedSucessfully())
			{
				return global::Newtonsoft.Json.Utilities.JavaScriptUtils.WriteEscapedJavaScriptStringWithDelimitersAsync(task, writer, s, delimiter, charEscapeFlags, stringEscapeHandling, client, writeBuffer, cancellationToken);
			}
			if (!global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty(s))
			{
				task = global::Newtonsoft.Json.Utilities.JavaScriptUtils.WriteEscapedJavaScriptStringWithoutDelimitersAsync(writer, s, charEscapeFlags, stringEscapeHandling, client, writeBuffer, cancellationToken);
				if (task.IsCompletedSucessfully())
				{
					return writer.WriteAsync(delimiter, cancellationToken);
				}
			}
			return global::Newtonsoft.Json.Utilities.JavaScriptUtils.WriteCharAsync(task, writer, delimiter, cancellationToken);
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00016F24 File Offset: 0x00015124
		private static global::System.Threading.Tasks.Task WriteEscapedJavaScriptStringWithDelimitersAsync(global::System.Threading.Tasks.Task task, global::System.IO.TextWriter writer, string s, char delimiter, bool[] charEscapeFlags, global::Newtonsoft.Json.StringEscapeHandling stringEscapeHandling, global::Newtonsoft.Json.JsonTextWriter client, char[] writeBuffer, global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.Utilities.JavaScriptUtils.<WriteEscapedJavaScriptStringWithDelimitersAsync>d__13 <WriteEscapedJavaScriptStringWithDelimitersAsync>d__;
			<WriteEscapedJavaScriptStringWithDelimitersAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<WriteEscapedJavaScriptStringWithDelimitersAsync>d__.task = task;
			<WriteEscapedJavaScriptStringWithDelimitersAsync>d__.writer = writer;
			<WriteEscapedJavaScriptStringWithDelimitersAsync>d__.s = s;
			<WriteEscapedJavaScriptStringWithDelimitersAsync>d__.delimiter = delimiter;
			<WriteEscapedJavaScriptStringWithDelimitersAsync>d__.charEscapeFlags = charEscapeFlags;
			<WriteEscapedJavaScriptStringWithDelimitersAsync>d__.stringEscapeHandling = stringEscapeHandling;
			<WriteEscapedJavaScriptStringWithDelimitersAsync>d__.client = client;
			<WriteEscapedJavaScriptStringWithDelimitersAsync>d__.writeBuffer = writeBuffer;
			<WriteEscapedJavaScriptStringWithDelimitersAsync>d__.cancellationToken = cancellationToken;
			<WriteEscapedJavaScriptStringWithDelimitersAsync>d__.<>1__state = -1;
			<WriteEscapedJavaScriptStringWithDelimitersAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.Utilities.JavaScriptUtils.<WriteEscapedJavaScriptStringWithDelimitersAsync>d__13>(ref <WriteEscapedJavaScriptStringWithDelimitersAsync>d__);
			return <WriteEscapedJavaScriptStringWithDelimitersAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00016FAC File Offset: 0x000151AC
		public static global::System.Threading.Tasks.Task WriteCharAsync(global::System.Threading.Tasks.Task task, global::System.IO.TextWriter writer, char c, global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.Utilities.JavaScriptUtils.<WriteCharAsync>d__14 <WriteCharAsync>d__;
			<WriteCharAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<WriteCharAsync>d__.task = task;
			<WriteCharAsync>d__.writer = writer;
			<WriteCharAsync>d__.c = c;
			<WriteCharAsync>d__.cancellationToken = cancellationToken;
			<WriteCharAsync>d__.<>1__state = -1;
			<WriteCharAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.Utilities.JavaScriptUtils.<WriteCharAsync>d__14>(ref <WriteCharAsync>d__);
			return <WriteCharAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00017008 File Offset: 0x00015208
		private static global::System.Threading.Tasks.Task WriteEscapedJavaScriptStringWithoutDelimitersAsync(global::System.IO.TextWriter writer, string s, bool[] charEscapeFlags, global::Newtonsoft.Json.StringEscapeHandling stringEscapeHandling, global::Newtonsoft.Json.JsonTextWriter client, char[] writeBuffer, global::System.Threading.CancellationToken cancellationToken)
		{
			int num = global::Newtonsoft.Json.Utilities.JavaScriptUtils.FirstCharToEscape(s, charEscapeFlags, stringEscapeHandling);
			if (num != -1)
			{
				return global::Newtonsoft.Json.Utilities.JavaScriptUtils.WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync(writer, s, num, charEscapeFlags, stringEscapeHandling, client, writeBuffer, cancellationToken);
			}
			return writer.WriteAsync(s, cancellationToken);
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x0001703C File Offset: 0x0001523C
		private static global::System.Threading.Tasks.Task WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync(global::System.IO.TextWriter writer, string s, int lastWritePosition, bool[] charEscapeFlags, global::Newtonsoft.Json.StringEscapeHandling stringEscapeHandling, global::Newtonsoft.Json.JsonTextWriter client, char[] writeBuffer, global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.Utilities.JavaScriptUtils.<WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync>d__16 <WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync>d__;
			<WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync>d__.writer = writer;
			<WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync>d__.s = s;
			<WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync>d__.lastWritePosition = lastWritePosition;
			<WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync>d__.charEscapeFlags = charEscapeFlags;
			<WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync>d__.stringEscapeHandling = stringEscapeHandling;
			<WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync>d__.client = client;
			<WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync>d__.writeBuffer = writeBuffer;
			<WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync>d__.cancellationToken = cancellationToken;
			<WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync>d__.<>1__state = -1;
			<WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.Utilities.JavaScriptUtils.<WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync>d__16>(ref <WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync>d__);
			return <WriteDefinitelyEscapedJavaScriptStringWithoutDelimitersAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x000170BC File Offset: 0x000152BC
		public static bool TryGetDateFromConstructorJson(global::Newtonsoft.Json.JsonReader reader, out global::System.DateTime dateTime, [global::System.Runtime.CompilerServices.Nullable(2)] [global::System.Diagnostics.CodeAnalysis.NotNullWhen(false)] out string errorMessage)
		{
			dateTime = default(global::System.DateTime);
			errorMessage = null;
			long? num;
			if (!global::Newtonsoft.Json.Utilities.JavaScriptUtils.TryGetDateConstructorValue(reader, out num, out errorMessage) || num == null)
			{
				errorMessage = (errorMessage ?? "Date constructor has no arguments.");
				return false;
			}
			long? num2;
			if (!global::Newtonsoft.Json.Utilities.JavaScriptUtils.TryGetDateConstructorValue(reader, out num2, out errorMessage))
			{
				return false;
			}
			if (num2 != null)
			{
				global::System.Collections.Generic.List<long> list = new global::System.Collections.Generic.List<long>
				{
					num.Value,
					num2.Value
				};
				long? num3;
				while (global::Newtonsoft.Json.Utilities.JavaScriptUtils.TryGetDateConstructorValue(reader, out num3, out errorMessage))
				{
					if (num3 != null)
					{
						list.Add(num3.Value);
					}
					else
					{
						if (list.Count > 7)
						{
							errorMessage = "Unexpected number of arguments when reading date constructor.";
							return false;
						}
						while (list.Count < 7)
						{
							list.Add(0L);
						}
						dateTime = new global::System.DateTime((int)list[0], (int)list[1] + 1, (list[2] == 0L) ? 1 : ((int)list[2]), (int)list[3], (int)list[4], (int)list[5], (int)list[6]);
						return true;
					}
				}
				return false;
			}
			dateTime = global::Newtonsoft.Json.Utilities.DateTimeUtils.ConvertJavaScriptTicksToDateTime(num.Value);
			return true;
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x000171E0 File Offset: 0x000153E0
		private static bool TryGetDateConstructorValue(global::Newtonsoft.Json.JsonReader reader, out long? integer, [global::System.Runtime.CompilerServices.Nullable(2)] [global::System.Diagnostics.CodeAnalysis.NotNullWhen(false)] out string errorMessage)
		{
			integer = null;
			errorMessage = null;
			if (!reader.Read())
			{
				errorMessage = "Unexpected end when reading date constructor.";
				return false;
			}
			if (reader.TokenType == global::Newtonsoft.Json.JsonToken.EndConstructor)
			{
				return true;
			}
			if (reader.TokenType != global::Newtonsoft.Json.JsonToken.Integer)
			{
				errorMessage = "Unexpected token when reading date constructor. Expected Integer, got " + reader.TokenType.ToString();
				return false;
			}
			integer = new long?((long)reader.Value);
			return true;
		}

		// Token: 0x040001F5 RID: 501
		internal static readonly bool[] SingleQuoteCharEscapeFlags = new bool[128];

		// Token: 0x040001F6 RID: 502
		internal static readonly bool[] DoubleQuoteCharEscapeFlags = new bool[128];

		// Token: 0x040001F7 RID: 503
		internal static readonly bool[] HtmlCharEscapeFlags = new bool[128];

		// Token: 0x040001F8 RID: 504
		private const int UnicodeTextLength = 6;

		// Token: 0x040001F9 RID: 505
		private const string EscapedUnicodeText = "!";
	}
}
