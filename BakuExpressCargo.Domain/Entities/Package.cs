using BakuExpressCargo.Domain.Shared;
using System.Net;

namespace BakuExpressCargo.Domain.Entities
{
    public class Package
    {
        public int Id { get; set; }

        public string SenderName { get; set; }

        public string ReceiverName { get; set; }

        public Adress SenderAdress { get; set; }

        public Adress ReceieverAdress { get; set; }

        public DeliveryStatus Status { get; private set; }

        public DateTime CreatedAt { get; private set; }

        public decimal Weight { get; set; }

        public int PackageSizeId { get; set; }
        public PackageSize PackageSize { get; set; }

        protected Package() { }
       

        public Package(string senderName, string receiverName, Adress senderAddress, Adress receiverAddress, decimal weight, PackageSize packageSize)
        {
            SenderName = senderName;
            ReceiverName = receiverName;
            SenderAdress = senderAddress;
            ReceieverAdress = receiverAddress;
            Weight = weight;
            PackageSize = packageSize;
            Status = DeliveryStatus.Pending;
            CreatedAt = DateTime.UtcNow;
        }


        public void UpdateStatus(DeliveryStatus newStatus)
        {
            Status = newStatus;

            // Eğer Delivered statüsüne geçtiyse event tetikle
            if (newStatus == DeliveryStatus.Delivered)
            {
                DomainEventDispatcher.Raise(new PackageDeliveredEvent(Id));
            }
        }


    }

    public enum DeliveryStatus
    {
        Created,
        InTransit,
        OutForDelivery,
        Pending,
        Delivered,
        DeliveryFailed,
        Returned
    }
}
