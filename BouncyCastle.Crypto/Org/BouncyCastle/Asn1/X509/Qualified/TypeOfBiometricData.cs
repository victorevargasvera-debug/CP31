using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509.Qualified
{
	// Token: 0x0200068E RID: 1678
	public class TypeOfBiometricData : global::Org.BouncyCastle.Asn1.Asn1Encodable, global::Org.BouncyCastle.Asn1.IAsn1Choice
	{
		// Token: 0x06003DD2 RID: 15826 RVA: 0x00119F20 File Offset: 0x00118120
		public static global::Org.BouncyCastle.Asn1.X509.Qualified.TypeOfBiometricData GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.X509.Qualified.TypeOfBiometricData)
			{
				return (global::Org.BouncyCastle.Asn1.X509.Qualified.TypeOfBiometricData)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.DerInteger)
			{
				return new global::Org.BouncyCastle.Asn1.X509.Qualified.TypeOfBiometricData(global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(obj).IntValueExact);
			}
			if (obj is global::Org.BouncyCastle.Asn1.DerObjectIdentifier)
			{
				return new global::Org.BouncyCastle.Asn1.X509.Qualified.TypeOfBiometricData(global::Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(obj));
			}
			throw new global::System.ArgumentException("unknown object in GetInstance: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003DD3 RID: 15827 RVA: 0x00119F86 File Offset: 0x00118186
		public TypeOfBiometricData(int predefinedBiometricType)
		{
			if (predefinedBiometricType == 0 || predefinedBiometricType == 1)
			{
				this.obj = new global::Org.BouncyCastle.Asn1.DerInteger(predefinedBiometricType);
				return;
			}
			throw new global::System.ArgumentException("unknow PredefinedBiometricType : " + predefinedBiometricType.ToString());
		}

		// Token: 0x06003DD4 RID: 15828 RVA: 0x00119FB8 File Offset: 0x001181B8
		public TypeOfBiometricData(global::Org.BouncyCastle.Asn1.DerObjectIdentifier biometricDataOid)
		{
			this.obj = biometricDataOid;
		}

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x06003DD5 RID: 15829 RVA: 0x00119FC7 File Offset: 0x001181C7
		public bool IsPredefined
		{
			get
			{
				return this.obj is global::Org.BouncyCastle.Asn1.DerInteger;
			}
		}

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x06003DD6 RID: 15830 RVA: 0x00119FD7 File Offset: 0x001181D7
		public int PredefinedBiometricType
		{
			get
			{
				return ((global::Org.BouncyCastle.Asn1.DerInteger)this.obj).IntValueExact;
			}
		}

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06003DD7 RID: 15831 RVA: 0x00119FE9 File Offset: 0x001181E9
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier BiometricDataOid
		{
			get
			{
				return (global::Org.BouncyCastle.Asn1.DerObjectIdentifier)this.obj;
			}
		}

		// Token: 0x06003DD8 RID: 15832 RVA: 0x00119FF6 File Offset: 0x001181F6
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return this.obj.ToAsn1Object();
		}

		// Token: 0x04001BA4 RID: 7076
		public const int Picture = 0;

		// Token: 0x04001BA5 RID: 7077
		public const int HandwrittenSignature = 1;

		// Token: 0x04001BA6 RID: 7078
		internal global::Org.BouncyCastle.Asn1.Asn1Encodable obj;
	}
}
