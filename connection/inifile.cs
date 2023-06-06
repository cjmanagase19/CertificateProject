using System.Runtime.InteropServices;
using System.Text;

namespace Kalinderya_Online_Api_Practice.Helper
{
    public class IniFile
    {
        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        private static extern int GetPrivateProfileString(string section, string key, string defaultValue, StringBuilder value, int size, string path);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        private static extern bool WritePrivateProfileString(string section, string key, string value, string path);

        private readonly string _path;

        public IniFile(string path)
        {
            _path = path;
        }

        public string ReadValue(string section, string key, string defaultValue = "")
        {
            var value = new StringBuilder(255);
            GetPrivateProfileString(section, key, defaultValue, value, value.Capacity, _path);
            return value.ToString();
        }

        public void WriteValue(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, _path);
        }
    }
}
