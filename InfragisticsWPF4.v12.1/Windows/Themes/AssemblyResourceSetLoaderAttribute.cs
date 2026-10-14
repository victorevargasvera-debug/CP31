using System;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000260 RID: 608
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly, AllowMultiple = false)]
	public sealed class AssemblyResourceSetLoaderAttribute : global::System.Attribute
	{
		// Token: 0x0600182F RID: 6191 RVA: 0x0005C654 File Offset: 0x0005A854
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

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06001830 RID: 6192 RVA: 0x0005C6A4 File Offset: 0x0005A8A4
		public global::System.Type AssemblyResourceSetLoaderType
		{
			get
			{
				return this.resourceSetLoaderType;
			}
		}

		// Token: 0x06001831 RID: 6193 RVA: 0x0005C6AC File Offset: 0x0005A8AC
		public override int GetHashCode()
		{
			return this.resourceSetLoaderType.GetHashCode();
		}

		// Token: 0x06001832 RID: 6194 RVA: 0x0005C6BC File Offset: 0x0005A8BC
		public override bool Equals(object obj)
		{
			global::Infragistics.Windows.Themes.AssemblyResourceSetLoaderAttribute assemblyResourceSetLoaderAttribute = obj as global::Infragistics.Windows.Themes.AssemblyResourceSetLoaderAttribute;
			return assemblyResourceSetLoaderAttribute != null && assemblyResourceSetLoaderAttribute.AssemblyResourceSetLoaderType == this.resourceSetLoaderType;
		}

		// Token: 0x04000B88 RID: 2952
		private global::System.Type resourceSetLoaderType;
	}
}
