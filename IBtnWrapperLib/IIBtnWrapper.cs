using System;

namespace IBtnWrapperLib
{
	// Token: 0x02000012 RID: 18
	public interface IIBtnWrapper
	{
		// Token: 0x06000063 RID: 99
		void OpenButton(int options);

		// Token: 0x06000064 RID: 100
		void OpenNonMotoBtn(int options);

		// Token: 0x06000065 RID: 101
		void CloseButton();

		// Token: 0x06000066 RID: 102
		void CreateFile(string fileName, out short pMaxBytes);

		// Token: 0x06000067 RID: 103
		void DeleteFile(string fileName);

		// Token: 0x06000068 RID: 104
		bool DoesFileExist(string fileName);

		// Token: 0x06000069 RID: 105
		byte[] GetROMSerialNum();

		// Token: 0x0600006A RID: 106
		string GetROMSerialNumString();

		// Token: 0x0600006B RID: 107
		void GetFileSize(string fileName, ref short pFileSz);

		// Token: 0x0600006C RID: 108
		void GetMaxFileSpace(string fileName, out short pMaxBytes);

		// Token: 0x0600006D RID: 109
		void ReadFile(string fileName, ref short pNumBytes, out byte[] pFileData);

		// Token: 0x0600006E RID: 110
		void WriteFile(string fileName, short numDataBytes, byte[] pFileData);

		// Token: 0x0600006F RID: 111
		void GetNumDaysLeft(ref short pDaysLeft);

		// Token: 0x06000070 RID: 112
		void ReadFileAtPage(string fileName, ref short pNumBytes, ref short nStartPage, out byte[] pFileData);

		// Token: 0x06000071 RID: 113
		void ReadMemoryData(byte addrLSB, byte addrMSB, short numBytesRequested, byte[] data);

		// Token: 0x06000072 RID: 114
		int GetWCC(uint pageNo);
	}
}
