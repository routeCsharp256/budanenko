using OzonEdu.MerchandiseService.Domain.AggregationModels.MerchPackAggregate;

namespace OzonEdu.MerchandiseService.Models
{
    public class MerchItemModelCreate
    {
        public MerchType MerchPack { get; set; }
        public long EmployeeId { get; set; }
    }
}