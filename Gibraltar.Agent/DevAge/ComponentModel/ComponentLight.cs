using System;
using System.ComponentModel;

namespace DevAge.ComponentModel
{
	// Token: 0x02000286 RID: 646
	[global::System.Serializable]
	internal class ComponentLight : global::System.ComponentModel.IComponent, global::System.IDisposable
	{
		// Token: 0x060020F3 RID: 8435 RVA: 0x00075F58 File Offset: 0x00074158
		public ComponentLight()
		{
		}

		// Token: 0x060020F4 RID: 8436 RVA: 0x00075F60 File Offset: 0x00074160
		public ComponentLight(global::DevAge.ComponentModel.ComponentLight other)
		{
		}

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x060020F5 RID: 8437 RVA: 0x00075F68 File Offset: 0x00074168
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::System.ComponentModel.IContainer Container
		{
			get
			{
				if (this.Site != null)
				{
					return this.Site.Container;
				}
				return null;
			}
		}

		// Token: 0x060020F6 RID: 8438 RVA: 0x00075F84 File Offset: 0x00074184
		protected virtual object GetService(global::System.Type service)
		{
			if (this.Site != null)
			{
				return this.Site.GetService(service);
			}
			return null;
		}

		// Token: 0x1400008F RID: 143
		// (add) Token: 0x060020F7 RID: 8439 RVA: 0x00075FA0 File Offset: 0x000741A0
		// (remove) Token: 0x060020F8 RID: 8440 RVA: 0x00075FBC File Offset: 0x000741BC
		public event global::System.EventHandler Disposed;

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x060020F9 RID: 8441 RVA: 0x00075FD8 File Offset: 0x000741D8
		// (set) Token: 0x060020FA RID: 8442 RVA: 0x00075FE0 File Offset: 0x000741E0
		[global::System.ComponentModel.DefaultValue(null)]
		[global::System.ComponentModel.Browsable(false)]
		public global::System.ComponentModel.ISite Site
		{
			get
			{
				return this.mSite;
			}
			set
			{
				this.mSite = value;
			}
		}

		// Token: 0x060020FB RID: 8443 RVA: 0x00075FEC File Offset: 0x000741EC
		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				if (disposing)
				{
					lock (this)
					{
						if (this.Site != null && this.Site.Container != null)
						{
							this.Site.Container.Remove(this);
						}
					}
					if (this.Disposed != null)
					{
						this.Disposed(this, global::System.EventArgs.Empty);
					}
				}
				this.disposed = true;
			}
		}

		// Token: 0x060020FC RID: 8444 RVA: 0x00076080 File Offset: 0x00074280
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x060020FD RID: 8445 RVA: 0x00076090 File Offset: 0x00074290
		~ComponentLight()
		{
			this.Dispose(false);
		}

		// Token: 0x04000C26 RID: 3110
		[global::System.NonSerialized]
		private global::System.ComponentModel.ISite mSite;

		// Token: 0x04000C27 RID: 3111
		private bool disposed;
	}
}
