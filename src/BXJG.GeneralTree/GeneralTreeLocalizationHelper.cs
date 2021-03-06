﻿using Abp.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BXJG.GeneralTree
{
    public static class GeneralTreeLocalizationHelper
    {
        public static string L(this string key)
        {
            return Abp.Localization.LocalizationHelper.GetString(GeneralTreeConsts.LocalizationSourceName, key);
        }

        public static ILocalizableString L1(this string key)
        {
            return new LocalizableString(key, GeneralTreeConsts.LocalizationSourceName);
        }
    }
}
