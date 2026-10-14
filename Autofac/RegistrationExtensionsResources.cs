using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Autofac
{
	// Token: 0x02000013 RID: 19
	[global::System.Diagnostics.DebuggerNonUserCode]
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	public class RegistrationExtensionsResources
	{
		// Token: 0x0600009C RID: 156 RVA: 0x00003D2B File Offset: 0x00001F2B
		internal RegistrationExtensionsResources()
		{
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00003D33 File Offset: 0x00001F33
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public static global::System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (global::Autofac.RegistrationExtensionsResources.resourceMan == null)
				{
					global::Autofac.RegistrationExtensionsResources.resourceMan = new global::System.Resources.ResourceManager("Autofac.RegistrationExtensionsResources", typeof(global::Autofac.RegistrationExtensionsResources).GetTypeInfo().Assembly);
				}
				return global::Autofac.RegistrationExtensionsResources.resourceMan;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00003D64 File Offset: 0x00001F64
		// (set) Token: 0x0600009F RID: 159 RVA: 0x00003D6B File Offset: 0x00001F6B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public static global::System.Globalization.CultureInfo Culture
		{
			get
			{
				return global::Autofac.RegistrationExtensionsResources.resourceCulture;
			}
			set
			{
				global::Autofac.RegistrationExtensionsResources.resourceCulture = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00003D73 File Offset: 0x00001F73
		public static string InstanceRegistrationsAreSingleInstanceOnly
		{
			get
			{
				return global::Autofac.RegistrationExtensionsResources.ResourceManager.GetString("InstanceRegistrationsAreSingleInstanceOnly", global::Autofac.RegistrationExtensionsResources.resourceCulture);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00003D89 File Offset: 0x00001F89
		public static string MetadataAttributeNotFound
		{
			get
			{
				return global::Autofac.RegistrationExtensionsResources.ResourceManager.GetString("MetadataAttributeNotFound", global::Autofac.RegistrationExtensionsResources.resourceCulture);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00003D9F File Offset: 0x00001F9F
		public static string MultipleMetadataAttributesSameType
		{
			get
			{
				return global::Autofac.RegistrationExtensionsResources.ResourceManager.GetString("MultipleMetadataAttributesSameType", global::Autofac.RegistrationExtensionsResources.resourceCulture);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00003DB5 File Offset: 0x00001FB5
		public static string NoMatchingConstructorExists
		{
			get
			{
				return global::Autofac.RegistrationExtensionsResources.ResourceManager.GetString("NoMatchingConstructorExists", global::Autofac.RegistrationExtensionsResources.resourceCulture);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00003DCB File Offset: 0x00001FCB
		public static string OnlyIfRequiresCallbackContainer
		{
			get
			{
				return global::Autofac.RegistrationExtensionsResources.ResourceManager.GetString("OnlyIfRequiresCallbackContainer", global::Autofac.RegistrationExtensionsResources.resourceCulture);
			}
		}

		// Token: 0x04000015 RID: 21
		private static global::System.Resources.ResourceManager resourceMan;

		// Token: 0x04000016 RID: 22
		private static global::System.Globalization.CultureInfo resourceCulture;
	}
}
