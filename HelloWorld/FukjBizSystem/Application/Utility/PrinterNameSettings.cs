using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zynas.Framework.Utility;

namespace FukjBizSystem.Application.Utility
{
    public class PrinterNameSettings : PortableSimpleXMLSetting
    {
        private static PrinterNameSettings defaultInstance = new PrinterNameSettings();

        public static PrinterNameSettings Default
        {
            get { return defaultInstance; }
        }

        public PrinterNameSettings() :
            base(Constants.PrinterConstant.PRINTER_SETTING_FILE_PATH
            , Constants.PrinterConstant.PRINTER_SETTING_SECTION
            , Constants.PrinterConstant.PRINTER_KEY_LIST
            , Constants.PrinterConstant.PRINTER_DISP_NAME_LIST)
        {

        }
    }
}
