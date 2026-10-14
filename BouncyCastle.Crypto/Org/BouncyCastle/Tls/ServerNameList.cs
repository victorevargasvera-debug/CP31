using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000E9 RID: 233
	public sealed class ServerNameList
	{
		// Token: 0x06000884 RID: 2180 RVA: 0x00022B95 File Offset: 0x00020D95
		public ServerNameList(global::System.Collections.IList serverNameList)
		{
			if (serverNameList == null)
			{
				throw new global::System.ArgumentNullException("serverNameList");
			}
			this.m_serverNameList = serverNameList;
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000885 RID: 2181 RVA: 0x00022BB2 File Offset: 0x00020DB2
		public global::System.Collections.IList ServerNames
		{
			get
			{
				return this.m_serverNameList;
			}
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00022BBC File Offset: 0x00020DBC
		public void Encode(global::System.IO.Stream output)
		{
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
			short[] nameTypesSeen = global::Org.BouncyCastle.Tls.TlsUtilities.EmptyShorts;
			foreach (object obj in this.ServerNames)
			{
				global::Org.BouncyCastle.Tls.ServerName entry = (global::Org.BouncyCastle.Tls.ServerName)obj;
				nameTypesSeen = global::Org.BouncyCastle.Tls.ServerNameList.CheckNameType(nameTypesSeen, entry.NameType);
				if (nameTypesSeen == null)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
				}
				entry.Encode(buf);
			}
			int i = (int)buf.Length;
			global::Org.BouncyCastle.Tls.TlsUtilities.CheckUint16(i);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16(i, output);
			global::Org.BouncyCastle.Utilities.IO.Streams.WriteBufTo(buf, output);
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00022C58 File Offset: 0x00020E58
		public static global::Org.BouncyCastle.Tls.ServerNameList Parse(global::System.IO.Stream input)
		{
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream(global::Org.BouncyCastle.Tls.TlsUtilities.ReadOpaque16(input, 1), false);
			short[] nameTypesSeen = global::Org.BouncyCastle.Tls.TlsUtilities.EmptyShorts;
			global::System.Collections.IList server_name_list = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			while (buf.Position < buf.Length)
			{
				global::Org.BouncyCastle.Tls.ServerName entry = global::Org.BouncyCastle.Tls.ServerName.Parse(buf);
				nameTypesSeen = global::Org.BouncyCastle.Tls.ServerNameList.CheckNameType(nameTypesSeen, entry.NameType);
				if (nameTypesSeen == null)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
				}
				server_name_list.Add(entry);
			}
			return new global::Org.BouncyCastle.Tls.ServerNameList(server_name_list);
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00022CBC File Offset: 0x00020EBC
		private static short[] CheckNameType(short[] nameTypesSeen, short nameType)
		{
			if (global::Org.BouncyCastle.Utilities.Arrays.Contains(nameTypesSeen, nameType))
			{
				return null;
			}
			return global::Org.BouncyCastle.Utilities.Arrays.Append(nameTypesSeen, nameType);
		}

		// Token: 0x0400067A RID: 1658
		private readonly global::System.Collections.IList m_serverNameList;
	}
}
