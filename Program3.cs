using System;

// Базовий інтерфейс для товару з ціною
interface IProduct
{
    void SetPrice(double price);
}

// Інтерфейс для товарів зі знижками
interface IDiscountable
{
    void ApplyDiscount(String discount);
    void ApplyPromocode(String promocode);
}

// Інтерфейс для одягу (розмір, колір)
interface IClothing
{
    void SetColor(byte color);
    void SetSize(byte size);
}

// Клас Книжка: має ціну та знижки, але не має розміру/кольору
class Book : IProduct, IDiscountable
{
    public void SetPrice(double price) { /*...*/ }
    public void ApplyDiscount(string discount) { /*...*/ }
    public void ApplyPromocode(string promocode) { /*...*/ }
}

// Клас Верхній одяг: має всі властивості
class Outerwear : IProduct, IDiscountable, IClothing
{
    public void SetPrice(double price) { /*...*/ }
    public void ApplyDiscount(string discount) { /*...*/ }
    public void ApplyPromocode(string promocode) { /*...*/ }
    public void SetColor(byte color) { /*...*/ }
    public void SetSize(byte size) { /*...*/ }
}