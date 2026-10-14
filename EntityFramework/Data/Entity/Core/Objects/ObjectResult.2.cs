using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Data.Entity.Core.Common.Internal.Materialization;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Internal;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Core.Objects
{
	// Token: 0x0200041D RID: 1053
	public class ObjectResult<T> : global::System.Data.Entity.Core.Objects.ObjectResult, global::System.Collections.Generic.IEnumerable<!0>, global::System.Collections.IEnumerable, global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<!0>, global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable
	{
		// Token: 0x060032AB RID: 12971 RVA: 0x000A174F File Offset: 0x0009F94F
		protected ObjectResult()
		{
		}

		// Token: 0x060032AC RID: 12972 RVA: 0x000A1757 File Offset: 0x0009F957
		internal ObjectResult(global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<T> shaper, global::System.Data.Entity.Core.Metadata.Edm.EntitySet singleEntitySet, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultItemType) : this(shaper, singleEntitySet, resultItemType, true, true, null)
		{
		}

		// Token: 0x060032AD RID: 12973 RVA: 0x000A1768 File Offset: 0x0009F968
		internal ObjectResult(global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<T> shaper, global::System.Data.Entity.Core.Metadata.Edm.EntitySet singleEntitySet, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultItemType, bool readerOwned, bool shouldReleaseConnection, global::System.Data.Common.DbCommand command = null) : this(shaper, singleEntitySet, resultItemType, readerOwned, shouldReleaseConnection, null, null, command)
		{
		}

		// Token: 0x060032AE RID: 12974 RVA: 0x000A1788 File Offset: 0x0009F988
		internal ObjectResult(global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<T> shaper, global::System.Data.Entity.Core.Metadata.Edm.EntitySet singleEntitySet, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultItemType, bool readerOwned, bool shouldReleaseConnection, global::System.Data.Entity.Core.Objects.NextResultGenerator nextResultGenerator, global::System.Action<object, global::System.EventArgs> onReaderDispose, global::System.Data.Common.DbCommand command = null)
		{
			this._shaper = shaper;
			this._reader = this._shaper.Reader;
			this._command = command;
			this._singleEntitySet = singleEntitySet;
			this._resultItemType = resultItemType;
			this._readerOwned = readerOwned;
			this._shouldReleaseConnection = shouldReleaseConnection;
			this._nextResultGenerator = nextResultGenerator;
			this._onReaderDispose = onReaderDispose;
		}

		// Token: 0x060032AF RID: 12975 RVA: 0x000A17E9 File Offset: 0x0009F9E9
		private void EnsureCanEnumerateResults()
		{
			if (this._shaper == null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.Materializer_CannotReEnumerateQueryResults);
			}
		}

		// Token: 0x060032B0 RID: 12976 RVA: 0x000A17FE File Offset: 0x0009F9FE
		public virtual global::System.Collections.Generic.IEnumerator<T> GetEnumerator()
		{
			return this.GetDbEnumerator();
		}

		// Token: 0x060032B1 RID: 12977 RVA: 0x000A1806 File Offset: 0x0009FA06
		internal virtual global::System.Data.Entity.Internal.IDbEnumerator<T> GetDbEnumerator()
		{
			this.EnsureCanEnumerateResults();
			global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<T> shaper = this._shaper;
			this._shaper = null;
			return shaper.GetEnumerator();
		}

		// Token: 0x060032B2 RID: 12978 RVA: 0x000A1820 File Offset: 0x0009FA20
		global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<T> global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<!0>.GetAsyncEnumerator()
		{
			return this.GetDbEnumerator();
		}

		// Token: 0x060032B3 RID: 12979 RVA: 0x000A1828 File Offset: 0x0009FA28
		protected override void Dispose(bool disposing)
		{
			global::System.Data.Common.DbDataReader reader = this._reader;
			this._reader = null;
			this._nextResultGenerator = null;
			if (reader != null && this._readerOwned)
			{
				reader.Dispose();
				if (this._onReaderDispose != null)
				{
					this._onReaderDispose(this, new global::System.EventArgs());
					this._onReaderDispose = null;
				}
			}
			if (this._shaper != null)
			{
				if (this._shaper.Context != null && this._readerOwned && this._shouldReleaseConnection)
				{
					this._shaper.Context.ReleaseConnection();
				}
				this._shaper = null;
			}
			if (this._command != null)
			{
				this._command.Dispose();
				this._command = null;
			}
		}

		// Token: 0x060032B4 RID: 12980 RVA: 0x000A18D1 File Offset: 0x0009FAD1
		internal override global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator GetAsyncEnumeratorInternal()
		{
			return this.GetDbEnumerator();
		}

		// Token: 0x060032B5 RID: 12981 RVA: 0x000A18D9 File Offset: 0x0009FAD9
		internal override global::System.Collections.IEnumerator GetEnumeratorInternal()
		{
			return this.GetDbEnumerator();
		}

		// Token: 0x060032B6 RID: 12982 RVA: 0x000A18E4 File Offset: 0x0009FAE4
		internal override global::System.Collections.IList GetIListSourceListInternal()
		{
			if (this._cachedBindingList == null)
			{
				this.EnsureCanEnumerateResults();
				bool forceReadOnly = this._shaper.MergeOption == global::System.Data.Entity.Core.Objects.MergeOption.NoTracking;
				this._cachedBindingList = global::System.Data.Entity.Core.Objects.ObjectViewFactory.CreateViewForQuery<T>(this._resultItemType, this, this._shaper.Context, forceReadOnly, this._singleEntitySet);
			}
			return this._cachedBindingList;
		}

		// Token: 0x060032B7 RID: 12983 RVA: 0x000A1938 File Offset: 0x0009FB38
		internal override global::System.Data.Entity.Core.Objects.ObjectResult<TElement> GetNextResultInternal<TElement>()
		{
			if (this._nextResultGenerator == null)
			{
				return null;
			}
			return this._nextResultGenerator.GetNextResult<TElement>(this._reader);
		}

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x060032B8 RID: 12984 RVA: 0x000A1955 File Offset: 0x0009FB55
		public override global::System.Type ElementType
		{
			get
			{
				return typeof(T);
			}
		}

		// Token: 0x04001086 RID: 4230
		private global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper<T> _shaper;

		// Token: 0x04001087 RID: 4231
		private global::System.Data.Common.DbDataReader _reader;

		// Token: 0x04001088 RID: 4232
		private global::System.Data.Common.DbCommand _command;

		// Token: 0x04001089 RID: 4233
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EntitySet _singleEntitySet;

		// Token: 0x0400108A RID: 4234
		private readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage _resultItemType;

		// Token: 0x0400108B RID: 4235
		private readonly bool _readerOwned;

		// Token: 0x0400108C RID: 4236
		private readonly bool _shouldReleaseConnection;

		// Token: 0x0400108D RID: 4237
		private global::System.ComponentModel.IBindingList _cachedBindingList;

		// Token: 0x0400108E RID: 4238
		private global::System.Data.Entity.Core.Objects.NextResultGenerator _nextResultGenerator;

		// Token: 0x0400108F RID: 4239
		private global::System.Action<object, global::System.EventArgs> _onReaderDispose;
	}
}
