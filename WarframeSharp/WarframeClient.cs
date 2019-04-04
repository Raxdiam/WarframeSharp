using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WarframeSharp.Converters;

namespace WarframeSharp
{
    public class WarframeClient
    {
        private readonly HttpClient _client;

        public WarframeClient()
        {
            _client = new HttpClient();
        }

        public async Task<WorldState>
            GetWorldStateAsync(Platform platform, CancellationToken? cancellationToken = null) =>
            await GetResponseAsync<WorldState>(null, platform, cancellationToken);

        public async Task<List<Arcane>> GetArcanesAsync(CancellationToken? cancellationToken = null) =>
            await GetResponseAsync<List<Arcane>>(Endpoint.Arcanes, null, cancellationToken);

        public async Task<List<Drop>> GetDropsAsync(CancellationToken? cancellationToken = null) =>
            await GetResponseAsync<List<Drop>>(Endpoint.Drops, null, cancellationToken);

        public async Task<List<Event>> GetEventsAsync(Platform platform, CancellationToken? cancellationToken = null) =>
            await GetResponseAsync<List<Event>>(Endpoint.Events, platform, cancellationToken);

        public async Task<List<Mod>> GetModsAsync(CancellationToken? cancellationToken = null) =>
            await GetResponseAsync<List<Mod>>(Endpoint.Mods, null, cancellationToken);

        public async Task<Sortie> GetSortieAsync(Platform platform, CancellationToken? cancellationToken = null) =>
            await GetResponseAsync<Sortie>(Endpoint.Sortie, platform, cancellationToken);

        public async Task<List<Warframe>> GetWarframesAsync(CancellationToken? cancellationToken = null) =>
            await GetResponseAsync<List<Warframe>>(Endpoint.Warframes, null, cancellationToken);

        public async Task<List<Weapon>> GetWeaponsAsync(CancellationToken? cancellationToken = null) =>
            await GetResponseAsync<List<Weapon>>(Endpoint.Weapons, null, cancellationToken);

        public WorldState GetWorldState(Platform platform) => GetWorldStateAsync(platform).GetAwaiter().GetResult();

        public List<Arcane> GetArcanes() => GetArcanesAsync().GetAwaiter().GetResult();

        public List<Drop> GetDrops() => GetDropsAsync().GetAwaiter().GetResult();

        public List<Event> GetEvents(Platform platform) => GetEventsAsync(platform).GetAwaiter().GetResult();

        public List<Mod> GetMods() => GetModsAsync().GetAwaiter().GetResult();

        public Sortie GetSortie(Platform platform) => GetSortieAsync(platform).GetAwaiter().GetResult();

        public List<Warframe> GetWarframes() => GetWarframesAsync().GetAwaiter().GetResult();

        public List<Weapon> GetWeapons() => GetWeaponsAsync().GetAwaiter().GetResult();

        private async Task<T> GetResponseAsync<T>(string endpoint, Platform? platform,
                                                  CancellationToken? cancellationToken)
        {
            var url = Endpoint.Base + (platform ?? "") + (endpoint ?? "");
            using (var req = new HttpRequestMessage(HttpMethod.Get, url))
            using (var res = await _client.SendAsync(req, cancellationToken ?? CancellationToken.None)) {
                res.EnsureSuccessStatusCode();
                var content = await res.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(content, Converter.Settings);
            }
        }
    }
}