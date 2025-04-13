
namespace Task_20_03
{
    // Перечисление статусов заказа
    public enum OrderStatus
    {
        New,
        Processing,
        Shipped,
        Delivered,
        Cancelled
    }
 
    // Класс для представления заказа
    public class Order
    {
        public int OrderId { get; set; }
        public OrderStatus Status { get; set; }

        public Order(int orderId)
        {
            OrderId = orderId;
            Status = OrderStatus.New;
        }

        // Метод для изменения статуса заказа
        public void ChangeStatus(OrderStatus newStatus)
        {
            if (Status == OrderStatus.Delivered || Status == OrderStatus.Cancelled)
            {
                Console.WriteLine($"Невозможно изменить статус заказа {OrderId}. Заказ уже в статусе: {Status}");
                return;
            }

            Status = newStatus;
            Console.WriteLine($"Заказ {OrderId} переведён в статус: {Status}");
        }
    }

    // Пример использования
    class Program
    {
        static void Main(string[] args)
        {
            Order order1 = new Order(123);

            order1.ChangeStatus(OrderStatus.Processing);
            order1.ChangeStatus(OrderStatus.Shipped);
            order1.ChangeStatus(OrderStatus.Delivered);
            order1.ChangeStatus(OrderStatus.Cancelled); // Попытка отменить доставленный заказ

            Order order2 = new Order(456);
            order2.ChangeStatus(OrderStatus.Cancelled);
            order2.ChangeStatus(OrderStatus.Processing);  // Попытка изменить отмененный заказ

            Console.ReadKey();
        }
    }
}