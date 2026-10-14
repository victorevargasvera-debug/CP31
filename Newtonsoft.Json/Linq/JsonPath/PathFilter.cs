using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000D4 RID: 212
	[global::System.Runtime.CompilerServices.NullableContext(2)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	internal abstract class PathFilter
	{
		// Token: 0x06000C06 RID: 3078
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		public abstract global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken> ExecuteFilter(global::Newtonsoft.Json.Linq.JToken root, global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken> current, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Linq.JsonSelectSettings settings);

		// Token: 0x06000C07 RID: 3079 RVA: 0x00030298 File Offset: 0x0002E498
		protected static global::Newtonsoft.Json.Linq.JToken GetTokenIndex([global::System.Runtime.CompilerServices.Nullable(1)] global::Newtonsoft.Json.Linq.JToken t, global::Newtonsoft.Json.Linq.JsonSelectSettings settings, int index)
		{
			global::Newtonsoft.Json.Linq.JArray jarray = t as global::Newtonsoft.Json.Linq.JArray;
			if (jarray != null)
			{
				if (jarray.Count > index)
				{
					return jarray[index];
				}
				if (settings != null && settings.ErrorWhenNoMatch)
				{
					throw new global::Newtonsoft.Json.JsonException("Index {0} outside the bounds of JArray.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, index));
				}
				return null;
			}
			else
			{
				global::Newtonsoft.Json.Linq.JConstructor jconstructor = t as global::Newtonsoft.Json.Linq.JConstructor;
				if (jconstructor != null)
				{
					if (jconstructor.Count > index)
					{
						return jconstructor[index];
					}
					if (settings != null && settings.ErrorWhenNoMatch)
					{
						throw new global::Newtonsoft.Json.JsonException("Index {0} outside the bounds of JConstructor.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, index));
					}
					return null;
				}
				else
				{
					if (settings != null && settings.ErrorWhenNoMatch)
					{
						throw new global::Newtonsoft.Json.JsonException("Index {0} not valid on {1}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, index, t.GetType().Name));
					}
					return null;
				}
			}
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x00030364 File Offset: 0x0002E564
		protected static global::Newtonsoft.Json.Linq.JToken GetNextScanValue([global::System.Runtime.CompilerServices.Nullable(1)] global::Newtonsoft.Json.Linq.JToken originalParent, global::Newtonsoft.Json.Linq.JToken container, global::Newtonsoft.Json.Linq.JToken value)
		{
			if (container != null && container.HasValues)
			{
				value = container.First;
			}
			else
			{
				while (value != null && value != originalParent && value == value.Parent.Last)
				{
					value = value.Parent;
				}
				if (value == null || value == originalParent)
				{
					return null;
				}
				value = value.Next;
			}
			return value;
		}
	}
}
