using System;

namespace Autofac.Core
{
	// Token: 0x02000072 RID: 114
	public sealed class KeyedService : global::Autofac.Core.Service, global::Autofac.Core.IServiceWithType, global::System.IEquatable<global::Autofac.Core.KeyedService>
	{
		// Token: 0x06000295 RID: 661 RVA: 0x00008912 File Offset: 0x00006B12
		public KeyedService(object serviceKey, global::System.Type serviceType)
		{
			if (serviceKey == null)
			{
				throw new global::System.ArgumentNullException("serviceKey");
			}
			if (serviceType == null)
			{
				throw new global::System.ArgumentNullException("serviceType");
			}
			this.ServiceKey = serviceKey;
			this.ServiceType = serviceType;
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000296 RID: 662 RVA: 0x0000894A File Offset: 0x00006B4A
		public object ServiceKey { get; }

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000297 RID: 663 RVA: 0x00008952 File Offset: 0x00006B52
		public global::System.Type ServiceType { get; }

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000298 RID: 664 RVA: 0x0000895A File Offset: 0x00006B5A
		public override string Description
		{
			get
			{
				return string.Concat(new object[]
				{
					this.ServiceKey,
					" (",
					this.ServiceType.FullName,
					")"
				});
			}
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0000898E File Offset: 0x00006B8E
		public bool Equals(global::Autofac.Core.KeyedService other)
		{
			return !(other == null) && this.ServiceKey.Equals(other.ServiceKey) && this.ServiceType == other.ServiceType;
		}

		// Token: 0x0600029A RID: 666 RVA: 0x000089C1 File Offset: 0x00006BC1
		public override bool Equals(object obj)
		{
			return this.Equals(obj as global::Autofac.Core.KeyedService);
		}

		// Token: 0x0600029B RID: 667 RVA: 0x000089CF File Offset: 0x00006BCF
		public override int GetHashCode()
		{
			return this.ServiceKey.GetHashCode() ^ this.ServiceType.GetHashCode();
		}

		// Token: 0x0600029C RID: 668 RVA: 0x000089E8 File Offset: 0x00006BE8
		public global::Autofac.Core.Service ChangeType(global::System.Type newType)
		{
			if (newType == null)
			{
				throw new global::System.ArgumentNullException("newType");
			}
			return new global::Autofac.Core.KeyedService(this.ServiceKey, newType);
		}
	}
}
