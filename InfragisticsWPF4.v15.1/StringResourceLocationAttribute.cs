using System;
using System.Diagnostics.CodeAnalysis;

namespace Infragistics
{
	// Token: 0x020000EA RID: 234
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1813:AvoidUnsealedAttributes")]
	[global::System.AttributeUsage(global::System.AttributeTargets.Assembly)]
	public class StringResourceLocationAttribute : global::System.Attribute
	{
		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000857 RID: 2135 RVA: 0x0001D5BA File Offset: 0x0001B7BA
		// (set) Token: 0x06000858 RID: 2136 RVA: 0x0001D5C2 File Offset: 0x0001B7C2
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

		// Token: 0x06000859 RID: 2137 RVA: 0x0001D5CB File Offset: 0x0001B7CB
		public StringResourceLocationAttribute(string location)
		{
			this.Location = location;
		}

		// Token: 0x040003FD RID: 1021
		private string _Location;
	}
}
