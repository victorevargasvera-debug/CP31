using System;
using System.Collections.Generic;
using System.Windows.Markup;

namespace Infragistics.Windows
{
	// Token: 0x0200009B RID: 155
	internal class CloneInfo
	{
		// Token: 0x06000600 RID: 1536 RVA: 0x000161CC File Offset: 0x000143CC
		internal CloneInfo(object rootSource)
		{
			this._rootSource = rootSource;
			this._clonedObjects = new global::System.Collections.Generic.Dictionary<object, object>();
			this._serviceProvider = new global::System.Windows.Markup.XamlDesignerSerializationManager(null)
			{
				XamlWriterMode = global::System.Windows.Markup.XamlWriterMode.Expression
			};
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000601 RID: 1537 RVA: 0x00016206 File Offset: 0x00014406
		public object RootSource
		{
			get
			{
				return this._rootSource;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000602 RID: 1538 RVA: 0x0001620E File Offset: 0x0001440E
		public global::System.IServiceProvider ServiceProvider
		{
			get
			{
				return this._serviceProvider;
			}
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00016216 File Offset: 0x00014416
		public bool TryGetClonedObject(object source, out object clone)
		{
			return this._clonedObjects.TryGetValue(source, out clone);
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00016225 File Offset: 0x00014425
		public void AddClone(object source, object clone)
		{
			this._clonedObjects.Add(source, clone);
		}

		// Token: 0x040002C8 RID: 712
		private object _rootSource;

		// Token: 0x040002C9 RID: 713
		private global::System.Collections.Generic.Dictionary<object, object> _clonedObjects;

		// Token: 0x040002CA RID: 714
		private global::System.IServiceProvider _serviceProvider;
	}
}
