using System;
using System.Collections;

namespace Org.BouncyCastle.Utilities.Collections
{
	// Token: 0x0200006C RID: 108
	public sealed class EmptyEnumerable : global::System.Collections.IEnumerable
	{
		// Token: 0x0600044B RID: 1099 RVA: 0x00015D76 File Offset: 0x00013F76
		private EmptyEnumerable()
		{
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00015D7E File Offset: 0x00013F7E
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return global::Org.BouncyCastle.Utilities.Collections.EmptyEnumerator.Instance;
		}

		// Token: 0x0400029D RID: 669
		public static readonly global::System.Collections.IEnumerable Instance = new global::Org.BouncyCastle.Utilities.Collections.EmptyEnumerable();
	}
}
