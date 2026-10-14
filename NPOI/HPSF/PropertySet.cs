using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using NPOI.HPSF.Wellknown;
using NPOI.Util;

namespace NPOI.HPSF
{
	// Token: 0x02000518 RID: 1304
	[global::System.Serializable]
	public class PropertySet
	{
		// Token: 0x17000CB4 RID: 3252
		// (get) Token: 0x060030C8 RID: 12488 RVA: 0x000927C8 File Offset: 0x000909C8
		// (set) Token: 0x060030C9 RID: 12489 RVA: 0x000927D0 File Offset: 0x000909D0
		public virtual int ByteOrder
		{
			get
			{
				return this.byteOrder;
			}
			set
			{
				this.byteOrder = value;
			}
		}

		// Token: 0x17000CB5 RID: 3253
		// (get) Token: 0x060030CA RID: 12490 RVA: 0x000927E2 File Offset: 0x000909E2
		// (set) Token: 0x060030CB RID: 12491 RVA: 0x000927D9 File Offset: 0x000909D9
		public virtual int Format
		{
			get
			{
				return this.format;
			}
			set
			{
				this.format = value;
			}
		}

		// Token: 0x17000CB6 RID: 3254
		// (get) Token: 0x060030CC RID: 12492 RVA: 0x000927F3 File Offset: 0x000909F3
		// (set) Token: 0x060030CD RID: 12493 RVA: 0x000927EA File Offset: 0x000909EA
		public virtual int OSVersion
		{
			get
			{
				return this.osVersion;
			}
			set
			{
				this.osVersion = value;
			}
		}

		// Token: 0x17000CB7 RID: 3255
		// (get) Token: 0x060030CE RID: 12494 RVA: 0x00092804 File Offset: 0x00090A04
		// (set) Token: 0x060030CF RID: 12495 RVA: 0x000927FB File Offset: 0x000909FB
		public virtual global::NPOI.Util.ClassID ClassID
		{
			get
			{
				return this.classID;
			}
			set
			{
				this.classID = value;
			}
		}

		// Token: 0x17000CB8 RID: 3256
		// (get) Token: 0x060030D0 RID: 12496 RVA: 0x00093804 File Offset: 0x00091A04
		public virtual int SectionCount
		{
			get
			{
				return this.sections.Count;
			}
		}

		// Token: 0x17000CB9 RID: 3257
		// (get) Token: 0x060030D1 RID: 12497 RVA: 0x00093811 File Offset: 0x00091A11
		public virtual global::System.Collections.Generic.List<global::NPOI.HPSF.Section> Sections
		{
			get
			{
				return this.sections;
			}
		}

		// Token: 0x060030D2 RID: 12498 RVA: 0x0000253E File Offset: 0x0000073E
		protected PropertySet()
		{
		}

		// Token: 0x060030D3 RID: 12499 RVA: 0x0009381C File Offset: 0x00091A1C
		public PropertySet(global::System.IO.Stream stream)
		{
			if (global::NPOI.HPSF.PropertySet.IsPropertySetStream(stream))
			{
				byte[] array = new byte[(stream as global::NPOI.Util.ByteArrayInputStream).Available()];
				stream.Read(array, 0, array.Length);
				this.init(array, 0, array.Length);
				return;
			}
			throw new global::NPOI.HPSF.NoPropertySetStreamException("this stream may not be a valid property set stream");
		}

		// Token: 0x060030D4 RID: 12500 RVA: 0x0009386A File Offset: 0x00091A6A
		public PropertySet(byte[] stream, int offset, int Length)
		{
			if (global::NPOI.HPSF.PropertySet.IsPropertySetStream(stream, offset, Length))
			{
				this.init(stream, offset, Length);
				return;
			}
			throw new global::NPOI.HPSF.NoPropertySetStreamException();
		}

		// Token: 0x060030D5 RID: 12501 RVA: 0x0009388B File Offset: 0x00091A8B
		public PropertySet(byte[] stream) : this(stream, 0, stream.Length)
		{
		}

		// Token: 0x060030D6 RID: 12502 RVA: 0x00093898 File Offset: 0x00091A98
		public static bool IsPropertySetStream(global::System.IO.Stream stream)
		{
			global::NPOI.Util.ByteArrayInputStream byteArrayInputStream = stream as global::NPOI.Util.ByteArrayInputStream;
			int num = 50;
			if (byteArrayInputStream == null || !byteArrayInputStream.MarkSupported())
			{
				throw new global::NPOI.HPSF.MarkUnsupportedException(stream.GetType().Name);
			}
			byteArrayInputStream.Mark(num);
			byte[] array = new byte[num];
			int length = stream.Read(array, 0, global::System.Math.Min(array.Length, byteArrayInputStream.Available()));
			bool result = global::NPOI.HPSF.PropertySet.IsPropertySetStream(array, 0, length);
			byteArrayInputStream.Reset();
			return result;
		}

		// Token: 0x060030D7 RID: 12503 RVA: 0x00093900 File Offset: 0x00091B00
		public static bool IsPropertySetStream(byte[] src, int offset, int Length)
		{
			int @ushort = global::NPOI.Util.LittleEndian.GetUShort(src, offset);
			int num = offset + 2;
			byte[] array = new byte[2];
			global::NPOI.Util.LittleEndian.PutShort(array, 0, (short)@ushort);
			if (!global::NPOI.Util.Arrays.Equals(array, global::NPOI.HPSF.PropertySet.BYTE_ORDER_ASSERTION))
			{
				return false;
			}
			int ushort2 = global::NPOI.Util.LittleEndian.GetUShort(src, num);
			num += 2;
			byte[] array2 = new byte[2];
			global::NPOI.Util.LittleEndian.PutShort(array2, 0, (short)ushort2);
			if (!global::NPOI.Util.Arrays.Equals(array2, global::NPOI.HPSF.PropertySet.FORMAT_ASSERTION))
			{
				return false;
			}
			global::NPOI.Util.LittleEndian.GetUInt(src, offset);
			num += 4;
			new global::NPOI.Util.ClassID(src, offset);
			num += 16;
			long @uint = global::NPOI.Util.LittleEndian.GetUInt(src, num);
			num += 4;
			return @uint >= 0L;
		}

		// Token: 0x060030D8 RID: 12504 RVA: 0x0009398C File Offset: 0x00091B8C
		private void init(byte[] src, int offset, int Length)
		{
			this.byteOrder = global::NPOI.Util.LittleEndian.GetUShort(src, offset);
			int num = offset + 2;
			this.format = global::NPOI.Util.LittleEndian.GetUShort(src, num);
			num += 2;
			this.osVersion = (int)global::NPOI.Util.LittleEndian.GetUInt(src, num);
			num += 4;
			this.classID = new global::NPOI.Util.ClassID(src, num);
			num += 16;
			int @int = global::NPOI.Util.LittleEndian.GetInt(src, num);
			num += 4;
			if (@int < 0)
			{
				throw new global::NPOI.HPSF.HPSFRuntimeException("Section count " + @int.ToString() + " is negative.");
			}
			this.sections = new global::System.Collections.Generic.List<global::NPOI.HPSF.Section>(@int);
			for (int i = 0; i < @int; i++)
			{
				global::NPOI.HPSF.Section item = new global::NPOI.HPSF.Section(src, num);
				num += this.ClassID.Length + 4;
				this.sections.Add(item);
			}
		}

		// Token: 0x17000CBA RID: 3258
		// (get) Token: 0x060030D9 RID: 12505 RVA: 0x00093A49 File Offset: 0x00091C49
		public virtual bool IsSummaryInformation
		{
			get
			{
				return this.sections.Count > 0 && global::NPOI.Util.Arrays.Equals(this.sections[0].FormatID.Bytes, global::NPOI.HPSF.Wellknown.SectionIDMap.SUMMARY_INFORMATION_ID);
			}
		}

		// Token: 0x17000CBB RID: 3259
		// (get) Token: 0x060030DA RID: 12506 RVA: 0x00093A7B File Offset: 0x00091C7B
		public virtual bool IsDocumentSummaryInformation
		{
			get
			{
				return this.sections.Count > 0 && global::NPOI.Util.Arrays.Equals(this.sections[0].FormatID.Bytes, global::NPOI.HPSF.Wellknown.SectionIDMap.DOCUMENT_SUMMARY_INFORMATION_ID1);
			}
		}

		// Token: 0x17000CBC RID: 3260
		// (get) Token: 0x060030DB RID: 12507 RVA: 0x00093AAD File Offset: 0x00091CAD
		public virtual global::NPOI.HPSF.Property[] Properties
		{
			get
			{
				return this.FirstSection.Properties;
			}
		}

		// Token: 0x060030DC RID: 12508 RVA: 0x00093ABA File Offset: 0x00091CBA
		public virtual object GetProperty(int id)
		{
			return this.FirstSection.GetProperty((long)id);
		}

		// Token: 0x060030DD RID: 12509 RVA: 0x00093AC9 File Offset: 0x00091CC9
		public virtual bool GetPropertyBooleanValue(int id)
		{
			return this.FirstSection.GetPropertyBooleanValue(id);
		}

		// Token: 0x060030DE RID: 12510 RVA: 0x00093AD7 File Offset: 0x00091CD7
		public virtual int GetPropertyIntValue(int id)
		{
			return this.FirstSection.GetPropertyIntValue((long)id);
		}

		// Token: 0x17000CBD RID: 3261
		// (get) Token: 0x060030DF RID: 12511 RVA: 0x00093AE6 File Offset: 0x00091CE6
		public virtual bool WasNull
		{
			get
			{
				return this.FirstSection.WasNull;
			}
		}

		// Token: 0x17000CBE RID: 3262
		// (get) Token: 0x060030E0 RID: 12512 RVA: 0x00093AF3 File Offset: 0x00091CF3
		public virtual global::NPOI.HPSF.Section FirstSection
		{
			get
			{
				if (this.SectionCount < 1)
				{
					throw new global::NPOI.HPSF.MissingSectionException("Property Set does not contain any sections.");
				}
				return this.sections[0];
			}
		}

		// Token: 0x17000CBF RID: 3263
		// (get) Token: 0x060030E1 RID: 12513 RVA: 0x00093B18 File Offset: 0x00091D18
		public global::NPOI.HPSF.Section SingleSection
		{
			get
			{
				int sectionCount = this.SectionCount;
				if (sectionCount != 1)
				{
					throw new global::NPOI.HPSF.NoSingleSectionException("Property Set Contains " + sectionCount.ToString() + " sections.");
				}
				return this.sections[0];
			}
		}

		// Token: 0x060030E2 RID: 12514 RVA: 0x00093B58 File Offset: 0x00091D58
		public override bool Equals(object o)
		{
			if (o == null || !(o is global::NPOI.HPSF.PropertySet))
			{
				return false;
			}
			global::NPOI.HPSF.PropertySet propertySet = (global::NPOI.HPSF.PropertySet)o;
			int num = propertySet.ByteOrder;
			int num2 = this.ByteOrder;
			global::NPOI.Util.ClassID classID = propertySet.ClassID;
			global::NPOI.Util.ClassID obj = this.ClassID;
			int num3 = propertySet.Format;
			int num4 = this.Format;
			int osversion = propertySet.OSVersion;
			int osversion2 = this.OSVersion;
			int sectionCount = propertySet.SectionCount;
			int sectionCount2 = this.SectionCount;
			return num == num2 && classID.Equals(obj) && num3 == num4 && osversion == osversion2 && sectionCount == sectionCount2 && global::NPOI.HPSF.Util.AreEqual(this.Sections, propertySet.Sections);
		}

		// Token: 0x060030E3 RID: 12515 RVA: 0x00093BF5 File Offset: 0x00091DF5
		public override int GetHashCode()
		{
			throw new global::System.InvalidOperationException("FIXME: Not yet implemented.");
		}

		// Token: 0x060030E4 RID: 12516 RVA: 0x00093C04 File Offset: 0x00091E04
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			int sectionCount = this.SectionCount;
			stringBuilder.Append(base.GetType().Name);
			stringBuilder.Append('[');
			stringBuilder.Append("byteOrder: ");
			stringBuilder.Append(this.ByteOrder);
			stringBuilder.Append(", classID: ");
			stringBuilder.Append(this.ClassID);
			stringBuilder.Append(", format: ");
			stringBuilder.Append(this.Format);
			stringBuilder.Append(", OSVersion: ");
			stringBuilder.Append(this.OSVersion);
			stringBuilder.Append(", sectionCount: ");
			stringBuilder.Append(sectionCount);
			stringBuilder.Append(", sections: [\n");
			foreach (global::NPOI.HPSF.Section section in this.Sections)
			{
				stringBuilder.Append(section.ToString());
			}
			stringBuilder.Append(']');
			stringBuilder.Append(']');
			return stringBuilder.ToString();
		}

		// Token: 0x0400158F RID: 5519
		protected static byte[] BYTE_ORDER_ASSERTION = new byte[]
		{
			254,
			byte.MaxValue
		};

		// Token: 0x04001590 RID: 5520
		protected int byteOrder;

		// Token: 0x04001591 RID: 5521
		protected static byte[] FORMAT_ASSERTION = new byte[2];

		// Token: 0x04001592 RID: 5522
		protected int format;

		// Token: 0x04001593 RID: 5523
		protected int osVersion;

		// Token: 0x04001594 RID: 5524
		public const int OS_WIN16 = 0;

		// Token: 0x04001595 RID: 5525
		public const int OS_MACINTOSH = 1;

		// Token: 0x04001596 RID: 5526
		public const int OS_WIN32 = 2;

		// Token: 0x04001597 RID: 5527
		[global::System.NonSerialized]
		protected global::NPOI.Util.ClassID classID;

		// Token: 0x04001598 RID: 5528
		protected global::System.Collections.Generic.List<global::NPOI.HPSF.Section> sections;
	}
}
