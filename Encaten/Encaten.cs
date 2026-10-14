using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Encaten
{
	// Token: 0x02000003 RID: 3
	public class Encaten : global::Encaten.IEncateWrapper
	{
		// Token: 0x06000004 RID: 4 RVA: 0x00002130 File Offset: 0x00000330
		public int openAndGetFilePackage(string upgradeFilePath, string cstrEncUuid, out string fileContent)
		{
			short num = (short)1866399744;
			short num2 = num;
			num = (short)317282600;
			short num3 = num;
			num = (short)1972787496;
			int result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1131675648;
				if (num != 0)
				{
				}
				num = (short)1800732673;
				if (num != 0)
				{
				}
				fileContent = string.Empty;
				try
				{
					byte[] upgradeFileBytes = global::System.IO.File.ReadAllBytes(upgradeFilePath);
					fileContent = this.openAndGetFilePackage(upgradeFileBytes, cstrEncUuid);
					result = 0;
				}
				catch (global::System.IO.FileNotFoundException)
				{
					goto IL_A4;
				}
				break;
				IL_A4:
				this.d = false;
				return -1;
			}
			return result;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002214 File Offset: 0x00000414
		public string openAndGetFilePackage(byte[] upgradeFileBytes, string cstrEncUuid)
		{
			short num = (short)960692224;
			short num2 = num;
			num = (short)878647210;
			short num3 = num;
			num = (short)1342117802;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)947519488;
				if (num != 0)
				{
				}
				if (global::Encaten.Encaten.a(upgradeFileBytes))
				{
					byte[] data = upgradeFileBytes.Skip(global::Encaten.Encaten.b).Skip(global::Encaten.Encaten.c.Length).ToArray<byte>();
					byte[] bytes = global::Encaten.CryptoHandler.Decrypt(cstrEncUuid, data);
					string @string = global::System.Text.Encoding.ASCII.GetString(bytes);
					this.d = true;
					return @string;
				}
				break;
			}
			num = (short)716439553;
			if (num != 0)
			{
			}
			this.d = false;
			return string.Empty;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000230C File Offset: 0x0000050C
		private static bool a(global::System.Collections.Generic.IEnumerable<byte> A_0)
		{
			short num = (short)256704512;
			short num2 = num;
			num = (short)698482689;
			if (num != 0)
			{
			}
			num = (short)1953207966;
			short num3 = num;
			num = (short)1285265054;
			switch (num3 == num)
			{
			}
			num = (short)900857856;
			if (num != 0)
			{
			}
			return A_0.Skip(global::Encaten.Encaten.b).Take(global::Encaten.Encaten.c.Length).SequenceEqual(global::Encaten.Encaten.c);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000023D8 File Offset: 0x000005D8
		public void getFilePackageEncryptionStatus(out bool encrypted)
		{
			short num = (short)1543634944;
			short num2 = num;
			num = (short)824401089;
			short num3 = num;
			num = (short)1251171521;
			switch (num3 == num)
			{
			}
			num = (short)552337409;
			if (num != 0)
			{
			}
			num = (short)475725824;
			if (num != 0)
			{
			}
			encrypted = this.d;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000248C File Offset: 0x0000068C
		public void extractCurrentFileToFile(string filePath)
		{
			short num = (short)1290076160;
			short num2 = num;
			num = (short)45111903;
			short num3 = num;
			num = (short)287136351;
			switch (num3 == num)
			{
			}
			num = (short)460390400;
			if (num != 0)
			{
			}
			num = (short)658636801;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002554 File Offset: 0x00000754
		// Note: this type is marked as 'beforefieldinit'.
		static Encaten()
		{
			int a_ = 11;
			short num = (short)77922304;
			short num2 = num;
			num = (short)1923291925;
			short num3 = num;
			num = (short)971578133;
			switch (num3 == num)
			{
			}
			num = (short)559874049;
			if (num != 0)
			{
			}
			num = (short)1381367808;
			if (num != 0)
			{
			}
			global::Encaten.Encaten.b = global::System.Text.Encoding.ASCII.GetBytes(global::Encaten.Rc4.b("ፏ㵑⑓⽕⩗㍙㭛㙝ᑟ䉡䱣ե䅧䩩幫幭䉯䉱味㭵᝷๹፻౽ꪅꢇ쎉뺏늑햓歹몙잟쪡킣향袧\ud8a9즫\uddad햯삱슳펵\udcb7钹", a_)).Length;
			global::Encaten.Encaten.c = new byte[]
			{
				1,
				10,
				11,
				11,
				25,
				10,
				15,
				22,
				69,
				3,
				10,
				70,
				16,
				48,
				45,
				76,
				77,
				45,
				54
			};
		}

		// Token: 0x04000003 RID: 3
		private const string a = "Copyright (c) 2020 Motorola, Inc. All rights reserved.";

		// Token: 0x04000004 RID: 4
		private static readonly int b;

		// Token: 0x04000005 RID: 5
		private static readonly byte[] c;

		// Token: 0x04000006 RID: 6
		private bool d;
	}
}
