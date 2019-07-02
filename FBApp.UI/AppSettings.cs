using System.IO;
using System.Reflection;
using System.Xml.Serialization;

namespace FBApp.UI
{
    public sealed class AppSettings
    {
        private static volatile AppSettings s_Instance;
        private static object s_lockObject = new object();

        public static AppSettings Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (s_lockObject)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new AppSettings();
                        }
                    }
                }

                return s_Instance;
            }
        }

        public bool RememberMe { get; set; }

        public string LastAccessToken { get; set; }

        private AppSettings()
        {
            RestoreDefault();
        }

        public void SaveToFile()
        {
            using (Stream stream = new FileStream(@"AppSettings.xml", FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }

        public void LoadFromFile()
        {
            if (File.Exists(@"AppSettings.xml"))
            {
                using (Stream stream = new FileStream(@"AppSettings.xml", FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    AppSettings appsettingsFromFile = serializer.Deserialize(stream) as AppSettings;
                    foreach (PropertyInfo property in appsettingsFromFile.GetType().GetProperties())
                    {
                        if (property.GetSetMethod() != null)
                        {
                            s_Instance.GetType().GetProperty(property.Name).SetValue(s_Instance, property.GetValue(appsettingsFromFile, null), null);
                        }
                    }
                }
            }
            else
            {
                // make default xml file if it was missing
                s_Instance.RestoreDefault();
                s_Instance.SaveToFile();
            }
        }

        public void RestoreDefault()
        {
            RememberMe = false;
            LastAccessToken = null;
        }
    }
}
