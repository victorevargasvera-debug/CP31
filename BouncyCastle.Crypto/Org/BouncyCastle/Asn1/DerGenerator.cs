using System;
using System.IO;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x02000609 RID: 1545
	public abstract class DerGenerator : global::Org.BouncyCastle.Asn1.Asn1Generator
	{
		// Token: 0x060039B7 RID: 14775 RVA: 0x0010D34E File Offset: 0x0010B54E
		protected DerGenerator(global::System.IO.Stream outStream) : base(outStream)
		{
		}

		// Token: 0x060039B8 RID: 14776 RVA: 0x0010D357 File Offset: 0x0010B557
		protected DerGenerator(global::System.IO.Stream outStream, int tagNo, bool isExplicit) : base(outStream)
		{
			this._tagged = true;
			this._isExplicit = isExplicit;
			this._tagNo = tagNo;
		}

		// Token: 0x060039B9 RID: 14777 RVA: 0x0010D378 File Offset: 0x0010B578
		private static void WriteLength(global::System.IO.Stream outStr, int length)
		{
			if (length > 127)
			{
				int size = 1;
				int val = length;
				while ((val >>= 8) != 0)
				{
					size++;
				}
				outStr.WriteByte((byte)(size | 128));
				for (int i = (size - 1) * 8; i >= 0; i -= 8)
				{
					outStr.WriteByte((byte)(length >> i));
				}
				return;
			}
			outStr.WriteByte((byte)length);
		}

		// Token: 0x060039BA RID: 14778 RVA: 0x0010D3CF File Offset: 0x0010B5CF
		internal static void WriteDerEncoded(global::System.IO.Stream outStream, int tag, byte[] bytes)
		{
			outStream.WriteByte((byte)tag);
			global::Org.BouncyCastle.Asn1.DerGenerator.WriteLength(outStream, bytes.Length);
			outStream.Write(bytes, 0, bytes.Length);
		}

		// Token: 0x060039BB RID: 14779 RVA: 0x0010D3F0 File Offset: 0x0010B5F0
		internal void WriteDerEncoded(int tag, byte[] bytes)
		{
			if (!this._tagged)
			{
				global::Org.BouncyCastle.Asn1.DerGenerator.WriteDerEncoded(base.Out, tag, bytes);
				return;
			}
			int tagNum = this._tagNo | 128;
			if (this._isExplicit)
			{
				int newTag = this._tagNo | 32 | 128;
				global::System.IO.MemoryStream bOut = new global::System.IO.MemoryStream();
				global::Org.BouncyCastle.Asn1.DerGenerator.WriteDerEncoded(bOut, tag, bytes);
				global::Org.BouncyCastle.Asn1.DerGenerator.WriteDerEncoded(base.Out, newTag, bOut.ToArray());
				return;
			}
			if ((tag & 32) != 0)
			{
				tagNum |= 32;
			}
			global::Org.BouncyCastle.Asn1.DerGenerator.WriteDerEncoded(base.Out, tagNum, bytes);
		}

		// Token: 0x060039BC RID: 14780 RVA: 0x0010D471 File Offset: 0x0010B671
		internal static void WriteDerEncoded(global::System.IO.Stream outStr, int tag, global::System.IO.Stream inStr)
		{
			global::Org.BouncyCastle.Asn1.DerGenerator.WriteDerEncoded(outStr, tag, global::Org.BouncyCastle.Utilities.IO.Streams.ReadAll(inStr));
		}

		// Token: 0x04001993 RID: 6547
		private bool _tagged;

		// Token: 0x04001994 RID: 6548
		private bool _isExplicit;

		// Token: 0x04001995 RID: 6549
		private int _tagNo;
	}
}
