using System;

namespace Autofac.Core
{
	// Token: 0x0200007A RID: 122
	public sealed class TypedService : global::Autofac.Core.Service, global::Autofac.Core.IServiceWithType, global::System.IEquatable<global::Autofac.Core.TypedService>
	{
		// Token: 0x060002BB RID: 699 RVA: 0x00008CF9 File Offset: 0x00006EF9
		public TypedService(global::System.Type serviceType)
		{
			if (serviceType == null)
			{
				throw new global::System.ArgumentNullException("serviceType");
			}
			this.ServiceType = serviceType;
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060002BC RID: 700 RVA: 0x00008D1C File Offset: 0x00006F1C
		public global::System.Type ServiceType { get; }

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060002BD RID: 701 RVA: 0x00008D24 File Offset: 0x00006F24
		public override string Description
		{
			get
			{
				return this.ServiceType.FullName;
			}
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00008D31 File Offset: 0x00006F31
		public bool Equals(global::Autofac.Core.TypedService other)
		{
			return !(other == null) && this.ServiceType == other.ServiceType;
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00008D4F File Offset: 0x00006F4F
		public override bool Equals(object obj)
		{
			return this.Equals(obj as global::Autofac.Core.TypedService);
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00008D5D File Offset: 0x00006F5D
		public override int GetHashCode()
		{
			return this.ServiceType.GetHashCode();
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00008D6A File Offset: 0x00006F6A
		public global::Autofac.Core.Service ChangeType(global::System.Type newType)
		{
			if (newType == null)
			{
				throw new global::System.ArgumentNullException("newType");
			}
			return new global::Autofac.Core.TypedService(newType);
		}
	}
}
