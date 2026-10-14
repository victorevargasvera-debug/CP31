using System;
using System.Collections.Generic;
using AcpCommonResources;
using AcpUtility;

namespace AcpBusinessLayer.UndoRedo
{
	// Token: 0x0200005C RID: 92
	internal class MoveRecordTask : global::AcpBusinessLayer.UndoRedo.RecordTaskBase
	{
		// Token: 0x06000523 RID: 1315 RVA: 0x0006E210 File Offset: 0x0006C410
		private MoveRecordTask()
		{
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x0006E224 File Offset: 0x0006C424
		internal MoveRecordTask(global::AcpBusinessLayer.FeatureNode rec, int newPos)
		{
			int a_ = 15;
			base..ctor(rec);
			this.a = newPos;
			base.Description = global::AcpCommonResources.AcpResources.Move_To.AcpStringFormat(new object[]
			{
				global::AcpBusinessLayer.UndoRedo.SetValueTask.b("쏠", a_) + this.record.FeatureName + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("쏠", a_),
				this.a.ToString()
			});
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x0006E29C File Offset: 0x0006C49C
		public override void Do()
		{
			short num = (short)427229185;
			if (num != 0)
			{
			}
			num = (short)1994748197;
			short num2 = num;
			num = (short)1502376229;
			switch (num2 == num)
			{
			}
			num = (short)1769472000;
			short num3 = num;
			num = (short)1938358272;
			if (num != 0)
			{
			}
			this.a();
			base.Do();
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x0006E350 File Offset: 0x0006C550
		public override void Undo()
		{
			short num = (short)811794433;
			if (num != 0)
			{
			}
			num = (short)2082866272;
			short num2 = num;
			num = (short)1793393760;
			switch (num2 == num)
			{
			}
			num = (short)1128005632;
			short num3 = num;
			num = (short)469368832;
			if (num != 0)
			{
			}
			this.a();
			base.Undo();
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x0006E408 File Offset: 0x0006C608
		private void a()
		{
			short num = (short)741867520;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_A8;
				}
				global::AcpBusinessLayer.Recordset recordset;
				int num3;
				for (;;)
				{
					IL_29:
					int num4;
					int num8;
					switch (num2)
					{
					case 0:
						goto IL_392;
					case 1:
						if (recordset.KeysToNode != null)
						{
							num = (short)1673396249;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_392;
					case 2:
						if (recordset.Count > recordset.Max)
						{
							num = (short)1717043214;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6F7;
					case 3:
						if (num3 > this.a)
						{
							num = (short)217448453;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2070085652;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_1ED;
					case 5:
					{
						num4 = this.a;
						int num5 = num3;
						num = (short)1731199000;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_1CE;
					case 7:
					{
						int num6;
						if (num6 >= recordset.Max)
						{
							num = (short)1513029650;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpBusinessLayer.FeatureNode)recordset[num6]).Valid = true;
						num6++;
						num = (short)381878293;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						try
						{
							num = (short)1934622721;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1940717572;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_5A9;
									}
									continue;
								case 3:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.AcpRecRefField> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1775239168;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									enumerator.Current.UpdateValue();
									num = (short)1725825026;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_61D;
								}
								IL_5CE:
								num = (short)1757216771;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5A9:
								goto IL_5CE;
							}
							IL_61D:;
						}
						finally
						{
							num = (short)223281152;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.AcpRecRefField> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_651;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1022033922;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_689;
								}
								IL_651:
								if (enumerator == null)
								{
									break;
								}
								num = (short)619053057;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_689:;
						}
						goto IL_68C;
					case 9:
						goto IL_38D;
					case 10:
					{
						global::AcpBusinessLayer.FeatureNode featureNode;
						if (featureNode.KeyField.ReferencingFields != null)
						{
							num = (short)1607467021;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_68C;
					}
					case 11:
						goto IL_259;
					case 12:
					{
						int num7;
						if (num7 >= recordset.Count)
						{
							num = (short)855703561;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpBusinessLayer.FeatureNode)recordset[num7]).Valid = false;
						num7++;
						num = (short)803733519;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
					{
						global::AcpBusinessLayer.FeatureNode featureNode;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.AcpRecRefField> enumerator = featureNode.KeyField.ReferencingFields.GetEnumerator();
						num = (short)1159331848;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
					{
						int num6 = 0;
						num = (short)1958084612;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						goto IL_34F;
					case 16:
						goto IL_259;
					case 17:
						goto IL_2FE;
					case 18:
					{
						int num7 = recordset.Max;
						num = (short)1749549083;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						num = (short)2111635466;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
					{
						if (this.a >= recordset.Count)
						{
							num = (short)520486941;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num5 = this.a;
						num = (short)1229062172;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						goto IL_1ED;
					case 22:
					{
						global::AcpBusinessLayer.FeatureNode featureNode;
						if (featureNode.KeyField != null)
						{
							num = (short)556400659;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_68C;
					}
					case 23:
					{
						int num5;
						if (num8 > num5)
						{
							num = (short)1381171226;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpBusinessLayer.FeatureNode featureNode = recordset[num8] as global::AcpBusinessLayer.FeatureNode;
						featureNode.RaisePositionChanged();
						num = (short)1125515265;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						goto IL_2FE;
					case 25:
						goto IL_499;
					case 26:
					{
						num = (short)1588157900;
						short num9 = num;
						num = (short)593190348;
						switch ((num9 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_499;
						case 1:
							break;
						default:
						{
							num = (short)593100800;
							short num10 = num;
							break;
						}
						}
						num = (short)593559552;
						if (num != 0)
						{
						}
						num = (short)1889206274;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
						goto IL_34F;
					case 28:
						num = (short)2050555905;
						if (num != 0)
						{
						}
						goto IL_1CE;
					case 29:
					{
						int num5 = recordset.Count - 1;
						num = (short)1483538438;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_A8;
					IL_1CE:
					num4 = num3;
					num = (short)1440415761;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1ED:
					num = (short)1846214663;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_259:
					num = (short)245170199;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2FE:
					recordset.Move(num3, this.a);
					num8 = num4;
					num = (short)208732176;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_34F:
					num = (short)595853324;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_392:
					num = (short)904069142;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_499:
					recordset.KeysToNode.UpdateKey((global::AcpBusinessLayer.FeatureNode)recordset[num8]);
					num = (short)1270677504;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_68C:
					num8++;
					num = (short)641466379;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_38D:
				IL_6F7:
				recordset.FinishedMoveRecord(num3, this.a);
				this.a = num3;
				return;
				IL_A8:
				recordset = (global::AcpBusinessLayer.Recordset)this.record.Parent;
				num3 = recordset.IndexOf(this.record);
				int num11 = this.a;
				num = (short)265355267;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x04000174 RID: 372
		private int a;
	}
}
