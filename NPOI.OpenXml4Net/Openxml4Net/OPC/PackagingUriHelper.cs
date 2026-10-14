using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using NPOI.OpenXml4Net.Exceptions;

namespace NPOI.OpenXml4Net.OPC
{
	// Token: 0x0200001A RID: 26
	public class PackagingUriHelper
	{
		// Token: 0x0600011F RID: 287 RVA: 0x00005B90 File Offset: 0x00003D90
		static PackagingUriHelper()
		{
			global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.RELATIONSHIP_PART_SEGMENT_NAME = "_rels";
			global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.RELATIONSHIP_PART_EXTENSION_NAME = ".rels";
			global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.FORWARD_SLASH_CHAR = '/';
			global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.FORWARD_SLASH_STRING = "/";
			global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.PACKAGE_PROPERTIES_SEGMENT_NAME = "docProps";
			global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.PACKAGE_CORE_PROPERTIES_NAME = "core.xml";
			global::System.Uri package_ROOT_URI = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.ParseUri("/", global::System.UriKind.Relative);
			global::System.Uri package_RELATIONSHIPS_ROOT_URI = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.ParseUri(global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.FORWARD_SLASH_CHAR.ToString() + global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.RELATIONSHIP_PART_SEGMENT_NAME + global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.FORWARD_SLASH_CHAR.ToString() + global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.RELATIONSHIP_PART_EXTENSION_NAME, global::System.UriKind.Relative);
			global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.packageRootUri = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.ParseUri("/", global::System.UriKind.Relative);
			global::System.Uri core_PROPERTIES_URI = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.ParseUri(global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.FORWARD_SLASH_CHAR.ToString() + global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.PACKAGE_PROPERTIES_SEGMENT_NAME + global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.FORWARD_SLASH_CHAR.ToString() + global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.PACKAGE_CORE_PROPERTIES_NAME, global::System.UriKind.Relative);
			global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.PACKAGE_ROOT_URI = package_ROOT_URI;
			global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.PACKAGE_RELATIONSHIPS_ROOT_URI = package_RELATIONSHIPS_ROOT_URI;
			global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.CORE_PROPERTIES_URI = core_PROPERTIES_URI;
			global::NPOI.OpenXml4Net.OPC.PackagePartName package_ROOT_PART_NAME = null;
			global::NPOI.OpenXml4Net.OPC.PackagePartName package_RELATIONSHIPS_ROOT_PART_NAME = null;
			global::NPOI.OpenXml4Net.OPC.PackagePartName core_PROPERTIES_PART_NAME = null;
			try
			{
				package_RELATIONSHIPS_ROOT_PART_NAME = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.CreatePartName(global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.PACKAGE_RELATIONSHIPS_ROOT_URI);
				core_PROPERTIES_PART_NAME = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.CreatePartName(global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.CORE_PROPERTIES_URI);
				package_ROOT_PART_NAME = new global::NPOI.OpenXml4Net.OPC.PackagePartName(global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.PACKAGE_ROOT_URI, false);
			}
			catch (global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException)
			{
			}
			global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.PACKAGE_RELATIONSHIPS_ROOT_PART_NAME = package_RELATIONSHIPS_ROOT_PART_NAME;
			global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.CORE_PROPERTIES_PART_NAME = core_PROPERTIES_PART_NAME;
			global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.PACKAGE_ROOT_PART_NAME = package_ROOT_PART_NAME;
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000120 RID: 288 RVA: 0x00005CE8 File Offset: 0x00003EE8
		public static global::System.Uri PackageRootUri
		{
			get
			{
				return global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.packageRootUri;
			}
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00005CEF File Offset: 0x00003EEF
		public static global::System.Uri ParseUri(string s, global::System.UriKind kind)
		{
			if (global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.IsMono)
			{
				if (kind == global::System.UriKind.Absolute)
				{
					throw new global::System.UriFormatException();
				}
				if (kind == global::System.UriKind.RelativeOrAbsolute && s.StartsWith("/"))
				{
					kind = global::System.UriKind.Relative;
				}
			}
			return new global::System.Uri(s, kind);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00005D1C File Offset: 0x00003F1C
		public static bool IsRelationshipPartURI(global::System.Uri partUri)
		{
			if (partUri == null)
			{
				throw new global::System.ArgumentException("partUri");
			}
			return global::System.Text.RegularExpressions.Regex.IsMatch(partUri.OriginalString, string.Concat(new string[]
			{
				".*",
				global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.RELATIONSHIP_PART_SEGMENT_NAME,
				".*",
				global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.RELATIONSHIP_PART_EXTENSION_NAME,
				"$"
			}));
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00005D7C File Offset: 0x00003F7C
		public static string GetFilename(global::System.Uri uri)
		{
			if (uri != null)
			{
				string originalString = uri.OriginalString;
				int num = originalString.Length;
				while (--num >= 0)
				{
					if (originalString[num] == global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.FORWARD_SLASH_CHAR)
					{
						return originalString.Substring(num + 1);
					}
				}
			}
			return "";
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00005DC8 File Offset: 0x00003FC8
		public static string GetFilenameWithoutExtension(global::System.Uri uri)
		{
			string filename = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.GetFilename(uri);
			int num = filename.LastIndexOf(".");
			if (num == -1)
			{
				return filename;
			}
			return filename.Substring(0, num);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00005DF8 File Offset: 0x00003FF8
		public static global::System.Uri GetPath(global::System.Uri uri)
		{
			if (uri != null)
			{
				string originalString = uri.OriginalString;
				int num = originalString.Length;
				while (--num >= 0)
				{
					if (originalString[num] == global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.FORWARD_SLASH_CHAR)
					{
						try
						{
							return global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.ParseUri(originalString.Substring(0, num), global::System.UriKind.Absolute);
						}
						catch (global::System.UriFormatException)
						{
							return null;
						}
						continue;
					}
				}
			}
			return null;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00005E60 File Offset: 0x00004060
		public static global::System.Uri Combine(global::System.Uri prefix, global::System.Uri suffix)
		{
			global::System.Uri result = null;
			try
			{
				result = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.ParseUri(global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.Combine(prefix.OriginalString, suffix.OriginalString), global::System.UriKind.Absolute);
			}
			catch (global::System.UriFormatException)
			{
				throw new global::System.ArgumentException("Prefix and suffix can't be Combine !");
			}
			return result;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00005EA8 File Offset: 0x000040A8
		public static string Combine(string prefix, string suffix)
		{
			if (!prefix.EndsWith(global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.FORWARD_SLASH_CHAR.ToString() ?? "") && !suffix.StartsWith(global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.FORWARD_SLASH_CHAR.ToString() ?? ""))
			{
				return prefix + global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.FORWARD_SLASH_CHAR.ToString() + suffix;
			}
			if ((!prefix.EndsWith(global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.FORWARD_SLASH_CHAR.ToString() ?? "") && suffix.StartsWith(global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.FORWARD_SLASH_CHAR.ToString() ?? "")) || (prefix.EndsWith(global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.FORWARD_SLASH_CHAR.ToString() ?? "") && !suffix.StartsWith(global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.FORWARD_SLASH_CHAR.ToString() ?? "")))
			{
				return prefix + suffix;
			}
			return "";
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00005F78 File Offset: 0x00004178
		public static global::System.Uri RelativizeUri(global::System.Uri sourceURI, global::System.Uri targetURI, bool msCompatible)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			string[] array = sourceURI.ToString().Split(new char[]
			{
				'/'
			});
			string[] array2 = targetURI.ToString().Split(new char[]
			{
				'/'
			});
			if (array.Length == 0)
			{
				throw new global::System.ArgumentException("Can't relativize an empty source Uri !");
			}
			if (array2.Length == 0)
			{
				throw new global::System.ArgumentException("Can't relativize an empty target Uri !");
			}
			if (sourceURI.ToString().Equals("/"))
			{
				string text = targetURI.ToString();
				if (msCompatible && text.Length > 0 && text[0] == '/')
				{
					try
					{
						targetURI = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.ParseUri(text.Substring(1), global::System.UriKind.RelativeOrAbsolute);
					}
					catch (global::System.Exception)
					{
						return null;
					}
				}
				return targetURI;
			}
			int num = 0;
			int num2 = 0;
			while (num2 < array.Length && num2 < array2.Length && array[num2].Equals(array2[num2]))
			{
				num++;
				num2++;
			}
			if ((num == 0 || num == 1) && array[0].Equals("") && array2[0].Equals(""))
			{
				for (int i = 0; i < array.Length - 2; i++)
				{
					stringBuilder.Append("../");
				}
				for (int j = 0; j < array2.Length; j++)
				{
					if (!array2[j].Equals(""))
					{
						stringBuilder.Append(array2[j]);
						if (j != array2.Length - 1)
						{
							stringBuilder.Append("/");
						}
					}
				}
				try
				{
					return global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.ParseUri(stringBuilder.ToString(), global::System.UriKind.RelativeOrAbsolute);
				}
				catch (global::System.Exception)
				{
					return null;
				}
			}
			if (num == array.Length && num == array2.Length)
			{
				if (sourceURI.Equals(targetURI))
				{
					stringBuilder.Append(array[array.Length - 1]);
				}
				else
				{
					stringBuilder.Append("");
				}
			}
			else
			{
				if (num == 1)
				{
					stringBuilder.Append("/");
				}
				else
				{
					for (int k = num; k < array.Length - 1; k++)
					{
						stringBuilder.Append("../");
					}
				}
				for (int l = num; l < array2.Length; l++)
				{
					if (stringBuilder.Length > 0 && stringBuilder[stringBuilder.Length - 1] != '/')
					{
						stringBuilder.Append("/");
					}
					stringBuilder.Append(array2[l]);
				}
			}
			global::System.Uri result;
			try
			{
				result = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.ParseUri(stringBuilder.ToString(), global::System.UriKind.RelativeOrAbsolute);
			}
			catch (global::System.Exception)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000129 RID: 297 RVA: 0x000061EC File Offset: 0x000043EC
		public static global::System.Uri RelativizeUri(global::System.Uri sourceURI, global::System.Uri targetURI)
		{
			return global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.RelativizeUri(sourceURI, targetURI, false);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x000061F8 File Offset: 0x000043F8
		public static global::System.Uri ResolvePartUri(global::System.Uri sourcePartUri, global::System.Uri targetUri)
		{
			if (sourcePartUri == null || sourcePartUri.IsAbsoluteUri)
			{
				throw new global::System.ArgumentException("sourcePartUri invalid - " + ((sourcePartUri != null) ? sourcePartUri.ToString() : null));
			}
			if (targetUri == null || targetUri.IsAbsoluteUri)
			{
				throw new global::System.ArgumentException("targetUri invalid - " + ((targetUri != null) ? targetUri.ToString() : null));
			}
			string text;
			if (sourcePartUri.OriginalString == "/")
			{
				text = "/";
			}
			else
			{
				text = global::System.IO.Path.GetDirectoryName(sourcePartUri.OriginalString).Replace("\\", "/");
			}
			string text2 = targetUri.OriginalString;
			if (text2.StartsWith("#"))
			{
				text = text + "/" + global::System.IO.Path.GetFileName(sourcePartUri.OriginalString) + text2;
			}
			else if (text2.StartsWith("../"))
			{
				string[] array = text.Split(new char[]
				{
					'/'
				});
				int num = array.Length - 1;
				while (text2.StartsWith("../"))
				{
					text2 = text2.Substring(3);
					num--;
				}
				text = "/";
				for (int i = 0; i <= num; i++)
				{
					if (array[i] != string.Empty)
					{
						text = text + array[i] + "/";
					}
				}
				text += text2;
			}
			else
			{
				text = global::System.IO.Path.Combine(text, targetUri.OriginalString).Replace("\\", "/");
			}
			return global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.ParseUri(text, global::System.UriKind.RelativeOrAbsolute);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0000636C File Offset: 0x0000456C
		public static global::System.Uri GetURIFromPath(string path)
		{
			global::System.Uri result = null;
			try
			{
				result = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.ParseUri(path, global::System.UriKind.RelativeOrAbsolute);
			}
			catch (global::System.UriFormatException)
			{
				throw new global::System.ArgumentException("path");
			}
			return result;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x000063A4 File Offset: 0x000045A4
		public static global::System.Uri GetSourcePartUriFromRelationshipPartUri(global::System.Uri relationshipPartUri)
		{
			if (relationshipPartUri == null)
			{
				throw new global::System.ArgumentException("Must not be null");
			}
			if (!global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.IsRelationshipPartURI(relationshipPartUri))
			{
				throw new global::System.ArgumentException("Must be a relationship part");
			}
			if (global::System.Uri.Compare(relationshipPartUri, global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.PACKAGE_RELATIONSHIPS_ROOT_URI, global::System.UriComponents.AbsoluteUri, global::System.UriFormat.SafeUnescaped, global::System.StringComparison.InvariantCultureIgnoreCase) == 0)
			{
				return global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.PACKAGE_ROOT_URI;
			}
			string text = relationshipPartUri.OriginalString;
			string filenameWithoutExtension = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.GetFilenameWithoutExtension(relationshipPartUri);
			text = text.Substring(0, text.Length - filenameWithoutExtension.Length - global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.RELATIONSHIP_PART_EXTENSION_NAME.Length);
			text = text.Substring(0, text.Length - global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.RELATIONSHIP_PART_SEGMENT_NAME.Length - 1);
			text = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.Combine(text, filenameWithoutExtension);
			return global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.GetURIFromPath(text);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00006446 File Offset: 0x00004646
		public static global::NPOI.OpenXml4Net.OPC.PackagePartName CreatePartName(global::System.Uri partUri)
		{
			if (partUri == null)
			{
				throw new global::System.ArgumentException("partName");
			}
			return new global::NPOI.OpenXml4Net.OPC.PackagePartName(partUri, true);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00006464 File Offset: 0x00004664
		public static global::NPOI.OpenXml4Net.OPC.PackagePartName CreatePartName(string partName)
		{
			global::System.Uri partUri;
			try
			{
				partName = partName.Replace("\\", "/");
				partUri = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.ParseUri(partName, global::System.UriKind.Relative);
			}
			catch (global::System.UriFormatException ex)
			{
				throw new global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException(ex.Message);
			}
			return global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.CreatePartName(partUri);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x000064B0 File Offset: 0x000046B0
		public static global::NPOI.OpenXml4Net.OPC.PackagePartName CreatePartName(string partName, global::NPOI.OpenXml4Net.OPC.PackagePart relativePart)
		{
			global::System.Uri partUri;
			try
			{
				partUri = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.ResolvePartUri(relativePart.PartName.URI, global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.ParseUri(partName, global::System.UriKind.RelativeOrAbsolute));
			}
			catch (global::System.UriFormatException ex)
			{
				throw new global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException(ex.Message);
			}
			return global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.CreatePartName(partUri);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x000064F8 File Offset: 0x000046F8
		public static global::NPOI.OpenXml4Net.OPC.PackagePartName CreatePartName(global::System.Uri partName, global::NPOI.OpenXml4Net.OPC.PackagePart relativePart)
		{
			return global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.CreatePartName(global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.ResolvePartUri(relativePart.PartName.URI, partName));
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00006510 File Offset: 0x00004710
		public static bool IsValidPartName(global::System.Uri partUri)
		{
			if (partUri == null)
			{
				throw new global::System.ArgumentException("partUri");
			}
			bool result;
			try
			{
				global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.CreatePartName(partUri);
				result = true;
			}
			catch (global::System.Exception)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00006554 File Offset: 0x00004754
		public static string DecodeURI(global::System.Uri uri)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			string originalString = uri.OriginalString;
			int length = originalString.Length;
			for (int i = 0; i < length; i++)
			{
				char c = originalString[i];
				if (c == '%')
				{
					if (length - i < 2)
					{
						throw new global::System.ArgumentException("The uri " + originalString + " contain invalid encoded character !");
					}
					char value = (char)global::System.Convert.ToInt32(originalString.Substring(i + 1, 2), 16);
					stringBuilder.Append(value);
					i += 2;
				}
				else
				{
					stringBuilder.Append(c);
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000133 RID: 307 RVA: 0x000065E4 File Offset: 0x000047E4
		public static global::System.Uri ToUri(string value)
		{
			if (value.IndexOf("\\") != -1)
			{
				value = value.Replace('\\', '/');
			}
			int num = value.IndexOf('#');
			if (num != -1)
			{
				string str = value.Substring(0, num);
				string s = value.Substring(num + 1);
				value = str + "#" + global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.Encode(s);
			}
			if (value.Length > 0)
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				int i;
				for (i = value.Length - 1; i >= 0; i--)
				{
					char c = value[i];
					if (!char.IsWhiteSpace(c) && c != '\u00a0')
					{
						break;
					}
					stringBuilder.Append(c);
				}
				if (stringBuilder.Length > 0)
				{
					char[] array = stringBuilder.ToString().ToCharArray();
					global::System.Array.Reverse(array);
					value = value.Substring(0, i + 1) + global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.Encode(new string(array));
				}
			}
			if (global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.missingAuthPattern.IsMatch(value))
			{
				value += "/";
			}
			return global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.ParseUri(value, global::System.UriKind.RelativeOrAbsolute);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x000066E0 File Offset: 0x000048E0
		public static string Encode(string s)
		{
			if (s.Length == 0)
			{
				return s;
			}
			byte[] bytes = global::System.Text.Encoding.UTF8.GetBytes(s);
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			byte[] array = bytes;
			for (int i = 0; i < array.Length; i++)
			{
				int num = (int)(array[i] & byte.MaxValue);
				if (global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.IsUnsafe(num))
				{
					stringBuilder.Append('%');
					stringBuilder.Append(global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.hexDigits[num >> 4 & 15]);
					stringBuilder.Append(global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.hexDigits[num & 15]);
				}
				else
				{
					stringBuilder.Append((char)num);
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00006767 File Offset: 0x00004967
		private static bool IsUnsafe(int ch)
		{
			return ch > 128 || char.IsWhiteSpace((char)ch);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x0000677C File Offset: 0x0000497C
		public static global::NPOI.OpenXml4Net.OPC.PackagePartName GetRelationshipPartName(global::NPOI.OpenXml4Net.OPC.PackagePartName partName)
		{
			if (partName == null)
			{
				throw new global::System.ArgumentException("partName");
			}
			if (global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.PACKAGE_ROOT_URI.OriginalString == partName.URI.OriginalString)
			{
				return global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.PACKAGE_RELATIONSHIPS_ROOT_PART_NAME;
			}
			if (partName.IsRelationshipPartURI())
			{
				throw new global::System.InvalidOperationException("Can't be a relationship part");
			}
			string text = partName.URI.OriginalString;
			string filename = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.GetFilename(partName.URI);
			text = text.Substring(0, text.Length - filename.Length);
			text = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.Combine(text, global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.RELATIONSHIP_PART_SEGMENT_NAME);
			text = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.Combine(text, filename);
			text += global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.RELATIONSHIP_PART_EXTENSION_NAME;
			global::NPOI.OpenXml4Net.OPC.PackagePartName result;
			try
			{
				result = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.CreatePartName(text);
			}
			catch (global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException)
			{
				return null;
			}
			return result;
		}

		// Token: 0x0400007D RID: 125
		private static global::System.Uri packageRootUri;

		// Token: 0x0400007E RID: 126
		public static string RELATIONSHIP_PART_EXTENSION_NAME;

		// Token: 0x0400007F RID: 127
		public static string RELATIONSHIP_PART_SEGMENT_NAME;

		// Token: 0x04000080 RID: 128
		public static string PACKAGE_PROPERTIES_SEGMENT_NAME;

		// Token: 0x04000081 RID: 129
		public static string PACKAGE_CORE_PROPERTIES_NAME;

		// Token: 0x04000082 RID: 130
		public static char FORWARD_SLASH_CHAR;

		// Token: 0x04000083 RID: 131
		public static string FORWARD_SLASH_STRING;

		// Token: 0x04000084 RID: 132
		public static global::System.Uri PACKAGE_RELATIONSHIPS_ROOT_URI;

		// Token: 0x04000085 RID: 133
		public static global::NPOI.OpenXml4Net.OPC.PackagePartName PACKAGE_RELATIONSHIPS_ROOT_PART_NAME;

		// Token: 0x04000086 RID: 134
		public static global::System.Uri CORE_PROPERTIES_URI;

		// Token: 0x04000087 RID: 135
		public static global::NPOI.OpenXml4Net.OPC.PackagePartName CORE_PROPERTIES_PART_NAME;

		// Token: 0x04000088 RID: 136
		public static global::System.Uri PACKAGE_ROOT_URI;

		// Token: 0x04000089 RID: 137
		public static global::NPOI.OpenXml4Net.OPC.PackagePartName PACKAGE_ROOT_PART_NAME;

		// Token: 0x0400008A RID: 138
		private static global::System.Text.RegularExpressions.Regex missingAuthPattern = new global::System.Text.RegularExpressions.Regex("\\w+://$", global::System.Text.RegularExpressions.RegexOptions.Compiled);

		// Token: 0x0400008B RID: 139
		private static readonly bool IsMono = global::System.Type.GetType("Mono.Runtime") != null;

		// Token: 0x0400008C RID: 140
		private static char[] hexDigits = new char[]
		{
			'0',
			'1',
			'2',
			'3',
			'4',
			'5',
			'6',
			'7',
			'8',
			'9',
			'A',
			'B',
			'C',
			'D',
			'E',
			'F'
		};
	}
}
