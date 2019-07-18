namespace FilesKeeper.DataBase.Models
{
    public class FileModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string OriginalName { get; set; }
        public string Extension { get; set; }
        public bool Compressed { get; set; }
        public long FullSize { get; set; }
        public long CompressedSize { get; set; }

        public byte[] ByteArray { get; set; }
    }
}
