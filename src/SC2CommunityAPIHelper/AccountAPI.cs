using SC2CommunityAPI.Http;
using SC2CommunityAPI.RequestArguments;
using SC2CommunityAPI.ResponseModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SC2CommunityAPI
{
    public class AccountAPI : BaseAPI
    {
        private const string URI_ACCOUNT = "https://{0}.api.blizzard.com/sc2/player/{1}";
        public AccountAPI(IOAuthTokenProvider tokenProvider) : base(tokenProvider)
        {

        }
        public AccountAPI(IWebRequestMachine requestMachine) : base(requestMachine)
        {

        }

        public async Task<APIResponse<IList<PlayerJson>>> GetPIResponseAsync(HostNameRegion region, string accountId)
        {
            string formattedUrl = string.Format(URI_ACCOUNT, GetHostNameRegionString(region), accountId);
            return await GetResponseAsync<IList<PlayerJson>>(formattedUrl);
        }
    }
}