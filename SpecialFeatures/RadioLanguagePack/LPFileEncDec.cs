using System;
using System.IO;
using System.Xml;
using AcpCryptoLib;
using AcpFileHandlerLib;

namespace SpecialFeatures.RadioLanguagePack
{
	// Token: 0x020000BE RID: 190
	public static class LPFileEncDec
	{
		// Token: 0x06000C32 RID: 3122 RVA: 0x000FD120 File Offset: 0x000FB320
		internal static void Encrypt(byte[] dataRaw, string outEncFile)
		{
			short num = (short)873839226;
			short num2 = num;
			num = (short)696171130;
			switch (num2 == num)
			{
			default:
			{
				num = (short)624164864;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1669595137;
			if (num != 0)
			{
			}
			num = (short)1714880512;
			if (num != 0)
			{
			}
			new global::AcpFileHandlerLib.AcpFileHandler().WriteFile(dataRaw, null, outEncFile, true, global::System.IO.FileMode.Create);
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x000FD1D8 File Offset: 0x000FB3D8
		internal static void Decrypt(out byte[] dataRaw, string inEncFile)
		{
			short num = (short)1022423152;
			short num2 = num;
			num = (short)1990324336;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1860960256;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1610219520;
			if (num != 0)
			{
			}
			num = (short)184025089;
			if (num != 0)
			{
			}
			new global::AcpFileHandlerLib.AcpFileHandler().ReadFile(out dataRaw, inEncFile, true);
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x000FD290 File Offset: 0x000FB490
		internal static void EncryptTxt(string dataStr, string outEncFile)
		{
			short num = (short)23944909;
			short num2 = num;
			num = (short)600334029;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1696661504;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1348468737;
			if (num != 0)
			{
			}
			num = (short)37945344;
			if (num != 0)
			{
			}
			global::AcpFileHandlerLib.AcpFileHandler acpFileHandler = new global::AcpFileHandlerLib.AcpFileHandler();
			byte[] writeBuffer = acpFileHandler.EncodeStringToByteArray(dataStr);
			acpFileHandler.WriteFile(writeBuffer, null, outEncFile, true, global::System.IO.FileMode.Create);
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x000FD350 File Offset: 0x000FB550
		internal static void DecryptTxt(out string dataStr, string inEncFile)
		{
			short num = (short)1350970028;
			short num2 = num;
			num = (short)2047224492;
			switch (num2 == num)
			{
			default:
			{
				num = (short)614858752;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)45350913;
			if (num != 0)
			{
			}
			num = (short)1373962240;
			if (num != 0)
			{
			}
			global::AcpFileHandlerLib.AcpFileHandler acpFileHandler = new global::AcpFileHandlerLib.AcpFileHandler();
			byte[] bytes;
			acpFileHandler.ReadFile(out bytes, inEncFile, true);
			dataStr = acpFileHandler.DecodeByteArrayToString(bytes);
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x000FD418 File Offset: 0x000FB618
		internal static global::System.Xml.XmlDocument Decrypt(string inEncXmlFile)
		{
			short num = (short)533395507;
			short num2 = num;
			num = (short)1243412531;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1982922752;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1645871104;
			if (num != 0)
			{
			}
			num = (short)1792475137;
			if (num != 0)
			{
			}
			return new global::AcpCryptoLib.AcpXMLEncryptDecrypt().DecryptXMLFile(inEncXmlFile);
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x000FD4D0 File Offset: 0x000FB6D0
		internal static global::System.Xml.XmlDocument Decrypt(global::System.IO.Stream inEncXmlStream)
		{
			short num = (short)2001418181;
			short num2 = num;
			num = (short)529938373;
			switch (num2 == num)
			{
			default:
			{
				num = (short)992542720;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)946667521;
			if (num != 0)
			{
			}
			num = (short)867696640;
			if (num != 0)
			{
			}
			return new global::AcpCryptoLib.AcpXMLEncryptDecrypt().DecryptXMLFile(inEncXmlStream);
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x000FD584 File Offset: 0x000FB784
		internal static void Encrypt(global::System.Xml.XmlDocument xmlDoc, string outEncXmlFile)
		{
			short num = (short)2114446931;
			short num2 = num;
			num = (short)2007033427;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1550057472;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1892941825;
			if (num != 0)
			{
			}
			num = (short)664338432;
			if (num != 0)
			{
			}
			new global::AcpCryptoLib.AcpXMLEncryptDecrypt().EncryptXMLDoc(xmlDoc, outEncXmlFile);
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x000FD63C File Offset: 0x000FB83C
		internal static void Encrypt(string inXmlFile, string outEncXmlFile)
		{
			short num = (short)523713997;
			short num2 = num;
			num = (short)1001274829;
			switch (num2 == num)
			{
			default:
			{
				num = (short)852623360;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1338638337;
			if (num != 0)
			{
			}
			num = (short)225116160;
			if (num != 0)
			{
			}
			new global::AcpCryptoLib.AcpXMLEncryptDecrypt().EncryptXMLFile(inXmlFile, outEncXmlFile);
		}
	}
}
