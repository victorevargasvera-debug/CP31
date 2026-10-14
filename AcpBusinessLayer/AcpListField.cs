using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;
using AcpBusinessLayer.Impl;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using AcpCommonResources;
using AcpUtility;

namespace AcpBusinessLayer
{
	// Token: 0x02000015 RID: 21
	[global::System.Serializable]
	public class AcpListField : global::AcpBusinessLayer.AcpFieldX<int, string>, global::AcpCommonLib.IAcpListField
	{
		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x00024978 File Offset: 0x00022B78
		// (set) Token: 0x060001E1 RID: 481 RVA: 0x00024A34 File Offset: 0x00022C34
		public global::AcpBusinessLayer.AcpListField BuddyList
		{
			get
			{
				short num = (short)1654938068;
				short num2 = num;
				num = (short)1694259668;
				switch (num2 == num)
				{
				}
				num = (short)1031405569;
				if (num != 0)
				{
				}
				num = (short)1024655360;
				short num3 = num;
				num = (short)222691328;
				if (num != 0)
				{
				}
				return ((global::AcpBusinessLayer.Impl.AcpListFieldImpl)base.FieldData).BuddyList;
			}
			set
			{
				short num = (short)1583720270;
				short num2 = num;
				num = (short)610445134;
				switch (num2 == num)
				{
				}
				num = (short)1132724224;
				if (num != 0)
				{
				}
				num = (short)2086928384;
				short num3 = num;
				num = (short)2075525121;
				if (num != 0)
				{
				}
				((global::AcpBusinessLayer.Impl.AcpListFieldImpl)base.FieldData).BuddyList = value;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x00024AEC File Offset: 0x00022CEC
		// (set) Token: 0x060001E3 RID: 483 RVA: 0x00024B9C File Offset: 0x00022D9C
		public virtual global::System.Collections.ObjectModel.ObservableCollection<global::AcpBusinessLayer.ListItem> Items
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)99135781;
				short num2 = num;
				num = (short)2105848101;
				switch (num2 == num)
				{
				}
				num = (short)1435959297;
				if (num != 0)
				{
				}
				num = (short)937295872;
				short num3 = num;
				num = (short)639959040;
				if (num != 0)
				{
				}
				return this.<Items>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			internal set
			{
				short num = (short)609312008;
				short num2 = num;
				num = (short)474373384;
				switch (num2 == num)
				{
				}
				num = (short)468123649;
				if (num != 0)
				{
				}
				num = (short)1355022336;
				short num3 = num;
				num = (short)1397161984;
				if (num != 0)
				{
				}
				this.<Items>k__BackingField = value;
			}
		}

		// Token: 0x1700007E RID: 126
		internal global::AcpBusinessLayer.ListItem this[int index]
		{
			get
			{
				while (index >= this.Items.Count)
				{
					short num = (short)656408576;
					short num2 = num;
					num = (short)1389923690;
					short num3 = num;
					num = (short)634031466;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1325465601;
						if (num != 0)
						{
						}
						num = (short)776732672;
						if (num != 0)
						{
						}
						return null;
					}
				}
				return this.Items[index];
			}
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00024D18 File Offset: 0x00022F18
		internal int IndexOf(global::AcpBusinessLayer.ListItem item)
		{
			short num = (short)1972321551;
			short num2 = num;
			num = (short)516242703;
			switch (num2 == num)
			{
			}
			num = (short)1506410497;
			if (num != 0)
			{
			}
			num = (short)900071424;
			short num3 = num;
			num = (short)1701707776;
			if (num != 0)
			{
			}
			return this.Items.IndexOf(item);
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x00024DD0 File Offset: 0x00022FD0
		// (set) Token: 0x060001E7 RID: 487 RVA: 0x00024E8C File Offset: 0x0002308C
		public bool SerializeItems
		{
			get
			{
				short num = (short)1623953851;
				short num2 = num;
				num = (short)1184928187;
				switch (num2 == num)
				{
				}
				num = (short)1464664064;
				if (num != 0)
				{
				}
				num = (short)933167104;
				short num3 = num;
				num = (short)258015233;
				if (num != 0)
				{
				}
				return ((global::AcpBusinessLayer.Impl.AcpListFieldImpl)base.FieldData).SerializeItems;
			}
			private set
			{
				short num = (short)2126997027;
				short num2 = num;
				num = (short)1256220195;
				switch (num2 == num)
				{
				}
				num = (short)1474035713;
				if (num != 0)
				{
				}
				num = (short)101711872;
				short num3 = num;
				num = (short)927334400;
				if (num != 0)
				{
				}
				((global::AcpBusinessLayer.Impl.AcpListFieldImpl)base.FieldData).SerializeItems = value;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x00024F48 File Offset: 0x00023148
		// (set) Token: 0x060001E9 RID: 489 RVA: 0x00025004 File Offset: 0x00023204
		public bool UndoIgnoresSelection
		{
			get
			{
				short num = (short)281266451;
				short num2 = num;
				num = (short)210028819;
				switch (num2 == num)
				{
				}
				num = (short)465829888;
				if (num != 0)
				{
				}
				num = (short)1534328832;
				short num3 = num;
				num = (short)1054015489;
				if (num != 0)
				{
				}
				return ((global::AcpBusinessLayer.Impl.AcpListFieldImpl)base.FieldData).UndoIgnoresSelection;
			}
			set
			{
				short num = (short)1782177626;
				short num2 = num;
				num = (short)1166466906;
				switch (num2 == num)
				{
				}
				num = (short)567148545;
				if (num != 0)
				{
				}
				num = (short)1187708928;
				short num3 = num;
				num = (short)80084992;
				if (num != 0)
				{
				}
				((global::AcpBusinessLayer.Impl.AcpListFieldImpl)base.FieldData).UndoIgnoresSelection = value;
			}
		}

		// Token: 0x060001EA RID: 490 RVA: 0x000250BC File Offset: 0x000232BC
		protected AcpListField()
		{
		}

		// Token: 0x060001EB RID: 491 RVA: 0x000250D0 File Offset: 0x000232D0
		public AcpListField(global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, string[] items) : this(parent, name, uiLabel)
		{
			foreach (string name2 in items)
			{
				this.AddItemHelper(name2);
			}
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00025108 File Offset: 0x00023308
		public AcpListField(global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, string[] items, string[] legacyUILabels) : this(parent, name, legacyUILabels, uiLabel)
		{
			foreach (string name2 in items)
			{
				this.AddItemHelper(name2);
			}
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00025144 File Offset: 0x00023344
		public AcpListField(int value, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, string[] items) : this(value, parent, name, uiLabel)
		{
			foreach (string name2 in items)
			{
				this.AddItemHelper(name2);
			}
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00025180 File Offset: 0x00023380
		public AcpListField(int value, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, string[] items, string[] legacyUILabels) : base(value, parent, name, uiLabel, legacyUILabels)
		{
			this.Items = new global::System.Collections.ObjectModel.ObservableCollection<global::AcpBusinessLayer.ListItem>();
			this._collectionChangedHandler = new global::System.Collections.Specialized.NotifyCollectionChangedEventHandler(this.a);
			this.a();
			foreach (string name2 in items)
			{
				this.AddItemHelper(name2);
			}
		}

		// Token: 0x060001EF RID: 495 RVA: 0x000251E0 File Offset: 0x000233E0
		public AcpListField(int value, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, bool sortItems, string[] items) : this(value, parent, name, uiLabel)
		{
			if (sortItems)
			{
				global::System.Array.Sort<string>(items);
			}
			foreach (string name2 in items)
			{
				this.AddItemHelper(name2);
			}
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00025228 File Offset: 0x00023428
		public AcpListField(int value, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, bool sortItems, string[] items, string[] legacyUILabels) : this(value, parent, name, uiLabel, legacyUILabels)
		{
			if (sortItems)
			{
				global::System.Array.Sort<string>(items);
			}
			foreach (string name2 in items)
			{
				this.AddItemHelper(name2);
			}
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00025274 File Offset: 0x00023474
		protected AcpListField(global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, bool serializeItems) : this(parent, name, uiLabel)
		{
			this.SerializeItems = serializeItems;
			if (!parent.HasListItemsToSerialize)
			{
				parent.HasListItemsToSerialize = serializeItems;
			}
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x000252A8 File Offset: 0x000234A8
		protected AcpListField(int value, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, bool serializeItems) : this(value, parent, name, uiLabel)
		{
			this.SerializeItems = serializeItems;
			if (!parent.HasListItemsToSerialize)
			{
				parent.HasListItemsToSerialize = serializeItems;
			}
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x000252DC File Offset: 0x000234DC
		protected AcpListField(global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, string[] items, bool serializeItems) : this(parent, name, uiLabel, items)
		{
			this.SerializeItems = serializeItems;
			if (!parent.HasListItemsToSerialize)
			{
				parent.HasListItemsToSerialize = serializeItems;
			}
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00025310 File Offset: 0x00023510
		protected AcpListField(global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, string[] items, bool serializeItems, string[] legacyUILabels) : this(parent, name, legacyUILabels, uiLabel)
		{
			foreach (string name2 in items)
			{
				this.AddItemHelper(name2);
			}
			this.SerializeItems = serializeItems;
			if (!parent.HasListItemsToSerialize)
			{
				parent.HasListItemsToSerialize = serializeItems;
			}
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00025368 File Offset: 0x00023568
		protected AcpListField(int value, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, string[] items, bool serializeItems) : this(value, parent, name, uiLabel, items)
		{
			this.SerializeItems = serializeItems;
			if (!parent.HasListItemsToSerialize)
			{
				parent.HasListItemsToSerialize = serializeItems;
			}
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x000253A0 File Offset: 0x000235A0
		protected AcpListField(global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel) : base(parent, name, uiLabel)
		{
			this.Items = new global::System.Collections.ObjectModel.ObservableCollection<global::AcpBusinessLayer.ListItem>();
			this._collectionChangedHandler = new global::System.Collections.Specialized.NotifyCollectionChangedEventHandler(this.a);
			this.a();
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x000253DC File Offset: 0x000235DC
		protected AcpListField(global::AcpBusinessLayer.FeatureSection parent, string name, string[] legacyUILabels, string uiLabel) : base(parent, name, uiLabel, legacyUILabels)
		{
			this.Items = new global::System.Collections.ObjectModel.ObservableCollection<global::AcpBusinessLayer.ListItem>();
			this._collectionChangedHandler = new global::System.Collections.Specialized.NotifyCollectionChangedEventHandler(this.a);
			this.a();
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00025418 File Offset: 0x00023618
		protected AcpListField(int value, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel) : base(value, parent, name, uiLabel)
		{
			this.Items = new global::System.Collections.ObjectModel.ObservableCollection<global::AcpBusinessLayer.ListItem>();
			this._collectionChangedHandler = new global::System.Collections.Specialized.NotifyCollectionChangedEventHandler(this.a);
			this.a();
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00025454 File Offset: 0x00023654
		public virtual void AddItem(string name)
		{
			while (global::AcpCommonLib.UndoRedo.UndoManager.MarkForUndo)
			{
				short num = (short)2039152640;
				short num2 = num;
				num = (short)542374192;
				short num3 = num;
				num = (short)707852592;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)113901569;
					if (num != 0)
					{
					}
					num = (short)215285760;
					if (num != 0)
					{
					}
					global::AcpCommonLib.UndoRedo.UndoManager.AddTask(new global::AcpBusinessLayer.UndoRedo.AddListItemTask(this, name));
					return;
				}
			}
			this.AddItemHelper(name);
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0002551C File Offset: 0x0002371C
		internal int AddItemHelper(string name)
		{
			short num = (short)1723203584;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 1:
					goto IL_102;
				case 2:
					goto IL_12A;
				}
				IL_30:
				num = (short)988658716;
				short num3 = num;
				num = (short)1667349532;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_102:
					((global::AcpBusinessLayer.Impl.AcpListFieldImpl)base.FieldData).DoubleItems();
					num = (short)686161922;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					break;
				default:
				{
					num = (short)1496907776;
					short num4 = num;
					break;
				}
				}
				num = (short)540868609;
				if (num != 0)
				{
				}
				num = (short)1162149888;
				if (num != 0)
				{
				}
				if (this.Items.Count < ((global::AcpBusinessLayer.Impl.AcpListFieldImpl)base.FieldData).ItemCount)
				{
					break;
				}
				num = (short)1447231489;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_12A:
			int count = this.Items.Count;
			this.Items.Add(new global::AcpBusinessLayer.ListItem(this, name));
			return count;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00025674 File Offset: 0x00023874
		internal void InsertItem(int index, string name)
		{
			short num = (short)915861307;
			short num2 = num;
			num = (short)1398861627;
			switch (num2 == num)
			{
			}
			num = (short)2122842112;
			if (num != 0)
			{
			}
			num = (short)1542979584;
			short num3 = num;
			num = (short)1927610369;
			if (num != 0)
			{
			}
			this.Items.Insert(index, new global::AcpBusinessLayer.ListItem(this, name));
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00025730 File Offset: 0x00023930
		internal void RemoveItem(string name)
		{
			short num = (short)1572844311;
			short num2 = num;
			num = (short)742372119;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1489371136;
				short num3 = num;
				num = (short)640745472;
				if (num != 0)
				{
				}
				num = (short)236453889;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.ListItem> enumerator = this.Items.GetEnumerator();
				try
				{
					num = (short)1553989634;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							num = (short)401473542;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_183;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_E8;
							}
							continue;
						case 3:
						{
							global::AcpBusinessLayer.ListItem listItem;
							this.Items.Remove(listItem);
							num = (short)878575617;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							global::AcpBusinessLayer.ListItem listItem;
							if (listItem.ItemName == name)
							{
								num = (short)829358083;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1044774912;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpBusinessLayer.ListItem listItem = enumerator.Current;
							num = (short)1510670340;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							goto IL_19F;
						}
						IL_129:
						num = (short)874840069;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_E8:
						goto IL_129;
					}
					IL_183:
					IL_19F:;
				}
				finally
				{
					num = (short)30015488;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_1D2;
							}
							continue;
						case 1:
							enumerator.Dispose();
							num = (short)1202520066;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_208;
						}
						IL_1D2:
						if (enumerator == null)
						{
							break;
						}
						num = (short)550830081;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_208:;
				}
				break;
			}
			}
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00025958 File Offset: 0x00023B58
		public string RemoveItemAt(int index)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			string result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return result;
				case 1:
				{
					num2 = (short)552743534;
					short num3 = num2;
					num2 = (short)1711813230;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
					{
						num2 = (short)1569193984;
						if (num2 != 0)
						{
						}
						if (global::AcpCommonLib.UndoRedo.UndoManager.MarkForUndo)
						{
							num2 = (short)289669122;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						result = this.Items[index].ItemName;
						this.Items.RemoveAt(index);
						num2 = (short)1532821504;
						short num4 = num2;
						num2 = (short)2078670848;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 2:
					global::AcpCommonLib.UndoRedo.UndoManager.AddTask(new global::AcpBusinessLayer.UndoRedo.RemoveListItemTask(this, index));
					num2 = (short)780140545;
					if (num2 != 0)
					{
					}
					num2 = (short)229900291;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					return result;
				}
				goto IL_20;
			}
			return result;
			IL_20:
			result = null;
			num2 = (short)952893441;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00025AB8 File Offset: 0x00023CB8
		public void MoveItem(int oldIndex, int newIndex)
		{
			while (global::AcpCommonLib.UndoRedo.UndoManager.MarkForUndo)
			{
				short num = (short)1351352320;
				short num2 = num;
				num = (short)1998292858;
				short num3 = num;
				num = (short)787646330;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)2001207297;
					if (num != 0)
					{
					}
					num = (short)579665920;
					if (num != 0)
					{
					}
					global::AcpCommonLib.UndoRedo.UndoManager.AddTask(new global::AcpBusinessLayer.UndoRedo.MoveListItemTask(this, oldIndex, newIndex));
					return;
				}
			}
			this.MoveItemHelper(oldIndex, newIndex);
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00025B84 File Offset: 0x00023D84
		internal void MoveItemHelper(int oldIndex, int newIndex)
		{
			short num = (short)1212117958;
			short num2 = num;
			num = (short)930640838;
			switch (num2 == num)
			{
			}
			num = (short)1544159233;
			if (num != 0)
			{
			}
			num = (short)1166934016;
			short num3 = num;
			num = (short)302579712;
			if (num != 0)
			{
			}
			this.Items.Move(oldIndex, newIndex);
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00025C38 File Offset: 0x00023E38
		public override void ParseDefaultValueFrom(string value)
		{
			short num = (short)1299578881;
			if (num != 0)
			{
			}
			num = (short)161178277;
			short num2 = num;
			num = (short)444490405;
			switch (num2 == num)
			{
			}
			num = (short)1810366464;
			short num3 = num;
			num = (short)1977745408;
			if (num != 0)
			{
			}
			this.DefaultValue = this.a(value);
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00025CEC File Offset: 0x00023EEC
		private int a(string A_0)
		{
			int result;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_30;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_132;
					case 1:
					{
						if (int.TryParse(A_0, out result))
						{
							num2 = (short)254083077;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						int num3 = 0;
						num2 = (short)1349320706;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 2:
						goto IL_132;
					case 3:
					{
						int num3;
						if (num3 >= this.Items.Count)
						{
							num2 = (short)1751646215;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1241382916;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 4:
					{
						int num3;
						if (this.Items[num3].ItemName == A_0)
						{
							num2 = (short)274137094;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num3++;
						num2 = (short)1443561472;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 5:
						return result;
					case 6:
					{
						int num3;
						return num3;
					}
					case 7:
						goto IL_1C1;
					}
					break;
					IL_132:
					num2 = (short)1124171635;
					short num4 = num2;
					num2 = (short)1978105715;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_00;
					default:
						num2 = (short)1672871936;
						if (num2 != 0)
						{
						}
						num2 = (short)1684865027;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
				}
				IL_30:
				num2 = (short)488046593;
				if (num2 != 0)
				{
				}
				num2 = (short)1802895360;
				short num5 = num2;
				base.UnsupportedValue = false;
				num2 = (short)1778581505;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			return result;
			IL_1C1:
			base.UnsupportedValue = true;
			return this.Value;
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000202 RID: 514 RVA: 0x00025EEC File Offset: 0x000240EC
		// (set) Token: 0x06000203 RID: 515 RVA: 0x00025FAC File Offset: 0x000241AC
		public override string UIValue
		{
			get
			{
				short num = (short)119355181;
				short num2 = num;
				num = (short)41563949;
				switch (num2 == num)
				{
				}
				num = (short)2047082497;
				if (num != 0)
				{
				}
				num = (short)742195200;
				short num3 = num;
				num = (short)665190400;
				if (num != 0)
				{
				}
				return this.Items[this.Value].ItemName;
			}
			set
			{
				short num = (short)1884291072;
				switch (num)
				{
				default:
				{
					num = (short)419889154;
					int num2 = (int)((global::System.IntPtr)num);
					int num3;
					int num5;
					for (;;)
					{
						bool itemVisibility;
						bool flag;
						bool flag2;
						switch (num2)
						{
						case 0:
							num = (short)1937375244;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (!global::AcpCommonLib.AppInfoManager.DragOperation)
							{
								num = (short)1431306259;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1870331910;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_B9;
							}
							continue;
						case 3:
							goto IL_2A0;
						case 4:
							if (itemVisibility)
							{
								num = (short)966393876;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3FE;
						case 5:
							if (num3 != -1)
							{
								num = (short)1128267779;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_51C;
						case 6:
							flag = false;
							goto IL_3B8;
						case 7:
						{
							num = (short)1111445107;
							short num4 = num;
							num = (short)32525939;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_517;
							default:
								num = (short)399769600;
								if (num != 0)
								{
								}
								flag = !global::AcpCommonLib.AppInfoManager.BackgroundDeserializeOpertaion;
								goto IL_3B8;
							}
							break;
						}
						case 8:
							num = (short)1331429381;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							if (!global::AcpCommonLib.AppInfoManager.DragOperation)
							{
								num = (short)172097553;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2A5;
						case 10:
							num3 = num5;
							num = (short)342294543;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							goto IL_17A;
						case 12:
							if (num5 == this.DefaultValue)
							{
								num = (short)187432970;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3DD;
						case 13:
							goto IL_17A;
						case 14:
							goto IL_3D8;
						case 15:
							goto IL_3DD;
						case 16:
							if (!global::AcpCommonLib.AppInfoManager.BackgroundDeserializeOpertaion)
							{
								num = (short)1471938585;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2A5;
						case 17:
							num = (short)1933377552;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 18:
							goto IL_517;
						case 19:
							num = (short)1992425479;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 20:
							flag2 = false;
							num = (short)2119827457;
							if (num != 0)
							{
							}
							num = (short)1569128466;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 21:
							return;
						case 22:
						{
							string itemName;
							if (itemName == value)
							{
								num = (short)313720855;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_FD;
						}
						case 23:
							num = (short)1597767689;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 24:
						{
							if (num5 >= this.Items.Count)
							{
								num = (short)1904738330;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							string itemName = this.Items[num5].ItemName;
							itemVisibility = this.Items[num5].ItemVisibility;
							num = (short)184942614;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 25:
							num = (short)1655111681;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 26:
							num = (short)869400603;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 27:
							if (flag2)
							{
								num = (short)838991880;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_51C;
						case 28:
						{
							num = (short)1709899776;
							short num6 = num;
							string itemName;
							if (itemName == value)
							{
								num = (short)1141243904;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3DD;
						}
						}
						IL_B9:
						if (value == null)
						{
							num = (short)517210133;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag2 = true;
						num3 = -1;
						num5 = 0;
						num = (short)156434445;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_FD:
						num = (short)304807940;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3B8:
						if (flag && itemVisibility)
						{
							num = (short)48693262;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FD;
						IL_17A:
						num = (short)1740439576;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3DD:
						num5++;
						num = (short)642449419;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3FE:
						num = (short)304349212;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_517:
						goto IL_3FE;
					}
					return;
					IL_2A0:
					this.Value = num3;
					base.UnsupportedValue = false;
					return;
					IL_2A5:
					this.Value = num5;
					base.UnsupportedValue = false;
					return;
					IL_3D8:
					goto IL_2A5;
					IL_51C:
					base.UnsupportedValue = true;
					throw new global::System.ArgumentException(global::AcpCommonResources.AcpResources.Cannot_Be_Set.AcpStringFormat(new object[]
					{
						base.Name,
						value
					}));
				}
				}
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000204 RID: 516 RVA: 0x00026500 File Offset: 0x00024700
		// (set) Token: 0x06000205 RID: 517 RVA: 0x000265B0 File Offset: 0x000247B0
		public override int Value
		{
			get
			{
				short num = (short)1867716998;
				short num2 = num;
				num = (short)1451432326;
				switch (num2 == num)
				{
				}
				num = (short)1436745729;
				if (num != 0)
				{
				}
				num = (short)209518592;
				short num3 = num;
				num = (short)1241513984;
				if (num != 0)
				{
				}
				return base.Value;
			}
			set
			{
				short num = (short)1540161537;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_197;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_48;
						}
						continue;
					case 2:
						goto IL_6D;
					case 3:
						if (this.Items != null)
						{
							num = (short)1823670279;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6D;
					case 4:
					{
						num = (short)1518206976;
						short num3 = num;
						num = (short)1299316739;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_A4;
					case 6:
						if (this.UndoIgnoresSelection)
						{
							goto IL_8D;
						}
						base.Value = value;
						num = (short)830799872;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)87490561;
						if (num != 0)
						{
						}
						num = (short)162856968;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (value < this.Items.Count)
						{
							num = (short)502136834;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_197;
					}
					IL_48:
					if (value >= 0)
					{
						num = (short)975765508;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_197;
					IL_6D:
					num = (short)629342214;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8D:
					num = (short)2020343813;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_197:
					num = (short)1649006009;
					short num4 = num;
					num = (short)1529533881;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_8D;
					default:
						goto IL_1CE;
					}
				}
				IL_A4:
				this.SetValue(value);
				return;
				IL_1CE:
				num = (short)2096365568;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x06000206 RID: 518 RVA: 0x000267A0 File Offset: 0x000249A0
		internal override int CompareToHelper(global::AcpBusinessLayer.AcpFieldBase otherField)
		{
			short num = (short)1204879360;
			switch (num)
			{
			default:
			{
				num = (short)471924744;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					int num4;
					switch (num2)
					{
					case 0:
					{
						global::AcpBusinessLayer.ListItem listItem;
						global::AcpBusinessLayer.ListItem listItem2;
						if (listItem.ItemVisibility != listItem2.ItemVisibility)
						{
							num = (short)1523122187;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)891699268;
						short num3 = num;
						num = (short)183910468;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1F6;
						default:
							num = (short)103284736;
							if (num != 0)
							{
							}
							num4++;
							num = (short)1444216834;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
					{
						int num5;
						if (num5 != 0)
						{
							num = (short)1441988618;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1473642496;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_1DE;
					case 3:
						goto IL_1DE;
					case 4:
						goto IL_1F6;
					case 5:
						goto IL_13C;
					case 6:
					{
						global::AcpBusinessLayer.AcpListField acpListField;
						if (this.Items.Count < acpListField.Items.Count)
						{
							num = (short)188022799;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1621360653;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						global::AcpBusinessLayer.AcpListField acpListField = (global::AcpBusinessLayer.AcpListField)otherField;
						num = (short)1984888838;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						switch (0)
						{
						case 0:
							goto IL_83;
						}
						continue;
					case 9:
						return -1;
					case 10:
					{
						int num5;
						return num5;
					}
					case 11:
						num = (short)1346437121;
						if (num != 0)
						{
						}
						num = (short)305463310;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						return 0;
					case 13:
					{
						global::AcpBusinessLayer.AcpListField acpListField;
						if (this.Items.Count > acpListField.Items.Count)
						{
							num = (short)1011482629;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num5 = 0;
						num4 = 0;
						num = (short)776208387;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
					{
						global::AcpBusinessLayer.ListItem listItem;
						if (!listItem.ItemVisibility)
						{
							num = (short)620953609;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return 1;
					}
					case 15:
						return -1;
					}
					IL_83:
					if (this.SerializeItems)
					{
						num = (short)946143239;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_36F;
					IL_1DE:
					num = (short)1867513860;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1F6:
					if (num4 >= this.Items.Count)
					{
						num = (short)368574476;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						global::AcpBusinessLayer.ListItem listItem = this.Items[num4];
						global::AcpBusinessLayer.AcpListField acpListField;
						global::AcpBusinessLayer.ListItem listItem2 = acpListField.Items[num4];
						int num5 = listItem.ItemName.CompareTo(listItem2.ItemName);
						num = (short)1069547521;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_13C:
				num = (short)1351221248;
				short num6 = num;
				return 1;
				IL_36F:
				return base.CompareToHelper(otherField);
			}
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000207 RID: 519 RVA: 0x00026B24 File Offset: 0x00024D24
		// (set) Token: 0x06000208 RID: 520 RVA: 0x00026BE8 File Offset: 0x00024DE8
		public override global::AcpCommonLib.StateConstraint IsValid
		{
			get
			{
				int a_ = 16;
				short num = (short)1391600887;
				short num2 = num;
				num = (short)739845367;
				switch (num2 == num)
				{
				}
				num = (short)741605376;
				if (num != 0)
				{
				}
				num = (short)782303233;
				if (num != 0)
				{
				}
				num = (short)1195376640;
				short num3 = num;
				throw new global::System.InvalidOperationException(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("ꏡ蟣雥ꓧ菩鿫髭뛯鯱釳髵鳷\udaf9飻釽旿焁␃栅朇縉Ⰻ納攏我搓礕樗渙㰛樝䠟䬡圣إ堧堩䌫席唯䀱䀳伵ᘷᨹ᰻欽㌿❁摃ཅ㭇͉≋⩍㕏⩑ɓ㝕㑗㍙㡛繝य़ౡᝣብ൧୩࡫䁭", a_));
			}
			set
			{
				int a_ = 11;
				short num = (short)1614073939;
				short num2 = num;
				num = (short)82759763;
				switch (num2 == num)
				{
				}
				num = (short)846856192;
				if (num != 0)
				{
				}
				num = (short)749731841;
				if (num != 0)
				{
				}
				num = (short)682098688;
				short num3 = num;
				throw new global::System.InvalidOperationException(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("鳜볞釠꿢賤铦鷨귪蓬諮鷰韲헴鏶雸黺軼\udffe漀氂焄✆稈縊紌缎縐愒愔㜖洘猚琜氞Ġ匢圤䠦夨个弬嬮䠰ᴲᔴ᜶永䠺堼Ἶࡀあౄ⥆ⵈ⹊㕌᥎ぐ㽒㱔㍖祘㉚㍜ⱞᕠ٢Ѥͦ䝨", a_));
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000209 RID: 521 RVA: 0x00026CB0 File Offset: 0x00024EB0
		// (set) Token: 0x0600020A RID: 522 RVA: 0x00026D68 File Offset: 0x00024F68
		public global::AcpCommonLib.ListItemStateConstraint IsIndexValid
		{
			get
			{
				short num = (short)1808983999;
				short num2 = num;
				num = (short)825092031;
				switch (num2 == num)
				{
				}
				num = (short)440467457;
				if (num != 0)
				{
				}
				num = (short)1229848576;
				if (num != 0)
				{
				}
				num = (short)255197184;
				short num3 = num;
				return ((global::AcpBusinessLayer.Impl.AcpListFieldImpl)base.FieldData).IsIndexValid;
			}
			set
			{
				short num = (short)445169098;
				short num2 = num;
				num = (short)420789706;
				switch (num2 == num)
				{
				}
				num = (short)949878785;
				if (num != 0)
				{
				}
				num = (short)1281949696;
				if (num != 0)
				{
				}
				num = (short)2090467328;
				short num3 = num;
				((global::AcpBusinessLayer.FeatureNode)base.Parent.Parent).RegisterValidity(this);
				((global::AcpBusinessLayer.Impl.AcpListFieldImpl)base.FieldData).IsIndexValid = value;
			}
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00026E3C File Offset: 0x0002503C
		internal override void ValidityHelper()
		{
			int a_ = 16;
			short num = (short)1039728640;
			switch (num)
			{
			default:
			{
				num = (short)1020002327;
				int num2 = (int)((global::System.IntPtr)num);
				bool flag2;
				for (;;)
				{
					int num3;
					switch (num2)
					{
					case 0:
						if (base.Applicable)
						{
							num = (short)1733558286;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						goto IL_1AE;
					case 2:
						return;
					case 3:
					{
						bool flag;
						if (!flag)
						{
							num = (short)800260098;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_26F;
					}
					case 4:
					{
						bool flag = true;
						num = (short)86769679;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						global::AcpCommonLib.ListItemStateConstraint isIndexValid;
						object[] customAttributes = isIndexValid.Method.GetCustomAttributes(true);
						num3 = 0;
						num = (short)635043857;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_121;
					case 7:
					{
						object obj;
						if (obj.ToString().Equals(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("ꇡ诣裥鯧黩黫迭駯鳱胳뻵鷷雹賻鯽狿Ⰱ倃琅愇洉欋欍戏䐑甓稕焗縙匛瀝氟䴡䔣䈥䄧䐩䬫", a_)))
						{
							num = (short)1720713220;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_335;
					}
					case 8:
						goto IL_2B7;
					case 9:
					{
						num = (short)1397751809;
						if (num != 0)
						{
						}
						object[] customAttributes;
						if (num3 >= customAttributes.Length)
						{
							num = (short)633536518;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						object obj = customAttributes[num3];
						num = (short)426508304;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						num = (short)1636630535;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						IL_26A:
						((global::AcpBusinessLayer.FeatureSection)base.Parent).CurrentField = this;
						num = (short)2070872065;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)2000748563;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						global::AcpCommonLib.ListItemStateConstraint isIndexValid;
						if (isIndexValid.Method != null)
						{
							num = (short)1244004357;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_121;
					}
					case 14:
						flag2 = global::AcpBusinessLayer.AcpConstraints.AcpValidilityRules(this);
						num = (short)439418898;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_335;
					case 16:
					{
						object obj;
						if (obj != null)
						{
							num = (short)179765258;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_335;
					}
					case 17:
						goto IL_2B7;
					case 18:
						if (this.IsIndexValid != null)
						{
							num = (short)785776652;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_40F;
					case 19:
						if (this.Value >= 0)
						{
							num = (short)112197643;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_40F;
					case 20:
					{
						global::AcpCommonLib.ListItemStateConstraint isIndexValid = this.IsIndexValid;
						bool flag = false;
						num = (short)18612248;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						return;
					case 22:
						num = (short)849608717;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						switch (0)
						{
						case 0:
							goto IL_B1;
						}
						continue;
					case 24:
					{
						global::AcpCommonLib.ListItemStateConstraint isIndexValid;
						if (isIndexValid != null)
						{
							num = (short)567607318;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_121;
					}
					}
					IL_B1:
					if (global::AcpBusinessLayer.AcpDocument.PageOnLoading)
					{
						num = (short)2072379412;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_26F;
					IL_121:
					num = (short)1672282112;
					short num4 = num;
					num = (short)56426499;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_40F:
					num = (short)1807066079;
					short num5 = num;
					num = (short)502899679;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_26A;
					default:
						num = (short)1669988352;
						if (num != 0)
						{
						}
						base.Valid = flag2;
						num = (short)71761941;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_26F:
					num = (short)263323648;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2B7:
					num = (short)901054473;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_335:
					num3++;
					num = (short)1547173896;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_1AE:
				base.Valid = (flag2 && this.IsIndexValid(base.Parent, this.Value));
				return;
			}
			}
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0002730C File Offset: 0x0002550C
		public virtual void CalculateItemsValidity()
		{
			short num = (short)849215492;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				int num4;
				switch (num2)
				{
				case 0:
					goto IL_82;
				case 1:
					return;
				case 2:
				{
					num = (short)556756027;
					short num3 = num;
					num = (short)1647995963;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1675821056;
						if (num != 0)
						{
						}
						goto IL_16A;
					}
					break;
				}
				case 3:
					goto IL_16A;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 5:
					if (num4 >= this.Items.Count)
					{
						num = (short)1462239233;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.Items[num4].ItemValidity = this.IsIndexValid(base.Parent, num4);
					num4++;
					num = (short)1265827842;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_3C:
				if (this.IsIndexValid == null)
				{
					num = (short)970522625;
					if (num != 0)
					{
					}
					num = (short)545128448;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				((global::AcpBusinessLayer.FeatureSection)base.Parent).CurrentField = this;
				num4 = 0;
				num = (short)847183875;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_16A:
				num = (short)620822533;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_82:
			num = (short)433127424;
			short num5 = num;
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600020D RID: 525 RVA: 0x000274C8 File Offset: 0x000256C8
		// (set) Token: 0x0600020E RID: 526 RVA: 0x00027584 File Offset: 0x00025784
		internal global::AcpCommonLib.ListItemImageConstraint IndexImage
		{
			get
			{
				short num = (short)1491259877;
				short num2 = num;
				num = (short)800510437;
				switch (num2 == num)
				{
				}
				num = (short)280166401;
				if (num != 0)
				{
				}
				num = (short)1731985408;
				if (num != 0)
				{
				}
				num = (short)1849950208;
				short num3 = num;
				return ((global::AcpBusinessLayer.Impl.AcpListFieldImpl)base.FieldData).IndexImage;
			}
			private set
			{
				short num = (short)664137418;
				short num2 = num;
				num = (short)2106257098;
				switch (num2 == num)
				{
				}
				num = (short)769392641;
				if (num != 0)
				{
				}
				num = (short)2019819520;
				if (num != 0)
				{
				}
				num = (short)689373184;
				short num3 = num;
				((global::AcpBusinessLayer.Impl.AcpListFieldImpl)base.FieldData).IndexImage = value;
			}
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00027644 File Offset: 0x00025844
		protected override void VisibilityHelper()
		{
			short num = (short)1159069697;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				IL_1F:
				switch (num2)
				{
				case 0:
					this.IndexImage(base.Parent, this);
					num = (short)46727170;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 2:
					goto IL_F7;
				}
				IL_31:
				while (this.IndexImage != null)
				{
					num = (short)1120105905;
					short num3 = num;
					num = (short)268596657;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)339279872;
						if (num != 0)
						{
						}
						num = (short)1986920448;
						short num4 = num;
						num = (short)597360640;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_1F;
					}
					}
				}
				break;
			}
			IL_F7:
			num = (short)1754660865;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00027774 File Offset: 0x00025974
		public override global::AcpCommonLib.UndoRedo.UndoableTask CopyValueOf(global::AcpCommonLib.IAcpField source)
		{
			short num = (short)231276544;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6E;
				}
				global::AcpBusinessLayer.AcpListField acpListField;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.ListItem> enumerator;
					switch (num2)
					{
					case 0:
						if (this.BuddyList == null)
						{
							num = (short)2073886732;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4BA;
					case 1:
						goto IL_F5;
					case 2:
					{
						string uivalue;
						if (this.UIValue.Equals(uivalue))
						{
							num = (short)873725953;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48F;
					}
					case 3:
						goto IL_4BA;
					case 4:
						num = (short)664928258;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_935;
					case 6:
						goto IL_4B5;
					case 7:
					{
						if (this.Items.Count <= 0)
						{
							num = (short)1958477835;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpCommonLib.UndoRedo.ContainerTask containerTask;
						containerTask.AddTask(new global::AcpBusinessLayer.UndoRedo.RemoveListItemTask(this, 0));
						num = (short)407044101;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						try
						{
							num = (short)225837072;
							num2 = (int)((global::System.IntPtr)num);
							global::AcpCommonLib.UndoRedo.UndoableTask result;
							for (;;)
							{
								int num3;
								switch (num2)
								{
								case 0:
									goto IL_2A2;
								case 1:
								{
									bool flag;
									if (flag)
									{
										num = (short)1376190466;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)99024906;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_37C;
								case 3:
									if (num3 < this.BuddyList.Items.Count)
									{
										num = (short)1167982597;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_37C;
								case 4:
									if (!this.BuddyList.Items[num3].ItemVisibility)
									{
										num = (short)1546715144;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2A7;
								case 5:
									num = (short)351272961;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_2C9;
								case 7:
									num = (short)1577189391;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									base.UnsupportedValue = true;
									result = null;
									num = (short)1663107083;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)173342727;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.ListItem listItem = enumerator.Current;
									bool flag = false;
									num3 = 0;
									num = (short)884277265;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
								{
									global::AcpBusinessLayer.ListItem listItem;
									if (this.BuddyList.Items[num3].ItemName == listItem.ItemName)
									{
										num = (short)857931788;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2A7;
								}
								case 11:
									goto IL_18F;
								case 12:
								{
									bool flag = true;
									num = (short)1004666884;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 13:
									base.UnsupportedValue = true;
									result = null;
									num = (short)464388096;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
								{
									bool flag;
									if (!flag)
									{
										num = (short)848166925;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 15:
									goto IL_3CD;
								case 16:
									switch (0)
									{
									case 0:
										goto IL_169;
									}
									continue;
								case 17:
									goto IL_2C9;
								}
								goto IL_169;
								IL_2A7:
								num3++;
								num = (short)1761869830;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2C9:
								num = (short)262864899;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_33E:
								num = (short)45350921;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_169:
								goto IL_33E;
								IL_37C:
								num = (short)998244366;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_18F:
							IL_2A2:
							return result;
							IL_3CD:
							goto IL_8BB;
						}
						finally
						{
							num = (short)1826881537;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)256114690;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_404;
									}
									continue;
								case 2:
									goto IL_48C;
								}
								IL_404:
								if (enumerator == null)
								{
									break;
								}
								num = (short)720963316;
								short num4 = num;
								num = (short)1363609332;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_48E;
								default:
									num = (short)1708654592;
									if (num != 0)
									{
									}
									num = (short)1597440000;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_48C:
							IL_48E:;
						}
						goto IL_48F;
						IL_8BB:
						base.UnsupportedValue = false;
						global::AcpCommonLib.UndoRedo.ContainerTask containerTask = new global::AcpCommonLib.UndoRedo.ContainerTask(global::AcpCommonResources.AcpResources.Copy_List_Item);
						num = (short)1424490496;
						short num5 = num;
						num = (short)1389494287;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						num = (short)1161035776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (this.UIValue != null)
						{
							num = (short)1299709956;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48F;
					case 11:
						enumerator = acpListField.Items.GetEnumerator();
						num = (short)1697054733;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)1549139969;
						if (num != 0)
						{
						}
						this.BuddyList = this;
						num = (short)171835395;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_9A7;
					case 14:
					{
						if (this.SerializeItems)
						{
							num = (short)1503526921;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string uivalue = acpListField.UIValue;
						num = (short)3342346;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						goto IL_935;
					}
					goto IL_6E;
					IL_48F:
					enumerator = this.Items.GetEnumerator();
					num = (short)330301446;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4BA:
					enumerator = acpListField.Items.GetEnumerator();
					num = (short)83230728;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_935:
					num = (short)1957560327;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_F5:
				base.UnsupportedValue = false;
				return null;
				IL_4B5:
				Block_6:
				try
				{
					num = (short)1977942023;
					num2 = (int)((global::System.IntPtr)num);
					global::AcpCommonLib.UndoRedo.UndoableTask result;
					for (;;)
					{
						switch (num2)
						{
						case 0:
							base.UnsupportedValue = false;
							result = this.GetModifyDataTask(((global::AcpBusinessLayer.AcpListField)source).Value);
							num = (short)768081921;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_6D3;
						case 2:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.ListItem> enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)1187643398;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpBusinessLayer.ListItem listItem2 = enumerator.Current;
							num = (short)1621360648;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							global::AcpBusinessLayer.ListItem listItem2;
							if (listItem2.ItemVisibility)
							{
								num = (short)782958592;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
							num = (short)1994194947;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_7B1;
						case 6:
							num = (short)2083782661;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							switch (0)
							{
							case 0:
								goto IL_6A2;
							}
							continue;
						case 8:
						{
							string uivalue;
							global::AcpBusinessLayer.ListItem listItem2;
							if (listItem2.ItemName.CompareTo(uivalue) == 0)
							{
								num = (short)1132134404;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						IL_710:
						num = (short)1101856770;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_6A2:
						goto IL_710;
					}
					IL_6D3:
					return result;
					IL_7B1:;
				}
				finally
				{
					num = (short)2016935938;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.ListItem> enumerator;
						switch (num2)
						{
						case 0:
							goto IL_81E;
						case 1:
							enumerator.Dispose();
							num = (short)156958720;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_7E5;
							}
							continue;
						}
						IL_7E5:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1317601281;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_81E:;
				}
				base.UnsupportedValue = true;
				return null;
				IL_9A7:
				try
				{
					num = (short)1132134403;
					num2 = (int)((global::System.IntPtr)num);
					global::AcpCommonLib.UndoRedo.ContainerTask containerTask;
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_5E9;
						case 2:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.ListItem> enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)276889604;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpBusinessLayer.ListItem listItem3 = enumerator.Current;
							containerTask.AddTask(new global::AcpBusinessLayer.UndoRedo.AddListItemTask(this, listItem3.ItemName));
							num = (short)1188036609;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							switch (0)
							{
							case 0:
								goto IL_563;
							}
							continue;
						case 4:
							num = (short)192348160;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_597:
						num = (short)240713730;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_563:
						goto IL_597;
					}
					IL_5E9:
					return containerTask;
				}
				finally
				{
					num = (short)572719105;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.ListItem> enumerator;
						switch (num2)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1531707394;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_620;
							}
							continue;
						case 2:
							goto IL_655;
						}
						IL_620:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1475149824;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_655:;
				}
				goto Block_6;
				IL_6E:
				acpListField = (source as global::AcpBusinessLayer.AcpListField);
				num = (short)426770446;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0002817C File Offset: 0x0002637C
		public global::AcpCommonLib.UndoRedo.UndoableTask GetModifyDataTask(int newValue)
		{
			global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int> modifyDataTask = new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(this, newValue);
			short num;
			if (base.ValueSetter == null)
			{
				num = (short)1169133541;
				short num2 = num;
				num = (short)3903461;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1571487745;
					if (num != 0)
					{
					}
					num = (short)1195769856;
					if (num != 0)
					{
					}
					return modifyDataTask;
				}
			}
			num = (short)1868038144;
			short num3 = num;
			global::AcpCommonLib.UndoRedo.ContainerTask containerTask = new global::AcpCommonLib.UndoRedo.ContainerTask(modifyDataTask.ToString());
			containerTask.AddTask(modifyDataTask);
			this.CallValueSetter(containerTask);
			return containerTask;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00028258 File Offset: 0x00026458
		internal void BuildItemsXml(global::System.Xml.XmlElement element)
		{
			int a_ = 1;
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.ListItem> enumerator = this.Items.GetEnumerator();
			short num;
			try
			{
				num = (short)38797316;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_EB;
					case 2:
						num = (short)105054209;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1283194882;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpBusinessLayer.ListItem listItem = enumerator.Current;
						global::System.Xml.XmlElement xmlElement = element.OwnerDocument.CreateElement(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("髒ꇔ닖듘", a_));
						xmlElement.InnerText = listItem.ItemName;
						element.AppendChild(xmlElement);
						num = (short)773849088;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						switch (0)
						{
						case 0:
							goto IL_4F;
						}
						continue;
					}
					IL_9D:
					num = (short)1206714371;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4F:
					goto IL_9D;
				}
				IL_EB:;
			}
			finally
			{
				num = (short)863961090;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_1CB;
					case 1:
						enumerator.Dispose();
						num = (short)1768423425;
						if (num != 0)
						{
						}
						num = (short)1351417856;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_122;
						}
						continue;
					}
					IL_122:
					if (enumerator == null)
					{
						break;
					}
					num = (short)714495990;
					short num3 = num;
					num = (short)861755382;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1CD;
					default:
						num = (short)1082327040;
						if (num != 0)
						{
						}
						num = (short)134152193;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_1CB:
				IL_1CD:;
			}
			num = (short)38469632;
			short num4 = num;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0002846C File Offset: 0x0002666C
		internal global::AcpCommonLib.UndoRedo.UndoableTask CopyValuesFromXml(global::System.Xml.XmlNode node)
		{
			short num = (short)918814720;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)838991880;
				num2 = (int)((global::System.IntPtr)num);
				global::System.Collections.IEnumerator enumerator;
				global::AcpCommonLib.UndoRedo.ContainerTask containerTask;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_67E;
					case 1:
						try
						{
							num = (short)1727201289;
							num2 = (int)((global::System.IntPtr)num);
							global::AcpCommonLib.UndoRedo.UndoableTask result;
							for (;;)
							{
								int num3;
								switch (num2)
								{
								case 0:
								{
									bool flag = true;
									num = (short)2066284558;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_50E;
								case 2:
									base.UnsupportedValue = true;
									result = null;
									num = (short)995033098;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									bool flag;
									if (!flag)
									{
										num = (short)1300365314;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									num = (short)1195835397;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_603;
								case 6:
									if (num3 < this.BuddyList.Items.Count)
									{
										num = (short)1330708496;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4B6;
								case 7:
									goto IL_46E;
								case 8:
								{
									bool flag;
									if (flag)
									{
										num = (short)307298315;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1713897489;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									switch (0)
									{
									case 0:
										goto IL_39E;
									}
									continue;
								case 10:
									goto IL_5E5;
								case 11:
									goto IL_4B6;
								case 12:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)474087428;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)enumerator.Current;
									bool flag = false;
									num3 = 0;
									num = (short)1538588687;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 13:
									base.UnsupportedValue = true;
									result = null;
									num = (short)1130037255;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									if (!this.BuddyList.Items[num3].ItemVisibility)
									{
										num = (short)731578381;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4EE;
								case 15:
									goto IL_50E;
								case 16:
									num = (short)1619853320;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 17:
								{
									global::System.Xml.XmlNode xmlNode;
									if (this.BuddyList.Items[num3].ItemName == xmlNode.InnerText)
									{
										num = (short)133562368;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4EE;
								}
								}
								IL_473:
								num = (short)323026956;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_39E:
								goto IL_473;
								IL_4B6:
								num = (short)1774518275;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4EE:
								num3++;
								num = (short)1538916353;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_50E:
								num = (short)541523974;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_46E:
							IL_5E5:
							return result;
							IL_603:
							goto IL_2AF;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_625;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_612:
								switch (num2)
								{
								case 0:
									goto IL_67B;
								case 1:
									disposable.Dispose();
									num = (short)1126039552;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									if (disposable != null)
									{
										num = (short)135593985;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_67D;
								}
								goto IL_625;
							}
							IL_67B:
							IL_67D:
							goto EndFinally_17;
							IL_625:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1937506306;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_612;
							EndFinally_17:;
						}
						goto IL_67E;
						IL_2AF:
						base.UnsupportedValue = false;
						containerTask = new global::AcpCommonLib.UndoRedo.ContainerTask(global::AcpCommonResources.AcpResources.Copy_Values);
						num = (short)1124139014;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						enumerator = node.ChildNodes.GetEnumerator();
						num = (short)1539506179;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_A9;
					case 4:
						if (this.Items.Count <= 0)
						{
							num = (short)1784217602;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						containerTask.AddTask(new global::AcpBusinessLayer.UndoRedo.RemoveListItemTask(this, 0));
						num = (short)563085312;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						this.BuddyList = this;
						num = (short)498335751;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						num = (short)1334706177;
						if (num != 0)
						{
						}
						num = (short)2061697024;
						short num4 = num;
						goto IL_67E;
					}
					case 7:
						goto IL_D6;
					case 8:
						switch (0)
						{
						case 0:
							goto IL_68;
						}
						continue;
					}
					IL_68:
					if (this.BuddyList == null)
					{
						num = (short)259194885;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_D6:
					enumerator = node.ChildNodes.GetEnumerator();
					num = (short)846331905;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_67E:
					num = (short)1615659012;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_A9:
				try
				{
					num = (short)765263876;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 1:
							goto IL_236;
						case 2:
							num = (short)441319425;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)384434178;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Xml.XmlNode xmlNode2 = (global::System.Xml.XmlNode)enumerator.Current;
							containerTask.AddTask(new global::AcpBusinessLayer.UndoRedo.AddListItemTask(this, xmlNode2.InnerText));
							num = (short)1490550784;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							IL_136:
							switch (0)
							{
							case 0:
								goto IL_15B;
							}
							continue;
						}
						IL_194:
						num = (short)2137062609;
						short num5 = num;
						num = (short)712113361;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_136;
						default:
							num = (short)829882368;
							if (num != 0)
							{
							}
							num = (short)283377667;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_15B:
						goto IL_194;
					}
					IL_236:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_255;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_242:
						switch (num2)
						{
						case 0:
							goto IL_2AA;
						case 1:
							disposable.Dispose();
							num = (short)580648960;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							if (disposable != null)
							{
								num = (short)658964481;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2AC;
						}
						goto IL_255;
					}
					IL_2AA:
					IL_2AC:
					goto EndFinally_16;
					IL_255:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)416612354;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_242;
					EndFinally_16:;
				}
				return containerTask;
			}
			}
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00028B74 File Offset: 0x00026D74
		internal override void CreateFieldData(string uiName)
		{
			short num = (short)878756967;
			short num2 = num;
			num = (short)23970919;
			switch (num2 == num)
			{
			default:
			{
				num = (short)815267840;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)218955777;
			if (num != 0)
			{
			}
			num = (short)985202688;
			if (num != 0)
			{
			}
			base.FieldData = new global::AcpBusinessLayer.Impl.AcpListFieldImpl(uiName);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00028C2C File Offset: 0x00026E2C
		internal bool GetItemVisibility(global::AcpBusinessLayer.ListItem item)
		{
			short num;
			if (!this.Items.Contains(item))
			{
				num = (short)499122176;
				short num2 = num;
				num = (short)1156215204;
				short num3 = num;
				num = (short)277967268;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1019871232;
					if (num != 0)
					{
					}
					return false;
				}
			}
			num = (short)1121320961;
			if (num != 0)
			{
			}
			return ((global::AcpBusinessLayer.Impl.AcpListFieldImpl)base.FieldData).GetItemVisibility(this.IndexOf(item));
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00028CFC File Offset: 0x00026EFC
		internal void SetItemVisibility(global::AcpBusinessLayer.ListItem item, bool value)
		{
			short num = (short)849346561;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)440733046;
				short num3 = num;
				num = (short)1724910966;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
					num = (short)1200816128;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						((global::AcpBusinessLayer.Impl.AcpListFieldImpl)base.FieldData).SetItemVisibility(this.IndexOf(item), value);
						num = (short)1700397058;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						num = (short)652214273;
						if (num != 0)
						{
						}
						num = (short)57016320;
						short num4 = num;
						switch (0)
						{
						case 0:
							goto IL_CC;
						}
						continue;
					}
					case 2:
						return;
					}
					IL_CC:
					if (!this.Items.Contains(item))
					{
						return;
					}
					num = (short)660996096;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00028E2C File Offset: 0x0002702C
		private void a(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
		{
			short num = (short)275086090;
			short num2 = num;
			num = (short)973110026;
			switch (num2 == num)
			{
			}
			num = (short)1583742976;
			short num3 = num;
			num = (short)711917568;
			if (num != 0)
			{
			}
			num = (short)336592897;
			if (num != 0)
			{
			}
			base.UpdateComparison();
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00028EE0 File Offset: 0x000270E0
		private void a()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::System.Collections.Specialized.INotifyCollectionChanged items;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					items.CollectionChanged += this._collectionChangedHandler;
					num2 = (short)2055077890;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (items != null)
					{
						goto IL_62;
					}
					goto IL_9E;
				case 2:
					goto IL_9E;
				}
				goto IL_1C;
				IL_62:
				num2 = (short)168296448;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_9E:
				num2 = (short)107311476;
				short num3 = num2;
				num2 = (short)1201107316;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_62;
				default:
					goto IL_D5;
				}
			}
			IL_D5:
			num2 = (short)1296891905;
			if (num2 != 0)
			{
			}
			num2 = (short)1043529728;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			num2 = (short)1642397696;
			short num4 = num2;
			items = this.Items;
			num2 = (short)817364993;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00029000 File Offset: 0x00027200
		public string BuildReportString()
		{
			int a_ = 11;
			switch (0)
			{
			case 0:
				goto IL_51;
			}
			int num;
			short num2;
			global::System.Text.StringBuilder stringBuilder;
			for (;;)
			{
				IL_13:
				int num5;
				int num6;
				int num7;
				switch (num)
				{
				case 0:
					num2 = (short)2131165185;
					if (num2 != 0)
					{
					}
					goto IL_147;
				case 1:
				{
					num2 = (short)13369344;
					short num3 = num2;
					num2 = (short)1425587613;
					short num4 = num2;
					num2 = (short)555662749;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_137;
					default:
						num2 = (short)1216806912;
						if (num2 != 0)
						{
						}
						if (this.Items.Count > 5)
						{
							num2 = (short)783548420;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_2FC;
					}
					break;
				}
				case 2:
					num2 = (short)1931739143;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (num5 >= num6)
					{
						num2 = (short)1787691010;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					stringBuilder.Append(this.Items[num5].ItemName.ToString());
					stringBuilder.Append(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("￞", a_));
					num5++;
					num2 = (short)1398276109;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					stringBuilder.Append(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("쿠", a_));
					num2 = (short)2005794826;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					num7 = 5;
					goto IL_2DC;
				case 6:
					goto IL_E6;
				case 7:
					if (stringBuilder.Length > 0)
					{
						num2 = (short)1648361480;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_147;
				case 8:
					stringBuilder.Remove(stringBuilder.Length - 2, 2);
					num2 = (short)1962737664;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (this.Items.Count >= 5)
					{
						num2 = (short)1649344524;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1494941707;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					goto IL_288;
				case 11:
					goto IL_137;
				case 12:
					num2 = (short)2019033093;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					goto IL_E6;
				}
				goto IL_51;
				IL_E6:
				num2 = (short)1713504259;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_147:
				num2 = (short)1885208577;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2DC:
				num6 = num7;
				num5 = 0;
				num2 = (short)504496134;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_137:
				num7 = this.Items.Count;
				goto IL_2DC;
			}
			IL_288:
			IL_2FC:
			return stringBuilder.ToString();
			IL_51:
			stringBuilder = new global::System.Text.StringBuilder();
			num2 = (short)595656713;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x04000066 RID: 102
		private global::System.Collections.Specialized.NotifyCollectionChangedEventHandler _collectionChangedHandler;
	}
}
