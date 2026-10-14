using System;
using ICSharpCode.SharpZipLib.Core;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000030 RID: 48
	public class PathTransformer : global::ICSharpCode.SharpZipLib.Core.INameTransform
	{
		// Token: 0x060001ED RID: 493 RVA: 0x000097D7 File Offset: 0x000079D7
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

		// Token: 0x060001EE RID: 494 RVA: 0x00009814 File Offset: 0x00007A14
		public string TransformFile(string name)
		{
			if (name != null)
			{
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
			}
			else
			{
				name = string.Empty;
			}
			return name;
		}
	}
}
