using System;
using System.Collections;
using Org.BouncyCastle.Asn1.X500;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.IsisMtt.X509
{
	// Token: 0x020006ED RID: 1773
	public class ProfessionInfo : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x0600404E RID: 16462 RVA: 0x00123A74 File Offset: 0x00121C74
		public static global::Org.BouncyCastle.Asn1.IsisMtt.X509.ProfessionInfo GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.IsisMtt.X509.ProfessionInfo)
			{
				return (global::Org.BouncyCastle.Asn1.IsisMtt.X509.ProfessionInfo)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.IsisMtt.X509.ProfessionInfo((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x0600404F RID: 16463 RVA: 0x00123AC4 File Offset: 0x00121CC4
		private ProfessionInfo(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count > 5)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString());
			}
			global::System.Collections.IEnumerator e = seq.GetEnumerator();
			e.MoveNext();
			global::Org.BouncyCastle.Asn1.Asn1Encodable o = (global::Org.BouncyCastle.Asn1.Asn1Encodable)e.Current;
			if (o is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
			{
				global::Org.BouncyCastle.Asn1.Asn1TaggedObject ato = (global::Org.BouncyCastle.Asn1.Asn1TaggedObject)o;
				if (ato.TagNo != 0)
				{
					throw new global::System.ArgumentException("Bad tag number: " + ato.TagNo.ToString());
				}
				this.namingAuthority = global::Org.BouncyCastle.Asn1.IsisMtt.X509.NamingAuthority.GetInstance(ato, true);
				e.MoveNext();
				o = (global::Org.BouncyCastle.Asn1.Asn1Encodable)e.Current;
			}
			this.professionItems = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(o);
			if (e.MoveNext())
			{
				o = (global::Org.BouncyCastle.Asn1.Asn1Encodable)e.Current;
				if (o is global::Org.BouncyCastle.Asn1.Asn1Sequence)
				{
					this.professionOids = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(o);
				}
				else if (o is global::Org.BouncyCastle.Asn1.DerPrintableString)
				{
					this.registrationNumber = global::Org.BouncyCastle.Asn1.DerPrintableString.GetInstance(o).GetString();
				}
				else
				{
					if (!(o is global::Org.BouncyCastle.Asn1.Asn1OctetString))
					{
						throw new global::System.ArgumentException("Bad object encountered: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(o));
					}
					this.addProfessionInfo = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(o);
				}
			}
			if (e.MoveNext())
			{
				o = (global::Org.BouncyCastle.Asn1.Asn1Encodable)e.Current;
				if (o is global::Org.BouncyCastle.Asn1.DerPrintableString)
				{
					this.registrationNumber = global::Org.BouncyCastle.Asn1.DerPrintableString.GetInstance(o).GetString();
				}
				else
				{
					if (!(o is global::Org.BouncyCastle.Asn1.DerOctetString))
					{
						throw new global::System.ArgumentException("Bad object encountered: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(o));
					}
					this.addProfessionInfo = (global::Org.BouncyCastle.Asn1.DerOctetString)o;
				}
			}
			if (!e.MoveNext())
			{
				return;
			}
			o = (global::Org.BouncyCastle.Asn1.Asn1Encodable)e.Current;
			if (o is global::Org.BouncyCastle.Asn1.DerOctetString)
			{
				this.addProfessionInfo = (global::Org.BouncyCastle.Asn1.DerOctetString)o;
				return;
			}
			throw new global::System.ArgumentException("Bad object encountered: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(o));
		}

		// Token: 0x06004050 RID: 16464 RVA: 0x00123C84 File Offset: 0x00121E84
		public ProfessionInfo(global::Org.BouncyCastle.Asn1.IsisMtt.X509.NamingAuthority namingAuthority, global::Org.BouncyCastle.Asn1.X500.DirectoryString[] professionItems, global::Org.BouncyCastle.Asn1.DerObjectIdentifier[] professionOids, string registrationNumber, global::Org.BouncyCastle.Asn1.Asn1OctetString addProfessionInfo)
		{
			this.namingAuthority = namingAuthority;
			this.professionItems = new global::Org.BouncyCastle.Asn1.DerSequence(professionItems);
			if (professionOids != null)
			{
				this.professionOids = new global::Org.BouncyCastle.Asn1.DerSequence(professionOids);
			}
			this.registrationNumber = registrationNumber;
			this.addProfessionInfo = addProfessionInfo;
		}

		// Token: 0x06004051 RID: 16465 RVA: 0x00123CD0 File Offset: 0x00121ED0
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			v.AddOptionalTagged(true, 0, this.namingAuthority);
			v.Add(this.professionItems);
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.professionOids
			});
			if (this.registrationNumber != null)
			{
				v.Add(new global::Org.BouncyCastle.Asn1.DerPrintableString(this.registrationNumber, true));
			}
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.addProfessionInfo
			});
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06004052 RID: 16466 RVA: 0x00123D47 File Offset: 0x00121F47
		public virtual global::Org.BouncyCastle.Asn1.Asn1OctetString AddProfessionInfo
		{
			get
			{
				return this.addProfessionInfo;
			}
		}

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x06004053 RID: 16467 RVA: 0x00123D4F File Offset: 0x00121F4F
		public virtual global::Org.BouncyCastle.Asn1.IsisMtt.X509.NamingAuthority NamingAuthority
		{
			get
			{
				return this.namingAuthority;
			}
		}

		// Token: 0x06004054 RID: 16468 RVA: 0x00123D58 File Offset: 0x00121F58
		public virtual global::Org.BouncyCastle.Asn1.X500.DirectoryString[] GetProfessionItems()
		{
			global::Org.BouncyCastle.Asn1.X500.DirectoryString[] result = new global::Org.BouncyCastle.Asn1.X500.DirectoryString[this.professionItems.Count];
			for (int i = 0; i < this.professionItems.Count; i++)
			{
				result[i] = global::Org.BouncyCastle.Asn1.X500.DirectoryString.GetInstance(this.professionItems[i]);
			}
			return result;
		}

		// Token: 0x06004055 RID: 16469 RVA: 0x00123DA4 File Offset: 0x00121FA4
		public virtual global::Org.BouncyCastle.Asn1.DerObjectIdentifier[] GetProfessionOids()
		{
			if (this.professionOids == null)
			{
				return new global::Org.BouncyCastle.Asn1.DerObjectIdentifier[0];
			}
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier[] result = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier[this.professionOids.Count];
			for (int i = 0; i < this.professionOids.Count; i++)
			{
				result[i] = global::Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(this.professionOids[i]);
			}
			return result;
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x06004056 RID: 16470 RVA: 0x00123DFC File Offset: 0x00121FFC
		public virtual string RegistrationNumber
		{
			get
			{
				return this.registrationNumber;
			}
		}

		// Token: 0x06004057 RID: 16471 RVA: 0x00123E04 File Offset: 0x00122004
		// Note: this type is marked as 'beforefieldinit'.
		static ProfessionInfo()
		{
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern = global::Org.BouncyCastle.Asn1.IsisMtt.X509.NamingAuthority.IdIsisMttATNamingAuthoritiesRechtWirtschaftSteuern;
			global::Org.BouncyCastle.Asn1.IsisMtt.X509.ProfessionInfo.Rechtsanwltin = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern != null) ? idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern.ToString() : null) + ".1");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern2 = global::Org.BouncyCastle.Asn1.IsisMtt.X509.NamingAuthority.IdIsisMttATNamingAuthoritiesRechtWirtschaftSteuern;
			global::Org.BouncyCastle.Asn1.IsisMtt.X509.ProfessionInfo.Rechtsanwalt = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern2 != null) ? idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern2.ToString() : null) + ".2");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern3 = global::Org.BouncyCastle.Asn1.IsisMtt.X509.NamingAuthority.IdIsisMttATNamingAuthoritiesRechtWirtschaftSteuern;
			global::Org.BouncyCastle.Asn1.IsisMtt.X509.ProfessionInfo.Rechtsbeistand = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern3 != null) ? idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern3.ToString() : null) + ".3");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern4 = global::Org.BouncyCastle.Asn1.IsisMtt.X509.NamingAuthority.IdIsisMttATNamingAuthoritiesRechtWirtschaftSteuern;
			global::Org.BouncyCastle.Asn1.IsisMtt.X509.ProfessionInfo.Steuerberaterin = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern4 != null) ? idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern4.ToString() : null) + ".4");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern5 = global::Org.BouncyCastle.Asn1.IsisMtt.X509.NamingAuthority.IdIsisMttATNamingAuthoritiesRechtWirtschaftSteuern;
			global::Org.BouncyCastle.Asn1.IsisMtt.X509.ProfessionInfo.Steuerberater = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern5 != null) ? idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern5.ToString() : null) + ".5");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern6 = global::Org.BouncyCastle.Asn1.IsisMtt.X509.NamingAuthority.IdIsisMttATNamingAuthoritiesRechtWirtschaftSteuern;
			global::Org.BouncyCastle.Asn1.IsisMtt.X509.ProfessionInfo.Steuerbevollmchtigte = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern6 != null) ? idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern6.ToString() : null) + ".6");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern7 = global::Org.BouncyCastle.Asn1.IsisMtt.X509.NamingAuthority.IdIsisMttATNamingAuthoritiesRechtWirtschaftSteuern;
			global::Org.BouncyCastle.Asn1.IsisMtt.X509.ProfessionInfo.Steuerbevollmchtigter = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern7 != null) ? idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern7.ToString() : null) + ".7");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern8 = global::Org.BouncyCastle.Asn1.IsisMtt.X509.NamingAuthority.IdIsisMttATNamingAuthoritiesRechtWirtschaftSteuern;
			global::Org.BouncyCastle.Asn1.IsisMtt.X509.ProfessionInfo.Notarin = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern8 != null) ? idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern8.ToString() : null) + ".8");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern9 = global::Org.BouncyCastle.Asn1.IsisMtt.X509.NamingAuthority.IdIsisMttATNamingAuthoritiesRechtWirtschaftSteuern;
			global::Org.BouncyCastle.Asn1.IsisMtt.X509.ProfessionInfo.Notar = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern9 != null) ? idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern9.ToString() : null) + ".9");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern10 = global::Org.BouncyCastle.Asn1.IsisMtt.X509.NamingAuthority.IdIsisMttATNamingAuthoritiesRechtWirtschaftSteuern;
			global::Org.BouncyCastle.Asn1.IsisMtt.X509.ProfessionInfo.Notarvertreterin = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern10 != null) ? idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern10.ToString() : null) + ".10");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern11 = global::Org.BouncyCastle.Asn1.IsisMtt.X509.NamingAuthority.IdIsisMttATNamingAuthoritiesRechtWirtschaftSteuern;
			global::Org.BouncyCastle.Asn1.IsisMtt.X509.ProfessionInfo.Notarvertreter = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern11 != null) ? idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern11.ToString() : null) + ".11");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern12 = global::Org.BouncyCastle.Asn1.IsisMtt.X509.NamingAuthority.IdIsisMttATNamingAuthoritiesRechtWirtschaftSteuern;
			global::Org.BouncyCastle.Asn1.IsisMtt.X509.ProfessionInfo.Notariatsverwalterin = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern12 != null) ? idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern12.ToString() : null) + ".12");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern13 = global::Org.BouncyCastle.Asn1.IsisMtt.X509.NamingAuthority.IdIsisMttATNamingAuthoritiesRechtWirtschaftSteuern;
			global::Org.BouncyCastle.Asn1.IsisMtt.X509.ProfessionInfo.Notariatsverwalter = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern13 != null) ? idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern13.ToString() : null) + ".13");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern14 = global::Org.BouncyCastle.Asn1.IsisMtt.X509.NamingAuthority.IdIsisMttATNamingAuthoritiesRechtWirtschaftSteuern;
			global::Org.BouncyCastle.Asn1.IsisMtt.X509.ProfessionInfo.Wirtschaftsprferin = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern14 != null) ? idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern14.ToString() : null) + ".14");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern15 = global::Org.BouncyCastle.Asn1.IsisMtt.X509.NamingAuthority.IdIsisMttATNamingAuthoritiesRechtWirtschaftSteuern;
			global::Org.BouncyCastle.Asn1.IsisMtt.X509.ProfessionInfo.Wirtschaftsprfer = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern15 != null) ? idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern15.ToString() : null) + ".15");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern16 = global::Org.BouncyCastle.Asn1.IsisMtt.X509.NamingAuthority.IdIsisMttATNamingAuthoritiesRechtWirtschaftSteuern;
			global::Org.BouncyCastle.Asn1.IsisMtt.X509.ProfessionInfo.VereidigteBuchprferin = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern16 != null) ? idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern16.ToString() : null) + ".16");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern17 = global::Org.BouncyCastle.Asn1.IsisMtt.X509.NamingAuthority.IdIsisMttATNamingAuthoritiesRechtWirtschaftSteuern;
			global::Org.BouncyCastle.Asn1.IsisMtt.X509.ProfessionInfo.VereidigterBuchprfer = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern17 != null) ? idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern17.ToString() : null) + ".17");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern18 = global::Org.BouncyCastle.Asn1.IsisMtt.X509.NamingAuthority.IdIsisMttATNamingAuthoritiesRechtWirtschaftSteuern;
			global::Org.BouncyCastle.Asn1.IsisMtt.X509.ProfessionInfo.Patentanwltin = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern18 != null) ? idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern18.ToString() : null) + ".18");
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern19 = global::Org.BouncyCastle.Asn1.IsisMtt.X509.NamingAuthority.IdIsisMttATNamingAuthoritiesRechtWirtschaftSteuern;
			global::Org.BouncyCastle.Asn1.IsisMtt.X509.ProfessionInfo.Patentanwalt = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(((idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern19 != null) ? idIsisMttATNamingAuthoritiesRechtWirtschaftSteuern19.ToString() : null) + ".19");
		}

		// Token: 0x04001E6B RID: 7787
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Rechtsanwltin;

		// Token: 0x04001E6C RID: 7788
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Rechtsanwalt;

		// Token: 0x04001E6D RID: 7789
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Rechtsbeistand;

		// Token: 0x04001E6E RID: 7790
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Steuerberaterin;

		// Token: 0x04001E6F RID: 7791
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Steuerberater;

		// Token: 0x04001E70 RID: 7792
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Steuerbevollmchtigte;

		// Token: 0x04001E71 RID: 7793
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Steuerbevollmchtigter;

		// Token: 0x04001E72 RID: 7794
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Notarin;

		// Token: 0x04001E73 RID: 7795
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Notar;

		// Token: 0x04001E74 RID: 7796
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Notarvertreterin;

		// Token: 0x04001E75 RID: 7797
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Notarvertreter;

		// Token: 0x04001E76 RID: 7798
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Notariatsverwalterin;

		// Token: 0x04001E77 RID: 7799
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Notariatsverwalter;

		// Token: 0x04001E78 RID: 7800
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Wirtschaftsprferin;

		// Token: 0x04001E79 RID: 7801
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Wirtschaftsprfer;

		// Token: 0x04001E7A RID: 7802
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier VereidigteBuchprferin;

		// Token: 0x04001E7B RID: 7803
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier VereidigterBuchprfer;

		// Token: 0x04001E7C RID: 7804
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Patentanwltin;

		// Token: 0x04001E7D RID: 7805
		public static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier Patentanwalt;

		// Token: 0x04001E7E RID: 7806
		private readonly global::Org.BouncyCastle.Asn1.IsisMtt.X509.NamingAuthority namingAuthority;

		// Token: 0x04001E7F RID: 7807
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence professionItems;

		// Token: 0x04001E80 RID: 7808
		private readonly global::Org.BouncyCastle.Asn1.Asn1Sequence professionOids;

		// Token: 0x04001E81 RID: 7809
		private readonly string registrationNumber;

		// Token: 0x04001E82 RID: 7810
		private readonly global::Org.BouncyCastle.Asn1.Asn1OctetString addProfessionInfo;
	}
}
