using System;
using System.Runtime.Serialization;

namespace System.Data.Entity.Migrations.Design
{
	// Token: 0x020000E6 RID: 230
	[global::System.Obsolete("Use System.Data.Entity.Infrastructure.Design.IErrorHandler instead.")]
	[global::System.Serializable]
	public class ToolingException : global::System.Exception
	{
		// Token: 0x0600115C RID: 4444 RVA: 0x00029BE9 File Offset: 0x00027DE9
		public ToolingException()
		{
			this.SubscribeToSerializeObjectState();
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x00029BF7 File Offset: 0x00027DF7
		public ToolingException(string message) : base(message)
		{
			this.SubscribeToSerializeObjectState();
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x00029C06 File Offset: 0x00027E06
		public ToolingException(string message, string innerType, string innerStackTrace) : base(message)
		{
			this._state.InnerType = innerType;
			this._state.InnerStackTrace = innerStackTrace;
			this.SubscribeToSerializeObjectState();
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x00029C2D File Offset: 0x00027E2D
		public ToolingException(string message, global::System.Exception innerException) : base(message, innerException)
		{
			this.SubscribeToSerializeObjectState();
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06001160 RID: 4448 RVA: 0x00029C3D File Offset: 0x00027E3D
		public string InnerType
		{
			get
			{
				return this._state.InnerType;
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06001161 RID: 4449 RVA: 0x00029C4A File Offset: 0x00027E4A
		public string InnerStackTrace
		{
			get
			{
				return this._state.InnerStackTrace;
			}
		}

		// Token: 0x06001162 RID: 4450 RVA: 0x00029C57 File Offset: 0x00027E57
		private void SubscribeToSerializeObjectState()
		{
			base.SerializeObjectState += delegate(object _, global::System.Runtime.Serialization.SafeSerializationEventArgs a)
			{
				a.AddSerializedState(this._state);
			};
		}

		// Token: 0x040008E0 RID: 2272
		[global::System.NonSerialized]
		private global::System.Data.Entity.Migrations.Design.ToolingException.ToolingExceptionState _state;

		// Token: 0x020007CC RID: 1996
		[global::System.Serializable]
		private struct ToolingExceptionState : global::System.Runtime.Serialization.ISafeSerializationData
		{
			// Token: 0x1700104B RID: 4171
			// (get) Token: 0x06005881 RID: 22657 RVA: 0x00138665 File Offset: 0x00136865
			// (set) Token: 0x06005882 RID: 22658 RVA: 0x0013866D File Offset: 0x0013686D
			public string InnerType { get; set; }

			// Token: 0x1700104C RID: 4172
			// (get) Token: 0x06005883 RID: 22659 RVA: 0x00138676 File Offset: 0x00136876
			// (set) Token: 0x06005884 RID: 22660 RVA: 0x0013867E File Offset: 0x0013687E
			public string InnerStackTrace { get; set; }

			// Token: 0x06005885 RID: 22661 RVA: 0x00138687 File Offset: 0x00136887
			public void CompleteDeserialization(object deserialized)
			{
				((global::System.Data.Entity.Migrations.Design.ToolingException)deserialized)._state = this;
			}
		}
	}
}
