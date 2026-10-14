using System;
using System.Collections.Generic;
using Gibraltar.Agent.Data;
using Gibraltar.Monitor;

namespace Gibraltar.Agent.Internal
{
	// Token: 0x02000034 RID: 52
	internal class ApplicationUser : global::Gibraltar.Agent.Data.IApplicationUser
	{
		// Token: 0x060002FF RID: 767 RVA: 0x0000A934 File Offset: 0x00008B34
		internal ApplicationUser(global::Gibraltar.Monitor.ApplicationUser wrappedObject)
		{
			this.m_WrappedObject = wrappedObject;
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000300 RID: 768 RVA: 0x0000A944 File Offset: 0x00008B44
		// (set) Token: 0x06000301 RID: 769 RVA: 0x0000A954 File Offset: 0x00008B54
		public string Key
		{
			get
			{
				return this.m_WrappedObject.Key;
			}
			set
			{
				this.m_WrappedObject.Key = value;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000302 RID: 770 RVA: 0x0000A964 File Offset: 0x00008B64
		public string FullyQualifiedUserName
		{
			get
			{
				return this.m_WrappedObject.FullyQualifiedUserName;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000303 RID: 771 RVA: 0x0000A974 File Offset: 0x00008B74
		// (set) Token: 0x06000304 RID: 772 RVA: 0x0000A984 File Offset: 0x00008B84
		public string Caption
		{
			get
			{
				return this.m_WrappedObject.Caption;
			}
			set
			{
				this.m_WrappedObject.Caption = value;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000305 RID: 773 RVA: 0x0000A994 File Offset: 0x00008B94
		// (set) Token: 0x06000306 RID: 774 RVA: 0x0000A9A4 File Offset: 0x00008BA4
		public string EmailAddress
		{
			get
			{
				return this.m_WrappedObject.EmailAddress;
			}
			set
			{
				this.m_WrappedObject.EmailAddress = value;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000307 RID: 775 RVA: 0x0000A9B4 File Offset: 0x00008BB4
		// (set) Token: 0x06000308 RID: 776 RVA: 0x0000A9C4 File Offset: 0x00008BC4
		public string Phone
		{
			get
			{
				return this.m_WrappedObject.Phone;
			}
			set
			{
				this.m_WrappedObject.Phone = value;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000309 RID: 777 RVA: 0x0000A9D4 File Offset: 0x00008BD4
		// (set) Token: 0x0600030A RID: 778 RVA: 0x0000A9E4 File Offset: 0x00008BE4
		public string Organization
		{
			get
			{
				return this.m_WrappedObject.Organization;
			}
			set
			{
				this.m_WrappedObject.Organization = value;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600030B RID: 779 RVA: 0x0000A9F4 File Offset: 0x00008BF4
		// (set) Token: 0x0600030C RID: 780 RVA: 0x0000AA04 File Offset: 0x00008C04
		public string Role
		{
			get
			{
				return this.m_WrappedObject.Role;
			}
			set
			{
				this.m_WrappedObject.Role = value;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600030D RID: 781 RVA: 0x0000AA14 File Offset: 0x00008C14
		// (set) Token: 0x0600030E RID: 782 RVA: 0x0000AA24 File Offset: 0x00008C24
		public string Tenant
		{
			get
			{
				return this.m_WrappedObject.Tenant;
			}
			set
			{
				this.m_WrappedObject.Tenant = value;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x0600030F RID: 783 RVA: 0x0000AA34 File Offset: 0x00008C34
		public global::System.Collections.Generic.Dictionary<string, string> Properties
		{
			get
			{
				return this.m_WrappedObject.Properties;
			}
		}

		// Token: 0x040000B7 RID: 183
		private readonly global::Gibraltar.Monitor.ApplicationUser m_WrappedObject;
	}
}
