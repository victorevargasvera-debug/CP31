using System;
using System.Diagnostics.CodeAnalysis;

namespace Infragistics
{
	// Token: 0x020000CC RID: 204
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1813:AvoidUnsealedAttributes")]
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly)]
	public class StringResourceLocationAttribute : global::System.Attribute
	{
		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000758 RID: 1880 RVA: 0x00019A0E File Offset: 0x00017C0E
		// (set) Token: 0x06000759 RID: 1881 RVA: 0x00019A16 File Offset: 0x00017C16
		public virtual string Location
		{
			get
			{
				return this._Location;
			}
			private set
			{
				this._Location = value;
			}
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x00019A1F File Offset: 0x00017C1F
		public StringResourceLocationAttribute(string location)
		{
			this.Location = location;
		}

		// Token: 0x0400034B RID: 843
		private string _Location;
	}
}
