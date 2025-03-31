class Product
{
    private string _name;
    private int _productID;
    private float _pricePerUnit;
    private int _quantity;

    public Product(string name, int productId, float pricePerUnit, int quantity)
    {
        _name = name;
        _productID = productId;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    public float GetTotalCostOfThisProduct()
    {
        return _pricePerUnit * _quantity;
    }

    public string GetProductLabel()
    {
        return $"{_name} {_productID}";
    }
}