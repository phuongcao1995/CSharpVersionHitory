using System.IO;

namespace UsingDeclarations
{
    public class ExtendStreamReader : StreamReader
    {
        public ExtendStreamReader(string path) : base(path)
        {

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
