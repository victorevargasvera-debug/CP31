using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Threading;
using Infragistics.Collections;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000155 RID: 341
	internal class FlatScrollRecordsCollection : global::Infragistics.PropertyChangeNotifier, global::System.Collections.IList, global::System.Collections.ICollection, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record>, global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Record>, global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>, global::System.Collections.IEnumerable, global::System.Collections.Specialized.INotifyCollectionChanged
	{
		// Token: 0x06001344 RID: 4932 RVA: 0x00053600 File Offset: 0x00051800
		internal FlatScrollRecordsCollection(global::Infragistics.Windows.DataPresenter.RecordManager recordManager)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(recordManager);
			this._recordManager = recordManager;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = recordManager.DataPresenter;
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(dataPresenter);
			this.VerifyViewableRecords();
			global::Infragistics.Windows.Internal.PropertyValueTracker item = new global::Infragistics.Windows.Internal.PropertyValueTracker(this._recordManager, "Current", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.VerifyViewableRecords));
			this._pvtTrackers.Add(item);
			item = new global::Infragistics.Windows.Internal.PropertyValueTracker(dataPresenter, global::Infragistics.Windows.DataPresenter.DataPresenterBase.ScrollCountRecalcVersionProperty, new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.RaiseCollectionChanged_ResetAsync));
			this._pvtTrackers.Add(item);
			this._headers = new global::Infragistics.Collections.SparseArray();
			this.HookIntoFieldLayouts();
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x000536BE File Offset: 0x000518BE
		protected override void OnHasListenersChanged()
		{
			base.OnHasListenersChanged();
			this.OnHasListenersChangedInternal();
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x000536CC File Offset: 0x000518CC
		public int IndexOf(global::Infragistics.Windows.DataPresenter.Record record)
		{
			if (record is global::Infragistics.Windows.DataPresenter.HeaderRecord && ((global::Infragistics.Windows.DataPresenter.HeaderRecord)record)._vrcPlaceholderRecord == null)
			{
				int num = this._headers.IndexOf(record);
				if (num >= 0)
				{
					num += this._vrc.ScrollCount;
				}
				return num;
			}
			if (record.ParentCollection == record.RecordManager.Sorted && record.RecordManager.HasGroups)
			{
				return -1;
			}
			return record.OverallScrollPosition;
		}

		// Token: 0x06001347 RID: 4935 RVA: 0x00053737 File Offset: 0x00051937
		public bool Contains(global::Infragistics.Windows.DataPresenter.Record record)
		{
			return this.IndexOf(record) >= 0;
		}

		// Token: 0x06001348 RID: 4936 RVA: 0x00053748 File Offset: 0x00051948
		public void CopyTo(global::Infragistics.Windows.DataPresenter.Record[] array, int arrayIndex)
		{
			for (int i = 0; i < this.Count; i++)
			{
				array[arrayIndex++] = this[i];
			}
		}

		// Token: 0x06001349 RID: 4937 RVA: 0x00053775 File Offset: 0x00051975
		private void OnHasListenersChangedInternal()
		{
			if (!this.HasListeners && this._pendingNotifications != null)
			{
				this._pendingNotifications.Clear();
				this._pendingNotificationsHasReset = false;
			}
		}

		// Token: 0x0600134A RID: 4938 RVA: 0x00053799 File Offset: 0x00051999
		public void BeginMeasure()
		{
			this.BeginMeasure(null);
		}

		// Token: 0x0600134B RID: 4939 RVA: 0x000537A4 File Offset: 0x000519A4
		internal void BeginMeasure(global::Infragistics.Windows.DataPresenter.GridViewPanelFlat.GenerationCache generatorCache)
		{
			if (this._beginMeasureCount == 0)
			{
				this.PopulateHeaderRecords();
				if (generatorCache != null)
				{
					this.EnsureItemsAllocated(generatorCache);
				}
				this.RaisePendingNotifications();
				this._usedHeaders = new bool[this.CountOfHeaderRecords];
				this._generatorsInMeasure = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection.RecordsInViewGenerator>();
			}
			this._beginMeasureCount++;
		}

		// Token: 0x0600134C RID: 4940 RVA: 0x000537FC File Offset: 0x000519FC
		public void EndMeasure()
		{
			if (this._beginMeasureCount > 0)
			{
				this._beginMeasureCount--;
				if (this._beginMeasureCount == 0)
				{
					this._headersUsedInLastMeasure = this.CreateUsedHeadersList(this._usedHeaders);
					this.CleanupHeaderRecords();
					this._usedHeaders = null;
					global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection.RecordsInViewGenerator> generatorsInMeasure = this._generatorsInMeasure;
					this._generatorsInMeasure = null;
					this.HookIntoGeneratedRecordsHelper(generatorsInMeasure, true);
				}
			}
		}

		// Token: 0x0600134D RID: 4941 RVA: 0x00053860 File Offset: 0x00051A60
		public int GetNextHeaderRecord(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, out global::Infragistics.Windows.DataPresenter.HeaderRecord headerRecord)
		{
			headerRecord = null;
			if (this._beginMeasureCount <= 0)
			{
				return -1;
			}
			for (int i = 0; i < 2; i++)
			{
				int j = 0;
				int count = this._headers.Count;
				while (j < count)
				{
					if (!this._usedHeaders[j])
					{
						global::Infragistics.Windows.DataPresenter.HeaderRecord headerRecord2 = (global::Infragistics.Windows.DataPresenter.HeaderRecord)this._headers[j];
						if (headerRecord2 == null || (1 == i && headerRecord2._isPlaceHolder))
						{
							headerRecord2 = (this._headers[j] = new global::Infragistics.Windows.DataPresenter.HeaderRecord(fieldLayout, this._headerRecordsParentCollection));
						}
						if (headerRecord2.FieldLayout == fieldLayout)
						{
							this._usedHeaders[j] = true;
							headerRecord2._isPlaceHolder = false;
							headerRecord = headerRecord2;
							return this._vrc.ScrollCount + j;
						}
					}
					j++;
				}
			}
			this._desiredHeaderCount *= 2;
			this.RaiseCollectionChanged_Reset(true);
			return -1;
		}

		// Token: 0x0600134E RID: 4942 RVA: 0x0005392A File Offset: 0x00051B2A
		internal global::Infragistics.Windows.DataPresenter.Record GetRecordAtScrollPosition(int scrollPosition)
		{
			if (scrollPosition >= 0 && scrollPosition < this.CountOfNonHeaderRecords)
			{
				return this.GetRecordsInViewGenerator(scrollPosition).FirstRecord;
			}
			return null;
		}

		// Token: 0x0600134F RID: 4943 RVA: 0x00053947 File Offset: 0x00051B47
		public global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection.RecordsInViewGenerator GetRecordsInViewGenerator(int topScrollPosition)
		{
			return new global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection.RecordsInViewGenerator(this, topScrollPosition);
		}

		// Token: 0x06001350 RID: 4944 RVA: 0x00053950 File Offset: 0x00051B50
		internal int GetScrollPositionOfRecord(global::Infragistics.Windows.DataPresenter.Record record)
		{
			if (record == null)
			{
				return -1;
			}
			int num = this.IndexOf(record);
			if (num < 0)
			{
				return -1;
			}
			int num2 = 0;
			if (record.ParentRecord == null)
			{
				if (record.IsFixed)
				{
					if (record.IsOnTopWhenFixed)
					{
						return this.Count - (num + 1);
					}
					return num - this.CountOfFixedRecordsOnTop;
				}
				else
				{
					num2 -= this.CountOfFixedRecordsOnTop;
				}
			}
			else
			{
				while (record != null)
				{
					global::Infragistics.Windows.DataPresenter.ViewableRecordCollection vrc = this.GetVrc(record);
					global::Infragistics.Windows.DataPresenter.Record parentRecord = record.ParentRecord;
					if (parentRecord == null)
					{
						if (!record.IsFixed)
						{
							num2 -= vrc.CountOfFixedRecordsOnTop;
						}
					}
					else if (record.IsFixed && record.IsOnTopWhenFixed)
					{
						num2 += vrc.Count - vrc.CountOfFixedRecordsOnTop;
					}
					else
					{
						num2 -= vrc.CountOfFixedRecordsOnTop;
					}
					record = parentRecord;
				}
			}
			return num + num2;
		}

		// Token: 0x06001351 RID: 4945 RVA: 0x00053A08 File Offset: 0x00051C08
		private void HookIntoGeneratedRecordsHelper(global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection.RecordsInViewGenerator> generatorList, bool unhookFromPreviousRecords)
		{
			global::Infragistics.Collections.WeakDictionary<object, global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection.EventHandlerHolder> hookedIntoObjects = this._hookedIntoObjects;
			global::Infragistics.Windows.Helpers.HashSet hashSet = new global::Infragistics.Windows.Helpers.HashSet();
			int i = 0;
			int count = generatorList.Count;
			while (i < count)
			{
				global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection.RecordsInViewGenerator recordsInViewGenerator = generatorList[i];
				global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record> enumerable = new global::Infragistics.Windows.DataPresenter.GridUtilities.AggregateEnumerable<global::Infragistics.Windows.DataPresenter.Record>(new global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>[]
				{
					recordsInViewGenerator.PrefixRecords,
					new global::Infragistics.Windows.DataPresenter.Record[]
					{
						recordsInViewGenerator.FirstRecord
					},
					recordsInViewGenerator._successiveRecords
				});
				foreach (global::Infragistics.Windows.DataPresenter.Record record in enumerable)
				{
					global::Infragistics.Windows.DataPresenter.ViewableRecordCollection vrc = this.GetVrc(record);
					if (vrc != null)
					{
						hashSet.Add(vrc);
						global::Infragistics.Windows.DataPresenter.RecordManager recordManager = vrc.RecordManager;
						if (recordManager != null)
						{
							hashSet.Add(recordManager);
						}
						global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = record as global::Infragistics.Windows.DataPresenter.DataRecord;
						if (dataRecord != null && dataRecord.IsExpanded)
						{
							this.AddChildVrcs(dataRecord, hashSet);
						}
					}
				}
				i++;
			}
			if (unhookFromPreviousRecords)
			{
				global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection.EventHandlerHolder> list = null;
				foreach (global::System.Collections.Generic.KeyValuePair<object, global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection.EventHandlerHolder> keyValuePair in ((global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<object, global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection.EventHandlerHolder>>)hookedIntoObjects))
				{
					if (!hashSet.Exists(keyValuePair.Key))
					{
						if (list == null)
						{
							list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection.EventHandlerHolder>();
						}
						list.Add(keyValuePair.Value);
					}
				}
				if (list != null)
				{
					int j = 0;
					int count2 = list.Count;
					while (j < count2)
					{
						global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection.EventHandlerHolder eventHandlerHolder = list[j];
						eventHandlerHolder.Unhook();
						hookedIntoObjects.Remove(eventHandlerHolder._obj);
						j++;
					}
				}
			}
			foreach (object obj in hashSet)
			{
				if (!hookedIntoObjects.ContainsKey(obj))
				{
					hookedIntoObjects[obj] = new global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection.EventHandlerHolder(this, (global::System.ComponentModel.INotifyPropertyChanged)obj);
				}
			}
		}

		// Token: 0x06001352 RID: 4946 RVA: 0x00053C0C File Offset: 0x00051E0C
		internal bool RaisePendingNotifications()
		{
			global::System.Collections.Generic.List<global::System.EventArgs> pendingNotifications = this._pendingNotifications;
			bool pendingNotificationsHasReset = this._pendingNotificationsHasReset;
			this._pendingNotifications = null;
			this._pendingNotificationsHasReset = false;
			if (pendingNotifications != null && pendingNotifications.Count > 0)
			{
				global::System.Collections.Specialized.NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs = null;
				if (pendingNotificationsHasReset)
				{
					foreach (global::System.EventArgs eventArgs in pendingNotifications)
					{
						if (eventArgs is global::System.Collections.Specialized.NotifyCollectionChangedEventArgs && global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset == ((global::System.Collections.Specialized.NotifyCollectionChangedEventArgs)eventArgs).Action)
						{
							notifyCollectionChangedEventArgs = (global::System.Collections.Specialized.NotifyCollectionChangedEventArgs)eventArgs;
							break;
						}
					}
				}
				if (notifyCollectionChangedEventArgs != null)
				{
					this.RaiseChangeEvent(notifyCollectionChangedEventArgs, false);
				}
				else
				{
					foreach (global::System.EventArgs e in pendingNotifications)
					{
						this.RaiseChangeEvent(e, false);
					}
				}
				return true;
			}
			return false;
		}

		// Token: 0x06001353 RID: 4947 RVA: 0x00053CF8 File Offset: 0x00051EF8
		private void AddChildVrcs(global::Infragistics.Windows.DataPresenter.DataRecord dr, global::Infragistics.Windows.Helpers.HashSet set)
		{
			global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordCollection childRecordsIfAllocated = dr.ChildRecordsIfAllocated;
			if (childRecordsIfAllocated != null)
			{
				foreach (global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord expandableFieldRecord in childRecordsIfAllocated)
				{
					global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableChildRecordsIfNeeded = expandableFieldRecord.ViewableChildRecordsIfNeeded;
					if (viewableChildRecordsIfNeeded != null)
					{
						set.Add(viewableChildRecordsIfNeeded);
					}
				}
			}
		}

		// Token: 0x06001354 RID: 4948 RVA: 0x00053D54 File Offset: 0x00051F54
		private void CleanupHeaderRecords()
		{
			for (int i = 0; i < this._headers.Count; i++)
			{
				global::Infragistics.Windows.DataPresenter.HeaderRecord headerRecord = (global::Infragistics.Windows.DataPresenter.HeaderRecord)this._headers[i];
				if (this._usedHeaders == null || !this._usedHeaders[i])
				{
					global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = (headerRecord != null) ? headerRecord.FieldLayout : null;
					if (fieldLayout != null && fieldLayout.WasRemovedFromCollection && this._recordManager.FieldLayout != null && fieldLayout != this._recordManager.FieldLayout)
					{
						headerRecord = new global::Infragistics.Windows.DataPresenter.HeaderRecord(this._recordManager.FieldLayout, this._headerRecordsParentCollection);
						headerRecord._isPlaceHolder = true;
						this._headers[i] = headerRecord;
					}
					else if (headerRecord.AssociatedRecordPresenter == null)
					{
						headerRecord._isPlaceHolder = true;
					}
				}
			}
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x00053E10 File Offset: 0x00052010
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.HeaderRecord> CreateUsedHeadersList(bool[] usedHeadersFlags)
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.HeaderRecord> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.HeaderRecord>();
			if (usedHeadersFlags != null)
			{
				for (int i = 0; i < usedHeadersFlags.Length; i++)
				{
					if (usedHeadersFlags[i])
					{
						global::Infragistics.Windows.DataPresenter.HeaderRecord headerRecord = this._headers[i] as global::Infragistics.Windows.DataPresenter.HeaderRecord;
						if (headerRecord != null)
						{
							list.Add(headerRecord);
						}
					}
				}
			}
			return list;
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x00053E56 File Offset: 0x00052056
		private void EnsureItemsAllocated(global::Infragistics.Windows.DataPresenter.GridViewPanelFlat.GenerationCache generatorCache)
		{
			if (generatorCache != null && generatorCache._estimatedRecordsToLayout > 0)
			{
				this.EnsureItemsAllocated(generatorCache._currentScrollPosition, generatorCache._estimatedRecordsToLayout);
			}
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x00053E78 File Offset: 0x00052078
		private void EnsureItemsAllocated(int startIndex, int count)
		{
			global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecordCollection = null;
			global::Infragistics.Windows.DataPresenter.RecordManager recordManager = null;
			for (int i = 0; i < count; i++)
			{
				global::Infragistics.Windows.DataPresenter.Record record = this[startIndex + i];
				if (record == null)
				{
					return;
				}
				global::Infragistics.Windows.DataPresenter.ViewableRecordCollection vrc = this.GetVrc(record);
				if (vrc != null && vrc != viewableRecordCollection)
				{
					vrc.Verify();
					viewableRecordCollection = vrc;
					global::Infragistics.Windows.DataPresenter.RecordManager recordManager2 = vrc.RecordManager;
					if (recordManager2 != null && recordManager2 != recordManager)
					{
						recordManager2.VerifySort();
						recordManager = recordManager2;
					}
				}
			}
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x00053EDC File Offset: 0x000520DC
		private global::Infragistics.Windows.DataPresenter.ViewableRecordCollection GetVrc(global::Infragistics.Windows.DataPresenter.Record record)
		{
			if (record != null)
			{
				global::Infragistics.Windows.DataPresenter.RecordCollectionBase parentCollection = record.ParentCollection;
				if (parentCollection != null)
				{
					return parentCollection.ViewableRecords;
				}
			}
			return null;
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x00053F00 File Offset: 0x00052100
		private void HookIntoFieldLayout(global::Infragistics.Windows.DataPresenter.FieldLayout fl)
		{
			if (!this._fieldLayoutPvtTrackers.ContainsKey(fl))
			{
				global::System.Collections.Generic.List<global::Infragistics.Windows.Internal.PropertyValueTracker> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.Internal.PropertyValueTracker>();
				global::Infragistics.Windows.Internal.PropertyValueTracker item = new global::Infragistics.Windows.Internal.PropertyValueTracker(fl, global::Infragistics.Windows.DataPresenter.FieldLayout.SpecialRecordsVersionProperty, new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnFieldLayout_SpecialRecordsVersionChanged));
				list.Add(item);
				this._fieldLayoutPvtTrackers.Add(fl, list);
			}
		}

		// Token: 0x0600135A RID: 4954 RVA: 0x00053F50 File Offset: 0x00052150
		private void HookIntoFieldLayouts()
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._recordManager.DataPresenter;
			global::Infragistics.Windows.DataPresenter.FieldLayoutCollection fieldLayoutCollection = (dataPresenter != null) ? dataPresenter.FieldLayouts : null;
			if (this._lastHookedFieldLayoutsColl != fieldLayoutCollection)
			{
				if (this._lastHookedFieldLayoutsColl != null)
				{
					this._lastHookedFieldLayoutsColl.CollectionChanged -= this.OnFieldLayouts_CollectionChanged;
				}
				fieldLayoutCollection.CollectionChanged += this.OnFieldLayouts_CollectionChanged;
				this._lastHookedFieldLayoutsColl = fieldLayoutCollection;
			}
			int i = 0;
			int count = fieldLayoutCollection.Count;
			while (i < count)
			{
				this.HookIntoFieldLayout(fieldLayoutCollection[i]);
				i++;
			}
		}

		// Token: 0x0600135B RID: 4955 RVA: 0x00053FD7 File Offset: 0x000521D7
		private void OnFieldLayouts_CollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this.HookIntoFieldLayouts();
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x00053FDF File Offset: 0x000521DF
		private void OnFieldLayout_SpecialRecordsVersionChanged()
		{
			this.RaiseCollectionChanged_Reset(true);
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x00053FE8 File Offset: 0x000521E8
		private void PopulateHeaderRecords()
		{
			if (this._headerRecordsParentCollection == null || this._headerRecordsParentCollection.FieldLayout != this._recordManager.FieldLayout)
			{
				this._headerRecordsParentCollection = new global::Infragistics.Windows.DataPresenter.RecordCollection(null, this._recordManager, null);
			}
			if (this._headers.Count < this._desiredHeaderCount && this._recordManager.FieldLayout != null)
			{
				for (int i = this._headers.Count; i < this._desiredHeaderCount; i++)
				{
					global::Infragistics.Windows.DataPresenter.HeaderRecord headerRecord = new global::Infragistics.Windows.DataPresenter.HeaderRecord(this._recordManager.FieldLayout, this._headerRecordsParentCollection);
					headerRecord._isPlaceHolder = true;
					this._headers.Add(headerRecord);
				}
				this.RaiseCollectionChanged_Reset(true);
			}
		}

		// Token: 0x0600135E RID: 4958 RVA: 0x00054095 File Offset: 0x00052295
		private void RaisePendingNotificationsCallback()
		{
			this.RaisePendingNotifications();
		}

		// Token: 0x0600135F RID: 4959 RVA: 0x000540A0 File Offset: 0x000522A0
		private void OnVrc_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			string propertyName;
			if ((propertyName = e.PropertyName) != null)
			{
				if (!(propertyName == "Item[]") && !(propertyName == "ScrollCount"))
				{
					return;
				}
				this.RaiseCollectionChanged_Reset(true);
			}
		}

		// Token: 0x06001360 RID: 4960 RVA: 0x000540D9 File Offset: 0x000522D9
		private void RaiseCollectionChanged_ResetAsync()
		{
			this.RaiseCollectionChanged_Reset(true);
		}

		// Token: 0x06001361 RID: 4961 RVA: 0x000540E4 File Offset: 0x000522E4
		private void RaiseCollectionChanged_Reset(bool async)
		{
			global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e = new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset);
			this.RaiseChangeEvent(e, async);
			this.RaiseChangeEvent(new global::System.ComponentModel.PropertyChangedEventArgs("Count"), async);
		}

		// Token: 0x06001362 RID: 4962 RVA: 0x00054114 File Offset: 0x00052314
		private void RaiseChangeEvent(global::System.EventArgs e, bool async)
		{
			if (async)
			{
				if (this._pendingNotificationsHasReset)
				{
					return;
				}
				if (this._pendingNotifications == null)
				{
					this._pendingNotifications = new global::System.Collections.Generic.List<global::System.EventArgs>();
				}
				bool flag = this._pendingNotifications.Count == 0;
				global::System.Collections.Specialized.NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs = e as global::System.Collections.Specialized.NotifyCollectionChangedEventArgs;
				if (notifyCollectionChangedEventArgs != null && notifyCollectionChangedEventArgs.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset)
				{
					this._pendingNotificationsHasReset = true;
					this._pendingNotifications.Clear();
				}
				this._pendingNotifications.Add(e);
				if (flag)
				{
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._recordManager.DataPresenter;
					if (dataPresenter != null)
					{
						global::System.Windows.Threading.Dispatcher dispatcher = dataPresenter.Dispatcher;
						if (dispatcher != null)
						{
							dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Send, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.RaisePendingNotificationsCallback));
							return;
						}
					}
				}
			}
			else
			{
				if (e is global::System.ComponentModel.PropertyChangedEventArgs)
				{
					base.RaisePropertyChangedEvent(((global::System.ComponentModel.PropertyChangedEventArgs)e).PropertyName);
					return;
				}
				if (e is global::System.Collections.Specialized.NotifyCollectionChangedEventArgs)
				{
					this.RaiseCollectionChangedHelper((global::System.Collections.Specialized.NotifyCollectionChangedEventArgs)e);
				}
			}
		}

		// Token: 0x06001363 RID: 4963 RVA: 0x000541E3 File Offset: 0x000523E3
		private void RaiseCollectionChangedHelper(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs eventArgs)
		{
			if (this._collectionChanged != null)
			{
				this._collectionChanged(this, eventArgs);
			}
		}

		// Token: 0x06001364 RID: 4964 RVA: 0x000541FC File Offset: 0x000523FC
		private void VerifyViewableRecords()
		{
			global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = this._recordManager.ViewableRecords;
			if (this._vrc != viewableRecords)
			{
				if (this._vrc != null)
				{
					this._vrc.PropertyChanged -= this.OnVrc_PropertyChanged;
				}
				this._vrc = viewableRecords;
				if (this._vrc != null)
				{
					this._vrc.PropertyChanged += this.OnVrc_PropertyChanged;
				}
				if (this.HasListeners)
				{
					this.RaiseCollectionChanged_Reset(true);
				}
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06001365 RID: 4965 RVA: 0x00054272 File Offset: 0x00052472
		public int Count
		{
			get
			{
				return this._vrc.ScrollCount + this.CountOfHeaderRecords;
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06001366 RID: 4966 RVA: 0x00054286 File Offset: 0x00052486
		public int CountOfFixedRecordsOnBottom
		{
			get
			{
				return this._vrc.CountOfFixedRecordsOnBottom;
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06001367 RID: 4967 RVA: 0x00054293 File Offset: 0x00052493
		public int CountOfFixedRecordsOnTop
		{
			get
			{
				return this._vrc.CountOfFixedRecordsOnTop;
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06001368 RID: 4968 RVA: 0x000542A0 File Offset: 0x000524A0
		public bool HasPendingNotifications
		{
			get
			{
				return this._pendingNotifications != null && this._pendingNotifications.Count > 0;
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06001369 RID: 4969 RVA: 0x000542BA File Offset: 0x000524BA
		public int CountOfHeaderRecords
		{
			get
			{
				return this._headers.Count;
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x0600136A RID: 4970 RVA: 0x000542C7 File Offset: 0x000524C7
		public int CountOfNonHeaderRecords
		{
			get
			{
				return this._vrc.ScrollCount;
			}
		}

		// Token: 0x170004A8 RID: 1192
		public global::Infragistics.Windows.DataPresenter.Record this[int index]
		{
			get
			{
				int scrollCount = this._vrc.ScrollCount;
				if (index < scrollCount)
				{
					return this._vrc.GetRecordAtScrollPosition(index);
				}
				return (global::Infragistics.Windows.DataPresenter.Record)this._headers[index - scrollCount];
			}
			set
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x0600136D RID: 4973 RVA: 0x00054318 File Offset: 0x00052518
		internal new bool HasListeners
		{
			get
			{
				return this._collectionChanged != null || base.HasListeners;
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x0600136E RID: 4974 RVA: 0x0005432A File Offset: 0x0005252A
		internal global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.HeaderRecord> HeadersUsedInLastMeasure
		{
			get
			{
				return this._headersUsedInLastMeasure;
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x0600136F RID: 4975 RVA: 0x00054332 File Offset: 0x00052532
		internal bool IsMeasuring
		{
			get
			{
				return this._beginMeasureCount > 0;
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06001370 RID: 4976 RVA: 0x0005433D File Offset: 0x0005253D
		internal global::Infragistics.Windows.DataPresenter.ViewableRecordCollection RootViewableRecords
		{
			get
			{
				return this._vrc;
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06001371 RID: 4977 RVA: 0x00054345 File Offset: 0x00052545
		internal global::Infragistics.Windows.DataPresenter.RecordManager RecordManager
		{
			get
			{
				return this._recordManager;
			}
		}

		// Token: 0x06001372 RID: 4978 RVA: 0x0005434D File Offset: 0x0005254D
		void global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record>.Insert(int index, global::Infragistics.Windows.DataPresenter.Record item)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06001373 RID: 4979 RVA: 0x0005435E File Offset: 0x0005255E
		void global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record>.RemoveAt(int index)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06001374 RID: 4980 RVA: 0x0005436F File Offset: 0x0005256F
		void global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Record>.Add(global::Infragistics.Windows.DataPresenter.Record item)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06001375 RID: 4981 RVA: 0x00054380 File Offset: 0x00052580
		void global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Record>.Clear()
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06001376 RID: 4982 RVA: 0x00054391 File Offset: 0x00052591
		bool global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Record>.IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06001377 RID: 4983 RVA: 0x00054394 File Offset: 0x00052594
		bool global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Record>.Remove(global::Infragistics.Windows.DataPresenter.Record item)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x06001378 RID: 4984 RVA: 0x000543A5 File Offset: 0x000525A5
		public global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> GetEnumerator()
		{
			return new global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection.Enumerator(this);
		}

		// Token: 0x06001379 RID: 4985 RVA: 0x000543AD File Offset: 0x000525AD
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x14000061 RID: 97
		// (add) Token: 0x0600137A RID: 4986 RVA: 0x000543B8 File Offset: 0x000525B8
		// (remove) Token: 0x0600137B RID: 4987 RVA: 0x000543F0 File Offset: 0x000525F0
		private event global::System.Collections.Specialized.NotifyCollectionChangedEventHandler _collectionChanged;

		// Token: 0x14000062 RID: 98
		// (add) Token: 0x0600137C RID: 4988 RVA: 0x00054425 File Offset: 0x00052625
		// (remove) Token: 0x0600137D RID: 4989 RVA: 0x00054444 File Offset: 0x00052644
		public event global::System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged
		{
			add
			{
				this._collectionChanged = (global::System.Delegate.Combine(this._collectionChanged, value) as global::System.Collections.Specialized.NotifyCollectionChangedEventHandler);
				this.OnHasListenersChangedInternal();
			}
			remove
			{
				this._collectionChanged = (global::System.Delegate.Remove(this._collectionChanged, value) as global::System.Collections.Specialized.NotifyCollectionChangedEventHandler);
				this.OnHasListenersChangedInternal();
			}
		}

		// Token: 0x0600137E RID: 4990 RVA: 0x00054463 File Offset: 0x00052663
		int global::System.Collections.IList.Add(object value)
		{
			((global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Record>)this).Add(value as global::Infragistics.Windows.DataPresenter.Record);
			return this.Count - 1;
		}

		// Token: 0x0600137F RID: 4991 RVA: 0x00054479 File Offset: 0x00052679
		void global::System.Collections.IList.Clear()
		{
			((global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Record>)this).Clear();
		}

		// Token: 0x06001380 RID: 4992 RVA: 0x00054481 File Offset: 0x00052681
		bool global::System.Collections.IList.Contains(object value)
		{
			return ((global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Record>)this).Contains(value as global::Infragistics.Windows.DataPresenter.Record);
		}

		// Token: 0x06001381 RID: 4993 RVA: 0x0005448F File Offset: 0x0005268F
		int global::System.Collections.IList.IndexOf(object value)
		{
			return ((global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record>)this).IndexOf(value as global::Infragistics.Windows.DataPresenter.Record);
		}

		// Token: 0x06001382 RID: 4994 RVA: 0x0005449D File Offset: 0x0005269D
		void global::System.Collections.IList.Insert(int index, object value)
		{
			((global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record>)this).Insert(index, value as global::Infragistics.Windows.DataPresenter.Record);
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06001383 RID: 4995 RVA: 0x000544AC File Offset: 0x000526AC
		bool global::System.Collections.IList.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06001384 RID: 4996 RVA: 0x000544AF File Offset: 0x000526AF
		bool global::System.Collections.IList.IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06001385 RID: 4997 RVA: 0x000544B2 File Offset: 0x000526B2
		void global::System.Collections.IList.Remove(object value)
		{
			((global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Record>)this).Remove(value as global::Infragistics.Windows.DataPresenter.Record);
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x000544C1 File Offset: 0x000526C1
		void global::System.Collections.IList.RemoveAt(int index)
		{
			((global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record>)this).RemoveAt(index);
		}

		// Token: 0x170004B1 RID: 1201
		object global::System.Collections.IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				this[index] = (value as global::Infragistics.Windows.DataPresenter.Record);
			}
		}

		// Token: 0x06001389 RID: 5001 RVA: 0x000544E4 File Offset: 0x000526E4
		void global::System.Collections.ICollection.CopyTo(global::System.Array array, int index)
		{
			for (int i = 0; i < this.Count; i++)
			{
				array.SetValue(this[i], index++);
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x0600138A RID: 5002 RVA: 0x00054515 File Offset: 0x00052715
		bool global::System.Collections.ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x0600138B RID: 5003 RVA: 0x00054518 File Offset: 0x00052718
		object global::System.Collections.ICollection.SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x04000760 RID: 1888
		private global::Infragistics.Windows.DataPresenter.RecordManager _recordManager;

		// Token: 0x04000761 RID: 1889
		private global::Infragistics.Windows.DataPresenter.ViewableRecordCollection _vrc;

		// Token: 0x04000762 RID: 1890
		private global::Infragistics.Collections.SparseArray _headers;

		// Token: 0x04000763 RID: 1891
		private global::Infragistics.Windows.DataPresenter.RecordCollectionBase _headerRecordsParentCollection;

		// Token: 0x04000764 RID: 1892
		private int _beginMeasureCount;

		// Token: 0x04000765 RID: 1893
		private bool[] _usedHeaders;

		// Token: 0x04000766 RID: 1894
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.HeaderRecord> _headersUsedInLastMeasure;

		// Token: 0x04000767 RID: 1895
		private global::System.Collections.Generic.List<global::Infragistics.Windows.Internal.PropertyValueTracker> _pvtTrackers = new global::System.Collections.Generic.List<global::Infragistics.Windows.Internal.PropertyValueTracker>();

		// Token: 0x04000768 RID: 1896
		private global::System.Collections.Generic.List<global::System.EventArgs> _pendingNotifications;

		// Token: 0x04000769 RID: 1897
		private int _desiredHeaderCount = 40;

		// Token: 0x0400076A RID: 1898
		private global::Infragistics.Windows.DataPresenter.FieldLayoutCollection _lastHookedFieldLayoutsColl;

		// Token: 0x0400076B RID: 1899
		private global::Infragistics.Collections.WeakDictionary<global::Infragistics.Windows.DataPresenter.FieldLayout, global::System.Collections.Generic.List<global::Infragistics.Windows.Internal.PropertyValueTracker>> _fieldLayoutPvtTrackers = new global::Infragistics.Collections.WeakDictionary<global::Infragistics.Windows.DataPresenter.FieldLayout, global::System.Collections.Generic.List<global::Infragistics.Windows.Internal.PropertyValueTracker>>(true, false);

		// Token: 0x0400076C RID: 1900
		private global::Infragistics.Collections.WeakDictionary<object, global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection.EventHandlerHolder> _hookedIntoObjects = new global::Infragistics.Collections.WeakDictionary<object, global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection.EventHandlerHolder>(true, false);

		// Token: 0x0400076D RID: 1901
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection.RecordsInViewGenerator> _generatorsInMeasure;

		// Token: 0x0400076E RID: 1902
		private bool _pendingNotificationsHasReset;

		// Token: 0x02000156 RID: 342
		private class Enumerator : global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x0600138C RID: 5004 RVA: 0x0005451B File Offset: 0x0005271B
			internal Enumerator(global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection list)
			{
				this._list = list;
				this.Reset();
			}

			// Token: 0x170004B4 RID: 1204
			// (get) Token: 0x0600138D RID: 5005 RVA: 0x00054530 File Offset: 0x00052730
			public global::Infragistics.Windows.DataPresenter.Record Current
			{
				get
				{
					return this._current;
				}
			}

			// Token: 0x0600138E RID: 5006 RVA: 0x00054538 File Offset: 0x00052738
			public void Dispose()
			{
			}

			// Token: 0x170004B5 RID: 1205
			// (get) Token: 0x0600138F RID: 5007 RVA: 0x0005453A File Offset: 0x0005273A
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this._current;
				}
			}

			// Token: 0x06001390 RID: 5008 RVA: 0x00054542 File Offset: 0x00052742
			public bool MoveNext()
			{
				this._index++;
				if (this._index < this._list.Count)
				{
					this._current = this._list[this._index];
					return true;
				}
				return false;
			}

			// Token: 0x06001391 RID: 5009 RVA: 0x0005457F File Offset: 0x0005277F
			public void Reset()
			{
				this._index = -1;
			}

			// Token: 0x04000770 RID: 1904
			private global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection _list;

			// Token: 0x04000771 RID: 1905
			private int _index;

			// Token: 0x04000772 RID: 1906
			private global::Infragistics.Windows.DataPresenter.Record _current;
		}

		// Token: 0x02000157 RID: 343
		private class EventHandlerHolder
		{
			// Token: 0x06001392 RID: 5010 RVA: 0x00054588 File Offset: 0x00052788
			internal EventHandlerHolder(global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection flatRecords, global::System.ComponentModel.INotifyPropertyChanged obj)
			{
				this._flatRecords = flatRecords;
				this._obj = obj;
				this._handler = new global::System.ComponentModel.PropertyChangedEventHandler(this.OnPropertyChanged);
				obj.PropertyChanged += this._handler;
			}

			// Token: 0x06001393 RID: 5011 RVA: 0x000545BC File Offset: 0x000527BC
			internal void OnPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
			{
				string propertyName = e.PropertyName;
				string a;
				if ((a = propertyName) != null)
				{
					if (!(a == "Current"))
					{
						if (!(a == "ScrollCount") && !(a == "Item[]"))
						{
							return;
						}
						if (this._obj is global::Infragistics.Windows.DataPresenter.ViewableRecordCollection)
						{
							this._flatRecords.RaiseCollectionChanged_Reset(true);
						}
					}
					else if (this._obj is global::Infragistics.Windows.DataPresenter.RecordManager)
					{
						this._flatRecords.RaiseCollectionChanged_Reset(true);
						return;
					}
				}
			}

			// Token: 0x06001394 RID: 5012 RVA: 0x00054630 File Offset: 0x00052830
			internal void Unhook()
			{
				this._obj.PropertyChanged -= this._handler;
			}

			// Token: 0x04000773 RID: 1907
			internal global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection _flatRecords;

			// Token: 0x04000774 RID: 1908
			internal global::System.ComponentModel.INotifyPropertyChanged _obj;

			// Token: 0x04000775 RID: 1909
			internal global::System.ComponentModel.PropertyChangedEventHandler _handler;
		}

		// Token: 0x02000158 RID: 344
		public class RecordsInViewGenerator
		{
			// Token: 0x06001395 RID: 5013 RVA: 0x00054643 File Offset: 0x00052843
			public RecordsInViewGenerator(global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection coll, int topScrollPos)
			{
				this._coll = coll;
				this._topScrollPos = topScrollPos;
				if (this._coll._generatorsInMeasure != null)
				{
					this._coll._generatorsInMeasure.Add(this);
				}
			}

			// Token: 0x06001396 RID: 5014 RVA: 0x00054680 File Offset: 0x00052880
			private void EnsureCalculated()
			{
				if (this._firstRecord == null)
				{
					this._prefixRecords = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record>();
					this._adjustedVrc = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.ViewableRecordCollection, global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection.RecordsInViewGenerator.TopFixedAdjustmentInfo>();
					this._firstRecord = this.GetRecordAtScrollPosHelper(this._coll._vrc, this._topScrollPos, true);
					this._successiveScrollPos = 1 + this._topScrollPos;
				}
			}

			// Token: 0x06001397 RID: 5015 RVA: 0x000546D8 File Offset: 0x000528D8
			private global::Infragistics.Windows.DataPresenter.Record GetRecordAtScrollPosHelper(global::Infragistics.Windows.DataPresenter.ViewableRecordCollection vrc, int scrollPos, bool calculating)
			{
				int scrollCount = vrc.ScrollCount;
				global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection.RecordsInViewGenerator.TopFixedAdjustmentInfo topFixedRecordsAdjustmentHelper = this.GetTopFixedRecordsAdjustmentHelper(vrc, calculating);
				if (topFixedRecordsAdjustmentHelper != null && scrollPos < scrollCount)
				{
					scrollPos += topFixedRecordsAdjustmentHelper._adjustment;
					if (scrollPos >= scrollCount)
					{
						scrollPos -= scrollCount;
					}
				}
				global::Infragistics.Windows.DataPresenter.Record recordContainingScrollIndex = vrc.GetRecordContainingScrollIndex(ref scrollPos);
				bool flag = recordContainingScrollIndex != null && recordContainingScrollIndex.OccupiesScrollPosition;
				bool flag2 = this._coll._vrc == vrc;
				if (recordContainingScrollIndex != null)
				{
					bool areChildrenAfterParent = recordContainingScrollIndex.AreChildrenAfterParent;
					if (this._excludeRootFixedRecords && flag2 && this.IsRootFixedRecord(recordContainingScrollIndex))
					{
						if (areChildrenAfterParent || !recordContainingScrollIndex.IsExpanded)
						{
							if (scrollPos == 0)
							{
								return null;
							}
						}
						else
						{
							global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableChildRecordsIfNeeded = recordContainingScrollIndex.ViewableChildRecordsIfNeeded;
							if (viewableChildRecordsIfNeeded != null)
							{
								if (scrollPos == viewableChildRecordsIfNeeded.ScrollCount)
								{
									return null;
								}
							}
							else if (scrollPos == 0)
							{
								return null;
							}
						}
					}
					if (calculating && (!this._excludeRootFixedRecords || !flag2) && topFixedRecordsAdjustmentHelper != null)
					{
						int count = this._prefixRecords.Count;
						bool flag3 = false;
						for (int i = 0; i < topFixedRecordsAdjustmentHelper._adjustment; i++)
						{
							global::Infragistics.Windows.DataPresenter.Record record = vrc[i];
							if (record == recordContainingScrollIndex && (topFixedRecordsAdjustmentHelper._adjustmentRecord != recordContainingScrollIndex || (scrollPos == 0 && flag)))
							{
								flag3 = true;
								break;
							}
							if (record == null || global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal.Top != record.FixedRecordLocationOverride)
							{
								break;
							}
							this._prefixRecords.Add(record);
						}
						if (flag3 && count < this._prefixRecords.Count)
						{
							this._prefixRecords.RemoveRange(count, this._prefixRecords.Count - count);
						}
					}
					if (flag && areChildrenAfterParent)
					{
						if (scrollPos == 0)
						{
							return recordContainingScrollIndex;
						}
						scrollPos--;
					}
					if (scrollPos >= 0 && recordContainingScrollIndex.IsExpanded)
					{
						global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableChildRecordsIfNeeded2 = recordContainingScrollIndex.ViewableChildRecordsIfNeeded;
						if (viewableChildRecordsIfNeeded2 == null)
						{
							return recordContainingScrollIndex;
						}
						if (flag && !areChildrenAfterParent && scrollPos == viewableChildRecordsIfNeeded2.ScrollCount)
						{
							return recordContainingScrollIndex;
						}
						return this.GetRecordAtScrollPosHelper(viewableChildRecordsIfNeeded2, scrollPos, calculating);
					}
				}
				return recordContainingScrollIndex;
			}

			// Token: 0x06001398 RID: 5016 RVA: 0x0005487C File Offset: 0x00052A7C
			private global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection.RecordsInViewGenerator.TopFixedAdjustmentInfo GetTopFixedRecordsAdjustmentHelper(global::Infragistics.Windows.DataPresenter.ViewableRecordCollection vrc, bool calculating)
			{
				global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection.RecordsInViewGenerator.TopFixedAdjustmentInfo topFixedAdjustmentInfo;
				if (this._adjustedVrc.TryGetValue(vrc, out topFixedAdjustmentInfo) || !calculating)
				{
					return topFixedAdjustmentInfo;
				}
				int countOfFixedRecordsOnTop = vrc.CountOfFixedRecordsOnTop;
				int num = countOfFixedRecordsOnTop;
				global::Infragistics.Windows.DataPresenter.Record record = null;
				if (countOfFixedRecordsOnTop > 0)
				{
					global::Infragistics.Windows.DataPresenter.Record record2 = vrc[countOfFixedRecordsOnTop - 1];
					if (record2.ScrollCountInternal > 1)
					{
						record = record2;
					}
				}
				if (num > 0 || record != null)
				{
					topFixedAdjustmentInfo = new global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection.RecordsInViewGenerator.TopFixedAdjustmentInfo(num, record);
					this._adjustedVrc[vrc] = topFixedAdjustmentInfo;
					return topFixedAdjustmentInfo;
				}
				return null;
			}

			// Token: 0x06001399 RID: 5017 RVA: 0x000548E4 File Offset: 0x00052AE4
			private bool IsRootFixedRecord(global::Infragistics.Windows.DataPresenter.Record record)
			{
				global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal fixedRecordLocationOverride = record.FixedRecordLocationOverride;
				return (global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal.Top == fixedRecordLocationOverride || global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal.Bottom == fixedRecordLocationOverride) && record.ParentCollection == this._coll._vrc.RecordCollection;
			}

			// Token: 0x0600139A RID: 5018 RVA: 0x0005491C File Offset: 0x00052B1C
			public global::Infragistics.Windows.DataPresenter.Record GetSuccessiveRecord()
			{
				this.EnsureCalculated();
				global::Infragistics.Windows.DataPresenter.Record recordAtScrollPosHelper;
				do
				{
					recordAtScrollPosHelper = this.GetRecordAtScrollPosHelper(this._coll._vrc, this._successiveScrollPos, false);
					this._successiveScrollPos++;
				}
				while (recordAtScrollPosHelper != null && this._prefixRecords.Contains(recordAtScrollPosHelper));
				if (recordAtScrollPosHelper != null)
				{
					if (this._successiveRecords == null)
					{
						this._successiveRecords = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record>();
					}
					this._successiveRecords.Add(recordAtScrollPosHelper);
				}
				return recordAtScrollPosHelper;
			}

			// Token: 0x170004B6 RID: 1206
			// (get) Token: 0x0600139B RID: 5019 RVA: 0x0005498A File Offset: 0x00052B8A
			public global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> PrefixRecords
			{
				get
				{
					this.EnsureCalculated();
					return this._prefixRecords;
				}
			}

			// Token: 0x170004B7 RID: 1207
			// (get) Token: 0x0600139C RID: 5020 RVA: 0x00054998 File Offset: 0x00052B98
			public global::Infragistics.Windows.DataPresenter.Record FirstRecord
			{
				get
				{
					this.EnsureCalculated();
					return this._firstRecord;
				}
			}

			// Token: 0x04000776 RID: 1910
			private global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection _coll;

			// Token: 0x04000777 RID: 1911
			private int _topScrollPos;

			// Token: 0x04000778 RID: 1912
			private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> _prefixRecords;

			// Token: 0x04000779 RID: 1913
			private global::Infragistics.Windows.DataPresenter.Record _firstRecord;

			// Token: 0x0400077A RID: 1914
			private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.ViewableRecordCollection, global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection.RecordsInViewGenerator.TopFixedAdjustmentInfo> _adjustedVrc;

			// Token: 0x0400077B RID: 1915
			private int _successiveScrollPos;

			// Token: 0x0400077C RID: 1916
			private bool _excludeRootFixedRecords = true;

			// Token: 0x0400077D RID: 1917
			internal global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> _successiveRecords;

			// Token: 0x02000159 RID: 345
			private class TopFixedAdjustmentInfo
			{
				// Token: 0x0600139D RID: 5021 RVA: 0x000549A6 File Offset: 0x00052BA6
				internal TopFixedAdjustmentInfo(int adjustment, global::Infragistics.Windows.DataPresenter.Record adjustmentRecord)
				{
					this._adjustment = adjustment;
					this._adjustmentRecord = adjustmentRecord;
				}

				// Token: 0x0400077E RID: 1918
				internal int _adjustment;

				// Token: 0x0400077F RID: 1919
				internal global::Infragistics.Windows.DataPresenter.Record _adjustmentRecord;
			}
		}
	}
}
