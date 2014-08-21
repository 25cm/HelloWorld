using System;
using System.Collections.Generic;
using System.Text;

using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace MapWorksViewer.MapWorks
{
    class SettingFile
    {
  	    //******************************************************************************
        //                           SettingFile
	    //******************************************************************************

	    //******************************************************************************
	    //                           汎用関数(ﾗｲﾌﾞﾗﾘ)
	    //******************************************************************************

        /// <summary>
        /// 設定ファイル名（XML）
        /// </summary>
        public static string xmlFileName = "MapWorksViewer.xml";
        /// <summary>
        /// 設定ファイル情報保持クラス
        /// </summary>
        public static XmlInitial xmlPara = new XmlInitial();

        /// <summary>
        /// XMLファイル読み込み
        /// </summary>
        /// <param name="filePath">XMLファイルパス</param>
        public static void ReadXml(string filePath)
        {
            if (File.Exists(filePath))
            {
                XmlSerializer xs = new XmlSerializer(typeof(XmlInitial));
                // TODO 暫定でReadを指定
                FileStream tr = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                try
                {
                    xmlPara = (XmlInitial)xs.Deserialize(tr);
                }
                catch
                {
                    xmlPara = new XmlInitial();
                }
                finally
                {
                    tr.Close();
                }
            }
            else
            {
                xmlPara = new XmlInitial();
            }
        }

        /// <summary>
        /// XMLファイル書き込み
        /// </summary>
        /// <param name="filePath">XMLファイルパス</param>
        public static void WriteXml(string filePath)
        {
            XmlSerializer xs = new XmlSerializer(typeof(XmlInitial));
            TextWriter tw = new StreamWriter(filePath);
            try
            {
                xs.Serialize(tw, xmlPara);
            }
            catch(Exception ex)
            {
                MessageBox.Show("設定ファイル保存時にエラーが発生しました。\n" + ex.Message, "設定ファイル保存エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                tw.Close();
            }
        }
    }
}
