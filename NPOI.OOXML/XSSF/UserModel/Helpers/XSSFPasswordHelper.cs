using System;
using System.Globalization;
using System.Xml;
using System.Xml.XPath;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.POIFS.Crypt;
using NPOI.Util;
using Org.BouncyCastle.Security;

namespace NPOI.XSSF.UserModel.Helpers
{
	// Token: 0x020000AD RID: 173
	public class XSSFPasswordHelper
	{
		// Token: 0x06000B16 RID: 2838 RVA: 0x00002FA4 File Offset: 0x000011A4
		private XSSFPasswordHelper()
		{
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x00029AA0 File Offset: 0x00027CA0
		public static void SetPassword(global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetProtection xobj, string password, global::NPOI.POIFS.Crypt.HashAlgorithm hashAlgo, string prefix)
		{
			if (password == null)
			{
				xobj.password = null;
				xobj.algorithmName = null;
				xobj.hashValue = null;
				xobj.saltValue = null;
				xobj.spinCount = null;
				return;
			}
			if (hashAlgo == null)
			{
				int num = global::NPOI.POIFS.Crypt.CryptoFunctions.CreateXorVerifier1(password);
				xobj.password = string.Format("{0:X4}", num).ToUpper();
				return;
			}
			byte[] array = new global::Org.BouncyCastle.Security.SecureRandom().GenerateSeed(16);
			int spinCount = 100000;
			byte[] inArray = global::NPOI.POIFS.Crypt.CryptoFunctions.HashPassword(password, hashAlgo, array, spinCount, false);
			xobj.algorithmName = hashAlgo.jceId;
			xobj.hashValue = global::System.Convert.ToBase64String(inArray);
			xobj.saltValue = global::System.Convert.ToBase64String(array);
			xobj.spinCount = (spinCount.ToString() ?? "");
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x00029B54 File Offset: 0x00027D54
		public static void SetPassword(global::System.Xml.XmlNode xobj, string password, global::NPOI.POIFS.Crypt.HashAlgorithm hashAlgo, string prefix)
		{
			global::System.Xml.XPath.XPathNavigator xpathNavigator = xobj.CreateNavigator();
			if (password == null)
			{
				if (xpathNavigator.MoveToAttribute("password", prefix))
				{
					xpathNavigator.DeleteSelf();
				}
				if (xpathNavigator.MoveToAttribute("algorithmName", prefix))
				{
					xpathNavigator.DeleteSelf();
				}
				if (xpathNavigator.MoveToAttribute("hashValue", prefix))
				{
					xpathNavigator.DeleteSelf();
				}
				if (xpathNavigator.MoveToAttribute("saltValue", prefix))
				{
					xpathNavigator.DeleteSelf();
				}
				if (xpathNavigator.MoveToAttribute("spinCount", prefix))
				{
					xpathNavigator.DeleteSelf();
				}
				return;
			}
			if (hashAlgo == null)
			{
				int num = global::NPOI.POIFS.Crypt.CryptoFunctions.CreateXorVerifier1(password);
				xpathNavigator.CreateAttribute(prefix, "password", null, string.Format("{0:X4}", num).ToUpper());
				return;
			}
			byte[] array = new global::Org.BouncyCastle.Security.SecureRandom().GenerateSeed(16);
			int spinCount = 100000;
			byte[] inArray = global::NPOI.POIFS.Crypt.CryptoFunctions.HashPassword(password, hashAlgo, array, spinCount, false);
			xpathNavigator.CreateAttribute(prefix, "algorithmName", null, hashAlgo.jceId);
			xpathNavigator.CreateAttribute(prefix, "hashValue", null, global::System.Convert.ToBase64String(inArray));
			xpathNavigator.CreateAttribute(prefix, "saltValue", null, global::System.Convert.ToBase64String(array));
			xpathNavigator.CreateAttribute(prefix, "spinCount", null, spinCount.ToString() ?? "");
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x00029C74 File Offset: 0x00027E74
		public static bool ValidatePassword(global::NPOI.OpenXmlFormats.Spreadsheet.CT_SheetProtection xobj, string password, string prefix)
		{
			if (password == null)
			{
				return false;
			}
			string password2 = xobj.password;
			string algorithmName = xobj.algorithmName;
			string hashValue = xobj.hashValue;
			string saltValue = xobj.saltValue;
			string spinCount = xobj.spinCount;
			if (password2 != null)
			{
				int num = int.Parse(password2, global::System.Globalization.NumberStyles.HexNumber);
				int num2 = global::NPOI.POIFS.Crypt.CryptoFunctions.CreateXorVerifier1(password);
				return num == num2;
			}
			if (hashValue == null || algorithmName == null || saltValue == null || spinCount == null)
			{
				return false;
			}
			object a = global::System.Convert.FromBase64String(hashValue);
			global::NPOI.POIFS.Crypt.HashAlgorithm hashAlgorithm = global::NPOI.POIFS.Crypt.HashAlgorithm.FromString(algorithmName);
			byte[] salt = global::System.Convert.FromBase64String(saltValue);
			int spinCount2 = int.Parse(spinCount);
			byte[] b = global::NPOI.POIFS.Crypt.CryptoFunctions.HashPassword(password, hashAlgorithm, salt, spinCount2, false);
			return global::NPOI.Util.Arrays.Equals(a, b);
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x00029D0C File Offset: 0x00027F0C
		public static bool ValidatePassword(global::System.Xml.XmlNode xobj, string password, string prefix)
		{
			if (password == null)
			{
				return false;
			}
			global::System.Xml.XPath.XPathNavigator xpathNavigator = xobj.CreateNavigator();
			xpathNavigator.MoveToAttribute("password", prefix);
			string value = xpathNavigator.Value;
			xpathNavigator.MoveToAttribute("algorithmName", prefix);
			string value2 = xpathNavigator.Value;
			xpathNavigator.MoveToAttribute("hashValue", prefix);
			string value3 = xpathNavigator.Value;
			xpathNavigator.MoveToAttribute("saltValue", prefix);
			string value4 = xpathNavigator.Value;
			xpathNavigator.MoveToAttribute("spinCount", prefix);
			string value5 = xpathNavigator.Value;
			if (value != null)
			{
				int num = int.Parse(value, global::System.Globalization.NumberStyles.HexNumber);
				int num2 = global::NPOI.POIFS.Crypt.CryptoFunctions.CreateXorVerifier1(password);
				return num == num2;
			}
			if (value3 == null || value2 == null || value4 == null || value5 == null)
			{
				return false;
			}
			object a = global::System.Convert.FromBase64String(value3);
			global::NPOI.POIFS.Crypt.HashAlgorithm hashAlgorithm = global::NPOI.POIFS.Crypt.HashAlgorithm.FromString(value2);
			byte[] salt = global::System.Convert.FromBase64String(value4);
			int spinCount = int.Parse(value5);
			byte[] b = global::NPOI.POIFS.Crypt.CryptoFunctions.HashPassword(password, hashAlgorithm, salt, spinCount, false);
			return global::NPOI.Util.Arrays.Equals(a, b);
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x00029DE8 File Offset: 0x00027FE8
		private static global::System.Xml.XmlQualifiedName GetAttrName(string prefix, string name)
		{
			if (string.IsNullOrEmpty(prefix))
			{
				return new global::System.Xml.XmlQualifiedName(name);
			}
			return new global::System.Xml.XmlQualifiedName(prefix + char.ToUpper(name[0]).ToString() + name.Substring(1));
		}
	}
}
