namespace CrystalQuartz.WebFramework.HttpAbstractions
{
    using System;
    using System.IO;
    using System.Threading.Tasks;

    public class Response
    {
        private readonly string _contentType;
        private readonly int _statusCode;
        private readonly Func<Stream, Task> _contentFiller;

        public Response(string contentType, int statusCode, Func<Stream, Task> contentFiller)
        {
            _contentType = contentType;
            _statusCode = statusCode;
            _contentFiller = contentFiller;
        }

        public string ContentType
        {
            get { return _contentType; }
        }

        public int StatusCode
        {
            get { return _statusCode; }
        }

        public Func<Stream, Task> ContentFiller
        {
            get { return _contentFiller; }
        }
    }
}