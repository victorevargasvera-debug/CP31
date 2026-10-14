using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace System.Data.Entity.Core.Common.Utils
{
	// Token: 0x020005F1 RID: 1521
	internal sealed class AliasGenerator
	{
		// Token: 0x06004A9A RID: 19098 RVA: 0x001077A4 File Offset: 0x001059A4
		internal AliasGenerator(string prefix) : this(prefix, 250)
		{
		}

		// Token: 0x06004A9B RID: 19099 RVA: 0x001077B4 File Offset: 0x001059B4
		internal AliasGenerator(string prefix, int cacheSize)
		{
			this._prefix = (prefix ?? string.Empty);
			if (0 < cacheSize)
			{
				string[] array = null;
				global::System.Collections.Generic.Dictionary<string, string[]> prefixCounter;
				while ((prefixCounter = global::System.Data.Entity.Core.Common.Utils.AliasGenerator._prefixCounter) == null || !prefixCounter.TryGetValue(prefix, out this._cache))
				{
					if (array == null)
					{
						array = new string[cacheSize];
					}
					int num = 1 + ((prefixCounter != null) ? prefixCounter.Count : 0);
					global::System.Collections.Generic.Dictionary<string, string[]> dictionary = new global::System.Collections.Generic.Dictionary<string, string[]>(num, global::System.StringComparer.InvariantCultureIgnoreCase);
					if (prefixCounter != null && num < 500)
					{
						foreach (global::System.Collections.Generic.KeyValuePair<string, string[]> keyValuePair in prefixCounter)
						{
							dictionary.Add(keyValuePair.Key, keyValuePair.Value);
						}
					}
					dictionary.Add(prefix, array);
					global::System.Threading.Interlocked.CompareExchange<global::System.Collections.Generic.Dictionary<string, string[]>>(ref global::System.Data.Entity.Core.Common.Utils.AliasGenerator._prefixCounter, dictionary, prefixCounter);
				}
			}
		}

		// Token: 0x06004A9C RID: 19100 RVA: 0x00107898 File Offset: 0x00105A98
		internal string Next()
		{
			this._counter = global::System.Math.Max(1 + this._counter, 0);
			return this.GetName(this._counter);
		}

		// Token: 0x06004A9D RID: 19101 RVA: 0x001078BC File Offset: 0x00105ABC
		internal string GetName(int index)
		{
			string text;
			if (this._cache == null || this._cache.Length <= index)
			{
				text = this._prefix + index.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
			}
			else if ((text = this._cache[index]) == null)
			{
				if (global::System.Data.Entity.Core.Common.Utils.AliasGenerator._counterNames.Length <= index)
				{
					text = index.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
				}
				else if ((text = global::System.Data.Entity.Core.Common.Utils.AliasGenerator._counterNames[index]) == null)
				{
					text = (global::System.Data.Entity.Core.Common.Utils.AliasGenerator._counterNames[index] = index.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
				}
				text = (this._cache[index] = this._prefix + text);
			}
			return text;
		}

		// Token: 0x04001A3B RID: 6715
		private const int MaxPrefixCount = 500;

		// Token: 0x04001A3C RID: 6716
		private const int CacheSize = 250;

		// Token: 0x04001A3D RID: 6717
		private static readonly string[] _counterNames = new string[250];

		// Token: 0x04001A3E RID: 6718
		private static global::System.Collections.Generic.Dictionary<string, string[]> _prefixCounter;

		// Token: 0x04001A3F RID: 6719
		private int _counter;

		// Token: 0x04001A40 RID: 6720
		private readonly string _prefix;

		// Token: 0x04001A41 RID: 6721
		private readonly string[] _cache;
	}
}
