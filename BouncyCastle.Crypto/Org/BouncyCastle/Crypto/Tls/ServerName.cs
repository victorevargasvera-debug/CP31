using System;
using System.IO;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000345 RID: 837
	public class ServerName
	{
		// Token: 0x06002290 RID: 8848 RVA: 0x000984E8 File Offset: 0x000966E8
		public ServerName(byte nameType, object name)
		{
			if (!global::Org.BouncyCastle.Crypto.Tls.ServerName.IsCorrectType(nameType, name))
			{
				throw new global::System.ArgumentException("not an instance of the correct type", "name");
			}
			this.mNameType = nameType;
			this.mName = name;
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06002291 RID: 8849 RVA: 0x00098517 File Offset: 0x00096717
		public virtual byte NameType
		{
			get
			{
				return this.mNameType;
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06002292 RID: 8850 RVA: 0x0009851F File Offset: 0x0009671F
		public virtual object Name
		{
			get
			{
				return this.mName;
			}
		}

		// Token: 0x06002293 RID: 8851 RVA: 0x00098527 File Offset: 0x00096727
		public virtual string GetHostName()
		{
			if (!global::Org.BouncyCastle.Crypto.Tls.ServerName.IsCorrectType(0, this.mName))
			{
				throw new global::System.InvalidOperationException("'name' is not a HostName string");
			}
			return (string)this.mName;
		}

		// Token: 0x06002294 RID: 8852 RVA: 0x00098550 File Offset: 0x00096750
		public virtual void Encode(global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8(this.mNameType, output);
			if (this.mNameType != 0)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
			byte[] array = global::Org.BouncyCastle.Utilities.Strings.ToAsciiByteArray((string)this.mName);
			if (array.Length < 1)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque16(array, output);
		}

		// Token: 0x06002295 RID: 8853 RVA: 0x000985A0 File Offset: 0x000967A0
		public static global::Org.BouncyCastle.Crypto.Tls.ServerName Parse(global::System.IO.Stream input)
		{
			byte b = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8(input);
			if (b != 0)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(50);
			}
			byte[] array = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque16(input);
			if (array.Length < 1)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(50);
			}
			object name = global::Org.BouncyCastle.Utilities.Strings.FromAsciiByteArray(array);
			return new global::Org.BouncyCastle.Crypto.Tls.ServerName(b, name);
		}

		// Token: 0x06002296 RID: 8854 RVA: 0x000985E1 File Offset: 0x000967E1
		protected static bool IsCorrectType(byte nameType, object name)
		{
			if (nameType == 0)
			{
				return name is string;
			}
			throw new global::System.ArgumentException("unsupported NameType", "nameType");
		}

		// Token: 0x04000DFE RID: 3582
		protected readonly byte mNameType;

		// Token: 0x04000DFF RID: 3583
		protected readonly object mName;
	}
}
