using System;

namespace Gibraltar.Agent.Metrics
{
	// Token: 0x0200001B RID: 27
	[global::System.AttributeUsage(global::System.AttributeTargets.Class | global::System.AttributeTargets.Struct | global::System.AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
	[global::System.Serializable]
	internal sealed class EventMetricDefaultColumnAttribute : global::System.Attribute
	{
		// Token: 0x060001A4 RID: 420 RVA: 0x00005CD8 File Offset: 0x00003ED8
		public EventMetricDefaultColumnAttribute(string columnName)
		{
			this.m_ColumnName = (string.IsNullOrEmpty(columnName) ? columnName : columnName.Trim());
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x00005D00 File Offset: 0x00003F00
		public string ColumnName
		{
			get
			{
				return this.m_ColumnName;
			}
		}

		// Token: 0x04000063 RID: 99
		private readonly string m_ColumnName;
	}
}
