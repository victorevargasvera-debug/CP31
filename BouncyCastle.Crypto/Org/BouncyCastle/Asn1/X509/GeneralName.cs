using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Text;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Net;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000655 RID: 1621
	public class GeneralName : global::Org.BouncyCastle.Asn1.Asn1Encodable, global::Org.BouncyCastle.Asn1.IAsn1Choice
	{
		// Token: 0x06003BF5 RID: 15349 RVA: 0x00112F33 File Offset: 0x00111133
		public GeneralName(global::Org.BouncyCastle.Asn1.X509.X509Name directoryName)
		{
			this.obj = directoryName;
			this.tag = 4;
		}

		// Token: 0x06003BF6 RID: 15350 RVA: 0x00112F49 File Offset: 0x00111149
		public GeneralName(global::Org.BouncyCastle.Asn1.Asn1Object name, int tag)
		{
			this.obj = name;
			this.tag = tag;
		}

		// Token: 0x06003BF7 RID: 15351 RVA: 0x00112F5F File Offset: 0x0011115F
		public GeneralName(int tag, global::Org.BouncyCastle.Asn1.Asn1Encodable name)
		{
			this.obj = name;
			this.tag = tag;
		}

		// Token: 0x06003BF8 RID: 15352 RVA: 0x00112F78 File Offset: 0x00111178
		public GeneralName(int tag, string name)
		{
			this.tag = tag;
			if (tag == 1 || tag == 2 || tag == 6)
			{
				this.obj = new global::Org.BouncyCastle.Asn1.DerIA5String(name);
				return;
			}
			if (tag == 8)
			{
				this.obj = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(name);
				return;
			}
			if (tag == 4)
			{
				this.obj = new global::Org.BouncyCastle.Asn1.X509.X509Name(name);
				return;
			}
			if (tag != 7)
			{
				throw new global::System.ArgumentException("can't process string for tag: " + tag.ToString(), "tag");
			}
			byte[] enc = this.toGeneralNameEncoding(name);
			if (enc == null)
			{
				throw new global::System.ArgumentException("IP Address is invalid", "name");
			}
			this.obj = new global::Org.BouncyCastle.Asn1.DerOctetString(enc);
		}

		// Token: 0x06003BF9 RID: 15353 RVA: 0x00113014 File Offset: 0x00111214
		public static global::Org.BouncyCastle.Asn1.X509.GeneralName GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.X509.GeneralName)
			{
				return (global::Org.BouncyCastle.Asn1.X509.GeneralName)obj;
			}
			if (!(obj is global::Org.BouncyCastle.Asn1.Asn1TaggedObject))
			{
				if (obj is byte[])
				{
					try
					{
						return global::Org.BouncyCastle.Asn1.X509.GeneralName.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray((byte[])obj));
					}
					catch (global::System.IO.IOException)
					{
						throw new global::System.ArgumentException("unable to parse encoded general name");
					}
				}
				throw new global::System.ArgumentException("unknown object in GetInstance: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
			}
			global::Org.BouncyCastle.Asn1.Asn1TaggedObject tagObj = (global::Org.BouncyCastle.Asn1.Asn1TaggedObject)obj;
			int tag = tagObj.TagNo;
			switch (tag)
			{
			case 0:
			case 3:
			case 5:
				return new global::Org.BouncyCastle.Asn1.X509.GeneralName(tag, global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(tagObj, false));
			case 1:
			case 2:
			case 6:
				return new global::Org.BouncyCastle.Asn1.X509.GeneralName(tag, global::Org.BouncyCastle.Asn1.DerIA5String.GetInstance(tagObj, false));
			case 4:
				return new global::Org.BouncyCastle.Asn1.X509.GeneralName(tag, global::Org.BouncyCastle.Asn1.X509.X509Name.GetInstance(tagObj, true));
			case 7:
				return new global::Org.BouncyCastle.Asn1.X509.GeneralName(tag, global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(tagObj, false));
			case 8:
				return new global::Org.BouncyCastle.Asn1.X509.GeneralName(tag, global::Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(tagObj, false));
			default:
				throw new global::System.ArgumentException("unknown tag: " + tag.ToString());
			}
		}

		// Token: 0x06003BFA RID: 15354 RVA: 0x00113128 File Offset: 0x00111328
		public static global::Org.BouncyCastle.Asn1.X509.GeneralName GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject tagObj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.X509.GeneralName.GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject.GetInstance(tagObj, true));
		}

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x06003BFB RID: 15355 RVA: 0x00113136 File Offset: 0x00111336
		public int TagNo
		{
			get
			{
				return this.tag;
			}
		}

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x06003BFC RID: 15356 RVA: 0x0011313E File Offset: 0x0011133E
		public global::Org.BouncyCastle.Asn1.Asn1Encodable Name
		{
			get
			{
				return this.obj;
			}
		}

		// Token: 0x06003BFD RID: 15357 RVA: 0x00113148 File Offset: 0x00111348
		public override string ToString()
		{
			global::System.Text.StringBuilder buf = new global::System.Text.StringBuilder();
			buf.Append(this.tag);
			buf.Append(": ");
			switch (this.tag)
			{
			case 1:
			case 2:
			case 6:
				buf.Append(global::Org.BouncyCastle.Asn1.DerIA5String.GetInstance(this.obj).GetString());
				goto IL_8C;
			case 4:
				buf.Append(global::Org.BouncyCastle.Asn1.X509.X509Name.GetInstance(this.obj).ToString());
				goto IL_8C;
			}
			buf.Append(this.obj.ToString());
			IL_8C:
			return buf.ToString();
		}

		// Token: 0x06003BFE RID: 15358 RVA: 0x001131E8 File Offset: 0x001113E8
		private byte[] toGeneralNameEncoding(string ip)
		{
			if (global::Org.BouncyCastle.Utilities.Net.IPAddress.IsValidIPv6WithNetmask(ip) || global::Org.BouncyCastle.Utilities.Net.IPAddress.IsValidIPv6(ip))
			{
				int slashIndex = ip.IndexOf('/');
				if (slashIndex < 0)
				{
					byte[] addr = new byte[16];
					int[] parsedIp = this.parseIPv6(ip);
					this.copyInts(parsedIp, addr, 0);
					return addr;
				}
				byte[] addr2 = new byte[32];
				int[] parsedIp2 = this.parseIPv6(ip.Substring(0, slashIndex));
				this.copyInts(parsedIp2, addr2, 0);
				string mask = ip.Substring(slashIndex + 1);
				if (mask.IndexOf(':') > 0)
				{
					parsedIp2 = this.parseIPv6(mask);
				}
				else
				{
					parsedIp2 = this.parseMask(mask);
				}
				this.copyInts(parsedIp2, addr2, 16);
				return addr2;
			}
			else
			{
				if (!global::Org.BouncyCastle.Utilities.Net.IPAddress.IsValidIPv4WithNetmask(ip) && !global::Org.BouncyCastle.Utilities.Net.IPAddress.IsValidIPv4(ip))
				{
					return null;
				}
				int slashIndex2 = ip.IndexOf('/');
				if (slashIndex2 < 0)
				{
					byte[] addr3 = new byte[4];
					this.parseIPv4(ip, addr3, 0);
					return addr3;
				}
				byte[] addr4 = new byte[8];
				this.parseIPv4(ip.Substring(0, slashIndex2), addr4, 0);
				string mask2 = ip.Substring(slashIndex2 + 1);
				if (mask2.IndexOf('.') > 0)
				{
					this.parseIPv4(mask2, addr4, 4);
				}
				else
				{
					this.parseIPv4Mask(mask2, addr4, 4);
				}
				return addr4;
			}
		}

		// Token: 0x06003BFF RID: 15359 RVA: 0x00113310 File Offset: 0x00111510
		private void parseIPv4Mask(string mask, byte[] addr, int offset)
		{
			int maskVal = int.Parse(mask);
			for (int i = 0; i != maskVal; i++)
			{
				int num = i / 8 + offset;
				addr[num] |= (byte)(1 << i % 8);
			}
		}

		// Token: 0x06003C00 RID: 15360 RVA: 0x0011334C File Offset: 0x0011154C
		private void parseIPv4(string ip, byte[] addr, int offset)
		{
			foreach (string token in ip.Split(new char[]
			{
				'.',
				'/'
			}))
			{
				addr[offset++] = (byte)int.Parse(token);
			}
		}

		// Token: 0x06003C01 RID: 15361 RVA: 0x00113394 File Offset: 0x00111594
		private int[] parseMask(string mask)
		{
			int[] res = new int[8];
			int maskVal = int.Parse(mask);
			for (int i = 0; i != maskVal; i++)
			{
				res[i / 16] |= 1 << i % 16;
			}
			return res;
		}

		// Token: 0x06003C02 RID: 15362 RVA: 0x001133D4 File Offset: 0x001115D4
		private void copyInts(int[] parsedIp, byte[] addr, int offSet)
		{
			for (int i = 0; i != parsedIp.Length; i++)
			{
				addr[i * 2 + offSet] = (byte)(parsedIp[i] >> 8);
				addr[i * 2 + 1 + offSet] = (byte)parsedIp[i];
			}
		}

		// Token: 0x06003C03 RID: 15363 RVA: 0x0011340C File Offset: 0x0011160C
		private int[] parseIPv6(string ip)
		{
			if (global::Org.BouncyCastle.Utilities.Platform.StartsWith(ip, "::"))
			{
				ip = ip.Substring(1);
			}
			else if (global::Org.BouncyCastle.Utilities.Platform.EndsWith(ip, "::"))
			{
				ip = ip.Substring(0, ip.Length - 1);
			}
			global::System.Collections.IEnumerator sEnum = ip.Split(new char[]
			{
				':'
			}).GetEnumerator();
			int index = 0;
			int[] val = new int[8];
			int doubleColon = -1;
			while (sEnum.MoveNext())
			{
				object obj = sEnum.Current;
				string e = (string)obj;
				if (e.Length == 0)
				{
					doubleColon = index;
					val[index++] = 0;
				}
				else if (e.IndexOf('.') < 0)
				{
					val[index++] = int.Parse(e, global::System.Globalization.NumberStyles.AllowHexSpecifier);
				}
				else
				{
					string[] tokens = e.Split(new char[]
					{
						'.'
					});
					val[index++] = (int.Parse(tokens[0]) << 8 | int.Parse(tokens[1]));
					val[index++] = (int.Parse(tokens[2]) << 8 | int.Parse(tokens[3]));
				}
			}
			if (index != val.Length)
			{
				global::System.Array.Copy(val, doubleColon, val, val.Length - (index - doubleColon), index - doubleColon);
				for (int i = doubleColon; i != val.Length - (index - doubleColon); i++)
				{
					val[i] = 0;
				}
			}
			return val;
		}

		// Token: 0x06003C04 RID: 15364 RVA: 0x00113544 File Offset: 0x00111744
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerTaggedObject(this.tag == 4, this.tag, this.obj);
		}

		// Token: 0x04001A64 RID: 6756
		public const int OtherName = 0;

		// Token: 0x04001A65 RID: 6757
		public const int Rfc822Name = 1;

		// Token: 0x04001A66 RID: 6758
		public const int DnsName = 2;

		// Token: 0x04001A67 RID: 6759
		public const int X400Address = 3;

		// Token: 0x04001A68 RID: 6760
		public const int DirectoryName = 4;

		// Token: 0x04001A69 RID: 6761
		public const int EdiPartyName = 5;

		// Token: 0x04001A6A RID: 6762
		public const int UniformResourceIdentifier = 6;

		// Token: 0x04001A6B RID: 6763
		public const int IPAddress = 7;

		// Token: 0x04001A6C RID: 6764
		public const int RegisteredID = 8;

		// Token: 0x04001A6D RID: 6765
		internal readonly global::Org.BouncyCastle.Asn1.Asn1Encodable obj;

		// Token: 0x04001A6E RID: 6766
		internal readonly int tag;
	}
}
