using System;

namespace Microsoft.Extensions.Logging
{
	// Token: 0x02000002 RID: 2
	public struct EventId
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public EventId(int id, string name = null)
		{
			this._id = id;
			this._name = name;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00002060 File Offset: 0x00000260
		public int Id
		{
			get
			{
				return this._id;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002068 File Offset: 0x00000268
		public string Name
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002070 File Offset: 0x00000270
		public static implicit operator global::Microsoft.Extensions.Logging.EventId(int i)
		{
			return new global::Microsoft.Extensions.Logging.EventId(i, null);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002079 File Offset: 0x00000279
		public override string ToString()
		{
			if (this._name != null)
			{
				return this._name;
			}
			return this._id.ToString();
		}

		// Token: 0x04000001 RID: 1
		private int _id;

		// Token: 0x04000002 RID: 2
		private string _name;
	}
}
