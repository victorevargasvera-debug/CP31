using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Objects;
using System.Runtime.Serialization;

namespace System.Data.Entity.Core
{
	// Token: 0x020002E0 RID: 736
	[global::System.Serializable]
	public class UpdateException : global::System.Data.DataException
	{
		// Token: 0x06002346 RID: 9030 RVA: 0x00062831 File Offset: 0x00060A31
		public UpdateException()
		{
		}

		// Token: 0x06002347 RID: 9031 RVA: 0x00062839 File Offset: 0x00060A39
		public UpdateException(string message) : base(message)
		{
		}

		// Token: 0x06002348 RID: 9032 RVA: 0x00062842 File Offset: 0x00060A42
		public UpdateException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x06002349 RID: 9033 RVA: 0x0006284C File Offset: 0x00060A4C
		public UpdateException(string message, global::System.Exception innerException, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Objects.ObjectStateEntry> stateEntries) : base(message, innerException)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.ObjectStateEntry> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.ObjectStateEntry>(stateEntries);
			this._stateEntries = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Objects.ObjectStateEntry>(list);
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x0600234A RID: 9034 RVA: 0x00062874 File Offset: 0x00060A74
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Objects.ObjectStateEntry> StateEntries
		{
			get
			{
				return this._stateEntries;
			}
		}

		// Token: 0x0600234B RID: 9035 RVA: 0x0006287C File Offset: 0x00060A7C
		protected UpdateException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x04000C0E RID: 3086
		[global::System.NonSerialized]
		private readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Objects.ObjectStateEntry> _stateEntries;
	}
}
