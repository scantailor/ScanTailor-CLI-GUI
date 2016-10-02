using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ScanTailor_CLI_GUI
{
    public class ProfileString
    {
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section,string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section,string key, string def, byte[] retVal, int size, string filePath);
        [DllImport("kernel32.dll")]
        private static extern int GetVolumeInformation(string lpRootPathName, string lpVolumeNameBuffer, int nVolumeNameSize, int lpVolumeSerialNumber, int lpMaximumComponentLength, ref int lpFileSystemFlags, string lpFileSystemNameBuffer, int nFileSystemNameSize);
        private const int FILE_READ_ONLY_VOLUME = 0x00080000;

        public string IniFile;
        public bool IsIniReadOnly;
        public string Section { get; set; }

        public ProfileString(string iniPath, string section = "Settings")
        {
            IniFile = iniPath;
            Section = section;
            IsIniReadOnly = IsDriveReadOnly(IniFile);
        }
        public bool IsDriveReadOnly(string path)
        {
            var bret = false;
            var rpath = Path.GetPathRoot(path);
            if (!String.IsNullOrEmpty(rpath))
            {
                rpath = rpath.TrimEnd('\\');
                rpath += "\\";
                var flags = 0;
                if (GetVolumeInformation(rpath, null, 0, 0, 0, ref flags, null, 0) != 0)
                {
                    flags &= FILE_READ_ONLY_VOLUME;
                    if (flags == FILE_READ_ONLY_VOLUME)
                    {
                        bret = true;
                    }
                    else
                    {
                        rpath = Path.GetDirectoryName(path) + "\\Test.txt";
                        using (StreamWriter writer = new StreamWriter(rpath))
                        {
                        }
                        if (File.Exists(rpath))
                        {
                            File.Delete(rpath);
                        }
                        else
                        {
                            bret = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Internal error #0000001", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("The drive of the path:[" + path + "] does not exist!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bret = true;
            }
            return bret;
        }

        public void Write(string section, string key, string value)
        {
            if (!IsIniReadOnly)
            {

                WritePrivateProfileString(section, key, value, IniFile);
            }
        }
        public void Write(string key, string value)
        {
            Write(Section, key, value);
        }
        public void Write(string key, bool value)
        {
            Write(Section, key, value.ToString());
        }
        public void Write(string section, string key, bool value)
        {
            Write(section, key, value.ToString());
        }
        public void Write(string key, int value)
        {
            Write(Section, key, value.ToString());
        }
        public void Write(string section, string key, int value)
        {
            Write(section, key, value.ToString());
        }
        public void Write(string key, double value)
        {
            Write(Section, key, value.ToString());
        }
        public void Write(string section, string key, double value)
        {
            Write(section, key, value.ToString());
        }
        public void Write(string key, decimal value)
        {
            Write(Section, key, value.ToString());
        }
        public void Write(string section, string key, decimal value)
        {
            Write(section, key, value.ToString());
        }

        public string Read(string key)
        {
            return Read(Section, key);
        }
        public string Read(string section, string key)
        {
            var barray = new byte[255];
            GetPrivateProfileString(section, key, "", barray, 255, IniFile);
            return Encoding.ASCII.GetString(barray).TrimEnd('\0');
        }
        public bool ReadBool(string key)
        {
            return ReadBool(Section, key);
        }
        public bool ReadBool(string key, bool rettrue = false)
        {
            return ReadBool(Section, key, rettrue);
        }
        public bool ReadBool(string section, string key, bool rettrue = false)
        {
            bool bRetv;
            var barray = new byte[255];
            GetPrivateProfileString(section, key, "", barray, 255, IniFile);
            try
            {
                bRetv = Convert.ToBoolean(Encoding.ASCII.GetString(barray).TrimEnd('\0'));
            }
            catch
            {
                bRetv = rettrue;
            }
            return bRetv;
        }
        public int ReadInt(string key)
        {
            return ReadInt(Section, key);
        }
        public int ReadInt(string key, int retminusone = -1)
        {
            return ReadInt(Section, key, retminusone);
        }
        public int ReadInt(string section, string key, int retminusone = -1)
        {
            int iRetv;
            var barray = new byte[255];
            GetPrivateProfileString(section, key, "", barray, 255, IniFile);
            try
            {
                iRetv = Convert.ToInt32(Encoding.ASCII.GetString(barray).TrimEnd('\0'));
            }
            catch
            {
                iRetv = retminusone;
            }
            return iRetv;
        }
        public double ReadDouble(string key)
        {
            return ReadDouble(Section, key);
        }
        public double ReadDouble(string key, double retminusone = -1)
        {
            return ReadDouble(Section, key, retminusone);
        }
        public double ReadDouble(string section, string key, double retminusone = -1)
        {
            double iRetv;
            var barray = new byte[255];
            GetPrivateProfileString(section, key, "", barray, 255, IniFile);
            try
            {
                iRetv = Convert.ToDouble(Encoding.ASCII.GetString(barray).TrimEnd('\0'));
            }
            catch
            {
                iRetv = retminusone;
            }
            return iRetv;
        }
        public decimal ReadDecimal(string key)
        {
            return ReadDecimal(Section, key);
        }
        public decimal ReadDecimal(string key, decimal retminusone = -1)
        {
            return ReadDecimal(Section, key, retminusone);
        }
        public decimal ReadDecimal(string section, string key, decimal retminusone = -1)
        {
            decimal iRetv;
            var barray = new byte[255];
            GetPrivateProfileString(section, key, "", barray, 255, IniFile);
            try
            {
                iRetv = Convert.ToDecimal(Encoding.ASCII.GetString(barray).TrimEnd('\0'));
            }
            catch
            {
                iRetv = retminusone;
            }
            return iRetv;
        }
    }
}
