using System;
using System.Globalization;
using System.Text;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x02000607 RID: 1543
	public class DerGeneralizedTime : global::Org.BouncyCastle.Asn1.Asn1Object
	{
		// Token: 0x0600399C RID: 14748 RVA: 0x0010CD84 File Offset: 0x0010AF84
		public static global::Org.BouncyCastle.Asn1.DerGeneralizedTime GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.DerGeneralizedTime)
			{
				return (global::Org.BouncyCastle.Asn1.DerGeneralizedTime)obj;
			}
			throw new global::System.ArgumentException("illegal object in GetInstance: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x0600399D RID: 14749 RVA: 0x0010CDB4 File Offset: 0x0010AFB4
		public static global::Org.BouncyCastle.Asn1.DerGeneralizedTime GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool isExplicit)
		{
			global::Org.BouncyCastle.Asn1.Asn1Object o = obj.GetObject();
			if (isExplicit || o is global::Org.BouncyCastle.Asn1.DerGeneralizedTime)
			{
				return global::Org.BouncyCastle.Asn1.DerGeneralizedTime.GetInstance(o);
			}
			return new global::Org.BouncyCastle.Asn1.DerGeneralizedTime(((global::Org.BouncyCastle.Asn1.Asn1OctetString)o).GetOctets());
		}

		// Token: 0x0600399E RID: 14750 RVA: 0x0010CDEC File Offset: 0x0010AFEC
		public DerGeneralizedTime(string time)
		{
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

		// Token: 0x0600399F RID: 14751 RVA: 0x0010CE38 File Offset: 0x0010B038
		public DerGeneralizedTime(global::System.DateTime time)
		{
			this.time = time.ToString("yyyyMMddHHmmss\\Z");
		}

		// Token: 0x060039A0 RID: 14752 RVA: 0x0010CE52 File Offset: 0x0010B052
		internal DerGeneralizedTime(byte[] bytes)
		{
			this.time = global::Org.BouncyCastle.Utilities.Strings.FromAsciiByteArray(bytes);
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x060039A1 RID: 14753 RVA: 0x0010CE66 File Offset: 0x0010B066
		public string TimeString
		{
			get
			{
				return this.time;
			}
		}

		// Token: 0x060039A2 RID: 14754 RVA: 0x0010CE70 File Offset: 0x0010B070
		public string GetTime()
		{
			if (this.time[this.time.Length - 1] == 'Z')
			{
				return this.time.Substring(0, this.time.Length - 1) + "GMT+00:00";
			}
			int signPos = this.time.Length - 5;
			char sign = this.time[signPos];
			if (sign == '-' || sign == '+')
			{
				return string.Concat(new string[]
				{
					this.time.Substring(0, signPos),
					"GMT",
					this.time.Substring(signPos, 3),
					":",
					this.time.Substring(signPos + 3)
				});
			}
			signPos = this.time.Length - 3;
			sign = this.time[signPos];
			if (sign == '-' || sign == '+')
			{
				return this.time.Substring(0, signPos) + "GMT" + this.time.Substring(signPos) + ":00";
			}
			return this.time + this.CalculateGmtOffset();
		}

		// Token: 0x060039A3 RID: 14755 RVA: 0x0010CF90 File Offset: 0x0010B190
		private string CalculateGmtOffset()
		{
			char sign = '+';
			global::System.DateTime time = this.ToDateTime();
			global::System.TimeSpan offset = global::System.TimeZone.CurrentTimeZone.GetUtcOffset(time);
			if (offset.CompareTo(global::System.TimeSpan.Zero) < 0)
			{
				sign = '-';
				offset = offset.Duration();
			}
			int hours = offset.Hours;
			int minutes = offset.Minutes;
			return string.Concat(new string[]
			{
				"GMT",
				sign.ToString(),
				global::Org.BouncyCastle.Asn1.DerGeneralizedTime.Convert(hours),
				":",
				global::Org.BouncyCastle.Asn1.DerGeneralizedTime.Convert(minutes)
			});
		}

		// Token: 0x060039A4 RID: 14756 RVA: 0x0010D016 File Offset: 0x0010B216
		private static string Convert(int time)
		{
			if (time < 10)
			{
				return "0" + time.ToString();
			}
			return time.ToString();
		}

		// Token: 0x060039A5 RID: 14757 RVA: 0x0010D038 File Offset: 0x0010B238
		public global::System.DateTime ToDateTime()
		{
			string d = this.time;
			bool makeUniversal = false;
			string formatStr;
			if (global::Org.BouncyCastle.Utilities.Platform.EndsWith(d, "Z"))
			{
				if (this.HasFractionalSeconds)
				{
					int fCount = d.Length - d.IndexOf('.') - 2;
					formatStr = "yyyyMMddHHmmss." + this.FString(fCount) + "\\Z";
				}
				else
				{
					formatStr = "yyyyMMddHHmmss\\Z";
				}
			}
			else if (this.time.IndexOf('-') > 0 || this.time.IndexOf('+') > 0)
			{
				d = this.GetTime();
				makeUniversal = true;
				if (this.HasFractionalSeconds)
				{
					int fCount2 = global::Org.BouncyCastle.Utilities.Platform.IndexOf(d, "GMT") - 1 - d.IndexOf('.');
					formatStr = "yyyyMMddHHmmss." + this.FString(fCount2) + "'GMT'zzz";
				}
				else
				{
					formatStr = "yyyyMMddHHmmss'GMT'zzz";
				}
			}
			else if (this.HasFractionalSeconds)
			{
				int fCount3 = d.Length - 1 - d.IndexOf('.');
				formatStr = "yyyyMMddHHmmss." + this.FString(fCount3);
			}
			else
			{
				formatStr = "yyyyMMddHHmmss";
			}
			return this.ParseDateString(d, formatStr, makeUniversal);
		}

		// Token: 0x060039A6 RID: 14758 RVA: 0x0010D148 File Offset: 0x0010B348
		private string FString(int count)
		{
			global::System.Text.StringBuilder sb = new global::System.Text.StringBuilder();
			for (int i = 0; i < count; i++)
			{
				sb.Append('f');
			}
			return sb.ToString();
		}

		// Token: 0x060039A7 RID: 14759 RVA: 0x0010D178 File Offset: 0x0010B378
		private global::System.DateTime ParseDateString(string s, string format, bool makeUniversal)
		{
			global::System.Globalization.DateTimeStyles style = global::System.Globalization.DateTimeStyles.None;
			if (global::Org.BouncyCastle.Utilities.Platform.EndsWith(format, "Z"))
			{
				try
				{
					style = (global::System.Globalization.DateTimeStyles)global::Org.BouncyCastle.Utilities.Enums.GetEnumValue(typeof(global::System.Globalization.DateTimeStyles), "AssumeUniversal");
				}
				catch (global::System.Exception)
				{
				}
				style |= global::System.Globalization.DateTimeStyles.AdjustToUniversal;
			}
			global::System.DateTime dt = global::System.DateTime.ParseExact(s, format, global::System.Globalization.DateTimeFormatInfo.InvariantInfo, style);
			if (!makeUniversal)
			{
				return dt;
			}
			return dt.ToUniversalTime();
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x060039A8 RID: 14760 RVA: 0x0010D1E4 File Offset: 0x0010B3E4
		private bool HasFractionalSeconds
		{
			get
			{
				return this.time.IndexOf('.') == 14;
			}
		}

		// Token: 0x060039A9 RID: 14761 RVA: 0x0010D1F7 File Offset: 0x0010B3F7
		private byte[] GetOctets()
		{
			return global::Org.BouncyCastle.Utilities.Strings.ToAsciiByteArray(this.time);
		}

		// Token: 0x060039AA RID: 14762 RVA: 0x0010D204 File Offset: 0x0010B404
		internal override int EncodedLength(bool withID)
		{
			return global::Org.BouncyCastle.Asn1.Asn1OutputStream.GetLengthOfEncodingDL(withID, this.time.Length);
		}

		// Token: 0x060039AB RID: 14763 RVA: 0x0010D217 File Offset: 0x0010B417
		internal override void Encode(global::Org.BouncyCastle.Asn1.Asn1OutputStream asn1Out, bool withID)
		{
			asn1Out.WriteEncodingDL(withID, 24, this.GetOctets());
		}

		// Token: 0x060039AC RID: 14764 RVA: 0x0010D228 File Offset: 0x0010B428
		protected override bool Asn1Equals(global::Org.BouncyCastle.Asn1.Asn1Object asn1Object)
		{
			global::Org.BouncyCastle.Asn1.DerGeneralizedTime other = asn1Object as global::Org.BouncyCastle.Asn1.DerGeneralizedTime;
			return other != null && this.time.Equals(other.time);
		}

		// Token: 0x060039AD RID: 14765 RVA: 0x0010D252 File Offset: 0x0010B452
		protected override int Asn1GetHashCode()
		{
			return this.time.GetHashCode();
		}

		// Token: 0x04001991 RID: 6545
		private readonly string time;
	}
}
