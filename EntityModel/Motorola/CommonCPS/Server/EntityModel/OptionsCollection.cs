using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Xsl;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.CommonContract;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel.CallBacks;
using Motorola.CommonCPS.Server.EntityModel.GenericModel;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000A4 RID: 164
	[global::System.Xml.Serialization.XmlType("Os")]
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class OptionsCollection
	{
		// Token: 0x06000C72 RID: 3186 RVA: 0x00085C50 File Offset: 0x00083E50
		public OptionsCollection()
		{
			this.OptionsList = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.OptionDesItem>();
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06000C73 RID: 3187 RVA: 0x00085C70 File Offset: 0x00083E70
		// (set) Token: 0x06000C74 RID: 3188 RVA: 0x00085D1C File Offset: 0x00083F1C
		[global::System.Runtime.Serialization.DataMember]
		[global::System.Xml.Serialization.XmlElement("O")]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.OptionDesItem> OptionsList
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1163919360;
				short num2 = num;
				num = (short)1524013034;
				short num3 = num;
				num = (short)1079941098;
				switch (num3 == num)
				{
				}
				num = (short)1662320641;
				if (num != 0)
				{
				}
				num = (short)1405812736;
				if (num != 0)
				{
				}
				return this.<OptionsList>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1576730624;
				short num2 = num;
				num = (short)2092715836;
				short num3 = num;
				num = (short)1163284284;
				switch (num3 == num)
				{
				}
				num = (short)1136918529;
				if (num != 0)
				{
				}
				num = (short)2061500416;
				if (num != 0)
				{
				}
				this.<OptionsList>k__BackingField = value;
			}
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x00085DCC File Offset: 0x00083FCC
		public string SerializeToXML()
		{
			short num = (short)664141824;
			short num2 = num;
			num = (short)1820572978;
			short num3 = num;
			num = (short)1651293490;
			switch (num3 == num)
			{
			}
			num = (short)362414081;
			if (num != 0)
			{
			}
			num = (short)642973696;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.CommonContract.Serializer.Serialize_ToXMLZipString(this);
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x00085E7C File Offset: 0x0008407C
		public static global::Motorola.CommonCPS.Server.EntityModel.OptionsCollection DeserializeFromXML(string xmlString)
		{
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.OptionsCollection result;
			try
			{
				num = (short)110698723;
				short num2 = num;
				num = (short)209461475;
				switch (num2 == num)
				{
				}
				num = (short)1786445824;
				if (num != 0)
				{
				}
				result = (global::Motorola.CommonCPS.CommonContract.Serializer.Deserialize_FromXMLZipString(xmlString, typeof(global::Motorola.CommonCPS.Server.EntityModel.OptionsCollection)) as global::Motorola.CommonCPS.Server.EntityModel.OptionsCollection);
			}
			catch
			{
				result = global::Motorola.CommonCPS.Server.EntityModel.OptionsCollection.a(xmlString);
			}
			num = (short)2131099649;
			if (num != 0)
			{
			}
			num = (short)1211039744;
			short num3 = num;
			return result;
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x00085F54 File Offset: 0x00084154
		private static global::Motorola.CommonCPS.Server.EntityModel.OptionsCollection a(string A_0)
		{
			int a_ = 13;
			short num = (short)559398693;
			short num2 = num;
			num = (short)1181269797;
			global::Motorola.CommonCPS.Server.EntityModel.OptionsCollection result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)2112684032;
				if (num != 0)
				{
				}
				num = (short)54001664;
				switch (num)
				{
				default:
				{
					num = (short)1257963521;
					if (num != 0)
					{
					}
					num = (short)1048510464;
					short num3 = num;
					global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
					xmlDocument.LoadXml(A_0);
					global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
					global::System.Xml.XmlWriter xmlWriter = global::System.Xml.XmlWriter.Create(stringBuilder, new global::System.Xml.XmlWriterSettings
					{
						Encoding = global::System.Text.Encoding.UTF8,
						Indent = true,
						OmitXmlDeclaration = true
					});
					try
					{
						global::System.Xml.Xsl.XslCompiledTransform xslCompiledTransform = new global::System.Xml.Xsl.XslCompiledTransform();
						global::System.IO.Stream manifestResourceStream = global::System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("䘊戌笎縐愒稔笖砘㔚帜瀞䰠丢䨤䤦樨笪縬Į戰嘲䜴䄶尸䤺ጼ稾⽀㝂ⱄ㍆えي≌⭎㑐㽒答ၖ㱘㕚㡜ⵞࡠb⡤ࡦ൨๪Ŭ䅮ばͲմ᭶x㙺⭼ま삀ꞈ쒊ﶌﮎﲒﮔ\uda98쒠삢톤캦욨얪캮튰\ud8b2슴횶쮸\udfba鎼잾닀꿂뇄", a_));
						try
						{
							global::System.Xml.XmlReader xmlReader = global::System.Xml.XmlReader.Create(manifestResourceStream);
							try
							{
								xslCompiledTransform.Load(xmlReader);
							}
							finally
							{
								num = (short)1335164928;
								int num4 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num4)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_16B;
										}
										continue;
									case 1:
										goto IL_1A3;
									case 2:
										((global::System.IDisposable)xmlReader).Dispose();
										num = (short)174653441;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_16B:
									if (xmlReader == null)
									{
										break;
									}
									num = (short)1289814018;
									num4 = (int)((global::System.IntPtr)num);
								}
								IL_1A3:;
							}
						}
						finally
						{
							num = (short)1756102656;
							int num4 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num4)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1D8;
									}
									continue;
								case 1:
									goto IL_20F;
								case 2:
									((global::System.IDisposable)manifestResourceStream).Dispose();
									num = (short)1052835841;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1D8:
								if (manifestResourceStream == null)
								{
									break;
								}
								num = (short)110624770;
								num4 = (int)((global::System.IntPtr)num);
							}
							IL_20F:;
						}
						xslCompiledTransform.Transform(xmlDocument.CreateNavigator(), null, xmlWriter);
						result = (global::Motorola.CommonCPS.CommonContract.Serializer.Deserialize_FromXMLString(stringBuilder.ToString(), typeof(global::Motorola.CommonCPS.Server.EntityModel.OptionsCollection)) as global::Motorola.CommonCPS.Server.EntityModel.OptionsCollection);
					}
					finally
					{
						num = (short)174653440;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_272;
								}
								continue;
							case 1:
								goto IL_2A7;
							case 2:
								((global::System.IDisposable)xmlWriter).Dispose();
								num = (short)1190002689;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_272:
							if (xmlWriter == null)
							{
								break;
							}
							num = (short)1957101570;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_2A7:;
					}
					break;
				}
				}
				break;
			}
			return result;
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x0008625C File Offset: 0x0008445C
		public static global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature> GetRadioFeatures(string xmlString, global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily)
		{
			short num = (short)1670840320;
			short num2 = num;
			num = (short)1538342243;
			short num3 = num;
			num = (short)160251235;
			switch (num3 == num)
			{
			}
			num = (short)789839873;
			if (num != 0)
			{
			}
			num = (short)725745664;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.Server.EntityModel.OptionsCollection.DeserializeFromXML(xmlString).GetRadioFeatures(productFamily);
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x00086318 File Offset: 0x00084518
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature> GetRadioFeatures(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily)
		{
			short num = (short)392429568;
			short num2 = num;
			num = (short)1243742208;
			switch (num)
			{
			default:
			{
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature> list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature>();
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.OptionDesItem>.Enumerator enumerator = this.OptionsList.GetEnumerator())
				{
					num = (short)674299906;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Motorola.CommonCPS.Server.EntityModel.OptionDesItem optionDesItem;
						global::Motorola.CommonCPS.Server.CommonDBConstants.FeatureStatus featureStatus;
						string featureNotice;
						switch (num3)
						{
						case 0:
							if (!enumerator.MoveNext())
							{
								num = (short)1209335814;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							optionDesItem = enumerator.Current;
							featureStatus = global::Motorola.CommonCPS.Server.EntityModel.OptionsCollection.a(optionDesItem.OptionStatus);
							featureNotice = string.Empty;
							goto IL_E6;
						case 1:
							if (optionDesItem.OptionID is global::Motorola.CommonCPS.Server.EntityModel.GenericModel.PCR_OptionIDDefinition)
							{
								num = (short)1551695879;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1E0;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_A1;
							}
							continue;
						case 3:
							goto IL_129;
						case 4:
							goto IL_1E0;
						case 5:
							goto IL_253;
						case 6:
							num = (short)1254424581;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
						{
							num = (short)1112975796;
							short num4 = num;
							num = (short)2079107508;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_E6;
							default:
								num = (short)759562240;
								if (num != 0)
								{
								}
								featureNotice = (optionDesItem.OptionID as global::Motorola.CommonCPS.Server.EntityModel.GenericModel.PCR_OptionIDDefinition).OptionNotice;
								num = (short)576520196;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						goto IL_A1;
						IL_E6:
						num = (short)2007498753;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_129:
						num = (short)1330839552;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_A1:
						num = (short)1177092097;
						if (num != 0)
						{
						}
						goto IL_129;
						IL_1E0:
						global::Motorola.CommonCPS.Server.EntityModel.RadioFeature radioFeature = global::Motorola.CommonCPS.Server.EntityModel.RadioFeature.CreateRadioFeature(null, global::System.Guid.Empty, optionDesItem.OptionID.OptionInt, (int)featureStatus, (int)featureStatus, false, 8, 0, 0, featureNotice);
						radioFeature.IsVisible = optionDesItem.Visible;
						list.Add(radioFeature);
						num = (short)405864451;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_253:;
				}
				return list;
			}
			}
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x000865A8 File Offset: 0x000847A8
		private static global::Motorola.CommonCPS.Server.CommonDBConstants.FeatureStatus a(global::Motorola.CommonCPS.Server.CommonDBConstants.OptionStatusEnum A_0)
		{
			short num = (short)532348928;
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
					return global::Motorola.CommonCPS.Server.CommonDBConstants.FeatureStatus.None;
				case 2:
					num = (short)702414849;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_30:
				switch (A_0)
				{
				case global::Motorola.CommonCPS.Server.CommonDBConstants.OptionStatusEnum.CFS_DISABLED:
					goto IL_5B;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.OptionStatusEnum.FREE:
					return global::Motorola.CommonCPS.Server.CommonDBConstants.FeatureStatus.Free;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.OptionStatusEnum.CFS_ENABLED:
					goto IL_9B;
				default:
					num = (short)863043586;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			return global::Motorola.CommonCPS.Server.CommonDBConstants.FeatureStatus.Free;
			IL_5B:
			num = (short)1374158849;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.Server.CommonDBConstants.FeatureStatus.Disabled;
			IL_9B:
			num = (short)1472428783;
			short num3 = num;
			num = (short)1376025327;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_5B;
			default:
			{
				num = (short)2141257728;
				if (num != 0)
				{
				}
				num = (short)950272000;
				short num4 = num;
				return global::Motorola.CommonCPS.Server.CommonDBConstants.FeatureStatus.Active;
			}
			}
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x000866C8 File Offset: 0x000848C8
		public bool ContainOption(global::Motorola.CommonCPS.Server.EntityModel.OptionDesItem option)
		{
			short num;
			for (;;)
			{
				if (this.OptionsList == null)
				{
					num = (short)1360031484;
					short num2 = num;
					num = (short)713060092;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_79;
					}
					break;
				}
				goto IL_B8;
			}
			num = (short)1431699456;
			short num3 = num;
			IL_79:
			num = (short)208470017;
			if (num != 0)
			{
			}
			num = (short)1693712384;
			if (num != 0)
			{
			}
			return false;
			IL_B8:
			return this.OptionsList.FirstOrDefault(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.OptionDesItem, bool>(a.b)) != null;
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x000867A8 File Offset: 0x000849A8
		public bool ContainOptionID(int optionID)
		{
			short num;
			for (;;)
			{
				if (this.OptionsList == null)
				{
					num = (short)1562901945;
					short num2 = num;
					num = (short)1323826617;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_79;
					}
					break;
				}
				goto IL_B8;
			}
			num = (short)1827340288;
			short num3 = num;
			IL_79:
			num = (short)1352466433;
			if (num != 0)
			{
			}
			num = (short)530251776;
			if (num != 0)
			{
			}
			return false;
			IL_B8:
			return this.OptionsList.FirstOrDefault(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.OptionDesItem, bool>(b.b)) != null;
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x00086888 File Offset: 0x00084A88
		public global::Motorola.CommonCPS.Server.EntityModel.OptionDesItem GetOptionByID(int optionID_Int)
		{
			short num;
			for (;;)
			{
				if (this.OptionsList == null)
				{
					num = (short)1475010012;
					short num2 = num;
					num = (short)967433692;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_79;
					}
					break;
				}
				goto IL_B8;
			}
			num = (short)522387456;
			short num3 = num;
			IL_79:
			num = (short)1295581184;
			if (num != 0)
			{
			}
			num = (short)1807548417;
			if (num != 0)
			{
			}
			return null;
			IL_B8:
			return this.OptionsList.FirstOrDefault(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.OptionDesItem, bool>(c.b));
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x00086964 File Offset: 0x00084B64
		public global::Motorola.CommonCPS.Server.EntityModel.OptionDesItem GetOptionByID(global::Motorola.CommonCPS.Server.EntityModel.GenericModel.OptionIDDefinition optionID)
		{
			short num;
			for (;;)
			{
				if (this.OptionsList != null)
				{
					goto IL_B6;
				}
				num = (short)1167851521;
				if (num != 0)
				{
				}
				num = (short)1233649664;
				short num2 = num;
				num = (short)503247744;
				short num3 = num;
				num = (short)579138432;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_9F;
				}
			}
			IL_9F:
			num = (short)1584332800;
			if (num != 0)
			{
			}
			return null;
			IL_B6:
			return this.OptionsList.FirstOrDefault(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.OptionDesItem, bool>(d.b));
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x00086A40 File Offset: 0x00084C40
		public global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.EntityModel.OptionDesItem, int> GetOptionDesItemDic()
		{
			int a_ = 4;
			short num = (short)891748352;
			short num2 = num;
			num = (short)839442303;
			short num3 = num;
			num = (short)1235083135;
			global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.EntityModel.OptionDesItem, int> dictionary;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1375076352;
				if (num != 0)
				{
				}
				dictionary = new global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.EntityModel.OptionDesItem, int>();
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.OptionDesItem>.Enumerator enumerator = this.OptionsList.GetEnumerator())
				{
					num = (short)1992359937;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							num = (short)1483079681;
							if (num != 0)
							{
							}
							break;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_D0;
							}
							continue;
						case 2:
						{
							global::Motorola.CommonCPS.Server.EntityModel.OptionDesItem optionDesItem;
							if (dictionary.Keys.Select(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.OptionDesItem, int>(global::Motorola.CommonCPS.Server.EntityModel.OptionsCollection.<>c.<>9.a)).Contains(optionDesItem.OptionID.OptionInt))
							{
								num = (short)291438598;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							dictionary.Add(optionDesItem, 1);
							num = (short)856031232;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							num = (short)871366660;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_203;
						case 5:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)106823683;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Server.EntityModel.OptionDesItem optionDesItem = enumerator.Current;
							num = (short)931397634;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							goto IL_12E;
						}
						IL_133:
						num = (short)934150149;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_D0:
						goto IL_133;
					}
					IL_12E:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("倁愃攅朇砉栋⸍砏猑戓猕㠗縙椛渝䰟䬡䜣䜥尧䌩䌫䀭ု崱䐳䈵儷唹刻", a_));
					IL_203:;
				}
				break;
			}
			return dictionary;
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06000C80 RID: 3200 RVA: 0x00086C80 File Offset: 0x00084E80
		public bool IsNeedToSerialize
		{
			get
			{
				short num = (short)1337655297;
				if (num != 0)
				{
				}
				if (this.OptionsList == null)
				{
					num = (short)1983705520;
					short num2 = num;
					num = (short)1800073648;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)506724352;
						if (num != 0)
						{
						}
						return false;
					}
				}
				num = (short)5373952;
				short num3 = num;
				return this.OptionsList.Count > 0;
			}
		}

		// Token: 0x020000A5 RID: 165
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x06000C82 RID: 3202 RVA: 0x00086D54 File Offset: 0x00084F54
			internal bool b(global::Motorola.CommonCPS.Server.EntityModel.OptionDesItem A_0)
			{
				short num;
				if (A_0.OptionID.OptionInt != this.a.OptionID.OptionInt)
				{
					num = (short)1284118251;
					short num2 = num;
					num = (short)1108743915;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)113573889;
						if (num != 0)
						{
						}
						num = (short)574226432;
						if (num != 0)
						{
						}
						return false;
					}
				}
				num = (short)925630464;
				short num3 = num;
				return A_0.OptionProductFamily == this.a.OptionProductFamily;
			}

			// Token: 0x040005EC RID: 1516
			public global::Motorola.CommonCPS.Server.EntityModel.OptionDesItem a;
		}

		// Token: 0x020000A6 RID: 166
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class b
		{
			// Token: 0x06000C84 RID: 3204 RVA: 0x00086E44 File Offset: 0x00085044
			internal bool b(global::Motorola.CommonCPS.Server.EntityModel.OptionDesItem A_0)
			{
				short num = (short)1251999744;
				short num2 = num;
				num = (short)1248396404;
				short num3 = num;
				num = (short)659817588;
				switch (num3 == num)
				{
				}
				num = (short)1063321601;
				if (num != 0)
				{
				}
				num = (short)654901248;
				if (num != 0)
				{
				}
				return A_0.OptionID.OptionInt == this.a;
			}

			// Token: 0x040005ED RID: 1517
			public int a;
		}

		// Token: 0x020000A7 RID: 167
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class c
		{
			// Token: 0x06000C86 RID: 3206 RVA: 0x00086F18 File Offset: 0x00085118
			internal bool b(global::Motorola.CommonCPS.Server.EntityModel.OptionDesItem A_0)
			{
				short num = (short)1420951552;
				short num2 = num;
				num = (short)1437921981;
				short num3 = num;
				num = (short)1244590781;
				switch (num3 == num)
				{
				}
				num = (short)1051656193;
				if (num != 0)
				{
				}
				num = (short)1876557824;
				if (num != 0)
				{
				}
				return A_0.OptionID.OptionInt == this.a;
			}

			// Token: 0x040005EE RID: 1518
			public int a;
		}

		// Token: 0x020000A8 RID: 168
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class d
		{
			// Token: 0x06000C88 RID: 3208 RVA: 0x00086FEC File Offset: 0x000851EC
			internal bool b(global::Motorola.CommonCPS.Server.EntityModel.OptionDesItem A_0)
			{
				short num = (short)1961099264;
				short num2 = num;
				num = (short)2091241781;
				short num3 = num;
				num = (short)1372639541;
				switch (num3 == num)
				{
				}
				num = (short)1530134528;
				if (num != 0)
				{
				}
				num = (short)687669249;
				if (num != 0)
				{
				}
				return A_0.OptionID == this.a;
			}

			// Token: 0x040005EF RID: 1519
			public global::Motorola.CommonCPS.Server.EntityModel.GenericModel.OptionIDDefinition a;
		}
	}
}
