using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Input
{
	// Token: 0x02000264 RID: 612
	[global::System.Runtime.Serialization.DataContract]
	public class TouchPoint : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x060012E3 RID: 4835 RVA: 0x00014760 File Offset: 0x00012960
		// (set) Token: 0x060012E4 RID: 4836 RVA: 0x00014768 File Offset: 0x00012968
		[global::System.Runtime.Serialization.DataMember(Name = "x", IsRequired = true)]
		public double X { get; set; }

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x060012E5 RID: 4837 RVA: 0x00014771 File Offset: 0x00012971
		// (set) Token: 0x060012E6 RID: 4838 RVA: 0x00014779 File Offset: 0x00012979
		[global::System.Runtime.Serialization.DataMember(Name = "y", IsRequired = true)]
		public double Y { get; set; }

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x060012E7 RID: 4839 RVA: 0x00014782 File Offset: 0x00012982
		// (set) Token: 0x060012E8 RID: 4840 RVA: 0x0001478A File Offset: 0x0001298A
		[global::System.Runtime.Serialization.DataMember(Name = "radiusX", IsRequired = false)]
		public double? RadiusX { get; set; }

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x060012E9 RID: 4841 RVA: 0x00014793 File Offset: 0x00012993
		// (set) Token: 0x060012EA RID: 4842 RVA: 0x0001479B File Offset: 0x0001299B
		[global::System.Runtime.Serialization.DataMember(Name = "radiusY", IsRequired = false)]
		public double? RadiusY { get; set; }

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x060012EB RID: 4843 RVA: 0x000147A4 File Offset: 0x000129A4
		// (set) Token: 0x060012EC RID: 4844 RVA: 0x000147AC File Offset: 0x000129AC
		[global::System.Runtime.Serialization.DataMember(Name = "rotationAngle", IsRequired = false)]
		public double? RotationAngle { get; set; }

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x060012ED RID: 4845 RVA: 0x000147B5 File Offset: 0x000129B5
		// (set) Token: 0x060012EE RID: 4846 RVA: 0x000147BD File Offset: 0x000129BD
		[global::System.Runtime.Serialization.DataMember(Name = "force", IsRequired = false)]
		public double? Force { get; set; }

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x060012EF RID: 4847 RVA: 0x000147C6 File Offset: 0x000129C6
		// (set) Token: 0x060012F0 RID: 4848 RVA: 0x000147CE File Offset: 0x000129CE
		[global::System.Runtime.Serialization.DataMember(Name = "tangentialPressure", IsRequired = false)]
		public double? TangentialPressure { get; set; }

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x060012F1 RID: 4849 RVA: 0x000147D7 File Offset: 0x000129D7
		// (set) Token: 0x060012F2 RID: 4850 RVA: 0x000147DF File Offset: 0x000129DF
		[global::System.Runtime.Serialization.DataMember(Name = "tiltX", IsRequired = false)]
		public int? TiltX { get; set; }

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x060012F3 RID: 4851 RVA: 0x000147E8 File Offset: 0x000129E8
		// (set) Token: 0x060012F4 RID: 4852 RVA: 0x000147F0 File Offset: 0x000129F0
		[global::System.Runtime.Serialization.DataMember(Name = "tiltY", IsRequired = false)]
		public int? TiltY { get; set; }

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x060012F5 RID: 4853 RVA: 0x000147F9 File Offset: 0x000129F9
		// (set) Token: 0x060012F6 RID: 4854 RVA: 0x00014801 File Offset: 0x00012A01
		[global::System.Runtime.Serialization.DataMember(Name = "twist", IsRequired = false)]
		public int? Twist { get; set; }

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x060012F7 RID: 4855 RVA: 0x0001480A File Offset: 0x00012A0A
		// (set) Token: 0x060012F8 RID: 4856 RVA: 0x00014812 File Offset: 0x00012A12
		[global::System.Runtime.Serialization.DataMember(Name = "id", IsRequired = false)]
		public double? Id { get; set; }
	}
}
