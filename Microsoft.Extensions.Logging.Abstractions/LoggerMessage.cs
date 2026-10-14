using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Logging.Internal;

namespace Microsoft.Extensions.Logging
{
	// Token: 0x02000009 RID: 9
	public static class LoggerMessage
	{
		// Token: 0x06000023 RID: 35 RVA: 0x000023CC File Offset: 0x000005CC
		public static global::System.Func<global::Microsoft.Extensions.Logging.ILogger, global::System.IDisposable> DefineScope(string formatString)
		{
			global::Microsoft.Extensions.Logging.Internal.LogValuesFormatter formatter = global::Microsoft.Extensions.Logging.LoggerMessage.CreateLogValuesFormatter(formatString, 0);
			global::Microsoft.Extensions.Logging.LoggerMessage.LogValues logValues = new global::Microsoft.Extensions.Logging.LoggerMessage.LogValues(formatter);
			return (global::Microsoft.Extensions.Logging.ILogger logger) => logger.BeginScope<global::Microsoft.Extensions.Logging.LoggerMessage.LogValues>(logValues);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000023FD File Offset: 0x000005FD
		public static global::System.Func<global::Microsoft.Extensions.Logging.ILogger, T1, global::System.IDisposable> DefineScope<T1>(string formatString)
		{
			global::Microsoft.Extensions.Logging.Internal.LogValuesFormatter formatter = global::Microsoft.Extensions.Logging.LoggerMessage.CreateLogValuesFormatter(formatString, 1);
			return (global::Microsoft.Extensions.Logging.ILogger logger, T1 arg1) => logger.BeginScope<global::Microsoft.Extensions.Logging.LoggerMessage.LogValues<T1>>(new global::Microsoft.Extensions.Logging.LoggerMessage.LogValues<T1>(formatter, arg1));
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000241C File Offset: 0x0000061C
		public static global::System.Func<global::Microsoft.Extensions.Logging.ILogger, T1, T2, global::System.IDisposable> DefineScope<T1, T2>(string formatString)
		{
			global::Microsoft.Extensions.Logging.Internal.LogValuesFormatter formatter = global::Microsoft.Extensions.Logging.LoggerMessage.CreateLogValuesFormatter(formatString, 2);
			return (global::Microsoft.Extensions.Logging.ILogger logger, T1 arg1, T2 arg2) => logger.BeginScope<global::Microsoft.Extensions.Logging.LoggerMessage.LogValues<T1, T2>>(new global::Microsoft.Extensions.Logging.LoggerMessage.LogValues<T1, T2>(formatter, arg1, arg2));
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000243B File Offset: 0x0000063B
		public static global::System.Func<global::Microsoft.Extensions.Logging.ILogger, T1, T2, T3, global::System.IDisposable> DefineScope<T1, T2, T3>(string formatString)
		{
			global::Microsoft.Extensions.Logging.Internal.LogValuesFormatter formatter = global::Microsoft.Extensions.Logging.LoggerMessage.CreateLogValuesFormatter(formatString, 3);
			return (global::Microsoft.Extensions.Logging.ILogger logger, T1 arg1, T2 arg2, T3 arg3) => logger.BeginScope<global::Microsoft.Extensions.Logging.LoggerMessage.LogValues<T1, T2, T3>>(new global::Microsoft.Extensions.Logging.LoggerMessage.LogValues<T1, T2, T3>(formatter, arg1, arg2, arg3));
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0000245A File Offset: 0x0000065A
		public static global::System.Action<global::Microsoft.Extensions.Logging.ILogger, global::System.Exception> Define(global::Microsoft.Extensions.Logging.LogLevel logLevel, global::Microsoft.Extensions.Logging.EventId eventId, string formatString)
		{
			global::Microsoft.Extensions.Logging.Internal.LogValuesFormatter formatter = global::Microsoft.Extensions.Logging.LoggerMessage.CreateLogValuesFormatter(formatString, 0);
			return delegate(global::Microsoft.Extensions.Logging.ILogger logger, global::System.Exception exception)
			{
				if (logger.IsEnabled(logLevel))
				{
					logger.Log<object>(logLevel, eventId, new global::Microsoft.Extensions.Logging.LoggerMessage.LogValues(formatter), exception, global::Microsoft.Extensions.Logging.LoggerMessage.LogValues.Callback);
				}
			};
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002487 File Offset: 0x00000687
		public static global::System.Action<global::Microsoft.Extensions.Logging.ILogger, T1, global::System.Exception> Define<T1>(global::Microsoft.Extensions.Logging.LogLevel logLevel, global::Microsoft.Extensions.Logging.EventId eventId, string formatString)
		{
			global::Microsoft.Extensions.Logging.Internal.LogValuesFormatter formatter = global::Microsoft.Extensions.Logging.LoggerMessage.CreateLogValuesFormatter(formatString, 1);
			return delegate(global::Microsoft.Extensions.Logging.ILogger logger, T1 arg1, global::System.Exception exception)
			{
				if (logger.IsEnabled(logLevel))
				{
					logger.Log<object>(logLevel, eventId, new global::Microsoft.Extensions.Logging.LoggerMessage.LogValues<T1>(formatter, arg1), exception, global::Microsoft.Extensions.Logging.LoggerMessage.LogValues<T1>.Callback);
				}
			};
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000024B4 File Offset: 0x000006B4
		public static global::System.Action<global::Microsoft.Extensions.Logging.ILogger, T1, T2, global::System.Exception> Define<T1, T2>(global::Microsoft.Extensions.Logging.LogLevel logLevel, global::Microsoft.Extensions.Logging.EventId eventId, string formatString)
		{
			global::Microsoft.Extensions.Logging.Internal.LogValuesFormatter formatter = global::Microsoft.Extensions.Logging.LoggerMessage.CreateLogValuesFormatter(formatString, 2);
			return delegate(global::Microsoft.Extensions.Logging.ILogger logger, T1 arg1, T2 arg2, global::System.Exception exception)
			{
				if (logger.IsEnabled(logLevel))
				{
					logger.Log<object>(logLevel, eventId, new global::Microsoft.Extensions.Logging.LoggerMessage.LogValues<T1, T2>(formatter, arg1, arg2), exception, global::Microsoft.Extensions.Logging.LoggerMessage.LogValues<T1, T2>.Callback);
				}
			};
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000024E1 File Offset: 0x000006E1
		public static global::System.Action<global::Microsoft.Extensions.Logging.ILogger, T1, T2, T3, global::System.Exception> Define<T1, T2, T3>(global::Microsoft.Extensions.Logging.LogLevel logLevel, global::Microsoft.Extensions.Logging.EventId eventId, string formatString)
		{
			global::Microsoft.Extensions.Logging.Internal.LogValuesFormatter formatter = global::Microsoft.Extensions.Logging.LoggerMessage.CreateLogValuesFormatter(formatString, 3);
			return delegate(global::Microsoft.Extensions.Logging.ILogger logger, T1 arg1, T2 arg2, T3 arg3, global::System.Exception exception)
			{
				if (logger.IsEnabled(logLevel))
				{
					logger.Log<object>(logLevel, eventId, new global::Microsoft.Extensions.Logging.LoggerMessage.LogValues<T1, T2, T3>(formatter, arg1, arg2, arg3), exception, global::Microsoft.Extensions.Logging.LoggerMessage.LogValues<T1, T2, T3>.Callback);
				}
			};
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000250E File Offset: 0x0000070E
		public static global::System.Action<global::Microsoft.Extensions.Logging.ILogger, T1, T2, T3, T4, global::System.Exception> Define<T1, T2, T3, T4>(global::Microsoft.Extensions.Logging.LogLevel logLevel, global::Microsoft.Extensions.Logging.EventId eventId, string formatString)
		{
			global::Microsoft.Extensions.Logging.Internal.LogValuesFormatter formatter = global::Microsoft.Extensions.Logging.LoggerMessage.CreateLogValuesFormatter(formatString, 4);
			return delegate(global::Microsoft.Extensions.Logging.ILogger logger, T1 arg1, T2 arg2, T3 arg3, T4 arg4, global::System.Exception exception)
			{
				if (logger.IsEnabled(logLevel))
				{
					logger.Log<object>(logLevel, eventId, new global::Microsoft.Extensions.Logging.LoggerMessage.LogValues<T1, T2, T3, T4>(formatter, arg1, arg2, arg3, arg4), exception, global::Microsoft.Extensions.Logging.LoggerMessage.LogValues<T1, T2, T3, T4>.Callback);
				}
			};
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000253B File Offset: 0x0000073B
		public static global::System.Action<global::Microsoft.Extensions.Logging.ILogger, T1, T2, T3, T4, T5, global::System.Exception> Define<T1, T2, T3, T4, T5>(global::Microsoft.Extensions.Logging.LogLevel logLevel, global::Microsoft.Extensions.Logging.EventId eventId, string formatString)
		{
			global::Microsoft.Extensions.Logging.Internal.LogValuesFormatter formatter = global::Microsoft.Extensions.Logging.LoggerMessage.CreateLogValuesFormatter(formatString, 5);
			return delegate(global::Microsoft.Extensions.Logging.ILogger logger, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, global::System.Exception exception)
			{
				if (logger.IsEnabled(logLevel))
				{
					logger.Log<object>(logLevel, eventId, new global::Microsoft.Extensions.Logging.LoggerMessage.LogValues<T1, T2, T3, T4, T5>(formatter, arg1, arg2, arg3, arg4, arg5), exception, global::Microsoft.Extensions.Logging.LoggerMessage.LogValues<T1, T2, T3, T4, T5>.Callback);
				}
			};
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002568 File Offset: 0x00000768
		public static global::System.Action<global::Microsoft.Extensions.Logging.ILogger, T1, T2, T3, T4, T5, T6, global::System.Exception> Define<T1, T2, T3, T4, T5, T6>(global::Microsoft.Extensions.Logging.LogLevel logLevel, global::Microsoft.Extensions.Logging.EventId eventId, string formatString)
		{
			global::Microsoft.Extensions.Logging.Internal.LogValuesFormatter formatter = global::Microsoft.Extensions.Logging.LoggerMessage.CreateLogValuesFormatter(formatString, 6);
			return delegate(global::Microsoft.Extensions.Logging.ILogger logger, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, global::System.Exception exception)
			{
				if (logger.IsEnabled(logLevel))
				{
					logger.Log<object>(logLevel, eventId, new global::Microsoft.Extensions.Logging.LoggerMessage.LogValues<T1, T2, T3, T4, T5, T6>(formatter, arg1, arg2, arg3, arg4, arg5, arg6), exception, global::Microsoft.Extensions.Logging.LoggerMessage.LogValues<T1, T2, T3, T4, T5, T6>.Callback);
				}
			};
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002598 File Offset: 0x00000798
		private static global::Microsoft.Extensions.Logging.Internal.LogValuesFormatter CreateLogValuesFormatter(string formatString, int expectedNamedParameterCount)
		{
			global::Microsoft.Extensions.Logging.Internal.LogValuesFormatter logValuesFormatter = new global::Microsoft.Extensions.Logging.Internal.LogValuesFormatter(formatString);
			int count = logValuesFormatter.ValueNames.Count;
			if (count != expectedNamedParameterCount)
			{
				throw new global::System.ArgumentException(global::Microsoft.Extensions.Logging.Abstractions.Resource.FormatUnexpectedNumberOfNamedParameters(formatString, expectedNamedParameterCount, count));
			}
			return logValuesFormatter;
		}

		// Token: 0x02000013 RID: 19
		private class LogValues : global::System.Collections.Generic.IReadOnlyList<global::System.Collections.Generic.KeyValuePair<string, object>>, global::System.Collections.Generic.IReadOnlyCollection<global::System.Collections.Generic.KeyValuePair<string, object>>, global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>, global::System.Collections.IEnumerable
		{
			// Token: 0x0600005A RID: 90 RVA: 0x00002D52 File Offset: 0x00000F52
			public LogValues(global::Microsoft.Extensions.Logging.Internal.LogValuesFormatter formatter)
			{
				this._formatter = formatter;
			}

			// Token: 0x1700000B RID: 11
			public global::System.Collections.Generic.KeyValuePair<string, object> this[int index]
			{
				get
				{
					if (index == 0)
					{
						return new global::System.Collections.Generic.KeyValuePair<string, object>("{OriginalFormat}", this._formatter.OriginalFormat);
					}
					throw new global::System.IndexOutOfRangeException("index");
				}
			}

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x0600005C RID: 92 RVA: 0x00002D86 File Offset: 0x00000F86
			public int Count
			{
				get
				{
					return 1;
				}
			}

			// Token: 0x0600005D RID: 93 RVA: 0x00002D89 File Offset: 0x00000F89
			public global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, object>> GetEnumerator()
			{
				yield return this[0];
				yield break;
			}

			// Token: 0x0600005E RID: 94 RVA: 0x00002D98 File Offset: 0x00000F98
			public object[] ToArray()
			{
				return global::Microsoft.Extensions.Logging.LoggerMessage.LogValues._valueArray;
			}

			// Token: 0x0600005F RID: 95 RVA: 0x00002D9F File Offset: 0x00000F9F
			public override string ToString()
			{
				return this._formatter.Format(this.ToArray());
			}

			// Token: 0x06000060 RID: 96 RVA: 0x00002DB2 File Offset: 0x00000FB2
			global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x0400001C RID: 28
			public static global::System.Func<object, global::System.Exception, string> Callback = (object state, global::System.Exception exception) => ((global::Microsoft.Extensions.Logging.LoggerMessage.LogValues)state)._formatter.Format(((global::Microsoft.Extensions.Logging.LoggerMessage.LogValues)state).ToArray());

			// Token: 0x0400001D RID: 29
			private static object[] _valueArray = new object[0];

			// Token: 0x0400001E RID: 30
			private readonly global::Microsoft.Extensions.Logging.Internal.LogValuesFormatter _formatter;
		}

		// Token: 0x02000014 RID: 20
		private class LogValues<T0> : global::System.Collections.Generic.IReadOnlyList<global::System.Collections.Generic.KeyValuePair<string, object>>, global::System.Collections.Generic.IReadOnlyCollection<global::System.Collections.Generic.KeyValuePair<string, object>>, global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>, global::System.Collections.IEnumerable
		{
			// Token: 0x06000062 RID: 98 RVA: 0x00002DDC File Offset: 0x00000FDC
			public LogValues(global::Microsoft.Extensions.Logging.Internal.LogValuesFormatter formatter, T0 value0)
			{
				this._formatter = formatter;
				this._value0 = value0;
			}

			// Token: 0x1700000D RID: 13
			public global::System.Collections.Generic.KeyValuePair<string, object> this[int index]
			{
				get
				{
					if (index == 0)
					{
						return new global::System.Collections.Generic.KeyValuePair<string, object>(this._formatter.ValueNames[0], this._value0);
					}
					if (index == 1)
					{
						return new global::System.Collections.Generic.KeyValuePair<string, object>("{OriginalFormat}", this._formatter.OriginalFormat);
					}
					throw new global::System.IndexOutOfRangeException("index");
				}
			}

			// Token: 0x1700000E RID: 14
			// (get) Token: 0x06000064 RID: 100 RVA: 0x00002E4A File Offset: 0x0000104A
			public int Count
			{
				get
				{
					return 2;
				}
			}

			// Token: 0x06000065 RID: 101 RVA: 0x00002E4D File Offset: 0x0000104D
			public global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, object>> GetEnumerator()
			{
				int num;
				for (int i = 0; i < this.Count; i = num)
				{
					yield return this[i];
					num = i + 1;
				}
				yield break;
			}

			// Token: 0x06000066 RID: 102 RVA: 0x00002E5C File Offset: 0x0000105C
			public object[] ToArray()
			{
				return new object[]
				{
					this._value0
				};
			}

			// Token: 0x06000067 RID: 103 RVA: 0x00002E72 File Offset: 0x00001072
			public override string ToString()
			{
				return this._formatter.Format(this.ToArray());
			}

			// Token: 0x06000068 RID: 104 RVA: 0x00002E85 File Offset: 0x00001085
			global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x0400001F RID: 31
			public static global::System.Func<object, global::System.Exception, string> Callback = (object state, global::System.Exception exception) => ((global::Microsoft.Extensions.Logging.LoggerMessage.LogValues<T0>)state)._formatter.Format(((global::Microsoft.Extensions.Logging.LoggerMessage.LogValues<T0>)state).ToArray());

			// Token: 0x04000020 RID: 32
			private readonly global::Microsoft.Extensions.Logging.Internal.LogValuesFormatter _formatter;

			// Token: 0x04000021 RID: 33
			private readonly T0 _value0;
		}

		// Token: 0x02000015 RID: 21
		private class LogValues<T0, T1> : global::System.Collections.Generic.IReadOnlyList<global::System.Collections.Generic.KeyValuePair<string, object>>, global::System.Collections.Generic.IReadOnlyCollection<global::System.Collections.Generic.KeyValuePair<string, object>>, global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>, global::System.Collections.IEnumerable
		{
			// Token: 0x0600006A RID: 106 RVA: 0x00002EA4 File Offset: 0x000010A4
			public LogValues(global::Microsoft.Extensions.Logging.Internal.LogValuesFormatter formatter, T0 value0, T1 value1)
			{
				this._formatter = formatter;
				this._value0 = value0;
				this._value1 = value1;
			}

			// Token: 0x1700000F RID: 15
			public global::System.Collections.Generic.KeyValuePair<string, object> this[int index]
			{
				get
				{
					switch (index)
					{
					case 0:
						return new global::System.Collections.Generic.KeyValuePair<string, object>(this._formatter.ValueNames[0], this._value0);
					case 1:
						return new global::System.Collections.Generic.KeyValuePair<string, object>(this._formatter.ValueNames[1], this._value1);
					case 2:
						return new global::System.Collections.Generic.KeyValuePair<string, object>("{OriginalFormat}", this._formatter.OriginalFormat);
					default:
						throw new global::System.IndexOutOfRangeException("index");
					}
				}
			}

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x0600006C RID: 108 RVA: 0x00002F49 File Offset: 0x00001149
			public int Count
			{
				get
				{
					return 3;
				}
			}

			// Token: 0x0600006D RID: 109 RVA: 0x00002F4C File Offset: 0x0000114C
			public global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, object>> GetEnumerator()
			{
				int num;
				for (int i = 0; i < this.Count; i = num)
				{
					yield return this[i];
					num = i + 1;
				}
				yield break;
			}

			// Token: 0x0600006E RID: 110 RVA: 0x00002F5B File Offset: 0x0000115B
			public object[] ToArray()
			{
				return new object[]
				{
					this._value0,
					this._value1
				};
			}

			// Token: 0x0600006F RID: 111 RVA: 0x00002F7F File Offset: 0x0000117F
			public override string ToString()
			{
				return this._formatter.Format(this.ToArray());
			}

			// Token: 0x06000070 RID: 112 RVA: 0x00002F92 File Offset: 0x00001192
			global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x04000022 RID: 34
			public static global::System.Func<object, global::System.Exception, string> Callback = (object state, global::System.Exception exception) => ((global::Microsoft.Extensions.Logging.LoggerMessage.LogValues<T0, T1>)state)._formatter.Format(((global::Microsoft.Extensions.Logging.LoggerMessage.LogValues<T0, T1>)state).ToArray());

			// Token: 0x04000023 RID: 35
			private readonly global::Microsoft.Extensions.Logging.Internal.LogValuesFormatter _formatter;

			// Token: 0x04000024 RID: 36
			private readonly T0 _value0;

			// Token: 0x04000025 RID: 37
			private readonly T1 _value1;
		}

		// Token: 0x02000016 RID: 22
		private class LogValues<T0, T1, T2> : global::System.Collections.Generic.IReadOnlyList<global::System.Collections.Generic.KeyValuePair<string, object>>, global::System.Collections.Generic.IReadOnlyCollection<global::System.Collections.Generic.KeyValuePair<string, object>>, global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>, global::System.Collections.IEnumerable
		{
			// Token: 0x17000011 RID: 17
			// (get) Token: 0x06000072 RID: 114 RVA: 0x00002FB1 File Offset: 0x000011B1
			public int Count
			{
				get
				{
					return 4;
				}
			}

			// Token: 0x17000012 RID: 18
			public global::System.Collections.Generic.KeyValuePair<string, object> this[int index]
			{
				get
				{
					switch (index)
					{
					case 0:
						return new global::System.Collections.Generic.KeyValuePair<string, object>(this._formatter.ValueNames[0], this._value0);
					case 1:
						return new global::System.Collections.Generic.KeyValuePair<string, object>(this._formatter.ValueNames[1], this._value1);
					case 2:
						return new global::System.Collections.Generic.KeyValuePair<string, object>(this._formatter.ValueNames[2], this._value2);
					case 3:
						return new global::System.Collections.Generic.KeyValuePair<string, object>("{OriginalFormat}", this._formatter.OriginalFormat);
					default:
						throw new global::System.IndexOutOfRangeException("index");
					}
				}
			}

			// Token: 0x06000074 RID: 116 RVA: 0x0000305F File Offset: 0x0000125F
			public LogValues(global::Microsoft.Extensions.Logging.Internal.LogValuesFormatter formatter, T0 value0, T1 value1, T2 value2)
			{
				this._formatter = formatter;
				this._value0 = value0;
				this._value1 = value1;
				this._value2 = value2;
			}

			// Token: 0x06000075 RID: 117 RVA: 0x00003084 File Offset: 0x00001284
			public object[] ToArray()
			{
				return new object[]
				{
					this._value0,
					this._value1,
					this._value2
				};
			}

			// Token: 0x06000076 RID: 118 RVA: 0x000030B6 File Offset: 0x000012B6
			public override string ToString()
			{
				return this._formatter.Format(this.ToArray());
			}

			// Token: 0x06000077 RID: 119 RVA: 0x000030C9 File Offset: 0x000012C9
			public global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, object>> GetEnumerator()
			{
				int num;
				for (int i = 0; i < this.Count; i = num)
				{
					yield return this[i];
					num = i + 1;
				}
				yield break;
			}

			// Token: 0x06000078 RID: 120 RVA: 0x000030D8 File Offset: 0x000012D8
			global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x04000026 RID: 38
			public static global::System.Func<object, global::System.Exception, string> Callback = (object state, global::System.Exception exception) => ((global::Microsoft.Extensions.Logging.LoggerMessage.LogValues<T0, T1, T2>)state)._formatter.Format(((global::Microsoft.Extensions.Logging.LoggerMessage.LogValues<T0, T1, T2>)state).ToArray());

			// Token: 0x04000027 RID: 39
			private readonly global::Microsoft.Extensions.Logging.Internal.LogValuesFormatter _formatter;

			// Token: 0x04000028 RID: 40
			public T0 _value0;

			// Token: 0x04000029 RID: 41
			public T1 _value1;

			// Token: 0x0400002A RID: 42
			public T2 _value2;
		}

		// Token: 0x02000017 RID: 23
		private class LogValues<T0, T1, T2, T3> : global::System.Collections.Generic.IReadOnlyList<global::System.Collections.Generic.KeyValuePair<string, object>>, global::System.Collections.Generic.IReadOnlyCollection<global::System.Collections.Generic.KeyValuePair<string, object>>, global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>, global::System.Collections.IEnumerable
		{
			// Token: 0x17000013 RID: 19
			// (get) Token: 0x0600007A RID: 122 RVA: 0x000030F7 File Offset: 0x000012F7
			public int Count
			{
				get
				{
					return 5;
				}
			}

			// Token: 0x17000014 RID: 20
			public global::System.Collections.Generic.KeyValuePair<string, object> this[int index]
			{
				get
				{
					switch (index)
					{
					case 0:
						return new global::System.Collections.Generic.KeyValuePair<string, object>(this._formatter.ValueNames[0], this._value0);
					case 1:
						return new global::System.Collections.Generic.KeyValuePair<string, object>(this._formatter.ValueNames[1], this._value1);
					case 2:
						return new global::System.Collections.Generic.KeyValuePair<string, object>(this._formatter.ValueNames[2], this._value2);
					case 3:
						return new global::System.Collections.Generic.KeyValuePair<string, object>(this._formatter.ValueNames[3], this._value3);
					case 4:
						return new global::System.Collections.Generic.KeyValuePair<string, object>("{OriginalFormat}", this._formatter.OriginalFormat);
					default:
						throw new global::System.IndexOutOfRangeException("index");
					}
				}
			}

			// Token: 0x0600007C RID: 124 RVA: 0x000031D0 File Offset: 0x000013D0
			public LogValues(global::Microsoft.Extensions.Logging.Internal.LogValuesFormatter formatter, T0 value0, T1 value1, T2 value2, T3 value3)
			{
				this._formatter = formatter;
				this._value0 = value0;
				this._value1 = value1;
				this._value2 = value2;
				this._value3 = value3;
			}

			// Token: 0x0600007D RID: 125 RVA: 0x000031FD File Offset: 0x000013FD
			public object[] ToArray()
			{
				return new object[]
				{
					this._value0,
					this._value1,
					this._value2,
					this._value3
				};
			}

			// Token: 0x0600007E RID: 126 RVA: 0x0000323D File Offset: 0x0000143D
			public override string ToString()
			{
				return this._formatter.Format(this.ToArray());
			}

			// Token: 0x0600007F RID: 127 RVA: 0x00003250 File Offset: 0x00001450
			public global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, object>> GetEnumerator()
			{
				int num;
				for (int i = 0; i < this.Count; i = num)
				{
					yield return this[i];
					num = i + 1;
				}
				yield break;
			}

			// Token: 0x06000080 RID: 128 RVA: 0x0000325F File Offset: 0x0000145F
			global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x0400002B RID: 43
			public static global::System.Func<object, global::System.Exception, string> Callback = (object state, global::System.Exception exception) => ((global::Microsoft.Extensions.Logging.LoggerMessage.LogValues<T0, T1, T2, T3>)state)._formatter.Format(((global::Microsoft.Extensions.Logging.LoggerMessage.LogValues<T0, T1, T2, T3>)state).ToArray());

			// Token: 0x0400002C RID: 44
			private readonly global::Microsoft.Extensions.Logging.Internal.LogValuesFormatter _formatter;

			// Token: 0x0400002D RID: 45
			public T0 _value0;

			// Token: 0x0400002E RID: 46
			public T1 _value1;

			// Token: 0x0400002F RID: 47
			public T2 _value2;

			// Token: 0x04000030 RID: 48
			public T3 _value3;
		}

		// Token: 0x02000018 RID: 24
		private class LogValues<T0, T1, T2, T3, T4> : global::System.Collections.Generic.IReadOnlyList<global::System.Collections.Generic.KeyValuePair<string, object>>, global::System.Collections.Generic.IReadOnlyCollection<global::System.Collections.Generic.KeyValuePair<string, object>>, global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>, global::System.Collections.IEnumerable
		{
			// Token: 0x17000015 RID: 21
			// (get) Token: 0x06000082 RID: 130 RVA: 0x0000327E File Offset: 0x0000147E
			public int Count
			{
				get
				{
					return 6;
				}
			}

			// Token: 0x17000016 RID: 22
			public global::System.Collections.Generic.KeyValuePair<string, object> this[int index]
			{
				get
				{
					switch (index)
					{
					case 0:
						return new global::System.Collections.Generic.KeyValuePair<string, object>(this._formatter.ValueNames[0], this._value0);
					case 1:
						return new global::System.Collections.Generic.KeyValuePair<string, object>(this._formatter.ValueNames[1], this._value1);
					case 2:
						return new global::System.Collections.Generic.KeyValuePair<string, object>(this._formatter.ValueNames[2], this._value2);
					case 3:
						return new global::System.Collections.Generic.KeyValuePair<string, object>(this._formatter.ValueNames[3], this._value3);
					case 4:
						return new global::System.Collections.Generic.KeyValuePair<string, object>(this._formatter.ValueNames[4], this._value4);
					case 5:
						return new global::System.Collections.Generic.KeyValuePair<string, object>("{OriginalFormat}", this._formatter.OriginalFormat);
					default:
						throw new global::System.IndexOutOfRangeException("index");
					}
				}
			}

			// Token: 0x06000084 RID: 132 RVA: 0x0000337E File Offset: 0x0000157E
			public LogValues(global::Microsoft.Extensions.Logging.Internal.LogValuesFormatter formatter, T0 value0, T1 value1, T2 value2, T3 value3, T4 value4)
			{
				this._formatter = formatter;
				this._value0 = value0;
				this._value1 = value1;
				this._value2 = value2;
				this._value3 = value3;
				this._value4 = value4;
			}

			// Token: 0x06000085 RID: 133 RVA: 0x000033B4 File Offset: 0x000015B4
			public object[] ToArray()
			{
				return new object[]
				{
					this._value0,
					this._value1,
					this._value2,
					this._value3,
					this._value4
				};
			}

			// Token: 0x06000086 RID: 134 RVA: 0x0000340D File Offset: 0x0000160D
			public override string ToString()
			{
				return this._formatter.Format(this.ToArray());
			}

			// Token: 0x06000087 RID: 135 RVA: 0x00003420 File Offset: 0x00001620
			public global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, object>> GetEnumerator()
			{
				int num;
				for (int i = 0; i < this.Count; i = num)
				{
					yield return this[i];
					num = i + 1;
				}
				yield break;
			}

			// Token: 0x06000088 RID: 136 RVA: 0x0000342F File Offset: 0x0000162F
			global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x04000031 RID: 49
			public static global::System.Func<object, global::System.Exception, string> Callback = (object state, global::System.Exception exception) => ((global::Microsoft.Extensions.Logging.LoggerMessage.LogValues<T0, T1, T2, T3, T4>)state)._formatter.Format(((global::Microsoft.Extensions.Logging.LoggerMessage.LogValues<T0, T1, T2, T3, T4>)state).ToArray());

			// Token: 0x04000032 RID: 50
			private readonly global::Microsoft.Extensions.Logging.Internal.LogValuesFormatter _formatter;

			// Token: 0x04000033 RID: 51
			public T0 _value0;

			// Token: 0x04000034 RID: 52
			public T1 _value1;

			// Token: 0x04000035 RID: 53
			public T2 _value2;

			// Token: 0x04000036 RID: 54
			public T3 _value3;

			// Token: 0x04000037 RID: 55
			public T4 _value4;
		}

		// Token: 0x02000019 RID: 25
		private class LogValues<T0, T1, T2, T3, T4, T5> : global::System.Collections.Generic.IReadOnlyList<global::System.Collections.Generic.KeyValuePair<string, object>>, global::System.Collections.Generic.IReadOnlyCollection<global::System.Collections.Generic.KeyValuePair<string, object>>, global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>, global::System.Collections.IEnumerable
		{
			// Token: 0x17000017 RID: 23
			// (get) Token: 0x0600008A RID: 138 RVA: 0x0000344E File Offset: 0x0000164E
			public int Count
			{
				get
				{
					return 7;
				}
			}

			// Token: 0x17000018 RID: 24
			public global::System.Collections.Generic.KeyValuePair<string, object> this[int index]
			{
				get
				{
					switch (index)
					{
					case 0:
						return new global::System.Collections.Generic.KeyValuePair<string, object>(this._formatter.ValueNames[0], this._value0);
					case 1:
						return new global::System.Collections.Generic.KeyValuePair<string, object>(this._formatter.ValueNames[1], this._value1);
					case 2:
						return new global::System.Collections.Generic.KeyValuePair<string, object>(this._formatter.ValueNames[2], this._value2);
					case 3:
						return new global::System.Collections.Generic.KeyValuePair<string, object>(this._formatter.ValueNames[3], this._value3);
					case 4:
						return new global::System.Collections.Generic.KeyValuePair<string, object>(this._formatter.ValueNames[4], this._value4);
					case 5:
						return new global::System.Collections.Generic.KeyValuePair<string, object>(this._formatter.ValueNames[5], this._value5);
					case 6:
						return new global::System.Collections.Generic.KeyValuePair<string, object>("{OriginalFormat}", this._formatter.OriginalFormat);
					default:
						throw new global::System.IndexOutOfRangeException("index");
					}
				}
			}

			// Token: 0x0600008C RID: 140 RVA: 0x00003574 File Offset: 0x00001774
			public LogValues(global::Microsoft.Extensions.Logging.Internal.LogValuesFormatter formatter, T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5)
			{
				this._formatter = formatter;
				this._value0 = value0;
				this._value1 = value1;
				this._value2 = value2;
				this._value3 = value3;
				this._value4 = value4;
				this._value5 = value5;
			}

			// Token: 0x0600008D RID: 141 RVA: 0x000035B4 File Offset: 0x000017B4
			public object[] ToArray()
			{
				return new object[]
				{
					this._value0,
					this._value1,
					this._value2,
					this._value3,
					this._value4,
					this._value5
				};
			}

			// Token: 0x0600008E RID: 142 RVA: 0x0000361B File Offset: 0x0000181B
			public override string ToString()
			{
				return this._formatter.Format(this.ToArray());
			}

			// Token: 0x0600008F RID: 143 RVA: 0x0000362E File Offset: 0x0000182E
			public global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, object>> GetEnumerator()
			{
				int num;
				for (int i = 0; i < this.Count; i = num)
				{
					yield return this[i];
					num = i + 1;
				}
				yield break;
			}

			// Token: 0x06000090 RID: 144 RVA: 0x0000363D File Offset: 0x0000183D
			global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x04000038 RID: 56
			public static global::System.Func<object, global::System.Exception, string> Callback = (object state, global::System.Exception exception) => ((global::Microsoft.Extensions.Logging.LoggerMessage.LogValues<T0, T1, T2, T3, T4, T5>)state)._formatter.Format(((global::Microsoft.Extensions.Logging.LoggerMessage.LogValues<T0, T1, T2, T3, T4, T5>)state).ToArray());

			// Token: 0x04000039 RID: 57
			private readonly global::Microsoft.Extensions.Logging.Internal.LogValuesFormatter _formatter;

			// Token: 0x0400003A RID: 58
			public T0 _value0;

			// Token: 0x0400003B RID: 59
			public T1 _value1;

			// Token: 0x0400003C RID: 60
			public T2 _value2;

			// Token: 0x0400003D RID: 61
			public T3 _value3;

			// Token: 0x0400003E RID: 62
			public T4 _value4;

			// Token: 0x0400003F RID: 63
			public T5 _value5;
		}

		// Token: 0x0200001A RID: 26
		private class LogValues<T0, T1, T2, T3, T4, T5, T6> : global::System.Collections.Generic.IReadOnlyList<global::System.Collections.Generic.KeyValuePair<string, object>>, global::System.Collections.Generic.IReadOnlyCollection<global::System.Collections.Generic.KeyValuePair<string, object>>, global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>, global::System.Collections.IEnumerable
		{
			// Token: 0x17000019 RID: 25
			// (get) Token: 0x06000092 RID: 146 RVA: 0x0000365C File Offset: 0x0000185C
			public int Count
			{
				get
				{
					return 8;
				}
			}

			// Token: 0x1700001A RID: 26
			public global::System.Collections.Generic.KeyValuePair<string, object> this[int index]
			{
				get
				{
					switch (index)
					{
					case 0:
						return new global::System.Collections.Generic.KeyValuePair<string, object>(this._formatter.ValueNames[0], this._value0);
					case 1:
						return new global::System.Collections.Generic.KeyValuePair<string, object>(this._formatter.ValueNames[1], this._value1);
					case 2:
						return new global::System.Collections.Generic.KeyValuePair<string, object>(this._formatter.ValueNames[2], this._value2);
					case 3:
						return new global::System.Collections.Generic.KeyValuePair<string, object>(this._formatter.ValueNames[3], this._value3);
					case 4:
						return new global::System.Collections.Generic.KeyValuePair<string, object>(this._formatter.ValueNames[4], this._value4);
					case 5:
						return new global::System.Collections.Generic.KeyValuePair<string, object>(this._formatter.ValueNames[5], this._value5);
					case 6:
						return new global::System.Collections.Generic.KeyValuePair<string, object>(this._formatter.ValueNames[6], this._value6);
					case 7:
						return new global::System.Collections.Generic.KeyValuePair<string, object>("{OriginalFormat}", this._formatter.OriginalFormat);
					default:
						throw new global::System.IndexOutOfRangeException("index");
					}
				}
			}

			// Token: 0x06000094 RID: 148 RVA: 0x000037A8 File Offset: 0x000019A8
			public LogValues(global::Microsoft.Extensions.Logging.Internal.LogValuesFormatter formatter, T0 value0, T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6)
			{
				this._formatter = formatter;
				this._value0 = value0;
				this._value1 = value1;
				this._value2 = value2;
				this._value3 = value3;
				this._value4 = value4;
				this._value5 = value5;
				this._value6 = value6;
			}

			// Token: 0x06000095 RID: 149 RVA: 0x000037F8 File Offset: 0x000019F8
			public object[] ToArray()
			{
				return new object[]
				{
					this._value0,
					this._value1,
					this._value2,
					this._value3,
					this._value4,
					this._value5,
					this._value6
				};
			}

			// Token: 0x06000096 RID: 150 RVA: 0x0000386D File Offset: 0x00001A6D
			public override string ToString()
			{
				return this._formatter.Format(this.ToArray());
			}

			// Token: 0x06000097 RID: 151 RVA: 0x00003880 File Offset: 0x00001A80
			public global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, object>> GetEnumerator()
			{
				int num;
				for (int i = 0; i < this.Count; i = num)
				{
					yield return this[i];
					num = i + 1;
				}
				yield break;
			}

			// Token: 0x06000098 RID: 152 RVA: 0x0000388F File Offset: 0x00001A8F
			global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x04000040 RID: 64
			public static global::System.Func<object, global::System.Exception, string> Callback = (object state, global::System.Exception exception) => ((global::Microsoft.Extensions.Logging.LoggerMessage.LogValues<T0, T1, T2, T3, T4, T5, T6>)state)._formatter.Format(((global::Microsoft.Extensions.Logging.LoggerMessage.LogValues<T0, T1, T2, T3, T4, T5, T6>)state).ToArray());

			// Token: 0x04000041 RID: 65
			private readonly global::Microsoft.Extensions.Logging.Internal.LogValuesFormatter _formatter;

			// Token: 0x04000042 RID: 66
			public T0 _value0;

			// Token: 0x04000043 RID: 67
			public T1 _value1;

			// Token: 0x04000044 RID: 68
			public T2 _value2;

			// Token: 0x04000045 RID: 69
			public T3 _value3;

			// Token: 0x04000046 RID: 70
			public T4 _value4;

			// Token: 0x04000047 RID: 71
			public T5 _value5;

			// Token: 0x04000048 RID: 72
			public T6 _value6;
		}
	}
}
