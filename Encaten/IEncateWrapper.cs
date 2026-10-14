using System;

namespace Encaten
{
	// Token: 0x02000007 RID: 7
	public interface IEncateWrapper
	{
		// Token: 0x0600000E RID: 14
		void extractCurrentFileToFile(string filePath);

		// Token: 0x0600000F RID: 15
		int openAndGetFilePackage(string upgradeFilePath, string cstrEncUUID, out string fileContent);

		// Token: 0x06000010 RID: 16
		string openAndGetFilePackage(byte[] upgradeFileBytes, string cstrEncUUID);

		// Token: 0x06000011 RID: 17
		void getFilePackageEncryptionStatus(out bool encrypted);
	}
}
