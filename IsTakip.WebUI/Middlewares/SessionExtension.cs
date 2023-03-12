using Microsoft.Extensions.FileProviders;
using Newtonsoft.Json;

namespace IsTakip.WebUI.Middlewares
{
    public static class SessionExtension
    {
        public static void SetSessionObject(this ISession session, string key, object nesne)
        {
            string nesneJson = JsonConvert.SerializeObject(nesne);
            session.SetString(key, nesneJson);
        }

        public static T GetSessionObject<T>(this ISession session, string key)
            where T : class, new()
        {
            string sessionKey = session.GetString(key);
            if (sessionKey != null)
            {
                return JsonConvert.DeserializeObject<T>(sessionKey);
            }
            return null;
        }
    }
}
