using System;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200029A RID: 666
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly, AllowMultiple = false)]
	public sealed class AssemblyThemeGroupingNameAttribute : global::System.Attribute
	{
		// Token: 0x06001A43 RID: 6723 RVA: 0x000631F2 File Offset: 0x000613F2
		public AssemblyThemeGroupingNameAttribute(string name)
		{
			if (name == null)
			{
				throw new global::System.ArgumentNullException("name");
			}
			this._name = name;
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06001A44 RID: 6724 RVA: 0x0006320F File Offset: 0x0006140F
		public string Name
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x06001A45 RID: 6725 RVA: 0x00063217 File Offset: 0x00061417
		public override int GetHashCode()
		{
			return this._name.GetHashCode();
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x00063224 File Offset: 0x00061424
		public override bool Equals(object obj)
		{
			global::Infragistics.Windows.Themes.AssemblyThemeGroupingNameAttribute assemblyThemeGroupingNameAttribute = obj as global::Infragistics.Windows.Themes.AssemblyThemeGroupingNameAttribute;
			return assemblyThemeGroupingNameAttribute != null && assemblyThemeGroupingNameAttribute._name == this._name;
		}

		// Token: 0x04000CEE RID: 3310
		private string _name;
	}
}
