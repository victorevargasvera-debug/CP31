using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000387 RID: 903
	internal class TlsSessionImpl : global::Org.BouncyCastle.Crypto.Tls.TlsSession
	{
		// Token: 0x060024B6 RID: 9398 RVA: 0x0009FAA0 File Offset: 0x0009DCA0
		internal TlsSessionImpl(byte[] sessionID, global::Org.BouncyCastle.Crypto.Tls.SessionParameters sessionParameters)
		{
			if (sessionID == null)
			{
				throw new global::System.ArgumentNullException("sessionID");
			}
			if (sessionID.Length > 32)
			{
				throw new global::System.ArgumentException("cannot be longer than 32 bytes", "sessionID");
			}
			this.mSessionID = global::Org.BouncyCastle.Utilities.Arrays.Clone(sessionID);
			this.mSessionParameters = sessionParameters;
			this.mResumable = (sessionID.Length != 0 && sessionParameters != null && sessionParameters.IsExtendedMasterSecret);
		}

		// Token: 0x060024B7 RID: 9399 RVA: 0x0009FB04 File Offset: 0x0009DD04
		public virtual global::Org.BouncyCastle.Crypto.Tls.SessionParameters ExportSessionParameters()
		{
			global::Org.BouncyCastle.Crypto.Tls.SessionParameters result;
			lock (this)
			{
				result = ((this.mSessionParameters == null) ? null : this.mSessionParameters.Copy());
			}
			return result;
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x060024B8 RID: 9400 RVA: 0x0009FB54 File Offset: 0x0009DD54
		public virtual byte[] SessionID
		{
			get
			{
				byte[] result;
				lock (this)
				{
					result = this.mSessionID;
				}
				return result;
			}
		}

		// Token: 0x060024B9 RID: 9401 RVA: 0x0009FB94 File Offset: 0x0009DD94
		public virtual void Invalidate()
		{
			lock (this)
			{
				this.mResumable = false;
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x060024BA RID: 9402 RVA: 0x0009FBD0 File Offset: 0x0009DDD0
		public virtual bool IsResumable
		{
			get
			{
				bool result;
				lock (this)
				{
					result = this.mResumable;
				}
				return result;
			}
		}

		// Token: 0x04000EC4 RID: 3780
		internal readonly byte[] mSessionID;

		// Token: 0x04000EC5 RID: 3781
		internal readonly global::Org.BouncyCastle.Crypto.Tls.SessionParameters mSessionParameters;

		// Token: 0x04000EC6 RID: 3782
		internal bool mResumable;
	}
}
