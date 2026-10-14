using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Threading;
using Infragistics.Collections;
using Infragistics.Windows.Controls;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000171 RID: 369
	internal class FlatScrollRecordsCollection : global::Infragistics.PropertyChangeNotifier, global::System.Collections.IList, global::System.Collections.ICollection, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record>, global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Record>, global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>, global::System.Collections.IEnumerable, global::System.Collections.Specialized.INotifyCollectionChanged
	{
		// Token: 0x060016BC RID: 5820 RVA: 0x00065388 File Offset: 0x00063588
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

		// Token: 0x060016BD RID: 5821 RVA: 0x00065446 File Offset: 0x00063646
		protected override void OnHasListenersChanged()
		{
			base.OnHasListenersChanged();
			this.OnHasListenersChangedInternal();
		}

		// Token: 0x060016BE RID: 5822 RVA: 0x00065454 File Offset: 0x00063654
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

		// Token: 0x060016BF RID: 5823 RVA: 0x000654BF File Offset: 0x000636BF
		public bool Contains(global::Infragistics.Windows.DataPresenter.Record record)
		{
			return this.IndexOf(record) >= 0;
		}

		// Token: 0x060016C0 RID: 5824 RVA: 0x000654D0 File Offset: 0x000636D0
		public void CopyTo(global::Infragistics.Windows.DataPresenter.Record[] array, int arrayIndex)
		{
			for (int i = 0; i < this.Count; i++)
			{
				array[arrayIndex++] = this[i];
			}
		}

		// Token: 0x060016C1 RID: 5825 RVA: 0x000654FD File Offset: 0x000636FD
		private void OnHasListenersChangedInternal()
		{
			if (!this.HasListeners && this._pendingNotifications != null)
			{
				this._pendingNotifications.Clear();
				this._pendingNotificationsHasReset = false;
			}
		}

		// Token: 0x060016C2 RID: 5826 RVA: 0x00065521 File Offset: 0x00063721
		public void BeginMeasure()
		{
			this.BeginMeasure(null);
		}

		// Token: 0x060016C3 RID: 5827 RVA: 0x0006552C File Offset: 0x0006372C
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

		// Token: 0x060016C4 RID: 5828 RVA: 0x00065584 File Offset: 0x00063784
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
					this.HookIntoGeneratedRecordsHelper(generatorsInMeasure, this._recordManager.DataPresenter.RecordContainerGenerationMode == global::Infragistics.Windows.Controls.ItemContainerGenerationMode.Recycle);
				}
			}
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x000655F8 File Offset: 0x000637F8
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

		// Token: 0x060016C6 RID: 5830 RVA: 0x000656C2 File Offset: 0x000638C2
		internal global::Infragistics.Windows.DataPresenter.Record GetRecordAtScrollPosition(int scrollPosition)
		{
			if (scrollPosition >= 0 && scrollPosition < this.CountOfNonHeaderRecords)
			{
				return this.GetRecordsInViewGenerator(scrollPosition).FirstRecord;
			}
			return null;
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x000656DF File Offset: 0x000638DF
		public global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection.RecordsInViewGenerator GetRecordsInViewGenerator(int topScrollPosition)
		{
			return new global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection.RecordsInViewGenerator(this, topScrollPosition);
		}

		// Token: 0x060016C8 RID: 5832 RVA: 0x000656E8 File Offset: 0x000638E8
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
						else
						{
							num2 -= vrc.IndexOf(record) + 1;
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

		// Token: 0x060016C9 RID: 5833 RVA: 0x000657B0 File Offset: 0x000639B0
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

		// Token: 0x060016CA RID: 5834 RVA: 0x000659B4 File Offset: 0x00063BB4
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

		// Token: 0x060016CB RID: 5835 RVA: 0x00065AA0 File Offset: 0x00063CA0
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

		// Token: 0x060016CC RID: 5836 RVA: 0x00065AFC File Offset: 0x00063CFC
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

		// Token: 0x060016CD RID: 5837 RVA: 0x00065BB8 File Offset: 0x00063DB8
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

		// Token: 0x060016CE RID: 5838 RVA: 0x00065BFE File Offset: 0x00063DFE
		private void EnsureItemsAllocated(global::Infragistics.Windows.DataPresenter.GridViewPanelFlat.GenerationCache generatorCache)
		{
			if (generatorCache != null && generatorCache._estimatedRecordsToLayout > 0)
			{
				this.EnsureItemsAllocated(generatorCache._currentScrollPosition, generatorCache._estimatedRecordsToLayout);
			}
		}

		// Token: 0x060016CF RID: 5839 RVA: 0x00065C20 File Offset: 0x00063E20
		private void EnsureItemsAllocated(int startIndex, int count)
		{
			global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecordCollection = null;
			global::Infragistics.Windows.DataPresenter.RecordManager recordManager = null;
			for (int i = 0; i < count; i++)
			{
				int num = startIndex + i;
				if (num >= this._vrc.ScrollCount)
				{
					return;
				}
				global::Infragistics.Windows.DataPresenter.Record record = this[num];
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

		// Token: 0x060016D0 RID: 5840 RVA: 0x00065C98 File Offset: 0x00063E98
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

		// Token: 0x060016D1 RID: 5841 RVA: 0x00065CBC File Offset: 0x00063EBC
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

		// Token: 0x060016D2 RID: 5842 RVA: 0x00065D0C File Offset: 0x00063F0C
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

		// Token: 0x060016D3 RID: 5843 RVA: 0x00065D93 File Offset: 0x00063F93
		private void OnFieldLayouts_CollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this.HookIntoFieldLayouts();
		}

		// Token: 0x060016D4 RID: 5844 RVA: 0x00065D9B File Offset: 0x00063F9B
		private void OnFieldLayout_SpecialRecordsVersionChanged()
		{
			this.RaiseCollectionChanged_Reset(true);
		}

		// Token: 0x060016D5 RID: 5845 RVA: 0x00065DA4 File Offset: 0x00063FA4
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

		// Token: 0x060016D6 RID: 5846 RVA: 0x00065E51 File Offset: 0x00064051
		private void RaisePendingNotificationsCallback()
		{
			this.RaisePendingNotifications();
		}

		// Token: 0x060016D7 RID: 5847 RVA: 0x00065E5C File Offset: 0x0006405C
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

		// Token: 0x060016D8 RID: 5848 RVA: 0x00065E95 File Offset: 0x00064095
		private void RaiseCollectionChanged_ResetAsync()
		{
			this.RaiseCollectionChanged_Reset(true);
		}

		// Token: 0x060016D9 RID: 5849 RVA: 0x00065EA0 File Offset: 0x000640A0
		private void RaiseCollectionChanged_Reset(bool async)
		{
			global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e = new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset);
			this.RaiseChangeEvent(e, async);
			this.RaiseChangeEvent(new global::System.ComponentModel.PropertyChangedEventArgs("Count"), async);
		}

		// Token: 0x060016DA RID: 5850 RVA: 0x00065ED0 File Offset: 0x000640D0
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

		// Token: 0x060016DB RID: 5851 RVA: 0x00065F9F File Offset: 0x0006419F
		private void RaiseCollectionChangedHelper(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs eventArgs)
		{
			if (this._collectionChanged != null)
			{
				this._collectionChanged(this, eventArgs);
			}
		}

		// Token: 0x060016DC RID: 5852 RVA: 0x00065FB8 File Offset: 0x000641B8
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

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x060016DD RID: 5853 RVA: 0x0006602E File Offset: 0x0006422E
		public int Count
		{
			get
			{
				return this._vrc.ScrollCount + this.CountOfHeaderRecords;
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x060016DE RID: 5854 RVA: 0x00066042 File Offset: 0x00064242
		public int CountOfFixedRecordsOnBottom
		{
			get
			{
				return this._vrc.CountOfFixedRecordsOnBottom;
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x060016DF RID: 5855 RVA: 0x0006604F File Offset: 0x0006424F
		public int CountOfFixedRecordsOnTop
		{
			get
			{
				return this._vrc.CountOfFixedRecordsOnTop;
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x060016E0 RID: 5856 RVA: 0x0006605C File Offset: 0x0006425C
		public bool HasPendingNotifications
		{
			get
			{
				return this._pendingNotifications != null && this._pendingNotifications.Count > 0;
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x060016E1 RID: 5857 RVA: 0x00066076 File Offset: 0x00064276
		public int CountOfHeaderRecords
		{
			get
			{
				return this._headers.Count;
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x060016E2 RID: 5858 RVA: 0x00066083 File Offset: 0x00064283
		public int CountOfNonHeaderRecords
		{
			get
			{
				return this._vrc.ScrollCount;
			}
		}

		// Token: 0x170005EE RID: 1518
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

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x060016E5 RID: 5861 RVA: 0x000660D4 File Offset: 0x000642D4
		internal new bool HasListeners
		{
			get
			{
				return this._collectionChanged != null || base.HasListeners;
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x060016E6 RID: 5862 RVA: 0x000660E6 File Offset: 0x000642E6
		internal global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.HeaderRecord> HeadersUsedInLastMeasure
		{
			get
			{
				return this._headersUsedInLastMeasure;
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x060016E7 RID: 5863 RVA: 0x000660EE File Offset: 0x000642EE
		internal bool IsMeasuring
		{
			get
			{
				return this._beginMeasureCount > 0;
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x060016E8 RID: 5864 RVA: 0x000660F9 File Offset: 0x000642F9
		internal global::Infragistics.Windows.DataPresenter.ViewableRecordCollection RootViewableRecords
		{
			get
			{
				return this._vrc;
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x060016E9 RID: 5865 RVA: 0x00066101 File Offset: 0x00064301
		internal global::Infragistics.Windows.DataPresenter.RecordManager RecordManager
		{
			get
			{
				return this._recordManager;
			}
		}

		// Token: 0x060016EA RID: 5866 RVA: 0x00066109 File Offset: 0x00064309
		void global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record>.Insert(int index, global::Infragistics.Windows.DataPresenter.Record item)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x060016EB RID: 5867 RVA: 0x0006611A File Offset: 0x0006431A
		void global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record>.RemoveAt(int index)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x060016EC RID: 5868 RVA: 0x0006612B File Offset: 0x0006432B
		void global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Record>.Add(global::Infragistics.Windows.DataPresenter.Record item)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x060016ED RID: 5869 RVA: 0x0006613C File Offset: 0x0006433C
		void global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Record>.Clear()
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x060016EE RID: 5870 RVA: 0x0006614D File Offset: 0x0006434D
		bool global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Record>.IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060016EF RID: 5871 RVA: 0x00066150 File Offset: 0x00064350
		bool global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Record>.Remove(global::Infragistics.Windows.DataPresenter.Record item)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_1"));
		}

		// Token: 0x060016F0 RID: 5872 RVA: 0x00066161 File Offset: 0x00064361
		public global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> GetEnumerator()
		{
			return new global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection.Enumerator(this);
		}

		// Token: 0x060016F1 RID: 5873 RVA: 0x00066169 File Offset: 0x00064369
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x14000062 RID: 98
		// (add) Token: 0x060016F2 RID: 5874 RVA: 0x00066174 File Offset: 0x00064374
		// (remove) Token: 0x060016F3 RID: 5875 RVA: 0x000661AC File Offset: 0x000643AC
		private event global::System.Collections.Specialized.NotifyCollectionChangedEventHandler _collectionChanged;

		// Token: 0x14000063 RID: 99
		// (add) Token: 0x060016F4 RID: 5876 RVA: 0x000661E1 File Offset: 0x000643E1
		// (remove) Token: 0x060016F5 RID: 5877 RVA: 0x00066200 File Offset: 0x00064400
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

		// Token: 0x060016F6 RID: 5878 RVA: 0x0006621F File Offset: 0x0006441F
		int global::System.Collections.IList.Add(object value)
		{
			((global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Record>)this).Add(value as global::Infragistics.Windows.DataPresenter.Record);
			return this.Count - 1;
		}

		// Token: 0x060016F7 RID: 5879 RVA: 0x00066235 File Offset: 0x00064435
		void global::System.Collections.IList.Clear()
		{
			((global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Record>)this).Clear();
		}

		// Token: 0x060016F8 RID: 5880 RVA: 0x0006623D File Offset: 0x0006443D
		bool global::System.Collections.IList.Contains(object value)
		{
			return ((global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Record>)this).Contains(value as global::Infragistics.Windows.DataPresenter.Record);
		}

		// Token: 0x060016F9 RID: 5881 RVA: 0x0006624B File Offset: 0x0006444B
		int global::System.Collections.IList.IndexOf(object value)
		{
			return ((global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record>)this).IndexOf(value as global::Infragistics.Windows.DataPresenter.Record);
		}

		// Token: 0x060016FA RID: 5882 RVA: 0x00066259 File Offset: 0x00064459
		void global::System.Collections.IList.Insert(int index, object value)
		{
			((global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record>)this).Insert(index, value as global::Infragistics.Windows.DataPresenter.Record);
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x060016FB RID: 5883 RVA: 0x00066268 File Offset: 0x00064468
		bool global::System.Collections.IList.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x060016FC RID: 5884 RVA: 0x0006626B File Offset: 0x0006446B
		bool global::System.Collections.IList.IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060016FD RID: 5885 RVA: 0x0006626E File Offset: 0x0006446E
		void global::System.Collections.IList.Remove(object value)
		{
			((global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.Record>)this).Remove(value as global::Infragistics.Windows.DataPresenter.Record);
		}

		// Token: 0x060016FE RID: 5886 RVA: 0x0006627D File Offset: 0x0006447D
		void global::System.Collections.IList.RemoveAt(int index)
		{
			((global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record>)this).RemoveAt(index);
		}

		// Token: 0x170005F7 RID: 1527
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

		// Token: 0x06001701 RID: 5889 RVA: 0x000662A0 File Offset: 0x000644A0
		void global::System.Collections.ICollection.CopyTo(global::System.Array array, int index)
		{
			for (int i = 0; i < this.Count; i++)
			{
				array.SetValue(this[i], index++);
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06001702 RID: 5890 RVA: 0x000662D1 File Offset: 0x000644D1
		bool global::System.Collections.ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06001703 RID: 5891 RVA: 0x000662D4 File Offset: 0x000644D4
		object global::System.Collections.ICollection.SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x04000912 RID: 2322
		private global::Infragistics.Windows.DataPresenter.RecordManager _recordManager;

		// Token: 0x04000913 RID: 2323
		private global::Infragistics.Windows.DataPresenter.ViewableRecordCollection _vrc;

		// Token: 0x04000914 RID: 2324
		private global::Infragistics.Collections.SparseArray _headers;

		// Token: 0x04000915 RID: 2325
		private global::Infragistics.Windows.DataPresenter.RecordCollectionBase _headerRecordsParentCollection;

		// Token: 0x04000916 RID: 2326
		private int _beginMeasureCount;

		// Token: 0x04000917 RID: 2327
		private bool[] _usedHeaders;

		// Token: 0x04000918 RID: 2328
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.HeaderRecord> _headersUsedInLastMeasure;

		// Token: 0x04000919 RID: 2329
		private global::System.Collections.Generic.List<global::Infragistics.Windows.Internal.PropertyValueTracker> _pvtTrackers = new global::System.Collections.Generic.List<global::Infragistics.Windows.Internal.PropertyValueTracker>();

		// Token: 0x0400091A RID: 2330
		private global::System.Collections.Generic.List<global::System.EventArgs> _pendingNotifications;

		// Token: 0x0400091B RID: 2331
		private int _desiredHeaderCount = 40;

		// Token: 0x0400091C RID: 2332
		private global::Infragistics.Windows.DataPresenter.FieldLayoutCollection _lastHookedFieldLayoutsColl;

		// Token: 0x0400091D RID: 2333
		private global::Infragistics.Collections.WeakDictionary<global::Infragistics.Windows.DataPresenter.FieldLayout, global::System.Collections.Generic.List<global::Infragistics.Windows.Internal.PropertyValueTracker>> _fieldLayoutPvtTrackers = new global::Infragistics.Collections.WeakDictionary<global::Infragistics.Windows.DataPresenter.FieldLayout, global::System.Collections.Generic.List<global::Infragistics.Windows.Internal.PropertyValueTracker>>(true, false);

		// Token: 0x0400091E RID: 2334
		private global::Infragistics.Collections.WeakDictionary<object, global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection.EventHandlerHolder> _hookedIntoObjects = new global::Infragistics.Collections.WeakDictionary<object, global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection.EventHandlerHolder>(true, false);

		// Token: 0x0400091F RID: 2335
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection.RecordsInViewGenerator> _generatorsInMeasure;

		// Token: 0x04000920 RID: 2336
		private bool _pendingNotificationsHasReset;

		// Token: 0x02000172 RID: 370
		private class Enumerator : global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x06001704 RID: 5892 RVA: 0x000662D7 File Offset: 0x000644D7
			internal Enumerator(global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection list)
			{
				this._list = list;
				this.Reset();
			}

			// Token: 0x170005FA RID: 1530
			// (get) Token: 0x06001705 RID: 5893 RVA: 0x000662EC File Offset: 0x000644EC
			public global::Infragistics.Windows.DataPresenter.Record Current
			{
				get
				{
					return this._current;
				}
			}

			// Token: 0x06001706 RID: 5894 RVA: 0x000662F4 File Offset: 0x000644F4
			public void Dispose()
			{
			}

			// Token: 0x170005FB RID: 1531
			// (get) Token: 0x06001707 RID: 5895 RVA: 0x000662F6 File Offset: 0x000644F6
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this._current;
				}
			}

			// Token: 0x06001708 RID: 5896 RVA: 0x000662FE File Offset: 0x000644FE
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

			// Token: 0x06001709 RID: 5897 RVA: 0x0006633B File Offset: 0x0006453B
			public void Reset()
			{
				this._index = -1;
			}

			// Token: 0x04000922 RID: 2338
			private global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection _list;

			// Token: 0x04000923 RID: 2339
			private int _index;

			// Token: 0x04000924 RID: 2340
			private global::Infragistics.Windows.DataPresenter.Record _current;
		}

		// Token: 0x02000173 RID: 371
		private class EventHandlerHolder
		{
			// Token: 0x0600170A RID: 5898 RVA: 0x00066344 File Offset: 0x00064544
			internal EventHandlerHolder(global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection flatRecords, global::System.ComponentModel.INotifyPropertyChanged obj)
			{
				this._flatRecords = flatRecords;
				this._obj = obj;
				this._handler = new global::System.ComponentModel.PropertyChangedEventHandler(this.OnPropertyChanged);
				obj.PropertyChanged += this._handler;
			}

			// Token: 0x0600170B RID: 5899 RVA: 0x00066378 File Offset: 0x00064578
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

			// Token: 0x0600170C RID: 5900 RVA: 0x000663EC File Offset: 0x000645EC
			internal void Unhook()
			{
				this._obj.PropertyChanged -= this._handler;
			}

			// Token: 0x04000925 RID: 2341
			internal global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection _flatRecords;

			// Token: 0x04000926 RID: 2342
			internal global::System.ComponentModel.INotifyPropertyChanged _obj;

			// Token: 0x04000927 RID: 2343
			internal global::System.ComponentModel.PropertyChangedEventHandler _handler;
		}

		// Token: 0x02000174 RID: 372
		public class RecordsInViewGenerator
		{
			// Token: 0x0600170D RID: 5901 RVA: 0x000663FF File Offset: 0x000645FF
			public RecordsInViewGenerator(global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection coll, int topScrollPos)
			{
				this._coll = coll;
				this._topScrollPos = topScrollPos;
				if (this._coll._generatorsInMeasure != null)
				{
					this._coll._generatorsInMeasure.Add(this);
				}
			}

			// Token: 0x0600170E RID: 5902 RVA: 0x0006643C File Offset: 0x0006463C
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

			// Token: 0x0600170F RID: 5903 RVA: 0x00066494 File Offset: 0x00064694
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

			// Token: 0x06001710 RID: 5904 RVA: 0x00066638 File Offset: 0x00064838
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

			// Token: 0x06001711 RID: 5905 RVA: 0x000666A0 File Offset: 0x000648A0
			private bool IsRootFixedRecord(global::Infragistics.Windows.DataPresenter.Record record)
			{
				global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal fixedRecordLocationOverride = record.FixedRecordLocationOverride;
				return (global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal.Top == fixedRecordLocationOverride || global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal.Bottom == fixedRecordLocationOverride) && record.ParentCollection == this._coll._vrc.RecordCollection;
			}

			// Token: 0x06001712 RID: 5906 RVA: 0x000666D8 File Offset: 0x000648D8
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

			// Token: 0x170005FC RID: 1532
			// (get) Token: 0x06001713 RID: 5907 RVA: 0x00066746 File Offset: 0x00064946
			public global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> PrefixRecords
			{
				get
				{
					this.EnsureCalculated();
					return this._prefixRecords;
				}
			}

			// Token: 0x170005FD RID: 1533
			// (get) Token: 0x06001714 RID: 5908 RVA: 0x00066754 File Offset: 0x00064954
			public global::Infragistics.Windows.DataPresenter.Record FirstRecord
			{
				get
				{
					this.EnsureCalculated();
					return this._firstRecord;
				}
			}

			// Token: 0x04000928 RID: 2344
			private global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection _coll;

			// Token: 0x04000929 RID: 2345
			private int _topScrollPos;

			// Token: 0x0400092A RID: 2346
			private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> _prefixRecords;

			// Token: 0x0400092B RID: 2347
			private global::Infragistics.Windows.DataPresenter.Record _firstRecord;

			// Token: 0x0400092C RID: 2348
			private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.ViewableRecordCollection, global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection.RecordsInViewGenerator.TopFixedAdjustmentInfo> _adjustedVrc;

			// Token: 0x0400092D RID: 2349
			private int _successiveScrollPos;

			// Token: 0x0400092E RID: 2350
			private bool _excludeRootFixedRecords = true;

			// Token: 0x0400092F RID: 2351
			internal global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> _successiveRecords;

			// Token: 0x02000175 RID: 373
			private class TopFixedAdjustmentInfo
			{
				// Token: 0x06001715 RID: 5909 RVA: 0x00066762 File Offset: 0x00064962
				internal TopFixedAdjustmentInfo(int adjustment, global::Infragistics.Windows.DataPresenter.Record adjustmentRecord)
				{
					this._adjustment = adjustment;
					this._adjustmentRecord = adjustmentRecord;
				}

				// Token: 0x04000930 RID: 2352
				internal int _adjustment;

				// Token: 0x04000931 RID: 2353
				internal global::Infragistics.Windows.DataPresenter.Record _adjustmentRecord;
			}
		}
	}
}
