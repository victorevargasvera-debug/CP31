using System;
using System.Collections.Generic;
using System.IO;
using NPOI.POIFS.FileSystem;
using NPOI.Util;

namespace NPOI.HPSF
{
	// Token: 0x02000512 RID: 1298
	[global::System.Serializable]
	public class MutablePropertySet : global::NPOI.HPSF.PropertySet
	{
		// Token: 0x06003083 RID: 12419 RVA: 0x00092684 File Offset: 0x00090884
		public MutablePropertySet()
		{
			this.byteOrder = global::NPOI.Util.LittleEndian.GetUShort(global::NPOI.HPSF.PropertySet.BYTE_ORDER_ASSERTION);
			this.format = global::NPOI.Util.LittleEndian.GetUShort(global::NPOI.HPSF.PropertySet.FORMAT_ASSERTION);
			this.osVersion = 133636;
			this.classID = new global::NPOI.Util.ClassID();
			this.sections = new global::System.Collections.Generic.List<global::NPOI.HPSF.Section>();
			this.sections.Add(new global::NPOI.HPSF.MutableSection());
		}

		// Token: 0x06003084 RID: 12420 RVA: 0x00092704 File Offset: 0x00090904
		public MutablePropertySet(global::NPOI.HPSF.PropertySet ps)
		{
			this.byteOrder = ps.ByteOrder;
			this.format = ps.Format;
			this.osVersion = ps.OSVersion;
			this.ClassID = ps.ClassID;
			this.ClearSections();
			if (this.sections == null)
			{
				this.sections = new global::System.Collections.Generic.List<global::NPOI.HPSF.Section>();
			}
			foreach (global::NPOI.HPSF.Section s in ps.Sections)
			{
				global::NPOI.HPSF.MutableSection section = new global::NPOI.HPSF.MutableSection(s);
				this.AddSection(section);
			}
		}

		// Token: 0x17000CA7 RID: 3239
		// (get) Token: 0x06003085 RID: 12421 RVA: 0x000927C8 File Offset: 0x000909C8
		// (set) Token: 0x06003086 RID: 12422 RVA: 0x000927D0 File Offset: 0x000909D0
		public override int ByteOrder
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

		// Token: 0x17000CA8 RID: 3240
		// (get) Token: 0x06003088 RID: 12424 RVA: 0x000927E2 File Offset: 0x000909E2
		// (set) Token: 0x06003087 RID: 12423 RVA: 0x000927D9 File Offset: 0x000909D9
		public override int Format
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

		// Token: 0x17000CA9 RID: 3241
		// (get) Token: 0x0600308A RID: 12426 RVA: 0x000927F3 File Offset: 0x000909F3
		// (set) Token: 0x06003089 RID: 12425 RVA: 0x000927EA File Offset: 0x000909EA
		public override int OSVersion
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

		// Token: 0x17000CAA RID: 3242
		// (get) Token: 0x0600308C RID: 12428 RVA: 0x00092804 File Offset: 0x00090A04
		// (set) Token: 0x0600308B RID: 12427 RVA: 0x000927FB File Offset: 0x000909FB
		public override global::NPOI.Util.ClassID ClassID
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

		// Token: 0x0600308D RID: 12429 RVA: 0x0009280C File Offset: 0x00090A0C
		public virtual void ClearSections()
		{
			this.sections = null;
		}

		// Token: 0x0600308E RID: 12430 RVA: 0x00092815 File Offset: 0x00090A15
		public virtual void AddSection(global::NPOI.HPSF.Section section)
		{
			if (this.sections == null)
			{
				this.sections = new global::System.Collections.Generic.List<global::NPOI.HPSF.Section>();
			}
			this.sections.Add(section);
		}

		// Token: 0x0600308F RID: 12431 RVA: 0x00092838 File Offset: 0x00090A38
		public virtual void Write(global::System.IO.Stream out1)
		{
			int count = this.sections.Count;
			int num = 0;
			num += global::NPOI.HPSF.TypeWriter.WriteToStream(out1, (short)this.ByteOrder);
			num += global::NPOI.HPSF.TypeWriter.WriteToStream(out1, (short)this.Format);
			num += global::NPOI.HPSF.TypeWriter.WriteToStream(out1, this.OSVersion);
			num += global::NPOI.HPSF.TypeWriter.WriteToStream(out1, this.ClassID);
			num += global::NPOI.HPSF.TypeWriter.WriteToStream(out1, count);
			int num2 = this.OFFSET_HEADER;
			num2 += count * (this.ClassID.Length + 4);
			int num3 = num2;
			foreach (object obj in this.sections)
			{
				global::NPOI.HPSF.MutableSection mutableSection = (global::NPOI.HPSF.MutableSection)obj;
				if (mutableSection.FormatID == null)
				{
					throw new global::NPOI.HPSF.NoFormatIDException();
				}
				num += global::NPOI.HPSF.TypeWriter.WriteToStream(out1, mutableSection.FormatID);
				num += global::NPOI.HPSF.TypeWriter.WriteUIntToStream(out1, (uint)num2);
				num2 += mutableSection.Size;
			}
			num2 = num3;
			foreach (object obj2 in this.sections)
			{
				global::NPOI.HPSF.MutableSection mutableSection2 = (global::NPOI.HPSF.MutableSection)obj2;
				num2 += mutableSection2.Write(out1);
			}
			out1.Close();
		}

		// Token: 0x06003090 RID: 12432 RVA: 0x00092954 File Offset: 0x00090B54
		public virtual global::System.IO.Stream ToInputStream()
		{
			global::System.IO.Stream result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
			{
				try
				{
					this.Write(memoryStream);
					memoryStream.Flush();
				}
				finally
				{
					memoryStream.Close();
				}
				result = new global::System.IO.MemoryStream(memoryStream.ToArray());
			}
			return result;
		}

		// Token: 0x06003091 RID: 12433 RVA: 0x000929B4 File Offset: 0x00090BB4
		public virtual void Write(global::NPOI.POIFS.FileSystem.DirectoryEntry dir, string name)
		{
			try
			{
				dir.GetEntry(name).Delete();
			}
			catch (global::System.IO.FileNotFoundException)
			{
			}
			dir.CreateDocument(name, this.ToInputStream());
		}

		// Token: 0x04001588 RID: 5512
		private int OFFSET_HEADER = global::NPOI.HPSF.PropertySet.BYTE_ORDER_ASSERTION.Length + global::NPOI.HPSF.PropertySet.FORMAT_ASSERTION.Length + 4 + 16 + 4;
	}
}
