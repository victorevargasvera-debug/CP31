using System;
using System.IO;
using System.Security;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using NLog.Common;

namespace NLog.Internal.FileAppenders
{
	// Token: 0x0200013D RID: 317
	[global::System.Security.SecuritySafeCritical]
	internal abstract class BaseMutexFileAppender : global::NLog.Internal.FileAppenders.BaseFileAppender
	{
		// Token: 0x06000E48 RID: 3656 RVA: 0x000244F1 File Offset: 0x000226F1
		protected BaseMutexFileAppender(string fileName, global::NLog.Internal.FileAppenders.ICreateFileParameters createParameters) : base(fileName, createParameters)
		{
			if (createParameters.IsArchivingEnabled)
			{
				this.ArchiveMutex = this.CreateArchiveMutex();
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000E49 RID: 3657 RVA: 0x0002450F File Offset: 0x0002270F
		// (set) Token: 0x06000E4A RID: 3658 RVA: 0x00024517 File Offset: 0x00022717
		public global::System.Threading.Mutex ArchiveMutex { get; private set; }

		// Token: 0x06000E4B RID: 3659 RVA: 0x00024520 File Offset: 0x00022720
		private global::System.Threading.Mutex CreateArchiveMutex()
		{
			global::System.Threading.Mutex result;
			try
			{
				result = this.CreateSharableMutex("FileArchiveLock");
			}
			catch (global::System.Exception ex)
			{
				if (ex is global::System.Security.SecurityException || ex is global::System.UnauthorizedAccessException || ex is global::System.NotSupportedException || ex is global::System.NotImplementedException || ex is global::System.PlatformNotSupportedException)
				{
					global::NLog.Common.InternalLogger.Warn(ex, "Failed to create global archive mutex: {0}", new object[]
					{
						base.FileName
					});
					result = new global::System.Threading.Mutex();
				}
				else
				{
					global::NLog.Common.InternalLogger.Error(ex, "Failed to create global archive mutex: {0}", new object[]
					{
						base.FileName
					});
					if (ex.MustBeRethrown())
					{
						throw;
					}
					result = new global::System.Threading.Mutex();
				}
			}
			return result;
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x000245C4 File Offset: 0x000227C4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
			if (disposing)
			{
				global::System.Threading.Mutex archiveMutex = this.ArchiveMutex;
				if (archiveMutex == null)
				{
					return;
				}
				archiveMutex.Close();
			}
		}

		// Token: 0x06000E4D RID: 3661 RVA: 0x000245E0 File Offset: 0x000227E0
		protected global::System.Threading.Mutex CreateSharableMutex(string mutexNamePrefix)
		{
			if (!global::NLog.Internal.PlatformDetector.SupportsSharableMutex)
			{
				return new global::System.Threading.Mutex();
			}
			string mutexName = this.GetMutexName(mutexNamePrefix);
			global::System.Security.AccessControl.MutexSecurity mutexSecurity = new global::System.Security.AccessControl.MutexSecurity();
			global::System.Security.Principal.SecurityIdentifier identity = new global::System.Security.Principal.SecurityIdentifier(global::System.Security.Principal.WellKnownSidType.WorldSid, null);
			mutexSecurity.AddAccessRule(new global::System.Security.AccessControl.MutexAccessRule(identity, global::System.Security.AccessControl.MutexRights.FullControl, global::System.Security.AccessControl.AccessControlType.Allow));
			bool flag;
			return new global::System.Threading.Mutex(false, mutexName, ref flag, mutexSecurity);
		}

		// Token: 0x06000E4E RID: 3662 RVA: 0x0002462C File Offset: 0x0002282C
		private string GetMutexName(string mutexNamePrefix)
		{
			string text = global::System.IO.Path.GetFullPath(base.FileName).ToLowerInvariant();
			text = text.Replace('\\', '_');
			text = text.Replace('/', '_');
			string text2 = string.Format("Global\\NLog-File{0}-{1}", mutexNamePrefix, text);
			if (text2.Length <= 260)
			{
				return text2;
			}
			string arg;
			using (global::System.Security.Cryptography.MD5 md = global::System.Security.Cryptography.MD5.Create())
			{
				arg = global::System.Convert.ToBase64String(md.ComputeHash(global::System.Text.Encoding.UTF8.GetBytes(text)));
			}
			text2 = string.Format("Global\\NLog-File{0}-{1}", mutexNamePrefix, arg);
			int startIndex = text.Length - (260 - text2.Length);
			return text2 + text.Substring(startIndex);
		}
	}
}
