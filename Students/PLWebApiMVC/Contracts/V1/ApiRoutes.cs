namespace PLWebApiMVC.Contracts.V1
{
    public static class ApiRoutes
    {
        public const string Root = "api";
        public const string Version = "v1";
        public const string Base = Root + "/" + Version;

        public static class Students
        {
            public const string Path = "/students";

            public const string GetAll = Base + Path;
            public const string Get = Base + Path + "/{id}";
            public const string Create = Base + Path;
            public const string Update = Base + Path;
            public const string Delete = Base + Path + "/{id}";
        }
    }
}