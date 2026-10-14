using System;
using System.Diagnostics;

namespace Infragistics
{
	// Token: 0x02000002 RID: 2
	[global::System.Diagnostics.Conditional("DEBUG")]
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly | global::System.AttributeTargets.Class | global::System.AttributeTargets.Struct | global::System.AttributeTargets.Enum | global::System.AttributeTargets.Constructor | global::System.AttributeTargets.Method | global::System.AttributeTargets.Property | global::System.AttributeTargets.Field | global::System.AttributeTargets.Event | global::System.AttributeTargets.Interface | global::System.AttributeTargets.Delegate, Inherited = false)]
	[global::System.Serializable]
	public class InfragisticsFeatureAttribute : global::System.Attribute
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x000020D8 File Offset: 0x000002D8
		// (set) Token: 0x06000003 RID: 3 RVA: 0x000020E0 File Offset: 0x000002E0
		public bool Exclude
		{
			get
			{
				return this.exclude;
			}
			set
			{
				this.exclude = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x000020E9 File Offset: 0x000002E9
		// (set) Token: 0x06000005 RID: 5 RVA: 0x000020F1 File Offset: 0x000002F1
		public string FeatureName
		{
			get
			{
				return this.featureName;
			}
			set
			{
				this.featureName = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000020FA File Offset: 0x000002FA
		// (set) Token: 0x06000007 RID: 7 RVA: 0x00002102 File Offset: 0x00000302
		public string SubFeatureName
		{
			get
			{
				return this.subfeatureName;
			}
			set
			{
				this.subfeatureName = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000008 RID: 8 RVA: 0x0000210B File Offset: 0x0000030B
		// (set) Token: 0x06000009 RID: 9 RVA: 0x00002113 File Offset: 0x00000313
		public string Version
		{
			get
			{
				return this.version;
			}
			set
			{
				this.version = value;
			}
		}

		// Token: 0x04000001 RID: 1
		private bool exclude;

		// Token: 0x04000002 RID: 2
		private string featureName;

		// Token: 0x04000003 RID: 3
		private string subfeatureName;

		// Token: 0x04000004 RID: 4
		private string version;
	}
}
