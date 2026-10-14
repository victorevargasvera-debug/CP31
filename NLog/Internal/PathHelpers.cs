using System;
using System.IO;

namespace NLog.Internal
{
	// Token: 0x02000114 RID: 276
	internal static class PathHelpers
	{
		// Token: 0x06000D38 RID: 3384 RVA: 0x00020B2C File Offset: 0x0001ED2C
		internal static string CombinePaths(string path, string dir, string file)
		{
			if (dir != null)
			{
				path = global::System.IO.Path.Combine(path, dir);
			}
			if (file != null)
			{
				path = global::System.IO.Path.Combine(path, file);
			}
			return path;
		}
	}
}
