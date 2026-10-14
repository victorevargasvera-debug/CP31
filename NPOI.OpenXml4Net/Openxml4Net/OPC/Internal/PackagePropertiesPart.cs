using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using NPOI.OpenXml4Net.Exceptions;
using NPOI.SS.Util;

namespace NPOI.OpenXml4Net.OPC.Internal
{
	// Token: 0x02000025 RID: 37
	public class PackagePropertiesPart : global::NPOI.OpenXml4Net.OPC.PackagePart, global::NPOI.OpenXml4Net.OPC.PackageProperties
	{
		// Token: 0x0600019C RID: 412 RVA: 0x00007EF4 File Offset: 0x000060F4
		public PackagePropertiesPart(global::NPOI.OpenXml4Net.OPC.OPCPackage pack, global::NPOI.OpenXml4Net.OPC.PackagePartName partName) : base(pack, partName, global::NPOI.OpenXml4Net.OPC.ContentTypes.CORE_PROPERTIES_PART)
		{
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00007F4A File Offset: 0x0000614A
		public string GetCategoryProperty()
		{
			return this.category;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00007F52 File Offset: 0x00006152
		public string GetContentStatusProperty()
		{
			return this.contentStatus;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00007F5A File Offset: 0x0000615A
		public string GetContentTypeProperty()
		{
			return this.contentType;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00007F62 File Offset: 0x00006162
		public global::System.DateTime? GetCreatedProperty()
		{
			return this.created;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00007F6A File Offset: 0x0000616A
		public string GetCreatedPropertyString()
		{
			return this.GetDateValue(this.created);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00007F78 File Offset: 0x00006178
		public string GetCreatorProperty()
		{
			return this.creator;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00007F80 File Offset: 0x00006180
		public string GetDescriptionProperty()
		{
			return this.description;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00007F88 File Offset: 0x00006188
		public string GetIdentifierProperty()
		{
			return this.identifier;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00007F90 File Offset: 0x00006190
		public string GetKeywordsProperty()
		{
			return this.keywords;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00007F98 File Offset: 0x00006198
		public string GetLanguageProperty()
		{
			return this.language;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00007FA0 File Offset: 0x000061A0
		public string GetLastModifiedByProperty()
		{
			return this.lastModifiedBy;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00007FA8 File Offset: 0x000061A8
		public global::System.DateTime? GetLastPrintedProperty()
		{
			return this.lastPrinted;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00007FB0 File Offset: 0x000061B0
		public string GetLastPrintedPropertyString()
		{
			return this.GetDateValue(this.lastPrinted);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00007FBE File Offset: 0x000061BE
		public global::System.DateTime? GetModifiedProperty()
		{
			return this.modified;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00007FC8 File Offset: 0x000061C8
		public string GetModifiedPropertyString()
		{
			global::System.DateTime value = this.modified.Value;
			return this.GetDateValue(this.modified);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00007FED File Offset: 0x000061ED
		public string GetRevisionProperty()
		{
			return this.revision;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00007FF5 File Offset: 0x000061F5
		public string GetSubjectProperty()
		{
			return this.subject;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00007FFD File Offset: 0x000061FD
		public string GetTitleProperty()
		{
			return this.title;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00008005 File Offset: 0x00006205
		public string GetVersionProperty()
		{
			return this.version;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0000800D File Offset: 0x0000620D
		public void SetCategoryProperty(string category)
		{
			this.category = this.SetStringValue(category);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000801C File Offset: 0x0000621C
		public void SetContentStatusProperty(string contentStatus)
		{
			this.contentStatus = this.SetStringValue(contentStatus);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0000802B File Offset: 0x0000622B
		public void SetContentTypeProperty(string contentType)
		{
			this.contentType = this.SetStringValue(contentType);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0000803C File Offset: 0x0000623C
		public void SetCreatedProperty(string created)
		{
			try
			{
				this.created = this.SetDateValue(created);
			}
			catch (global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException innerException)
			{
				throw new global::System.ArgumentException("Date for created could not be parsed: " + created, innerException);
			}
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0000807C File Offset: 0x0000627C
		public void SetCreatedProperty(global::System.DateTime? created)
		{
			if (created != null)
			{
				this.created = created;
			}
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0000808E File Offset: 0x0000628E
		public void SetCreatorProperty(string creator)
		{
			this.creator = this.SetStringValue(creator);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0000809D File Offset: 0x0000629D
		public void SetDescriptionProperty(string description)
		{
			this.description = this.SetStringValue(description);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x000080AC File Offset: 0x000062AC
		public void SetIdentifierProperty(string identifier)
		{
			this.identifier = this.SetStringValue(identifier);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x000080BB File Offset: 0x000062BB
		public void SetKeywordsProperty(string keywords)
		{
			this.keywords = this.SetStringValue(keywords);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x000080CA File Offset: 0x000062CA
		public void SetLanguageProperty(string language)
		{
			this.language = this.SetStringValue(language);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x000080D9 File Offset: 0x000062D9
		public void SetLastModifiedByProperty(string lastModifiedBy)
		{
			this.lastModifiedBy = this.SetStringValue(lastModifiedBy);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x000080E8 File Offset: 0x000062E8
		public void SetLastPrintedProperty(string lastPrinted)
		{
			try
			{
				this.lastPrinted = this.SetDateValue(lastPrinted);
			}
			catch (global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException ex)
			{
				new global::System.ArgumentException("lastPrinted  : " + ex.Message, ex);
			}
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00008130 File Offset: 0x00006330
		public void SetLastPrintedProperty(global::System.DateTime? lastPrinted)
		{
			if (lastPrinted != null)
			{
				this.lastPrinted = lastPrinted;
			}
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00008144 File Offset: 0x00006344
		public void SetModifiedProperty(string modified)
		{
			try
			{
				this.modified = this.SetDateValue(modified);
			}
			catch (global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException ex)
			{
				new global::System.ArgumentException("modified  : " + ex.Message, ex);
			}
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000818C File Offset: 0x0000638C
		public void SetModifiedProperty(global::System.DateTime? modified)
		{
			if (modified != null)
			{
				this.modified = modified;
			}
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0000819E File Offset: 0x0000639E
		public void SetRevisionProperty(string revision)
		{
			this.revision = this.SetStringValue(revision);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x000081AD File Offset: 0x000063AD
		public void SetSubjectProperty(string subject)
		{
			this.subject = this.SetStringValue(subject);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x000081BC File Offset: 0x000063BC
		public void SetTitleProperty(string title)
		{
			this.title = this.SetStringValue(title);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x000081CB File Offset: 0x000063CB
		public void SetVersionProperty(string version)
		{
			this.version = this.SetStringValue(version);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x000081DA File Offset: 0x000063DA
		private string SetStringValue(string s)
		{
			if (s == null || s.Equals(""))
			{
				return null;
			}
			return s;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x000081F0 File Offset: 0x000063F0
		private global::System.DateTime? SetDateValue(string dateStr)
		{
			if (dateStr == null || dateStr.Equals(""))
			{
				return null;
			}
			global::System.Text.RegularExpressions.Match match = this.TIME_ZONE_PAT.Match(dateStr);
			string source;
			string[] array;
			int i;
			if (match.Success)
			{
				source = dateStr.Substring(0, match.Index) + match.Groups[1].Value + match.Groups[2].Value;
				array = this.TZ_DATE_FORMATS;
				i = 0;
				if (i < array.Length)
				{
					global::System.DateTime value = new global::NPOI.SS.Util.SimpleDateFormat(array[i])
					{
						TimeZone = global::System.TimeZoneInfo.Utc
					}.Parse(source);
					return new global::System.DateTime?(value);
				}
			}
			source = (dateStr.EndsWith("Z") ? dateStr : (dateStr + "Z"));
			array = global::NPOI.OpenXml4Net.OPC.Internal.PackagePropertiesPart.DATE_FORMATS;
			i = 0;
			if (i >= array.Length)
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				int num = 0;
				foreach (string value2 in this.TZ_DATE_FORMATS)
				{
					if (num++ > 0)
					{
						stringBuilder.Append(", ");
					}
					stringBuilder.Append(value2);
				}
				foreach (string value3 in global::NPOI.OpenXml4Net.OPC.Internal.PackagePropertiesPart.DATE_FORMATS)
				{
					stringBuilder.Append(", ").Append(value3);
				}
				throw new global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException("Date " + dateStr + " not well formatted, expected format in: " + stringBuilder.ToString());
			}
			global::System.DateTime value4 = new global::NPOI.SS.Util.SimpleDateFormat(array[i])
			{
				TimeZone = global::System.TimeZoneInfo.Utc
			}.Parse(source).ToUniversalTime();
			return new global::System.DateTime?(value4);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00008390 File Offset: 0x00006590
		private string GetDateValue(global::System.DateTime? d)
		{
			if (d == null || d == null || d.Equals(""))
			{
				return "";
			}
			return new global::NPOI.SS.Util.SimpleDateFormat(global::NPOI.OpenXml4Net.OPC.Internal.PackagePropertiesPart.DEFAULT_DATEFORMAT)
			{
				TimeZone = global::System.TimeZoneInfo.Utc
			}.Format(d.Value, global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x000083F4 File Offset: 0x000065F4
		protected override global::System.IO.Stream GetInputStreamImpl()
		{
			throw new global::System.InvalidOperationException("Operation not authorized");
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x000083F4 File Offset: 0x000065F4
		protected override global::System.IO.Stream GetOutputStreamImpl()
		{
			throw new global::System.InvalidOperationException("Operation not authorized");
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x000083F4 File Offset: 0x000065F4
		public override bool Save(global::System.IO.Stream zos)
		{
			throw new global::System.InvalidOperationException("Operation not authorized");
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x000083F4 File Offset: 0x000065F4
		public override bool Load(global::System.IO.Stream ios)
		{
			throw new global::System.InvalidOperationException("Operation not authorized");
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000478E File Offset: 0x0000298E
		public override void Close()
		{
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0000478E File Offset: 0x0000298E
		public override void Flush()
		{
		}

		// Token: 0x040000AB RID: 171
		public static string NAMESPACE_DC = "http://purl.org/dc/elements/1.1/";

		// Token: 0x040000AC RID: 172
		public static string NAMESPACE_DC_URI = "http://purl.org/dc/elements/1.1/";

		// Token: 0x040000AD RID: 173
		public static string NAMESPACE_CP_URI = "http://schemas.openxmlformats.org/package/2006/metadata/core-properties";

		// Token: 0x040000AE RID: 174
		public static string NAMESPACE_DCTERMS_URI = "http://purl.org/dc/terms/";

		// Token: 0x040000AF RID: 175
		public static string NAMESPACE_XSI_URI = "http://www.w3.org/2001/XMLSchema-instance";

		// Token: 0x040000B0 RID: 176
		private static string DEFAULT_DATEFORMAT = "yyyy-MM-dd'T'HH:mm:ss'Z'";

		// Token: 0x040000B1 RID: 177
		private static string[] DATE_FORMATS = new string[]
		{
			global::NPOI.OpenXml4Net.OPC.Internal.PackagePropertiesPart.DEFAULT_DATEFORMAT,
			"yyyy-MM-dd'T'HH:mm:ss.ff'Z'"
		};

		// Token: 0x040000B2 RID: 178
		private string[] TZ_DATE_FORMATS = new string[]
		{
			"yyyy-MM-dd'T'HH:mm:ssz",
			"yyyy-MM-dd'T'HH:mm:ss.fz",
			"yyyy-MM-dd'T'HH:mm:ss.ffz",
			"yyyy-MM-dd'T'HH:mm:ss.fffz"
		};

		// Token: 0x040000B3 RID: 179
		private global::System.Text.RegularExpressions.Regex TIME_ZONE_PAT = new global::System.Text.RegularExpressions.Regex("([-+]\\d\\d):?(\\d\\d)");

		// Token: 0x040000B4 RID: 180
		protected string category;

		// Token: 0x040000B5 RID: 181
		protected string contentStatus;

		// Token: 0x040000B6 RID: 182
		protected string contentType;

		// Token: 0x040000B7 RID: 183
		protected global::System.DateTime? created;

		// Token: 0x040000B8 RID: 184
		protected string creator;

		// Token: 0x040000B9 RID: 185
		protected string description;

		// Token: 0x040000BA RID: 186
		protected string identifier;

		// Token: 0x040000BB RID: 187
		protected string keywords;

		// Token: 0x040000BC RID: 188
		protected string language;

		// Token: 0x040000BD RID: 189
		protected string lastModifiedBy;

		// Token: 0x040000BE RID: 190
		protected global::System.DateTime? lastPrinted;

		// Token: 0x040000BF RID: 191
		protected global::System.DateTime? modified;

		// Token: 0x040000C0 RID: 192
		protected string revision;

		// Token: 0x040000C1 RID: 193
		protected string subject;

		// Token: 0x040000C2 RID: 194
		protected string title;

		// Token: 0x040000C3 RID: 195
		protected string version;
	}
}
