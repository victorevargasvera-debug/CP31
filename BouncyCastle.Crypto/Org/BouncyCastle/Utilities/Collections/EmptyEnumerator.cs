using System;
using System.Collections;

namespace Org.BouncyCastle.Utilities.Collections
{
	// Token: 0x0200006D RID: 109
	public sealed class EmptyEnumerator : global::System.Collections.IEnumerator
	{
		// Token: 0x0600044E RID: 1102 RVA: 0x00015D91 File Offset: 0x00013F91
		private EmptyEnumerator()
		{
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00015D99 File Offset: 0x00013F99
		public bool MoveNext()
		{
			return false;
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00015D9C File Offset: 0x00013F9C
		public void Reset()
		{
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x00015D9E File Offset: 0x00013F9E
		public object Current
		{
			get
			{
				throw new global::System.InvalidOperationException("No elements");
			}
		}

		// Token: 0x0400029E RID: 670
		public static readonly global::System.Collections.IEnumerator Instance = new global::Org.BouncyCastle.Utilities.Collections.EmptyEnumerator();
	}
}
