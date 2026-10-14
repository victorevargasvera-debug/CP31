using System;
using System.Collections.Generic;
using AcpCommonLib;
using AcpCommonLib.FieldsReport;
using AcpCommonLib.UndoRedo;
using AcpCommonResources;
using AcpUtility;

namespace AcpBusinessLayer.UndoRedo
{
	// Token: 0x02000055 RID: 85
	public class DeleteRecordTask : global::AcpBusinessLayer.UndoRedo.RecordTaskBase
	{
		// Token: 0x06000502 RID: 1282 RVA: 0x0006B388 File Offset: 0x00069588
		private DeleteRecordTask()
		{
			this.e = -1;
			base..ctor();
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x0006B3A4 File Offset: 0x000695A4
		public DeleteRecordTask(global::AcpBusinessLayer.FeatureNode rec)
		{
			int a_ = 15;
			this.e = -1;
			base..ctor(rec);
			this.a = this.record.Parent.IndexOf(this.record);
			base.Description = global::AcpCommonResources.AcpResources.Delete.AcpStringFormat(new object[]
			{
				global::AcpBusinessLayer.UndoRedo.SetValueTask.b("쇠쇢", a_) + rec.FeatureName + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("쏠", a_)
			});
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x0006B424 File Offset: 0x00069624
		internal DeleteRecordTask(global::AcpBusinessLayer.FeatureNode rec, bool dndimpexp)
		{
			int a_ = 2;
			this.e = -1;
			base..ctor(rec);
			this.a = this.record.Parent.IndexOf(this.record);
			base.Description = global::AcpCommonResources.AcpResources.Delete.AcpStringFormat(new object[]
			{
				global::AcpBusinessLayer.UndoRedo.SetValueTask.b("", a_) + rec.FeatureName + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("", a_)
			});
			this.g = dndimpexp;
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x0006B4AC File Offset: 0x000696AC
		public override void Do()
		{
			short num = (short)1420886016;
			switch (num)
			{
			default:
			{
				num = (short)953876485;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					int num3;
					global::AcpBusinessLayer.FeatureNode featureNode;
					global::System.Collections.Generic.List<global::AcpCommonLib.IAcpCommon>.Enumerator enumerator;
					switch (num2)
					{
					case 0:
						goto IL_24D;
					case 1:
						if (num3 >= this.record.Parent.Count)
						{
							num = (short)2069561354;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						featureNode = (global::AcpBusinessLayer.FeatureNode)this.record.Parent[num3];
						num = (short)518520839;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_24D;
					case 3:
						try
						{
							num = (short)892731394;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpCommon acpCommon;
									if (acpCommon is global::AcpCommonLib.IAcpFeatureNode)
									{
										num = (short)878641160;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									goto IL_978;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_830;
									}
									continue;
								case 3:
								{
									global::AcpCommonLib.IAcpCommon acpCommon;
									if (acpCommon is global::AcpCommonLib.IAcpField)
									{
										num = (short)386924550;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1920204800;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)886243337;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpCommon acpCommon = enumerator.Current;
									num = (short)1030684675;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::AcpCommonLib.IAcpCommon acpCommon;
									global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.UnregisterFieldInReport((global::AcpCommonLib.IAcpField)acpCommon);
									global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.FieldsReportChanged = true;
									num = (short)1636827143;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									global::AcpCommonLib.IAcpCommon acpCommon;
									global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.UnregisterFieldInReport((global::AcpCommonLib.IAcpFeatureNode)acpCommon);
									global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.FieldsReportChanged = true;
									num = (short)902692868;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									num = (short)693633025;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_873:
								num = (short)1673592837;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_830:
								goto IL_873;
							}
							IL_978:
							goto IL_195;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_98B;
						IL_195:
						num = (short)268238860;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						((global::AcpBusinessLayer.Recordset)this.record.Parent).RemoveRecordAtNoMin(this.a);
						num = (short)532348934;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_C0;
						}
						continue;
					case 6:
						goto IL_248;
					case 7:
						if (!featureNode.Valid)
						{
							num = (short)1913192456;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3++;
						num = (short)284753920;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_98B;
					case 9:
						this.f = new global::AcpCommonLib.UndoRedo.ContainerTask(base.Description);
						this.record.NodeDeleted(this.record, this.f);
						num = (short)1263271954;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_11F;
					case 11:
						if (this.e != -1)
						{
							num = (short)557187094;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E8;
					case 12:
						if (this.f != null)
						{
							num = (short)675086360;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EF2;
					case 13:
					{
						this.b = new global::System.Collections.Generic.List<global::AcpCommonLib.IAcpCommon>();
						this.c = new global::System.Collections.Generic.List<global::AcpBusinessLayer.AcpRecRefField>();
						global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.FieldsReport.FieldsReportInfo> enumerator2 = global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.Fields.GetEnumerator();
						num = (short)128647182;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						try
						{
							num = (short)649396239;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::AcpCommonLib.FieldsReport.FieldsReportInfo fieldsReportInfo;
								global::AcpCommonLib.IAcpField field;
								switch (num2)
								{
								case 0:
									num = (short)768016391;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									if (fieldsReportInfo.Node.Parent.ParentSection.Parent == this.record)
									{
										num = (short)1948385300;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 3:
									if (fieldsReportInfo.Node.Parent.IsEmbeddedRecset)
									{
										num = (short)517603339;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 4:
									if (fieldsReportInfo.Field != null)
									{
										num = (short)706871310;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_D71;
								case 5:
									num = (short)2052718617;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									if (fieldsReportInfo.Node != this.record)
									{
										num = (short)1029111817;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_C2B;
								case 7:
									if (field.Parent.ParentRecset.ParentSection.Parent == this.record)
									{
										num = (short)1731264528;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 8:
									num = (short)947650573;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									num = (short)1902772227;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									field = fieldsReportInfo.Field;
									num = (short)1172242450;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									num = (short)1951989762;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									if (fieldsReportInfo.FieldType == global::AcpCommonLib.FieldInfoType.Record)
									{
										num = (short)1916928017;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 13:
									goto IL_E81;
								case 14:
									num = (short)1472856086;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 15:
									switch (0)
									{
									case 0:
										goto IL_AF0;
									}
									continue;
								case 16:
									goto IL_E3E;
								case 17:
									num = (short)891289606;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 18:
									if (field.Parent.Parent != this.record)
									{
										num = (short)790626309;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_E3E;
								case 20:
									goto IL_C2B;
								case 21:
									if (fieldsReportInfo.Node != null)
									{
										num = (short)530645015;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 22:
									if (fieldsReportInfo.FieldType == global::AcpCommonLib.FieldInfoType.Field)
									{
										num = (short)90505226;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_D71;
								case 23:
									num = (short)740753420;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 24:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.FieldsReport.FieldsReportInfo> enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)2058027016;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									fieldsReportInfo = enumerator2.Current;
									num = (short)1315504132;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 25:
									if (field.Parent.ParentRecset.IsEmbeddedRecset)
									{
										num = (short)1562181632;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								goto IL_AF0;
								IL_C2B:
								this.b.Add(fieldsReportInfo.Node);
								num = (short)532676627;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_CF1:
								num = (short)2085224472;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_AF0:
								goto IL_CF1;
								IL_D71:
								num = (short)1164836885;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E3E:
								this.b.Add(field);
								num = (short)1603665921;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_E81:
							goto IL_72A;
						}
						finally
						{
							num = (short)533069824;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.FieldsReport.FieldsReportInfo> enumerator2;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_EB9;
									}
									continue;
								case 1:
									enumerator2.Dispose();
									num = (short)1632501762;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_EEF;
								}
								IL_EB9:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)599851009;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_EEF:;
						}
						goto IL_EF2;
						IL_72A:
						num = (short)890503196;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						num = (short)526843930;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						goto IL_11F;
					case 17:
						if (this.record.Valid)
						{
							num = (short)882704384;
							short num4 = num;
							num = (short)1100611603;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11F;
					case 18:
						goto IL_E8;
					case 19:
						num3 = 0;
						num = (short)756547586;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						try
						{
							num = (short)355270657;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_5A9;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_2D3;
									}
									continue;
								case 2:
									try
									{
										num = (short)374145026;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::AcpBusinessLayer.AcpRecRefSlaveItem acpRecRefSlaveItem;
											switch (num2)
											{
											case 0:
											{
												num = (short)1441088310;
												short num5 = num;
												num = (short)2046444342;
												switch ((num5 == num) ? 1 : 0)
												{
												case 0:
												case 2:
													goto IL_3D2;
												default:
													num = (short)133169152;
													if (num != 0)
													{
													}
													num = (short)1396244481;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 1:
												goto IL_4E2;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_360;
												}
												continue;
											case 3:
												if (this.d == null)
												{
													num = (short)62128134;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_399;
											case 4:
												num = (short)1260847107;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 6:
												goto IL_3D2;
											case 7:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.AcpRecRefSlaveItem> enumerator3;
												if (!enumerator3.MoveNext())
												{
													num = (short)1441136640;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												acpRecRefSlaveItem = enumerator3.Current;
												num = (short)1570504712;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 8:
												if (acpRecRefSlaveItem.SlaveField.ReferencedNode != null)
												{
													num = (short)62914564;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											case 9:
												goto IL_399;
											}
											goto IL_360;
											IL_399:
											this.d[acpRecRefSlaveItem.SlaveField] = acpRecRefSlaveItem.SlaveField.ReferencedNode;
											num = (short)22216709;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_3D2:
											this.d = new global::System.Collections.Generic.Dictionary<global::AcpBusinessLayer.AcpRecRefField, global::AcpBusinessLayer.FeatureNode>();
											num = (short)2020802569;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_3F8:
											num = (short)1575944199;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_360:
											goto IL_3F8;
										}
										IL_4E2:;
									}
									finally
									{
										num = (short)1159266304;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.AcpRecRefSlaveItem> enumerator3;
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_516;
												}
												continue;
											case 1:
												goto IL_54F;
											case 2:
												enumerator3.Dispose();
												num = (short)109707265;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_516:
											if (enumerator3 == null)
											{
												break;
											}
											num = (short)2002976770;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_54F:;
									}
									break;
								case 3:
									num = (short)1472135168;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.AcpRecRefField> enumerator4;
									if (!enumerator4.MoveNext())
									{
										num = (short)2076770307;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField = enumerator4.Current;
									this.c.Add(acpRecRefField);
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.AcpRecRefSlaveItem> enumerator3 = acpRecRefField.SlaveFields.GetEnumerator();
									num = (short)606208002;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_552:
								num = (short)776077316;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2D3:
								goto IL_552;
							}
							IL_5A9:
							goto IL_772;
						}
						finally
						{
							num = (short)1917911040;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.AcpRecRefField> enumerator4;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_5E0;
									}
									continue;
								case 1:
									goto IL_616;
								case 2:
									enumerator4.Dispose();
									num = (short)1361248257;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_5E0:
								if (enumerator4 == null)
								{
									break;
								}
								num = (short)1504903170;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_616:;
						}
						goto IL_619;
					case 21:
						goto IL_675;
					case 22:
						((global::AcpBusinessLayer.FeatureNode)this.record.Parent[this.e]).Valid = true;
						num = (short)488243227;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						if (this.record.NodeDeleted != null)
						{
							num = (short)334888969;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E8;
					case 24:
						goto IL_619;
					case 25:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.AcpRecRefField> enumerator4 = this.record.KeyField.ReferencingFields.GetEnumerator();
						num = (short)944570388;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
						if (this.record.KeyField.ReferencingFields != null)
						{
							num = (short)1111556121;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_772;
					case 27:
						goto IL_E8;
					case 28:
						if (this.record.KeyField != null)
						{
							num = (short)1829437455;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_772;
					case 29:
						if (this.g)
						{
							num = (short)1146486788;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpBusinessLayer.Recordset)this.record.Parent).RemoveRecordAt(this.a);
						num = (short)2041970709;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						goto IL_EF2;
					}
					IL_C0:
					if (this.b == null)
					{
						num = (short)1379270669;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1617559563;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E8:
					this.record.Deleted = true;
					enumerator = this.b.GetEnumerator();
					num = (short)1098842115;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_11F:
					num = (short)1777991703;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_24D:
					num = (short)569245697;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_619:
					this.f.Do();
					num = (short)1482489886;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_772:
					num = (short)2020474897;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_98B:
					featureNode.Valid = true;
					this.e = num3;
					num = (short)1596981264;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_EF2:
					num = (short)386727937;
					if (num != 0)
					{
					}
					num = (short)675086365;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_248:
				IL_675:
				this.record.DropReferences();
				base.Do();
				return;
			}
			}
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x0006C4F0 File Offset: 0x0006A6F0
		public override void Undo()
		{
			short num = (short)2126315520;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				switch (0)
				{
				case 0:
					goto IL_62;
				}
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.List<global::AcpCommonLib.IAcpCommon>.Enumerator enumerator2;
					switch (num2)
					{
					case 0:
					{
						global::System.Collections.Generic.Dictionary<global::AcpBusinessLayer.AcpRecRefField, global::AcpBusinessLayer.FeatureNode>.Enumerator enumerator = this.d.GetEnumerator();
						num = (short)95354884;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						this.f.Undo();
						num = (short)1453654027;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)349241345;
						if (num != 0)
						{
						}
						if (this.b != null)
						{
							num = (short)400162821;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_412;
					case 3:
						if (this.e != -1)
						{
							num = (short)824180743;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_47D;
					case 4:
						try
						{
							num = (short)1013514244;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)252510210;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::System.Collections.Generic.Dictionary<global::AcpBusinessLayer.AcpRecRefField, global::AcpBusinessLayer.FeatureNode>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1453064192;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<global::AcpBusinessLayer.AcpRecRefField, global::AcpBusinessLayer.FeatureNode> keyValuePair = enumerator.Current;
									keyValuePair.Key.UIValue = keyValuePair.Value.ReferenceKey;
									num = (short)955252739;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_585;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_4F9;
									}
									continue;
								}
								IL_534:
								num = (short)170917889;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4F9:
								goto IL_534;
							}
							IL_585:
							goto IL_364;
						}
						finally
						{
							global::System.Collections.Generic.Dictionary<global::AcpBusinessLayer.AcpRecRefField, global::AcpBusinessLayer.FeatureNode>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto Block_7;
					case 5:
						goto IL_665;
					case 6:
						goto IL_47D;
					case 7:
					{
						num = (short)1376583680;
						short num3 = num;
						((global::AcpBusinessLayer.FeatureNode)this.record.Parent[this.e]).Valid = false;
						num = (short)473432070;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						try
						{
							num = (short)939917314;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::AcpCommonLib.IAcpCommon acpCommon;
								switch (num2)
								{
								case 0:
									global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.RegisterFieldInReport((global::AcpCommonLib.IAcpField)acpCommon, string.Empty, true);
									global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.FieldsReportChanged = true;
									num = (short)1432813572;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_24C;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1B6;
									}
									continue;
								case 3:
									if (acpCommon is global::AcpCommonLib.IAcpField)
									{
										num = (short)35520512;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)88014857;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_351;
								case 6:
									global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.RegisterFieldInReport((global::AcpCommonLib.IAcpFeatureNode)acpCommon, global::AcpCommonResources.AcpResources.Extra_Record);
									global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.FieldsReportChanged = true;
									num = (short)1828913159;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									num = (short)1235631543;
									short num4 = num;
									num = (short)2073902519;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_24C;
									default:
										num = (short)1536491520;
										if (num != 0)
										{
										}
										num = (short)1604780037;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
									if (acpCommon is global::AcpCommonLib.IAcpFeatureNode)
									{
										num = (short)923009030;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								goto IL_1B6;
								IL_24C:
								if (!enumerator2.MoveNext())
								{
									num = (short)559087624;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								acpCommon = enumerator2.Current;
								num = (short)885850115;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_232:
								num = (short)2020540417;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1B6:
								goto IL_232;
							}
							IL_351:
							goto IL_412;
						}
						finally
						{
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto IL_364;
					case 9:
						if (this.d != null)
						{
							num = (short)1444610048;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_364;
					case 10:
						goto IL_598;
					case 11:
						goto IL_3CB;
					case 12:
						if (this.f != null)
						{
							num = (short)1669070849;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_68F;
					}
					goto IL_62;
					IL_364:
					num = (short)1459748867;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_7:
					global::System.Collections.Generic.List<global::AcpBusinessLayer.AcpRecRefField>.Enumerator enumerator3;
					try
					{
						IL_598:
						num = (short)1634402308;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								num = (short)829095938;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								if (!enumerator3.MoveNext())
								{
									num = (short)1709965312;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								enumerator3.Current.UIValue = this.record.ReferenceKey;
								num = (short)1381761027;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_652;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_5D3;
								}
								continue;
							}
							IL_603:
							num = (short)962592769;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_5D3:
							goto IL_603;
						}
						IL_652:
						goto IL_3D0;
					}
					finally
					{
						((global::System.IDisposable)enumerator3).Dispose();
					}
					goto IL_665;
					IL_3D0:
					num = (short)285081609;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_412:
					((global::AcpBusinessLayer.Recordset)this.record.Parent).InsertRecord(this.a, this.record);
					this.record.PopulateReferences();
					this.record.CalculateApplicability();
					this.record.CalculateValidity();
					enumerator3 = this.c.GetEnumerator();
					num = (short)756678666;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_47D:
					num = (short)1023868940;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_665:
					enumerator2 = this.b.GetEnumerator();
					num = (short)550961160;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_3CB:
				IL_68F:
				base.Undo();
				return;
				IL_62:
				this.record.Deleted = false;
				num = (short)2145452034;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
		}

		// Token: 0x04000160 RID: 352
		private int a;

		// Token: 0x04000161 RID: 353
		private global::System.Collections.Generic.List<global::AcpCommonLib.IAcpCommon> b;

		// Token: 0x04000162 RID: 354
		private global::System.Collections.Generic.List<global::AcpBusinessLayer.AcpRecRefField> c;

		// Token: 0x04000163 RID: 355
		private global::System.Collections.Generic.Dictionary<global::AcpBusinessLayer.AcpRecRefField, global::AcpBusinessLayer.FeatureNode> d;

		// Token: 0x04000164 RID: 356
		private int e;

		// Token: 0x04000165 RID: 357
		private global::AcpCommonLib.UndoRedo.ContainerTask f;

		// Token: 0x04000166 RID: 358
		private bool g;
	}
}
