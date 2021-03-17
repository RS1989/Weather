using System.Collections.Generic;

namespace MD.HttpService
{
    public interface IHttpService
    {
        string Get(Dictionary<string, string> param, string url);
    }
}