using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000650 RID: 1616
	public class DisplayText : global::Org.BouncyCastle.Asn1.Asn1Encodable, global::Org.BouncyCastle.Asn1.IAsn1Choice
	{
		// Token: 0x06003BC7 RID: 15303 RVA: 0x001126EC File Offset: 0x001108EC
		public DisplayText(int type, string text)
		{
			if (text.Length > 200)
			{
				text = text.Substring(0, 200);
			}
			this.contentType = type;
			switch (type)
			{
			case 0:
				this.contents = new global::Org.BouncyCastle.Asn1.DerIA5String(text);
				return;
			case 1:
				this.contents = new global::Org.BouncyCastle.Asn1.DerBmpString(text);
				return;
			case 2:
				this.contents = new global::Org.BouncyCastle.Asn1.DerUtf8String(text);
				return;
			case 3:
				this.contents = new global::Org.BouncyCastle.Asn1.DerVisibleString(text);
				return;
			default:
				this.contents = new global::Org.BouncyCastle.Asn1.DerUtf8String(text);
				return;
			}
		}

		// Token: 0x06003BC8 RID: 15304 RVA: 0x00112779 File Offset: 0x00110979
		public DisplayText(string text)
		{
			if (text.Length > 200)
			{
				text = text.Substring(0, 200);
			}
			this.contentType = 2;
			this.contents = new global::Org.BouncyCastle.Asn1.DerUtf8String(text);
		}

		// Token: 0x06003BC9 RID: 15305 RVA: 0x001127AF File Offset: 0x001109AF
		public DisplayText(global::Org.BouncyCastle.Asn1.IAsn1String contents)
		{
			this.contents = contents;
		}

		// Token: 0x06003BCA RID: 15306 RVA: 0x001127BE File Offset: 0x001109BE
		public static global::Org.BouncyCastle.Asn1.X509.DisplayText GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.IAsn1String)
			{
				return new global::Org.BouncyCastle.Asn1.X509.DisplayText((global::Org.BouncyCastle.Asn1.IAsn1String)obj);
			}
			if (obj is global::Org.BouncyCastle.Asn1.X509.DisplayText)
			{
				return (global::Org.BouncyCastle.Asn1.X509.DisplayText)obj;
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003BCB RID: 15307 RVA: 0x001127FD File Offset: 0x001109FD
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return (global::Org.BouncyCastle.Asn1.Asn1Object)this.contents;
		}

		// Token: 0x06003BCC RID: 15308 RVA: 0x0011280A File Offset: 0x00110A0A
		public string GetString()
		{
			return this.contents.GetString();
		}

		// Token: 0x04001A51 RID: 6737
		public const int ContentTypeIA5String = 0;

		// Token: 0x04001A52 RID: 6738
		public const int ContentTypeBmpString = 1;

		// Token: 0x04001A53 RID: 6739
		public const int ContentTypeUtf8String = 2;

		// Token: 0x04001A54 RID: 6740
		public const int ContentTypeVisibleString = 3;

		// Token: 0x04001A55 RID: 6741
		public const int DisplayTextMaximumSize = 200;

		// Token: 0x04001A56 RID: 6742
		internal readonly int contentType;

		// Token: 0x04001A57 RID: 6743
		internal readonly global::Org.BouncyCastle.Asn1.IAsn1String contents;
	}
}
