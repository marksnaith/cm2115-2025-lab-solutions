using System;

namespace Lab07.Test;

public class OrderServiceTests
{

    // the lab sheet said to update this to be [Theory] but it's kept here for completeness
    [Fact]
    public void CalculateTotalCost_ReturnsCostWithDelivery()
    {
        // arrange
        var os = new OrderService(null); // null parameter is because of update to accept shipping api

        // act
        int result = os.CalculateTotalCost(9); // changed from the lab sheet so the test still passes given the updated method

        // assert
        Assert.Equal(11, result);
    }

    [Theory]
    [InlineData(9, 11)]
    [InlineData(10, 10)]
    [InlineData(11, 11)]
    public void CalculateTotalCost_ReturnsCostWithDelivery2(int subtotal, int expected)
    {
        // arrange
        var os = new OrderService(null);

        // act
        int result = os.CalculateTotalCost(subtotal);

        // assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(10, 2, 12)]
    [InlineData(10, 1, 11)]
    [InlineData(21, 2, 21)]
    public void CalculateTotalCost_ReturnsCostWithDeliveryPostcode(int subtotal, int delivery, int expected)
    {
        // arrange
        var fake = new FakeShippingAPI();
        fake.CostToReturn = delivery;
        var os = new OrderService(fake);

        // act
        int result = os.CalculateTotalCostPostcode(subtotal, "");

        // assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void AddToCart_ItemIsAdded()
    {
        // arrange
        var os = new OrderService(null); // we don't need the address api
        os.AddToCart(new Item("", 0));

        // act
        int size = os.CartSize;

        // assert
        Assert.Equal(1, size);

    }

    [Fact]
    public void RemoveFromCart_ItemIsRemoved()
    {
        // arrange
        var os = new OrderService(null);
        var item = new Item("Book", 10);
        os.AddToCart(item);

        // act
        bool result = os.RemoveFromCart(item);
        bool result2 = os.RemoveFromCart(new Item("", 0));

        // assert
        Assert.True(result);
        Assert.False(result2);
    }

    [Fact]
    public void GetSubTotal_ReturnsSubTotal()
    {
        // arrange
        var os = new OrderService(null);
        os.AddToCart(new Item("", 10));
        os.AddToCart(new Item("", 5));

        // act
        int result = os.GetSubTotal();

        // assert
        Assert.Equal(15, result);
    }
}
