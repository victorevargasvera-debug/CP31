using System;
using System.Collections.Generic;
using Gibraltar.Monitor;
using Loupe.Extensibility.Data;

namespace Gibraltar.Data.Internal
{
	// Token: 0x02000263 RID: 611
	internal abstract class TransportPackageBase : global::System.IDisposable
	{
		// Token: 0x06001F24 RID: 7972 RVA: 0x00070F6C File Offset: 0x0006F16C
		protected TransportPackageBase(string product, string application, global::Gibraltar.Data.SimplePackage package)
		{
			if (package == null)
			{
				throw new global::System.ArgumentNullException("package");
			}
			if (string.IsNullOrEmpty(product))
			{
				throw new global::System.ArgumentNullException("product");
			}
			this.Package = package;
			this.Product = product;
			this.Application = application;
		}

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x06001F25 RID: 7973 RVA: 0x00070FC0 File Offset: 0x0006F1C0
		// (set) Token: 0x06001F26 RID: 7974 RVA: 0x00070FC8 File Offset: 0x0006F1C8
		public global::Gibraltar.Data.SimplePackage Package { get; private set; }

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x06001F27 RID: 7975 RVA: 0x00070FD4 File Offset: 0x0006F1D4
		// (set) Token: 0x06001F28 RID: 7976 RVA: 0x00070FDC File Offset: 0x0006F1DC
		public string Product { get; private set; }

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x06001F29 RID: 7977 RVA: 0x00070FE8 File Offset: 0x0006F1E8
		// (set) Token: 0x06001F2A RID: 7978 RVA: 0x00070FF0 File Offset: 0x0006F1F0
		public string Application { get; private set; }

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x06001F2B RID: 7979 RVA: 0x00070FFC File Offset: 0x0006F1FC
		// (set) Token: 0x06001F2C RID: 7980 RVA: 0x00071004 File Offset: 0x0006F204
		public bool HasProblemSessions { get; set; }

		// Token: 0x06001F2D RID: 7981 RVA: 0x00071010 File Offset: 0x0006F210
		public void Dispose()
		{
			if (!this.m_IsDisposed)
			{
				this.m_IsDisposed = true;
				this.Dispose(true);
			}
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x06001F2E RID: 7982 RVA: 0x00071034 File Offset: 0x0006F234
		// (set) Token: 0x06001F2F RID: 7983 RVA: 0x0007103C File Offset: 0x0006F23C
		public global::Gibraltar.Data.PackageSendEventArgs Status { get; private set; }

		// Token: 0x06001F30 RID: 7984 RVA: 0x00071048 File Offset: 0x0006F248
		public void MarkContentsAsRead(global::Gibraltar.Monitor.LocalRepository repository)
		{
			if (this.Package == null)
			{
				throw new global::System.NullReferenceException("There is no working package available, indicating an internal Loupe programming error.");
			}
			try
			{
				if (!global::Gibraltar.Monitor.Log.SilentMode)
				{
					global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "Loupe.Packager", "Marking all sessions in the package as read", null, new object[0]);
				}
				global::System.Collections.Generic.IList<global::Gibraltar.Data.SessionHeader> sessions = this.Package.GetSessions();
				if (sessions.Count == 0)
				{
					if (!global::Gibraltar.Monitor.Log.SilentMode)
					{
						global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "Loupe.Packager", "No Sessions to Mark Read", "There are unexpectedly no sessions in the working package, so none can be marked as read.  We shouldn't have gotten to this point if tehre are no sessions in the package.", new object[0]);
					}
				}
				else
				{
					if (!global::Gibraltar.Monitor.Log.SilentMode)
					{
						global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "Loupe.Packager", "Found sessions to mark as read", "There are {0} sessions to be marked as read (although some may have been marked as read before).", new object[]
						{
							sessions.Count
						});
					}
					global::System.Collections.Generic.List<global::System.Guid> list = new global::System.Collections.Generic.List<global::System.Guid>(sessions.Count);
					foreach (global::Gibraltar.Data.SessionHeader sessionHeader in sessions)
					{
						list.Add(sessionHeader.Id);
					}
					try
					{
						repository.SetSessionsNew(list.ToArray(), false);
					}
					catch (global::System.Exception ex)
					{
						if (!global::Gibraltar.Monitor.Log.SilentMode)
						{
							global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, "Loupe.Packager", "Error marking an included session as read", "Unable to mark one or more of the sessions included in the package as read.  This won't prevent the package from being sent.  Exception:\r\n{0}", new object[]
							{
								ex.Message
							});
						}
					}
				}
			}
			catch (global::System.Exception ex2)
			{
				if (!global::Gibraltar.Monitor.Log.SilentMode)
				{
					global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, global::Gibraltar.Monitor.LogWriteMode.Queued, ex2, "Loupe.Packager", "General error while marking included sessions as read", "A general error occurred while marking the source sessions included in the package as read.  This won't prevent the package from being sent.\r\nException ({0}):\r\n{1}", new object[]
					{
						ex2.GetType().FullName,
						ex2.Message
					});
				}
				throw;
			}
		}

		// Token: 0x06001F31 RID: 7985 RVA: 0x0007122C File Offset: 0x0006F42C
		public void Send(global::Gibraltar.ProgressMonitorStack progressMonitors)
		{
			this.Status = this.OnSend(progressMonitors);
		}

		// Token: 0x06001F32 RID: 7986
		protected abstract global::Gibraltar.Data.PackageSendEventArgs OnSend(global::Gibraltar.ProgressMonitorStack progressMonitors);

		// Token: 0x06001F33 RID: 7987 RVA: 0x0007123C File Offset: 0x0006F43C
		protected virtual void Dispose(bool releaseManaged)
		{
			if (releaseManaged)
			{
				try
				{
					if (this.Package != null)
					{
						this.Package.Dispose();
						this.Package = null;
					}
				}
				catch (global::System.Exception ex)
				{
					if (!global::Gibraltar.Monitor.Log.SilentMode)
					{
						global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, "Loupe.Packager", "Unable to properly dispose working email package file", "Unable to properly dispose the transport package due to an exception ({0}): {1}", new object[]
						{
							ex.GetType().FullName,
							ex.Message
						});
					}
				}
			}
		}

		// Token: 0x04000BC4 RID: 3012
		private bool m_IsDisposed;
	}
}
