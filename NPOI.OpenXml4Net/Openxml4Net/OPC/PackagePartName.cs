using System;
using System.Text.RegularExpressions;
using NPOI.OpenXml4Net.Exceptions;

namespace NPOI.OpenXml4Net.OPC
{
	// Token: 0x02000015 RID: 21
	public class PackagePartName : global::System.IComparable<global::NPOI.OpenXml4Net.OPC.PackagePartName>
	{
		// Token: 0x060000C0 RID: 192 RVA: 0x00004870 File Offset: 0x00002A70
		public PackagePartName(global::System.Uri uri, bool checkConformance)
		{
			if (checkConformance)
			{
				global::NPOI.OpenXml4Net.OPC.PackagePartName.ThrowExceptionIfInvalidPartUri(uri);
			}
			else if (!global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.PACKAGE_ROOT_URI.Equals(uri))
			{
				throw new global::NPOI.OpenXml4Net.OpenXml4NetException("OCP conformance must be check for ALL part name except special cases : ['/']");
			}
			this.partNameURI = uri;
			this.isRelationship = this.IsRelationshipPartURI(this.partNameURI);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000048C0 File Offset: 0x00002AC0
		internal PackagePartName(string partName, bool checkConformance)
		{
			global::System.Uri uri;
			try
			{
				uri = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.ParseUri(partName, global::System.UriKind.RelativeOrAbsolute);
			}
			catch (global::System.UriFormatException)
			{
				throw new global::System.ArgumentException("partName argmument is not a valid OPC part name !");
			}
			if (checkConformance)
			{
				global::NPOI.OpenXml4Net.OPC.PackagePartName.ThrowExceptionIfInvalidPartUri(uri);
			}
			else if (!global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.PACKAGE_ROOT_URI.Equals(uri))
			{
				throw new global::NPOI.OpenXml4Net.OpenXml4NetException("OCP conformance must be check for ALL part name except special cases : ['/']");
			}
			this.partNameURI = uri;
			this.isRelationship = this.IsRelationshipPartURI(this.partNameURI);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00004938 File Offset: 0x00002B38
		private bool IsRelationshipPartURI(global::System.Uri partUri)
		{
			if (partUri == null)
			{
				throw new global::System.ArgumentException("partUri");
			}
			return global::System.Text.RegularExpressions.Regex.IsMatch(partUri.OriginalString, string.Concat(new string[]
			{
				"^.*/",
				global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.RELATIONSHIP_PART_SEGMENT_NAME,
				"/.*\\",
				global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.RELATIONSHIP_PART_EXTENSION_NAME,
				"$"
			}));
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00004997 File Offset: 0x00002B97
		public bool IsRelationshipPartURI()
		{
			return this.isRelationship;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000499F File Offset: 0x00002B9F
		private static void ThrowExceptionIfInvalidPartUri(global::System.Uri partUri)
		{
			if (partUri == null)
			{
				throw new global::System.ArgumentException("partUri");
			}
			global::NPOI.OpenXml4Net.OPC.PackagePartName.ThrowExceptionIfEmptyURI(partUri);
			global::NPOI.OpenXml4Net.OPC.PackagePartName.ThrowExceptionIfAbsoluteUri(partUri);
			global::NPOI.OpenXml4Net.OPC.PackagePartName.ThrowExceptionIfPartNameNotStartsWithForwardSlashChar(partUri);
			global::NPOI.OpenXml4Net.OPC.PackagePartName.ThrowExceptionIfPartNameEndsWithForwardSlashChar(partUri);
			global::NPOI.OpenXml4Net.OPC.PackagePartName.ThrowExceptionIfPartNameHaveInvalidSegments(partUri);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000049D4 File Offset: 0x00002BD4
		private static void ThrowExceptionIfEmptyURI(global::System.Uri partURI)
		{
			if (partURI == null)
			{
				throw new global::System.ArgumentException("partURI");
			}
			string originalString = partURI.OriginalString;
			if (originalString.Length == 0 || (originalString.Length == 1 && originalString[0] == global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.FORWARD_SLASH_CHAR))
			{
				throw new global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException("A part name shall not be empty [M1.1]: " + partURI.OriginalString);
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00004A34 File Offset: 0x00002C34
		private static void ThrowExceptionIfPartNameHaveInvalidSegments(global::System.Uri partUri)
		{
			if (partUri == null || "".Equals(partUri))
			{
				throw new global::System.ArgumentException("partUri");
			}
			string[] array = partUri.OriginalString.Split(new char[]
			{
				'/'
			});
			if (array.Length <= 1 || !array[0].Equals(""))
			{
				throw new global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException("A part name shall not have empty segments [M1.3]: " + partUri.OriginalString);
			}
			for (int i = 1; i < array.Length; i++)
			{
				string text = array[i];
				if (text == null || "".Equals(text))
				{
					throw new global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException("A part name shall not have empty segments [M1.3]: " + partUri.OriginalString);
				}
				if (text.EndsWith("."))
				{
					throw new global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException("A segment shall not end with a dot ('.') character [M1.9]: " + partUri.OriginalString);
				}
				if ("".Equals(text.Replace("\\\\.", "")))
				{
					throw new global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException("A segment shall include at least one non-dot character. [M1.10]: " + partUri.OriginalString);
				}
				global::NPOI.OpenXml4Net.OPC.PackagePartName.CheckPCharCompliance(text);
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00004B40 File Offset: 0x00002D40
		private static void CheckPCharCompliance(string segment)
		{
			int length = segment.Length;
			for (int i = 0; i < length; i++)
			{
				char c = segment[i];
				bool flag = true;
				if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || (c >= '0' && c <= '9'))
				{
					flag = false;
				}
				else
				{
					for (int j = 0; j < global::NPOI.OpenXml4Net.OPC.PackagePartName.RFC3986_PCHAR_UNRESERVED_SUP.Length; j++)
					{
						if (c == global::NPOI.OpenXml4Net.OPC.PackagePartName.RFC3986_PCHAR_UNRESERVED_SUP[j][0])
						{
							flag = false;
							break;
						}
					}
					int num = 0;
					while (flag && num < global::NPOI.OpenXml4Net.OPC.PackagePartName.RFC3986_PCHAR_AUTHORIZED_SUP.Length)
					{
						if (c == global::NPOI.OpenXml4Net.OPC.PackagePartName.RFC3986_PCHAR_AUTHORIZED_SUP[num][0])
						{
							flag = false;
						}
						num++;
					}
					int num2 = 0;
					while (flag && num2 < global::NPOI.OpenXml4Net.OPC.PackagePartName.RFC3986_PCHAR_SUB_DELIMS.Length)
					{
						if (c == global::NPOI.OpenXml4Net.OPC.PackagePartName.RFC3986_PCHAR_SUB_DELIMS[num2][0])
						{
							flag = false;
						}
						num2++;
					}
				}
				if (flag && c == '%')
				{
					if (length - i < 2)
					{
						throw new global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException("The segment " + segment + " contain invalid encoded character !");
					}
					flag = false;
					char c2 = (char)global::System.Convert.ToInt32(segment.Substring(i + 1, 2), 16);
					i += 2;
					if (c2 == '/' || c2 == '\\')
					{
						throw new global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException("A segment shall not contain percent-encoded forward slash ('/'), or backward slash ('') characters. [M1.7]");
					}
					if ((c2 >= 'A' && c2 <= 'Z') || (c2 >= 'a' && c2 <= 'z') || (c2 >= '0' && c2 <= '9'))
					{
						flag = true;
					}
					int num3 = 0;
					while (!flag && num3 < global::NPOI.OpenXml4Net.OPC.PackagePartName.RFC3986_PCHAR_UNRESERVED_SUP.Length)
					{
						if (c == global::NPOI.OpenXml4Net.OPC.PackagePartName.RFC3986_PCHAR_UNRESERVED_SUP[num3][0])
						{
							flag = true;
							break;
						}
						num3++;
					}
					if (flag)
					{
						throw new global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException("A segment shall not contain percent-encoded unreserved characters. [M1.8]");
					}
				}
				if (flag)
				{
					throw new global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException("A segment shall not hold any characters other than pchar characters. [M1.6]");
				}
			}
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00004CE4 File Offset: 0x00002EE4
		private static void ThrowExceptionIfPartNameNotStartsWithForwardSlashChar(global::System.Uri partUri)
		{
			string originalString = partUri.OriginalString;
			if (originalString.Length > 0 && originalString[0] != global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.FORWARD_SLASH_CHAR)
			{
				throw new global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException("A part name shall start with a forward slash ('/') character [M1.4]: " + partUri.OriginalString);
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00004D28 File Offset: 0x00002F28
		private static void ThrowExceptionIfPartNameEndsWithForwardSlashChar(global::System.Uri partUri)
		{
			string originalString = partUri.OriginalString;
			if (originalString.Length > 0 && originalString[originalString.Length - 1] == global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.FORWARD_SLASH_CHAR)
			{
				throw new global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException("A part name shall not have a forward slash as the last character [M1.5]: " + partUri.OriginalString);
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00004D70 File Offset: 0x00002F70
		private static void ThrowExceptionIfAbsoluteUri(global::System.Uri partUri)
		{
			if (partUri.IsAbsoluteUri)
			{
				throw new global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException("Absolute URI forbidden: " + ((partUri != null) ? partUri.ToString() : null));
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00004D97 File Offset: 0x00002F97
		public int CompareTo(global::NPOI.OpenXml4Net.OPC.PackagePartName other)
		{
			return global::NPOI.OpenXml4Net.OPC.PackagePartName.Compare(this, other);
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00004DA0 File Offset: 0x00002FA0
		public string Extension
		{
			get
			{
				string originalString = this.partNameURI.OriginalString;
				if (originalString.Length > 0)
				{
					int num = originalString.LastIndexOf(".");
					if (num > -1)
					{
						return originalString.Substring(num + 1);
					}
				}
				return "";
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00004DE1 File Offset: 0x00002FE1
		public string Name
		{
			get
			{
				return this.partNameURI.OriginalString;
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00004DEE File Offset: 0x00002FEE
		public override bool Equals(object other)
		{
			return other is global::NPOI.OpenXml4Net.OPC.PackagePartName && this.partNameURI.OriginalString.ToLower().Equals(((global::NPOI.OpenXml4Net.OPC.PackagePartName)other).partNameURI.OriginalString.ToLower());
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00004E24 File Offset: 0x00003024
		public override int GetHashCode()
		{
			return this.partNameURI.OriginalString.ToLower().GetHashCode();
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00004E3B File Offset: 0x0000303B
		public override string ToString()
		{
			return this.Name;
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00004E43 File Offset: 0x00003043
		public global::System.Uri URI
		{
			get
			{
				return this.partNameURI;
			}
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00004E4B File Offset: 0x0000304B
		public static int Compare(global::NPOI.OpenXml4Net.OPC.PackagePartName obj1, global::NPOI.OpenXml4Net.OPC.PackagePartName obj2)
		{
			if (obj1 == null)
			{
				if (obj2 != null)
				{
					return -1;
				}
				return 0;
			}
			else
			{
				if (obj2 == null)
				{
					return 1;
				}
				return global::NPOI.OpenXml4Net.OPC.PackagePartName.Compare(obj1.URI.OriginalString.ToLower(), obj2.URI.OriginalString.ToLower());
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00004E84 File Offset: 0x00003084
		public static int Compare(string str1, string str2)
		{
			if (str1 == null)
			{
				if (str2 != null)
				{
					return -1;
				}
				return 0;
			}
			else
			{
				if (str2 == null)
				{
					return 1;
				}
				int length = str1.Length;
				int length2 = str2.Length;
				int num = 0;
				int num2 = 0;
				while (num < length && num2 < length2)
				{
					char c = str1[num++];
					char c2 = str2[num2++];
					if (char.IsDigit(c) && char.IsDigit(c2))
					{
						int num3 = num - 1;
						while (num < length && char.IsDigit(str1[num]))
						{
							num++;
						}
						int num4 = num2 - 1;
						while (num2 < length2 && char.IsDigit(str2[num2]))
						{
							num2++;
						}
						int num5 = decimal.Parse(str1.Substring(num3, num - num3)).CompareTo(decimal.Parse(str2.Substring(num4, num2 - num4)));
						if (num5 != 0)
						{
							return num5;
						}
					}
					else if (c != c2)
					{
						return (int)(c - c2);
					}
				}
				return length - length2;
			}
		}

		// Token: 0x04000051 RID: 81
		private global::System.Uri partNameURI;

		// Token: 0x04000052 RID: 82
		private static string[] RFC3986_PCHAR_SUB_DELIMS = new string[]
		{
			"!",
			"$",
			"&",
			"'",
			"(",
			")",
			"*",
			"+",
			",",
			";",
			"="
		};

		// Token: 0x04000053 RID: 83
		private static string[] RFC3986_PCHAR_UNRESERVED_SUP = new string[]
		{
			"-",
			".",
			"_",
			"~"
		};

		// Token: 0x04000054 RID: 84
		private static string[] RFC3986_PCHAR_AUTHORIZED_SUP = new string[]
		{
			":",
			"@"
		};

		// Token: 0x04000055 RID: 85
		private bool isRelationship;
	}
}
