// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Globalization;
using System.Security;
using System.Windows.Data;

namespace Microsoft.Test.DataServices
{
    [SecurityCritical]
    public class CultureConverter : IValueConverter
    {
        #region IValueConverter Members

        [SecurityCritical]
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            return (string)value + ": " + culture.DisplayName;
        }

        [SecurityCritical]
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion
    }

}
