using System;
using Haru.Hashing;
using Haru.IO;
using Haru.Converters;

namespace Haru.ServerData.Tables
{
    public class JsonTable
    {
        private readonly Resx _resx;
        public string Data { get; private set; }
        public uint Hash { get; private set; }

        public JsonTable()
        {
            _resx = new Resx(GetType().Assembly);
        }

        public void Load(string path)
        {
            // import
            var data = _resx.GetText(path);
            Set(data);

            // log
            var hex = "0x" + Hash.ToString("X");
            Console.WriteLine("[database]: Loaded " + hex + ", " + path);
        }

        public void Set(string data)
        {
            Data = data;

            // hash
            var bytes = Utf8.ToBytes(Data);
            Hash = Crc32.Compute(bytes);

            // set crc in cached response
            Data = Data.Remove(Data.Length - 1);
            Data += ",\"crc\":" + Hash + "}";
        }
    }
}