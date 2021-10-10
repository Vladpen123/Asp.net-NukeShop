using BLL.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WebUI.Infrastructure;

namespace WebUI.Models
{
    public class SessionFavorites : Favorites
    {
        [JsonIgnore]
        public ISession Session { get; set; }

        public static Favorites GetFavorites(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
            .HttpContext.Session;
            SessionFavorites favorites = session?.GetJson<SessionFavorites>("Favorites")
            ?? new SessionFavorites();
            favorites.Session = session;
            return favorites;
        }

        public override void AddItem(GoodDTO good)
        {
            base.AddItem(good);
            Session.SetJson("Favorites", this);
        }

        public override void Clear()
        {
            base.Clear();
            Session.SetJson("Favorites", this);
        }

        public override void RemoveLine(GoodDTO good)
        {
            base.RemoveLine(good);
            Session.SetJson("Favorites", this);
        }
    }
}
