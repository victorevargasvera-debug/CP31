using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Principal;
using NLog.Common;
using NLog.Internal;

namespace NLog.Targets.Wrappers
{
	// Token: 0x02000066 RID: 102
	[global::System.Security.SecuritySafeCritical]
	[global::NLog.Targets.Target("ImpersonatingWrapper", IsWrapper = true)]
	public class ImpersonatingTargetWrapper : global::NLog.Targets.Wrappers.WrapperTargetBase
	{
		// Token: 0x0600080E RID: 2062 RVA: 0x000148C8 File Offset: 0x00012AC8
		public ImpersonatingTargetWrapper() : this(null)
		{
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x000148D1 File Offset: 0x00012AD1
		public ImpersonatingTargetWrapper(string name, global::NLog.Targets.Target wrappedTarget) : this(wrappedTarget)
		{
			base.Name = name;
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x000148E1 File Offset: 0x00012AE1
		public ImpersonatingTargetWrapper(global::NLog.Targets.Target wrappedTarget)
		{
			this.Domain = ".";
			this.LogOnType = global::NLog.Targets.Wrappers.SecurityLogOnType.Interactive;
			this.LogOnProvider = global::NLog.Targets.Wrappers.LogOnProviderType.Default;
			this.ImpersonationLevel = global::NLog.Targets.Wrappers.SecurityImpersonationLevel.Impersonation;
			base.WrappedTarget = wrappedTarget;
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000811 RID: 2065 RVA: 0x0001491B File Offset: 0x00012B1B
		// (set) Token: 0x06000812 RID: 2066 RVA: 0x00014923 File Offset: 0x00012B23
		public string UserName { get; set; }

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000813 RID: 2067 RVA: 0x0001492C File Offset: 0x00012B2C
		// (set) Token: 0x06000814 RID: 2068 RVA: 0x00014934 File Offset: 0x00012B34
		public string Password { get; set; }

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000815 RID: 2069 RVA: 0x0001493D File Offset: 0x00012B3D
		// (set) Token: 0x06000816 RID: 2070 RVA: 0x00014945 File Offset: 0x00012B45
		[global::System.ComponentModel.DefaultValue(".")]
		public string Domain { get; set; }

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000817 RID: 2071 RVA: 0x0001494E File Offset: 0x00012B4E
		// (set) Token: 0x06000818 RID: 2072 RVA: 0x00014956 File Offset: 0x00012B56
		public global::NLog.Targets.Wrappers.SecurityLogOnType LogOnType { get; set; }

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000819 RID: 2073 RVA: 0x0001495F File Offset: 0x00012B5F
		// (set) Token: 0x0600081A RID: 2074 RVA: 0x00014967 File Offset: 0x00012B67
		public global::NLog.Targets.Wrappers.LogOnProviderType LogOnProvider { get; set; }

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x0600081B RID: 2075 RVA: 0x00014970 File Offset: 0x00012B70
		// (set) Token: 0x0600081C RID: 2076 RVA: 0x00014978 File Offset: 0x00012B78
		public global::NLog.Targets.Wrappers.SecurityImpersonationLevel ImpersonationLevel { get; set; }

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x0600081D RID: 2077 RVA: 0x00014981 File Offset: 0x00012B81
		// (set) Token: 0x0600081E RID: 2078 RVA: 0x00014989 File Offset: 0x00012B89
		[global::System.ComponentModel.DefaultValue(false)]
		public bool RevertToSelf { get; set; }

		// Token: 0x0600081F RID: 2079 RVA: 0x00014994 File Offset: 0x00012B94
		protected override void InitializeTarget()
		{
			if (!this.RevertToSelf)
			{
				this.newIdentity = this.CreateWindowsIdentity(out this.duplicateTokenHandle);
			}
			using (this.DoImpersonate())
			{
				base.InitializeTarget();
			}
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x000149E4 File Offset: 0x00012BE4
		protected override void CloseTarget()
		{
			using (this.DoImpersonate())
			{
				base.CloseTarget();
			}
			if (this.duplicateTokenHandle != global::System.IntPtr.Zero)
			{
				global::NLog.Internal.NativeMethods.CloseHandle(this.duplicateTokenHandle);
				this.duplicateTokenHandle = global::System.IntPtr.Zero;
			}
			if (this.newIdentity != null)
			{
				this.newIdentity.Dispose();
				this.newIdentity = null;
			}
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x00014A60 File Offset: 0x00012C60
		protected override void Write(global::NLog.Common.AsyncLogEventInfo logEvent)
		{
			using (this.DoImpersonate())
			{
				base.WrappedTarget.WriteAsyncLogEvent(logEvent);
			}
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x00014A9C File Offset: 0x00012C9C
		[global::System.Obsolete("Instead override Write(IList<AsyncLogEventInfo> logEvents. Marked obsolete on NLog 4.5")]
		protected override void Write(global::NLog.Common.AsyncLogEventInfo[] logEvents)
		{
			this.Write(logEvents);
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x00014AA8 File Offset: 0x00012CA8
		protected override void Write(global::System.Collections.Generic.IList<global::NLog.Common.AsyncLogEventInfo> logEvents)
		{
			using (this.DoImpersonate())
			{
				base.WrappedTarget.WriteAsyncLogEvents(logEvents);
			}
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x00014AE4 File Offset: 0x00012CE4
		protected override void FlushAsync(global::NLog.Common.AsyncContinuation asyncContinuation)
		{
			using (this.DoImpersonate())
			{
				base.WrappedTarget.Flush(asyncContinuation);
			}
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x00014B20 File Offset: 0x00012D20
		private global::System.IDisposable DoImpersonate()
		{
			if (this.RevertToSelf)
			{
				return new global::NLog.Targets.Wrappers.ImpersonatingTargetWrapper.ContextReverter(global::System.Security.Principal.WindowsIdentity.Impersonate(global::System.IntPtr.Zero));
			}
			return new global::NLog.Targets.Wrappers.ImpersonatingTargetWrapper.ContextReverter(this.newIdentity.Impersonate());
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x00014B4C File Offset: 0x00012D4C
		private global::System.Security.Principal.WindowsIdentity CreateWindowsIdentity(out global::System.IntPtr handle)
		{
			global::System.IntPtr intPtr;
			if (!global::NLog.Internal.NativeMethods.LogonUser(this.UserName, this.Domain, this.Password, (int)this.LogOnType, (int)this.LogOnProvider, out intPtr))
			{
				throw global::System.Runtime.InteropServices.Marshal.GetExceptionForHR(global::System.Runtime.InteropServices.Marshal.GetHRForLastWin32Error());
			}
			if (!global::NLog.Internal.NativeMethods.DuplicateToken(intPtr, (int)this.ImpersonationLevel, out handle))
			{
				global::NLog.Internal.NativeMethods.CloseHandle(intPtr);
				throw global::System.Runtime.InteropServices.Marshal.GetExceptionForHR(global::System.Runtime.InteropServices.Marshal.GetHRForLastWin32Error());
			}
			global::NLog.Internal.NativeMethods.CloseHandle(intPtr);
			return new global::System.Security.Principal.WindowsIdentity(handle);
		}

		// Token: 0x040001D0 RID: 464
		private global::System.Security.Principal.WindowsIdentity newIdentity;

		// Token: 0x040001D1 RID: 465
		private global::System.IntPtr duplicateTokenHandle = global::System.IntPtr.Zero;

		// Token: 0x020001E9 RID: 489
		internal class ContextReverter : global::System.IDisposable
		{
			// Token: 0x0600125F RID: 4703 RVA: 0x0002FF23 File Offset: 0x0002E123
			public ContextReverter(global::System.Security.Principal.WindowsImpersonationContext windowsImpersonationContext)
			{
				this.wic = windowsImpersonationContext;
			}

			// Token: 0x06001260 RID: 4704 RVA: 0x0002FF32 File Offset: 0x0002E132
			public void Dispose()
			{
				this.wic.Undo();
			}

			// Token: 0x04000573 RID: 1395
			private readonly global::System.Security.Principal.WindowsImpersonationContext wic;
		}
	}
}
