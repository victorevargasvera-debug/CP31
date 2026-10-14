using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using System.Xml;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using AcpCommonResources;

namespace AcpBusinessLayer
{
	// Token: 0x02000032 RID: 50
	[global::System.Serializable]
	public abstract class FeatureSection : global::AcpCommonLib.IAcpFeatureSection, global::AcpCommonLib.IAcpConstraints, global::AcpCommonLib.IAcpCommon, global::System.IDisposable, global::System.Runtime.Serialization.ISerializable, global::System.ComponentModel.INotifyPropertyChanged, global::System.ComponentModel.INotifyPropertyChanging
	{
		// Token: 0x0600035F RID: 863
		public abstract void PopulateReferences();

		// Token: 0x06000360 RID: 864
		public abstract void DropReferences();

		// Token: 0x06000361 RID: 865
		public abstract void SetupDependencies();

		// Token: 0x06000362 RID: 866
		public abstract void SetConstraints();

		// Token: 0x06000363 RID: 867
		public abstract void Init(global::System.Collections.Generic.List<string> producerFields);

		// Token: 0x06000364 RID: 868
		public abstract void Init();

		// Token: 0x06000365 RID: 869 RVA: 0x000414D0 File Offset: 0x0003F6D0
		public virtual void UpdateKey()
		{
			short num = (short)2019819520;
			short num2 = num;
			num = (short)1224401318;
			short num3 = num;
			num = (short)1474093478;
			switch (num3 == num)
			{
			}
			num = (short)1284177920;
			if (num != 0)
			{
			}
			num = (short)1941045249;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00041578 File Offset: 0x0003F778
		public virtual bool CanFill(global::AcpCommonLib.IAcpField myField)
		{
			short num = (short)1035206656;
			short num2 = num;
			num = (short)1468851336;
			short num3 = num;
			num = (short)1509155976;
			switch (num3 == num)
			{
			}
			num = (short)911671297;
			if (num != 0)
			{
			}
			num = (short)337444864;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000367 RID: 871 RVA: 0x00041624 File Offset: 0x0003F824
		// (set) Token: 0x06000368 RID: 872 RVA: 0x000416D4 File Offset: 0x0003F8D4
		protected int Id
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1972043776;
				short num2 = num;
				num = (short)1120195286;
				short num3 = num;
				num = (short)2143670998;
				switch (num3 == num)
				{
				}
				num = (short)1478033409;
				if (num != 0)
				{
				}
				num = (short)1388642304;
				if (num != 0)
				{
				}
				return this.<Id>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1126367232;
				short num2 = num;
				num = (short)1649712102;
				short num3 = num;
				num = (short)30120934;
				switch (num3 == num)
				{
				}
				num = (short)1952186369;
				if (num != 0)
				{
				}
				num = (short)1966276608;
				if (num != 0)
				{
				}
				this.<Id>k__BackingField = value;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000369 RID: 873 RVA: 0x00041784 File Offset: 0x0003F984
		// (set) Token: 0x0600036A RID: 874 RVA: 0x00041834 File Offset: 0x0003FA34
		internal bool HasListItemsToSerialize
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)684523520;
				short num2 = num;
				num = (short)1515128997;
				short num3 = num;
				num = (short)2085554341;
				switch (num3 == num)
				{
				}
				num = (short)285343745;
				if (num != 0)
				{
				}
				num = (short)1843658752;
				if (num != 0)
				{
				}
				return this.<HasListItemsToSerialize>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1545338880;
				short num2 = num;
				num = (short)992697508;
				short num3 = num;
				num = (short)1439718564;
				switch (num3 == num)
				{
				}
				num = (short)1333198849;
				if (num != 0)
				{
				}
				num = (short)517079040;
				if (num != 0)
				{
				}
				this.<HasListItemsToSerialize>k__BackingField = value;
			}
		}

		// Token: 0x0600036B RID: 875 RVA: 0x000418E4 File Offset: 0x0003FAE4
		internal void RegisterForDataTransfer(global::AcpBusinessLayer.AcpFieldBase field, int order)
		{
			short num = (short)1340646954;
			short num2 = num;
			num = (short)519284266;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_15E:
				this.fieldsBlocked = new global::System.Collections.Generic.List<global::AcpBusinessLayer.AcpFieldBase>();
				num = (short)253886466;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1399980033;
				if (num != 0)
				{
				}
				num = (short)939917312;
				if (num != 0)
				{
				}
				num = (short)678100995;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_15E;
				case 1:
				{
					num = (short)1280180224;
					short num4 = num;
					if (!this.fieldsBlocked.Contains(field))
					{
						num = (short)1395785736;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 2:
					goto IL_F2;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_C2;
					}
					continue;
				case 4:
					this.sortedFields = new global::System.Collections.Generic.SortedDictionary<int, global::AcpBusinessLayer.AcpFieldBase>();
					num = (short)403832842;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (order > 0)
					{
						num = (short)1347026950;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1440546817;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_124;
				case 7:
					return;
				case 8:
					this.fieldsBlocked.Add(field);
					num = (short)614334471;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (this.fieldsBlocked == null)
					{
						num = (short)1316945920;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F2;
				case 10:
					goto IL_126;
				}
				IL_C2:
				if (this.sortedFields == null)
				{
					num = (short)749273092;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_126;
				IL_F2:
				num = (short)158334981;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_126:
				num = (short)1893203977;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_124:
			this.sortedFields.Add(order, field);
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00041B38 File Offset: 0x0003FD38
		protected FeatureSection() : this(null)
		{
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00041B4C File Offset: 0x0003FD4C
		protected FeatureSection(global::AcpBusinessLayer.FeatureNode parent)
		{
			this.Parent = parent;
			this.fieldsByUIName = new global::System.Collections.Generic.Dictionary<string, global::AcpBusinessLayer.AcpFieldBase>();
			this.fieldsByName = new global::System.Collections.Generic.Dictionary<string, global::AcpBusinessLayer.AcpFieldBase>();
			this.b();
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00041B84 File Offset: 0x0003FD84
		private void b()
		{
			short num = (short)409468928;
			short num2 = num;
			num = (short)711458817;
			if (num != 0)
			{
			}
			num = (short)1622327568;
			short num3 = num;
			num = (short)653050128;
			switch (num3 == num)
			{
			}
			num = (short)984612864;
			if (num != 0)
			{
			}
			this.diffCount = new global::AcpBusinessLayer.DifferenceCount();
			this.diffCount.CountChanged += this.a;
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00041C50 File Offset: 0x0003FE50
		public void FirePropertyChanged(string name)
		{
			short num = (short)973471745;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_C7;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 2:
				{
					this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(name));
					num = (short)647180517;
					short num3 = num;
					num = (short)86782181;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C7;
					default:
						num = (short)560594944;
						if (num != 0)
						{
						}
						num = (short)1614217216;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_30:
				if (this.PropertyChanged == null)
				{
					return;
				}
				num = (short)834600962;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_C7:
			num = (short)1060896768;
			short num4 = num;
			num = (short)1743257601;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00041D78 File Offset: 0x0003FF78
		internal void FirePropertyChanging(string name)
		{
			short num = (short)2045575169;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1086259201;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					return;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_58;
					}
					continue;
				case 2:
				{
					this.PropertyChanging(this, new global::System.ComponentModel.PropertyChangingEventArgs(name));
					num = (short)1455586170;
					short num3 = num;
					num = (short)963607418;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num = (short)1770323968;
						if (num != 0)
						{
						}
						num = (short)262471680;
						short num4 = num;
						num = (short)2094923776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				}
				IL_58:
				if (this.PropertyChanging == null)
				{
					break;
				}
				num = (short)1775894530;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00041EA0 File Offset: 0x000400A0
		internal void InvokeRecRefValidities()
		{
			short num = (short)1865940992;
			short num2 = num;
			num = (short)1001848833;
			if (num != 0)
			{
			}
			num = (short)687549235;
			short num3 = num;
			num = (short)211495731;
			switch (num3 == num)
			{
			}
			num = (short)1945174016;
			if (num != 0)
			{
			}
			((global::AcpBusinessLayer.FeatureNode)this.Parent).InvokeRecRefValidities();
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00041F58 File Offset: 0x00040158
		internal bool AddToXml(global::System.Xml.XmlNode node, global::AcpCommonLib.XmlFileType fileType)
		{
			int a_ = 11;
			short num = (short)1317601280;
			switch (num)
			{
			default:
			{
				num = (short)1096024064;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.Xml.XmlElement xmlElement2;
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator2;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_8D;
						}
						continue;
					case 1:
					{
						num = (short)222887936;
						short num3 = num;
						num = (short)540803083;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (!this.EmbeddedRecset.HiddenStatic)
						{
							num = (short)1250820103;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5C0;
					case 3:
						goto IL_815;
					case 4:
					{
						global::System.Collections.Generic.SortedDictionary<int, global::AcpBusinessLayer.AcpFieldBase>.ValueCollection.Enumerator enumerator = this.sortedFields.Values.GetEnumerator();
						num = (short)486604812;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_5C0;
					case 6:
						if (fileType == global::AcpCommonLib.XmlFileType.CustomView)
						{
							num = (short)904134659;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1022558217;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)721616904;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (!this.EmbeddedRecset.HasVisibleObjects)
						{
							num = (short)385941505;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4ED;
					case 9:
						if (this.sortedFields != null)
						{
							num = (short)236847108;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_86E;
					case 10:
						num = (short)1917976578;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (this.embeddedRecset.Count == 0)
						{
							num = (short)917372942;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5C0;
					case 12:
						try
						{
							num = (short)1234501632;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Xml.XmlElement xmlElement;
								global::AcpBusinessLayer.AcpFieldBase acpFieldBase;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_22D;
									}
									continue;
								case 2:
									goto IL_259;
								case 3:
									xmlElement = node.OwnerDocument.CreateElement(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("鯜뛞蓠迢臤", a_));
									xmlElement.SetAttribute(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("鏜뻞賠蛢", a_), acpFieldBase.UIName);
									num = (short)1153564683;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									num = (short)1434255372;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									num = (short)205258767;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									if (!acpFieldBase.HiddenStatic)
									{
										num = (short)934084611;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 7:
								{
									global::AcpBusinessLayer.AcpListField acpListField;
									if (acpListField != null)
									{
										num = (short)470876165;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_42A;
								}
								case 8:
									goto IL_259;
								case 9:
								{
									global::System.Collections.Generic.SortedDictionary<int, global::AcpBusinessLayer.AcpFieldBase>.ValueCollection.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)2040070148;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpFieldBase = enumerator.Current;
									num = (short)706412550;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
								{
									global::AcpBusinessLayer.AcpListField acpListField;
									acpListField.BuildItemsXml(xmlElement);
									num = (short)2075787266;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
									if (this.HasListItemsToSerialize)
									{
										num = (short)1768095758;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									xmlElement.InnerText = acpFieldBase.ToString();
									num = (short)1896349704;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									goto IL_46E;
								case 13:
									goto IL_259;
								case 14:
								{
									global::AcpBusinessLayer.AcpListField acpListField = acpFieldBase as global::AcpBusinessLayer.AcpListField;
									num = (short)946143239;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 15:
								{
									global::AcpBusinessLayer.AcpListField acpListField;
									if (acpListField.SerializeItems)
									{
										num = (short)492699658;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_42A;
								}
								}
								goto IL_22D;
								IL_259:
								xmlElement2.AppendChild(xmlElement);
								num = (short)219938817;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_27E:
								num = (short)1145176073;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_22D:
								goto IL_27E;
								IL_42A:
								xmlElement.InnerText = acpFieldBase.ToString();
								num = (short)1546059789;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_46E:
							goto IL_86E;
						}
						finally
						{
							global::System.Collections.Generic.SortedDictionary<int, global::AcpBusinessLayer.AcpFieldBase>.ValueCollection.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_481;
					case 13:
						try
						{
							num = (short)1705574401;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_752;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_641;
									}
									continue;
								case 3:
								{
									global::System.Xml.XmlElement xmlElement3 = node.OwnerDocument.CreateElement(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("鯜뛞蓠迢臤", a_));
									global::AcpBusinessLayer.AcpFieldBase acpFieldBase2;
									xmlElement3.SetAttribute(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("鏜뻞賠蛢", a_), acpFieldBase2.UIName);
									xmlElement3.InnerText = acpFieldBase2.CustomViewVisibility.ToString();
									xmlElement2.AppendChild(xmlElement3);
									num = (short)636878850;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)1123680256;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::AcpBusinessLayer.AcpFieldBase acpFieldBase2;
									if (!acpFieldBase2.HiddenStatic)
									{
										num = (short)653852675;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)1253769220;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.AcpFieldBase acpFieldBase2 = (global::AcpBusinessLayer.AcpFieldBase)enumerator2.Current;
									num = (short)545521669;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_700:
								num = (short)1569980422;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_641:
								goto IL_700;
							}
							IL_752:
							goto IL_86E;
						}
						finally
						{
							num = (short)1343488001;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_812;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_789;
									}
									continue;
								case 2:
								{
									enumerator2.Dispose();
									num = (short)1024665111;
									short num4 = num;
									num = (short)911025687;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_812;
									default:
										num = (short)1062273024;
										if (num != 0)
										{
										}
										num = (short)313524224;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_789:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)1589706754;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_812:;
						}
						goto IL_815;
					case 14:
						goto IL_4ED;
					case 15:
						if (this.HasEmbeddedRecset)
						{
							num = (short)1743192074;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5C0;
					}
					goto IL_8D;
					IL_4ED:
					xmlElement2.SetAttribute(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("飜닞菠蛢臤菦賨迪", a_), global::AcpBusinessLayer.UndoRedo.SetValueTask.b("觜귞铠蛢", a_));
					this.EmbeddedRecset.AddToXml(xmlElement2, fileType);
					num = (short)1675624453;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_53B:
					global::System.Xml.XmlDocument ownerDocument;
					string name;
					xmlElement2 = ownerDocument.CreateElement(name);
					xmlElement2.SetAttribute(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("鏜뻞賠蛢", a_), this.UIName);
					xmlElement2.SetAttribute(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("드믞", a_), this.Id.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					num = (short)967901199;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_481:
					name = global::AcpBusinessLayer.UndoRedo.SetValueTask.b("飜닞菠蛢臤菦賨迪뻬諮鋰蟲鳴飶韸", a_);
					goto IL_53B;
					IL_8D:
					num = (short)1514864641;
					if (num != 0)
					{
					}
					ownerDocument = node.OwnerDocument;
					if (!this.ParentRecset.IsEmbeddedRecset)
					{
						name = global::AcpBusinessLayer.UndoRedo.SetValueTask.b("軜뫞苠韢賤裦蟨", a_);
						goto IL_53B;
					}
					goto IL_481;
					IL_5C0:
					num = (short)1377370118;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_815:
					enumerator2 = this.FieldsCollection.GetEnumerator();
					num = (short)316997645;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_86E:
				node.AppendChild(xmlElement2);
				return true;
			}
			}
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00042810 File Offset: 0x00040A10
		internal bool ReadFromXml(global::System.Xml.XmlNode node, global::AcpCommonLib.UndoRedo.ContainerTask task, global::AcpCommonLib.XmlFileType fileType, bool importCopyOper, global::System.Collections.Generic.Dictionary<global::AcpCommonLib.IAcpField, string> RecRefsToRepair, global::System.Collections.Generic.Dictionary<global::AcpCommonLib.IAcpField, string> RecRefFieldsOfEmbedRecset)
		{
			int a_ = 8;
			short num = (short)637599744;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_E8;
				}
				global::System.Collections.IEnumerator enumerator;
				global::System.Collections.Generic.List<string> list3;
				global::System.Collections.Generic.SortedDictionary<int, string> sortedDictionary;
				for (;;)
				{
					IL_31:
					global::System.Collections.Generic.List<string> list;
					global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField>> dictionary;
					bool flag;
					global::System.Collections.Generic.List<string>.Enumerator enumerator3;
					global::System.Collections.Generic.List<string> list2;
					switch (num2)
					{
					case 0:
						if (fileType != global::AcpCommonLib.XmlFileType.CustomView)
						{
							num = (short)1918369829;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FD0;
					case 1:
					{
						global::AcpBusinessLayer.FeatureNode featureNode = (global::AcpBusinessLayer.FeatureNode)this.EmbeddedRecset[0];
						num = (short)66453529;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)1905328158;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						this.a(node.FirstChild, list);
						((global::AcpBusinessLayer.Recordset)this.EmbeddedRecset).FindNewFieldsInEmbeddedRecset_ImpExp(list, dictionary);
						this.EmbeddedRecset.ClearRecordset(this.EmbeddedRecset, task);
						num = (short)2117664780;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)1591738402;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)452329472;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)1885798413;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						global::AcpBusinessLayer.FeatureNode featureNode;
						if (!featureNode.KeyField.BlockDataTransfer)
						{
							num = (short)400752666;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C5F;
					}
					case 8:
						goto IL_575;
					case 9:
						goto IL_575;
					case 10:
					{
						global::AcpBusinessLayer.FeatureNode featureNode;
						if (featureNode.KeyField != null)
						{
							num = (short)1503133736;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C5F;
					}
					case 11:
						goto IL_1FD0;
					case 12:
						goto IL_1FD0;
					case 13:
						if (this.EmbeddedRecset.Count > 0)
						{
							num = (short)1155727384;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C5F;
					case 14:
						try
						{
							num = (short)1331101699;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1884880897;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_1D4E;
								case 2:
									try
									{
										num = (short)2063925248;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_E34;
												}
												continue;
											case 1:
											{
												if (!enumerator.MoveNext())
												{
													num = (short)1456013315;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)enumerator.Current;
												global::System.Xml.XmlAttribute xmlAttribute = xmlNode.Attributes[global::AcpBusinessLayer.UndoRedo.SetValueTask.b("铙뷛돝藟", a_)];
												num = (short)471334917;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 2:
												try
												{
													switch (0)
													{
													case 0:
														goto IL_FBF;
													}
													global::System.Xml.XmlAttribute xmlAttribute;
													global::AcpBusinessLayer.AcpFieldBase acpFieldBase;
													for (;;)
													{
														IL_EA0:
														string text;
														global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
														string a;
														string text2;
														switch (num2)
														{
														case 0:
															goto IL_1291;
														case 1:
															if (acpFieldBase == null)
															{
																num = (short)1669267522;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															goto IL_11E1;
														case 2:
															num = (short)1613430788;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 3:
															if (!acpFieldBase.Editable)
															{
																num = (short)1058603013;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															goto IL_1278;
														case 4:
														{
															if (fileType != global::AcpCommonLib.XmlFileType.CustomView)
															{
																num = (short)2127036477;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															global::System.Xml.XmlNode xmlNode;
															acpFieldBase.CustomViewVisibility = global::System.Convert.ToBoolean(xmlNode.FirstChild.Value, global::System.Globalization.CultureInfo.InvariantCulture);
															num = (short)1742864432;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														case 5:
															goto IL_1173;
														case 6:
															num = (short)157679679;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 7:
															RecRefsToRepair[acpFieldBase] = text;
															num = (short)939851832;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 8:
															num = (short)1456537635;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 9:
															num = (short)2003435541;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 10:
															if (acpRecRefField.SlaveRecRef)
															{
																num = (short)1941307399;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															goto IL_175B;
														case 11:
															if (acpFieldBase.AllowsDataTransfer())
															{
																num = (short)753598500;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															num = (short)618594369;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 12:
															if (acpFieldBase.BlockDataTransfer)
															{
																num = (short)174391335;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															goto IL_1615;
														case 13:
															if (acpRecRefField.SlaveRecRef)
															{
																num = (short)1404829705;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															goto IL_186D;
														case 14:
															goto IL_1A2D;
														case 15:
															goto IL_1BEC;
														case 16:
															goto IL_17D4;
														case 17:
															num = (short)1120272421;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 18:
															a = null;
															goto IL_1401;
														case 19:
															num = (short)1044185146;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 20:
															if (fileType != global::AcpCommonLib.XmlFileType.ImpExp)
															{
																num = (short)1856307202;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															num = (short)1786773515;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 21:
															if (!acpRecRefField.Applicable)
															{
																num = (short)1511784517;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															goto IL_186D;
														case 22:
															try
															{
																switch (0)
																{
																case 0:
																	goto IL_10D5;
																}
																for (;;)
																{
																	IL_10BE:
																	switch (num2)
																	{
																	case 0:
																		if (acpFieldBase.UnsupportedValue)
																		{
																			num = (short)1125318659;
																			num2 = (int)((global::System.IntPtr)num);
																			continue;
																		}
																		goto IL_113E;
																	case 1:
																		goto IL_113E;
																	case 2:
																		goto IL_1156;
																	case 3:
																		global::AcpCommonLib.AppInfoManager.ImportExportFieldsReport.RegisterFieldInReport(acpFieldBase, global::AcpCommonResources.AcpResources.Value_Not_Copied_Unsupported_Value, false);
																		num = (short)415825921;
																		num2 = (int)((global::System.IntPtr)num);
																		continue;
																	}
																	goto IL_10D5;
																	IL_113E:
																	num = (short)1630797826;
																	num2 = (int)((global::System.IntPtr)num);
																}
																IL_1156:
																goto IL_1278;
																IL_10D5:
																global::AcpCommonLib.UndoRedo.UndoableTask task2;
																task.AddTask(task2);
																num = (short)473432064;
																num2 = (int)((global::System.IntPtr)num);
																goto IL_10BE;
															}
															catch (global::System.Exception)
															{
																global::AcpCommonLib.AppInfoManager.ImportExportFieldsReport.RegisterFieldInReport(acpFieldBase, global::AcpCommonResources.AcpResources.Value_Not_Copied_Unsupported_Value, false);
																goto IL_1278;
															}
															goto IL_1173;
														case 23:
															goto IL_17D4;
														case 24:
														{
															global::System.Xml.XmlNode xmlNode;
															global::AcpBusinessLayer.AcpListField acpListField;
															global::AcpCommonLib.UndoRedo.UndoableTask task2 = acpListField.CopyValuesFromXml(xmlNode);
															num = (short)493617175;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														case 25:
															goto IL_1830;
														case 26:
															if (fileType == global::AcpCommonLib.XmlFileType.ImpExp)
															{
																num = (short)2057240593;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															goto IL_1BD4;
														case 27:
														{
															global::AcpCommonLib.UndoRedo.UndoableTask task2 = null;
															global::AcpBusinessLayer.AcpListField acpListField = acpFieldBase as global::AcpBusinessLayer.AcpListField;
															num = (short)24444983;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														case 28:
															goto IL_121B;
														case 29:
														{
															global::AcpBusinessLayer.AcpSparseLOVField acpSparseLOVField;
															if (acpSparseLOVField != null)
															{
																num = (short)78512134;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															global::AcpCommonLib.UndoRedo.UndoableTask task2 = acpFieldBase.CreateSetValueTask(text);
															num = (short)615251984;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														case 30:
															if (acpRecRefField != null)
															{
																num = (short)1166409779;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															goto IL_175B;
														case 31:
															goto IL_1278;
														case 32:
															if (acpFieldBase != null)
															{
																num = (short)1667891219;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															num = (short)389152794;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 33:
															text2 = null;
															goto IL_13B8;
														case 34:
															if (acpFieldBase.Name == global::AcpBusinessLayer.UndoRedo.SetValueTask.b("軙껛뗝돟鯡韣ꇥ跧蓩觫鳭釯黱뗳藵鏷꣹駻追痿欁瘃挅氇唉䴋㨍␏⬑␓⼕", a_))
															{
																num = (short)1838940185;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															goto IL_121B;
														case 35:
														{
															global::System.Xml.XmlNode xmlNode;
															text2 = xmlNode.FirstChild.Value;
															goto IL_13B8;
														}
														case 36:
															num = (short)1532231729;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 37:
														{
															global::System.Xml.XmlNode xmlNode;
															if (xmlNode.Name != global::AcpBusinessLayer.UndoRedo.SetValueTask.b("鿙뇛볝藟蛡胣菥賧룩觫跭華韱胳", a_))
															{
																num = (short)530120761;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															goto IL_1BD4;
														}
														case 38:
															goto IL_17D4;
														case 39:
															global::AcpCommonLib.AppInfoManager.ImportExportFieldsReport.RegisterFieldInReport(acpFieldBase, global::AcpCommonResources.AcpResources.Value_Not_Copied_Unsupported_DataTransfer, false);
															num = (short)1443168296;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 40:
															goto IL_1278;
														case 41:
															if (acpRecRefField.HasSiblingRecset)
															{
																num = (short)641073219;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															goto IL_186D;
														case 42:
															goto IL_1BD4;
														case 43:
														{
															global::System.Xml.XmlNode xmlNode;
															global::System.Xml.XmlNode firstChild = xmlNode.FirstChild;
															if (firstChild == null)
															{
																num = (short)2028732463;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															a = firstChild.Value;
															goto IL_1401;
														}
														case 44:
														{
															string text3;
															if (acpFieldBase.LegacyUINames.Contains(text3))
															{
																num = (short)609157134;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															goto IL_1BD4;
														}
														case 45:
															num = (short)1269170220;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 46:
															try
															{
																num = (short)703725568;
																num2 = (int)((global::System.IntPtr)num);
																for (;;)
																{
																	switch (num2)
																	{
																	case 0:
																		switch (0)
																		{
																		case 0:
																			goto IL_14E3;
																		}
																		continue;
																	case 1:
																	{
																		global::AcpBusinessLayer.AcpFieldBase acpFieldBase2;
																		if (acpFieldBase2 != null)
																		{
																			num = (short)1025638404;
																			num2 = (int)((global::System.IntPtr)num);
																			continue;
																		}
																		break;
																	}
																	case 2:
																		goto IL_158A;
																	case 3:
																	{
																		global::System.Collections.Generic.IEnumerator<string> enumerator2;
																		if (!enumerator2.MoveNext())
																		{
																			num = (short)1512308742;
																			num2 = (int)((global::System.IntPtr)num);
																			continue;
																		}
																		string key = enumerator2.Current;
																		global::AcpBusinessLayer.AcpFieldBase acpFieldBase2 = this.fieldsByName[key];
																		num = (short)1086849025;
																		num2 = (int)((global::System.IntPtr)num);
																		continue;
																	}
																	case 4:
																	{
																		global::AcpBusinessLayer.AcpFieldBase acpFieldBase2;
																		acpFieldBase = acpFieldBase2;
																		num = (short)1722810370;
																		num2 = (int)((global::System.IntPtr)num);
																		continue;
																	}
																	case 5:
																		goto IL_15A2;
																	case 6:
																		goto IL_158A;
																	}
																	IL_14E5:
																	num = (short)298909699;
																	num2 = (int)((global::System.IntPtr)num);
																	continue;
																	IL_14E3:
																	goto IL_14E5;
																	IL_158A:
																	num = (short)1377894405;
																	num2 = (int)((global::System.IntPtr)num);
																}
																IL_15A2:
																goto IL_11E1;
															}
															finally
															{
																num = (short)1777664001;
																num2 = (int)((global::System.IntPtr)num);
																for (;;)
																{
																	global::System.Collections.Generic.IEnumerator<string> enumerator2;
																	switch (num2)
																	{
																	case 0:
																		goto IL_1612;
																	case 1:
																		switch (0)
																		{
																		case 0:
																			goto IL_15D9;
																		}
																		continue;
																	case 2:
																		enumerator2.Dispose();
																		num = (short)1221001216;
																		num2 = (int)((global::System.IntPtr)num);
																		continue;
																	}
																	IL_15D9:
																	if (enumerator2 == null)
																	{
																		break;
																	}
																	num = (short)1234108418;
																	num2 = (int)((global::System.IntPtr)num);
																}
																IL_1612:;
															}
															goto IL_1615;
														case 47:
															a = null;
															goto IL_1401;
														case 48:
															goto IL_1278;
														case 49:
														{
															global::System.Xml.XmlNode xmlNode;
															if (xmlNode.FirstChild != null)
															{
																num = (short)1931608072;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															num = (short)1097924641;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														case 50:
															goto IL_1278;
														case 51:
															RecRefFieldsOfEmbedRecset.Remove(acpRecRefField);
															num = (short)399704077;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 52:
															num = (short)624099340;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 53:
															acpFieldBase.Editable = true;
															num = (short)1100611612;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 54:
														{
															global::AcpBusinessLayer.AcpListField acpListField;
															if (acpListField.SerializeItems)
															{
																num = (short)682164248;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															global::AcpBusinessLayer.AcpSparseLOVField acpSparseLOVField = acpFieldBase as global::AcpBusinessLayer.AcpSparseLOVField;
															num = (short)1041235997;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														case 55:
														{
															global::AcpBusinessLayer.AcpListField acpListField;
															if (acpListField != null)
															{
																num = (short)100073531;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															global::AcpCommonLib.UndoRedo.UndoableTask task2 = acpFieldBase.CreateSetValueTask(text);
															num = (short)1755840550;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														case 56:
															goto IL_175B;
														case 57:
														{
															global::System.Xml.XmlNode xmlNode;
															global::AcpCommonLib.Utility.LogMissingXmlNode(xmlNode);
															num = (short)1150025770;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														case 58:
														{
															string text3;
															if (string.Compare(text3, acpFieldBase.UIName) != 0)
															{
																num = (short)974651437;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															goto IL_1A2D;
														}
														case 59:
															num = (short)1226178614;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 60:
															if (flag)
															{
																num = (short)1723727899;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															goto IL_1278;
														case 61:
															num = (short)1587347487;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 62:
															goto IL_175B;
														case 63:
															try
															{
																acpFieldBase.UnsupportedValue = false;
																global::AcpBusinessLayer.AcpSparseLOVField acpSparseLOVField;
																int newValue = (int)acpSparseLOVField.Converter.ConvertBack(text, null, acpSparseLOVField.ConverterParameterObject, null);
																global::AcpCommonLib.UndoRedo.UndoableTask task2 = acpSparseLOVField.GetModifyDataTask(newValue);
																goto IL_17D4;
															}
															catch
															{
																acpFieldBase.UnsupportedValue = true;
																goto IL_17D4;
															}
															goto IL_1830;
														case 64:
														{
															global::System.Xml.XmlNode xmlNode;
															if (xmlNode == null)
															{
																num = (short)1244069956;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															num = (short)199032875;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														case 65:
															if (!acpFieldBase.HiddenStatic)
															{
																num = (short)154337332;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															goto IL_1278;
														case 66:
														{
															global::System.Collections.Generic.IEnumerator<string> enumerator2 = global::AcpCommonLib.AppInfoManager.GetInternalNamesByUIName(xmlAttribute.Value).GetEnumerator();
															num = (short)2007498798;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														case 67:
															flag = false;
															num = (short)1233322046;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 68:
															num = (short)1753612306;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 69:
															num = (short)1217200169;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														goto IL_FBF;
														IL_1173:
														global::AcpCommonLib.AppInfoManager.ImportExportFieldsReport.RegisterFieldInReport(acpFieldBase, global::AcpCommonResources.AcpResources.Value_Not_Copied_Uneditable_Destination, false);
														num = (short)510984242;
														num2 = (int)((global::System.IntPtr)num);
														continue;
														IL_11E1:
														num = (short)1724579872;
														num2 = (int)((global::System.IntPtr)num);
														continue;
														IL_121B:
														num = (short)913309716;
														num2 = (int)((global::System.IntPtr)num);
														continue;
														IL_1401:
														if (a == bool.TrueString)
														{
															num = (short)413270069;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														goto IL_121B;
														IL_1278:
														num = (short)892993536;
														num2 = (int)((global::System.IntPtr)num);
														continue;
														IL_13B8:
														text = text2;
														flag = true;
														acpRecRefField = (acpFieldBase as global::AcpBusinessLayer.AcpRecRefField);
														num = (short)901185566;
														num2 = (int)((global::System.IntPtr)num);
														continue;
														IL_1615:
														num = (short)1839136771;
														num2 = (int)((global::System.IntPtr)num);
														continue;
														IL_175B:
														num = (short)486080572;
														num2 = (int)((global::System.IntPtr)num);
														continue;
														IL_17D4:
														num = (short)99942422;
														num2 = (int)((global::System.IntPtr)num);
														continue;
														IL_1830:
														num = (short)158531648;
														num2 = (int)((global::System.IntPtr)num);
														continue;
														IL_186D:
														num = (short)737935370;
														num2 = (int)((global::System.IntPtr)num);
														continue;
														IL_1A2D:
														num = (short)1032257570;
														num2 = (int)((global::System.IntPtr)num);
														continue;
														IL_1BD4:
														num = (short)234618895;
														num2 = (int)((global::System.IntPtr)num);
													}
													IL_1291:
													goto IL_1CC1;
													IL_1BEC:
													break;
													IL_FBF:
													acpFieldBase = (global::AcpBusinessLayer.AcpFieldBase)this[xmlAttribute.Value];
													num = (short)49545217;
													num2 = (int)((global::System.IntPtr)num);
													goto IL_EA0;
												}
												catch (global::System.Collections.Generic.KeyNotFoundException)
												{
												}
												break;
											case 3:
												num = (short)213385220;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 4:
												goto IL_1C4A;
											case 5:
											{
												global::System.Xml.XmlAttribute xmlAttribute;
												if (xmlAttribute != null)
												{
													num = (short)2097872898;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											}
											IL_1BF1:
											num = (short)1367080961;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_E34:
											goto IL_1BF1;
										}
										IL_1C4A:;
									}
									finally
									{
										switch (0)
										{
										case 0:
											goto IL_1C69;
										}
										global::System.IDisposable disposable;
										for (;;)
										{
											IL_1C56:
											switch (num2)
											{
											case 0:
												goto IL_1CBE;
											case 1:
												if (disposable != null)
												{
													num = (short)264962050;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_1CC0;
											case 2:
												disposable.Dispose();
												num = (short)1283129344;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_1C69;
										}
										IL_1CBE:
										IL_1CC0:
										break;
										IL_1C69:
										disposable = (enumerator as global::System.IDisposable);
										num = (short)388759553;
										num2 = (int)((global::System.IntPtr)num);
										goto IL_1C56;
									}
									break;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_DEF;
									}
									continue;
								case 4:
								{
									if (!enumerator3.MoveNext())
									{
										num = (short)1991245824;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string text3 = enumerator3.Current;
									enumerator = node.ChildNodes.GetEnumerator();
									num = (short)1353580546;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_1CC1:
								num = (short)1673789444;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_DEF:
								goto IL_1CC1;
							}
							IL_1D4E:
							goto IL_D71;
						}
						finally
						{
							((global::System.IDisposable)enumerator3).Dispose();
						}
						goto IL_1D61;
						IL_D71:
						num = (short)1012072465;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						global::AcpBusinessLayer.FeatureNode featureNode;
						if (featureNode.KeyField.Editable)
						{
							num = (short)1203306500;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C5F;
					}
					case 16:
						return true;
					case 17:
						if (this.HasEmbeddedRecset)
						{
							num = (short)134676502;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 18:
					{
						bool flag2 = node.Attributes[global::AcpBusinessLayer.UndoRedo.SetValueTask.b("鿙뇛볝藟蛡胣菥賧", a_)] != null;
						dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField>>();
						list = new global::System.Collections.Generic.List<string>();
						if (flag2)
						{
							num = (short)1674379266;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_575;
					}
					case 19:
					{
						global::AcpBusinessLayer.FeatureNode featureNode;
						if (featureNode != null)
						{
							num = (short)1207173158;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FD0;
					}
					case 20:
						try
						{
							num = (short)85983233;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)468779010;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1E43;
									}
									continue;
								case 2:
									goto IL_1EC3;
								case 4:
								{
									global::System.Collections.Generic.SortedDictionary<int, string>.Enumerator enumerator4;
									if (!enumerator4.MoveNext())
									{
										num = (short)1887174656;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<int, string> keyValuePair = enumerator4.Current;
									list2.Add(keyValuePair.Value);
									num = (short)9830403;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_1E73:
								num = (short)1532952580;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1E43:
								goto IL_1E73;
							}
							IL_1EC3:
							goto IL_BE9;
						}
						finally
						{
							global::System.Collections.Generic.SortedDictionary<int, string>.Enumerator enumerator4;
							((global::System.IDisposable)enumerator4).Dispose();
						}
						goto IL_1ED6;
					case 21:
						if (!importCopyOper)
						{
							num = (short)331350017;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FD0;
					case 22:
						num = (short)142737426;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						if (this.EmbeddedRecset.Min != this.EmbeddedRecset.Max)
						{
							num = (short)1879900163;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FD0;
					case 24:
						num = (short)2089025546;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
					{
						global::AcpBusinessLayer.FeatureNode featureNode;
						if (featureNode != null)
						{
							num = (short)735903750;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C5F;
					}
					case 26:
						num = (short)411500559;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						num = (short)1051852823;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						num = (short)1977745440;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
					{
						try
						{
							num = (short)931135492;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpBusinessLayer.FeatureNode featureNode2;
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.AcpRecRefField> enumerator5 = featureNode2.KeyField.ReferencingFields.GetEnumerator();
									num = (short)1723138054;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_3C8;
								case 2:
									goto IL_3E1;
								case 3:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator6;
									if (!enumerator6.MoveNext())
									{
										num = (short)88932353;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureNode featureNode2 = enumerator6.Current;
									num = (short)1206386693;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_1E9;
									}
									continue;
								case 5:
								{
									global::AcpBusinessLayer.FeatureNode featureNode2;
									if (featureNode2.KeyField.ReferencingFields != null)
									{
										num = (short)74907648;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									try
									{
										num = (short)1620049922;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 1:
												num = (short)195100676;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_2D4;
												}
												continue;
											case 3:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.AcpRecRefField> enumerator5;
												if (!enumerator5.MoveNext())
												{
													num = (short)1610678273;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::AcpBusinessLayer.AcpRecRefField acpRecRefField2 = enumerator5.Current;
												RecRefFieldsOfEmbedRecset[acpRecRefField2] = acpRecRefField2.UIValue;
												num = (short)2040332288;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 4:
												goto IL_355;
											}
											IL_306:
											num = (short)414908419;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_2D4:
											goto IL_306;
										}
										IL_355:
										break;
									}
									finally
									{
										num = (short)385941504;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.AcpRecRefField> enumerator5;
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_38C;
												}
												continue;
											case 1:
												enumerator5.Dispose();
												num = (short)1387397122;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												goto IL_3C5;
											}
											IL_38C:
											if (enumerator5 == null)
											{
												break;
											}
											num = (short)1708392449;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_3C5:;
									}
									goto IL_3C8;
								}
								IL_1EB:
								num = (short)497745923;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1E9:
								goto IL_1EB;
								IL_3C8:
								num = (short)1646723074;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3E1:
							goto IL_20B8;
						}
						finally
						{
							num = (short)118030336;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator6;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_419;
									}
									continue;
								case 1:
									enumerator6.Dispose();
									num = (short)971505666;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_452;
								}
								IL_419:
								if (enumerator6 == null)
								{
									break;
								}
								num = (short)398917633;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_452:;
						}
						goto IL_455;
						IL_20B8:
						this.a(node.FirstChild, list);
						((global::AcpBusinessLayer.Recordset)this.EmbeddedRecset).FindNewFieldsInEmbeddedRecset_ImpExp(list, dictionary);
						this.EmbeddedRecset.ClearRecordset(this.EmbeddedRecset, task);
						num = (short)1427505152;
						short num3 = num;
						num = (short)1759838219;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
						if (this.EmbeddedRecset != null)
						{
							num = (short)431882268;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_455;
					case 31:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator6 = ((global::AcpBusinessLayer.Recordset)this.EmbeddedRecset).GetEnumerator();
						num = (short)970588189;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 32:
						if (!this.EmbeddedRecset.HiddenStatic)
						{
							num = (short)28770309;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_575;
					case 33:
						goto IL_B22;
					case 34:
						if (this.EmbeddedRecset.Min != this.EmbeddedRecset.Max)
						{
							num = (short)118358047;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C5F;
					case 35:
					{
						global::AcpBusinessLayer.FeatureNode featureNode;
						if (featureNode.KeyField == null)
						{
							num = (short)1795620891;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FD0;
					}
					case 36:
						if (fileType == global::AcpCommonLib.XmlFileType.ImpExp)
						{
							num = (short)520683562;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_575;
					case 37:
						goto IL_1ED6;
					case 38:
						goto IL_1D61;
					case 39:
						num = (short)830406691;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						num = (short)795344897;
						if (num != 0)
						{
						}
						num = (short)1775239175;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						if (this.EmbeddedRecset.Count > 0)
						{
							num = (short)1947336743;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FD0;
					case 42:
						global::AcpCommonLib.Utility.LogMissingXmlNode(node);
						num = (short)1508900872;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
					{
						try
						{
							num = (short)2097872899;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									try
									{
										switch (0)
										{
										case 0:
											goto IL_66B;
										}
										global::AcpBusinessLayer.AcpFieldBase acpFieldBase4;
										global::System.Xml.XmlAttribute xmlAttribute2;
										for (;;)
										{
											IL_634:
											switch (num2)
											{
											case 0:
												try
												{
													num = (short)1865809924;
													num2 = (int)((global::System.IntPtr)num);
													for (;;)
													{
														switch (num2)
														{
														case 0:
														{
															global::System.Collections.Generic.IEnumerator<string> enumerator2;
															if (!enumerator2.MoveNext())
															{
																num = (short)1270480902;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															string key2 = enumerator2.Current;
															global::AcpBusinessLayer.AcpFieldBase acpFieldBase3 = this.fieldsByName[key2];
															num = (short)893845505;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														case 1:
														{
															global::AcpBusinessLayer.AcpFieldBase acpFieldBase3;
															if (acpFieldBase3 != null)
															{
																num = (short)851312645;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															break;
														}
														case 2:
															goto IL_7BD;
														case 3:
															goto IL_7A4;
														case 4:
															switch (0)
															{
															case 0:
																goto IL_6FA;
															}
															continue;
														case 5:
														{
															global::AcpBusinessLayer.AcpFieldBase acpFieldBase3;
															acpFieldBase4 = acpFieldBase3;
															num = (short)1413152771;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														case 6:
															goto IL_7A4;
														}
														IL_766:
														num = (short)7929856;
														num2 = (int)((global::System.IntPtr)num);
														continue;
														IL_6FA:
														goto IL_766;
														IL_7A4:
														num = (short)620691458;
														num2 = (int)((global::System.IntPtr)num);
													}
													IL_7BD:
													goto IL_939;
												}
												finally
												{
													num = (short)2031747074;
													num2 = (int)((global::System.IntPtr)num);
													for (;;)
													{
														global::System.Collections.Generic.IEnumerator<string> enumerator2;
														switch (num2)
														{
														case 0:
															enumerator2.Dispose();
															num = (short)811794433;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 1:
															goto IL_82E;
														case 2:
															switch (0)
															{
															case 0:
																goto IL_7F5;
															}
															continue;
														}
														IL_7F5:
														if (enumerator2 == null)
														{
															break;
														}
														num = (short)1867972608;
														num2 = (int)((global::System.IntPtr)num);
													}
													IL_82E:;
												}
												goto IL_831;
											case 1:
												goto IL_972;
											case 2:
												if (acpFieldBase4 == null)
												{
													num = (short)1199964169;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_939;
											case 3:
												goto IL_98A;
											case 4:
												if (!list3.Contains(xmlAttribute2.Value))
												{
													num = (short)679149575;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_972;
											case 5:
												if (acpFieldBase4 != null)
												{
													num = (short)852230155;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_972;
											case 6:
												goto IL_831;
											case 7:
												list3.Add(xmlAttribute2.Value);
												num = (short)837222410;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 8:
												if (acpFieldBase4.DataTransferOrder > 0)
												{
													num = (short)317063174;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												num = (short)336527364;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 9:
											{
												global::System.Collections.Generic.IEnumerator<string> enumerator2 = global::AcpCommonLib.AppInfoManager.GetInternalNamesByUIName(xmlAttribute2.Value).GetEnumerator();
												num = (short)758513664;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 10:
												goto IL_972;
											case 11:
												num = (short)624951304;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_66B;
											IL_831:
											sortedDictionary.Add(acpFieldBase4.DataTransferOrder, xmlAttribute2.Value);
											num = (short)1606549505;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_939:
											num = (short)2030829573;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_972:
											num = (short)1264713731;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_98A:
										break;
										IL_66B:
										acpFieldBase4 = (global::AcpBusinessLayer.AcpFieldBase)this[xmlAttribute2.Value];
										num = (short)540934146;
										num2 = (int)((global::System.IntPtr)num);
										goto IL_634;
									}
									catch (global::System.ArgumentException)
									{
									}
									catch (global::System.Collections.Generic.KeyNotFoundException)
									{
									}
									break;
								case 1:
								{
									global::System.Xml.XmlAttribute xmlAttribute2;
									if (xmlAttribute2 != null)
									{
										num = (short)2065563648;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1015676932;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Xml.XmlAttribute xmlAttribute2 = ((global::System.Xml.XmlNode)enumerator.Current).Attributes[global::AcpBusinessLayer.UndoRedo.SetValueTask.b("铙뷛돝藟", a_)];
									num = (short)943915009;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_625;
									}
									continue;
								case 4:
									num = (short)2097807365;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_A4F;
								}
								IL_992:
								num = (short)1747058690;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_625:
								goto IL_992;
							}
							IL_A4F:
							goto IL_208C;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_A71;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_A5E:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)1330970625;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_B1F;
								case 2:
								{
									if (disposable == null)
									{
										goto IL_B21;
									}
									num = (short)833480090;
									short num4 = num;
									num = (short)404088218;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_B1F;
									default:
										num = (short)967245824;
										if (num != 0)
										{
										}
										num = (short)698875904;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								goto IL_A71;
							}
							IL_B1F:
							IL_B21:
							goto EndFinally_98;
							IL_A71:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)345440258;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_A5E;
							EndFinally_98:;
						}
						goto Block_8;
						IL_208C:
						list2 = new global::System.Collections.Generic.List<string>();
						global::System.Collections.Generic.SortedDictionary<int, string>.Enumerator enumerator4 = sortedDictionary.GetEnumerator();
						num = (short)926351380;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_E8;
					IL_455:
					num = (short)1038352420;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_8:
					try
					{
						IL_B22:
						num = (short)1865416707;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								num = (short)546111489;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_BD6;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_B5C;
								}
								continue;
							case 4:
							{
								if (!enumerator3.MoveNext())
								{
									num = (short)1947598848;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								string item = enumerator3.Current;
								list2.Add(item);
								num = (short)1733885954;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_B5E:
							num = (short)1310724;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_B5C:
							goto IL_B5E;
						}
						IL_BD6:
						goto IL_4FD;
					}
					finally
					{
						((global::System.IDisposable)enumerator3).Dispose();
					}
					goto IL_BE9;
					IL_4FD:
					flag = true;
					enumerator3 = list2.GetEnumerator();
					num = (short)449183758;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_575:
					list.Clear();
					dictionary.Clear();
					num = (short)1380122640;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BE9:
					enumerator3 = list3.GetEnumerator();
					num = (short)845217825;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C5F:
					num = (short)1084686355;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1D61:
					num = (short)1674706985;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1ED6:
					num = (short)480051221;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1FD0:
					((global::AcpBusinessLayer.Recordset)this.EmbeddedRecset).ReadFromXml(node.FirstChild, task, fileType, true, RecRefsToRepair, RecRefFieldsOfEmbedRecset);
					((global::AcpBusinessLayer.Recordset)this.EmbeddedRecset).UpdateNewFieldsInEmbeddedRecset_ImpExpDnD(task, dictionary);
					num = (short)89587721;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_E8:
				sortedDictionary = new global::System.Collections.Generic.SortedDictionary<int, string>();
				list3 = new global::System.Collections.Generic.List<string>();
				enumerator = node.ChildNodes.GetEnumerator();
				num = (short)1623261227;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00044AA8 File Offset: 0x00042CA8
		private void a(global::System.Xml.XmlNode A_0, global::System.Collections.Generic.List<string> A_1)
		{
			int a_ = 1;
			short num = (short)964165632;
			short num2 = num;
			num = (short)87949312;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6E;
				}
				global::System.Xml.XmlNode firstChild;
				for (;;)
				{
					IL_5B:
					global::System.Collections.IEnumerator enumerator;
					switch (num3)
					{
					case 0:
						try
						{
							num = (short)1680080900;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									goto IL_360;
								case 1:
									goto IL_378;
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)344195072;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.IEnumerator enumerator2 = ((global::System.Xml.XmlNode)enumerator.Current).ChildNodes.GetEnumerator();
									num = (short)726925315;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									try
									{
										num = (short)534446086;
										num3 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Xml.XmlAttribute xmlAttribute;
											switch (num3)
											{
											case 0:
												goto IL_2E4;
											case 1:
												goto IL_1C0;
											case 2:
												num = (short)547028992;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											case 4:
												if (xmlAttribute != null)
												{
													num = (short)1208090625;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											case 5:
											{
												global::System.Collections.IEnumerator enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = (short)1448411138;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												num = (short)819349224;
												short num4 = num;
												num = (short)1122584296;
												switch ((num4 == num) ? 1 : 0)
												{
												case 0:
												case 2:
													goto IL_1C0;
												default:
													num = (short)223281152;
													if (num != 0)
													{
													}
													xmlAttribute = ((global::System.Xml.XmlNode)enumerator2.Current).Attributes[global::AcpBusinessLayer.UndoRedo.SetValueTask.b("鷒듔뫖볘", a_)];
													num = (short)989724676;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 6:
												switch (0)
												{
												case 0:
													goto IL_1BB;
												}
												continue;
											}
											goto IL_1BB;
											IL_1C0:
											A_1.Add(xmlAttribute.Value);
											num = (short)1396703235;
											num3 = (int)((global::System.IntPtr)num);
											continue;
											IL_28F:
											num = (short)61276165;
											num3 = (int)((global::System.IntPtr)num);
											continue;
											IL_1BB:
											goto IL_28F;
										}
										IL_2E4:
										break;
									}
									finally
									{
										switch (0)
										{
										case 0:
											goto IL_306;
										}
										global::System.IDisposable disposable;
										for (;;)
										{
											IL_2F3:
											switch (num3)
											{
											case 0:
												goto IL_35D;
											case 1:
												disposable.Dispose();
												num = (short)1736179712;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												if (disposable != null)
												{
													num = (short)1449984001;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_35F;
											}
											goto IL_306;
										}
										IL_35D:
										IL_35F:
										goto EndFinally_11;
										IL_306:
										global::System.Collections.IEnumerator enumerator2;
										disposable = (enumerator2 as global::System.IDisposable);
										num = (short)1688469506;
										num3 = (int)((global::System.IntPtr)num);
										goto IL_2F3;
										EndFinally_11:;
									}
									goto IL_360;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_10E;
									}
									continue;
								}
								IL_110:
								num = (short)662175746;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_10E:
								goto IL_110;
								IL_360:
								num = (short)2004156417;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_378:
							return;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_39A;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_387:
								switch (num3)
								{
								case 0:
									goto IL_3F1;
								case 1:
									disposable.Dispose();
									num = (short)1122369536;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									if (disposable != null)
									{
										num = (short)1782579201;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3F3;
								}
								goto IL_39A;
							}
							IL_3F1:
							IL_3F3:
							goto EndFinally_12;
							IL_39A:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)204275714;
							num3 = (int)((global::System.IntPtr)num);
							goto IL_387;
							EndFinally_12:;
						}
						goto IL_3F4;
					case 1:
						goto IL_3F4;
					case 2:
						num = (short)306577409;
						if (num != 0)
						{
						}
						if (firstChild != null)
						{
							num = (short)1458110465;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					goto IL_6E;
					IL_3F4:
					global::System.Xml.XmlAttribute xmlAttribute2 = firstChild.Attributes[global::AcpBusinessLayer.UndoRedo.SetValueTask.b("뫒뇔", a_)];
					enumerator = firstChild.ChildNodes.GetEnumerator();
					num = (short)1139212288;
					num3 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_6E:
				firstChild = A_0.FirstChild;
				num = (short)1327169538;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_5B;
			}
			}
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00044F20 File Offset: 0x00043120
		internal global::AcpCommonLib.IAcpField FieldFromPathHelper(string path, bool absolute, string delimiter)
		{
			short num = (short)1286144000;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_56;
				}
				global::AcpCommonLib.IAcpField acpField;
				string[] array;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						if (acpField == null)
						{
							num = (short)304480264;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DC;
					case 1:
						if (acpField == null)
						{
							num = (short)883621894;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return acpField;
					case 2:
						acpField = this.embeddedRecset.FieldFromPathHelper(array[1], absolute, delimiter);
						num = (short)534380549;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (array[0] == this.UIName)
						{
							num = (short)539164681;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return acpField;
					case 4:
						if (this.HasEmbeddedRecset)
						{
							num = (short)1266548738;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return acpField;
					case 5:
						return acpField;
					case 6:
						num = (short)1136197636;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						try
						{
							num = (short)103088135;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									bool flag;
									if (flag)
									{
										num = (short)762314756;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									goto IL_513;
								case 2:
									num = (short)332398593;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									try
									{
										num = (short)1848573958;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::AcpCommonLib.IAcpField acpField2;
											global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator;
											switch (num2)
											{
											case 0:
												goto IL_401;
											case 1:
												goto IL_3A4;
											case 2:
												num = (short)1174011904;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 3:
												if (acpField2.NewUIName == array[1])
												{
													num = (short)884124369;
													short num3 = num;
													num = (short)693349073;
													switch ((num3 == num) ? 1 : 0)
													{
													case 0:
													case 2:
														goto IL_2EE;
													default:
														num = (short)1384513536;
														if (num != 0)
														{
														}
														num = (short)1820590084;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
												}
												break;
											case 4:
											{
												acpField = acpField2;
												bool flag = true;
												num = (short)1020461057;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 5:
												if (!enumerator.MoveNext())
												{
													num = (short)209387522;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_2EE;
											case 6:
												switch (0)
												{
												case 0:
													goto IL_2E9;
												}
												continue;
											}
											goto IL_2E9;
											IL_2EE:
											acpField2 = enumerator.Current;
											num = (short)1799225347;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_3A9:
											num = (short)1090846725;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_2E9:
											goto IL_3A9;
										}
										IL_3A4:
										IL_401:
										goto IL_272;
									}
									finally
									{
										num = (short)1587085314;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator;
											switch (num2)
											{
											case 0:
												goto IL_46F;
											case 1:
												enumerator.Dispose();
												num = (short)1637482496;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_438;
												}
												continue;
											}
											IL_438:
											if (enumerator == null)
											{
												break;
											}
											num = (short)1441398785;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_46F:;
									}
									break;
									IL_272:
									num = (short)882835456;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									num = (short)3866630;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)677576706;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureSection acpFeatureSection = enumerator2.Current;
									bool flag = false;
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator = acpFeatureSection.FieldsCollection.GetEnumerator();
									num = (short)1192886275;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_4C4;
								case 7:
									switch (0)
									{
									case 0:
										goto IL_26D;
									}
									continue;
								}
								IL_472:
								num = (short)546701317;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_26D:
								goto IL_472;
							}
							IL_4C4:
							IL_513:
							goto IL_DC;
						}
						finally
						{
							num = (short)1740505090;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2;
								switch (num2)
								{
								case 0:
									goto IL_580;
								case 1:
									enumerator2.Dispose();
									num = (short)517603328;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_54B;
									}
									continue;
								}
								IL_54B:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)345964545;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_580:;
						}
						return acpField;
					case 8:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2 = this.Parent.FeatureSectionsCollection.GetEnumerator();
						num = (short)1049427975;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						acpField = this[array[1]];
						num = (short)533004288;
						short num4 = num;
						num = (short)529465344;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_56;
					IL_DC:
					num = (short)944832513;
					num2 = (int)((global::System.IntPtr)num);
				}
				return acpField;
				IL_56:
				num = (short)902103041;
				if (num != 0)
				{
				}
				acpField = null;
				array = path.Split(new string[]
				{
					delimiter
				}, 2, global::System.StringSplitOptions.None);
				num = (short)893255683;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000376 RID: 886 RVA: 0x000454E8 File Offset: 0x000436E8
		// (set) Token: 0x06000377 RID: 887 RVA: 0x00045598 File Offset: 0x00043798
		public global::AcpCommonLib.IAcpFeatureNode Parent
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)328597504;
				short num2 = num;
				num = (short)1742276418;
				short num3 = num;
				num = (short)1582368578;
				switch (num3 == num)
				{
				}
				num = (short)98697216;
				if (num != 0)
				{
				}
				num = (short)885784577;
				if (num != 0)
				{
				}
				return this.<Parent>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)622067712;
				short num2 = num;
				num = (short)982089916;
				short num3 = num;
				num = (short)1046380732;
				switch (num3 == num)
				{
				}
				num = (short)2066415616;
				if (num != 0)
				{
				}
				num = (short)1867317249;
				if (num != 0)
				{
				}
				this.<Parent>k__BackingField = value;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000378 RID: 888 RVA: 0x00045648 File Offset: 0x00043848
		public global::AcpCommonLib.IAcpRecordset ParentRecset
		{
			get
			{
				short num = (short)633991338;
				short num2 = num;
				num = (short)1081143466;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_A4;
				case 1:
					break;
				default:
				{
					num = (short)1201602560;
					short num3 = num;
					break;
				}
				}
				num = (short)1771044865;
				if (num != 0)
				{
				}
				num = (short)9043968;
				if (num != 0)
				{
				}
				if (this.Parent == null)
				{
					return null;
				}
				IL_A4:
				return this.Parent.Parent;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000379 RID: 889 RVA: 0x00045708 File Offset: 0x00043908
		public int FeatureSectionId
		{
			get
			{
				short num = (short)515506176;
				short num2 = num;
				num = (short)2104341095;
				short num3 = num;
				num = (short)1432793703;
				switch (num3 == num)
				{
				}
				num = (short)1865482240;
				if (num != 0)
				{
				}
				num = (short)2016542721;
				if (num != 0)
				{
				}
				return this.Id;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600037A RID: 890 RVA: 0x000457B8 File Offset: 0x000439B8
		// (set) Token: 0x0600037B RID: 891 RVA: 0x00045864 File Offset: 0x00043A64
		public string FeatureSectionName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1518075904;
				short num2 = num;
				num = (short)542607215;
				short num3 = num;
				num = (short)2138015599;
				switch (num3 == num)
				{
				}
				num = (short)478150656;
				if (num != 0)
				{
				}
				num = (short)466550785;
				if (num != 0)
				{
				}
				return this.<FeatureSectionName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)200343552;
				short num2 = num;
				num = (short)330008164;
				short num3 = num;
				num = (short)682460772;
				switch (num3 == num)
				{
				}
				num = (short)1505165313;
				if (num != 0)
				{
				}
				num = (short)1282015232;
				if (num != 0)
				{
				}
				this.<FeatureSectionName>k__BackingField = value;
			}
		}

		// Token: 0x170000DB RID: 219
		internal global::AcpCommonLib.IAcpField this[string name, bool isName]
		{
			get
			{
				short num = (short)1017249792;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_34;
						}
						continue;
					case 1:
						if (this.fieldsByName.ContainsKey(name))
						{
							num = (short)1937833986;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9A;
					case 2:
						goto IL_136;
					case 3:
						goto IL_98;
					}
					IL_34:
					num = (short)2056446377;
					short num3 = num;
					num = (short)951116201;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_98:
						num = (short)282853377;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
						num = (short)187760640;
						if (num != 0)
						{
						}
						if (!isName)
						{
							goto IL_138;
						}
						num = (short)1051197443;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_9A:
				num = (short)2101280769;
				if (num != 0)
				{
				}
				return null;
				IL_136:
				num = (short)290193408;
				short num4 = num;
				return this.fieldsByName[name];
				IL_138:
				return this[name];
			}
			set
			{
				short num = (short)1611291286;
				short num2 = num;
				num = (short)142236310;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_78;
				case 1:
					break;
				default:
				{
					num = (short)2027880448;
					short num3 = num;
					break;
				}
				}
				num = (short)450560000;
				if (num != 0)
				{
				}
				if (!isName)
				{
					this[name] = value;
					return;
				}
				IL_78:
				num = (short)367984641;
				if (num != 0)
				{
				}
				global::AcpBusinessLayer.AcpFieldBase value2 = (global::AcpBusinessLayer.AcpFieldBase)value;
				this.fieldsByName[name] = value2;
			}
		}

		// Token: 0x170000DC RID: 220
		public global::AcpCommonLib.IAcpField this[string uiName]
		{
			get
			{
				short num = (short)959119361;
				if (num != 0)
				{
				}
				num = (short)1579024384;
				short num2 = num;
				num = (short)939539509;
				short num3 = num;
				num = (short)1962490933;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1749876736;
					if (num != 0)
					{
					}
					if (!this.fieldsByUIName.ContainsKey(uiName))
					{
						return null;
					}
					break;
				}
				return this.fieldsByUIName[uiName];
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_2C;
				}
				int num;
				global::System.Guid guid;
				short num2;
				global::AcpBusinessLayer.AcpFieldBase acpFieldBase;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_D2;
					case 1:
					{
						global::AcpCommonLib.IAcpFeatureSection acpFeatureSection = global::AcpBusinessLayer.FeatureSection.InitializedSections[guid];
						num2 = (short)1843658755;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 2:
						if (global::AcpBusinessLayer.FeatureSection.InitializedSections.ContainsKey(guid))
						{
							num2 = (short)2013396993;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						global::AcpBusinessLayer.FeatureSection.InitializedSections[guid] = this;
						acpFieldBase.CreateFieldData(uiName);
						num2 = (short)584318981;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
					{
						global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
						if (acpFeatureSection == this)
						{
							num2 = (short)1986134020;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						acpFieldBase.FieldData = ((global::AcpBusinessLayer.AcpFieldBase)acpFeatureSection[uiName]).FieldData;
						num2 = (short)80281601;
						if (num2 != 0)
						{
						}
						num2 = (short)546504704;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 4:
					{
						acpFieldBase.CreateFieldData(uiName);
						num2 = (short)490923245;
						short num3 = num2;
						num2 = (short)1649337581;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_D2;
						default:
							num2 = (short)814612480;
							if (num2 != 0)
							{
							}
							num2 = (short)2123169798;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 5:
						goto IL_1BA;
					case 6:
						goto IL_142;
					}
					goto IL_2C;
				}
				IL_D2:
				IL_142:
				goto IL_1E6;
				IL_1BA:
				num2 = (short)1668546560;
				short num4 = num2;
				IL_1E6:
				this.fieldsByUIName[uiName] = acpFieldBase;
				return;
				IL_2C:
				acpFieldBase = (global::AcpBusinessLayer.AcpFieldBase)value;
				guid = base.GetType().GUID;
				num2 = (short)2062221314;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000380 RID: 896 RVA: 0x00045DF8 File Offset: 0x00043FF8
		public global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpField> FieldsCollection
		{
			get
			{
				short num = (short)1383989248;
				short num2 = num;
				num = (short)1976276512;
				short num3 = num;
				num = (short)24155680;
				switch (num3 == num)
				{
				}
				num = (short)1008336897;
				if (num != 0)
				{
				}
				num = (short)2089680896;
				if (num != 0)
				{
				}
				global::AcpBusinessLayer.FeatureSection.<get_FieldsCollection>d__54 <get_FieldsCollection>d__ = new global::AcpBusinessLayer.FeatureSection.<get_FieldsCollection>d__54(-2);
				<get_FieldsCollection>d__.<>4__this = this;
				return <get_FieldsCollection>d__;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000381 RID: 897 RVA: 0x00045EAC File Offset: 0x000440AC
		public global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpField> FieldsCollectionByOrder
		{
			get
			{
				short num = (short)1810956288;
				short num2 = num;
				num = (short)1837784077;
				short num3 = num;
				num = (short)85810189;
				switch (num3 == num)
				{
				}
				num = (short)366215169;
				if (num != 0)
				{
				}
				num = (short)1492058112;
				if (num != 0)
				{
				}
				global::AcpBusinessLayer.FeatureSection.<get_FieldsCollectionByOrder>d__56 <get_FieldsCollectionByOrder>d__ = new global::AcpBusinessLayer.FeatureSection.<get_FieldsCollectionByOrder>d__56(-2);
				<get_FieldsCollectionByOrder>d__.<>4__this = this;
				return <get_FieldsCollectionByOrder>d__;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000382 RID: 898 RVA: 0x00045F60 File Offset: 0x00044160
		public int FieldsCount
		{
			get
			{
				short num = (short)566493184;
				short num2 = num;
				num = (short)1849326681;
				short num3 = num;
				num = (short)1359379545;
				switch (num3 == num)
				{
				}
				num = (short)210960385;
				if (num != 0)
				{
				}
				num = (short)1987313664;
				if (num != 0)
				{
				}
				return this.fieldsByUIName.Count;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000383 RID: 899 RVA: 0x00046014 File Offset: 0x00044214
		public bool HasEmbeddedRecset
		{
			get
			{
				short num = (short)1662779392;
				short num2 = num;
				num = (short)2020522274;
				short num3 = num;
				num = (short)1358280994;
				switch (num3 == num)
				{
				}
				num = (short)1354170369;
				if (num != 0)
				{
				}
				num = (short)1414070272;
				if (num != 0)
				{
				}
				return this.EmbeddedRecset != null;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000384 RID: 900 RVA: 0x000460C4 File Offset: 0x000442C4
		// (set) Token: 0x06000385 RID: 901 RVA: 0x00046178 File Offset: 0x00044378
		public global::AcpCommonLib.IAcpRecordset EmbeddedRecset
		{
			get
			{
				short num = (short)1082654720;
				short num2 = num;
				num = (short)550680280;
				short num3 = num;
				num = (short)1771550424;
				switch (num3 == num)
				{
				}
				num = (short)151977985;
				if (num != 0)
				{
				}
				num = (short)1607139328;
				if (num != 0)
				{
				}
				return this.embeddedRecset;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (this.embeddedRecset != null)
						{
							num2 = (short)1316290561;
							if (num2 != 0)
							{
							}
							num2 = (short)987103234;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 1:
						return;
					case 2:
						goto IL_FD;
					}
					goto IL_1C;
				}
				IL_FD:
				goto IL_FF;
				IL_1C:
				this.embeddedRecset = (global::AcpBusinessLayer.Recordset)value;
				num2 = (short)891955225;
				short num3 = num2;
				num2 = (short)2082220057;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_FF:
					this.embeddedRecset.ParentSection = this;
					this.embeddedRecset.IsEmbeddedRecset = true;
					num2 = (short)1384644609;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				case 1:
					break;
				default:
				{
					num2 = (short)165019648;
					short num4 = num2;
					break;
				}
				}
				num2 = (short)1404370944;
				if (num2 != 0)
				{
				}
				num2 = (short)820248576;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x06000386 RID: 902 RVA: 0x000462B8 File Offset: 0x000444B8
		internal void CalculateValidityWithoutDependencies()
		{
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_28;
				}
				int num;
				short num2;
				global::System.Collections.Generic.Dictionary<string, global::AcpBusinessLayer.AcpFieldBase>.ValueCollection.Enumerator enumerator;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_213;
					case 1:
						try
						{
							num2 = (short)444203010;
							num = (int)((global::System.IntPtr)num2);
							for (;;)
							{
								switch (num)
								{
								case 0:
								{
									global::AcpBusinessLayer.AcpFieldBase acpFieldBase;
									if (acpFieldBase.ForceValid)
									{
										num2 = (short)1844445190;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									break;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_150;
									}
									continue;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num2 = (short)1806827524;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									global::AcpBusinessLayer.AcpFieldBase acpFieldBase = enumerator.Current;
									num2 = (short)892076032;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								case 4:
									num2 = (short)564068357;
									num = (int)((global::System.IntPtr)num2);
									continue;
								case 5:
									goto IL_200;
								case 6:
								{
									global::AcpBusinessLayer.AcpFieldBase acpFieldBase;
									acpFieldBase.ValidityHelper();
									num2 = (short)1433927681;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								}
								IL_1AD:
								num2 = (short)553451523;
								num = (int)((global::System.IntPtr)num2);
								continue;
								IL_150:
								goto IL_1AD;
							}
							IL_200:
							goto IL_327;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto Block_2;
					case 2:
					{
						num2 = (short)1399090862;
						short num3 = num2;
						num2 = (short)972385966;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
						{
							num2 = (short)2039414784;
							if (num2 != 0)
							{
							}
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = ((global::AcpBusinessLayer.Recordset)this.EmbeddedRecset).GetEnumerator();
							num2 = (short)433389568;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 3:
						if (this.HasEmbeddedRecset)
						{
							num2 = (short)1872166916;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 4:
					{
						num2 = (short)1688666112;
						short num4 = num2;
						num2 = (short)1827995653;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 5:
						if (this.EmbeddedRecset.Count > 0)
						{
							num2 = (short)1751777282;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
					IL_327:
					num2 = (short)280035329;
					if (num2 != 0)
					{
					}
					num2 = (short)1483538435;
					num = (int)((global::System.IntPtr)num2);
					continue;
					Block_2:
					try
					{
						IL_213:
						num2 = (short)1148321792;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_24C;
								}
								continue;
							case 1:
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
								if (!enumerator2.MoveNext())
								{
									num2 = (short)1410990084;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								enumerator2.Current.CalculateValidityWithoutDependencies();
								num2 = (short)2003828738;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							case 3:
								goto IL_2B9;
							case 4:
								num2 = (short)1178009603;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							IL_24E:
							num2 = (short)644415489;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_24C:
							goto IL_24E;
						}
						IL_2B9:
						return;
					}
					finally
					{
						num2 = (short)1477836800;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
							switch (num)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_2EE;
								}
								continue;
							case 1:
								goto IL_324;
							case 2:
								enumerator2.Dispose();
								num2 = (short)1185611777;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							IL_2EE:
							if (enumerator2 == null)
							{
								break;
							}
							num2 = (short)389939202;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_324:;
					}
					goto IL_327;
				}
				IL_28:
				enumerator = this.fieldsByUIName.Values.GetEnumerator();
				num2 = (short)1686372353;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00046698 File Offset: 0x00044898
		public global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpField> Search(string token)
		{
			short num = (short)1464991744;
			short num2 = num;
			num = (short)23051774;
			short num3 = num;
			num = (short)1383972350;
			switch (num3 == num)
			{
			}
			num = (short)1863712769;
			if (num != 0)
			{
			}
			num = (short)1807613952;
			if (num != 0)
			{
			}
			return this.a(token, false);
		}

		// Token: 0x06000388 RID: 904 RVA: 0x0004674C File Offset: 0x0004494C
		public global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpField> SearchAll(string token)
		{
			short num = (short)555876352;
			short num2 = num;
			num = (short)1401252686;
			short num3 = num;
			num = (short)681995086;
			switch (num3 == num)
			{
			}
			num = (short)911736833;
			if (num != 0)
			{
			}
			num = (short)655884288;
			if (num != 0)
			{
			}
			return this.a(token, true);
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00046800 File Offset: 0x00044A00
		private global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpField> a(string A_0, bool A_1)
		{
			short num = (short)892076032;
			short num2 = num;
			num = (short)980899350;
			short num3 = num;
			num = (short)856774166;
			switch (num3 == num)
			{
			}
			num = (short)876347392;
			if (num != 0)
			{
			}
			num = (short)235667457;
			if (num != 0)
			{
			}
			global::AcpBusinessLayer.FeatureSection.<SearchConditionally>d__67 <SearchConditionally>d__ = new global::AcpBusinessLayer.FeatureSection.<SearchConditionally>d__67(-2);
			<SearchConditionally>d__.<>4__this = this;
			<SearchConditionally>d__.<>3__token = A_0;
			<SearchConditionally>d__.<>3__searchHiddenStatic = A_1;
			return <SearchConditionally>d__;
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600038A RID: 906 RVA: 0x000468C8 File Offset: 0x00044AC8
		// (set) Token: 0x0600038B RID: 907 RVA: 0x0004698C File Offset: 0x00044B8C
		public string UIName
		{
			get
			{
				short num = (short)2063231539;
				short num2 = num;
				num = (short)1727556147;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_A7;
				case 1:
					break;
				default:
				{
					num = (short)410124288;
					short num3 = num;
					break;
				}
				}
				num = (short)1030291457;
				if (num != 0)
				{
				}
				num = (short)1262026752;
				if (num != 0)
				{
				}
				if (this.uiName != null)
				{
					return this.uiName;
				}
				IL_A7:
				return this.FeatureSectionName;
			}
			set
			{
				short num = (short)135659520;
				short num2 = num;
				num = (short)1799047735;
				short num3 = num;
				num = (short)1610959415;
				switch (num3 == num)
				{
				}
				num = (short)573177856;
				if (num != 0)
				{
				}
				num = (short)1291255809;
				if (num != 0)
				{
				}
				this.uiName = value;
			}
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00046A3C File Offset: 0x00044C3C
		public string Path(string delimiter)
		{
			short num = (short)1793723711;
			short num2 = num;
			num = (short)1048644927;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_A5;
			case 1:
				break;
			default:
			{
				num = (short)1735393280;
				short num3 = num;
				break;
			}
			}
			num = (short)613023745;
			if (num != 0)
			{
			}
			num = (short)486080512;
			if (num != 0)
			{
			}
			if (this.Parent == null)
			{
				return this.UIName;
			}
			IL_A5:
			return this.Parent.Path(delimiter) + delimiter + this.UIName;
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600038D RID: 909 RVA: 0x00046B10 File Offset: 0x00044D10
		// (set) Token: 0x0600038E RID: 910 RVA: 0x00046BC0 File Offset: 0x00044DC0
		public global::AcpCommonLib.IAcpField CurrentField
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)895287296;
				short num2 = num;
				num = (short)1774651358;
				short num3 = num;
				num = (short)299829214;
				switch (num3 == num)
				{
				}
				num = (short)56164353;
				if (num != 0)
				{
				}
				num = (short)738918400;
				if (num != 0)
				{
				}
				return this.<CurrentField>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			internal set
			{
				short num = (short)1533345793;
				if (num != 0)
				{
				}
				num = (short)837681152;
				short num2 = num;
				num = (short)787557140;
				short num3 = num;
				num = (short)1124543252;
				switch (num3 == num)
				{
				}
				num = (short)1183449088;
				if (num != 0)
				{
				}
				this.<CurrentField>k__BackingField = value;
			}
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00046C74 File Offset: 0x00044E74
		public void SetCurrentField(global::AcpCommonLib.IAcpField fieldName)
		{
			short num = (short)582551660;
			short num2 = num;
			num = (short)457967724;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1833762816;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1854996481;
			if (num != 0)
			{
			}
			num = (short)1688862720;
			if (num != 0)
			{
			}
			this.CurrentField = fieldName;
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00046D28 File Offset: 0x00044F28
		public void CallConstraints()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			short num2;
			global::System.Collections.Generic.Dictionary<string, global::AcpBusinessLayer.AcpFieldBase>.ValueCollection.Enumerator enumerator;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_1E0;
				case 1:
					if (this.HasEmbeddedRecset)
					{
						num2 = (short)46071808;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
				{
					num2 = (short)2134835201;
					if (num2 != 0)
					{
					}
					try
					{
						num2 = (short)1125974019;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 1:
								num2 = (short)1747582980;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								if (!enumerator.MoveNext())
								{
									num2 = (short)1290928129;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								((global::AcpCommonLib.IAcpConstraints)enumerator.Current).CallConstraints();
								num2 = (short)1036255232;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_159;
								}
								continue;
							case 4:
								goto IL_1CD;
							}
							IL_17E:
							num2 = (short)925892610;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_159:
							goto IL_17E;
						}
						IL_1CD:
						goto IL_B9;
					}
					finally
					{
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_1E0;
					IL_B9:
					num2 = (short)1154940928;
					short num3 = num2;
					num2 = (short)1447231489;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					return;
				}
				goto IL_20;
				IL_1E0:
				this.EmbeddedRecset.CallConstraints();
				num2 = (short)230621187;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_20:
			enumerator = this.fieldsByUIName.Values.GetEnumerator();
			num2 = (short)1398279297;
			short num4 = num2;
			num2 = (short)1717636225;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_0A;
			default:
			{
				num2 = (short)2020933632;
				if (num2 != 0)
				{
				}
				num2 = (short)1409417218;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00046F4C File Offset: 0x0004514C
		public void CalculateValidity()
		{
			short num = (short)1281687553;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_46;
			}
			global::System.Collections.Generic.Dictionary<string, global::AcpBusinessLayer.AcpFieldBase>.ValueCollection.Enumerator enumerator;
			for (;;)
			{
				IL_30:
				int num2;
				switch (num2)
				{
				case 0:
					goto IL_1DF;
				case 1:
					if (this.HasEmbeddedRecset)
					{
						num = (short)1294729216;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
				{
					try
					{
						num = (short)1406337027;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 1:
								num = (short)182910980;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								if (!enumerator.MoveNext())
								{
									num = (short)1125122049;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								((global::AcpCommonLib.IAcpConstraints)enumerator.Current).CalculateValidity();
								num = (short)1530462208;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_15D;
								}
								continue;
							case 4:
								goto IL_1CC;
							}
							IL_181:
							num = (short)968818690;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_15D:
							goto IL_181;
						}
						IL_1CC:
						goto IL_BC;
					}
					finally
					{
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_1DF;
					IL_BC:
					num = (short)933888000;
					short num3 = num;
					num = (short)58523649;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					return;
				}
				goto IL_46;
				IL_1DF:
				this.EmbeddedRecset.CalculateValidity();
				num = (short)1397227523;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_46:
			enumerator = this.fieldsByUIName.Values.GetEnumerator();
			num = (short)1480295946;
			short num4 = num;
			num = (short)520455690;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_30;
			default:
			{
				num = (short)466288640;
				if (num != 0)
				{
				}
				num = (short)6815746;
				int num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00047170 File Offset: 0x00045370
		public void CalculateApplicability()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			short num2;
			global::System.Collections.Generic.Dictionary<string, global::AcpBusinessLayer.AcpFieldBase>.ValueCollection.Enumerator enumerator;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_1E7;
				case 1:
				{
					num2 = (short)1147207680;
					short num3 = num2;
					num2 = (short)200146945;
					if (num2 != 0)
					{
					}
					if (this.HasEmbeddedRecset)
					{
						num2 = (short)475856896;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 2:
					try
					{
						num2 = (short)1857093635;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 1:
								num2 = (short)784400388;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								if (!enumerator.MoveNext())
								{
									num2 = (short)1392246785;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								((global::AcpCommonLib.IAcpConstraints)enumerator.Current).CalculateApplicability();
								num2 = (short)1939734528;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_162;
								}
								continue;
							case 4:
								goto IL_1D4;
							}
							IL_188:
							num2 = (short)1178796034;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_162:
							goto IL_188;
						}
						IL_1D4:
						goto IL_99;
					}
					finally
					{
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_1E7;
					IL_99:
					num2 = (short)2004877313;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					return;
				}
				goto IL_20;
				IL_1E7:
				this.EmbeddedRecset.CalculateApplicability();
				num2 = (short)120782851;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_20:
			enumerator = this.fieldsByUIName.Values.GetEnumerator();
			num2 = (short)1305752638;
			short num4 = num2;
			num2 = (short)781333566;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_0A;
			default:
			{
				num2 = (short)616955904;
				if (num2 != 0)
				{
				}
				num2 = (short)1416232962;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0004739C File Offset: 0x0004559C
		public void CalculateVisibility()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			short num2;
			global::System.Collections.Generic.Dictionary<string, global::AcpBusinessLayer.AcpFieldBase>.ValueCollection.Enumerator enumerator;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_1B8;
				case 1:
				{
					num2 = (short)1203044352;
					short num3 = num2;
					if (this.HasEmbeddedRecset)
					{
						num2 = (short)1329397760;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 2:
					try
					{
						num2 = (short)2131689475;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 1:
								num2 = (short)218103812;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								if (!enumerator.MoveNext())
								{
									num2 = (short)744751105;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								((global::AcpCommonLib.IAcpConstraints)enumerator.Current).CalculateVisibility();
								num2 = (short)1619460096;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_136;
								}
								continue;
							case 4:
								goto IL_1A5;
							}
							IL_15B:
							num2 = (short)913047554;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_136:
							goto IL_15B;
						}
						IL_1A5:
						goto IL_94;
					}
					finally
					{
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_1B8;
					IL_94:
					num2 = (short)193200129;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					return;
				}
				goto IL_20;
				IL_1B8:
				this.EmbeddedRecset.CalculateVisibility();
				num2 = (short)1272643585;
				if (num2 != 0)
				{
				}
				num2 = (short)8978435;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_20:
			enumerator = this.fieldsByUIName.Values.GetEnumerator();
			num2 = (short)1366260776;
			short num4 = num2;
			num2 = (short)931298344;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_0A;
			default:
			{
				num2 = (short)1935343616;
				if (num2 != 0)
				{
				}
				num2 = (short)1866203138;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000394 RID: 916 RVA: 0x000475C0 File Offset: 0x000457C0
		public void CalculateEditability()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			short num2;
			global::System.Collections.Generic.Dictionary<string, global::AcpBusinessLayer.AcpFieldBase>.ValueCollection.Enumerator enumerator;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_1E2;
				case 1:
					if (this.HasEmbeddedRecset)
					{
						num2 = (short)535363584;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
				{
					try
					{
						num2 = (short)1245380611;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 1:
								num2 = (short)1826226180;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								if (!enumerator.MoveNext())
								{
									num2 = (short)564592641;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								((global::AcpCommonLib.IAcpConstraints)enumerator.Current).CalculateEditability();
								num2 = (short)1545273344;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_15E;
								}
								continue;
							case 4:
								goto IL_1CF;
							}
							IL_182:
							num2 = (short)1481834498;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_15E:
							goto IL_182;
						}
						IL_1CF:
						goto IL_BC;
					}
					finally
					{
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_1E2;
					IL_BC:
					num2 = (short)205127680;
					short num3 = num2;
					num2 = (short)496500737;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					return;
				}
				goto IL_20;
				IL_1E2:
				this.EmbeddedRecset.CalculateEditability();
				num2 = (short)126681091;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_20:
			enumerator = this.fieldsByUIName.Values.GetEnumerator();
			num2 = (short)1606388399;
			short num4 = num2;
			num2 = (short)777423535;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_0A;
			default:
			{
				num2 = (short)1076756481;
				if (num2 != 0)
				{
				}
				num2 = (short)1101070336;
				if (num2 != 0)
				{
				}
				num2 = (short)1219690498;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000395 RID: 917 RVA: 0x000477E4 File Offset: 0x000459E4
		public void CalculateVisibility(bool allFields)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			short num2;
			global::System.Collections.Generic.Dictionary<string, global::AcpBusinessLayer.AcpFieldBase>.ValueCollection.Enumerator enumerator;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_1BA;
				case 1:
				{
					num2 = (short)1936523264;
					short num3 = num2;
					if (this.HasEmbeddedRecset)
					{
						num2 = (short)2057240576;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 2:
					try
					{
						num2 = (short)511246339;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 1:
								num2 = (short)1399521284;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								if (!enumerator.MoveNext())
								{
									num2 = (short)339083265;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								((global::AcpCommonLib.IAcpConstraints)enumerator.Current).CalculateVisibility();
								num2 = (short)248315904;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_137;
								}
								continue;
							case 4:
								goto IL_1A7;
							}
							IL_15B:
							num2 = (short)1568473090;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_137:
							goto IL_15B;
						}
						IL_1A7:
						goto IL_95;
					}
					finally
					{
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_1BA;
					IL_95:
					num2 = (short)1893662721;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					return;
				}
				goto IL_20;
				IL_1BA:
				num2 = (short)1790640129;
				if (num2 != 0)
				{
				}
				this.EmbeddedRecset.CalculateVisibility(allFields);
				num2 = (short)1086390275;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_20:
			enumerator = this.fieldsByUIName.Values.GetEnumerator();
			num2 = (short)2105218184;
			short num4 = num2;
			num2 = (short)1610552456;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_0A;
			default:
			{
				num2 = (short)43712512;
				if (num2 != 0)
				{
				}
				num2 = (short)310312962;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00047A0C File Offset: 0x00045C0C
		public void CalculateEditability(bool allFields)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			short num2;
			global::System.Collections.Generic.Dictionary<string, global::AcpBusinessLayer.AcpFieldBase>.ValueCollection.Enumerator enumerator;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_1E1;
				case 1:
					if (this.HasEmbeddedRecset)
					{
						num2 = (short)661716992;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
				{
					try
					{
						num2 = (short)1247477763;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 1:
								num2 = (short)2142306308;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								if (!enumerator.MoveNext())
								{
									num2 = (short)1559822337;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								((global::AcpCommonLib.IAcpConstraints)enumerator.Current).CalculateEditability();
								num2 = (short)1133314048;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_15D;
								}
								continue;
							case 4:
								goto IL_1CE;
							}
							IL_181:
							num2 = (short)1843396610;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_15D:
							goto IL_181;
						}
						IL_1CE:
						goto IL_BB;
					}
					finally
					{
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_1E1;
					IL_BB:
					num2 = (short)1880686592;
					short num3 = num2;
					num2 = (short)316997633;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					return;
				}
				goto IL_20;
				IL_1E1:
				this.EmbeddedRecset.CalculateEditability(allFields);
				num2 = (short)1954152451;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_20:
			enumerator = this.fieldsByUIName.Values.GetEnumerator();
			num2 = (short)1161281481;
			short num4 = num2;
			num2 = (short)760528841;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_0A;
			default:
			{
				num2 = (short)1339555841;
				if (num2 != 0)
				{
				}
				num2 = (short)399966208;
				if (num2 != 0)
				{
				}
				num2 = (short)687144962;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00047C30 File Offset: 0x00045E30
		private void a(object A_0, global::AcpBusinessLayer.DifferenceCountChangedEventArgs A_1)
		{
			int a_ = 15;
			switch (0)
			{
			case 0:
				goto IL_3D;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (this.DiffCount.Value == 0)
					{
						num2 = (short)2080047107;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					if (A_1.Action == global::AcpBusinessLayer.DifferenceCountChangedAction.Increment)
					{
						num2 = (short)1684799495;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_D6;
				case 2:
				{
					num2 = (short)1489091971;
					short num3 = num2;
					num2 = (short)1217838467;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)598081537;
						if (num2 != 0)
						{
						}
						num2 = (short)1063452672;
						if (num2 != 0)
						{
						}
						if (A_1.Action == global::AcpBusinessLayer.DifferenceCountChangedAction.Decrement)
						{
							num2 = (short)1044447236;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				case 3:
					((global::AcpBusinessLayer.FeatureNode)this.Parent).DiffCount.Decrement(this.FeatureSectionName);
					this.FirePropertyChanged(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("ꧠ苢雤ꏦ胨跪诬鳮", a_));
					num2 = (short)306249733;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					num2 = (short)89849856;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_20F;
				case 6:
					if (this.DiffCount.Value == 1)
					{
						num2 = (short)429654024;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_D6;
				case 7:
					num2 = (short)685703174;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					goto IL_1C6;
				}
				goto IL_3D;
				IL_D6:
				num2 = (short)1437401090;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_1C6:
			((global::AcpBusinessLayer.FeatureNode)this.Parent).DiffCount.Increment(this.FeatureSectionName);
			this.FirePropertyChanged(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("ꧠ苢雤ꏦ胨跪诬鳮", a_));
			return;
			IL_20F:
			num2 = (short)368967680;
			short num4 = num2;
			return;
			IL_3D:
			this.FirePropertyChanged(A_1.Name + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("뻠ꯢ蓤铦귨苪诬觮苰", a_));
			num2 = (short)616693761;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000398 RID: 920 RVA: 0x00047EA8 File Offset: 0x000460A8
		internal global::AcpBusinessLayer.DifferenceCount DiffCount
		{
			get
			{
				short num = (short)1703147300;
				short num2 = num;
				num = (short)261224228;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1230503936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)183304193;
				if (num != 0)
				{
				}
				num = (short)633208832;
				if (num != 0)
				{
				}
				return this.diffCount;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000399 RID: 921 RVA: 0x00047F58 File Offset: 0x00046158
		public bool _HasDiffs
		{
			get
			{
				short num = (short)494304643;
				short num2 = num;
				num = (short)1033993603;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2014380032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)990838785;
				if (num != 0)
				{
				}
				num = (short)124846080;
				if (num != 0)
				{
				}
				return this.DiffCount.Value > 0;
			}
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0004800C File Offset: 0x0004620C
		public void ClearHasDiffs()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			short num2;
			global::System.Collections.Generic.Dictionary<string, global::AcpBusinessLayer.AcpFieldBase>.ValueCollection.Enumerator enumerator;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_1E3;
				case 1:
					if (this.HasEmbeddedRecset)
					{
						num2 = (short)406257664;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_207;
				case 2:
				{
					try
					{
						num2 = (short)1839267843;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 1:
								num2 = (short)1002569732;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								if (!enumerator.MoveNext())
								{
									num2 = (short)1359806465;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								((global::AcpCommonLib.IAcpField)enumerator.Current)._HasDiffs = false;
								num2 = (short)439812096;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_135;
								}
								continue;
							case 4:
								goto IL_1A9;
							}
							IL_15C:
							num2 = (short)943849474;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_135:
							goto IL_15C;
						}
						IL_1A9:
						goto IL_94;
					}
					finally
					{
						num2 = (short)1178861569;
						if (num2 != 0)
						{
						}
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_1E3;
					IL_94:
					num2 = (short)422838272;
					short num3 = num2;
					num2 = (short)348585985;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					goto IL_205;
				}
				goto IL_20;
				IL_1E3:
				this.EmbeddedRecset.ClearHasDiffs();
				num2 = (short)233832451;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_205:
			IL_207:
			this.DiffCount.Reset(this.FeatureSectionName);
			return;
			IL_20:
			enumerator = this.fieldsByUIName.Values.GetEnumerator();
			num2 = (short)938635277;
			short num4 = num2;
			num2 = (short)736718861;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_0A;
			default:
			{
				num2 = (short)1992687616;
				if (num2 != 0)
				{
				}
				num2 = (short)1233846274;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600039B RID: 923 RVA: 0x00048244 File Offset: 0x00046444
		public bool HasVisibleObjects
		{
			get
			{
				short num2;
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_24;
					}
					int num;
					global::System.Collections.Generic.Dictionary<string, global::AcpBusinessLayer.AcpFieldBase>.ValueCollection.Enumerator enumerator;
					for (;;)
					{
						IL_0A:
						switch (num)
						{
						case 0:
						{
							if (!this.HasEmbeddedRecset)
							{
								return false;
							}
							num2 = (short)109328782;
							short num3 = num2;
							num2 = (short)1300052366;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num2 = (short)2132213760;
								if (num2 != 0)
								{
								}
								num2 = (short)1781399554;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							break;
						}
						case 1:
							if (this.EmbeddedRecset.HasVisibleObjects)
							{
								num2 = (short)1983709188;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							return false;
						case 2:
							num2 = (short)857145345;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 3:
						{
							try
							{
								num2 = (short)1205469186;
								num = (int)((global::System.IntPtr)num2);
								bool result;
								for (;;)
								{
									switch (num)
									{
									case 0:
										num2 = (short)231604227;
										num = (int)((global::System.IntPtr)num2);
										continue;
									case 1:
										goto IL_1B6;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_16A;
										}
										continue;
									case 3:
										goto IL_211;
									case 4:
										if (!enumerator.Current.HiddenStatic)
										{
											num2 = (short)1432813574;
											num = (int)((global::System.IntPtr)num2);
											continue;
										}
										break;
									case 5:
										if (!enumerator.MoveNext())
										{
											num2 = (short)482082816;
											num = (int)((global::System.IntPtr)num2);
											continue;
										}
										num2 = (short)1652621316;
										num = (int)((global::System.IntPtr)num2);
										continue;
									case 6:
										result = true;
										num2 = (short)830996481;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									IL_16C:
									num2 = (short)821428229;
									num = (int)((global::System.IntPtr)num2);
									continue;
									IL_16A:
									goto IL_16C;
								}
								IL_1B6:
								return result;
								IL_211:
								goto IL_77;
							}
							finally
							{
								((global::System.IDisposable)enumerator).Dispose();
							}
							return false;
							IL_77:
							num2 = (short)187957248;
							short num4 = num2;
							num2 = (short)1953955840;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						case 4:
							goto IL_263;
						}
						break;
					}
					IL_24:
					enumerator = this.fieldsByUIName.Values.GetEnumerator();
					num2 = (short)747700227;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				return false;
				IL_263:
				num2 = (short)2063204353;
				if (num2 != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600039C RID: 924 RVA: 0x000484CC File Offset: 0x000466CC
		// (set) Token: 0x0600039D RID: 925 RVA: 0x0004857C File Offset: 0x0004677C
		public int DataTransferOrder
		{
			get
			{
				short num = (short)669354914;
				short num2 = num;
				num = (short)1847364514;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1330053120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2022244353;
				if (num != 0)
				{
				}
				num = (short)789839872;
				if (num != 0)
				{
				}
				return this.dataXferOrder;
			}
			set
			{
				short num = (short)935591280;
				short num2 = num;
				num = (short)422509936;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1773862912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1561001985;
				if (num != 0)
				{
				}
				num = (short)449249280;
				if (num != 0)
				{
				}
				this.dataXferOrder = value;
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600039E RID: 926 RVA: 0x0004862C File Offset: 0x0004682C
		// (remove) Token: 0x0600039F RID: 927 RVA: 0x00048760 File Offset: 0x00046960
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				for (;;)
				{
					short num = (short)1485570048;
					short num2 = num;
					switch (0)
					{
					case 0:
						goto IL_47;
					}
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
					for (;;)
					{
						IL_35:
						int num3;
						global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
						switch (num3)
						{
						case 0:
							if (propertyChangedEventHandler == propertyChangedEventHandler2)
							{
								num = (short)965607426;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_AD;
						case 1:
							goto IL_AD;
						case 2:
							return;
						}
						break;
						IL_AD:
						num = (short)977731585;
						if (num != 0)
						{
						}
						propertyChangedEventHandler2 = propertyChangedEventHandler;
						global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Combine(propertyChangedEventHandler2, value);
						propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
						num = (short)1861484544;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_47:
					propertyChangedEventHandler = this.PropertyChanged;
					num = (short)1158873084;
					short num4 = num;
					num = (short)1244266492;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)926941184;
						if (num != 0)
						{
						}
						num = (short)1523253249;
						int num3 = (int)((global::System.IntPtr)num);
						goto IL_35;
					}
					}
				}
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				for (;;)
				{
					short num = (short)676462592;
					short num2 = num;
					switch (0)
					{
					case 0:
						goto IL_47;
					}
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
					for (;;)
					{
						IL_35:
						int num3;
						global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
						switch (num3)
						{
						case 0:
							if (propertyChangedEventHandler == propertyChangedEventHandler2)
							{
								num = (short)241238018;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_DC;
						case 1:
							goto IL_DC;
						case 2:
							return;
						}
						break;
						IL_DC:
						propertyChangedEventHandler2 = propertyChangedEventHandler;
						global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Remove(propertyChangedEventHandler2, value);
						propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
						num = (short)131203072;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_47:
					propertyChangedEventHandler = this.PropertyChanged;
					num = (short)1566214641;
					short num4 = num;
					num = (short)1074825713;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1315766273;
						if (num != 0)
						{
						}
						num = (short)1496317952;
						if (num != 0)
						{
						}
						num = (short)456916993;
						int num3 = (int)((global::System.IntPtr)num);
						goto IL_35;
					}
					}
				}
			}
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0004889C File Offset: 0x00046A9C
		public virtual void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 8;
			short num = (short)1793851392;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_58;
				}
				for (;;)
				{
					IL_31:
					global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator;
					global::System.Collections.Generic.Dictionary<string, global::AcpBusinessLayer.AcpFieldBase>.Enumerator enumerator2;
					int num3;
					switch (num2)
					{
					case 0:
						enumerator = this.FieldsCollection.GetEnumerator();
						num = (short)858324996;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_5F1;
					case 2:
						enumerator2 = this.fieldsByName.GetEnumerator();
						num = (short)311951361;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (this.HasListItemsToSerialize)
						{
							num = (short)1582497792;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_72E;
					case 4:
						goto IL_296;
					case 5:
						if (global::AcpCommonLib.AppInfoManager.DndOperation)
						{
							num = (short)340328450;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BDF;
					case 6:
						try
						{
							num = (short)2013462542;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.KeyValuePair<string, global::AcpBusinessLayer.AcpFieldBase> keyValuePair;
								switch (num2)
								{
								case 1:
									if (keyValuePair.Value.UIInvalid)
									{
										num = (short)962330640;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)692191234;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									if (keyValuePair.Value is global::AcpBusinessLayer.AcpRecRefField)
									{
										num = (short)528875531;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									info.AddValue(keyValuePair.Key, keyValuePair.Value.ValueString);
									num = (short)774570001;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_9B1;
								case 4:
									num = (short)436469778;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									if (((global::AcpBusinessLayer.AcpRecRefField)keyValuePair.Value).IsExactPrepend)
									{
										num = (short)773259277;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									info.AddValue(keyValuePair.Key, keyValuePair.Value.ToString());
									num = (short)2102591498;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_BCC;
								case 7:
									goto IL_9B1;
								case 8:
									goto IL_9B1;
								case 9:
									num = (short)188612614;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									goto IL_9B1;
								case 11:
									num = (short)76414981;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									((global::AcpBusinessLayer.AcpRecRefField)keyValuePair.Value).UpdateValue();
									info.AddValue(keyValuePair.Key, ((global::AcpBusinessLayer.AcpRecRefField)keyValuePair.Value).Value);
									num = (short)1145044999;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									info.AddValue(keyValuePair.Key + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("藙뗛귝ꗟ髡藣藥鳧뫩黫语胯韱髳鋵", a_), ((global::AcpBusinessLayer.AcpRecRefField)keyValuePair.Value).IsExactPrepend);
									info.AddValue(keyValuePair.Key, keyValuePair.Value.ValueString);
									num = (short)2090401795;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									switch (0)
									{
									case 0:
										goto IL_86A;
									}
									continue;
								case 15:
									if (!global::AcpCommonLib.AppInfoManager.DndOperation)
									{
										num = (short)803799044;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_969;
								case 16:
									info.AddValue(keyValuePair.Key, keyValuePair.Value.ToString());
									num = (short)1086717960;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 17:
									goto IL_9B1;
								case 18:
									if (keyValuePair.Value is global::AcpBusinessLayer.AcpRecRefField)
									{
										num = (short)1254948876;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_969;
								case 19:
									if (!enumerator2.MoveNext())
									{
										num = (short)467337225;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									keyValuePair = enumerator2.Current;
									num = (short)1789067279;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_86A;
								IL_969:
								num = (short)759365633;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_9B1:
								info.AddValue(keyValuePair.Key + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("藙뫛닝臟藡", a_), keyValuePair.Value.GetFlags());
								num = (short)110493696;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_A8D:
								num = (short)694288403;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_86A:
								goto IL_A8D;
							}
							IL_BCC:
							goto IL_103;
						}
						finally
						{
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto IL_BDF;
						IL_103:
						num = (short)1972961285;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						try
						{
							num = (short)1791098881;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_225;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_17D;
									}
									continue;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1374814212;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.AcpFieldBase acpFieldBase = (global::AcpBusinessLayer.AcpFieldBase)enumerator.Current;
									info.AddValue(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("鳙뗛믝賟蛡ꫣ蟥藧迩", a_) + num3.ToString(), acpFieldBase.Name);
									num3++;
									num = (short)112984066;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)296878080;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1D0:
								num = (short)1674510339;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_17D:
								goto IL_1D0;
							}
							IL_225:
							goto IL_BDF;
						}
						finally
						{
							num = (short)967376896;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_25D;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1633288194;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_293;
								}
								IL_25D:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1274281985;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_293:;
						}
						goto Block_4;
					}
					goto IL_58;
					IL_72E:
					enumerator2 = this.fieldsByName.GetEnumerator();
					num = (short)386727942;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_5:
					try
					{
						IL_5F1:
						num = (short)293011457;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_71E;
							case 1:
								goto IL_607;
							case 2:
							{
								num = (short)195335841;
								short num4 = num;
								num = (short)872060577;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_607;
								default:
									num = (short)1878458368;
									if (num != 0)
									{
									}
									break;
								}
								break;
							}
							case 3:
							{
								if (!enumerator2.MoveNext())
								{
									num = (short)715128836;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Collections.Generic.KeyValuePair<string, global::AcpBusinessLayer.AcpFieldBase> keyValuePair2 = enumerator2.Current;
								info.AddValue(keyValuePair2.Key + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("藙铛럝蓟蛡臣裥믧黩跫髭駯釱", a_), keyValuePair2.Value.HiddenStatic);
								num = (short)597295106;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								num = (short)739115008;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_62C;
							IL_607:
							switch (0)
							{
							case 0:
								IL_62C:
								goto IL_6C7;
							}
							continue;
							IL_6C7:
							num = (short)1302724611;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_71E:
						goto IL_758;
					}
					finally
					{
						((global::System.IDisposable)enumerator2).Dispose();
					}
					goto IL_72E;
					IL_758:
					info.AddValue(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("鳙뗛믝賟蛡꟣觥鷧蓩飫", a_), this.FieldsCount);
					num3 = 0;
					enumerator = this.FieldsCollection.GetEnumerator();
					num = (short)1649737735;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_4:
					try
					{
						IL_296:
						num = (short)745144330;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							int num5;
							switch (num2)
							{
							case 0:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1501888519;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpBusinessLayer.AcpSparseLOVField acpSparseLOVField = enumerator.Current as global::AcpBusinessLayer.AcpSparseLOVField;
								num = (short)2073427983;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								num = (short)1440546824;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								goto IL_37D;
							case 4:
							{
								int count;
								if (num5 >= count)
								{
									num = (short)947781634;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpBusinessLayer.AcpSparseLOVField acpSparseLOVField;
								string text = acpSparseLOVField.Name + num5.ToString();
								num = (short)97255436;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
								goto IL_581;
							case 6:
								goto IL_342;
							case 7:
								num = (short)108068869;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
							{
								global::AcpBusinessLayer.AcpSparseLOVField acpSparseLOVField;
								if (acpSparseLOVField.SerializeItems)
								{
									num = (short)1063583758;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 9:
							{
								global::AcpBusinessLayer.AcpSparseLOVField acpSparseLOVField;
								int count = acpSparseLOVField.Items.Count;
								info.AddValue(acpSparseLOVField.Name + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("藙鿛뇝闟賡郣", a_), count);
								num5 = 0;
								num = (short)1481703430;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 10:
								switch (0)
								{
								case 0:
									goto IL_2FE;
								}
								continue;
							case 11:
							{
								global::AcpBusinessLayer.AcpSparseLOVField acpSparseLOVField;
								if (acpSparseLOVField.Items != null)
								{
									num = (short)1982922761;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 12:
							{
								global::AcpBusinessLayer.AcpSparseLOVField acpSparseLOVField;
								int value;
								try
								{
									value = (int)acpSparseLOVField.Converter.ConvertBack(acpSparseLOVField.Items[num5].ItemName, null, acpSparseLOVField.ConverterParameterObject, null);
								}
								catch
								{
									goto IL_37D;
								}
								string text;
								info.AddValue(text, value);
								info.AddValue(text + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("藙闛ꫝ藟迡닣迥鯧菩軫蟭鳯鯱胳迵", a_), acpSparseLOVField.Items[num5].ItemVisibility);
								num = (short)572719107;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 13:
								goto IL_342;
							case 14:
								num = (short)309329931;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 15:
							{
								global::AcpBusinessLayer.AcpSparseLOVField acpSparseLOVField;
								if (acpSparseLOVField != null)
								{
									num = (short)123731969;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							}
							goto IL_2FE;
							IL_342:
							num = (short)361365508;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_37D:
							num5++;
							num = (short)1852964877;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_4A1:
							num = (short)1515847680;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_2FE:
							goto IL_4A1;
						}
						IL_581:
						goto IL_72E;
					}
					finally
					{
						num = (short)1373962240;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_5B8;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)1861287938;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_5EE;
							}
							IL_5B8:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1462304769;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_5EE:;
					}
					goto Block_5;
				}
				IL_BDF:
				num = (short)118882304;
				short num6 = num;
				num = (short)481034241;
				if (num != 0)
				{
				}
				return;
				IL_58:
				info.AddValue(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("鳙맛뿝铟韡難菥믧迩迫髭駯鷱髳룵駷韹駻", a_), this.FeatureSectionName);
				info.AddValue(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("这闛郝臟迡臣", a_), this.UIName);
				info.AddValue(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("鿙뇛볝藟蛡胣菥賧룩觫跭華韱胳", a_), this.embeddedRecset);
				info.AddValue(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("鋙뷛귝곟诡韣鋥ꇧ黩觫菭華꛱鯳ꗵ鷷裹闻鿽泿欁縃挅", a_), this.HasListItemsToSerialize);
				num = (short)1990459395;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00049554 File Offset: 0x00047754
		protected FeatureSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 5;
			this..ctor();
			bool flag = false;
			if (!string.IsNullOrEmpty(global::AcpCommonLib.Document.CodePlugVersionNumber))
			{
				flag = (int.Parse(global::AcpCommonLib.Document.CodePlugVersionNumber.Substring(1, 2)) >= global::AcpCommonLib.AppInfoManager.LOCALIZED_VERSION_NUMBER);
			}
			if (global::AcpCommonLib.AppInfoManager.DndOperation && global::AcpCommonLib.AppInfoManager.ProducerVersion >= global::AcpCommonLib.AppInfoManager.LOCALIZED_VERSION_NUMBER)
			{
				flag = true;
			}
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("뻖럘뷚닜", a_));
			}
			this.FeatureSectionName = info.GetString(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("釖볘뫚꧜꫞鏠蛢뛤苦諨鿪蓬胮鿰뷲铴髶鳸", a_));
			try
			{
				this.EmbeddedRecset = (global::AcpBusinessLayer.Recordset)info.GetValue(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("鋖듘맚룜믞藠蛢臤뗦賨裪黬諮藰", a_), typeof(global::AcpBusinessLayer.Recordset));
				goto IL_1F3;
			}
			catch (global::System.Exception)
			{
				goto IL_1F3;
			}
			IL_1CC:
			if (!global::AcpCommonLib.AppInfoManager.DndOperation)
			{
				global::AcpCommonLib.AppInfoManager.IsOldCodeplug = false;
				this.a(info, this.fieldsByName);
				return;
			}
			if (global::AcpCommonLib.AppInfoManager.ProducerVersion < global::AcpCommonLib.AppInfoManager.LOCALIZED_VERSION_NUMBER)
			{
				global::AcpCommonLib.AppInfoManager.IsOldCodeplug = true;
				this.a(info, this.fieldsByUIName);
				return;
			}
			global::AcpCommonLib.AppInfoManager.IsOldCodeplug = false;
			this.a(info, this.fieldsByName);
			return;
			IL_1F3:
			this.HasListItemsToSerialize = info.GetBoolean(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("鿖룘꣚釜뛞鋠韢곤鏦賨蛪黬믮黰ꃲ郴藶郸髺釼雾笀昂", a_));
			if (global::AcpCommonLib.AppInfoManager.DndOperation)
			{
				global::System.Collections.Generic.List<string> list = null;
				try
				{
					int @int = info.GetInt32(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("釖냘뻚뇜믞ꋠ賢郤触鷨", a_));
					if (list == null)
					{
						list = new global::System.Collections.Generic.List<string>();
					}
					for (int i = 0; i < @int; i++)
					{
						list.Add(info.GetString(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("釖냘뻚뇜믞꿠苢裤苦", a_) + i.ToString()));
					}
					this.Init(list);
					if (list != null)
					{
						list.Clear();
					}
					goto IL_219;
				}
				catch (global::System.Exception)
				{
					this.Init();
					goto IL_219;
				}
				goto IL_2B2;
			}
			IL_D8:
			this.Init();
			IL_219:
			if (this.HasListItemsToSerialize)
			{
				using (global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator = this.FieldsCollection.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						global::AcpCommonLib.IAcpField acpField = enumerator.Current;
						global::AcpBusinessLayer.AcpSparseLOVField acpSparseLOVField = acpField as global::AcpBusinessLayer.AcpSparseLOVField;
						if (acpSparseLOVField != null && acpSparseLOVField.SerializeItems && acpSparseLOVField.Items != null)
						{
							acpSparseLOVField.Items.Clear();
							try
							{
								if (flag)
								{
									if (global::AcpCommonLib.AppInfoManager.DndOperation)
									{
										if (global::AcpCommonLib.AppInfoManager.ProducerVersion < global::AcpCommonLib.AppInfoManager.LOCALIZED_VERSION_NUMBER)
										{
											this.a(info, acpSparseLOVField);
										}
										else
										{
											this.b(info, acpSparseLOVField);
										}
									}
									else
									{
										this.b(info, acpSparseLOVField);
									}
								}
								else
								{
									this.a(info, acpSparseLOVField);
								}
							}
							catch (global::System.Runtime.Serialization.SerializationException)
							{
							}
							catch (global::System.FormatException)
							{
							}
						}
					}
					goto IL_2B2;
				}
				goto IL_D8;
			}
			IL_2B2:
			if (flag)
			{
				goto IL_1CC;
			}
			global::AcpCommonLib.AppInfoManager.IsOldCodeplug = true;
			this.a(info, this.fieldsByUIName);
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x00049870 File Offset: 0x00047A70
		private void b(global::System.Runtime.Serialization.SerializationInfo A_0, global::AcpBusinessLayer.AcpSparseLOVField A_1)
		{
			int a_ = 8;
			switch (0)
			{
			case 0:
				goto IL_2D;
			}
			int num;
			int num2;
			short num3;
			int @int;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					return;
				case 1:
					goto IL_E9;
				case 2:
					goto IL_E9;
				case 3:
					try
					{
						string text;
						A_1[num2].ItemVisibility = A_0.GetBoolean(text + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("藙闛ꫝ藟迡닣迥鯧菩軫蟭鳯鯱胳迵", a_));
						goto IL_8E;
					}
					catch (global::System.Runtime.Serialization.SerializationException)
					{
						goto IL_8E;
					}
					return;
					IL_8E:
					num2++;
					num3 = (short)1883963394;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 4:
				{
					num3 = (short)1915336441;
					short num4 = num3;
					num3 = (short)1095087865;
					switch ((num4 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
					{
						num3 = (short)1909194752;
						if (num3 != 0)
						{
						}
						num3 = (short)362348545;
						if (num3 != 0)
						{
						}
						if (num2 >= @int)
						{
							num3 = (short)1110114304;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						string text = A_1.Name + num2.ToString();
						A_1.AddValue(A_0.GetInt32(text));
						num3 = (short)1988820995;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					}
					break;
				}
				}
				goto IL_2D;
				IL_E9:
				num3 = (short)1227096068;
				num = (int)((global::System.IntPtr)num3);
			}
			return;
			IL_2D:
			@int = A_0.GetInt32(A_1.Name + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("藙鿛뇝闟賡郣", a_));
			num2 = 0;
			num3 = (short)1188757504;
			short num5 = num3;
			num3 = (short)1490616321;
			num = (int)((global::System.IntPtr)num3);
			goto IL_13;
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00049A54 File Offset: 0x00047C54
		private void a(global::System.Runtime.Serialization.SerializationInfo A_0, global::AcpBusinessLayer.AcpSparseLOVField A_1)
		{
			int a_ = 11;
			switch (0)
			{
			case 0:
				goto IL_2D;
			}
			int num;
			short num2;
			int num3;
			int @int;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					return;
				case 1:
					try
					{
						num2 = (short)553910273;
						if (num2 != 0)
						{
						}
						string text;
						A_1[num3].ItemVisibility = A_0.GetBoolean(text + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("苜雞闠蛢裤뇦胨飪蓬跮飰鿲鳴菶胸", a_));
						goto IL_8D;
					}
					catch (global::System.Runtime.Serialization.SerializationException)
					{
						goto IL_8D;
					}
					return;
					IL_8D:
					num3++;
					num2 = (short)1895890947;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)885617284;
					short num4 = num2;
					num2 = (short)1831498372;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
					{
						num2 = (short)105709568;
						if (num2 != 0)
						{
						}
						if (num3 >= @int)
						{
							num2 = (short)188481536;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						string text = A_1.UIName + num3.ToString();
						A_1.AddItemHelper(A_0.GetString(text));
						num2 = (short)256311297;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 3:
					goto IL_E9;
				case 4:
					goto IL_E9;
				}
				goto IL_2D;
				IL_E9:
				num2 = (short)1249509378;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_2D:
			@int = A_0.GetInt32(A_1.UIName + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("苜鳞軠離诤鏦", a_));
			num3 = 0;
			num2 = (short)994508800;
			short num5 = num2;
			num2 = (short)2083323908;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00049C38 File Offset: 0x00047E38
		private void a(global::System.Runtime.Serialization.SerializationInfo A_0, global::System.Collections.Generic.Dictionary<string, global::AcpBusinessLayer.AcpFieldBase> A_1)
		{
			int a_ = 0;
			short num = (short)1750007808;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_47;
				}
				global::System.Collections.Generic.Dictionary<string, global::AcpBusinessLayer.AcpFieldBase>.Enumerator enumerator2;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						goto IL_D22;
					case 1:
						if (global::AcpCommonLib.AppInfoManager.DndOperation)
						{
							num = (short)129695744;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D47;
					case 2:
						try
						{
							num = (short)668401668;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_31F;
								case 1:
									goto IL_307;
								case 2:
									try
									{
										global::System.Collections.Generic.KeyValuePair<string, global::AcpBusinessLayer.AcpFieldBase> keyValuePair;
										keyValuePair.Value.HiddenStatic = A_0.GetBoolean(keyValuePair.Key + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("跑鳓뿕볗뻙맛냝돟雡藣鋥臧觩", a_));
										goto IL_F4;
									}
									catch (global::System.Runtime.Serialization.SerializationException)
									{
										global::System.Collections.Generic.KeyValuePair<string, global::AcpBusinessLayer.AcpFieldBase> keyValuePair;
										keyValuePair.Value.HiddenStatic = true;
										global::System.Collections.Generic.IEnumerator<string> enumerator = global::AcpCommonLib.AppInfoManager.GetLegacyUINames(keyValuePair.Value.Name).GetEnumerator();
										try
										{
											num = (short)1701183492;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num2)
												{
												case 0:
													goto IL_28C;
												case 1:
												{
													if (!enumerator.MoveNext())
													{
														num = (short)635895810;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													string str = enumerator.Current;
													num = (short)796393475;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 2:
													goto IL_274;
												case 3:
													try
													{
														string str;
														keyValuePair.Value.HiddenStatic = A_0.GetBoolean(str + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("跑鳓뿕볗뻙맛냝돟雡藣鋥臧觩", a_));
														goto IL_274;
													}
													catch (global::System.Runtime.Serialization.SerializationException)
													{
													}
													break;
												case 4:
													switch (0)
													{
													case 0:
														goto IL_1ED;
													}
													continue;
												}
												IL_23B:
												num = (short)997982209;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_1ED:
												goto IL_23B;
												IL_274:
												num = (short)820576256;
												num2 = (int)((global::System.IntPtr)num);
											}
											IL_28C:;
										}
										finally
										{
											num = (short)1053622274;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num2)
												{
												case 0:
													enumerator.Dispose();
													num = (short)1818230785;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 1:
													goto IL_2F9;
												case 2:
													switch (0)
													{
													case 0:
														goto IL_2C1;
													}
													continue;
												}
												IL_2C1:
												if (enumerator == null)
												{
													break;
												}
												num = (short)1369047040;
												num2 = (int)((global::System.IntPtr)num);
											}
											IL_2F9:;
										}
										goto IL_F4;
									}
									catch (global::System.FormatException)
									{
										goto IL_F4;
									}
									goto IL_307;
								case 3:
								{
									if (!enumerator2.MoveNext())
									{
										goto IL_118;
									}
									global::System.Collections.Generic.KeyValuePair<string, global::AcpBusinessLayer.AcpFieldBase> keyValuePair = enumerator2.Current;
									num = (short)781058050;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_A2;
									}
									continue;
								}
								goto IL_A2;
								IL_F4:
								num = (short)840368131;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_A2:
								num = (short)96993430;
								short num3 = num;
								num = (short)1899626646;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									IL_118:
									num = (short)556531713;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								default:
									num = (short)2052456448;
									if (num != 0)
									{
									}
									goto IL_F4;
								}
								IL_307:
								num = (short)1531445248;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_31F:
							goto IL_D47;
						}
						finally
						{
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto IL_332;
					case 3:
						try
						{
							num = (short)397082628;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.KeyValuePair<string, global::AcpBusinessLayer.AcpFieldBase> keyValuePair2;
								switch (num2)
								{
								case 0:
									goto IL_D0F;
								case 1:
									num = (short)1291845632;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									try
									{
										switch (0)
										{
										case 0:
											goto IL_4B7;
										}
										string text;
										int? intValueNoThrow2;
										int? num7;
										for (;;)
										{
											IL_420:
											int? num5;
											int? num6;
											string stringValueNoThrow;
											bool flag2;
											bool? flag3;
											string stringValueNoThrow2;
											bool? flag4;
											bool? flag5;
											switch (num2)
											{
											case 0:
												goto IL_CC6;
											case 1:
											{
												int? num4 = null;
												num = (short)2086862877;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 2:
											{
												bool? flag;
												if (flag == null)
												{
													num = (short)218103839;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												num = (short)1844707337;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 3:
												if (num5 == null)
												{
													num = (short)491978753;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												num = (short)1087569926;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 4:
												num = (short)1990524952;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 5:
											{
												int? intValueNoThrow = A_0.GetIntValueNoThrow(text);
												num = (short)1077673997;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 6:
												num6 = new int?(num5.GetValueOrDefault() & 32768);
												goto IL_B81;
											case 7:
												try
												{
													num = (short)1982595078;
													num2 = (int)((global::System.IntPtr)num);
													for (;;)
													{
														switch (num2)
														{
														case 0:
														{
															global::System.Collections.Generic.IEnumerator<string> enumerator;
															if (!enumerator.MoveNext())
															{
																num = (short)545652737;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															text = enumerator.Current;
															intValueNoThrow2 = A_0.GetIntValueNoThrow(text + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("跑닓뫕맗뷙", a_));
															num = (short)656998404;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														case 1:
															num = (short)164233218;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 2:
															goto IL_857;
														case 3:
															num7 = intValueNoThrow2;
															num = (short)1458110469;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 4:
															if (intValueNoThrow2 != null)
															{
																num = (short)791478275;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															break;
														case 6:
															switch (0)
															{
															case 0:
																goto IL_78B;
															}
															continue;
														}
														IL_804:
														num = (short)1481244672;
														num2 = (int)((global::System.IntPtr)num);
														continue;
														IL_78B:
														goto IL_804;
													}
													IL_857:
													goto IL_AB8;
												}
												finally
												{
													num = (short)1023803394;
													num2 = (int)((global::System.IntPtr)num);
													for (;;)
													{
														global::System.Collections.Generic.IEnumerator<string> enumerator;
														switch (num2)
														{
														case 0:
															enumerator.Dispose();
															num = (short)739442689;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 1:
															goto IL_8C7;
														case 2:
															switch (0)
															{
															case 0:
																goto IL_88E;
															}
															continue;
														}
														IL_88E:
														if (enumerator == null)
														{
															break;
														}
														num = (short)571539456;
														num2 = (int)((global::System.IntPtr)num);
													}
													IL_8C7:;
												}
												goto IL_8CA;
											case 8:
												keyValuePair2.Value.ParseValueFrom(stringValueNoThrow);
												this.a(keyValuePair2.Value, num7, flag2);
												num = (short)1710817310;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 9:
											{
												bool? flag;
												flag3 = new bool?(!flag.GetValueOrDefault());
												goto IL_907;
											}
											case 10:
												if (keyValuePair2.Value is global::AcpBusinessLayer.AcpRecRefField)
												{
													num = (short)2043084832;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_9CC;
											case 11:
												goto IL_CAD;
											case 12:
												if (stringValueNoThrow2 != null)
												{
													num = (short)89325583;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_CAD;
											case 13:
											{
												int? intValueNoThrow;
												if (intValueNoThrow != null)
												{
													num = (short)460652562;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_CAD;
											}
											case 14:
												if (stringValueNoThrow != null)
												{
													num = (short)2083717128;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_CAD;
											case 15:
												goto IL_8CA;
											case 16:
												goto IL_C28;
											case 17:
												num = (short)446824481;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 18:
											{
												int? intValueNoThrow;
												((global::AcpBusinessLayer.AcpRecRefField)keyValuePair2.Value).DefaultValue = intValueNoThrow.Value;
												((global::AcpBusinessLayer.AcpRecRefField)keyValuePair2.Value).ResetToDefaultNoConstraints();
												this.a(keyValuePair2.Value, num7, flag2);
												num = (short)969408523;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 19:
												goto IL_AB8;
											case 20:
												if (flag4.Value)
												{
													num = (short)53870608;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_AFC;
											case 21:
												if (!flag2)
												{
													num = (short)1957036060;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_C28;
											case 22:
											{
												if (intValueNoThrow2 != null)
												{
													num = (short)194052131;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::System.Collections.Generic.IEnumerator<string> enumerator = global::AcpCommonLib.AppInfoManager.GetLegacyUINames(keyValuePair2.Value.Name).GetEnumerator();
												num = (short)1367867399;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 23:
												if (!global::AcpCommonLib.AppInfoManager.DndOperation)
												{
													num = (short)732954628;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_B44;
											case 24:
												if (keyValuePair2.Value is global::AcpBusinessLayer.AcpRecRefField)
												{
													num = (short)450035717;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_B44;
											case 25:
												flag3 = flag4;
												goto IL_907;
											case 26:
												if (!global::AcpCommonLib.AppInfoManager.IsOldCodeplug)
												{
													num = (short)569573393;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_C28;
											case 27:
											{
												bool? flag = flag5;
												num = (short)2019885058;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 28:
												num = (short)20185114;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 29:
											{
												int? num4;
												num6 = num4;
												goto IL_B81;
											}
											case 30:
												goto IL_CAD;
											case 31:
												flag4 = null;
												num = (short)2005794841;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 32:
												try
												{
													switch (0)
													{
													case 0:
														goto IL_63A;
													}
													bool? boolValueNoThrow;
													for (;;)
													{
														IL_61F:
														switch (num2)
														{
														case 0:
															goto IL_6E6;
														case 1:
															goto IL_6CC;
														case 2:
															goto IL_6CC;
														case 3:
															flag5 = boolValueNoThrow;
															num = (short)808452097;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 4:
															if (boolValueNoThrow != null)
															{
																num = (short)297336835;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															flag5 = new bool?(false);
															num = (short)1720320002;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														goto IL_63A;
														IL_6CC:
														num = (short)2086666240;
														num2 = (int)((global::System.IntPtr)num);
													}
													IL_6E6:
													goto IL_9CC;
													IL_63A:
													boolValueNoThrow = A_0.GetBoolValueNoThrow(text + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("跑뷓ꗕ鷗ꋙ뷛뷝铟닡難菥飧迩苫諭", a_));
													num = (short)128319492;
													num2 = (int)((global::System.IntPtr)num);
													goto IL_61F;
												}
												catch (global::System.FormatException)
												{
													flag5 = new bool?(false);
													goto IL_9CC;
												}
												goto IL_6F9;
											case 33:
												if (keyValuePair2.Value is global::AcpBusinessLayer.AcpRecRefField)
												{
													num = (short)1481965595;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_AFC;
											case 34:
												goto IL_CAD;
											case 35:
												goto IL_6F9;
											}
											goto IL_4B7;
											IL_6F9:
											num7 = intValueNoThrow2;
											num = (short)1440677907;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_8CA:
											keyValuePair2.Value.ParseValueHelper(stringValueNoThrow2);
											this.a(keyValuePair2.Value, num7, flag2);
											num = (short)285802530;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_907:
											flag4 = flag3;
											num = (short)266272788;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_9CC:
											num = (short)1653735447;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_AB8:
											num5 = num7;
											num = (short)1435041795;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_AFC:
											stringValueNoThrow2 = A_0.GetStringValueNoThrow(text);
											num = (short)754122764;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_B44:
											num = (short)1767112725;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_B81:
											int? num8 = num6;
											int num9 = 0;
											flag2 = !(num8.GetValueOrDefault() == num9 & num8 != null);
											flag5 = new bool?(false);
											num = (short)915603466;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_C28:
											stringValueNoThrow = A_0.GetStringValueNoThrow(text);
											num = (short)813760526;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_CAD:
											num = (short)1896153088;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_CC6:
										break;
										IL_4B7:
										num7 = new int?(0);
										text = keyValuePair2.Key;
										intValueNoThrow2 = A_0.GetIntValueNoThrow(text + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("跑닓뫕맗뷙", a_));
										num = (short)1779630102;
										num2 = (int)((global::System.IntPtr)num);
										goto IL_420;
									}
									catch (global::System.FormatException)
									{
										break;
									}
									goto IL_CD1;
								case 3:
									if (!enumerator2.MoveNext())
									{
										num = (short)2105409537;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_CD1;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_3D3;
									}
									continue;
								}
								IL_3D8:
								num = (short)1445396483;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3D3:
								goto IL_3D8;
								IL_CD1:
								keyValuePair2 = enumerator2.Current;
								num = (short)385220610;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_D0F:
							goto IL_332;
						}
						finally
						{
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto IL_D22;
					}
					goto IL_47;
					IL_332:
					num = (short)2101805057;
					if (num != 0)
					{
					}
					num = (short)382205953;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D22:
					enumerator2 = A_1.GetEnumerator();
					num = (short)1353187330;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_D47:
				num = (short)1730543616;
				short num10 = num;
				return;
				IL_47:
				enumerator2 = A_1.GetEnumerator();
				num = (short)220266499;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0004AA94 File Offset: 0x00048C94
		private void a(global::AcpBusinessLayer.AcpFieldBase A_0, int? A_1, bool A_2)
		{
			short num = (short)644087808;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1280059856;
				short num3 = num;
				num = (short)565717456;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_A8:
					switch (0)
					{
					case 0:
						goto IL_C5;
					}
					break;
				default:
				{
					num = (short)1173815296;
					short num4 = num;
					num = (short)2082734080;
					if (num != 0)
					{
					}
					num = (short)1793130496;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
				int? num5;
				int num6;
				for (;;)
				{
					IL_B2:
					switch (num2)
					{
					case 0:
						goto IL_A8;
					case 1:
						num = (short)4194305;
						if (num != 0)
						{
						}
						num5 = (A_1 & 256);
						num6 = 0;
						A_0.ForceValid = !(num5.GetValueOrDefault() == num6 & num5 != null);
						A_0.UIInvalid = A_2;
						num = (short)1754923010;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_1B0;
					}
					goto IL_C5;
				}
				IL_1B0:
				num5 = (A_1 & 16);
				num6 = 0;
				A_0.Applicable = !(num5.GetValueOrDefault() == num6 & num5 != null);
				return;
				IL_C5:
				num5 = (A_1 & 8);
				num6 = 0;
				A_0.Valid = !(num5.GetValueOrDefault() == num6 & num5 != null);
				num = (short)1385693185;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_B2;
			}
			}
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0004AC98 File Offset: 0x00048E98
		public void ResetToDefault()
		{
			short num = (short)1056835565;
			short num2 = num;
			num = (short)2146961389;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			case 1:
				break;
			default:
			{
				num = (short)835715072;
				short num3 = num;
				break;
			}
			}
			num = (short)609157120;
			if (num != 0)
			{
			}
			num = (short)41877505;
			if (num != 0)
			{
			}
			using (global::System.Collections.Generic.Dictionary<string, global::AcpBusinessLayer.AcpFieldBase>.ValueCollection.Enumerator enumerator = this.fieldsByUIName.Values.GetEnumerator())
			{
				num = (short)1148321794;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 1:
						num = (short)866320388;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_E8;
						}
						continue;
					case 3:
						if (!enumerator.MoveNext())
						{
							num = (short)426508289;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpCommonLib.IAcpCommon)enumerator.Current).ResetToDefault();
						num = (short)658440192;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_159;
					}
					IL_10E:
					num = (short)2002386947;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_E8:
					goto IL_10E;
				}
				IL_159:;
			}
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0004AE20 File Offset: 0x00049020
		public void RepairRecRefs()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::System.Collections.Generic.Dictionary<string, global::AcpBusinessLayer.AcpFieldBase>.ValueCollection.Enumerator enumerator;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_D9;
				case 1:
				{
					num2 = (short)1371144193;
					if (num2 != 0)
					{
					}
					num2 = (short)2087287308;
					short num3 = num2;
					num2 = (short)1797290508;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D9;
					default:
						num2 = (short)2021588992;
						if (num2 != 0)
						{
						}
						try
						{
							num2 = (short)2042101764;
							num = (int)((global::System.IntPtr)num2);
							for (;;)
							{
								switch (num)
								{
								case 0:
								{
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
									if (acpRecRefField != null)
									{
										num2 = (short)902561793;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									break;
								}
								case 1:
								{
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
									acpRecRefField.ResetToDefaultNoConstraints();
									num2 = (short)1471807491;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num2 = (short)1857486853;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField = enumerator.Current as global::AcpBusinessLayer.AcpRecRefField;
									num2 = (short)520749056;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_141;
									}
									continue;
								case 5:
									num2 = (short)1782513670;
									num = (int)((global::System.IntPtr)num2);
									continue;
								case 6:
									goto IL_1EA;
								}
								IL_17E:
								num2 = (short)1006567426;
								num = (int)((global::System.IntPtr)num2);
								continue;
								IL_141:
								goto IL_17E;
							}
							IL_1EA:
							goto IL_BB;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_1FD;
						IL_BB:
						this.PopulateReferences();
						num2 = (short)1390673920;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					goto IL_1FD;
				case 3:
					goto IL_224;
				}
				goto IL_20;
				IL_D9:
				if (this.HasEmbeddedRecset)
				{
					num2 = (short)1741619202;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				break;
				IL_1FD:
				((global::AcpBusinessLayer.Recordset)this.EmbeddedRecset).RepairRecRefs();
				num2 = (short)2126446595;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_224:
			num2 = (short)664469504;
			short num4 = num2;
			return;
			IL_20:
			enumerator = this.fieldsByUIName.Values.GetEnumerator();
			num2 = (short)1885011969;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060003A8 RID: 936 RVA: 0x0004B08C File Offset: 0x0004928C
		// (remove) Token: 0x060003A9 RID: 937 RVA: 0x0004B1C0 File Offset: 0x000493C0
		public event global::System.ComponentModel.PropertyChangingEventHandler PropertyChanging
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::System.ComponentModel.PropertyChangingEventHandler propertyChangingEventHandler;
				global::System.ComponentModel.PropertyChangingEventHandler propertyChangingEventHandler2;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_83;
					case 1:
						if (propertyChangingEventHandler == propertyChangingEventHandler2)
						{
							num2 = (short)1509556226;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_85;
					case 2:
						goto IL_D5;
					}
					goto IL_1C;
				}
				IL_D5:
				num2 = (short)911343617;
				if (num2 != 0)
				{
				}
				num2 = (short)845873152;
				short num3 = num2;
				return;
				IL_1C:
				num2 = (short)951669601;
				short num4 = num2;
				num2 = (short)228610913;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_83:
					break;
				default:
					num2 = (short)62455808;
					if (num2 != 0)
					{
					}
					propertyChangingEventHandler = this.PropertyChanging;
					num2 = (short)12517376;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				IL_85:
				propertyChangingEventHandler2 = propertyChangingEventHandler;
				global::System.ComponentModel.PropertyChangingEventHandler value2 = (global::System.ComponentModel.PropertyChangingEventHandler)global::System.Delegate.Combine(propertyChangingEventHandler2, value);
				propertyChangingEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangingEventHandler>(ref this.PropertyChanging, value2, propertyChangingEventHandler2);
				num2 = (short)1570177025;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::System.ComponentModel.PropertyChangingEventHandler propertyChangingEventHandler;
				global::System.ComponentModel.PropertyChangingEventHandler propertyChangingEventHandler2;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_AD;
					case 1:
						if (propertyChangingEventHandler == propertyChangingEventHandler2)
						{
							num2 = (short)1852178434;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_AF;
					case 2:
						goto IL_FF;
					}
					goto IL_1C;
				}
				IL_FF:
				num2 = (short)360513536;
				short num3 = num2;
				return;
				IL_1C:
				num2 = (short)71351429;
				short num4 = num2;
				num2 = (short)974437509;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_AD:
					break;
				default:
					num2 = (short)815398912;
					if (num2 != 0)
					{
					}
					propertyChangingEventHandler = this.PropertyChanging;
					num2 = (short)1926103041;
					if (num2 != 0)
					{
					}
					num2 = (short)664076288;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				IL_AF:
				propertyChangingEventHandler2 = propertyChangingEventHandler;
				global::System.ComponentModel.PropertyChangingEventHandler value2 = (global::System.ComponentModel.PropertyChangingEventHandler)global::System.Delegate.Remove(propertyChangingEventHandler2, value);
				propertyChangingEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangingEventHandler>(ref this.PropertyChanging, value2, propertyChangingEventHandler2);
				num2 = (short)1294401537;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0004B2F8 File Offset: 0x000494F8
		protected virtual void Dispose(bool disposing)
		{
			short num = (short)1732575243;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (disposing)
					{
						num = (short)1449525251;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_268;
				case 1:
					goto IL_179;
				case 2:
					if (!this.disposedValue)
					{
						num = (short)756744198;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_289;
				case 3:
					this.isDisposeInProgress = true;
					num = (short)40173569;
					if (num != 0)
					{
					}
					num = (short)1813118981;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_179;
				case 5:
				{
					global::AcpCommonLib.IAcpField currentField = this.CurrentField;
					if (currentField == null)
					{
						num = (short)1789919233;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					currentField.Dispose();
					num = (short)346030084;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					num = (short)793509888;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_1D4;
				case 8:
					goto IL_287;
				case 9:
					goto IL_1D4;
				case 10:
					return;
				case 11:
					switch (0)
					{
					case 0:
						goto IL_5C;
					}
					continue;
				case 12:
				{
					global::AcpBusinessLayer.DifferenceCount differenceCount = this.diffCount;
					if (differenceCount == null)
					{
						num = (short)1548746759;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					differenceCount.Dispose();
					num = (short)642187273;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 13:
				{
					num = (short)1052377088;
					short num3 = num;
					goto IL_268;
				}
				}
				IL_5C:
				if (this.isDisposeInProgress)
				{
					num = (short)1228996618;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)664993794;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_179:
				num = (short)209125388;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1D4:
				this.a();
				num = (short)207251481;
				short num4 = num;
				num = (short)682846233;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_268:
					this.disposedValue = true;
					num = (short)2106064904;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)2144337920;
					if (num != 0)
					{
					}
					num = (short)353304589;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			return;
			IL_287:
			IL_289:
			this.isDisposeInProgress = false;
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0004B598 File Offset: 0x00049798
		private void a()
		{
			short num = (short)1930035202;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.Dictionary<string, global::AcpBusinessLayer.AcpFieldBase>.Enumerator enumerator;
				switch (num2)
				{
				case 0:
					goto IL_1D2;
				case 1:
					try
					{
						num = (short)780730370;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 1:
							{
								num = (short)935295564;
								short num3 = num;
								num = (short)1559001676;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									continue;
								default:
								{
									num = (short)1530462208;
									if (num != 0)
									{
									}
									global::System.Collections.Generic.KeyValuePair<string, global::AcpBusinessLayer.AcpFieldBase> keyValuePair;
									global::AcpBusinessLayer.AcpFieldBase value = keyValuePair.Value;
									if (value == null)
									{
										num = (short)1138688003;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									value.Dispose();
									num = (short)1138032640;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								break;
							}
							case 2:
								switch (0)
								{
								case 0:
									goto IL_BF;
								}
								continue;
							case 4:
								goto IL_1C2;
							case 5:
								num = (short)1464074244;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1114570757;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Collections.Generic.KeyValuePair<string, global::AcpBusinessLayer.AcpFieldBase> keyValuePair = enumerator.Current;
								num = (short)1576271873;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_C1:
							num = (short)1198981126;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_BF:
							goto IL_C1;
						}
						IL_1C2:
						return;
					}
					finally
					{
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_1D2;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				num = (short)1447362560;
				short num4 = num;
				if (this.fieldsByName != null)
				{
					num = (short)490078208;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1D2:
				enumerator = this.fieldsByName.GetEnumerator();
				num = (short)749731841;
				if (num != 0)
				{
				}
				num = (short)728563713;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0004B7E4 File Offset: 0x000499E4
		public void Dispose()
		{
			short num = (short)1073213649;
			short num2 = num;
			num = (short)516485329;
			switch (num2 == num)
			{
			}
			num = (short)2059665408;
			short num3 = num;
			num = (short)828243969;
			if (num != 0)
			{
			}
			num = (short)1781596160;
			if (num != 0)
			{
			}
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0004B8A0 File Offset: 0x00049AA0
		// Note: this type is marked as 'beforefieldinit'.
		static FeatureSection()
		{
			short num = (short)1438204062;
			short num2 = num;
			num = (short)545800350;
			switch (num2 == num)
			{
			}
			num = (short)653983744;
			short num3 = num;
			num = (short)897974273;
			if (num != 0)
			{
			}
			num = (short)1261174784;
			if (num != 0)
			{
			}
			global::AcpBusinessLayer.FeatureSection.InitializedSections = new global::System.Collections.Generic.Dictionary<global::System.Guid, global::AcpCommonLib.IAcpFeatureSection>();
		}

		// Token: 0x040000D8 RID: 216
		private global::System.Collections.Generic.Dictionary<string, global::AcpBusinessLayer.AcpFieldBase> fieldsByUIName;

		// Token: 0x040000D9 RID: 217
		private global::System.Collections.Generic.Dictionary<string, global::AcpBusinessLayer.AcpFieldBase> fieldsByName;

		// Token: 0x040000DA RID: 218
		private global::System.Collections.Generic.SortedDictionary<int, global::AcpBusinessLayer.AcpFieldBase> sortedFields;

		// Token: 0x040000DB RID: 219
		private global::System.Collections.Generic.List<global::AcpBusinessLayer.AcpFieldBase> fieldsBlocked;

		// Token: 0x040000DC RID: 220
		private global::AcpBusinessLayer.Recordset embeddedRecset;

		// Token: 0x040000DD RID: 221
		private string uiName;

		// Token: 0x040000DE RID: 222
		private global::AcpBusinessLayer.DifferenceCount diffCount;

		// Token: 0x040000DF RID: 223
		internal static global::System.Collections.Generic.Dictionary<global::System.Guid, global::AcpCommonLib.IAcpFeatureSection> InitializedSections;

		// Token: 0x040000E3 RID: 227
		private int dataXferOrder;

		// Token: 0x040000E4 RID: 228
		private bool disposedValue;

		// Token: 0x040000E5 RID: 229
		private bool isDisposeInProgress;
	}
}
