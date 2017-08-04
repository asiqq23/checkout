using System;
using System.Text;
using System.Threading.Tasks;
using Consul;

namespace checkout
{
    public class ConsulClientWrapper
    {
        public async Task RegisterRoutes()
        {
            using (var client = GetClient())
            {
                var putPair = new KVPair("checkout")
                {
                    Value = Encoding.UTF8.GetBytes("/api/values")
                };

                await client.KV.Put(putPair);
            }
        }

        private ConsulClient GetClient()
        {
            return new ConsulClient(configuration =>
            {
                configuration.Address = new Uri("http://192.168.44.117:8500");
            });
        }
    }
}