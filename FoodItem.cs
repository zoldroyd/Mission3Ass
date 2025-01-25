namespace Mission3Ass;

public class FoodItem
{
    public string name { get; set; }
    public string category { get; set; }
    public int qty { get; set; }
    public DateTime expDate { get; set; }
   
    public FoodItem(string name, string category, int qty, DateTime expDate)
    {
        this.name = name;
        this.category = category;
        this.qty = qty;
        this.expDate = expDate;
    }
    
    public override string ToString()
    {
        return $"Name: {name}, Category: {category}, Quantity: {qty}, Expiration Date: {expDate.ToShortDateString()}";
    }
}
