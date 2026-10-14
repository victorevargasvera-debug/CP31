using System;
using System.Configuration;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Internal.ConfigFile
{
	// Token: 0x0200014E RID: 334
	internal class InterceptorElement : global::System.Configuration.ConfigurationElement
	{
		// Token: 0x0600159D RID: 5533 RVA: 0x00037573 File Offset: 0x00035773
		public InterceptorElement(int key)
		{
			this.Key = key;
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x0600159E RID: 5534 RVA: 0x00037582 File Offset: 0x00035782
		// (set) Token: 0x0600159F RID: 5535 RVA: 0x0003758A File Offset: 0x0003578A
		internal int Key { get; private set; }

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x060015A0 RID: 5536 RVA: 0x00037593 File Offset: 0x00035793
		// (set) Token: 0x060015A1 RID: 5537 RVA: 0x000375A5 File Offset: 0x000357A5
		[global::System.Configuration.ConfigurationProperty("type", IsRequired = true)]
		public virtual string TypeName
		{
			get
			{
				return (string)base["type"];
			}
			set
			{
				base["type"] = value;
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x060015A2 RID: 5538 RVA: 0x000375B3 File Offset: 0x000357B3
		[global::System.Configuration.ConfigurationProperty("parameters")]
		public virtual global::System.Data.Entity.Internal.ConfigFile.ParameterCollection Parameters
		{
			get
			{
				return (global::System.Data.Entity.Internal.ConfigFile.ParameterCollection)base["parameters"];
			}
		}

		// Token: 0x060015A3 RID: 5539 RVA: 0x000375C8 File Offset: 0x000357C8
		public virtual global::System.Data.Entity.Infrastructure.Interception.IDbInterceptor CreateInterceptor()
		{
			object obj;
			try
			{
				obj = global::System.Activator.CreateInstance(global::System.Type.GetType(this.TypeName, true), this.Parameters.GetTypedParameterValues());
			}
			catch (global::System.Exception innerException)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.InterceptorTypeNotFound(this.TypeName), innerException);
			}
			global::System.Data.Entity.Infrastructure.Interception.IDbInterceptor dbInterceptor = obj as global::System.Data.Entity.Infrastructure.Interception.IDbInterceptor;
			if (dbInterceptor == null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.InterceptorTypeNotInterceptor(this.TypeName));
			}
			return dbInterceptor;
		}

		// Token: 0x040009E4 RID: 2532
		private const string TypeKey = "type";

		// Token: 0x040009E5 RID: 2533
		private const string ParametersKey = "parameters";
	}
}
