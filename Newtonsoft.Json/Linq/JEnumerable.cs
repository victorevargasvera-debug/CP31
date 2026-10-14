using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000BC RID: 188
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public readonly struct JEnumerable<[global::System.Runtime.CompilerServices.Nullable(0)] T> : global::Newtonsoft.Json.Linq.IJEnumerable<T>, global::System.Collections.Generic.IEnumerable<T>, global::System.Collections.IEnumerable, global::System.IEquatable<global::Newtonsoft.Json.Linq.JEnumerable<T>> where T : global::Newtonsoft.Json.Linq.JToken
	{
		// Token: 0x06000A20 RID: 2592 RVA: 0x00029664 File Offset: 0x00027864
		public JEnumerable(global::System.Collections.Generic.IEnumerable<T> enumerable)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(enumerable, "enumerable");
			this._enumerable = enumerable;
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x00029678 File Offset: 0x00027878
		public global::System.Collections.Generic.IEnumerator<T> GetEnumerator()
		{
			return (this._enumerable ?? global::Newtonsoft.Json.Linq.JEnumerable<T>.Empty).GetEnumerator();
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x00029693 File Offset: 0x00027893
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x170001D9 RID: 473
		public global::Newtonsoft.Json.Linq.IJEnumerable<global::Newtonsoft.Json.Linq.JToken> this[object key]
		{
			get
			{
				if (this._enumerable == null)
				{
					return global::Newtonsoft.Json.Linq.JEnumerable<global::Newtonsoft.Json.Linq.JToken>.Empty;
				}
				return new global::Newtonsoft.Json.Linq.JEnumerable<global::Newtonsoft.Json.Linq.JToken>(this._enumerable.Values(key));
			}
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x000296C6 File Offset: 0x000278C6
		public bool Equals([global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			0,
			1
		})] global::Newtonsoft.Json.Linq.JEnumerable<T> other)
		{
			return object.Equals(this._enumerable, other._enumerable);
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x000296DC File Offset: 0x000278DC
		public override bool Equals(object obj)
		{
			if (obj is global::Newtonsoft.Json.Linq.JEnumerable<T>)
			{
				global::Newtonsoft.Json.Linq.JEnumerable<T> other = (global::Newtonsoft.Json.Linq.JEnumerable<T>)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x00029701 File Offset: 0x00027901
		public override int GetHashCode()
		{
			if (this._enumerable == null)
			{
				return 0;
			}
			return this._enumerable.GetHashCode();
		}

		// Token: 0x04000366 RID: 870
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			0,
			1
		})]
		public static readonly global::Newtonsoft.Json.Linq.JEnumerable<T> Empty = new global::Newtonsoft.Json.Linq.JEnumerable<T>(global::System.Linq.Enumerable.Empty<T>());

		// Token: 0x04000367 RID: 871
		private readonly global::System.Collections.Generic.IEnumerable<T> _enumerable;
	}
}
