using System;
using System.ComponentModel;

namespace Autofac.Builder
{
	// Token: 0x020000BD RID: 189
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public interface IHideObjectMembers
	{
		// Token: 0x06000438 RID: 1080
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		global::System.Type GetType();

		// Token: 0x06000439 RID: 1081
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		int GetHashCode();

		// Token: 0x0600043A RID: 1082
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		string ToString();

		// Token: 0x0600043B RID: 1083
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		bool Equals(object other);
	}
}
