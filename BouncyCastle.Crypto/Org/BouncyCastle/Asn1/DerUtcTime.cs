using System;
using System.Globalization;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x0200061F RID: 1567
	public class DerUtcTime : global::Org.BouncyCastle.Asn1.Asn1Object
	{
		// Token: 0x06003A6D RID: 14957 RVA: 0x0010EBA7 File Offset: 0x0010CDA7
		public static global::Org.BouncyCastle.Asn1.DerUtcTime GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.DerUtcTime)
			{
				return (global::Org.BouncyCastle.Asn1.DerUtcTime)obj;
			}
			throw new global::System.ArgumentException("illegal object in GetInstance: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj));
		}

		// Token: 0x06003A6E RID: 14958 RVA: 0x0010EBD0 File Offset: 0x0010CDD0
		public static global::Org.BouncyCastle.Asn1.DerUtcTime GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
		{
			global::Org.BouncyCastle.Asn1.Asn1Object o = obj.GetObject();
			if (isExplicit || o is global::Org.BouncyCastle.Asn1.DerUtcTime)
			{
				return global::Org.BouncyCastle.Asn1.DerUtcTime.GetInstance(o);
			}
			return new global::Org.BouncyCastle.Asn1.DerUtcTime(((global::Org.BouncyCastle.Asn1.Asn1OctetString)o).GetOctets());
		}

		// Token: 0x06003A6F RID: 14959 RVA: 0x0010EC08 File Offset: 0x0010CE08
		public DerUtcTime(string time)
		{
			if (time == null)
			{
				throw new global::System.ArgumentNullException("time");
			}
			this.time = time;
			try
			{
				this.ToDateTime();
			}
			catch (global::System.FormatException e)
			{
				throw new global::System.ArgumentException("invalid date string: " + e.Message);
			}
		}

		// Token: 0x06003A70 RID: 14960 RVA: 0x0010EC60 File Offset: 0x0010CE60
		public DerUtcTime(global::System.DateTime time)
		{
			this.time = time.ToString("yyMMddHHmmss", global::System.Globalization.CultureInfo.InvariantCulture) + "Z";
		}

		// Token: 0x06003A71 RID: 14961 RVA: 0x0010EC89 File Offset: 0x0010CE89
		internal DerUtcTime(byte[] bytes)
		{
			this.time = global::Org.BouncyCastle.Utilities.Strings.FromAsciiByteArray(bytes);
		}

		// Token: 0x06003A72 RID: 14962 RVA: 0x0010EC9D File Offset: 0x0010CE9D
		public global::System.DateTime ToDateTime()
		{
			return this.ParseDateString(this.TimeString, "yyMMddHHmmss'GMT'zzz");
		}

		// Token: 0x06003A73 RID: 14963 RVA: 0x0010ECB0 File Offset: 0x0010CEB0
		public global::System.DateTime ToAdjustedDateTime()
		{
			return this.ParseDateString(this.AdjustedTimeString, "yyyyMMddHHmmss'GMT'zzz");
		}

		// Token: 0x06003A74 RID: 14964 RVA: 0x0010ECC4 File Offset: 0x0010CEC4
		private global::System.DateTime ParseDateString(string dateStr, string formatStr)
		{
			return global::System.DateTime.ParseExact(dateStr, formatStr, global::System.Globalization.DateTimeFormatInfo.InvariantInfo).ToUniversalTime();
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06003A75 RID: 14965 RVA: 0x0010ECE8 File Offset: 0x0010CEE8
		public string TimeString
		{
			get
			{
				if (this.time.IndexOf('-') < 0 && this.time.IndexOf('+') < 0)
				{
					if (this.time.Length == 11)
					{
						return this.time.Substring(0, 10) + "00GMT+00:00";
					}
					return this.time.Substring(0, 12) + "GMT+00:00";
				}
				else
				{
					int index = this.time.IndexOf('-');
					if (index < 0)
					{
						index = this.time.IndexOf('+');
					}
					string d = this.time;
					if (index == this.time.Length - 3)
					{
						d += "00";
					}
					if (index == 10)
					{
						return string.Concat(new string[]
						{
							d.Substring(0, 10),
							"00GMT",
							d.Substring(10, 3),
							":",
							d.Substring(13, 2)
						});
					}
					return string.Concat(new string[]
					{
						d.Substring(0, 12),
						"GMT",
						d.Substring(12, 3),
						":",
						d.Substring(15, 2)
					});
				}
			}
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06003A76 RID: 14966 RVA: 0x0010EE1D File Offset: 0x0010D01D
		[global::System.Obsolete("Use 'AdjustedTimeString' property instead")]
		public string AdjustedTime
		{
			get
			{
				return this.AdjustedTimeString;
			}
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x06003A77 RID: 14967 RVA: 0x0010EE28 File Offset: 0x0010D028
		public string AdjustedTimeString
		{
			get
			{
				string d = this.TimeString;
				return ((d[0] < '5') ? "20" : "19") + d;
			}
		}

		// Token: 0x06003A78 RID: 14968 RVA: 0x0010EE59 File Offset: 0x0010D059
		private byte[] GetOctets()
		{
			return global::Org.BouncyCastle.Utilities.Strings.ToAsciiByteArray(this.time);
		}

		// Token: 0x06003A79 RID: 14969 RVA: 0x0010EE66 File Offset: 0x0010D066
		internal override int EncodedLength(bool withID)
		{
			return global::Org.BouncyCastle.Asn1.Asn1OutputStream.GetLengthOfEncodingDL(withID, this.time.Length);
		}

		// Token: 0x06003A7A RID: 14970 RVA: 0x0010EE79 File Offset: 0x0010D079
		internal override void Encode(global::Org.BouncyCastle.Asn1.Asn1OutputStream asn1Out, bool withID)
		{
			asn1Out.WriteEncodingDL(withID, 23, this.GetOctets());
		}

		// Token: 0x06003A7B RID: 14971 RVA: 0x0010EE8C File Offset: 0x0010D08C
		protected override bool Asn1Equals(global::Org.BouncyCastle.Asn1.Asn1Object asn1Object)
		{
			global::Org.BouncyCastle.Asn1.DerUtcTime other = asn1Object as global::Org.BouncyCastle.Asn1.DerUtcTime;
			return other != null && this.time.Equals(other.time);
		}

		// Token: 0x06003A7C RID: 14972 RVA: 0x0010EEB6 File Offset: 0x0010D0B6
		protected override int Asn1GetHashCode()
		{
			return this.time.GetHashCode();
		}

		// Token: 0x06003A7D RID: 14973 RVA: 0x0010EEC3 File Offset: 0x0010D0C3
		public override string ToString()
		{
			return this.time;
		}

		// Token: 0x040019AF RID: 6575
		private readonly string time;
	}
}
