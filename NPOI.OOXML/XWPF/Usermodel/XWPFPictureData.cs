using System;
using System.IO;
using NPOI.OpenXml4Net.OPC;
using NPOI.Util;

namespace NPOI.XWPF.UserModel
{
	// Token: 0x02000044 RID: 68
	public class XWPFPictureData : global::NPOI.POIXMLDocumentPart
	{
		// Token: 0x060002B5 RID: 693 RVA: 0x0000A8C4 File Offset: 0x00008AC4
		static XWPFPictureData()
		{
			global::NPOI.XWPF.UserModel.XWPFPictureData.RELATIONS[2] = global::NPOI.XWPF.UserModel.XWPFRelation.IMAGE_EMF;
			global::NPOI.XWPF.UserModel.XWPFPictureData.RELATIONS[3] = global::NPOI.XWPF.UserModel.XWPFRelation.IMAGE_WMF;
			global::NPOI.XWPF.UserModel.XWPFPictureData.RELATIONS[4] = global::NPOI.XWPF.UserModel.XWPFRelation.IMAGE_PICT;
			global::NPOI.XWPF.UserModel.XWPFPictureData.RELATIONS[5] = global::NPOI.XWPF.UserModel.XWPFRelation.IMAGE_JPEG;
			global::NPOI.XWPF.UserModel.XWPFPictureData.RELATIONS[6] = global::NPOI.XWPF.UserModel.XWPFRelation.IMAGE_PNG;
			global::NPOI.XWPF.UserModel.XWPFPictureData.RELATIONS[7] = global::NPOI.XWPF.UserModel.XWPFRelation.IMAGE_DIB;
			global::NPOI.XWPF.UserModel.XWPFPictureData.RELATIONS[8] = global::NPOI.XWPF.UserModel.XWPFRelation.IMAGE_GIF;
			global::NPOI.XWPF.UserModel.XWPFPictureData.RELATIONS[9] = global::NPOI.XWPF.UserModel.XWPFRelation.IMAGE_TIFF;
			global::NPOI.XWPF.UserModel.XWPFPictureData.RELATIONS[10] = global::NPOI.XWPF.UserModel.XWPFRelation.IMAGE_EPS;
			global::NPOI.XWPF.UserModel.XWPFPictureData.RELATIONS[11] = global::NPOI.XWPF.UserModel.XWPFRelation.IMAGE_BMP;
			global::NPOI.XWPF.UserModel.XWPFPictureData.RELATIONS[12] = global::NPOI.XWPF.UserModel.XWPFRelation.IMAGE_WPG;
			global::NPOI.XWPF.UserModel.XWPFPictureData.RELATIONS[13] = global::NPOI.XWPF.UserModel.XWPFRelation.IMAGE_SVG;
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0000A972 File Offset: 0x00008B72
		protected XWPFPictureData()
		{
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0000A97A File Offset: 0x00008B7A
		public XWPFPictureData(global::NPOI.OpenXml4Net.OPC.PackagePart part) : base(part)
		{
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0000A983 File Offset: 0x00008B83
		[global::System.Obsolete("deprecated in POI 3.14, scheduled for removal in POI 3.16")]
		public XWPFPictureData(global::NPOI.OpenXml4Net.OPC.PackagePart part, global::NPOI.OpenXml4Net.OPC.PackageRelationship rel) : this(part)
		{
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x0000A98C File Offset: 0x00008B8C
		internal override void OnDocumentRead()
		{
			base.OnDocumentRead();
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060002BA RID: 698 RVA: 0x0000A994 File Offset: 0x00008B94
		public byte[] Data
		{
			get
			{
				byte[] result;
				try
				{
					result = global::NPOI.Util.IOUtils.ToByteArray(base.GetPackagePart().GetInputStream());
				}
				catch (global::System.IO.IOException ex)
				{
					throw new global::NPOI.POIXMLException(ex);
				}
				return result;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060002BB RID: 699 RVA: 0x0000A9CC File Offset: 0x00008BCC
		public string FileName
		{
			get
			{
				string name = base.GetPackagePart().PartName.Name;
				return name.Substring(name.LastIndexOf('/') + 1);
			}
		}

		// Token: 0x060002BC RID: 700 RVA: 0x0000A9ED File Offset: 0x00008BED
		public string SuggestFileExtension()
		{
			return base.GetPackagePart().PartName.Extension;
		}

		// Token: 0x060002BD RID: 701 RVA: 0x0000AA00 File Offset: 0x00008C00
		public int GetPictureType()
		{
			string contentType = base.GetPackagePart().ContentType;
			for (int i = 0; i < global::NPOI.XWPF.UserModel.XWPFPictureData.RELATIONS.Length; i++)
			{
				if (global::NPOI.XWPF.UserModel.XWPFPictureData.RELATIONS[i] != null && global::NPOI.XWPF.UserModel.XWPFPictureData.RELATIONS[i].ContentType.Equals(contentType))
				{
					return i;
				}
			}
			return 0;
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060002BE RID: 702 RVA: 0x0000AA4C File Offset: 0x00008C4C
		public long Checksum
		{
			get
			{
				if (this.checksum == null)
				{
					global::System.IO.Stream stream = null;
					byte[] data;
					try
					{
						stream = base.GetPackagePart().GetInputStream();
						data = global::NPOI.Util.IOUtils.ToByteArray(stream);
					}
					catch (global::System.IO.IOException ex)
					{
						throw new global::NPOI.POIXMLException(ex);
					}
					finally
					{
						try
						{
							if (stream != null)
							{
								stream.Close();
							}
						}
						catch (global::System.IO.IOException ex2)
						{
							throw new global::NPOI.POIXMLException(ex2);
						}
					}
					this.checksum = new long?(global::NPOI.Util.IOUtils.CalculateChecksum(data));
				}
				return this.checksum.Value;
			}
		}

		// Token: 0x060002BF RID: 703 RVA: 0x0000AADC File Offset: 0x00008CDC
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			if (obj == null)
			{
				return false;
			}
			if (!(obj is global::NPOI.XWPF.UserModel.XWPFPictureData))
			{
				return false;
			}
			global::NPOI.XWPF.UserModel.XWPFPictureData xwpfpictureData = (global::NPOI.XWPF.UserModel.XWPFPictureData)obj;
			global::NPOI.OpenXml4Net.OPC.PackagePart packagePart = xwpfpictureData.GetPackagePart();
			global::NPOI.OpenXml4Net.OPC.PackagePart packagePart2 = base.GetPackagePart();
			if ((packagePart != null && packagePart2 == null) || (packagePart == null && packagePart2 != null))
			{
				return false;
			}
			if (packagePart2 != null)
			{
				global::NPOI.OpenXml4Net.OPC.OPCPackage package = packagePart.Package;
				global::NPOI.OpenXml4Net.OPC.OPCPackage package2 = packagePart2.Package;
				if ((package != null && package2 == null) || (package == null && package2 != null))
				{
					return false;
				}
				if (package2 != null && !package2.Equals(package))
				{
					return false;
				}
			}
			long obj2 = xwpfpictureData.Checksum;
			return this.Checksum.Equals(obj2) && global::NPOI.Util.Arrays.Equals(this.Data, xwpfpictureData.Data);
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x0000AB84 File Offset: 0x00008D84
		public override int GetHashCode()
		{
			return this.Checksum.GetHashCode();
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x000029BF File Offset: 0x00000BBF
		protected internal override void PrepareForCommit()
		{
		}

		// Token: 0x040001EE RID: 494
		internal static global::NPOI.POIXMLRelation[] RELATIONS = new global::NPOI.POIXMLRelation[14];

		// Token: 0x040001EF RID: 495
		private long? checksum;
	}
}
