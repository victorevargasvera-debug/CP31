using System;
using System.Text;
using NPOI.OpenXml4Net.OPC.Internal;
using NPOI.OpenXmlFormats;

namespace NPOI
{
	// Token: 0x0200000A RID: 10
	public class POIXMLPropertiesTextExtractor : global::NPOI.POIXMLTextExtractor
	{
		// Token: 0x0600008F RID: 143 RVA: 0x00003A04 File Offset: 0x00001C04
		public POIXMLPropertiesTextExtractor(global::NPOI.POIXMLDocument doc) : base(doc)
		{
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00003A0D File Offset: 0x00001C0D
		public POIXMLPropertiesTextExtractor(global::NPOI.POIXMLTextExtractor otherExtractor) : base(otherExtractor.Document)
		{
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00003A1B File Offset: 0x00001C1B
		private void AppendIfPresent(global::System.Text.StringBuilder text, string thing, bool value)
		{
			this.AppendIfPresent(text, thing, value.ToString());
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00003A2C File Offset: 0x00001C2C
		private void AppendIfPresent(global::System.Text.StringBuilder text, string thing, int value)
		{
			this.AppendIfPresent(text, thing, value.ToString());
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00003A3D File Offset: 0x00001C3D
		private void AppendIfPresent(global::System.Text.StringBuilder text, string thing, global::System.DateTime? value)
		{
			if (value == null)
			{
				return;
			}
			this.AppendIfPresent(text, thing, value.ToString());
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00003A5E File Offset: 0x00001C5E
		private void AppendIfPresent(global::System.Text.StringBuilder text, string thing, string value)
		{
			if (value == null)
			{
				return;
			}
			text.Append(thing);
			text.Append(" = ");
			text.Append(value);
			text.Append("\n");
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00003A8C File Offset: 0x00001C8C
		public string GetCorePropertiesText()
		{
			if (base.Document == null)
			{
				return "";
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			global::NPOI.OpenXml4Net.OPC.Internal.PackagePropertiesPart underlyingProperties = base.Document.GetProperties().CoreProperties.GetUnderlyingProperties();
			this.AppendIfPresent(stringBuilder, "Category", underlyingProperties.GetCategoryProperty());
			this.AppendIfPresent(stringBuilder, "Category", underlyingProperties.GetCategoryProperty());
			this.AppendIfPresent(stringBuilder, "ContentStatus", underlyingProperties.GetContentStatusProperty());
			this.AppendIfPresent(stringBuilder, "ContentType", underlyingProperties.GetContentTypeProperty());
			this.AppendIfPresent(stringBuilder, "Created", new global::System.DateTime?(underlyingProperties.GetCreatedProperty().Value));
			this.AppendIfPresent(stringBuilder, "CreatedString", underlyingProperties.GetCreatedPropertyString());
			this.AppendIfPresent(stringBuilder, "Creator", underlyingProperties.GetCreatorProperty());
			this.AppendIfPresent(stringBuilder, "Description", underlyingProperties.GetDescriptionProperty());
			this.AppendIfPresent(stringBuilder, "Identifier", underlyingProperties.GetIdentifierProperty());
			this.AppendIfPresent(stringBuilder, "Keywords", underlyingProperties.GetKeywordsProperty());
			this.AppendIfPresent(stringBuilder, "Language", underlyingProperties.GetLanguageProperty());
			this.AppendIfPresent(stringBuilder, "LastModifiedBy", underlyingProperties.GetLastModifiedByProperty());
			this.AppendIfPresent(stringBuilder, "LastPrinted", underlyingProperties.GetLastPrintedProperty());
			this.AppendIfPresent(stringBuilder, "LastPrintedString", underlyingProperties.GetLastPrintedPropertyString());
			this.AppendIfPresent(stringBuilder, "Modified", underlyingProperties.GetModifiedProperty());
			this.AppendIfPresent(stringBuilder, "ModifiedString", underlyingProperties.GetModifiedPropertyString());
			this.AppendIfPresent(stringBuilder, "Revision", underlyingProperties.GetRevisionProperty());
			this.AppendIfPresent(stringBuilder, "Subject", underlyingProperties.GetSubjectProperty());
			this.AppendIfPresent(stringBuilder, "Title", underlyingProperties.GetTitleProperty());
			this.AppendIfPresent(stringBuilder, "Version", underlyingProperties.GetVersionProperty());
			return stringBuilder.ToString();
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00003C40 File Offset: 0x00001E40
		public string GetExtendedPropertiesText()
		{
			if (base.Document == null)
			{
				return "";
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			global::NPOI.OpenXmlFormats.CT_ExtendedProperties underlyingProperties = base.Document.GetProperties().ExtendedProperties.GetUnderlyingProperties();
			this.AppendIfPresent(stringBuilder, "Application", underlyingProperties.Application);
			this.AppendIfPresent(stringBuilder, "AppVersion", underlyingProperties.AppVersion);
			this.AppendIfPresent(stringBuilder, "Characters", underlyingProperties.Characters);
			this.AppendIfPresent(stringBuilder, "CharactersWithSpaces", underlyingProperties.CharactersWithSpaces);
			this.AppendIfPresent(stringBuilder, "Company", underlyingProperties.Company);
			this.AppendIfPresent(stringBuilder, "HyperlinkBase", underlyingProperties.HyperlinkBase);
			this.AppendIfPresent(stringBuilder, "HyperlinksChanged", underlyingProperties.HyperlinksChanged);
			this.AppendIfPresent(stringBuilder, "Lines", underlyingProperties.Lines);
			this.AppendIfPresent(stringBuilder, "LinksUpToDate", underlyingProperties.LinksUpToDate);
			this.AppendIfPresent(stringBuilder, "Manager", underlyingProperties.Manager);
			this.AppendIfPresent(stringBuilder, "Pages", underlyingProperties.Pages);
			this.AppendIfPresent(stringBuilder, "Paragraphs", underlyingProperties.Paragraphs);
			this.AppendIfPresent(stringBuilder, "PresentationFormat", underlyingProperties.PresentationFormat);
			this.AppendIfPresent(stringBuilder, "Template", underlyingProperties.Template);
			this.AppendIfPresent(stringBuilder, "TotalTime", underlyingProperties.TotalTime);
			return stringBuilder.ToString();
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00003D8C File Offset: 0x00001F8C
		public string GetCustomPropertiesText()
		{
			if (base.Document == null)
			{
				return "";
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			foreach (global::NPOI.OpenXmlFormats.CT_Property ct_Property in base.Document.GetProperties().CustomProperties.GetUnderlyingProperties().GetPropertyList())
			{
				string str = "(not implemented!)";
				if (ct_Property.IsSetLpwstr())
				{
					str = ct_Property.GetLpwstr();
				}
				else if (ct_Property.IsSetLpstr())
				{
					str = ct_Property.GetLpstr();
				}
				else if (ct_Property.IsSetDate())
				{
					str = ct_Property.GetDate().ToString();
				}
				else if (ct_Property.IsSetFiletime())
				{
					str = ct_Property.GetFiletime().ToString();
				}
				else if (ct_Property.IsSetBool())
				{
					str = ct_Property.GetBool().ToString();
				}
				else if (ct_Property.IsSetI1())
				{
					str = ct_Property.GetI1().ToString();
				}
				else if (ct_Property.IsSetI2())
				{
					str = ct_Property.GetI2().ToString();
				}
				else if (ct_Property.IsSetI4())
				{
					str = ct_Property.GetI4().ToString();
				}
				else if (ct_Property.IsSetI8())
				{
					str = ct_Property.GetI8().ToString();
				}
				else if (ct_Property.IsSetInt())
				{
					str = ct_Property.GetInt().ToString();
				}
				else if (ct_Property.IsSetUi1())
				{
					str = ct_Property.GetUi1().ToString();
				}
				else if (ct_Property.IsSetUi2())
				{
					str = ct_Property.GetUi2().ToString();
				}
				else if (ct_Property.IsSetUi4())
				{
					str = ct_Property.GetUi4().ToString();
				}
				else if (ct_Property.IsSetUi8())
				{
					str = ct_Property.GetUi8().ToString();
				}
				else if (ct_Property.IsSetUint())
				{
					str = ct_Property.GetUint().ToString();
				}
				else if (ct_Property.IsSetR4())
				{
					str = ct_Property.GetR4().ToString();
				}
				else if (ct_Property.IsSetR8())
				{
					str = ct_Property.GetR8().ToString();
				}
				else if (ct_Property.IsSetDecimal())
				{
					decimal? @decimal = ct_Property.GetDecimal();
					if (@decimal == null)
					{
						str = null;
					}
					else
					{
						str = @decimal.ToString();
					}
				}
				stringBuilder.Append(ct_Property.name + " = " + str + "\n");
			}
			return stringBuilder.ToString();
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00003FFC File Offset: 0x000021FC
		public override string Text
		{
			get
			{
				return this.GetCorePropertiesText() + this.GetExtendedPropertiesText() + this.GetCustomPropertiesText();
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00004015 File Offset: 0x00002215
		public override global::NPOI.POITextExtractor MetadataTextExtractor
		{
			get
			{
				throw new global::System.InvalidOperationException("You already have the Metadata Text Extractor, not recursing!");
			}
		}
	}
}
