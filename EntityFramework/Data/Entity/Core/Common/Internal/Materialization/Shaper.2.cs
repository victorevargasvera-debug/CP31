using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Internal;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Core.Common.Internal.Materialization
{
	// Token: 0x02000642 RID: 1602
	internal class Shaper<T> : global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper
	{
		// Token: 0x06004D34 RID: 19764 RVA: 0x0010FBA4 File Offset: 0x0010DDA4
		internal Shaper(global::System.Data.Common.DbDataReader reader, global::System.Data.Entity.Core.Objects.ObjectContext context, global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace workspace, global::System.Data.Entity.Core.Objects.MergeOption mergeOption, int stateCount, global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory<T> rootCoordinatorFactory, bool readerOwned, bool streaming) : base(reader, context, workspace, mergeOption, stateCount, streaming)
		{
			this.RootCoordinator = (global::System.Data.Entity.Core.Common.Internal.Materialization.Coordinator<T>)rootCoordinatorFactory.CreateCoordinator(null, null);
			this._isObjectQuery = !(typeof(T) == typeof(global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState));
			this._isActive = true;
			this.RootCoordinator.Initialize(this);
			this._readerOwned = readerOwned;
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06004D35 RID: 19765 RVA: 0x0010FC14 File Offset: 0x0010DE14
		// (remove) Token: 0x06004D36 RID: 19766 RVA: 0x0010FC4C File Offset: 0x0010DE4C
		internal event global::System.EventHandler OnDone;

		// Token: 0x17000EEE RID: 3822
		// (get) Token: 0x06004D37 RID: 19767 RVA: 0x0010FC81 File Offset: 0x0010DE81
		// (set) Token: 0x06004D38 RID: 19768 RVA: 0x0010FC89 File Offset: 0x0010DE89
		internal bool DataWaiting { get; set; }

		// Token: 0x17000EEF RID: 3823
		// (get) Token: 0x06004D39 RID: 19769 RVA: 0x0010FC92 File Offset: 0x0010DE92
		internal global::System.Data.Entity.Internal.IDbEnumerator<T> RootEnumerator
		{
			get
			{
				if (this._rootEnumerator == null)
				{
					this.InitializeRecordStates(this.RootCoordinator.CoordinatorFactory);
					this._rootEnumerator = this.GetEnumerator();
				}
				return this._rootEnumerator;
			}
		}

		// Token: 0x06004D3A RID: 19770 RVA: 0x0010FCC0 File Offset: 0x0010DEC0
		private void InitializeRecordStates(global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory coordinatorFactory)
		{
			foreach (global::System.Data.Entity.Core.Common.Internal.Materialization.RecordStateFactory recordStateFactory in coordinatorFactory.RecordStateFactories)
			{
				this.State[recordStateFactory.StateSlotNumber] = recordStateFactory.Create(coordinatorFactory);
			}
			foreach (global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory coordinatorFactory2 in coordinatorFactory.NestedCoordinators)
			{
				this.InitializeRecordStates(coordinatorFactory2);
			}
		}

		// Token: 0x06004D3B RID: 19771 RVA: 0x0010FD58 File Offset: 0x0010DF58
		public virtual global::System.Data.Entity.Internal.IDbEnumerator<T> GetEnumerator()
		{
			if (this.RootCoordinator.CoordinatorFactory.IsSimple)
			{
				return new global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<T>.SimpleEnumerator(this);
			}
			global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<T>.RowNestedResultEnumerator rowEnumerator = new global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<T>.RowNestedResultEnumerator(this);
			if (this._isObjectQuery)
			{
				return new global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<T>.ObjectQueryNestedEnumerator(rowEnumerator);
			}
			return (global::System.Data.Entity.Internal.IDbEnumerator<T>)new global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<T>.RecordStateEnumerator(rowEnumerator);
		}

		// Token: 0x06004D3C RID: 19772 RVA: 0x0010FDA0 File Offset: 0x0010DFA0
		private void Finally()
		{
			if (this._isActive)
			{
				this._isActive = false;
				if (this._readerOwned)
				{
					if (this._isObjectQuery)
					{
						this.Reader.Dispose();
					}
					if (this.Context != null && this.Streaming)
					{
						this.Context.ReleaseConnection();
					}
				}
				if (this.OnDone != null)
				{
					this.OnDone(this, new global::System.EventArgs());
				}
			}
		}

		// Token: 0x06004D3D RID: 19773 RVA: 0x0010FE0C File Offset: 0x0010E00C
		private bool StoreRead()
		{
			bool result;
			try
			{
				result = this.Reader.Read();
			}
			catch (global::System.Exception e)
			{
				this.HandleReaderException(e);
				throw;
			}
			return result;
		}

		// Token: 0x06004D3E RID: 19774 RVA: 0x0010FE44 File Offset: 0x0010E044
		private async global::System.Threading.Tasks.Task<bool> StoreReadAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			bool result;
			try
			{
				result = await this.Reader.ReadAsync(cancellationToken).WithCurrentCulture<bool>();
			}
			catch (global::System.Exception e)
			{
				this.HandleReaderException(e);
				throw;
			}
			return result;
		}

		// Token: 0x06004D3F RID: 19775 RVA: 0x0010FE91 File Offset: 0x0010E091
		private void HandleReaderException(global::System.Exception e)
		{
			if (!e.IsCatchableEntityExceptionType())
			{
				return;
			}
			if (this.Reader.IsClosed)
			{
				throw new global::System.Data.Entity.Core.EntityCommandExecutionException(global::System.Data.Entity.Resources.Strings.ADP_DataReaderClosed("Read"), e);
			}
			throw new global::System.Data.Entity.Core.EntityCommandExecutionException(global::System.Data.Entity.Resources.Strings.EntityClient_StoreReaderFailed, e);
		}

		// Token: 0x06004D40 RID: 19776 RVA: 0x0010FEC5 File Offset: 0x0010E0C5
		private void StartMaterializingElement()
		{
			if (this.Context != null)
			{
				this.Context.InMaterialization = true;
				base.InitializeForOnMaterialize();
			}
		}

		// Token: 0x06004D41 RID: 19777 RVA: 0x0010FEE1 File Offset: 0x0010E0E1
		private void StopMaterializingElement()
		{
			if (this.Context != null)
			{
				this.Context.InMaterialization = false;
				base.RaiseMaterializedEvents();
			}
		}

		// Token: 0x04001B69 RID: 7017
		private readonly bool _isObjectQuery;

		// Token: 0x04001B6A RID: 7018
		private bool _isActive;

		// Token: 0x04001B6B RID: 7019
		private global::System.Data.Entity.Internal.IDbEnumerator<T> _rootEnumerator;

		// Token: 0x04001B6C RID: 7020
		private readonly bool _readerOwned;

		// Token: 0x04001B6F RID: 7023
		internal readonly global::System.Data.Entity.Core.Common.Internal.Materialization.Coordinator<T> RootCoordinator;

		// Token: 0x02000C65 RID: 3173
		private class SimpleEnumerator : global::System.Data.Entity.Internal.IDbEnumerator<T>, global::System.Collections.Generic.IEnumerator<!0>, global::System.IDisposable, global::System.Collections.IEnumerator, global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<T>, global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator
		{
			// Token: 0x06006AF4 RID: 27380 RVA: 0x0016C302 File Offset: 0x0016A502
			internal SimpleEnumerator(global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<T> shaper)
			{
				this._shaper = shaper;
			}

			// Token: 0x17001182 RID: 4482
			// (get) Token: 0x06006AF5 RID: 27381 RVA: 0x0016C311 File Offset: 0x0016A511
			public T Current
			{
				get
				{
					return this._shaper.RootCoordinator.Current;
				}
			}

			// Token: 0x17001183 RID: 4483
			// (get) Token: 0x06006AF6 RID: 27382 RVA: 0x0016C323 File Offset: 0x0016A523
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this._shaper.RootCoordinator.Current;
				}
			}

			// Token: 0x17001184 RID: 4484
			// (get) Token: 0x06006AF7 RID: 27383 RVA: 0x0016C33A File Offset: 0x0016A53A
			object global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator.Current
			{
				get
				{
					return this._shaper.RootCoordinator.Current;
				}
			}

			// Token: 0x06006AF8 RID: 27384 RVA: 0x0016C351 File Offset: 0x0016A551
			public void Dispose()
			{
				global::System.GC.SuppressFinalize(this);
				this._shaper.RootCoordinator.SetCurrentToDefault();
				this._shaper.Finally();
			}

			// Token: 0x06006AF9 RID: 27385 RVA: 0x0016C374 File Offset: 0x0016A574
			public bool MoveNext()
			{
				if (!this._shaper._isActive)
				{
					return false;
				}
				if (this._shaper.StoreRead())
				{
					try
					{
						this._shaper.StartMaterializingElement();
						this._shaper.RootCoordinator.ReadNextElement(this._shaper);
					}
					finally
					{
						this._shaper.StopMaterializingElement();
					}
					return true;
				}
				this.Dispose();
				return false;
			}

			// Token: 0x06006AFA RID: 27386 RVA: 0x0016C3E8 File Offset: 0x0016A5E8
			public async global::System.Threading.Tasks.Task<bool> MoveNextAsync(global::System.Threading.CancellationToken cancellationToken)
			{
				bool result;
				if (!this._shaper._isActive)
				{
					result = false;
				}
				else
				{
					cancellationToken.ThrowIfCancellationRequested();
					global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = this._shaper.StoreReadAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
					if (!cultureAwaiter.IsCompleted)
					{
						await cultureAwaiter;
						global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
						cultureAwaiter = cultureAwaiter2;
						cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
					}
					if (cultureAwaiter.GetResult())
					{
						try
						{
							this._shaper.StartMaterializingElement();
							this._shaper.RootCoordinator.ReadNextElement(this._shaper);
						}
						finally
						{
							this._shaper.StopMaterializingElement();
						}
						result = true;
					}
					else
					{
						this.Dispose();
						result = false;
					}
				}
				return result;
			}

			// Token: 0x06006AFB RID: 27387 RVA: 0x0016C435 File Offset: 0x0016A635
			public void Reset()
			{
				throw new global::System.NotSupportedException();
			}

			// Token: 0x04003101 RID: 12545
			private readonly global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<T> _shaper;
		}

		// Token: 0x02000C66 RID: 3174
		private class RowNestedResultEnumerator : global::System.Data.Entity.Internal.IDbEnumerator<global::System.Data.Entity.Core.Common.Internal.Materialization.Coordinator[]>, global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Common.Internal.Materialization.Coordinator[]>, global::System.IDisposable, global::System.Collections.IEnumerator, global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<global::System.Data.Entity.Core.Common.Internal.Materialization.Coordinator[]>, global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator
		{
			// Token: 0x06006AFC RID: 27388 RVA: 0x0016C43C File Offset: 0x0016A63C
			internal RowNestedResultEnumerator(global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<T> shaper)
			{
				this._shaper = shaper;
				this._current = new global::System.Data.Entity.Core.Common.Internal.Materialization.Coordinator[this._shaper.RootCoordinator.MaxDistanceToLeaf() + 1];
			}

			// Token: 0x17001185 RID: 4485
			// (get) Token: 0x06006AFD RID: 27389 RVA: 0x0016C468 File Offset: 0x0016A668
			public global::System.Data.Entity.Core.Common.Internal.Materialization.Coordinator[] Current
			{
				get
				{
					return this._current;
				}
			}

			// Token: 0x17001186 RID: 4486
			// (get) Token: 0x06006AFE RID: 27390 RVA: 0x0016C470 File Offset: 0x0016A670
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this._current;
				}
			}

			// Token: 0x17001187 RID: 4487
			// (get) Token: 0x06006AFF RID: 27391 RVA: 0x0016C478 File Offset: 0x0016A678
			object global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator.Current
			{
				get
				{
					return this._current;
				}
			}

			// Token: 0x06006B00 RID: 27392 RVA: 0x0016C480 File Offset: 0x0016A680
			public void Dispose()
			{
				global::System.GC.SuppressFinalize(this);
				this._shaper.Finally();
			}

			// Token: 0x06006B01 RID: 27393 RVA: 0x0016C494 File Offset: 0x0016A694
			public bool MoveNext()
			{
				try
				{
					this._shaper.StartMaterializingElement();
					if (!this._shaper.StoreRead())
					{
						this.RootCoordinator.ResetCollection(this._shaper);
						return false;
					}
					this.MaterializeRow();
				}
				finally
				{
					this._shaper.StopMaterializingElement();
				}
				return true;
			}

			// Token: 0x06006B02 RID: 27394 RVA: 0x0016C4F8 File Offset: 0x0016A6F8
			public async global::System.Threading.Tasks.Task<bool> MoveNextAsync(global::System.Threading.CancellationToken cancellationToken)
			{
				try
				{
					this._shaper.StartMaterializingElement();
					global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = this._shaper.StoreReadAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
					if (!cultureAwaiter.IsCompleted)
					{
						await cultureAwaiter;
						global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
						cultureAwaiter = cultureAwaiter2;
						cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
					}
					if (!cultureAwaiter.GetResult())
					{
						this.RootCoordinator.ResetCollection(this._shaper);
						return false;
					}
					this.MaterializeRow();
				}
				finally
				{
					this._shaper.StopMaterializingElement();
				}
				return true;
			}

			// Token: 0x06006B03 RID: 27395 RVA: 0x0016C548 File Offset: 0x0016A748
			private void MaterializeRow()
			{
				global::System.Data.Entity.Core.Common.Internal.Materialization.Coordinator coordinator = this._shaper.RootCoordinator;
				int i = 0;
				bool flag = false;
				while (i < this._current.Length)
				{
					while (coordinator != null && !coordinator.CoordinatorFactory.HasData(this._shaper))
					{
						coordinator = coordinator.Next;
					}
					if (coordinator == null)
					{
						IL_A8:
						while (i < this._current.Length)
						{
							this._current[i] = null;
							i++;
						}
						return;
					}
					if (coordinator.HasNextElement(this._shaper))
					{
						if (!flag && coordinator.Child != null)
						{
							coordinator.Child.ResetCollection(this._shaper);
						}
						flag = true;
						coordinator.ReadNextElement(this._shaper);
						this._current[i] = coordinator;
					}
					else
					{
						this._current[i] = null;
					}
					coordinator = coordinator.Child;
					i++;
				}
				goto IL_A8;
			}

			// Token: 0x06006B04 RID: 27396 RVA: 0x0016C608 File Offset: 0x0016A808
			public void Reset()
			{
				throw new global::System.NotSupportedException();
			}

			// Token: 0x17001188 RID: 4488
			// (get) Token: 0x06006B05 RID: 27397 RVA: 0x0016C60F File Offset: 0x0016A80F
			internal global::System.Data.Entity.Core.Common.Internal.Materialization.Coordinator<T> RootCoordinator
			{
				get
				{
					return this._shaper.RootCoordinator;
				}
			}

			// Token: 0x04003102 RID: 12546
			private readonly global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<T> _shaper;

			// Token: 0x04003103 RID: 12547
			private readonly global::System.Data.Entity.Core.Common.Internal.Materialization.Coordinator[] _current;
		}

		// Token: 0x02000C67 RID: 3175
		private class ObjectQueryNestedEnumerator : global::System.Data.Entity.Internal.IDbEnumerator<T>, global::System.Collections.Generic.IEnumerator<!0>, global::System.IDisposable, global::System.Collections.IEnumerator, global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<T>, global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator
		{
			// Token: 0x06006B06 RID: 27398 RVA: 0x0016C61C File Offset: 0x0016A81C
			internal ObjectQueryNestedEnumerator(global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<T>.RowNestedResultEnumerator rowEnumerator)
			{
				this._rowEnumerator = rowEnumerator;
				this._previousElement = default(T);
				this._state = global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<T>.ObjectQueryNestedEnumerator.State.Start;
			}

			// Token: 0x17001189 RID: 4489
			// (get) Token: 0x06006B07 RID: 27399 RVA: 0x0016C63E File Offset: 0x0016A83E
			public T Current
			{
				get
				{
					return this._previousElement;
				}
			}

			// Token: 0x1700118A RID: 4490
			// (get) Token: 0x06006B08 RID: 27400 RVA: 0x0016C646 File Offset: 0x0016A846
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x1700118B RID: 4491
			// (get) Token: 0x06006B09 RID: 27401 RVA: 0x0016C653 File Offset: 0x0016A853
			object global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x06006B0A RID: 27402 RVA: 0x0016C660 File Offset: 0x0016A860
			public void Dispose()
			{
				global::System.GC.SuppressFinalize(this);
				this._rowEnumerator.Dispose();
			}

			// Token: 0x06006B0B RID: 27403 RVA: 0x0016C674 File Offset: 0x0016A874
			public bool MoveNext()
			{
				switch (this._state)
				{
				case global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<T>.ObjectQueryNestedEnumerator.State.Start:
					if (this.TryReadToNextElement())
					{
						this.ReadElement();
					}
					else
					{
						this._state = global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<T>.ObjectQueryNestedEnumerator.State.NoRows;
					}
					break;
				case global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<T>.ObjectQueryNestedEnumerator.State.Reading:
					this.ReadElement();
					break;
				case global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<T>.ObjectQueryNestedEnumerator.State.NoRowsLastElementPending:
					this._state = global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<T>.ObjectQueryNestedEnumerator.State.NoRows;
					break;
				}
				bool result;
				if (this._state == global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<T>.ObjectQueryNestedEnumerator.State.NoRows)
				{
					this._previousElement = default(T);
					result = false;
				}
				else
				{
					result = true;
				}
				return result;
			}

			// Token: 0x06006B0C RID: 27404 RVA: 0x0016C6E0 File Offset: 0x0016A8E0
			public async global::System.Threading.Tasks.Task<bool> MoveNextAsync(global::System.Threading.CancellationToken cancellationToken)
			{
				cancellationToken.ThrowIfCancellationRequested();
				switch (this._state)
				{
				case global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<T>.ObjectQueryNestedEnumerator.State.Start:
				{
					global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = this.TryReadToNextElementAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
					if (!cultureAwaiter.IsCompleted)
					{
						await cultureAwaiter;
						global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
						cultureAwaiter = cultureAwaiter2;
						cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
					}
					if (cultureAwaiter.GetResult())
					{
						await this.ReadElementAsync(cancellationToken).WithCurrentCulture();
					}
					else
					{
						this._state = global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<T>.ObjectQueryNestedEnumerator.State.NoRows;
					}
					break;
				}
				case global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<T>.ObjectQueryNestedEnumerator.State.Reading:
					await this.ReadElementAsync(cancellationToken).WithCurrentCulture();
					break;
				case global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<T>.ObjectQueryNestedEnumerator.State.NoRowsLastElementPending:
					this._state = global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<T>.ObjectQueryNestedEnumerator.State.NoRows;
					break;
				}
				bool result;
				if (this._state == global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<T>.ObjectQueryNestedEnumerator.State.NoRows)
				{
					this._previousElement = default(T);
					result = false;
				}
				else
				{
					result = true;
				}
				return result;
			}

			// Token: 0x06006B0D RID: 27405 RVA: 0x0016C72D File Offset: 0x0016A92D
			private void ReadElement()
			{
				this._previousElement = this._rowEnumerator.RootCoordinator.Current;
				if (this.TryReadToNextElement())
				{
					this._state = global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<T>.ObjectQueryNestedEnumerator.State.Reading;
					return;
				}
				this._state = global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<T>.ObjectQueryNestedEnumerator.State.NoRowsLastElementPending;
			}

			// Token: 0x06006B0E RID: 27406 RVA: 0x0016C75C File Offset: 0x0016A95C
			private async global::System.Threading.Tasks.Task ReadElementAsync(global::System.Threading.CancellationToken cancellationToken)
			{
				this._previousElement = this._rowEnumerator.RootCoordinator.Current;
				global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = this.TryReadToNextElementAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
				if (!cultureAwaiter.IsCompleted)
				{
					await cultureAwaiter;
					global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
					cultureAwaiter = cultureAwaiter2;
					cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
				}
				if (cultureAwaiter.GetResult())
				{
					this._state = global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<T>.ObjectQueryNestedEnumerator.State.Reading;
				}
				else
				{
					this._state = global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<T>.ObjectQueryNestedEnumerator.State.NoRowsLastElementPending;
				}
			}

			// Token: 0x06006B0F RID: 27407 RVA: 0x0016C7A9 File Offset: 0x0016A9A9
			private bool TryReadToNextElement()
			{
				while (this._rowEnumerator.MoveNext())
				{
					if (this._rowEnumerator.Current[0] != null)
					{
						return true;
					}
				}
				return false;
			}

			// Token: 0x06006B10 RID: 27408 RVA: 0x0016C7CC File Offset: 0x0016A9CC
			private async global::System.Threading.Tasks.Task<bool> TryReadToNextElementAsync(global::System.Threading.CancellationToken cancellationToken)
			{
				do
				{
					global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = this._rowEnumerator.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
					if (!cultureAwaiter.IsCompleted)
					{
						await cultureAwaiter;
						global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
						cultureAwaiter = cultureAwaiter2;
						cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
					}
					if (!cultureAwaiter.GetResult())
					{
						goto Block_3;
					}
				}
				while (this._rowEnumerator.Current[0] == null);
				return true;
				Block_3:
				return false;
			}

			// Token: 0x06006B11 RID: 27409 RVA: 0x0016C819 File Offset: 0x0016AA19
			public void Reset()
			{
				this._rowEnumerator.Reset();
			}

			// Token: 0x04003104 RID: 12548
			private readonly global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<T>.RowNestedResultEnumerator _rowEnumerator;

			// Token: 0x04003105 RID: 12549
			private T _previousElement;

			// Token: 0x04003106 RID: 12550
			private global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<T>.ObjectQueryNestedEnumerator.State _state;

			// Token: 0x02000D98 RID: 3480
			private enum State
			{
				// Token: 0x040033B8 RID: 13240
				Start,
				// Token: 0x040033B9 RID: 13241
				Reading,
				// Token: 0x040033BA RID: 13242
				NoRowsLastElementPending,
				// Token: 0x040033BB RID: 13243
				NoRows
			}
		}

		// Token: 0x02000C68 RID: 3176
		private class RecordStateEnumerator : global::System.Data.Entity.Internal.IDbEnumerator<global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState>, global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState>, global::System.IDisposable, global::System.Collections.IEnumerator, global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState>, global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator
		{
			// Token: 0x06006B12 RID: 27410 RVA: 0x0016C826 File Offset: 0x0016AA26
			internal RecordStateEnumerator(global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<T>.RowNestedResultEnumerator rowEnumerator)
			{
				this._rowEnumerator = rowEnumerator;
				this._current = null;
				this._depth = -1;
				this._readerConsumed = false;
			}

			// Token: 0x1700118C RID: 4492
			// (get) Token: 0x06006B13 RID: 27411 RVA: 0x0016C84A File Offset: 0x0016AA4A
			public global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState Current
			{
				get
				{
					return this._current;
				}
			}

			// Token: 0x1700118D RID: 4493
			// (get) Token: 0x06006B14 RID: 27412 RVA: 0x0016C852 File Offset: 0x0016AA52
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this._current;
				}
			}

			// Token: 0x1700118E RID: 4494
			// (get) Token: 0x06006B15 RID: 27413 RVA: 0x0016C85A File Offset: 0x0016AA5A
			object global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator.Current
			{
				get
				{
					return this._current;
				}
			}

			// Token: 0x06006B16 RID: 27414 RVA: 0x0016C862 File Offset: 0x0016AA62
			public void Dispose()
			{
				global::System.GC.SuppressFinalize(this);
				this._rowEnumerator.Dispose();
			}

			// Token: 0x06006B17 RID: 27415 RVA: 0x0016C878 File Offset: 0x0016AA78
			public bool MoveNext()
			{
				if (!this._readerConsumed)
				{
					global::System.Data.Entity.Core.Common.Internal.Materialization.Coordinator coordinator;
					for (;;)
					{
						if (-1 == this._depth || this._rowEnumerator.Current.Length == this._depth)
						{
							if (!this._rowEnumerator.MoveNext())
							{
								break;
							}
							this._depth = 0;
						}
						coordinator = this._rowEnumerator.Current[this._depth];
						if (coordinator != null)
						{
							goto Block_3;
						}
						this._depth++;
					}
					this._current = null;
					this._readerConsumed = true;
					goto IL_97;
					Block_3:
					this._current = ((global::System.Data.Entity.Core.Common.Internal.Materialization.Coordinator<global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState>)coordinator).Current;
					this._depth++;
				}
				IL_97:
				return !this._readerConsumed;
			}

			// Token: 0x06006B18 RID: 27416 RVA: 0x0016C928 File Offset: 0x0016AB28
			public async global::System.Threading.Tasks.Task<bool> MoveNextAsync(global::System.Threading.CancellationToken cancellationToken)
			{
				if (!this._readerConsumed)
				{
					cancellationToken.ThrowIfCancellationRequested();
					global::System.Data.Entity.Core.Common.Internal.Materialization.Coordinator coordinator;
					for (;;)
					{
						if (-1 == this._depth || this._rowEnumerator.Current.Length == this._depth)
						{
							global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = this._rowEnumerator.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
							if (!cultureAwaiter.IsCompleted)
							{
								await cultureAwaiter;
								global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
								cultureAwaiter = cultureAwaiter2;
								cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
							}
							if (!cultureAwaiter.GetResult())
							{
								break;
							}
							this._depth = 0;
						}
						coordinator = this._rowEnumerator.Current[this._depth];
						if (coordinator != null)
						{
							goto Block_5;
						}
						this._depth++;
					}
					this._current = null;
					this._readerConsumed = true;
					goto IL_120;
					Block_5:
					this._current = ((global::System.Data.Entity.Core.Common.Internal.Materialization.Coordinator<global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState>)coordinator).Current;
					this._depth++;
				}
				IL_120:
				return !this._readerConsumed;
			}

			// Token: 0x06006B19 RID: 27417 RVA: 0x0016C975 File Offset: 0x0016AB75
			public void Reset()
			{
				this._rowEnumerator.Reset();
			}

			// Token: 0x04003107 RID: 12551
			private readonly global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<T>.RowNestedResultEnumerator _rowEnumerator;

			// Token: 0x04003108 RID: 12552
			private global::System.Data.Entity.Core.Common.Internal.Materialization.RecordState _current;

			// Token: 0x04003109 RID: 12553
			private int _depth;

			// Token: 0x0400310A RID: 12554
			private bool _readerConsumed;
		}
	}
}
