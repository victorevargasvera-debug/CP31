using System;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000299 RID: 665
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly, AllowMultiple = false)]
	public sealed class AssemblyResourceSetLoaderAttribute : global::System.Attribute
	{
		// Token: 0x06001A3F RID: 6719 RVA: 0x00063160 File Offset: 0x00061360
		public AssemblyResourceSetLoaderAttribute(global::System.Type assemblyResourceSetLoaderType)
		{
			if (null == assemblyResourceSetLoaderType)
			{
				throw new global::System.ArgumentNullException("assemblyResourceSetLoaderType");
			}
			if (!typeof(global::Infragistics.Windows.Themes.AssemblyResourceSetLoader).IsAssignableFrom(assemblyResourceSetLoaderType))
			{
				throw new global::System.ArgumentException(global::SR.GetString("LE_ArgumentException_5"));
			}
			this.resourceSetLoaderType = assemblyResourceSetLoaderType;
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06001A40 RID: 6720 RVA: 0x000631B0 File Offset: 0x000613B0
		public global::System.Type AssemblyResourceSetLoaderType
		{
			get
			{
				return this.resourceSetLoaderType;
			}
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x000631B8 File Offset: 0x000613B8
		public override int GetHashCode()
		{
			return this.resourceSetLoaderType.GetHashCode();
		}

		// Token: 0x06001A42 RID: 6722 RVA: 0x000631C8 File Offset: 0x000613C8
		public override bool Equals(object obj)
		{
			global::Infragistics.Windows.Themes.AssemblyResourceSetLoaderAttribute assemblyResourceSetLoaderAttribute = obj as global::Infragistics.Windows.Themes.AssemblyResourceSetLoaderAttribute;
			return assemblyResourceSetLoaderAttribute != null && assemblyResourceSetLoaderAttribute.AssemblyResourceSetLoaderType == this.resourceSetLoaderType;
		}

		// Token: 0x04000CED RID: 3309
		private global::System.Type resourceSetLoaderType;
	}
}
