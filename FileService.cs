using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace LuyenDe1
{
    internal class FileService
    {
        private static FileStream _fs;
        private static BinaryFormatter _bf;
        public static string SaveFile(string path, List<LapTop> data)
        {
            _fs = new FileStream(path, FileMode.Create);
            _bf = new BinaryFormatter();
            _bf.Serialize(_fs, data);
            _fs.Close();
            return "Lưu thành công";
        }
        public static string ReadFile(string path)
        {
            List<LapTop> _lstdata = new List<LapTop>();
            _fs = new FileStream(path, FileMode.Open);
            _bf = new BinaryFormatter();
            var data = _bf.Deserialize(_fs);
            _lstdata = (List<LapTop>)data;
            return _lstdata.Count.ToString();
        }
    }
}
