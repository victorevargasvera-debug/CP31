using System;
using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Date;
using Org.BouncyCastle.X509.Extension;

namespace Org.BouncyCastle.X509.Store
{
	// Token: 0x0200002C RID: 44
	public class X509CrlStoreSelector : global::Org.BouncyCastle.X509.Store.IX509Selector, global::System.ICloneable
	{
		// Token: 0x060001F8 RID: 504 RVA: 0x0000AC67 File Offset: 0x00008E67
		public X509CrlStoreSelector()
		{
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0000AC70 File Offset: 0x00008E70
		public X509CrlStoreSelector(global::Org.BouncyCastle.X509.Store.X509CrlStoreSelector o)
		{
			this.certificateChecking = o.CertificateChecking;
			this.dateAndTime = o.DateAndTime;
			this.issuers = o.Issuers;
			this.maxCrlNumber = o.MaxCrlNumber;
			this.minCrlNumber = o.MinCrlNumber;
			this.deltaCrlIndicatorEnabled = o.DeltaCrlIndicatorEnabled;
			this.completeCrlEnabled = o.CompleteCrlEnabled;
			this.maxBaseCrlNumber = o.MaxBaseCrlNumber;
			this.attrCertChecking = o.AttrCertChecking;
			this.issuingDistributionPointEnabled = o.IssuingDistributionPointEnabled;
			this.issuingDistributionPoint = o.IssuingDistributionPoint;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0000AD07 File Offset: 0x00008F07
		public virtual object Clone()
		{
			return new global::Org.BouncyCastle.X509.Store.X509CrlStoreSelector(this);
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060001FB RID: 507 RVA: 0x0000AD0F File Offset: 0x00008F0F
		// (set) Token: 0x060001FC RID: 508 RVA: 0x0000AD17 File Offset: 0x00008F17
		public global::Org.BouncyCastle.X509.X509Certificate CertificateChecking
		{
			get
			{
				return this.certificateChecking;
			}
			set
			{
				this.certificateChecking = value;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060001FD RID: 509 RVA: 0x0000AD20 File Offset: 0x00008F20
		// (set) Token: 0x060001FE RID: 510 RVA: 0x0000AD28 File Offset: 0x00008F28
		public global::Org.BouncyCastle.Utilities.Date.DateTimeObject DateAndTime
		{
			get
			{
				return this.dateAndTime;
			}
			set
			{
				this.dateAndTime = value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060001FF RID: 511 RVA: 0x0000AD31 File Offset: 0x00008F31
		// (set) Token: 0x06000200 RID: 512 RVA: 0x0000AD3E File Offset: 0x00008F3E
		public global::System.Collections.ICollection Issuers
		{
			get
			{
				return global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(this.issuers);
			}
			set
			{
				this.issuers = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(value);
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000201 RID: 513 RVA: 0x0000AD4C File Offset: 0x00008F4C
		// (set) Token: 0x06000202 RID: 514 RVA: 0x0000AD54 File Offset: 0x00008F54
		public global::Org.BouncyCastle.Math.BigInteger MaxCrlNumber
		{
			get
			{
				return this.maxCrlNumber;
			}
			set
			{
				this.maxCrlNumber = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000203 RID: 515 RVA: 0x0000AD5D File Offset: 0x00008F5D
		// (set) Token: 0x06000204 RID: 516 RVA: 0x0000AD65 File Offset: 0x00008F65
		public global::Org.BouncyCastle.Math.BigInteger MinCrlNumber
		{
			get
			{
				return this.minCrlNumber;
			}
			set
			{
				this.minCrlNumber = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000205 RID: 517 RVA: 0x0000AD6E File Offset: 0x00008F6E
		// (set) Token: 0x06000206 RID: 518 RVA: 0x0000AD76 File Offset: 0x00008F76
		public global::Org.BouncyCastle.X509.IX509AttributeCertificate AttrCertChecking
		{
			get
			{
				return this.attrCertChecking;
			}
			set
			{
				this.attrCertChecking = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000207 RID: 519 RVA: 0x0000AD7F File Offset: 0x00008F7F
		// (set) Token: 0x06000208 RID: 520 RVA: 0x0000AD87 File Offset: 0x00008F87
		public bool CompleteCrlEnabled
		{
			get
			{
				return this.completeCrlEnabled;
			}
			set
			{
				this.completeCrlEnabled = value;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000209 RID: 521 RVA: 0x0000AD90 File Offset: 0x00008F90
		// (set) Token: 0x0600020A RID: 522 RVA: 0x0000AD98 File Offset: 0x00008F98
		public bool DeltaCrlIndicatorEnabled
		{
			get
			{
				return this.deltaCrlIndicatorEnabled;
			}
			set
			{
				this.deltaCrlIndicatorEnabled = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600020B RID: 523 RVA: 0x0000ADA1 File Offset: 0x00008FA1
		// (set) Token: 0x0600020C RID: 524 RVA: 0x0000ADAE File Offset: 0x00008FAE
		public byte[] IssuingDistributionPoint
		{
			get
			{
				return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.issuingDistributionPoint);
			}
			set
			{
				this.issuingDistributionPoint = global::Org.BouncyCastle.Utilities.Arrays.Clone(value);
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600020D RID: 525 RVA: 0x0000ADBC File Offset: 0x00008FBC
		// (set) Token: 0x0600020E RID: 526 RVA: 0x0000ADC4 File Offset: 0x00008FC4
		public bool IssuingDistributionPointEnabled
		{
			get
			{
				return this.issuingDistributionPointEnabled;
			}
			set
			{
				this.issuingDistributionPointEnabled = value;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600020F RID: 527 RVA: 0x0000ADCD File Offset: 0x00008FCD
		// (set) Token: 0x06000210 RID: 528 RVA: 0x0000ADD5 File Offset: 0x00008FD5
		public global::Org.BouncyCastle.Math.BigInteger MaxBaseCrlNumber
		{
			get
			{
				return this.maxBaseCrlNumber;
			}
			set
			{
				this.maxBaseCrlNumber = value;
			}
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0000ADE0 File Offset: 0x00008FE0
		public virtual bool Match(object obj)
		{
			global::Org.BouncyCastle.X509.X509Crl c = obj as global::Org.BouncyCastle.X509.X509Crl;
			if (c == null)
			{
				return false;
			}
			if (this.dateAndTime != null)
			{
				global::System.DateTime dt = this.dateAndTime.Value;
				global::System.DateTime tu = c.ThisUpdate;
				global::Org.BouncyCastle.Utilities.Date.DateTimeObject nu = c.NextUpdate;
				if (dt.CompareTo(tu) < 0 || nu == null || dt.CompareTo(nu.Value) >= 0)
				{
					return false;
				}
			}
			if (this.issuers != null)
			{
				global::Org.BouncyCastle.Asn1.X509.X509Name i = c.IssuerDN;
				bool found = false;
				using (global::System.Collections.IEnumerator enumerator = this.issuers.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (((global::Org.BouncyCastle.Asn1.X509.X509Name)enumerator.Current).Equivalent(i, true))
						{
							found = true;
							break;
						}
					}
				}
				if (!found)
				{
					return false;
				}
			}
			if (this.maxCrlNumber != null || this.minCrlNumber != null)
			{
				global::Org.BouncyCastle.Asn1.Asn1OctetString extVal = c.GetExtensionValue(global::Org.BouncyCastle.Asn1.X509.X509Extensions.CrlNumber);
				if (extVal == null)
				{
					return false;
				}
				global::Org.BouncyCastle.Math.BigInteger cn = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(global::Org.BouncyCastle.X509.Extension.X509ExtensionUtilities.FromExtensionValue(extVal)).PositiveValue;
				if (this.maxCrlNumber != null && cn.CompareTo(this.maxCrlNumber) > 0)
				{
					return false;
				}
				if (this.minCrlNumber != null && cn.CompareTo(this.minCrlNumber) < 0)
				{
					return false;
				}
			}
			global::Org.BouncyCastle.Asn1.DerInteger dci = null;
			try
			{
				global::Org.BouncyCastle.Asn1.Asn1OctetString bytes = c.GetExtensionValue(global::Org.BouncyCastle.Asn1.X509.X509Extensions.DeltaCrlIndicator);
				if (bytes != null)
				{
					dci = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(global::Org.BouncyCastle.X509.Extension.X509ExtensionUtilities.FromExtensionValue(bytes));
				}
			}
			catch (global::System.Exception)
			{
				return false;
			}
			if (dci == null)
			{
				if (this.DeltaCrlIndicatorEnabled)
				{
					return false;
				}
			}
			else
			{
				if (this.CompleteCrlEnabled)
				{
					return false;
				}
				if (this.maxBaseCrlNumber != null && dci.PositiveValue.CompareTo(this.maxBaseCrlNumber) > 0)
				{
					return false;
				}
			}
			if (this.issuingDistributionPointEnabled)
			{
				global::Org.BouncyCastle.Asn1.Asn1OctetString idp = c.GetExtensionValue(global::Org.BouncyCastle.Asn1.X509.X509Extensions.IssuingDistributionPoint);
				if (this.issuingDistributionPoint == null)
				{
					if (idp != null)
					{
						return false;
					}
				}
				else if (!global::Org.BouncyCastle.Utilities.Arrays.AreEqual(idp.GetOctets(), this.issuingDistributionPoint))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x040000E0 RID: 224
		private global::Org.BouncyCastle.X509.X509Certificate certificateChecking;

		// Token: 0x040000E1 RID: 225
		private global::Org.BouncyCastle.Utilities.Date.DateTimeObject dateAndTime;

		// Token: 0x040000E2 RID: 226
		private global::System.Collections.ICollection issuers;

		// Token: 0x040000E3 RID: 227
		private global::Org.BouncyCastle.Math.BigInteger maxCrlNumber;

		// Token: 0x040000E4 RID: 228
		private global::Org.BouncyCastle.Math.BigInteger minCrlNumber;

		// Token: 0x040000E5 RID: 229
		private global::Org.BouncyCastle.X509.IX509AttributeCertificate attrCertChecking;

		// Token: 0x040000E6 RID: 230
		private bool completeCrlEnabled;

		// Token: 0x040000E7 RID: 231
		private bool deltaCrlIndicatorEnabled;

		// Token: 0x040000E8 RID: 232
		private byte[] issuingDistributionPoint;

		// Token: 0x040000E9 RID: 233
		private bool issuingDistributionPointEnabled;

		// Token: 0x040000EA RID: 234
		private global::Org.BouncyCastle.Math.BigInteger maxBaseCrlNumber;
	}
}
