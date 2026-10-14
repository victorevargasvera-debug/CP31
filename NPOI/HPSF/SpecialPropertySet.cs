using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using NPOI.HPSF.Wellknown;
using NPOI.POIFS.FileSystem;
using NPOI.Util;

namespace NPOI.HPSF
{
	// Token: 0x0200051C RID: 1308
	[global::System.Serializable]
	public abstract class SpecialPropertySet : global::NPOI.HPSF.MutablePropertySet
	{
		// Token: 0x17000CC8 RID: 3272
		// (get) Token: 0x06003100 RID: 12544
		public abstract global::NPOI.HPSF.Wellknown.PropertyIDMap PropertySetIDMap { get; }

		// Token: 0x06003101 RID: 12545 RVA: 0x00094565 File Offset: 0x00092765
		public SpecialPropertySet(global::NPOI.HPSF.PropertySet ps)
		{
			this.delegate1 = new global::NPOI.HPSF.MutablePropertySet(ps);
		}

		// Token: 0x06003102 RID: 12546 RVA: 0x00094579 File Offset: 0x00092779
		public SpecialPropertySet(global::NPOI.HPSF.MutablePropertySet ps)
		{
			this.delegate1 = ps;
		}

		// Token: 0x17000CC9 RID: 3273
		// (get) Token: 0x06003103 RID: 12547 RVA: 0x00094588 File Offset: 0x00092788
		// (set) Token: 0x06003104 RID: 12548 RVA: 0x00094595 File Offset: 0x00092795
		public override int ByteOrder
		{
			get
			{
				return this.delegate1.ByteOrder;
			}
			set
			{
				this.delegate1.ByteOrder = value;
			}
		}

		// Token: 0x17000CCA RID: 3274
		// (get) Token: 0x06003105 RID: 12549 RVA: 0x000945A3 File Offset: 0x000927A3
		// (set) Token: 0x06003106 RID: 12550 RVA: 0x000945B0 File Offset: 0x000927B0
		public override int Format
		{
			get
			{
				return this.delegate1.Format;
			}
			set
			{
				this.delegate1.Format = value;
			}
		}

		// Token: 0x17000CCB RID: 3275
		// (get) Token: 0x06003107 RID: 12551 RVA: 0x000945BE File Offset: 0x000927BE
		// (set) Token: 0x06003108 RID: 12552 RVA: 0x000945CB File Offset: 0x000927CB
		public override global::NPOI.Util.ClassID ClassID
		{
			get
			{
				return this.delegate1.ClassID;
			}
			set
			{
				this.delegate1.ClassID = value;
			}
		}

		// Token: 0x17000CCC RID: 3276
		// (get) Token: 0x06003109 RID: 12553 RVA: 0x000945D9 File Offset: 0x000927D9
		public override int SectionCount
		{
			get
			{
				return this.delegate1.SectionCount;
			}
		}

		// Token: 0x17000CCD RID: 3277
		// (get) Token: 0x0600310A RID: 12554 RVA: 0x000945E6 File Offset: 0x000927E6
		public override global::System.Collections.Generic.List<global::NPOI.HPSF.Section> Sections
		{
			get
			{
				return this.delegate1.Sections;
			}
		}

		// Token: 0x17000CCE RID: 3278
		// (get) Token: 0x0600310B RID: 12555 RVA: 0x000945F3 File Offset: 0x000927F3
		public override bool IsSummaryInformation
		{
			get
			{
				return this.delegate1.IsSummaryInformation;
			}
		}

		// Token: 0x0600310C RID: 12556 RVA: 0x00094600 File Offset: 0x00092800
		public override global::System.IO.Stream ToInputStream()
		{
			return this.delegate1.ToInputStream();
		}

		// Token: 0x17000CCF RID: 3279
		// (get) Token: 0x0600310D RID: 12557 RVA: 0x0009460D File Offset: 0x0009280D
		public override bool IsDocumentSummaryInformation
		{
			get
			{
				return this.delegate1.IsDocumentSummaryInformation;
			}
		}

		// Token: 0x17000CD0 RID: 3280
		// (get) Token: 0x0600310E RID: 12558 RVA: 0x0009461A File Offset: 0x0009281A
		public override global::NPOI.HPSF.Section FirstSection
		{
			get
			{
				return this.delegate1.FirstSection;
			}
		}

		// Token: 0x0600310F RID: 12559 RVA: 0x00094627 File Offset: 0x00092827
		public override void AddSection(global::NPOI.HPSF.Section section)
		{
			this.delegate1.AddSection(section);
		}

		// Token: 0x06003110 RID: 12560 RVA: 0x00094635 File Offset: 0x00092835
		public override void ClearSections()
		{
			this.delegate1.ClearSections();
		}

		// Token: 0x17000CD1 RID: 3281
		// (get) Token: 0x06003112 RID: 12562 RVA: 0x00094650 File Offset: 0x00092850
		// (set) Token: 0x06003111 RID: 12561 RVA: 0x00094642 File Offset: 0x00092842
		public override int OSVersion
		{
			get
			{
				return this.delegate1.OSVersion;
			}
			set
			{
				this.delegate1.OSVersion = value;
			}
		}

		// Token: 0x06003113 RID: 12563 RVA: 0x0009465D File Offset: 0x0009285D
		public override void Write(global::NPOI.POIFS.FileSystem.DirectoryEntry dir, string name)
		{
			this.delegate1.Write(dir, name);
		}

		// Token: 0x06003114 RID: 12564 RVA: 0x0009466C File Offset: 0x0009286C
		public override void Write(global::System.IO.Stream out1)
		{
			this.delegate1.Write(out1);
		}

		// Token: 0x06003115 RID: 12565 RVA: 0x0009467A File Offset: 0x0009287A
		public override bool Equals(object o)
		{
			return this.delegate1.Equals(o);
		}

		// Token: 0x17000CD2 RID: 3282
		// (get) Token: 0x06003116 RID: 12566 RVA: 0x00094688 File Offset: 0x00092888
		public override global::NPOI.HPSF.Property[] Properties
		{
			get
			{
				return this.delegate1.Properties;
			}
		}

		// Token: 0x06003117 RID: 12567 RVA: 0x00094695 File Offset: 0x00092895
		public override object GetProperty(int id)
		{
			return this.delegate1.GetProperty(id);
		}

		// Token: 0x06003118 RID: 12568 RVA: 0x000946A3 File Offset: 0x000928A3
		public override bool GetPropertyBooleanValue(int id)
		{
			return this.delegate1.GetPropertyBooleanValue(id);
		}

		// Token: 0x06003119 RID: 12569 RVA: 0x000946B1 File Offset: 0x000928B1
		public override int GetPropertyIntValue(int id)
		{
			return this.delegate1.GetPropertyIntValue(id);
		}

		// Token: 0x0600311A RID: 12570 RVA: 0x000946BF File Offset: 0x000928BF
		protected string GetPropertyStringValue(int propertyId)
		{
			return global::NPOI.HPSF.SpecialPropertySet.GetPropertyStringValue(this.GetProperty(propertyId));
		}

		// Token: 0x0600311B RID: 12571 RVA: 0x000946D0 File Offset: 0x000928D0
		protected static string GetPropertyStringValue(object propertyValue)
		{
			if (propertyValue == null)
			{
				return null;
			}
			if (propertyValue is string)
			{
				return (string)propertyValue;
			}
			if (!(propertyValue is byte[]))
			{
				return propertyValue.ToString();
			}
			byte[] array = (byte[])propertyValue;
			if (array.Length == 0)
			{
				return "";
			}
			if (array.Length == 1)
			{
				return array[0].ToString();
			}
			if (array.Length == 2)
			{
				return global::NPOI.Util.LittleEndian.GetUShort(array).ToString();
			}
			if (array.Length == 4)
			{
				return global::NPOI.Util.LittleEndian.GetUInt(array).ToString();
			}
			return global::System.Text.Encoding.UTF8.GetString(array);
		}

		// Token: 0x0600311C RID: 12572 RVA: 0x00094759 File Offset: 0x00092959
		public override int GetHashCode()
		{
			return this.delegate1.GetHashCode();
		}

		// Token: 0x0600311D RID: 12573 RVA: 0x00094766 File Offset: 0x00092966
		public override string ToString()
		{
			return this.delegate1.ToString();
		}

		// Token: 0x17000CD3 RID: 3283
		// (get) Token: 0x0600311E RID: 12574 RVA: 0x00094773 File Offset: 0x00092973
		public override bool WasNull
		{
			get
			{
				return this.delegate1.WasNull;
			}
		}

		// Token: 0x0400159F RID: 5535
		private global::NPOI.HPSF.MutablePropertySet delegate1;
	}
}
