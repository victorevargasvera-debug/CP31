using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Gibraltar.Agent.Data;

namespace Gibraltar.Agent.Internal
{
	// Token: 0x02000036 RID: 54
	internal class LogMessageInfoCollection : global::System.Collections.ObjectModel.ReadOnlyCollection<global::Gibraltar.Agent.Data.ILogMessage>, global::Gibraltar.Agent.Data.ILogMessageCollection, global::System.Collections.Generic.IList<global::Gibraltar.Agent.Data.ILogMessage>, global::System.Collections.Generic.ICollection<global::Gibraltar.Agent.Data.ILogMessage>, global::System.Collections.Generic.IEnumerable<global::Gibraltar.Agent.Data.ILogMessage>, global::System.Collections.IEnumerable
	{
		// Token: 0x06000316 RID: 790 RVA: 0x0000AAD0 File Offset: 0x00008CD0
		internal LogMessageInfoCollection(global::System.Collections.Generic.IList<global::Gibraltar.Agent.Data.ILogMessage> messages) : base(messages)
		{
		}

		// Token: 0x06000317 RID: 791 RVA: 0x0000AADC File Offset: 0x00008CDC
		[global::System.Obsolete("Not a valid operation.  This is a read-only collection.", true)]
		public void Clear()
		{
			((global::System.Collections.Generic.ICollection<global::Gibraltar.Agent.Data.ILogMessage>)this).Clear();
		}

		// Token: 0x06000318 RID: 792 RVA: 0x0000AAE4 File Offset: 0x00008CE4
		[global::System.Obsolete("Not a valid operation.  This is a read-only collection.", true)]
		public void Add(global::Gibraltar.Agent.Data.ILogMessage item)
		{
			((global::System.Collections.Generic.ICollection<global::Gibraltar.Agent.Data.ILogMessage>)this).Add(item);
		}

		// Token: 0x06000319 RID: 793 RVA: 0x0000AAF0 File Offset: 0x00008CF0
		[global::System.Obsolete("Not a valid operation.  This is a read-only collection.", true)]
		public void Remove(global::Gibraltar.Agent.Data.ILogMessage item)
		{
			((global::System.Collections.Generic.ICollection<global::Gibraltar.Agent.Data.ILogMessage>)this).Remove(item);
		}

		// Token: 0x0600031A RID: 794 RVA: 0x0000AAFC File Offset: 0x00008CFC
		[global::System.Obsolete("Not a valid operation.  This is a read-only collection.", true)]
		public void Insert(int index, global::Gibraltar.Agent.Data.ILogMessage item)
		{
			((global::System.Collections.Generic.IList<global::Gibraltar.Agent.Data.ILogMessage>)this).Insert(index, item);
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0000AB08 File Offset: 0x00008D08
		[global::System.Obsolete("Not a valid operation.  This is a read-only collection.", true)]
		public void RemoveAt(int index)
		{
			((global::System.Collections.Generic.IList<global::Gibraltar.Agent.Data.ILogMessage>)this).RemoveAt(index);
		}
	}
}
