using System;

namespace Lab07;

public class OrderService
{
    private int deliveryFee = 2;
    private IShippingAPI shippingAPI;

    private List<Item> cart = new List<Item>();

    public int CartSize { get => this.cart.Count; } // this is one way to get the cart size without exposing the cart itself publicly

    public OrderService(IShippingAPI shippingAPI)
    {
        this.shippingAPI = shippingAPI;
    }

    public int CalculateTotalCost(int subtotal)
    {
        if (subtotal < 10)
        {
            subtotal += deliveryFee;
        }
        return subtotal;
    }

    // the lab sheet had this is an update to the previous method, but making it a new one for completeness
    public int CalculateTotalCostPostcode(int subtotal, string postcode)
    {
        int shipping = this.shippingAPI.GetShipping(postcode);

        // if shipping is < 10% of subtotal, it's free
        if (shipping < 0.1 * subtotal)
        {
            return subtotal;
        }
        else
        {
            return subtotal + shipping;
        }
    }

    public void AddToCart(Item item)
    {
        cart.Add(item);
    }

    public bool RemoveFromCart(Item item)
    {
        bool result = cart.Remove(item);
        return result;
    }

    public int GetSubTotal()
    {
        int subtotal = 0;

        foreach (var item in this.cart)
        {
            subtotal += item.Price;
        }
        return subtotal;
    }
}
