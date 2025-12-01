using System.Collections.Generic;

class Item { /*...*/ }

// Відповідає тільки за логіку замовлення
class Order
{
    public List<Item> ItemList { get; set; }

    public void CalculateTotalSum() { /*...*/ }
    public void GetItems() { /*...*/ }
    public void GetItemCount() { /*...*/ }
    public void AddItem(Item item) { /*...*/ }
    public void DeleteItem(Item item) { /*...*/ }
}

// Відповідає за збереження даних (Persistence)
class OrderRepository
{
    public void Load(Order order) { /*...*/ }
    public void Save(Order order) { /*...*/ }
    public void Update(Order order) { /*...*/ }
    public void Delete(Order order) { /*...*/ }
}

// Відповідає за відображення (UI/Output)
class OrderPrinter
{
    public void PrintOrder(Order order) { /*...*/ }
    public void ShowOrder(Order order) { /*...*/ }
}