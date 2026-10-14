using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000346 RID: 838
	public class ServerNameList
	{
		// Token: 0x06002297 RID: 8855 RVA: 0x00098600 File Offset: 0x00096800
		public ServerNameList(global::System.Collections.IList serverNameList)
		{
			if (serverNameList == null)
			{
				throw new global::System.ArgumentNullException("serverNameList");
			}
			this.mServerNameList = serverNameList;
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06002298 RID: 8856 RVA: 0x0009861D File Offset: 0x0009681D
		public virtual global::System.Collections.IList ServerNames
		{
			get
			{
				return this.mServerNameList;
			}
		}

		// Token: 0x06002299 RID: 8857 RVA: 0x00098628 File Offset: 0x00096828
		public virtual void Encode(global::System.IO.Stream output)
		{
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
			byte[] nameTypesSeen = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.EmptyBytes;
			foreach (object obj in this.ServerNames)
			{
				global::Org.BouncyCastle.Crypto.Tls.ServerName entry = (global::Org.BouncyCastle.Crypto.Tls.ServerName)obj;
				nameTypesSeen = global::Org.BouncyCastle.Crypto.Tls.ServerNameList.CheckNameType(nameTypesSeen, entry.NameType);
				if (nameTypesSeen == null)
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
				}
				entry.Encode(buf);
			}
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CheckUint16(buf.Length);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16((int)buf.Length, output);
			global::Org.BouncyCastle.Utilities.IO.Streams.WriteBufTo(buf, output);
		}

		// Token: 0x0600229A RID: 8858 RVA: 0x000986C8 File Offset: 0x000968C8
		public static global::Org.BouncyCastle.Crypto.Tls.ServerNameList Parse(global::System.IO.Stream input)
		{
			int num = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint16(input);
			if (num < 1)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(50);
			}
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream(global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadFully(num, input), false);
			byte[] nameTypesSeen = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.EmptyBytes;
			global::System.Collections.IList server_name_list = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			while (buf.Position < buf.Length)
			{
				global::Org.BouncyCastle.Crypto.Tls.ServerName entry = global::Org.BouncyCastle.Crypto.Tls.ServerName.Parse(buf);
				nameTypesSeen = global::Org.BouncyCastle.Crypto.Tls.ServerNameList.CheckNameType(nameTypesSeen, entry.NameType);
				if (nameTypesSeen == null)
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
				}
				server_name_list.Add(entry);
			}
			return new global::Org.BouncyCastle.Crypto.Tls.ServerNameList(server_name_list);
		}

		// Token: 0x0600229B RID: 8859 RVA: 0x0009873D File Offset: 0x0009693D
		private static byte[] CheckNameType(byte[] nameTypesSeen, byte nameType)
		{
			if (!global::Org.BouncyCastle.Crypto.Tls.NameType.IsValid(nameType) || global::Org.BouncyCastle.Utilities.Arrays.Contains(nameTypesSeen, nameType))
			{
				return null;
			}
			return global::Org.BouncyCastle.Utilities.Arrays.Append(nameTypesSeen, nameType);
		}

		// Token: 0x04000E00 RID: 3584
		protected readonly global::System.Collections.IList mServerNameList;
	}
}
