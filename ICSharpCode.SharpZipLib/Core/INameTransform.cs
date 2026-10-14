using System;

namespace ICSharpCode.SharpZipLib.Core
{
	// Token: 0x02000067 RID: 103
	public interface INameTransform
	{
		// Token: 0x06000466 RID: 1126
		string TransformFile(string name);

		// Token: 0x06000467 RID: 1127
		string TransformDirectory(string name);
	}
}
