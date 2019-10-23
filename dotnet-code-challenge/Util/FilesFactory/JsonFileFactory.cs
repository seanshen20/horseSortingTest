namespace dotnet_code_challenge.Util.FilesFactory
{
    public class JsonFileFactory : FileFactory
    {
        public override IReader Create() => new JsonReader();
    }
}
