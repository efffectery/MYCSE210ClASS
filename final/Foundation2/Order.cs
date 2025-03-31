using System.Numerics;

class Order
{
    private Coustemer _coustemer; 
    private List<Product> _products;


    public Order(Coustemer coustemer, List<Product> products)
    {
        _coustemer = coustemer;
        _products = products;
    }


    public string GetShippingLabel()
    {
        return _coustemer.GetShippingLabel();
    }
    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach(Product product in _products)
        {
            packingLabel += product.GetProductLabel();
            packingLabel += "\n";
        }
        return packingLabel;
    }

    public float CalculateTotalCost()
    {
        float total = 0;
        foreach(Product product in _products)
        {
            total += product.GetTotalCostOfThisProduct();
        }
        if(_coustemer.GetIsUSA() == true)
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }

}