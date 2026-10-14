namespace SpecialFeatures
{
    using Motorola.Common.CustomException;
    using Motorola.CommonCPS.ResourceRepository;
    using System;
    using System.Runtime.InteropServices;
    using System.ServiceModel;

    public class CommonExceptionHelper
    {
        public static readonly CommonErrorCode DirectMsgCode;

        static unsafe CommonExceptionHelper()
        {
            short num;
            short num1;
            short num2;
            switch ((((short) *(((short*) &-32720))) == ((short) *(((short*) &-32720)))))
            {
                case 1:
                    break;

                default:
                {
                TR_0005:
                    num1 = (short) *(((short*) &0));
                    short local1 = num1;
                    break;
                }
            }
        TR_0003:
            if (((short) *(((short*) &0))) != null)
            {
            }
        TR_0002:
            num2 = (short) *(((short*) &1));
        TR_0001:
            if (num2 != null)
            {
            }
        TR_0000:
            DirectMsgCode = 0x802;
            return;
        }

        public CommonExceptionHelper()
        {
            base..ctor();
            return;
        }

        internal static unsafe void ConvertExceptiontAndThrow(Exception ex)
        {
            CommonException exception;
            CommonErrorCode code;
            FaultException<CommonExceptionData> exception2;
            int num;
            short num2;
            short num1;
            short num3;
            num2 = 5;
            num = (IntPtr) ((short) *(((short*) &num2)));
            goto TR_001F;
        TR_0002:
            if ((ex as CommonException) == null)
            {
                num = (IntPtr) ((short) *(((short*) &0)));
            }
            else
            {
                num2 = 1;
                num = (IntPtr) ((short) *(((short*) &num2)));
            }
            goto TR_001F;
        TR_001F:
            while (true)
            {
                num2 = 1;
                num1 = (short) *(((short*) &num2));
            TR_001D:
                if (num1 != null)
                {
                }
            TR_001C:
                switch (num)
                {
                    case 0:
                    {
                        if ((ex as FaultException<CommonExceptionData>) != null)
                        {
                            num2 = 6;
                            num = (IntPtr) ((short) *(((short*) &num2)));
                        }
                        else
                        {
                            num2 = 8;
                            num = (IntPtr) ((short) *(((short*) &num2)));
                        }
                        continue;
                    }
                    case 1:
                        break;

                    case 2:
                        throw ex;

                    case 3:
                    {
                        if (exception.get_ErrorCode() != DirectMsgCode)
                        {
                            num2 = 0xa47;
                            switch ((((short) *(((short*) &num2))) == ((short) *(((short*) &0xa47)))))
                            {
                                case 0:
                                case 2:
                                    break;

                                default:
                                {
                                TR_000A:
                                    num2 = 0;
                                    if (((short) *(((short*) &num2))) != null)
                                    {
                                    }
                                TR_0009:
                                    throw CreateCommonException(exception.get_ErrorCode(), ResourceHelper.GetCommonErrorMessageByID(&exception.get_ErrorCode().ToString(), null), ex);
                                }
                            }
                            break;
                        }
                        num2 = 2;
                        num = (IntPtr) ((short) *(((short*) &num2)));
                        continue;
                    }
                    case 4:
                    {
                        num = (IntPtr) ((short) *(((short*) &9)));
                        continue;
                    }
                    case 5:
                        switch (0)
                        {
                            case 0:
                                break;

                            default:
                            {
                                continue;
                            }
                        }
                        goto TR_0002;

                    case 6:
                        exception2 = ex as FaultException<CommonExceptionData>;
                        throw CreateCommonException(exception2.Detail.get_ErrorCode(), ResourceHelper.GetCommonErrorMessageByID(&exception2.Detail.get_ErrorCode().ToString(), null), ex);

                    case 7:
                    {
                        if ((ex as TimeoutException) == null)
                        {
                            return;
                        }
                        num3 = (short) *(((short*) &0));
                        short local1 = num3;
                        num2 = 10;
                        num = (IntPtr) ((short) *(((short*) &num2)));
                        continue;
                    }
                    case 8:
                    {
                        num = ((ex as CommunicationException) == null) ? ((IntPtr) ((short) *(((short*) &7)))) : ((IntPtr) ((short) *(((short*) &4))));
                        continue;
                    }
                    case 9:
                    {
                        if ((ex as EndpointNotFoundException) == null)
                        {
                            throw CreateCommonException(0x34, Resources.get_CommunicationServiceCommunicationError(), ex);
                        }
                        num2 = 11;
                        num = (IntPtr) ((short) *(((short*) &num2)));
                        continue;
                    }
                    case 10:
                        throw CreateCommonException(0x33, Resources.get_CommunicationServiceTimeout(), ex);

                    case 11:
                        throw CreateCommonException(50, Resources.get_CommunicationServiceNotAvailabe(), ex);

                    default:
                        goto TR_0002;
                }
            TR_0006:
                exception = ex as CommonException;
                num = (IntPtr) ((short) *(((short*) &3)));
            }
            goto TR_0002;
        }

        public static unsafe CommonException CreateCommonException(CommonErrorCode errorID, string message, Exception ex)
        {
            short num;
            short num1;
            short num2;
            switch ((((short) *(((short*) &-16241))) == ((short) *(((short*) &-16241)))))
            {
                case 0:
                case 2:
                    break;

                default:
                {
                TR_0006:
                    num = 0;
                    if (((short) *(((short*) &num))) != null)
                    {
                    }
                TR_0005:
                    if (ex == null)
                    {
                        break;
                    }
                    num = 0;
                    num2 = (short) *(((short*) &num));
                    short local1 = num2;
                    return new CommonException(errorID, message, ex);
                }
            }
        TR_0002:
            num1 = (short) *(((short*) &1));
        TR_0001:
            if (num1 != null)
            {
            }
        TR_0000:
            return new CommonException(errorID, message, new Exception());
        }

        public static unsafe CommonException CreateDirectMessageCommonException(string message)
        {
            short num;
            short num1;
            short num2;
            num = -9022;
            num = -9022;
            switch ((((short) *(((short*) &num))) == ((short) *(((short*) &num)))))
            {
                case 1:
                    break;

                default:
                {
                TR_0005:
                    num = 0;
                    num1 = (short) *(((short*) &num));
                    short local1 = num1;
                    break;
                }
            }
        TR_0003:
            num2 = (short) *(((short*) &1));
        TR_0002:
            if (num2 != null)
            {
            }
        TR_0001:
            if (((short) *(((short*) &0))) != null)
            {
            }
        TR_0000:
            return new CommonException(DirectMsgCode, message);
        }
    }
}

