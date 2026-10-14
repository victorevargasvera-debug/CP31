using System;
using System.Collections.Generic;
using System.IO;
using NPOI.OpenXml4Net.OPC;
using NPOI.SS.UserModel;
using NPOI.Util;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x02000093 RID: 147
	public class XSSFPictureData : global::NPOI.POIXMLDocumentPart, global::NPOI.SS.UserModel.IPictureData
	{
		// Token: 0x0600079A RID: 1946 RVA: 0x0001972C File Offset: 0x0001792C
		static XSSFPictureData()
		{
			global::NPOI.XSSF.UserModel.XSSFPictureData.RELATIONS[2] = global::NPOI.XSSF.UserModel.XSSFRelation.IMAGE_EMF;
			global::NPOI.XSSF.UserModel.XSSFPictureData.RELATIONS[3] = global::NPOI.XSSF.UserModel.XSSFRelation.IMAGE_WMF;
			global::NPOI.XSSF.UserModel.XSSFPictureData.RELATIONS[4] = global::NPOI.XSSF.UserModel.XSSFRelation.IMAGE_PICT;
			global::NPOI.XSSF.UserModel.XSSFPictureData.RELATIONS[5] = global::NPOI.XSSF.UserModel.XSSFRelation.IMAGE_JPEG;
			global::NPOI.XSSF.UserModel.XSSFPictureData.RELATIONS[6] = global::NPOI.XSSF.UserModel.XSSFRelation.IMAGE_PNG;
			global::NPOI.XSSF.UserModel.XSSFPictureData.RELATIONS[7] = global::NPOI.XSSF.UserModel.XSSFRelation.IMAGE_DIB;
			global::NPOI.XSSF.UserModel.XSSFPictureData.RELATIONS[global::NPOI.XSSF.UserModel.XSSFWorkbook.PICTURE_TYPE_GIF] = global::NPOI.XSSF.UserModel.XSSFRelation.IMAGE_GIF;
			global::NPOI.XSSF.UserModel.XSSFPictureData.RELATIONS[global::NPOI.XSSF.UserModel.XSSFWorkbook.PICTURE_TYPE_TIFF] = global::NPOI.XSSF.UserModel.XSSFRelation.IMAGE_TIFF;
			global::NPOI.XSSF.UserModel.XSSFPictureData.RELATIONS[global::NPOI.XSSF.UserModel.XSSFWorkbook.PICTURE_TYPE_EPS] = global::NPOI.XSSF.UserModel.XSSFRelation.IMAGE_EPS;
			global::NPOI.XSSF.UserModel.XSSFPictureData.RELATIONS[global::NPOI.XSSF.UserModel.XSSFWorkbook.PICTURE_TYPE_BMP] = global::NPOI.XSSF.UserModel.XSSFRelation.IMAGE_BMP;
			global::NPOI.XSSF.UserModel.XSSFPictureData.RELATIONS[global::NPOI.XSSF.UserModel.XSSFWorkbook.PICTURE_TYPE_WPG] = global::NPOI.XSSF.UserModel.XSSFRelation.IMAGE_WPG;
			global::NPOI.XSSF.UserModel.XSSFPictureData.RELATIONS[global::NPOI.XSSF.UserModel.XSSFWorkbook.PICTURE_TYPE_JPG] = global::NPOI.XSSF.UserModel.XSSFRelation.IMAGE_JPG;
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x0000A972 File Offset: 0x00008B72
		public XSSFPictureData()
		{
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x0000A97A File Offset: 0x00008B7A
		public XSSFPictureData(global::NPOI.OpenXml4Net.OPC.PackagePart part) : base(part)
		{
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x0001981D File Offset: 0x00017A1D
		[global::System.Obsolete("deprecated in POI 3.14, scheduled for removal in POI 3.16")]
		internal XSSFPictureData(global::NPOI.OpenXml4Net.OPC.PackagePart part, global::NPOI.OpenXml4Net.OPC.PackageRelationship rel) : this(part)
		{
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x0000A9ED File Offset: 0x00008BED
		public string SuggestFileExtension()
		{
			return base.GetPackagePart().PartName.Extension;
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x0600079F RID: 1951 RVA: 0x00019828 File Offset: 0x00017A28
		public global::NPOI.SS.UserModel.PictureType PictureType
		{
			get
			{
				string contentType = base.GetPackagePart().ContentType;
				using (global::System.Collections.Generic.Dictionary<int, global::NPOI.POIXMLRelation>.KeyCollection.Enumerator enumerator = global::NPOI.XSSF.UserModel.XSSFPictureData.RELATIONS.Keys.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						global::NPOI.SS.UserModel.PictureType pictureType = (global::NPOI.SS.UserModel.PictureType)enumerator.Current;
						if (global::NPOI.XSSF.UserModel.XSSFPictureData.RELATIONS[(int)pictureType].ContentType.Equals(contentType))
						{
							return pictureType;
						}
					}
				}
				return global::NPOI.SS.UserModel.PictureType.None;
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x060007A0 RID: 1952 RVA: 0x000198A4 File Offset: 0x00017AA4
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

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x060007A1 RID: 1953 RVA: 0x000198DC File Offset: 0x00017ADC
		public string MimeType
		{
			get
			{
				return base.GetPackagePart().ContentType;
			}
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x000029BF File Offset: 0x00000BBF
		protected internal override void PrepareForCommit()
		{
		}

		// Token: 0x040002FC RID: 764
		internal static global::System.Collections.Generic.Dictionary<int, global::NPOI.POIXMLRelation> RELATIONS = new global::System.Collections.Generic.Dictionary<int, global::NPOI.POIXMLRelation>(12);
	}
}
