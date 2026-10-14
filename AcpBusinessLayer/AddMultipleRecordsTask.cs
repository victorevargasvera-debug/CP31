using System;
using System.Collections.Generic;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.FieldsReport;
using AcpCommonResources;
using AcpUtility;

namespace AcpBusinessLayer
{
	// Token: 0x0200003E RID: 62
	public class AddMultipleRecordsTask : global::AcpBusinessLayer.MultiRecordTaskBase
	{
		// Token: 0x060004A9 RID: 1193 RVA: 0x00064C40 File Offset: 0x00062E40
		protected AddMultipleRecordsTask()
		{
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00064C54 File Offset: 0x00062E54
		public AddMultipleRecordsTask(global::AcpBusinessLayer.FeatureNode[] records)
		{
			int a_ = 12;
			base..ctor(records);
			base.Description = global::AcpCommonResources.AcpResources.Add_Records.AcpStringFormat(new object[]
			{
				base.Count.ToString() + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("ﻝ", a_) + records[0].FeatureName
			});
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00064CB4 File Offset: 0x00062EB4
		internal AddMultipleRecordsTask(global::AcpBusinessLayer.FeatureNode[] records, bool isCurrentAdd)
		{
			int a_ = 19;
			base..ctor(records);
			this.b = isCurrentAdd;
			base.Description = string.Concat(new string[]
			{
				global::AcpBusinessLayer.UndoRedo.SetValueTask.b("ꓤ菦跨쯪", a_),
				base.Count.ToString(),
				global::AcpBusinessLayer.UndoRedo.SetValueTask.b("엤蓦蛨鯪蓬諮苰폲髴釶\ud9f8", a_),
				records[0].FeatureName,
				global::AcpBusinessLayer.UndoRedo.SetValueTask.b("엤闦賨裪苬鷮闰", a_)
			});
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00064D38 File Offset: 0x00062F38
		public override void Do()
		{
			short num = (short)1029046273;
			if (num != 0)
			{
			}
			num = (short)1568931693;
			short num2 = num;
			num = (short)99090285;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1251606528;
				if (num != 0)
				{
				}
				num = (short)1114243072;
				num3 = (int)num;
				switch (num3)
				{
				}
				break;
			}
			switch (0)
			{
			case 0:
				goto IL_C2;
			}
			int num5;
			global::AcpBusinessLayer.Recordset recordset;
			for (;;)
			{
				IL_9B:
				global::AcpBusinessLayer.Recordset recordset2;
				bool notFirstNoLastAddOnMultiAddOperation;
				switch (num3)
				{
				case 0:
				{
					global::System.Collections.Generic.List<global::AcpCommonLib.IAcpCommon>.Enumerator enumerator = this.a.GetEnumerator();
					num = (short)485752835;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
				{
					num = (short)1600585728;
					short num4 = num;
					num = (short)1795424263;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					if (num5 >= base.Count)
					{
						num = (short)1072889857;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					recordset.LastRecordInOperation = (num5 == base.Count - 1);
					num = (short)2045378564;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					try
					{
						num = (short)1362952193;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::AcpCommonLib.IAcpCommon acpCommon;
							switch (num3)
							{
							case 0:
								goto IL_37A;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_236;
								}
								continue;
							case 2:
								num = (short)489422858;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								if (acpCommon is global::AcpCommonLib.IAcpField)
								{
									num = (short)81199108;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)114163724;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								num = (short)1979842568;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.RegisterFieldInReport((global::AcpCommonLib.IAcpFeatureNode)acpCommon, global::AcpCommonResources.AcpResources.Extra_Record);
								global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.FieldsReportChanged = true;
								num = (short)752549894;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 7:
								num = (short)1009909773;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
								if (acpCommon is global::AcpBusinessLayer.AcpRecRefField)
								{
									num = (short)1766457351;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_37A;
							case 10:
								goto IL_423;
							case 11:
							{
								global::System.Collections.Generic.List<global::AcpCommonLib.IAcpCommon>.Enumerator enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)1604714498;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								acpCommon = enumerator.Current;
								num = (short)306053123;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 12:
								if (acpCommon is global::AcpCommonLib.IAcpFeatureNode)
								{
									num = (short)482082821;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 13:
								if (!this.b)
								{
									num = (short)2122579968;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							IL_238:
							num = (short)152829963;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_236:
							goto IL_238;
							IL_37A:
							global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.UnregisterFieldInReport((global::AcpCommonLib.IAcpField)acpCommon);
							global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.RegisterFieldInReport((global::AcpCommonLib.IAcpField)acpCommon, string.Empty, true);
							global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.FieldsReportChanged = true;
							num = (short)2013593609;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_423:
						goto IL_4CB;
					}
					finally
					{
						global::System.Collections.Generic.List<global::AcpCommonLib.IAcpCommon>.Enumerator enumerator;
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_436;
				case 4:
					recordset2 = recordset;
					notFirstNoLastAddOnMultiAddOperation = (num5 != 0 && num5 != base.Count - 1);
					goto IL_436;
				case 5:
					goto IL_FC;
				case 6:
					goto IL_FC;
				case 7:
					if (this.a != null)
					{
						num = (short)1875902464;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4CB;
				}
				goto IL_C2;
				IL_FC:
				num = (short)878641154;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_436:
				recordset2.NotFirstNoLastAddOnMultiAddOperation = notFirstNoLastAddOnMultiAddOperation;
				recordset.AddRecord(base.Records[num5]);
				base.Records[num5].Initialize();
				base.Records[num5].CallConstraints();
				base.Records[num5].Deleted = false;
				num5++;
				num = (short)691470342;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_4CB:
			recordset.NotFirstNoLastAddOnMultiAddOperation = false;
			base.Do();
			return;
			IL_C2:
			recordset = (base.Records[0].Parent as global::AcpBusinessLayer.Recordset);
			recordset.LastRecordInOperation = false;
			recordset.NotFirstNoLastAddOnMultiAddOperation = false;
			num5 = 0;
			num = (short)1613561861;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_9B;
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x0006523C File Offset: 0x0006343C
		public override void Undo()
		{
			short num = (short)355139584;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_77;
				}
				global::AcpBusinessLayer.Recordset recordset;
				int num3;
				int num6;
				for (;;)
				{
					IL_28:
					int num4;
					global::AcpBusinessLayer.FeatureNode[] records;
					switch (num2)
					{
					case 0:
					{
						this.a = new global::System.Collections.Generic.List<global::AcpCommonLib.IAcpCommon>();
						global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.FieldsReport.FieldsReportInfo> enumerator = global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.Fields.GetEnumerator();
						num = (short)229900291;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						recordset.RemoveRecordInternal(num3, new bool?(false));
						num = (short)1121648652;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_1DC;
					case 3:
						try
						{
							num = (short)2040528905;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::AcpCommonLib.FieldsReport.FieldsReportInfo fieldsReportInfo;
								global::AcpCommonLib.IAcpField field;
								switch (num2)
								{
								case 1:
									num = (short)920977427;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									num = (short)1879441429;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									if (fieldsReportInfo.Field is global::AcpBusinessLayer.AcpRecRefField)
									{
										num = (short)2137391122;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_527;
								case 4:
									num = (short)48627717;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									if (fieldsReportInfo.FieldType == global::AcpCommonLib.FieldInfoType.Record)
									{
										num = (short)1935343638;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_63D;
								case 6:
									if (fieldsReportInfo.Node != null)
									{
										num = (short)2137915396;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_63D;
								case 7:
									num = (short)1062076433;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									num = (short)1344012316;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									switch (0)
									{
									case 0:
										goto IL_441;
									}
									continue;
								case 10:
									if (field.Parent.ParentRecset.IsEmbeddedRecset)
									{
										num = (short)1704067079;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_63D;
								case 11:
									if (fieldsReportInfo.Node.Parent.IsEmbeddedRecset)
									{
										num = (short)1781596161;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_63D;
								case 12:
								{
									global::AcpBusinessLayer.FeatureNode featureNode;
									if (field.Parent.Parent != featureNode)
									{
										num = (short)527761440;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_882;
								}
								case 13:
									num = (short)1056178187;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									goto IL_446;
								case 15:
									num = (short)413007875;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
									goto IL_63D;
								case 17:
								{
									global::AcpBusinessLayer.FeatureNode featureNode;
									if (field.Parent.ParentRecset.ParentSection.Parent == featureNode)
									{
										num = (short)1993408541;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_63D;
								}
								case 18:
									num = (short)1585774616;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 19:
								{
									global::AcpBusinessLayer.FeatureNode featureNode;
									if (fieldsReportInfo.Node.Parent.ParentSection.Parent == featureNode)
									{
										num = (short)1170866202;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_63D;
								}
								case 20:
									goto IL_527;
								case 21:
									if (fieldsReportInfo.FieldType == global::AcpCommonLib.FieldInfoType.Field)
									{
										num = (short)1763311631;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_803;
								case 22:
									num = (short)230948887;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 23:
								{
									global::AcpBusinessLayer.FeatureNode featureNode;
									if (fieldsReportInfo.Node != featureNode)
									{
										num = (short)924385293;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_8AD;
								}
								case 24:
									if (!this.b)
									{
										num = (short)2050490388;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_803;
								case 25:
								{
									if (num4 >= records.Length)
									{
										num = (short)404226048;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureNode featureNode = records[num4];
									num = (short)564133919;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 26:
									goto IL_8AD;
								case 27:
									goto IL_63D;
								case 28:
									goto IL_8F5;
								case 29:
									goto IL_882;
								case 30:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.FieldsReport.FieldsReportInfo> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)169213960;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									fieldsReportInfo = enumerator.Current;
									records = base.Records;
									num4 = 0;
									num = (short)1050542094;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 31:
									if (fieldsReportInfo.Field != null)
									{
										num = (short)95420418;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_803;
								case 32:
									num = (short)404684810;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 33:
									goto IL_446;
								}
								goto IL_441;
								IL_446:
								num = (short)1729953817;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_527:
								field = fieldsReportInfo.Field;
								num = (short)48037900;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_63D:
								num4++;
								num = (short)378535969;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_803:
								num = (short)1148125190;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_844:
								num = (short)522649630;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_441:
								goto IL_844;
								IL_882:
								this.a.Add(field);
								num = (short)749207568;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_8AD:
								this.a.Add(fieldsReportInfo.Node);
								num = (short)1646067739;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_8F5:
							goto IL_124;
						}
						finally
						{
							num = (short)1388314625;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.FieldsReport.FieldsReportInfo> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_9B3;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_92C;
									}
									continue;
								case 2:
								{
									enumerator.Dispose();
									num = (short)2122844040;
									short num5 = num;
									num = (short)1011025800;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_9B5;
									default:
										num = (short)1104216064;
										if (num != 0)
										{
										}
										num = (short)217382912;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_92C:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1730281474;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_9B3:
							IL_9B5:;
						}
						goto Block_7;
					case 4:
						num = (short)1798438920;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_18F;
					case 6:
						global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.FieldsReportChanged = true;
						num = (short)81920005;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_1DC;
					case 8:
						if (this.a == null)
						{
							num = (short)629669888;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_124;
					case 9:
						goto IL_14E;
					case 10:
						if (this.a.Count > 0)
						{
							num = (short)1046216710;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_18F;
					case 11:
						goto IL_9B6;
					case 12:
						goto IL_244;
					case 13:
						goto IL_217;
					case 14:
						if (num3 >= 0)
						{
							num = (short)1390804993;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_244;
					case 15:
						goto IL_14E;
					case 16:
						if (num6 >= base.Count)
						{
							num = (short)257359876;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						recordset.LastRecordInOperation = (num6 == base.Count - 1);
						num3 = recordset.IndexOf(base.Records[num6]);
						num = (short)555614222;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (num4 >= records.Length)
						{
							num = (short)1003749389;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						records[num4].Deleted = true;
						num4++;
						num = (short)1569980423;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_77;
					Block_7:
					global::System.Collections.Generic.List<global::AcpCommonLib.IAcpCommon>.Enumerator enumerator2;
					try
					{
						IL_9B6:
						num = (short)1383006210;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::AcpCommonLib.IAcpCommon acpCommon;
								global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.UnregisterFieldInReport((global::AcpCommonLib.IAcpFeatureNode)acpCommon);
								global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.FieldsReportChanged = true;
								num = (short)1530200068;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								goto IL_B50;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_A04;
								}
								continue;
							case 3:
							{
								global::AcpCommonLib.IAcpCommon acpCommon;
								if (acpCommon is global::AcpCommonLib.IAcpField)
								{
									num = (short)1710227464;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)973340678;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
							{
								global::AcpCommonLib.IAcpCommon acpCommon;
								if (acpCommon is global::AcpCommonLib.IAcpFeatureNode)
								{
									num = (short)1485963264;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 7:
								num = (short)482803713;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
							{
								global::AcpCommonLib.IAcpCommon acpCommon;
								global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.UnregisterFieldInReport((global::AcpCommonLib.IAcpField)acpCommon);
								global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.FieldsReportChanged = true;
								num = (short)927399941;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 9:
							{
								if (!enumerator2.MoveNext())
								{
									num = (short)1633091591;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpCommonLib.IAcpCommon acpCommon = enumerator2.Current;
								num = (short)1729101827;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_A7F:
							num = (short)1579876361;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_A04:
							goto IL_A7F;
						}
						IL_B50:
						goto IL_B3;
					}
					finally
					{
						((global::System.IDisposable)enumerator2).Dispose();
					}
					goto IL_B63;
					IL_B3:
					num = (short)1889402880;
					short num7 = num;
					num = (short)164102154;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_124:
					enumerator2 = this.a.GetEnumerator();
					num = (short)90112011;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_14E:
					num = (short)2027880464;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_18F:
					records = base.Records;
					num4 = 0;
					num = (short)1360592898;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1DC:
					num = (short)928055313;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_244:
					num6++;
					num = (short)1915748367;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_217:
				num = (short)1464729601;
				if (num != 0)
				{
				}
				IL_B63:
				base.Undo();
				return;
				IL_77:
				recordset = (base.Records[0].Parent as global::AcpBusinessLayer.Recordset);
				recordset.LastRecordInOperation = false;
				num3 = 0;
				num6 = 0;
				num = (short)1407385609;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x04000144 RID: 324
		private global::System.Collections.Generic.List<global::AcpCommonLib.IAcpCommon> a;

		// Token: 0x04000145 RID: 325
		private bool b;
	}
}
