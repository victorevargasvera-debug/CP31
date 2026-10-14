using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Microsoft.Extensions.Logging.Internal
{
	// Token: 0x0200000C RID: 12
	public class FormattedLogValues : global::System.Collections.Generic.IReadOnlyList<global::System.Collections.Generic.KeyValuePair<string, object>>, global::System.Collections.Generic.IReadOnlyCollection<global::System.Collections.Generic.KeyValuePair<string, object>>, global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>, global::System.Collections.IEnumerable
	{
		// Token: 0x06000033 RID: 51 RVA: 0x00002634 File Offset: 0x00000834
		public FormattedLogValues(string format, params object[] values)
		{
			if ((values == null || values.Length != 0) && format != null)
			{
				this._formatter = global::Microsoft.Extensions.Logging.Internal.FormattedLogValues._formatters.GetOrAdd(format, (string f) => new global::Microsoft.Extensions.Logging.Internal.LogValuesFormatter(f));
			}
			this._originalMessage = (format ?? "[null]");
			this._values = values;
		}

		// Token: 0x17000003 RID: 3
		public global::System.Collections.Generic.KeyValuePair<string, object> this[int index]
		{
			get
			{
				if (index < 0 || index >= this.Count)
				{
					throw new global::System.IndexOutOfRangeException("index");
				}
				if (index == this.Count - 1)
				{
					return new global::System.Collections.Generic.KeyValuePair<string, object>("{OriginalFormat}", this._originalMessage);
				}
				return this._formatter.GetValue(this._values, index);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000035 RID: 53 RVA: 0x000026F3 File Offset: 0x000008F3
		public int Count
		{
			get
			{
				if (this._formatter == null)
				{
					return 1;
				}
				return this._formatter.ValueNames.Count + 1;
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002711 File Offset: 0x00000911
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

		// Token: 0x06000037 RID: 55 RVA: 0x00002720 File Offset: 0x00000920
		public override string ToString()
		{
			if (this._formatter == null)
			{
				return this._originalMessage;
			}
			return this._formatter.Format(this._values);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002742 File Offset: 0x00000942
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x0400000D RID: 13
		private const string NullFormat = "[null]";

		// Token: 0x0400000E RID: 14
		private static global::System.Collections.Concurrent.ConcurrentDictionary<string, global::Microsoft.Extensions.Logging.Internal.LogValuesFormatter> _formatters = new global::System.Collections.Concurrent.ConcurrentDictionary<string, global::Microsoft.Extensions.Logging.Internal.LogValuesFormatter>();

		// Token: 0x0400000F RID: 15
		private readonly global::Microsoft.Extensions.Logging.Internal.LogValuesFormatter _formatter;

		// Token: 0x04000010 RID: 16
		private readonly object[] _values;

		// Token: 0x04000011 RID: 17
		private readonly string _originalMessage;
	}
}
