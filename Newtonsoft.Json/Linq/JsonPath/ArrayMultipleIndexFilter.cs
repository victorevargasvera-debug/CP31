using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000CF RID: 207
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	internal class ArrayMultipleIndexFilter : global::Newtonsoft.Json.Linq.JsonPath.PathFilter
	{
		// Token: 0x06000BE0 RID: 3040 RVA: 0x0002F028 File Offset: 0x0002D228
		public ArrayMultipleIndexFilter(global::System.Collections.Generic.List<int> indexes)
		{
			this.Indexes = indexes;
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x0002F037 File Offset: 0x0002D237
		public override global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken> ExecuteFilter(global::Newtonsoft.Json.Linq.JToken root, global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken> current, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Linq.JsonSelectSettings settings)
		{
			foreach (global::Newtonsoft.Json.Linq.JToken t in current)
			{
				foreach (int index in this.Indexes)
				{
					global::Newtonsoft.Json.Linq.JToken tokenIndex = global::Newtonsoft.Json.Linq.JsonPath.PathFilter.GetTokenIndex(t, settings, index);
					if (tokenIndex != null)
					{
						yield return tokenIndex;
					}
				}
				global::System.Collections.Generic.List<int>.Enumerator enumerator2 = default(global::System.Collections.Generic.List<int>.Enumerator);
				t = null;
			}
			global::System.Collections.Generic.IEnumerator<global::Newtonsoft.Json.Linq.JToken> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x040003AF RID: 943
		internal global::System.Collections.Generic.List<int> Indexes;
	}
}
