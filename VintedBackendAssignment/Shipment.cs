using VintedBackendAssignment.Enums;

namespace VintedBackendAssignment
{
    public class Shipment(DateTime date, Size size, Provider provider)
    {
        private readonly DateTime _date = date;
        private readonly Size _size = size;
        private readonly Provider _provider = provider;

        public DateTime Date => _date;
        public Size Size => _size;
        public Provider Provider => _provider;
    }
}
