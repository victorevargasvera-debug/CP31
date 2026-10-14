using System;
using System.Security.Principal;
using Gibraltar.Agent.Data;
using Gibraltar.Agent.Internal;
using Gibraltar.Monitor;

namespace Gibraltar.Agent
{
	// Token: 0x02000003 RID: 3
	public class ApplicationUserResolutionEventArgs : global::System.EventArgs
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002048 File Offset: 0x00000248
		internal ApplicationUserResolutionEventArgs(global::Gibraltar.Monitor.ResolveUserEventArgs wrappedEventArgs)
		{
			this.m_WrappedEventArgs = wrappedEventArgs;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00002058 File Offset: 0x00000258
		public string UserName
		{
			get
			{
				return this.m_WrappedEventArgs.UserName;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002068 File Offset: 0x00000268
		public global::System.Security.Principal.IPrincipal Principal
		{
			get
			{
				return this.m_WrappedEventArgs.Principal;
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002078 File Offset: 0x00000278
		public global::Gibraltar.Agent.Data.IApplicationUser GetUser()
		{
			if (this.m_ApplicationUser == null)
			{
				this.m_ApplicationUser = new global::Gibraltar.Agent.Internal.ApplicationUser(this.m_WrappedEventArgs.GetUser());
			}
			return this.m_ApplicationUser;
		}

		// Token: 0x04000007 RID: 7
		private readonly global::Gibraltar.Monitor.ResolveUserEventArgs m_WrappedEventArgs;

		// Token: 0x04000008 RID: 8
		private global::Gibraltar.Agent.Data.IApplicationUser m_ApplicationUser;
	}
}
