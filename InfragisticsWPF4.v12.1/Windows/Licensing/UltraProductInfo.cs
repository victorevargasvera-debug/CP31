using System;
using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using System.Windows;
using Microsoft.Win32;

namespace Infragistics.Windows.Licensing
{
	// Token: 0x020001F2 RID: 498
	[global::System.Runtime.InteropServices.ComVisible(false)]
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public sealed class UltraProductInfo : global::Infragistics.Windows.Licensing.UltraProductInfoBase
	{
		// Token: 0x060012A7 RID: 4775 RVA: 0x00043668 File Offset: 0x00041868
		public UltraProductInfo(string productName, string regKeyProductName, string codePrefix, global::System.Guid id, bool requiresActivation, byte majorVersion, byte minorVersion) : base(productName)
		{
			if (codePrefix == null || codePrefix.Length != 4)
			{
				throw new global::System.ArgumentException(global::SR.GetString("LE_ArgumentException_18"));
			}
			this.regKeyProductName = regKeyProductName;
			this.codePrefix = codePrefix;
			this.id = id;
			this.requiresActivation = requiresActivation;
			this.majorVersion = majorVersion;
			this.minorVersion = minorVersion;
		}

		// Token: 0x060012A8 RID: 4776 RVA: 0x000436D4 File Offset: 0x000418D4
		public UltraProductInfo(string productName, string regKeyProductName, string codePrefix, global::System.Guid id, bool requiresActivation, global::Infragistics.Windows.Licensing.ProductType productType, byte majorVersion, byte minorVersion) : base(productName, productType)
		{
			if (codePrefix == null || codePrefix.Length != 4)
			{
				throw new global::System.ArgumentException(global::SR.GetString("LE_ArgumentException_19"));
			}
			this.regKeyProductName = regKeyProductName;
			this.codePrefix = codePrefix;
			this.id = id;
			this.requiresActivation = requiresActivation;
			this.minorVersion = minorVersion;
			this.majorVersion = majorVersion;
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x060012A9 RID: 4777 RVA: 0x00043740 File Offset: 0x00041940
		public override string Expiration
		{
			get
			{
				switch (this.Status)
				{
				case global::Infragistics.Windows.Licensing.LicenseStatus.UnableToLocateLicenseAssembly:
				case global::Infragistics.Windows.Licensing.LicenseStatus.RegKeyNotFound:
					return global::SR.GetString("LDR_UltraProdInfo_Expiration9");
				case global::Infragistics.Windows.Licensing.LicenseStatus.InsufficientSecurityPermissions:
					return global::SR.GetString("LDR_UltraProdInfo_Expiration10");
				case global::Infragistics.Windows.Licensing.LicenseStatus.CDKeyInvalid:
					return global::SR.GetString("LDR_UltraProdInfo_Expiration6");
				case global::Infragistics.Windows.Licensing.LicenseStatus.BetaExpired:
					return global::SR.GetString("LDR_UltraProdInfo_Expiration3");
				case global::Infragistics.Windows.Licensing.LicenseStatus.BetaValid:
				case global::Infragistics.Windows.Licensing.LicenseStatus.Licensed:
					return global::SR.GetString("LDR_UltraProdInfo_Expiration5");
				case global::Infragistics.Windows.Licensing.LicenseStatus.TrialExpired:
					return global::SR.GetString("LDR_UltraProdInfo_Expiration2");
				case global::Infragistics.Windows.Licensing.LicenseStatus.ActivationGracePeriodExpired:
					return global::SR.GetString("LDR_UltraProdInfo_Expiration1");
				case global::Infragistics.Windows.Licensing.LicenseStatus.CDKeyValid:
					return global::SR.GetString("LDR_UltraProdInfo_Expiration7");
				case global::Infragistics.Windows.Licensing.LicenseStatus.TrialValid:
				case global::Infragistics.Windows.Licensing.LicenseStatus.ActivationGracePeriodValid:
					return global::SR.GetString("LDR_UltraProdInfo_Expiration4", new object[]
					{
						this.daysRemaining,
						this.GetCalendarWeeksLeft()
					});
				}
				return global::SR.GetString("LDR_UltraProdInfo_Expiration8");
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x060012AA RID: 4778 RVA: 0x00043821 File Offset: 0x00041A21
		public override bool RequiresActivation
		{
			get
			{
				return this.requiresActivation;
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x060012AB RID: 4779 RVA: 0x00043829 File Offset: 0x00041A29
		public override global::Infragistics.Windows.Licensing.LicenseStatus Status
		{
			get
			{
				if (this.status == global::Infragistics.Windows.Licensing.LicenseStatus.Unchecked)
				{
					this.CheckLicenseStatus();
				}
				return this.status;
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x060012AC RID: 4780 RVA: 0x0004383F File Offset: 0x00041A3F
		public override string Key
		{
			get
			{
				return this.cdkey;
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x060012AD RID: 4781 RVA: 0x00043847 File Offset: 0x00041A47
		public override string CompanyName
		{
			get
			{
				return this.companyName;
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x060012AE RID: 4782 RVA: 0x0004384F File Offset: 0x00041A4F
		public override string UserName
		{
			get
			{
				return this.userName;
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x060012AF RID: 4783 RVA: 0x00043857 File Offset: 0x00041A57
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public string RegKeyProductName
		{
			get
			{
				return this.regKeyProductName;
			}
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x00043860 File Offset: 0x00041A60
		private void CheckLicenseStatus()
		{
			if (this.status != global::Infragistics.Windows.Licensing.LicenseStatus.Unchecked)
			{
				return;
			}
			if (global::Infragistics.Windows.Licensing.UltraProductInfo.CheckProductStatus(this, false) != global::Infragistics.Windows.Licensing.LicenseStatus.Unchecked)
			{
				global::Infragistics.Windows.Licensing.UltraProductInfo.CheckProductStatus(this, true);
				return;
			}
			string empty = string.Empty;
			string licenseAssemblyInfo = global::Infragistics.Windows.Licensing.UltraProductInfo.GetLicenseAssemblyInfo();
			try
			{
				global::System.Runtime.Remoting.ObjectHandle objectHandle = global::System.Activator.CreateInstance(licenseAssemblyInfo, "Infragistics.License.LicenseValidator");
				object obj = objectHandle.Unwrap();
				global::System.Type type = obj.GetType();
				object[] array = new object[]
				{
					this.regKeyProductName,
					this.majorVersion,
					this.minorVersion,
					empty,
					this.userName,
					this.companyName
				};
				global::System.Reflection.MethodInfo method = type.GetMethod("GetRegistryInfo");
				object obj2 = method.Invoke(obj, array);
				if (obj2 == null || !(bool)obj2 || (string)array[3] == "{Error}")
				{
					this.UpdateProductStatus(global::Infragistics.Windows.Licensing.LicenseStatus.RegKeyNotFound, global::System.DateTime.MinValue);
				}
				else
				{
					this.cdkey = (array[3] as string);
					this.userName = (array[4] as string);
					this.companyName = (array[5] as string);
					if (this.cdkey == "{Trial}")
					{
						this.IsDemoValid(true);
					}
					else
					{
						this.IsLicenseValid(this.cdkey, true);
					}
				}
			}
			catch (global::System.IO.FileNotFoundException)
			{
				if (this.status == global::Infragistics.Windows.Licensing.LicenseStatus.Unchecked)
				{
					this.UpdateProductStatus(global::Infragistics.Windows.Licensing.LicenseStatus.UnableToLocateLicenseAssembly, global::System.DateTime.MinValue);
				}
			}
			catch (global::System.Security.SecurityException)
			{
				if (this.status == global::Infragistics.Windows.Licensing.LicenseStatus.Unchecked)
				{
					this.UpdateProductStatus(global::Infragistics.Windows.Licensing.LicenseStatus.InsufficientSecurityPermissions, global::System.DateTime.MinValue);
				}
			}
			catch (global::System.Exception)
			{
				if (this.status == global::Infragistics.Windows.Licensing.LicenseStatus.Unchecked)
				{
					this.UpdateProductStatus(global::Infragistics.Windows.Licensing.LicenseStatus.RegKeyNotFound, global::System.DateTime.MinValue);
				}
			}
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x00043A34 File Offset: 0x00041C34
		private static string GetLicenseAssemblyInfo()
		{
			string format = "Infragistics.License, Culture=\"\", Version={0}, PublicKeyToken=7dd5c3163f2cd0cb";
			global::Microsoft.Win32.RegistryKey registryKey2;
			global::Microsoft.Win32.RegistryKey registryKey = registryKey2 = null;
			string result;
			try
			{
				registryKey = global::Microsoft.Win32.Registry.ClassesRoot.OpenSubKey("Infragistics.License");
				registryKey2 = registryKey.OpenSubKey("Version1");
				string arg = registryKey2.GetValue(null) as string;
				result = string.Format(format, arg);
			}
			catch (global::System.Exception)
			{
				result = "Infragistics.License, Culture=\"\", PublicKeyToken=7dd5c3163f2cd0cb";
			}
			finally
			{
				if (registryKey2 != null)
				{
					registryKey2.Close();
				}
				if (registryKey != null)
				{
					registryKey.Close();
				}
			}
			return result;
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x00043ABC File Offset: 0x00041CBC
		protected internal override bool IsKeyValid(string key)
		{
			return key == "{Trial}" || (key != null && key.Length != 0 && this.IsLicenseValid(key, false));
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x00043AE4 File Offset: 0x00041CE4
		private bool IsDemoValid(bool updateProductInfo)
		{
			string licenseAssemblyInfo = global::Infragistics.Windows.Licensing.UltraProductInfo.GetLicenseAssemblyInfo();
			object obj = null;
			try
			{
				global::System.Runtime.Remoting.ObjectHandle objectHandle = global::System.Activator.CreateInstance(licenseAssemblyInfo, "Infragistics.License.LicenseValidator");
				obj = objectHandle.Unwrap();
			}
			catch (global::System.IO.FileNotFoundException)
			{
				if (updateProductInfo)
				{
					this.UpdateProductStatus(global::Infragistics.Windows.Licensing.LicenseStatus.UnableToLocateLicenseAssembly, global::System.DateTime.MinValue);
				}
				return false;
			}
			catch (global::System.Security.SecurityException)
			{
				if (updateProductInfo)
				{
					this.UpdateProductStatus(global::Infragistics.Windows.Licensing.LicenseStatus.InsufficientSecurityPermissions, global::System.DateTime.MinValue);
				}
				return false;
			}
			catch (global::System.Exception)
			{
				if (updateProductInfo)
				{
					this.UpdateProductStatus(global::Infragistics.Windows.Licensing.LicenseStatus.RegKeyNotFound, global::System.DateTime.MinValue);
				}
				return false;
			}
			bool result;
			try
			{
				global::System.Type type = obj.GetType();
				global::System.Reflection.MethodInfo method = type.GetMethod("DaysRemainingBeforeTimeOut");
				object[] parameters = new object[]
				{
					20,
					this.regKeyProductName,
					this.majorVersion,
					this.minorVersion,
					this.id
				};
				try
				{
					object obj2 = method.Invoke(obj, parameters);
					int num = (int)obj2;
					this.daysRemaining = num;
					if (updateProductInfo)
					{
						if (num >= 0)
						{
							this.UpdateProductStatus(global::Infragistics.Windows.Licensing.LicenseStatus.TrialValid, global::Infragistics.Windows.Licensing.UltraProductInfo.GetExpirationDate(num));
						}
						else
						{
							this.UpdateProductStatus(global::Infragistics.Windows.Licensing.LicenseStatus.TrialExpired, global::Infragistics.Windows.Licensing.UltraProductInfo.GetExpirationDate(num));
						}
					}
					result = (num >= 0);
				}
				catch (global::System.Exception ex)
				{
					if (updateProductInfo)
					{
						global::System.Exception innerException = ex.InnerException;
						global::System.Security.SecurityException ex2 = innerException as global::System.Security.SecurityException;
						if (ex2 == null && innerException != null)
						{
							ex2 = (innerException.InnerException as global::System.Security.SecurityException);
						}
						if (ex2 != null)
						{
							if (ex2.PermissionType == null || typeof(global::System.Security.Permissions.RegistryPermission).IsAssignableFrom(ex2.PermissionType))
							{
								this.daysRemaining = 20;
								this.UpdateProductStatus(global::Infragistics.Windows.Licensing.LicenseStatus.TrialValid, global::Infragistics.Windows.Licensing.UltraProductInfo.GetExpirationDate(this.daysRemaining));
								return true;
							}
							this.UpdateProductStatus(global::Infragistics.Windows.Licensing.LicenseStatus.InsufficientSecurityPermissions, global::System.DateTime.MinValue);
						}
						else
						{
							this.UpdateProductStatus(global::Infragistics.Windows.Licensing.LicenseStatus.RegKeyNotFound, global::System.DateTime.MinValue);
						}
					}
					result = false;
				}
			}
			catch (global::System.Exception)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x00043D2C File Offset: 0x00041F2C
		private void UpdateProductStatus(global::Infragistics.Windows.Licensing.LicenseStatus newStatus, global::System.DateTime expirationDate)
		{
			this.status = newStatus;
			this.expirationDate = expirationDate;
			if (newStatus > global::Infragistics.Windows.Licensing.LicenseStatus.RegKeyNotFound && global::Infragistics.Windows.Licensing.UltraProductInfo.CheckProductStatus(this, false) == global::Infragistics.Windows.Licensing.LicenseStatus.Unchecked)
			{
				global::Infragistics.Windows.Licensing.UltraProductInfo.ProductVerified(this);
			}
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x00043D4F File Offset: 0x00041F4F
		private bool IsLicenseValid(string key, bool updateProductInfo)
		{
			if (!this.VerifyCheckSum(key, false))
			{
				if (updateProductInfo)
				{
					this.UpdateProductStatus(global::Infragistics.Windows.Licensing.LicenseStatus.CDKeyInvalid, global::System.DateTime.MinValue);
				}
				return false;
			}
			if (!updateProductInfo)
			{
				return true;
			}
			if (updateProductInfo)
			{
				this.cdkey = key;
				this.UpdateProductStatus(global::Infragistics.Windows.Licensing.LicenseStatus.Licensed, global::System.DateTime.MaxValue);
			}
			return true;
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x00043D89 File Offset: 0x00041F89
		private static void ProductVerified(global::Infragistics.Windows.Licensing.UltraProductInfo product)
		{
			if (product == null)
			{
				return;
			}
			if (global::Infragistics.Windows.Licensing.UltraProductInfo.verifiedProducts == null)
			{
				global::Infragistics.Windows.Licensing.UltraProductInfo.verifiedProducts = new global::System.Collections.ArrayList();
			}
			global::Infragistics.Windows.Licensing.UltraProductInfo.verifiedProducts.Add(product);
		}

		// Token: 0x060012B7 RID: 4791 RVA: 0x00043DAC File Offset: 0x00041FAC
		private static bool HasPromptBeenDisplayed(global::Infragistics.Windows.Licensing.UltraProductInfo product)
		{
			if (global::Infragistics.Windows.Licensing.UltraProductInfo._canCheckEnvironmentVariable && product != null)
			{
				try
				{
					string promptVariableName = product.GetPromptVariableName();
					string environmentVariable = global::System.Environment.GetEnvironmentVariable(promptVariableName);
					if (bool.TrueString.Equals(environmentVariable))
					{
						return true;
					}
				}
				catch (global::System.Security.SecurityException)
				{
					global::Infragistics.Windows.Licensing.UltraProductInfo._canCheckEnvironmentVariable = false;
				}
			}
			if (global::Infragistics.Windows.Licensing.UltraProductInfo.verifiedProducts == null || product == null)
			{
				return false;
			}
			foreach (object obj in global::Infragistics.Windows.Licensing.UltraProductInfo.verifiedProducts)
			{
				global::Infragistics.Windows.Licensing.UltraProductInfo ultraProductInfo = (global::Infragistics.Windows.Licensing.UltraProductInfo)obj;
				if (ultraProductInfo.Equals(product))
				{
					return ultraProductInfo.promptDisplayed;
				}
			}
			return false;
		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x00043E68 File Offset: 0x00042068
		private string GetPromptVariableName()
		{
			return string.Format("IG_{0}_{1}_{2}_{3}_{4}", new object[]
			{
				this.codePrefix,
				this.majorVersion,
				this.minorVersion,
				this.regKeyProductName,
				this.id
			});
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x00043EC8 File Offset: 0x000420C8
		private static void UpdatePromptStatus(global::Infragistics.Windows.Licensing.UltraProductInfo product, bool hasBeenDisplayed)
		{
			if (global::Infragistics.Windows.Licensing.UltraProductInfo.verifiedProducts == null || product == null)
			{
				return;
			}
			foreach (object obj in global::Infragistics.Windows.Licensing.UltraProductInfo.verifiedProducts)
			{
				global::Infragistics.Windows.Licensing.UltraProductInfo ultraProductInfo = (global::Infragistics.Windows.Licensing.UltraProductInfo)obj;
				if (ultraProductInfo.Equals(product))
				{
					ultraProductInfo.promptDisplayed = hasBeenDisplayed;
				}
			}
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x00043F34 File Offset: 0x00042134
		private static global::Infragistics.Windows.Licensing.LicenseStatus CheckProductStatus(global::Infragistics.Windows.Licensing.UltraProductInfo product, bool updateProductInfoIfFound)
		{
			if (global::Infragistics.Windows.Licensing.UltraProductInfo.verifiedProducts == null || product == null)
			{
				return global::Infragistics.Windows.Licensing.LicenseStatus.Unchecked;
			}
			foreach (object obj in global::Infragistics.Windows.Licensing.UltraProductInfo.verifiedProducts)
			{
				global::Infragistics.Windows.Licensing.UltraProductInfo ultraProductInfo = (global::Infragistics.Windows.Licensing.UltraProductInfo)obj;
				if (ultraProductInfo.Equals(product))
				{
					if (updateProductInfoIfFound)
					{
						if (ultraProductInfo.cdkey != null && ultraProductInfo.cdkey.Length > 0)
						{
							product.cdkey = ultraProductInfo.cdkey;
						}
						product.companyName = ultraProductInfo.companyName;
						product.expirationDate = ultraProductInfo.expirationDate;
						product.status = ultraProductInfo.status;
						product.userName = ultraProductInfo.userName;
						product.promptDisplayed = ultraProductInfo.promptDisplayed;
						product.daysRemaining = ultraProductInfo.daysRemaining;
					}
					return ultraProductInfo.Status;
				}
			}
			return global::Infragistics.Windows.Licensing.LicenseStatus.Unchecked;
		}

		// Token: 0x060012BB RID: 4795 RVA: 0x0004401C File Offset: 0x0004221C
		private bool VerifyCheckSum(string str, bool isInternal)
		{
			if (!isInternal && this.badCount > 6)
			{
				return false;
			}
			if (str == null)
			{
				return false;
			}
			if (str.Length != 18)
			{
				return false;
			}
			for (int i = 0; i < str.Length; i++)
			{
				char c = str[i];
				if (c < '0' || (c > 'Z' && i > 0))
				{
					return false;
				}
			}
			if (!global::Infragistics.Windows.Licensing.UltraProductInfo.IsCDKeyPrefixValid(str))
			{
				if (!isInternal)
				{
					this.badCount++;
				}
				return false;
			}
			if (this.codePrefix.Substring(0, 2) != str.Substring(0, 2))
			{
				if (!isInternal)
				{
					this.badCount++;
				}
				return false;
			}
			if (this.codePrefix.Length >= 4 && str.Length >= 4 && char.IsNumber(this.codePrefix[2]) && char.IsNumber(this.codePrefix[3]) && char.IsNumber(str[2]) && char.IsNumber(str[3]))
			{
				int num = int.Parse(str.Substring(2, 2));
				int num2 = int.Parse(this.codePrefix.Substring(2, 2));
				if (num < num2)
				{
					if (!isInternal)
					{
						this.badCount++;
					}
					return false;
				}
			}
			for (int j = 8; j < 18; j++)
			{
				if (!char.IsDigit(str[j]))
				{
					if (!isInternal)
					{
						this.badCount++;
					}
					return false;
				}
			}
			int num3 = 0;
			bool flag = global::Infragistics.Windows.Licensing.UltraProductInfo.VerifyCDKey(str, ref num3) != 0L;
			if (!isInternal && !flag)
			{
				global::System.Threading.Thread.Sleep(1000);
				this.badCount++;
			}
			return flag;
		}

		// Token: 0x060012BC RID: 4796 RVA: 0x000441B8 File Offset: 0x000423B8
		private static bool IsCDKeyPrefixValid(string licKey)
		{
			if (licKey == null || licKey.Length < 7)
			{
				return false;
			}
			for (int i = 0; i < 6; i++)
			{
				char c = licKey[i];
				if (!char.IsDigit(c) && (i >= 2 || !char.IsLetter(c)))
				{
					return false;
				}
			}
			return (licKey[4] != '0' || licKey[5] != '0') && (licKey[6] == '0' || char.IsLetter(licKey[6])) && (licKey[7] == '0' || licKey[7] == '1');
		}

		// Token: 0x060012BD RID: 4797 RVA: 0x0004424C File Offset: 0x0004244C
		private static long LicenseCalcCheckSum(string str)
		{
			long num = 27L;
			long num2 = 31L;
			long num3 = 12765L;
			long num4 = 376L;
			for (int i = 0; i < str.Length; i++)
			{
				long num5 = (long)((ulong)str[i]);
				num5 = num5 * 3L + num2;
				num4 += num * (num5 * num5);
				num2 = (long)((ulong)str[i]);
				num2 *= 3L;
				num3 += num4;
				num += 1L;
				global::Infragistics.Windows.Licensing.UltraProductInfo.ReduceValue(ref num4, 999999, 697543);
				global::Infragistics.Windows.Licensing.UltraProductInfo.ReduceValue(ref num3, 99999, 58567);
				global::Infragistics.Windows.Licensing.UltraProductInfo.ReduceValue(ref num3, 9999, 9997);
			}
			return num3;
		}

		// Token: 0x060012BE RID: 4798 RVA: 0x000442F0 File Offset: 0x000424F0
		private static void ReduceValue(ref long value, int maximum, int factor)
		{
			if (value <= (long)maximum)
			{
				return;
			}
			long num = value - (long)maximum;
			long num2 = num / (long)factor;
			if (num % (long)factor != 0L)
			{
				num2 += 1L;
			}
			value -= num2 * (long)factor;
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x00044328 File Offset: 0x00042528
		private static long VerifyCDKey(string licKey, ref int serialNumber)
		{
			char[] array = new char[7];
			global::Infragistics.Windows.Licensing.UltraProductInfo.CDMsk checkDigitMask = global::Infragistics.Windows.Licensing.UltraProductInfo.GetCheckDigitMask(licKey);
			int num = 0;
			bool flag = true;
			for (int i = 0; i < 4; i++)
			{
				int num2 = (int)checkDigitMask.rgCP[i];
				while (num + i + 8 < num2)
				{
					array[5 - num] = licKey[8 + i + num];
					num++;
				}
				string str = new string(licKey.ToCharArray(0, num2));
				long checkSum = global::Infragistics.Windows.Licensing.UltraProductInfo.LicenseCalcCheckSum(str);
				char c = licKey[num2];
				if (c != global::Infragistics.Windows.Licensing.UltraProductInfo.GetCheckDigitFromSum(checkSum, checkDigitMask))
				{
					flag = false;
				}
			}
			if (flag)
			{
				long num3 = long.Parse(new string(array));
				if (num3 < checkDigitMask.nF1)
				{
					num3 += 1000000L - checkDigitMask.nF1;
				}
				else
				{
					num3 -= checkDigitMask.nF1;
				}
				serialNumber = (int)num3;
			}
			if (flag)
			{
				return 3L;
			}
			global::System.Threading.Thread.Sleep(500);
			return 0L;
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x00044408 File Offset: 0x00042608
		private static global::Infragistics.Windows.Licensing.UltraProductInfo.CDMsk GetCheckDigitMask(string licKey)
		{
			if (licKey == null || licKey.Length < 18)
			{
				throw new global::System.ArgumentException(global::SR.GetString("LE_ArgumentException_19"));
			}
			string str = licKey.Substring(0, 8);
			long num = global::Infragistics.Windows.Licensing.UltraProductInfo.LicenseCalcCheckSum(str);
			return global::Infragistics.Windows.Licensing.UltraProductInfo.s_CDM[(int)(checked((global::System.IntPtr)(num % unchecked((long)global::Infragistics.Windows.Licensing.UltraProductInfo.s_CDM.Length))))];
		}

		// Token: 0x060012C1 RID: 4801 RVA: 0x0004445C File Offset: 0x0004265C
		private static char GetCheckDigitFromSum(long checkSum, global::Infragistics.Windows.Licensing.UltraProductInfo.CDMsk mask)
		{
			return (char)(48L + (checkSum + mask.nF3) % mask.nF2 % 10L);
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x00044478 File Offset: 0x00042678
		private int GetCalendarWeeksLeft()
		{
			return (this.daysRemaining + 2 - 1) / 2;
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x00044488 File Offset: 0x00042688
		private static global::System.DateTime GetExpirationDate(int usageDaysRemaining)
		{
			int num = (usageDaysRemaining + 2 - 1) / 2;
			return global::System.DateTime.Today.AddDays(7.0 * (double)num);
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x060012C4 RID: 4804 RVA: 0x000444B6 File Offset: 0x000426B6
		internal global::Infragistics.Windows.Licensing.UltraProductInfo[] AllNewerProducts
		{
			get
			{
				if (this.allNewerProducts == null)
				{
					this.LoadAllNewerProductInfo();
				}
				return this.allNewerProducts;
			}
		}

		// Token: 0x060012C5 RID: 4805 RVA: 0x000444CC File Offset: 0x000426CC
		private void LoadAllNewerProductInfo()
		{
			if (this.allNewerProducts != null)
			{
				return;
			}
			string licenseAssemblyInfo = global::Infragistics.Windows.Licensing.UltraProductInfo.GetLicenseAssemblyInfo();
			global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList(3);
			global::System.Collections.ArrayList arrayList2 = new global::System.Collections.ArrayList(3);
			try
			{
				global::System.Runtime.Remoting.ObjectHandle objectHandle = global::System.Activator.CreateInstance(licenseAssemblyInfo, "Infragistics.License.LicenseValidator");
				object obj = objectHandle.Unwrap();
				global::System.Type type = obj.GetType();
				global::System.Reflection.MethodInfo method = type.GetMethod("GetNewerVersions");
				object[] parameters = new object[]
				{
					this.regKeyProductName,
					this.majorVersion,
					this.minorVersion,
					arrayList,
					arrayList2
				};
				method.Invoke(obj, parameters);
				byte[] array = arrayList.ToArray(typeof(byte)) as byte[];
				byte[] array2 = arrayList2.ToArray(typeof(byte)) as byte[];
				if (array != null && array2 != null && array.Length == array2.Length)
				{
					this.allNewerProducts = new global::Infragistics.Windows.Licensing.UltraProductInfo[array.Length];
					for (int i = 0; i < array.Length; i++)
					{
						byte b = array[i];
						byte b2 = array2[i];
						global::Infragistics.Windows.Licensing.UltraProductInfo ultraProductInfo = new global::Infragistics.Windows.Licensing.UltraProductInfo(base.ProductName, this.regKeyProductName, this.codePrefix, this.id, this.requiresActivation, base.Type, b, b2);
						this.allNewerProducts[i] = ultraProductInfo;
					}
				}
				else
				{
					this.allNewerProducts = new global::Infragistics.Windows.Licensing.UltraProductInfo[0];
				}
			}
			catch
			{
			}
		}

		// Token: 0x060012C6 RID: 4806 RVA: 0x00044644 File Offset: 0x00042844
		internal void DisplayPrompt()
		{
			if (this.promptDisplayed)
			{
				return;
			}
			if (global::Infragistics.Windows.Licensing.UltraProductInfo.HasPromptBeenDisplayed(this))
			{
				this.promptDisplayed = true;
				return;
			}
			string text = null;
			switch (this.status)
			{
			case global::Infragistics.Windows.Licensing.LicenseStatus.TrialValid:
				text = string.Format(global::SR.GetString("LicensedProductTrialPeriodPrompt"), this.daysRemaining, this.GetCalendarWeeksLeft(), base.ProductName);
				break;
			case global::Infragistics.Windows.Licensing.LicenseStatus.ActivationGracePeriodValid:
				text = string.Format(global::SR.GetString("LicensedProductActivationGracePrompt"), this.daysRemaining, this.GetCalendarWeeksLeft(), base.ProductName);
				break;
			default:
				return;
			}
			this.promptDisplayed = true;
			global::Infragistics.Windows.Licensing.UltraProductInfo.UpdatePromptStatus(this, true);
			if (text != null && global::Infragistics.Windows.Licensing.UltraProductInfo._canCheckEnvironmentVariable)
			{
				try
				{
					string promptVariableName = this.GetPromptVariableName();
					global::System.Environment.SetEnvironmentVariable(promptVariableName, bool.TrueString);
				}
				catch (global::System.Security.SecurityException)
				{
					global::Infragistics.Windows.Licensing.UltraProductInfo._canCheckEnvironmentVariable = false;
				}
			}
			try
			{
				string @string = global::SR.GetString("LicensedProductPromptDialogTitle", new object[]
				{
					base.ProductName
				});
				global::System.Windows.MessageBox.Show(text, @string, global::System.Windows.MessageBoxButton.OK, global::System.Windows.MessageBoxImage.Exclamation);
			}
			catch
			{
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x060012C7 RID: 4807 RVA: 0x00044760 File Offset: 0x00042960
		public override bool Expired
		{
			get
			{
				return global::System.DateTime.Today > this.expirationDate;
			}
		}

		// Token: 0x060012C8 RID: 4808 RVA: 0x00044772 File Offset: 0x00042972
		public override int GetHashCode()
		{
			return this.codePrefix.GetHashCode();
		}

		// Token: 0x060012C9 RID: 4809 RVA: 0x00044780 File Offset: 0x00042980
		public override bool Equals(object obj)
		{
			global::Infragistics.Windows.Licensing.UltraProductInfo ultraProductInfo = obj as global::Infragistics.Windows.Licensing.UltraProductInfo;
			return ultraProductInfo != null && this.codePrefix == ultraProductInfo.codePrefix && this.majorVersion == ultraProductInfo.majorVersion && this.minorVersion == ultraProductInfo.minorVersion && this.regKeyProductName == ultraProductInfo.regKeyProductName && this.id == ultraProductInfo.id;
		}

		// Token: 0x04000995 RID: 2453
		private const int MIN_USAGE_DAYS_PER_WEEK = 2;

		// Token: 0x04000996 RID: 2454
		private const int TRIAL_MAX_USAGE_DAYS = 20;

		// Token: 0x04000997 RID: 2455
		private const int GRACE_MAX_USAGE_DAYS = 40;

		// Token: 0x04000998 RID: 2456
		private const int SSCDKEYTYPE_INVALID = 0;

		// Token: 0x04000999 RID: 2457
		private const int SSCDKEYTYPE_3RDGEN = 3;

		// Token: 0x0400099A RID: 2458
		internal const string trialKeyText = "{Trial}";

		// Token: 0x0400099B RID: 2459
		private const string errorKeyText = "{Error}";

		// Token: 0x0400099C RID: 2460
		private const int SIZEOFCDKEY = 18;

		// Token: 0x0400099D RID: 2461
		private global::System.DateTime expirationDate = global::System.DateTime.MaxValue;

		// Token: 0x0400099E RID: 2462
		private string cdkey;

		// Token: 0x0400099F RID: 2463
		private string companyName;

		// Token: 0x040009A0 RID: 2464
		private string userName;

		// Token: 0x040009A1 RID: 2465
		private string regKeyProductName;

		// Token: 0x040009A2 RID: 2466
		private string codePrefix;

		// Token: 0x040009A3 RID: 2467
		private global::System.Guid id;

		// Token: 0x040009A4 RID: 2468
		private bool requiresActivation;

		// Token: 0x040009A5 RID: 2469
		private byte majorVersion;

		// Token: 0x040009A6 RID: 2470
		private byte minorVersion;

		// Token: 0x040009A7 RID: 2471
		private global::Infragistics.Windows.Licensing.LicenseStatus status;

		// Token: 0x040009A8 RID: 2472
		private int badCount;

		// Token: 0x040009A9 RID: 2473
		private static global::System.Collections.ArrayList verifiedProducts;

		// Token: 0x040009AA RID: 2474
		private bool promptDisplayed;

		// Token: 0x040009AB RID: 2475
		private int daysRemaining;

		// Token: 0x040009AC RID: 2476
		private static bool _canCheckEnvironmentVariable = true;

		// Token: 0x040009AD RID: 2477
		private static global::Infragistics.Windows.Licensing.UltraProductInfo.CDMsk[] s_CDM = new global::Infragistics.Windows.Licensing.UltraProductInfo.CDMsk[]
		{
			new global::Infragistics.Windows.Licensing.UltraProductInfo.CDMsk(123456L, '\t', '\v', '\r', '\u0011', 53L, 1782L),
			new global::Infragistics.Windows.Licensing.UltraProductInfo.CDMsk(734561L, '\t', '\v', '\u000e', '\u0011', 69L, 2772L),
			new global::Infragistics.Windows.Licensing.UltraProductInfo.CDMsk(217192L, '\t', '\v', '\u000f', '\u0011', 86L, 1771L),
			new global::Infragistics.Windows.Licensing.UltraProductInfo.CDMsk(152473L, '\t', '\f', '\u000e', '\u0011', 75L, 6177L),
			new global::Infragistics.Windows.Licensing.UltraProductInfo.CDMsk(368242L, '\t', '\f', '\u000f', '\u0011', 92L, 3255L),
			new global::Infragistics.Windows.Licensing.UltraProductInfo.CDMsk(476532L, '\t', '\r', '\u000f', '\u0011', 97L, 2552L),
			new global::Infragistics.Windows.Licensing.UltraProductInfo.CDMsk(885162L, '\n', '\f', '\u000e', '\u0011', 37L, 7484L),
			new global::Infragistics.Windows.Licensing.UltraProductInfo.CDMsk(49735L, '\n', '\f', '\u000f', '\u0011', 89L, 2251L),
			new global::Infragistics.Windows.Licensing.UltraProductInfo.CDMsk(901278L, '\v', '\r', '\u000f', '\u0011', 72L, 1552L)
		};

		// Token: 0x040009AE RID: 2478
		private global::Infragistics.Windows.Licensing.UltraProductInfo[] allNewerProducts;

		// Token: 0x020001F3 RID: 499
		private struct CDMsk
		{
			// Token: 0x060012CB RID: 4811 RVA: 0x00044978 File Offset: 0x00042B78
			public CDMsk(long f1, char ch1, char ch2, char ch3, char ch4, long f2, long f3)
			{
				this.rgCP = new char[]
				{
					ch1,
					ch2,
					ch3,
					ch4
				};
				this.nF1 = f1;
				this.nF2 = f2;
				this.nF3 = f3;
			}

			// Token: 0x040009AF RID: 2479
			public readonly long nF1;

			// Token: 0x040009B0 RID: 2480
			public readonly char[] rgCP;

			// Token: 0x040009B1 RID: 2481
			public readonly long nF2;

			// Token: 0x040009B2 RID: 2482
			public readonly long nF3;
		}
	}
}
