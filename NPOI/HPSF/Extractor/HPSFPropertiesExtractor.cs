using System;
using System.Globalization;
using System.Text;
using NPOI.HPSF.Wellknown;
using NPOI.POIFS.FileSystem;

namespace NPOI.HPSF.Extractor
{
	// Token: 0x02000529 RID: 1321
	public class HPSFPropertiesExtractor : global::NPOI.POIOLE2TextExtractor
	{
		// Token: 0x06003199 RID: 12697 RVA: 0x00095DD6 File Offset: 0x00093FD6
		public HPSFPropertiesExtractor(global::NPOI.POIOLE2TextExtractor mainExtractor) : base(mainExtractor)
		{
		}

		// Token: 0x0600319A RID: 12698 RVA: 0x00095DDF File Offset: 0x00093FDF
		public HPSFPropertiesExtractor(global::NPOI.POIDocument doc) : base(doc)
		{
		}

		// Token: 0x0600319B RID: 12699 RVA: 0x00095DE8 File Offset: 0x00093FE8
		public HPSFPropertiesExtractor(global::NPOI.POIFS.FileSystem.POIFSFileSystem fs) : base(new global::NPOI.HPSF.HPSFPropertiesOnlyDocument(fs))
		{
		}

		// Token: 0x0600319C RID: 12700 RVA: 0x00095DF6 File Offset: 0x00093FF6
		public HPSFPropertiesExtractor(global::NPOI.POIFS.FileSystem.NPOIFSFileSystem fs) : base(new global::NPOI.HPSF.HPSFPropertiesOnlyDocument(fs))
		{
		}

		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x0600319D RID: 12701 RVA: 0x00095E04 File Offset: 0x00094004
		public string DocumentSummaryInformationText
		{
			get
			{
				if (this.document == null)
				{
					return "";
				}
				global::NPOI.HPSF.DocumentSummaryInformation documentSummaryInformation = this.document.DocumentSummaryInformation;
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				stringBuilder.Append(global::NPOI.HPSF.Extractor.HPSFPropertiesExtractor.GetPropertiesText(documentSummaryInformation));
				global::NPOI.HPSF.CustomProperties customProperties = (documentSummaryInformation == null) ? null : documentSummaryInformation.CustomProperties;
				if (customProperties != null)
				{
					foreach (object obj in customProperties.NameSet())
					{
						string text = obj.ToString();
						string propertyValueText = global::NPOI.HPSF.Extractor.HPSFPropertiesExtractor.HelperPropertySet.GetPropertyValueText(customProperties[text]);
						stringBuilder.Append(text + " = " + propertyValueText + "\n");
					}
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x17000CF0 RID: 3312
		// (get) Token: 0x0600319E RID: 12702 RVA: 0x00095EA0 File Offset: 0x000940A0
		public string SummaryInformationText
		{
			get
			{
				if (this.document == null)
				{
					return "";
				}
				return global::NPOI.HPSF.Extractor.HPSFPropertiesExtractor.GetPropertiesText(this.document.SummaryInformation);
			}
		}

		// Token: 0x0600319F RID: 12703 RVA: 0x00095EC0 File Offset: 0x000940C0
		private static string GetPropertiesText(global::NPOI.HPSF.SpecialPropertySet ps)
		{
			if (ps == null)
			{
				return "";
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			global::NPOI.HPSF.Wellknown.PropertyIDMap propertySetIDMap = ps.PropertySetIDMap;
			global::NPOI.HPSF.Property[] properties = ps.Properties;
			for (int i = 0; i < properties.Length; i++)
			{
				string str = properties[i].ID.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
				object obj = propertySetIDMap.Get(properties[i].ID);
				if (obj != null)
				{
					str = obj.ToString();
				}
				string propertyValueText = global::NPOI.HPSF.Extractor.HPSFPropertiesExtractor.HelperPropertySet.GetPropertyValueText(properties[i].Value);
				stringBuilder.Append(str + " = " + propertyValueText + "\n");
			}
			return stringBuilder.ToString();
		}

		// Token: 0x17000CF1 RID: 3313
		// (get) Token: 0x060031A0 RID: 12704 RVA: 0x00095F5C File Offset: 0x0009415C
		public override string Text
		{
			get
			{
				return this.SummaryInformationText + this.DocumentSummaryInformationText;
			}
		}

		// Token: 0x17000CF2 RID: 3314
		// (get) Token: 0x060031A1 RID: 12705 RVA: 0x00095F6F File Offset: 0x0009416F
		public override global::NPOI.POITextExtractor MetadataTextExtractor
		{
			get
			{
				throw new global::System.InvalidOperationException("You already have the Metadata Text Extractor, not recursing!");
			}
		}

		// Token: 0x0200062B RID: 1579
		public abstract class HelperPropertySet : global::NPOI.HPSF.SpecialPropertySet
		{
			// Token: 0x060036E4 RID: 14052 RVA: 0x000A7B0D File Offset: 0x000A5D0D
			public HelperPropertySet() : base(null)
			{
			}

			// Token: 0x060036E5 RID: 14053 RVA: 0x000A7B16 File Offset: 0x000A5D16
			public static string GetPropertyValueText(object val)
			{
				if (val == null)
				{
					return "(not set)";
				}
				return global::NPOI.HPSF.SpecialPropertySet.GetPropertyStringValue(val);
			}
		}
	}
}
