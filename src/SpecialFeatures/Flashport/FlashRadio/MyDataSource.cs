namespace SpecialFeatures.Flashport.FlashRadio
{
    using System;
    using System.Collections.ObjectModel;

    public class MyDataSource
    {
        public MyDataSource();
        public static ObservableCollection<SystemKeyData> GetLoadedASKWithoutDefault();
    }
}

