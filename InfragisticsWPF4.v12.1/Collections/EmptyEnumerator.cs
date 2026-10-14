using System;
using System.Collections;

namespace Infragistics.Collections
{
	// Token: 0x02000080 RID: 128
	public sealed class EmptyEnumerator : global::System.Collections.IEnumerator
	{
		// Token: 0x06000520 RID: 1312 RVA: 0x00013A11 File Offset: 0x00011C11
		private EmptyEnumerator()
		{
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000521 RID: 1313 RVA: 0x00013A19 File Offset: 0x00011C19
		object global::System.Collections.IEnumerator.Current
		{
			get
			{
				throw new global::System.InvalidOperationException(global::SR.GetString("LE_InvalidOperationException_4"));
			}
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00013A2A File Offset: 0x00011C2A
		bool global::System.Collections.IEnumerator.MoveNext()
		{
			return false;
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x00013A2D File Offset: 0x00011C2D
		void global::System.Collections.IEnumerator.Reset()
		{
		}

		// Token: 0x040001B3 RID: 435
		public static readonly global::Infragistics.Collections.EmptyEnumerator Instance = new global::Infragistics.Collections.EmptyEnumerator();
	}
}
