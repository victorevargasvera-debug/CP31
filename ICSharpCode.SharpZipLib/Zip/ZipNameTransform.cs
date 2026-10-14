using System;
using System.IO;
using System.Text;
using ICSharpCode.SharpZipLib.Core;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x0200002F RID: 47
	public class ZipNameTransform : global::ICSharpCode.SharpZipLib.Core.INameTransform
	{
		// Token: 0x060001E2 RID: 482 RVA: 0x00009533 File Offset: 0x00007733
		public ZipNameTransform()
		{
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0000953B File Offset: 0x0000773B
		public ZipNameTransform(string trimPrefix)
		{
			this.TrimPrefix = trimPrefix;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0000954C File Offset: 0x0000774C
		static ZipNameTransform()
		{
			char[] invalidPathChars = global::System.IO.Path.GetInvalidPathChars();
			int num = invalidPathChars.Length + 2;
			global::ICSharpCode.SharpZipLib.Zip.ZipNameTransform.InvalidEntryCharsRelaxed = new char[num];
			global::System.Array.Copy(invalidPathChars, 0, global::ICSharpCode.SharpZipLib.Zip.ZipNameTransform.InvalidEntryCharsRelaxed, 0, invalidPathChars.Length);
			global::ICSharpCode.SharpZipLib.Zip.ZipNameTransform.InvalidEntryCharsRelaxed[num - 1] = '*';
			global::ICSharpCode.SharpZipLib.Zip.ZipNameTransform.InvalidEntryCharsRelaxed[num - 2] = '?';
			num = invalidPathChars.Length + 4;
			global::ICSharpCode.SharpZipLib.Zip.ZipNameTransform.InvalidEntryChars = new char[num];
			global::System.Array.Copy(invalidPathChars, 0, global::ICSharpCode.SharpZipLib.Zip.ZipNameTransform.InvalidEntryChars, 0, invalidPathChars.Length);
			global::ICSharpCode.SharpZipLib.Zip.ZipNameTransform.InvalidEntryChars[num - 1] = ':';
			global::ICSharpCode.SharpZipLib.Zip.ZipNameTransform.InvalidEntryChars[num - 2] = '\\';
			global::ICSharpCode.SharpZipLib.Zip.ZipNameTransform.InvalidEntryChars[num - 3] = '*';
			global::ICSharpCode.SharpZipLib.Zip.ZipNameTransform.InvalidEntryChars[num - 4] = '?';
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x000095E3 File Offset: 0x000077E3
		public string TransformDirectory(string name)
		{
			name = this.TransformFile(name);
			if (name.Length > 0)
			{
				if (!name.EndsWith("/", global::System.StringComparison.Ordinal))
				{
					name += "/";
				}
				return name;
			}
			throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Cannot have an empty directory name");
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00009620 File Offset: 0x00007820
		public string TransformFile(string name)
		{
			if (name != null)
			{
				string text = name.ToLower();
				if (this.trimPrefix_ != null && text.IndexOf(this.trimPrefix_, global::System.StringComparison.Ordinal) == 0)
				{
					name = name.Substring(this.trimPrefix_.Length);
				}
				name = name.Replace("\\", "/");
				name = global::ICSharpCode.SharpZipLib.Core.PathUtils.DropPathRoot(name);
				name = name.Trim(new char[]
				{
					'/'
				});
				for (int i = name.IndexOf("//", global::System.StringComparison.Ordinal); i >= 0; i = name.IndexOf("//", global::System.StringComparison.Ordinal))
				{
					name = name.Remove(i, 1);
				}
				name = global::ICSharpCode.SharpZipLib.Zip.ZipNameTransform.MakeValidName(name, '_');
			}
			else
			{
				name = string.Empty;
			}
			return name;
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x000096CF File Offset: 0x000078CF
		// (set) Token: 0x060001E8 RID: 488 RVA: 0x000096D7 File Offset: 0x000078D7
		public string TrimPrefix
		{
			get
			{
				return this.trimPrefix_;
			}
			set
			{
				this.trimPrefix_ = value;
				if (this.trimPrefix_ != null)
				{
					this.trimPrefix_ = this.trimPrefix_.ToLower();
				}
			}
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x000096FC File Offset: 0x000078FC
		private static string MakeValidName(string name, char replacement)
		{
			int i = name.IndexOfAny(global::ICSharpCode.SharpZipLib.Zip.ZipNameTransform.InvalidEntryChars);
			if (i >= 0)
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(name);
				while (i >= 0)
				{
					stringBuilder[i] = replacement;
					if (i >= name.Length)
					{
						i = -1;
					}
					else
					{
						i = name.IndexOfAny(global::ICSharpCode.SharpZipLib.Zip.ZipNameTransform.InvalidEntryChars, i + 1);
					}
				}
				name = stringBuilder.ToString();
			}
			if (name.Length > 65535)
			{
				throw new global::System.IO.PathTooLongException();
			}
			return name;
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00009768 File Offset: 0x00007968
		public static bool IsValidName(string name, bool relaxed)
		{
			bool flag = name != null;
			if (flag)
			{
				if (relaxed)
				{
					flag = (name.IndexOfAny(global::ICSharpCode.SharpZipLib.Zip.ZipNameTransform.InvalidEntryCharsRelaxed) < 0);
				}
				else
				{
					flag = (name.IndexOfAny(global::ICSharpCode.SharpZipLib.Zip.ZipNameTransform.InvalidEntryChars) < 0 && name.IndexOf('/') != 0);
				}
			}
			return flag;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x000097AF File Offset: 0x000079AF
		public static bool IsValidName(string name)
		{
			return name != null && name.IndexOfAny(global::ICSharpCode.SharpZipLib.Zip.ZipNameTransform.InvalidEntryChars) < 0 && name.IndexOf('/') != 0;
		}

		// Token: 0x040000F8 RID: 248
		private string trimPrefix_;

		// Token: 0x040000F9 RID: 249
		private static readonly char[] InvalidEntryChars;

		// Token: 0x040000FA RID: 250
		private static readonly char[] InvalidEntryCharsRelaxed;
	}
}
