using System.IO;

namespace TESTCasee
{
    public class WriterLogsInFile
    {
        string path = @"C:\log.txt";
        public void ABOBA(string text)
        {
            using StreamWriter writer = new StreamWriter(path, true);
            writer.Write(text);
        }
    }
}
    