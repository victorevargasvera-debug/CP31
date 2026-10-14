using System;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;

namespace System.Data.Entity
{
	// Token: 0x0200005A RID: 90
	[global::System.AttributeUsage(global::System.AttributeTargets.Class, AllowMultiple = false)]
	public class DbConfigurationTypeAttribute : global::System.Attribute
	{
		// Token: 0x06000278 RID: 632 RVA: 0x00009156 File Offset: 0x00007356
		public DbConfigurationTypeAttribute(global::System.Type configurationType)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Type>(configurationType, "configurationType");
			this._configurationType = configurationType;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00009174 File Offset: 0x00007374
		public DbConfigurationTypeAttribute(string configurationTypeName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(configurationTypeName, "configurationTypeName");
			try
			{
				this._configurationType = global::System.Type.GetType(configurationTypeName, true);
			}
			catch (global::System.Exception innerException)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.DbConfigurationTypeInAttributeNotFound(configurationTypeName), innerException);
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600027A RID: 634 RVA: 0x000091C0 File Offset: 0x000073C0
		public global::System.Type ConfigurationType
		{
			get
			{
				return this._configurationType;
			}
		}

		// Token: 0x040000AF RID: 175
		private readonly global::System.Type _configurationType;
	}
}
