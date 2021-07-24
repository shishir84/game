namespace Play.Catalog.Service.Settings
{
    public class MongoDbSettings
    {
        public string Host { get; init; }

        public int Port { get; init; }

        public string ConnectionString => $"mongodb://172.17.0.1:27017";
    }

    //mongodb://172.17.0.1:27017/?readPreference=primary&appname=mongodb-vscode%200.6.0&ssl=false
}