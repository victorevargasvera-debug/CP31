using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Runtime.Serialization;

namespace System.Data.Entity.Core
{
	// Token: 0x020002DD RID: 733
	[global::System.Serializable]
	public sealed class OptimisticConcurrencyException : global::System.Data.Entity.Core.UpdateException
	{
		// Token: 0x06002335 RID: 9013 RVA: 0x0006274A File Offset: 0x0006094A
		public OptimisticConcurrencyException()
		{
		}

		// Token: 0x06002336 RID: 9014 RVA: 0x00062752 File Offset: 0x00060952
		public OptimisticConcurrencyException(string message) : base(message)
		{
		}

		// Token: 0x06002337 RID: 9015 RVA: 0x0006275B File Offset: 0x0006095B
		public OptimisticConcurrencyException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x06002338 RID: 9016 RVA: 0x00062765 File Offset: 0x00060965
		public OptimisticConcurrencyException(string message, global::System.Exception innerException, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Objects.ObjectStateEntry> stateEntries) : base(message, innerException, stateEntries)
		{
		}

		// Token: 0x06002339 RID: 9017 RVA: 0x00062770 File Offset: 0x00060970
		private OptimisticConcurrencyException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
