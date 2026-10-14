using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using System.Xml;
using System.Xml.Serialization;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using AcpCommonResources;

namespace AcpBusinessLayer
{
	// Token: 0x02000014 RID: 20
	[global::System.Diagnostics.DebuggerDisplay("Node = {FeatureName}, RefKey = {ReferenceKey}, NodeID = {NodeId}")]
	[global::System.Serializable]
	public abstract class FeatureNode : global::AcpCommonLib.IAcpFeatureNode, global::AcpCommonLib.IAcpConstraints, global::AcpCommonLib.IAcpCommon, global::System.IDisposable, global::System.Runtime.Serialization.ISerializable, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600018A RID: 394 RVA: 0x0001C774 File Offset: 0x0001A974
		// (set) Token: 0x0600018B RID: 395 RVA: 0x0001C824 File Offset: 0x0001AA24
		public global::AcpBusinessLayer.AcpKeyField KeyField
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)938538722;
				short num2 = num;
				num = (short)2082993890;
				switch (num2 == num)
				{
				}
				num = (short)1870528513;
				if (num != 0)
				{
				}
				num = (short)1678966784;
				if (num != 0)
				{
				}
				num = (short)586678272;
				short num3 = num;
				return this.<KeyField>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1045678512;
				short num2 = num;
				num = (short)754108848;
				switch (num2 == num)
				{
				}
				num = (short)1154154497;
				if (num != 0)
				{
				}
				num = (short)47185920;
				if (num != 0)
				{
				}
				num = (short)372178944;
				short num3 = num;
				this.<KeyField>k__BackingField = value;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600018C RID: 396 RVA: 0x0001C8D8 File Offset: 0x0001AAD8
		// (set) Token: 0x0600018D RID: 397 RVA: 0x0001C988 File Offset: 0x0001AB88
		public bool HasEmbeddedRecset
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)379624978;
				short num2 = num;
				num = (short)1160355346;
				switch (num2 == num)
				{
				}
				num = (short)492371968;
				if (num != 0)
				{
				}
				num = (short)415498241;
				if (num != 0)
				{
				}
				num = (short)1969684480;
				short num3 = num;
				return this.<HasEmbeddedRecset>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)683540481;
				if (num != 0)
				{
				}
				num = (short)1488641938;
				short num2 = num;
				num = (short)893247378;
				switch (num2 == num)
				{
				}
				num = (short)1072103424;
				if (num != 0)
				{
				}
				num = (short)1157824512;
				short num3 = num;
				this.<HasEmbeddedRecset>k__BackingField = value;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600018E RID: 398 RVA: 0x0001CA3C File Offset: 0x0001AC3C
		// (set) Token: 0x0600018F RID: 399 RVA: 0x0001CAEC File Offset: 0x0001ACEC
		internal bool bAddCurrentOnParent
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)884995265;
				short num2 = num;
				num = (short)1500837057;
				switch (num2 == num)
				{
				}
				num = (short)1394737152;
				if (num != 0)
				{
				}
				num = (short)588382209;
				if (num != 0)
				{
				}
				num = (short)828899328;
				short num3 = num;
				return this.<bAddCurrentOnParent>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)170002944;
				short num2 = num;
				num = (short)694094336;
				switch (num2 == num)
				{
				}
				num = (short)1756364801;
				if (num != 0)
				{
				}
				num = (short)2067529728;
				if (num != 0)
				{
				}
				num = (short)1470038016;
				short num3 = num;
				this.<bAddCurrentOnParent>k__BackingField = value;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000190 RID: 400 RVA: 0x0001CBA0 File Offset: 0x0001ADA0
		// (set) Token: 0x06000191 RID: 401 RVA: 0x0001CC50 File Offset: 0x0001AE50
		public bool Deleted
		{
			get
			{
				short num = (short)2061697025;
				if (num != 0)
				{
				}
				num = (short)981595956;
				short num2 = num;
				num = (short)1084356404;
				switch (num2 == num)
				{
				}
				num = (short)548339712;
				if (num != 0)
				{
				}
				num = (short)92602368;
				short num3 = num;
				return this.deleted;
			}
			internal set
			{
				switch (0)
				{
				case 0:
					goto IL_24;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_0A:
					global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator;
					switch (num)
					{
					case 0:
						return;
					case 1:
						num2 = (short)754712577;
						if (num2 != 0)
						{
						}
						num2 = (short)1194393604;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						try
						{
							num2 = (short)1459486723;
							num = (int)((global::System.IntPtr)num2);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
								switch (num)
								{
								case 0:
									goto IL_257;
								case 1:
									if (!enumerator.MoveNext())
									{
										num2 = (short)1645871106;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									goto IL_213;
								case 2:
									num2 = (short)808189952;
									num = (int)((global::System.IntPtr)num2);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_C5;
									}
									continue;
								case 4:
									try
									{
										num2 = (short)365428739;
										num = (int)((global::System.IntPtr)num2);
										for (;;)
										{
											switch (num)
											{
											case 0:
												goto IL_1A7;
											case 1:
												if (!enumerator2.MoveNext())
												{
													num2 = (short)655097858;
													num = (int)((global::System.IntPtr)num2);
													continue;
												}
												enumerator2.Current.Deleted = value;
												num2 = (short)748683268;
												num = (int)((global::System.IntPtr)num2);
												continue;
											case 2:
												num2 = (short)1246691328;
												num = (int)((global::System.IntPtr)num2);
												continue;
											case 3:
												switch (0)
												{
												case 0:
													goto IL_137;
												}
												continue;
											}
											IL_139:
											num2 = (short)671088641;
											num = (int)((global::System.IntPtr)num2);
											continue;
											IL_137:
											goto IL_139;
										}
										IL_1A7:
										break;
									}
									finally
									{
										num2 = (short)1189806081;
										num = (int)((global::System.IntPtr)num2);
										for (;;)
										{
											switch (num)
											{
											case 0:
												goto IL_210;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_1DD;
												}
												continue;
											case 2:
												enumerator2.Dispose();
												num2 = (short)885850112;
												num = (int)((global::System.IntPtr)num2);
												continue;
											}
											IL_1DD:
											if (enumerator2 == null)
											{
												break;
											}
											num2 = (short)1364918274;
											num = (int)((global::System.IntPtr)num2);
										}
										IL_210:;
									}
									goto IL_213;
								}
								IL_C7:
								num2 = (short)2058747905;
								num = (int)((global::System.IntPtr)num2);
								continue;
								IL_C5:
								goto IL_C7;
								IL_213:
								enumerator2 = ((global::AcpBusinessLayer.Recordset)enumerator.Current).GetEnumerator();
								num2 = (short)554041348;
								num = (int)((global::System.IntPtr)num2);
							}
							IL_257:
							return;
						}
						finally
						{
							num2 = (short)475791361;
							num = (int)((global::System.IntPtr)num2);
							for (;;)
							{
								switch (num)
								{
								case 0:
								{
									num2 = (short)1686775821;
									short num3 = num2;
									num2 = (short)1508714509;
									switch ((num3 == num2) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_2AE;
									default:
										goto IL_2F8;
									}
									break;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_28C;
									}
									continue;
								case 2:
									enumerator.Dispose();
									goto IL_2AE;
								}
								IL_28C:
								if (enumerator != null)
								{
									num2 = (short)1093795842;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_310;
								IL_2AE:
								num2 = (short)1439432704;
								num = (int)((global::System.IntPtr)num2);
							}
							IL_2F8:
							num2 = (short)196608;
							if (num2 != 0)
							{
							}
							IL_310:;
						}
						goto IL_311;
					case 3:
						if (this.Parent != null)
						{
							num2 = (short)1002700801;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 4:
						if (this.Parent.IsEmbeddedRecset)
						{
							num2 = (short)122945536;
							short num4 = num2;
							num2 = (short)84672512;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_311;
					}
					goto IL_24;
					IL_311:
					enumerator = this.EmbeddedRecordsets.GetEnumerator();
					num2 = (short)1320812546;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_24:
				this.deleted = value;
				num2 = (short)942342147;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000192 RID: 402 RVA: 0x0001D034 File Offset: 0x0001B234
		// (set) Token: 0x06000193 RID: 403 RVA: 0x0001D0E0 File Offset: 0x0001B2E0
		public global::AcpCommonLib.FeatureNodeConstraint NodeDeleted
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1712968374;
				short num2 = num;
				num = (short)54907574;
				switch (num2 == num)
				{
				}
				num = (short)1039794177;
				if (num != 0)
				{
				}
				num = (short)1457324032;
				if (num != 0)
				{
				}
				num = (short)572850176;
				short num3 = num;
				return this.<NodeDeleted>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)859060448;
				short num2 = num;
				num = (short)686897376;
				switch (num2 == num)
				{
				}
				num = (short)2117533696;
				if (num != 0)
				{
				}
				num = (short)1617887233;
				if (num != 0)
				{
				}
				num = (short)1095499776;
				short num3 = num;
				this.<NodeDeleted>k__BackingField = value;
			}
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0001D190 File Offset: 0x0001B390
		private FeatureNode()
		{
			this.fieldsAll = new global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField>();
			this.fieldsWithValidity = new global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField>();
			this.fieldsWithApplicability = new global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField>();
			this.fieldsWithEditability = new global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField>();
			this.fieldsWithVisibility = new global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField>();
			this.recRefFields = new global::System.Collections.Generic.List<global::AcpBusinessLayer.AcpRecRefField>();
			this.valid = true;
			base..ctor();
			this.id = ++global::AcpBusinessLayer.FeatureNode.NodeIdCounter;
			this.diffCount = new global::AcpBusinessLayer.DifferenceCount();
			this.diffCount.CountChanged += this.a;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0001D224 File Offset: 0x0001B424
		protected FeatureNode(global::AcpBusinessLayer.Recordset parent) : this()
		{
			this.sections = new global::System.Collections.Generic.Dictionary<int, global::AcpBusinessLayer.FeatureSection>();
			this.sectionsByOrder = new global::System.Collections.Generic.SortedDictionary<int, global::AcpBusinessLayer.FeatureSection>();
			this.parent = parent;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0001D254 File Offset: 0x0001B454
		internal global::AcpBusinessLayer.FeatureNode DeepCopy(global::System.Collections.Generic.Dictionary<global::AcpCommonLib.IAcpField, string> RecRefsToRepair)
		{
			short num = (short)1126326722;
			short num2 = num;
			num = (short)1311269314;
			switch (num2 == num)
			{
			}
			num = (short)1484980225;
			if (num != 0)
			{
			}
			num = (short)1359806464;
			if (num != 0)
			{
			}
			num = (short)1839267840;
			short num3 = num;
			return this.a(true, RecRefsToRepair);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0001D304 File Offset: 0x0001B504
		internal void RegisterValidity(global::AcpCommonLib.IAcpField field)
		{
			short num = (short)1299114688;
			short num2 = num;
			num = (short)220719808;
			switch (num2 == num)
			{
			}
			num = (short)446300160;
			if (num != 0)
			{
			}
			num = (short)730005505;
			if (num != 0)
			{
			}
			num = (short)1877671936;
			short num3 = num;
			this.fieldsWithValidity.Add(field);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0001D3BC File Offset: 0x0001B5BC
		internal void RegisterApplicability(global::AcpCommonLib.IAcpField field)
		{
			short num = (short)1088002722;
			short num2 = num;
			num = (short)1886362274;
			switch (num2 == num)
			{
			}
			num = (short)530186241;
			if (num != 0)
			{
			}
			num = (short)638648320;
			if (num != 0)
			{
			}
			num = (short)877330432;
			short num3 = num;
			this.fieldsWithApplicability.Add(field);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0001D470 File Offset: 0x0001B670
		internal void RegisterVisibility(global::AcpCommonLib.IAcpField field)
		{
			short num = (short)77725696;
			short num2 = num;
			num = (short)950684161;
			short num3 = num;
			num = (short)1356548609;
			switch (num3 == num)
			{
			}
			num = (short)1518141440;
			if (num != 0)
			{
			}
			num = (short)1527382017;
			if (num != 0)
			{
			}
			this.fieldsWithVisibility.Add(field);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0001D524 File Offset: 0x0001B724
		internal void RegisterEditability(global::AcpCommonLib.IAcpField field)
		{
			short num = (short)2026897408;
			short num2 = num;
			num = (short)999334263;
			short num3 = num;
			num = (short)1325179255;
			switch (num3 == num)
			{
			}
			num = (short)750256129;
			if (num != 0)
			{
			}
			num = (short)754712576;
			if (num != 0)
			{
			}
			this.fieldsWithEditability.Add(field);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0001D5D8 File Offset: 0x0001B7D8
		private global::AcpBusinessLayer.FeatureNode a(bool A_0, global::System.Collections.Generic.Dictionary<global::AcpCommonLib.IAcpField, string> A_1)
		{
			short num = (short)363724800;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_68;
				}
				global::AcpBusinessLayer.FeatureNode featureNode;
				bool flag;
				global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2;
				bool flag2;
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
						featureNode.KeyField.ForceValid = false;
						num = (short)1506344963;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (flag)
						{
							num = (short)74252290;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return featureNode;
					case 2:
						num = (short)2144927745;
						if (num != 0)
						{
						}
						global::AcpCommonLib.UndoRedo.UndoManager.StartUndoRedo();
						num = (short)1850081284;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_16B;
					case 4:
						return featureNode;
					case 5:
						try
						{
							num = (short)1976762371;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::AcpBusinessLayer.FeatureSection featureSection;
								global::AcpBusinessLayer.Recordset recordset;
								global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator3;
								switch (num2)
								{
								case 0:
									goto IL_63D;
								case 1:
									goto IL_63D;
								case 2:
									if (featureSection.HasEmbeddedRecset)
									{
										num = (short)1158545414;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_6CF;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_1FE;
									}
									continue;
								case 4:
									num = (short)1450901515;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									int count;
									if (count-- <= 0)
									{
										num = (short)673841160;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_469;
								}
								case 6:
								{
									recordset = (featureSection.EmbeddedRecset as global::AcpBusinessLayer.Recordset);
									int count = recordset.Count;
									recordset.lastId = 0;
									global::AcpBusinessLayer.FeatureSection featureSection2;
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = ((global::AcpBusinessLayer.Recordset)featureSection2.EmbeddedRecset).GetEnumerator();
									num = (short)1527185417;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)2065039364;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureSection featureSection2 = (global::AcpBusinessLayer.FeatureSection)enumerator2.Current;
									featureSection = (featureNode[featureSection2.FeatureSectionId] as global::AcpBusinessLayer.FeatureSection);
									featureSection.FeatureSectionName = featureSection2.FeatureSectionName;
									num = (short)1890844674;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									goto IL_6CF;
								case 9:
								{
									try
									{
										num = (short)1563492352;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											num = (short)239464091;
											short num3 = num;
											num = (short)905178779;
											global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
											switch ((num3 == num) ? 1 : 0)
											{
											case 0:
											case 2:
												break;
											default:
												num = (short)1901199360;
												if (num != 0)
												{
												}
												switch (num2)
												{
												case 0:
													switch (0)
													{
													case 0:
														goto IL_36A;
													}
													continue;
												case 2:
													if (!enumerator.MoveNext())
													{
														num = (short)914292739;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_36C;
												case 3:
													num = (short)233766916;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 4:
													goto IL_3F5;
												}
												IL_3A0:
												num = (short)507707394;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_36A:
												goto IL_3A0;
											}
											IL_36C:
											global::AcpBusinessLayer.FeatureNode featureNode2 = enumerator.Current;
											recordset.AddRecord(featureNode2.a(false, recordset));
											num = (short)776732673;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_3F5:
										goto IL_23E;
									}
									finally
									{
										num = (short)2121728000;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_42D;
												}
												continue;
											case 1:
												enumerator.Dispose();
												num = (short)1381236738;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												goto IL_466;
											}
											IL_42D:
											if (enumerator == null)
											{
												break;
											}
											num = (short)1834876929;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_466:;
									}
									goto IL_469;
									IL_23E:
									global::AcpBusinessLayer.FeatureSection featureSection2;
									recordset.lastId = ((global::AcpBusinessLayer.Recordset)featureSection2.EmbeddedRecset).Count;
									num = (short)1569521665;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
									try
									{
										num = (short)224788482;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												num = (short)549388294;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
											{
												if (!enumerator3.MoveNext())
												{
													num = (short)1603665920;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::AcpBusinessLayer.AcpFieldBase acpFieldBase = (global::AcpBusinessLayer.AcpFieldBase)enumerator3.Current;
												global::AcpBusinessLayer.FeatureSection featureSection2;
												acpFieldBase.DeepCopy(featureSection2[acpFieldBase.UIName]);
												global::AcpBusinessLayer.AcpRecRefField acpRecRefField = acpFieldBase as global::AcpBusinessLayer.AcpRecRefField;
												num = (short)1414594563;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 2:
												switch (0)
												{
												case 0:
													goto IL_4D2;
												}
												continue;
											case 3:
											{
												global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
												if (acpRecRefField != null)
												{
													num = (short)733216772;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 4:
											{
												global::AcpBusinessLayer.FeatureSection featureSection2;
												global::AcpBusinessLayer.AcpFieldBase acpFieldBase;
												global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
												A_1[acpRecRefField] = ((global::AcpBusinessLayer.AcpRecRefField)featureSection2[acpFieldBase.UIName]).UIValue;
												num = (short)2101870597;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 6:
												goto IL_5C9;
											}
											IL_4D4:
											num = (short)611385345;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_4D2:
											goto IL_4D4;
										}
										IL_5C9:
										break;
									}
									finally
									{
										num = (short)1461977088;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_601;
												}
												continue;
											case 1:
												enumerator3.Dispose();
												num = (short)2072248322;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												goto IL_63A;
											}
											IL_601:
											if (enumerator3 == null)
											{
												break;
											}
											num = (short)1184432129;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_63A:;
									}
									goto IL_63D;
								case 11:
									goto IL_713;
								}
								IL_203:
								num = (short)145424391;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1FE:
								goto IL_203;
								IL_469:
								recordset.RemoveRecordAt(0);
								num = (short)1004929024;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_63D:
								num = (short)745472005;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_6CF:
								enumerator3 = featureSection.FieldsCollectionByOrder.GetEnumerator();
								num = (short)432799754;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_713:
							goto IL_838;
						}
						finally
						{
							num = (short)1707737088;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_74B;
									}
									continue;
								case 1:
									enumerator2.Dispose();
									num = (short)1426259970;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_782;
								}
								IL_74B:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)2102919169;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_782:;
						}
						goto IL_785;
						IL_838:
						num = (short)2096037898;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_785;
					case 7:
						goto IL_86D;
					case 8:
						if (this.ReferenceKey == featureNode.ReferenceKey)
						{
							num = (short)994443264;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_16B;
					case 9:
						if (featureNode.KeyField != null)
						{
							num = (short)276824070;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_16B;
					case 10:
						if (flag2)
						{
							num = (short)462749708;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_86D;
					case 11:
						if (A_0)
						{
							num = (short)630063117;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_16B;
					case 12:
						global::AcpCommonLib.ConstraintManager.Resume();
						num = (short)1821376519;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)1729495049;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_68;
					IL_16B:
					num = (short)1592131585;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_785:
					num = (short)1966669832;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_86D:
					num = (short)2035220491;
					num2 = (int)((global::System.IntPtr)num);
				}
				return featureNode;
				IL_68:
				num = (short)1879572480;
				short num4 = num;
				flag = global::AcpCommonLib.UndoRedo.UndoManager.StopUndoRedo();
				flag2 = global::AcpCommonLib.ConstraintManager.Suspend();
				featureNode = ((global::AcpBusinessLayer.Recordset)this.Parent).CreateDefaultRecordHelper();
				featureNode.FeatureName = this.FeatureName;
				featureNode.UIPagePath = this.UIPagePath;
				featureNode.TreeNodeLabel = this.TreeNodeLabel;
				featureNode.HasEmbeddedRecset = this.HasEmbeddedRecset;
				enumerator2 = this.FeatureSectionsCollectionByOrder.GetEnumerator();
				num = (short)1243742213;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0001DEDC File Offset: 0x0001C0DC
		private global::AcpBusinessLayer.FeatureNode a(bool A_0, global::AcpBusinessLayer.Recordset A_1)
		{
			short num = (short)298647552;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5F;
				}
				global::AcpBusinessLayer.FeatureNode featureNode;
				bool flag;
				bool flag2;
				for (;;)
				{
					IL_28:
					global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator;
					switch (num2)
					{
					case 0:
						if (featureNode.KeyField != null)
						{
							num = (short)2093416453;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_511;
					case 1:
						num = (short)1675821057;
						if (num != 0)
						{
						}
						goto IL_511;
					case 2:
						if (flag)
						{
							num = (short)1406599174;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return featureNode;
					case 3:
					{
						num = (short)1880754905;
						short num3 = num;
						num = (short)1453132505;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_216;
						case 1:
							break;
						default:
						{
							num = (short)345309184;
							short num4 = num;
							break;
						}
						}
						num = (short)452198400;
						if (num != 0)
						{
						}
						if (!A_1.HasKeyField)
						{
							num = (short)1413021703;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_511;
					}
					case 4:
						goto IL_19A;
					case 5:
						A_1.InitKeysToNode();
						num = (short)487784449;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						global::AcpCommonLib.UndoRedo.UndoManager.StartUndoRedo();
						num = (short)1090912266;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)1480916992;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (flag2)
						{
							num = (short)192282633;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_19A;
					case 9:
						global::AcpCommonLib.ConstraintManager.Resume();
						num = (short)953942020;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						return featureNode;
					case 11:
						try
						{
							num = (short)839122944;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_2B9;
									}
									continue;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)656670722;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureSection featureSection = (global::AcpBusinessLayer.FeatureSection)enumerator.Current;
									global::AcpBusinessLayer.FeatureSection featureSection2 = featureNode[featureSection.FeatureSectionId] as global::AcpBusinessLayer.FeatureSection;
									featureSection2.FeatureSectionName = featureSection.FeatureSectionName;
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator2 = featureSection2.FieldsCollectionByOrder.GetEnumerator();
									num = (short)145817603;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_487;
								case 3:
									try
									{
										num = (short)1158873088;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_381;
												}
												continue;
											case 2:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = (short)335347715;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::AcpBusinessLayer.AcpFieldBase acpFieldBase = (global::AcpBusinessLayer.AcpFieldBase)enumerator2.Current;
												global::AcpBusinessLayer.FeatureSection featureSection;
												acpFieldBase.DeepCopy(featureSection[acpFieldBase.UIName]);
												num = (short)1722613761;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 3:
												num = (short)818479108;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 4:
												goto IL_412;
											}
											IL_3BE:
											num = (short)1833697282;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_381:
											goto IL_3BE;
										}
										IL_412:
										break;
									}
									finally
									{
										num = (short)1235156992;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator2;
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_44A;
												}
												continue;
											case 1:
												enumerator2.Dispose();
												num = (short)1456537602;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												goto IL_484;
											}
											IL_44A:
											if (enumerator2 == null)
											{
												break;
											}
											num = (short)42336257;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_484:;
									}
									goto IL_487;
								case 4:
									goto IL_4A0;
								}
								IL_2BB:
								num = (short)271384577;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2B9:
								goto IL_2BB;
								IL_487:
								num = (short)1789722628;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4A0:
							goto IL_216;
						}
						finally
						{
							num = (short)1231749120;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_4D8;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1308819458;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_50E;
								}
								IL_4D8:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1762131969;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_50E:;
						}
						goto IL_511;
					}
					goto IL_5F;
					IL_19A:
					num = (short)1211564034;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_216:
					featureNode.bAddCurrentOnParent = false;
					num = (short)797900808;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_511:
					featureNode.FeatureName = this.FeatureName;
					featureNode.UIPagePath = this.UIPagePath;
					featureNode.TreeNodeLabel = this.TreeNodeLabel;
					featureNode.HasEmbeddedRecset = this.HasEmbeddedRecset;
					featureNode.bAddCurrentOnParent = true;
					enumerator = this.FeatureSectionsCollectionByOrder.GetEnumerator();
					num = (short)1075576843;
					num2 = (int)((global::System.IntPtr)num);
				}
				return featureNode;
				IL_5F:
				flag = global::AcpCommonLib.UndoRedo.UndoManager.StopUndoRedo();
				flag2 = global::AcpCommonLib.ConstraintManager.Suspend();
				featureNode = ((global::AcpBusinessLayer.Recordset)this.Parent).CreateDefaultRecordHelper();
				featureNode.Parent = A_1;
				num = (short)1302069251;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0001E490 File Offset: 0x0001C690
		internal void InvokeRecRefValidities()
		{
			short num;
			for (;;)
			{
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = this.ReferencingNodes.GetEnumerator();
				try
				{
					num = (short)864878594;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_B4;
						case 1:
							num = (short)1051590656;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_47;
							}
							continue;
						case 3:
							if (!enumerator.MoveNext())
							{
								num = (short)979369985;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							enumerator.Current.CallConstraints();
							num = (short)1853947908;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_6B:
						num = (short)1565327363;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_47:
						goto IL_6B;
					}
					IL_B4:;
				}
				finally
				{
					num = (short)1030684672;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_E7;
							}
							continue;
						case 1:
							goto IL_11B;
						case 2:
							enumerator.Dispose();
							num = (short)1518338049;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_E7:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1899560962;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_11B:;
				}
				num = (short)42572043;
				short num3 = num;
				num = (short)855546123;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_152;
				}
			}
			IL_152:
			num = (short)843579393;
			if (num != 0)
			{
			}
			num = (short)2132279296;
			if (num != 0)
			{
			}
			num = (short)1968308224;
			short num4 = num;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0001E664 File Offset: 0x0001C864
		internal void CalculateValidityWithoutDependencies()
		{
			short num = (short)71696384;
			short num2 = num;
			using (global::System.Collections.Generic.Dictionary<int, global::AcpBusinessLayer.FeatureSection>.ValueCollection.Enumerator enumerator = this.sections.Values.GetEnumerator())
			{
				num = (short)389349378;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_130;
					case 1:
					{
						num = (short)1041719332;
						short num4 = num;
						num = (short)1602969636;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_51;
						default:
							num = (short)1260912640;
							if (num != 0)
							{
							}
							num = (short)1599078400;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						goto IL_51;
					case 3:
						if (!enumerator.MoveNext())
						{
							num = (short)71696385;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator.Current.CalculateValidityWithoutDependencies();
						num = (short)1499529220;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_75;
					IL_51:
					switch (0)
					{
					case 0:
						IL_75:
						goto IL_9A;
					}
					continue;
					IL_9A:
					num = (short)907149315;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_130:;
			}
			num = (short)441974785;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0001E7E8 File Offset: 0x0001C9E8
		public override string ToString()
		{
			short num = (short)93823749;
			short num2 = num;
			num = (short)1378853637;
			switch (num2 == num)
			{
			}
			num = (short)1785069569;
			if (num != 0)
			{
			}
			num = (short)261357568;
			if (num != 0)
			{
			}
			num = (short)77070336;
			short num3 = num;
			return this.ReferenceKey;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0001E89C File Offset: 0x0001CA9C
		internal void SetupDependencies()
		{
			short num = (short)1763966976;
			short num2 = num;
			using (global::System.Collections.Generic.Dictionary<int, global::AcpBusinessLayer.FeatureSection>.ValueCollection.Enumerator enumerator = this.sections.Values.GetEnumerator())
			{
				num = (short)1873543172;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						num = (short)1243283457;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_199;
					case 3:
					{
						global::AcpBusinessLayer.FeatureSection featureSection;
						if (featureSection.HasEmbeddedRecset)
						{
							goto IL_FF;
						}
						break;
					}
					case 4:
						switch (0)
						{
						case 0:
							goto IL_7F;
						}
						continue;
					case 5:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1774845952;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)410661828;
						short num4 = num;
						num = (short)1617245124;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_FF;
						default:
						{
							num = (short)1735786496;
							if (num != 0)
							{
							}
							global::AcpBusinessLayer.FeatureSection featureSection = enumerator.Current;
							featureSection.SetupDependencies();
							num = (short)470548483;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 6:
					{
						global::AcpBusinessLayer.FeatureSection featureSection;
						((global::AcpBusinessLayer.Recordset)featureSection.EmbeddedRecset).SetupDependencies();
						num = (short)1234042882;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_7F;
					IL_FF:
					num = (short)1357971462;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_119:
					num = (short)2007302149;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_7F:
					goto IL_119;
				}
				IL_199:;
			}
			num = (short)1264189441;
			if (num != 0)
			{
			}
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0001EA94 File Offset: 0x0001CC94
		internal void SetConstraints()
		{
			short num = (short)1455292416;
			short num2 = num;
			num = (short)1186332673;
			if (num != 0)
			{
			}
			using (global::System.Collections.Generic.Dictionary<int, global::AcpBusinessLayer.FeatureSection>.ValueCollection.Enumerator enumerator = this.sections.Values.GetEnumerator())
			{
				num = (short)1386807300;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						num = (short)1563099137;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_1B6;
					case 3:
					{
						global::AcpBusinessLayer.FeatureSection featureSection;
						if (featureSection.HasEmbeddedRecset)
						{
							goto IL_11E;
						}
						break;
					}
					case 4:
						switch (0)
						{
						case 0:
							goto IL_A3;
						}
						continue;
					case 5:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)2102853632;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1492236606;
						short num4 = num;
						num = (short)1713551678;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_11E;
						default:
						{
							num = (short)1021771776;
							if (num != 0)
							{
							}
							global::AcpBusinessLayer.FeatureSection featureSection = enumerator.Current;
							featureSection.SetConstraints();
							num = (short)587137027;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 6:
					{
						global::AcpBusinessLayer.FeatureSection featureSection;
						((global::AcpBusinessLayer.Recordset)featureSection.EmbeddedRecset).SetConstraints();
						num = (short)1251016706;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_A3;
					IL_11E:
					num = (short)910884870;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_137:
					num = (short)9306117;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_A3:
					goto IL_137;
				}
				IL_1B6:;
			}
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0001EC84 File Offset: 0x0001CE84
		internal void Initialize()
		{
			short num = (short)741829260;
			short num2 = num;
			num = (short)338848396;
			switch (num2 == num)
			{
			}
			num = (short)1377566720;
			if (num != 0)
			{
			}
			num = (short)272629761;
			if (num != 0)
			{
			}
			num = (short)573243392;
			short num3 = num;
			this.SetupDependencies();
			this.PopulateReferences();
			this.SetConstraints();
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0001ED40 File Offset: 0x0001CF40
		internal bool AddToXml(global::System.Xml.XmlNode node, global::AcpCommonLib.XmlFileType fileType)
		{
			int a_ = 11;
			short num;
			global::System.Xml.XmlElement xmlElement;
			for (;;)
			{
				num = (short)714801153;
				if (num != 0)
				{
				}
				global::System.Xml.XmlDocument ownerDocument = node.OwnerDocument;
				if (this.Parent.IsEmbeddedRecset)
				{
					goto IL_23A;
				}
				string name = global::AcpBusinessLayer.UndoRedo.SetValueTask.b("鏜냞藠蛢", a_);
				IL_25A:
				xmlElement = ownerDocument.CreateElement(name);
				xmlElement.SetAttribute(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("鏜뻞賠蛢", a_), this.UIName);
				xmlElement.SetAttribute(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("远뫞蟠蛢韤苦蟨裪裬ꓮ铰諲", a_), this.ReferenceKey);
				global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator = this.FeatureSectionsCollection.GetEnumerator();
				try
				{
					num = (short)744488962;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
						switch (num2)
						{
						case 1:
							goto IL_18C;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_9A;
							}
							continue;
						case 3:
							if (!acpFeatureSection.HasVisibleObjects)
							{
								num = (short)2061500425;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_18C;
						case 4:
							num = (short)2093023239;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							num = (short)1416757254;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							if (acpFeatureSection.EmbeddedRecset.Count == 0)
							{
								num = (short)1873936385;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 7:
							goto IL_1CD;
						case 8:
							if (!enumerator.MoveNext())
							{
								num = (short)444661764;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							acpFeatureSection = enumerator.Current;
							num = (short)858914819;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							num = (short)1180172298;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							if (acpFeatureSection.HasEmbeddedRecset)
							{
								num = (short)1132986373;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						IL_9C:
						num = (short)983957512;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_9A:
						goto IL_9C;
						IL_18C:
						((global::AcpBusinessLayer.FeatureSection)acpFeatureSection).AddToXml(xmlElement, fileType);
						num = (short)1042939904;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1CD:
					goto IL_2A5;
				}
				finally
				{
					num = (short)1147338752;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_202;
							}
							continue;
						case 1:
							goto IL_237;
						case 2:
							enumerator.Dispose();
							num = (short)46792705;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_202:
						if (enumerator == null)
						{
							break;
						}
						num = (short)964755458;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_237:;
				}
				goto IL_23A;
				IL_2A5:
				num = (short)525186553;
				short num3 = num;
				num = (short)1089254905;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_2D9;
				}
				IL_23A:
				name = global::AcpBusinessLayer.UndoRedo.SetValueTask.b("飜닞菠蛢臤菦賨迪ꏬ胮闰雲", a_);
				goto IL_25A;
			}
			IL_2D9:
			num = (short)386596864;
			if (num != 0)
			{
			}
			num = (short)1963130880;
			short num4 = num;
			node.AppendChild(xmlElement);
			return true;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0001F08C File Offset: 0x0001D28C
		internal bool ReadFromXml(global::System.Xml.XmlNode node, global::AcpCommonLib.UndoRedo.ContainerTask task, global::AcpCommonLib.XmlFileType fileType, bool importCopyOper, global::System.Collections.Generic.Dictionary<global::AcpCommonLib.IAcpField, string> RecRefsToRepair, global::System.Collections.Generic.Dictionary<global::AcpCommonLib.IAcpField, string> RecRefFieldsOfEmbedRecset)
		{
			int a_ = 19;
			short num = (short)1569718272;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_48;
				}
				global::System.Xml.XmlAttribute xmlAttribute;
				for (;;)
				{
					IL_31:
					bool flag;
					global::System.Collections.Generic.SortedDictionary<int, int>.Enumerator enumerator2;
					global::System.Collections.Generic.SortedDictionary<int, int> sortedDictionary;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)1779367940;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.KeyValuePair<int, int> keyValuePair;
								switch (num2)
								{
								case 0:
									num = (short)1831403521;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_586;
								case 2:
									try
									{
										num = (short)1126563848;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_324;
											case 1:
												flag = false;
												num = (short)604176384;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
											{
												int num3;
												global::AcpBusinessLayer.FeatureSection featureSection = (global::AcpBusinessLayer.FeatureSection)this[num3];
												global::AcpCommonLib.AppInfoManager.DndAndImportSection.Add(featureSection.GetType());
												num = (short)453312517;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 3:
												if (fileType == global::AcpCommonLib.XmlFileType.ImpExp)
												{
													num = (short)2009595913;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_42C;
											case 4:
												goto IL_385;
											case 5:
											{
												global::AcpBusinessLayer.FeatureSection featureSection;
												if (featureSection != null)
												{
													num = (short)1157824522;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												num = (short)1101922307;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 6:
											{
												int num3;
												global::System.Xml.XmlNode xmlNode;
												if (int.TryParse(xmlNode.Attributes[global::AcpBusinessLayer.UndoRedo.SetValueTask.b("賤菦", a_)].Value, out num3))
												{
													num = (short)1415643150;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												flag = false;
												num = (short)1582366724;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 7:
												goto IL_427;
											case 8:
												switch (0)
												{
												case 0:
													goto IL_1F7;
												}
												continue;
											case 9:
											{
												global::System.Xml.XmlNode xmlNode;
												global::AcpCommonLib.Utility.LogMissingXmlNode(xmlNode);
												num = (short)1343094791;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 10:
												num = (short)1031340048;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 11:
											{
												global::System.Collections.IEnumerator enumerator;
												if (!enumerator.MoveNext())
												{
													num = (short)1179779087;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)enumerator.Current;
												num = (short)104529926;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 12:
											{
												int num3;
												if (keyValuePair.Value == num3)
												{
													num = (short)835518466;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 13:
												goto IL_445;
											case 14:
												num = (short)606994444;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 15:
												goto IL_42C;
											case 16:
											{
												global::AcpBusinessLayer.FeatureSection featureSection;
												global::System.Xml.XmlNode xmlNode;
												if (!featureSection.ReadFromXml(xmlNode, task, fileType, importCopyOper, RecRefsToRepair, RecRefFieldsOfEmbedRecset))
												{
													num = (short)1465057281;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_42C;
											}
											}
											IL_329:
											num = (short)693174283;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_1F7:
											goto IL_329;
											IL_42C:
											num = (short)617086989;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_324:
										IL_385:
										IL_427:
										IL_445:
										goto IL_501;
									}
									finally
									{
										switch (0)
										{
										case 0:
											goto IL_467;
										}
										global::System.IDisposable disposable;
										for (;;)
										{
											IL_454:
											switch (num2)
											{
											case 0:
												if (disposable != null)
												{
													num = (short)1166475266;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_4BE;
											case 1:
												goto IL_4BC;
											case 2:
												disposable.Dispose();
												num = (short)1820065793;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_467;
										}
										IL_4BC:
										IL_4BE:
										goto EndFinally_25;
										IL_467:
										global::System.Collections.IEnumerator enumerator;
										disposable = (enumerator as global::System.IDisposable);
										num = (short)893583360;
										num2 = (int)((global::System.IntPtr)num);
										goto IL_454;
										EndFinally_25:;
									}
									goto IL_4BF;
								case 3:
									if (flag)
									{
										num = (short)1574699014;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_501;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_161;
									}
									continue;
								case 5:
									if (!enumerator2.MoveNext())
									{
										num = (short)900202496;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4BF;
								case 6:
								{
									global::System.Collections.IEnumerator enumerator = node.ChildNodes.GetEnumerator();
									num = (short)120979458;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								goto IL_161;
								IL_4BF:
								keyValuePair = enumerator2.Current;
								num = (short)2046689283;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_501:
								num = (short)1565589509;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_161:
								num = (short)513605633;
								if (num != 0)
								{
								}
								goto IL_501;
							}
							IL_586:
							return flag;
						}
						finally
						{
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto Block_3;
					case 1:
					{
						if (xmlAttribute == null)
						{
							num = (short)350093315;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = true;
						this.FeatureName = xmlAttribute.Value;
						sortedDictionary = new global::System.Collections.Generic.SortedDictionary<int, int>();
						global::System.Collections.IEnumerator enumerator = node.ChildNodes.GetEnumerator();
						num = (short)1705508866;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_599;
					case 3:
						return false;
					}
					goto IL_48;
					Block_3:
					try
					{
						IL_599:
						num = (short)1434845192;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::AcpBusinessLayer.FeatureSection featureSection2;
								int value;
								sortedDictionary.Add(featureSection2.DataTransferOrder, value);
								num = (short)1551958027;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
							{
								global::AcpBusinessLayer.FeatureSection featureSection2;
								if (featureSection2.DataTransferOrder > 0)
								{
									num = (short)1613365248;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 2:
							{
								global::System.Collections.IEnumerator enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)1480065031;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Xml.XmlNode xmlNode2 = (global::System.Xml.XmlNode)enumerator.Current;
								global::System.Xml.XmlAttribute xmlAttribute2 = xmlNode2.Attributes[global::AcpBusinessLayer.UndoRedo.SetValueTask.b("賤菦", a_)];
								num = (short)217776143;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								num = (short)1305870341;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
							{
								int value;
								global::System.Xml.XmlAttribute xmlAttribute2;
								if (int.TryParse(xmlAttribute2.Value, out value))
								{
									num = (short)397213706;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 6:
							{
								global::AcpBusinessLayer.FeatureSection featureSection2;
								if (featureSection2 != null)
								{
									num = (short)362610702;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1056374793;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 7:
								num = (short)992935949;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
								switch (0)
								{
								case 0:
									goto IL_605;
								}
								continue;
							case 9:
								if (fileType == global::AcpCommonLib.XmlFileType.ImpExp)
								{
									num = (short)1110704140;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 10:
							{
								int value;
								global::AcpBusinessLayer.FeatureSection featureSection2 = (global::AcpBusinessLayer.FeatureSection)this[value];
								num = (short)1312358406;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 12:
							{
								global::System.Xml.XmlNode xmlNode2;
								global::AcpCommonLib.Utility.LogMissingXmlNode(xmlNode2);
								num = (short)423428099;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 13:
								goto IL_838;
							case 14:
								num = (short)1853030401;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 15:
							{
								global::System.Xml.XmlAttribute xmlAttribute2;
								if (xmlAttribute2 != null)
								{
									num = (short)198508548;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								flag = false;
								num = (short)45350928;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 16:
								goto IL_6B4;
							}
							IL_7E2:
							num = (short)694812674;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_605:
							goto IL_7E2;
						}
						IL_6B4:
						IL_838:
						goto IL_BD;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_85A;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_847:
							switch (num2)
							{
							case 0:
								if (disposable != null)
								{
									num = (short)1210056706;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_8FF;
							case 1:
							{
								num = (short)1240832258;
								short num4 = num;
								num = (short)469473538;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_89D;
								default:
									goto IL_8E8;
								}
								break;
							}
							case 2:
								disposable.Dispose();
								goto IL_89D;
							}
							goto IL_85A;
							IL_89D:
							num = (short)2018246657;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_8E8:
						num = (short)1500708864;
						if (num != 0)
						{
						}
						IL_8FF:
						goto EndFinally_24;
						IL_85A:
						global::System.Collections.IEnumerator enumerator;
						disposable = (enumerator as global::System.IDisposable);
						num = (short)1084555264;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_847;
						EndFinally_24:;
					}
					return flag;
					IL_BD:
					enumerator2 = sortedDictionary.GetEnumerator();
					num = (short)1070268416;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_48:
				xmlAttribute = node.Attributes[global::AcpBusinessLayer.UndoRedo.SetValueTask.b("ꯤ蛦蓨軪", a_)];
				num = (short)2049507328;
				short num5 = num;
				num = (short)803864577;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0001F9E8 File Offset: 0x0001DBE8
		internal global::AcpCommonLib.IAcpField FieldFromPathHelper(string path, bool absolute, string delimiter)
		{
			short num = (short)870383617;
			if (num != 0)
			{
			}
			num = (short)2119499776;
			short num2 = num;
			global::AcpCommonLib.IAcpField acpField = null;
			global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator = this.FeatureSectionsCollection.GetEnumerator();
			try
			{
				num = (short)1210318853;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_173;
					case 1:
						goto IL_1A8;
					case 2:
						goto IL_18C;
					case 3:
						num = (short)1855062018;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)160366592;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)605624958;
						short num4 = num;
						num = (short)1669274238;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_173;
						default:
							num = (short)1348206592;
							if (num != 0)
							{
							}
							acpField = ((global::AcpBusinessLayer.FeatureSection)enumerator.Current).FieldFromPathHelper(path, absolute, delimiter);
							num = (short)1292238854;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						switch (0)
						{
						case 0:
							goto IL_A2;
						}
						continue;
					case 6:
						if (acpField != null)
						{
							num = (short)1454112771;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					IL_13A:
					num = (short)564133892;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_A2:
					goto IL_13A;
					IL_173:
					num = (short)404488193;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_18C:
				IL_1A8:;
			}
			finally
			{
				num = (short)434110466;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						enumerator.Dispose();
						num = (short)1031733249;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_20E;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_1DB;
						}
						continue;
					}
					IL_1DB:
					if (enumerator == null)
					{
						break;
					}
					num = (short)269221888;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_20E:;
			}
			return acpField;
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x0001FC24 File Offset: 0x0001DE24
		// (set) Token: 0x060001A7 RID: 423 RVA: 0x0001FCD0 File Offset: 0x0001DED0
		[global::System.Xml.Serialization.XmlIgnore]
		public global::AcpCommonLib.IAcpRecordset Parent
		{
			get
			{
				short num = (short)2143300806;
				short num2 = num;
				num = (short)949955782;
				switch (num2 == num)
				{
				}
				num = (short)1411055616;
				if (num != 0)
				{
				}
				num = (short)1659961344;
				short num3 = num;
				num = (short)867237889;
				if (num != 0)
				{
				}
				return this.parent;
			}
			set
			{
				short num = (short)1379732607;
				short num2 = num;
				num = (short)482741375;
				switch (num2 == num)
				{
				}
				num = (short)1038090241;
				if (num != 0)
				{
				}
				num = (short)1919746048;
				short num3 = num;
				num = (short)981401600;
				if (num != 0)
				{
				}
				this.parent = (global::AcpBusinessLayer.Recordset)value;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x0001FD88 File Offset: 0x0001DF88
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x0001FE3C File Offset: 0x0001E03C
		public string FeatureName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)549627732;
				short num2 = num;
				num = (short)470067028;
				switch (num2 == num)
				{
				}
				num = (short)112918528;
				if (num != 0)
				{
				}
				num = (short)1206910976;
				short num3 = num;
				num = (short)549322753;
				if (num != 0)
				{
				}
				return this.<FeatureName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)158990337;
				if (num != 0)
				{
				}
				num = (short)1013037198;
				short num2 = num;
				num = (short)440055950;
				switch (num2 == num)
				{
				}
				num = (short)575406080;
				short num3 = num;
				num = (short)764149760;
				if (num != 0)
				{
				}
				this.<FeatureName>k__BackingField = value;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001AA RID: 426 RVA: 0x0001FEEC File Offset: 0x0001E0EC
		// (set) Token: 0x060001AB RID: 427 RVA: 0x0001FF98 File Offset: 0x0001E198
		public bool Valid
		{
			get
			{
				short num = (short)1941139952;
				short num2 = num;
				num = (short)2030727664;
				switch (num2 == num)
				{
				}
				num = (short)8978432;
				if (num != 0)
				{
				}
				num = (short)2019098624;
				short num3 = num;
				num = (short)1667956737;
				if (num != 0)
				{
				}
				return this.valid;
			}
			internal set
			{
				int a_ = 17;
				short num = (short)331481104;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_36B;
					case 1:
						num = (short)335544323;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (!global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.ContainsField(this))
						{
							num = (short)1864040453;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						if (!global::AcpCommonLib.AppInfoManager.BackgroundDeserializeOpertaion)
						{
							num = (short)747175936;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						goto IL_2FE;
					case 5:
					{
						global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.RegisterFieldInReport(this, global::AcpCommonResources.AcpResources.Extra_Record);
						global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.PostFieldsReport();
						num = (short)512733125;
						short num3 = num;
						num = (short)102019013;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_10C;
						default:
							num = (short)569114624;
							if (num != 0)
							{
							}
							num = (short)464715788;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
					{
						num = (short)1486749696;
						short num4 = num;
						if (this.PropertyChanged != null)
						{
							num = (short)1621360649;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2FE;
					}
					case 7:
						if (value)
						{
							num = (short)2146238472;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)314834958;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)1782579210;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("뗢蓤详胨迪", a_)));
						goto IL_10C;
					case 10:
						if (!global::AcpCommonLib.AppInfoManager.DragOperation)
						{
							num = (short)2096234497;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 11:
						this.valid = value;
						num = (short)2136539137;
						if (num != 0)
						{
						}
						num = (short)564068358;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_2BF;
					case 13:
						if (!global::AcpCommonLib.AppInfoManager.BackgroundDeserializeOpertaion)
						{
							num = (short)1589772305;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 14:
						if (!global::AcpCommonLib.AppInfoManager.DragOperation)
						{
							num = (short)1656946703;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 15:
						num = (short)651427853;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						switch (0)
						{
						case 0:
							goto IL_77;
						}
						continue;
					case 17:
						num = (short)1943535618;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_77:
					if (this.valid != value)
					{
						num = (short)1866137611;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_10C:
					num = (short)6029316;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2FE:
					num = (short)585826311;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2BF:
				return;
				IL_36B:
				global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.UnregisterFieldInReport(this);
				global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.PostFieldsReport();
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001AC RID: 428 RVA: 0x00020318 File Offset: 0x0001E518
		public virtual string ReferenceKey
		{
			get
			{
				short num;
				if (this.KeyField == null)
				{
					for (;;)
					{
						num = (short)2030043137;
						if (num != 0)
						{
						}
						num = (short)969125164;
						short num2 = num;
						num = (short)775269676;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_65;
						}
					}
					IL_65:
					num = (short)1015414784;
					if (num != 0)
					{
					}
					return this.FeatureName;
				}
				num = (short)1008009216;
				short num3 = num;
				return this.KeyField.DisplayText;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001AD RID: 429 RVA: 0x000203DC File Offset: 0x0001E5DC
		public int NodeId
		{
			get
			{
				short num = (short)848676652;
				short num2 = num;
				num = (short)2006042412;
				switch (num2 == num)
				{
				}
				num = (short)2036072448;
				if (num != 0)
				{
				}
				num = (short)1961951232;
				short num3 = num;
				num = (short)2059927553;
				if (num != 0)
				{
				}
				return this.id;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001AE RID: 430 RVA: 0x0002048C File Offset: 0x0001E68C
		// (set) Token: 0x060001AF RID: 431 RVA: 0x0002053C File Offset: 0x0001E73C
		public string UIPagePath
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)968060735;
				short num2 = num;
				num = (short)770666303;
				switch (num2 == num)
				{
				}
				num = (short)123142145;
				if (num != 0)
				{
				}
				num = (short)1428160512;
				short num3 = num;
				num = (short)239468544;
				if (num != 0)
				{
				}
				return this.<UIPagePath>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
				short num = (short)503117835;
				short num2 = num;
				num = (short)1181218827;
				switch (num2 == num)
				{
				}
				num = (short)1612644353;
				if (num != 0)
				{
				}
				num = (short)309985280;
				short num3 = num;
				num = (short)1783234560;
				if (num != 0)
				{
				}
				this.<UIPagePath>k__BackingField = value;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x000205EC File Offset: 0x0001E7EC
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x00020698 File Offset: 0x0001E898
		public string TreeNodeLabel
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)650028925;
				short num2 = num;
				num = (short)364619645;
				switch (num2 == num)
				{
				}
				num = (short)1433206785;
				if (num != 0)
				{
				}
				num = (short)1126563840;
				short num3 = num;
				num = (short)2126381056;
				if (num != 0)
				{
				}
				return this.<TreeNodeLabel>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)431018345;
				short num2 = num;
				num = (short)790286697;
				switch (num2 == num)
				{
				}
				num = (short)658702337;
				if (num != 0)
				{
				}
				num = (short)1830551552;
				short num3 = num;
				num = (short)458227712;
				if (num != 0)
				{
				}
				this.<TreeNodeLabel>k__BackingField = value;
			}
		}

		// Token: 0x1700006D RID: 109
		public global::AcpCommonLib.IAcpFeatureSection this[int id]
		{
			get
			{
				short num;
				if (this.sections.ContainsKey(id))
				{
					for (;;)
					{
						num = (short)1575485441;
						if (num != 0)
						{
						}
						num = (short)1434342110;
						short num2 = num;
						num = (short)1002132190;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_70;
						}
					}
					IL_70:
					num = (short)1587675136;
					if (num != 0)
					{
					}
					return this.sections[id];
				}
				num = (short)479592448;
				short num3 = num;
				return null;
			}
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00020814 File Offset: 0x0001EA14
		public void AddFeatureSection(global::AcpCommonLib.IAcpFeatureSection section)
		{
			short num = (short)431685633;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_53;
			}
			int num2;
			global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator;
			for (;;)
			{
				IL_31:
				switch (num2)
				{
				case 0:
					this.HasEmbeddedRecset = section.HasEmbeddedRecset;
					num = (short)1122172929;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_80;
				case 2:
					return;
				case 3:
					goto IL_3BC;
				case 4:
					if (!this.HasEmbeddedRecset)
					{
						num = (short)535756800;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_80;
				case 5:
					try
					{
						num = (short)1677393930;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::AcpCommonLib.IAcpField acpField;
							switch (num2)
							{
							case 1:
								goto IL_34E;
							case 2:
								num = (short)375980038;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								if (acpField is global::AcpBusinessLayer.AcpKeyField)
								{
									num = (short)1501036546;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 4:
								this.KeyField = (global::AcpBusinessLayer.AcpKeyField)acpField;
								num = (short)508035072;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								goto IL_21B;
							case 6:
								if (this.KeyField == null)
								{
									num = (short)1318780932;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 7:
							{
								if (enumerator.MoveNext())
								{
									acpField = enumerator.Current;
									this.fieldsAll.Add(acpField);
									num = (short)1192558600;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)323273527;
								short num3 = num;
								num = (short)870826807;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_30A;
								default:
									num = (short)661913600;
									if (num != 0)
									{
									}
									num = (short)30539787;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 8:
								if (acpField is global::AcpBusinessLayer.AcpRecRefField)
								{
									num = (short)127139849;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_21B;
							case 9:
								goto IL_30A;
							case 10:
								switch (0)
								{
								case 0:
									goto IL_193;
								}
								continue;
							case 11:
								num = (short)1265172481;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_195:
							num = (short)109576199;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_193:
							goto IL_195;
							IL_21B:
							num = (short)327352323;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_30A:
							this.recRefFields.Add((global::AcpBusinessLayer.AcpRecRefField)acpField);
							num = (short)594870277;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_34E:
						goto IL_100;
					}
					finally
					{
						num = (short)1273167874;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)1402929153;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_3B9;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_385;
								}
								continue;
							}
							IL_385:
							if (enumerator == null)
							{
								break;
							}
							num = (short)130416640;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_3B9:;
					}
					goto IL_3BC;
					IL_100:
					num = (short)752222212;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (section.DataTransferOrder > 0)
					{
						num = (short)1876623363;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				goto IL_53;
				IL_80:
				num = (short)1936523264;
				short num4 = num;
				this.sections[section.FeatureSectionId] = (global::AcpBusinessLayer.FeatureSection)section;
				num = (short)136445958;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3BC:
				this.sectionsByOrder.Add(section.DataTransferOrder, (global::AcpBusinessLayer.FeatureSection)section);
				num = (short)1183842306;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_53:
			section.Parent = this;
			enumerator = section.FieldsCollection.GetEnumerator();
			num = (short)1133117445;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_31;
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x00020C54 File Offset: 0x0001EE54
		public global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpFeatureSection> FeatureSectionsCollection
		{
			get
			{
				short num = (short)2090069760;
				short num2 = num;
				num = (short)1075244800;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1680015360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1327169537;
				if (num != 0)
				{
				}
				num = (short)739377152;
				if (num != 0)
				{
				}
				global::AcpBusinessLayer.FeatureNode.<get_FeatureSectionsCollection>d__80 <get_FeatureSectionsCollection>d__ = new global::AcpBusinessLayer.FeatureNode.<get_FeatureSectionsCollection>d__80(-2);
				<get_FeatureSectionsCollection>d__.<>4__this = this;
				return <get_FeatureSectionsCollection>d__;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x00020D0C File Offset: 0x0001EF0C
		public global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpFeatureSection> FeatureSectionsCollectionByOrder
		{
			get
			{
				short num = (short)1207764625;
				short num2 = num;
				num = (short)21169809;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1989935104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)781647873;
				if (num != 0)
				{
				}
				num = (short)511049728;
				if (num != 0)
				{
				}
				global::AcpBusinessLayer.FeatureNode.<get_FeatureSectionsCollectionByOrder>d__82 <get_FeatureSectionsCollectionByOrder>d__ = new global::AcpBusinessLayer.FeatureNode.<get_FeatureSectionsCollectionByOrder>d__82(-2);
				<get_FeatureSectionsCollectionByOrder>d__.<>4__this = this;
				return <get_FeatureSectionsCollectionByOrder>d__;
			}
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00020DC4 File Offset: 0x0001EFC4
		public void PopulateReferences()
		{
			short num = (short)211554639;
			short num2 = num;
			num = (short)1565331791;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_191;
			case 1:
				break;
			default:
			{
				num = (short)1044971520;
				short num3 = num;
				break;
			}
			}
			num = (short)527433728;
			if (num != 0)
			{
			}
			using (global::System.Collections.Generic.Dictionary<int, global::AcpBusinessLayer.FeatureSection>.ValueCollection.Enumerator enumerator = this.sections.Values.GetEnumerator())
			{
				num = (short)3801091;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						goto IL_181;
					case 1:
					{
						global::AcpBusinessLayer.FeatureSection featureSection;
						((global::AcpBusinessLayer.Recordset)featureSection.EmbeddedRecset).PopulateReferences();
						num = (short)477364228;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						global::AcpBusinessLayer.FeatureSection featureSection;
						if (featureSection.HasEmbeddedRecset)
						{
							num = (short)8912897;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_C8;
						}
						continue;
					case 5:
						num = (short)1386807296;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)423952389;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpBusinessLayer.FeatureSection featureSection = enumerator.Current;
						featureSection.PopulateReferences();
						num = (short)2010775554;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_10A:
					num = (short)959840262;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_C8:
					goto IL_10A;
				}
				IL_181:;
			}
			IL_191:
			num = (short)738066433;
			if (num != 0)
			{
			}
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00020F9C File Offset: 0x0001F19C
		public void DropReferences()
		{
			short num = (short)111516589;
			short num2 = num;
			num = (short)442866605;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			case 1:
				break;
			default:
			{
				num = (short)347734016;
				short num3 = num;
				break;
			}
			}
			num = (short)76546048;
			if (num != 0)
			{
			}
			using (global::System.Collections.Generic.Dictionary<int, global::AcpBusinessLayer.FeatureSection>.ValueCollection.Enumerator enumerator = this.sections.Values.GetEnumerator())
			{
				num = (short)1939734529;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						goto IL_109;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_BF;
						}
						continue;
					case 2:
						num = (short)1175322627;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_157;
					case 4:
						if (!enumerator.MoveNext())
						{
							num = (short)817102850;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator.Current.DropReferences();
						num = (short)1107951616;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_BF;
					IL_109:
					num = (short)353173508;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_BF:
					num = (short)665059329;
					if (num != 0)
					{
					}
					goto IL_109;
				}
				IL_157:;
			}
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00021120 File Offset: 0x0001F320
		public virtual void CalculateValidity()
		{
			short num = (short)1112748194;
			short num2 = num;
			num = (short)729755810;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)660733953;
				if (num != 0)
				{
				}
				num = (short)1409089536;
				if (num != 0)
				{
				}
				using (global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField>.Enumerator enumerator = this.fieldsWithValidity.GetEnumerator())
				{
					num = (short)50659329;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							if (!enumerator.MoveNext())
							{
								num = (short)305856516;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							((global::AcpBusinessLayer.AcpFieldBase)enumerator.Current).CalculateValidity();
							num = (short)1916731394;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_1E0;
							}
							continue;
						case 3:
							goto IL_255;
						case 4:
							num = (short)1277886467;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_1E2:
						num = (short)1545142272;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_1E0:
						goto IL_1E2;
					}
					IL_255:
					goto IL_196;
				}
				break;
				for (;;)
				{
					IL_196:
					global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator2 = this.EmbeddedRecordsets.GetEnumerator();
					try
					{
						num = (short)1470300161;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								if (!enumerator2.MoveNext())
								{
									num = (short)1254227972;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								enumerator2.Current.CalculateValidity();
								num = (short)2116157442;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_BA;
								}
								continue;
							case 3:
								goto IL_129;
							case 4:
								num = (short)155713539;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_BC:
							num = (short)1105526784;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_BA:
							goto IL_BC;
						}
						IL_129:
						break;
					}
					finally
					{
						num = (short)579272704;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_15F;
								}
								continue;
							case 1:
								goto IL_193;
							case 2:
								enumerator2.Dispose();
								num = (short)1146617857;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_15F:
							if (enumerator2 == null)
							{
								break;
							}
							num = (short)2026242050;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_193:;
					}
				}
				break;
			}
			num = (short)1646854144;
			short num4 = num;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x000213DC File Offset: 0x0001F5DC
		public virtual void CalculateApplicability()
		{
			short num = (short)273037089;
			short num2 = num;
			num = (short)18888481;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1224540160;
				if (num != 0)
				{
				}
				num = (short)1261764609;
				if (num != 0)
				{
				}
				using (global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField>.Enumerator enumerator = this.fieldsWithApplicability.GetEnumerator())
				{
					num = (short)1475739649;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							if (!enumerator.MoveNext())
							{
								num = (short)622133252;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							enumerator.Current.CalculateApplicability();
							num = (short)1945042946;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_1E3;
							}
							continue;
						case 3:
							goto IL_254;
						case 4:
							num = (short)1258881027;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_1E5:
						num = (short)542638080;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_1E3:
						goto IL_1E5;
					}
					IL_254:
					goto IL_199;
				}
				break;
				for (;;)
				{
					IL_199:
					global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator2 = this.EmbeddedRecordsets.GetEnumerator();
					try
					{
						num = (short)714473473;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								if (!enumerator2.MoveNext())
								{
									num = (short)1461911556;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								enumerator2.Current.CalculateApplicability();
								num = (short)59310082;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_BA;
								}
								continue;
							case 3:
								goto IL_12C;
							case 4:
								num = (short)489422851;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_BC:
							num = (short)1888616448;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_BA:
							goto IL_BC;
						}
						IL_12C:
						break;
					}
					finally
					{
						num = (short)1379926016;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_162;
								}
								continue;
							case 1:
								goto IL_196;
							case 2:
								enumerator2.Dispose();
								num = (short)497221633;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_162:
							if (enumerator2 == null)
							{
								break;
							}
							num = (short)29687810;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_196:;
					}
				}
				break;
			}
			num = (short)1801846784;
			short num4 = num;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00021698 File Offset: 0x0001F898
		public void CalculateVisibility()
		{
			short num = (short)551614406;
			short num2 = num;
			num = (short)1554970566;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1899692032;
				if (num != 0)
				{
				}
				num = (short)1755119617;
				if (num != 0)
				{
				}
				using (global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField>.Enumerator enumerator = this.fieldsWithVisibility.GetEnumerator())
				{
					num = (short)121896961;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							if (!enumerator.MoveNext())
							{
								num = (short)148111364;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							enumerator.Current.CalculateVisibility();
							num = (short)1337524226;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_1E0;
							}
							continue;
						case 3:
							goto IL_250;
						case 4:
							num = (short)2079326211;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_1E2:
						num = (short)675938304;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_1E0:
						goto IL_1E2;
					}
					IL_250:
					goto IL_197;
				}
				break;
				for (;;)
				{
					IL_197:
					global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator2 = this.EmbeddedRecordsets.GetEnumerator();
					try
					{
						num = (short)490799105;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								if (!enumerator2.MoveNext())
								{
									num = (short)343932932;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								enumerator2.Current.CalculateVisibility();
								num = (short)1967980546;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_BC;
								}
								continue;
							case 3:
								goto IL_12C;
							case 4:
								num = (short)388956163;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_BE:
							num = (short)254214144;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_BC:
							goto IL_BE;
						}
						IL_12C:
						break;
					}
					finally
					{
						num = (short)421789696;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_161;
								}
								continue;
							case 1:
								goto IL_194;
							case 2:
								enumerator2.Dispose();
								num = (short)448724993;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_161:
							if (enumerator2 == null)
							{
								break;
							}
							num = (short)166199298;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_194:;
					}
				}
				break;
			}
			num = (short)1852243968;
			short num4 = num;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00021950 File Offset: 0x0001FB50
		public void CalculateEditability()
		{
			using (global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField>.Enumerator enumerator = this.fieldsWithEditability.GetEnumerator())
			{
				short num = (short)856752129;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 1:
						switch (0)
						{
						case 0:
							goto IL_204;
						}
						continue;
					case 2:
						goto IL_274;
					case 3:
						if (!enumerator.MoveNext())
						{
							num = (short)1649410052;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator.Current.CalculateEditability();
						num = (short)616497152;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)1175060482;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_206:
					num = (short)1714290691;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_204:
					goto IL_206;
				}
				IL_274:
				goto IL_16C;
			}
			return;
			for (;;)
			{
				IL_16C:
				short num = (short)1434058753;
				if (num != 0)
				{
				}
				num = (short)160366592;
				short num3 = num;
				global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator2 = this.EmbeddedRecordsets.GetEnumerator();
				try
				{
					num = (short)579665921;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 1:
							switch (0)
							{
							case 0:
								goto IL_49;
							}
							continue;
						case 2:
							goto IL_B5;
						case 3:
							if (!enumerator2.MoveNext())
							{
								num = (short)562298884;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							enumerator2.Current.CalculateEditability();
							num = (short)1454374912;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							num = (short)338100226;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_4B:
						num = (short)847970307;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_49:
						goto IL_4B;
					}
					IL_B5:
					break;
				}
				finally
				{
					num = (short)1708982273;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_169;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_EA;
							}
							continue;
						case 2:
							goto IL_14A;
						}
						IL_EA:
						num = (short)1754399908;
						short num4 = num;
						num = (short)933889188;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_14A:
							enumerator2.Dispose();
							num = (short)401670144;
							num2 = (int)((global::System.IntPtr)num);
							break;
						default:
							num = (short)1656094720;
							if (num != 0)
							{
							}
							if (enumerator2 == null)
							{
								goto IL_16B;
							}
							num = (short)1967194114;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					IL_169:
					IL_16B:;
				}
			}
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00021C00 File Offset: 0x0001FE00
		public void CalculateVisibility(bool allFields)
		{
			short num = (short)1679360000;
			short num2 = num;
			num = (short)548208641;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator = this.FeatureSectionsCollection.GetEnumerator();
			try
			{
				num = (short)1915879425;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						num = (short)509411330;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_97;
						}
						continue;
					case 2:
						goto IL_106;
					case 4:
						if (!enumerator.MoveNext())
						{
							num = (short)1251475456;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator.Current.CalculateVisibility(allFields);
						num = (short)1026359299;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_BC:
					num = (short)1368719364;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_97:
					goto IL_BC;
				}
				IL_106:;
			}
			finally
			{
				num = (short)1768882177;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_1BD;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_13C;
						}
						continue;
					case 2:
						goto IL_19E;
					}
					IL_13C:
					num = (short)1553902233;
					short num4 = num;
					num = (short)1358736025;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_19E:
						enumerator.Dispose();
						num = (short)611123200;
						num3 = (int)((global::System.IntPtr)num);
						break;
					default:
						num = (short)1053097984;
						if (num != 0)
						{
						}
						if (enumerator == null)
						{
							goto IL_1BF;
						}
						num = (short)545456130;
						num3 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_1BD:
				IL_1BF:;
			}
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00021DE0 File Offset: 0x0001FFE0
		public void CalculateEditability(bool allFields)
		{
			short num = (short)1930199358;
			short num2 = num;
			num = (short)1866367294;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			case 1:
				break;
			default:
			{
				num = (short)230948864;
				short num3 = num;
				break;
			}
			}
			num = (short)1451294720;
			if (num != 0)
			{
			}
			num = (short)594477057;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator = this.FeatureSectionsCollection.GetEnumerator();
			try
			{
				num = (short)1097990145;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 1:
						switch (0)
						{
						case 0:
							goto IL_E1;
						}
						continue;
					case 2:
						num = (short)1863778308;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (!enumerator.MoveNext())
						{
							num = (short)1304231938;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator.Current.CalculateEditability(allFields);
						num = (short)605487104;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_152;
					}
					IL_106:
					num = (short)158531587;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_E1:
					goto IL_106;
				}
				IL_152:;
			}
			finally
			{
				num = (short)663552000;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_185;
						}
						continue;
					case 1:
						enumerator.Dispose();
						num = (short)378077186;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_1B8;
					}
					IL_185:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1759707137;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_1B8:;
			}
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00021FB8 File Offset: 0x000201B8
		private void a(object A_0, global::AcpBusinessLayer.DifferenceCountChangedEventArgs A_1)
		{
			int a_ = 18;
			short num = (short)1361510405;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)20709377;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (this.DiffCount.Value == 0)
					{
						num = (short)1318846466;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					IL_108:
					((global::AcpBusinessLayer.Recordset)this.Parent).DiffCount.Decrement(this.FeatureName);
					this.a(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("믣껥觧駩꣫蟭雯铱蟳", a_));
					num = (short)961019912;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_1DA;
				case 4:
					num = (short)939130886;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_51;
					}
					continue;
				case 6:
					if (this.DiffCount.Value == 1)
					{
						num = (short)1157300227;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_10D;
				case 7:
					if (A_1.Action == global::AcpBusinessLayer.DifferenceCountChangedAction.Decrement)
					{
						num = (short)1902706688;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 8:
					return;
				}
				IL_51:
				num = (short)535101441;
				if (num != 0)
				{
				}
				if (A_1.Action == global::AcpBusinessLayer.DifferenceCountChangedAction.Increment)
				{
					num = (short)603914240;
					short num3 = num;
					num = (short)1560936452;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_10D:
				num = (short)896823158;
				short num4 = num;
				num = (short)1313042294;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_108;
				default:
					num = (short)304349184;
					if (num != 0)
					{
					}
					num = (short)1564999687;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_1DA:
			((global::AcpBusinessLayer.Recordset)this.Parent).DiffCount.Increment(this.FeatureName);
			this.a(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("믣껥觧駩꣫蟭雯铱蟳", a_));
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001BF RID: 447 RVA: 0x0002221C File Offset: 0x0002041C
		internal global::AcpBusinessLayer.DifferenceCount DiffCount
		{
			get
			{
				short num = (short)1804769828;
				short num2 = num;
				num = (short)675453476;
				switch (num2 == num)
				{
				default:
				{
					num = (short)935788544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1210056705;
				if (num != 0)
				{
				}
				num = (short)448462848;
				if (num != 0)
				{
				}
				return this.diffCount;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x000222CC File Offset: 0x000204CC
		public bool _HasDiffs
		{
			get
			{
				short num = (short)1114977670;
				short num2 = num;
				num = (short)1992570246;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1856372736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)677052417;
				if (num != 0)
				{
				}
				num = (short)401014784;
				if (num != 0)
				{
				}
				return this.DiffCount.Value > 0;
			}
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00022384 File Offset: 0x00020584
		public void ClearHasDiffs()
		{
			short num = (short)1704312404;
			short num2 = num;
			num = (short)1854914132;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_1BB;
			case 1:
				break;
			default:
			{
				num = (short)71106560;
				short num3 = num;
				break;
			}
			}
			num = (short)219414529;
			if (num != 0)
			{
			}
			num = (short)2094727168;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator = this.FeatureSectionsCollection.GetEnumerator();
			try
			{
				num = (short)573898753;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 1:
						switch (0)
						{
						case 0:
							goto IL_E3;
						}
						continue;
					case 2:
						num = (short)719716356;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (!enumerator.MoveNext())
						{
							num = (short)964165634;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator.Current.ClearHasDiffs();
						num = (short)1964638208;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_151;
					}
					IL_106:
					num = (short)297664515;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_E3:
					goto IL_106;
				}
				IL_151:;
			}
			finally
			{
				num = (short)1005256704;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_183;
						}
						continue;
					case 1:
						enumerator.Dispose();
						num = (short)113901570;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_1B8;
					}
					IL_183:
					if (enumerator == null)
					{
						break;
					}
					num = (short)480837633;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_1B8:;
			}
			IL_1BB:
			this.DiffCount.Reset(this.FeatureName);
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x00022570 File Offset: 0x00020770
		public bool HasVisibleObjects
		{
			get
			{
				short num = (short)1788743876;
				short num2 = num;
				num = (short)994250948;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return false;
				case 1:
					break;
				default:
				{
					num = (short)1016004608;
					short num3 = num;
					break;
				}
				}
				num = (short)1074462720;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator = this.FeatureSectionsCollection.GetEnumerator();
				bool result;
				try
				{
					num = (short)737345539;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							if (!enumerator.MoveNext())
							{
								num = (short)1832583169;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1588330501;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							num = (short)155254785;
							if (num != 0)
							{
							}
							num = (short)1090060294;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_14C;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_C4;
							}
							continue;
						case 4:
							result = true;
							num = (short)530513922;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							if (enumerator.Current.HasVisibleObjects)
							{
								num = (short)1542455300;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 6:
							goto IL_191;
						}
						IL_C6:
						num = (short)1873608704;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_C4:
						goto IL_C6;
					}
					IL_14C:
					return result;
					IL_191:
					return false;
				}
				finally
				{
					num = (short)869990400;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_1C6;
							}
							continue;
						case 1:
							enumerator.Dispose();
							num = (short)362217474;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_1F9;
						}
						IL_1C6:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1903099905;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_1F9:;
				}
				return result;
			}
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00022798 File Offset: 0x00020998
		public virtual void CallConstraints()
		{
			short num = (short)53034403;
			short num2 = num;
			num = (short)335363491;
			switch (num2 == num)
			{
			}
			num = (short)163250176;
			short num3 = num;
			num = (short)1230372865;
			if (num != 0)
			{
			}
			num = (short)526843904;
			if (num != 0)
			{
			}
			this.CalculateVisibility(true);
			this.CalculateEditability();
			this.CalculateApplicability();
			this.CalculateValidity();
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0002285C File Offset: 0x00020A5C
		public global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpField> Search(string token)
		{
			short num = (short)1891655459;
			short num2 = num;
			num = (short)1050435363;
			switch (num2 == num)
			{
			}
			num = (short)1710948352;
			short num3 = num;
			num = (short)541720576;
			if (num != 0)
			{
			}
			num = (short)625213441;
			if (num != 0)
			{
			}
			return this.a(token, false);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00022910 File Offset: 0x00020B10
		public global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpField> SearchAll(string token)
		{
			short num = (short)1638328344;
			short num2 = num;
			num = (short)765061144;
			switch (num2 == num)
			{
			}
			num = (short)1443758080;
			short num3 = num;
			num = (short)1327235073;
			if (num != 0)
			{
			}
			num = (short)636485632;
			if (num != 0)
			{
			}
			return this.a(token, true);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x000229C0 File Offset: 0x00020BC0
		private global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpField> a(string A_0, bool A_1)
		{
			short num = (short)1428488193;
			if (num != 0)
			{
			}
			num = (short)903497360;
			short num2 = num;
			num = (short)1702643344;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1158348800;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1473380352;
			if (num != 0)
			{
			}
			global::AcpBusinessLayer.FeatureNode.<SearchConditionally>d__102 <SearchConditionally>d__ = new global::AcpBusinessLayer.FeatureNode.<SearchConditionally>d__102(-2);
			<SearchConditionally>d__.<>4__this = this;
			<SearchConditionally>d__.<>3__token = A_0;
			<SearchConditionally>d__.<>3__searchHiddenStatic = A_1;
			return <SearchConditionally>d__;
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x00022A88 File Offset: 0x00020C88
		// (set) Token: 0x060001C8 RID: 456 RVA: 0x00022B48 File Offset: 0x00020D48
		public string UIName
		{
			get
			{
				short num;
				for (;;)
				{
					num = (short)615907329;
					if (num != 0)
					{
					}
					if (this.uiName != null)
					{
						goto IL_83;
					}
					num = (short)962058818;
					short num2 = num;
					num = (short)471521858;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_65;
					}
				}
				IL_65:
				num = (short)1551040512;
				if (num != 0)
				{
				}
				return this.FeatureName;
				IL_83:
				num = (short)1957822464;
				short num3 = num;
				return this.uiName;
			}
			set
			{
				short num = (short)1635310906;
				short num2 = num;
				num = (short)354606394;
				switch (num2 == num)
				{
				}
				num = (short)1524170752;
				short num3 = num;
				num = (short)564527105;
				if (num != 0)
				{
				}
				num = (short)386859008;
				if (num != 0)
				{
				}
				this.uiName = value;
			}
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00022BFC File Offset: 0x00020DFC
		public virtual void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 6;
			switch (0)
			{
			case 0:
				goto IL_29;
			}
			int num;
			int num2;
			short num3;
			global::AcpBusinessLayer.FeatureSection[] array;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (num2 >= this.sections.Count)
					{
						num3 = (short)1703018497;
						if (num3 != 0)
						{
						}
						num3 = (short)500891651;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					info.AddValue(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("诗뿙뿛ꫝ觟跡諣", a_) + num2.ToString(), array[num2], typeof(global::AcpBusinessLayer.FeatureSection));
					num2++;
					goto IL_180;
				case 1:
					goto IL_A0;
				case 2:
					goto IL_A0;
				case 3:
					return;
				}
				goto IL_29;
				IL_A0:
				num3 = (short)1603660469;
				short num4 = num3;
				num3 = (short)1248062133;
				switch ((num4 == num3) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_180:
					num3 = (short)1837301760;
					short num5 = num3;
					num3 = (short)727318530;
					num = (int)((global::System.IntPtr)num3);
					break;
				}
				default:
					num3 = (short)2120876032;
					if (num3 != 0)
					{
					}
					num3 = (short)2031353856;
					num = (int)((global::System.IntPtr)num3);
					break;
				}
			}
			return;
			IL_29:
			info.AddValue(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("黗뿙뷛ꫝ闟郡臣꣥觧蟩觫", a_), this.FeatureName);
			info.AddValue(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("诗뿙뿛ꫝ觟跡諣ꗥ蟧鿩苫髭", a_), this.sections.Count);
			array = new global::AcpBusinessLayer.FeatureSection[this.sections.Count];
			this.sections.Values.CopyTo(array, 0);
			num2 = 0;
			num3 = (short)1442119681;
			num = (int)((global::System.IntPtr)num3);
			goto IL_13;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00022DD0 File Offset: 0x00020FD0
		protected FeatureNode(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 0;
			this..ctor(null);
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("믑뫓냕럗", a_));
			}
			this.FeatureName = info.GetString(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("铑뇓럕곗꿙껛믝껟菡解菥", a_));
			int @int = info.GetInt32(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("臑뇓뗕곗동돛냝ꏟ跡釣裥鳧", a_));
			for (int i = 0; i < @int; i++)
			{
				for (;;)
				{
					try
					{
						this.AddFeatureSection((global::AcpBusinessLayer.FeatureSection)info.GetValue(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("臑뇓뗕곗동돛냝", a_) + i.ToString(), typeof(global::AcpBusinessLayer.FeatureSection)));
						break;
					}
					catch (global::System.InvalidCastException)
					{
						break;
					}
					catch (global::System.Runtime.Serialization.SerializationException)
					{
						break;
					}
				}
			}
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00022EA4 File Offset: 0x000210A4
		public void ResetToDefault()
		{
			short num = (short)334463161;
			short num2 = num;
			num = (short)229081273;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1933377536;
				short num3 = num;
				num = (short)369360897;
				if (num != 0)
				{
				}
				num = (short)749797376;
				if (num != 0)
				{
				}
				using (global::System.Collections.Generic.Dictionary<int, global::AcpBusinessLayer.FeatureSection>.ValueCollection.Enumerator enumerator = this.sections.Values.GetEnumerator())
				{
					num = (short)233177089;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							if (!enumerator.MoveNext())
							{
								num = (short)440139780;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							((global::AcpCommonLib.IAcpCommon)enumerator.Current).ResetToDefault();
							num = (short)1834942466;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_E7;
							}
							continue;
						case 3:
							goto IL_157;
						case 4:
							num = (short)1990590467;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_10B:
						num = (short)299827200;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_E7:
						goto IL_10B;
					}
					IL_157:;
				}
				break;
			}
			}
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00023028 File Offset: 0x00021228
		public string Path(string delimiter)
		{
			short num = (short)1758855169;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1786321447;
					short num3 = num;
					num = (short)1768299047;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_10F;
					default:
						num = (short)866582529;
						if (num != 0)
						{
						}
						num = (short)616824832;
						if (num != 0)
						{
						}
						num = (short)1810497539;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 2:
					goto IL_14F;
				case 3:
					if (!this.Parent.SingleInstance)
					{
						goto IL_10F;
					}
					goto IL_C4;
				}
				IL_34:
				if (this.Parent != null)
				{
					num = (short)217448448;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_151;
				IL_10F:
				num = (short)1649213440;
				short num4 = num;
				num = (short)1034289154;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_C4:
			return this.Parent.Path(delimiter);
			IL_14F:
			return this.Parent.Path(delimiter) + delimiter + this.ReferenceKey;
			IL_151:
			return this.ReferenceKey;
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001CD RID: 461 RVA: 0x0002318C File Offset: 0x0002138C
		public global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpField> AllFields
		{
			get
			{
				short num = (short)66111215;
				short num2 = num;
				num = (short)2105525999;
				switch (num2 == num)
				{
				}
				num = (short)1647247360;
				short num3 = num;
				num = (short)1532166145;
				if (num != 0)
				{
				}
				num = (short)1948778496;
				if (num != 0)
				{
				}
				global::AcpBusinessLayer.FeatureNode.<get_AllFields>d__111 <get_AllFields>d__ = new global::AcpBusinessLayer.FeatureNode.<get_AllFields>d__111(-2);
				<get_AllFields>d__.<>4__this = this;
				return <get_AllFields>d__;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001CE RID: 462 RVA: 0x00023248 File Offset: 0x00021448
		public global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpRecordset> EmbeddedRecordsets
		{
			get
			{
				short num = (short)1556152321;
				if (num != 0)
				{
				}
				num = (short)2079240700;
				short num2 = num;
				num = (short)299872764;
				switch (num2 == num)
				{
				default:
				{
					num = (short)656736256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)824115200;
				if (num != 0)
				{
				}
				global::AcpBusinessLayer.FeatureNode.<get_EmbeddedRecordsets>d__113 <get_EmbeddedRecordsets>d__ = new global::AcpBusinessLayer.FeatureNode.<get_EmbeddedRecordsets>d__113(-2);
				<get_EmbeddedRecordsets>d__.<>4__this = this;
				return <get_EmbeddedRecordsets>d__;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001CF RID: 463 RVA: 0x00023300 File Offset: 0x00021500
		internal int FieldsCount
		{
			get
			{
				short num = (short)944848275;
				short num2 = num;
				num = (short)145374611;
				switch (num2 == num)
				{
				}
				num = (short)549912576;
				short num3 = num;
				num = (short)1830551552;
				if (num != 0)
				{
				}
				num = (short)854523905;
				if (num != 0)
				{
				}
				return this.fieldsAll.Count;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x000233B4 File Offset: 0x000215B4
		public global::System.Collections.Generic.IEnumerable<global::AcpBusinessLayer.FeatureNode> ReferencingNodes
		{
			get
			{
				short num = (short)1915016053;
				short num2 = num;
				num = (short)249090933;
				switch (num2 == num)
				{
				}
				num = (short)1457192960;
				short num3 = num;
				num = (short)1609039873;
				if (num != 0)
				{
				}
				num = (short)751501312;
				if (num != 0)
				{
				}
				global::AcpBusinessLayer.FeatureNode.<get_ReferencingNodes>d__117 <get_ReferencingNodes>d__ = new global::AcpBusinessLayer.FeatureNode.<get_ReferencingNodes>d__117(-2);
				<get_ReferencingNodes>d__.<>4__this = this;
				return <get_ReferencingNodes>d__;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x0002346C File Offset: 0x0002166C
		public int SectionCount
		{
			get
			{
				short num = (short)1216872449;
				if (num != 0)
				{
				}
				num = (short)1428871873;
				short num2 = num;
				num = (short)1085070017;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1220804608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1646395392;
				if (num != 0)
				{
				}
				return this.sections.Count;
			}
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00023520 File Offset: 0x00021720
		public void RepairRecRefs()
		{
			short num = (short)1344907628;
			short num2 = num;
			num = (short)973056364;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1245052928;
				short num3 = num;
				num = (short)219414529;
				if (num != 0)
				{
				}
				num = (short)1452212224;
				if (num != 0)
				{
				}
				using (global::System.Collections.Generic.Dictionary<int, global::AcpBusinessLayer.FeatureSection>.ValueCollection.Enumerator enumerator = this.sections.Values.GetEnumerator())
				{
					num = (short)2008285185;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							if (!enumerator.MoveNext())
							{
								num = (short)1260322820;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							enumerator.Current.RepairRecRefs();
							num = (short)69533698;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_E8;
							}
							continue;
						case 3:
							goto IL_158;
						case 4:
							num = (short)1375535107;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_10C:
						num = (short)225116160;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_E8:
						goto IL_10C;
					}
					IL_158:;
				}
				break;
			}
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x000236A8 File Offset: 0x000218A8
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x00023828 File Offset: 0x00021A28
		public int Position
		{
			get
			{
				short num = (short)1010040833;
				int num2 = (int)((global::System.IntPtr)num);
				int num3;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_122;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_38;
						}
						continue;
					case 2:
						return 0;
					case 3:
						num3 = ((global::AcpBusinessLayer.Recordset)this.Parent).Count;
						goto IL_6A;
					case 4:
						if (num3 < 0)
						{
							num = (short)1928527873;
							if (num != 0)
							{
							}
							num = (short)872677376;
							short num4 = num;
							num = (short)1302593539;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_122;
					}
					IL_38:
					if (this.Parent == null)
					{
						num = (short)705429506;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num3 = ((global::AcpBusinessLayer.Recordset)this.Parent).IndexOf(this);
					num = (short)1871970308;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6A:
					num = (short)2005991424;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_122:
					num = (short)439174942;
					short num5 = num;
					num = (short)345458462;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6A;
					default:
						goto IL_158;
					}
				}
				return 0;
				IL_158:
				num = (short)248709120;
				if (num != 0)
				{
				}
				return num3 + 1;
			}
			set
			{
				short num = (short)1908211721;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					int num3;
					switch (num2)
					{
					case 0:
						goto IL_276;
					case 1:
						goto IL_179;
					case 2:
						goto IL_1E3;
					case 3:
						goto IL_20E;
					case 4:
						if (num3 >= this.Parent.Count)
						{
							num = (short)1891041290;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E3;
					case 5:
						if (global::AcpCommonLib.UndoRedo.UndoManager.MarkForUndo)
						{
							num = (short)166395910;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
						num3 = value - 1;
						num = (short)170983428;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_79;
					case 8:
						goto IL_2C0;
					case 9:
						switch (0)
						{
						case 0:
							goto IL_5C;
						}
						continue;
					case 10:
						num3 = this.Parent.Count - 1;
						num = (short)1891565570;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						num = (short)1989491056;
						short num4 = num;
						num = (short)382286192;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_79;
						default:
							num = (short)575733760;
							if (num != 0)
							{
							}
							if (value == this.Position)
							{
								num = (short)253558785;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1745027085;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 12:
					{
						int count;
						if (value > count)
						{
							num = (short)2135228424;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1236729857;
						if (num != 0)
						{
						}
						num = (short)1768947717;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
					{
						if (value <= 0)
						{
							num = (short)1832255488;
							short num5 = num;
							num = (short)929431552;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int count = ((global::AcpBusinessLayer.Recordset)this.Parent).Count;
						num = (short)1357905932;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_5C:
					if (this.Parent != null)
					{
						num = (short)1559494663;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_79:
					num = (short)386924555;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E3:
					this.parent.MoveRecord(this.Position - 1, num3);
					num = (short)1173880835;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_179:
				return;
				IL_20E:
				return;
				IL_276:
				this.RaisePositionChanged();
				return;
				IL_2C0:
				this.RaisePositionChanged();
			}
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00023AFC File Offset: 0x00021CFC
		private void a(string A_0)
		{
			short num = (short)39976960;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 1:
				{
					this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(A_0));
					num = (short)1400438784;
					short num3 = num;
					num = (short)94371842;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					return;
				}
				IL_31:
				num = (short)1496645633;
				if (num != 0)
				{
				}
				if (this.PropertyChanged == null)
				{
					break;
				}
				num = (short)113264173;
				short num4 = num;
				num = (short)12600877;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
					num = (short)769064960;
					if (num != 0)
					{
					}
					num = (short)1332084737;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00023C28 File Offset: 0x00021E28
		internal void RaisePositionChanged()
		{
			int a_ = 10;
			short num = (short)1031838957;
			short num2 = num;
			num = (short)979148013;
			switch (num2 == num)
			{
			}
			num = (short)302055424;
			short num3 = num;
			num = (short)832045057;
			if (num != 0)
			{
			}
			num = (short)229113856;
			if (num != 0)
			{
			}
			this.a(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("賛뇝鏟诡郣迥蟧蓩", a_));
			this.OnPositionChanged();
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00023CF4 File Offset: 0x00021EF4
		protected virtual void OnPositionChanged()
		{
			short num = (short)237024260;
			short num2 = num;
			num = (short)713864196;
			switch (num2 == num)
			{
			}
			num = (short)13697024;
			short num3 = num;
			num = (short)1861812224;
			if (num != 0)
			{
			}
			num = (short)1427439617;
			if (num != 0)
			{
			}
			this.InvokeRecRefValidities();
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x00023DA4 File Offset: 0x00021FA4
		public global::System.Collections.Generic.IEnumerable<global::AcpBusinessLayer.AcpRecRefField> RecRefFields
		{
			get
			{
				short num = (short)1750215987;
				short num2 = num;
				num = (short)96808243;
				switch (num2 == num)
				{
				}
				num = (short)1523908609;
				if (num != 0)
				{
				}
				num = (short)1379926016;
				if (num != 0)
				{
				}
				num = (short)826540032;
				short num3 = num;
				global::AcpBusinessLayer.FeatureNode.<get_RecRefFields>d__128 <get_RecRefFields>d__ = new global::AcpBusinessLayer.FeatureNode.<get_RecRefFields>d__128(-2);
				<get_RecRefFields>d__.<>4__this = this;
				return <get_RecRefFields>d__;
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060001D9 RID: 473 RVA: 0x00023E5C File Offset: 0x0002205C
		// (remove) Token: 0x060001DA RID: 474 RVA: 0x00023F90 File Offset: 0x00022190
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				int num;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				short num2;
				switch (0)
				{
				case 0:
					break;
				default:
					for (;;)
					{
						IL_0A:
						global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
						switch (num)
						{
						case 0:
							return;
						case 1:
							if (propertyChangedEventHandler == propertyChangedEventHandler2)
							{
								num2 = (short)2018902016;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_D5;
						case 2:
						{
							num2 = (short)1521723374;
							short num3 = num2;
							num2 = (short)1609738222;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_23;
							default:
								num2 = (short)1065943040;
								if (num2 != 0)
								{
								}
								num2 = (short)734658561;
								if (num2 != 0)
								{
								}
								goto IL_D5;
							}
							break;
						}
						}
						goto IL_1C;
						IL_D5:
						propertyChangedEventHandler2 = propertyChangedEventHandler;
						global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Combine(propertyChangedEventHandler2, value);
						propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
						num2 = (short)1422196737;
						num = (int)((global::System.IntPtr)num2);
					}
					return;
				}
				IL_1C:
				propertyChangedEventHandler = this.PropertyChanged;
				IL_23:
				num2 = (short)794165248;
				short num4 = num2;
				num2 = (short)182124546;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				int num;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				short num2;
				switch (0)
				{
				case 0:
					break;
				default:
					for (;;)
					{
						IL_0A:
						global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
						switch (num)
						{
						case 0:
							return;
						case 1:
							if (propertyChangedEventHandler == propertyChangedEventHandler2)
							{
								num2 = (short)796590081;
								if (num2 != 0)
								{
								}
								num2 = (short)672333824;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_AC;
						case 2:
						{
							num2 = (short)1358679775;
							short num3 = num2;
							num2 = (short)868077279;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_23;
							default:
								num2 = (short)674627584;
								if (num2 != 0)
								{
								}
								goto IL_AC;
							}
							break;
						}
						}
						goto IL_1C;
						IL_AC:
						propertyChangedEventHandler2 = propertyChangedEventHandler;
						global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Remove(propertyChangedEventHandler2, value);
						propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
						num2 = (short)2147352577;
						num = (int)((global::System.IntPtr)num2);
					}
					return;
				}
				IL_1C:
				propertyChangedEventHandler = this.PropertyChanged;
				IL_23:
				num2 = (short)912064512;
				short num4 = num2;
				num2 = (short)170131458;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001DB RID: 475 RVA: 0x000240C4 File Offset: 0x000222C4
		// (set) Token: 0x060001DC RID: 476 RVA: 0x00024170 File Offset: 0x00022370
		public global::AcpCommonLib.Permissions Permissions
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2090763607;
				short num2 = num;
				num = (short)89163095;
				switch (num2 == num)
				{
				}
				num = (short)1966473216;
				if (num != 0)
				{
				}
				num = (short)1165819905;
				if (num != 0)
				{
				}
				num = (short)1349386240;
				short num3 = num;
				return this.<Permissions>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)936993249;
				short num2 = num;
				num = (short)2008310241;
				switch (num2 == num)
				{
				}
				num = (short)155254785;
				if (num != 0)
				{
				}
				num = (short)1318125568;
				if (num != 0)
				{
				}
				num = (short)927072256;
				short num3 = num;
				this.<Permissions>k__BackingField = value;
			}
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00024220 File Offset: 0x00022420
		protected virtual void Dispose(bool disposing)
		{
			short num = (short)237633538;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (!this.disposedValue)
					{
						num = (short)752877578;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_27C;
				case 1:
					goto IL_25C;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_58;
					}
					continue;
				case 3:
				{
					this.isDisposeInProgress = true;
					this.a();
					num = (short)1113137848;
					short num3 = num;
					num = (short)1079190200;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_7A;
					default:
						num = (short)1422196736;
						if (num != 0)
						{
						}
						num = (short)1902182406;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					goto IL_27A;
				case 5:
					goto IL_7A;
				case 6:
				{
					global::AcpBusinessLayer.DifferenceCount differenceCount = this.diffCount;
					if (differenceCount == null)
					{
						num = (short)2099511301;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					differenceCount.Dispose();
					num = (short)1112342529;
					if (num != 0)
					{
					}
					num = (short)1856962569;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
					if (disposing)
					{
						num = (short)2097807363;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_25C;
				case 8:
				{
					global::AcpBusinessLayer.AcpKeyField keyField = this.KeyField;
					if (keyField == null)
					{
						num = (short)439877633;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					keyField.Dispose();
					num = (short)1456537611;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
					goto IL_7A;
				case 10:
					num = (short)146669575;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
				{
					num = (short)1082458112;
					short num4 = num;
					goto IL_25C;
				}
				case 12:
					return;
				}
				IL_58:
				if (this.isDisposeInProgress)
				{
					num = (short)1616838668;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)951517184;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_7A:
				num = (short)167772168;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_25C:
				this.disposedValue = true;
				num = (short)1529610244;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_27A:
			IL_27C:
			this.isDisposeInProgress = false;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x000244B0 File Offset: 0x000226B0
		private void a()
		{
			short num = (short)1488060421;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator2;
			for (;;)
			{
				global::System.Collections.Generic.Dictionary<int, global::AcpBusinessLayer.FeatureSection>.Enumerator enumerator;
				switch (num2)
				{
				case 0:
					goto IL_1F2;
				case 1:
					try
					{
						num = (short)653197318;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::System.Collections.Generic.KeyValuePair<int, global::AcpBusinessLayer.FeatureSection> keyValuePair;
								global::AcpBusinessLayer.FeatureSection value = keyValuePair.Value;
								if (value == null)
								{
									num = (short)1274281988;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								value.Dispose();
								num = (short)247267331;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1414135813;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Collections.Generic.KeyValuePair<int, global::AcpBusinessLayer.FeatureSection> keyValuePair = enumerator.Current;
								num = (short)1644494848;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								goto IL_1DF;
							case 5:
								num = (short)816054274;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								switch (0)
								{
								case 0:
									goto IL_12F;
								}
								continue;
							}
							IL_15A:
							num = (short)948895745;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_12F:
							goto IL_15A;
						}
						IL_1DF:
						goto IL_B0;
					}
					finally
					{
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_1F2;
				case 2:
					enumerator2 = this.EmbeddedRecordsets.GetEnumerator();
					num = (short)316342275;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_81;
				case 4:
					if (this.EmbeddedRecordsets != null)
					{
						num = (short)1733754882;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_3E;
					}
					continue;
				}
				IL_3E:
				if (this.sections != null)
				{
					num = (short)994967552;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_B0:
				num = (short)2092433412;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1F2:
				num = (short)249430017;
				if (num != 0)
				{
				}
				enumerator = this.sections.GetEnumerator();
				num = (short)1340473345;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_81:
			num = (short)1734606848;
			short num3 = num;
			try
			{
				num = (short)439943174;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (!enumerator2.MoveNext())
						{
							num = (short)1330577409;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1622016005;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)1421541378;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_32B;
					case 5:
					{
						global::AcpCommonLib.IAcpRecordset acpRecordset = enumerator2.Current;
						if (acpRecordset == null)
						{
							num = (short)943194115;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						acpRecordset.Dispose();
						num = (short)1076559876;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						switch (0)
						{
						case 0:
							goto IL_283;
						}
						continue;
					}
					IL_285:
					num = (short)1859715072;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_283:
					goto IL_285;
				}
				IL_32B:;
			}
			finally
			{
				for (;;)
				{
					IL_330:
					num = (short)1730936834;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_3E5;
						case 1:
						{
							enumerator2.Dispose();
							num = (short)664217634;
							short num4 = num;
							num = (short)1639655458;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_330;
							default:
								num = (short)1783758848;
								if (num != 0)
								{
								}
								num = (short)2113732608;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_361;
							}
							continue;
						}
						IL_361:
						if (enumerator2 == null)
						{
							goto IL_3E7;
						}
						num = (short)2025717761;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_3E5:
				IL_3E7:;
			}
		}

		// Token: 0x060001DF RID: 479 RVA: 0x000248C4 File Offset: 0x00022AC4
		public void Dispose()
		{
			short num = (short)1755734501;
			short num2 = num;
			num = (short)2115527141;
			switch (num2 == num)
			{
			}
			num = (short)851443713;
			if (num != 0)
			{
			}
			num = (short)776273920;
			if (num != 0)
			{
			}
			num = (short)2048262144;
			short num3 = num;
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0400004B RID: 75
		private global::AcpBusinessLayer.Recordset parent;

		// Token: 0x0400004C RID: 76
		private int id;

		// Token: 0x0400004D RID: 77
		private global::AcpBusinessLayer.DifferenceCount diffCount;

		// Token: 0x0400004E RID: 78
		internal global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField> fieldsAll;

		// Token: 0x0400004F RID: 79
		internal global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField> fieldsWithValidity;

		// Token: 0x04000050 RID: 80
		internal global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField> fieldsWithApplicability;

		// Token: 0x04000051 RID: 81
		internal global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField> fieldsWithEditability;

		// Token: 0x04000052 RID: 82
		internal global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField> fieldsWithVisibility;

		// Token: 0x04000053 RID: 83
		private global::System.Collections.Generic.List<global::AcpBusinessLayer.AcpRecRefField> recRefFields;

		// Token: 0x04000057 RID: 87
		private global::System.Collections.Generic.Dictionary<int, global::AcpBusinessLayer.FeatureSection> sections;

		// Token: 0x04000058 RID: 88
		private global::System.Collections.Generic.SortedDictionary<int, global::AcpBusinessLayer.FeatureSection> sectionsByOrder;

		// Token: 0x04000059 RID: 89
		internal static int NodeIdCounter;

		// Token: 0x0400005A RID: 90
		private string uiName;

		// Token: 0x0400005B RID: 91
		private bool deleted;

		// Token: 0x0400005E RID: 94
		private bool valid;

		// Token: 0x0400005F RID: 95
		private bool disposedValue;

		// Token: 0x04000060 RID: 96
		private bool isDisposeInProgress;
	}
}
