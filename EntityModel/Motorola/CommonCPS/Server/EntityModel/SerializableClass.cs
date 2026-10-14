using System;
using System.Runtime.Serialization;
using Motorola.CommonCPS.CommonContract;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000191 RID: 401
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class SerializableClass<T>
	{
		// Token: 0x06001563 RID: 5475 RVA: 0x000E3D88 File Offset: 0x000E1F88
		public string SerializeToXML()
		{
			short num = (short)1129706499;
			short num2 = num;
			num = (short)221770755;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1006764032;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)644939777;
			if (num != 0)
			{
			}
			num = (short)1204879360;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.CommonContract.Serializer.Serialize_ToXMLString(this);
		}

		// Token: 0x06001564 RID: 5476 RVA: 0x000E3E38 File Offset: 0x000E2038
		public static T DeserializeFromXML(string xmlString)
		{
			short num = (short)1288306689;
			if (num != 0)
			{
			}
			num = (short)632029184;
			short num2 = num;
			num = (short)1601984929;
			short num3 = num;
			num = (short)870472097;
			switch (num3 == num)
			{
			}
			num = (short)1875640320;
			if (num != 0)
			{
			}
			return (T)((object)global::Motorola.CommonCPS.CommonContract.Serializer.Deserialize_FromXMLString(xmlString, typeof(T)));
		}
	}
}
