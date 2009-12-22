using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace HTTPRequester
{
    class Utility
    {
        public static Color GetRandomColor(int offset, int randRange)
        {
            Random rand = new Random();

            int r = rand.Next(randRange);
            int g = rand.Next(randRange);
            int b = rand.Next(randRange);

            return Color.FromArgb(r + offset, g + offset, b + offset);
        }

        public static byte[] GetBytesFromStream(Stream stream)
        {
            BinaryReader reader = new BinaryReader(stream);
            MemoryStream memContent = new MemoryStream();
            int bufSize = 2048;
            int readBytes = 0;
            int contentSize = 0;
            byte[] buffer = new byte[bufSize];
            do
            {
                readBytes = reader.Read(buffer, 0, bufSize);
                Console.Write(""+readBytes+", ");
                memContent.Write(buffer, 0, readBytes);
                contentSize += readBytes;
            } while (readBytes > 0);
            reader.Close();
            byte []returnContent = new byte[contentSize];
            memContent.Seek(0, SeekOrigin.Begin);
            memContent.Read(returnContent, 0, contentSize);
            memContent.Close();

            return returnContent;
        }

        public static byte[] ReadFileBytes(string filepath)
        {
            return GetBytesFromStream(new FileStream(filepath, FileMode.Open));
        }

        public static void WriteFileBytes(string filepath, byte[] content)
        {
            BinaryWriter writer = new BinaryWriter(new FileStream(filepath, FileMode.Create, FileAccess.Write));
            writer.Write(content, 0, content.Length);
            writer.Close();
        }
    }
}
