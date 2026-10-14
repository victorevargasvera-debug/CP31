using System;
using System.Globalization;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000673 RID: 1651
	public class Time : global::Org.BouncyCastle.Asn1.Asn1Encodable, global::Org.BouncyCastle.Asn1.IAsn1Choice
	{
		// Token: 0x06003CE1 RID: 15585 RVA: 0x00115EC0 File Offset: 0x001140C0
		public static global::Org.BouncyCastle.Asn1.X509.Time GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.X509.Time.GetInstance(obj.GetObject());
		}

		// Token: 0x06003CE2 RID: 15586 RVA: 0x00115ECD File Offset: 0x001140CD
		public Time(global::Org.BouncyCastle.Asn1.Asn1Object time)
		{
			if (time == null)
			{
				throw new global::System.ArgumentNullException("time");
			}
			if (!(time is global::Org.BouncyCastle.Asn1.DerUtcTime) && !(time is global::Org.BouncyCastle.Asn1.DerGeneralizedTime))
			{
				throw new global::System.ArgumentException("unknown object passed to Time");
			}
			this.time = time;
		}

		// Token: 0x06003CE3 RID: 15587 RVA: 0x00115F08 File Offset: 0x00114108
		public Time(global::System.DateTime date)
		{
			string d = date.ToString("yyyyMMddHHmmss", global::System.Globalization.CultureInfo.InvariantCulture) + "Z";
			int year = int.Parse(d.Substring(0, 4));
			if (year < 1950 || year > 2049)
			{
				this.time = new global::Org.BouncyCastle.Asn1.DerGeneralizedTime(d);
				return;
			}
			this.time = new global::Org.BouncyCastle.Asn1.DerUtcTime(d.Substring(2));
		}

		// Token: 0x06003CE4 RID: 15588 RVA: 0x00115F74 File Offset: 0x00114174
		public static global::Org.BouncyCastle.Asn1.X509.Time GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.X509.Time)
			{
				return (global::Org.BouncyCastle.Asn1.X509.Time)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.DerUtcTime)
			{
				return new global::Org.BouncyCastle.Asn1.X509.Time((global::Org.BouncyCastle.Asn1.DerUtcTime)obj);
			}
			if (obj is global::Org.BouncyCastle.Asn1.DerGeneralizedTime)
			{
				return new global::Org.BouncyCastle.Asn1.X509.Time((global::Org.BouncyCastle.Asn1.DerGeneralizedTime)obj);
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003CE5 RID: 15589 RVA: 0x00115FD5 File Offset: 0x001141D5
		public string GetTime()
		{
			if (this.time is global::Org.BouncyCastle.Asn1.DerUtcTime)
			{
				return ((global::Org.BouncyCastle.Asn1.DerUtcTime)this.time).AdjustedTimeString;
			}
			return ((global::Org.BouncyCastle.Asn1.DerGeneralizedTime)this.time).GetTime();
		}

		// Token: 0x06003CE6 RID: 15590 RVA: 0x00116008 File Offset: 0x00114208
		public global::System.DateTime ToDateTime()
		{
			global::System.DateTime result;
			try
			{
				if (this.time is global::Org.BouncyCastle.Asn1.DerUtcTime)
				{
					result = ((global::Org.BouncyCastle.Asn1.DerUtcTime)this.time).ToAdjustedDateTime();
				}
				else
				{
					result = ((global::Org.BouncyCastle.Asn1.DerGeneralizedTime)this.time).ToDateTime();
				}
			}
			catch (global::System.FormatException e)
			{
				throw new global::System.InvalidOperationException("invalid date string: " + e.Message);
			}
			return result;
		}

		// Token: 0x06003CE7 RID: 15591 RVA: 0x00116070 File Offset: 0x00114270
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return this.time;
		}

		// Token: 0x06003CE8 RID: 15592 RVA: 0x00116078 File Offset: 0x00114278
		public override string ToString()
		{
			return this.GetTime();
		}

		// Token: 0x04001AE1 RID: 6881
		private readonly global::Org.BouncyCastle.Asn1.Asn1Object time;
	}
}
