using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000FD RID: 253
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class Record : global::Motorola.CommonCPS.Server.EntityModel.DBNode, global::Motorola.CommonCPS.Server.EntityModel.IRecordSummary
	{
		// Token: 0x06000F53 RID: 3923 RVA: 0x000A48B4 File Offset: 0x000A2AB4
		public override void Accept(global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.IDBNodeVisitor visitor)
		{
			short num = (short)620237819;
			short num2 = num;
			num = (short)797971451;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)915275776;
				short num3 = num;
				num = (short)595263488;
				if (num != 0)
				{
				}
				visitor.VisitRecord_Begin(this);
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode>.Enumerator enumerator = base.ChildNodesList.GetEnumerator())
				{
					num = (short)729481218;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							num = (short)1417216001;
							if (num != 0)
							{
							}
							if (!enumerator.MoveNext())
							{
								num = (short)1197735940;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							enumerator.Current.Accept(visitor);
							num = (short)1626341377;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_C0;
							}
							continue;
						case 3:
							goto IL_159;
						case 4:
							num = (short)457441283;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_E5:
						num = (short)268828672;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_C0:
						goto IL_E5;
					}
					IL_159:;
				}
				break;
			}
			}
			visitor.VisitRecord_End(this);
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06000F54 RID: 3924 RVA: 0x000A4A44 File Offset: 0x000A2C44
		// (set) Token: 0x06000F55 RID: 3925 RVA: 0x000A4AF4 File Offset: 0x000A2CF4
		[global::System.Runtime.Serialization.DataMember]
		[global::System.Xml.Serialization.XmlAttribute("UUID")]
		public string UUID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1848009027;
				short num2 = num;
				num = (short)1531011395;
				switch (num2 == num)
				{
				}
				num = (short)1117847552;
				short num3 = num;
				num = (short)1653080065;
				if (num != 0)
				{
				}
				num = (short)4063232;
				if (num != 0)
				{
				}
				return this.<UUID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2029567412;
				short num2 = num;
				num = (short)572702132;
				switch (num2 == num)
				{
				}
				num = (short)18612224;
				short num3 = num;
				num = (short)931790848;
				if (num != 0)
				{
				}
				num = (short)2038169601;
				if (num != 0)
				{
				}
				this.<UUID>k__BackingField = value;
			}
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06000F56 RID: 3926 RVA: 0x000A4BA4 File Offset: 0x000A2DA4
		// (set) Token: 0x06000F57 RID: 3927 RVA: 0x000A4C54 File Offset: 0x000A2E54
		[global::Motorola.CommonCPS.Server.EntityModel.CreateBLField(true)]
		[global::System.Runtime.Serialization.DataMember]
		[global::System.Xml.Serialization.XmlAttribute("SetName")]
		public string SetName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)499683165;
				short num2 = num;
				num = (short)1220775773;
				switch (num2 == num)
				{
				}
				num = (short)1088290816;
				short num3 = num;
				num = (short)1409220608;
				if (num != 0)
				{
				}
				num = (short)1473904641;
				if (num != 0)
				{
				}
				return this.<SetName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1832328225;
				short num2 = num;
				num = (short)149822497;
				switch (num2 == num)
				{
				}
				num = (short)885719040;
				short num3 = num;
				num = (short)835715072;
				if (num != 0)
				{
				}
				num = (short)1745485825;
				if (num != 0)
				{
				}
				this.<SetName>k__BackingField = value;
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06000F58 RID: 3928 RVA: 0x000A4D08 File Offset: 0x000A2F08
		// (set) Token: 0x06000F59 RID: 3929 RVA: 0x000A4DB8 File Offset: 0x000A2FB8
		[global::Motorola.CommonCPS.Server.EntityModel.CreateBLField(true)]
		[global::System.Runtime.Serialization.DataMember]
		[global::System.Xml.Serialization.XmlAttribute("LastModifiedDate")]
		public global::System.DateTime LastModifiedDate
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)569069812;
				short num2 = num;
				num = (short)430133492;
				switch (num2 == num)
				{
				}
				num = (short)1470431232;
				short num3 = num;
				num = (short)545193985;
				if (num != 0)
				{
				}
				num = (short)46792704;
				if (num != 0)
				{
				}
				return this.<LastModifiedDate>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1825785141;
				short num2 = num;
				num = (short)749487413;
				switch (num2 == num)
				{
				}
				num = (short)1528365056;
				short num3 = num;
				num = (short)849870848;
				if (num != 0)
				{
				}
				num = (short)536936449;
				if (num != 0)
				{
				}
				this.<LastModifiedDate>k__BackingField = value;
			}
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x06000F5A RID: 3930 RVA: 0x000A4E68 File Offset: 0x000A3068
		// (set) Token: 0x06000F5B RID: 3931 RVA: 0x000A4F18 File Offset: 0x000A3118
		[global::System.Runtime.Serialization.DataMember]
		[global::System.Xml.Serialization.XmlAttribute("Timestamp")]
		public byte[] Timestamp
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)507136864;
				short num2 = num;
				num = (short)898517856;
				switch (num2 == num)
				{
				}
				num = (short)1760231424;
				short num3 = num;
				num = (short)1725366273;
				if (num != 0)
				{
				}
				num = (short)1216086016;
				if (num != 0)
				{
				}
				return this.<Timestamp>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1328146872;
				short num2 = num;
				num = (short)1486612920;
				switch (num2 == num)
				{
				}
				num = (short)1103626240;
				short num3 = num;
				num = (short)148111360;
				if (num != 0)
				{
				}
				num = (short)877461505;
				if (num != 0)
				{
				}
				this.<Timestamp>k__BackingField = value;
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06000F5C RID: 3932 RVA: 0x000A4FC8 File Offset: 0x000A31C8
		// (set) Token: 0x06000F5D RID: 3933 RVA: 0x000A5078 File Offset: 0x000A3278
		[global::System.Xml.Serialization.XmlAttribute("Comments")]
		[global::Motorola.CommonCPS.Server.EntityModel.CreateBLField(true)]
		[global::System.Runtime.Serialization.DataMember]
		public string Comments
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1070489987;
				short num2 = num;
				num = (short)1439457667;
				switch (num2 == num)
				{
				}
				num = (short)583139328;
				short num3 = num;
				num = (short)217513984;
				if (num != 0)
				{
				}
				num = (short)976551937;
				if (num != 0)
				{
				}
				return this.<Comments>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1457129610;
				short num2 = num;
				num = (short)1917520010;
				switch (num2 == num)
				{
				}
				num = (short)419233792;
				short num3 = num;
				num = (short)118620161;
				if (num != 0)
				{
				}
				num = (short)1145372672;
				if (num != 0)
				{
				}
				this.<Comments>k__BackingField = value;
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06000F5E RID: 3934 RVA: 0x000A5128 File Offset: 0x000A3328
		// (set) Token: 0x06000F5F RID: 3935 RVA: 0x000A51D8 File Offset: 0x000A33D8
		[global::System.Xml.Serialization.XmlIgnore]
		public int Index
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)246318831;
				short num2 = num;
				num = (short)1089308399;
				switch (num2 == num)
				{
				}
				num = (short)1256521728;
				short num3 = num;
				num = (short)146210816;
				if (num != 0)
				{
				}
				num = (short)1491206145;
				if (num != 0)
				{
				}
				return this.<Index>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1800828250;
				short num2 = num;
				num = (short)796030298;
				switch (num2 == num)
				{
				}
				num = (short)1449918464;
				short num3 = num;
				num = (short)449708033;
				if (num != 0)
				{
				}
				num = (short)1887174656;
				if (num != 0)
				{
				}
				this.<Index>k__BackingField = value;
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06000F60 RID: 3936 RVA: 0x000A5288 File Offset: 0x000A3488
		// (set) Token: 0x06000F61 RID: 3937 RVA: 0x000A5338 File Offset: 0x000A3538
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.RSExtentions Extention
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)723939415;
				short num2 = num;
				num = (short)4550743;
				switch (num2 == num)
				{
				}
				num = (short)955777024;
				short num3 = num;
				num = (short)131858433;
				if (num != 0)
				{
				}
				num = (short)1001914368;
				if (num != 0)
				{
				}
				return this.<Extention>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1781676045;
				short num2 = num;
				num = (short)1643919373;
				switch (num2 == num)
				{
				}
				num = (short)2129002496;
				short num3 = num;
				num = (short)1495007233;
				if (num != 0)
				{
				}
				num = (short)610336768;
				if (num != 0)
				{
				}
				this.<Extention>k__BackingField = value;
			}
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x000A53FC File Offset: 0x000A35FC
		public override int GetHashCode()
		{
			while (!string.IsNullOrEmpty(this.UUID))
			{
				short num = (short)1181389960;
				short num2 = num;
				num = (short)1265865864;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1245511680;
					short num3 = num;
					num = (short)1131151360;
					if (num != 0)
					{
					}
					num = (short)1326645249;
					if (num != 0)
					{
					}
					return this.UUID.GetHashCode();
				}
				}
			}
			return base.GetHashCode();
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x000A54CC File Offset: 0x000A36CC
		public override bool Equals(object obj)
		{
			short num = (short)1329528833;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.CommonCPS.Server.EntityModel.IRecordSummary recordSummary;
			for (;;)
			{
				num = (short)262057703;
				short num3 = num;
				num = (short)1679142631;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)272760832;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
					{
						num = (short)919011328;
						short num4 = num;
						if (recordSummary != null)
						{
							num = (short)1235091458;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_88;
						}
						continue;
					case 2:
						goto IL_BF;
					case 3:
						if (recordSummary.GetHashCode() == this.GetHashCode())
						{
							num = (short)179699717;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 4:
						num = (short)1600585729;
						if (num != 0)
						{
						}
						recordSummary = (obj as global::Motorola.CommonCPS.Server.EntityModel.IRecordSummary);
						num = (short)1113718784;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_100;
					}
					IL_88:
					if (obj is global::Motorola.CommonCPS.Server.EntityModel.IRecordSummary)
					{
						num = (short)740032516;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				IL_BF:
				num = (short)216137731;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_100:
			return recordSummary.SetName == this.SetName;
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x000A5670 File Offset: 0x000A3870
		public global::Motorola.CommonCPS.Server.EntityModel.DBNode GetChild(string name)
		{
			switch (0)
			{
			case 0:
				goto IL_67;
			}
			short num;
			int num3;
			global::Motorola.CommonCPS.Server.EntityModel.DBNode result;
			for (;;)
			{
				IL_0A:
				num = (short)387082208;
				short num2 = num;
				num = (short)255354848;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1229062144;
					if (num != 0)
					{
					}
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode>.Enumerator enumerator;
					switch (num3)
					{
					case 0:
						num = (short)941948929;
						if (num != 0)
						{
						}
						try
						{
							num = (short)1536819202;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									goto IL_17B;
								case 1:
									goto IL_195;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_E8;
									}
									continue;
								case 3:
									num = (short)359858177;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode;
									if (dbnode.Name == name)
									{
										num = (short)1358168070;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1441267715;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode = enumerator.Current;
									num = (short)712966148;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode;
									result = dbnode;
									num = (short)312147968;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_EA:
								num = (short)1397030917;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_E8:
								goto IL_EA;
							}
							IL_17B:
							IL_195:
							goto IL_1F6;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_1A5;
					case 1:
						goto IL_7F;
					case 2:
						goto IL_1A5;
					}
					goto IL_67;
					IL_1A5:
					enumerator = base.ChildNodesList.GetEnumerator();
					num = (short)75956224;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_7F:
				if (base.ChildNodesList == null)
				{
					break;
				}
				num = (short)862781442;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_1F6:
			num = (short)15663104;
			short num4 = num;
			return result;
			IL_67:
			result = null;
			num = (short)1662255105;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06000F66 RID: 3942 RVA: 0x000A58B0 File Offset: 0x000A3AB0
		// (set) Token: 0x06000F67 RID: 3943 RVA: 0x000A5960 File Offset: 0x000A3B60
		[global::System.Runtime.Serialization.DataMember]
		public bool IsTopSet
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)467468289;
				if (num != 0)
				{
				}
				num = (short)653483038;
				short num2 = num;
				num = (short)1512922142;
				switch (num2 == num)
				{
				}
				num = (short)270532608;
				if (num != 0)
				{
				}
				num = (short)341835776;
				short num3 = num;
				return this.<IsTopSet>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)318297582;
				short num2 = num;
				num = (short)457692654;
				switch (num2 == num)
				{
				}
				num = (short)1754791936;
				if (num != 0)
				{
				}
				num = (short)655032321;
				if (num != 0)
				{
				}
				num = (short)619184128;
				short num3 = num;
				this.<IsTopSet>k__BackingField = value;
			}
		}
	}
}
