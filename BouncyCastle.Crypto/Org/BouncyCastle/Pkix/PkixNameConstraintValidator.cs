using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X500;
using Org.BouncyCastle.Asn1.X500.Style;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Pkix
{
	// Token: 0x020001A1 RID: 417
	public class PkixNameConstraintValidator
	{
		// Token: 0x06000F54 RID: 3924 RVA: 0x00039BF8 File Offset: 0x00037DF8
		private static bool WithinDNSubtree(global::Org.BouncyCastle.Asn1.Asn1Sequence dns, global::Org.BouncyCastle.Asn1.Asn1Sequence subtree)
		{
			if (subtree.Count < 1 || subtree.Count > dns.Count)
			{
				return false;
			}
			int start = 0;
			global::Org.BouncyCastle.Asn1.X500.Rdn subtreeRdnStart = global::Org.BouncyCastle.Asn1.X500.Rdn.GetInstance(subtree[0]);
			for (int i = 0; i < dns.Count; i++)
			{
				start = i;
				global::Org.BouncyCastle.Asn1.X500.Rdn dnsRdn = global::Org.BouncyCastle.Asn1.X500.Rdn.GetInstance(dns[i]);
				if (global::Org.BouncyCastle.Asn1.X500.Style.IetfUtilities.RdnAreEqual(subtreeRdnStart, dnsRdn))
				{
					break;
				}
			}
			if (subtree.Count > dns.Count - start)
			{
				return false;
			}
			for (int j = 0; j < subtree.Count; j++)
			{
				global::Org.BouncyCastle.Asn1.X500.Rdn subtreeRdn = global::Org.BouncyCastle.Asn1.X500.Rdn.GetInstance(subtree[j]);
				global::Org.BouncyCastle.Asn1.X500.Rdn dnsRdn2 = global::Org.BouncyCastle.Asn1.X500.Rdn.GetInstance(dns[start + j]);
				if (subtreeRdn.Count == 1 && dnsRdn2.Count == 1 && subtreeRdn.GetFirst().GetType().Equals(global::Org.BouncyCastle.Pkix.PkixNameConstraintValidator.SerialNumberOid) && dnsRdn2.GetFirst().GetType().Equals(global::Org.BouncyCastle.Pkix.PkixNameConstraintValidator.SerialNumberOid))
				{
					if (!global::Org.BouncyCastle.Utilities.Platform.StartsWith(dnsRdn2.GetFirst().Value.ToString(), subtreeRdn.GetFirst().Value.ToString()))
					{
						return false;
					}
				}
				else if (!global::Org.BouncyCastle.Asn1.X500.Style.IetfUtilities.RdnAreEqual(subtreeRdn, dnsRdn2))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x00039D20 File Offset: 0x00037F20
		public void CheckPermittedDN(global::Org.BouncyCastle.Asn1.Asn1Sequence dn)
		{
			this.CheckPermittedDirectory(this.permittedSubtreesDN, dn);
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x00039D2F File Offset: 0x00037F2F
		public void CheckExcludedDN(global::Org.BouncyCastle.Asn1.Asn1Sequence dn)
		{
			this.CheckExcludedDirectory(this.excludedSubtreesDN, dn);
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x00039D40 File Offset: 0x00037F40
		private global::Org.BouncyCastle.Utilities.Collections.ISet IntersectDN(global::Org.BouncyCastle.Utilities.Collections.ISet permitted, global::Org.BouncyCastle.Utilities.Collections.ISet dns)
		{
			global::Org.BouncyCastle.Utilities.Collections.ISet intersect = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
			foreach (object obj in dns)
			{
				global::Org.BouncyCastle.Asn1.Asn1Sequence dn = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(((global::Org.BouncyCastle.Asn1.X509.GeneralSubtree)obj).Base.Name);
				if (permitted == null)
				{
					if (dn != null)
					{
						intersect.Add(dn);
					}
				}
				else
				{
					foreach (object obj2 in permitted)
					{
						global::Org.BouncyCastle.Asn1.Asn1Sequence dn2 = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj2);
						if (global::Org.BouncyCastle.Pkix.PkixNameConstraintValidator.WithinDNSubtree(dn, dn2))
						{
							intersect.Add(dn);
						}
						else if (global::Org.BouncyCastle.Pkix.PkixNameConstraintValidator.WithinDNSubtree(dn2, dn))
						{
							intersect.Add(dn2);
						}
					}
				}
			}
			return intersect;
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x00039E20 File Offset: 0x00038020
		private global::Org.BouncyCastle.Utilities.Collections.ISet UnionDN(global::Org.BouncyCastle.Utilities.Collections.ISet excluded, global::Org.BouncyCastle.Asn1.Asn1Sequence dn)
		{
			if (!excluded.IsEmpty)
			{
				global::Org.BouncyCastle.Utilities.Collections.ISet union = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
				foreach (object obj in excluded)
				{
					global::Org.BouncyCastle.Asn1.Asn1Sequence subtree = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj);
					if (global::Org.BouncyCastle.Pkix.PkixNameConstraintValidator.WithinDNSubtree(dn, subtree))
					{
						union.Add(subtree);
					}
					else if (global::Org.BouncyCastle.Pkix.PkixNameConstraintValidator.WithinDNSubtree(subtree, dn))
					{
						union.Add(dn);
					}
					else
					{
						union.Add(subtree);
						union.Add(dn);
					}
				}
				return union;
			}
			if (dn == null)
			{
				return excluded;
			}
			excluded.Add(dn);
			return excluded;
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x00039EBC File Offset: 0x000380BC
		private global::Org.BouncyCastle.Utilities.Collections.ISet IntersectOtherName(global::Org.BouncyCastle.Utilities.Collections.ISet permitted, global::Org.BouncyCastle.Utilities.Collections.ISet otherNames)
		{
			global::Org.BouncyCastle.Utilities.Collections.ISet intersect = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
			foreach (object obj in otherNames)
			{
				global::Org.BouncyCastle.Asn1.X509.OtherName otherName = global::Org.BouncyCastle.Asn1.X509.OtherName.GetInstance(((global::Org.BouncyCastle.Asn1.X509.GeneralSubtree)obj).Base.Name);
				if (otherName != null)
				{
					if (permitted == null)
					{
						intersect.Add(otherName);
					}
					else
					{
						foreach (object obj2 in permitted)
						{
							global::Org.BouncyCastle.Asn1.X509.OtherName otherName2 = global::Org.BouncyCastle.Asn1.X509.OtherName.GetInstance(obj2);
							if (otherName2 != null)
							{
								this.IntersectOtherName(otherName, otherName2, intersect);
							}
						}
					}
				}
			}
			return intersect;
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x00039F80 File Offset: 0x00038180
		private void IntersectOtherName(global::Org.BouncyCastle.Asn1.X509.OtherName otherName1, global::Org.BouncyCastle.Asn1.X509.OtherName otherName2, global::Org.BouncyCastle.Utilities.Collections.ISet intersect)
		{
			if (otherName1.Equals(otherName2))
			{
				intersect.Add(otherName1);
			}
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x00039F92 File Offset: 0x00038192
		private global::Org.BouncyCastle.Utilities.Collections.ISet UnionOtherName(global::Org.BouncyCastle.Utilities.Collections.ISet permitted, global::Org.BouncyCastle.Asn1.X509.OtherName otherName)
		{
			global::Org.BouncyCastle.Utilities.Collections.HashSet hashSet = (permitted != null) ? new global::Org.BouncyCastle.Utilities.Collections.HashSet(permitted) : new global::Org.BouncyCastle.Utilities.Collections.HashSet();
			((global::Org.BouncyCastle.Utilities.Collections.ISet)hashSet).Add(otherName);
			return hashSet;
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x00039FAC File Offset: 0x000381AC
		private global::Org.BouncyCastle.Utilities.Collections.ISet IntersectEmail(global::Org.BouncyCastle.Utilities.Collections.ISet permitted, global::Org.BouncyCastle.Utilities.Collections.ISet emails)
		{
			global::Org.BouncyCastle.Utilities.Collections.ISet intersect = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
			foreach (object obj in emails)
			{
				global::Org.BouncyCastle.Asn1.X509.GeneralSubtree subtree = (global::Org.BouncyCastle.Asn1.X509.GeneralSubtree)obj;
				string email = this.ExtractNameAsString(subtree.Base);
				if (permitted == null)
				{
					if (email != null)
					{
						intersect.Add(email);
					}
				}
				else
				{
					foreach (object obj2 in permitted)
					{
						string _permitted = (string)obj2;
						this.IntersectEmail(email, _permitted, intersect);
					}
				}
			}
			return intersect;
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x0003A070 File Offset: 0x00038270
		private global::Org.BouncyCastle.Utilities.Collections.ISet UnionEmail(global::Org.BouncyCastle.Utilities.Collections.ISet excluded, string email)
		{
			if (!excluded.IsEmpty)
			{
				global::Org.BouncyCastle.Utilities.Collections.ISet union = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
				foreach (object obj in excluded)
				{
					string _excluded = (string)obj;
					this.UnionEmail(_excluded, email, union);
				}
				return union;
			}
			if (email == null)
			{
				return excluded;
			}
			excluded.Add(email);
			return excluded;
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x0003A0E4 File Offset: 0x000382E4
		private global::Org.BouncyCastle.Utilities.Collections.ISet IntersectIP(global::Org.BouncyCastle.Utilities.Collections.ISet permitted, global::Org.BouncyCastle.Utilities.Collections.ISet ips)
		{
			global::Org.BouncyCastle.Utilities.Collections.ISet intersect = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
			foreach (object obj in ips)
			{
				byte[] ip = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(((global::Org.BouncyCastle.Asn1.X509.GeneralSubtree)obj).Base.Name).GetOctets();
				if (permitted == null)
				{
					if (ip != null)
					{
						intersect.Add(ip);
					}
				}
				else
				{
					foreach (object obj2 in permitted)
					{
						byte[] _permitted = (byte[])obj2;
						intersect.AddAll(this.IntersectIPRange(_permitted, ip));
					}
				}
			}
			return intersect;
		}

		// Token: 0x06000F5F RID: 3935 RVA: 0x0003A1B0 File Offset: 0x000383B0
		private global::Org.BouncyCastle.Utilities.Collections.ISet UnionIP(global::Org.BouncyCastle.Utilities.Collections.ISet excluded, byte[] ip)
		{
			if (!excluded.IsEmpty)
			{
				global::Org.BouncyCastle.Utilities.Collections.ISet union = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
				foreach (object obj in excluded)
				{
					byte[] _excluded = (byte[])obj;
					union.AddAll(this.UnionIPRange(_excluded, ip));
				}
				return union;
			}
			if (ip == null)
			{
				return excluded;
			}
			excluded.Add(ip);
			return excluded;
		}

		// Token: 0x06000F60 RID: 3936 RVA: 0x0003A228 File Offset: 0x00038428
		private global::Org.BouncyCastle.Utilities.Collections.ISet UnionIPRange(byte[] ipWithSubmask1, byte[] ipWithSubmask2)
		{
			global::Org.BouncyCastle.Utilities.Collections.ISet set = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
			if (global::Org.BouncyCastle.Utilities.Arrays.AreEqual(ipWithSubmask1, ipWithSubmask2))
			{
				set.Add(ipWithSubmask1);
			}
			else
			{
				set.Add(ipWithSubmask1);
				set.Add(ipWithSubmask2);
			}
			return set;
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x0003A25C File Offset: 0x0003845C
		private global::Org.BouncyCastle.Utilities.Collections.ISet IntersectIPRange(byte[] ipWithSubmask1, byte[] ipWithSubmask2)
		{
			if (ipWithSubmask1.Length != ipWithSubmask2.Length)
			{
				return new global::Org.BouncyCastle.Utilities.Collections.HashSet();
			}
			byte[][] array = this.ExtractIPsAndSubnetMasks(ipWithSubmask1, ipWithSubmask2);
			byte[] ip = array[0];
			byte[] subnetmask = array[1];
			byte[] ip2 = array[2];
			byte[] subnetmask2 = array[3];
			byte[][] minMax = this.MinMaxIPs(ip, subnetmask, ip2, subnetmask2);
			byte[] max = global::Org.BouncyCastle.Pkix.PkixNameConstraintValidator.Min(minMax[1], minMax[3]);
			if (global::Org.BouncyCastle.Pkix.PkixNameConstraintValidator.CompareTo(global::Org.BouncyCastle.Pkix.PkixNameConstraintValidator.Max(minMax[0], minMax[2]), max) == 1)
			{
				return new global::Org.BouncyCastle.Utilities.Collections.HashSet();
			}
			byte[] ip3 = global::Org.BouncyCastle.Pkix.PkixNameConstraintValidator.Or(minMax[0], minMax[2]);
			byte[] subnetmask3 = global::Org.BouncyCastle.Pkix.PkixNameConstraintValidator.Or(subnetmask, subnetmask2);
			return new global::Org.BouncyCastle.Utilities.Collections.HashSet
			{
				this.IpWithSubnetMask(ip3, subnetmask3)
			};
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x0003A2F4 File Offset: 0x000384F4
		private byte[] IpWithSubnetMask(byte[] ip, byte[] subnetMask)
		{
			int ipLength = ip.Length;
			byte[] temp = new byte[ipLength * 2];
			global::System.Array.Copy(ip, 0, temp, 0, ipLength);
			global::System.Array.Copy(subnetMask, 0, temp, ipLength, ipLength);
			return temp;
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x0003A324 File Offset: 0x00038524
		private byte[][] ExtractIPsAndSubnetMasks(byte[] ipWithSubmask1, byte[] ipWithSubmask2)
		{
			int ipLength = ipWithSubmask1.Length / 2;
			byte[] ip = new byte[ipLength];
			byte[] subnetmask = new byte[ipLength];
			global::System.Array.Copy(ipWithSubmask1, 0, ip, 0, ipLength);
			global::System.Array.Copy(ipWithSubmask1, ipLength, subnetmask, 0, ipLength);
			byte[] ip2 = new byte[ipLength];
			byte[] subnetmask2 = new byte[ipLength];
			global::System.Array.Copy(ipWithSubmask2, 0, ip2, 0, ipLength);
			global::System.Array.Copy(ipWithSubmask2, ipLength, subnetmask2, 0, ipLength);
			return new byte[][]
			{
				ip,
				subnetmask,
				ip2,
				subnetmask2
			};
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x0003A394 File Offset: 0x00038594
		private byte[][] MinMaxIPs(byte[] ip1, byte[] subnetmask1, byte[] ip2, byte[] subnetmask2)
		{
			int ipLength = ip1.Length;
			byte[] min = new byte[ipLength];
			byte[] max = new byte[ipLength];
			byte[] min2 = new byte[ipLength];
			byte[] max2 = new byte[ipLength];
			for (int i = 0; i < ipLength; i++)
			{
				min[i] = (ip1[i] & subnetmask1[i]);
				max[i] = ((ip1[i] & subnetmask1[i]) | ~subnetmask1[i]);
				min2[i] = (ip2[i] & subnetmask2[i]);
				max2[i] = ((ip2[i] & subnetmask2[i]) | ~subnetmask2[i]);
			}
			return new byte[][]
			{
				min,
				max,
				min2,
				max2
			};
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x0003A431 File Offset: 0x00038631
		private bool IsOtherNameConstrained(global::Org.BouncyCastle.Asn1.X509.OtherName constraint, global::Org.BouncyCastle.Asn1.X509.OtherName otherName)
		{
			return constraint.Equals(otherName);
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x0003A43C File Offset: 0x0003863C
		private bool IsOtherNameConstrained(global::Org.BouncyCastle.Utilities.Collections.ISet constraints, global::Org.BouncyCastle.Asn1.X509.OtherName otherName)
		{
			foreach (object obj in constraints)
			{
				global::Org.BouncyCastle.Asn1.X509.OtherName constraint = global::Org.BouncyCastle.Asn1.X509.OtherName.GetInstance(obj);
				if (this.IsOtherNameConstrained(constraint, otherName))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000F67 RID: 3943 RVA: 0x0003A49C File Offset: 0x0003869C
		private void CheckPermittedOtherName(global::Org.BouncyCastle.Utilities.Collections.ISet permitted, global::Org.BouncyCastle.Asn1.X509.OtherName name)
		{
			if (permitted != null && !this.IsOtherNameConstrained(permitted, name))
			{
				throw new global::Org.BouncyCastle.Pkix.PkixNameConstraintValidatorException("Subject OtherName is not from a permitted subtree.");
			}
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x0003A4B6 File Offset: 0x000386B6
		private void CheckExcludedOtherName(global::Org.BouncyCastle.Utilities.Collections.ISet excluded, global::Org.BouncyCastle.Asn1.X509.OtherName name)
		{
			if (this.IsOtherNameConstrained(excluded, name))
			{
				throw new global::Org.BouncyCastle.Pkix.PkixNameConstraintValidatorException("OtherName is from an excluded subtree.");
			}
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x0003A4D0 File Offset: 0x000386D0
		private bool IsEmailConstrained(string constraint, string email)
		{
			string sub = email.Substring(email.IndexOf('@') + 1);
			if (constraint.IndexOf('@') != -1)
			{
				if (global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(email).Equals(global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(constraint)))
				{
					return true;
				}
			}
			else if (!constraint[0].Equals('.'))
			{
				if (global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(sub).Equals(global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(constraint)))
				{
					return true;
				}
			}
			else if (this.WithinDomain(sub, constraint))
			{
				return true;
			}
			return false;
		}

		// Token: 0x06000F6A RID: 3946 RVA: 0x0003A544 File Offset: 0x00038744
		private bool IsEmailConstrained(global::Org.BouncyCastle.Utilities.Collections.ISet constraints, string email)
		{
			foreach (object obj in constraints)
			{
				string constraint = (string)obj;
				if (this.IsEmailConstrained(constraint, email))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000F6B RID: 3947 RVA: 0x0003A5A4 File Offset: 0x000387A4
		private void CheckPermittedEmail(global::Org.BouncyCastle.Utilities.Collections.ISet permitted, string email)
		{
			if (permitted != null && (email.Length != 0 || !permitted.IsEmpty) && !this.IsEmailConstrained(permitted, email))
			{
				throw new global::Org.BouncyCastle.Pkix.PkixNameConstraintValidatorException("Subject email address is not from a permitted subtree.");
			}
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x0003A5CE File Offset: 0x000387CE
		private void CheckExcludedEmail(global::Org.BouncyCastle.Utilities.Collections.ISet excluded, string email)
		{
			if (this.IsEmailConstrained(excluded, email))
			{
				throw new global::Org.BouncyCastle.Pkix.PkixNameConstraintValidatorException("Email address is from an excluded subtree.");
			}
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x0003A5E5 File Offset: 0x000387E5
		private bool IsDnsConstrained(string constraint, string dns)
		{
			return this.WithinDomain(dns, constraint) || global::Org.BouncyCastle.Utilities.Platform.EqualsIgnoreCase(dns, constraint);
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x0003A5FC File Offset: 0x000387FC
		private bool IsDnsConstrained(global::Org.BouncyCastle.Utilities.Collections.ISet constraints, string dns)
		{
			foreach (object obj in constraints)
			{
				string constraint = (string)obj;
				if (this.IsDnsConstrained(constraint, dns))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x0003A65C File Offset: 0x0003885C
		private void CheckPermittedDns(global::Org.BouncyCastle.Utilities.Collections.ISet permitted, string dns)
		{
			if (permitted != null && (dns.Length != 0 || !permitted.IsEmpty) && !this.IsDnsConstrained(permitted, dns))
			{
				throw new global::Org.BouncyCastle.Pkix.PkixNameConstraintValidatorException("DNS is not from a permitted subtree.");
			}
		}

		// Token: 0x06000F70 RID: 3952 RVA: 0x0003A686 File Offset: 0x00038886
		private void CheckExcludedDns(global::Org.BouncyCastle.Utilities.Collections.ISet excluded, string dns)
		{
			if (this.IsDnsConstrained(excluded, dns))
			{
				throw new global::Org.BouncyCastle.Pkix.PkixNameConstraintValidatorException("DNS is from an excluded subtree.");
			}
		}

		// Token: 0x06000F71 RID: 3953 RVA: 0x0003A6A0 File Offset: 0x000388A0
		private bool IsDirectoryConstrained(global::Org.BouncyCastle.Utilities.Collections.ISet constraints, global::Org.BouncyCastle.Asn1.Asn1Sequence directory)
		{
			foreach (object obj in constraints)
			{
				global::Org.BouncyCastle.Asn1.Asn1Sequence constraint = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj);
				if (global::Org.BouncyCastle.Pkix.PkixNameConstraintValidator.WithinDNSubtree(directory, constraint))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x0003A700 File Offset: 0x00038900
		private void CheckPermittedDirectory(global::Org.BouncyCastle.Utilities.Collections.ISet permitted, global::Org.BouncyCastle.Asn1.Asn1Sequence directory)
		{
			if (permitted != null && (directory.Count != 0 || !permitted.IsEmpty) && !this.IsDirectoryConstrained(permitted, directory))
			{
				throw new global::Org.BouncyCastle.Pkix.PkixNameConstraintValidatorException("Subject distinguished name is not from a permitted subtree");
			}
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x0003A72A File Offset: 0x0003892A
		private void CheckExcludedDirectory(global::Org.BouncyCastle.Utilities.Collections.ISet excluded, global::Org.BouncyCastle.Asn1.Asn1Sequence directory)
		{
			if (this.IsDirectoryConstrained(excluded, directory))
			{
				throw new global::Org.BouncyCastle.Pkix.PkixNameConstraintValidatorException("Subject distinguished name is from an excluded subtree");
			}
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x0003A744 File Offset: 0x00038944
		private bool IsUriConstrained(string constraint, string uri)
		{
			string host = global::Org.BouncyCastle.Pkix.PkixNameConstraintValidator.ExtractHostFromURL(uri);
			if (global::Org.BouncyCastle.Utilities.Platform.StartsWith(constraint, "."))
			{
				return this.WithinDomain(host, constraint);
			}
			return global::Org.BouncyCastle.Utilities.Platform.EqualsIgnoreCase(host, constraint);
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x0003A778 File Offset: 0x00038978
		private bool IsUriConstrained(global::Org.BouncyCastle.Utilities.Collections.ISet constraints, string uri)
		{
			foreach (object obj in constraints)
			{
				string constraint = (string)obj;
				if (this.IsUriConstrained(constraint, uri))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x0003A7D8 File Offset: 0x000389D8
		private void CheckPermittedUri(global::Org.BouncyCastle.Utilities.Collections.ISet permitted, string uri)
		{
			if (permitted != null && (uri.Length != 0 || !permitted.IsEmpty) && !this.IsUriConstrained(permitted, uri))
			{
				throw new global::Org.BouncyCastle.Pkix.PkixNameConstraintValidatorException("URI is not from a permitted subtree.");
			}
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x0003A802 File Offset: 0x00038A02
		private void CheckExcludedUri(global::Org.BouncyCastle.Utilities.Collections.ISet excluded, string uri)
		{
			if (this.IsUriConstrained(excluded, uri))
			{
				throw new global::Org.BouncyCastle.Pkix.PkixNameConstraintValidatorException("URI is from an excluded subtree.");
			}
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x0003A81C File Offset: 0x00038A1C
		private bool IsIPConstrained(byte[] constraint, byte[] ip)
		{
			int ipLength = ip.Length;
			if (ipLength != constraint.Length / 2)
			{
				return false;
			}
			byte[] subnetMask = new byte[ipLength];
			global::System.Array.Copy(constraint, ipLength, subnetMask, 0, ipLength);
			byte[] permittedSubnetAddress = new byte[ipLength];
			byte[] ipSubnetAddress = new byte[ipLength];
			for (int i = 0; i < ipLength; i++)
			{
				permittedSubnetAddress[i] = (constraint[i] & subnetMask[i]);
				ipSubnetAddress[i] = (ip[i] & subnetMask[i]);
			}
			return global::Org.BouncyCastle.Utilities.Arrays.AreEqual(permittedSubnetAddress, ipSubnetAddress);
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x0003A88C File Offset: 0x00038A8C
		private bool IsIPConstrained(global::Org.BouncyCastle.Utilities.Collections.ISet constraints, byte[] ip)
		{
			foreach (object obj in constraints)
			{
				byte[] constraint = (byte[])obj;
				if (this.IsIPConstrained(constraint, ip))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x0003A8EC File Offset: 0x00038AEC
		private void CheckPermittedIP(global::Org.BouncyCastle.Utilities.Collections.ISet permitted, byte[] ip)
		{
			if (permitted != null && (ip.Length != 0 || !permitted.IsEmpty) && !this.IsIPConstrained(permitted, ip))
			{
				throw new global::Org.BouncyCastle.Pkix.PkixNameConstraintValidatorException("IP is not from a permitted subtree.");
			}
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x0003A912 File Offset: 0x00038B12
		private void CheckExcludedIP(global::Org.BouncyCastle.Utilities.Collections.ISet excluded, byte[] ip)
		{
			if (this.IsIPConstrained(excluded, ip))
			{
				throw new global::Org.BouncyCastle.Pkix.PkixNameConstraintValidatorException("IP is from an excluded subtree.");
			}
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x0003A92C File Offset: 0x00038B2C
		private bool WithinDomain(string testDomain, string domain)
		{
			string tempDomain = domain;
			if (global::Org.BouncyCastle.Utilities.Platform.StartsWith(tempDomain, "."))
			{
				tempDomain = tempDomain.Substring(1);
			}
			string[] domainParts = tempDomain.Split(new char[]
			{
				'.'
			});
			string[] testDomainParts = testDomain.Split(new char[]
			{
				'.'
			});
			if (testDomainParts.Length <= domainParts.Length)
			{
				return false;
			}
			int d = testDomainParts.Length - domainParts.Length;
			for (int i = -1; i < domainParts.Length; i++)
			{
				if (i == -1)
				{
					if (testDomainParts[i + d].Length < 1)
					{
						return false;
					}
				}
				else if (!global::Org.BouncyCastle.Utilities.Platform.EqualsIgnoreCase(testDomainParts[i + d], domainParts[i]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x0003A9C4 File Offset: 0x00038BC4
		private void UnionEmail(string email1, string email2, global::Org.BouncyCastle.Utilities.Collections.ISet union)
		{
			if (email1.IndexOf('@') != -1)
			{
				string _sub = email1.Substring(email1.IndexOf('@') + 1);
				if (email2.IndexOf('@') != -1)
				{
					if (global::Org.BouncyCastle.Utilities.Platform.EqualsIgnoreCase(email1, email2))
					{
						union.Add(email1);
						return;
					}
					union.Add(email1);
					union.Add(email2);
					return;
				}
				else if (global::Org.BouncyCastle.Utilities.Platform.StartsWith(email2, "."))
				{
					if (this.WithinDomain(_sub, email2))
					{
						union.Add(email2);
						return;
					}
					union.Add(email1);
					union.Add(email2);
					return;
				}
				else
				{
					if (global::Org.BouncyCastle.Utilities.Platform.EqualsIgnoreCase(_sub, email2))
					{
						union.Add(email2);
						return;
					}
					union.Add(email1);
					union.Add(email2);
					return;
				}
			}
			else if (global::Org.BouncyCastle.Utilities.Platform.StartsWith(email1, "."))
			{
				if (email2.IndexOf('@') != -1)
				{
					string _sub2 = email2.Substring(email1.IndexOf('@') + 1);
					if (this.WithinDomain(_sub2, email1))
					{
						union.Add(email1);
						return;
					}
					union.Add(email1);
					union.Add(email2);
					return;
				}
				else if (global::Org.BouncyCastle.Utilities.Platform.StartsWith(email2, "."))
				{
					if (this.WithinDomain(email1, email2) || global::Org.BouncyCastle.Utilities.Platform.EqualsIgnoreCase(email1, email2))
					{
						union.Add(email2);
						return;
					}
					if (this.WithinDomain(email2, email1))
					{
						union.Add(email1);
						return;
					}
					union.Add(email1);
					union.Add(email2);
					return;
				}
				else
				{
					if (this.WithinDomain(email2, email1))
					{
						union.Add(email1);
						return;
					}
					union.Add(email1);
					union.Add(email2);
					return;
				}
			}
			else if (email2.IndexOf('@') != -1)
			{
				if (global::Org.BouncyCastle.Utilities.Platform.EqualsIgnoreCase(email2.Substring(email1.IndexOf('@') + 1), email1))
				{
					union.Add(email1);
					return;
				}
				union.Add(email1);
				union.Add(email2);
				return;
			}
			else if (global::Org.BouncyCastle.Utilities.Platform.StartsWith(email2, "."))
			{
				if (this.WithinDomain(email1, email2))
				{
					union.Add(email2);
					return;
				}
				union.Add(email1);
				union.Add(email2);
				return;
			}
			else
			{
				if (global::Org.BouncyCastle.Utilities.Platform.EqualsIgnoreCase(email1, email2))
				{
					union.Add(email1);
					return;
				}
				union.Add(email1);
				union.Add(email2);
				return;
			}
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x0003ABA8 File Offset: 0x00038DA8
		private void unionURI(string email1, string email2, global::Org.BouncyCastle.Utilities.Collections.ISet union)
		{
			if (email1.IndexOf('@') != -1)
			{
				string _sub = email1.Substring(email1.IndexOf('@') + 1);
				if (email2.IndexOf('@') != -1)
				{
					if (global::Org.BouncyCastle.Utilities.Platform.EqualsIgnoreCase(email1, email2))
					{
						union.Add(email1);
						return;
					}
					union.Add(email1);
					union.Add(email2);
					return;
				}
				else if (global::Org.BouncyCastle.Utilities.Platform.StartsWith(email2, "."))
				{
					if (this.WithinDomain(_sub, email2))
					{
						union.Add(email2);
						return;
					}
					union.Add(email1);
					union.Add(email2);
					return;
				}
				else
				{
					if (global::Org.BouncyCastle.Utilities.Platform.EqualsIgnoreCase(_sub, email2))
					{
						union.Add(email2);
						return;
					}
					union.Add(email1);
					union.Add(email2);
					return;
				}
			}
			else if (global::Org.BouncyCastle.Utilities.Platform.StartsWith(email1, "."))
			{
				if (email2.IndexOf('@') != -1)
				{
					string _sub2 = email2.Substring(email1.IndexOf('@') + 1);
					if (this.WithinDomain(_sub2, email1))
					{
						union.Add(email1);
						return;
					}
					union.Add(email1);
					union.Add(email2);
					return;
				}
				else if (global::Org.BouncyCastle.Utilities.Platform.StartsWith(email2, "."))
				{
					if (this.WithinDomain(email1, email2) || global::Org.BouncyCastle.Utilities.Platform.EqualsIgnoreCase(email1, email2))
					{
						union.Add(email2);
						return;
					}
					if (this.WithinDomain(email2, email1))
					{
						union.Add(email1);
						return;
					}
					union.Add(email1);
					union.Add(email2);
					return;
				}
				else
				{
					if (this.WithinDomain(email2, email1))
					{
						union.Add(email1);
						return;
					}
					union.Add(email1);
					union.Add(email2);
					return;
				}
			}
			else if (email2.IndexOf('@') != -1)
			{
				if (global::Org.BouncyCastle.Utilities.Platform.EqualsIgnoreCase(email2.Substring(email1.IndexOf('@') + 1), email1))
				{
					union.Add(email1);
					return;
				}
				union.Add(email1);
				union.Add(email2);
				return;
			}
			else if (global::Org.BouncyCastle.Utilities.Platform.StartsWith(email2, "."))
			{
				if (this.WithinDomain(email1, email2))
				{
					union.Add(email2);
					return;
				}
				union.Add(email1);
				union.Add(email2);
				return;
			}
			else
			{
				if (global::Org.BouncyCastle.Utilities.Platform.EqualsIgnoreCase(email1, email2))
				{
					union.Add(email1);
					return;
				}
				union.Add(email1);
				union.Add(email2);
				return;
			}
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x0003AD8C File Offset: 0x00038F8C
		private global::Org.BouncyCastle.Utilities.Collections.ISet IntersectDns(global::Org.BouncyCastle.Utilities.Collections.ISet permitted, global::Org.BouncyCastle.Utilities.Collections.ISet dnss)
		{
			global::Org.BouncyCastle.Utilities.Collections.ISet intersect = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
			foreach (object obj in dnss)
			{
				global::Org.BouncyCastle.Asn1.X509.GeneralSubtree subtree = (global::Org.BouncyCastle.Asn1.X509.GeneralSubtree)obj;
				string dns = this.ExtractNameAsString(subtree.Base);
				if (permitted == null)
				{
					if (dns != null)
					{
						intersect.Add(dns);
					}
				}
				else
				{
					foreach (object obj2 in permitted)
					{
						string _permitted = (string)obj2;
						if (this.WithinDomain(_permitted, dns))
						{
							intersect.Add(_permitted);
						}
						else if (this.WithinDomain(dns, _permitted))
						{
							intersect.Add(dns);
						}
					}
				}
			}
			return intersect;
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x0003AE70 File Offset: 0x00039070
		private global::Org.BouncyCastle.Utilities.Collections.ISet UnionDns(global::Org.BouncyCastle.Utilities.Collections.ISet excluded, string dns)
		{
			if (!excluded.IsEmpty)
			{
				global::Org.BouncyCastle.Utilities.Collections.ISet union = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
				foreach (object obj in excluded)
				{
					string _excluded = (string)obj;
					if (this.WithinDomain(_excluded, dns))
					{
						union.Add(dns);
					}
					else if (this.WithinDomain(dns, _excluded))
					{
						union.Add(_excluded);
					}
					else
					{
						union.Add(_excluded);
						union.Add(dns);
					}
				}
				return union;
			}
			if (dns == null)
			{
				return excluded;
			}
			excluded.Add(dns);
			return excluded;
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x0003AF10 File Offset: 0x00039110
		private void IntersectEmail(string email1, string email2, global::Org.BouncyCastle.Utilities.Collections.ISet intersect)
		{
			if (email1.IndexOf('@') != -1)
			{
				string _sub = email1.Substring(email1.IndexOf('@') + 1);
				if (email2.IndexOf('@') != -1)
				{
					if (global::Org.BouncyCastle.Utilities.Platform.EqualsIgnoreCase(email1, email2))
					{
						intersect.Add(email1);
						return;
					}
				}
				else if (global::Org.BouncyCastle.Utilities.Platform.StartsWith(email2, "."))
				{
					if (this.WithinDomain(_sub, email2))
					{
						intersect.Add(email1);
						return;
					}
				}
				else if (global::Org.BouncyCastle.Utilities.Platform.EqualsIgnoreCase(_sub, email2))
				{
					intersect.Add(email1);
					return;
				}
			}
			else if (global::Org.BouncyCastle.Utilities.Platform.StartsWith(email1, "."))
			{
				if (email2.IndexOf('@') != -1)
				{
					string _sub2 = email2.Substring(email1.IndexOf('@') + 1);
					if (this.WithinDomain(_sub2, email1))
					{
						intersect.Add(email2);
						return;
					}
				}
				else if (global::Org.BouncyCastle.Utilities.Platform.StartsWith(email2, "."))
				{
					if (this.WithinDomain(email1, email2) || global::Org.BouncyCastle.Utilities.Platform.EqualsIgnoreCase(email1, email2))
					{
						intersect.Add(email1);
						return;
					}
					if (this.WithinDomain(email2, email1))
					{
						intersect.Add(email2);
						return;
					}
				}
				else if (this.WithinDomain(email2, email1))
				{
					intersect.Add(email2);
					return;
				}
			}
			else if (email2.IndexOf('@') != -1)
			{
				if (global::Org.BouncyCastle.Utilities.Platform.EqualsIgnoreCase(email2.Substring(email2.IndexOf('@') + 1), email1))
				{
					intersect.Add(email2);
					return;
				}
			}
			else if (global::Org.BouncyCastle.Utilities.Platform.StartsWith(email2, "."))
			{
				if (this.WithinDomain(email1, email2))
				{
					intersect.Add(email1);
					return;
				}
			}
			else if (global::Org.BouncyCastle.Utilities.Platform.EqualsIgnoreCase(email1, email2))
			{
				intersect.Add(email1);
			}
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x0003B074 File Offset: 0x00039274
		private global::Org.BouncyCastle.Utilities.Collections.ISet IntersectUri(global::Org.BouncyCastle.Utilities.Collections.ISet permitted, global::Org.BouncyCastle.Utilities.Collections.ISet uris)
		{
			global::Org.BouncyCastle.Utilities.Collections.ISet intersect = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
			foreach (object obj in uris)
			{
				global::Org.BouncyCastle.Asn1.X509.GeneralSubtree subtree = (global::Org.BouncyCastle.Asn1.X509.GeneralSubtree)obj;
				string uri = this.ExtractNameAsString(subtree.Base);
				if (permitted == null)
				{
					if (uri != null)
					{
						intersect.Add(uri);
					}
				}
				else
				{
					foreach (object obj2 in permitted)
					{
						string _permitted = (string)obj2;
						this.IntersectUri(_permitted, uri, intersect);
					}
				}
			}
			return intersect;
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x0003B138 File Offset: 0x00039338
		private global::Org.BouncyCastle.Utilities.Collections.ISet UnionUri(global::Org.BouncyCastle.Utilities.Collections.ISet excluded, string uri)
		{
			if (!excluded.IsEmpty)
			{
				global::Org.BouncyCastle.Utilities.Collections.ISet union = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
				foreach (object obj in excluded)
				{
					string _excluded = (string)obj;
					this.unionURI(_excluded, uri, union);
				}
				return union;
			}
			if (uri == null)
			{
				return excluded;
			}
			excluded.Add(uri);
			return excluded;
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x0003B1AC File Offset: 0x000393AC
		private void IntersectUri(string email1, string email2, global::Org.BouncyCastle.Utilities.Collections.ISet intersect)
		{
			if (email1.IndexOf('@') != -1)
			{
				string _sub = email1.Substring(email1.IndexOf('@') + 1);
				if (email2.IndexOf('@') != -1)
				{
					if (global::Org.BouncyCastle.Utilities.Platform.EqualsIgnoreCase(email1, email2))
					{
						intersect.Add(email1);
						return;
					}
				}
				else if (global::Org.BouncyCastle.Utilities.Platform.StartsWith(email2, "."))
				{
					if (this.WithinDomain(_sub, email2))
					{
						intersect.Add(email1);
						return;
					}
				}
				else if (global::Org.BouncyCastle.Utilities.Platform.EqualsIgnoreCase(_sub, email2))
				{
					intersect.Add(email1);
					return;
				}
			}
			else if (global::Org.BouncyCastle.Utilities.Platform.StartsWith(email1, "."))
			{
				if (email2.IndexOf('@') != -1)
				{
					string _sub2 = email2.Substring(email1.IndexOf('@') + 1);
					if (this.WithinDomain(_sub2, email1))
					{
						intersect.Add(email2);
						return;
					}
				}
				else if (global::Org.BouncyCastle.Utilities.Platform.StartsWith(email2, "."))
				{
					if (this.WithinDomain(email1, email2) || global::Org.BouncyCastle.Utilities.Platform.EqualsIgnoreCase(email1, email2))
					{
						intersect.Add(email1);
						return;
					}
					if (this.WithinDomain(email2, email1))
					{
						intersect.Add(email2);
						return;
					}
				}
				else if (this.WithinDomain(email2, email1))
				{
					intersect.Add(email2);
					return;
				}
			}
			else if (email2.IndexOf('@') != -1)
			{
				if (global::Org.BouncyCastle.Utilities.Platform.EqualsIgnoreCase(email2.Substring(email2.IndexOf('@') + 1), email1))
				{
					intersect.Add(email2);
					return;
				}
			}
			else if (global::Org.BouncyCastle.Utilities.Platform.StartsWith(email2, "."))
			{
				if (this.WithinDomain(email1, email2))
				{
					intersect.Add(email1);
					return;
				}
			}
			else if (global::Org.BouncyCastle.Utilities.Platform.EqualsIgnoreCase(email1, email2))
			{
				intersect.Add(email1);
			}
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x0003B310 File Offset: 0x00039510
		private static string ExtractHostFromURL(string url)
		{
			string sub = url.Substring(url.IndexOf(':') + 1);
			int idxOfSlashes = global::Org.BouncyCastle.Utilities.Platform.IndexOf(sub, "//");
			if (idxOfSlashes != -1)
			{
				sub = sub.Substring(idxOfSlashes + 2);
			}
			if (sub.LastIndexOf(':') != -1)
			{
				sub = sub.Substring(0, sub.LastIndexOf(':'));
			}
			sub = sub.Substring(sub.IndexOf(':') + 1);
			sub = sub.Substring(sub.IndexOf('@') + 1);
			if (sub.IndexOf('/') != -1)
			{
				sub = sub.Substring(0, sub.IndexOf('/'));
			}
			return sub;
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x0003B3A4 File Offset: 0x000395A4
		public void checkPermitted(global::Org.BouncyCastle.Asn1.X509.GeneralName name)
		{
			switch (name.TagNo)
			{
			case 0:
				this.CheckPermittedOtherName(this.permittedSubtreesOtherName, global::Org.BouncyCastle.Asn1.X509.OtherName.GetInstance(name.Name));
				return;
			case 1:
				this.CheckPermittedEmail(this.permittedSubtreesEmail, this.ExtractNameAsString(name));
				return;
			case 2:
				this.CheckPermittedDns(this.permittedSubtreesDNS, this.ExtractNameAsString(name));
				return;
			case 3:
			case 5:
				break;
			case 4:
				this.CheckPermittedDN(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(name.Name.ToAsn1Object()));
				return;
			case 6:
				this.CheckPermittedUri(this.permittedSubtreesURI, this.ExtractNameAsString(name));
				return;
			case 7:
				this.CheckPermittedIP(this.permittedSubtreesIP, global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(name.Name).GetOctets());
				break;
			default:
				return;
			}
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x0003B468 File Offset: 0x00039668
		public void checkExcluded(global::Org.BouncyCastle.Asn1.X509.GeneralName name)
		{
			switch (name.TagNo)
			{
			case 0:
				this.CheckExcludedOtherName(this.excludedSubtreesOtherName, global::Org.BouncyCastle.Asn1.X509.OtherName.GetInstance(name.Name));
				return;
			case 1:
				this.CheckExcludedEmail(this.excludedSubtreesEmail, this.ExtractNameAsString(name));
				return;
			case 2:
				this.CheckExcludedDns(this.excludedSubtreesDNS, this.ExtractNameAsString(name));
				return;
			case 3:
			case 5:
				break;
			case 4:
				this.CheckExcludedDN(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(name.Name.ToAsn1Object()));
				return;
			case 6:
				this.CheckExcludedUri(this.excludedSubtreesURI, this.ExtractNameAsString(name));
				return;
			case 7:
				this.CheckExcludedIP(this.excludedSubtreesIP, global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(name.Name).GetOctets());
				break;
			default:
				return;
			}
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x0003B52C File Offset: 0x0003972C
		public void IntersectPermittedSubtree(global::Org.BouncyCastle.Asn1.Asn1Sequence permitted)
		{
			global::System.Collections.IDictionary subtreesMap = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
			foreach (object obj in permitted)
			{
				global::Org.BouncyCastle.Asn1.X509.GeneralSubtree subtree = global::Org.BouncyCastle.Asn1.X509.GeneralSubtree.GetInstance(obj);
				int tagNo = subtree.Base.TagNo;
				if (subtreesMap[tagNo] == null)
				{
					subtreesMap[tagNo] = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
				}
				((global::Org.BouncyCastle.Utilities.Collections.ISet)subtreesMap[tagNo]).Add(subtree);
			}
			foreach (object obj2 in subtreesMap)
			{
				global::System.Collections.DictionaryEntry entry = (global::System.Collections.DictionaryEntry)obj2;
				switch ((int)entry.Key)
				{
				case 0:
					this.permittedSubtreesOtherName = this.IntersectOtherName(this.permittedSubtreesOtherName, (global::Org.BouncyCastle.Utilities.Collections.ISet)entry.Value);
					break;
				case 1:
					this.permittedSubtreesEmail = this.IntersectEmail(this.permittedSubtreesEmail, (global::Org.BouncyCastle.Utilities.Collections.ISet)entry.Value);
					break;
				case 2:
					this.permittedSubtreesDNS = this.IntersectDns(this.permittedSubtreesDNS, (global::Org.BouncyCastle.Utilities.Collections.ISet)entry.Value);
					break;
				case 4:
					this.permittedSubtreesDN = this.IntersectDN(this.permittedSubtreesDN, (global::Org.BouncyCastle.Utilities.Collections.ISet)entry.Value);
					break;
				case 6:
					this.permittedSubtreesURI = this.IntersectUri(this.permittedSubtreesURI, (global::Org.BouncyCastle.Utilities.Collections.ISet)entry.Value);
					break;
				case 7:
					this.permittedSubtreesIP = this.IntersectIP(this.permittedSubtreesIP, (global::Org.BouncyCastle.Utilities.Collections.ISet)entry.Value);
					break;
				}
			}
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x0003B724 File Offset: 0x00039924
		private string ExtractNameAsString(global::Org.BouncyCastle.Asn1.X509.GeneralName name)
		{
			return global::Org.BouncyCastle.Asn1.DerIA5String.GetInstance(name.Name).GetString();
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x0003B738 File Offset: 0x00039938
		public void IntersectEmptyPermittedSubtree(int nameType)
		{
			switch (nameType)
			{
			case 0:
				this.permittedSubtreesOtherName = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
				return;
			case 1:
				this.permittedSubtreesEmail = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
				return;
			case 2:
				this.permittedSubtreesDNS = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
				return;
			case 3:
			case 5:
				break;
			case 4:
				this.permittedSubtreesDN = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
				return;
			case 6:
				this.permittedSubtreesURI = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
				return;
			case 7:
				this.permittedSubtreesIP = new global::Org.BouncyCastle.Utilities.Collections.HashSet();
				break;
			default:
				return;
			}
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x0003B7B4 File Offset: 0x000399B4
		public void AddExcludedSubtree(global::Org.BouncyCastle.Asn1.X509.GeneralSubtree subtree)
		{
			global::Org.BouncyCastle.Asn1.X509.GeneralName subTreeBase = subtree.Base;
			switch (subTreeBase.TagNo)
			{
			case 0:
				this.excludedSubtreesOtherName = this.UnionOtherName(this.excludedSubtreesOtherName, global::Org.BouncyCastle.Asn1.X509.OtherName.GetInstance(subTreeBase.Name));
				return;
			case 1:
				this.excludedSubtreesEmail = this.UnionEmail(this.excludedSubtreesEmail, this.ExtractNameAsString(subTreeBase));
				return;
			case 2:
				this.excludedSubtreesDNS = this.UnionDns(this.excludedSubtreesDNS, this.ExtractNameAsString(subTreeBase));
				return;
			case 3:
			case 5:
				break;
			case 4:
				this.excludedSubtreesDN = this.UnionDN(this.excludedSubtreesDN, (global::Org.BouncyCastle.Asn1.Asn1Sequence)subTreeBase.Name.ToAsn1Object());
				return;
			case 6:
				this.excludedSubtreesURI = this.UnionUri(this.excludedSubtreesURI, this.ExtractNameAsString(subTreeBase));
				return;
			case 7:
				this.excludedSubtreesIP = this.UnionIP(this.excludedSubtreesIP, global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(subTreeBase.Name).GetOctets());
				break;
			default:
				return;
			}
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x0003B8A8 File Offset: 0x00039AA8
		private static byte[] Max(byte[] ip1, byte[] ip2)
		{
			for (int i = 0; i < ip1.Length; i++)
			{
				if (((int)ip1[i] & 65535) > ((int)ip2[i] & 65535))
				{
					return ip1;
				}
			}
			return ip2;
		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x0003B8DC File Offset: 0x00039ADC
		private static byte[] Min(byte[] ip1, byte[] ip2)
		{
			for (int i = 0; i < ip1.Length; i++)
			{
				if (((int)ip1[i] & 65535) < ((int)ip2[i] & 65535))
				{
					return ip1;
				}
			}
			return ip2;
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x0003B90E File Offset: 0x00039B0E
		private static int CompareTo(byte[] ip1, byte[] ip2)
		{
			if (global::Org.BouncyCastle.Utilities.Arrays.AreEqual(ip1, ip2))
			{
				return 0;
			}
			if (global::Org.BouncyCastle.Utilities.Arrays.AreEqual(global::Org.BouncyCastle.Pkix.PkixNameConstraintValidator.Max(ip1, ip2), ip1))
			{
				return 1;
			}
			return -1;
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x0003B930 File Offset: 0x00039B30
		private static byte[] Or(byte[] ip1, byte[] ip2)
		{
			byte[] temp = new byte[ip1.Length];
			for (int i = 0; i < ip1.Length; i++)
			{
				temp[i] = (ip1[i] | ip2[i]);
			}
			return temp;
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x0003B960 File Offset: 0x00039B60
		[global::System.Obsolete("Use GetHashCode instead")]
		public int HashCode()
		{
			return this.GetHashCode();
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x0003B968 File Offset: 0x00039B68
		public override int GetHashCode()
		{
			return this.HashCollection(this.excludedSubtreesDN) + this.HashCollection(this.excludedSubtreesDNS) + this.HashCollection(this.excludedSubtreesEmail) + this.HashCollection(this.excludedSubtreesIP) + this.HashCollection(this.excludedSubtreesURI) + this.HashCollection(this.excludedSubtreesOtherName) + this.HashCollection(this.permittedSubtreesDN) + this.HashCollection(this.permittedSubtreesDNS) + this.HashCollection(this.permittedSubtreesEmail) + this.HashCollection(this.permittedSubtreesIP) + this.HashCollection(this.permittedSubtreesURI) + this.HashCollection(this.permittedSubtreesOtherName);
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x0003BA10 File Offset: 0x00039C10
		private int HashCollection(global::System.Collections.ICollection c)
		{
			if (c == null)
			{
				return 0;
			}
			int hash = 0;
			foreach (object o in c)
			{
				if (o is byte[])
				{
					hash += global::Org.BouncyCastle.Utilities.Arrays.GetHashCode((byte[])o);
				}
				else
				{
					hash += o.GetHashCode();
				}
			}
			return hash;
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x0003BA84 File Offset: 0x00039C84
		public override bool Equals(object o)
		{
			if (!(o is global::Org.BouncyCastle.Pkix.PkixNameConstraintValidator))
			{
				return false;
			}
			global::Org.BouncyCastle.Pkix.PkixNameConstraintValidator constraintValidator = (global::Org.BouncyCastle.Pkix.PkixNameConstraintValidator)o;
			return this.CollectionsAreEqual(constraintValidator.excludedSubtreesDN, this.excludedSubtreesDN) && this.CollectionsAreEqual(constraintValidator.excludedSubtreesDNS, this.excludedSubtreesDNS) && this.CollectionsAreEqual(constraintValidator.excludedSubtreesEmail, this.excludedSubtreesEmail) && this.CollectionsAreEqual(constraintValidator.excludedSubtreesIP, this.excludedSubtreesIP) && this.CollectionsAreEqual(constraintValidator.excludedSubtreesURI, this.excludedSubtreesURI) && this.CollectionsAreEqual(constraintValidator.excludedSubtreesOtherName, this.excludedSubtreesOtherName) && this.CollectionsAreEqual(constraintValidator.permittedSubtreesDN, this.permittedSubtreesDN) && this.CollectionsAreEqual(constraintValidator.permittedSubtreesDNS, this.permittedSubtreesDNS) && this.CollectionsAreEqual(constraintValidator.permittedSubtreesEmail, this.permittedSubtreesEmail) && this.CollectionsAreEqual(constraintValidator.permittedSubtreesIP, this.permittedSubtreesIP) && this.CollectionsAreEqual(constraintValidator.permittedSubtreesURI, this.permittedSubtreesURI) && this.CollectionsAreEqual(constraintValidator.permittedSubtreesOtherName, this.permittedSubtreesOtherName);
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x0003BBA4 File Offset: 0x00039DA4
		private bool CollectionsAreEqual(global::System.Collections.ICollection coll1, global::System.Collections.ICollection coll2)
		{
			if (coll1 == coll2)
			{
				return true;
			}
			if (coll1 == null || coll2 == null || coll1.Count != coll2.Count)
			{
				return false;
			}
			foreach (object a in coll1)
			{
				bool found = false;
				foreach (object b in coll2)
				{
					if (this.SpecialEquals(a, b))
					{
						found = true;
						break;
					}
				}
				if (!found)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000F95 RID: 3989 RVA: 0x0003BC64 File Offset: 0x00039E64
		private bool SpecialEquals(object o1, object o2)
		{
			if (o1 == o2)
			{
				return true;
			}
			if (o1 == null || o2 == null)
			{
				return false;
			}
			if (o1 is byte[] && o2 is byte[])
			{
				return global::Org.BouncyCastle.Utilities.Arrays.AreEqual((byte[])o1, (byte[])o2);
			}
			return o1.Equals(o2);
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x0003BCA0 File Offset: 0x00039EA0
		private string StringifyIP(byte[] ip)
		{
			string temp = "";
			for (int i = 0; i < ip.Length / 2; i++)
			{
				temp = temp + ((int)(ip[i] & byte.MaxValue)).ToString() + ".";
			}
			temp = temp.Substring(0, temp.Length - 1);
			temp += "/";
			for (int j = ip.Length / 2; j < ip.Length; j++)
			{
				temp = temp + ((int)(ip[j] & byte.MaxValue)).ToString() + ".";
			}
			return temp.Substring(0, temp.Length - 1);
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x0003BD3C File Offset: 0x00039F3C
		private string StringifyIPCollection(global::Org.BouncyCastle.Utilities.Collections.ISet ips)
		{
			string temp = "";
			temp += "[";
			foreach (object obj in ips)
			{
				byte[] ip = (byte[])obj;
				temp = temp + this.StringifyIP(ip) + ",";
			}
			if (temp.Length > 1)
			{
				temp = temp.Substring(0, temp.Length - 1);
			}
			temp += "]";
			return temp;
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x0003BDD4 File Offset: 0x00039FD4
		private string StringifyOtherNameCollection(global::Org.BouncyCastle.Utilities.Collections.ISet otherNames)
		{
			string temp = "";
			temp += "[";
			foreach (object obj in otherNames)
			{
				global::Org.BouncyCastle.Asn1.X509.OtherName name = global::Org.BouncyCastle.Asn1.X509.OtherName.GetInstance(obj);
				if (temp.Length > 1)
				{
					temp += ",";
				}
				temp += name.TypeID.Id;
				temp += ":";
				try
				{
					temp += global::Org.BouncyCastle.Utilities.Encoders.Hex.ToHexString(name.Value.ToAsn1Object().GetEncoded());
				}
				catch (global::System.IO.IOException e)
				{
					temp += e.ToString();
				}
			}
			temp += "]";
			return temp;
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x0003BEB0 File Offset: 0x0003A0B0
		public override string ToString()
		{
			string temp = "";
			temp += "permitted:\n";
			if (this.permittedSubtreesDN != null)
			{
				temp += "DN:\n";
				temp = temp + this.permittedSubtreesDN.ToString() + "\n";
			}
			if (this.permittedSubtreesDNS != null)
			{
				temp += "DNS:\n";
				temp = temp + this.permittedSubtreesDNS.ToString() + "\n";
			}
			if (this.permittedSubtreesEmail != null)
			{
				temp += "Email:\n";
				temp = temp + this.permittedSubtreesEmail.ToString() + "\n";
			}
			if (this.permittedSubtreesURI != null)
			{
				temp += "URI:\n";
				temp = temp + this.permittedSubtreesURI.ToString() + "\n";
			}
			if (this.permittedSubtreesIP != null)
			{
				temp += "IP:\n";
				temp = temp + this.StringifyIPCollection(this.permittedSubtreesIP) + "\n";
			}
			if (this.permittedSubtreesOtherName != null)
			{
				temp += "OtherName:\n";
				temp += this.StringifyOtherNameCollection(this.permittedSubtreesOtherName);
			}
			temp += "excluded:\n";
			if (!this.excludedSubtreesDN.IsEmpty)
			{
				temp += "DN:\n";
				temp = temp + this.excludedSubtreesDN.ToString() + "\n";
			}
			if (!this.excludedSubtreesDNS.IsEmpty)
			{
				temp += "DNS:\n";
				temp = temp + this.excludedSubtreesDNS.ToString() + "\n";
			}
			if (!this.excludedSubtreesEmail.IsEmpty)
			{
				temp += "Email:\n";
				temp = temp + this.excludedSubtreesEmail.ToString() + "\n";
			}
			if (!this.excludedSubtreesURI.IsEmpty)
			{
				temp += "URI:\n";
				temp = temp + this.excludedSubtreesURI.ToString() + "\n";
			}
			if (!this.excludedSubtreesIP.IsEmpty)
			{
				temp += "IP:\n";
				temp = temp + this.StringifyIPCollection(this.excludedSubtreesIP) + "\n";
			}
			if (!this.excludedSubtreesOtherName.IsEmpty)
			{
				temp += "OtherName:\n";
				temp += this.StringifyOtherNameCollection(this.excludedSubtreesOtherName);
			}
			return temp;
		}

		// Token: 0x04000863 RID: 2147
		private static readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier SerialNumberOid = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier("2.5.4.5");

		// Token: 0x04000864 RID: 2148
		private global::Org.BouncyCastle.Utilities.Collections.ISet excludedSubtreesDN = new global::Org.BouncyCastle.Utilities.Collections.HashSet();

		// Token: 0x04000865 RID: 2149
		private global::Org.BouncyCastle.Utilities.Collections.ISet excludedSubtreesDNS = new global::Org.BouncyCastle.Utilities.Collections.HashSet();

		// Token: 0x04000866 RID: 2150
		private global::Org.BouncyCastle.Utilities.Collections.ISet excludedSubtreesEmail = new global::Org.BouncyCastle.Utilities.Collections.HashSet();

		// Token: 0x04000867 RID: 2151
		private global::Org.BouncyCastle.Utilities.Collections.ISet excludedSubtreesURI = new global::Org.BouncyCastle.Utilities.Collections.HashSet();

		// Token: 0x04000868 RID: 2152
		private global::Org.BouncyCastle.Utilities.Collections.ISet excludedSubtreesIP = new global::Org.BouncyCastle.Utilities.Collections.HashSet();

		// Token: 0x04000869 RID: 2153
		private global::Org.BouncyCastle.Utilities.Collections.ISet excludedSubtreesOtherName = new global::Org.BouncyCastle.Utilities.Collections.HashSet();

		// Token: 0x0400086A RID: 2154
		private global::Org.BouncyCastle.Utilities.Collections.ISet permittedSubtreesDN;

		// Token: 0x0400086B RID: 2155
		private global::Org.BouncyCastle.Utilities.Collections.ISet permittedSubtreesDNS;

		// Token: 0x0400086C RID: 2156
		private global::Org.BouncyCastle.Utilities.Collections.ISet permittedSubtreesEmail;

		// Token: 0x0400086D RID: 2157
		private global::Org.BouncyCastle.Utilities.Collections.ISet permittedSubtreesURI;

		// Token: 0x0400086E RID: 2158
		private global::Org.BouncyCastle.Utilities.Collections.ISet permittedSubtreesIP;

		// Token: 0x0400086F RID: 2159
		private global::Org.BouncyCastle.Utilities.Collections.ISet permittedSubtreesOtherName;
	}
}
