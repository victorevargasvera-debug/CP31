using System;

namespace Org.BouncyCastle.Asn1.X9
{
	// Token: 0x02000634 RID: 1588
	public class X962Parameters : global::Org.BouncyCastle.Asn1.Asn1Encodable, global::Org.BouncyCastle.Asn1.IAsn1Choice
	{
		// Token: 0x06003AEF RID: 15087 RVA: 0x001100F0 File Offset: 0x0010E2F0
		public static global::Org.BouncyCastle.Asn1.X9.X962Parameters GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.X9.X962Parameters)
			{
				return (global::Org.BouncyCastle.Asn1.X9.X962Parameters)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Object)
			{
				return new global::Org.BouncyCastle.Asn1.X9.X962Parameters((global::Org.BouncyCastle.Asn1.Asn1Object)obj);
			}
			if (obj is byte[])
			{
				try
				{
					return new global::Org.BouncyCastle.Asn1.X9.X962Parameters(global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray((byte[])obj));
				}
				catch (global::System.Exception e)
				{
					throw new global::System.ArgumentException("unable to parse encoded data: " + e.Message, e);
				}
			}
			throw new global::System.ArgumentException("unknown object in getInstance()");
		}

		// Token: 0x06003AF0 RID: 15088 RVA: 0x00110174 File Offset: 0x0010E374
		public X962Parameters(global::Org.BouncyCastle.Asn1.X9.X9ECParameters ecParameters)
		{
			this._params = ecParameters.ToAsn1Object();
		}

		// Token: 0x06003AF1 RID: 15089 RVA: 0x00110188 File Offset: 0x0010E388
		public X962Parameters(global::Org.BouncyCastle.Asn1.DerObjectIdentifier namedCurve)
		{
			this._params = namedCurve;
		}

		// Token: 0x06003AF2 RID: 15090 RVA: 0x00110197 File Offset: 0x0010E397
		public X962Parameters(global::Org.BouncyCastle.Asn1.Asn1Null obj)
		{
			this._params = obj;
		}

		// Token: 0x06003AF3 RID: 15091 RVA: 0x001101A6 File Offset: 0x0010E3A6
		[global::System.Obsolete("Use 'GetInstance' instead")]
		public X962Parameters(global::Org.BouncyCastle.Asn1.Asn1Object obj)
		{
			this._params = obj;
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x06003AF4 RID: 15092 RVA: 0x001101B5 File Offset: 0x0010E3B5
		public bool IsNamedCurve
		{
			get
			{
				return this._params is global::Org.BouncyCastle.Asn1.DerObjectIdentifier;
			}
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x06003AF5 RID: 15093 RVA: 0x001101C5 File Offset: 0x0010E3C5
		public bool IsImplicitlyCA
		{
			get
			{
				return this._params is global::Org.BouncyCastle.Asn1.Asn1Null;
			}
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x06003AF6 RID: 15094 RVA: 0x001101D5 File Offset: 0x0010E3D5
		public global::Org.BouncyCastle.Asn1.Asn1Object Parameters
		{
			get
			{
				return this._params;
			}
		}

		// Token: 0x06003AF7 RID: 15095 RVA: 0x001101DD File Offset: 0x0010E3DD
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return this._params;
		}

		// Token: 0x040019CB RID: 6603
		private readonly global::Org.BouncyCastle.Asn1.Asn1Object _params;
	}
}
