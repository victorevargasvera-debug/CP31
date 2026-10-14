using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using NPOI.OpenXml4Net.OPC;
using NPOI.OpenXmlFormats.Spreadsheet;

namespace NPOI.XSSF.Model
{
	// Token: 0x020000E6 RID: 230
	public class SharedStringsTable : global::NPOI.POIXMLDocumentPart
	{
		// Token: 0x06000E32 RID: 3634 RVA: 0x00030E5F File Offset: 0x0002F05F
		public SharedStringsTable()
		{
			this._sstDoc = new global::NPOI.OpenXmlFormats.Spreadsheet.SstDocument();
			this._sstDoc.AddNewSst();
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x00030E93 File Offset: 0x0002F093
		public SharedStringsTable(global::NPOI.OpenXml4Net.OPC.PackagePart part) : base(part)
		{
			this.ReadFrom(part.GetInputStream());
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x00030EBE File Offset: 0x0002F0BE
		[global::System.Obsolete("deprecated in POI 3.14, scheduled for removal in POI 3.16")]
		public SharedStringsTable(global::NPOI.OpenXml4Net.OPC.PackagePart part, global::NPOI.OpenXml4Net.OPC.PackageRelationship rel) : this(part)
		{
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x00030EC8 File Offset: 0x0002F0C8
		public void ReadFrom(global::System.IO.Stream is1)
		{
			try
			{
				int num = 0;
				global::System.Xml.XmlDocument xml = global::NPOI.POIXMLDocumentPart.ConvertStreamToXml(is1);
				this._sstDoc = global::NPOI.OpenXmlFormats.Spreadsheet.SstDocument.Parse(xml, global::NPOI.POIXMLDocumentPart.NamespaceManager);
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sst sst = this._sstDoc.GetSst();
				this.count = sst.count;
				this.uniqueCount = sst.uniqueCount;
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_Rst ct_Rst in sst.si)
				{
					string key = this.GetKey(ct_Rst);
					if (key != null && !this.stmap.ContainsKey(key))
					{
						this.stmap.Add(key, num);
					}
					this.strings.Add(ct_Rst);
					num++;
				}
			}
			catch (global::System.Xml.XmlException innerException)
			{
				throw new global::System.IO.IOException("unable to parse shared strings table", innerException);
			}
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x00030FAC File Offset: 0x0002F1AC
		private string GetKey(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Rst st)
		{
			return st.XmlText;
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x00030FB4 File Offset: 0x0002F1B4
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Rst GetEntryAt(int idx)
		{
			return this.strings[idx];
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000E38 RID: 3640 RVA: 0x00030FC2 File Offset: 0x0002F1C2
		public int Count
		{
			get
			{
				return this.count;
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000E39 RID: 3641 RVA: 0x00030FCA File Offset: 0x0002F1CA
		public int UniqueCount
		{
			get
			{
				return this.uniqueCount;
			}
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x00030FD4 File Offset: 0x0002F1D4
		public int AddEntry(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Rst st)
		{
			string key = this.GetKey(st);
			this.count++;
			if (this.stmap.ContainsKey(key))
			{
				return this.stmap[key];
			}
			this.uniqueCount++;
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Rst ct_Rst = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Rst();
			this._sstDoc.GetSst().si.Add(ct_Rst);
			ct_Rst.Set(st);
			int num = this.strings.Count;
			this.stmap[key] = num;
			this.strings.Add(ct_Rst);
			return num;
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000E3B RID: 3643 RVA: 0x00031069 File Offset: 0x0002F269
		public global::System.Collections.Generic.IList<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Rst> Items
		{
			get
			{
				return this.strings.AsReadOnly();
			}
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x00031076 File Offset: 0x0002F276
		public void WriteTo(global::System.IO.Stream out1)
		{
			global::NPOI.OpenXmlFormats.Spreadsheet.CT_Sst sst = this._sstDoc.GetSst();
			sst.count = this.count;
			sst.uniqueCount = this.uniqueCount;
			this._sstDoc.Save(out1);
		}

		// Token: 0x06000E3D RID: 3645 RVA: 0x000310A8 File Offset: 0x0002F2A8
		protected internal override void Commit()
		{
			global::System.IO.Stream outputStream = base.GetPackagePart().GetOutputStream();
			this.WriteTo(outputStream);
			outputStream.Close();
		}

		// Token: 0x04000421 RID: 1057
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Rst> strings = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Rst>();

		// Token: 0x04000422 RID: 1058
		private global::System.Collections.Generic.Dictionary<string, int> stmap = new global::System.Collections.Generic.Dictionary<string, int>();

		// Token: 0x04000423 RID: 1059
		private int count;

		// Token: 0x04000424 RID: 1060
		private int uniqueCount;

		// Token: 0x04000425 RID: 1061
		private global::NPOI.OpenXmlFormats.Spreadsheet.SstDocument _sstDoc;
	}
}
