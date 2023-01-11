namespace card_storm.Data
{
  public class CartItem
  {
    public Guid CartId { get; set; }
    public int CartKey { get; set; }
    public string? CartTitle { get; set; }
    public float CartPrice { get; set; }
    public int CartCount { get; set; }
    public string? CartImg { get; set; }
  }
}
