using System;
using System.ComponentModel;

namespace DevAge.ComponentModel
{
	// Token: 0x020002A0 RID: 672
	internal class EmptyContainer : global::System.ComponentModel.IContainer, global::System.IDisposable
	{
		// Token: 0x060021AA RID: 8618 RVA: 0x00077CA8 File Offset: 0x00075EA8
		public void Add(global::System.ComponentModel.IComponent component, string name)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060021AB RID: 8619 RVA: 0x00077CB0 File Offset: 0x00075EB0
		public void Add(global::System.ComponentModel.IComponent component)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x060021AC RID: 8620 RVA: 0x00077CB8 File Offset: 0x00075EB8
		public global::System.ComponentModel.ComponentCollection Components
		{
			get
			{
				return new global::System.ComponentModel.ComponentCollection(null);
			}
		}

		// Token: 0x060021AD RID: 8621 RVA: 0x00077CC0 File Offset: 0x00075EC0
		public void Remove(global::System.ComponentModel.IComponent component)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060021AE RID: 8622 RVA: 0x00077CC8 File Offset: 0x00075EC8
		public void Dispose()
		{
		}
	}
}
