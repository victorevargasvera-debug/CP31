using System;
using System.Windows;

namespace Infragistics
{
	// Token: 0x0200006E RID: 110
	public abstract class DependencyObjectRecyclingContainer<T> : global::Infragistics.DependencyObjectNotifier, global::Infragistics.ISupportRecycling where T : global::System.Windows.FrameworkElement
	{
		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000484 RID: 1156 RVA: 0x00011FBE File Offset: 0x000101BE
		protected virtual global::System.Type RecyclingElementType
		{
			get
			{
				return global::Infragistics.DependencyObjectRecyclingContainer<T>._recyclingElementType;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000485 RID: 1157 RVA: 0x00011FC5 File Offset: 0x000101C5
		protected virtual string RecyclingIdentifier
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000486 RID: 1158 RVA: 0x00011FC8 File Offset: 0x000101C8
		// (set) Token: 0x06000487 RID: 1159 RVA: 0x00011FD0 File Offset: 0x000101D0
		protected virtual bool IsDirty { get; set; }

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000488 RID: 1160 RVA: 0x00011FD9 File Offset: 0x000101D9
		// (set) Token: 0x06000489 RID: 1161 RVA: 0x00011FE1 File Offset: 0x000101E1
		protected global::System.Windows.FrameworkElement AttachedElement { get; set; }

		// Token: 0x0600048A RID: 1162
		protected abstract T CreateInstanceOfRecyclingElement();

		// Token: 0x0600048B RID: 1163 RVA: 0x00011FEA File Offset: 0x000101EA
		protected virtual void OnElementAttached(T element)
		{
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00011FEC File Offset: 0x000101EC
		protected virtual void OnElementReleased(T element)
		{
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00011FEE File Offset: 0x000101EE
		protected virtual bool OnElementReleasing(T element)
		{
			return true;
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600048E RID: 1166 RVA: 0x00011FF1 File Offset: 0x000101F1
		global::System.Type global::Infragistics.ISupportRecycling.RecyclingElementType
		{
			get
			{
				return this.RecyclingElementType;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600048F RID: 1167 RVA: 0x00011FF9 File Offset: 0x000101F9
		string global::Infragistics.ISupportRecycling.RecyclingIdentifier
		{
			get
			{
				return this.RecyclingIdentifier;
			}
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00012001 File Offset: 0x00010201
		global::System.Windows.FrameworkElement global::Infragistics.ISupportRecycling.CreateInstanceOfRecyclingElement()
		{
			return this.CreateInstanceOfRecyclingElement();
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x0001200E File Offset: 0x0001020E
		void global::Infragistics.ISupportRecycling.OnElementAttached(global::System.Windows.FrameworkElement elem)
		{
			this.OnElementAttached(elem as T);
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00012021 File Offset: 0x00010221
		bool global::Infragistics.ISupportRecycling.OnElementReleasing(global::System.Windows.FrameworkElement elem)
		{
			return this.OnElementReleasing(elem as T);
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00012034 File Offset: 0x00010234
		void global::Infragistics.ISupportRecycling.OnElementReleased(global::System.Windows.FrameworkElement elem)
		{
			this.OnElementReleased(elem as T);
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000494 RID: 1172 RVA: 0x00012047 File Offset: 0x00010247
		// (set) Token: 0x06000495 RID: 1173 RVA: 0x0001204F File Offset: 0x0001024F
		global::System.Windows.FrameworkElement global::Infragistics.ISupportRecycling.AttachedElement
		{
			get
			{
				return this.AttachedElement;
			}
			set
			{
				this.AttachedElement = value;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x00012058 File Offset: 0x00010258
		// (set) Token: 0x06000497 RID: 1175 RVA: 0x00012060 File Offset: 0x00010260
		bool global::Infragistics.ISupportRecycling.IsDirty
		{
			get
			{
				return this.IsDirty;
			}
			set
			{
				this.IsDirty = value;
			}
		}

		// Token: 0x04000178 RID: 376
		private static global::System.Type _recyclingElementType = typeof(T);
	}
}
