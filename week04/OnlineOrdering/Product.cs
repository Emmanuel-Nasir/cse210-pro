using System;
class Product{
    private string username;
    private string productId;
    private double price;
    private int quantity;

    public Product(string username, string productId, double price, int quantity){
        this.username=username;
        this.productId=productId;
        this.price=price;
        this.quantity=quantity;
    }
    public double GetTotalCost(){
        return price *quantity;
    }
    public string GetName(){
        return username;
    }
    public string GetProductId(){
        return productId;
    }
}
