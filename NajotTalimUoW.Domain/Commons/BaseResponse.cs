using NajotTalimUoW.Domain.Commons;

namespace NajotTalimUoW.Domain.Common
{
    public class BaseResponse<Tsource>
    {
        public int? Code { get; set; } = 200;

        public Tsource Data { get; set; }

        public ErrorResponse Error { get; set; }

    }
}
