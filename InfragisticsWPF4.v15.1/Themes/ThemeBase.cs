using System;
using System.Collections.Generic;

namespace Infragistics.Themes
{
	// Token: 0x020001C6 RID: 454
	public abstract class ThemeBase
	{
		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000F8B RID: 3979 RVA: 0x00033F84 File Offset: 0x00032184
		// (set) Token: 0x06000F8C RID: 3980 RVA: 0x00033F8C File Offset: 0x0003218C
		protected global::System.Collections.Generic.Dictionary<string, string> Mappings
		{
			get
			{
				return this._mappings;
			}
			set
			{
				this._mappings = value;
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000F8D RID: 3981 RVA: 0x00033F98 File Offset: 0x00032198
		internal global::System.Collections.Generic.Dictionary<string, string> MappingsSnapshot
		{
			get
			{
				if (!this._isInitialized)
				{
					this.Initialize();
				}
				global::System.Collections.Generic.Dictionary<string, string> result;
				if ((result = this._mappingsSnapshot) == null)
				{
					result = (this._mappingsSnapshot = new global::System.Collections.Generic.Dictionary<string, string>(this.Mappings));
				}
				return result;
			}
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x00033FD1 File Offset: 0x000321D1
		internal void Initialize()
		{
			this.ConfigureControlMappings();
			this._isInitialized = true;
		}

		// Token: 0x06000F8F RID: 3983
		protected abstract void ConfigureControlMappings();

		// Token: 0x06000F90 RID: 3984 RVA: 0x00033FE0 File Offset: 0x000321E0
		public static string BuildLocationString(string assemblyFullName, string relativeSource)
		{
			return string.Format("pack://application:,,,/{0};component/{1}", assemblyFullName, relativeSource);
		}

		// Token: 0x0400085A RID: 2138
		private global::System.Collections.Generic.Dictionary<string, string> _mappings = new global::System.Collections.Generic.Dictionary<string, string>();

		// Token: 0x0400085B RID: 2139
		private global::System.Collections.Generic.Dictionary<string, string> _mappingsSnapshot;

		// Token: 0x0400085C RID: 2140
		private bool _isInitialized;
	}
}
