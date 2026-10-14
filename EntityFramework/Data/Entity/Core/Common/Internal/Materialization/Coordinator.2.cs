using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects.Internal;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.Core.Common.Internal.Materialization
{
	// Token: 0x0200063B RID: 1595
	internal class Coordinator<T> : global::System.Data.Entity.Core.Common.Internal.Materialization.Coordinator
	{
		// Token: 0x17000EE2 RID: 3810
		// (get) Token: 0x06004CD7 RID: 19671 RVA: 0x0010E6DB File Offset: 0x0010C8DB
		internal virtual T Current
		{
			get
			{
				return this._current;
			}
		}

		// Token: 0x06004CD8 RID: 19672 RVA: 0x0010E6E4 File Offset: 0x0010C8E4
		internal Coordinator(global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory<T> coordinatorFactory, global::System.Data.Entity.Core.Common.Internal.Materialization.Coordinator parent, global::System.Data.Entity.Core.Common.Internal.Materialization.Coordinator next) : base(coordinatorFactory, parent, next)
		{
			this.TypedCoordinatorFactory = coordinatorFactory;
			global::System.Data.Entity.Core.Common.Internal.Materialization.Coordinator next2 = null;
			foreach (global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory coordinatorFactory2 in coordinatorFactory.NestedCoordinators.Reverse<global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory>())
			{
				base.Child = coordinatorFactory2.CreateCoordinator(this, next2);
				next2 = base.Child;
			}
			this.IsUsingElementCollection = (!base.IsRoot && typeof(T) != typeof(global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState));
		}

		// Token: 0x06004CD9 RID: 19673 RVA: 0x0010E780 File Offset: 0x0010C980
		internal override void ResetCollection(global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper shaper)
		{
			if (this._handleClose != null)
			{
				this._handleClose(shaper, this._wrappedElements);
				this._handleClose = null;
			}
			base.IsEntered = false;
			if (this.IsUsingElementCollection)
			{
				this._elements = this.TypedCoordinatorFactory.InitializeCollection(shaper);
				this._wrappedElements = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>();
			}
			if (base.Child != null)
			{
				base.Child.ResetCollection(shaper);
			}
			if (this.Next != null)
			{
				this.Next.ResetCollection(shaper);
			}
		}

		// Token: 0x06004CDA RID: 19674 RVA: 0x0010E808 File Offset: 0x0010CA08
		internal override void ReadNextElement(global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper shaper)
		{
			global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper entityWrapper = null;
			T t;
			try
			{
				if (this.TypedCoordinatorFactory.WrappedElement == null)
				{
					t = this.TypedCoordinatorFactory.Element(shaper);
				}
				else
				{
					entityWrapper = this.TypedCoordinatorFactory.WrappedElement(shaper);
					t = (T)((object)entityWrapper.Entity);
				}
			}
			catch (global::System.Exception e)
			{
				if (e.IsCatchableExceptionType() && !shaper.Reader.IsClosed)
				{
					this.ResetCollection(shaper);
					t = this.TypedCoordinatorFactory.ElementWithErrorHandling(shaper);
				}
				throw;
			}
			if (this.IsUsingElementCollection)
			{
				this._elements.Add(t);
				if (entityWrapper != null)
				{
					this._wrappedElements.Add(entityWrapper);
					return;
				}
			}
			else
			{
				this._current = t;
			}
		}

		// Token: 0x06004CDB RID: 19675 RVA: 0x0010E8C4 File Offset: 0x0010CAC4
		internal void RegisterCloseHandler(global::System.Action<global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>> closeHandler)
		{
			this._handleClose = closeHandler;
		}

		// Token: 0x06004CDC RID: 19676 RVA: 0x0010E8CD File Offset: 0x0010CACD
		internal void SetCurrentToDefault()
		{
			this._current = default(T);
		}

		// Token: 0x06004CDD RID: 19677 RVA: 0x0010E8DB File Offset: 0x0010CADB
		private global::System.Collections.Generic.IEnumerable<T> GetElements()
		{
			return this._elements;
		}

		// Token: 0x04001B3C RID: 6972
		internal readonly global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory<T> TypedCoordinatorFactory;

		// Token: 0x04001B3D RID: 6973
		private T _current;

		// Token: 0x04001B3E RID: 6974
		private global::System.Collections.Generic.ICollection<T> _elements;

		// Token: 0x04001B3F RID: 6975
		private global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper> _wrappedElements;

		// Token: 0x04001B40 RID: 6976
		private global::System.Action<global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper>> _handleClose;

		// Token: 0x04001B41 RID: 6977
		private readonly bool IsUsingElementCollection;
	}
}
