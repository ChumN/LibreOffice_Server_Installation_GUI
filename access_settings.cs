#region Licence
/*This file is part of the project "Reisisoft Server Install GUI",
 * which is licenced under LGPL v3+. You may find a copy in the source,
 * or obtain one at http://www.gnu.org/licenses/lgpl-3.0-standalone.html */
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using IWshRuntimeLibrary;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;

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
          return  Path.GetTempPath() + "libosigui.configuration";
          
      }
      public string program_version()
      { return "4.0.1"; }

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
          int arrylength = 1;
          if(old_array != null) 
           arrylength = old_array.Length + 1;
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
    public string last_path_to_sofficeEXE;
}
public class LINK
{
    public LINK()
    {

    }
    ResourceManager rm = new ResourceManager("WindowsFormsApplication1.strings", Assembly.GetExecutingAssembly());
    public void exeptionmessage(string ex_message)
    {
        MessageBox.Show(getstring("standarderror") + ex_message, getstring("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    public string getstring(string strMessage)
    {
        string rt = "???";
        try
        {
            rt = rm.GetString(strMessage);
        }
        catch (Exception)
        {
            exeptionmessage("An error in the l10n part occured!");
        }
        return rt;
    }
    public void create_ink(string link_to_exe, string version)
    {

        bool ok = true;
        try
        {
            if (version == null || version == "")
                throw new Exception(getstring("ink_error_1"));
            WshShell wsh = new WshShell();
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) , "LibO Parallel " + version + ".lnk");
            IWshShortcut shortcut = (IWshShortcut)wsh.CreateShortcut(@path);
            string des = getstring("ink_des");
            des = des.Replace("%version",version);
            shortcut.Description = des;
            shortcut.TargetPath = link_to_exe;
            shortcut.Save();
        }
        catch (Exception ex)
        { exeptionmessage(ex.Message);
        ok = false;
        }
        if (ok)
            MessageBox.Show(getstring("msb_lnk_txt"), getstring("msb_lnk_title"), MessageBoxButtons.OK);
    }
}
