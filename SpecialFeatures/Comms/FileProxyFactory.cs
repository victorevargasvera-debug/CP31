using System;
using System.Diagnostics;
using System.Windows;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.ResourceRepository;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Comms
{
	// Token: 0x02000165 RID: 357
	public class FileProxyFactory
	{
		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06001202 RID: 4610 RVA: 0x00187830 File Offset: 0x00185A30
		public static global::SpecialFeatures.Comms.FileProxyFactory Instance
		{
			get
			{
				short num = (short)1672431989;
				short num2 = num;
				num = (short)698501493;
				switch (num2 == num)
				{
				}
				num = (short)2068512769;
				if (num != 0)
				{
				}
				num = (short)1548156928;
				if (num != 0)
				{
				}
				num = (short)1138884608;
				short num3 = num;
				return global::SpecialFeatures.Comms.FileProxyFactory.a;
			}
		}

		// Token: 0x06001203 RID: 4611 RVA: 0x000036B9 File Offset: 0x000018B9
		public FileProxyFactory()
		{
			this._proxyParameter = new global::SpecialFeatures.Comms.ProxyParameter();
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x001878DC File Offset: 0x00185ADC
		internal global::SpecialFeatures.Comms.IDeviceProxy GetDevice(object arg, global::Motorola.Common.Communication.CommonUtil.RadioOperation radioOperation)
		{
			short num = (short)94213241;
			short num2 = num;
			num = (short)776967289;
			switch (num2 == num)
			{
			}
			num = (short)1819934721;
			if (num != 0)
			{
			}
			num = (short)1420427264;
			if (num != 0)
			{
			}
			num = (short)1979908096;
			short num3 = num;
			return this.CreateDevice(new global::SpecialFeatures.Comms.ProxyParameter
			{
				RadioParams = (global::SpecialFeatures.Comms.RadioParams)arg,
				RadioOperation = radioOperation,
				AstroDeviceInfo = this._proxyParameter.AstroDeviceInfo,
				DeviceFile = this._proxyParameter.DeviceFile
			});
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x001879C8 File Offset: 0x00185BC8
		public virtual bool SetupVirtualProxy(string deviceFile, global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo deviceInfo)
		{
			int a_ = 3;
			short num = (short)2069757953;
			if (num != 0)
			{
			}
			num = (short)503700202;
			short num2 = num;
			num = (short)565697258;
			switch (num2 == num)
			{
			}
			num = (short)1546321920;
			if (num != 0)
			{
			}
			num = (short)1036255232;
			short num3 = num;
			bool flag = (bool)global::System.Windows.Application.Current.Properties[global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얅ﺏ\ud893ﾕﾙ\udf9b캝", a_)];
			if (flag)
			{
				this._proxyParameter.DeviceFile = deviceFile;
				this._proxyParameter.AstroDeviceInfo = deviceInfo;
			}
			return flag;
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x00187ABC File Offset: 0x00185CBC
		protected virtual global::SpecialFeatures.Comms.IDeviceProxy CreateDevice(global::SpecialFeatures.Comms.ProxyParameter parameter)
		{
			int a_ = 5;
			short num;
			global::SpecialFeatures.Comms.IDeviceProxy result;
			try
			{
				num = (short)1444668026;
				short num2 = num;
				num = (short)1965482618;
				switch (num2 == num)
				{
				}
				num = (short)2113536000;
				if (num != 0)
				{
				}
				result = new global::SpecialFeatures.Comms.FileProxy(parameter.DeviceFile, parameter.AstroDeviceInfo);
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
			catch (global::System.Exception ex)
			{
				global::System.Diagnostics.Trace.WriteLine(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펇캉憐욕쎡잣튥잧\ud8a9햫첳햵\uddb7쪹좻ힽ꾿곁駃鷅诇룉꧋꿍꓏럑郓돕껗동뿛믝뷟\ud8e1쓣", a_) + ex.Message);
				throw global::SpecialFeatures.CommonExceptionHelper.CreateCommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, global::Motorola.CommonCPS.ResourceRepository.Resources.GenericError, ex);
			}
			num = (short)1725104128;
			short num3 = num;
			num = (short)760610817;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x00187BCC File Offset: 0x00185DCC
		// Note: this type is marked as 'beforefieldinit'.
		static FileProxyFactory()
		{
			short num = (short)680591361;
			if (num != 0)
			{
			}
			num = (short)1317686327;
			short num2 = num;
			num = (short)1184320567;
			switch (num2 == num)
			{
			}
			num = (short)2070151168;
			if (num != 0)
			{
			}
			num = (short)1986134016;
			short num3 = num;
			global::SpecialFeatures.Comms.FileProxyFactory.a = new global::SpecialFeatures.Comms.FileProxyFactory();
		}

		// Token: 0x040009CF RID: 2511
		protected global::SpecialFeatures.Comms.ProxyParameter _proxyParameter;

		// Token: 0x040009D0 RID: 2512
		private static global::SpecialFeatures.Comms.FileProxyFactory a;
	}
}
