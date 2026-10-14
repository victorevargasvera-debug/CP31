using System;
using System.Text;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000652 RID: 1618
	public class DistributionPointName : global::Org.BouncyCastle.Asn1.Asn1Encodable, global::Org.BouncyCastle.Asn1.IAsn1Choice
	{
		// Token: 0x06003BD7 RID: 15319 RVA: 0x00112A4C File Offset: 0x00110C4C
		public static global::Org.BouncyCastle.Asn1.X509.DistributionPointName GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.X509.DistributionPointName.GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject.GetInstance(obj, true));
		}

		// Token: 0x06003BD8 RID: 15320 RVA: 0x00112A5C File Offset: 0x00110C5C
		public static global::Org.BouncyCastle.Asn1.X509.DistributionPointName GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.X509.DistributionPointName)
			{
				return (global::Org.BouncyCastle.Asn1.X509.DistributionPointName)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
			{
				return new global::Org.BouncyCastle.Asn1.X509.DistributionPointName((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)obj);
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003BD9 RID: 15321 RVA: 0x00112AA9 File Offset: 0x00110CA9
		public DistributionPointName(int type, global::Org.BouncyCastle.Asn1.Asn1Encodable name)
		{
			this.type = type;
			this.name = name;
		}

		// Token: 0x06003BDA RID: 15322 RVA: 0x00112ABF File Offset: 0x00110CBF
		public DistributionPointName(global::Org.BouncyCastle.Asn1.X509.GeneralNames name) : this(0, name)
		{
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x06003BDB RID: 15323 RVA: 0x00112AC9 File Offset: 0x00110CC9
		public int PointType
		{
			get
			{
				return this.type;
			}
		}

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x06003BDC RID: 15324 RVA: 0x00112AD1 File Offset: 0x00110CD1
		public global::Org.BouncyCastle.Asn1.Asn1Encodable Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x06003BDD RID: 15325 RVA: 0x00112AD9 File Offset: 0x00110CD9
		public DistributionPointName(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj)
		{
			this.type = obj.TagNo;
			if (this.type == 0)
			{
				this.name = global::Org.BouncyCastle.Asn1.X509.GeneralNames.GetInstance(obj, false);
				return;
			}
			this.name = global::Org.BouncyCastle.Asn1.Asn1Set.GetInstance(obj, false);
		}

		// Token: 0x06003BDE RID: 15326 RVA: 0x00112B10 File Offset: 0x00110D10
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerTaggedObject(false, this.type, this.name);
		}

		// Token: 0x06003BDF RID: 15327 RVA: 0x00112B24 File Offset: 0x00110D24
		public override string ToString()
		{
			string sep = global::Org.BouncyCastle.Utilities.Platform.NewLine;
			global::System.Text.StringBuilder buf = new global::System.Text.StringBuilder();
			buf.Append("DistributionPointName: [");
			buf.Append(sep);
			if (this.type == 0)
			{
				this.appendObject(buf, sep, "fullName", this.name.ToString());
			}
			else
			{
				this.appendObject(buf, sep, "nameRelativeToCRLIssuer", this.name.ToString());
			}
			buf.Append("]");
			buf.Append(sep);
			return buf.ToString();
		}

		// Token: 0x06003BE0 RID: 15328 RVA: 0x00112BA8 File Offset: 0x00110DA8
		private void appendObject(global::System.Text.StringBuilder buf, string sep, string name, string val)
		{
			string indent = "    ";
			buf.Append(indent);
			buf.Append(name);
			buf.Append(":");
			buf.Append(sep);
			buf.Append(indent);
			buf.Append(indent);
			buf.Append(val);
			buf.Append(sep);
		}

		// Token: 0x04001A5B RID: 6747
		internal readonly global::Org.BouncyCastle.Asn1.Asn1Encodable name;

		// Token: 0x04001A5C RID: 6748
		internal readonly int type;

		// Token: 0x04001A5D RID: 6749
		public const int FullName = 0;

		// Token: 0x04001A5E RID: 6750
		public const int NameRelativeToCrlIssuer = 1;
	}
}
