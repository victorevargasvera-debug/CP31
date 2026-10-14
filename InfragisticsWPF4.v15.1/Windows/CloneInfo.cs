using System;
using System.Collections.Generic;
using System.Windows.Markup;

namespace Infragistics.Windows
{
	// Token: 0x020000B5 RID: 181
	internal class CloneInfo
	{
		// Token: 0x060006E4 RID: 1764 RVA: 0x000198EC File Offset: 0x00017AEC
		internal CloneInfo(object rootSource)
		{
			this._rootSource = rootSource;
			this._clonedObjects = new global::System.Collections.Generic.Dictionary<object, object>();
			this._serviceProvider = new global::System.Windows.Markup.XamlDesignerSerializationManager(null)
			{
				XamlWriterMode = global::System.Windows.Markup.XamlWriterMode.Expression
			};
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060006E5 RID: 1765 RVA: 0x00019926 File Offset: 0x00017B26
		public object RootSource
		{
			get
			{
				return this._rootSource;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060006E6 RID: 1766 RVA: 0x0001992E File Offset: 0x00017B2E
		public global::System.IServiceProvider ServiceProvider
		{
			get
			{
				return this._serviceProvider;
			}
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00019936 File Offset: 0x00017B36
		public bool TryGetClonedObject(object source, out object clone)
		{
			return this._clonedObjects.TryGetValue(source, out clone);
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x00019945 File Offset: 0x00017B45
		public void AddClone(object source, object clone)
		{
			this._clonedObjects.Add(source, clone);
		}

		// Token: 0x0400034F RID: 847
		private object _rootSource;

		// Token: 0x04000350 RID: 848
		private global::System.Collections.Generic.Dictionary<object, object> _clonedObjects;

		// Token: 0x04000351 RID: 849
		private global::System.IServiceProvider _serviceProvider;
	}
}
