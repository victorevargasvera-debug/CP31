using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x02000125 RID: 293
	internal class TlsSessionImpl : global::Org.BouncyCastle.Tls.TlsSession
	{
		// Token: 0x06000B5B RID: 2907 RVA: 0x0002B318 File Offset: 0x00029518
		internal TlsSessionImpl(byte[] sessionID, global::Org.BouncyCastle.Tls.SessionParameters sessionParameters)
		{
			if (sessionID == null)
			{
				throw new global::System.ArgumentNullException("sessionID");
			}
			if (sessionID.Length > 32)
			{
				throw new global::System.ArgumentException("cannot be longer than 32 bytes", "sessionID");
			}
			this.m_sessionID = global::Org.BouncyCastle.Utilities.Arrays.Clone(sessionID);
			this.m_sessionParameters = sessionParameters;
			this.m_resumable = (sessionID.Length != 0 && sessionParameters != null);
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x0002B374 File Offset: 0x00029574
		public global::Org.BouncyCastle.Tls.SessionParameters ExportSessionParameters()
		{
			global::Org.BouncyCastle.Tls.SessionParameters result;
			lock (this)
			{
				result = ((this.m_sessionParameters == null) ? null : this.m_sessionParameters.Copy());
			}
			return result;
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000B5D RID: 2909 RVA: 0x0002B3C4 File Offset: 0x000295C4
		public byte[] SessionID
		{
			get
			{
				byte[] sessionID;
				lock (this)
				{
					sessionID = this.m_sessionID;
				}
				return sessionID;
			}
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x0002B404 File Offset: 0x00029604
		public void Invalidate()
		{
			lock (this)
			{
				this.m_resumable = false;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000B5F RID: 2911 RVA: 0x0002B440 File Offset: 0x00029640
		public bool IsResumable
		{
			get
			{
				bool resumable;
				lock (this)
				{
					resumable = this.m_resumable;
				}
				return resumable;
			}
		}

		// Token: 0x04000743 RID: 1859
		private readonly byte[] m_sessionID;

		// Token: 0x04000744 RID: 1860
		private readonly global::Org.BouncyCastle.Tls.SessionParameters m_sessionParameters;

		// Token: 0x04000745 RID: 1861
		private bool m_resumable;
	}
}
