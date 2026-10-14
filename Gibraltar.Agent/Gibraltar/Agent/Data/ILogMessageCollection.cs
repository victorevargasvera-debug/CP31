using System;
using System.Collections;
using System.Collections.Generic;

namespace Gibraltar.Agent.Data
{
	// Token: 0x0200003E RID: 62
	public interface ILogMessageCollection : global::System.Collections.Generic.IList<global::Gibraltar.Agent.Data.ILogMessage>, global::System.Collections.Generic.ICollection<global::Gibraltar.Agent.Data.ILogMessage>, global::System.Collections.Generic.IEnumerable<global::Gibraltar.Agent.Data.ILogMessage>, global::System.Collections.IEnumerable
	{
		// Token: 0x06000379 RID: 889
		[global::System.Obsolete("Not a valid operation.  This is a read-only collection.", true)]
		void Clear();

		// Token: 0x0600037A RID: 890
		[global::System.Obsolete("Not a valid operation.  This is a read-only collection.", true)]
		void Add(global::Gibraltar.Agent.Data.ILogMessage item);

		// Token: 0x0600037B RID: 891
		[global::System.Obsolete("Not a valid operation.  This is a read-only collection.", true)]
		void Remove(global::Gibraltar.Agent.Data.ILogMessage item);

		// Token: 0x0600037C RID: 892
		[global::System.Obsolete("Not a valid operation.  This is a read-only collection.", true)]
		void Insert(int index, global::Gibraltar.Agent.Data.ILogMessage item);

		// Token: 0x0600037D RID: 893
		[global::System.Obsolete("Not a valid operation.  This is a read-only collection.", true)]
		void RemoveAt(int index);
	}
}
