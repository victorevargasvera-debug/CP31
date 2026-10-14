using System;
using System.Data.Entity.Utilities;
using System.Runtime.Serialization;

namespace System.Data.Entity.Core
{
	// Token: 0x020002DE RID: 734
	[global::System.Serializable]
	public sealed class PropertyConstraintException : global::System.Data.ConstraintException
	{
		// Token: 0x0600233A RID: 9018 RVA: 0x0006277A File Offset: 0x0006097A
		public PropertyConstraintException()
		{
		}

		// Token: 0x0600233B RID: 9019 RVA: 0x00062782 File Offset: 0x00060982
		public PropertyConstraintException(string message) : base(message)
		{
		}

		// Token: 0x0600233C RID: 9020 RVA: 0x0006278B File Offset: 0x0006098B
		public PropertyConstraintException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x0600233D RID: 9021 RVA: 0x00062795 File Offset: 0x00060995
		public PropertyConstraintException(string message, string propertyName) : base(message)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(propertyName, "propertyName");
			this.PropertyName = propertyName;
		}

		// Token: 0x0600233E RID: 9022 RVA: 0x000627B1 File Offset: 0x000609B1
		public PropertyConstraintException(string message, string propertyName, global::System.Exception innerException) : base(message, innerException)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(propertyName, "propertyName");
			this.PropertyName = propertyName;
		}

		// Token: 0x0600233F RID: 9023 RVA: 0x000627CE File Offset: 0x000609CE
		private PropertyConstraintException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			this.PropertyName = info.GetString("PropertyName");
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x06002340 RID: 9024 RVA: 0x000627E9 File Offset: 0x000609E9
		public string PropertyName { get; }

		// Token: 0x06002341 RID: 9025 RVA: 0x000627F1 File Offset: 0x000609F1
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("PropertyName", this.PropertyName);
		}
	}
}
