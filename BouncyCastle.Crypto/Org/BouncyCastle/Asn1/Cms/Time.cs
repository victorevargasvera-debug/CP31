using System;
using System.Globalization;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cms
{
	// Token: 0x02000765 RID: 1893
	public class Time : global::Org.BouncyCastle.Asn1.Asn1Encodable, global::Org.BouncyCastle.Asn1.IAsn1Choice
	{
		// Token: 0x060043A6 RID: 17318 RVA: 0x0012EAB8 File Offset: 0x0012CCB8
		public static global::Org.BouncyCastle.Asn1.Cms.Time GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.Cms.Time.GetInstance(obj.GetObject());
		}

		// Token: 0x060043A7 RID: 17319 RVA: 0x0012EAC5 File Offset: 0x0012CCC5
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

		// Token: 0x060043A8 RID: 17320 RVA: 0x0012EB00 File Offset: 0x0012CD00
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

		// Token: 0x060043A9 RID: 17321 RVA: 0x0012EB6C File Offset: 0x0012CD6C
		public static global::Org.BouncyCastle.Asn1.Cms.Time GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Cms.Time)
			{
				return (global::Org.BouncyCastle.Asn1.Cms.Time)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.DerUtcTime)
			{
				return new global::Org.BouncyCastle.Asn1.Cms.Time((global::Org.BouncyCastle.Asn1.DerUtcTime)obj);
			}
			if (obj is global::Org.BouncyCastle.Asn1.DerGeneralizedTime)
			{
				return new global::Org.BouncyCastle.Asn1.Cms.Time((global::Org.BouncyCastle.Asn1.DerGeneralizedTime)obj);
			}
			throw new global::System.ArgumentException("unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x060043AA RID: 17322 RVA: 0x0012EBCD File Offset: 0x0012CDCD
		public string TimeString
		{
			get
			{
				if (this.time is global::Org.BouncyCastle.Asn1.DerUtcTime)
				{
					return ((global::Org.BouncyCastle.Asn1.DerUtcTime)this.time).AdjustedTimeString;
				}
				return ((global::Org.BouncyCastle.Asn1.DerGeneralizedTime)this.time).GetTime();
			}
		}

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x060043AB RID: 17323 RVA: 0x0012EC00 File Offset: 0x0012CE00
		public global::System.DateTime Date
		{
			get
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
		}

		// Token: 0x060043AC RID: 17324 RVA: 0x0012EC68 File Offset: 0x0012CE68
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return this.time;
		}

		// Token: 0x04002087 RID: 8327
		private readonly global::Org.BouncyCastle.Asn1.Asn1Object time;
	}
}
