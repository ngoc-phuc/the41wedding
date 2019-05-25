namespace Dtos.Shared
{
    public class DictionaryDataDto
    {
        public DictionaryItemDto[] TaskStatus { get; set; }

        public DictionaryItemDto[] DeliveryIssueType { get; set; }

        public DictionaryItemDto[] DeliveryPointStatus { get; set; }

        public DictionaryItemDto[] SaleOrderStatus { get; set; }

        public DictionaryItemDto[] CustomerTypes { get; set; }

        public DictionaryItemDto[] PaymentTypes { get; set; }

        public DictionaryItemDto[] Genders { get; set; }

        public DictionaryItemDto[] ToDoDeliveryPointStatus { get; set; }

        public DictionaryItemDto[] HistoryDeliveryPointStatus { get; set; }

        public DictionaryItemDto[] HistoryTaskStatus { get; set; }

        public DictionaryItemDto[] ToDoTaskStatus { get; set; }
    }
}