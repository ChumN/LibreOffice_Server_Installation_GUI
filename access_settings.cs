using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace WindowsFormsApplication1
{
    class access_settings
    {
      public SETTINGS  open_settings()
        {
            SETTINGS value = new SETTINGS();
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(SETTINGS));
                StreamReader sr = new StreamReader(@getpath());
                value = (SETTINGS)ser.Deserialize(sr);
                sr.Close();
            }
            catch (Exception )
            {}
            return value;
        }
      private string getpath()
      {
          return  Path.GetTempPath() + "libosigui.settings";
          
      }

      public void  save_settings(SETTINGS set)
        {
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(SETTINGS));
                FileStream str = new FileStream(@getpath(), FileMode.Create);
                ser.Serialize(str, set);
                str.Close();
            }
            catch (Exception)
            { }
    }
      public string[] update_manager_array(string[] old_array, string toadd)
      {
           int arrylength = old_array.Length + 1;
           if (old_array == null)
               arrylength = 1;
               string[] new_array = new string[arrylength];
               if (old_array != null)
               {
                   for (int i = 0; i <= (arrylength - 2); i++)
                   {
                       new_array[i] = old_array[i];
                   }
               }
          new_array[arrylength - 1] = toadd;
          return new_array;
      }
    }
}
public class SETTINGS
{
    public string installdir;
    public string subfolder;
    public bool checkbox;
    public int lang;
    public string l10n;
    public string[] manager;
}