using System;
using System.IO;
using System.Text;
using ICSharpCode.SharpZipLib.Core;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x0200000A RID: 10
	public class WindowsNameTransform : global::ICSharpCode.SharpZipLib.Core.INameTransform
	{
		// Token: 0x06000052 RID: 82 RVA: 0x00002EF2 File Offset: 0x000010F2
		public WindowsNameTransform(string baseDirectory, bool allowParentTraversal = false)
		{
			if (baseDirectory == null)
			{
				throw new global::System.ArgumentNullException("baseDirectory", "Directory name is invalid");
			}
			this.BaseDirectory = baseDirectory;
			this.AllowParentTraversal = allowParentTraversal;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002F24 File Offset: 0x00001124
		public WindowsNameTransform()
		{
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00002F34 File Offset: 0x00001134
		// (set) Token: 0x06000055 RID: 85 RVA: 0x00002F3C File Offset: 0x0000113C
		public string BaseDirectory
		{
			get
			{
				return this._baseDirectory;
			}
			set
			{
				if (value == null)
				{
					throw new global::System.ArgumentNullException("value");
				}
				this._baseDirectory = global::System.IO.Path.GetFullPath(value);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00002F58 File Offset: 0x00001158
		// (set) Token: 0x06000057 RID: 87 RVA: 0x00002F60 File Offset: 0x00001160
		public bool AllowParentTraversal
		{
			get
			{
				return this._allowParentTraversal;
			}
			set
			{
				this._allowParentTraversal = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00002F69 File Offset: 0x00001169
		// (set) Token: 0x06000059 RID: 89 RVA: 0x00002F71 File Offset: 0x00001171
		public bool TrimIncomingPaths
		{
			get
			{
				return this._trimIncomingPaths;
			}
			set
			{
				this._trimIncomingPaths = value;
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002F7C File Offset: 0x0000117C
		public string TransformDirectory(string name)
		{
			name = this.TransformFile(name);
			if (name.Length > 0)
			{
				while (name.EndsWith(global::System.IO.Path.DirectorySeparatorChar.ToString(), global::System.StringComparison.Ordinal))
				{
					name = name.Remove(name.Length - 1, 1);
				}
				return name;
			}
			throw new global::ICSharpCode.SharpZipLib.Core.InvalidNameException("Cannot have an empty directory name");
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002FD4 File Offset: 0x000011D4
		public string TransformFile(string name)
		{
			if (name != null)
			{
				name = global::ICSharpCode.SharpZipLib.Zip.WindowsNameTransform.MakeValidName(name, this._replacementChar);
				if (this._trimIncomingPaths)
				{
					name = global::System.IO.Path.GetFileName(name);
				}
				if (this._baseDirectory != null)
				{
					name = global::System.IO.Path.Combine(this._baseDirectory, name);
					string text = global::System.IO.Path.GetFullPath(this._baseDirectory);
					if (text[text.Length - 1] != global::System.IO.Path.DirectorySeparatorChar)
					{
						text += global::System.IO.Path.DirectorySeparatorChar.ToString();
					}
					if (!this._allowParentTraversal && !global::System.IO.Path.GetFullPath(name).StartsWith(text, global::System.StringComparison.InvariantCultureIgnoreCase))
					{
						throw new global::ICSharpCode.SharpZipLib.Core.InvalidNameException("Parent traversal in paths is not allowed");
					}
				}
			}
			else
			{
				name = string.Empty;
			}
			return name;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000307A File Offset: 0x0000127A
		public static bool IsValidName(string name)
		{
			return name != null && name.Length <= 260 && string.Compare(name, global::ICSharpCode.SharpZipLib.Zip.WindowsNameTransform.MakeValidName(name, '_'), global::System.StringComparison.Ordinal) == 0;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000030A0 File Offset: 0x000012A0
		public static string MakeValidName(string name, char replacement)
		{
			if (name == null)
			{
				throw new global::System.ArgumentNullException("name");
			}
			name = global::ICSharpCode.SharpZipLib.Core.PathUtils.DropPathRoot(name.Replace("/", global::System.IO.Path.DirectorySeparatorChar.ToString()));
			while (name.Length > 0)
			{
				if (name[0] != global::System.IO.Path.DirectorySeparatorChar)
				{
					break;
				}
				name = name.Remove(0, 1);
			}
			while (name.Length > 0 && name[name.Length - 1] == global::System.IO.Path.DirectorySeparatorChar)
			{
				name = name.Remove(name.Length - 1, 1);
			}
			int i;
			for (i = name.IndexOf(string.Format("{0}{0}", global::System.IO.Path.DirectorySeparatorChar), global::System.StringComparison.Ordinal); i >= 0; i = name.IndexOf(string.Format("{0}{0}", global::System.IO.Path.DirectorySeparatorChar), global::System.StringComparison.Ordinal))
			{
				name = name.Remove(i, 1);
			}
			i = name.IndexOfAny(global::ICSharpCode.SharpZipLib.Zip.WindowsNameTransform.InvalidEntryChars);
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
						i = name.IndexOfAny(global::ICSharpCode.SharpZipLib.Zip.WindowsNameTransform.InvalidEntryChars, i + 1);
					}
				}
				name = stringBuilder.ToString();
			}
			if (name.Length > 260)
			{
				throw new global::System.IO.PathTooLongException();
			}
			return name;
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600005E RID: 94 RVA: 0x000031D3 File Offset: 0x000013D3
		// (set) Token: 0x0600005F RID: 95 RVA: 0x000031DC File Offset: 0x000013DC
		public char Replacement
		{
			get
			{
				return this._replacementChar;
			}
			set
			{
				for (int i = 0; i < global::ICSharpCode.SharpZipLib.Zip.WindowsNameTransform.InvalidEntryChars.Length; i++)
				{
					if (global::ICSharpCode.SharpZipLib.Zip.WindowsNameTransform.InvalidEntryChars[i] == value)
					{
						throw new global::System.ArgumentException("invalid path character");
					}
				}
				if (value == global::System.IO.Path.DirectorySeparatorChar || value == global::System.IO.Path.AltDirectorySeparatorChar)
				{
					throw new global::System.ArgumentException("invalid replacement character");
				}
				this._replacementChar = value;
			}
		}

		// Token: 0x0400001E RID: 30
		private const int MaxPath = 260;

		// Token: 0x0400001F RID: 31
		private string _baseDirectory;

		// Token: 0x04000020 RID: 32
		private bool _trimIncomingPaths;

		// Token: 0x04000021 RID: 33
		private char _replacementChar = '_';

		// Token: 0x04000022 RID: 34
		private bool _allowParentTraversal;

		// Token: 0x04000023 RID: 35
		private static readonly char[] InvalidEntryChars = new char[]
		{
			'"',
			'<',
			'>',
			'|',
			'\0',
			'\u0001',
			'\u0002',
			'\u0003',
			'\u0004',
			'\u0005',
			'\u0006',
			'\a',
			'\b',
			'\t',
			'\n',
			'\v',
			'\f',
			'\r',
			'\u000e',
			'\u000f',
			'\u0010',
			'\u0011',
			'\u0012',
			'\u0013',
			'\u0014',
			'\u0015',
			'\u0016',
			'\u0017',
			'\u0018',
			'\u0019',
			'\u001a',
			'\u001b',
			'\u001c',
			'\u001d',
			'\u001e',
			'\u001f',
			'*',
			'?',
			':'
		};
	}
}
