using System;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000261 RID: 609
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly, AllowMultiple = false)]
	public sealed class AssemblyThemeGroupingNameAttribute : global::System.Attribute
	{
		// Token: 0x06001833 RID: 6195 RVA: 0x0005C6E6 File Offset: 0x0005A8E6
		public AssemblyThemeGroupingNameAttribute(string name)
		{
			if (name == null)
			{
				throw new global::System.ArgumentNullException("name");
			}
			this._name = name;
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06001834 RID: 6196 RVA: 0x0005C703 File Offset: 0x0005A903
		public string Name
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x06001835 RID: 6197 RVA: 0x0005C70B File Offset: 0x0005A90B
		public override int GetHashCode()
		{
			return this._name.GetHashCode();
		}

		// Token: 0x06001836 RID: 6198 RVA: 0x0005C718 File Offset: 0x0005A918
		public override bool Equals(object obj)
		{
			global::Infragistics.Windows.Themes.AssemblyThemeGroupingNameAttribute assemblyThemeGroupingNameAttribute = obj as global::Infragistics.Windows.Themes.AssemblyThemeGroupingNameAttribute;
			return assemblyThemeGroupingNameAttribute != null && assemblyThemeGroupingNameAttribute._name == this._name;
		}

		// Token: 0x04000B89 RID: 2953
		private string _name;
	}
}
