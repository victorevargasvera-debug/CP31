using System;
using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.Utilities.Date;
using Org.BouncyCastle.X509.Extension;

namespace Org.BouncyCastle.X509.Store
{
	// Token: 0x02000027 RID: 39
	public class X509AttrCertStoreSelector : global::Org.BouncyCastle.X509.Store.IX509Selector, global::System.ICloneable
	{
		// Token: 0x060001A6 RID: 422 RVA: 0x0000A06F File Offset: 0x0000826F
		public X509AttrCertStoreSelector()
		{
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0000A090 File Offset: 0x00008290
		private X509AttrCertStoreSelector(global::Org.BouncyCastle.X509.Store.X509AttrCertStoreSelector o)
		{
			this.attributeCert = o.attributeCert;
			this.attributeCertificateValid = o.attributeCertificateValid;
			this.holder = o.holder;
			this.issuer = o.issuer;
			this.serialNumber = o.serialNumber;
			this.targetGroups = new global::Org.BouncyCastle.Utilities.Collections.HashSet(o.targetGroups);
			this.targetNames = new global::Org.BouncyCastle.Utilities.Collections.HashSet(o.targetNames);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0000A118 File Offset: 0x00008318
		public bool Match(object obj)
		{
			if (obj == null)
			{
				throw new global::System.ArgumentNullException("obj");
			}
			global::Org.BouncyCastle.X509.IX509AttributeCertificate attrCert = obj as global::Org.BouncyCastle.X509.IX509AttributeCertificate;
			if (attrCert == null)
			{
				return false;
			}
			if (this.attributeCert != null && !this.attributeCert.Equals(attrCert))
			{
				return false;
			}
			if (this.serialNumber != null && !attrCert.SerialNumber.Equals(this.serialNumber))
			{
				return false;
			}
			if (this.holder != null && !attrCert.Holder.Equals(this.holder))
			{
				return false;
			}
			if (this.issuer != null && !attrCert.Issuer.Equals(this.issuer))
			{
				return false;
			}
			if (this.attributeCertificateValid != null && !attrCert.IsValid(this.attributeCertificateValid.Value))
			{
				return false;
			}
			if (this.targetNames.Count > 0 || this.targetGroups.Count > 0)
			{
				global::Org.BouncyCastle.Asn1.Asn1OctetString targetInfoExt = attrCert.GetExtensionValue(global::Org.BouncyCastle.Asn1.X509.X509Extensions.TargetInformation);
				if (targetInfoExt != null)
				{
					global::Org.BouncyCastle.Asn1.X509.TargetInformation targetinfo;
					try
					{
						targetinfo = global::Org.BouncyCastle.Asn1.X509.TargetInformation.GetInstance(global::Org.BouncyCastle.X509.Extension.X509ExtensionUtilities.FromExtensionValue(targetInfoExt));
					}
					catch (global::System.Exception)
					{
						return false;
					}
					global::Org.BouncyCastle.Asn1.X509.Targets[] targetss = targetinfo.GetTargetsObjects();
					if (this.targetNames.Count > 0)
					{
						bool found = false;
						int i = 0;
						while (i < targetss.Length && !found)
						{
							global::Org.BouncyCastle.Asn1.X509.Target[] targets = targetss[i].GetTargets();
							for (int j = 0; j < targets.Length; j++)
							{
								global::Org.BouncyCastle.Asn1.X509.GeneralName targetName = targets[j].TargetName;
								if (targetName != null && this.targetNames.Contains(targetName))
								{
									found = true;
									break;
								}
							}
							i++;
						}
						if (!found)
						{
							return false;
						}
					}
					if (this.targetGroups.Count <= 0)
					{
						return true;
					}
					bool found2 = false;
					int k = 0;
					while (k < targetss.Length && !found2)
					{
						global::Org.BouncyCastle.Asn1.X509.Target[] targets2 = targetss[k].GetTargets();
						for (int l = 0; l < targets2.Length; l++)
						{
							global::Org.BouncyCastle.Asn1.X509.GeneralName targetGroup = targets2[l].TargetGroup;
							if (targetGroup != null && this.targetGroups.Contains(targetGroup))
							{
								found2 = true;
								break;
							}
						}
						k++;
					}
					if (!found2)
					{
						return false;
					}
					return true;
				}
			}
			return true;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0000A30C File Offset: 0x0000850C
		public object Clone()
		{
			return new global::Org.BouncyCastle.X509.Store.X509AttrCertStoreSelector(this);
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060001AA RID: 426 RVA: 0x0000A314 File Offset: 0x00008514
		// (set) Token: 0x060001AB RID: 427 RVA: 0x0000A31C File Offset: 0x0000851C
		public global::Org.BouncyCastle.X509.IX509AttributeCertificate AttributeCert
		{
			get
			{
				return this.attributeCert;
			}
			set
			{
				this.attributeCert = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060001AC RID: 428 RVA: 0x0000A325 File Offset: 0x00008525
		// (set) Token: 0x060001AD RID: 429 RVA: 0x0000A32D File Offset: 0x0000852D
		[global::System.Obsolete("Use AttributeCertificateValid instead")]
		public global::Org.BouncyCastle.Utilities.Date.DateTimeObject AttribueCertificateValid
		{
			get
			{
				return this.attributeCertificateValid;
			}
			set
			{
				this.attributeCertificateValid = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060001AE RID: 430 RVA: 0x0000A336 File Offset: 0x00008536
		// (set) Token: 0x060001AF RID: 431 RVA: 0x0000A33E File Offset: 0x0000853E
		public global::Org.BouncyCastle.Utilities.Date.DateTimeObject AttributeCertificateValid
		{
			get
			{
				return this.attributeCertificateValid;
			}
			set
			{
				this.attributeCertificateValid = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x0000A347 File Offset: 0x00008547
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x0000A34F File Offset: 0x0000854F
		public global::Org.BouncyCastle.X509.AttributeCertificateHolder Holder
		{
			get
			{
				return this.holder;
			}
			set
			{
				this.holder = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x0000A358 File Offset: 0x00008558
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x0000A360 File Offset: 0x00008560
		public global::Org.BouncyCastle.X509.AttributeCertificateIssuer Issuer
		{
			get
			{
				return this.issuer;
			}
			set
			{
				this.issuer = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x0000A369 File Offset: 0x00008569
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x0000A371 File Offset: 0x00008571
		public global::Org.BouncyCastle.Math.BigInteger SerialNumber
		{
			get
			{
				return this.serialNumber;
			}
			set
			{
				this.serialNumber = value;
			}
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0000A37A File Offset: 0x0000857A
		public void AddTargetName(global::Org.BouncyCastle.Asn1.X509.GeneralName name)
		{
			this.targetNames.Add(name);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0000A388 File Offset: 0x00008588
		public void AddTargetName(byte[] name)
		{
			this.AddTargetName(global::Org.BouncyCastle.Asn1.X509.GeneralName.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(name)));
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0000A39B File Offset: 0x0000859B
		public void SetTargetNames(global::System.Collections.IEnumerable names)
		{
			this.targetNames = this.ExtractGeneralNames(names);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0000A3AA File Offset: 0x000085AA
		public global::System.Collections.IEnumerable GetTargetNames()
		{
			return new global::Org.BouncyCastle.Utilities.Collections.EnumerableProxy(this.targetNames);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0000A3B7 File Offset: 0x000085B7
		public void AddTargetGroup(global::Org.BouncyCastle.Asn1.X509.GeneralName group)
		{
			this.targetGroups.Add(group);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0000A3C5 File Offset: 0x000085C5
		public void AddTargetGroup(byte[] name)
		{
			this.AddTargetGroup(global::Org.BouncyCastle.Asn1.X509.GeneralName.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(name)));
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0000A3D8 File Offset: 0x000085D8
		public void SetTargetGroups(global::System.Collections.IEnumerable names)
		{
			this.targetGroups = this.ExtractGeneralNames(names);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0000A3E7 File Offset: 0x000085E7
		public global::System.Collections.IEnumerable GetTargetGroups()
		{
			return new global::Org.BouncyCastle.Utilities.Collections.EnumerableProxy(this.targetGroups);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000A3F4 File Offset: 0x000085F4
		private global::Org.BouncyCastle.Utilities.Collections.ISet ExtractGeneralNames(global::System.Collections.IEnumerable names)
		{
			global::Org.BouncyCastle.Utilities.Collections.ISet result = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
			if (names != null)
			{
				foreach (object o in names)
				{
					if (o is global::Org.BouncyCastle.Asn1.X509.GeneralName)
					{
						result.Add(o);
					}
					else
					{
						result.Add(global::Org.BouncyCastle.Asn1.X509.GeneralName.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray((byte[])o)));
					}
				}
			}
			return result;
		}

		// Token: 0x040000C5 RID: 197
		private global::Org.BouncyCastle.X509.IX509AttributeCertificate attributeCert;

		// Token: 0x040000C6 RID: 198
		private global::Org.BouncyCastle.Utilities.Date.DateTimeObject attributeCertificateValid;

		// Token: 0x040000C7 RID: 199
		private global::Org.BouncyCastle.X509.AttributeCertificateHolder holder;

		// Token: 0x040000C8 RID: 200
		private global::Org.BouncyCastle.X509.AttributeCertificateIssuer issuer;

		// Token: 0x040000C9 RID: 201
		private global::Org.BouncyCastle.Math.BigInteger serialNumber;

		// Token: 0x040000CA RID: 202
		private global::Org.BouncyCastle.Utilities.Collections.ISet targetNames = new global::Org.BouncyCastle.Utilities.Collections.HashSet();

		// Token: 0x040000CB RID: 203
		private global::Org.BouncyCastle.Utilities.Collections.ISet targetGroups = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
	}
}
