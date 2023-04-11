namespace TESTCasee
{
    public class SortFile
    {
        string path = @"C:\111.txt";
        public void Sort()
        {
            var contents = File.ReadAllLines(path);
            Array.Sort(contents);
            File.WriteAllLines(path, contents);
        }
    }
}
