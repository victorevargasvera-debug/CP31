using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Threading;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.Licensing
{
	// Token: 0x0200021C RID: 540
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	[global::System.Runtime.InteropServices.ComVisible(false)]
	public sealed class UltraLicenseProvider : global::System.ComponentModel.LicenseProvider
	{
		// Token: 0x0600145F RID: 5215 RVA: 0x00048BC0 File Offset: 0x00046DC0
		public override global::System.ComponentModel.License GetLicense(global::System.ComponentModel.LicenseContext context, global::System.Type type, object instance, bool allowExceptions)
		{
			global::Infragistics.Windows.Licensing.UltraLicense ultraLicense = null;
			if (context != null && context.UsageMode == global::System.ComponentModel.LicenseUsageMode.Runtime)
			{
				if (global::Infragistics.Windows.Licensing.UltraLicenseProvider.LicenseInfos == null)
				{
					global::Infragistics.Windows.Licensing.UltraLicenseProvider.LicenseInfos = new global::System.Collections.Generic.Dictionary<global::System.Type, global::Infragistics.Windows.Licensing.UltraLicenseInfo>();
				}
				global::Infragistics.Windows.Licensing.UltraLicenseInfo licenseInfo;
				if (global::Infragistics.Windows.Licensing.UltraLicenseProvider.LicenseInfos.TryGetValue(type, out licenseInfo))
				{
					ultraLicense = new global::Infragistics.Windows.Licensing.UltraLicense(licenseInfo);
				}
			}
			if (context != null && ultraLicense == null)
			{
				global::Infragistics.Windows.Licensing.UltraLicenseBaseAttribute licenseAttribute = global::Infragistics.Windows.Licensing.UltraLicenseProvider.GetLicenseAttribute(type, instance, allowExceptions);
				if (licenseAttribute != null)
				{
					if (context.UsageMode == global::System.ComponentModel.LicenseUsageMode.Runtime)
					{
						if (global::Infragistics.Windows.Licensing.UltraLicenseProvider.LicenseKeys == null)
						{
							global::Infragistics.Windows.Licensing.UltraLicenseProvider.LicenseKeys = new global::System.Collections.Generic.Dictionary<global::System.Type, string>();
						}
						string text;
						if (!global::Infragistics.Windows.Licensing.UltraLicenseProvider.LicenseKeys.TryGetValue(type, out text))
						{
							try
							{
								text = context.GetSavedLicenseKey(type, null);
							}
							catch (global::System.Exception)
							{
								text = null;
							}
							global::Infragistics.Windows.Licensing.UltraLicenseProvider.LicenseKeys[type] = text;
						}
						ultraLicense = global::Infragistics.Windows.Licensing.UltraLicenseProvider.GetRunTimeLicense(text, type, instance, allowExceptions, licenseAttribute);
						if (ultraLicense != null)
						{
							global::Infragistics.Windows.Licensing.UltraLicenseProvider.LicenseInfos[type] = ultraLicense.LicenseInfo;
						}
					}
					else
					{
						ultraLicense = global::Infragistics.Windows.Licensing.UltraLicenseProvider.GetDesignTimeLicense(type, instance, allowExceptions, licenseAttribute);
						if (ultraLicense != null)
						{
							context.SetSavedLicenseKey(type, ultraLicense.LicenseKey);
						}
					}
				}
			}
			return ultraLicense;
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x00048CB0 File Offset: 0x00046EB0
		private static global::Infragistics.Windows.Licensing.UltraLicenseBaseAttribute GetLicenseAttribute(global::System.Type type, object instance, bool allowExceptions)
		{
			if (!global::Infragistics.Windows.Utilities.HasSamePublicKey(type))
			{
				if (allowExceptions)
				{
					throw new global::System.ComponentModel.LicenseException(type, instance, global::SR.GetString("LE_LicenseException_1"));
				}
				return null;
			}
			else
			{
				global::Infragistics.Windows.Licensing.UltraLicenseBaseAttribute ultraLicenseBaseAttribute = null;
				object[] array = null;
				try
				{
					array = type.GetCustomAttributes(typeof(global::Infragistics.Windows.Licensing.UltraLicenseBaseAttribute), false);
				}
				catch
				{
				}
				if (array != null)
				{
					for (int i = 0; i < array.Length; i++)
					{
						ultraLicenseBaseAttribute = (array[i] as global::Infragistics.Windows.Licensing.UltraLicenseBaseAttribute);
						if (ultraLicenseBaseAttribute != null)
						{
							break;
						}
					}
				}
				if (ultraLicenseBaseAttribute == null && allowExceptions)
				{
					throw new global::System.ComponentModel.LicenseException(type, instance, global::SR.GetString("LE_LicenseException_2"));
				}
				return ultraLicenseBaseAttribute;
			}
		}

		// Token: 0x06001461 RID: 5217 RVA: 0x00048D40 File Offset: 0x00046F40
		private static global::Infragistics.Windows.Licensing.UltraLicense GetDesignTimeLicense(global::System.Type type, object instance, bool allowExceptions, global::Infragistics.Windows.Licensing.UltraLicenseBaseAttribute licenseAttribute)
		{
			global::Infragistics.Windows.Licensing.LicenseOptions licenseOptions = global::Infragistics.Windows.Licensing.UltraLicenseProvider.LicenseOptions;
			global::Infragistics.Windows.Licensing.UltraProductInfoBase[] allProducts = licenseAttribute.AllProducts;
			if (allProducts == null || allProducts.Length < 1)
			{
				return null;
			}
			global::Infragistics.Windows.Licensing.UltraProductInfoBase ultraProductInfoBase = null;
			for (int i = 0; i < allProducts.Length; i++)
			{
				if (ultraProductInfoBase == null || ultraProductInfoBase.Status < allProducts[i].Status)
				{
					ultraProductInfoBase = allProducts[i];
				}
				if (ultraProductInfoBase.Status == global::Infragistics.Windows.Licensing.LicenseStatus.Licensed)
				{
					break;
				}
			}
			if (ultraProductInfoBase == null)
			{
				if (allowExceptions)
				{
					throw new global::System.ComponentModel.LicenseException(type, instance, global::SR.GetString("LicenseExceptionUnlicensed"));
				}
			}
			else
			{
				switch (ultraProductInfoBase.Status)
				{
				case global::Infragistics.Windows.Licensing.LicenseStatus.UnableToLocateLicenseAssembly:
					if (allowExceptions)
					{
						throw new global::System.ComponentModel.LicenseException(type, instance, global::SR.GetString("LE_LicenseException_3"));
					}
					break;
				case global::Infragistics.Windows.Licensing.LicenseStatus.InsufficientSecurityPermissions:
					if (allowExceptions)
					{
						throw new global::System.ComponentModel.LicenseException(type, instance, global::SR.GetString("LicenseExceptionSecurityPermission"));
					}
					break;
				case global::Infragistics.Windows.Licensing.LicenseStatus.RegKeyNotFound:
					if (allowExceptions)
					{
						throw new global::System.ComponentModel.LicenseException(type, instance, global::SR.GetString("LicenseExceptionInformationNotFound"));
					}
					break;
				case global::Infragistics.Windows.Licensing.LicenseStatus.CDKeyInvalid:
					if (allowExceptions)
					{
						throw new global::System.ComponentModel.LicenseException(type, instance, global::SR.GetString("LicenseExceptionInvalidCDKey"));
					}
					break;
				case global::Infragistics.Windows.Licensing.LicenseStatus.BetaExpired:
					if (allowExceptions)
					{
						throw new global::System.ComponentModel.LicenseException(type, instance, global::SR.GetString("LicenseExceptionBetaExpired", new object[]
						{
							ultraProductInfoBase.ProductName,
							ultraProductInfoBase.Expiration
						}));
					}
					break;
				case global::Infragistics.Windows.Licensing.LicenseStatus.BetaValid:
				case global::Infragistics.Windows.Licensing.LicenseStatus.TrialValid:
				case global::Infragistics.Windows.Licensing.LicenseStatus.ActivationGracePeriodValid:
				case global::Infragistics.Windows.Licensing.LicenseStatus.Licensed:
				{
					global::Infragistics.Windows.Licensing.UltraProductInfo ultraProductInfo = ultraProductInfoBase as global::Infragistics.Windows.Licensing.UltraProductInfo;
					if (ultraProductInfo != null && allowExceptions)
					{
						global::System.Windows.DependencyObject dependencyObject = instance as global::System.Windows.DependencyObject;
						if (dependencyObject != null)
						{
							dependencyObject.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Render, new global::Infragistics.Windows.Internal.PropertyValueTracker.MethodInvoker(ultraProductInfo.DisplayPrompt));
						}
						else
						{
							ultraProductInfo.DisplayPrompt();
						}
					}
					return new global::Infragistics.Windows.Licensing.UltraLicense(licenseAttribute.ComponentName, ultraProductInfoBase, licenseOptions);
				}
				case global::Infragistics.Windows.Licensing.LicenseStatus.TrialExpired:
					if (allowExceptions)
					{
						throw new global::System.ComponentModel.LicenseException(type, instance, global::SR.GetString("LicenseExceptionTrialExpired", new object[]
						{
							ultraProductInfoBase.ProductName,
							ultraProductInfoBase.Expiration
						}));
					}
					break;
				case global::Infragistics.Windows.Licensing.LicenseStatus.ActivationGracePeriodExpired:
					if (allowExceptions)
					{
						throw new global::System.ComponentModel.LicenseException(type, instance, global::SR.GetString("LicenseExceptionGracePeriodExpired", new object[]
						{
							ultraProductInfoBase.ProductName,
							ultraProductInfoBase.Expiration
						}));
					}
					break;
				case global::Infragistics.Windows.Licensing.LicenseStatus.CDKeyValid:
					if (allowExceptions)
					{
						throw new global::System.ComponentModel.LicenseException(type, instance, global::SR.GetString("LicenseExceptionIncomplete"));
					}
					break;
				}
			}
			return null;
		}

		// Token: 0x06001462 RID: 5218 RVA: 0x00048F54 File Offset: 0x00047154
		private static global::Infragistics.Windows.Licensing.UltraLicense GetRunTimeLicense(string key, global::System.Type type, object instance, bool allowExceptions, global::Infragistics.Windows.Licensing.UltraLicenseBaseAttribute licenseAttribute)
		{
			global::Infragistics.Windows.Licensing.LicenseOptions licenseOptions = global::Infragistics.Windows.Licensing.UltraLicense.ParseLicenseOptionsTokensFromKey(ref key);
			global::Infragistics.Windows.Licensing.UltraProductInfoBase[] licensedWithProducts = licenseAttribute.GetLicensedWithProducts();
			if (licensedWithProducts == null)
			{
				return null;
			}
			if (key == null)
			{
				return new global::Infragistics.Windows.Licensing.UltraLicense(licenseAttribute.ComponentName, licensedWithProducts[0], string.Empty, licenseOptions);
			}
			bool flag = false;
			for (int i = 0; i < licensedWithProducts.Length; i++)
			{
				if (licensedWithProducts[i].Type == global::Infragistics.Windows.Licensing.ProductType.WebFormsComponent)
				{
					flag = true;
					break;
				}
			}
			for (int j = 0; j < licensedWithProducts.Length; j++)
			{
				if (licensedWithProducts[j].IsKeyValid(key))
				{
					if (!global::Infragistics.Windows.Licensing.UltraLicenseProvider.hasDisplayedRuntimeDemoMsg && !flag && allowExceptions && key == "{Trial}")
					{
						try
						{
							global::Infragistics.Windows.Licensing.UltraLicenseProvider.hasDisplayedRuntimeDemoMsg = true;
							string @string = global::SR.GetString("LicenseExceptionUnlicensedProgram", new object[]
							{
								licensedWithProducts[j].ProductName
							});
							string string2 = global::SR.GetString("LicensedProductPromptDialogTitle", new object[]
							{
								licensedWithProducts[j].ProductName
							});
							global::System.Windows.DependencyObject dependencyObject = instance as global::System.Windows.DependencyObject;
							if (dependencyObject != null)
							{
								dependencyObject.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Render, new global::Infragistics.Windows.Licensing.UltraLicenseProvider.ShowMessageBoxDelegate(global::Infragistics.Windows.Licensing.UltraLicenseProvider.ShowMessageBoxDelayed), dependencyObject, new object[]
								{
									string2,
									@string
								});
							}
							else
							{
								global::System.Windows.MessageBox.Show(@string, string2, global::System.Windows.MessageBoxButton.OK, global::System.Windows.MessageBoxImage.Exclamation);
							}
						}
						catch
						{
						}
					}
					return new global::Infragistics.Windows.Licensing.UltraLicense(licenseAttribute.ComponentName, licensedWithProducts[j], key, licenseOptions);
				}
			}
			if (allowExceptions)
			{
				throw new global::System.ComponentModel.LicenseException(type, instance, global::SR.GetString("LE_LicenseException_4"));
			}
			return null;
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x000490D4 File Offset: 0x000472D4
		private static void ShowMessageBoxDelayed(global::System.Windows.DependencyObject d, string title, string message)
		{
			if (!global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(d))
			{
				global::System.Windows.MessageBox.Show(message, title, global::System.Windows.MessageBoxButton.OK, global::System.Windows.MessageBoxImage.Exclamation);
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06001464 RID: 5220 RVA: 0x000490EC File Offset: 0x000472EC
		private static global::Infragistics.Windows.Licensing.LicenseOptions LicenseOptions
		{
			get
			{
				if (!global::Infragistics.Windows.Licensing.UltraLicenseProvider.licenseOptionsChecked)
				{
					try
					{
						global::Infragistics.Windows.Licensing.UltraLicenseProvider.licenseOptions = global::Infragistics.Windows.Licensing.LicenseOptions.Office2007UI;
					}
					finally
					{
						global::Infragistics.Windows.Licensing.UltraLicenseProvider.licenseOptionsChecked = true;
					}
				}
				return global::Infragistics.Windows.Licensing.UltraLicenseProvider.licenseOptions;
			}
		}

		// Token: 0x04000AC4 RID: 2756
		private static bool hasDisplayedRuntimeDemoMsg;

		// Token: 0x04000AC5 RID: 2757
		private static bool licenseOptionsChecked;

		// Token: 0x04000AC6 RID: 2758
		private static global::Infragistics.Windows.Licensing.LicenseOptions licenseOptions = global::Infragistics.Windows.Licensing.LicenseOptions.None;

		// Token: 0x04000AC7 RID: 2759
		[global::System.ThreadStatic]
		private static global::System.Collections.Generic.Dictionary<global::System.Type, string> LicenseKeys;

		// Token: 0x04000AC8 RID: 2760
		[global::System.ThreadStatic]
		private static global::System.Collections.Generic.Dictionary<global::System.Type, global::Infragistics.Windows.Licensing.UltraLicenseInfo> LicenseInfos;

		// Token: 0x0200021D RID: 541
		// (Invoke) Token: 0x06001468 RID: 5224
		private delegate void ShowMessageBoxDelegate(global::System.Windows.DependencyObject d, string title, string message);
	}
}
