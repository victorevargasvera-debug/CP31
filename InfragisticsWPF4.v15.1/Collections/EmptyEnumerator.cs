using System;
using System.Collections;

namespace Infragistics.Collections
{
	// Token: 0x02000097 RID: 151
	public sealed class EmptyEnumerator : global::System.Collections.IEnumerator
	{
		// Token: 0x060005E3 RID: 1507 RVA: 0x00016471 File Offset: 0x00014671
		private EmptyEnumerator()
		{
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060005E4 RID: 1508 RVA: 0x00016479 File Offset: 0x00014679
		object global::System.Collections.IEnumerator.Current
		{
			get
			{
				throw new global::System.InvalidOperationException(global::SR.GetString("LE_InvalidOperationException_4"));
			}
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x0001648A File Offset: 0x0001468A
		bool global::System.Collections.IEnumerator.MoveNext()
		{
			return false;
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x0001648D File Offset: 0x0001468D
		void global::System.Collections.IEnumerator.Reset()
		{
		}

		// Token: 0x04000229 RID: 553
		public static readonly global::Infragistics.Collections.EmptyEnumerator Instance = new global::Infragistics.Collections.EmptyEnumerator();
	}
}
